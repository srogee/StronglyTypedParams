using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace StronglyTypedParams
{
    public class ParamCollection<T> : IEnumerable<T> where T : ParamRow, new()
    {
        private SoulsFormats.PARAM Data;
        private Dictionary<int, T> RowsById;
        private Dictionary<int, string> RowNamesById;
        private string ParamName;
        private SoulsFormats.PARAMDEF ParamDef;

        public ParamCollection(SoulsFormats.PARAM data, string paramName, string paramClassName)
        {
            var defPath = Path.Combine(ParamClassGenerator.ParamDefinitionsDir, paramClassName + ".xml");
            var rowNamesPath = Path.Combine(ParamClassGenerator.ParamNamesDir, paramName + ".txt");

            Data = data;
            ParamDef = SoulsFormats.PARAMDEF.XmlDeserialize(defPath);
            Data.ApplyParamdef(ParamDef);
            RowsById = new Dictionary<int, T>();
            RowNamesById = LoadRowNamesById(rowNamesPath);
            ParamName = paramName;
        }

        public byte[] ToByteArray()
        {
            Data.Rows.Sort((a, b) => a.ID.CompareTo(b.ID));
            return Data.Write();
        }

        private T GetOrLoadRow(int id)
        {
            if (!RowsById.ContainsKey(id))
            {
                LoadRow(id);
            }

            return RowsById[id];
        }

        private void LoadRow(int id)
        {
            var row = Data.Rows.Find(soulsRow => soulsRow.ID == id);
            if (row == null)
            {
                //Console.WriteLine($"Unable to find row with id {row.ID} in table {ParamName}");
                RowsById.Add(id, null);
                return;
            }
            RowNamesById.TryGetValue(row.ID, out string name);
            row.Name = name;

            AddNewRowPrivate(row);
        }

        private static Dictionary<int, string> LoadRowNamesById(string rowNamesPath)
        {
            var rowNamesById = new Dictionary<int, string>();
            try
            {
                var lines = File.ReadAllLines(rowNamesPath);
                foreach (var line in lines)
                {
                    var split = line.Split(new char[] { ' ' }, 2);
                    var id = int.Parse(split[0]);
                    var name = split[1];
                    try
                    {
                        rowNamesById.Add(id, name);
                    }
                    catch (Exception e)
                    {
                        if (!(rowNamesById.ContainsKey(id) && rowNamesById[id] == name))
                        {
                            Console.WriteLine($"Error when loading row names: {id} {name} {e}");
                        }
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine($"Error when loading row names: {e}");
            }
            return rowNamesById;
        }

        public T AddNewRow(int id, string name)
        {
            var data = new SoulsFormats.PARAM.Row(id, name, ParamDef);
            return AddNewRowPrivate(data);
        }

        private T AddNewRowPrivate(SoulsFormats.PARAM.Row data)
        {
            var rowAsT = new T();
            var rowAsParamRow = rowAsT as ParamRow;
            rowAsParamRow.Load(data);
            try
            {
                RowsById.Add(data.ID, rowAsT);
            }
            catch (Exception e)
            {
                Console.WriteLine($"Error when initializing param collection: {ParamName} {data.ID} {e}");
            }
            return rowAsT;
        }

        public T this[int id]
        {
            get
            {
                return GetOrLoadRow(id);
            }
        }

        public IEnumerator<T> GetEnumerator()
        {
            return Data.Rows.Select(row => GetOrLoadRow(row.ID)).GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}

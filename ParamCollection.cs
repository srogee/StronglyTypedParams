using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;

namespace StronglyTypedParams
{
    public class ParamCollection<T> : IEnumerable<T> where T : ParamRow, new()
    {
        private SoulsFormats.PARAM Data;
        private Dictionary<int, T> RowsById;
        private Dictionary<int, string> RowNamesById;
        private string ParamName;

        public ParamCollection(SoulsFormats.PARAM data, string paramName)
        {
            var defPath = Path.Combine(ParamClassGenerator.ParamDefinitionsDir, paramName + ".xml");
            var rowNamesPath = Path.Combine(ParamClassGenerator.ParamNamesDir, paramName + ".txt");

            Data = data;
            Data.ApplyParamdef(SoulsFormats.PARAMDEF.XmlDeserialize(defPath));
            RowsById = new Dictionary<int, T>();
            RowNamesById = LoadRowNamesById(rowNamesPath);
            ParamName = paramName;
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
                Console.WriteLine($"Unable to find row with id {row.ID} in table {ParamName}");
                RowsById.Add(id, null);
                return;
            }
            RowNamesById.TryGetValue(row.ID, out string name);

            var rowAsT = new T();
            var rowAsParamRow = rowAsT as ParamRow;
            rowAsParamRow.RowName = name;
            rowAsParamRow.Load(row);
            try
            {
                RowsById.Add(row.ID, rowAsT);
            }
            catch (Exception e)
            {
                Console.WriteLine($"Error when initializing param collection: {ParamName} {row.ID} {e}");
            }
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
                        Console.WriteLine($"Error when loading row names: {e}");
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine($"Error when loading row names: {e}");
            }
            return rowNamesById;
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
            return RowsById.Values.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return RowsById.Values.GetEnumerator();
        }
    }
}

using System;
using System.Collections.Generic;

namespace StronglyTypedParams
{
    public class ParamRow
    {
        public int Id => Data.ID;
        public string RowName => Data.Name;
        protected SoulsFormats.PARAM.Row Data;
        protected Dictionary<string, ParamCell> CellsByName;

        public ParamRow()
        {
            CellsByName = new Dictionary<string, ParamCell>();
        }

        public ParamCell this[string name]
        {
            get
            {
                CellsByName.TryGetValue(name, out ParamCell cell);
                return cell;
            }
        }

        public void Load(SoulsFormats.PARAM.Row data)
        {
            Data = data;
            foreach (var cell in Data.Cells)
            {
                var cellName = ParamClassGenerator.GetFieldName(cell.Def.DisplayName);
                if (!string.IsNullOrWhiteSpace(cellName) && !ParamClassGenerator.CellNamesToIgnore.Contains(cellName.ToLower()))
                {
                    try
                    {
                        CellsByName.Add(cellName, new ParamCell(cell));
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine($"Error when loading row: {GetType().Name} {cellName} {e}");
                    }
                }
            }
        }
    }
}

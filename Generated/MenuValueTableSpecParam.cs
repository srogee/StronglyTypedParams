
namespace StronglyTypedParams
{
    public class MenuValueTableSpecParam : ParamRow
    {
        public MenuValueTableSpecParam() : base()
        {
        }


        // Def="s32 value"
        /// <summary>
        /// Value (s32)
        /// </summary>
        /// <remarks>
        /// Value to compare
        /// </remarks>
        public int Value
        {
            get => (int)CellsByName["Value"].Value;
            set => CellsByName["Value"].Value = value;
        }


        // Def="s32 textId"
        /// <summary>
        /// Text ID (s32)
        /// </summary>
        /// <remarks>
        /// Converted text ID
        /// </remarks>
        public int TextID
        {
            get => (int)CellsByName["TextID"].Value;
            set => CellsByName["TextID"].Value = value;
        }


        // Def="s8 compareType"
        /// <summary>
        /// Compare Type (s8)
        /// </summary>
        /// <remarks>
        /// Comparison type
        /// </remarks>
        public sbyte CompareType
        {
            get => (sbyte)CellsByName["CompareType"].Value;
            set => CellsByName["CompareType"].Value = value;
        }


        // Def="dummy8 padding[3]"
        /// <summary>
        /// Padding (dummy8)
        /// </summary>
        /// <remarks>
        /// Padding
        /// </remarks>
        public object Padding
        {
            get => (object)CellsByName["Padding"].Value;
            set => CellsByName["Padding"].Value = value;
        }

    }
}

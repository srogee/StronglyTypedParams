
namespace StronglyTypedParams
{
    public class MenuPropertySpecParam : ParamRow
    {
        public MenuPropertySpecParam() : base()
        {
        }


        // Def="s32 CaptionTextID"
        /// <summary>
        /// Caption Text ID (s32)
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        public int CaptionTextID
        {
            get => (int)CellsByName["CaptionTextID"].Value;
            set => CellsByName["CaptionTextID"].Value = value;
        }


        // Def="s32 IconID"
        /// <summary>
        /// Icon ID (s32)
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        public int IconID
        {
            get => (int)CellsByName["IconID"].Value;
            set => CellsByName["IconID"].Value = value;
        }


        // Def="u32 RequiredPropertyID"
        /// <summary>
        /// Required Property ID (u32)
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        public uint RequiredPropertyID
        {
            get => (uint)CellsByName["RequiredPropertyID"].Value;
            set => CellsByName["RequiredPropertyID"].Value = value;
        }


        // Def="s8 CompareType"
        /// <summary>
        /// Compare Type (s8)
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        public sbyte CompareType
        {
            get => (sbyte)CellsByName["CompareType"].Value;
            set => CellsByName["CompareType"].Value = value;
        }


        // Def="dummy8 pad2[1]"
        /// <summary>
        /// Padding (dummy8)
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        public object Padding
        {
            get => (object)CellsByName["Padding"].Value;
            set => CellsByName["Padding"].Value = value;
        }


        // Def="u16 FormatType"
        /// <summary>
        /// Format Type (u16)
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        public ushort FormatType
        {
            get => (ushort)CellsByName["FormatType"].Value;
            set => CellsByName["FormatType"].Value = value;
        }


    }
}


namespace StronglyTypedParams
{
    public class BonfireWarpTabParam : ParamRow
    {
        public BonfireWarpTabParam() : base()
        {
        }


        // Def="u8 disableParam_NT:1"
        /// <summary>
        /// Disable Param - Network Test (u8)
        /// </summary>
        /// <remarks>
        /// Parameters marked with ○ are excluded in the NT version package.
        /// </remarks>
        public byte DisableParamNetworkTest
        {
            get => (byte)CellsByName["DisableParamNetworkTest"].Value;
            set => CellsByName["DisableParamNetworkTest"].Value = value;
        }


        // Def="dummy8 disableParamReserve1:7"
        /// <summary>
        /// Reserve for package output 1 (dummy8)
        /// </summary>
        /// <remarks>
        /// Reserve for package output 1
        /// </remarks>
        public object ReserveForPackageOutput1
        {
            get => (object)CellsByName["ReserveForPackageOutput1"].Value;
            set => CellsByName["ReserveForPackageOutput1"].Value = value;
        }


        // Def="dummy8 disableParamReserve2[3]"
        /// <summary>
        /// Reserve for package output 2 (dummy8)
        /// </summary>
        /// <remarks>
        /// Reserve for package output 2
        /// </remarks>
        public object ReserveForPackageOutput2
        {
            get => (object)CellsByName["ReserveForPackageOutput2"].Value;
            set => CellsByName["ReserveForPackageOutput2"].Value = value;
        }


        // Def="s32 textId"
        /// <summary>
        /// Text ID (s32)
        /// </summary>
        /// <remarks>
        /// Tab Display Name Text ID [MenuText]
        /// </remarks>
        public int TextID
        {
            get => (int)CellsByName["TextID"].Value;
            set => CellsByName["TextID"].Value = value;
        }


        // Def="s32 sortId"
        /// <summary>
        /// Sort ID (s32)
        /// </summary>
        /// <remarks>
        /// Tab display order sort ID. Line up from the left with aim
        /// </remarks>
        public int SortID
        {
            get => (int)CellsByName["SortID"].Value;
            set => CellsByName["SortID"].Value = value;
        }


        // Def="u16 iconId"
        /// <summary>
        /// Icon ID (u16)
        /// </summary>
        /// <remarks>
        /// Tab icon ID. Menu resource compliance
        /// </remarks>
        public ushort IconID
        {
            get => (ushort)CellsByName["IconID"].Value;
            set => CellsByName["IconID"].Value = value;
        }


        // Def="dummy8 pad[2]"
        /// <summary>
        /// pad (dummy8)
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        public object Pad
        {
            get => (object)CellsByName["Pad"].Value;
            set => CellsByName["Pad"].Value = value;
        }

    }
}

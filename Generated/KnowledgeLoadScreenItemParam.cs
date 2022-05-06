
namespace StronglyTypedParams
{
    public class KnowledgeLoadScreenItemParam : ParamRow
    {
        public KnowledgeLoadScreenItemParam() : base()
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


        // Def="u32 unlockFlagId"
        /// <summary>
        /// Unlock Flag ID (u32)
        /// </summary>
        /// <remarks>
        /// Lifting flag (default: 0). If this event flag is set, the ban will be lifted (displayed on the loading screen). If it is 0, the ban is always lifted. The invalid flag has priority
        /// </remarks>
        public uint UnlockFlagID
        {
            get => (uint)CellsByName["UnlockFlagID"].Value;
            set => CellsByName["UnlockFlagID"].Value = value;
        }


        // Def="u32 invalidFlagId"
        /// <summary>
        /// Invalid Flag ID (u32)
        /// </summary>
        /// <remarks>
        /// Invalid flag (default: 0). If this event flag is set, it will be disabled (it will not be displayed on the loading screen). If it is 0, this flag is not always set.
        /// </remarks>
        public uint InvalidFlagID
        {
            get => (uint)CellsByName["InvalidFlagID"].Value;
            set => CellsByName["InvalidFlagID"].Value = value;
        }


        // Def="s32 msgId"
        /// <summary>
        /// Message ID (s32)
        /// </summary>
        /// <remarks>
        /// Text ID (Loading Text.xlsx). Used for both loading titles and loading text
        /// </remarks>
        public int MessageID
        {
            get => (int)CellsByName["MessageID"].Value;
            set => CellsByName["MessageID"].Value = value;
        }

    }
}

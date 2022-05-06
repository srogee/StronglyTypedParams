
namespace StronglyTypedParams
{
    public class EventFlagUsageParam : ParamRow
    {
        public EventFlagUsageParam() : base()
        {
        }


        // Def="u8 usageType"
        /// <summary>
        /// Use (u8)
        /// </summary>
        /// <remarks>
        /// Use of the flag.
        /// </remarks>
        public byte Use
        {
            get => (byte)CellsByName["Use"].Value;
            set => CellsByName["Use"].Value = value;
        }


        // Def="u8 playlogCategory"
        /// <summary>
        /// Playlog category (u8)
        /// </summary>
        /// <remarks>
        /// Valid only when the usage is "ON / OFF". If this is set, the play log will be collected when the flag is turned ON.
        /// </remarks>
        public byte PlaylogCategory
        {
            get => (byte)CellsByName["PlaylogCategory"].Value;
            set => CellsByName["PlaylogCategory"].Value = value;
        }


        // Def="dummy8 padding1[2]"
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


        // Def="s32 flagNum = 1"
        /// <summary>
        /// Number of secured flags (s32)
        /// </summary>
        /// <remarks>
        /// Set to 1 for "ON / OFF". In the case of "frame allocation" and "integer", "parameter number-parameter number + number of secured flags-1" is secured.
        /// </remarks>
        public int NumberOfSecuredFlags
        {
            get => (int)CellsByName["NumberOfSecuredFlags"].Value;
            set => CellsByName["NumberOfSecuredFlags"].Value = value;
        }


    }
}

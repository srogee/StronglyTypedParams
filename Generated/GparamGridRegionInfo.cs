
namespace StronglyTypedParams
{
    public class GparamGridRegionInfo : ParamRow
    {
        public GparamGridRegionInfo() : base()
        {
        }


        // Def="u32 GparamGridRegionId"
        /// <summary>
        /// GPARAM Grid Region ID (u32)
        /// </summary>
        /// <remarks>
        /// Open local ID for MapGparam. Used for the XX part of m60_00_00XX.gparamxml
        /// </remarks>
        public uint GPARAMGridRegionID
        {
            get => (uint)CellsByName["GPARAMGridRegionID"].Value;
            set => CellsByName["GPARAMGridRegionID"].Value = value;
        }


        // Def="dummy8 Reserve[28]"
        /// <summary>
        /// Reserve (dummy8)
        /// </summary>
        /// <remarks>
        /// Reserve
        /// </remarks>
        public object Reserve
        {
            get => (object)CellsByName["Reserve"].Value;
            set => CellsByName["Reserve"].Value = value;
        }

    }
}

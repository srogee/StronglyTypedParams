
namespace StronglyTypedParams
{
    public class MapGdRegionInfo : ParamRow
    {
        public MapGdRegionInfo() : base()
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


        // Def="u32 mapRegionId"
        /// <summary>
        /// Map Region ID (u32)
        /// </summary>
        /// <remarks>
        /// Map for GD use Local identification ID [00-99: Open, 1000-9999: Legacy]
        /// </remarks>
        public uint MapRegionID
        {
            get => (uint)CellsByName["MapRegionID"].Value;
            set => CellsByName["MapRegionID"].Value = value;
        }


        // Def="dummy8 Reserve[24]"
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

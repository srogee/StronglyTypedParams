
namespace StronglyTypedParams
{
    public class MapGridCreateHeightLimitInfo : ParamRow
    {
        public MapGridCreateHeightLimitInfo() : base()
        {
        }


        // Def="f32 GridEnableCreateHeightMin = -99999"
        /// <summary>
        /// Min Height - Grid Creation (LOD2) (f32)
        /// </summary>
        /// <remarks>
        /// Minimum height that can be built in the grid [m]. (LOD 2 units)
        /// </remarks>
        public float MinHeightGridCreationLOD2
        {
            get => (float)CellsByName["MinHeightGridCreationLOD2"].Value;
            set => CellsByName["MinHeightGridCreationLOD2"].Value = value;
        }


        // Def="f32 GridEnableCreateHeightMax = 99999"
        /// <summary>
        /// Max Height - Grid Creation (LOD2) (f32)
        /// </summary>
        /// <remarks>
        /// Maximum height that can be constructed in the grid [m]. (LOD 2 units)
        /// </remarks>
        public float MaxHeightGridCreationLOD2
        {
            get => (float)CellsByName["MaxHeightGridCreationLOD2"].Value;
            set => CellsByName["MaxHeightGridCreationLOD2"].Value = value;
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

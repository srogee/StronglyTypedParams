
namespace StronglyTypedParams
{
    public class GrassLodRangeParam : ParamRow
    {
        public GrassLodRangeParam() : base()
        {
        }


        // Def="f32 LOD0_range"
        /// <summary>
        /// LOD 0 - Distance (f32)
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        public float LOD0Distance
        {
            get => (float)CellsByName["LOD0Distance"].Value;
            set => CellsByName["LOD0Distance"].Value = value;
        }


        // Def="f32 LOD0_play"
        /// <summary>
        /// LOD 0 - Play (f32)
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        public float LOD0Play
        {
            get => (float)CellsByName["LOD0Play"].Value;
            set => CellsByName["LOD0Play"].Value = value;
        }


        // Def="f32 LOD1_range"
        /// <summary>
        /// LOD 1 - Distance (f32)
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        public float LOD1Distance
        {
            get => (float)CellsByName["LOD1Distance"].Value;
            set => CellsByName["LOD1Distance"].Value = value;
        }


        // Def="f32 LOD1_play"
        /// <summary>
        /// LOD 1 - Play (f32)
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        public float LOD1Play
        {
            get => (float)CellsByName["LOD1Play"].Value;
            set => CellsByName["LOD1Play"].Value = value;
        }


        // Def="f32 LOD2_range"
        /// <summary>
        /// LOD 2 - Distance (f32)
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        public float LOD2Distance
        {
            get => (float)CellsByName["LOD2Distance"].Value;
            set => CellsByName["LOD2Distance"].Value = value;
        }


        // Def="f32 LOD2_play"
        /// <summary>
        /// LOD 2 - Play (f32)
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        public float LOD2Play
        {
            get => (float)CellsByName["LOD2Play"].Value;
            set => CellsByName["LOD2Play"].Value = value;
        }

    }
}

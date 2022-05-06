
            namespace StronglyTypedParams
            {
                public class CameraFadeParam : ParamRow
                {
                    public CameraFadeParam() : base()
                    {
                    }
            

            // Def="f32 NearMinDist"
            /// <summary>
            /// Proximity Fade: Minimum Near Distance (f32)
            /// </summary>
            /// <remarks>
            /// Near Fade minimum distance (m): Distance where α = 0
            /// </remarks>
            public float ProximityFadeMinimumNearDistance 
            {
                get => (float)CellsByName["ProximityFadeMinimumNearDistance"].Value;
                set => CellsByName["ProximityFadeMinimumNearDistance"].Value = value;
            }
            

            // Def="f32 NearMaxDist"
            /// <summary>
            /// Proximity Fade: Maximum Near Distance (f32)
            /// </summary>
            /// <remarks>
            /// Near fade maximum distance (m): Starting distance between α = Middel Alpha
            /// </remarks>
            public float ProximityFadeMaximumNearDistance 
            {
                get => (float)CellsByName["ProximityFadeMaximumNearDistance"].Value;
                set => CellsByName["ProximityFadeMaximumNearDistance"].Value = value;
            }
            

            // Def="f32 FarMinDist"
            /// <summary>
            /// Proximity Fade: Minimum Far Distance (f32)
            /// </summary>
            /// <remarks>
            /// Minimum distance of Far fade (m): End distance between α = Middle Alpha
            /// </remarks>
            public float ProximityFadeMinimumFarDistance 
            {
                get => (float)CellsByName["ProximityFadeMinimumFarDistance"].Value;
                set => CellsByName["ProximityFadeMinimumFarDistance"].Value = value;
            }
            

            // Def="f32 FarMaxDist"
            /// <summary>
            /// Proximity Fade: Maximum Far Distance (f32)
            /// </summary>
            /// <remarks>
            /// Maximum Far Fade Distance (m): Distance where α = 1
            /// </remarks>
            public float ProximityFadeMaximumFarDistance 
            {
                get => (float)CellsByName["ProximityFadeMaximumFarDistance"].Value;
                set => CellsByName["ProximityFadeMaximumFarDistance"].Value = value;
            }
            

            // Def="f32 MiddleAlpha"
            /// <summary>
            /// Proximity Fade: Alpha (f32)
            /// </summary>
            /// <remarks>
            /// Intermediate α value
            /// </remarks>
            public float ProximityFadeAlpha 
            {
                get => (float)CellsByName["ProximityFadeAlpha"].Value;
                set => CellsByName["ProximityFadeAlpha"].Value = value;
            }
            

            // Def="dummy8 dummy[12]"
            /// <summary>
            /// dummy (dummy8)
            /// </summary>
            /// <remarks>
            /// 
            /// </remarks>
            public object Dummy 
            {
                get => (object)CellsByName["Dummy"].Value;
                set => CellsByName["Dummy"].Value = value;
            }
            
                }
            }
            
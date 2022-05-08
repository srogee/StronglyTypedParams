
            namespace StronglyTypedParams
            {
                // LOAD_BALANCER_NEW_DRAW_DIST_SCALE_PARAM_ST
                public class LoadBalancerNewDrawDistScaleParam : ParamRow
                {
                    public LoadBalancerNewDrawDistScaleParam() : base()
                    {
                    }
            

            // Def="u8 DrawDist_LvBegin = 21"
            /// <summary>
            /// Draw Distance - Level Start (u8)
            /// </summary>
            /// <remarks>
            /// Drawing distance scale activation level (start)
            /// </remarks>
            public byte DrawDistanceLevelStart 
            {
                get => (byte)CellsByName["DrawDistanceLevelStart"].Value;
                set => CellsByName["DrawDistanceLevelStart"].Value = (byte)value;
            }
            

            // Def="u8 DrawDist_LvEnd = 21"
            /// <summary>
            /// Draw Distance - Level End (u8)
            /// </summary>
            /// <remarks>
            /// Drawing distance scale activation level (completed)
            /// </remarks>
            public byte DrawDistanceLevelEnd 
            {
                get => (byte)CellsByName["DrawDistanceLevelEnd"].Value;
                set => CellsByName["DrawDistanceLevelEnd"].Value = (byte)value;
            }
            

            // Def="dummy8 reserve0[2]"
            /// <summary>
            /// Reserve (dummy8)
            /// </summary>
            /// <remarks>
            /// Reserve
            /// </remarks>
            public object Reserve 
            {
                get => (object)CellsByName["Reserve"].Value;
                set => CellsByName["Reserve"].Value = (object)value;
            }
            

            // Def="f32 DrawDist_ScaleBegin = 1"
            /// <summary>
            /// Draw Distance - Scale Start (f32)
            /// </summary>
            /// <remarks>
            /// Drawing distance scale (start)
            /// </remarks>
            public float DrawDistanceScaleStart 
            {
                get => (float)CellsByName["DrawDistanceScaleStart"].Value;
                set => CellsByName["DrawDistanceScaleStart"].Value = (float)value;
            }
            

            // Def="f32 DrawDist_ScaleEnd = 1"
            /// <summary>
            /// Draw Distance - Scale End (f32)
            /// </summary>
            /// <remarks>
            /// Drawing distance scale (completed)
            /// </remarks>
            public float DrawDistanceScaleEnd 
            {
                get => (float)CellsByName["DrawDistanceScaleEnd"].Value;
                set => CellsByName["DrawDistanceScaleEnd"].Value = (float)value;
            }
            

            // Def="u8 ShadwDrawDist_LvBegin = 21"
            /// <summary>
            /// Shadow Draw Distance - Level Start (u8)
            /// </summary>
            /// <remarks>
            /// Shadow drawing distance scale activation level (start)
            /// </remarks>
            public byte ShadowDrawDistanceLevelStart 
            {
                get => (byte)CellsByName["ShadowDrawDistanceLevelStart"].Value;
                set => CellsByName["ShadowDrawDistanceLevelStart"].Value = (byte)value;
            }
            

            // Def="u8 ShadwDrawDist_LvEnd = 21"
            /// <summary>
            /// Shadow Draw Distance - Level End (u8)
            /// </summary>
            /// <remarks>
            /// Shadow drawing distance scale activation level (completed)
            /// </remarks>
            public byte ShadowDrawDistanceLevelEnd 
            {
                get => (byte)CellsByName["ShadowDrawDistanceLevelEnd"].Value;
                set => CellsByName["ShadowDrawDistanceLevelEnd"].Value = (byte)value;
            }
            


            // Def="f32 ShadwDrawDist_ScaleBegin = 1"
            /// <summary>
            /// Shadow Draw Distance - Scale Start (f32)
            /// </summary>
            /// <remarks>
            /// Shadow drawing distance scale (start)
            /// </remarks>
            public float ShadowDrawDistanceScaleStart 
            {
                get => (float)CellsByName["ShadowDrawDistanceScaleStart"].Value;
                set => CellsByName["ShadowDrawDistanceScaleStart"].Value = (float)value;
            }
            

            // Def="f32 ShadwDrawDist_ScaleEnd = 1"
            /// <summary>
            /// Shadow Draw Distance - Scale End (f32)
            /// </summary>
            /// <remarks>
            /// Shadow drawing distance scale (completed)
            /// </remarks>
            public float ShadowDrawDistanceScaleEnd 
            {
                get => (float)CellsByName["ShadowDrawDistanceScaleEnd"].Value;
                set => CellsByName["ShadowDrawDistanceScaleEnd"].Value = (float)value;
            }
            

                }
            }
            
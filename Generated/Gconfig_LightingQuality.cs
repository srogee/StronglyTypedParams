
            namespace StronglyTypedParams
            {
                public class Gconfig_LightingQuality : ParamRow
                {
                    public Gconfig_LightingQuality() : base()
                    {
                    }
            

            // Def="f32 localLightDistFactor = 0.75"
            /// <summary>
            /// Local Light Distance Factor (f32)
            /// </summary>
            /// <remarks>
            /// Local light effective distance coefficient (smaller, it disappears at a short distance)
            /// </remarks>
            public float LocalLightDistanceFactor 
            {
                get => (float)CellsByName["LocalLightDistanceFactor"].Value;
                set => CellsByName["LocalLightDistanceFactor"].Value = value;
            }
            

            // Def="u8 localLightShadowEnabled = 1"
            /// <summary>
            /// Local Light Shadow Enabled (u8)
            /// </summary>
            /// <remarks>
            /// Local light shadow enabled
            /// </remarks>
            public byte LocalLightShadowEnabled 
            {
                get => (byte)CellsByName["LocalLightShadowEnabled"].Value;
                set => CellsByName["LocalLightShadowEnabled"].Value = value;
            }
            

            // Def="u8 forwardPassLightingEnabled = 1"
            /// <summary>
            /// Forward Pass Write Enabled (u8)
            /// </summary>
            /// <remarks>
            /// Forward pass writing enabled
            /// </remarks>
            public byte ForwardPassWriteEnabled 
            {
                get => (byte)CellsByName["ForwardPassWriteEnabled"].Value;
                set => CellsByName["ForwardPassWriteEnabled"].Value = value;
            }
            

            // Def="u8 localLightShadowSpecLevelMax = 1"
            /// <summary>
            /// Local Light Shadow Specular Level (u8)
            /// </summary>
            /// <remarks>
            /// Local light shadow spec level. The larger the value, the more light sources will be shadowed.
            /// </remarks>
            public byte LocalLightShadowSpecularLevel 
            {
                get => (byte)CellsByName["LocalLightShadowSpecularLevel"].Value;
                set => CellsByName["LocalLightShadowSpecularLevel"].Value = value;
            }
            

            // Def="dummy8 dmy[1]"
            /// <summary>
            /// dmy (dummy8)
            /// </summary>
            /// <remarks>
            /// 
            /// </remarks>
            public object Dmy 
            {
                get => (object)CellsByName["Dmy"].Value;
                set => CellsByName["Dmy"].Value = value;
            }
            
                }
            }
            
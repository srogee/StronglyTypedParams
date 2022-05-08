
            namespace StronglyTypedParams
            {
                // CS_LIGHTING_QUALITY_DETAIL
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
                set => CellsByName["LocalLightDistanceFactor"].Value = (float)value;
            }
            

            // Def="u8 localLightShadowEnabled = 1"
            /// <summary>
            /// Local Light Shadow Enabled (u8)
            /// </summary>
            /// <remarks>
            /// Local light shadow enabled
            /// </remarks>
            public OnOff LocalLightShadowEnabled 
            {
                get => (OnOff)CellsByName["LocalLightShadowEnabled"].Value;
                set => CellsByName["LocalLightShadowEnabled"].Value = (byte)value;
            }
            

            // Def="u8 forwardPassLightingEnabled = 1"
            /// <summary>
            /// Forward Pass Write Enabled (u8)
            /// </summary>
            /// <remarks>
            /// Forward pass writing enabled
            /// </remarks>
            public OnOff ForwardPassWriteEnabled 
            {
                get => (OnOff)CellsByName["ForwardPassWriteEnabled"].Value;
                set => CellsByName["ForwardPassWriteEnabled"].Value = (byte)value;
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
                set => CellsByName["LocalLightShadowSpecularLevel"].Value = (byte)value;
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
                set => CellsByName["Dmy"].Value = (object)value;
            }
            
                }
            }
            
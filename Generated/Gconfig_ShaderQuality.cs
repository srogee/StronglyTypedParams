
            namespace StronglyTypedParams
            {
                // CS_SHADER_QUALITY_DETAIL
                public class Gconfig_ShaderQuality : ParamRow
                {
                    public Gconfig_ShaderQuality() : base()
                    {
                    }
            

            // Def="u8 sssEnabled = 1"
            /// <summary>
            /// SSS Enabled (u8)
            /// </summary>
            /// <remarks>
            /// SSS enabled
            /// </remarks>
            public OnOff SSSEnabled 
            {
                get => (OnOff)CellsByName["SSSEnabled"].Value;
                set => CellsByName["SSSEnabled"].Value = (byte)value;
            }
            

            // Def="u8 tessellationEnabled"
            /// <summary>
            /// Tessellation Enabled (u8)
            /// </summary>
            /// <remarks>
            /// Tessellation enabled
            /// </remarks>
            public OnOff TessellationEnabled 
            {
                get => (OnOff)CellsByName["TessellationEnabled"].Value;
                set => CellsByName["TessellationEnabled"].Value = (byte)value;
            }
            

            // Def="u8 highPrecisionNormalEnabled"
            /// <summary>
            /// High Precision Normal Enabled (u8)
            /// </summary>
            /// <remarks>
            /// High precision normal valid (setting the accuracy of the normal stored in G-Buffer)
            /// </remarks>
            public OnOff HighPrecisionNormalEnabled 
            {
                get => (OnOff)CellsByName["HighPrecisionNormalEnabled"].Value;
                set => CellsByName["HighPrecisionNormalEnabled"].Value = (byte)value;
            }
            

            // Def="fixstr dmy[1]"
            /// <summary>
            /// dmy (fixstr)
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
            
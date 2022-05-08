
            namespace StronglyTypedParams
            {
                // CS_AA_QUALITY_DETAIL
                public class Gconfig_AAQuality : ParamRow
                {
                    public Gconfig_AAQuality() : base()
                    {
                    }
            

            // Def="u8 enabled"
            /// <summary>
            /// AA Enabled (u8)
            /// </summary>
            /// <remarks>
            /// AA valid
            /// </remarks>
            public OnOff AAEnabled 
            {
                get => (OnOff)CellsByName["AAEnabled"].Value;
                set => CellsByName["AAEnabled"].Value = (byte)value;
            }
            

            // Def="u8 forceFXAA2"
            /// <summary>
            /// Force FXAA2 (u8)
            /// </summary>
            /// <remarks>
            /// Force FXAA2
            /// </remarks>
            public OnOff ForceFXAA2 
            {
                get => (OnOff)CellsByName["ForceFXAA2"].Value;
                set => CellsByName["ForceFXAA2"].Value = (byte)value;
            }
            

            // Def="dummy8 dmy[2]"
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
            

            namespace StronglyTypedParams
            {
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
            public byte AAEnabled 
            {
                get => (byte)CellsByName["AAEnabled"].Value;
                set => CellsByName["AAEnabled"].Value = value;
            }
            

            // Def="u8 forceFXAA2"
            /// <summary>
            /// Force FXAA2 (u8)
            /// </summary>
            /// <remarks>
            /// Force FXAA2
            /// </remarks>
            public byte ForceFXAA2 
            {
                get => (byte)CellsByName["ForceFXAA2"].Value;
                set => CellsByName["ForceFXAA2"].Value = value;
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
                set => CellsByName["Dmy"].Value = value;
            }
            
                }
            }
            
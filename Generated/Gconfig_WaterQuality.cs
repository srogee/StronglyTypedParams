
            namespace StronglyTypedParams
            {
                public class Gconfig_WaterQuality : ParamRow
                {
                    public Gconfig_WaterQuality() : base()
                    {
                    }
            

            // Def="u8 interactionEnabled = 1"
            /// <summary>
            /// Interaction Enabled (u8)
            /// </summary>
            /// <remarks>
            /// Interaction enabled
            /// </remarks>
            public byte InteractionEnabled 
            {
                get => (byte)CellsByName["InteractionEnabled"].Value;
                set => CellsByName["InteractionEnabled"].Value = value;
            }
            

            // Def="dummy8 dmy[3]"
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
            
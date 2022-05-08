
            namespace StronglyTypedParams
            {
                // CS_WATER_QUALITY_DETAIL
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
            public OnOff InteractionEnabled 
            {
                get => (OnOff)CellsByName["InteractionEnabled"].Value;
                set => CellsByName["InteractionEnabled"].Value = (byte)value;
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
                set => CellsByName["Dmy"].Value = (object)value;
            }
            
                }
            }
            
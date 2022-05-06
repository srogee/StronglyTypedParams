
            namespace StronglyTypedParams
            {
                public class SeActivationRangeParam : ParamRow
                {
                    public SeActivationRangeParam() : base()
                    {
                    }
            

            // Def="f32 activateRange"
            /// <summary>
            /// Activation Range (f32)
            /// </summary>
            /// <remarks>
            /// Distance to enable placement SE (m) (0 or less: always enabled)
            /// </remarks>
            public float ActivationRange 
            {
                get => (float)CellsByName["ActivationRange"].Value;
                set => CellsByName["ActivationRange"].Value = value;
            }
            
                }
            }
            
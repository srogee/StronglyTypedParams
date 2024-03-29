
            namespace StronglyTypedParams
            {
                // DIRECTION_CAMERA_PARAM_ST
                public class DirectionCameraParam : ParamRow
                {
                    public DirectionCameraParam() : base()
                    {
                    }
            

            // Def="u8 isUseOption:1"
            /// <summary>
            /// Is Use Option (u8)
            /// </summary>
            /// <remarks>
            /// Is it affected by the production camera ON / OFF option?
            /// </remarks>
            public BoolYesnoType IsUseOption 
            {
                get => (BoolYesnoType)CellsByName["IsUseOption"].Value;
                set => CellsByName["IsUseOption"].Value = (byte)value;
            }
            

            // Def="dummy8 pad2:3"
            /// <summary>
            /// pad (dummy8)
            /// </summary>
            /// <remarks>
            /// pad
            /// </remarks>
            public object Pad 
            {
                get => (object)CellsByName["Pad"].Value;
                set => CellsByName["Pad"].Value = (object)value;
            }
            

                }
            }
            
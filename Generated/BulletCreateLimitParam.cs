
            namespace StronglyTypedParams
            {
                // BULLET_CREATE_LIMIT_PARAM_ST
                public class BulletCreateLimitParam : ParamRow
                {
                    public BulletCreateLimitParam() : base()
                    {
                    }
            

            // Def="u8 limitNum_byGroup"
            /// <summary>
            /// Max Amount - By Group (u8)
            /// </summary>
            /// <remarks>
            /// Maximum number of creations in the same group
            /// </remarks>
            public byte MaxAmountByGroup 
            {
                get => (byte)CellsByName["MaxAmountByGroup"].Value;
                set => CellsByName["MaxAmountByGroup"].Value = (byte)value;
            }
            

            // Def="u8 isLimitEachOwner:1"
            /// <summary>
            /// Is Limited for each Owner (u8)
            /// </summary>
            /// <remarks>
            /// Is it restricted for each owner?
            /// </remarks>
            public OnOff IsLimitedForEachOwner 
            {
                get => (OnOff)CellsByName["IsLimitedForEachOwner"].Value;
                set => CellsByName["IsLimitedForEachOwner"].Value = (byte)value;
            }
            

            // Def="dummy8 pad2:7"
            /// <summary>
            /// Padding (dummy8)
            /// </summary>
            /// <remarks>
            /// pad2
            /// </remarks>
            public object Padding 
            {
                get => (object)CellsByName["Padding"].Value;
                set => CellsByName["Padding"].Value = (object)value;
            }
            

                }
            }
            
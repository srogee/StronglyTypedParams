
            namespace StronglyTypedParams
            {
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
                set => CellsByName["MaxAmountByGroup"].Value = value;
            }
            

            // Def="u8 isLimitEachOwner:1"
            /// <summary>
            /// Is Limited for each Owner (u8)
            /// </summary>
            /// <remarks>
            /// Is it restricted for each owner?
            /// </remarks>
            public byte IsLimitedForEachOwner 
            {
                get => (byte)CellsByName["IsLimitedForEachOwner"].Value;
                set => CellsByName["IsLimitedForEachOwner"].Value = value;
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
                set => CellsByName["Padding"].Value = value;
            }
            

                }
            }
            
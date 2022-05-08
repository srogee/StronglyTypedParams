
            namespace StronglyTypedParams
            {
                // SFX_BLOCK_RES_SHARE_PARAM
                public class SfxBlockResShareParam : ParamRow
                {
                    public SfxBlockResShareParam() : base()
                    {
                    }
            

            // Def="u32 shareBlockRsMapUidVal"
            /// <summary>
            /// Shared Resource Block - Map UID (u32)
            /// </summary>
            /// <remarks>
            /// The map number that references the resource. Set the numerical value of the map number. (m12_34_56_78 → 12345678)
            /// </remarks>
            public uint SharedResourceBlockMapUID 
            {
                get => (uint)CellsByName["SharedResourceBlockMapUID"].Value;
                set => CellsByName["SharedResourceBlockMapUID"].Value = (uint)value;
            }
            
                }
            }
            
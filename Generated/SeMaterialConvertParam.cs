
            namespace StronglyTypedParams
            {
                // SE_MATERIAL_CONVERT_PARAM_ST
                public class SeMaterialConvertParam : ParamRow
                {
                    public SeMaterialConvertParam() : base()
                    {
                    }
            

            // Def="u8 seMaterialId"
            /// <summary>
            /// SE Material ID (u8)
            /// </summary>
            /// <remarks>
            /// Conversion from SFX material ID (3 digits) to SE material ID (2 digits)
            /// </remarks>
            public MaterialSeType SEMaterialID 
            {
                get => (MaterialSeType)CellsByName["SEMaterialID"].Value;
                set => CellsByName["SEMaterialID"].Value = (byte)value;
            }
            

            // Def="dummy8 pad[3]"
            /// <summary>
            /// Padding (dummy8)
            /// </summary>
            /// <remarks>
            /// Padding
            /// </remarks>
            public object Padding 
            {
                get => (object)CellsByName["Padding"].Value;
                set => CellsByName["Padding"].Value = (object)value;
            }
            
                }
            }
            
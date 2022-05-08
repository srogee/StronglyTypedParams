
            namespace StronglyTypedParams
            {
                // MENUPROPERTY_SPEC
                public class MenuPropertySpecParam : ParamRow
                {
                    public MenuPropertySpecParam() : base()
                    {
                    }
            

            // Def="s32 CaptionTextID"
            /// <summary>
            /// Caption Text ID (s32)
            /// </summary>
            /// <remarks>
            /// 
            /// </remarks>
            public int CaptionTextID 
            {
                get => (int)CellsByName["CaptionTextID"].Value;
                set => CellsByName["CaptionTextID"].Value = (int)value;
            }
            

            // Def="s32 IconID"
            /// <summary>
            /// Icon ID (s32)
            /// </summary>
            /// <remarks>
            /// 
            /// </remarks>
            public int IconID 
            {
                get => (int)CellsByName["IconID"].Value;
                set => CellsByName["IconID"].Value = (int)value;
            }
            

            // Def="u32 RequiredPropertyID"
            /// <summary>
            /// Required Property ID (u32)
            /// </summary>
            /// <remarks>
            /// 
            /// </remarks>
            public MenuPropertyId RequiredPropertyID 
            {
                get => (MenuPropertyId)CellsByName["RequiredPropertyID"].Value;
                set => CellsByName["RequiredPropertyID"].Value = (uint)value;
            }
            

            // Def="s8 CompareType"
            /// <summary>
            /// Compare Type (s8)
            /// </summary>
            /// <remarks>
            /// 
            /// </remarks>
            public MenuPropertyCmpType CompareType 
            {
                get => (MenuPropertyCmpType)CellsByName["CompareType"].Value;
                set => CellsByName["CompareType"].Value = (sbyte)value;
            }
            

            // Def="dummy8 pad2[1]"
            /// <summary>
            /// Padding (dummy8)
            /// </summary>
            /// <remarks>
            /// 
            /// </remarks>
            public object Padding 
            {
                get => (object)CellsByName["Padding"].Value;
                set => CellsByName["Padding"].Value = (object)value;
            }
            

            // Def="u16 FormatType"
            /// <summary>
            /// Format Type (u16)
            /// </summary>
            /// <remarks>
            /// 
            /// </remarks>
            public MenuPropertyFormatType FormatType 
            {
                get => (MenuPropertyFormatType)CellsByName["FormatType"].Value;
                set => CellsByName["FormatType"].Value = (ushort)value;
            }
            

                }
            }
            
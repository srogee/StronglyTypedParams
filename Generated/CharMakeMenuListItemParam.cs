
            namespace StronglyTypedParams
            {
                // CHARMAKEMENU_LISTITEM_PARAM_ST
                public class CharMakeMenuListItemParam : ParamRow
                {
                    public CharMakeMenuListItemParam() : base()
                    {
                    }
            

            // Def="s32 value"
            /// <summary>
            /// Value (s32)
            /// </summary>
            /// <remarks>
            /// The value handled by the program. Make serial numbers within one group
            /// </remarks>
            public int Value 
            {
                get => (int)CellsByName["Value"].Value;
                set => CellsByName["Value"].Value = (int)value;
            }
            

            // Def="s32 captionId"
            /// <summary>
            /// Caption ID (s32)
            /// </summary>
            /// <remarks>
            /// ID of the text to be displayed
            /// </remarks>
            public int CaptionID 
            {
                get => (int)CellsByName["CaptionID"].Value;
                set => CellsByName["CaptionID"].Value = (int)value;
            }
            

            // Def="u8 iconId"
            /// <summary>
            /// Icon ID (u8)
            /// </summary>
            /// <remarks>
            /// ID of the icon to be displayed
            /// </remarks>
            public byte IconID 
            {
                get => (byte)CellsByName["IconID"].Value;
                set => CellsByName["IconID"].Value = (byte)value;
            }
            

            // Def="dummy8 reserved[7]"
            /// <summary>
            /// reserve (dummy8)
            /// </summary>
            /// <remarks>
            /// 
            /// </remarks>
            public object Reserve 
            {
                get => (object)CellsByName["Reserve"].Value;
                set => CellsByName["Reserve"].Value = (object)value;
            }
            
                }
            }
            

            namespace StronglyTypedParams
            {
                public class MenuPropertyLayoutParam : ParamRow
                {
                    public MenuPropertyLayoutParam() : base()
                    {
                    }
            

            // Def="fixstr LayoutPath[16]"
            /// <summary>
            /// Layout Path (fixstr)
            /// </summary>
            /// <remarks>
            /// 
            /// </remarks>
            public object LayoutPath 
            {
                get => (object)CellsByName["LayoutPath"].Value;
                set => CellsByName["LayoutPath"].Value = value;
            }
            

            // Def="s32 PropertyID"
            /// <summary>
            /// Menu Property ID (s32)
            /// </summary>
            /// <remarks>
            /// 
            /// </remarks>
            public int MenuPropertyID 
            {
                get => (int)CellsByName["MenuPropertyID"].Value;
                set => CellsByName["MenuPropertyID"].Value = value;
            }
            

            // Def="s32 CaptionTextID"
            /// <summary>
            /// Caption Text ID (s32)
            /// </summary>
            /// <remarks>
            /// If a valid text ID is set, this will be displayed in preference to the property name.
            /// </remarks>
            public int CaptionTextID 
            {
                get => (int)CellsByName["CaptionTextID"].Value;
                set => CellsByName["CaptionTextID"].Value = value;
            }
            

            // Def="s32 HelpTextID"
            /// <summary>
            /// Help Text ID (s32)
            /// </summary>
            /// <remarks>
            /// Only if this is a valid text ID will it be selectable in the field help.
            /// </remarks>
            public int HelpTextID 
            {
                get => (int)CellsByName["HelpTextID"].Value;
                set => CellsByName["HelpTextID"].Value = value;
            }
            

            // Def="dummy8 reserved[4]"
            /// <summary>
            /// reserve (dummy8)
            /// </summary>
            /// <remarks>
            /// 
            /// </remarks>
            public object Reserve 
            {
                get => (object)CellsByName["Reserve"].Value;
                set => CellsByName["Reserve"].Value = value;
            }
            
                }
            }
            
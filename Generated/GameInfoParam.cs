
            namespace StronglyTypedParams
            {
                // GAME_INFO_PARAM
                public class GameInfoParam : ParamRow
                {
                    public GameInfoParam() : base()
                    {
                    }
            

            // Def="s32 titleMsgId"
            /// <summary>
            /// Title Message ID (s32)
            /// </summary>
            /// <remarks>
            /// Title name
            /// </remarks>
            public int TitleMessageID 
            {
                get => (int)CellsByName["TitleMessageID"].Value;
                set => CellsByName["TitleMessageID"].Value = (int)value;
            }
            

            // Def="s32 contentMsgId"
            /// <summary>
            /// Content Messae ID (s32)
            /// </summary>
            /// <remarks>
            /// Contents
            /// </remarks>
            public int ContentMessaeID 
            {
                get => (int)CellsByName["ContentMessaeID"].Value;
                set => CellsByName["ContentMessaeID"].Value = (int)value;
            }
            

            // Def="s32 value"
            /// <summary>
            /// Price (s32)
            /// </summary>
            /// <remarks>
            /// price
            /// </remarks>
            public int Price 
            {
                get => (int)CellsByName["Price"].Value;
                set => CellsByName["Price"].Value = (int)value;
            }
            

            // Def="s32 sortId"
            /// <summary>
            /// Sort ID (s32)
            /// </summary>
            /// <remarks>
            /// Sort ID
            /// </remarks>
            public int SortID 
            {
                get => (int)CellsByName["SortID"].Value;
                set => CellsByName["SortID"].Value = (int)value;
            }
            

            // Def="s32 eventId"
            /// <summary>
            /// Action ID (s32)
            /// </summary>
            /// <remarks>
            /// This is the action ID that determines the sales status.
            /// </remarks>
            public int ActionID 
            {
                get => (int)CellsByName["ActionID"].Value;
                set => CellsByName["ActionID"].Value = (int)value;
            }
            

            // Def="dummy8 Pad[12]"
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
            

            namespace StronglyTypedParams
            {
                // NPC_AI_ACTION_PARAM_ST
                public class NpcAiActionParam : ParamRow
                {
                    public NpcAiActionParam() : base()
                    {
                    }
            

            // Def="u8 moveDir"
            /// <summary>
            /// Move Direction (u8)
            /// </summary>
            /// <remarks>
            /// Moving direction to enter
            /// </remarks>
            public NpcAiActionMoveDir MoveDirection 
            {
                get => (NpcAiActionMoveDir)CellsByName["MoveDirection"].Value;
                set => CellsByName["MoveDirection"].Value = (byte)value;
            }
            

            // Def="u8 key1"
            /// <summary>
            /// Key [1] (u8)
            /// </summary>
            /// <remarks>
            /// Key to enter
            /// </remarks>
            public NpcAiActionKey Key1 
            {
                get => (NpcAiActionKey)CellsByName["Key1"].Value;
                set => CellsByName["Key1"].Value = (byte)value;
            }
            

            // Def="u8 key2"
            /// <summary>
            /// Key [2] (u8)
            /// </summary>
            /// <remarks>
            /// Key to enter
            /// </remarks>
            public NpcAiActionKey Key2 
            {
                get => (NpcAiActionKey)CellsByName["Key2"].Value;
                set => CellsByName["Key2"].Value = (byte)value;
            }
            

            // Def="u8 key3"
            /// <summary>
            /// Key [3] (u8)
            /// </summary>
            /// <remarks>
            /// Key to enter
            /// </remarks>
            public NpcAiActionKey Key3 
            {
                get => (NpcAiActionKey)CellsByName["Key3"].Value;
                set => CellsByName["Key3"].Value = (byte)value;
            }
            

            // Def="u8 bMoveDirHold"
            /// <summary>
            /// Handle Move Direction as Long Press (u8)
            /// </summary>
            /// <remarks>
            /// Whether to handle the input movement direction as long press
            /// </remarks>
            public OnOff HandleMoveDirectionAsLongPress 
            {
                get => (OnOff)CellsByName["HandleMoveDirectionAsLongPress"].Value;
                set => CellsByName["HandleMoveDirectionAsLongPress"].Value = (byte)value;
            }
            

            // Def="u8 bKeyHold1"
            /// <summary>
            /// Handle Key [1] Hold as Long Press (u8)
            /// </summary>
            /// <remarks>
            /// Whether to treat the key to be entered as a long press
            /// </remarks>
            public OnOff HandleKey1HoldAsLongPress 
            {
                get => (OnOff)CellsByName["HandleKey1HoldAsLongPress"].Value;
                set => CellsByName["HandleKey1HoldAsLongPress"].Value = (byte)value;
            }
            

            // Def="u8 bKeyHold2"
            /// <summary>
            /// Handle Key [2] Hold as Long Press (u8)
            /// </summary>
            /// <remarks>
            /// Whether to treat the key to be entered as a long press
            /// </remarks>
            public OnOff HandleKey2HoldAsLongPress 
            {
                get => (OnOff)CellsByName["HandleKey2HoldAsLongPress"].Value;
                set => CellsByName["HandleKey2HoldAsLongPress"].Value = (byte)value;
            }
            

            // Def="u8 bKeyHold3"
            /// <summary>
            /// Handle Key [3] Hold as Long Press (u8)
            /// </summary>
            /// <remarks>
            /// Whether to treat the key to be entered as a long press
            /// </remarks>
            public OnOff HandleKey3HoldAsLongPress 
            {
                get => (OnOff)CellsByName["HandleKey3HoldAsLongPress"].Value;
                set => CellsByName["HandleKey3HoldAsLongPress"].Value = (byte)value;
            }
            

            // Def="s32 gestureId"
            /// <summary>
            /// Gesture ID (s32)
            /// </summary>
            /// <remarks>
            /// Gesture ID
            /// </remarks>
            public int GestureID 
            {
                get => (int)CellsByName["GestureID"].Value;
                set => CellsByName["GestureID"].Value = (int)value;
            }
            

            // Def="u8 bLifeEndSuccess"
            /// <summary>
            /// AI Goal Waits For Duration End (u8)
            /// </summary>
            /// <remarks>
            /// If this is ON, the AI goal will not be successful until the end of its life
            /// </remarks>
            public OnOff AIGoalWaitsForDurationEnd 
            {
                get => (OnOff)CellsByName["AIGoalWaitsForDurationEnd"].Value;
                set => CellsByName["AIGoalWaitsForDurationEnd"].Value = (byte)value;
            }
            

            // Def="dummy8 pad1[3]"
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
            
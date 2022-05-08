
            namespace StronglyTypedParams
            {
                // KEY_ASSIGN_PARAM_ST
                public class KeyAssignParam : ParamRow
                {
                    public KeyAssignParam() : base()
                    {
                    }
            

            // Def="s32 padKeyId = -1"
            /// <summary>
            /// Pad Key ID (s32)
            /// </summary>
            /// <remarks>
            /// Pad (physical key)
            /// </remarks>
            public CsPadKey PadKeyID 
            {
                get => (CsPadKey)CellsByName["PadKeyID"].Value;
                set => CellsByName["PadKeyID"].Value = (int)value;
            }
            

            // Def="s32 keyboardModifyKey"
            /// <summary>
            /// Keyboard Modify Key (s32)
            /// </summary>
            /// <remarks>
            /// Keyboard modifier keys
            /// </remarks>
            public CsModifierKey KeyboardModifyKey 
            {
                get => (CsModifierKey)CellsByName["KeyboardModifyKey"].Value;
                set => CellsByName["KeyboardModifyKey"].Value = (int)value;
            }
            

            // Def="s32 keyboardKeyId = -1"
            /// <summary>
            /// Keyboard Key ID (s32)
            /// </summary>
            /// <remarks>
            /// Keyboard (physical keys)
            /// </remarks>
            public CsKeyboardKey KeyboardKeyID 
            {
                get => (CsKeyboardKey)CellsByName["KeyboardKeyID"].Value;
                set => CellsByName["KeyboardKeyID"].Value = (int)value;
            }
            

            // Def="s32 mouseModifyKey"
            /// <summary>
            /// Mouse Modify Key (s32)
            /// </summary>
            /// <remarks>
            /// Mouse modifier key
            /// </remarks>
            public CsModifierKey MouseModifyKey 
            {
                get => (CsModifierKey)CellsByName["MouseModifyKey"].Value;
                set => CellsByName["MouseModifyKey"].Value = (int)value;
            }
            

            // Def="s32 mouseKeyId"
            /// <summary>
            /// Mouse Key ID (s32)
            /// </summary>
            /// <remarks>
            /// Mouse (physical key)
            /// </remarks>
            public CsMouseKey MouseKeyID 
            {
                get => (CsMouseKey)CellsByName["MouseKeyID"].Value;
                set => CellsByName["MouseKeyID"].Value = (int)value;
            }
            

                }
            }
            
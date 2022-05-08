
            namespace StronglyTypedParams
            {
                // FE_TEXT_EFFECT_PARAM_ST
                public class FeTextEffectParam : ParamRow
                {
                    public FeTextEffectParam() : base()
                    {
                    }
            

            // Def="s16 resId"
            /// <summary>
            /// Resource ID (s16)
            /// </summary>
            /// <remarks>
            /// Instance name of the menu resource. ID of TextEffect_X
            /// </remarks>
            public short ResourceID 
            {
                get => (short)CellsByName["ResourceID"].Value;
                set => CellsByName["ResourceID"].Value = (short)value;
            }
            

            // Def="dummy8 pad1[2]"
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
            

            // Def="s32 textId = -1"
            /// <summary>
            /// Text ID (s32)
            /// </summary>
            /// <remarks>
            /// Text ID to display (-1: No text). MenuText
            /// </remarks>
            public int TextID 
            {
                get => (int)CellsByName["TextID"].Value;
                set => CellsByName["TextID"].Value = (int)value;
            }
            

            // Def="s32 seId = -1"
            /// <summary>
            /// SE ID (s32)
            /// </summary>
            /// <remarks>
            /// Voice ID to play (-1: No SE)
            /// </remarks>
            public int SEID 
            {
                get => (int)CellsByName["SEID"].Value;
                set => CellsByName["SEID"].Value = (int)value;
            }
            

            // Def="u8 canMixMapName:1"
            /// <summary>
            /// Display Simultaneously with Map Name (u8)
            /// </summary>
            /// <remarks>
            /// Whether to display at the same time as the map name
            /// </remarks>
            public BoolCirclecrossType DisplaySimultaneouslyWithMapName 
            {
                get => (BoolCirclecrossType)CellsByName["DisplaySimultaneouslyWithMapName"].Value;
                set => CellsByName["DisplaySimultaneouslyWithMapName"].Value = (byte)value;
            }
            


                }
            }
            
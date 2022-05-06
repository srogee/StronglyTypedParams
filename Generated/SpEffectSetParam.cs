
            namespace StronglyTypedParams
            {
                public class SpEffectSetParam : ParamRow
                {
                    public SpEffectSetParam() : base()
                    {
                    }
            

            // Def="s32 spEffectId1 = -1"
            /// <summary>
            /// SpEffect ID [1] (s32)
            /// </summary>
            /// <remarks>
            /// Special effect ID1
            /// </remarks>
            public int SpEffectID1 
            {
                get => (int)CellsByName["SpEffectID1"].Value;
                set => CellsByName["SpEffectID1"].Value = value;
            }
            

            // Def="s32 spEffectId2 = -1"
            /// <summary>
            /// SpEffect ID [2] (s32)
            /// </summary>
            /// <remarks>
            /// Special effect ID2
            /// </remarks>
            public int SpEffectID2 
            {
                get => (int)CellsByName["SpEffectID2"].Value;
                set => CellsByName["SpEffectID2"].Value = value;
            }
            

            // Def="s32 spEffectId3 = -1"
            /// <summary>
            /// SpEffect ID [3] (s32)
            /// </summary>
            /// <remarks>
            /// Special effect ID3
            /// </remarks>
            public int SpEffectID3 
            {
                get => (int)CellsByName["SpEffectID3"].Value;
                set => CellsByName["SpEffectID3"].Value = value;
            }
            

            // Def="s32 spEffectId4 = -1"
            /// <summary>
            /// SpEffect ID [4] (s32)
            /// </summary>
            /// <remarks>
            /// Special effect ID4
            /// </remarks>
            public int SpEffectID4 
            {
                get => (int)CellsByName["SpEffectID4"].Value;
                set => CellsByName["SpEffectID4"].Value = value;
            }
            
                }
            }
            

            namespace StronglyTypedParams
            {
                public class CommonSystemParam : ParamRow
                {
                    public CommonSystemParam() : base()
                    {
                    }
            

            // Def="u32 mapSaveMapNameIdOnGameStart"
            /// <summary>
            /// Save Data - Game Start: Map Name (u32)
            /// </summary>
            /// <remarks>
            /// At the start of the game Map name ID_for save data (SEQ15052)
            /// </remarks>
            public uint SaveDataGameStartMapName 
            {
                get => (uint)CellsByName["SaveDataGameStartMapName"].Value;
                set => CellsByName["SaveDataGameStartMapName"].Value = value;
            }
            

            // Def="dummy8 reserve0[60]"
            /// <summary>
            /// Reserve (dummy8)
            /// </summary>
            /// <remarks>
            /// Reserve
            /// </remarks>
            public object Reserve 
            {
                get => (object)CellsByName["Reserve"].Value;
                set => CellsByName["Reserve"].Value = value;
            }
            
                }
            }
            
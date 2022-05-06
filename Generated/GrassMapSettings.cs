
            namespace StronglyTypedParams
            {
                public class GrassMapSettings : ParamRow
                {
                    public GrassMapSettings() : base()
                    {
                    }
            

            // Def="u32 grassType0"
            /// <summary>
            /// Grass Type [0] (u32)
            /// </summary>
            /// <remarks>
            /// 
            /// </remarks>
            public uint GrassType0 
            {
                get => (uint)CellsByName["GrassType0"].Value;
                set => CellsByName["GrassType0"].Value = value;
            }
            

            // Def="u32 grassType1"
            /// <summary>
            /// Grass Type [1] (u32)
            /// </summary>
            /// <remarks>
            /// 
            /// </remarks>
            public uint GrassType1 
            {
                get => (uint)CellsByName["GrassType1"].Value;
                set => CellsByName["GrassType1"].Value = value;
            }
            

            // Def="u32 grassType2"
            /// <summary>
            /// Grass Type [2] (u32)
            /// </summary>
            /// <remarks>
            /// 
            /// </remarks>
            public uint GrassType2 
            {
                get => (uint)CellsByName["GrassType2"].Value;
                set => CellsByName["GrassType2"].Value = value;
            }
            
                }
            }
            
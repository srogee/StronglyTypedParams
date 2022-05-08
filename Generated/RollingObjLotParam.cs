
            namespace StronglyTypedParams
            {
                // ROLLING_OBJ_LOT_PARAM_ST
                public class RollingObjLotParam : ParamRow
                {
                    public RollingObjLotParam() : base()
                    {
                    }
            

            // Def="u8 disableParam_NT:1"
            /// <summary>
            /// Disable Param - Network Test (u8)
            /// </summary>
            /// <remarks>
            /// Parameters marked with ○ are excluded in the NT version package.
            /// </remarks>
            public BoolCirclecrossType DisableParamNetworkTest 
            {
                get => (BoolCirclecrossType)CellsByName["DisableParamNetworkTest"].Value;
                set => CellsByName["DisableParamNetworkTest"].Value = (byte)value;
            }
            

            // Def="dummy8 disableParamReserve1:7"
            /// <summary>
            /// Reserve for package output 1 (dummy8)
            /// </summary>
            /// <remarks>
            /// Reserve for package output 1
            /// </remarks>
            public object ReserveForPackageOutput1 
            {
                get => (object)CellsByName["ReserveForPackageOutput1"].Value;
                set => CellsByName["ReserveForPackageOutput1"].Value = (object)value;
            }
            

            // Def="dummy8 disableParamReserve2[3]"
            /// <summary>
            /// Reserve for package output 2 (dummy8)
            /// </summary>
            /// <remarks>
            /// Reserve for package output 2
            /// </remarks>
            public object ReserveForPackageOutput2 
            {
                get => (object)CellsByName["ReserveForPackageOutput2"].Value;
                set => CellsByName["ReserveForPackageOutput2"].Value = (object)value;
            }
            

            // Def="s32 AssetId_0 = -1"
            /// <summary>
            /// Asset ID [0] (s32)
            /// </summary>
            /// <remarks>
            /// AssetId_0 (-1: Ignore)
            /// </remarks>
            public int AssetID0 
            {
                get => (int)CellsByName["AssetID0"].Value;
                set => CellsByName["AssetID0"].Value = (int)value;
            }
            

            // Def="s32 AssetId_1 = -1"
            /// <summary>
            /// Asset ID [1] (s32)
            /// </summary>
            /// <remarks>
            /// AssetId_1 (-1: Ignore)
            /// </remarks>
            public int AssetID1 
            {
                get => (int)CellsByName["AssetID1"].Value;
                set => CellsByName["AssetID1"].Value = (int)value;
            }
            

            // Def="s32 AssetId_2 = -1"
            /// <summary>
            /// Asset ID [2] (s32)
            /// </summary>
            /// <remarks>
            /// AssetId_2 (-1: Ignore)
            /// </remarks>
            public int AssetID2 
            {
                get => (int)CellsByName["AssetID2"].Value;
                set => CellsByName["AssetID2"].Value = (int)value;
            }
            

            // Def="s32 AssetId_3 = -1"
            /// <summary>
            /// Asset ID [3] (s32)
            /// </summary>
            /// <remarks>
            /// AssetId_3 (-1: Ignore)
            /// </remarks>
            public int AssetID3 
            {
                get => (int)CellsByName["AssetID3"].Value;
                set => CellsByName["AssetID3"].Value = (int)value;
            }
            

            // Def="s32 AssetId_4 = -1"
            /// <summary>
            /// Asset ID [4] (s32)
            /// </summary>
            /// <remarks>
            /// AssetId_4 (-1: Ignore)
            /// </remarks>
            public int AssetID4 
            {
                get => (int)CellsByName["AssetID4"].Value;
                set => CellsByName["AssetID4"].Value = (int)value;
            }
            

            // Def="s32 AssetId_5 = -1"
            /// <summary>
            /// Asset ID [5] (s32)
            /// </summary>
            /// <remarks>
            /// AssetId_5 (-1: Ignore)
            /// </remarks>
            public int AssetID5 
            {
                get => (int)CellsByName["AssetID5"].Value;
                set => CellsByName["AssetID5"].Value = (int)value;
            }
            

            // Def="s32 AssetId_6 = -1"
            /// <summary>
            /// Asset ID [6] (s32)
            /// </summary>
            /// <remarks>
            /// AssetId_6 (-1: Ignore)
            /// </remarks>
            public int AssetID6 
            {
                get => (int)CellsByName["AssetID6"].Value;
                set => CellsByName["AssetID6"].Value = (int)value;
            }
            

            // Def="s32 AssetId_7 = -1"
            /// <summary>
            /// Asset ID [7] (s32)
            /// </summary>
            /// <remarks>
            /// AssetId_7 (-1: Ignore)
            /// </remarks>
            public int AssetID7 
            {
                get => (int)CellsByName["AssetID7"].Value;
                set => CellsByName["AssetID7"].Value = (int)value;
            }
            

            // Def="u8 CreateWeight_0"
            /// <summary>
            /// Appearance Weight [0] (u8)
            /// </summary>
            /// <remarks>
            /// Appearance ratio point (weight) _0: 0 is ignored
            /// </remarks>
            public byte AppearanceWeight0 
            {
                get => (byte)CellsByName["AppearanceWeight0"].Value;
                set => CellsByName["AppearanceWeight0"].Value = (byte)value;
            }
            

            // Def="u8 CreateWeight_1"
            /// <summary>
            /// Appearance Weight [1] (u8)
            /// </summary>
            /// <remarks>
            /// Appearance ratio point (weight) _1
            /// </remarks>
            public byte AppearanceWeight1 
            {
                get => (byte)CellsByName["AppearanceWeight1"].Value;
                set => CellsByName["AppearanceWeight1"].Value = (byte)value;
            }
            

            // Def="u8 CreateWeight_2"
            /// <summary>
            /// Appearance Weight [2] (u8)
            /// </summary>
            /// <remarks>
            /// Appearance ratio point (weight) _2
            /// </remarks>
            public byte AppearanceWeight2 
            {
                get => (byte)CellsByName["AppearanceWeight2"].Value;
                set => CellsByName["AppearanceWeight2"].Value = (byte)value;
            }
            

            // Def="u8 CreateWeight_3"
            /// <summary>
            /// Appearance Weight [3] (u8)
            /// </summary>
            /// <remarks>
            /// Appearance ratio point (weight) _3
            /// </remarks>
            public byte AppearanceWeight3 
            {
                get => (byte)CellsByName["AppearanceWeight3"].Value;
                set => CellsByName["AppearanceWeight3"].Value = (byte)value;
            }
            

            // Def="u8 CreateWeight_4"
            /// <summary>
            /// Appearance Weight [4] (u8)
            /// </summary>
            /// <remarks>
            /// Appearance ratio point (weight) _4
            /// </remarks>
            public byte AppearanceWeight4 
            {
                get => (byte)CellsByName["AppearanceWeight4"].Value;
                set => CellsByName["AppearanceWeight4"].Value = (byte)value;
            }
            

            // Def="u8 CreateWeight_5"
            /// <summary>
            /// Appearance Weight [5] (u8)
            /// </summary>
            /// <remarks>
            /// Appearance ratio point (weight) _5
            /// </remarks>
            public byte AppearanceWeight5 
            {
                get => (byte)CellsByName["AppearanceWeight5"].Value;
                set => CellsByName["AppearanceWeight5"].Value = (byte)value;
            }
            

            // Def="u8 CreateWeight_6"
            /// <summary>
            /// Appearance Weight [6] (u8)
            /// </summary>
            /// <remarks>
            /// Appearance ratio point (weight) _6
            /// </remarks>
            public byte AppearanceWeight6 
            {
                get => (byte)CellsByName["AppearanceWeight6"].Value;
                set => CellsByName["AppearanceWeight6"].Value = (byte)value;
            }
            

            // Def="u8 CreateWeight_7"
            /// <summary>
            /// Appearance Weight [7] (u8)
            /// </summary>
            /// <remarks>
            /// Appearance ratio point (weight) _7
            /// </remarks>
            public byte AppearanceWeight7 
            {
                get => (byte)CellsByName["AppearanceWeight7"].Value;
                set => CellsByName["AppearanceWeight7"].Value = (byte)value;
            }
            

            // Def="dummy8 Reserve_0[20]"
            /// <summary>
            /// Reserve (dummy8)
            /// </summary>
            /// <remarks>
            /// Reserve
            /// </remarks>
            public object Reserve 
            {
                get => (object)CellsByName["Reserve"].Value;
                set => CellsByName["Reserve"].Value = (object)value;
            }
            
                }
            }
            

            namespace StronglyTypedParams
            {
                public class GameAreaParam : ParamRow
                {
                    public GameAreaParam() : base()
                    {
                    }
            

            // Def="u8 disableParam_NT:1"
            /// <summary>
            /// Disable Param - Network Test (u8)
            /// </summary>
            /// <remarks>
            /// Parameters marked with ○ are excluded in the NT version package.
            /// </remarks>
            public byte DisableParamNetworkTest 
            {
                get => (byte)CellsByName["DisableParamNetworkTest"].Value;
                set => CellsByName["DisableParamNetworkTest"].Value = value;
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
                set => CellsByName["ReserveForPackageOutput1"].Value = value;
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
                set => CellsByName["ReserveForPackageOutput2"].Value = value;
            }
            

            // Def="u32 bonusSoul_single"
            /// <summary>
            /// Bonus Runes - Singleplayer (u32)
            /// </summary>
            /// <remarks>
            /// Amount of soul that can be obtained when defeating an area boss (in single play)
            /// </remarks>
            public uint BonusRunesSingleplayer 
            {
                get => (uint)CellsByName["BonusRunesSingleplayer"].Value;
                set => CellsByName["BonusRunesSingleplayer"].Value = value;
            }
            

            // Def="u32 bonusSoul_multi"
            /// <summary>
            /// Bonus Runes - Multiplayer (u32)
            /// </summary>
            /// <remarks>
            /// Amount of soul that can be obtained when defeating an area boss (during multiplayer)
            /// </remarks>
            public uint BonusRunesMultiplayer 
            {
                get => (uint)CellsByName["BonusRunesMultiplayer"].Value;
                set => CellsByName["BonusRunesMultiplayer"].Value = value;
            }
            

            // Def="u32 humanityPointCountFlagIdTop"
            /// <summary>
            /// Humanity Point Count Flag ID (u32)
            /// </summary>
            /// <remarks>
            /// First flag ID for managing humanity drop points (using 20 Bit)
            /// </remarks>
            public uint HumanityPointCountFlagID 
            {
                get => (uint)CellsByName["HumanityPointCountFlagID"].Value;
                set => CellsByName["HumanityPointCountFlagID"].Value = value;
            }
            

            // Def="u16 humanityDropPoint1"
            /// <summary>
            /// Humanity Drop Threshold [1] (u16)
            /// </summary>
            /// <remarks>
            /// Threshold for acquiring humanity 1
            /// </remarks>
            public ushort HumanityDropThreshold1 
            {
                get => (ushort)CellsByName["HumanityDropThreshold1"].Value;
                set => CellsByName["HumanityDropThreshold1"].Value = value;
            }
            

            // Def="u16 humanityDropPoint2"
            /// <summary>
            /// Humanity Drop Threshold [2] (u16)
            /// </summary>
            /// <remarks>
            /// Threshold 2 for acquiring humanity
            /// </remarks>
            public ushort HumanityDropThreshold2 
            {
                get => (ushort)CellsByName["HumanityDropThreshold2"].Value;
                set => CellsByName["HumanityDropThreshold2"].Value = value;
            }
            

            // Def="u16 humanityDropPoint3"
            /// <summary>
            /// Humanity Drop Threshold [3] (u16)
            /// </summary>
            /// <remarks>
            /// Threshold 3 for acquiring humanity
            /// </remarks>
            public ushort HumanityDropThreshold3 
            {
                get => (ushort)CellsByName["HumanityDropThreshold3"].Value;
                set => CellsByName["HumanityDropThreshold3"].Value = value;
            }
            

            // Def="u16 humanityDropPoint4"
            /// <summary>
            /// Humanity Drop Threshold [4] (u16)
            /// </summary>
            /// <remarks>
            /// Threshold 4 for acquiring humanity
            /// </remarks>
            public ushort HumanityDropThreshold4 
            {
                get => (ushort)CellsByName["HumanityDropThreshold4"].Value;
                set => CellsByName["HumanityDropThreshold4"].Value = value;
            }
            

            // Def="u16 humanityDropPoint5"
            /// <summary>
            /// Humanity Drop Threshold [5] (u16)
            /// </summary>
            /// <remarks>
            /// Threshold 5 for acquiring humanity
            /// </remarks>
            public ushort HumanityDropThreshold5 
            {
                get => (ushort)CellsByName["HumanityDropThreshold5"].Value;
                set => CellsByName["HumanityDropThreshold5"].Value = value;
            }
            

            // Def="u16 humanityDropPoint6"
            /// <summary>
            /// Humanity Drop Threshold [6] (u16)
            /// </summary>
            /// <remarks>
            /// Threshold 6 for acquiring humanity
            /// </remarks>
            public ushort HumanityDropThreshold6 
            {
                get => (ushort)CellsByName["HumanityDropThreshold6"].Value;
                set => CellsByName["HumanityDropThreshold6"].Value = value;
            }
            

            // Def="u16 humanityDropPoint7"
            /// <summary>
            /// Humanity Drop Threshold [7] (u16)
            /// </summary>
            /// <remarks>
            /// Threshold for acquiring humanity 7
            /// </remarks>
            public ushort HumanityDropThreshold7 
            {
                get => (ushort)CellsByName["HumanityDropThreshold7"].Value;
                set => CellsByName["HumanityDropThreshold7"].Value = value;
            }
            

            // Def="u16 humanityDropPoint8"
            /// <summary>
            /// Humanity Drop Threshold [8] (u16)
            /// </summary>
            /// <remarks>
            /// Threshold for acquiring humanity 8
            /// </remarks>
            public ushort HumanityDropThreshold8 
            {
                get => (ushort)CellsByName["HumanityDropThreshold8"].Value;
                set => CellsByName["HumanityDropThreshold8"].Value = value;
            }
            

            // Def="u16 humanityDropPoint9"
            /// <summary>
            /// Humanity Drop Threshold [9] (u16)
            /// </summary>
            /// <remarks>
            /// Threshold for acquiring humanity 9
            /// </remarks>
            public ushort HumanityDropThreshold9 
            {
                get => (ushort)CellsByName["HumanityDropThreshold9"].Value;
                set => CellsByName["HumanityDropThreshold9"].Value = value;
            }
            

            // Def="u16 humanityDropPoint10"
            /// <summary>
            /// Humanity Drop Threshold [10] (u16)
            /// </summary>
            /// <remarks>
            /// Threshold 10 for acquiring humanity
            /// </remarks>
            public ushort HumanityDropThreshold10 
            {
                get => (ushort)CellsByName["HumanityDropThreshold10"].Value;
                set => CellsByName["HumanityDropThreshold10"].Value = value;
            }
            

            // Def="u32 soloBreakInPoint_Min"
            /// <summary>
            /// Min Invasion Spawns added after Boss Defeat (u32)
            /// </summary>
            /// <remarks>
            /// The minimum value of solo intrusion points to be added when defeating an area boss.
            /// </remarks>
            public uint MinInvasionSpawnsAddedAfterBossDefeat 
            {
                get => (uint)CellsByName["MinInvasionSpawnsAddedAfterBossDefeat"].Value;
                set => CellsByName["MinInvasionSpawnsAddedAfterBossDefeat"].Value = value;
            }
            

            // Def="u32 soloBreakInPoint_Max = 10000"
            /// <summary>
            /// Max Invasion Spawns added after Boss Defeat (u32)
            /// </summary>
            /// <remarks>
            /// The maximum value of solo intrusion points to be added when defeating an area boss.
            /// </remarks>
            public uint MaxInvasionSpawnsAddedAfterBossDefeat 
            {
                get => (uint)CellsByName["MaxInvasionSpawnsAddedAfterBossDefeat"].Value;
                set => CellsByName["MaxInvasionSpawnsAddedAfterBossDefeat"].Value = value;
            }
            

            // Def="u32 defeatBossFlagId_forSignAimList"
            /// <summary>
            /// Boss Defeat Flag - For Purpose List (u32)
            /// </summary>
            /// <remarks>
            /// If this flag is ON, it will not be displayed in the list of purpose settings at the time of hosting. If it is 0, it is always displayed.
            /// </remarks>
            public uint BossDefeatFlagForPurposeList 
            {
                get => (uint)CellsByName["BossDefeatFlagForPurposeList"].Value;
                set => CellsByName["BossDefeatFlagForPurposeList"].Value = value;
            }
            

            // Def="u32 displayAimFlagId"
            /// <summary>
            /// Display Purpose Flag ID (u32)
            /// </summary>
            /// <remarks>
            /// 
            /// </remarks>
            public uint DisplayPurposeFlagID 
            {
                get => (uint)CellsByName["DisplayPurposeFlagID"].Value;
                set => CellsByName["DisplayPurposeFlagID"].Value = value;
            }
            

            // Def="u32 foundBossFlagId"
            /// <summary>
            /// Discovered Boss Flag ID (u32)
            /// </summary>
            /// <remarks>
            /// 
            /// </remarks>
            public uint DiscoveredBossFlagID 
            {
                get => (uint)CellsByName["DiscoveredBossFlagID"].Value;
                set => CellsByName["DiscoveredBossFlagID"].Value = value;
            }
            

            // Def="s32 foundBossTextId = -1"
            /// <summary>
            /// Discovered Boss Text ID (s32)
            /// </summary>
            /// <remarks>
            /// 
            /// </remarks>
            public int DiscoveredBossTextID 
            {
                get => (int)CellsByName["DiscoveredBossTextID"].Value;
                set => CellsByName["DiscoveredBossTextID"].Value = value;
            }
            

            // Def="s32 notFindBossTextId = -1"
            /// <summary>
            /// Undiscovered Boss Text ID (s32)
            /// </summary>
            /// <remarks>
            /// 
            /// </remarks>
            public int UndiscoveredBossTextID 
            {
                get => (int)CellsByName["UndiscoveredBossTextID"].Value;
                set => CellsByName["UndiscoveredBossTextID"].Value = value;
            }
            

            // Def="u32 bossChallengeFlagId"
            /// <summary>
            /// Boss Challenge Flag ID (u32)
            /// </summary>
            /// <remarks>
            /// Boss challengeable flag ID. When selecting the target boss in the intrusion position search when "Is the intrusion point automatically generated?" In the multiplayer area para is ○, the boss with this flag ON is targeted. If it is 0, it is always the target.
            /// </remarks>
            public uint BossChallengeFlagID 
            {
                get => (uint)CellsByName["BossChallengeFlagID"].Value;
                set => CellsByName["BossChallengeFlagID"].Value = value;
            }
            

            // Def="u32 defeatBossFlagId"
            /// <summary>
            /// Boss Defeat Flag ID (u32)
            /// </summary>
            /// <remarks>
            /// Boss defeat flag ID. When selecting the target boss in the intrusion position search when "Is the intrusion point automatically generated?" In the multiplayer area para is ○, the boss with this flag OFF is targeted.
            /// </remarks>
            public uint BossDefeatFlagID 
            {
                get => (uint)CellsByName["BossDefeatFlagID"].Value;
                set => CellsByName["BossDefeatFlagID"].Value = value;
            }
            

            // Def="f32 bossPosX"
            /// <summary>
            /// Boss Coordinate: X (f32)
            /// </summary>
            /// <remarks>
            /// Boss position_X coordinates (relative coordinates from the specified map). It is used to check the distance between the host and the boss in the intrusion position search when "Is the intrusion point automatically generated?" In the multiplayer area para.
            /// </remarks>
            public float BossCoordinateX 
            {
                get => (float)CellsByName["BossCoordinateX"].Value;
                set => CellsByName["BossCoordinateX"].Value = value;
            }
            

            // Def="f32 bossPosY"
            /// <summary>
            /// Boss Coordinate: Y (f32)
            /// </summary>
            /// <remarks>
            /// Boss position_Y coordinates (relative coordinates from the specified map). It is used to check the distance between the host and the boss in the intrusion position search when "Is the intrusion point automatically generated?" In the multiplayer area para.
            /// </remarks>
            public float BossCoordinateY 
            {
                get => (float)CellsByName["BossCoordinateY"].Value;
                set => CellsByName["BossCoordinateY"].Value = value;
            }
            

            // Def="f32 bossPosZ"
            /// <summary>
            /// Boss Coordinate: Z (f32)
            /// </summary>
            /// <remarks>
            /// Boss position_Z coordinates (relative coordinates from the specified map). It is used to check the distance between the host and the boss in the intrusion position search when "Is the intrusion point automatically generated?" In the multiplayer area para.
            /// </remarks>
            public float BossCoordinateZ 
            {
                get => (float)CellsByName["BossCoordinateZ"].Value;
                set => CellsByName["BossCoordinateZ"].Value = value;
            }
            

            // Def="u8 bossMapAreaNo"
            /// <summary>
            /// Map Area (u8)
            /// </summary>
            /// <remarks>
            /// Boss position_area number (mXX_00_00_00). It is used to check the distance between the host and the boss in the intrusion position search when "Is the intrusion point automatically generated?" In the multiplayer area para.
            /// </remarks>
            public byte MapArea 
            {
                get => (byte)CellsByName["MapArea"].Value;
                set => CellsByName["MapArea"].Value = value;
            }
            

            // Def="u8 bossMapBlockNo"
            /// <summary>
            /// Map Block (u8)
            /// </summary>
            /// <remarks>
            /// Boss position_grid X number (m00_XX_00_00). It is used to check the distance between the host and the boss in the intrusion position search when "Is the intrusion point automatically generated?" In the multiplayer area para.
            /// </remarks>
            public byte MapBlock 
            {
                get => (byte)CellsByName["MapBlock"].Value;
                set => CellsByName["MapBlock"].Value = value;
            }
            

            // Def="u8 bossMapMapNo"
            /// <summary>
            /// Map Region (u8)
            /// </summary>
            /// <remarks>
            /// Boss position_grid Z number (m00_00_XX_00). It is used to check the distance between the host and the boss in the intrusion position search when "Is the intrusion point automatically generated?" In the multiplayer area para.
            /// </remarks>
            public byte MapRegion 
            {
                get => (byte)CellsByName["MapRegion"].Value;
                set => CellsByName["MapRegion"].Value = value;
            }
            

            // Def="dummy8 reserve[9]"
            /// <summary>
            /// Reserved area (dummy8)
            /// </summary>
            /// <remarks>
            /// Reserved area
            /// </remarks>
            public object ReservedArea 
            {
                get => (object)CellsByName["ReservedArea"].Value;
                set => CellsByName["ReservedArea"].Value = value;
            }
            
                }
            }
            

namespace StronglyTypedParams
{
    public class PlayRegionParam : ParamRow
    {
        public PlayRegionParam() : base()
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


        // Def="s32 matchAreaId"
        /// <summary>
        /// Match Area ID (s32)
        /// </summary>
        /// <remarks>
        /// Simple match area ID
        /// </remarks>
        public int MatchAreaID
        {
            get => (int)CellsByName["MatchAreaID"].Value;
            set => CellsByName["MatchAreaID"].Value = value;
        }


        // Def="u32 multiPlayStartLimitEventFlagId"
        /// <summary>
        /// Multiplayer Start Limit - Event Flag ID (u32)
        /// </summary>
        /// <remarks>
        /// Multiplayer start limit event flag ID
        /// </remarks>
        public uint MultiplayerStartLimitEventFlagID
        {
            get => (uint)CellsByName["MultiplayerStartLimitEventFlagID"].Value;
            set => CellsByName["MultiplayerStartLimitEventFlagID"].Value = value;
        }


        // Def="f32 otherDisableDistance"
        /// <summary>
        /// Disable Intrusion if Other Ghost In Range (f32)
        /// </summary>
        /// <remarks>
        /// Other distances that cannot be invaded by spirits. The intrusion position is searched for the intrusion points within the "other ghost invasion impossible distance" to the "other ghost invasion range upper limit" from the host position.
        /// </remarks>
        public float DisableIntrusionIfOtherGhostInRange
        {
            get => (float)CellsByName["DisableIntrusionIfOtherGhostInRange"].Value;
            set => CellsByName["DisableIntrusionIfOtherGhostInRange"].Value = value;
        }


        // Def="u32 pcPositionSaveLimitEventFlagId"
        /// <summary>
        /// Player Position Save Limit - Event Flag ID (u32)
        /// </summary>
        /// <remarks>
        /// PC position save restriction event flag ID (flag ON: PC position save valid flag OFF: PC position save invalid 0: PC position save always valid)
        /// </remarks>
        public uint PlayerPositionSaveLimitEventFlagID
        {
            get => (uint)CellsByName["PlayerPositionSaveLimitEventFlagID"].Value;
            set => CellsByName["PlayerPositionSaveLimitEventFlagID"].Value = value;
        }


        // Def="u32 bossAreaId"
        /// <summary>
        /// Boss Area ID (u32)
        /// </summary>
        /// <remarks>
        /// Areas with the same ID are treated as the same boss area.
        /// </remarks>
        public uint BossAreaID
        {
            get => (uint)CellsByName["BossAreaID"].Value;
            set => CellsByName["BossAreaID"].Value = value;
        }


        // Def="s16 cultNpcWhiteGhostEntityId_byFree = -1"
        /// <summary>
        /// White Phantom Entity ID - Free Frame (s16)
        /// </summary>
        /// <remarks>
        /// NPC White Spirit Summon Ritual Summon The beginning of the free frame ID used as the NPC's entity ID
        /// </remarks>
        public short WhitePhantomEntityIDFreeFrame
        {
            get => (short)CellsByName["WhitePhantomEntityIDFreeFrame"].Value;
            set => CellsByName["WhitePhantomEntityIDFreeFrame"].Value = value;
        }


        // Def="u8 bMapGuradianRegion"
        /// <summary>
        /// Is Map Guardian Region (u8)
        /// </summary>
        /// <remarks>
        /// Whether to increase or decrease the frame of the map protection area
        /// </remarks>
        public byte IsMapGuardianRegion
        {
            get => (byte)CellsByName["IsMapGuardianRegion"].Value;
            set => CellsByName["IsMapGuardianRegion"].Value = value;
        }


        // Def="u8 bYellowCostumeRegion:1"
        /// <summary>
        /// Is Yellow Monk Region (u8)
        /// </summary>
        /// <remarks>
        /// Is it the old man sign area of yellow robe?
        /// </remarks>
        public byte IsYellowMonkRegion
        {
            get => (byte)CellsByName["IsYellowMonkRegion"].Value;
            set => CellsByName["IsYellowMonkRegion"].Value = value;
        }


        // Def="u8 multiPlayStartLimitEventFlagId_targetFlagState:1 = 1"
        /// <summary>
        /// Target Flag State - Multiplayer Start Limit ID [1] (u8)
        /// </summary>
        /// <remarks>
        /// Flag state that limits "multiplayer start restriction event flag ID"
        /// </remarks>
        public byte TargetFlagStateMultiplayerStartLimitID1
        {
            get => (byte)CellsByName["TargetFlagStateMultiplayerStartLimitID1"].Value;
            set => CellsByName["TargetFlagStateMultiplayerStartLimitID1"].Value = value;
        }


        // Def="u8 breakInLimitEventFlagId_1_targetFlagState:1 = 1"
        /// <summary>
        /// Target Flag State - Invasion Start Limit ID [1] (u8)
        /// </summary>
        /// <remarks>
        /// Flag state that limits "intrusion restriction event flag ID1"
        /// </remarks>
        public byte TargetFlagStateInvasionStartLimitID1
        {
            get => (byte)CellsByName["TargetFlagStateInvasionStartLimitID1"].Value;
            set => CellsByName["TargetFlagStateInvasionStartLimitID1"].Value = value;
        }


        // Def="u8 whiteSignLimitEventFlagId_1_targetFlagState:1 = 1"
        /// <summary>
        /// Target Flag State - White Sign Start Limit ID [1] (u8)
        /// </summary>
        /// <remarks>
        /// Flag state that limits "white sign restriction event flag ID1"
        /// </remarks>
        public byte TargetFlagStateWhiteSignStartLimitID1
        {
            get => (byte)CellsByName["TargetFlagStateWhiteSignStartLimitID1"].Value;
            set => CellsByName["TargetFlagStateWhiteSignStartLimitID1"].Value = value;
        }


        // Def="u8 redSignLimitEventFlagId_1_targetFlagState:1 = 1"
        /// <summary>
        /// Target Flag State - Red Sign Start Limit ID [1] (u8)
        /// </summary>
        /// <remarks>
        /// Flag state that limits "red sign limit event flag ID1"
        /// </remarks>
        public byte TargetFlagStateRedSignStartLimitID1
        {
            get => (byte)CellsByName["TargetFlagStateRedSignStartLimitID1"].Value;
            set => CellsByName["TargetFlagStateRedSignStartLimitID1"].Value = value;
        }


        // Def="u8 breakInLimitEventFlagId_2_targetFlagState:1 = 1"
        /// <summary>
        /// Target Flag State - Invasion Start Limit ID [2] (u8)
        /// </summary>
        /// <remarks>
        /// Flag state that limits "intrusion restriction event flag ID2"
        /// </remarks>
        public byte TargetFlagStateInvasionStartLimitID2
        {
            get => (byte)CellsByName["TargetFlagStateInvasionStartLimitID2"].Value;
            set => CellsByName["TargetFlagStateInvasionStartLimitID2"].Value = value;
        }


        // Def="u8 breakInLimitEventFlagId_3_targetFlagState:1 = 1"
        /// <summary>
        /// Target Flag State - Invasion Start Limit ID [3] (u8)
        /// </summary>
        /// <remarks>
        /// Flag state that limits "intrusion restriction event flag ID3"
        /// </remarks>
        public byte TargetFlagStateInvasionStartLimitID3
        {
            get => (byte)CellsByName["TargetFlagStateInvasionStartLimitID3"].Value;
            set => CellsByName["TargetFlagStateInvasionStartLimitID3"].Value = value;
        }


        // Def="u8 whiteSignLimitEventFlagId_2_targetFlagState:1 = 1"
        /// <summary>
        /// Target Flag State - White Sign Start Limit ID [2] (u8)
        /// </summary>
        /// <remarks>
        /// Flag state that limits "white sign restriction event flag ID2"
        /// </remarks>
        public byte TargetFlagStateWhiteSignStartLimitID2
        {
            get => (byte)CellsByName["TargetFlagStateWhiteSignStartLimitID2"].Value;
            set => CellsByName["TargetFlagStateWhiteSignStartLimitID2"].Value = value;
        }


        // Def="u32 warpItemUsePermitBonfireId_1"
        /// <summary>
        /// Warp Item Usage Permitted - Bonfire ID [1] (u32)
        /// </summary>
        /// <remarks>
        /// Bonfire entity ID1 used to determine whether to allow the use of warp items
        /// </remarks>
        public uint WarpItemUsagePermittedBonfireID1
        {
            get => (uint)CellsByName["WarpItemUsagePermittedBonfireID1"].Value;
            set => CellsByName["WarpItemUsagePermittedBonfireID1"].Value = value;
        }


        // Def="u32 warpItemUsePermitBonfireId_2"
        /// <summary>
        /// Warp Item Usage Permitted - Bonfire ID [2] (u32)
        /// </summary>
        /// <remarks>
        /// Bonfire entity ID 2 used to determine permission to use warp items
        /// </remarks>
        public uint WarpItemUsagePermittedBonfireID2
        {
            get => (uint)CellsByName["WarpItemUsagePermittedBonfireID2"].Value;
            set => CellsByName["WarpItemUsagePermittedBonfireID2"].Value = value;
        }


        // Def="u32 warpItemUsePermitBonfireId_3"
        /// <summary>
        /// Warp Item Usage Permitted - Bonfire ID [3] (u32)
        /// </summary>
        /// <remarks>
        /// Bonfire entity ID 3 used to determine permission to use warp items
        /// </remarks>
        public uint WarpItemUsagePermittedBonfireID3
        {
            get => (uint)CellsByName["WarpItemUsagePermittedBonfireID3"].Value;
            set => CellsByName["WarpItemUsagePermittedBonfireID3"].Value = value;
        }


        // Def="u32 warpItemUsePermitBonfireId_4"
        /// <summary>
        /// Warp Item Usage Permitted - Bonfire ID [4] (u32)
        /// </summary>
        /// <remarks>
        /// Bonfire entity ID 4 used to determine permission to use warp items
        /// </remarks>
        public uint WarpItemUsagePermittedBonfireID4
        {
            get => (uint)CellsByName["WarpItemUsagePermittedBonfireID4"].Value;
            set => CellsByName["WarpItemUsagePermittedBonfireID4"].Value = value;
        }


        // Def="u32 warpItemUsePermitBonfireId_5"
        /// <summary>
        /// Warp Item Usage Permitted - Bonfire ID [5] (u32)
        /// </summary>
        /// <remarks>
        /// Bonfire entity ID 5 used to determine permission to use warp items
        /// </remarks>
        public uint WarpItemUsagePermittedBonfireID5
        {
            get => (uint)CellsByName["WarpItemUsagePermittedBonfireID5"].Value;
            set => CellsByName["WarpItemUsagePermittedBonfireID5"].Value = value;
        }


        // Def="u32 warpItemProhibitionEventFlagId_1"
        /// <summary>
        /// Warp Item Prohibition - Event Flag ID [1] (u32)
        /// </summary>
        /// <remarks>
        /// Event flag ID 1 to determine the prohibition of warp items. Warp item permission Higher priority than judgment by bonfire ID
        /// </remarks>
        public uint WarpItemProhibitionEventFlagID1
        {
            get => (uint)CellsByName["WarpItemProhibitionEventFlagID1"].Value;
            set => CellsByName["WarpItemProhibitionEventFlagID1"].Value = value;
        }


        // Def="u32 warpItemProhibitionEventFlagId_2"
        /// <summary>
        /// Warp Item Prohibition - Event Flag ID [2] (u32)
        /// </summary>
        /// <remarks>
        /// Event flag ID 2 to determine the prohibition of warp items. Warp item permission Higher priority than judgment by bonfire ID
        /// </remarks>
        public uint WarpItemProhibitionEventFlagID2
        {
            get => (uint)CellsByName["WarpItemProhibitionEventFlagID2"].Value;
            set => CellsByName["WarpItemProhibitionEventFlagID2"].Value = value;
        }


        // Def="u32 warpItemProhibitionEventFlagId_3"
        /// <summary>
        /// Warp Item Prohibition - Event Flag ID [3] (u32)
        /// </summary>
        /// <remarks>
        /// Event flag ID 3 to determine the prohibition of warp items. Warp item permission Higher priority than judgment by bonfire ID
        /// </remarks>
        public uint WarpItemProhibitionEventFlagID3
        {
            get => (uint)CellsByName["WarpItemProhibitionEventFlagID3"].Value;
            set => CellsByName["WarpItemProhibitionEventFlagID3"].Value = value;
        }


        // Def="u32 warpItemProhibitionEventFlagId_4"
        /// <summary>
        /// Warp Item Prohibition - Event Flag ID [4] (u32)
        /// </summary>
        /// <remarks>
        /// Event flag ID 4 to determine the prohibition of warp items. Warp item permission Higher priority than judgment by bonfire ID
        /// </remarks>
        public uint WarpItemProhibitionEventFlagID4
        {
            get => (uint)CellsByName["WarpItemProhibitionEventFlagID4"].Value;
            set => CellsByName["WarpItemProhibitionEventFlagID4"].Value = value;
        }


        // Def="u32 warpItemProhibitionEventFlagId_5"
        /// <summary>
        /// Warp Item Prohibition - Event Flag ID [5] (u32)
        /// </summary>
        /// <remarks>
        /// Event flag ID 5 to determine the prohibition of warp items. Warp item permission Higher priority than judgment by bonfire ID
        /// </remarks>
        public uint WarpItemProhibitionEventFlagID5
        {
            get => (uint)CellsByName["WarpItemProhibitionEventFlagID5"].Value;
            set => CellsByName["WarpItemProhibitionEventFlagID5"].Value = value;
        }


        // Def="u8 enableBloodstain:1 = 1"
        /// <summary>
        /// Enable Bloodstain (u8)
        /// </summary>
        /// <remarks>
        /// Effective bloodstain / death illusion
        /// </remarks>
        public byte EnableBloodstain
        {
            get => (byte)CellsByName["EnableBloodstain"].Value;
            set => CellsByName["EnableBloodstain"].Value = value;
        }


        // Def="u8 enableBloodMessage:1 = 1"
        /// <summary>
        /// Enable Blood Message (u8)
        /// </summary>
        /// <remarks>
        /// Blood character valid
        /// </remarks>
        public byte EnableBloodMessage
        {
            get => (byte)CellsByName["EnableBloodMessage"].Value;
            set => CellsByName["EnableBloodMessage"].Value = value;
        }


        // Def="u8 enableGhost:1 = 1"
        /// <summary>
        /// Enable Ghost (u8)
        /// </summary>
        /// <remarks>
        /// Phantom effective
        /// </remarks>
        public byte EnableGhost
        {
            get => (byte)CellsByName["EnableGhost"].Value;
            set => CellsByName["EnableGhost"].Value = value;
        }


        // Def="u8 dispMask00:1"
        /// <summary>
        /// Display Mask M00 (u8)
        /// </summary>
        /// <remarks>
        /// Whether to display on map M00
        /// </remarks>
        public byte DisplayMaskM00
        {
            get => (byte)CellsByName["DisplayMaskM00"].Value;
            set => CellsByName["DisplayMaskM00"].Value = value;
        }


        // Def="u8 dispMask01:1"
        /// <summary>
        /// Display Mask M01 (u8)
        /// </summary>
        /// <remarks>
        /// Whether to display on map M01
        /// </remarks>
        public byte DisplayMaskM01
        {
            get => (byte)CellsByName["DisplayMaskM01"].Value;
            set => CellsByName["DisplayMaskM01"].Value = value;
        }


        // Def="u8 whiteSignLimitEventFlagId_3_targetFlagState:1 = 1"
        /// <summary>
        /// Target Flag State - White Sign Start Limit ID [3] (u8)
        /// </summary>
        /// <remarks>
        /// Flag state that limits "white sign restriction event flag ID3"
        /// </remarks>
        public byte TargetFlagStateWhiteSignStartLimitID3
        {
            get => (byte)CellsByName["TargetFlagStateWhiteSignStartLimitID3"].Value;
            set => CellsByName["TargetFlagStateWhiteSignStartLimitID3"].Value = value;
        }


        // Def="u8 redSignLimitEventFlagId_2_targetFlagState:1 = 1"
        /// <summary>
        /// Target Flag State - Red Sign Start Limit ID [2] (u8)
        /// </summary>
        /// <remarks>
        /// Flag state that limits "red sign limit event flag ID2"
        /// </remarks>
        public byte TargetFlagStateRedSignStartLimitID2
        {
            get => (byte)CellsByName["TargetFlagStateRedSignStartLimitID2"].Value;
            set => CellsByName["TargetFlagStateRedSignStartLimitID2"].Value = value;
        }


        // Def="u8 redSignLimitEventFlagId_3_targetFlagState:1 = 1"
        /// <summary>
        /// Target Flag State - Red Sign Start Limit ID [3] (u8)
        /// </summary>
        /// <remarks>
        /// Flag state that limits "red sign limit event flag ID3"
        /// </remarks>
        public byte TargetFlagStateRedSignStartLimitID3
        {
            get => (byte)CellsByName["TargetFlagStateRedSignStartLimitID3"].Value;
            set => CellsByName["TargetFlagStateRedSignStartLimitID3"].Value = value;
        }


        // Def="u8 isAutoIntrudePoint:1"
        /// <summary>
        /// Is Automatic Invasion Point (u8)
        /// </summary>
        /// <remarks>
        /// Is it an intrusion point automatic generation? If it is set to ○, the intrusion position is searched by the automatically generated logic for the intrusion point.
        /// </remarks>
        public byte IsAutomaticInvasionPoint
        {
            get => (byte)CellsByName["IsAutomaticInvasionPoint"].Value;
            set => CellsByName["IsAutomaticInvasionPoint"].Value = value;
        }


        // Def="dummy8 pad1:7"
        /// <summary>
        /// pad1 (dummy8)
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        public object Pad1
        {
            get => (object)CellsByName["Pad1"].Value;
            set => CellsByName["Pad1"].Value = value;
        }


        // Def="dummy8 pad2[2]"
        /// <summary>
        /// pad2 (dummy8)
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        public object Pad2
        {
            get => (object)CellsByName["Pad2"].Value;
            set => CellsByName["Pad2"].Value = value;
        }


        // Def="u32 multiPlayHASHostLimitEventFlagId"
        /// <summary>
        /// Block Yellow Monk Multiplayer - Event Flag ID (u32)
        /// </summary>
        /// <remarks>
        /// Yellow Coat Host Restriction Event Flag: When this flag is turned on, multiplayer as a host of Yellow Coat is prohibited. It is assumed that the block clear flag will be inserted. 0: No limit
        /// </remarks>
        public uint BlockYellowMonkMultiplayerEventFlagID
        {
            get => (uint)CellsByName["BlockYellowMonkMultiplayerEventFlagID"].Value;
            set => CellsByName["BlockYellowMonkMultiplayerEventFlagID"].Value = value;
        }


        // Def="f32 otherMaxDistance = 1000"
        /// <summary>
        /// Other Ghost Invasion Range - Max Limit (f32)
        /// </summary>
        /// <remarks>
        /// Other ghost invasion range upper limit. The intrusion position is searched for the intrusion points within the "other ghost invasion impossible distance" to the "other ghost invasion range upper limit" from the host position.
        /// </remarks>
        public float OtherGhostInvasionRangeMaxLimit
        {
            get => (float)CellsByName["OtherGhostInvasionRangeMaxLimit"].Value;
            set => CellsByName["OtherGhostInvasionRangeMaxLimit"].Value = value;
        }


        // Def="u32 signPuddleOpenEventFlagId"
        /// <summary>
        /// Summoning Pool Open - Event Flag ID (u32)
        /// </summary>
        /// <remarks>
        /// Sign accumulation release event flag ID
        /// </remarks>
        public uint SummoningPoolOpenEventFlagID
        {
            get => (uint)CellsByName["SummoningPoolOpenEventFlagID"].Value;
            set => CellsByName["SummoningPoolOpenEventFlagID"].Value = value;
        }


        // Def="u8 areaNo"
        /// <summary>
        /// Map Area (u8)
        /// </summary>
        /// <remarks>
        /// Area number (mXX_00_00_00). Data for specifying the display position in the map menu
        /// </remarks>
        public byte MapArea
        {
            get => (byte)CellsByName["MapArea"].Value;
            set => CellsByName["MapArea"].Value = value;
        }


        // Def="u8 gridXNo"
        /// <summary>
        /// Map Block (u8)
        /// </summary>
        /// <remarks>
        /// Grid X number (m00_XX_00_00). Data for specifying the display position in the map menu
        /// </remarks>
        public byte MapBlock
        {
            get => (byte)CellsByName["MapBlock"].Value;
            set => CellsByName["MapBlock"].Value = value;
        }


        // Def="u8 gridZNo"
        /// <summary>
        /// Map Region (u8)
        /// </summary>
        /// <remarks>
        /// Grid Z number (m00_00_XX_00). Data for specifying the display position in the map menu
        /// </remarks>
        public byte MapRegion
        {
            get => (byte)CellsByName["MapRegion"].Value;
            set => CellsByName["MapRegion"].Value = value;
        }


        // Def="dummy8 pad4[1]"
        /// <summary>
        /// pad4 (dummy8)
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        public object Pad4
        {
            get => (object)CellsByName["Pad4"].Value;
            set => CellsByName["Pad4"].Value = value;
        }


        // Def="f32 posX"
        /// <summary>
        /// Coordinate: X (f32)
        /// </summary>
        /// <remarks>
        /// X coordinates (relative coordinates from the specified map). Data for specifying the display position in the map menu
        /// </remarks>
        public float CoordinateX
        {
            get => (float)CellsByName["CoordinateX"].Value;
            set => CellsByName["CoordinateX"].Value = value;
        }


        // Def="f32 posY"
        /// <summary>
        /// Coordinate: Y (f32)
        /// </summary>
        /// <remarks>
        /// Y coordinates (relative coordinates from the specified map). Data for specifying the display position in the map menu. Not actually used, but keep XYZ aligned
        /// </remarks>
        public float CoordinateY
        {
            get => (float)CellsByName["CoordinateY"].Value;
            set => CellsByName["CoordinateY"].Value = value;
        }


        // Def="f32 posZ"
        /// <summary>
        /// Coordinate: Z (f32)
        /// </summary>
        /// <remarks>
        /// Z coordinates (relative coordinates from the specified map). Data for specifying the display position in the map menu
        /// </remarks>
        public float CoordinateZ
        {
            get => (float)CellsByName["CoordinateZ"].Value;
            set => CellsByName["CoordinateZ"].Value = value;
        }


        // Def="u32 breakInLimitEventFlagId_1"
        /// <summary>
        /// Invasion Restriction - Event Flag ID [1] (u32)
        /// </summary>
        /// <remarks>
        /// Intrusion restriction event flag ID1
        /// </remarks>
        public uint InvasionRestrictionEventFlagID1
        {
            get => (uint)CellsByName["InvasionRestrictionEventFlagID1"].Value;
            set => CellsByName["InvasionRestrictionEventFlagID1"].Value = value;
        }


        // Def="u32 whiteSignLimitEventFlagId_1"
        /// <summary>
        /// Summon Restriction - Event Flag ID [1] (u32)
        /// </summary>
        /// <remarks>
        /// White sign limit event flag ID1
        /// </remarks>
        public uint SummonRestrictionEventFlagID1
        {
            get => (uint)CellsByName["SummonRestrictionEventFlagID1"].Value;
            set => CellsByName["SummonRestrictionEventFlagID1"].Value = value;
        }


        // Def="u32 matchAreaSignCreateLimitEventFlagId"
        /// <summary>
        /// Summoning Pool Restriction - Event Flag ID (u32)
        /// </summary>
        /// <remarks>
        /// Sign accumulation registration restriction Event flag ID (Flag ON: Sign accumulation registration is permitted Flag OFF: Sign accumulation registration is prohibited 0: Sign accumulation registration is always permitted)
        /// </remarks>
        public uint SummoningPoolRestrictionEventFlagID
        {
            get => (uint)CellsByName["SummoningPoolRestrictionEventFlagID"].Value;
            set => CellsByName["SummoningPoolRestrictionEventFlagID"].Value = value;
        }


        // Def="u32 signAimId_1"
        /// <summary>
        /// Sign Aim ID [1] (u32)
        /// </summary>
        /// <remarks>
        /// Multi-purpose ID to be displayed in the list when setting the purpose
        /// </remarks>
        public uint SignAimID1
        {
            get => (uint)CellsByName["SignAimID1"].Value;
            set => CellsByName["SignAimID1"].Value = value;
        }


        // Def="u32 signAimId_2"
        /// <summary>
        /// Sign Aim ID [2] (u32)
        /// </summary>
        /// <remarks>
        /// Multi-purpose ID to be displayed in the list when setting the purpose
        /// </remarks>
        public uint SignAimID2
        {
            get => (uint)CellsByName["SignAimID2"].Value;
            set => CellsByName["SignAimID2"].Value = value;
        }


        // Def="u32 signAimId_3"
        /// <summary>
        /// Sign Aim ID [3] (u32)
        /// </summary>
        /// <remarks>
        /// Multi-purpose ID to be displayed in the list when setting the purpose
        /// </remarks>
        public uint SignAimID3
        {
            get => (uint)CellsByName["SignAimID3"].Value;
            set => CellsByName["SignAimID3"].Value = value;
        }


        // Def="u32 signAimId_4"
        /// <summary>
        /// Sign Aim ID [4] (u32)
        /// </summary>
        /// <remarks>
        /// Multi-purpose ID to be displayed in the list when setting the purpose
        /// </remarks>
        public uint SignAimID4
        {
            get => (uint)CellsByName["SignAimID4"].Value;
            set => CellsByName["SignAimID4"].Value = value;
        }


        // Def="u32 signAimId_5"
        /// <summary>
        /// Sign Aim ID [5] (u32)
        /// </summary>
        /// <remarks>
        /// Multi-purpose ID to be displayed in the list when setting the purpose
        /// </remarks>
        public uint SignAimID5
        {
            get => (uint)CellsByName["SignAimID5"].Value;
            set => CellsByName["SignAimID5"].Value = value;
        }


        // Def="u32 signAimId_6"
        /// <summary>
        /// Sign Aim ID [6] (u32)
        /// </summary>
        /// <remarks>
        /// Multi-purpose ID to be displayed in the list when setting the purpose
        /// </remarks>
        public uint SignAimID6
        {
            get => (uint)CellsByName["SignAimID6"].Value;
            set => CellsByName["SignAimID6"].Value = value;
        }


        // Def="u32 signAimId_7"
        /// <summary>
        /// Sign Aim ID [7] (u32)
        /// </summary>
        /// <remarks>
        /// Multi-purpose ID to be displayed in the list when setting the purpose
        /// </remarks>
        public uint SignAimID7
        {
            get => (uint)CellsByName["SignAimID7"].Value;
            set => CellsByName["SignAimID7"].Value = value;
        }


        // Def="u32 signAimId_8"
        /// <summary>
        /// Sign Aim ID [8] (u32)
        /// </summary>
        /// <remarks>
        /// Multi-purpose ID to be displayed in the list when setting the purpose
        /// </remarks>
        public uint SignAimID8
        {
            get => (uint)CellsByName["SignAimID8"].Value;
            set => CellsByName["SignAimID8"].Value = value;
        }


        // Def="u32 redSignLimitEventFlagId_1"
        /// <summary>
        /// Red Sign Limit - Event Flag ID [1] (u32)
        /// </summary>
        /// <remarks>
        /// Red sign limit event flag ID1
        /// </remarks>
        public uint RedSignLimitEventFlagID1
        {
            get => (uint)CellsByName["RedSignLimitEventFlagID1"].Value;
            set => CellsByName["RedSignLimitEventFlagID1"].Value = value;
        }


        // Def="u32 breakInLimitEventFlagId_2"
        /// <summary>
        /// Invasion Limit - Event Flag ID [2] (u32)
        /// </summary>
        /// <remarks>
        /// Intrusion restriction event flag ID2
        /// </remarks>
        public uint InvasionLimitEventFlagID2
        {
            get => (uint)CellsByName["InvasionLimitEventFlagID2"].Value;
            set => CellsByName["InvasionLimitEventFlagID2"].Value = value;
        }


        // Def="u32 breakInLimitEventFlagId_3"
        /// <summary>
        /// Invasion Limit - Event Flag ID [3] (u32)
        /// </summary>
        /// <remarks>
        /// Intrusion restriction event flag ID3
        /// </remarks>
        public uint InvasionLimitEventFlagID3
        {
            get => (uint)CellsByName["InvasionLimitEventFlagID3"].Value;
            set => CellsByName["InvasionLimitEventFlagID3"].Value = value;
        }


        // Def="u32 whiteSignLimitEventFlagId_2"
        /// <summary>
        /// White Sign Limit - Event Flag ID [2] (u32)
        /// </summary>
        /// <remarks>
        /// White sign limit event flag ID2
        /// </remarks>
        public uint WhiteSignLimitEventFlagID2
        {
            get => (uint)CellsByName["WhiteSignLimitEventFlagID2"].Value;
            set => CellsByName["WhiteSignLimitEventFlagID2"].Value = value;
        }


        // Def="u32 whiteSignLimitEventFlagId_3"
        /// <summary>
        /// White Sign Limit - Event Flag ID [3] (u32)
        /// </summary>
        /// <remarks>
        /// White sign limit event flag ID3
        /// </remarks>
        public uint WhiteSignLimitEventFlagID3
        {
            get => (uint)CellsByName["WhiteSignLimitEventFlagID3"].Value;
            set => CellsByName["WhiteSignLimitEventFlagID3"].Value = value;
        }


        // Def="u32 redSignLimitEventFlagId_2"
        /// <summary>
        /// Red Sign Limit - Event Flag ID [2] (u32)
        /// </summary>
        /// <remarks>
        /// Red sign limit event flag ID2
        /// </remarks>
        public uint RedSignLimitEventFlagID2
        {
            get => (uint)CellsByName["RedSignLimitEventFlagID2"].Value;
            set => CellsByName["RedSignLimitEventFlagID2"].Value = value;
        }


        // Def="u32 redSignLimitEventFlagId_3"
        /// <summary>
        /// Red Sign Limit - Event Flag ID [3] (u32)
        /// </summary>
        /// <remarks>
        /// Red sign limit event flag ID3
        /// </remarks>
        public uint RedSignLimitEventFlagID3
        {
            get => (uint)CellsByName["RedSignLimitEventFlagID3"].Value;
            set => CellsByName["RedSignLimitEventFlagID3"].Value = value;
        }


        // Def="u32 bossId_1"
        /// <summary>
        /// Boss ID [1] (u32)
        /// </summary>
        /// <remarks>
        /// Area boss ID. It is used to select the target boss when "Is the intrusion point automatically generated?" Is ○.
        /// </remarks>
        public uint BossID1
        {
            get => (uint)CellsByName["BossID1"].Value;
            set => CellsByName["BossID1"].Value = value;
        }


        // Def="u32 bossId_2"
        /// <summary>
        /// Boss ID [2] (u32)
        /// </summary>
        /// <remarks>
        /// Area boss ID. It is used to select the target boss when "Is the intrusion point automatically generated?" Is ○.
        /// </remarks>
        public uint BossID2
        {
            get => (uint)CellsByName["BossID2"].Value;
            set => CellsByName["BossID2"].Value = value;
        }


        // Def="u32 bossId_3"
        /// <summary>
        /// Boss ID [3] (u32)
        /// </summary>
        /// <remarks>
        /// Area boss ID. It is used to select the target boss when "Is the intrusion point automatically generated?" Is ○.
        /// </remarks>
        public uint BossID3
        {
            get => (uint)CellsByName["BossID3"].Value;
            set => CellsByName["BossID3"].Value = value;
        }


        // Def="u32 bossId_4"
        /// <summary>
        /// Boss ID [4] (u32)
        /// </summary>
        /// <remarks>
        /// Area boss ID. It is used to select the target boss when "Is the intrusion point automatically generated?" Is ○.
        /// </remarks>
        public uint BossID4
        {
            get => (uint)CellsByName["BossID4"].Value;
            set => CellsByName["BossID4"].Value = value;
        }


        // Def="u32 bossId_5"
        /// <summary>
        /// Boss ID [5] (u32)
        /// </summary>
        /// <remarks>
        /// Area boss ID. It is used to select the target boss when "Is the intrusion point automatically generated?" Is ○.
        /// </remarks>
        public uint BossID5
        {
            get => (uint)CellsByName["BossID5"].Value;
            set => CellsByName["BossID5"].Value = value;
        }


        // Def="u32 bossId_6"
        /// <summary>
        /// Boss ID [6] (u32)
        /// </summary>
        /// <remarks>
        /// Area boss ID. It is used to select the target boss when "Is the intrusion point automatically generated?" Is ○.
        /// </remarks>
        public uint BossID6
        {
            get => (uint)CellsByName["BossID6"].Value;
            set => CellsByName["BossID6"].Value = value;
        }


        // Def="u32 bossId_7"
        /// <summary>
        /// Boss ID [7] (u32)
        /// </summary>
        /// <remarks>
        /// Area boss ID. It is used to select the target boss when "Is the intrusion point automatically generated?" Is ○.
        /// </remarks>
        public uint BossID7
        {
            get => (uint)CellsByName["BossID7"].Value;
            set => CellsByName["BossID7"].Value = value;
        }


        // Def="u32 bossId_8"
        /// <summary>
        /// Boss ID [8] (u32)
        /// </summary>
        /// <remarks>
        /// Area boss ID. It is used to select the target boss when "Is the intrusion point automatically generated?" Is ○.
        /// </remarks>
        public uint BossID8
        {
            get => (uint)CellsByName["BossID8"].Value;
            set => CellsByName["BossID8"].Value = value;
        }


        // Def="u32 bossId_9"
        /// <summary>
        /// Boss ID [9] (u32)
        /// </summary>
        /// <remarks>
        /// Area boss ID. It is used to select the target boss when "Is the intrusion point automatically generated?" Is ○.
        /// </remarks>
        public uint BossID9
        {
            get => (uint)CellsByName["BossID9"].Value;
            set => CellsByName["BossID9"].Value = value;
        }


        // Def="u32 bossId_10"
        /// <summary>
        /// Boss ID [10] (u32)
        /// </summary>
        /// <remarks>
        /// Area boss ID. It is used to select the target boss when "Is the intrusion point automatically generated?" Is ○.
        /// </remarks>
        public uint BossID10
        {
            get => (uint)CellsByName["BossID10"].Value;
            set => CellsByName["BossID10"].Value = value;
        }


        // Def="u32 bossId_11"
        /// <summary>
        /// Boss ID [11] (u32)
        /// </summary>
        /// <remarks>
        /// Area boss ID. It is used to select the target boss when "Is the intrusion point automatically generated?" Is ○.
        /// </remarks>
        public uint BossID11
        {
            get => (uint)CellsByName["BossID11"].Value;
            set => CellsByName["BossID11"].Value = value;
        }


        // Def="u32 bossId_12"
        /// <summary>
        /// Boss ID [12] (u32)
        /// </summary>
        /// <remarks>
        /// Area boss ID. It is used to select the target boss when "Is the intrusion point automatically generated?" Is ○.
        /// </remarks>
        public uint BossID12
        {
            get => (uint)CellsByName["BossID12"].Value;
            set => CellsByName["BossID12"].Value = value;
        }


        // Def="u32 bossId_13"
        /// <summary>
        /// Boss ID [13] (u32)
        /// </summary>
        /// <remarks>
        /// Area boss ID. It is used to select the target boss when "Is the intrusion point automatically generated?" Is ○.
        /// </remarks>
        public uint BossID13
        {
            get => (uint)CellsByName["BossID13"].Value;
            set => CellsByName["BossID13"].Value = value;
        }


        // Def="u32 bossId_14"
        /// <summary>
        /// Boss ID [14] (u32)
        /// </summary>
        /// <remarks>
        /// Area boss ID. It is used to select the target boss when "Is the intrusion point automatically generated?" Is ○.
        /// </remarks>
        public uint BossID14
        {
            get => (uint)CellsByName["BossID14"].Value;
            set => CellsByName["BossID14"].Value = value;
        }


        // Def="u32 bossId_15"
        /// <summary>
        /// Boss ID [15] (u32)
        /// </summary>
        /// <remarks>
        /// Area boss ID. It is used to select the target boss when "Is the intrusion point automatically generated?" Is ○.
        /// </remarks>
        public uint BossID15
        {
            get => (uint)CellsByName["BossID15"].Value;
            set => CellsByName["BossID15"].Value = value;
        }


        // Def="u32 bossId_16"
        /// <summary>
        /// Boss ID [16] (u32)
        /// </summary>
        /// <remarks>
        /// Area boss ID. It is used to select the target boss when "Is the intrusion point automatically generated?" Is ○.
        /// </remarks>
        public uint BossID16
        {
            get => (uint)CellsByName["BossID16"].Value;
            set => CellsByName["BossID16"].Value = value;
        }


        // Def="u32 mapMenuUnlockEventId"
        /// <summary>
        /// Map Menu Unlock - Event Flag ID (u32)
        /// </summary>
        /// <remarks>
        /// Map display_event flag ID (0: always displayed). Only when this event flag is set, it will be displayed in a lively manner in the map menu.
        /// </remarks>
        public uint MapMenuUnlockEventFlagID
        {
            get => (uint)CellsByName["MapMenuUnlockEventFlagID"].Value;
            set => CellsByName["MapMenuUnlockEventFlagID"].Value = value;
        }


        // Def="dummy8 pad5[32]"
        /// <summary>
        /// pad5 (dummy8)
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        public object Pad5
        {
            get => (object)CellsByName["Pad5"].Value;
            set => CellsByName["Pad5"].Value = value;
        }

    }
}

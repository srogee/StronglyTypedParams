
            namespace StronglyTypedParams
            {
                // BUDDY_PARAM_ST
                public class BuddyParam : ParamRow
                {
                    public BuddyParam() : base()
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
            

            // Def="s32 triggerSpEffectId = -1"
            /// <summary>
            /// Trigger SpEffect ID (s32)
            /// </summary>
            /// <remarks>
            /// Set the special effect ID that will be the summoning condition
            /// </remarks>
            public int TriggerSpEffectID 
            {
                get => (int)CellsByName["TriggerSpEffectID"].Value;
                set => CellsByName["TriggerSpEffectID"].Value = (int)value;
            }
            

            // Def="s32 npcParamId = -1"
            /// <summary>
            /// NPC Param ID (s32)
            /// </summary>
            /// <remarks>
            /// Set the NPC parameter ID of the summoned buddy
            /// </remarks>
            public int NPCParamID 
            {
                get => (int)CellsByName["NPCParamID"].Value;
                set => CellsByName["NPCParamID"].Value = (int)value;
            }
            

            // Def="s32 npcThinkParamId = -1"
            /// <summary>
            /// NPC Think Param ID (s32)
            /// </summary>
            /// <remarks>
            /// Sets the NPC Thinking Parameter ID of the summoned buddy
            /// </remarks>
            public int NPCThinkParamID 
            {
                get => (int)CellsByName["NPCThinkParamID"].Value;
                set => CellsByName["NPCThinkParamID"].Value = (int)value;
            }
            

            // Def="s32 npcParamId_ridden = -1"
            /// <summary>
            /// NPC Param ID - Ride (s32)
            /// </summary>
            /// <remarks>
            /// For buddies that you want to summon while riding, set the NPC parameter ID for the "rider"
            /// </remarks>
            public int NPCParamIDRide 
            {
                get => (int)CellsByName["NPCParamIDRide"].Value;
                set => CellsByName["NPCParamIDRide"].Value = (int)value;
            }
            

            // Def="s32 npcThinkParamId_ridden = -1"
            /// <summary>
            /// NPC Think Param ID - Ride (s32)
            /// </summary>
            /// <remarks>
            /// For buddies that you want to summon while riding, set the NPC Thinking Parameter ID for the "rider"
            /// </remarks>
            public int NPCThinkParamIDRide 
            {
                get => (int)CellsByName["NPCThinkParamIDRide"].Value;
                set => CellsByName["NPCThinkParamIDRide"].Value = (int)value;
            }
            

            // Def="f32 x_offset"
            /// <summary>
            /// Spawn Offset: X (f32)
            /// </summary>
            /// <remarks>
            /// Sets the distance in meters to offset the buddy from the summon point to the X coordinate
            /// </remarks>
            public float SpawnOffsetX 
            {
                get => (float)CellsByName["SpawnOffsetX"].Value;
                set => CellsByName["SpawnOffsetX"].Value = (float)value;
            }
            

            // Def="f32 z_offset"
            /// <summary>
            /// Spawn Offset: Z (f32)
            /// </summary>
            /// <remarks>
            /// Sets the distance in meters that offsets the buddy from the summon point to the Z coordinate.
            /// </remarks>
            public float SpawnOffsetZ 
            {
                get => (float)CellsByName["SpawnOffsetZ"].Value;
                set => CellsByName["SpawnOffsetZ"].Value = (float)value;
            }
            

            // Def="f32 y_angle"
            /// <summary>
            /// Spawn Angle: Y (f32)
            /// </summary>
            /// <remarks>
            /// Set the angle to rotate yourself around the Y axis
            /// </remarks>
            public float SpawnAngleY 
            {
                get => (float)CellsByName["SpawnAngleY"].Value;
                set => CellsByName["SpawnAngleY"].Value = (float)value;
            }
            

            // Def="u8 appearOnAroundSekihi"
            /// <summary>
            /// Appear near Stone Monument (u8)
            /// </summary>
            /// <remarks>
            /// Will it emerge from around the stone monument?
            /// </remarks>
            public BoolCirclecrossType AppearNearStoneMonument 
            {
                get => (BoolCirclecrossType)CellsByName["AppearNearStoneMonument"].Value;
                set => CellsByName["AppearNearStoneMonument"].Value = (byte)value;
            }
            

            // Def="u8 disablePCTargetShare"
            /// <summary>
            /// Disable Player Target Share (u8)
            /// </summary>
            /// <remarks>
            /// Do you want to skip target sharing with your PC?
            /// </remarks>
            public BoolCirclecrossType DisablePlayerTargetShare 
            {
                get => (BoolCirclecrossType)CellsByName["DisablePlayerTargetShare"].Value;
                set => CellsByName["DisablePlayerTargetShare"].Value = (byte)value;
            }
            

            // Def="u8 pcFollowType"
            /// <summary>
            /// Player Follow Type (u8)
            /// </summary>
            /// <remarks>
            /// PC tracking & warp type
            /// </remarks>
            public BuddyPcFollowType PlayerFollowType 
            {
                get => (BuddyPcFollowType)CellsByName["PlayerFollowType"].Value;
                set => CellsByName["PlayerFollowType"].Value = (byte)value;
            }
            

            // Def="dummy8 Reserve[1]"
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
            

            // Def="s32 dopingSpEffect_lv0 = -1"
            /// <summary>
            /// Reinforcement SpEffect: +0 (s32)
            /// </summary>
            /// <remarks>
            /// +0 o'clock doping special effect
            /// </remarks>
            public int ReinforcementSpEffect0 
            {
                get => (int)CellsByName["ReinforcementSpEffect0"].Value;
                set => CellsByName["ReinforcementSpEffect0"].Value = (int)value;
            }
            

            // Def="s32 dopingSpEffect_lv1 = -1"
            /// <summary>
            /// Reinforcement SpEffect: +1 (s32)
            /// </summary>
            /// <remarks>
            /// +0 o'clock doping special effect
            /// </remarks>
            public int ReinforcementSpEffect1 
            {
                get => (int)CellsByName["ReinforcementSpEffect1"].Value;
                set => CellsByName["ReinforcementSpEffect1"].Value = (int)value;
            }
            

            // Def="s32 dopingSpEffect_lv2 = -1"
            /// <summary>
            /// Reinforcement SpEffect: +2 (s32)
            /// </summary>
            /// <remarks>
            /// +0 o'clock doping special effect
            /// </remarks>
            public int ReinforcementSpEffect2 
            {
                get => (int)CellsByName["ReinforcementSpEffect2"].Value;
                set => CellsByName["ReinforcementSpEffect2"].Value = (int)value;
            }
            

            // Def="s32 dopingSpEffect_lv3 = -1"
            /// <summary>
            /// Reinforcement SpEffect: +3 (s32)
            /// </summary>
            /// <remarks>
            /// +0 o'clock doping special effect
            /// </remarks>
            public int ReinforcementSpEffect3 
            {
                get => (int)CellsByName["ReinforcementSpEffect3"].Value;
                set => CellsByName["ReinforcementSpEffect3"].Value = (int)value;
            }
            

            // Def="s32 dopingSpEffect_lv4 = -1"
            /// <summary>
            /// Reinforcement SpEffect: +4 (s32)
            /// </summary>
            /// <remarks>
            /// +0 o'clock doping special effect
            /// </remarks>
            public int ReinforcementSpEffect4 
            {
                get => (int)CellsByName["ReinforcementSpEffect4"].Value;
                set => CellsByName["ReinforcementSpEffect4"].Value = (int)value;
            }
            

            // Def="s32 dopingSpEffect_lv5 = -1"
            /// <summary>
            /// Reinforcement SpEffect: +5 (s32)
            /// </summary>
            /// <remarks>
            /// +0 o'clock doping special effect
            /// </remarks>
            public int ReinforcementSpEffect5 
            {
                get => (int)CellsByName["ReinforcementSpEffect5"].Value;
                set => CellsByName["ReinforcementSpEffect5"].Value = (int)value;
            }
            

            // Def="s32 dopingSpEffect_lv6 = -1"
            /// <summary>
            /// Reinforcement SpEffect: +6 (s32)
            /// </summary>
            /// <remarks>
            /// +0 o'clock doping special effect
            /// </remarks>
            public int ReinforcementSpEffect6 
            {
                get => (int)CellsByName["ReinforcementSpEffect6"].Value;
                set => CellsByName["ReinforcementSpEffect6"].Value = (int)value;
            }
            

            // Def="s32 dopingSpEffect_lv7 = -1"
            /// <summary>
            /// Reinforcement SpEffect: +7 (s32)
            /// </summary>
            /// <remarks>
            /// +0 o'clock doping special effect
            /// </remarks>
            public int ReinforcementSpEffect7 
            {
                get => (int)CellsByName["ReinforcementSpEffect7"].Value;
                set => CellsByName["ReinforcementSpEffect7"].Value = (int)value;
            }
            

            // Def="s32 dopingSpEffect_lv8 = -1"
            /// <summary>
            /// Reinforcement SpEffect: +8 (s32)
            /// </summary>
            /// <remarks>
            /// +0 o'clock doping special effect
            /// </remarks>
            public int ReinforcementSpEffect8 
            {
                get => (int)CellsByName["ReinforcementSpEffect8"].Value;
                set => CellsByName["ReinforcementSpEffect8"].Value = (int)value;
            }
            

            // Def="s32 dopingSpEffect_lv9 = -1"
            /// <summary>
            /// Reinforcement SpEffect: +9 (s32)
            /// </summary>
            /// <remarks>
            /// +0 o'clock doping special effect
            /// </remarks>
            public int ReinforcementSpEffect9 
            {
                get => (int)CellsByName["ReinforcementSpEffect9"].Value;
                set => CellsByName["ReinforcementSpEffect9"].Value = (int)value;
            }
            

            // Def="s32 dopingSpEffect_lv10 = -1"
            /// <summary>
            /// Reinforcement SpEffect: +10 (s32)
            /// </summary>
            /// <remarks>
            /// +0 o'clock doping special effect
            /// </remarks>
            public int ReinforcementSpEffect10 
            {
                get => (int)CellsByName["ReinforcementSpEffect10"].Value;
                set => CellsByName["ReinforcementSpEffect10"].Value = (int)value;
            }
            

            // Def="s32 npcPlayerInitParamId = -1"
            /// <summary>
            /// Character Init ID (s32)
            /// </summary>
            /// <remarks>
            /// Initial parameter ID by architype
            /// </remarks>
            public int CharacterInitID 
            {
                get => (int)CellsByName["CharacterInitID"].Value;
                set => CellsByName["CharacterInitID"].Value = (int)value;
            }
            

            // Def="s32 generateAnimId = -1"
            /// <summary>
            /// Generate Anim ID (s32)
            /// </summary>
            /// <remarks>
            /// Generate Anime ID
            /// </remarks>
            public int GenerateAnimID 
            {
                get => (int)CellsByName["GenerateAnimID"].Value;
                set => CellsByName["GenerateAnimID"].Value = (int)value;
            }
            

            // Def="dummy8 Reserve2[4]"
            /// <summary>
            /// Reserve 2 (dummy8)
            /// </summary>
            /// <remarks>
            /// Reserve 2
            /// </remarks>
            public object Reserve2 
            {
                get => (object)CellsByName["Reserve2"].Value;
                set => CellsByName["Reserve2"].Value = (object)value;
            }
            
                }
            }
            
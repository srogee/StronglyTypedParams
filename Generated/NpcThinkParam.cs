
namespace StronglyTypedParams
{
    public class NpcThinkParam : ParamRow
    {
        public NpcThinkParam() : base()
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


        // Def="s32 logicId = -1"
        /// <summary>
        /// Logic ID (s32)
        /// </summary>
        /// <remarks>
        /// Set the ID of the logic created by the script.
        /// </remarks>
        public int LogicID
        {
            get => (int)CellsByName["LogicID"].Value;
            set => CellsByName["LogicID"].Value = value;
        }


        // Def="s32 battleGoalID = -1"
        /// <summary>
        /// Battle Goal ID (s32)
        /// </summary>
        /// <remarks>
        /// Battle goal ID
        /// </remarks>
        public int BattleGoalID
        {
            get => (int)CellsByName["BattleGoalID"].Value;
            set => CellsByName["BattleGoalID"].Value = value;
        }


        // Def="u16 searchEye_dist"
        /// <summary>
        /// Vision - Distance (u16)
        /// </summary>
        /// <remarks>
        /// Search range by visual search.
        /// </remarks>
        public ushort VisionDistance
        {
            get => (ushort)CellsByName["VisionDistance"].Value;
            set => CellsByName["VisionDistance"].Value = value;
        }


        // Def="u8 searchEye_angY"
        /// <summary>
        /// Vision - Width (u8)
        /// </summary>
        /// <remarks>
        /// Search range by visual search.
        /// </remarks>
        public byte VisionWidth
        {
            get => (byte)CellsByName["VisionWidth"].Value;
            set => CellsByName["VisionWidth"].Value = value;
        }


        // Def="u8 isNoAvoidHugeEnemy:1"
        /// <summary>
        /// Don't Avoid Giant Enemy (u8)
        /// </summary>
        /// <remarks>
        /// Do you not detour a huge enemy?
        /// </remarks>
        public byte DonTAvoidGiantEnemy
        {
            get => (byte)CellsByName["DonTAvoidGiantEnemy"].Value;
            set => CellsByName["DonTAvoidGiantEnemy"].Value = value;
        }


        // Def="u8 enableWeaponOnOff:1"
        /// <summary>
        /// Enable Weapon Switch (u8)
        /// </summary>
        /// <remarks>
        /// Do you want to pull out the sword?
        /// </remarks>
        public byte EnableWeaponSwitch
        {
            get => (byte)CellsByName["EnableWeaponSwitch"].Value;
            set => CellsByName["EnableWeaponSwitch"].Value = value;
        }


        // Def="u8 targetAILockDmyPoly:1 = 1"
        /// <summary>
        /// Aim for AI Target Lock Dummy Poly ID (u8)
        /// </summary>
        /// <remarks>
        /// Do you aim for Rock Damipoli (for enemies)?
        /// </remarks>
        public byte AimForAITargetLockDummyPolyID
        {
            get => (byte)CellsByName["AimForAITargetLockDummyPolyID"].Value;
            set => CellsByName["AimForAITargetLockDummyPolyID"].Value = value;
        }


        // Def="dummy8 pad8:5"
        /// <summary>
        /// Padding (dummy8)
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        public object Padding
        {
            get => (object)CellsByName["Padding"].Value;
            set => CellsByName["Padding"].Value = value;
        }


        // Def="s32 spEffectId_RangedAttack = -1"
        /// <summary>
        /// Ranged Attack - SpEffect ID (s32)
        /// </summary>
        /// <remarks>
        /// Special effects ID for ranged attacks
        /// </remarks>
        public int RangedAttackSpEffectID
        {
            get => (int)CellsByName["RangedAttackSpEffectID"].Value;
            set => CellsByName["RangedAttackSpEffectID"].Value = value;
        }


        // Def="f32 searchTargetLv1ForgetTime = 5"
        /// <summary>
        /// Search Target - Forget Time [1] (f32)
        /// </summary>
        /// <remarks>
        /// Search enemy Lv1 Target Time to forget.
        /// </remarks>
        public float SearchTargetForgetTime1
        {
            get => (float)CellsByName["SearchTargetForgetTime1"].Value;
            set => CellsByName["SearchTargetForgetTime1"].Value = value;
        }


        // Def="f32 searchTargetLv2ForgetTime = 8"
        /// <summary>
        /// Search Target - Forget Time [2] (f32)
        /// </summary>
        /// <remarks>
        /// Search enemy Lv2 time to forget the target.
        /// </remarks>
        public float SearchTargetForgetTime2
        {
            get => (float)CellsByName["SearchTargetForgetTime2"].Value;
            set => CellsByName["SearchTargetForgetTime2"].Value = value;
        }


        // Def="f32 BackHomeLife_OnHitEneWal = 5"
        /// <summary>
        /// Back Home Time on Touching Enemy Wall (f32)
        /// </summary>
        /// <remarks>
        /// The life of the BackToHome goal when it touches an enemy wall that blocks the block
        /// </remarks>
        public float BackHomeTimeOnTouchingEnemyWall
        {
            get => (float)CellsByName["BackHomeTimeOnTouchingEnemyWall"].Value;
            set => CellsByName["BackHomeTimeOnTouchingEnemyWall"].Value = value;
        }


        // Def="f32 SightTargetForgetTime = 600"
        /// <summary>
        /// Search Target - Visual Forget Time (f32)
        /// </summary>
        /// <remarks>
        /// Time to forget the visual target.
        /// </remarks>
        public float SearchTargetVisualForgetTime
        {
            get => (float)CellsByName["SearchTargetVisualForgetTime"].Value;
            set => CellsByName["SearchTargetVisualForgetTime"].Value = value;
        }


        // Def="s32 idAttackCannotMove"
        /// <summary>
        /// Blocked Movement - Anim ID (s32)
        /// </summary>
        /// <remarks>
        /// An action that automatically takes place when a destructible object stops it.
        /// </remarks>
        public int BlockedMovementAnimID
        {
            get => (int)CellsByName["BlockedMovementAnimID"].Value;
            set => CellsByName["BlockedMovementAnimID"].Value = value;
        }


        // Def="f32 ear_dist"
        /// <summary>
        /// Listen - Distance (f32)
        /// </summary>
        /// <remarks>
        /// Hearing search range ...
        /// </remarks>
        public float ListenDistance
        {
            get => (float)CellsByName["ListenDistance"].Value;
            set => CellsByName["ListenDistance"].Value = value;
        }


        // Def="s32 callHelp_ActionAnimId = -1"
        /// <summary>
        /// Call Help - Action Animation ID (s32)
        /// </summary>
        /// <remarks>
        /// Animation ID (EzStateAnimID) when responding
        /// </remarks>
        public int CallHelpActionAnimationID
        {
            get => (int)CellsByName["CallHelpActionAnimationID"].Value;
            set => CellsByName["CallHelpActionAnimationID"].Value = value;
        }


        // Def="s32 callHelp_CallActionId = -1"
        /// <summary>
        /// Call Help - Call Action ID (s32)
        /// </summary>
        /// <remarks>
        /// Action ID (EzStateAnimID) when calling a friend
        /// </remarks>
        public int CallHelpCallActionID
        {
            get => (int)CellsByName["CallHelpCallActionID"].Value;
            set => CellsByName["CallHelpCallActionID"].Value = value;
        }



        // Def="u8 isGuard_Act"
        /// <summary>
        /// Use Guard during Action (u8)
        /// </summary>
        /// <remarks>
        /// Whether to guard against actions (assumed when returning home, looking toward the target)
        /// </remarks>
        public byte UseGuardDuringAction
        {
            get => (byte)CellsByName["UseGuardDuringAction"].Value;
            set => CellsByName["UseGuardDuringAction"].Value = value;
        }



        // Def="u16 ear_soundcut_dist"
        /// <summary>
        /// Listen - Sound Cutoff Distance (u16)
        /// </summary>
        /// <remarks>
        /// The distance to reduce the size of the sound source. You will not hear any sound below this distance.
        /// </remarks>
        public ushort ListenSoundCutoffDistance
        {
            get => (ushort)CellsByName["ListenSoundCutoffDistance"].Value;
            set => CellsByName["ListenSoundCutoffDistance"].Value = value;
        }


        // Def="u16 nose_dist"
        /// <summary>
        /// Sense - Distance (u16)
        /// </summary>
        /// <remarks>
        /// Search range by smell.
        /// </remarks>
        public ushort SenseDistance
        {
            get => (ushort)CellsByName["SenseDistance"].Value;
            set => CellsByName["SenseDistance"].Value = value;
        }


        // Def="u16 maxBackhomeDist"
        /// <summary>
        /// Retreat Home - Max Distance (u16)
        /// </summary>
        /// <remarks>
        /// COMMON_SetBattleActLogic argument
        /// </remarks>
        public ushort RetreatHomeMaxDistance
        {
            get => (ushort)CellsByName["RetreatHomeMaxDistance"].Value;
            set => CellsByName["RetreatHomeMaxDistance"].Value = value;
        }


        // Def="u16 backhomeDist"
        /// <summary>
        /// Retreat Home - Distance (u16)
        /// </summary>
        /// <remarks>
        /// COMMON_SetBattleActLogic argument
        /// </remarks>
        public ushort RetreatHomeDistance
        {
            get => (ushort)CellsByName["RetreatHomeDistance"].Value;
            set => CellsByName["RetreatHomeDistance"].Value = value;
        }


        // Def="u16 backhomeBattleDist"
        /// <summary>
        /// Retreat Home - Battle Distance (u16)
        /// </summary>
        /// <remarks>
        /// COMMON_SetBattleActLogic argument
        /// </remarks>
        public ushort RetreatHomeBattleDistance
        {
            get => (ushort)CellsByName["RetreatHomeBattleDistance"].Value;
            set => CellsByName["RetreatHomeBattleDistance"].Value = value;
        }


        // Def="u16 nonBattleActLife"
        /// <summary>
        /// Non-Battle Act Duration when in Combat (u16)
        /// </summary>
        /// <remarks>
        /// COMMON_SetBattleActLogic argument
        /// </remarks>
        public ushort NonBattleActDurationWhenInCombat
        {
            get => (ushort)CellsByName["NonBattleActDurationWhenInCombat"].Value;
            set => CellsByName["NonBattleActDurationWhenInCombat"].Value = value;
        }


        // Def="u16 BackHome_LookTargetTime = 3"
        /// <summary>
        /// Retreat Home - Look for Target Time (u16)
        /// </summary>
        /// <remarks>
        /// When returning home: Time to look at the target [sec]
        /// </remarks>
        public ushort RetreatHomeLookForTargetTime
        {
            get => (ushort)CellsByName["RetreatHomeLookForTargetTime"].Value;
            set => CellsByName["RetreatHomeLookForTargetTime"].Value = value;
        }


        // Def="u16 BackHome_LookTargetDist = 10"
        /// <summary>
        /// Retreat Home - Look for Target Distance (u16)
        /// </summary>
        /// <remarks>
        /// When returning home: Distance to see the target [m]
        /// </remarks>
        public ushort RetreatHomeLookForTargetDistance
        {
            get => (ushort)CellsByName["RetreatHomeLookForTargetDistance"].Value;
            set => CellsByName["RetreatHomeLookForTargetDistance"].Value = value;
        }


        // Def="f32 SoundTargetForgetTime = 3"
        /// <summary>
        /// Sound Target - Forget Time (f32)
        /// </summary>
        /// <remarks>
        /// Time to forget the sound target.
        /// </remarks>
        public float SoundTargetForgetTime
        {
            get => (float)CellsByName["SoundTargetForgetTime"].Value;
            set => CellsByName["SoundTargetForgetTime"].Value = value;
        }


        // Def="u16 BattleStartDist"
        /// <summary>
        /// Battle - Start Distance (u16)
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        public ushort BattleStartDistance
        {
            get => (ushort)CellsByName["BattleStartDistance"].Value;
            set => CellsByName["BattleStartDistance"].Value = value;
        }


        // Def="u16 callHelp_MyPeerId"
        /// <summary>
        /// Call Help - My Peer ID (u16)
        /// </summary>
        /// <remarks>
        /// My fellow group ID
        /// </remarks>
        public ushort CallHelpMyPeerID
        {
            get => (ushort)CellsByName["CallHelpMyPeerID"].Value;
            set => CellsByName["CallHelpMyPeerID"].Value = value;
        }


        // Def="u16 callHelp_CallPeerId"
        /// <summary>
        /// Call Help - Call Peer ID (u16)
        /// </summary>
        /// <remarks>
        /// Companion group ID to call a companion
        /// </remarks>
        public ushort CallHelpCallPeerID
        {
            get => (ushort)CellsByName["CallHelpCallPeerID"].Value;
            set => CellsByName["CallHelpCallPeerID"].Value = value;
        }


        // Def="u16 targetSys_DmgEffectRate = 100"
        /// <summary>
        /// Target System - Damage Effect Rate (u16)
        /// </summary>
        /// <remarks>
        /// Damage impact rate acquisition (target system evaluation information)
        /// </remarks>
        public ushort TargetSystemDamageEffectRate
        {
            get => (ushort)CellsByName["TargetSystemDamageEffectRate"].Value;
            set => CellsByName["TargetSystemDamageEffectRate"].Value = value;
        }


        // Def="u8 TeamAttackEffectivity = 25"
        /// <summary>
        /// Team Attack Effectivity (u8)
        /// </summary>
        /// <remarks>
        /// A value for determining the number of simultaneous attacks in a team. Increasing the value reduces the number of people who can participate in the attack at the same time.
        /// </remarks>
        public byte TeamAttackEffectivity
        {
            get => (byte)CellsByName["TeamAttackEffectivity"].Value;
            set => CellsByName["TeamAttackEffectivity"].Value = value;
        }


        // Def="u8 eye_angX"
        /// <summary>
        /// Vision - Height Angle (u8)
        /// </summary>
        /// <remarks>
        /// Visual search range.
        /// </remarks>
        public byte VisionHeightAngle
        {
            get => (byte)CellsByName["VisionHeightAngle"].Value;
            set => CellsByName["VisionHeightAngle"].Value = value;
        }


        // Def="u8 eye_angY"
        /// <summary>
        /// Vision - Width Angle (u8)
        /// </summary>
        /// <remarks>
        /// Visual search range.
        /// </remarks>
        public byte VisionWidthAngle
        {
            get => (byte)CellsByName["VisionWidthAngle"].Value;
            set => CellsByName["VisionWidthAngle"].Value = value;
        }


        // Def="u8 disableDark"
        /// <summary>
        /// Disable Darkness Modifier to Distance (u8)
        /// </summary>
        /// <remarks>
        /// Whether the alert vision_distance and battle start distance are not affected by the darkness
        /// </remarks>
        public byte DisableDarknessModifierToDistance
        {
            get => (byte)CellsByName["DisableDarknessModifierToDistance"].Value;
            set => CellsByName["DisableDarknessModifierToDistance"].Value = value;
        }


        // Def="u8 caravanRole"
        /// <summary>
        /// Caravan Role (u8)
        /// </summary>
        /// <remarks>
        /// Role in the caravan
        /// </remarks>
        public byte CaravanRole
        {
            get => (byte)CellsByName["CaravanRole"].Value;
            set => CellsByName["CaravanRole"].Value = value;
        }


        // Def="u8 callHelp_CallValidMinDistTarget = 5"
        /// <summary>
        /// Call Help - Valid Target Min Distance (u8)
        /// </summary>
        /// <remarks>
        /// If it is closer than this value, you cannot call a friend.
        /// </remarks>
        public byte CallHelpValidTargetMinDistance
        {
            get => (byte)CellsByName["CallHelpValidTargetMinDistance"].Value;
            set => CellsByName["CallHelpValidTargetMinDistance"].Value = value;
        }


        // Def="u8 callHelp_CallValidRange = 15"
        /// <summary>
        /// Call Help - Valid Target Range (u8)
        /// </summary>
        /// <remarks>
        /// Do not call if the companion is farther than this value.
        /// </remarks>
        public byte CallHelpValidTargetRange
        {
            get => (byte)CellsByName["CallHelpValidTargetRange"].Value;
            set => CellsByName["CallHelpValidTargetRange"].Value = value;
        }


        // Def="u8 callHelp_ForgetTimeByArrival"
        /// <summary>
        /// Call Help - Forget Time by Arrival (u8)
        /// </summary>
        /// <remarks>
        /// Time to respond
        /// </remarks>
        public byte CallHelpForgetTimeByArrival
        {
            get => (byte)CellsByName["CallHelpForgetTimeByArrival"].Value;
            set => CellsByName["CallHelpForgetTimeByArrival"].Value = value;
        }


        // Def="u8 callHelp_MinWaitTime"
        /// <summary>
        /// Call Help - Min Wait Time (u8)
        /// </summary>
        /// <remarks>
        /// Minimum time for the first wait goal of the response goal [101 => 10.1sec]
        /// </remarks>
        public byte CallHelpMinWaitTime
        {
            get => (byte)CellsByName["CallHelpMinWaitTime"].Value;
            set => CellsByName["CallHelpMinWaitTime"].Value = value;
        }


        // Def="u8 callHelp_MaxWaitTime"
        /// <summary>
        /// Call Help - Max Wait Time (u8)
        /// </summary>
        /// <remarks>
        /// Maximum time for the first waiting goal of the response goal [101 => 10.1sec]
        /// </remarks>
        public byte CallHelpMaxWaitTime
        {
            get => (byte)CellsByName["CallHelpMaxWaitTime"].Value;
            set => CellsByName["CallHelpMaxWaitTime"].Value = value;
        }


        // Def="u8 goalAction_ToCaution"
        /// <summary>
        /// Goal Action - To Caution (Sound) (u8)
        /// </summary>
        /// <remarks>
        /// Goal action: Target becomes alert due to normal sound detection
        /// </remarks>
        public byte GoalActionToCautionSound
        {
            get => (byte)CellsByName["GoalActionToCautionSound"].Value;
            set => CellsByName["GoalActionToCautionSound"].Value = value;
        }


        // Def="u8 ear_listenLevel = 128"
        /// <summary>
        /// Listen - Listen Level (u8)
        /// </summary>
        /// <remarks>
        /// How good your ears are
        /// </remarks>
        public byte ListenListenLevel
        {
            get => (byte)CellsByName["ListenListenLevel"].Value;
            set => CellsByName["ListenListenLevel"].Value = value;
        }


        // Def="u8 callHelp_ReplyBehaviorType"
        /// <summary>
        /// Call Help - Reply Behavior Type (u8)
        /// </summary>
        /// <remarks>
        /// Action type to target position after response
        /// </remarks>
        public byte CallHelpReplyBehaviorType
        {
            get => (byte)CellsByName["CallHelpReplyBehaviorType"].Value;
            set => CellsByName["CallHelpReplyBehaviorType"].Value = value;
        }


        // Def="u8 disablePathMove"
        /// <summary>
        /// Disable Path Move (u8)
        /// </summary>
        /// <remarks>
        /// Whether to move directly without following the path even if a path move command comes
        /// </remarks>
        public byte DisablePathMove
        {
            get => (byte)CellsByName["DisablePathMove"].Value;
            set => CellsByName["DisablePathMove"].Value = value;
        }


        // Def="u8 skipArrivalVisibleCheck"
        /// <summary>
        /// Skip Arrival Visibility Check (u8)
        /// </summary>
        /// <remarks>
        /// Do you want to skip the arrival judgment by the line of sight? When set to On, arrival judgment is performed even if the line of sight does not pass.
        /// </remarks>
        public byte SkipArrivalVisibilityCheck
        {
            get => (byte)CellsByName["SkipArrivalVisibilityCheck"].Value;
            set => CellsByName["SkipArrivalVisibilityCheck"].Value = value;
        }


        // Def="u8 thinkAttr_doAdmirer"
        /// <summary>
        /// Think Attribute - Do Admirer (u8)
        /// </summary>
        /// <remarks>
        /// Thinking attribute: When turned on, it plays a role of surrounding.
        /// </remarks>
        public byte ThinkAttributeDoAdmirer
        {
            get => (byte)CellsByName["ThinkAttributeDoAdmirer"].Value;
            set => CellsByName["ThinkAttributeDoAdmirer"].Value = value;
        }


        // Def="u8 enableNaviFlg_Edge:1 = 1"
        /// <summary>
        /// Navigation - Edge (u8)
        /// </summary>
        /// <remarks>
        /// Can you pass through the node "cliff"? (def: 1)
        /// </remarks>
        public byte NavigationEdge
        {
            get => (byte)CellsByName["NavigationEdge"].Value;
            set => CellsByName["NavigationEdge"].Value = value;
        }


        // Def="u8 enableNaviFlg_LargeSpace:1 = 1"
        /// <summary>
        /// Navigation - Large Space (u8)
        /// </summary>
        /// <remarks>
        /// Can you pass through the node "wide"? (def: 1)
        /// </remarks>
        public byte NavigationLargeSpace
        {
            get => (byte)CellsByName["NavigationLargeSpace"].Value;
            set => CellsByName["NavigationLargeSpace"].Value = value;
        }


        // Def="u8 enableNaviFlg_Ladder:1"
        /// <summary>
        /// Navigation - Ladder (u8)
        /// </summary>
        /// <remarks>
        /// Can you pass through the node "ladder"? (def: 0)
        /// </remarks>
        public byte NavigationLadder
        {
            get => (byte)CellsByName["NavigationLadder"].Value;
            set => CellsByName["NavigationLadder"].Value = value;
        }


        // Def="u8 enableNaviFlg_Hole:1"
        /// <summary>
        /// Navigation - Hole (u8)
        /// </summary>
        /// <remarks>
        /// Can you go through the node "hole"? (def: 0)
        /// </remarks>
        public byte NavigationHole
        {
            get => (byte)CellsByName["NavigationHole"].Value;
            set => CellsByName["NavigationHole"].Value = value;
        }


        // Def="u8 enableNaviFlg_Door:1"
        /// <summary>
        /// Navigation - Door (u8)
        /// </summary>
        /// <remarks>
        /// Can you pass through the node "door"? (def: 0)
        /// </remarks>
        public byte NavigationDoor
        {
            get => (byte)CellsByName["NavigationDoor"].Value;
            set => CellsByName["NavigationDoor"].Value = value;
        }


        // Def="u8 enableNaviFlg_InSideWall:1"
        /// <summary>
        /// Navigation - Ignore Navmesh Wall (u8)
        /// </summary>
        /// <remarks>
        /// Can you pass through the node "in the wall"? (def: 0)
        /// </remarks>
        public byte NavigationIgnoreNavmeshWall
        {
            get => (byte)CellsByName["NavigationIgnoreNavmeshWall"].Value;
            set => CellsByName["NavigationIgnoreNavmeshWall"].Value = value;
        }


        // Def="u8 enableNaviFlg_Lava:1"
        /// <summary>
        /// Navigation - Lava (u8)
        /// </summary>
        /// <remarks>
        /// Can you pass through the node "lava"? (def: 0)
        /// </remarks>
        public byte NavigationLava
        {
            get => (byte)CellsByName["NavigationLava"].Value;
            set => CellsByName["NavigationLava"].Value = value;
        }


        // Def="u8 enableNaviFlg_Edge_Ordinary:1 = 1"
        /// <summary>
        /// Navigation - Cliff Edge (u8)
        /// </summary>
        /// <remarks>
        /// Can you pass the node "cliff" under normal / alert conditions? (def: 1)
        /// </remarks>
        public byte NavigationCliffEdge
        {
            get => (byte)CellsByName["NavigationCliffEdge"].Value;
            set => CellsByName["NavigationCliffEdge"].Value = value;
        }


        // Def="dummy8 enableNaviFlg_reserve1[3]"
        /// <summary>
        /// Really booked (dummy8)
        /// </summary>
        /// <remarks>
        /// If you need a new flag, put it here (Not Padding)
        /// </remarks>
        public object ReallyBooked
        {
            get => (object)CellsByName["ReallyBooked"].Value;
            set => CellsByName["ReallyBooked"].Value = value;
        }


        // Def="s32 searchThreshold_Lv0toLv1 = 10"
        /// <summary>
        /// Search Threshold - Level 0 to Level 1 (s32)
        /// </summary>
        /// <remarks>
        /// Search enemy Lv0 → Lv1 threshold
        /// </remarks>
        public int SearchThresholdLevel0ToLevel1
        {
            get => (int)CellsByName["SearchThresholdLevel0ToLevel1"].Value;
            set => CellsByName["SearchThresholdLevel0ToLevel1"].Value = value;
        }


        // Def="s32 searchThreshold_Lv1toLv2 = 70"
        /// <summary>
        /// Search Threshold - Level 1 to Level 2 (s32)
        /// </summary>
        /// <remarks>
        /// Search enemy Lv1 → Lv2 threshold
        /// </remarks>
        public int SearchThresholdLevel1ToLevel2
        {
            get => (int)CellsByName["SearchThresholdLevel1ToLevel2"].Value;
            set => CellsByName["SearchThresholdLevel1ToLevel2"].Value = value;
        }


        // Def="f32 platoonReplyTime"
        /// <summary>
        /// Platoon - Reply Time (f32)
        /// </summary>
        /// <remarks>
        /// Platoon reaction delay time [sec]
        /// </remarks>
        public float PlatoonReplyTime
        {
            get => (float)CellsByName["PlatoonReplyTime"].Value;
            set => CellsByName["PlatoonReplyTime"].Value = value;
        }


        // Def="f32 platoonReplyAddRandomTime"
        /// <summary>
        /// Platoon - Reply Add Random Time (f32)
        /// </summary>
        /// <remarks>
        /// Platoon reaction additional random time [sec]
        /// </remarks>
        public float PlatoonReplyAddRandomTime
        {
            get => (float)CellsByName["PlatoonReplyAddRandomTime"].Value;
            set => CellsByName["PlatoonReplyAddRandomTime"].Value = value;
        }


        // Def="u8 searchEye_angX"
        /// <summary>
        /// Search Vision - Height Angle (u8)
        /// </summary>
        /// <remarks>
        /// Searching enemy vision_angle (height) [deg]
        /// </remarks>
        public byte SearchVisionHeightAngle
        {
            get => (byte)CellsByName["SearchVisionHeightAngle"].Value;
            set => CellsByName["SearchVisionHeightAngle"].Value = value;
        }


        // Def="u8 isUpdateBattleSight"
        /// <summary>
        /// Update Battle Vision (u8)
        /// </summary>
        /// <remarks>
        /// Do you want to overwrite the battle view?
        /// </remarks>
        public byte UpdateBattleVision
        {
            get => (byte)CellsByName["UpdateBattleVision"].Value;
            set => CellsByName["UpdateBattleVision"].Value = value;
        }


        // Def="u16 battleEye_updateDist"
        /// <summary>
        /// Battle Vision - Overwrite Distance (u16)
        /// </summary>
        /// <remarks>
        /// Battle Vision_Overwrite Distance [m]
        /// </remarks>
        public ushort BattleVisionOverwriteDistance
        {
            get => (ushort)CellsByName["BattleVisionOverwriteDistance"].Value;
            set => CellsByName["BattleVisionOverwriteDistance"].Value = value;
        }


        // Def="u8 battleEye_updateAngX"
        /// <summary>
        /// Battle Vision - Overwrite Height Angle (u8)
        /// </summary>
        /// <remarks>
        /// Battle Vision_Overwrite Angle (Height) [deg]
        /// </remarks>
        public byte BattleVisionOverwriteHeightAngle
        {
            get => (byte)CellsByName["BattleVisionOverwriteHeightAngle"].Value;
            set => CellsByName["BattleVisionOverwriteHeightAngle"].Value = value;
        }


        // Def="u8 battleEye_updateAngY"
        /// <summary>
        /// Battle Vision - Overwrite Width Angle (u8)
        /// </summary>
        /// <remarks>
        /// Battle Vision_Overwrite Angle (Width) [deg]
        /// </remarks>
        public byte BattleVisionOverwriteWidthAngle
        {
            get => (byte)CellsByName["BattleVisionOverwriteWidthAngle"].Value;
            set => CellsByName["BattleVisionOverwriteWidthAngle"].Value = value;
        }



        // Def="u16 eye_BackOffsetDist"
        /// <summary>
        /// Vision - Start Position - Backward Offset (u16)
        /// </summary>
        /// <remarks>
        /// The viewing angle start position is behind this distance from the center of the character.
        /// </remarks>
        public ushort VisionStartPositionBackwardOffset
        {
            get => (ushort)CellsByName["VisionStartPositionBackwardOffset"].Value;
            set => CellsByName["VisionStartPositionBackwardOffset"].Value = value;
        }


        // Def="u16 eye_BeginDist"
        /// <summary>
        /// Vision - Start Distance (u16)
        /// </summary>
        /// <remarks>
        /// This distance is not recognized from the viewing angle generation position
        /// </remarks>
        public ushort VisionStartDistance
        {
            get => (ushort)CellsByName["VisionStartDistance"].Value;
            set => CellsByName["VisionStartDistance"].Value = value;
        }


        // Def="u8 actTypeOnFailedPath"
        /// <summary>
        /// Act Type on Failed Path (u8)
        /// </summary>
        /// <remarks>
        /// Default action type to be performed when the path search fails, when the end point of the alternative path is reached / when the homecoming limit distance is reached
        /// </remarks>
        public byte ActTypeOnFailedPath
        {
            get => (byte)CellsByName["ActTypeOnFailedPath"].Value;
            set => CellsByName["ActTypeOnFailedPath"].Value = value;
        }


        // Def="u8 goalAction_ToCautionImportant"
        /// <summary>
        /// Goal Action - Target Alerted by Important Sound (u8)
        /// </summary>
        /// <remarks>
        /// Goal action: Target becomes alert due to detection of important sound
        /// </remarks>
        public byte GoalActionTargetAlertedByImportantSound
        {
            get => (byte)CellsByName["GoalActionTargetAlertedByImportantSound"].Value;
            set => CellsByName["GoalActionTargetAlertedByImportantSound"].Value = value;
        }


        // Def="s32 shiftAnimeId_RangedAttack = -1"
        /// <summary>
        /// Shift Animation ID on Ranged Attack (s32)
        /// </summary>
        /// <remarks>
        /// Reference ID for AI attack parameters
        /// </remarks>
        public int ShiftAnimationIDOnRangedAttack
        {
            get => (int)CellsByName["ShiftAnimationIDOnRangedAttack"].Value;
            set => CellsByName["ShiftAnimationIDOnRangedAttack"].Value = value;
        }


        // Def="u8 actTypeOnNonBtlFailedPath"
        /// <summary>
        /// Act Type on Non-BTL Failed Path (u8)
        /// </summary>
        /// <remarks>
        /// Target [None] Sometimes, the action to be taken after rewriting the current location to a nest
        /// </remarks>
        public byte ActTypeOnNonBTLFailedPath
        {
            get => (byte)CellsByName["ActTypeOnNonBTLFailedPath"].Value;
            set => CellsByName["ActTypeOnNonBTLFailedPath"].Value = value;
        }


        // Def="u8 isBuddyAI"
        /// <summary>
        /// Is Spirit Summon AI (u8)
        /// </summary>
        /// <remarks>
        /// Thinking for a buddy
        /// </remarks>
        public byte IsSpiritSummonAI
        {
            get => (byte)CellsByName["IsSpiritSummonAI"].Value;
            set => CellsByName["IsSpiritSummonAI"].Value = value;
        }


        // Def="u8 goalAction_ToSearchLv1"
        /// <summary>
        /// Goal Action - Target Search Level 1 (u8)
        /// </summary>
        /// <remarks>
        /// Goal action: Target becomes Lv1
        /// </remarks>
        public byte GoalActionTargetSearchLevel1
        {
            get => (byte)CellsByName["GoalActionTargetSearchLevel1"].Value;
            set => CellsByName["GoalActionTargetSearchLevel1"].Value = value;
        }


        // Def="u8 goalAction_ToSearchLv2"
        /// <summary>
        /// Goal Action - Target Search Level 2 (u8)
        /// </summary>
        /// <remarks>
        /// Goal action: Target became enemy Lv2
        /// </remarks>
        public byte GoalActionTargetSearchLevel2
        {
            get => (byte)CellsByName["GoalActionTargetSearchLevel2"].Value;
            set => CellsByName["GoalActionTargetSearchLevel2"].Value = value;
        }


        // Def="u8 enableJumpMove"
        /// <summary>
        /// Jump Move Type (u8)
        /// </summary>
        /// <remarks>
        /// Whether to jump over the user edge for jumping (non-combat state)
        /// </remarks>
        public byte JumpMoveType
        {
            get => (byte)CellsByName["JumpMoveType"].Value;
            set => CellsByName["JumpMoveType"].Value = value;
        }


        // Def="u8 disableLocalSteering"
        /// <summary>
        /// Disable Local Steering (u8)
        /// </summary>
        /// <remarks>
        /// Do you want to turn off the behavior (local steering) that tries to move while avoiding other characters?
        /// </remarks>
        public byte DisableLocalSteering
        {
            get => (byte)CellsByName["DisableLocalSteering"].Value;
            set => CellsByName["DisableLocalSteering"].Value = value;
        }


        // Def="u8 goalAction_ToDisappear"
        /// <summary>
        /// Goal Action - Target Lost (u8)
        /// </summary>
        /// <remarks>
        /// Goal action: Lost target
        /// </remarks>
        public byte GoalActionTargetLost
        {
            get => (byte)CellsByName["GoalActionTargetLost"].Value;
            set => CellsByName["GoalActionTargetLost"].Value = value;
        }


        // Def="u8 changeStateAction_ToNormal"
        /// <summary>
        /// Change State Action - To Normal (u8)
        /// </summary>
        /// <remarks>
        /// Action when transitioning to the normal state
        /// </remarks>
        public byte ChangeStateActionToNormal
        {
            get => (byte)CellsByName["ChangeStateActionToNormal"].Value;
            set => CellsByName["ChangeStateActionToNormal"].Value = value;
        }


        // Def="f32 MemoryTargetForgetTime = 150"
        /// <summary>
        /// Time to Forget Target (f32)
        /// </summary>
        /// <remarks>
        /// Time to forget the memory target.
        /// </remarks>
        public float TimeToForgetTarget
        {
            get => (float)CellsByName["TimeToForgetTarget"].Value;
            set => CellsByName["TimeToForgetTarget"].Value = value;
        }


        // Def="s32 rangedAttackId = -1"
        /// <summary>
        /// Attack ID - On Ranged Attack (s32)
        /// </summary>
        /// <remarks>
        /// A parameter that specifies the attack ID issued by the enemy when making a ranged attack
        /// </remarks>
        public int AttackIDOnRangedAttack
        {
            get => (int)CellsByName["AttackIDOnRangedAttack"].Value;
            set => CellsByName["AttackIDOnRangedAttack"].Value = value;
        }


        // Def="u8 useFall_onNormalCaution = 2"
        /// <summary>
        /// Use Fall Jump - Outside of Combat (u8)
        /// </summary>
        /// <remarks>
        /// Allows AI to pass the jumping edge in non-combat state
        /// </remarks>
        public byte UseFallJumpOutsideOfCombat
        {
            get => (byte)CellsByName["UseFallJumpOutsideOfCombat"].Value;
            set => CellsByName["UseFallJumpOutsideOfCombat"].Value = value;
        }


        // Def="u8 useFall_onSearchBattle = 2"
        /// <summary>
        /// Use Fall Jump - In Combat (u8)
        /// </summary>
        /// <remarks>
        /// Allow AI to pass through the jumping edge in combat
        /// </remarks>
        public byte UseFallJumpInCombat
        {
            get => (byte)CellsByName["UseFallJumpInCombat"].Value;
            set => CellsByName["UseFallJumpInCombat"].Value = value;
        }


        // Def="u8 enableJumpMove_onBattle"
        /// <summary>
        /// Enable Jump - In Combat (u8)
        /// </summary>
        /// <remarks>
        /// Whether to jump over the user edge for jumping (combat state)
        /// </remarks>
        public byte EnableJumpInCombat
        {
            get => (byte)CellsByName["EnableJumpInCombat"].Value;
            set => CellsByName["EnableJumpInCombat"].Value = value;
        }


        // Def="u8 backToHomeStuckAct"
        /// <summary>
        /// Back to Home Stuck Act (u8)
        /// </summary>
        /// <remarks>
        /// Behavior when addicted to the homecoming limit
        /// </remarks>
        public byte BackToHomeStuckAct
        {
            get => (byte)CellsByName["BackToHomeStuckAct"].Value;
            set => CellsByName["BackToHomeStuckAct"].Value = value;
        }



        // Def="s32 soundBehaviorId01 = -1"
        /// <summary>
        /// Sound Behavior ID [1] (s32)
        /// </summary>
        /// <remarks>
        /// Corresponds to the behavior ID of the sound target that can be heard
        /// </remarks>
        public int SoundBehaviorID1
        {
            get => (int)CellsByName["SoundBehaviorID1"].Value;
            set => CellsByName["SoundBehaviorID1"].Value = value;
        }


        // Def="s32 soundBehaviorId02 = -1"
        /// <summary>
        /// Sound Behavior ID [2] (s32)
        /// </summary>
        /// <remarks>
        /// Corresponds to the behavior ID of the sound target that can be heard
        /// </remarks>
        public int SoundBehaviorID2
        {
            get => (int)CellsByName["SoundBehaviorID2"].Value;
            set => CellsByName["SoundBehaviorID2"].Value = value;
        }


        // Def="s32 soundBehaviorId03 = -1"
        /// <summary>
        /// Sound Behavior ID [3] (s32)
        /// </summary>
        /// <remarks>
        /// Corresponds to the behavior ID of the sound target that can be heard
        /// </remarks>
        public int SoundBehaviorID3
        {
            get => (int)CellsByName["SoundBehaviorID3"].Value;
            set => CellsByName["SoundBehaviorID3"].Value = value;
        }


        // Def="s32 soundBehaviorId04 = -1"
        /// <summary>
        /// Sound Behavior ID [4] (s32)
        /// </summary>
        /// <remarks>
        /// Corresponds to the behavior ID of the sound target that can be heard
        /// </remarks>
        public int SoundBehaviorID4
        {
            get => (int)CellsByName["SoundBehaviorID4"].Value;
            set => CellsByName["SoundBehaviorID4"].Value = value;
        }


        // Def="s32 soundBehaviorId05 = -1"
        /// <summary>
        /// Sound Behavior ID [5] (s32)
        /// </summary>
        /// <remarks>
        /// Corresponds to the behavior ID of the sound target that can be heard
        /// </remarks>
        public int SoundBehaviorID5
        {
            get => (int)CellsByName["SoundBehaviorID5"].Value;
            set => CellsByName["SoundBehaviorID5"].Value = value;
        }


        // Def="s32 soundBehaviorId06 = -1"
        /// <summary>
        /// Sound Behavior ID [6] (s32)
        /// </summary>
        /// <remarks>
        /// Corresponds to the behavior ID of the sound target that can be heard
        /// </remarks>
        public int SoundBehaviorID6
        {
            get => (int)CellsByName["SoundBehaviorID6"].Value;
            set => CellsByName["SoundBehaviorID6"].Value = value;
        }


        // Def="s32 soundBehaviorId07 = -1"
        /// <summary>
        /// Sound Behavior ID [7] (s32)
        /// </summary>
        /// <remarks>
        /// Corresponds to the behavior ID of the sound target that can be heard
        /// </remarks>
        public int SoundBehaviorID7
        {
            get => (int)CellsByName["SoundBehaviorID7"].Value;
            set => CellsByName["SoundBehaviorID7"].Value = value;
        }


        // Def="s32 soundBehaviorId08 = -1"
        /// <summary>
        /// Sound Behavior ID [8] (s32)
        /// </summary>
        /// <remarks>
        /// Corresponds to the behavior ID of the sound target that can be heard
        /// </remarks>
        public int SoundBehaviorID8
        {
            get => (int)CellsByName["SoundBehaviorID8"].Value;
            set => CellsByName["SoundBehaviorID8"].Value = value;
        }


        // Def="s32 weaponOffSpecialEffectId = -1"
        /// <summary>
        /// Weapon Switch Out - SpEffect ID (s32)
        /// </summary>
        /// <remarks>
        /// Special effect ID at the time of sword delivery
        /// </remarks>
        public int WeaponSwitchOutSpEffectID
        {
            get => (int)CellsByName["WeaponSwitchOutSpEffectID"].Value;
            set => CellsByName["WeaponSwitchOutSpEffectID"].Value = value;
        }


        // Def="s32 weaponOnSpecialEffectId = -1"
        /// <summary>
        /// Weapon Switch In - SpEffect ID (s32)
        /// </summary>
        /// <remarks>
        /// Special effect ID when pulling out a sword
        /// </remarks>
        public int WeaponSwitchInSpEffectID
        {
            get => (int)CellsByName["WeaponSwitchInSpEffectID"].Value;
            set => CellsByName["WeaponSwitchInSpEffectID"].Value = value;
        }


        // Def="s32 weaponOffAnimId = -1"
        /// <summary>
        /// Weapon Switch Out - Animation ID (s32)
        /// </summary>
        /// <remarks>
        /// Katana Anime ID
        /// </remarks>
        public int WeaponSwitchOutAnimationID
        {
            get => (int)CellsByName["WeaponSwitchOutAnimationID"].Value;
            set => CellsByName["WeaponSwitchOutAnimationID"].Value = value;
        }


        // Def="s32 weaponOnAnimId = -1"
        /// <summary>
        /// Weapon Switch In - Animation ID (s32)
        /// </summary>
        /// <remarks>
        /// Sword animation ID
        /// </remarks>
        public int WeaponSwitchInAnimationID
        {
            get => (int)CellsByName["WeaponSwitchInAnimationID"].Value;
            set => CellsByName["WeaponSwitchInAnimationID"].Value = value;
        }


        // Def="s32 surpriseAnimId = -1"
        /// <summary>
        /// Stealth Attack - Animation ID (s32)
        /// </summary>
        /// <remarks>
        /// Amazing anime ID
        /// </remarks>
        public int StealthAttackAnimationID
        {
            get => (int)CellsByName["StealthAttackAnimationID"].Value;
            set => CellsByName["StealthAttackAnimationID"].Value = value;
        }

    }
}

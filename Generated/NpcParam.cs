
namespace StronglyTypedParams
{
    public class NpcParam : ParamRow
    {
        public NpcParam() : base()
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


        // Def="s32 behaviorVariationId"
        /// <summary>
        /// Behavior Variation ID (s32)
        /// </summary>
        /// <remarks>
        /// Variation ID used when calculating the action ID.
        /// </remarks>
        public int BehaviorVariationID
        {
            get => (int)CellsByName["BehaviorVariationID"].Value;
            set => CellsByName["BehaviorVariationID"].Value = value;
        }


        // Def="s32 resistCorrectId_poison = -1"
        /// <summary>
        /// Resist Correct: Poison (s32)
        /// </summary>
        /// <remarks>
        /// When the abnormal condition is activated, the maximum value is temporarily changed by using the set value of the abnormal condition resistance correction parameter.
        /// </remarks>
        public int ResistCorrectPoison
        {
            get => (int)CellsByName["ResistCorrectPoison"].Value;
            set => CellsByName["ResistCorrectPoison"].Value = value;
        }


        // Def="s32 nameId = -1"
        /// <summary>
        /// Name ID (s32)
        /// </summary>
        /// <remarks>
        /// NPC Name Message Parameter ID
        /// </remarks>
        public int NameID
        {
            get => (int)CellsByName["NameID"].Value;
            set => CellsByName["NameID"].Value = value;
        }


        // Def="f32 turnVellocity"
        /// <summary>
        /// Turn Velocity (f32)
        /// </summary>
        /// <remarks>
        /// Rotational speed [degrees / second] that can turn in 1 second.
        /// </remarks>
        public float TurnVelocity
        {
            get => (float)CellsByName["TurnVelocity"].Value;
            set => CellsByName["TurnVelocity"].Value = value;
        }


        // Def="f32 hitHeight"
        /// <summary>
        /// Capsule Height (f32)
        /// </summary>
        /// <remarks>
        /// The height of the capsule per character.
        /// </remarks>
        public float CapsuleHeight
        {
            get => (float)CellsByName["CapsuleHeight"].Value;
            set => CellsByName["CapsuleHeight"].Value = value;
        }


        // Def="f32 hitRadius"
        /// <summary>
        /// Capsule Radius (f32)
        /// </summary>
        /// <remarks>
        /// Radius of capsule per character.
        /// </remarks>
        public float CapsuleRadius
        {
            get => (float)CellsByName["CapsuleRadius"].Value;
            set => CellsByName["CapsuleRadius"].Value = value;
        }


        // Def="u32 weight"
        /// <summary>
        /// Weight (u32)
        /// </summary>
        /// <remarks>
        /// weight.
        /// </remarks>
        public uint Weight
        {
            get => (uint)CellsByName["Weight"].Value;
            set => CellsByName["Weight"].Value = value;
        }


        // Def="f32 hitYOffset"
        /// <summary>
        /// Display Position - Height Offset (f32)
        /// </summary>
        /// <remarks>
        /// Offset of the model display position in the Y (height) direction. It can be floated from the hit position.
        /// </remarks>
        public float DisplayPositionHeightOffset
        {
            get => (float)CellsByName["DisplayPositionHeightOffset"].Value;
            set => CellsByName["DisplayPositionHeightOffset"].Value = value;
        }


        // Def="u32 hp"
        /// <summary>
        /// Base HP (u32)
        /// </summary>
        /// <remarks>
        /// Death grace.
        /// </remarks>
        public uint BaseHP
        {
            get => (uint)CellsByName["BaseHP"].Value;
            set => CellsByName["BaseHP"].Value = value;
        }


        // Def="u32 mp"
        /// <summary>
        /// Base FP (u32)
        /// </summary>
        /// <remarks>
        /// Magic usage.
        /// </remarks>
        public uint BaseFP
        {
            get => (uint)CellsByName["BaseFP"].Value;
            set => CellsByName["BaseFP"].Value = value;
        }


        // Def="u32 getSoul"
        /// <summary>
        /// Base Runes (u32)
        /// </summary>
        /// <remarks>
        /// The amount of soul that a character can get at the time of death.
        /// </remarks>
        public uint BaseRunes
        {
            get => (uint)CellsByName["BaseRunes"].Value;
            set => CellsByName["BaseRunes"].Value = value;
        }


        // Def="s32 itemLotId_enemy = -1"
        /// <summary>
        /// Enemy Itemlot ID (s32)
        /// </summary>
        /// <remarks>
        /// Specify the lottery ID_for enemies of the item to be acquired at the time of death. Please set only one of them.
        /// </remarks>
        public int EnemyItemlotID
        {
            get => (int)CellsByName["EnemyItemlotID"].Value;
            set => CellsByName["EnemyItemlotID"].Value = value;
        }


        // Def="s32 itemLotId_map = -1"
        /// <summary>
        /// Map Itemlot ID (s32)
        /// </summary>
        /// <remarks>
        /// Specify for the lottery ID_map of the item to be acquired at the time of death. Please set only one of them.
        /// </remarks>
        public int MapItemlotID
        {
            get => (int)CellsByName["MapItemlotID"].Value;
            set => CellsByName["MapItemlotID"].Value = value;
        }


        // Def="f32 maxAnkleRollAngle = -1"
        /// <summary>
        /// FootIK Ankle Roll Angle Limit (f32)
        /// </summary>
        /// <remarks>
        /// FootIK Ankle roll limit angle (-1: no limit)
        /// </remarks>
        public float FootIKAnkleRollAngleLimit
        {
            get => (float)CellsByName["FootIKAnkleRollAngleLimit"].Value;
            set => CellsByName["FootIKAnkleRollAngleLimit"].Value = value;
        }


        // Def="u8 chrHitGroupAndNavimesh"
        /// <summary>
        /// Chr Hit Judgment (u8)
        /// </summary>
        /// <remarks>
        /// Set the hit judgment with other characters (If you hit the ragdoll, other characters will hit the ragdoll)
        /// </remarks>
        public byte ChrHitJudgment
        {
            get => (byte)CellsByName["ChrHitJudgment"].Value;
            set => CellsByName["ChrHitJudgment"].Value = value;
        }


        // Def="u8 faceIconId"
        /// <summary>
        /// Face Icon ID (u8)
        /// </summary>
        /// <remarks>
        /// NPC face image ID (0: invalid value (default)). Specify the ID of the face image to be displayed in the "Sign browsing menu", "Kick menu", etc. If it is an invalid value, the dress-up model is displayed.
        /// </remarks>
        public byte FaceIconID
        {
            get => (byte)CellsByName["FaceIconID"].Value;
            set => CellsByName["FaceIconID"].Value = value;
        }


        // Def="s16 deactivateDist = -1"
        /// <summary>
        /// Deactivation Distance (s16)
        /// </summary>
        /// <remarks>
        /// Distance at which the character is deactivated (valid only for open placement characters)
        /// </remarks>
        public short DeactivationDistance
        {
            get => (short)CellsByName["DeactivationDistance"].Value;
            set => CellsByName["DeactivationDistance"].Value = value;
        }


        // Def="u32 chrActivateConditionParamId"
        /// <summary>
        /// Chr Activate Condition Param ID (u32)
        /// </summary>
        /// <remarks>
        /// Character appearance condition parameter ID
        /// </remarks>
        public uint ChrActivateConditionParamID
        {
            get => (uint)CellsByName["ChrActivateConditionParamID"].Value;
            set => CellsByName["ChrActivateConditionParamID"].Value = value;
        }


        // Def="f32 footIkErrorHeightLimit"
        /// <summary>
        /// Foot IK Apperance Height Limit (f32)
        /// </summary>
        /// <remarks>
        /// FootIK Appearance up / down limit
        /// </remarks>
        public float FootIKApperanceHeightLimit
        {
            get => (float)CellsByName["FootIKApperanceHeightLimit"].Value;
            set => CellsByName["FootIKApperanceHeightLimit"].Value = value;
        }


        // Def="s32 humanityLotId = -1"
        /// <summary>
        /// Humanity Lot ID (s32)
        /// </summary>
        /// <remarks>
        /// Specify the lottery ID of human nature to be acquired at the time of death
        /// </remarks>
        public int HumanityLotID
        {
            get => (int)CellsByName["HumanityLotID"].Value;
            set => CellsByName["HumanityLotID"].Value = value;
        }


        // Def="s32 spEffectID0 = -1"
        /// <summary>
        /// SpEffect ID [0] (s32)
        /// </summary>
        /// <remarks>
        /// Resident special effect 0
        /// </remarks>
        public int SpEffectID0
        {
            get => (int)CellsByName["SpEffectID0"].Value;
            set => CellsByName["SpEffectID0"].Value = value;
        }


        // Def="s32 spEffectID1 = -1"
        /// <summary>
        /// SpEffect ID [1] (s32)
        /// </summary>
        /// <remarks>
        /// Resident special effect 1
        /// </remarks>
        public int SpEffectID1
        {
            get => (int)CellsByName["SpEffectID1"].Value;
            set => CellsByName["SpEffectID1"].Value = value;
        }


        // Def="s32 spEffectID2 = -1"
        /// <summary>
        /// SpEffect ID [2] (s32)
        /// </summary>
        /// <remarks>
        /// Resident special effect 2
        /// </remarks>
        public int SpEffectID2
        {
            get => (int)CellsByName["SpEffectID2"].Value;
            set => CellsByName["SpEffectID2"].Value = value;
        }


        // Def="s32 spEffectID3 = -1"
        /// <summary>
        /// SpEffect ID [3] (s32)
        /// </summary>
        /// <remarks>
        /// Resident special effect 3
        /// </remarks>
        public int SpEffectID3
        {
            get => (int)CellsByName["SpEffectID3"].Value;
            set => CellsByName["SpEffectID3"].Value = value;
        }


        // Def="s32 spEffectID4 = -1"
        /// <summary>
        /// SpEffect ID [4] (s32)
        /// </summary>
        /// <remarks>
        /// Resident special effect 4
        /// </remarks>
        public int SpEffectID4
        {
            get => (int)CellsByName["SpEffectID4"].Value;
            set => CellsByName["SpEffectID4"].Value = value;
        }


        // Def="s32 spEffectID5 = -1"
        /// <summary>
        /// SpEffect ID [5] (s32)
        /// </summary>
        /// <remarks>
        /// Resident special effect 5
        /// </remarks>
        public int SpEffectID5
        {
            get => (int)CellsByName["SpEffectID5"].Value;
            set => CellsByName["SpEffectID5"].Value = value;
        }


        // Def="s32 spEffectID6 = -1"
        /// <summary>
        /// SpEffect ID [6] (s32)
        /// </summary>
        /// <remarks>
        /// Resident special effect 6
        /// </remarks>
        public int SpEffectID6
        {
            get => (int)CellsByName["SpEffectID6"].Value;
            set => CellsByName["SpEffectID6"].Value = value;
        }


        // Def="s32 spEffectID7 = -1"
        /// <summary>
        /// SpEffect ID [7] (s32)
        /// </summary>
        /// <remarks>
        /// Resident special effect 7
        /// </remarks>
        public int SpEffectID7
        {
            get => (int)CellsByName["SpEffectID7"].Value;
            set => CellsByName["SpEffectID7"].Value = value;
        }


        // Def="s32 GameClearSpEffectID = -1"
        /// <summary>
        /// Game Clear - SpEffect ID (s32)
        /// </summary>
        /// <remarks>
        /// Special effect ID for lap bonus
        /// </remarks>
        public int GameClearSpEffectID
        {
            get => (int)CellsByName["GameClearSpEffectID"].Value;
            set => CellsByName["GameClearSpEffectID"].Value = value;
        }


        // Def="f32 physGuardCutRate"
        /// <summary>
        /// Guard Absorption %: Physical (f32)
        /// </summary>
        /// <remarks>
        /// Set the damage cut rate when guarding for each attack
        /// </remarks>
        public float GuardAbsorptionPercentPhysical
        {
            get => (float)CellsByName["GuardAbsorptionPercentPhysical"].Value;
            set => CellsByName["GuardAbsorptionPercentPhysical"].Value = value;
        }


        // Def="f32 magGuardCutRate"
        /// <summary>
        /// Guard Absorption %: Magic (f32)
        /// </summary>
        /// <remarks>
        /// If it is not a guard attack, enter 0
        /// </remarks>
        public float GuardAbsorptionPercentMagic
        {
            get => (float)CellsByName["GuardAbsorptionPercentMagic"].Value;
            set => CellsByName["GuardAbsorptionPercentMagic"].Value = value;
        }


        // Def="f32 fireGuardCutRate"
        /// <summary>
        /// Guard Absorption %: Fire (f32)
        /// </summary>
        /// <remarks>
        /// How much to cut the fire attack?
        /// </remarks>
        public float GuardAbsorptionPercentFire
        {
            get => (float)CellsByName["GuardAbsorptionPercentFire"].Value;
            set => CellsByName["GuardAbsorptionPercentFire"].Value = value;
        }


        // Def="f32 thunGuardCutRate"
        /// <summary>
        /// Guard Absorption %: Lightning (f32)
        /// </summary>
        /// <remarks>
        /// How much to cut the electric shock attack?
        /// </remarks>
        public float GuardAbsorptionPercentLightning
        {
            get => (float)CellsByName["GuardAbsorptionPercentLightning"].Value;
            set => CellsByName["GuardAbsorptionPercentLightning"].Value = value;
        }


        // Def="s32 animIdOffset"
        /// <summary>
        /// Anim ID Offset [1] (s32)
        /// </summary>
        /// <remarks>
        /// All animations will be played with IDs shifted by this number. If not, the original anime ID is referenced.
        /// </remarks>
        public int AnimIDOffset1
        {
            get => (int)CellsByName["AnimIDOffset1"].Value;
            set => CellsByName["AnimIDOffset1"].Value = value;
        }


        // Def="s16 lockGazePoint0 = -1"
        /// <summary>
        /// Lock Gaze Point - Dummy Poly ID [0] (s16)
        /// </summary>
        /// <remarks>
        /// Gaze at the Damipoli specified when locking the Lock-on Damipoly 22X (-1: Invalid)
        /// </remarks>
        public short LockGazePointDummyPolyID0
        {
            get => (short)CellsByName["LockGazePointDummyPolyID0"].Value;
            set => CellsByName["LockGazePointDummyPolyID0"].Value = value;
        }


        // Def="s16 lockGazePoint1 = -1"
        /// <summary>
        /// Lock Gaze Point - Dummy Poly ID [1] (s16)
        /// </summary>
        /// <remarks>
        /// Gaze at the Damipoli specified when locking the Lock-on Damipoly 22X (-1: Invalid)
        /// </remarks>
        public short LockGazePointDummyPolyID1
        {
            get => (short)CellsByName["LockGazePointDummyPolyID1"].Value;
            set => CellsByName["LockGazePointDummyPolyID1"].Value = value;
        }


        // Def="s16 lockGazePoint2 = -1"
        /// <summary>
        /// Lock Gaze Point - Dummy Poly ID [2] (s16)
        /// </summary>
        /// <remarks>
        /// Gaze at the Damipoli specified when locking the Lock-on Damipoly 22X (-1: Invalid)
        /// </remarks>
        public short LockGazePointDummyPolyID2
        {
            get => (short)CellsByName["LockGazePointDummyPolyID2"].Value;
            set => CellsByName["LockGazePointDummyPolyID2"].Value = value;
        }


        // Def="s16 lockGazePoint3 = -1"
        /// <summary>
        /// Lock Gaze Point - Dummy Poly ID [3] (s16)
        /// </summary>
        /// <remarks>
        /// Gaze at the Damipoli specified when locking the Lock-on Damipoly 22X (-1: Invalid)
        /// </remarks>
        public short LockGazePointDummyPolyID3
        {
            get => (short)CellsByName["LockGazePointDummyPolyID3"].Value;
            set => CellsByName["LockGazePointDummyPolyID3"].Value = value;
        }


        // Def="s16 lockGazePoint4 = -1"
        /// <summary>
        /// Lock Gaze Point - Dummy Poly ID [4] (s16)
        /// </summary>
        /// <remarks>
        /// Gaze at the Damipoli specified when locking the Lock-on Damipoly 22X (-1: Invalid)
        /// </remarks>
        public short LockGazePointDummyPolyID4
        {
            get => (short)CellsByName["LockGazePointDummyPolyID4"].Value;
            set => CellsByName["LockGazePointDummyPolyID4"].Value = value;
        }


        // Def="s16 lockGazePoint5 = -1"
        /// <summary>
        /// Lock Gaze Point - Dummy Poly ID [5] (s16)
        /// </summary>
        /// <remarks>
        /// Gaze at the Damipoli specified when locking the Lock-on Damipoly 22X (-1: Invalid)
        /// </remarks>
        public short LockGazePointDummyPolyID5
        {
            get => (short)CellsByName["LockGazePointDummyPolyID5"].Value;
            set => CellsByName["LockGazePointDummyPolyID5"].Value = value;
        }


        // Def="f32 networkWarpDist"
        /// <summary>
        /// Network Warp Display (f32)
        /// </summary>
        /// <remarks>
        /// Distance to warp instead of complementary movement in network synchronization. Faster people (ex dragons) need to be longer.
        /// </remarks>
        public float NetworkWarpDisplay
        {
            get => (float)CellsByName["NetworkWarpDisplay"].Value;
            set => CellsByName["NetworkWarpDisplay"].Value = value;
        }


        // Def="s32 dbgBehaviorR1 = -1"
        /// <summary>
        /// Debug Action - R1 (s32)
        /// </summary>
        /// <remarks>
        /// Register the ID from the action parameter tool and specify the action.
        /// </remarks>
        public int DebugActionR1
        {
            get => (int)CellsByName["DebugActionR1"].Value;
            set => CellsByName["DebugActionR1"].Value = value;
        }


        // Def="s32 dbgBehaviorL1 = -1"
        /// <summary>
        /// Debug Action - L1 (s32)
        /// </summary>
        /// <remarks>
        /// Register the ID from the action parameter tool and specify the action.
        /// </remarks>
        public int DebugActionL1
        {
            get => (int)CellsByName["DebugActionL1"].Value;
            set => CellsByName["DebugActionL1"].Value = value;
        }


        // Def="s32 dbgBehaviorR2 = -1"
        /// <summary>
        /// Debug Action - R2 (s32)
        /// </summary>
        /// <remarks>
        /// Register the ID from the action parameter tool and specify the action.
        /// </remarks>
        public int DebugActionR2
        {
            get => (int)CellsByName["DebugActionR2"].Value;
            set => CellsByName["DebugActionR2"].Value = value;
        }


        // Def="s32 dbgBehaviorL2 = -1"
        /// <summary>
        /// Debug Action - L2 (s32)
        /// </summary>
        /// <remarks>
        /// Register the ID from the action parameter tool and specify the action.
        /// </remarks>
        public int DebugActionL2
        {
            get => (int)CellsByName["DebugActionL2"].Value;
            set => CellsByName["DebugActionL2"].Value = value;
        }


        // Def="s32 dbgBehaviorRL = -1"
        /// <summary>
        /// Debug Action - Square (s32)
        /// </summary>
        /// <remarks>
        /// Register the ID from the action parameter tool and specify the action.
        /// </remarks>
        public int DebugActionSquare
        {
            get => (int)CellsByName["DebugActionSquare"].Value;
            set => CellsByName["DebugActionSquare"].Value = value;
        }


        // Def="s32 dbgBehaviorRR = -1"
        /// <summary>
        /// Debug Action - Circle (s32)
        /// </summary>
        /// <remarks>
        /// Register the ID from the action parameter tool and specify the action.
        /// </remarks>
        public int DebugActionCircle
        {
            get => (int)CellsByName["DebugActionCircle"].Value;
            set => CellsByName["DebugActionCircle"].Value = value;
        }


        // Def="s32 dbgBehaviorRD = -1"
        /// <summary>
        /// Debug Action - Cross (s32)
        /// </summary>
        /// <remarks>
        /// Register the ID from the action parameter tool and specify the action.
        /// </remarks>
        public int DebugActionCross
        {
            get => (int)CellsByName["DebugActionCross"].Value;
            set => CellsByName["DebugActionCross"].Value = value;
        }


        // Def="s32 dbgBehaviorRU = -1"
        /// <summary>
        /// Debug Action - Triangle (s32)
        /// </summary>
        /// <remarks>
        /// Register the ID from the action parameter tool and specify the action.
        /// </remarks>
        public int DebugActionTriangle
        {
            get => (int)CellsByName["DebugActionTriangle"].Value;
            set => CellsByName["DebugActionTriangle"].Value = value;
        }


        // Def="s32 dbgBehaviorLL = -1"
        /// <summary>
        /// Debug Action - Left D-Pad (s32)
        /// </summary>
        /// <remarks>
        /// Register the ID from the action parameter tool and specify the action.
        /// </remarks>
        public int DebugActionLeftDPad
        {
            get => (int)CellsByName["DebugActionLeftDPad"].Value;
            set => CellsByName["DebugActionLeftDPad"].Value = value;
        }


        // Def="s32 dbgBehaviorLR = -1"
        /// <summary>
        /// Debug Action - Right D-Pad (s32)
        /// </summary>
        /// <remarks>
        /// Register the ID from the action parameter tool and specify the action.
        /// </remarks>
        public int DebugActionRightDPad
        {
            get => (int)CellsByName["DebugActionRightDPad"].Value;
            set => CellsByName["DebugActionRightDPad"].Value = value;
        }


        // Def="s32 dbgBehaviorLD = -1"
        /// <summary>
        /// Debug Action - Down D-Pad (s32)
        /// </summary>
        /// <remarks>
        /// Register the ID from the action parameter tool and specify the action.
        /// </remarks>
        public int DebugActionDownDPad
        {
            get => (int)CellsByName["DebugActionDownDPad"].Value;
            set => CellsByName["DebugActionDownDPad"].Value = value;
        }


        // Def="s32 dbgBehaviorLU = -1"
        /// <summary>
        /// Debug Action - Up D-Pad (s32)
        /// </summary>
        /// <remarks>
        /// Register the ID from the action parameter tool and specify the action.
        /// </remarks>
        public int DebugActionUpDPad
        {
            get => (int)CellsByName["DebugActionUpDPad"].Value;
            set => CellsByName["DebugActionUpDPad"].Value = value;
        }


        // Def="s32 animIdOffset2"
        /// <summary>
        /// Anim ID Offset [2] (s32)
        /// </summary>
        /// <remarks>
        /// All animations will be played with IDs shifted by this number. If not, the animation ID of the animation ID offset 1 is referred to.
        /// </remarks>
        public int AnimIDOffset2
        {
            get => (int)CellsByName["AnimIDOffset2"].Value;
            set => CellsByName["AnimIDOffset2"].Value = value;
        }


        // Def="f32 partsDamageRate1 = 1"
        /// <summary>
        /// Damage %: Part [1] (f32)
        /// </summary>
        /// <remarks>
        /// Magnification that adapts to damage processing for part 1
        /// </remarks>
        public float DamagePercentPart1
        {
            get => (float)CellsByName["DamagePercentPart1"].Value;
            set => CellsByName["DamagePercentPart1"].Value = value;
        }


        // Def="f32 partsDamageRate2 = 1"
        /// <summary>
        /// Damage %: Part [2] (f32)
        /// </summary>
        /// <remarks>
        /// Magnification that adapts to damage processing for part 2
        /// </remarks>
        public float DamagePercentPart2
        {
            get => (float)CellsByName["DamagePercentPart2"].Value;
            set => CellsByName["DamagePercentPart2"].Value = value;
        }


        // Def="f32 partsDamageRate3 = 1"
        /// <summary>
        /// Damage %: Part [3] (f32)
        /// </summary>
        /// <remarks>
        /// Magnification that adapts to damage processing for part 3
        /// </remarks>
        public float DamagePercentPart3
        {
            get => (float)CellsByName["DamagePercentPart3"].Value;
            set => CellsByName["DamagePercentPart3"].Value = value;
        }


        // Def="f32 partsDamageRate4 = 1"
        /// <summary>
        /// Damage %: Part [4] (f32)
        /// </summary>
        /// <remarks>
        /// Magnification that adapts to damage processing for part 4
        /// </remarks>
        public float DamagePercentPart4
        {
            get => (float)CellsByName["DamagePercentPart4"].Value;
            set => CellsByName["DamagePercentPart4"].Value = value;
        }


        // Def="f32 partsDamageRate5 = 1"
        /// <summary>
        /// Damage %: Part [5] (f32)
        /// </summary>
        /// <remarks>
        /// Magnification that adapts to damage processing for part 5
        /// </remarks>
        public float DamagePercentPart5
        {
            get => (float)CellsByName["DamagePercentPart5"].Value;
            set => CellsByName["DamagePercentPart5"].Value = value;
        }


        // Def="f32 partsDamageRate6 = 1"
        /// <summary>
        /// Damage %: Part [6] (f32)
        /// </summary>
        /// <remarks>
        /// Magnification to adapt to damage processing for part 6
        /// </remarks>
        public float DamagePercentPart6
        {
            get => (float)CellsByName["DamagePercentPart6"].Value;
            set => CellsByName["DamagePercentPart6"].Value = value;
        }


        // Def="f32 partsDamageRate7 = 1"
        /// <summary>
        /// Damage %: Part [7] (f32)
        /// </summary>
        /// <remarks>
        /// Magnification that adapts to damage processing for part 7
        /// </remarks>
        public float DamagePercentPart7
        {
            get => (float)CellsByName["DamagePercentPart7"].Value;
            set => CellsByName["DamagePercentPart7"].Value = value;
        }


        // Def="f32 partsDamageRate8 = 1"
        /// <summary>
        /// Damage %: Part [8] (f32)
        /// </summary>
        /// <remarks>
        /// Magnification that adapts to damage processing for part 8
        /// </remarks>
        public float DamagePercentPart8
        {
            get => (float)CellsByName["DamagePercentPart8"].Value;
            set => CellsByName["DamagePercentPart8"].Value = value;
        }


        // Def="f32 weakPartsDamageRate = 1"
        /// <summary>
        /// Damage %: Weak Part (f32)
        /// </summary>
        /// <remarks>
        /// Magnification that adapts to damage processing for weak points
        /// </remarks>
        public float DamagePercentWeakPart
        {
            get => (float)CellsByName["DamagePercentWeakPart"].Value;
            set => CellsByName["DamagePercentWeakPart"].Value = value;
        }


        // Def="f32 superArmorRecoverCorrection"
        /// <summary>
        /// Poise Recovery Correction (f32)
        /// </summary>
        /// <remarks>
        /// Correction value for super armor recovery time
        /// </remarks>
        public float PoiseRecoveryCorrection
        {
            get => (float)CellsByName["PoiseRecoveryCorrection"].Value;
            set => CellsByName["PoiseRecoveryCorrection"].Value = value;
        }


        // Def="f32 superArmorBrakeKnockbackDist"
        /// <summary>
        /// Poise Knockback Distance (f32)
        /// </summary>
        /// <remarks>
        /// Knockback distance that can be used only at the time of SA break
        /// </remarks>
        public float PoiseKnockbackDistance
        {
            get => (float)CellsByName["PoiseKnockbackDistance"].Value;
            set => CellsByName["PoiseKnockbackDistance"].Value = value;
        }


        // Def="u16 stamina"
        /// <summary>
        /// Stamina (u16)
        /// </summary>
        /// <remarks>
        /// Total amount of stamina.
        /// </remarks>
        public ushort Stamina
        {
            get => (ushort)CellsByName["Stamina"].Value;
            set => CellsByName["Stamina"].Value = value;
        }


        // Def="u16 staminaRecoverBaseVel"
        /// <summary>
        /// Stamina Recovery (u16)
        /// </summary>
        /// <remarks>
        /// Stamina recovery basic speed [point / s]
        /// </remarks>
        public ushort StaminaRecovery
        {
            get => (ushort)CellsByName["StaminaRecovery"].Value;
            set => CellsByName["StaminaRecovery"].Value = value;
        }


        // Def="u16 def_phys"
        /// <summary>
        /// Defence: Physical (u16)
        /// </summary>
        /// <remarks>
        /// Damage reduction base value for physical attacks.
        /// </remarks>
        public ushort DefencePhysical
        {
            get => (ushort)CellsByName["DefencePhysical"].Value;
            set => CellsByName["DefencePhysical"].Value = value;
        }


        // Def="s16 def_slash"
        /// <summary>
        /// Defence: Slash (s16)
        /// </summary>
        /// <remarks>
        /// Look at the attack attribute, and if it is a slash attribute, reduce the defense power.
        /// </remarks>
        public short DefenceSlash
        {
            get => (short)CellsByName["DefenceSlash"].Value;
            set => CellsByName["DefenceSlash"].Value = value;
        }


        // Def="s16 def_blow"
        /// <summary>
        /// Defence: Strike (s16)
        /// </summary>
        /// <remarks>
        /// Look at the attack attribute, and if it is a hit attribute, reduce the defense power.
        /// </remarks>
        public short DefenceStrike
        {
            get => (short)CellsByName["DefenceStrike"].Value;
            set => CellsByName["DefenceStrike"].Value = value;
        }


        // Def="s16 def_thrust"
        /// <summary>
        /// Defence: Thrust (s16)
        /// </summary>
        /// <remarks>
        /// Look at the attack attribute, and if it is a piercing attribute, reduce the defense power.
        /// </remarks>
        public short DefenceThrust
        {
            get => (short)CellsByName["DefenceThrust"].Value;
            set => CellsByName["DefenceThrust"].Value = value;
        }


        // Def="u16 def_mag"
        /// <summary>
        /// Defence: Magic (u16)
        /// </summary>
        /// <remarks>
        /// Damage reduction base value for magic attacks.
        /// </remarks>
        public ushort DefenceMagic
        {
            get => (ushort)CellsByName["DefenceMagic"].Value;
            set => CellsByName["DefenceMagic"].Value = value;
        }


        // Def="u16 def_fire"
        /// <summary>
        /// Defence: Fire (u16)
        /// </summary>
        /// <remarks>
        /// Damage reduction base value against fire attack.
        /// </remarks>
        public ushort DefenceFire
        {
            get => (ushort)CellsByName["DefenceFire"].Value;
            set => CellsByName["DefenceFire"].Value = value;
        }


        // Def="u16 def_thunder"
        /// <summary>
        /// Defence: Lightning (u16)
        /// </summary>
        /// <remarks>
        /// Damage reduction base value against electric shock attack.
        /// </remarks>
        public ushort DefenceLightning
        {
            get => (ushort)CellsByName["DefenceLightning"].Value;
            set => CellsByName["DefenceLightning"].Value = value;
        }


        // Def="u16 defFlickPower"
        /// <summary>
        /// Weapon Repel Power (u16)
        /// </summary>
        /// <remarks>
        /// Used to determine the repelling of enemy attacks. // It is intended to be repelled by normal attacks other than guards. // Enemies with a hard skin can be repelled without doing anything ... It doesn't matter if it is a normal enemy.
        /// </remarks>
        public ushort WeaponRepelPower
        {
            get => (ushort)CellsByName["WeaponRepelPower"].Value;
            set => CellsByName["WeaponRepelPower"].Value = value;
        }


        // Def="u16 resist_poison"
        /// <summary>
        /// Resist: Poison (u16)
        /// </summary>
        /// <remarks>
        /// Difficulty in getting poisonous
        /// </remarks>
        public ushort ResistPoison
        {
            get => (ushort)CellsByName["ResistPoison"].Value;
            set => CellsByName["ResistPoison"].Value = value;
        }


        // Def="u16 resist_desease"
        /// <summary>
        /// Resist: Scarlet Rot (u16)
        /// </summary>
        /// <remarks>
        /// Difficulty in getting sick
        /// </remarks>
        public ushort ResistScarletRot
        {
            get => (ushort)CellsByName["ResistScarletRot"].Value;
            set => CellsByName["ResistScarletRot"].Value = value;
        }


        // Def="u16 resist_blood"
        /// <summary>
        /// Resist: Hemorrhage (u16)
        /// </summary>
        /// <remarks>
        /// Difficulty in getting bleeding abnormalities
        /// </remarks>
        public ushort ResistHemorrhage
        {
            get => (ushort)CellsByName["ResistHemorrhage"].Value;
            set => CellsByName["ResistHemorrhage"].Value = value;
        }


        // Def="u16 resist_curse"
        /// <summary>
        /// Resist: Blight (u16)
        /// </summary>
        /// <remarks>
        /// Difficulty in dealing with abnormal curse conditions
        /// </remarks>
        public ushort ResistBlight
        {
            get => (ushort)CellsByName["ResistBlight"].Value;
            set => CellsByName["ResistBlight"].Value = value;
        }


        // Def="s16 ghostModelId = -1"
        /// <summary>
        /// Ghost Model ID (s16)
        /// </summary>
        /// <remarks>
        /// Replacement model when wandering ghost, texture ID
        /// </remarks>
        public short GhostModelID
        {
            get => (short)CellsByName["GhostModelID"].Value;
            set => CellsByName["GhostModelID"].Value = value;
        }


        // Def="s16 normalChangeResouceId = -1"
        /// <summary>
        /// Override Resource Chr ID (s16)
        /// </summary>
        /// <remarks>
        /// Replace resource ID during normal operation (do not use it unnecessarily)
        /// </remarks>
        public short OverrideResourceChrID
        {
            get => (short)CellsByName["OverrideResourceChrID"].Value;
            set => CellsByName["OverrideResourceChrID"].Value = value;
        }


        // Def="s16 guardAngle"
        /// <summary>
        /// Guard Angle (s16)
        /// </summary>
        /// <remarks>
        /// Defense range angle when guarding weapons. Pending
        /// </remarks>
        public short GuardAngle
        {
            get => (short)CellsByName["GuardAngle"].Value;
            set => CellsByName["GuardAngle"].Value = value;
        }


        // Def="s16 slashGuardCutRate"
        /// <summary>
        /// Guard Absorption %: Slash (s16)
        /// </summary>
        /// <remarks>
        /// Looking at the attack type, what percentage of the damage of the slashing attribute is cut? Specify
        /// </remarks>
        public short GuardAbsorptionPercentSlash
        {
            get => (short)CellsByName["GuardAbsorptionPercentSlash"].Value;
            set => CellsByName["GuardAbsorptionPercentSlash"].Value = value;
        }


        // Def="s16 blowGuardCutRate"
        /// <summary>
        /// Guard Absorption %: Strike (s16)
        /// </summary>
        /// <remarks>
        /// Looking at the attack type, what percentage of the damage of the hit attribute is cut? Specify
        /// </remarks>
        public short GuardAbsorptionPercentStrike
        {
            get => (short)CellsByName["GuardAbsorptionPercentStrike"].Value;
            set => CellsByName["GuardAbsorptionPercentStrike"].Value = value;
        }


        // Def="s16 thrustGuardCutRate"
        /// <summary>
        /// Guard Absorption %: Thrust (s16)
        /// </summary>
        /// <remarks>
        /// Looking at the attack type, what percentage of the damage of the piercing attribute is cut? Specify
        /// </remarks>
        public short GuardAbsorptionPercentThrust
        {
            get => (short)CellsByName["GuardAbsorptionPercentThrust"].Value;
            set => CellsByName["GuardAbsorptionPercentThrust"].Value = value;
        }


        // Def="s16 lockGazePoint6 = -1"
        /// <summary>
        /// Lock Gaze Point - Dummy Poly [6] (s16)
        /// </summary>
        /// <remarks>
        /// Gaze at the Damipoli specified when locking the Lock-on Damipoly 22X (-1: Invalid)
        /// </remarks>
        public short LockGazePointDummyPoly6
        {
            get => (short)CellsByName["LockGazePointDummyPoly6"].Value;
            set => CellsByName["LockGazePointDummyPoly6"].Value = value;
        }


        // Def="s16 normalChangeTexChrId = -1"
        /// <summary>
        /// Override Texture Chr ID (s16)
        /// </summary>
        /// <remarks>
        /// Normal replacement texture character ID (do not use it unnecessarily)
        /// </remarks>
        public short OverrideTextureChrID
        {
            get => (short)CellsByName["OverrideTextureChrID"].Value;
            set => CellsByName["OverrideTextureChrID"].Value = value;
        }


        // Def="u16 dropType"
        /// <summary>
        /// Drop Type (u16)
        /// </summary>
        /// <remarks>
        /// Display method when dropping an item (corpse emission or item display)
        /// </remarks>
        public ushort DropType
        {
            get => (ushort)CellsByName["DropType"].Value;
            set => CellsByName["DropType"].Value = value;
        }


        // Def="u8 knockbackRate"
        /// <summary>
        /// Received Knockback % (u8)
        /// </summary>
        /// <remarks>
        /// Decrease value when receiving knockback damage / Specifically, cut the initial knockback speed of the attacking side
        /// </remarks>
        public byte ReceivedKnockbackPercent
        {
            get => (byte)CellsByName["ReceivedKnockbackPercent"].Value;
            set => CellsByName["ReceivedKnockbackPercent"].Value = value;
        }


        // Def="u8 knockbackParamId"
        /// <summary>
        /// Knockback Param ID (u8)
        /// </summary>
        /// <remarks>
        /// Set the parameter ID used for knockback
        /// </remarks>
        public byte KnockbackParamID
        {
            get => (byte)CellsByName["KnockbackParamID"].Value;
            set => CellsByName["KnockbackParamID"].Value = value;
        }


        // Def="u8 fallDamageDump"
        /// <summary>
        /// Fall Damage Reduction % (u8)
        /// </summary>
        /// <remarks>
        /// Fall damage reduction correction [%]
        /// </remarks>
        public byte FallDamageReductionPercent
        {
            get => (byte)CellsByName["FallDamageReductionPercent"].Value;
            set => CellsByName["FallDamageReductionPercent"].Value = value;
        }


        // Def="u8 staminaGuardDef"
        /// <summary>
        /// Guard Stamina (u8)
        /// </summary>
        /// <remarks>
        /// Defense against enemy stamina attacks when guarding successfully
        /// </remarks>
        public byte GuardStamina
        {
            get => (byte)CellsByName["GuardStamina"].Value;
            set => CellsByName["GuardStamina"].Value = value;
        }


        // Def="u16 resist_sleep"
        /// <summary>
        /// Resist: Sleep (u16)
        /// </summary>
        /// <remarks>
        /// Difficulty in getting sleep abnormalities
        /// </remarks>
        public ushort ResistSleep
        {
            get => (ushort)CellsByName["ResistSleep"].Value;
            set => CellsByName["ResistSleep"].Value = value;
        }


        // Def="u16 resist_madness"
        /// <summary>
        /// Resist: Madness (u16)
        /// </summary>
        /// <remarks>
        /// Difficulty in getting mad
        /// </remarks>
        public ushort ResistMadness
        {
            get => (ushort)CellsByName["ResistMadness"].Value;
            set => CellsByName["ResistMadness"].Value = value;
        }


        // Def="s8 sleepGuardResist"
        /// <summary>
        /// Guard Resist: Sleep (s8)
        /// </summary>
        /// <remarks>
        /// How much to cut the attack power against sleep (set as a special effect parameter)
        /// </remarks>
        public sbyte GuardResistSleep
        {
            get => (sbyte)CellsByName["GuardResistSleep"].Value;
            set => CellsByName["GuardResistSleep"].Value = value;
        }


        // Def="s8 madnessGuardResist"
        /// <summary>
        /// Guard Resist: Madness (s8)
        /// </summary>
        /// <remarks>
        /// How much to cut the attack power against madness (set as a special effect parameter)
        /// </remarks>
        public sbyte GuardResistMadness
        {
            get => (sbyte)CellsByName["GuardResistMadness"].Value;
            set => CellsByName["GuardResistMadness"].Value = value;
        }


        // Def="s16 lockGazePoint7 = -1"
        /// <summary>
        /// Lock Gaze Point - Dummy Poly [7] (s16)
        /// </summary>
        /// <remarks>
        /// Gaze at the Damipoli specified when locking the Lock-on Damipoly 22X (-1: Invalid)
        /// </remarks>
        public short LockGazePointDummyPoly7
        {
            get => (short)CellsByName["LockGazePointDummyPoly7"].Value;
            set => CellsByName["LockGazePointDummyPoly7"].Value = value;
        }


        // Def="u8 mpRecoverBaseVel"
        /// <summary>
        /// FP Recovery (u8)
        /// </summary>
        /// <remarks>
        /// MP recovery basic speed [% / s]
        /// </remarks>
        public byte FPRecovery
        {
            get => (byte)CellsByName["FPRecovery"].Value;
            set => CellsByName["FPRecovery"].Value = value;
        }


        // Def="u8 flickDamageCutRate"
        /// <summary>
        /// Weapon Repel Absorption (u8)
        /// </summary>
        /// <remarks>
        /// Set a value to attenuate damage when repelling an attack
        /// </remarks>
        public byte WeaponRepelAbsorption
        {
            get => (byte)CellsByName["WeaponRepelAbsorption"].Value;
            set => CellsByName["WeaponRepelAbsorption"].Value = value;
        }


        // Def="s8 defaultLodParamId = -1"
        /// <summary>
        /// Default LOD Param ID (s8)
        /// </summary>
        /// <remarks>
        /// Default LOD Param ID (-1: None)
        /// </remarks>
        public sbyte DefaultLODParamID
        {
            get => (sbyte)CellsByName["DefaultLODParamID"].Value;
            set => CellsByName["DefaultLODParamID"].Value = value;
        }


        // Def="s8 drawType"
        /// <summary>
        /// Draw Type (s8)
        /// </summary>
        /// <remarks>
        /// Drawing type
        /// </remarks>
        public sbyte DrawType
        {
            get => (sbyte)CellsByName["DrawType"].Value;
            set => CellsByName["DrawType"].Value = value;
        }


        // Def="u8 npcType"
        /// <summary>
        /// NPC Type (u8)
        /// </summary>
        /// <remarks>
        /// NPC type. OK if Zako enemies / boss enemies are distinguished
        /// </remarks>
        public byte NPCType
        {
            get => (byte)CellsByName["NPCType"].Value;
            set => CellsByName["NPCType"].Value = value;
        }


        // Def="u8 teamType"
        /// <summary>
        /// Team Type (u8)
        /// </summary>
        /// <remarks>
        /// NPC attack hit / not hit, aim / not aim setting
        /// </remarks>
        public byte TeamType
        {
            get => (byte)CellsByName["TeamType"].Value;
            set => CellsByName["TeamType"].Value = value;
        }


        // Def="u8 moveType"
        /// <summary>
        /// Move Type (u8)
        /// </summary>
        /// <remarks>
        /// Moving method. This changes the control.
        /// </remarks>
        public byte MoveType
        {
            get => (byte)CellsByName["MoveType"].Value;
            set => CellsByName["MoveType"].Value = value;
        }


        // Def="u8 lockDist"
        /// <summary>
        /// Lock Distance (u8)
        /// </summary>
        /// <remarks>
        /// Lock-on distance [m]
        /// </remarks>
        public byte LockDistance
        {
            get => (byte)CellsByName["LockDistance"].Value;
            set => CellsByName["LockDistance"].Value = value;
        }


        // Def="u16 materialSe_Weak1"
        /// <summary>
        /// Weak Point - SE Material (u16)
        /// </summary>
        /// <remarks>
        /// Determines the SE that sounds when the weak point is damaged. 1
        /// </remarks>
        public ushort WeakPointSEMaterial
        {
            get => (ushort)CellsByName["WeakPointSEMaterial"].Value;
            set => CellsByName["WeakPointSEMaterial"].Value = value;
        }


        // Def="u16 materialSfx_Weak1"
        /// <summary>
        /// Weak Point - SFX Material (u16)
        /// </summary>
        /// <remarks>
        /// Determines the SFX that occurs when the weak point is damaged. 1
        /// </remarks>
        public ushort WeakPointSFXMaterial
        {
            get => (ushort)CellsByName["WeakPointSFXMaterial"].Value;
            set => CellsByName["WeakPointSFXMaterial"].Value = value;
        }


        // Def="u8 partsDamageType"
        /// <summary>
        /// Parts Damage - Attack Type (u8)
        /// </summary>
        /// <remarks>
        /// Set the attack type to apply site damage
        /// </remarks>
        public byte PartsDamageAttackType
        {
            get => (byte)CellsByName["PartsDamageAttackType"].Value;
            set => CellsByName["PartsDamageAttackType"].Value = value;
        }


        // Def="u8 vowType"
        /// <summary>
        /// Vow Type (u8)
        /// </summary>
        /// <remarks>
        /// Pledge type
        /// </remarks>
        public byte VowType
        {
            get => (byte)CellsByName["VowType"].Value;
            set => CellsByName["VowType"].Value = value;
        }


        // Def="s8 guardLevel"
        /// <summary>
        /// Guard Level (s8)
        /// </summary>
        /// <remarks>
        /// When guarding, which guard motion will the enemy attack? Decide
        /// </remarks>
        public sbyte GuardLevel
        {
            get => (sbyte)CellsByName["GuardLevel"].Value;
            set => CellsByName["GuardLevel"].Value = value;
        }


        // Def="u8 burnSfxType"
        /// <summary>
        /// Burn SFX Type (u8)
        /// </summary>
        /// <remarks>
        /// SFX type at the time of combustion
        /// </remarks>
        public byte BurnSFXType
        {
            get => (byte)CellsByName["BurnSFXType"].Value;
            set => CellsByName["BurnSFXType"].Value = value;
        }


        // Def="s8 poisonGuardResist"
        /// <summary>
        /// Guard Resist: Poison (s8)
        /// </summary>
        /// <remarks>
        /// How much to cut the attack power to poison (set to the special effect parameter)
        /// </remarks>
        public sbyte GuardResistPoison
        {
            get => (sbyte)CellsByName["GuardResistPoison"].Value;
            set => CellsByName["GuardResistPoison"].Value = value;
        }


        // Def="s8 diseaseGuardResist"
        /// <summary>
        /// Guard Resist: Scarlet Rot (s8)
        /// </summary>
        /// <remarks>
        /// How much to cut the attack power (set as a special effect parameter) to make it a plague
        /// </remarks>
        public sbyte GuardResistScarletRot
        {
            get => (sbyte)CellsByName["GuardResistScarletRot"].Value;
            set => CellsByName["GuardResistScarletRot"].Value = value;
        }


        // Def="s8 bloodGuardResist"
        /// <summary>
        /// Guard Resist: Hemorrhage (s8)
        /// </summary>
        /// <remarks>
        /// How much to cut the attack power (set as a special effect parameter) to make bleeding
        /// </remarks>
        public sbyte GuardResistHemorrhage
        {
            get => (sbyte)CellsByName["GuardResistHemorrhage"].Value;
            set => CellsByName["GuardResistHemorrhage"].Value = value;
        }


        // Def="s8 curseGuardResist"
        /// <summary>
        /// Guard Resist: Blight (s8)
        /// </summary>
        /// <remarks>
        /// How much to cut the attack power (set as a special effect parameter) to make a curse
        /// </remarks>
        public sbyte GuardResistBlight
        {
            get => (sbyte)CellsByName["GuardResistBlight"].Value;
            set => CellsByName["GuardResistBlight"].Value = value;
        }


        // Def="u8 parryAttack"
        /// <summary>
        /// Parry Attack Power (u8)
        /// </summary>
        /// <remarks>
        /// Parry attack power. Used by the parrying side
        /// </remarks>
        public byte ParryAttackPower
        {
            get => (byte)CellsByName["ParryAttackPower"].Value;
            set => CellsByName["ParryAttackPower"].Value = value;
        }


        // Def="u8 parryDefence"
        /// <summary>
        /// Parry Defence Power (u8)
        /// </summary>
        /// <remarks>
        /// Parry defense. Used by the parried side.
        /// </remarks>
        public byte ParryDefencePower
        {
            get => (byte)CellsByName["ParryDefencePower"].Value;
            set => CellsByName["ParryDefencePower"].Value = value;
        }


        // Def="u8 sfxSize"
        /// <summary>
        /// SFX Size (u8)
        /// </summary>
        /// <remarks>
        /// SFX size
        /// </remarks>
        public byte SFXSize
        {
            get => (byte)CellsByName["SFXSize"].Value;
            set => CellsByName["SFXSize"].Value = value;
        }


        // Def="u8 pushOutCamRegionRadius = 12"
        /// <summary>
        /// Push Out Camera Region Radius (u8)
        /// </summary>
        /// <remarks>
        /// Camera extrusion area radius [m]
        /// </remarks>
        public byte PushOutCameraRegionRadius
        {
            get => (byte)CellsByName["PushOutCameraRegionRadius"].Value;
            set => CellsByName["PushOutCameraRegionRadius"].Value = value;
        }


        // Def="u8 hitStopType"
        /// <summary>
        /// Hit Stop Type (u8)
        /// </summary>
        /// <remarks>
        /// Setting whether to perform hit stop processing
        /// </remarks>
        public byte HitStopType
        {
            get => (byte)CellsByName["HitStopType"].Value;
            set => CellsByName["HitStopType"].Value = value;
        }


        // Def="u8 ladderEndChkOffsetTop = 15"
        /// <summary>
        /// Ladder End Check Offset Top (u8)
        /// </summary>
        /// <remarks>
        /// Upper side of the ladder end judgment offset
        /// </remarks>
        public byte LadderEndCheckOffsetTop
        {
            get => (byte)CellsByName["LadderEndCheckOffsetTop"].Value;
            set => CellsByName["LadderEndCheckOffsetTop"].Value = value;
        }


        // Def="u8 ladderEndChkOffsetLow = 8"
        /// <summary>
        /// Ladder End Check Offset Bottom (u8)
        /// </summary>
        /// <remarks>
        /// Lower side of ladder end judgment offset
        /// </remarks>
        public byte LadderEndCheckOffsetBottom
        {
            get => (byte)CellsByName["LadderEndCheckOffsetBottom"].Value;
            set => CellsByName["LadderEndCheckOffsetBottom"].Value = value;
        }


        // Def="u8 useRagdollCamHit:1"
        /// <summary>
        /// Use Ragdoll Camera Hit (u8)
        /// </summary>
        /// <remarks>
        /// Does the camera hit the enemy ragdoll? (Valid only when hitting the player)
        /// </remarks>
        public byte UseRagdollCameraHit
        {
            get => (byte)CellsByName["UseRagdollCameraHit"].Value;
            set => CellsByName["UseRagdollCameraHit"].Value = value;
        }


        // Def="u8 disableClothRigidHit:1"
        /// <summary>
        /// Disable Cloth Rigid Hit (u8)
        /// </summary>
        /// <remarks>
        /// If you want to prevent the cross rigid from hitting you ○
        /// </remarks>
        public byte DisableClothRigidHit
        {
            get => (byte)CellsByName["DisableClothRigidHit"].Value;
            set => CellsByName["DisableClothRigidHit"].Value = value;
        }


        // Def="u8 useUndulationAddAnimFB:1"
        /// <summary>
        /// Use Undulating Add Anim (u8)
        /// </summary>
        /// <remarks>
        /// Whether to use front and back undulation addition
        /// </remarks>
        public byte UseUndulatingAddAnim
        {
            get => (byte)CellsByName["UseUndulatingAddAnim"].Value;
            set => CellsByName["UseUndulatingAddAnim"].Value = value;
        }


        // Def="u8 isWeakA:1"
        /// <summary>
        /// Enemy Type: Type A (u8)
        /// </summary>
        /// <remarks>
        /// Special attack A? Special attack A damage multiplier will be included in the calculation
        /// </remarks>
        public byte EnemyTypeTypeA
        {
            get => (byte)CellsByName["EnemyTypeTypeA"].Value;
            set => CellsByName["EnemyTypeTypeA"].Value = value;
        }


        // Def="u8 isGhost:1"
        /// <summary>
        /// Is Ghost (u8)
        /// </summary>
        /// <remarks>
        /// The opponent's attack will be able to slip through. The attack hits only when the "anti-spirit weapon" of the weapon para is attacked with the weapon of ○. Be careful not to confuse it with a wandering ghost
        /// </remarks>
        public byte IsGhost
        {
            get => (byte)CellsByName["IsGhost"].Value;
            set => CellsByName["IsGhost"].Value = value;
        }


        // Def="u8 isNoDamageMotion:1"
        /// <summary>
        /// Is No Damage Motion (u8)
        /// </summary>
        /// <remarks>
        /// Do you not play the damage motion when the damage is 0?
        /// </remarks>
        public byte IsNoDamageMotion
        {
            get => (byte)CellsByName["IsNoDamageMotion"].Value;
            set => CellsByName["IsNoDamageMotion"].Value = value;
        }


        // Def="u8 isUnduration:1"
        /// <summary>
        /// Is Undulating (u8)
        /// </summary>
        /// <remarks>
        /// Do you match the back and forth rotation of the character with the undulations of the ground? Cannot be used for flying characters
        /// </remarks>
        public byte IsUndulating
        {
            get => (byte)CellsByName["IsUndulating"].Value;
            set => CellsByName["IsUndulating"].Value = value;
        }


        // Def="u8 isChangeWanderGhost:1"
        /// <summary>
        /// Is Wandering Ghost (u8)
        /// </summary>
        /// <remarks>
        /// Will it be a wandering ghost when the player is a client?
        /// </remarks>
        public byte IsWanderingGhost
        {
            get => (byte)CellsByName["IsWanderingGhost"].Value;
            set => CellsByName["IsWanderingGhost"].Value = value;
        }


        // Def="u8 modelDispMask0:1"
        /// <summary>
        /// Model Display Mask [0] (u8)
        /// </summary>
        /// <remarks>
        /// Displays the model corresponding to the display mask.
        /// </remarks>
        public byte ModelDisplayMask0
        {
            get => (byte)CellsByName["ModelDisplayMask0"].Value;
            set => CellsByName["ModelDisplayMask0"].Value = value;
        }


        // Def="u8 modelDispMask1:1"
        /// <summary>
        /// Model Display Mask [1] (u8)
        /// </summary>
        /// <remarks>
        /// Displays the model corresponding to the display mask.
        /// </remarks>
        public byte ModelDisplayMask1
        {
            get => (byte)CellsByName["ModelDisplayMask1"].Value;
            set => CellsByName["ModelDisplayMask1"].Value = value;
        }


        // Def="u8 modelDispMask2:1"
        /// <summary>
        /// Model Display Mask [2] (u8)
        /// </summary>
        /// <remarks>
        /// Displays the model corresponding to the display mask.
        /// </remarks>
        public byte ModelDisplayMask2
        {
            get => (byte)CellsByName["ModelDisplayMask2"].Value;
            set => CellsByName["ModelDisplayMask2"].Value = value;
        }


        // Def="u8 modelDispMask3:1"
        /// <summary>
        /// Model Display Mask [3] (u8)
        /// </summary>
        /// <remarks>
        /// Displays the model corresponding to the display mask.
        /// </remarks>
        public byte ModelDisplayMask3
        {
            get => (byte)CellsByName["ModelDisplayMask3"].Value;
            set => CellsByName["ModelDisplayMask3"].Value = value;
        }


        // Def="u8 modelDispMask4:1"
        /// <summary>
        /// Model Display Mask [4] (u8)
        /// </summary>
        /// <remarks>
        /// Displays the model corresponding to the display mask.
        /// </remarks>
        public byte ModelDisplayMask4
        {
            get => (byte)CellsByName["ModelDisplayMask4"].Value;
            set => CellsByName["ModelDisplayMask4"].Value = value;
        }


        // Def="u8 modelDispMask5:1"
        /// <summary>
        /// Model Display Mask [5] (u8)
        /// </summary>
        /// <remarks>
        /// Displays the model corresponding to the display mask.
        /// </remarks>
        public byte ModelDisplayMask5
        {
            get => (byte)CellsByName["ModelDisplayMask5"].Value;
            set => CellsByName["ModelDisplayMask5"].Value = value;
        }


        // Def="u8 modelDispMask6:1"
        /// <summary>
        /// Model Display Mask [6] (u8)
        /// </summary>
        /// <remarks>
        /// Displays the model corresponding to the display mask.
        /// </remarks>
        public byte ModelDisplayMask6
        {
            get => (byte)CellsByName["ModelDisplayMask6"].Value;
            set => CellsByName["ModelDisplayMask6"].Value = value;
        }


        // Def="u8 modelDispMask7:1"
        /// <summary>
        /// Model Display Mask [7] (u8)
        /// </summary>
        /// <remarks>
        /// Displays the model corresponding to the display mask.
        /// </remarks>
        public byte ModelDisplayMask7
        {
            get => (byte)CellsByName["ModelDisplayMask7"].Value;
            set => CellsByName["ModelDisplayMask7"].Value = value;
        }


        // Def="u8 modelDispMask8:1"
        /// <summary>
        /// Model Display Mask [8] (u8)
        /// </summary>
        /// <remarks>
        /// Displays the model corresponding to the display mask.
        /// </remarks>
        public byte ModelDisplayMask8
        {
            get => (byte)CellsByName["ModelDisplayMask8"].Value;
            set => CellsByName["ModelDisplayMask8"].Value = value;
        }


        // Def="u8 modelDispMask9:1"
        /// <summary>
        /// Model Display Mask [9] (u8)
        /// </summary>
        /// <remarks>
        /// Displays the model corresponding to the display mask.
        /// </remarks>
        public byte ModelDisplayMask9
        {
            get => (byte)CellsByName["ModelDisplayMask9"].Value;
            set => CellsByName["ModelDisplayMask9"].Value = value;
        }


        // Def="u8 modelDispMask10:1"
        /// <summary>
        /// Model Display Mask [10] (u8)
        /// </summary>
        /// <remarks>
        /// Displays the model corresponding to the display mask.
        /// </remarks>
        public byte ModelDisplayMask10
        {
            get => (byte)CellsByName["ModelDisplayMask10"].Value;
            set => CellsByName["ModelDisplayMask10"].Value = value;
        }


        // Def="u8 modelDispMask11:1"
        /// <summary>
        /// Model Display Mask [11] (u8)
        /// </summary>
        /// <remarks>
        /// Displays the model corresponding to the display mask.
        /// </remarks>
        public byte ModelDisplayMask11
        {
            get => (byte)CellsByName["ModelDisplayMask11"].Value;
            set => CellsByName["ModelDisplayMask11"].Value = value;
        }


        // Def="u8 modelDispMask12:1"
        /// <summary>
        /// Model Display Mask [12] (u8)
        /// </summary>
        /// <remarks>
        /// Displays the model corresponding to the display mask.
        /// </remarks>
        public byte ModelDisplayMask12
        {
            get => (byte)CellsByName["ModelDisplayMask12"].Value;
            set => CellsByName["ModelDisplayMask12"].Value = value;
        }


        // Def="u8 modelDispMask13:1"
        /// <summary>
        /// Model Display Mask [13] (u8)
        /// </summary>
        /// <remarks>
        /// Displays the model corresponding to the display mask.
        /// </remarks>
        public byte ModelDisplayMask13
        {
            get => (byte)CellsByName["ModelDisplayMask13"].Value;
            set => CellsByName["ModelDisplayMask13"].Value = value;
        }


        // Def="u8 modelDispMask14:1"
        /// <summary>
        /// Model Display Mask [14] (u8)
        /// </summary>
        /// <remarks>
        /// Displays the model corresponding to the display mask.
        /// </remarks>
        public byte ModelDisplayMask14
        {
            get => (byte)CellsByName["ModelDisplayMask14"].Value;
            set => CellsByName["ModelDisplayMask14"].Value = value;
        }


        // Def="u8 modelDispMask15:1"
        /// <summary>
        /// Model Display Mask [15] (u8)
        /// </summary>
        /// <remarks>
        /// Displays the model corresponding to the display mask.
        /// </remarks>
        public byte ModelDisplayMask15
        {
            get => (byte)CellsByName["ModelDisplayMask15"].Value;
            set => CellsByName["ModelDisplayMask15"].Value = value;
        }


        // Def="u8 isEnableNeckTurn:1"
        /// <summary>
        /// Is Enable Neck Turn (u8)
        /// </summary>
        /// <remarks>
        /// Do you want to enable the swing set in Param Weaver?
        /// </remarks>
        public byte IsEnableNeckTurn
        {
            get => (byte)CellsByName["IsEnableNeckTurn"].Value;
            set => CellsByName["IsEnableNeckTurn"].Value = value;
        }


        // Def="u8 disableRespawn:1"
        /// <summary>
        /// Disable Respawn upon Rest (u8)
        /// </summary>
        /// <remarks>
        /// Do you ban respawn?
        /// </remarks>
        public byte DisableRespawnUponRest
        {
            get => (byte)CellsByName["DisableRespawnUponRest"].Value;
            set => CellsByName["DisableRespawnUponRest"].Value = value;
        }


        // Def="u8 isMoveAnimWait:1"
        /// <summary>
        /// Play Movement Anim until Over (u8)
        /// </summary>
        /// <remarks>
        /// Do you want to play the moving animation until the animation is over? (Like a mayfly dragon.)
        /// </remarks>
        public byte PlayMovementAnimUntilOver
        {
            get => (byte)CellsByName["PlayMovementAnimUntilOver"].Value;
            set => CellsByName["PlayMovementAnimUntilOver"].Value = value;
        }


        // Def="u8 isCrowd:1"
        /// <summary>
        /// Reduce Processing Load during Crowds (u8)
        /// </summary>
        /// <remarks>
        /// Do you want to reduce the processing load during crowds? For babies (preferably phalanx)
        /// </remarks>
        public byte ReduceProcessingLoadDuringCrowds
        {
            get => (byte)CellsByName["ReduceProcessingLoadDuringCrowds"].Value;
            set => CellsByName["ReduceProcessingLoadDuringCrowds"].Value = value;
        }


        // Def="u8 isWeakB:1"
        /// <summary>
        /// Enemy Type: Type B (u8)
        /// </summary>
        /// <remarks>
        /// Special attack B? Special attack B damage multiplier will be included in the calculation
        /// </remarks>
        public byte EnemyTypeTypeB
        {
            get => (byte)CellsByName["EnemyTypeTypeB"].Value;
            set => CellsByName["EnemyTypeTypeB"].Value = value;
        }


        // Def="u8 isWeakC:1"
        /// <summary>
        /// Enemy Type: Type C (u8)
        /// </summary>
        /// <remarks>
        /// Special attack C? Special attack C damage multiplier will be included in the calculation
        /// </remarks>
        public byte EnemyTypeTypeC
        {
            get => (byte)CellsByName["EnemyTypeTypeC"].Value;
            set => CellsByName["EnemyTypeTypeC"].Value = value;
        }


        // Def="u8 isWeakD:1"
        /// <summary>
        /// Enemy Type: Type D (u8)
        /// </summary>
        /// <remarks>
        /// Special attack D? Special attack D damage multiplier will be included in the calculation
        /// </remarks>
        public byte EnemyTypeTypeD
        {
            get => (byte)CellsByName["EnemyTypeTypeD"].Value;
            set => CellsByName["EnemyTypeTypeD"].Value = value;
        }


        // Def="u8 doesAlwaysUseSpecialTurn:1"
        /// <summary>
        /// Always Use Special Turn (u8)
        /// </summary>
        /// <remarks>
        /// Always execute a special turn (even if there is no navigation mesh at the turn destination, the special turn is continuously executed)
        /// </remarks>
        public byte AlwaysUseSpecialTurn
        {
            get => (byte)CellsByName["AlwaysUseSpecialTurn"].Value;
            set => CellsByName["AlwaysUseSpecialTurn"].Value = value;
        }


        // Def="u8 isRideAtkTarget:1"
        /// <summary>
        /// Is Ride Attack Target (u8)
        /// </summary>
        /// <remarks>
        /// Will you be the target of a riding special attack (if you are riding)?
        /// </remarks>
        public byte IsRideAttackTarget
        {
            get => (byte)CellsByName["IsRideAttackTarget"].Value;
            set => CellsByName["IsRideAttackTarget"].Value = value;
        }


        // Def="u8 isEnableStepDispInterpolate:1"
        /// <summary>
        /// Enable Step Display Interpolation (u8)
        /// </summary>
        /// <remarks>
        /// Whether to use step-over display interpolation
        /// </remarks>
        public byte EnableStepDisplayInterpolation
        {
            get => (byte)CellsByName["EnableStepDisplayInterpolation"].Value;
            set => CellsByName["EnableStepDisplayInterpolation"].Value = value;
        }


        // Def="u8 isStealthTarget:1 = 1"
        /// <summary>
        /// Is Stealth Attack Target (u8)
        /// </summary>
        /// <remarks>
        /// Is it a stealth attack target?
        /// </remarks>
        public byte IsStealthAttackTarget
        {
            get => (byte)CellsByName["IsStealthAttackTarget"].Value;
            set => CellsByName["IsStealthAttackTarget"].Value = value;
        }


        // Def="u8 disableInitializeDead:1"
        /// <summary>
        /// Disable Init Dead (u8)
        /// </summary>
        /// <remarks>
        /// If you do not make an initial death, TRUE, even if you kill and save it, the corpse will not be reproduced.
        /// </remarks>
        public byte DisableInitDead
        {
            get => (byte)CellsByName["DisableInitDead"].Value;
            set => CellsByName["DisableInitDead"].Value = value;
        }


        // Def="u8 isHitRumble:1"
        /// <summary>
        /// Is Hit Rumble (u8)
        /// </summary>
        /// <remarks>
        /// TRUE if it vibrates when hit. Use when you want to change from a normal hit stop, such as a dead person.
        /// </remarks>
        public byte IsHitRumble
        {
            get => (byte)CellsByName["IsHitRumble"].Value;
            set => CellsByName["IsHitRumble"].Value = value;
        }


        // Def="u8 isSmoothTurn:1 = 1"
        /// <summary>
        /// Use Smooth Turning (u8)
        /// </summary>
        /// <remarks>
        /// Whether to perform interpolation when turning between nodes in route movement
        /// </remarks>
        public byte UseSmoothTurning
        {
            get => (byte)CellsByName["UseSmoothTurning"].Value;
            set => CellsByName["UseSmoothTurning"].Value = value;
        }


        // Def="u8 isWeakE:1"
        /// <summary>
        /// Enemy Type: Type E (u8)
        /// </summary>
        /// <remarks>
        /// Special attack E? Special attack E damage multiplier will be included in the calculation
        /// </remarks>
        public byte EnemyTypeTypeE
        {
            get => (byte)CellsByName["EnemyTypeTypeE"].Value;
            set => CellsByName["EnemyTypeTypeE"].Value = value;
        }


        // Def="u8 isWeakF:1"
        /// <summary>
        /// Enemy Type: Type F (u8)
        /// </summary>
        /// <remarks>
        /// Special attack F? Special attack F damage multiplier will be included in the calculation
        /// </remarks>
        public byte EnemyTypeTypeF
        {
            get => (byte)CellsByName["EnemyTypeTypeF"].Value;
            set => CellsByName["EnemyTypeTypeF"].Value = value;
        }


        // Def="u8 modelDispMask16:1"
        /// <summary>
        /// Model Display Mask [16] (u8)
        /// </summary>
        /// <remarks>
        /// Displays the model corresponding to the display mask.
        /// </remarks>
        public byte ModelDisplayMask16
        {
            get => (byte)CellsByName["ModelDisplayMask16"].Value;
            set => CellsByName["ModelDisplayMask16"].Value = value;
        }


        // Def="u8 modelDispMask17:1"
        /// <summary>
        /// Model Display Mask [17] (u8)
        /// </summary>
        /// <remarks>
        /// Displays the model corresponding to the display mask.
        /// </remarks>
        public byte ModelDisplayMask17
        {
            get => (byte)CellsByName["ModelDisplayMask17"].Value;
            set => CellsByName["ModelDisplayMask17"].Value = value;
        }


        // Def="u8 modelDispMask18:1"
        /// <summary>
        /// Model Display Mask [18] (u8)
        /// </summary>
        /// <remarks>
        /// Displays the model corresponding to the display mask.
        /// </remarks>
        public byte ModelDisplayMask18
        {
            get => (byte)CellsByName["ModelDisplayMask18"].Value;
            set => CellsByName["ModelDisplayMask18"].Value = value;
        }


        // Def="u8 modelDispMask19:1"
        /// <summary>
        /// Model Display Mask [19] (u8)
        /// </summary>
        /// <remarks>
        /// Displays the model corresponding to the display mask.
        /// </remarks>
        public byte ModelDisplayMask19
        {
            get => (byte)CellsByName["ModelDisplayMask19"].Value;
            set => CellsByName["ModelDisplayMask19"].Value = value;
        }


        // Def="u8 modelDispMask20:1"
        /// <summary>
        /// Model Display Mask [20] (u8)
        /// </summary>
        /// <remarks>
        /// Displays the model corresponding to the display mask.
        /// </remarks>
        public byte ModelDisplayMask20
        {
            get => (byte)CellsByName["ModelDisplayMask20"].Value;
            set => CellsByName["ModelDisplayMask20"].Value = value;
        }


        // Def="u8 modelDispMask21:1"
        /// <summary>
        /// Model Display Mask [21] (u8)
        /// </summary>
        /// <remarks>
        /// Displays the model corresponding to the display mask.
        /// </remarks>
        public byte ModelDisplayMask21
        {
            get => (byte)CellsByName["ModelDisplayMask21"].Value;
            set => CellsByName["ModelDisplayMask21"].Value = value;
        }


        // Def="u8 modelDispMask22:1"
        /// <summary>
        /// Model Display Mask [22] (u8)
        /// </summary>
        /// <remarks>
        /// Displays the model corresponding to the display mask.
        /// </remarks>
        public byte ModelDisplayMask22
        {
            get => (byte)CellsByName["ModelDisplayMask22"].Value;
            set => CellsByName["ModelDisplayMask22"].Value = value;
        }


        // Def="u8 modelDispMask23:1"
        /// <summary>
        /// Model Display Mask [23] (u8)
        /// </summary>
        /// <remarks>
        /// Displays the model corresponding to the display mask.
        /// </remarks>
        public byte ModelDisplayMask23
        {
            get => (byte)CellsByName["ModelDisplayMask23"].Value;
            set => CellsByName["ModelDisplayMask23"].Value = value;
        }


        // Def="u8 modelDispMask24:1"
        /// <summary>
        /// Model Display Mask [24] (u8)
        /// </summary>
        /// <remarks>
        /// Displays the model corresponding to the display mask.
        /// </remarks>
        public byte ModelDisplayMask24
        {
            get => (byte)CellsByName["ModelDisplayMask24"].Value;
            set => CellsByName["ModelDisplayMask24"].Value = value;
        }


        // Def="u8 modelDispMask25:1"
        /// <summary>
        /// Model Display Mask [25] (u8)
        /// </summary>
        /// <remarks>
        /// Displays the model corresponding to the display mask.
        /// </remarks>
        public byte ModelDisplayMask25
        {
            get => (byte)CellsByName["ModelDisplayMask25"].Value;
            set => CellsByName["ModelDisplayMask25"].Value = value;
        }


        // Def="u8 modelDispMask26:1"
        /// <summary>
        /// Model Display Mask [26] (u8)
        /// </summary>
        /// <remarks>
        /// Displays the model corresponding to the display mask.
        /// </remarks>
        public byte ModelDisplayMask26
        {
            get => (byte)CellsByName["ModelDisplayMask26"].Value;
            set => CellsByName["ModelDisplayMask26"].Value = value;
        }


        // Def="u8 modelDispMask27:1"
        /// <summary>
        /// Model Display Mask [27] (u8)
        /// </summary>
        /// <remarks>
        /// Displays the model corresponding to the display mask.
        /// </remarks>
        public byte ModelDisplayMask27
        {
            get => (byte)CellsByName["ModelDisplayMask27"].Value;
            set => CellsByName["ModelDisplayMask27"].Value = value;
        }


        // Def="u8 modelDispMask28:1"
        /// <summary>
        /// Model Display Mask [28] (u8)
        /// </summary>
        /// <remarks>
        /// Displays the model corresponding to the display mask.
        /// </remarks>
        public byte ModelDisplayMask28
        {
            get => (byte)CellsByName["ModelDisplayMask28"].Value;
            set => CellsByName["ModelDisplayMask28"].Value = value;
        }


        // Def="u8 modelDispMask29:1"
        /// <summary>
        /// Model Display Mask [29] (u8)
        /// </summary>
        /// <remarks>
        /// Displays the model corresponding to the display mask.
        /// </remarks>
        public byte ModelDisplayMask29
        {
            get => (byte)CellsByName["ModelDisplayMask29"].Value;
            set => CellsByName["ModelDisplayMask29"].Value = value;
        }


        // Def="u8 modelDispMask30:1"
        /// <summary>
        /// Model Display Mask [30] (u8)
        /// </summary>
        /// <remarks>
        /// Displays the model corresponding to the display mask.
        /// </remarks>
        public byte ModelDisplayMask30
        {
            get => (byte)CellsByName["ModelDisplayMask30"].Value;
            set => CellsByName["ModelDisplayMask30"].Value = value;
        }


        // Def="u8 modelDispMask31:1"
        /// <summary>
        /// Model Display Mask [31] (u8)
        /// </summary>
        /// <remarks>
        /// Displays the model corresponding to the display mask.
        /// </remarks>
        public byte ModelDisplayMask31
        {
            get => (byte)CellsByName["ModelDisplayMask31"].Value;
            set => CellsByName["ModelDisplayMask31"].Value = value;
        }


        // Def="f32 itemSearchRadius"
        /// <summary>
        /// Item Pickup Radius (f32)
        /// </summary>
        /// <remarks>
        /// Radius to be added as a correction to the cylinder radius of normal Item search judgment (applicable to enemy drop items. Used for large characters etc.)
        /// </remarks>
        public float ItemPickupRadius
        {
            get => (float)CellsByName["ItemPickupRadius"].Value;
            set => CellsByName["ItemPickupRadius"].Value = value;
        }


        // Def="f32 chrHitHeight"
        /// <summary>
        /// Chr Capsule Height (f32)
        /// </summary>
        /// <remarks>
        /// The height of the capsule per character.
        /// </remarks>
        public float ChrCapsuleHeight
        {
            get => (float)CellsByName["ChrCapsuleHeight"].Value;
            set => CellsByName["ChrCapsuleHeight"].Value = value;
        }


        // Def="f32 chrHitRadius"
        /// <summary>
        /// Chr Capsule Radius (f32)
        /// </summary>
        /// <remarks>
        /// Radius of capsule per character.
        /// </remarks>
        public float ChrCapsuleRadius
        {
            get => (float)CellsByName["ChrCapsuleRadius"].Value;
            set => CellsByName["ChrCapsuleRadius"].Value = value;
        }


        // Def="u8 specialTurnType"
        /// <summary>
        /// Special Turn Type (u8)
        /// </summary>
        /// <remarks>
        /// Special turning type
        /// </remarks>
        public byte SpecialTurnType
        {
            get => (byte)CellsByName["SpecialTurnType"].Value;
            set => CellsByName["SpecialTurnType"].Value = value;
        }


        // Def="u8 isSoulGetByBoss:1"
        /// <summary>
        /// Is Boss Soul Drop (u8)
        /// </summary>
        /// <remarks>
        /// Do you get a boss in soul?
        /// </remarks>
        public byte IsBossSoulDrop
        {
            get => (byte)CellsByName["IsBossSoulDrop"].Value;
            set => CellsByName["IsBossSoulDrop"].Value = value;
        }


        // Def="u8 isBulletOwner_byObject:1"
        /// <summary>
        /// Is Bullet Owner - By Object (u8)
        /// </summary>
        /// <remarks>
        /// If you become the owner of a bullet, a flag that applies the object's damage calculation related to the bullet. Used for damage correction by power.
        /// </remarks>
        public byte IsBulletOwnerByObject
        {
            get => (byte)CellsByName["IsBulletOwnerByObject"].Value;
            set => CellsByName["IsBulletOwnerByObject"].Value = value;
        }


        // Def="u8 isUseLowHitFootIk:1"
        /// <summary>
        /// Use FootIK Filter for Low Hit (u8)
        /// </summary>
        /// <remarks>
        /// Whether to use the FootIk filter for low hits
        /// </remarks>
        public byte UseFootIKFilterForLowHit
        {
            get => (byte)CellsByName["UseFootIKFilterForLowHit"].Value;
            set => CellsByName["UseFootIKFilterForLowHit"].Value = value;
        }


        // Def="u8 isCalculatePvPDamage:1"
        /// <summary>
        /// Use PvP Damage Modifiers (u8)
        /// </summary>
        /// <remarks>
        /// Decide whether to calculate damage as a "player" when calculating damage. If it is invalid, it is treated as an "enemy".
        /// </remarks>
        public byte UsePvPDamageModifiers
        {
            get => (byte)CellsByName["UsePvPDamageModifiers"].Value;
            set => CellsByName["UsePvPDamageModifiers"].Value = value;
        }


        // Def="u8 isHostSyncChr:1"
        /// <summary>
        /// Is Synced with Host World (u8)
        /// </summary>
        /// <remarks>
        /// Can only be activated when active in the host world
        /// </remarks>
        public byte IsSyncedWithHostWorld
        {
            get => (byte)CellsByName["IsSyncedWithHostWorld"].Value;
            set => CellsByName["IsSyncedWithHostWorld"].Value = value;
        }


        // Def="u8 isSkipWeakDamageAnim:1"
        /// <summary>
        /// Skip Weak Damage Anim (u8)
        /// </summary>
        /// <remarks>
        /// Weakness damage Whether to skip animation playback. "Part damage rate" and "defense material" are treated as weak points just by not playing the animation.
        /// </remarks>
        public byte SkipWeakDamageAnim
        {
            get => (byte)CellsByName["SkipWeakDamageAnim"].Value;
            set => CellsByName["SkipWeakDamageAnim"].Value = value;
        }


        // Def="u8 isKeepHitOnRide:1"
        /// <summary>
        /// Keep Capsule on Ride (u8)
        /// </summary>
        /// <remarks>
        /// When riding on a character with this parameter ○, the character's Atari remains while riding.
        /// </remarks>
        public byte KeepCapsuleOnRide
        {
            get => (byte)CellsByName["KeepCapsuleOnRide"].Value;
            set => CellsByName["KeepCapsuleOnRide"].Value = value;
        }


        // Def="u8 isSpCollide:1"
        /// <summary>
        /// Is Special Collider (u8)
        /// </summary>
        /// <remarks>
        /// Is it a special character?
        /// </remarks>
        public byte IsSpecialCollider
        {
            get => (byte)CellsByName["IsSpecialCollider"].Value;
            set => CellsByName["IsSpecialCollider"].Value = value;
        }


        // Def="u16 def_dark"
        /// <summary>
        /// Defence: Holy (u16)
        /// </summary>
        /// <remarks>
        /// Damage reduction base value for dark attacks.
        /// </remarks>
        public ushort DefenceHoly
        {
            get => (ushort)CellsByName["DefenceHoly"].Value;
            set => CellsByName["DefenceHoly"].Value = value;
        }


        // Def="u32 threatLv = 1"
        /// <summary>
        /// Threat Level (u32)
        /// </summary>
        /// <remarks>
        /// Threat level. If it is 0, even if the PC is found, "FE that seems to be found" is not displayed.
        /// </remarks>
        public uint ThreatLevel
        {
            get => (uint)CellsByName["ThreatLevel"].Value;
            set => CellsByName["ThreatLevel"].Value = value;
        }


        // Def="f32 specialTurnDistanceThreshold = 4"
        /// <summary>
        /// Special Turn Distance Threshold (f32)
        /// </summary>
        /// <remarks>
        /// Make a special turn when the distance to the target is greater than or equal to the set threshold
        /// </remarks>
        public float SpecialTurnDistanceThreshold
        {
            get => (float)CellsByName["SpecialTurnDistanceThreshold"].Value;
            set => CellsByName["SpecialTurnDistanceThreshold"].Value = value;
        }


        // Def="s32 autoFootEffectSfxId = -1"
        /// <summary>
        /// Automatic Foot Effect - SFX ID (s32)
        /// </summary>
        /// <remarks>
        /// The SFX identifier used in the automatic foot effect. (ZZZ of XYYZZZ)
        /// </remarks>
        public int AutomaticFootEffectSFXID
        {
            get => (int)CellsByName["AutomaticFootEffectSFXID"].Value;
            set => CellsByName["AutomaticFootEffectSFXID"].Value = value;
        }


        // Def="u16 materialSe1"
        /// <summary>
        /// Damaged - Material SE [1] (u16)
        /// </summary>
        /// <remarks>
        /// Determine the SE that sounds when damaged. 1. It is OK to set it by appearance.
        /// </remarks>
        public ushort DamagedMaterialSE1
        {
            get => (ushort)CellsByName["DamagedMaterialSE1"].Value;
            set => CellsByName["DamagedMaterialSE1"].Value = value;
        }


        // Def="u16 materialSfx1"
        /// <summary>
        /// Damaged - Material SFX [1] (u16)
        /// </summary>
        /// <remarks>
        /// Determine the SFX that occurs when you take damage. 1. It is OK to set it by appearance.
        /// </remarks>
        public ushort DamagedMaterialSFX1
        {
            get => (ushort)CellsByName["DamagedMaterialSFX1"].Value;
            set => CellsByName["DamagedMaterialSFX1"].Value = value;
        }


        // Def="u16 materialSe_Weak2"
        /// <summary>
        /// Weak Point - Material SE [2] (u16)
        /// </summary>
        /// <remarks>
        /// Determines the SE that sounds when the weak point is damaged. 2
        /// </remarks>
        public ushort WeakPointMaterialSE2
        {
            get => (ushort)CellsByName["WeakPointMaterialSE2"].Value;
            set => CellsByName["WeakPointMaterialSE2"].Value = value;
        }


        // Def="u16 materialSfx_Weak2"
        /// <summary>
        /// Weak Point - Material SFX [2] (u16)
        /// </summary>
        /// <remarks>
        /// Determines the SFX that occurs when the weak point is damaged. 2
        /// </remarks>
        public ushort WeakPointMaterialSFX2
        {
            get => (ushort)CellsByName["WeakPointMaterialSFX2"].Value;
            set => CellsByName["WeakPointMaterialSFX2"].Value = value;
        }


        // Def="u16 materialSe2"
        /// <summary>
        /// Damaged - Material SE [2] (u16)
        /// </summary>
        /// <remarks>
        /// Determine the SE that sounds when damaged. 2. It is OK to set it by appearance.
        /// </remarks>
        public ushort DamagedMaterialSE2
        {
            get => (ushort)CellsByName["DamagedMaterialSE2"].Value;
            set => CellsByName["DamagedMaterialSE2"].Value = value;
        }


        // Def="u16 materialSfx2"
        /// <summary>
        /// Damaged - Material SFX [2] (u16)
        /// </summary>
        /// <remarks>
        /// Determine the SFX that occurs when you take damage. 2. It is OK to set it by appearance.
        /// </remarks>
        public ushort DamagedMaterialSFX2
        {
            get => (ushort)CellsByName["DamagedMaterialSFX2"].Value;
            set => CellsByName["DamagedMaterialSFX2"].Value = value;
        }


        // Def="s32 spEffectID8 = -1"
        /// <summary>
        /// SpEffect ID [8] (s32)
        /// </summary>
        /// <remarks>
        /// Resident special effect 8
        /// </remarks>
        public int SpEffectID8
        {
            get => (int)CellsByName["SpEffectID8"].Value;
            set => CellsByName["SpEffectID8"].Value = value;
        }


        // Def="s32 spEffectID9 = -1"
        /// <summary>
        /// SpEffect ID [9] (s32)
        /// </summary>
        /// <remarks>
        /// Resident special effect 9
        /// </remarks>
        public int SpEffectID9
        {
            get => (int)CellsByName["SpEffectID9"].Value;
            set => CellsByName["SpEffectID9"].Value = value;
        }


        // Def="s32 spEffectID10 = -1"
        /// <summary>
        /// SpEffect ID [10] (s32)
        /// </summary>
        /// <remarks>
        /// Resident special effect 10
        /// </remarks>
        public int SpEffectID10
        {
            get => (int)CellsByName["SpEffectID10"].Value;
            set => CellsByName["SpEffectID10"].Value = value;
        }


        // Def="s32 spEffectID11 = -1"
        /// <summary>
        /// SpEffect ID [11] (s32)
        /// </summary>
        /// <remarks>
        /// Resident special effects 11
        /// </remarks>
        public int SpEffectID11
        {
            get => (int)CellsByName["SpEffectID11"].Value;
            set => CellsByName["SpEffectID11"].Value = value;
        }


        // Def="s32 spEffectID12 = -1"
        /// <summary>
        /// SpEffect ID [12] (s32)
        /// </summary>
        /// <remarks>
        /// Resident special effect 12
        /// </remarks>
        public int SpEffectID12
        {
            get => (int)CellsByName["SpEffectID12"].Value;
            set => CellsByName["SpEffectID12"].Value = value;
        }


        // Def="s32 spEffectID13 = -1"
        /// <summary>
        /// SpEffect ID [13] (s32)
        /// </summary>
        /// <remarks>
        /// Resident special effect 13
        /// </remarks>
        public int SpEffectID13
        {
            get => (int)CellsByName["SpEffectID13"].Value;
            set => CellsByName["SpEffectID13"].Value = value;
        }


        // Def="s32 spEffectID14 = -1"
        /// <summary>
        /// SpEffect ID [14] (s32)
        /// </summary>
        /// <remarks>
        /// Resident special effect 14
        /// </remarks>
        public int SpEffectID14
        {
            get => (int)CellsByName["SpEffectID14"].Value;
            set => CellsByName["SpEffectID14"].Value = value;
        }


        // Def="s32 spEffectID15 = -1"
        /// <summary>
        /// SpEffect ID [15] (s32)
        /// </summary>
        /// <remarks>
        /// Resident special effects 15
        /// </remarks>
        public int SpEffectID15
        {
            get => (int)CellsByName["SpEffectID15"].Value;
            set => CellsByName["SpEffectID15"].Value = value;
        }


        // Def="s32 autoFootEffectDecalBaseId1 = -1"
        /// <summary>
        /// Automatic Foot Effect - Decal Base ID [1] (s32)
        /// </summary>
        /// <remarks>
        /// Decal to be attached when a foot effect occurs. Floor material is also taken into consideration
        /// </remarks>
        public int AutomaticFootEffectDecalBaseID1
        {
            get => (int)CellsByName["AutomaticFootEffectDecalBaseID1"].Value;
            set => CellsByName["AutomaticFootEffectDecalBaseID1"].Value = value;
        }


        // Def="u32 toughness"
        /// <summary>
        /// Toughness (u32)
        /// </summary>
        /// <remarks>
        /// Basic value of toughness
        /// </remarks>
        public uint Toughness
        {
            get => (uint)CellsByName["Toughness"].Value;
            set => CellsByName["Toughness"].Value = value;
        }


        // Def="f32 toughnessRecoverCorrection"
        /// <summary>
        /// Toughness Correction (f32)
        /// </summary>
        /// <remarks>
        /// Correction value for toughness recovery time
        /// </remarks>
        public float ToughnessCorrection
        {
            get => (float)CellsByName["ToughnessCorrection"].Value;
            set => CellsByName["ToughnessCorrection"].Value = value;
        }


        // Def="f32 neutralDamageCutRate = 1"
        /// <summary>
        /// Absorption %: Standard (f32)
        /// </summary>
        /// <remarks>
        /// Non-attribute damage multiplier. The final damage value is the value obtained by multiplying the damage calculation result by this value.
        /// </remarks>
        public float AbsorptionPercentStandard
        {
            get => (float)CellsByName["AbsorptionPercentStandard"].Value;
            set => CellsByName["AbsorptionPercentStandard"].Value = value;
        }


        // Def="f32 slashDamageCutRate = 1"
        /// <summary>
        /// Absorption %: Slash (f32)
        /// </summary>
        /// <remarks>
        /// Slash damage multiplier. The final damage value is the value obtained by multiplying the damage calculation result by this value.
        /// </remarks>
        public float AbsorptionPercentSlash
        {
            get => (float)CellsByName["AbsorptionPercentSlash"].Value;
            set => CellsByName["AbsorptionPercentSlash"].Value = value;
        }


        // Def="f32 blowDamageCutRate = 1"
        /// <summary>
        /// Absorption %: Strike (f32)
        /// </summary>
        /// <remarks>
        /// Batter damage multiplier. The final damage value is the value obtained by multiplying the damage calculation result by this value.
        /// </remarks>
        public float AbsorptionPercentStrike
        {
            get => (float)CellsByName["AbsorptionPercentStrike"].Value;
            set => CellsByName["AbsorptionPercentStrike"].Value = value;
        }


        // Def="f32 thrustDamageCutRate = 1"
        /// <summary>
        /// Absorption %: Thrust (f32)
        /// </summary>
        /// <remarks>
        /// Puncture damage ratio. The final damage value is the value obtained by multiplying the damage calculation result by this value.
        /// </remarks>
        public float AbsorptionPercentThrust
        {
            get => (float)CellsByName["AbsorptionPercentThrust"].Value;
            set => CellsByName["AbsorptionPercentThrust"].Value = value;
        }


        // Def="f32 magicDamageCutRate = 1"
        /// <summary>
        /// Absorption %: Magic (f32)
        /// </summary>
        /// <remarks>
        /// Magic damage multiplier. The final damage value is the value obtained by multiplying the damage calculation result by this value.
        /// </remarks>
        public float AbsorptionPercentMagic
        {
            get => (float)CellsByName["AbsorptionPercentMagic"].Value;
            set => CellsByName["AbsorptionPercentMagic"].Value = value;
        }


        // Def="f32 fireDamageCutRate = 1"
        /// <summary>
        /// Absorption %: Fire (f32)
        /// </summary>
        /// <remarks>
        /// Flame damage multiplier. The final damage value is the value obtained by multiplying the damage calculation result by this value.
        /// </remarks>
        public float AbsorptionPercentFire
        {
            get => (float)CellsByName["AbsorptionPercentFire"].Value;
            set => CellsByName["AbsorptionPercentFire"].Value = value;
        }


        // Def="f32 thunderDamageCutRate = 1"
        /// <summary>
        /// Absorption %: Lightning (f32)
        /// </summary>
        /// <remarks>
        /// Electric shock damage ratio. The final damage value is the value obtained by multiplying the damage calculation result by this value.
        /// </remarks>
        public float AbsorptionPercentLightning
        {
            get => (float)CellsByName["AbsorptionPercentLightning"].Value;
            set => CellsByName["AbsorptionPercentLightning"].Value = value;
        }


        // Def="f32 darkDamageCutRate = 1"
        /// <summary>
        /// Absorption %: Holy (f32)
        /// </summary>
        /// <remarks>
        /// Dark damage multiplier. The final damage value is the value obtained by multiplying the damage calculation result by this value.
        /// </remarks>
        public float AbsorptionPercentHoly
        {
            get => (float)CellsByName["AbsorptionPercentHoly"].Value;
            set => CellsByName["AbsorptionPercentHoly"].Value = value;
        }


        // Def="f32 darkGuardCutRate"
        /// <summary>
        /// Guard Absorption %: Holy (f32)
        /// </summary>
        /// <remarks>
        /// How much to cut the dark attack?
        /// </remarks>
        public float GuardAbsorptionPercentHoly
        {
            get => (float)CellsByName["GuardAbsorptionPercentHoly"].Value;
            set => CellsByName["GuardAbsorptionPercentHoly"].Value = value;
        }


        // Def="s8 clothUpdateOffset"
        /// <summary>
        /// Cloth Update Offset (s8)
        /// </summary>
        /// <remarks>
        /// Cross update priority offset [m]
        /// </remarks>
        public sbyte ClothUpdateOffset
        {
            get => (sbyte)CellsByName["ClothUpdateOffset"].Value;
            set => CellsByName["ClothUpdateOffset"].Value = value;
        }


        // Def="u8 npcPlayerWeightType"
        /// <summary>
        /// NPC Player Weight Type (u8)
        /// </summary>
        /// <remarks>
        /// Equipment weight type applied for NPC players
        /// </remarks>
        public byte NPCPlayerWeightType
        {
            get => (byte)CellsByName["NPCPlayerWeightType"].Value;
            set => CellsByName["NPCPlayerWeightType"].Value = value;
        }


        // Def="s16 normalChangeModelId = -1"
        /// <summary>
        /// Replacement Change - Model ID (s16)
        /// </summary>
        /// <remarks>
        /// Normal replacement model, texture ID
        /// </remarks>
        public short ReplacementChangeModelID
        {
            get => (short)CellsByName["ReplacementChangeModelID"].Value;
            set => CellsByName["ReplacementChangeModelID"].Value = value;
        }


        // Def="s16 normalChangeAnimChrId = -1"
        /// <summary>
        /// Replacement Change - Anim Chr ID (s16)
        /// </summary>
        /// <remarks>
        /// Replace the target animation with the specified ID Anibnd
        /// </remarks>
        public short ReplacementChangeAnimChrID
        {
            get => (short)CellsByName["ReplacementChangeAnimChrID"].Value;
            set => CellsByName["ReplacementChangeAnimChrID"].Value = value;
        }


        // Def="u16 paintRenderTargetSize = 256"
        /// <summary>
        /// Paint Render Target Size (u16)
        /// </summary>
        /// <remarks>
        /// Paint render target size [pix]
        /// </remarks>
        public ushort PaintRenderTargetSize
        {
            get => (ushort)CellsByName["PaintRenderTargetSize"].Value;
            set => CellsByName["PaintRenderTargetSize"].Value = value;
        }


        // Def="s32 resistCorrectId_disease = -1"
        /// <summary>
        /// Resist Correct: Scarlet Rot (s32)
        /// </summary>
        /// <remarks>
        /// When the abnormal condition is activated, the maximum value is temporarily changed by using the set value of the abnormal condition resistance correction parameter.
        /// </remarks>
        public int ResistCorrectScarletRot
        {
            get => (int)CellsByName["ResistCorrectScarletRot"].Value;
            set => CellsByName["ResistCorrectScarletRot"].Value = value;
        }


        // Def="s32 phantomShaderId = -1"
        /// <summary>
        /// Phantom Shader ID (s32)
        /// </summary>
        /// <remarks>
        /// ID of the phantom parameter .xlsm to apply
        /// </remarks>
        public int PhantomShaderID
        {
            get => (int)CellsByName["PhantomShaderID"].Value;
            set => CellsByName["PhantomShaderID"].Value = value;
        }


        // Def="s32 multiPlayCorrectionParamId = -1"
        /// <summary>
        /// Multiplayer Correction Param ID (s32)
        /// </summary>
        /// <remarks>
        /// Multiplayer correction parameter ID
        /// </remarks>
        public int MultiplayerCorrectionParamID
        {
            get => (int)CellsByName["MultiplayerCorrectionParamID"].Value;
            set => CellsByName["MultiplayerCorrectionParamID"].Value = value;
        }


        // Def="f32 maxAnklePitchAngle = -1"
        /// <summary>
        /// FootIK Ankle Pitch Limit Angle (f32)
        /// </summary>
        /// <remarks>
        /// FootIK Ankle pitch limit angle (-1: no limit). If you have not set Foot End L S in HAT, this angle is used in common with rolls.
        /// </remarks>
        public float FootIKAnklePitchLimitAngle
        {
            get => (float)CellsByName["FootIKAnklePitchLimitAngle"].Value;
            set => CellsByName["FootIKAnklePitchLimitAngle"].Value = value;
        }


        // Def="u16 resist_freeze"
        /// <summary>
        /// Resist: Frostbite (u16)
        /// </summary>
        /// <remarks>
        /// Difficulty in getting cold air condition abnormal
        /// </remarks>
        public ushort ResistFrostbite
        {
            get => (ushort)CellsByName["ResistFrostbite"].Value;
            set => CellsByName["ResistFrostbite"].Value = value;
        }


        // Def="s8 freezeGuardResist"
        /// <summary>
        /// Guard Resist: Frostbite (s8)
        /// </summary>
        /// <remarks>
        /// How much to cut the attack power against cold air (set as a special effect parameter)
        /// </remarks>
        public sbyte GuardResistFrostbite
        {
            get => (sbyte)CellsByName["GuardResistFrostbite"].Value;
            set => CellsByName["GuardResistFrostbite"].Value = value;
        }


        // Def="dummy8 pad1[1]"
        /// <summary>
        /// pad (dummy8)
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        public object Pad
        {
            get => (object)CellsByName["Pad"].Value;
            set => CellsByName["Pad"].Value = value;
        }


        // Def="s32 lockCameraParamId = -1"
        /// <summary>
        /// Lock Camera Param ID (s32)
        /// </summary>
        /// <remarks>
        /// The ID of the lock camera parameter applied to the camera when locked on. Highest priority. Unused if -1
        /// </remarks>
        public int LockCameraParamID
        {
            get => (int)CellsByName["LockCameraParamID"].Value;
            set => CellsByName["LockCameraParamID"].Value = value;
        }


        // Def="s32 spEffectID16 = -1"
        /// <summary>
        /// SpEffect ID [16] (s32)
        /// </summary>
        /// <remarks>
        /// Resident special effects 16
        /// </remarks>
        public int SpEffectID16
        {
            get => (int)CellsByName["SpEffectID16"].Value;
            set => CellsByName["SpEffectID16"].Value = value;
        }


        // Def="s32 spEffectID17 = -1"
        /// <summary>
        /// SpEffect ID [17] (s32)
        /// </summary>
        /// <remarks>
        /// Resident special effects 17
        /// </remarks>
        public int SpEffectID17
        {
            get => (int)CellsByName["SpEffectID17"].Value;
            set => CellsByName["SpEffectID17"].Value = value;
        }


        // Def="s32 spEffectID18 = -1"
        /// <summary>
        /// SpEffect ID [18] (s32)
        /// </summary>
        /// <remarks>
        /// Resident special effects 18
        /// </remarks>
        public int SpEffectID18
        {
            get => (int)CellsByName["SpEffectID18"].Value;
            set => CellsByName["SpEffectID18"].Value = value;
        }


        // Def="s32 spEffectID19 = -1"
        /// <summary>
        /// SpEffect ID [19] (s32)
        /// </summary>
        /// <remarks>
        /// Resident special effects 19
        /// </remarks>
        public int SpEffectID19
        {
            get => (int)CellsByName["SpEffectID19"].Value;
            set => CellsByName["SpEffectID19"].Value = value;
        }


        // Def="s32 spEffectID20 = -1"
        /// <summary>
        /// SpEffect ID [20] (s32)
        /// </summary>
        /// <remarks>
        /// Resident special effect 20
        /// </remarks>
        public int SpEffectID20
        {
            get => (int)CellsByName["SpEffectID20"].Value;
            set => CellsByName["SpEffectID20"].Value = value;
        }


        // Def="s32 spEffectID21 = -1"
        /// <summary>
        /// SpEffect ID [21] (s32)
        /// </summary>
        /// <remarks>
        /// Resident special effect 21
        /// </remarks>
        public int SpEffectID21
        {
            get => (int)CellsByName["SpEffectID21"].Value;
            set => CellsByName["SpEffectID21"].Value = value;
        }


        // Def="s32 spEffectID22 = -1"
        /// <summary>
        /// SpEffect ID [22] (s32)
        /// </summary>
        /// <remarks>
        /// Resident special effect 22
        /// </remarks>
        public int SpEffectID22
        {
            get => (int)CellsByName["SpEffectID22"].Value;
            set => CellsByName["SpEffectID22"].Value = value;
        }


        // Def="s32 spEffectID23 = -1"
        /// <summary>
        /// SpEffect ID [23] (s32)
        /// </summary>
        /// <remarks>
        /// Resident special effect 23
        /// </remarks>
        public int SpEffectID23
        {
            get => (int)CellsByName["SpEffectID23"].Value;
            set => CellsByName["SpEffectID23"].Value = value;
        }


        // Def="s32 spEffectID24 = -1"
        /// <summary>
        /// SpEffect ID [24] (s32)
        /// </summary>
        /// <remarks>
        /// Resident special effect 24
        /// </remarks>
        public int SpEffectID24
        {
            get => (int)CellsByName["SpEffectID24"].Value;
            set => CellsByName["SpEffectID24"].Value = value;
        }


        // Def="s32 spEffectID25 = -1"
        /// <summary>
        /// SpEffect ID [25] (s32)
        /// </summary>
        /// <remarks>
        /// Resident special effects 25
        /// </remarks>
        public int SpEffectID25
        {
            get => (int)CellsByName["SpEffectID25"].Value;
            set => CellsByName["SpEffectID25"].Value = value;
        }


        // Def="s32 spEffectID26 = -1"
        /// <summary>
        /// SpEffect ID [26] (s32)
        /// </summary>
        /// <remarks>
        /// Resident special effect 26
        /// </remarks>
        public int SpEffectID26
        {
            get => (int)CellsByName["SpEffectID26"].Value;
            set => CellsByName["SpEffectID26"].Value = value;
        }


        // Def="s32 spEffectID27 = -1"
        /// <summary>
        /// SpEffect ID [27] (s32)
        /// </summary>
        /// <remarks>
        /// Resident special effect 27
        /// </remarks>
        public int SpEffectID27
        {
            get => (int)CellsByName["SpEffectID27"].Value;
            set => CellsByName["SpEffectID27"].Value = value;
        }


        // Def="s32 spEffectID28 = -1"
        /// <summary>
        /// SpEffect ID [28] (s32)
        /// </summary>
        /// <remarks>
        /// Resident special effects 28
        /// </remarks>
        public int SpEffectID28
        {
            get => (int)CellsByName["SpEffectID28"].Value;
            set => CellsByName["SpEffectID28"].Value = value;
        }


        // Def="s32 spEffectID29 = -1"
        /// <summary>
        /// SpEffect ID [29] (s32)
        /// </summary>
        /// <remarks>
        /// Resident special effect 29
        /// </remarks>
        public int SpEffectID29
        {
            get => (int)CellsByName["SpEffectID29"].Value;
            set => CellsByName["SpEffectID29"].Value = value;
        }


        // Def="s32 spEffectID30 = -1"
        /// <summary>
        /// SpEffect ID [30] (s32)
        /// </summary>
        /// <remarks>
        /// Resident special effect 30
        /// </remarks>
        public int SpEffectID30
        {
            get => (int)CellsByName["SpEffectID30"].Value;
            set => CellsByName["SpEffectID30"].Value = value;
        }


        // Def="s32 spEffectID31 = -1"
        /// <summary>
        /// SpEffect ID [31] (s32)
        /// </summary>
        /// <remarks>
        /// Resident special effects 31
        /// </remarks>
        public int SpEffectID31
        {
            get => (int)CellsByName["SpEffectID31"].Value;
            set => CellsByName["SpEffectID31"].Value = value;
        }


        // Def="f32 disableLockOnAng"
        /// <summary>
        /// Disable Lock-on Angle (f32)
        /// </summary>
        /// <remarks>
        /// Create a conical lock-on non-lockable area beneath the enemy. The angle of the size of the cone. Can be changed temporarily from TAE
        /// </remarks>
        public float DisableLockOnAngle
        {
            get => (float)CellsByName["DisableLockOnAngle"].Value;
            set => CellsByName["DisableLockOnAngle"].Value = value;
        }


        // Def="s8 clothOffLodLevel = -1"
        /// <summary>
        /// LOD Level to Disable Cloth Processing (s8)
        /// </summary>
        /// <remarks>
        /// Set the LOD level to turn off cross processing
        /// </remarks>
        public sbyte LODLevelToDisableClothProcessing
        {
            get => (sbyte)CellsByName["LODLevelToDisableClothProcessing"].Value;
            set => CellsByName["LODLevelToDisableClothProcessing"].Value = value;
        }


        // Def="u8 isUseFootIKNormalByUnduration:1"
        /// <summary>
        /// Use Foot IK for Undulating Character (u8)
        /// </summary>
        /// <remarks>
        /// Do you use the FootIK result to match your character to the undulations of the ground? Cannot be used for flying characters
        /// </remarks>
        public byte UseFootIKForUndulatingCharacter
        {
            get => (byte)CellsByName["UseFootIKForUndulatingCharacter"].Value;
            set => CellsByName["UseFootIKForUndulatingCharacter"].Value = value;
        }


        // Def="u8 attachHitInitializeDead:1"
        /// <summary>
        /// Attach to Ground upon Death (u8)
        /// </summary>
        /// <remarks>
        /// Whether to ground the capsule at the time of initial death
        /// </remarks>
        public byte AttachToGroundUponDeath
        {
            get => (byte)CellsByName["AttachToGroundUponDeath"].Value;
            set => CellsByName["AttachToGroundUponDeath"].Value = value;
        }


        // Def="u8 excludeGroupRewardCheck:1"
        /// <summary>
        /// Exclude Group Reward Check (u8)
        /// </summary>
        /// <remarks>
        /// Group reward: In the judgment of "all dead", characters with this parameter ○ are excluded from the judgment.
        /// </remarks>
        public byte ExcludeGroupRewardCheck
        {
            get => (byte)CellsByName["ExcludeGroupRewardCheck"].Value;
            set => CellsByName["ExcludeGroupRewardCheck"].Value = value;
        }


        // Def="u8 enableAILockDmyPoly_212:1 = 1"
        /// <summary>
        /// Enable AI Lock Dummy Poly [212] (u8)
        /// </summary>
        /// <remarks>
        /// Is Rock Damipoli (for Enemy) 212 Effective?
        /// </remarks>
        public byte EnableAILockDummyPoly212
        {
            get => (byte)CellsByName["EnableAILockDummyPoly212"].Value;
            set => CellsByName["EnableAILockDummyPoly212"].Value = value;
        }


        // Def="u8 enableAILockDmyPoly_213:1 = 1"
        /// <summary>
        /// Enable AI Lock Dummy Poly [213] (u8)
        /// </summary>
        /// <remarks>
        /// Is Rock Damipoli (for Enemy) 213 Effective?
        /// </remarks>
        public byte EnableAILockDummyPoly213
        {
            get => (byte)CellsByName["EnableAILockDummyPoly213"].Value;
            set => CellsByName["EnableAILockDummyPoly213"].Value = value;
        }


        // Def="u8 enableAILockDmyPoly_214:1 = 1"
        /// <summary>
        /// Enable AI Lock Dummy Poly [214] (u8)
        /// </summary>
        /// <remarks>
        /// Is Rock Damipoli (for Enemy) 214 Effective?
        /// </remarks>
        public byte EnableAILockDummyPoly214
        {
            get => (byte)CellsByName["EnableAILockDummyPoly214"].Value;
            set => CellsByName["EnableAILockDummyPoly214"].Value = value;
        }


        // Def="u8 disableActivateOpen_xb1:1"
        /// <summary>
        /// Disable Open Activation - XB1 (u8)
        /// </summary>
        /// <remarks>
        /// Excluded from open_XB1
        /// </remarks>
        public byte DisableOpenActivationXB1
        {
            get => (byte)CellsByName["DisableOpenActivationXB1"].Value;
            set => CellsByName["DisableOpenActivationXB1"].Value = value;
        }


        // Def="u8 disableActivateLegacy_xb1:1"
        /// <summary>
        /// Disable Legacy Activation - XB1 (u8)
        /// </summary>
        /// <remarks>
        /// Excluded from Legacy_XB1
        /// </remarks>
        public byte DisableLegacyActivationXB1
        {
            get => (byte)CellsByName["DisableLegacyActivationXB1"].Value;
            set => CellsByName["DisableLegacyActivationXB1"].Value = value;
        }


        // Def="s16 estusFlaskRecoveryParamId = -1"
        /// <summary>
        /// Flask Recovery Param ID (s16)
        /// </summary>
        /// <remarks>
        /// When the character dies, the data ID of the est usage count recovery parameter .xlsm, which is the same as the value, is acquired and the est bottle is recovered. Unused if -1
        /// </remarks>
        public short FlaskRecoveryParamID
        {
            get => (short)CellsByName["FlaskRecoveryParamID"].Value;
            set => CellsByName["FlaskRecoveryParamID"].Value = value;
        }


        // Def="s32 roleNameId = -1"
        /// <summary>
        /// Role Name ID (s32)
        /// </summary>
        /// <remarks>
        /// Specify the role name at the time of summoning. -1: Use the default role name of the target spirit body. 0: No display. 1 or more: Used as a text ID.
        /// </remarks>
        public int RoleNameID
        {
            get => (int)CellsByName["RoleNameID"].Value;
            set => CellsByName["RoleNameID"].Value = value;
        }


        // Def="u16 estusFlaskLotPoint"
        /// <summary>
        /// HP/FP Flask Recovery Chance (u16)
        /// </summary>
        /// <remarks>
        /// HP / MP est recovery probability when defeating an enemy. The numerator is obtained from the NPC para with 10000 as the denominator.
        /// </remarks>
        public ushort HPFPFlaskRecoveryChance
        {
            get => (ushort)CellsByName["HPFPFlaskRecoveryChance"].Value;
            set => CellsByName["HPFPFlaskRecoveryChance"].Value = value;
        }


        // Def="u16 hpEstusFlaskLotPoint"
        /// <summary>
        /// HP Flask Recovery Chance (u16)
        /// </summary>
        /// <remarks>
        /// Recovery probability of MP Est when defeating an enemy. The numerator is obtained from the NPC para with 10000 as the denominator.
        /// </remarks>
        public ushort HPFlaskRecoveryChance
        {
            get => (ushort)CellsByName["HPFlaskRecoveryChance"].Value;
            set => CellsByName["HPFlaskRecoveryChance"].Value = value;
        }


        // Def="u16 mpEstusFlaskLotPoint"
        /// <summary>
        /// FP Flask Recovery Chance (u16)
        /// </summary>
        /// <remarks>
        /// Recovery probability of MP Est when defeating an enemy. The numerator is obtained from the NPC para with 10000 as the denominator.
        /// </remarks>
        public ushort FPFlaskRecoveryChance
        {
            get => (ushort)CellsByName["FPFlaskRecoveryChance"].Value;
            set => CellsByName["FPFlaskRecoveryChance"].Value = value;
        }


        // Def="u16 estusFlaskRecovery_failedLotPointAdd"
        /// <summary>
        /// Missed HP/FP Flask Recovery - Bonus Chance (u16)
        /// </summary>
        /// <remarks>
        /// Next time probability increase value when you miss the HP / MP est recovery lottery. Addition value of numerator.
        /// </remarks>
        public ushort MissedHPFPFlaskRecoveryBonusChance
        {
            get => (ushort)CellsByName["MissedHPFPFlaskRecoveryBonusChance"].Value;
            set => CellsByName["MissedHPFPFlaskRecoveryBonusChance"].Value = value;
        }


        // Def="u16 hpEstusFlaskRecovery_failedLotPointAdd"
        /// <summary>
        /// Missed HP Flask Recovery - Bonus Chance (u16)
        /// </summary>
        /// <remarks>
        /// The next probability increase value when you miss the HP Est Recovery Lottery. Addition value of numerator.
        /// </remarks>
        public ushort MissedHPFlaskRecoveryBonusChance
        {
            get => (ushort)CellsByName["MissedHPFlaskRecoveryBonusChance"].Value;
            set => CellsByName["MissedHPFlaskRecoveryBonusChance"].Value = value;
        }


        // Def="u16 mpEstusFlaskRecovery_failedLotPointAdd"
        /// <summary>
        /// Missed FP Flask Recovery - Bonus Chance (u16)
        /// </summary>
        /// <remarks>
        /// The next probability increase value when the MP est recovery lottery is missed. Addition value of numerator.
        /// </remarks>
        public ushort MissedFPFlaskRecoveryBonusChance
        {
            get => (ushort)CellsByName["MissedFPFlaskRecoveryBonusChance"].Value;
            set => CellsByName["MissedFPFlaskRecoveryBonusChance"].Value = value;
        }


        // Def="s32 WanderGhostPhantomId = -1"
        /// <summary>
        /// Wandering Ghost Phantom ID (s32)
        /// </summary>
        /// <remarks>
        /// Phantom shader with ID specified only on the guest side Specify the phantom shader ID and make it an illusion
        /// </remarks>
        public int WanderingGhostPhantomID
        {
            get => (int)CellsByName["WanderingGhostPhantomID"].Value;
            set => CellsByName["WanderingGhostPhantomID"].Value = value;
        }


        // Def="f32 hearingHeadSize = -1"
        /// <summary>
        /// Listen Head Size (f32)
        /// </summary>
        /// <remarks>
        /// The offset size to be set instead of the capsule offset at the time of hearing judgment. Use this value as an offset only if it is set to 0 or higher.
        /// </remarks>
        public float ListenHeadSize
        {
            get => (float)CellsByName["ListenHeadSize"].Value;
            set => CellsByName["ListenHeadSize"].Value = value;
        }


        // Def="s16 SoundBankId = -1"
        /// <summary>
        /// Sound Bank ID (s16)
        /// </summary>
        /// <remarks>
        /// Sound bank ID can be specified -1: Use the bank of character ID (resource name)
        /// </remarks>
        public short SoundBankID
        {
            get => (short)CellsByName["SoundBankID"].Value;
            set => CellsByName["SoundBankID"].Value = value;
        }


        // Def="u8 forwardUndulationLimit"
        /// <summary>
        /// Forward Undulation Limit (u8)
        /// </summary>
        /// <remarks>
        /// The upper limit angle when adjusting the front-back angle to the undulation. If the total length is long, it is better to set it lower.
        /// </remarks>
        public byte ForwardUndulationLimit
        {
            get => (byte)CellsByName["ForwardUndulationLimit"].Value;
            set => CellsByName["ForwardUndulationLimit"].Value = value;
        }


        // Def="u8 sideUndulationLimit"
        /// <summary>
        /// Side Undulation Limit (u8)
        /// </summary>
        /// <remarks>
        /// Upper limit angle when adjusting the left and right angles to the undulations. If the total length is long, it is better to set it lower.
        /// </remarks>
        public byte SideUndulationLimit
        {
            get => (byte)CellsByName["SideUndulationLimit"].Value;
            set => CellsByName["SideUndulationLimit"].Value = value;
        }


        // Def="f32 deactiveMoveSpeed"
        /// <summary>
        /// Platoon - Deactivation Movement Speed (f32)
        /// </summary>
        /// <remarks>
        /// Platoon Deactive Movement Speed [m / s]
        /// </remarks>
        public float PlatoonDeactivationMovementSpeed
        {
            get => (float)CellsByName["PlatoonDeactivationMovementSpeed"].Value;
            set => CellsByName["PlatoonDeactivationMovementSpeed"].Value = value;
        }


        // Def="f32 deactiveMoveDist"
        /// <summary>
        /// Platoon - Deactivation Distance (f32)
        /// </summary>
        /// <remarks>
        /// Distance to switch to platoon deactive movement [m]
        /// </remarks>
        public float PlatoonDeactivationDistance
        {
            get => (float)CellsByName["PlatoonDeactivationDistance"].Value;
            set => CellsByName["PlatoonDeactivationDistance"].Value = value;
        }


        // Def="f32 enableSoundObjDist = 48"
        /// <summary>
        /// Sound Source Validity - Player Distance (f32)
        /// </summary>
        /// <remarks>
        /// The distance from the player for which the character sound source is valid. -1: Effective at all distances
        /// </remarks>
        public float SoundSourceValidityPlayerDistance
        {
            get => (float)CellsByName["SoundSourceValidityPlayerDistance"].Value;
            set => CellsByName["SoundSourceValidityPlayerDistance"].Value = value;
        }


        // Def="f32 undulationCorrectGain = 0.1"
        /// <summary>
        /// Undulation Angle Correction (f32)
        /// </summary>
        /// <remarks>
        /// Set the speed when adjusting the angle to the undulations
        /// </remarks>
        public float UndulationAngleCorrection
        {
            get => (float)CellsByName["UndulationAngleCorrection"].Value;
            set => CellsByName["UndulationAngleCorrection"].Value = value;
        }


        // Def="s16 autoFootEffectDecalBaseId2 = -1"
        /// <summary>
        /// Automatic Foot Effect - Decal Base ID [2] (s16)
        /// </summary>
        /// <remarks>
        /// Decal to be attached when a foot effect occurs. Floor material is also taken into consideration
        /// </remarks>
        public short AutomaticFootEffectDecalBaseID2
        {
            get => (short)CellsByName["AutomaticFootEffectDecalBaseID2"].Value;
            set => CellsByName["AutomaticFootEffectDecalBaseID2"].Value = value;
        }


        // Def="s16 autoFootEffectDecalBaseId3 = -1"
        /// <summary>
        /// Automatic Foot Effect - Decal Base ID [3] (s16)
        /// </summary>
        /// <remarks>
        /// Decal to be attached when a foot effect occurs. Floor material is also taken into consideration
        /// </remarks>
        public short AutomaticFootEffectDecalBaseID3
        {
            get => (short)CellsByName["AutomaticFootEffectDecalBaseID3"].Value;
            set => CellsByName["AutomaticFootEffectDecalBaseID3"].Value = value;
        }


        // Def="s16 RetargetReferenceChrId = -1"
        /// <summary>
        /// Motion Re-target Reference Chr ID (s16)
        /// </summary>
        /// <remarks>
        /// Character ID to be referred to when specifying the motion retarget destination
        /// </remarks>
        public short MotionReTargetReferenceChrID
        {
            get => (short)CellsByName["MotionReTargetReferenceChrID"].Value;
            set => CellsByName["MotionReTargetReferenceChrID"].Value = value;
        }


        // Def="s16 SfxResBankId = -1"
        /// <summary>
        /// SFX Resource Bank ID (s16)
        /// </summary>
        /// <remarks>
        /// SFX resource bank ID can be specified -1: Use the bank of character ID (resource name)
        /// </remarks>
        public short SFXResourceBankID
        {
            get => (short)CellsByName["SFXResourceBankID"].Value;
            set => CellsByName["SFXResourceBankID"].Value = value;
        }


        // Def="f32 updateActivatePriolity = 1"
        /// <summary>
        /// Activation Update Priority (f32)
        /// </summary>
        /// <remarks>
        /// Used to determine the activation / renewal level. The larger it is, the lower the update level will be even if you are far from the player.
        /// </remarks>
        public float ActivationUpdatePriority
        {
            get => (float)CellsByName["ActivationUpdatePriority"].Value;
            set => CellsByName["ActivationUpdatePriority"].Value = value;
        }


        // Def="u8 chrNavimeshFlag_Alive"
        /// <summary>
        /// Chr Navmesh Flag - Alive (u8)
        /// </summary>
        /// <remarks>
        /// Flag the value of the touching Nav Mesh while the character is alive. Does not follow the movement.
        /// </remarks>
        public byte ChrNavmeshFlagAlive
        {
            get => (byte)CellsByName["ChrNavmeshFlagAlive"].Value;
            set => CellsByName["ChrNavmeshFlagAlive"].Value = value;
        }


        // Def="u8 chrNavimeshFlag_Dead"
        /// <summary>
        /// Chr Navmesh Flag - Dead (u8)
        /// </summary>
        /// <remarks>
        /// Flag the value on the touching Nav Mesh while the character is dying. Does not follow the movement.
        /// </remarks>
        public byte ChrNavmeshFlagDead
        {
            get => (byte)CellsByName["ChrNavmeshFlagDead"].Value;
            set => CellsByName["ChrNavmeshFlagDead"].Value = value;
        }



        // Def="u8 wheelRotType"
        /// <summary>
        /// Wheel Rotation Type (u8)
        /// </summary>
        /// <remarks>
        /// Wheel control type
        /// </remarks>
        public byte WheelRotationType
        {
            get => (byte)CellsByName["WheelRotationType"].Value;
            set => CellsByName["WheelRotationType"].Value = value;
        }


        // Def="f32 wheelRotRadius"
        /// <summary>
        /// Wheel Rotation Radius (f32)
        /// </summary>
        /// <remarks>
        /// Specify the radius of the wheel [m]
        /// </remarks>
        public float WheelRotationRadius
        {
            get => (float)CellsByName["WheelRotationRadius"].Value;
            set => CellsByName["WheelRotationRadius"].Value = value;
        }


        // Def="f32 retargetMoveRate = 1"
        /// <summary>
        /// Retarget Movement Rate (f32)
        /// </summary>
        /// <remarks>
        /// Magnification of movement amount at the time of retargeting
        /// </remarks>
        public float RetargetMovementRate
        {
            get => (float)CellsByName["RetargetMovementRate"].Value;
            set => CellsByName["RetargetMovementRate"].Value = value;
        }


        // Def="f32 ladderWarpOffset"
        /// <summary>
        /// Ladder - Warp Z Offset (f32)
        /// </summary>
        /// <remarks>
        /// Offsets along the Damipoly Z-axis at the specified value. Both positive and negative numbers can be specified.
        /// </remarks>
        public float LadderWarpZOffset
        {
            get => (float)CellsByName["LadderWarpZOffset"].Value;
            set => CellsByName["LadderWarpZOffset"].Value = value;
        }


        // Def="s32 loadAssetId = -1"
        /// <summary>
        /// Load Asset ID (s32)
        /// </summary>
        /// <remarks>
        /// Asset ID to be read in connection with character loading (for dynamic generation of characters, etc.).
        /// </remarks>
        public int LoadAssetID
        {
            get => (int)CellsByName["LoadAssetID"].Value;
            set => CellsByName["LoadAssetID"].Value = value;
        }


        // Def="s32 overlapCameraDmypolyId = -1"
        /// <summary>
        /// Overlap Camera - Dummy Poly ID (s32)
        /// </summary>
        /// <remarks>
        /// Set the Damipoly ID (220-227) to enable the overlap camera. If it is -1, it will be invalid.
        /// </remarks>
        public int OverlapCameraDummyPolyID
        {
            get => (int)CellsByName["OverlapCameraDummyPolyID"].Value;
            set => CellsByName["OverlapCameraDummyPolyID"].Value = value;
        }


        // Def="s32 residentMaterialExParamId00 = -1"
        /// <summary>
        /// Material Ex Param ID [0] (s32)
        /// </summary>
        /// <remarks>
        /// Resident Material Expansion Para ID0
        /// </remarks>
        public int MaterialExParamID0
        {
            get => (int)CellsByName["MaterialExParamID0"].Value;
            set => CellsByName["MaterialExParamID0"].Value = value;
        }


        // Def="s32 residentMaterialExParamId01 = -1"
        /// <summary>
        /// Material Ex Param ID [1] (s32)
        /// </summary>
        /// <remarks>
        /// Resident Material Expansion Para ID1
        /// </remarks>
        public int MaterialExParamID1
        {
            get => (int)CellsByName["MaterialExParamID1"].Value;
            set => CellsByName["MaterialExParamID1"].Value = value;
        }


        // Def="s32 residentMaterialExParamId02 = -1"
        /// <summary>
        /// Material Ex Param ID [2] (s32)
        /// </summary>
        /// <remarks>
        /// Resident Material Expansion Para ID2
        /// </remarks>
        public int MaterialExParamID2
        {
            get => (int)CellsByName["MaterialExParamID2"].Value;
            set => CellsByName["MaterialExParamID2"].Value = value;
        }


        // Def="s32 residentMaterialExParamId03 = -1"
        /// <summary>
        /// Material Ex Param ID [3] (s32)
        /// </summary>
        /// <remarks>
        /// Resident Material Expansion Para ID3
        /// </remarks>
        public int MaterialExParamID3
        {
            get => (int)CellsByName["MaterialExParamID3"].Value;
            set => CellsByName["MaterialExParamID3"].Value = value;
        }


        // Def="s32 residentMaterialExParamId04 = -1"
        /// <summary>
        /// Material Ex Param ID [4] (s32)
        /// </summary>
        /// <remarks>
        /// Resident Material Expansion Para ID4
        /// </remarks>
        public int MaterialExParamID4
        {
            get => (int)CellsByName["MaterialExParamID4"].Value;
            set => CellsByName["MaterialExParamID4"].Value = value;
        }


        // Def="s32 sleepCollectorItemLotId_enemy = -1"
        /// <summary>
        /// Sleep Collector - Enemy Item Lot (s32)
        /// </summary>
        /// <remarks>
        /// Specify the lottery ID_for enemies of the item to be acquired when collecting Nemuri. Please set only one of them.
        /// </remarks>
        public int SleepCollectorEnemyItemLot
        {
            get => (int)CellsByName["SleepCollectorEnemyItemLot"].Value;
            set => CellsByName["SleepCollectorEnemyItemLot"].Value = value;
        }


        // Def="s32 sleepCollectorItemLotId_map = -1"
        /// <summary>
        /// Sleep Collector - Map Item Lot (s32)
        /// </summary>
        /// <remarks>
        /// Specify for the lottery ID_map of the item to be acquired when collecting Nemuri. Please set only one of them.
        /// </remarks>
        public int SleepCollectorMapItemLot
        {
            get => (int)CellsByName["SleepCollectorMapItemLot"].Value;
            set => CellsByName["SleepCollectorMapItemLot"].Value = value;
        }


        // Def="f32 footIkErrorOnGain = 0.1"
        /// <summary>
        /// Foot IK - Error On Gain (f32)
        /// </summary>
        /// <remarks>
        /// FootIK Appearance height correction ON gain value
        /// </remarks>
        public float FootIKErrorOnGain
        {
            get => (float)CellsByName["FootIKErrorOnGain"].Value;
            set => CellsByName["FootIKErrorOnGain"].Value = value;
        }


        // Def="f32 footIkErrorOffGain = 0.4"
        /// <summary>
        /// Foot IK - Error Off Gain (f32)
        /// </summary>
        /// <remarks>
        /// FootIK Appearance height correction OFF gain value
        /// </remarks>
        public float FootIKErrorOffGain
        {
            get => (float)CellsByName["FootIKErrorOffGain"].Value;
            set => CellsByName["FootIKErrorOffGain"].Value = value;
        }


        // Def="s16 SoundAddBankId = -1"
        /// <summary>
        /// Sound Add Bank ID (s16)
        /// </summary>
        /// <remarks>
        /// You can specify an additional sound bank ID -1 or 0: No addition (SEQ 16135)
        /// </remarks>
        public short SoundAddBankID
        {
            get => (short)CellsByName["SoundAddBankID"].Value;
            set => CellsByName["SoundAddBankID"].Value = value;
        }


        // Def="u8 materialVariationValue"
        /// <summary>
        /// Material Variation Value (u8)
        /// </summary>
        /// <remarks>
        /// It is a value used in combination with the defense material to classify abnormal conditions, damage SFX, and SE. SEQ16473
        /// </remarks>
        public byte MaterialVariationValue
        {
            get => (byte)CellsByName["MaterialVariationValue"].Value;
            set => CellsByName["MaterialVariationValue"].Value = value;
        }


        // Def="u8 materialVariationValue_Weak"
        /// <summary>
        /// Weak Point - Material Variation Value (u8)
        /// </summary>
        /// <remarks>
        /// It is a value used for variation of abnormal condition, damage SFX, SE in combination with weak point defense material. SEQ16473
        /// </remarks>
        public byte WeakPointMaterialVariationValue
        {
            get => (byte)CellsByName["WeakPointMaterialVariationValue"].Value;
            set => CellsByName["WeakPointMaterialVariationValue"].Value = value;
        }


        // Def="f32 superArmorDurability"
        /// <summary>
        /// Poise (f32)
        /// </summary>
        /// <remarks>
        /// Super armor durability value
        /// </remarks>
        public float Poise
        {
            get => (float)CellsByName["Poise"].Value;
            set => CellsByName["Poise"].Value = value;
        }


        // Def="f32 saRecoveryRate = 1"
        /// <summary>
        /// Poise Recovery (f32)
        /// </summary>
        /// <remarks>
        /// Correct the SA recovery speed by multiplying the SA basic recovery amount
        /// </remarks>
        public float PoiseRecovery
        {
            get => (float)CellsByName["PoiseRecovery"].Value;
            set => CellsByName["PoiseRecovery"].Value = value;
        }


        // Def="f32 saGuardCutRate"
        /// <summary>
        /// Guard Absorption %: Poise Damage (f32)
        /// </summary>
        /// <remarks>
        /// Cut rate of SA damage when guard is successful
        /// </remarks>
        public float GuardAbsorptionPercentPoiseDamage
        {
            get => (float)CellsByName["GuardAbsorptionPercentPoiseDamage"].Value;
            set => CellsByName["GuardAbsorptionPercentPoiseDamage"].Value = value;
        }


        // Def="s32 resistCorrectId_blood = -1"
        /// <summary>
        /// Resist Correct ID: Hemorrhage (s32)
        /// </summary>
        /// <remarks>
        /// When the abnormal condition is activated, the maximum value is temporarily changed by using the setting value of the abnormal condition resistance correction parameter.
        /// </remarks>
        public int ResistCorrectIDHemorrhage
        {
            get => (int)CellsByName["ResistCorrectIDHemorrhage"].Value;
            set => CellsByName["ResistCorrectIDHemorrhage"].Value = value;
        }


        // Def="s32 resistCorrectId_curse = -1"
        /// <summary>
        /// Resist Correct ID: Blight (s32)
        /// </summary>
        /// <remarks>
        /// When the abnormal condition is activated, the maximum value is temporarily changed by using the set value of the abnormal condition resistance correction parameter.
        /// </remarks>
        public int ResistCorrectIDBlight
        {
            get => (int)CellsByName["ResistCorrectIDBlight"].Value;
            set => CellsByName["ResistCorrectIDBlight"].Value = value;
        }


        // Def="s32 resistCorrectId_freeze = -1"
        /// <summary>
        /// Resist Correct ID: Frostbite (s32)
        /// </summary>
        /// <remarks>
        /// When the abnormal condition is activated, the maximum value is temporarily changed by using the setting value of the abnormal condition resistance correction parameter.
        /// </remarks>
        public int ResistCorrectIDFrostbite
        {
            get => (int)CellsByName["ResistCorrectIDFrostbite"].Value;
            set => CellsByName["ResistCorrectIDFrostbite"].Value = value;
        }


        // Def="s32 resistCorrectId_sleep = -1"
        /// <summary>
        /// Resist Correct ID: Sleep (s32)
        /// </summary>
        /// <remarks>
        /// When the abnormal condition is activated, the maximum value is temporarily changed by using the set value of the abnormal condition resistance correction parameter.
        /// </remarks>
        public int ResistCorrectIDSleep
        {
            get => (int)CellsByName["ResistCorrectIDSleep"].Value;
            set => CellsByName["ResistCorrectIDSleep"].Value = value;
        }


        // Def="s32 resistCorrectId_madness = -1"
        /// <summary>
        /// Resist Correct ID: Madness (s32)
        /// </summary>
        /// <remarks>
        /// When the abnormal condition is activated, the maximum value is temporarily changed by using the set value of the abnormal condition resistance correction parameter.
        /// </remarks>
        public int ResistCorrectIDMadness
        {
            get => (int)CellsByName["ResistCorrectIDMadness"].Value;
            set => CellsByName["ResistCorrectIDMadness"].Value = value;
        }


        // Def="u32 chrDeadTutorialFlagId"
        /// <summary>
        /// Chr Dead Tutorial Flag ID (u32)
        /// </summary>
        /// <remarks>
        /// Event flag ID for the tutorial when the character is defeated for the first time. Flag ON when the character dies.
        /// </remarks>
        public uint ChrDeadTutorialFlagID
        {
            get => (uint)CellsByName["ChrDeadTutorialFlagID"].Value;
            set => CellsByName["ChrDeadTutorialFlagID"].Value = value;
        }


        // Def="f32 stepDispInterpolateTime = 0.5"
        /// <summary>
        /// Step Display Interpolation Time (f32)
        /// </summary>
        /// <remarks>
        /// Step crossing display interpolation time
        /// </remarks>
        public float StepDisplayInterpolationTime
        {
            get => (float)CellsByName["StepDisplayInterpolationTime"].Value;
            set => CellsByName["StepDisplayInterpolationTime"].Value = value;
        }


        // Def="f32 stepDispInterpolateTriggerValue = 0.6"
        /// <summary>
        /// Step Display Interpolation Trigger Value (f32)
        /// </summary>
        /// <remarks>
        /// Step crossing display activation judgment value
        /// </remarks>
        public float StepDisplayInterpolationTriggerValue
        {
            get => (float)CellsByName["StepDisplayInterpolationTriggerValue"].Value;
            set => CellsByName["StepDisplayInterpolationTriggerValue"].Value = value;
        }


        // Def="f32 lockScoreOffset"
        /// <summary>
        /// Lock Score Offset (f32)
        /// </summary>
        /// <remarks>
        /// Lock score correction value
        /// </remarks>
        public float LockScoreOffset
        {
            get => (float)CellsByName["LockScoreOffset"].Value;
            set => CellsByName["LockScoreOffset"].Value = value;
        }


        // Def="dummy8 pad12[8]"
        /// <summary>
        /// Padding 12 (dummy8)
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        public object Padding12
        {
            get => (object)CellsByName["Padding12"].Value;
            set => CellsByName["Padding12"].Value = value;
        }

    }
}

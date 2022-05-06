
namespace StronglyTypedParams
{
    public class GameSystemCommonParam : ParamRow
    {
        public GameSystemCommonParam() : base()
        {
        }


        // Def="f32 baseToughnessRecoverTime"
        /// <summary>
        /// Base Toughness Recovery Time (f32)
        /// </summary>
        /// <remarks>
        /// This is the basic value of toughness recovery time. (Seconds)
        /// </remarks>
        public float BaseToughnessRecoveryTime
        {
            get => (float)CellsByName["BaseToughnessRecoveryTime"].Value;
            set => CellsByName["BaseToughnessRecoveryTime"].Value = value;
        }


        // Def="s32 chrEventTrun_byLeft90"
        /// <summary>
        /// Chr Event Turn - By Left 90 (s32)
        /// </summary>
        /// <remarks>
        /// This is a 90 ° left turn animation for the "Character Turn" event.
        /// </remarks>
        public int ChrEventTurnByLeft90
        {
            get => (int)CellsByName["ChrEventTurnByLeft90"].Value;
            set => CellsByName["ChrEventTurnByLeft90"].Value = value;
        }


        // Def="s32 chrEventTrun_byRight90"
        /// <summary>
        /// Chr Event Turn - By Right 90 (s32)
        /// </summary>
        /// <remarks>
        /// This is a 90 ° right turn animation for the "Character Turn" event.
        /// </remarks>
        public int ChrEventTurnByRight90
        {
            get => (int)CellsByName["ChrEventTurnByRight90"].Value;
            set => CellsByName["ChrEventTurnByRight90"].Value = value;
        }


        // Def="s32 chrEventTrun_byLeft180"
        /// <summary>
        /// Chr Event Turn - By Left 180 (s32)
        /// </summary>
        /// <remarks>
        /// This is a 180 ° left turn animation for the "Character Turn" event.
        /// </remarks>
        public int ChrEventTurnByLeft180
        {
            get => (int)CellsByName["ChrEventTurnByLeft180"].Value;
            set => CellsByName["ChrEventTurnByLeft180"].Value = value;
        }


        // Def="s32 chrEventTrun_byRight180"
        /// <summary>
        /// Chr Event Turn - By Right 180 (s32)
        /// </summary>
        /// <remarks>
        /// This is a 180 ° right turn animation for the "Character Turn" event.
        /// </remarks>
        public int ChrEventTurnByRight180
        {
            get => (int)CellsByName["ChrEventTurnByRight180"].Value;
            set => CellsByName["ChrEventTurnByRight180"].Value = value;
        }


        // Def="s16 chrEventTrun_90TurnStartAngle"
        /// <summary>
        /// Chr Event Turn - 90 Turn Start Angle (s16)
        /// </summary>
        /// <remarks>
        /// The starting angle of the angle to which the 90 ° swivel animation for the "Character Swirl" event is applied. If the event starts at an angle smaller than this angle, a system turn will occur.
        /// </remarks>
        public short ChrEventTurn90TurnStartAngle
        {
            get => (short)CellsByName["ChrEventTurn90TurnStartAngle"].Value;
            set => CellsByName["ChrEventTurn90TurnStartAngle"].Value = value;
        }


        // Def="s16 chrEventTrun_180TurnStartAngle"
        /// <summary>
        /// Chr Event Turn - 180 Turn Start Angle (s16)
        /// </summary>
        /// <remarks>
        /// The starting angle of the angle to which the 180 ° swivel animation for the "Character Swirl" event is applied.
        /// </remarks>
        public short ChrEventTurn180TurnStartAngle
        {
            get => (short)CellsByName["ChrEventTurn180TurnStartAngle"].Value;
            set => CellsByName["ChrEventTurn180TurnStartAngle"].Value = value;
        }


        // Def="f32 stealthAtkDamageRate"
        /// <summary>
        /// Stealth Attack Multiplier (f32)
        /// </summary>
        /// <remarks>
        /// Stealth attack damage multiplier
        /// </remarks>
        public float StealthAttackMultiplier
        {
            get => (float)CellsByName["StealthAttackMultiplier"].Value;
            set => CellsByName["StealthAttackMultiplier"].Value = value;
        }


        // Def="f32 flickDamageCutRateSuccessGurad"
        /// <summary>
        /// Weapon Rebel Absorption on Successful Guard (f32)
        /// </summary>
        /// <remarks>
        /// Damage cut rate when the guard is successful when repelled. Multiply the final damage
        /// </remarks>
        public float WeaponRebelAbsorptionOnSuccessfulGuard
        {
            get => (float)CellsByName["WeaponRebelAbsorptionOnSuccessfulGuard"].Value;
            set => CellsByName["WeaponRebelAbsorptionOnSuccessfulGuard"].Value = value;
        }


        // Def="f32 npcTalkAnimBeginDiffAngle"
        /// <summary>
        /// NPC Talk Anim - Start Diff Angle (f32)
        /// </summary>
        /// <remarks>
        /// This is the difference angle at which the animation playback of the motion during the conversation of the NPC conversation starts.
        /// </remarks>
        public float NPCTalkAnimStartDiffAngle
        {
            get => (float)CellsByName["NPCTalkAnimStartDiffAngle"].Value;
            set => CellsByName["NPCTalkAnimStartDiffAngle"].Value = value;
        }


        // Def="f32 npcTalkAnimEndDiffAngle"
        /// <summary>
        /// NPC Talk Anim - End Diff Angle (f32)
        /// </summary>
        /// <remarks>
        /// This is the difference angle at which the animation playback of the motion during the conversation of the NPC conversation is stopped.
        /// </remarks>
        public float NPCTalkAnimEndDiffAngle
        {
            get => (float)CellsByName["NPCTalkAnimEndDiffAngle"].Value;
            set => CellsByName["NPCTalkAnimEndDiffAngle"].Value = value;
        }


        // Def="s32 sleepCollectorItemActionButtonParamId = -1"
        /// <summary>
        /// Sleep Collector Item Action Button Param ID (s32)
        /// </summary>
        /// <remarks>
        /// Nemuri Item Acquisition Range_Action Button Para ID. TAE flag Used as the default value when not overwriting with "Event> Nemuri item registration".
        /// </remarks>
        public int SleepCollectorItemActionButtonParamID
        {
            get => (int)CellsByName["SleepCollectorItemActionButtonParamID"].Value;
            set => CellsByName["SleepCollectorItemActionButtonParamID"].Value = value;
        }


        // Def="f32 allowUseBuddyItem_sfxInterval"
        /// <summary>
        /// Spirit Summon Item - SFX Interval (f32)
        /// </summary>
        /// <remarks>
        /// Buddy item permission_SFX occurrence interval [s]
        /// </remarks>
        public float SpiritSummonItemSFXInterval
        {
            get => (float)CellsByName["SpiritSummonItemSFXInterval"].Value;
            set => CellsByName["SpiritSummonItemSFXInterval"].Value = value;
        }


        // Def="s32 allowUseBuddyItem_sfxDmyPolyId = -1"
        /// <summary>
        /// Spirit Summon Item - SFX Dummy Poly ID (s32)
        /// </summary>
        /// <remarks>
        /// Buddy Item Permission_SFX Occurrence PC Damipoli ID
        /// </remarks>
        public int SpiritSummonItemSFXDummyPolyID
        {
            get => (int)CellsByName["SpiritSummonItemSFXDummyPolyID"].Value;
            set => CellsByName["SpiritSummonItemSFXDummyPolyID"].Value = value;
        }


        // Def="s32 allowUseBuddyItem_sfxDmyPolyId_horse = -1"
        /// <summary>
        /// Spirit Summon Item - SFX Dummy Poly ID (Horse) (s32)
        /// </summary>
        /// <remarks>
        /// Buddy item permission_SFX generated horse Damipoli ID_when riding
        /// </remarks>
        public int SpiritSummonItemSFXDummyPolyIDHorse
        {
            get => (int)CellsByName["SpiritSummonItemSFXDummyPolyIDHorse"].Value;
            set => CellsByName["SpiritSummonItemSFXDummyPolyIDHorse"].Value = value;
        }


        // Def="s32 allowUseBuddyItem_sfxId = -1"
        /// <summary>
        /// Spirit Summon Item - SFX ID (s32)
        /// </summary>
        /// <remarks>
        /// Buddy Item Permission_Occurrence SFXID
        /// </remarks>
        public int SpiritSummonItemSFXID
        {
            get => (int)CellsByName["SpiritSummonItemSFXID"].Value;
            set => CellsByName["SpiritSummonItemSFXID"].Value = value;
        }


        // Def="f32 onBuddySummon_inActivateRange_sfxInterval"
        /// <summary>
        /// Spirit Summon - Activation Range - SFX Interval (f32)
        /// </summary>
        /// <remarks>
        /// Buddy Summoning_Initial Range_SFX Occurrence Interval [s]
        /// </remarks>
        public float SpiritSummonActivationRangeSFXInterval
        {
            get => (float)CellsByName["SpiritSummonActivationRangeSFXInterval"].Value;
            set => CellsByName["SpiritSummonActivationRangeSFXInterval"].Value = value;
        }


        // Def="s32 onBuddySummon_inActivateRange_sfxDmyPolyId = -1"
        /// <summary>
        /// Spirit Summon - Activation Range - SFX Dummy Poly ID (s32)
        /// </summary>
        /// <remarks>
        /// Buddy Summoning_Initial Range_SFX Occurrence PC Damipoli ID
        /// </remarks>
        public int SpiritSummonActivationRangeSFXDummyPolyID
        {
            get => (int)CellsByName["SpiritSummonActivationRangeSFXDummyPolyID"].Value;
            set => CellsByName["SpiritSummonActivationRangeSFXDummyPolyID"].Value = value;
        }


        // Def="s32 onBuddySummon_inActivateRange_sfxDmyPolyId_horse = -1"
        /// <summary>
        /// Spirit Summon - Activation Range - SFX Dummy Poly ID (Horse) (s32)
        /// </summary>
        /// <remarks>
        /// Buddy Summoning_Initial Range_SFX Generated Horse Damipoli ID_When Riding
        /// </remarks>
        public int SpiritSummonActivationRangeSFXDummyPolyIDHorse
        {
            get => (int)CellsByName["SpiritSummonActivationRangeSFXDummyPolyIDHorse"].Value;
            set => CellsByName["SpiritSummonActivationRangeSFXDummyPolyIDHorse"].Value = value;
        }


        // Def="s32 onBuddySummon_inActivateRange_sfxId = -1"
        /// <summary>
        /// Spirit Summon - Activation Range - SFX ID (s32)
        /// </summary>
        /// <remarks>
        /// Buddy Summoning_Initial Range_Occurrence SFXID
        /// </remarks>
        public int SpiritSummonActivationRangeSFXID
        {
            get => (int)CellsByName["SpiritSummonActivationRangeSFXID"].Value;
            set => CellsByName["SpiritSummonActivationRangeSFXID"].Value = value;
        }


        // Def="s32 onBuddySummon_inActivateRange_spEffectId_pc = -1"
        /// <summary>
        /// Spirit Summon - Activation Range - Player SpEffect ID (s32)
        /// </summary>
        /// <remarks>
        /// Buddy Summoning_Initial range Special effect ID_For PC
        /// </remarks>
        public int SpiritSummonActivationRangePlayerSpEffectID
        {
            get => (int)CellsByName["SpiritSummonActivationRangePlayerSpEffectID"].Value;
            set => CellsByName["SpiritSummonActivationRangePlayerSpEffectID"].Value = value;
        }


        // Def="s32 onBuddySummon_inWarnRange_spEffectId_pc = -1"
        /// <summary>
        /// Spirit Summon - Warn Range - Player SpEffect ID (s32)
        /// </summary>
        /// <remarks>
        /// Buddy Summoning_Warning Range Special Effect ID_For PC
        /// </remarks>
        public int SpiritSummonWarnRangePlayerSpEffectID
        {
            get => (int)CellsByName["SpiritSummonWarnRangePlayerSpEffectID"].Value;
            set => CellsByName["SpiritSummonWarnRangePlayerSpEffectID"].Value = value;
        }


        // Def="s32 onBuddySummon_atBuddyUnsummon_spEffectId_pc = -1"
        /// <summary>
        /// Spirit Summon - Unsummoned - Player SpEffect ID (s32)
        /// </summary>
        /// <remarks>
        /// Buddy Summoning_Buddy Return Special Effect ID_For PC
        /// </remarks>
        public int SpiritSummonUnsummonedPlayerSpEffectID
        {
            get => (int)CellsByName["SpiritSummonUnsummonedPlayerSpEffectID"].Value;
            set => CellsByName["SpiritSummonUnsummonedPlayerSpEffectID"].Value = value;
        }


        // Def="s32 onBuddySummon_inWarnRange_spEffectId_buddy = -1"
        /// <summary>
        /// Spirit Summon - Warn Range - Spirit SpEffect ID (s32)
        /// </summary>
        /// <remarks>
        /// Buddy Summoning_Warning Range Special Effect ID_For Buddy
        /// </remarks>
        public int SpiritSummonWarnRangeSpiritSpEffectID
        {
            get => (int)CellsByName["SpiritSummonWarnRangeSpiritSpEffectID"].Value;
            set => CellsByName["SpiritSummonWarnRangeSpiritSpEffectID"].Value = value;
        }


        // Def="u8 morningIngameHour"
        /// <summary>
        /// Morning - In-game Hour (u8)
        /// </summary>
        /// <remarks>
        /// Morning in-game time (hours). Used in conversation.
        /// </remarks>
        public byte MorningInGameHour
        {
            get => (byte)CellsByName["MorningInGameHour"].Value;
            set => CellsByName["MorningInGameHour"].Value = value;
        }


        // Def="u8 morningIngameMinute"
        /// <summary>
        /// Morning - In-game Minute (u8)
        /// </summary>
        /// <remarks>
        /// Morning in-game time (minutes). Used in conversation.
        /// </remarks>
        public byte MorningInGameMinute
        {
            get => (byte)CellsByName["MorningInGameMinute"].Value;
            set => CellsByName["MorningInGameMinute"].Value = value;
        }


        // Def="u8 morningIngameSecond"
        /// <summary>
        /// Morning - In-game Second (u8)
        /// </summary>
        /// <remarks>
        /// Morning in-game time (seconds). Used in conversation.
        /// </remarks>
        public byte MorningInGameSecond
        {
            get => (byte)CellsByName["MorningInGameSecond"].Value;
            set => CellsByName["MorningInGameSecond"].Value = value;
        }


        // Def="u8 noonIngameHour"
        /// <summary>
        /// Noon - In-game Hour (u8)
        /// </summary>
        /// <remarks>
        /// Daytime in-game time (hours). Used in conversation.
        /// </remarks>
        public byte NoonInGameHour
        {
            get => (byte)CellsByName["NoonInGameHour"].Value;
            set => CellsByName["NoonInGameHour"].Value = value;
        }


        // Def="u8 noonIngameMinute"
        /// <summary>
        /// Noon - In-game Minute (u8)
        /// </summary>
        /// <remarks>
        /// Daytime in-game time (minutes). Used in conversation.
        /// </remarks>
        public byte NoonInGameMinute
        {
            get => (byte)CellsByName["NoonInGameMinute"].Value;
            set => CellsByName["NoonInGameMinute"].Value = value;
        }


        // Def="u8 noonIngameSecond"
        /// <summary>
        /// Noon - In-game Second (u8)
        /// </summary>
        /// <remarks>
        /// Daytime in-game time (seconds). Used in conversation.
        /// </remarks>
        public byte NoonInGameSecond
        {
            get => (byte)CellsByName["NoonInGameSecond"].Value;
            set => CellsByName["NoonInGameSecond"].Value = value;
        }


        // Def="u8 nightIngameHour"
        /// <summary>
        /// Night - In-game Hour (u8)
        /// </summary>
        /// <remarks>
        /// Night in-game time (hours). Used in conversation.
        /// </remarks>
        public byte NightInGameHour
        {
            get => (byte)CellsByName["NightInGameHour"].Value;
            set => CellsByName["NightInGameHour"].Value = value;
        }


        // Def="u8 nightIngameMinute"
        /// <summary>
        /// Night - In-game Minute (u8)
        /// </summary>
        /// <remarks>
        /// Night in-game time (minutes). Used in conversation.
        /// </remarks>
        public byte NightInGameMinute
        {
            get => (byte)CellsByName["NightInGameMinute"].Value;
            set => CellsByName["NightInGameMinute"].Value = value;
        }


        // Def="u8 nightIngameSecond"
        /// <summary>
        /// Night - In-game Second (u8)
        /// </summary>
        /// <remarks>
        /// Night in-game time (seconds). Used in conversation.
        /// </remarks>
        public byte NightInGameSecond
        {
            get => (byte)CellsByName["NightInGameSecond"].Value;
            set => CellsByName["NightInGameSecond"].Value = value;
        }


        // Def="u8 aiSightRateStart_Morning_Hour"
        /// <summary>
        /// AI Sight Rate Start - Morning Hour (u8)
        /// </summary>
        /// <remarks>
        /// AI visibility magnification_morning_start time (hour)
        /// </remarks>
        public byte AISightRateStartMorningHour
        {
            get => (byte)CellsByName["AISightRateStartMorningHour"].Value;
            set => CellsByName["AISightRateStartMorningHour"].Value = value;
        }


        // Def="u8 aiSightRateStart_Morning_Minute"
        /// <summary>
        /// AI Sight Rate Start - Morning Minute (u8)
        /// </summary>
        /// <remarks>
        /// AI visibility magnification_morning_start time (minutes)
        /// </remarks>
        public byte AISightRateStartMorningMinute
        {
            get => (byte)CellsByName["AISightRateStartMorningMinute"].Value;
            set => CellsByName["AISightRateStartMorningMinute"].Value = value;
        }


        // Def="u8 aiSightRateStart_Noon_Hour"
        /// <summary>
        /// AI Sight Rate Start - Noon Hour (u8)
        /// </summary>
        /// <remarks>
        /// AI visibility magnification_day_start time (hour)
        /// </remarks>
        public byte AISightRateStartNoonHour
        {
            get => (byte)CellsByName["AISightRateStartNoonHour"].Value;
            set => CellsByName["AISightRateStartNoonHour"].Value = value;
        }


        // Def="u8 aiSightRateStart_Noon_Minute"
        /// <summary>
        /// AI Sight Rate Start - Noon Minute (u8)
        /// </summary>
        /// <remarks>
        /// AI visibility magnification_day_start time (minutes)
        /// </remarks>
        public byte AISightRateStartNoonMinute
        {
            get => (byte)CellsByName["AISightRateStartNoonMinute"].Value;
            set => CellsByName["AISightRateStartNoonMinute"].Value = value;
        }


        // Def="u8 aiSightRateStart_Evening_Hour"
        /// <summary>
        /// AI Sight Rate Start - Evening Hour (u8)
        /// </summary>
        /// <remarks>
        /// AI visibility magnification_evening_start time (hour)
        /// </remarks>
        public byte AISightRateStartEveningHour
        {
            get => (byte)CellsByName["AISightRateStartEveningHour"].Value;
            set => CellsByName["AISightRateStartEveningHour"].Value = value;
        }


        // Def="u8 aiSightRateStart_Evening_Minute"
        /// <summary>
        /// AI Sight Rate Start - Evening Minute (u8)
        /// </summary>
        /// <remarks>
        /// AI visibility magnification_evening_start time (minutes)
        /// </remarks>
        public byte AISightRateStartEveningMinute
        {
            get => (byte)CellsByName["AISightRateStartEveningMinute"].Value;
            set => CellsByName["AISightRateStartEveningMinute"].Value = value;
        }


        // Def="u8 aiSightRateStart_Night_Hour"
        /// <summary>
        /// AI Sight Rate Start - Night Hour (u8)
        /// </summary>
        /// <remarks>
        /// AI visibility magnification_night_start time (hour)
        /// </remarks>
        public byte AISightRateStartNightHour
        {
            get => (byte)CellsByName["AISightRateStartNightHour"].Value;
            set => CellsByName["AISightRateStartNightHour"].Value = value;
        }


        // Def="u8 aiSightRateStart_Night_Minute"
        /// <summary>
        /// AI Sight Rate Start - Night Minute (u8)
        /// </summary>
        /// <remarks>
        /// AI visibility magnification_night_start time (minutes)
        /// </remarks>
        public byte AISightRateStartNightMinute
        {
            get => (byte)CellsByName["AISightRateStartNightMinute"].Value;
            set => CellsByName["AISightRateStartNightMinute"].Value = value;
        }


        // Def="u8 aiSightRateStart_Midnight_Hour"
        /// <summary>
        /// AI Sight Rate Start - Midnight Hour (u8)
        /// </summary>
        /// <remarks>
        /// AI visibility magnification_midnight_start time (hour)
        /// </remarks>
        public byte AISightRateStartMidnightHour
        {
            get => (byte)CellsByName["AISightRateStartMidnightHour"].Value;
            set => CellsByName["AISightRateStartMidnightHour"].Value = value;
        }


        // Def="u8 aiSightRateStart_Midnight_Minute"
        /// <summary>
        /// AI Sight Rate Start - Midnight Minute (u8)
        /// </summary>
        /// <remarks>
        /// AI visibility magnification_midnight_start time (minutes)
        /// </remarks>
        public byte AISightRateStartMidnightMinute
        {
            get => (byte)CellsByName["AISightRateStartMidnightMinute"].Value;
            set => CellsByName["AISightRateStartMidnightMinute"].Value = value;
        }


        // Def="u8 saLargeDamageHitSfx_Threshold"
        /// <summary>
        /// Poise - Large Damage Hit SFX Threshold (u8)
        /// </summary>
        /// <remarks>
        /// SA large damage hit production SFX_ Occurrence condition SA damage threshold ratio [%]
        /// </remarks>
        public byte PoiseLargeDamageHitSFXThreshold
        {
            get => (byte)CellsByName["PoiseLargeDamageHitSFXThreshold"].Value;
            set => CellsByName["PoiseLargeDamageHitSFXThreshold"].Value = value;
        }


        // Def="s32 saLargeDamageHitSfx_SfxId"
        /// <summary>
        /// Poise - Large Damage Hit SFX ID (s32)
        /// </summary>
        /// <remarks>
        /// SA heavy damage hit production SFX_SFXID
        /// </remarks>
        public int PoiseLargeDamageHitSFXID
        {
            get => (int)CellsByName["PoiseLargeDamageHitSFXID"].Value;
            set => CellsByName["PoiseLargeDamageHitSFXID"].Value = value;
        }


        // Def="f32 signCreatableDistFromSafePos"
        /// <summary>
        /// Sign Creatable Distance from Safe Position (f32)
        /// </summary>
        /// <remarks>
        /// Distance at which you can create a sign away from the last safe position on your PC [m]
        /// </remarks>
        public float SignCreatableDistanceFromSafePosition
        {
            get => (float)CellsByName["SignCreatableDistanceFromSafePosition"].Value;
            set => CellsByName["SignCreatableDistanceFromSafePosition"].Value = value;
        }


        // Def="f32 guestResummonDist"
        /// <summary>
        /// Guest Resummon Distance (f32)
        /// </summary>
        /// <remarks>
        /// Distance between host and guest where resummoning occurs [m]
        /// </remarks>
        public float GuestResummonDistance
        {
            get => (float)CellsByName["GuestResummonDistance"].Value;
            set => CellsByName["GuestResummonDistance"].Value = value;
        }


        // Def="f32 guestLeavingMessageDistMax"
        /// <summary>
        /// Guest Leaving Message - Max Distance (f32)
        /// </summary>
        /// <remarks>
        /// Distance [m] to notify the guest that they are about to leave the host. Notify me when I'm farther than this distance.
        /// </remarks>
        public float GuestLeavingMessageMaxDistance
        {
            get => (float)CellsByName["GuestLeavingMessageMaxDistance"].Value;
            set => CellsByName["GuestLeavingMessageMaxDistance"].Value = value;
        }


        // Def="f32 guestLeavingMessageDistMin"
        /// <summary>
        /// Guest Leaving Message - Min Distance (f32)
        /// </summary>
        /// <remarks>
        /// Distance [m] that allows the guest to be re-notified that they are about to leave the host. Do not re-notify until closer than this distance.
        /// </remarks>
        public float GuestLeavingMessageMinDistance
        {
            get => (float)CellsByName["GuestLeavingMessageMinDistance"].Value;
            set => CellsByName["GuestLeavingMessageMinDistance"].Value = value;
        }


        // Def="f32 guestLeaveSessionDist"
        /// <summary>
        /// Guest Leave Session Distance (f32)
        /// </summary>
        /// <remarks>
        /// Maximum distance [m] that a guest can leave the host. If a certain period of time elapses while the distance is longer than this distance, the session will be withdrawn.
        /// </remarks>
        public float GuestLeaveSessionDistance
        {
            get => (float)CellsByName["GuestLeaveSessionDistance"].Value;
            set => CellsByName["GuestLeaveSessionDistance"].Value = value;
        }


        // Def="f32 retryPointAreaRadius = -1"
        /// <summary>
        /// Marika Stake Area Radius (f32)
        /// </summary>
        /// <remarks>
        /// Retry area radius_default value (m). It is used as the default value when the radius and area are not set in the event type "Retry Point" of MapStudio.
        /// </remarks>
        public float MarikaStakeAreaRadius
        {
            get => (float)CellsByName["MarikaStakeAreaRadius"].Value;
            set => CellsByName["MarikaStakeAreaRadius"].Value = value;
        }


        // Def="s32 sleepCollectorSpEffectId = -1"
        /// <summary>
        /// Sleep Collector SpEffect ID (s32)
        /// </summary>
        /// <remarks>
        /// A special effect ID that activates when a Nemuri item can be acquired. TAE flag Used as the default value when not overwriting with "Event> Nemuri item registration".
        /// </remarks>
        public int SleepCollectorSpEffectID
        {
            get => (int)CellsByName["SleepCollectorSpEffectID"].Value;
            set => CellsByName["SleepCollectorSpEffectID"].Value = value;
        }


        // Def="s32 recoverBelowMaxHpCompletionNoticeSpEffectId"
        /// <summary>
        /// Recovery below HP Max - Notification SpEffect ID (s32)
        /// </summary>
        /// <remarks>
        /// ID of the special effect that notifies that "Recovery below HP maximum" is completed. Mainly used for multi synchronization.
        /// </remarks>
        public int RecoveryBelowHPMaxNotificationSpEffectID
        {
            get => (int)CellsByName["RecoveryBelowHPMaxNotificationSpEffectID"].Value;
            set => CellsByName["RecoveryBelowHPMaxNotificationSpEffectID"].Value = value;
        }


        // Def="s32 estusFlaskRecovery_AbsorptionProductionSfxId_byHp"
        /// <summary>
        /// HP Flask - Absorption SFX ID for Intruder Flask Restoration (s32)
        /// </summary>
        /// <remarks>
        /// Absorption effect SFXID when recovering the number of times the HP Est bottle has been used when defeating an intruder
        /// </remarks>
        public int HPFlaskAbsorptionSFXIDForIntruderFlaskRestoration
        {
            get => (int)CellsByName["HPFlaskAbsorptionSFXIDForIntruderFlaskRestoration"].Value;
            set => CellsByName["HPFlaskAbsorptionSFXIDForIntruderFlaskRestoration"].Value = value;
        }


        // Def="s32 estusFlaskRecovery_AbsorptionProductionSfxId_byMp"
        /// <summary>
        /// FP Flask - Absorption SFX ID for Intruder Flask Restoration (s32)
        /// </summary>
        /// <remarks>
        /// Absorption effect SFXID when recovering the number of times the MP Est bottle has been used when defeating an intruder
        /// </remarks>
        public int FPFlaskAbsorptionSFXIDForIntruderFlaskRestoration
        {
            get => (int)CellsByName["FPFlaskAbsorptionSFXIDForIntruderFlaskRestoration"].Value;
            set => CellsByName["FPFlaskAbsorptionSFXIDForIntruderFlaskRestoration"].Value = value;
        }


        // Def="s32 respawnSpecialEffectActiveCheckerSpEffectId"
        /// <summary>
        /// Resurrection - Notification SpEffect ID (s32)
        /// </summary>
        /// <remarks>
        /// ID of the special effect that notifies that the resurrection special effect has been activated. Mainly used for multi synchronization.
        /// </remarks>
        public int ResurrectionNotificationSpEffectID
        {
            get => (int)CellsByName["ResurrectionNotificationSpEffectID"].Value;
            set => CellsByName["ResurrectionNotificationSpEffectID"].Value = value;
        }


        // Def="s32 onBuddySummon_inActivateRange_spEffectId_buddy = -1"
        /// <summary>
        /// Spirit Summon - Activation Range - Spirit SpEffect ID (s32)
        /// </summary>
        /// <remarks>
        /// Buddy Summoning_Initial Range Special Effect ID_For Buddy
        /// </remarks>
        public int SpiritSummonActivationRangeSpiritSpEffectID
        {
            get => (int)CellsByName["SpiritSummonActivationRangeSpiritSpEffectID"].Value;
            set => CellsByName["SpiritSummonActivationRangeSpiritSpEffectID"].Value = value;
        }


        // Def="f32 estusFlaskRecovery_AddEstusTime"
        /// <summary>
        /// Flask - Absorption SFX Playback Time (f32)
        /// </summary>
        /// <remarks>
        /// Time from the start of est absorption SFX playback to the start of est addition processing
        /// </remarks>
        public float FlaskAbsorptionSFXPlaybackTime
        {
            get => (float)CellsByName["FlaskAbsorptionSFXPlaybackTime"].Value;
            set => CellsByName["FlaskAbsorptionSFXPlaybackTime"].Value = value;
        }


        // Def="f32 defeatMultiModeEnemyOfSoulCorrectRate_byHost"
        /// <summary>
        /// Rune Absorption Multiplier - Normal Enemy - Host (f32)
        /// </summary>
        /// <remarks>
        /// Correction value of the amount of soul acquired by the host when defeating a normal enemy in multiplayer
        /// </remarks>
        public float RuneAbsorptionMultiplierNormalEnemyHost
        {
            get => (float)CellsByName["RuneAbsorptionMultiplierNormalEnemyHost"].Value;
            set => CellsByName["RuneAbsorptionMultiplierNormalEnemyHost"].Value = value;
        }


        // Def="f32 defeatMultiModeEnemyOfSoulCorrectRate_byTeamGhost"
        /// <summary>
        /// Rune Absorption Multiplier - Normal Enemy - Friendly Phantom (f32)
        /// </summary>
        /// <remarks>
        /// Correction value of the amount of soul acquired by cooperating spirits when defeating a normal enemy in multiplayer
        /// </remarks>
        public float RuneAbsorptionMultiplierNormalEnemyFriendlyPhantom
        {
            get => (float)CellsByName["RuneAbsorptionMultiplierNormalEnemyFriendlyPhantom"].Value;
            set => CellsByName["RuneAbsorptionMultiplierNormalEnemyFriendlyPhantom"].Value = value;
        }


        // Def="f32 defeatMultiModeBossOfSoulCorrectRate_byHost"
        /// <summary>
        /// Rune Absorption Multiplier - Boss - Host (f32)
        /// </summary>
        /// <remarks>
        /// Correction value of the amount of soul acquired by the host when defeating the boss in multiplayer
        /// </remarks>
        public float RuneAbsorptionMultiplierBossHost
        {
            get => (float)CellsByName["RuneAbsorptionMultiplierBossHost"].Value;
            set => CellsByName["RuneAbsorptionMultiplierBossHost"].Value = value;
        }


        // Def="f32 defeatMultiModeBossOfSoulCorrectRate_byTeamGhost"
        /// <summary>
        /// Rune Absorption Multiplier - Boss - Friendly Phantom (f32)
        /// </summary>
        /// <remarks>
        /// Correction value of the amount of soul acquired when the boss is defeated in multiplayer
        /// </remarks>
        public float RuneAbsorptionMultiplierBossFriendlyPhantom
        {
            get => (float)CellsByName["RuneAbsorptionMultiplierBossFriendlyPhantom"].Value;
            set => CellsByName["RuneAbsorptionMultiplierBossFriendlyPhantom"].Value = value;
        }


        // Def="u16 enemyHpGaugeScreenOffset_byUp"
        /// <summary>
        /// Enemy HP Gauge - Cutoff Pixel Offset (u16)
        /// </summary>
        /// <remarks>
        /// Offset value [pixel] (FullHD standard) that fits in the screen when the enemy's HP gauge is cut off on the screen
        /// </remarks>
        public ushort EnemyHPGaugeCutoffPixelOffset
        {
            get => (ushort)CellsByName["EnemyHPGaugeCutoffPixelOffset"].Value;
            set => CellsByName["EnemyHPGaugeCutoffPixelOffset"].Value = value;
        }


        // Def="u16 playRegionCollectDist"
        /// <summary>
        /// Play Region Collection Distance (u16)
        /// </summary>
        /// <remarks>
        /// Collection radius of the play area around the PC
        /// </remarks>
        public ushort PlayRegionCollectionDistance
        {
            get => (ushort)CellsByName["PlayRegionCollectionDistance"].Value;
            set => CellsByName["PlayRegionCollectionDistance"].Value = value;
        }


        // Def="u16 enemyDetectionSpEffect_ShootBulletDummypolyId"
        /// <summary>
        /// Enemy Detection - Shoot Bullet Dummy Poly ID (u16)
        /// </summary>
        /// <remarks>
        /// Detect bullet firing position Damipoli ID
        /// </remarks>
        public ushort EnemyDetectionShootBulletDummyPolyID
        {
            get => (ushort)CellsByName["EnemyDetectionShootBulletDummyPolyID"].Value;
            set => CellsByName["EnemyDetectionShootBulletDummyPolyID"].Value = value;
        }


        // Def="u16 bigRuneGreaterDemonBreakInGoodsNum"
        /// <summary>
        /// Phantom Great Rune - Amount given for Invasion (u16)
        /// </summary>
        /// <remarks>
        /// Large Rune: Number of tools granted when the Greater Demon invades
        /// </remarks>
        public ushort PhantomGreatRuneAmountGivenForInvasion
        {
            get => (ushort)CellsByName["PhantomGreatRuneAmountGivenForInvasion"].Value;
            set => CellsByName["PhantomGreatRuneAmountGivenForInvasion"].Value = value;
        }


        // Def="s32 bigRuneGreaterDemonBreakInGoodsId = -1"
        /// <summary>
        /// Phantom Great Rune - Goods ID (s32)
        /// </summary>
        /// <remarks>
        /// Large Rune: Greater Demon Invasion Tool Item ID
        /// </remarks>
        public int PhantomGreatRuneGoodsID
        {
            get => (int)CellsByName["PhantomGreatRuneGoodsID"].Value;
            set => CellsByName["PhantomGreatRuneGoodsID"].Value = value;
        }


        // Def="s32 rideJumpRegionDefaultSfxId"
        /// <summary>
        /// Spiritspring Jump SFX ID (s32)
        /// </summary>
        /// <remarks>
        /// SFX ID in the riding large jump area
        /// </remarks>
        public int SpiritspringJumpSFXID
        {
            get => (int)CellsByName["SpiritspringJumpSFXID"].Value;
            set => CellsByName["SpiritspringJumpSFXID"].Value = value;
        }


        // Def="f32 saAttackRate_forVsRideAtk = 1"
        /// <summary>
        /// Poise Damage - Vs. Ride Attack (f32)
        /// </summary>
        /// <remarks>
        /// Magnification to be corrected at the time of riding special attack
        /// </remarks>
        public float PoiseDamageVsRideAttack
        {
            get => (float)CellsByName["PoiseDamageVsRideAttack"].Value;
            set => CellsByName["PoiseDamageVsRideAttack"].Value = value;
        }


        // Def="s32 enemySpEffectIdAfterSleepCollectorItemLot = -1"
        /// <summary>
        /// Sleep Collector Item Lot - Enemy SpEffect ID (s32)
        /// </summary>
        /// <remarks>
        /// Special effects on the enemy side when drawing Nemuri items
        /// </remarks>
        public int SleepCollectorItemLotEnemySpEffectID
        {
            get => (int)CellsByName["SleepCollectorItemLotEnemySpEffectID"].Value;
            set => CellsByName["SleepCollectorItemLotEnemySpEffectID"].Value = value;
        }


        // Def="s32 afterEndingMapUid"
        /// <summary>
        /// After Ending Map UID (s32)
        /// </summary>
        /// <remarks>
        /// Map UID on hold for lap, enter in 8 digits (example ... m60_42_36_00-> 60423600)
        /// </remarks>
        public int AfterEndingMapUID
        {
            get => (int)CellsByName["AfterEndingMapUID"].Value;
            set => CellsByName["AfterEndingMapUID"].Value = value;
        }


        // Def="u32 afterEndingReturnPointEntityId"
        /// <summary>
        /// After Ending Return Point Entity ID (u32)
        /// </summary>
        /// <remarks>
        /// Entity ID of return point on hold
        /// </remarks>
        public uint AfterEndingReturnPointEntityID
        {
            get => (uint)CellsByName["AfterEndingReturnPointEntityID"].Value;
            set => CellsByName["AfterEndingReturnPointEntityID"].Value = value;
        }


        // Def="s32 enemyDetectionSpEffect_BulletId_byCoopRing_RedHunter"
        /// <summary>
        /// Enemy Detection - Bullet ID (Co-op/Anti-Invader) (s32)
        /// </summary>
        /// <remarks>
        /// Bullet ID to fly depending on enemy power / type (also used for multi-automatic firing)
        /// </remarks>
        public int EnemyDetectionBulletIDCoOpAntiInvader
        {
            get => (int)CellsByName["EnemyDetectionBulletIDCoOpAntiInvader"].Value;
            set => CellsByName["EnemyDetectionBulletIDCoOpAntiInvader"].Value = value;
        }


        // Def="s32 enemyDetectionSpEffect_BulletId_byInvadeOrb_None"
        /// <summary>
        /// Enemy Detection - Bullet ID (Invader) (s32)
        /// </summary>
        /// <remarks>
        /// Bullet ID to fly depending on enemy power / type (also used for multi-automatic firing)
        /// </remarks>
        public int EnemyDetectionBulletIDInvader
        {
            get => (int)CellsByName["EnemyDetectionBulletIDInvader"].Value;
            set => CellsByName["EnemyDetectionBulletIDInvader"].Value = value;
        }


        // Def="u32 tutorialFlagOnAccessDistView"
        /// <summary>
        /// Tutorial Flag: Accessing Birdseye Telescope (u32)
        /// </summary>
        /// <remarks>
        /// For tutorial judgment: Event flag to turn on when accessing the distant view
        /// </remarks>
        public uint TutorialFlagAccessingBirdseyeTelescope
        {
            get => (uint)CellsByName["TutorialFlagAccessingBirdseyeTelescope"].Value;
            set => CellsByName["TutorialFlagAccessingBirdseyeTelescope"].Value = value;
        }


        // Def="u32 tutorialFlagOnAccessRetryPoint"
        /// <summary>
        /// Tutorial Flag: Accessing Marika Stake (u32)
        /// </summary>
        /// <remarks>
        /// For tutorial judgment: Event flag to turn on when accessing the retry point
        /// </remarks>
        public uint TutorialFlagAccessingMarikaStake
        {
            get => (uint)CellsByName["TutorialFlagAccessingMarikaStake"].Value;
            set => CellsByName["TutorialFlagAccessingMarikaStake"].Value = value;
        }


        // Def="u32 tutorialFlagOnGetGroupReward"
        /// <summary>
        /// Tutorial Flag: Enemy Group Flask Restoration (u32)
        /// </summary>
        /// <remarks>
        /// For tutorial judgment: Event flag to turn on when group reward is entered after defeating a group
        /// </remarks>
        public uint TutorialFlagEnemyGroupFlaskRestoration
        {
            get => (uint)CellsByName["TutorialFlagEnemyGroupFlaskRestoration"].Value;
            set => CellsByName["TutorialFlagEnemyGroupFlaskRestoration"].Value = value;
        }


        // Def="u32 tutorialFlagOnEnterRideJumpRegion"
        /// <summary>
        /// Tutorial Flag: Entering Spiritspring Jump (u32)
        /// </summary>
        /// <remarks>
        /// For tutorial judgment: Event flag to turn on when entering the riding big jump point
        /// </remarks>
        public uint TutorialFlagEnteringSpiritspringJump
        {
            get => (uint)CellsByName["TutorialFlagEnteringSpiritspringJump"].Value;
            set => CellsByName["TutorialFlagEnteringSpiritspringJump"].Value = value;
        }


        // Def="f32 tutorialCheckRideJumpRegionExpandRange"
        /// <summary>
        /// Tutorial: Check Spiritspring Jump Region Range (f32)
        /// </summary>
        /// <remarks>
        /// For tutorial judgment: The riding large jump point is expanded by ○ [m] to judge inside and outside. ○ Set the value of [m] here.
        /// </remarks>
        public float TutorialCheckSpiritspringJumpRegionRange
        {
            get => (float)CellsByName["TutorialCheckSpiritspringJumpRegionRange"].Value;
            set => CellsByName["TutorialCheckSpiritspringJumpRegionRange"].Value = value;
        }


        // Def="s32 retryPointActivatedPcAnimId = -1"
        /// <summary>
        /// Activated Marika Stake: Player Animation ID (s32)
        /// </summary>
        /// <remarks>
        /// PC animation ID when retry point is started. If it is -1, it will not be played.
        /// </remarks>
        public int ActivatedMarikaStakePlayerAnimationID
        {
            get => (int)CellsByName["ActivatedMarikaStakePlayerAnimationID"].Value;
            set => CellsByName["ActivatedMarikaStakePlayerAnimationID"].Value = value;
        }


        // Def="f32 retryPointActivatedDialogDelayTime"
        /// <summary>
        /// Activated Marika Stake: Dialog Display Delay (f32)
        /// </summary>
        /// <remarks>
        /// Delay time of dialog display when retry point is started [seconds]
        /// </remarks>
        public float ActivatedMarikaStakeDialogDisplayDelay
        {
            get => (float)CellsByName["ActivatedMarikaStakeDialogDisplayDelay"].Value;
            set => CellsByName["ActivatedMarikaStakeDialogDisplayDelay"].Value = value;
        }


        // Def="s32 retryPointActivatedDialogTextId = -1"
        /// <summary>
        /// Activated Marika Stake: Dialog Text ID (s32)
        /// </summary>
        /// <remarks>
        /// The text ID of the dialog when the retry point is started. Set the text in EventText_ForMap.xlsm. If it is -1, the dialog is not displayed.
        /// </remarks>
        public int ActivatedMarikaStakeDialogTextID
        {
            get => (int)CellsByName["ActivatedMarikaStakeDialogTextID"].Value;
            set => CellsByName["ActivatedMarikaStakeDialogTextID"].Value = value;
        }


        // Def="s32 signPuddleOpenPcAnimId = -1"
        /// <summary>
        /// Opened Summoning Pool: Player Animation ID (s32)
        /// </summary>
        /// <remarks>
        /// PC animation ID at the time of sign accumulation startup. If it is -1, it will not be played.
        /// </remarks>
        public int OpenedSummoningPoolPlayerAnimationID
        {
            get => (int)CellsByName["OpenedSummoningPoolPlayerAnimationID"].Value;
            set => CellsByName["OpenedSummoningPoolPlayerAnimationID"].Value = value;
        }


        // Def="f32 signPuddleOpenDialogDelayTime"
        /// <summary>
        /// Opened Summoning Pool: Dialog Display Delay (f32)
        /// </summary>
        /// <remarks>
        /// Delay time of dialog display at startup of sign accumulation [seconds]
        /// </remarks>
        public float OpenedSummoningPoolDialogDisplayDelay
        {
            get => (float)CellsByName["OpenedSummoningPoolDialogDisplayDelay"].Value;
            set => CellsByName["OpenedSummoningPoolDialogDisplayDelay"].Value = value;
        }


        // Def="s32 activityOfDeadSpEffect_BulletId"
        /// <summary>
        /// Corpse Explosion - Bullet ID (s32)
        /// </summary>
        /// <remarks>
        /// Bullet ID fired when the "Activity of the Dead" special effect is activated
        /// </remarks>
        public int CorpseExplosionBulletID
        {
            get => (int)CellsByName["CorpseExplosionBulletID"].Value;
            set => CellsByName["CorpseExplosionBulletID"].Value = value;
        }


        // Def="s32 activityOfDeadSpEffect_ShootBulletDummypolyId"
        /// <summary>
        /// Corpse Explosion - Bullet Dummy Poly ID (s32)
        /// </summary>
        /// <remarks>
        /// Damipoli ID at the position where the bullet is generated when the "Activity of the Dead" special effect is activated
        /// </remarks>
        public int CorpseExplosionBulletDummyPolyID
        {
            get => (int)CellsByName["CorpseExplosionBulletDummyPolyID"].Value;
            set => CellsByName["CorpseExplosionBulletDummyPolyID"].Value = value;
        }


        // Def="f32 activityOfDeadSpEffect_DeadFadeOutTime"
        /// <summary>
        /// Corpse Explosion - Dead Fadeout Time (f32)
        /// </summary>
        /// <remarks>
        /// Fade time when the corpse fades out when the "Activity of the Dead" special effect is activated
        /// </remarks>
        public float CorpseExplosionDeadFadeoutTime
        {
            get => (float)CellsByName["CorpseExplosionDeadFadeoutTime"].Value;
            set => CellsByName["CorpseExplosionDeadFadeoutTime"].Value = value;
        }


        // Def="f32 ignorNetStateSyncTime_ForThrow"
        /// <summary>
        /// Ignore Network State Sync Time for Throw (f32)
        /// </summary>
        /// <remarks>
        /// Time to ignore transitions due to network information at the start of throwing
        /// </remarks>
        public float IgnoreNetworkStateSyncTimeForThrow
        {
            get => (float)CellsByName["IgnoreNetworkStateSyncTimeForThrow"].Value;
            set => CellsByName["IgnoreNetworkStateSyncTimeForThrow"].Value = value;
        }


        // Def="u16 netPenaltyPointLanDisconnect"
        /// <summary>
        /// Muliplayer Disconnect: LAN Disconnect Penalty Points (u16)
        /// </summary>
        /// <remarks>
        /// Multi-pre-penalty: LAN disconnection
        /// </remarks>
        public ushort MuliplayerDisconnectLANDisconnectPenaltyPoints
        {
            get => (ushort)CellsByName["MuliplayerDisconnectLANDisconnectPenaltyPoints"].Value;
            set => CellsByName["MuliplayerDisconnectLANDisconnectPenaltyPoints"].Value = value;
        }


        // Def="u16 netPenaltyPointProfileSignout"
        /// <summary>
        /// Muliplayer Disconnect: Profile Signout Penalty Points (u16)
        /// </summary>
        /// <remarks>
        /// Multi-pre-penalty: Profile sign-out
        /// </remarks>
        public ushort MuliplayerDisconnectProfileSignoutPenaltyPoints
        {
            get => (ushort)CellsByName["MuliplayerDisconnectProfileSignoutPenaltyPoints"].Value;
            set => CellsByName["MuliplayerDisconnectProfileSignoutPenaltyPoints"].Value = value;
        }


        // Def="u16 netPenaltyPointReboot"
        /// <summary>
        /// Muliplayer Disconnect: Reboot Penalty Points (u16)
        /// </summary>
        /// <remarks>
        /// Multi-pre-penalty: Power off
        /// </remarks>
        public ushort MuliplayerDisconnectRebootPenaltyPoints
        {
            get => (ushort)CellsByName["MuliplayerDisconnectRebootPenaltyPoints"].Value;
            set => CellsByName["MuliplayerDisconnectRebootPenaltyPoints"].Value = value;
        }


        // Def="u16 netPnaltyPointSuspend"
        /// <summary>
        /// Muliplayer Disconnect: Suspend Penalty Points (u16)
        /// </summary>
        /// <remarks>
        /// Multi-pre-penalty: Suspend / Pause
        /// </remarks>
        public ushort MuliplayerDisconnectSuspendPenaltyPoints
        {
            get => (ushort)CellsByName["MuliplayerDisconnectSuspendPenaltyPoints"].Value;
            set => CellsByName["MuliplayerDisconnectSuspendPenaltyPoints"].Value = value;
        }


        // Def="f32 netPenaltyForgiveItemLimitTime"
        /// <summary>
        /// Muliplayer Disconnect: Delay before White Ring is given (f32)
        /// </summary>
        /// <remarks>
        /// Multi-pre-penalty: Waiting time (seconds) to start the generation (sale) of the bone of reason
        /// </remarks>
        public float MuliplayerDisconnectDelayBeforeWhiteRingIsGiven
        {
            get => (float)CellsByName["MuliplayerDisconnectDelayBeforeWhiteRingIsGiven"].Value;
            set => CellsByName["MuliplayerDisconnectDelayBeforeWhiteRingIsGiven"].Value = value;
        }


        // Def="u16 netPenaltyPointThreshold"
        /// <summary>
        /// Multiplayer Disconnect: Point Threshold (u16)
        /// </summary>
        /// <remarks>
        /// Multi-pre-penalty: Penalty judgment points
        /// </remarks>
        public ushort MultiplayerDisconnectPointThreshold
        {
            get => (ushort)CellsByName["MultiplayerDisconnectPointThreshold"].Value;
            set => CellsByName["MultiplayerDisconnectPointThreshold"].Value = value;
        }


        // Def="u16 uncontrolledMoveThresholdTime"
        /// <summary>
        /// Multiplayer: Timeout due to lack of Activity (u16)
        /// </summary>
        /// <remarks>
        /// It is for leaving people who have not operated for a certain period of time in multiplayer. The unit is seconds.
        /// </remarks>
        public ushort MultiplayerTimeoutDueToLackOfActivity
        {
            get => (ushort)CellsByName["MultiplayerTimeoutDueToLackOfActivity"].Value;
            set => CellsByName["MultiplayerTimeoutDueToLackOfActivity"].Value = value;
        }


        // Def="s32 enemyDetectionSpEffect_BulletId_byNpcEnemy"
        /// <summary>
        /// Enemy Detection - Bullet ID (NPC Enemy) (s32)
        /// </summary>
        /// <remarks>
        /// Bullet ID to shoot to hostile NPCs / enemy characters when hostility detection fails
        /// </remarks>
        public int EnemyDetectionBulletIDNPCEnemy
        {
            get => (int)CellsByName["EnemyDetectionBulletIDNPCEnemy"].Value;
            set => CellsByName["EnemyDetectionBulletIDNPCEnemy"].Value = value;
        }


        // Def="s32 activityOfDeadTargetSearchSpEffect_OnHitSpEffect"
        /// <summary>
        /// Corpse Explosion - On Hit SpEffect (s32)
        /// </summary>
        /// <remarks>
        /// Special effects applied to the searched target
        /// </remarks>
        public int CorpseExplosionOnHitSpEffect
        {
            get => (int)CellsByName["CorpseExplosionOnHitSpEffect"].Value;
            set => CellsByName["CorpseExplosionOnHitSpEffect"].Value = value;
        }


        // Def="f32 activityOfDeadTargetSearchSpEffect_MaxLength"
        /// <summary>
        /// Corpse Explosion - Max Length (f32)
        /// </summary>
        /// <remarks>
        /// Maximum searchable distance
        /// </remarks>
        public float CorpseExplosionMaxLength
        {
            get => (float)CellsByName["CorpseExplosionMaxLength"].Value;
            set => CellsByName["CorpseExplosionMaxLength"].Value = value;
        }


        // Def="f32 sightRangeLowerPromiseRate"
        /// <summary>
        /// Field of View - Minimum Guaranteed Distance (f32)
        /// </summary>
        /// <remarks>
        /// Field of view_Minimum guaranteed distance [magnification conversion]
        /// </remarks>
        public float FieldOfViewMinimumGuaranteedDistance
        {
            get => (float)CellsByName["FieldOfViewMinimumGuaranteedDistance"].Value;
            set => CellsByName["FieldOfViewMinimumGuaranteedDistance"].Value = value;
        }


        // Def="s16 saLargeDamageHitSfx_MinDamage = -1"
        /// <summary>
        /// Poise Large Damage Hit SFX - Minimum Damage (s16)
        /// </summary>
        /// <remarks>
        /// SA large damage hit production SFX_ Occurrence condition SA damage minimum required [pt]
        /// </remarks>
        public short PoiseLargeDamageHitSFXMinimumDamage
        {
            get => (short)CellsByName["PoiseLargeDamageHitSFXMinimumDamage"].Value;
            set => CellsByName["PoiseLargeDamageHitSFXMinimumDamage"].Value = value;
        }


        // Def="s16 saLargeDamageHitSfx_ForceDamage = -1"
        /// <summary>
        /// Poise Large Damage Hit SFX - Force Damage (s16)
        /// </summary>
        /// <remarks>
        /// SA large damage hit production SFX_ Occurrence condition SA damage forced occurrence minimum value [pt]
        /// </remarks>
        public short PoiseLargeDamageHitSFXForceDamage
        {
            get => (short)CellsByName["PoiseLargeDamageHitSFXForceDamage"].Value;
            set => CellsByName["PoiseLargeDamageHitSFXForceDamage"].Value = value;
        }


        // Def="u32 soloBreakInMaxPoint"
        /// <summary>
        /// Maximum Solo Intrusion Point (u32)
        /// </summary>
        /// <remarks>
        /// Maximum solo intrusion point. When this value is exceeded, it will be invaded solo.
        /// </remarks>
        public uint MaximumSoloIntrusionPoint
        {
            get => (uint)CellsByName["MaximumSoloIntrusionPoint"].Value;
            set => CellsByName["MaximumSoloIntrusionPoint"].Value = value;
        }


        // Def="f32 npcTalkTimeOutThreshold"
        /// <summary>
        /// NPC Talk Timeout Threshold (f32)
        /// </summary>
        /// <remarks>
        /// Voice playback timeout for NPC conversations. If voice playback does not end after this time, proceed to the next message.
        /// </remarks>
        public float NPCTalkTimeoutThreshold
        {
            get => (float)CellsByName["NPCTalkTimeoutThreshold"].Value;
            set => CellsByName["NPCTalkTimeoutThreshold"].Value = value;
        }


        // Def="f32 sendPlayLogIntervalTime"
        /// <summary>
        /// Send Play Log Interval (f32)
        /// </summary>
        /// <remarks>
        /// Interval to send item usage log etc. to the server
        /// </remarks>
        public float SendPlayLogInterval
        {
            get => (float)CellsByName["SendPlayLogInterval"].Value;
            set => CellsByName["SendPlayLogInterval"].Value = value;
        }


        // Def="u8 item370_MaxSfxNum"
        /// <summary>
        /// Rainbow Stone - Max SFX Count (u8)
        /// </summary>
        /// <remarks>
        /// Maximum number of seven-colored stones installed
        /// </remarks>
        public byte RainbowStoneMaxSFXCount
        {
            get => (byte)CellsByName["RainbowStoneMaxSFXCount"].Value;
            set => CellsByName["RainbowStoneMaxSFXCount"].Value = value;
        }


        // Def="u8 chrActivateDist_forLeavePC"
        /// <summary>
        /// Chr Activate Distance - For Leave Player (u8)
        /// </summary>
        /// <remarks>
        /// Distance allowed to activate during character deactivation (valid only for open placement characters)
        /// </remarks>
        public byte ChrActivateDistanceForLeavePlayer
        {
            get => (byte)CellsByName["ChrActivateDistanceForLeavePlayer"].Value;
            set => CellsByName["ChrActivateDistanceForLeavePlayer"].Value = value;
        }


        // Def="s16 summonDataCoopMatchingLevelUpperAbs"
        /// <summary>
        /// Coop - Host Level Addition Correction (s16)
        /// </summary>
        /// <remarks>
        /// Weakened stats when multiplayer. Host level addition correction
        /// </remarks>
        public short CoopHostLevelAdditionCorrection
        {
            get => (short)CellsByName["CoopHostLevelAdditionCorrection"].Value;
            set => CellsByName["CoopHostLevelAdditionCorrection"].Value = value;
        }


        // Def="s16 summonDataCoopMatchingLevelUpperRel"
        /// <summary>
        /// Coop - Host Level Magnification Correction (s16)
        /// </summary>
        /// <remarks>
        /// Weakened stats when multiplayer. Host level magnification correction
        /// </remarks>
        public short CoopHostLevelMagnificationCorrection
        {
            get => (short)CellsByName["CoopHostLevelMagnificationCorrection"].Value;
            set => CellsByName["CoopHostLevelMagnificationCorrection"].Value = value;
        }


        // Def="s16 summonDataCoopMatchingWepLevelMul"
        /// <summary>
        /// Coop - Maximum Weapon Reinforcement Correction (s16)
        /// </summary>
        /// <remarks>
        /// Weakened stats when multiplayer. Maximum weapon enhancement level correction
        /// </remarks>
        public short CoopMaximumWeaponReinforcementCorrection
        {
            get => (short)CellsByName["CoopMaximumWeaponReinforcementCorrection"].Value;
            set => CellsByName["CoopMaximumWeaponReinforcementCorrection"].Value = value;
        }


        // Def="s32 pickUpBerserkerSignSpEffectBulletId"
        /// <summary>
        /// Pickup Berserker Sign - Bullet ID (s32)
        /// </summary>
        /// <remarks>
        /// Bullet ID when generating a bullet for special effects at the sign position
        /// </remarks>
        public int PickupBerserkerSignBulletID
        {
            get => (int)CellsByName["PickupBerserkerSignBulletID"].Value;
            set => CellsByName["PickupBerserkerSignBulletID"].Value = value;
        }


        // Def="s32 succeedBerserkerSelfKillingEffectId"
        /// <summary>
        /// Berserker Success Player Kill - SpEffect ID (s32)
        /// </summary>
        /// <remarks>
        /// Special effect to play a special effect when Berserker succeeds in killing the PC by himself
        /// </remarks>
        public int BerserkerSuccessPlayerKillSpEffectID
        {
            get => (int)CellsByName["BerserkerSuccessPlayerKillSpEffectID"].Value;
            set => CellsByName["BerserkerSuccessPlayerKillSpEffectID"].Value = value;
        }


        // Def="u8 machingLevelWhiteSignUpperRel"
        /// <summary>
        /// Friendly Phantom - Level Coefficient 1 (u8)
        /// </summary>
        /// <remarks>
        /// Soul level coefficient of whether to apply level sync
        /// </remarks>
        public byte FriendlyPhantomLevelCoefficient1
        {
            get => (byte)CellsByName["FriendlyPhantomLevelCoefficient1"].Value;
            set => CellsByName["FriendlyPhantomLevelCoefficient1"].Value = value;
        }


        // Def="u8 machingLevelWhiteSignUpperAbs"
        /// <summary>
        /// Friendly Phantom - Level Coefficient 2 (u8)
        /// </summary>
        /// <remarks>
        /// Soul level coefficient of whether to apply level sync
        /// </remarks>
        public byte FriendlyPhantomLevelCoefficient2
        {
            get => (byte)CellsByName["FriendlyPhantomLevelCoefficient2"].Value;
            set => CellsByName["FriendlyPhantomLevelCoefficient2"].Value = value;
        }


        // Def="u8 machingLevelRedSignUpperRel"
        /// <summary>
        /// Hostile Phantom - Level Coefficient 1 (u8)
        /// </summary>
        /// <remarks>
        /// Soul level coefficient of whether to apply level sync
        /// </remarks>
        public byte HostilePhantomLevelCoefficient1
        {
            get => (byte)CellsByName["HostilePhantomLevelCoefficient1"].Value;
            set => CellsByName["HostilePhantomLevelCoefficient1"].Value = value;
        }


        // Def="u8 machingLevelRedSignUpperAbs"
        /// <summary>
        /// Hostile Phantom - Level Coefficient 2 (u8)
        /// </summary>
        /// <remarks>
        /// Soul level coefficient of whether to apply level sync
        /// </remarks>
        public byte HostilePhantomLevelCoefficient2
        {
            get => (byte)CellsByName["HostilePhantomLevelCoefficient2"].Value;
            set => CellsByName["HostilePhantomLevelCoefficient2"].Value = value;
        }


        // Def="u8 machingWeaponLevelUpperWhiteSign_0"
        /// <summary>
        /// Friendly Phantom - Max Reinforcement Coefficient 0 (u8)
        /// </summary>
        /// <remarks>
        /// Maximum weapon enhancement level factor for whether to apply level sync
        /// </remarks>
        public byte FriendlyPhantomMaxReinforcementCoefficient0
        {
            get => (byte)CellsByName["FriendlyPhantomMaxReinforcementCoefficient0"].Value;
            set => CellsByName["FriendlyPhantomMaxReinforcementCoefficient0"].Value = value;
        }


        // Def="u8 machingWeaponLevelUpperWhiteSign_1"
        /// <summary>
        /// Friendly Phantom - Max Reinforcement Coefficient 1 (u8)
        /// </summary>
        /// <remarks>
        /// Maximum weapon enhancement level factor for whether to apply level sync
        /// </remarks>
        public byte FriendlyPhantomMaxReinforcementCoefficient1
        {
            get => (byte)CellsByName["FriendlyPhantomMaxReinforcementCoefficient1"].Value;
            set => CellsByName["FriendlyPhantomMaxReinforcementCoefficient1"].Value = value;
        }


        // Def="u8 machingWeaponLevelUpperWhiteSign_2"
        /// <summary>
        /// Friendly Phantom - Max Reinforcement Coefficient 2 (u8)
        /// </summary>
        /// <remarks>
        /// Maximum weapon enhancement level factor for whether to apply level sync
        /// </remarks>
        public byte FriendlyPhantomMaxReinforcementCoefficient2
        {
            get => (byte)CellsByName["FriendlyPhantomMaxReinforcementCoefficient2"].Value;
            set => CellsByName["FriendlyPhantomMaxReinforcementCoefficient2"].Value = value;
        }


        // Def="u8 machingWeaponLevelUpperWhiteSign_3"
        /// <summary>
        /// Friendly Phantom - Max Reinforcement Coefficient 3 (u8)
        /// </summary>
        /// <remarks>
        /// Maximum weapon enhancement level factor for whether to apply level sync
        /// </remarks>
        public byte FriendlyPhantomMaxReinforcementCoefficient3
        {
            get => (byte)CellsByName["FriendlyPhantomMaxReinforcementCoefficient3"].Value;
            set => CellsByName["FriendlyPhantomMaxReinforcementCoefficient3"].Value = value;
        }


        // Def="u8 machingWeaponLevelUpperWhiteSign_4"
        /// <summary>
        /// Friendly Phantom - Max Reinforcement Coefficient 4 (u8)
        /// </summary>
        /// <remarks>
        /// Maximum weapon enhancement level factor for whether to apply level sync
        /// </remarks>
        public byte FriendlyPhantomMaxReinforcementCoefficient4
        {
            get => (byte)CellsByName["FriendlyPhantomMaxReinforcementCoefficient4"].Value;
            set => CellsByName["FriendlyPhantomMaxReinforcementCoefficient4"].Value = value;
        }


        // Def="u8 machingWeaponLevelUpperWhiteSign_5"
        /// <summary>
        /// Friendly Phantom - Max Reinforcement Coefficient 5 (u8)
        /// </summary>
        /// <remarks>
        /// Maximum weapon enhancement level factor for whether to apply level sync
        /// </remarks>
        public byte FriendlyPhantomMaxReinforcementCoefficient5
        {
            get => (byte)CellsByName["FriendlyPhantomMaxReinforcementCoefficient5"].Value;
            set => CellsByName["FriendlyPhantomMaxReinforcementCoefficient5"].Value = value;
        }


        // Def="u8 machingWeaponLevelUpperWhiteSign_6"
        /// <summary>
        /// Friendly Phantom - Max Reinforcement Coefficient 6 (u8)
        /// </summary>
        /// <remarks>
        /// Maximum weapon enhancement level factor for whether to apply level sync
        /// </remarks>
        public byte FriendlyPhantomMaxReinforcementCoefficient6
        {
            get => (byte)CellsByName["FriendlyPhantomMaxReinforcementCoefficient6"].Value;
            set => CellsByName["FriendlyPhantomMaxReinforcementCoefficient6"].Value = value;
        }


        // Def="u8 machingWeaponLevelUpperWhiteSign_7"
        /// <summary>
        /// Friendly Phantom - Max Reinforcement Coefficient 7 (u8)
        /// </summary>
        /// <remarks>
        /// Maximum weapon enhancement level factor for whether to apply level sync
        /// </remarks>
        public byte FriendlyPhantomMaxReinforcementCoefficient7
        {
            get => (byte)CellsByName["FriendlyPhantomMaxReinforcementCoefficient7"].Value;
            set => CellsByName["FriendlyPhantomMaxReinforcementCoefficient7"].Value = value;
        }


        // Def="u8 machingWeaponLevelUpperWhiteSign_8"
        /// <summary>
        /// Friendly Phantom - Max Reinforcement Coefficient 8 (u8)
        /// </summary>
        /// <remarks>
        /// Maximum weapon enhancement level factor for whether to apply level sync
        /// </remarks>
        public byte FriendlyPhantomMaxReinforcementCoefficient8
        {
            get => (byte)CellsByName["FriendlyPhantomMaxReinforcementCoefficient8"].Value;
            set => CellsByName["FriendlyPhantomMaxReinforcementCoefficient8"].Value = value;
        }


        // Def="u8 machingWeaponLevelUpperWhiteSign_9"
        /// <summary>
        /// Friendly Phantom - Max Reinforcement Coefficient 9 (u8)
        /// </summary>
        /// <remarks>
        /// Maximum weapon enhancement level factor for whether to apply level sync
        /// </remarks>
        public byte FriendlyPhantomMaxReinforcementCoefficient9
        {
            get => (byte)CellsByName["FriendlyPhantomMaxReinforcementCoefficient9"].Value;
            set => CellsByName["FriendlyPhantomMaxReinforcementCoefficient9"].Value = value;
        }


        // Def="u8 machingWeaponLevelUpperWhiteSign_10"
        /// <summary>
        /// Friendly Phantom - Max Reinforcement Coefficient 10 (u8)
        /// </summary>
        /// <remarks>
        /// Maximum weapon enhancement level factor for whether to apply level sync
        /// </remarks>
        public byte FriendlyPhantomMaxReinforcementCoefficient10
        {
            get => (byte)CellsByName["FriendlyPhantomMaxReinforcementCoefficient10"].Value;
            set => CellsByName["FriendlyPhantomMaxReinforcementCoefficient10"].Value = value;
        }


        // Def="u8 machingWeaponLevelUpperRedSign_0"
        /// <summary>
        /// Hostile Phantom - Max Reinforcement Coefficient 0 (u8)
        /// </summary>
        /// <remarks>
        /// Maximum weapon enhancement level factor for whether to apply level sync
        /// </remarks>
        public byte HostilePhantomMaxReinforcementCoefficient0
        {
            get => (byte)CellsByName["HostilePhantomMaxReinforcementCoefficient0"].Value;
            set => CellsByName["HostilePhantomMaxReinforcementCoefficient0"].Value = value;
        }


        // Def="u8 machingWeaponLevelUpperRedSign_1"
        /// <summary>
        /// Hostile Phantom - Max Reinforcement Coefficient 1 (u8)
        /// </summary>
        /// <remarks>
        /// Maximum weapon enhancement level factor for whether to apply level sync
        /// </remarks>
        public byte HostilePhantomMaxReinforcementCoefficient1
        {
            get => (byte)CellsByName["HostilePhantomMaxReinforcementCoefficient1"].Value;
            set => CellsByName["HostilePhantomMaxReinforcementCoefficient1"].Value = value;
        }


        // Def="u8 machingWeaponLevelUpperRedSign_2"
        /// <summary>
        /// Hostile Phantom - Max Reinforcement Coefficient 2 (u8)
        /// </summary>
        /// <remarks>
        /// Maximum weapon enhancement level factor for whether to apply level sync
        /// </remarks>
        public byte HostilePhantomMaxReinforcementCoefficient2
        {
            get => (byte)CellsByName["HostilePhantomMaxReinforcementCoefficient2"].Value;
            set => CellsByName["HostilePhantomMaxReinforcementCoefficient2"].Value = value;
        }


        // Def="u8 machingWeaponLevelUpperRedSign_3"
        /// <summary>
        /// Hostile Phantom - Max Reinforcement Coefficient 3 (u8)
        /// </summary>
        /// <remarks>
        /// Maximum weapon enhancement level factor for whether to apply level sync
        /// </remarks>
        public byte HostilePhantomMaxReinforcementCoefficient3
        {
            get => (byte)CellsByName["HostilePhantomMaxReinforcementCoefficient3"].Value;
            set => CellsByName["HostilePhantomMaxReinforcementCoefficient3"].Value = value;
        }


        // Def="u8 machingWeaponLevelUpperRedSign_4"
        /// <summary>
        /// Hostile Phantom - Max Reinforcement Coefficient 4 (u8)
        /// </summary>
        /// <remarks>
        /// Maximum weapon enhancement level factor for whether to apply level sync
        /// </remarks>
        public byte HostilePhantomMaxReinforcementCoefficient4
        {
            get => (byte)CellsByName["HostilePhantomMaxReinforcementCoefficient4"].Value;
            set => CellsByName["HostilePhantomMaxReinforcementCoefficient4"].Value = value;
        }


        // Def="u8 machingWeaponLevelUpperRedSign_5"
        /// <summary>
        /// Hostile Phantom - Max Reinforcement Coefficient 5 (u8)
        /// </summary>
        /// <remarks>
        /// Maximum weapon enhancement level factor for whether to apply level sync
        /// </remarks>
        public byte HostilePhantomMaxReinforcementCoefficient5
        {
            get => (byte)CellsByName["HostilePhantomMaxReinforcementCoefficient5"].Value;
            set => CellsByName["HostilePhantomMaxReinforcementCoefficient5"].Value = value;
        }


        // Def="u8 machingWeaponLevelUpperRedSign_6"
        /// <summary>
        /// Hostile Phantom - Max Reinforcement Coefficient 6 (u8)
        /// </summary>
        /// <remarks>
        /// Maximum weapon enhancement level factor for whether to apply level sync
        /// </remarks>
        public byte HostilePhantomMaxReinforcementCoefficient6
        {
            get => (byte)CellsByName["HostilePhantomMaxReinforcementCoefficient6"].Value;
            set => CellsByName["HostilePhantomMaxReinforcementCoefficient6"].Value = value;
        }


        // Def="u8 machingWeaponLevelUpperRedSign_7"
        /// <summary>
        /// Hostile Phantom - Max Reinforcement Coefficient 7 (u8)
        /// </summary>
        /// <remarks>
        /// Maximum weapon enhancement level factor for whether to apply level sync
        /// </remarks>
        public byte HostilePhantomMaxReinforcementCoefficient7
        {
            get => (byte)CellsByName["HostilePhantomMaxReinforcementCoefficient7"].Value;
            set => CellsByName["HostilePhantomMaxReinforcementCoefficient7"].Value = value;
        }


        // Def="u8 machingWeaponLevelUpperRedSign_8"
        /// <summary>
        /// Hostile Phantom - Max Reinforcement Coefficient 8 (u8)
        /// </summary>
        /// <remarks>
        /// Maximum weapon enhancement level factor for whether to apply level sync
        /// </remarks>
        public byte HostilePhantomMaxReinforcementCoefficient8
        {
            get => (byte)CellsByName["HostilePhantomMaxReinforcementCoefficient8"].Value;
            set => CellsByName["HostilePhantomMaxReinforcementCoefficient8"].Value = value;
        }


        // Def="u8 machingWeaponLevelUpperRedSign_9"
        /// <summary>
        /// Hostile Phantom - Max Reinforcement Coefficient 9 (u8)
        /// </summary>
        /// <remarks>
        /// Maximum weapon enhancement level factor for whether to apply level sync
        /// </remarks>
        public byte HostilePhantomMaxReinforcementCoefficient9
        {
            get => (byte)CellsByName["HostilePhantomMaxReinforcementCoefficient9"].Value;
            set => CellsByName["HostilePhantomMaxReinforcementCoefficient9"].Value = value;
        }


        // Def="u8 machingWeaponLevelUpperRedSign_10"
        /// <summary>
        /// Hostile Phantom - Max Reinforcement Coefficient 10 (u8)
        /// </summary>
        /// <remarks>
        /// Maximum weapon enhancement level factor for whether to apply level sync
        /// </remarks>
        public byte HostilePhantomMaxReinforcementCoefficient10
        {
            get => (byte)CellsByName["HostilePhantomMaxReinforcementCoefficient10"].Value;
            set => CellsByName["HostilePhantomMaxReinforcementCoefficient10"].Value = value;
        }


        // Def="u8 autoInvadePoint_generateDist = 40"
        /// <summary>
        /// Automatic Invasion Point - Generation Distance (u8)
        /// </summary>
        /// <remarks>
        /// Automatic placement interval of intrusion points
        /// </remarks>
        public byte AutomaticInvasionPointGenerationDistance
        {
            get => (byte)CellsByName["AutomaticInvasionPointGenerationDistance"].Value;
            set => CellsByName["AutomaticInvasionPointGenerationDistance"].Value = value;
        }


        // Def="u8 autoInvadePoint_cancelDist = 20"
        /// <summary>
        /// Automatic Invasion Point - Cancel Distance (u8)
        /// </summary>
        /// <remarks>
        /// Intrusion point automatic placement cancellation range
        /// </remarks>
        public byte AutomaticInvasionPointCancelDistance
        {
            get => (byte)CellsByName["AutomaticInvasionPointCancelDistance"].Value;
            set => CellsByName["AutomaticInvasionPointCancelDistance"].Value = value;
        }


        // Def="f32 sendGlobalEventLogIntervalTime"
        /// <summary>
        /// Send Global Event Log Interval (f32)
        /// </summary>
        /// <remarks>
        /// Interval to send global event log to server
        /// </remarks>
        public float SendGlobalEventLogInterval
        {
            get => (float)CellsByName["SendGlobalEventLogInterval"].Value;
            set => CellsByName["SendGlobalEventLogInterval"].Value = value;
        }


        // Def="u16 addSoloBreakInPoint_White"
        /// <summary>
        /// Solo Intrusion Point - White Phantom (u16)
        /// </summary>
        /// <remarks>
        /// Solo intrusion point addition value_white sign
        /// </remarks>
        public ushort SoloIntrusionPointWhitePhantom
        {
            get => (ushort)CellsByName["SoloIntrusionPointWhitePhantom"].Value;
            set => CellsByName["SoloIntrusionPointWhitePhantom"].Value = value;
        }


        // Def="u16 addSoloBreakInPoint_Black"
        /// <summary>
        /// Solo Intrusion Point - Black Phantom (u16)
        /// </summary>
        /// <remarks>
        /// Solo intrusion point addition value_red sign
        /// </remarks>
        public ushort SoloIntrusionPointBlackPhantom
        {
            get => (ushort)CellsByName["SoloIntrusionPointBlackPhantom"].Value;
            set => CellsByName["SoloIntrusionPointBlackPhantom"].Value = value;
        }


        // Def="u16 addSoloBreakInPoint_ForceJoin"
        /// <summary>
        /// Solo Intrusion Point - Force Join (u16)
        /// </summary>
        /// <remarks>
        /// Solo intrusion point addition value_intrusion
        /// </remarks>
        public ushort SoloIntrusionPointForceJoin
        {
            get => (ushort)CellsByName["SoloIntrusionPointForceJoin"].Value;
            set => CellsByName["SoloIntrusionPointForceJoin"].Value = value;
        }


        // Def="u16 addSoloBreakInPoint_VisitorGuardian"
        /// <summary>
        /// Solo Intrusion Point - Visitor Guardian (u16)
        /// </summary>
        /// <remarks>
        /// Solo intrusion point addition value_Map guardian visit
        /// </remarks>
        public ushort SoloIntrusionPointVisitorGuardian
        {
            get => (ushort)CellsByName["SoloIntrusionPointVisitorGuardian"].Value;
            set => CellsByName["SoloIntrusionPointVisitorGuardian"].Value = value;
        }


        // Def="u16 addSoloBreakInPoint_VisitorRedHunter"
        /// <summary>
        /// Solo Intrusion Point - Red Hunter (u16)
        /// </summary>
        /// <remarks>
        /// Solo intrusion point addition value_Red Scare visit
        /// </remarks>
        public ushort SoloIntrusionPointRedHunter
        {
            get => (ushort)CellsByName["SoloIntrusionPointRedHunter"].Value;
            set => CellsByName["SoloIntrusionPointRedHunter"].Value = value;
        }


        // Def="u8 invincibleTimer_forNetPC_initSync"
        /// <summary>
        /// Invincibility Timer for Initial Player Sync (u8)
        /// </summary>
        /// <remarks>
        /// Invincible timer for initial sync PC
        /// </remarks>
        public byte InvincibilityTimerForInitialPlayerSync
        {
            get => (byte)CellsByName["InvincibilityTimerForInitialPlayerSync"].Value;
            set => CellsByName["InvincibilityTimerForInitialPlayerSync"].Value = value;
        }


        // Def="u8 invincibleTimer_forNetPC = 10"
        /// <summary>
        /// Invincibility Timer for Non-Initial Player Sync (u8)
        /// </summary>
        /// <remarks>
        /// Invincible timer for non-initial sync PCs
        /// </remarks>
        public byte InvincibilityTimerForNonInitialPlayerSync
        {
            get => (byte)CellsByName["InvincibilityTimerForNonInitialPlayerSync"].Value;
            set => CellsByName["InvincibilityTimerForNonInitialPlayerSync"].Value = value;
        }


        // Def="f32 redHunter_HostBossAreaGetSoulRate"
        /// <summary>
        /// Red Hunter - Host Boss Area Soul Absorption (f32)
        /// </summary>
        /// <remarks>
        /// Soul that you can get red hunting when the host passes through the white door = Soul required for red hunting to change from the previous Lv to the current Lv * This magnification
        /// </remarks>
        public float RedHunterHostBossAreaSoulAbsorption
        {
            get => (float)CellsByName["RedHunterHostBossAreaSoulAbsorption"].Value;
            set => CellsByName["RedHunterHostBossAreaSoulAbsorption"].Value = value;
        }


        // Def="s32 ghostFootprintDecalParamId"
        /// <summary>
        /// Ghost Footprint Decal Param ID (s32)
        /// </summary>
        /// <remarks>
        /// Decal parameter ID of the trace that the wandering illusion puts out while moving
        /// </remarks>
        public int GhostFootprintDecalParamID
        {
            get => (int)CellsByName["GhostFootprintDecalParamID"].Value;
            set => CellsByName["GhostFootprintDecalParamID"].Value = value;
        }


        // Def="f32 leaveAroundHostWarningTime"
        /// <summary>
        /// Exceeded Multiplayer Limit Distance - Warning Time (f32)
        /// </summary>
        /// <remarks>
        /// If this count time elapses while you are out of the multiplayer limit distance, the multiplayer will be disbanded.
        /// </remarks>
        public float ExceededMultiplayerLimitDistanceWarningTime
        {
            get => (float)CellsByName["ExceededMultiplayerLimitDistanceWarningTime"].Value;
            set => CellsByName["ExceededMultiplayerLimitDistanceWarningTime"].Value = value;
        }


        // Def="s32 hostModeCostItemId"
        /// <summary>
        /// Host Mode Cost Item ID (s32)
        /// </summary>
        /// <remarks>
        /// ID of the cost item consumed when hosting is turned on
        /// </remarks>
        public int HostModeCostItemID
        {
            get => (int)CellsByName["HostModeCostItemID"].Value;
            set => CellsByName["HostModeCostItemID"].Value = value;
        }


        // Def="f32 aIJump_DecelerateParam"
        /// <summary>
        /// AI Jump - Deceleration (f32)
        /// </summary>
        /// <remarks>
        /// Deceleration parameters for AI jump (0.0: constant velocity motion, 1.0: maximum deceleration, speed 0 at target point)
        /// </remarks>
        public float AIJumpDeceleration
        {
            get => (float)CellsByName["AIJumpDeceleration"].Value;
            set => CellsByName["AIJumpDeceleration"].Value = value;
        }


        // Def="f32 buddyDisappearDelaySec"
        /// <summary>
        /// Spirit Summon - Disappearance Delay (f32)
        /// </summary>
        /// <remarks>
        /// The time from the death flag to the actual disappearance of the instance
        /// </remarks>
        public float SpiritSummonDisappearanceDelay
        {
            get => (float)CellsByName["SpiritSummonDisappearanceDelay"].Value;
            set => CellsByName["SpiritSummonDisappearanceDelay"].Value = value;
        }


        // Def="f32 aIJump_AnimYMoveCorrectRate_onJumpOff"
        /// <summary>
        /// AI Jump - Y Movement Amount Correction (f32)
        /// </summary>
        /// <remarks>
        /// AI jump jumping Y movement amount correction factor
        /// </remarks>
        public float AIJumpYMovementAmountCorrection
        {
            get => (float)CellsByName["AIJumpYMovementAmountCorrection"].Value;
            set => CellsByName["AIJumpYMovementAmountCorrection"].Value = value;
        }


        // Def="f32 stealthSystemSightRate_NotInStealthRigid_NotSightHide_StealthMode = 1"
        /// <summary>
        /// Stealth Visibility - Crouch - No Stealth Effect (f32)
        /// </summary>
        /// <remarks>
        /// Stealth visibility magnification_Crouching without stealth effect
        /// </remarks>
        public float StealthVisibilityCrouchNoStealthEffect
        {
            get => (float)CellsByName["StealthVisibilityCrouchNoStealthEffect"].Value;
            set => CellsByName["StealthVisibilityCrouchNoStealthEffect"].Value = value;
        }


        // Def="f32 stealthSystemSightRate_NotInStealthRigid_SightHide_NotStealthMode = 1"
        /// <summary>
        /// Stealth Visibility - Stand - Stealth Ray Effect (f32)
        /// </summary>
        /// <remarks>
        /// Stealth visibility magnification_Standing in stealth ray shielded area
        /// </remarks>
        public float StealthVisibilityStandStealthRayEffect
        {
            get => (float)CellsByName["StealthVisibilityStandStealthRayEffect"].Value;
            set => CellsByName["StealthVisibilityStandStealthRayEffect"].Value = value;
        }


        // Def="f32 stealthSystemSightRate_NotInStealthRigid_SightHide_StealthMode = 1"
        /// <summary>
        /// Stealth Visibility - Crouch - Stealth Ray Effect (f32)
        /// </summary>
        /// <remarks>
        /// Stealth visibility magnification_Crouching in stealth ray shielded area
        /// </remarks>
        public float StealthVisibilityCrouchStealthRayEffect
        {
            get => (float)CellsByName["StealthVisibilityCrouchStealthRayEffect"].Value;
            set => CellsByName["StealthVisibilityCrouchStealthRayEffect"].Value = value;
        }


        // Def="f32 stealthSystemSightRate_InStealthRigid_NotSightHide_NotStealthMode = 1"
        /// <summary>
        /// Stealth Visibility - Stand - Stealth Hit (f32)
        /// </summary>
        /// <remarks>
        /// Stealth visibility magnification_Standing within a stealth hit
        /// </remarks>
        public float StealthVisibilityStandStealthHit
        {
            get => (float)CellsByName["StealthVisibilityStandStealthHit"].Value;
            set => CellsByName["StealthVisibilityStandStealthHit"].Value = value;
        }


        // Def="f32 stealthSystemSightRate_InStealthRigid_NotSightHide_StealthMode = 1"
        /// <summary>
        /// Stealth Visibility - Crouch - Stealth Hit (f32)
        /// </summary>
        /// <remarks>
        /// Stealth visibility magnification_Crouching within a stealth hit
        /// </remarks>
        public float StealthVisibilityCrouchStealthHit
        {
            get => (float)CellsByName["StealthVisibilityCrouchStealthHit"].Value;
            set => CellsByName["StealthVisibilityCrouchStealthHit"].Value = value;
        }


        // Def="f32 stealthSystemSightRate_InStealthRigid_SightHide_NotStealthMode = 1"
        /// <summary>
        /// Stealth Visibility - Stealth Ray + Stand in Stealth Hit (f32)
        /// </summary>
        /// <remarks>
        /// Stealth visibility magnification_Stealth ray shielded area + standing in stealth hit
        /// </remarks>
        public float StealthVisibilityStealthRayStandInStealthHit
        {
            get => (float)CellsByName["StealthVisibilityStealthRayStandInStealthHit"].Value;
            set => CellsByName["StealthVisibilityStealthRayStandInStealthHit"].Value = value;
        }


        // Def="f32 stealthSystemSightRate_InStealthRigid_SightHide_StealthMode = 1"
        /// <summary>
        /// Stealth Visibility - Stealth Ray + Crouch in Stealth Hit (f32)
        /// </summary>
        /// <remarks>
        /// Stealth visibility magnification_Stealth ray shielded area + crouching in stealth hit
        /// </remarks>
        public float StealthVisibilityStealthRayCrouchInStealthHit
        {
            get => (float)CellsByName["StealthVisibilityStealthRayCrouchInStealthHit"].Value;
            set => CellsByName["StealthVisibilityStealthRayCrouchInStealthHit"].Value = value;
        }


        // Def="s32 msbEventGeomTreasureInfo_actionButtonParamId_corpse"
        /// <summary>
        /// Treasure Corpse - Default Action Button ID (s32)
        /// </summary>
        /// <remarks>
        /// Default action button parameter ID when "Treasure corpse" is selected in the treasure box type of treasure box information for OBJ of MapStudio event
        /// </remarks>
        public int TreasureCorpseDefaultActionButtonID
        {
            get => (int)CellsByName["TreasureCorpseDefaultActionButtonID"].Value;
            set => CellsByName["TreasureCorpseDefaultActionButtonID"].Value = value;
        }


        // Def="s32 msbEventGeomTreasureInfo_itemGetAnimId_corpse"
        /// <summary>
        /// Treasure Corpse - Item Get Anim ID (s32)
        /// </summary>
        /// <remarks>
        /// When "Treasure corpse" is selected in the treasure box type of the treasure box information for OBJ of the MapStudio event, the default item is acquired. Animation ID
        /// </remarks>
        public int TreasureCorpseItemGetAnimID
        {
            get => (int)CellsByName["TreasureCorpseItemGetAnimID"].Value;
            set => CellsByName["TreasureCorpseItemGetAnimID"].Value = value;
        }


        // Def="s32 msbEventGeomTreasureInfo_actionButtonParamId_box"
        /// <summary>
        /// Treasure Chest - Default Action Button ID (s32)
        /// </summary>
        /// <remarks>
        /// Default action button parameter ID when "Treasure chest" is selected in the treasure chest type of treasure chest information for OBJ of MapStudio event
        /// </remarks>
        public int TreasureChestDefaultActionButtonID
        {
            get => (int)CellsByName["TreasureChestDefaultActionButtonID"].Value;
            set => CellsByName["TreasureChestDefaultActionButtonID"].Value = value;
        }


        // Def="s32 msbEventGeomTreasureInfo_itemGetAnimId_box"
        /// <summary>
        /// Treasure Chest - Item Get Anim ID (s32)
        /// </summary>
        /// <remarks>
        /// When "Treasure chest" is selected in the treasure chest type of the treasure chest information for OBJ of the MapStudio event, the default item acquisition animation ID
        /// </remarks>
        public int TreasureChestItemGetAnimID
        {
            get => (int)CellsByName["TreasureChestItemGetAnimID"].Value;
            set => CellsByName["TreasureChestItemGetAnimID"].Value = value;
        }


        // Def="s32 msbEventGeomTreasureInfo_actionButtonParamId_shine"
        /// <summary>
        /// FFX Treasure - Default Action Button ID (s32)
        /// </summary>
        /// <remarks>
        /// Default action button parameter ID when "Item light" is selected in the treasure chest type of treasure chest information for OBJ of MapStudio event
        /// </remarks>
        public int FFXTreasureDefaultActionButtonID
        {
            get => (int)CellsByName["FFXTreasureDefaultActionButtonID"].Value;
            set => CellsByName["FFXTreasureDefaultActionButtonID"].Value = value;
        }


        // Def="s32 msbEventGeomTreasureInfo_itemGetAnimId_shine"
        /// <summary>
        /// FFX Treasure - Item Get Anim ID (s32)
        /// </summary>
        /// <remarks>
        /// When "Item Hikari" is selected as the treasure chest type of the treasure chest information for OBJ of the MapStudio event, the default item acquisition animation ID
        /// </remarks>
        public int FFXTreasureItemGetAnimID
        {
            get => (int)CellsByName["FFXTreasureItemGetAnimID"].Value;
            set => CellsByName["FFXTreasureItemGetAnimID"].Value = value;
        }


        // Def="s32 signPuddleAssetId"
        /// <summary>
        /// Summoning Pool - Asset ID (s32)
        /// </summary>
        /// <remarks>
        /// Assets used for sign collection
        /// </remarks>
        public int SummoningPoolAssetID
        {
            get => (int)CellsByName["SummoningPoolAssetID"].Value;
            set => CellsByName["SummoningPoolAssetID"].Value = value;
        }


        // Def="s32 signPuddleAppearDmypolyId0"
        /// <summary>
        /// Summoning Pool - Dummy Poly ID [0] (s32)
        /// </summary>
        /// <remarks>
        /// Damipoli used to determine the display position of the sign in the sign pool
        /// </remarks>
        public int SummoningPoolDummyPolyID0
        {
            get => (int)CellsByName["SummoningPoolDummyPolyID0"].Value;
            set => CellsByName["SummoningPoolDummyPolyID0"].Value = value;
        }


        // Def="s32 signPuddleAppearDmypolyId1"
        /// <summary>
        /// Summoning Pool - Dummy Poly ID [1] (s32)
        /// </summary>
        /// <remarks>
        /// Damipoli used to determine the display position of the sign in the sign pool
        /// </remarks>
        public int SummoningPoolDummyPolyID1
        {
            get => (int)CellsByName["SummoningPoolDummyPolyID1"].Value;
            set => CellsByName["SummoningPoolDummyPolyID1"].Value = value;
        }


        // Def="s32 signPuddleAppearDmypolyId2"
        /// <summary>
        /// Summoning Pool - Dummy Poly ID [2] (s32)
        /// </summary>
        /// <remarks>
        /// Damipoli used to determine the display position of the sign in the sign pool
        /// </remarks>
        public int SummoningPoolDummyPolyID2
        {
            get => (int)CellsByName["SummoningPoolDummyPolyID2"].Value;
            set => CellsByName["SummoningPoolDummyPolyID2"].Value = value;
        }


        // Def="s32 signPuddleAppearDmypolyId3"
        /// <summary>
        /// Summoning Pool - Dummy Poly ID [3] (s32)
        /// </summary>
        /// <remarks>
        /// Damipoli used to determine the display position of the sign in the sign pool
        /// </remarks>
        public int SummoningPoolDummyPolyID3
        {
            get => (int)CellsByName["SummoningPoolDummyPolyID3"].Value;
            set => CellsByName["SummoningPoolDummyPolyID3"].Value = value;
        }


        // Def="f32 fallDamageRate_forRidePC = 1"
        /// <summary>
        /// Fall Damage Multiplier - Mounted Player (f32)
        /// </summary>
        /// <remarks>
        /// Rider's fall damage multiplier correction_for PC
        /// </remarks>
        public float FallDamageMultiplierMountedPlayer
        {
            get => (float)CellsByName["FallDamageMultiplierMountedPlayer"].Value;
            set => CellsByName["FallDamageMultiplierMountedPlayer"].Value = value;
        }


        // Def="f32 fallDamageRate_forRideNPC = 1"
        /// <summary>
        /// Fall Damage Multiplier - Mounted NPC (f32)
        /// </summary>
        /// <remarks>
        /// Rider's Fall Damage Multiplier Correction_for NPCs
        /// </remarks>
        public float FallDamageMultiplierMountedNPC
        {
            get => (float)CellsByName["FallDamageMultiplierMountedNPC"].Value;
            set => CellsByName["FallDamageMultiplierMountedNPC"].Value = value;
        }


        // Def="s32 OldMonkOfYellow_CreateSignSpEffectId"
        /// <summary>
        /// Old Monk of Yellow - Create Sign SpEffect ID (s32)
        /// </summary>
        /// <remarks>
        /// Special effect ID when creating the old man sign of yellow robe
        /// </remarks>
        public int OldMonkOfYellowCreateSignSpEffectID
        {
            get => (int)CellsByName["OldMonkOfYellowCreateSignSpEffectID"].Value;
            set => CellsByName["OldMonkOfYellowCreateSignSpEffectID"].Value = value;
        }


        // Def="f32 StragglerActivateDist"
        /// <summary>
        /// Straggler - Activation Distance (f32)
        /// </summary>
        /// <remarks>
        /// Defeated soldier activation distance
        /// </remarks>
        public float StragglerActivationDistance
        {
            get => (float)CellsByName["StragglerActivationDistance"].Value;
            set => CellsByName["StragglerActivationDistance"].Value = value;
        }


        // Def="s32 SpEffectId_EnableUseItem_StragglerActivate = -1"
        /// <summary>
        /// Straggler - Enable Item Use SpEffect ID (s32)
        /// </summary>
        /// <remarks>
        /// Permission to use defeated soldier items_Special effects for PC
        /// </remarks>
        public int StragglerEnableItemUseSpEffectID
        {
            get => (int)CellsByName["StragglerEnableItemUseSpEffectID"].Value;
            set => CellsByName["StragglerEnableItemUseSpEffectID"].Value = value;
        }


        // Def="s32 SpEffectId_StragglerWakeUp = -1"
        /// <summary>
        /// Straggler - Wake Up SpEffect ID (s32)
        /// </summary>
        /// <remarks>
        /// Activate defeated soldiers_Special effects for defeated soldier characters
        /// </remarks>
        public int StragglerWakeUpSpEffectID
        {
            get => (int)CellsByName["StragglerWakeUpSpEffectID"].Value;
            set => CellsByName["StragglerWakeUpSpEffectID"].Value = value;
        }


        // Def="s32 SpEffectId_StragglerTarget = -1"
        /// <summary>
        /// Straggler - Target SpEffect ID (s32)
        /// </summary>
        /// <remarks>
        /// Defeated soldiers_Special effects for subjugation targets
        /// </remarks>
        public int StragglerTargetSpEffectID
        {
            get => (int)CellsByName["StragglerTargetSpEffectID"].Value;
            set => CellsByName["StragglerTargetSpEffectID"].Value = value;
        }


        // Def="s32 SpEffectId_StragglerOppose = -1"
        /// <summary>
        /// Straggler - Oppose SpEffect ID (s32)
        /// </summary>
        /// <remarks>
        /// Defeated soldiers_Special effects after hostility
        /// </remarks>
        public int StragglerOpposeSpEffectID
        {
            get => (int)CellsByName["StragglerOpposeSpEffectID"].Value;
            set => CellsByName["StragglerOpposeSpEffectID"].Value = value;
        }


        // Def="f32 buddyWarp_TriggerTimeRayBlocked = 10"
        /// <summary>
        /// Spirit Summon - Trigger Time for Warp when Raycast is blocked (f32)
        /// </summary>
        /// <remarks>
        /// Time for a buddy to warp a player with a ray block [s]
        /// </remarks>
        public float SpiritSummonTriggerTimeForWarpWhenRaycastIsBlocked
        {
            get => (float)CellsByName["SpiritSummonTriggerTimeForWarpWhenRaycastIsBlocked"].Value;
            set => CellsByName["SpiritSummonTriggerTimeForWarpWhenRaycastIsBlocked"].Value = value;
        }


        // Def="f32 buddyWarp_TriggerDistToPlayer = 25"
        /// <summary>
        /// Spirit Summon - Trigger Warp Distance to Player (f32)
        /// </summary>
        /// <remarks>
        /// Distance at which the buddy warps the player at a straight line distance [m]
        /// </remarks>
        public float SpiritSummonTriggerWarpDistanceToPlayer
        {
            get => (float)CellsByName["SpiritSummonTriggerWarpDistanceToPlayer"].Value;
            set => CellsByName["SpiritSummonTriggerWarpDistanceToPlayer"].Value = value;
        }


        // Def="f32 buddyWarp_ThresholdTimePathStacked = 5"
        /// <summary>
        /// Spirit Summon - Time Threshold for Stuck Spirit (f32)
        /// </summary>
        /// <remarks>
        /// Judgment time when the buddy is stuck in the pass movement [s]
        /// </remarks>
        public float SpiritSummonTimeThresholdForStuckSpirit
        {
            get => (float)CellsByName["SpiritSummonTimeThresholdForStuckSpirit"].Value;
            set => CellsByName["SpiritSummonTimeThresholdForStuckSpirit"].Value = value;
        }


        // Def="f32 buddyWarp_ThresholdRangePathStacked = 1"
        /// <summary>
        /// Spirit Summon - Distance Threshold for Stuck Spirit (f32)
        /// </summary>
        /// <remarks>
        /// Distance [m] that the buddy considers to be clogged with a pass move
        /// </remarks>
        public float SpiritSummonDistanceThresholdForStuckSpirit
        {
            get => (float)CellsByName["SpiritSummonDistanceThresholdForStuckSpirit"].Value;
            set => CellsByName["SpiritSummonDistanceThresholdForStuckSpirit"].Value = value;
        }


        // Def="f32 aiSightRate_morning = 1"
        /// <summary>
        /// AI Sight Multiplier - Morning (f32)
        /// </summary>
        /// <remarks>
        /// [Morning] AI visibility magnification
        /// </remarks>
        public float AISightMultiplierMorning
        {
            get => (float)CellsByName["AISightMultiplierMorning"].Value;
            set => CellsByName["AISightMultiplierMorning"].Value = value;
        }


        // Def="f32 aiSightRate_noonA = 1"
        /// <summary>
        /// AI Sight Multiplier - Noon (f32)
        /// </summary>
        /// <remarks>
        /// [Day] AI visibility magnification
        /// </remarks>
        public float AISightMultiplierNoon
        {
            get => (float)CellsByName["AISightMultiplierNoon"].Value;
            set => CellsByName["AISightMultiplierNoon"].Value = value;
        }


        // Def="f32 buddyPassThroughTriggerTime = 0.5"
        /// <summary>
        /// Spirit Summon - Pass through Player Trigger Time (f32)
        /// </summary>
        /// <remarks>
        /// Time when the buddy and the player collide and start slipping through [s]
        /// </remarks>
        public float SpiritSummonPassThroughPlayerTriggerTime
        {
            get => (float)CellsByName["SpiritSummonPassThroughPlayerTriggerTime"].Value;
            set => CellsByName["SpiritSummonPassThroughPlayerTriggerTime"].Value = value;
        }


        // Def="f32 aiSightRate_evening = 1"
        /// <summary>
        /// AI Sight Multiplier - Evening (f32)
        /// </summary>
        /// <remarks>
        /// [Evening] AI visibility magnification
        /// </remarks>
        public float AISightMultiplierEvening
        {
            get => (float)CellsByName["AISightMultiplierEvening"].Value;
            set => CellsByName["AISightMultiplierEvening"].Value = value;
        }


        // Def="f32 aiSightRate_night = 1"
        /// <summary>
        /// AI Sight Multiplier - Night (f32)
        /// </summary>
        /// <remarks>
        /// [Night] AI visibility magnification
        /// </remarks>
        public float AISightMultiplierNight
        {
            get => (float)CellsByName["AISightMultiplierNight"].Value;
            set => CellsByName["AISightMultiplierNight"].Value = value;
        }


        // Def="f32 aiSightRate_midnightA = 1"
        /// <summary>
        /// AI Sight Multiplier - Midnight (f32)
        /// </summary>
        /// <remarks>
        /// [Midnight] AI visibility magnification
        /// </remarks>
        public float AISightMultiplierMidnight
        {
            get => (float)CellsByName["AISightMultiplierMidnight"].Value;
            set => CellsByName["AISightMultiplierMidnight"].Value = value;
        }


        // Def="dummy8 reserve4_2[4]"
        /// <summary>
        /// Reserve (dummy8)
        /// </summary>
        /// <remarks>
        /// (dummy8)
        /// </remarks>
        public object Reserve
        {
            get => (object)CellsByName["Reserve"].Value;
            set => CellsByName["Reserve"].Value = value;
        }


        // Def="f32 aiSightRate_sunloss_light = 1"
        /// <summary>
        /// AI Sight Multiplier - Sunloss - Light (f32)
        /// </summary>
        /// <remarks>
        /// AI visibility magnification_place where the sun cannot be seen (bright)
        /// </remarks>
        public float AISightMultiplierSunlossLight
        {
            get => (float)CellsByName["AISightMultiplierSunlossLight"].Value;
            set => CellsByName["AISightMultiplierSunlossLight"].Value = value;
        }


        // Def="f32 aiSightRate_sunloss_dark = 1"
        /// <summary>
        /// AI Sight Multiplier - Sunloss - Darkness (f32)
        /// </summary>
        /// <remarks>
        /// AI visibility magnification_place where the sun cannot be seen (darkness)
        /// </remarks>
        public float AISightMultiplierSunlossDarkness
        {
            get => (float)CellsByName["AISightMultiplierSunlossDarkness"].Value;
            set => CellsByName["AISightMultiplierSunlossDarkness"].Value = value;
        }


        // Def="f32 aiSightRate_sunloss_veryDark = 1"
        /// <summary>
        /// AI Sight Multiplier - Sunloss - Total Darkness (f32)
        /// </summary>
        /// <remarks>
        /// AI visibility magnification_place where the sun cannot be seen (total darkness)
        /// </remarks>
        public float AISightMultiplierSunlossTotalDarkness
        {
            get => (float)CellsByName["AISightMultiplierSunlossTotalDarkness"].Value;
            set => CellsByName["AISightMultiplierSunlossTotalDarkness"].Value = value;
        }


        // Def="f32 stealthSystemSightAngleReduceRate_NotInStealthRigid_NotSightHide_StealthMode"
        /// <summary>
        /// Stealth View Angle Attenuation - Crouch - No Stealth Effect (f32)
        /// </summary>
        /// <remarks>
        /// Stealth view angle attenuation factor_ crouching without stealth effect
        /// </remarks>
        public float StealthViewAngleAttenuationCrouchNoStealthEffect
        {
            get => (float)CellsByName["StealthViewAngleAttenuationCrouchNoStealthEffect"].Value;
            set => CellsByName["StealthViewAngleAttenuationCrouchNoStealthEffect"].Value = value;
        }


        // Def="f32 stealthSystemSightAngleReduceRate_NotInStealthRigid_SightHide_NotStealthMode"
        /// <summary>
        /// Stealth View Angle Attenuation - Stand - Stealth Ray (f32)
        /// </summary>
        /// <remarks>
        /// Stealth view angle attenuation rate_Standing in stealth ray shielded area
        /// </remarks>
        public float StealthViewAngleAttenuationStandStealthRay
        {
            get => (float)CellsByName["StealthViewAngleAttenuationStandStealthRay"].Value;
            set => CellsByName["StealthViewAngleAttenuationStandStealthRay"].Value = value;
        }


        // Def="f32 stealthSystemSightAngleReduceRate_NotInStealthRigid_SightHide_StealthMode"
        /// <summary>
        /// Stealth View Angle Attenuation - Crouch - Stealth Ray (f32)
        /// </summary>
        /// <remarks>
        /// Stealth visibility angle attenuation _ crouching in stealth ray shielded area
        /// </remarks>
        public float StealthViewAngleAttenuationCrouchStealthRay
        {
            get => (float)CellsByName["StealthViewAngleAttenuationCrouchStealthRay"].Value;
            set => CellsByName["StealthViewAngleAttenuationCrouchStealthRay"].Value = value;
        }


        // Def="f32 stealthSystemSightAngleReduceRate_InStealthRigid_NotSightHide_NotStealthMode"
        /// <summary>
        /// Stealth View Angle Attenuation - Stand - Stealth Hit (f32)
        /// </summary>
        /// <remarks>
        /// Stealth view angle attenuation rate_Standing within stealth hit
        /// </remarks>
        public float StealthViewAngleAttenuationStandStealthHit
        {
            get => (float)CellsByName["StealthViewAngleAttenuationStandStealthHit"].Value;
            set => CellsByName["StealthViewAngleAttenuationStandStealthHit"].Value = value;
        }


        // Def="f32 stealthSystemSightAngleReduceRate_InStealthRigid_NotSightHide_StealthMode"
        /// <summary>
        /// Stealth View Angle Attenuation - Crouch - Stealth Hit (f32)
        /// </summary>
        /// <remarks>
        /// Stealth view angle attenuation rate_ crouching within stealth hit
        /// </remarks>
        public float StealthViewAngleAttenuationCrouchStealthHit
        {
            get => (float)CellsByName["StealthViewAngleAttenuationCrouchStealthHit"].Value;
            set => CellsByName["StealthViewAngleAttenuationCrouchStealthHit"].Value = value;
        }


        // Def="f32 stealthSystemSightAngleReduceRate_InStealthRigid_SightHide_NotStealthMode"
        /// <summary>
        /// Stealth View Angle Attenuation - Stand - Stealth Ray + Stealth Hit (f32)
        /// </summary>
        /// <remarks>
        /// Stealth view angle attenuation rate_Stealth ray shielded area + standing in stealth hit
        /// </remarks>
        public float StealthViewAngleAttenuationStandStealthRayStealthHit
        {
            get => (float)CellsByName["StealthViewAngleAttenuationStandStealthRayStealthHit"].Value;
            set => CellsByName["StealthViewAngleAttenuationStandStealthRayStealthHit"].Value = value;
        }


        // Def="f32 stealthSystemSightAngleReduceRate_InStealthRigid_SightHide_StealthMode"
        /// <summary>
        /// Stealth View Angle Attenuation - Crouch - Stealth Ray + Stealth Hit (f32)
        /// </summary>
        /// <remarks>
        /// Stealth view angle attenuation rate_Stealth ray shielded area + crouching in stealth hit
        /// </remarks>
        public float StealthViewAngleAttenuationCrouchStealthRayStealthHit
        {
            get => (float)CellsByName["StealthViewAngleAttenuationCrouchStealthRayStealthHit"].Value;
            set => CellsByName["StealthViewAngleAttenuationCrouchStealthRayStealthHit"].Value = value;
        }


        // Def="u8 weatherLotConditionStart_Morning_Hour = 7"
        /// <summary>
        /// Weather Lottery Condition - Morning: Hour (u8)
        /// </summary>
        /// <remarks>
        /// Weather lottery conditions_morning_start time_hour (SEQ09371)
        /// </remarks>
        public byte WeatherLotteryConditionMorningHour
        {
            get => (byte)CellsByName["WeatherLotteryConditionMorningHour"].Value;
            set => CellsByName["WeatherLotteryConditionMorningHour"].Value = value;
        }


        // Def="u8 weatherLotConditionStart_Morning_Minute"
        /// <summary>
        /// Weather Lottery Condition - Morning: Minute (u8)
        /// </summary>
        /// <remarks>
        /// Weather lottery conditions_morning_start time_minutes (SEQ09371)
        /// </remarks>
        public byte WeatherLotteryConditionMorningMinute
        {
            get => (byte)CellsByName["WeatherLotteryConditionMorningMinute"].Value;
            set => CellsByName["WeatherLotteryConditionMorningMinute"].Value = value;
        }


        // Def="u8 weatherLotConditionStart_Day_Hour = 12"
        /// <summary>
        /// Weather Lottery Condition - Day: Hour (u8)
        /// </summary>
        /// <remarks>
        /// Weather lottery conditions_day_start time_hour (SEQ09371)
        /// </remarks>
        public byte WeatherLotteryConditionDayHour
        {
            get => (byte)CellsByName["WeatherLotteryConditionDayHour"].Value;
            set => CellsByName["WeatherLotteryConditionDayHour"].Value = value;
        }


        // Def="u8 weatherLotConditionStart_Day_Minute"
        /// <summary>
        /// Weather Lottery Condition - Day: Minute (u8)
        /// </summary>
        /// <remarks>
        /// Weather lottery conditions_day_start time_minutes (SEQ09371)
        /// </remarks>
        public byte WeatherLotteryConditionDayMinute
        {
            get => (byte)CellsByName["WeatherLotteryConditionDayMinute"].Value;
            set => CellsByName["WeatherLotteryConditionDayMinute"].Value = value;
        }


        // Def="u8 weatherLotConditionStart_Evening_Hour = 17"
        /// <summary>
        /// Weather Lottery Condition - Evening: Hour (u8)
        /// </summary>
        /// <remarks>
        /// Weather lottery conditions_evening_start time_hour (SEQ09371)
        /// </remarks>
        public byte WeatherLotteryConditionEveningHour
        {
            get => (byte)CellsByName["WeatherLotteryConditionEveningHour"].Value;
            set => CellsByName["WeatherLotteryConditionEveningHour"].Value = value;
        }


        // Def="u8 weatherLotConditionStart_Evening_Minute"
        /// <summary>
        /// Weather Lottery Condition - Evening: Minute (u8)
        /// </summary>
        /// <remarks>
        /// Weather lottery conditions_evening_start time_minutes (SEQ09371)
        /// </remarks>
        public byte WeatherLotteryConditionEveningMinute
        {
            get => (byte)CellsByName["WeatherLotteryConditionEveningMinute"].Value;
            set => CellsByName["WeatherLotteryConditionEveningMinute"].Value = value;
        }


        // Def="u8 weatherLotConditionStart_Night_Hour = 19"
        /// <summary>
        /// Weather Lottery Condition - Night: Hour (u8)
        /// </summary>
        /// <remarks>
        /// Weather lottery conditions_night_start time_hour (SEQ09371)
        /// </remarks>
        public byte WeatherLotteryConditionNightHour
        {
            get => (byte)CellsByName["WeatherLotteryConditionNightHour"].Value;
            set => CellsByName["WeatherLotteryConditionNightHour"].Value = value;
        }


        // Def="u8 weatherLotConditionStart_Night_Minute"
        /// <summary>
        /// Weather Lottery Condition - Night: Minute (u8)
        /// </summary>
        /// <remarks>
        /// Weather lottery conditions_night_start time_minutes (SEQ09371)
        /// </remarks>
        public byte WeatherLotteryConditionNightMinute
        {
            get => (byte)CellsByName["WeatherLotteryConditionNightMinute"].Value;
            set => CellsByName["WeatherLotteryConditionNightMinute"].Value = value;
        }


        // Def="u8 weatherLotConditionStart_DayBreak_Hour = 5"
        /// <summary>
        /// Weather Lottery Condition - Dawn: Hour (u8)
        /// </summary>
        /// <remarks>
        /// Weather lottery conditions_dawn_start time_hour (SEQ09371)
        /// </remarks>
        public byte WeatherLotteryConditionDawnHour
        {
            get => (byte)CellsByName["WeatherLotteryConditionDawnHour"].Value;
            set => CellsByName["WeatherLotteryConditionDawnHour"].Value = value;
        }


        // Def="u8 weatherLotConditionStart_DayBreak_Minute"
        /// <summary>
        /// Weather Lottery Condition - Dawn: Minute (u8)
        /// </summary>
        /// <remarks>
        /// Weather lottery conditions_dawn_start time_minutes (SEQ09371)
        /// </remarks>
        public byte WeatherLotteryConditionDawnMinute
        {
            get => (byte)CellsByName["WeatherLotteryConditionDawnMinute"].Value;
            set => CellsByName["WeatherLotteryConditionDawnMinute"].Value = value;
        }


        // Def="dummy8 weatherLotCondition_reserved[2]"
        /// <summary>
        /// Weather lottery conditions_reservation (dummy8)
        /// </summary>
        /// <remarks>
        /// (dummy8)
        /// </remarks>
        public object WeatherLotteryConditions_reservation
        {
            get => (object)CellsByName["WeatherLotteryConditions_reservation"].Value;
            set => CellsByName["WeatherLotteryConditions_reservation"].Value = value;
        }


        // Def="u8 pclightScaleChangeStart_Hour = 18"
        /// <summary>
        /// Player Light Intensity Scale - Start Hour (u8)
        /// </summary>
        /// <remarks>
        /// Player Light Intensity Scale Change Time Zone_Start Time_Hour (SEQ16562)
        /// </remarks>
        public byte PlayerLightIntensityScaleStartHour
        {
            get => (byte)CellsByName["PlayerLightIntensityScaleStartHour"].Value;
            set => CellsByName["PlayerLightIntensityScaleStartHour"].Value = value;
        }


        // Def="u8 pclightScaleChangeStart_Minute"
        /// <summary>
        /// Player Light Intensity Scale - Start Minute (u8)
        /// </summary>
        /// <remarks>
        /// Player Light Intensity Scale Change Time Zone_Start Time_Minute (SEQ16562)
        /// </remarks>
        public byte PlayerLightIntensityScaleStartMinute
        {
            get => (byte)CellsByName["PlayerLightIntensityScaleStartMinute"].Value;
            set => CellsByName["PlayerLightIntensityScaleStartMinute"].Value = value;
        }


        // Def="u8 pclightScaleChangeEnd_Hour = 5"
        /// <summary>
        /// Player Light Intensity Scale - End Hour (u8)
        /// </summary>
        /// <remarks>
        /// Player Light intensity scale change time zone_end time_hour (SEQ16562)
        /// </remarks>
        public byte PlayerLightIntensityScaleEndHour
        {
            get => (byte)CellsByName["PlayerLightIntensityScaleEndHour"].Value;
            set => CellsByName["PlayerLightIntensityScaleEndHour"].Value = value;
        }


        // Def="u8 pclightScaleChangeEnd_Minute"
        /// <summary>
        /// Player Light Intensity Scale - End Minute (u8)
        /// </summary>
        /// <remarks>
        /// Player Light Intensity Scale Change Time Zone_End Time_Minute (SEQ16562)
        /// </remarks>
        public byte PlayerLightIntensityScaleEndMinute
        {
            get => (byte)CellsByName["PlayerLightIntensityScaleEndMinute"].Value;
            set => CellsByName["PlayerLightIntensityScaleEndMinute"].Value = value;
        }


        // Def="f32 pclightScaleByTimezone = 1"
        /// <summary>
        /// Player Light Intensity Scale - Timezone (f32)
        /// </summary>
        /// <remarks>
        /// Time zone Player light intensity scale change value (SEQ16562)
        /// </remarks>
        public float PlayerLightIntensityScaleTimezone
        {
            get => (float)CellsByName["PlayerLightIntensityScaleTimezone"].Value;
            set => CellsByName["PlayerLightIntensityScaleTimezone"].Value = value;
        }


        // Def="s32 bigRuneGreaterDemon_SummonBuddySpecialEffectId_Buddy = -1"
        /// <summary>
        /// Great Rune - Greater Demon Spirit Summon - Spirit SpEffect ID (s32)
        /// </summary>
        /// <remarks>
        /// Large Rune: Greater Demon Buddy Summon Buddy Special Effect ID
        /// </remarks>
        public int GreatRuneGreaterDemonSpiritSummonSpiritSpEffectID
        {
            get => (int)CellsByName["GreatRuneGreaterDemonSpiritSummonSpiritSpEffectID"].Value;
            set => CellsByName["GreatRuneGreaterDemonSpiritSummonSpiritSpEffectID"].Value = value;
        }


        // Def="s32 bigRuneGreaterDemon_SummonBuddySpecialEffectId_Pc = -1"
        /// <summary>
        /// Great Rune - Greater Demon Spirit Summon - Player SpEffect ID (s32)
        /// </summary>
        /// <remarks>
        /// Large Rune: Special effect ID given to PC when summoning Greater Demon Buddy
        /// </remarks>
        public int GreatRuneGreaterDemonSpiritSummonPlayerSpEffectID
        {
            get => (int)CellsByName["GreatRuneGreaterDemonSpiritSummonPlayerSpEffectID"].Value;
            set => CellsByName["GreatRuneGreaterDemonSpiritSummonPlayerSpEffectID"].Value = value;
        }


        // Def="s32 homeBonfireParamId"
        /// <summary>
        /// Base Bonfire Warp Param ID (s32)
        /// </summary>
        /// <remarks>
        /// Base bonfire bonfire warp parameter ID
        /// </remarks>
        public int BaseBonfireWarpParamID
        {
            get => (int)CellsByName["BaseBonfireWarpParamID"].Value;
            set => CellsByName["BaseBonfireWarpParamID"].Value = value;
        }


        // Def="u8 machingWeaponLevelUpperWhiteSign_11"
        /// <summary>
        /// Friendly Phantom - Max Reinforcement Coefficient 11 (u8)
        /// </summary>
        /// <remarks>
        /// Maximum weapon enhancement level factor for whether to apply level sync
        /// </remarks>
        public byte FriendlyPhantomMaxReinforcementCoefficient11
        {
            get => (byte)CellsByName["FriendlyPhantomMaxReinforcementCoefficient11"].Value;
            set => CellsByName["FriendlyPhantomMaxReinforcementCoefficient11"].Value = value;
        }


        // Def="u8 machingWeaponLevelUpperWhiteSign_12"
        /// <summary>
        /// Friendly Phantom - Max Reinforcement Coefficient 12 (u8)
        /// </summary>
        /// <remarks>
        /// Maximum weapon enhancement level factor for whether to apply level sync
        /// </remarks>
        public byte FriendlyPhantomMaxReinforcementCoefficient12
        {
            get => (byte)CellsByName["FriendlyPhantomMaxReinforcementCoefficient12"].Value;
            set => CellsByName["FriendlyPhantomMaxReinforcementCoefficient12"].Value = value;
        }


        // Def="u8 machingWeaponLevelUpperWhiteSign_13"
        /// <summary>
        /// Friendly Phantom - Max Reinforcement Coefficient 13 (u8)
        /// </summary>
        /// <remarks>
        /// Maximum weapon enhancement level factor for whether to apply level sync
        /// </remarks>
        public byte FriendlyPhantomMaxReinforcementCoefficient13
        {
            get => (byte)CellsByName["FriendlyPhantomMaxReinforcementCoefficient13"].Value;
            set => CellsByName["FriendlyPhantomMaxReinforcementCoefficient13"].Value = value;
        }


        // Def="u8 machingWeaponLevelUpperWhiteSign_14"
        /// <summary>
        /// Friendly Phantom - Max Reinforcement Coefficient 14 (u8)
        /// </summary>
        /// <remarks>
        /// Maximum weapon enhancement level factor for whether to apply level sync
        /// </remarks>
        public byte FriendlyPhantomMaxReinforcementCoefficient14
        {
            get => (byte)CellsByName["FriendlyPhantomMaxReinforcementCoefficient14"].Value;
            set => CellsByName["FriendlyPhantomMaxReinforcementCoefficient14"].Value = value;
        }


        // Def="u8 machingWeaponLevelUpperWhiteSign_15"
        /// <summary>
        /// Friendly Phantom - Max Reinforcement Coefficient 15 (u8)
        /// </summary>
        /// <remarks>
        /// Maximum weapon enhancement level factor for whether to apply level sync
        /// </remarks>
        public byte FriendlyPhantomMaxReinforcementCoefficient15
        {
            get => (byte)CellsByName["FriendlyPhantomMaxReinforcementCoefficient15"].Value;
            set => CellsByName["FriendlyPhantomMaxReinforcementCoefficient15"].Value = value;
        }


        // Def="u8 machingWeaponLevelUpperWhiteSign_16"
        /// <summary>
        /// Friendly Phantom - Max Reinforcement Coefficient 16 (u8)
        /// </summary>
        /// <remarks>
        /// Maximum weapon enhancement level factor for whether to apply level sync
        /// </remarks>
        public byte FriendlyPhantomMaxReinforcementCoefficient16
        {
            get => (byte)CellsByName["FriendlyPhantomMaxReinforcementCoefficient16"].Value;
            set => CellsByName["FriendlyPhantomMaxReinforcementCoefficient16"].Value = value;
        }


        // Def="u8 machingWeaponLevelUpperWhiteSign_17"
        /// <summary>
        /// Friendly Phantom - Max Reinforcement Coefficient 17 (u8)
        /// </summary>
        /// <remarks>
        /// Maximum weapon enhancement level factor for whether to apply level sync
        /// </remarks>
        public byte FriendlyPhantomMaxReinforcementCoefficient17
        {
            get => (byte)CellsByName["FriendlyPhantomMaxReinforcementCoefficient17"].Value;
            set => CellsByName["FriendlyPhantomMaxReinforcementCoefficient17"].Value = value;
        }


        // Def="u8 machingWeaponLevelUpperWhiteSign_18"
        /// <summary>
        /// Friendly Phantom - Max Reinforcement Coefficient 18 (u8)
        /// </summary>
        /// <remarks>
        /// Maximum weapon enhancement level factor for whether to apply level sync
        /// </remarks>
        public byte FriendlyPhantomMaxReinforcementCoefficient18
        {
            get => (byte)CellsByName["FriendlyPhantomMaxReinforcementCoefficient18"].Value;
            set => CellsByName["FriendlyPhantomMaxReinforcementCoefficient18"].Value = value;
        }


        // Def="u8 machingWeaponLevelUpperWhiteSign_19"
        /// <summary>
        /// Friendly Phantom - Max Reinforcement Coefficient 19 (u8)
        /// </summary>
        /// <remarks>
        /// Maximum weapon enhancement level factor for whether to apply level sync
        /// </remarks>
        public byte FriendlyPhantomMaxReinforcementCoefficient19
        {
            get => (byte)CellsByName["FriendlyPhantomMaxReinforcementCoefficient19"].Value;
            set => CellsByName["FriendlyPhantomMaxReinforcementCoefficient19"].Value = value;
        }


        // Def="u8 machingWeaponLevelUpperWhiteSign_20"
        /// <summary>
        /// Friendly Phantom - Max Reinforcement Coefficient 20 (u8)
        /// </summary>
        /// <remarks>
        /// Maximum weapon enhancement level factor for whether to apply level sync
        /// </remarks>
        public byte FriendlyPhantomMaxReinforcementCoefficient20
        {
            get => (byte)CellsByName["FriendlyPhantomMaxReinforcementCoefficient20"].Value;
            set => CellsByName["FriendlyPhantomMaxReinforcementCoefficient20"].Value = value;
        }


        // Def="u8 machingWeaponLevelUpperWhiteSign_21"
        /// <summary>
        /// Friendly Phantom - Max Reinforcement Coefficient 21 (u8)
        /// </summary>
        /// <remarks>
        /// Maximum weapon enhancement level factor for whether to apply level sync
        /// </remarks>
        public byte FriendlyPhantomMaxReinforcementCoefficient21
        {
            get => (byte)CellsByName["FriendlyPhantomMaxReinforcementCoefficient21"].Value;
            set => CellsByName["FriendlyPhantomMaxReinforcementCoefficient21"].Value = value;
        }


        // Def="u8 machingWeaponLevelUpperWhiteSign_22"
        /// <summary>
        /// Friendly Phantom - Max Reinforcement Coefficient 22 (u8)
        /// </summary>
        /// <remarks>
        /// Maximum weapon enhancement level factor for whether to apply level sync
        /// </remarks>
        public byte FriendlyPhantomMaxReinforcementCoefficient22
        {
            get => (byte)CellsByName["FriendlyPhantomMaxReinforcementCoefficient22"].Value;
            set => CellsByName["FriendlyPhantomMaxReinforcementCoefficient22"].Value = value;
        }


        // Def="u8 machingWeaponLevelUpperWhiteSign_23"
        /// <summary>
        /// Friendly Phantom - Max Reinforcement Coefficient 23 (u8)
        /// </summary>
        /// <remarks>
        /// Maximum weapon enhancement level factor for whether to apply level sync
        /// </remarks>
        public byte FriendlyPhantomMaxReinforcementCoefficient23
        {
            get => (byte)CellsByName["FriendlyPhantomMaxReinforcementCoefficient23"].Value;
            set => CellsByName["FriendlyPhantomMaxReinforcementCoefficient23"].Value = value;
        }


        // Def="u8 machingWeaponLevelUpperWhiteSign_24"
        /// <summary>
        /// Friendly Phantom - Max Reinforcement Coefficient 24 (u8)
        /// </summary>
        /// <remarks>
        /// Maximum weapon enhancement level factor for whether to apply level sync
        /// </remarks>
        public byte FriendlyPhantomMaxReinforcementCoefficient24
        {
            get => (byte)CellsByName["FriendlyPhantomMaxReinforcementCoefficient24"].Value;
            set => CellsByName["FriendlyPhantomMaxReinforcementCoefficient24"].Value = value;
        }


        // Def="u8 machingWeaponLevelUpperWhiteSign_25"
        /// <summary>
        /// Friendly Phantom - Max Reinforcement Coefficient 25 (u8)
        /// </summary>
        /// <remarks>
        /// Maximum weapon enhancement level factor for whether to apply level sync
        /// </remarks>
        public byte FriendlyPhantomMaxReinforcementCoefficient25
        {
            get => (byte)CellsByName["FriendlyPhantomMaxReinforcementCoefficient25"].Value;
            set => CellsByName["FriendlyPhantomMaxReinforcementCoefficient25"].Value = value;
        }


        // Def="u8 machingWeaponLevelUpperRedSign_11"
        /// <summary>
        /// Hostile Phantom - Max Reinforcement Coefficient 11 (u8)
        /// </summary>
        /// <remarks>
        /// Maximum weapon enhancement level factor for whether to apply level sync
        /// </remarks>
        public byte HostilePhantomMaxReinforcementCoefficient11
        {
            get => (byte)CellsByName["HostilePhantomMaxReinforcementCoefficient11"].Value;
            set => CellsByName["HostilePhantomMaxReinforcementCoefficient11"].Value = value;
        }


        // Def="u8 machingWeaponLevelUpperRedSign_12"
        /// <summary>
        /// Hostile Phantom - Max Reinforcement Coefficient 12 (u8)
        /// </summary>
        /// <remarks>
        /// Maximum weapon enhancement level factor for whether to apply level sync
        /// </remarks>
        public byte HostilePhantomMaxReinforcementCoefficient12
        {
            get => (byte)CellsByName["HostilePhantomMaxReinforcementCoefficient12"].Value;
            set => CellsByName["HostilePhantomMaxReinforcementCoefficient12"].Value = value;
        }


        // Def="u8 machingWeaponLevelUpperRedSign_13"
        /// <summary>
        /// Hostile Phantom - Max Reinforcement Coefficient 13 (u8)
        /// </summary>
        /// <remarks>
        /// Maximum weapon enhancement level factor for whether to apply level sync
        /// </remarks>
        public byte HostilePhantomMaxReinforcementCoefficient13
        {
            get => (byte)CellsByName["HostilePhantomMaxReinforcementCoefficient13"].Value;
            set => CellsByName["HostilePhantomMaxReinforcementCoefficient13"].Value = value;
        }


        // Def="u8 machingWeaponLevelUpperRedSign_14"
        /// <summary>
        /// Hostile Phantom - Max Reinforcement Coefficient 14 (u8)
        /// </summary>
        /// <remarks>
        /// Maximum weapon enhancement level factor for whether to apply level sync
        /// </remarks>
        public byte HostilePhantomMaxReinforcementCoefficient14
        {
            get => (byte)CellsByName["HostilePhantomMaxReinforcementCoefficient14"].Value;
            set => CellsByName["HostilePhantomMaxReinforcementCoefficient14"].Value = value;
        }


        // Def="u8 machingWeaponLevelUpperRedSign_15"
        /// <summary>
        /// Hostile Phantom - Max Reinforcement Coefficient 15 (u8)
        /// </summary>
        /// <remarks>
        /// Maximum weapon enhancement level factor for whether to apply level sync
        /// </remarks>
        public byte HostilePhantomMaxReinforcementCoefficient15
        {
            get => (byte)CellsByName["HostilePhantomMaxReinforcementCoefficient15"].Value;
            set => CellsByName["HostilePhantomMaxReinforcementCoefficient15"].Value = value;
        }


        // Def="u8 machingWeaponLevelUpperRedSign_16"
        /// <summary>
        /// Hostile Phantom - Max Reinforcement Coefficient 16 (u8)
        /// </summary>
        /// <remarks>
        /// Maximum weapon enhancement level factor for whether to apply level sync
        /// </remarks>
        public byte HostilePhantomMaxReinforcementCoefficient16
        {
            get => (byte)CellsByName["HostilePhantomMaxReinforcementCoefficient16"].Value;
            set => CellsByName["HostilePhantomMaxReinforcementCoefficient16"].Value = value;
        }


        // Def="u8 machingWeaponLevelUpperRedSign_17"
        /// <summary>
        /// Hostile Phantom - Max Reinforcement Coefficient 17 (u8)
        /// </summary>
        /// <remarks>
        /// Maximum weapon enhancement level factor for whether to apply level sync
        /// </remarks>
        public byte HostilePhantomMaxReinforcementCoefficient17
        {
            get => (byte)CellsByName["HostilePhantomMaxReinforcementCoefficient17"].Value;
            set => CellsByName["HostilePhantomMaxReinforcementCoefficient17"].Value = value;
        }


        // Def="u8 machingWeaponLevelUpperRedSign_18"
        /// <summary>
        /// Hostile Phantom - Max Reinforcement Coefficient 18 (u8)
        /// </summary>
        /// <remarks>
        /// Maximum weapon enhancement level factor for whether to apply level sync
        /// </remarks>
        public byte HostilePhantomMaxReinforcementCoefficient18
        {
            get => (byte)CellsByName["HostilePhantomMaxReinforcementCoefficient18"].Value;
            set => CellsByName["HostilePhantomMaxReinforcementCoefficient18"].Value = value;
        }


        // Def="u8 machingWeaponLevelUpperRedSign_19"
        /// <summary>
        /// Hostile Phantom - Max Reinforcement Coefficient 19 (u8)
        /// </summary>
        /// <remarks>
        /// Maximum weapon enhancement level factor for whether to apply level sync
        /// </remarks>
        public byte HostilePhantomMaxReinforcementCoefficient19
        {
            get => (byte)CellsByName["HostilePhantomMaxReinforcementCoefficient19"].Value;
            set => CellsByName["HostilePhantomMaxReinforcementCoefficient19"].Value = value;
        }


        // Def="u8 machingWeaponLevelUpperRedSign_20"
        /// <summary>
        /// Hostile Phantom - Max Reinforcement Coefficient 20 (u8)
        /// </summary>
        /// <remarks>
        /// Maximum weapon enhancement level factor for whether to apply level sync
        /// </remarks>
        public byte HostilePhantomMaxReinforcementCoefficient20
        {
            get => (byte)CellsByName["HostilePhantomMaxReinforcementCoefficient20"].Value;
            set => CellsByName["HostilePhantomMaxReinforcementCoefficient20"].Value = value;
        }


        // Def="u8 machingWeaponLevelUpperRedSign_21"
        /// <summary>
        /// Hostile Phantom - Max Reinforcement Coefficient 21 (u8)
        /// </summary>
        /// <remarks>
        /// Maximum weapon enhancement level factor for whether to apply level sync
        /// </remarks>
        public byte HostilePhantomMaxReinforcementCoefficient21
        {
            get => (byte)CellsByName["HostilePhantomMaxReinforcementCoefficient21"].Value;
            set => CellsByName["HostilePhantomMaxReinforcementCoefficient21"].Value = value;
        }


        // Def="u8 machingWeaponLevelUpperRedSign_22"
        /// <summary>
        /// Hostile Phantom - Max Reinforcement Coefficient 22 (u8)
        /// </summary>
        /// <remarks>
        /// Maximum weapon enhancement level factor for whether to apply level sync
        /// </remarks>
        public byte HostilePhantomMaxReinforcementCoefficient22
        {
            get => (byte)CellsByName["HostilePhantomMaxReinforcementCoefficient22"].Value;
            set => CellsByName["HostilePhantomMaxReinforcementCoefficient22"].Value = value;
        }


        // Def="u8 machingWeaponLevelUpperRedSign_23"
        /// <summary>
        /// Hostile Phantom - Max Reinforcement Coefficient 23 (u8)
        /// </summary>
        /// <remarks>
        /// Maximum weapon enhancement level factor for whether to apply level sync
        /// </remarks>
        public byte HostilePhantomMaxReinforcementCoefficient23
        {
            get => (byte)CellsByName["HostilePhantomMaxReinforcementCoefficient23"].Value;
            set => CellsByName["HostilePhantomMaxReinforcementCoefficient23"].Value = value;
        }


        // Def="u8 machingWeaponLevelUpperRedSign_24"
        /// <summary>
        /// Hostile Phantom - Max Reinforcement Coefficient 24 (u8)
        /// </summary>
        /// <remarks>
        /// Maximum weapon enhancement level factor for whether to apply level sync
        /// </remarks>
        public byte HostilePhantomMaxReinforcementCoefficient24
        {
            get => (byte)CellsByName["HostilePhantomMaxReinforcementCoefficient24"].Value;
            set => CellsByName["HostilePhantomMaxReinforcementCoefficient24"].Value = value;
        }


        // Def="u8 machingWeaponLevelUpperRedSign_25"
        /// <summary>
        /// Hostile Phantom - Max Reinforcement Coefficient 25 (u8)
        /// </summary>
        /// <remarks>
        /// Maximum weapon enhancement level factor for whether to apply level sync
        /// </remarks>
        public byte HostilePhantomMaxReinforcementCoefficient25
        {
            get => (byte)CellsByName["HostilePhantomMaxReinforcementCoefficient25"].Value;
            set => CellsByName["HostilePhantomMaxReinforcementCoefficient25"].Value = value;
        }


        // Def="u8 menuTimezoneStart_Morning_Hour = 7"
        /// <summary>
        /// Menu Timezone - Morning: Hour (u8)
        /// </summary>
        /// <remarks>
        /// Menu time zone display_morning_start time_hour (SEQ22108)
        /// </remarks>
        public byte MenuTimezoneMorningHour
        {
            get => (byte)CellsByName["MenuTimezoneMorningHour"].Value;
            set => CellsByName["MenuTimezoneMorningHour"].Value = value;
        }


        // Def="u8 menuTimezoneStart_Morning_Minute"
        /// <summary>
        /// Menu Timezone - Morning: Minute (u8)
        /// </summary>
        /// <remarks>
        /// Menu time zone display_morning_start time_minute (SEQ22108)
        /// </remarks>
        public byte MenuTimezoneMorningMinute
        {
            get => (byte)CellsByName["MenuTimezoneMorningMinute"].Value;
            set => CellsByName["MenuTimezoneMorningMinute"].Value = value;
        }


        // Def="u8 menuTimezoneStart_Day1_Hour = 12"
        /// <summary>
        /// Menu Timezone - Day 1: Hour (u8)
        /// </summary>
        /// <remarks>
        /// Menu time zone display_day 1_start time_hour (SEQ22108)
        /// </remarks>
        public byte MenuTimezoneDay1Hour
        {
            get => (byte)CellsByName["MenuTimezoneDay1Hour"].Value;
            set => CellsByName["MenuTimezoneDay1Hour"].Value = value;
        }


        // Def="u8 menuTimezoneStart_Day1_Minute"
        /// <summary>
        /// Menu Timezone - Day 1: Minute (u8)
        /// </summary>
        /// <remarks>
        /// Menu time zone display_day 1_start time_minute (SEQ22108)
        /// </remarks>
        public byte MenuTimezoneDay1Minute
        {
            get => (byte)CellsByName["MenuTimezoneDay1Minute"].Value;
            set => CellsByName["MenuTimezoneDay1Minute"].Value = value;
        }


        // Def="u8 menuTimezoneStart_Day2_Hour = 12"
        /// <summary>
        /// Menu Timezone - Day 2: Hour (u8)
        /// </summary>
        /// <remarks>
        /// Menu time zone display_day 2_start time_hour (SEQ22108)
        /// </remarks>
        public byte MenuTimezoneDay2Hour
        {
            get => (byte)CellsByName["MenuTimezoneDay2Hour"].Value;
            set => CellsByName["MenuTimezoneDay2Hour"].Value = value;
        }


        // Def="u8 menuTimezoneStart_Day2_Minute"
        /// <summary>
        /// Menu Timezone - Day 2: Minute (u8)
        /// </summary>
        /// <remarks>
        /// Time zone display for menu_Lunch 2_Start time_Minute (SEQ22108)
        /// </remarks>
        public byte MenuTimezoneDay2Minute
        {
            get => (byte)CellsByName["MenuTimezoneDay2Minute"].Value;
            set => CellsByName["MenuTimezoneDay2Minute"].Value = value;
        }


        // Def="u8 menuTimezoneStart_Evening_Hour = 17"
        /// <summary>
        /// Menu Timezone - Evening: Hour (u8)
        /// </summary>
        /// <remarks>
        /// Menu time zone display_evening_start time_hour (SEQ22108)
        /// </remarks>
        public byte MenuTimezoneEveningHour
        {
            get => (byte)CellsByName["MenuTimezoneEveningHour"].Value;
            set => CellsByName["MenuTimezoneEveningHour"].Value = value;
        }


        // Def="u8 menuTimezoneStart_Evening_Minute"
        /// <summary>
        /// Menu Timezone - Evening: Minute (u8)
        /// </summary>
        /// <remarks>
        /// Menu time zone display_evening_start time_minute (SEQ22108)
        /// </remarks>
        public byte MenuTimezoneEveningMinute
        {
            get => (byte)CellsByName["MenuTimezoneEveningMinute"].Value;
            set => CellsByName["MenuTimezoneEveningMinute"].Value = value;
        }


        // Def="u8 menuTimezoneStart_Night_Hour = 19"
        /// <summary>
        /// Menu Timezone - Night: Hour (u8)
        /// </summary>
        /// <remarks>
        /// Menu time zone display_night_start time_hour (SEQ22108)
        /// </remarks>
        public byte MenuTimezoneNightHour
        {
            get => (byte)CellsByName["MenuTimezoneNightHour"].Value;
            set => CellsByName["MenuTimezoneNightHour"].Value = value;
        }


        // Def="u8 menuTimezoneStart_Night_Minute"
        /// <summary>
        /// Menu Timezone - Night: Minute (u8)
        /// </summary>
        /// <remarks>
        /// Menu time zone display_night_start time_minute (SEQ22108)
        /// </remarks>
        public byte MenuTimezoneNightMinute
        {
            get => (byte)CellsByName["MenuTimezoneNightMinute"].Value;
            set => CellsByName["MenuTimezoneNightMinute"].Value = value;
        }


        // Def="u8 menuTimezoneStart_Midnight_Hour = 5"
        /// <summary>
        /// Menu Timezone - Midnight: Hour (u8)
        /// </summary>
        /// <remarks>
        /// Menu time zone display_midnight_start time_hour (SEQ22108)
        /// </remarks>
        public byte MenuTimezoneMidnightHour
        {
            get => (byte)CellsByName["MenuTimezoneMidnightHour"].Value;
            set => CellsByName["MenuTimezoneMidnightHour"].Value = value;
        }


        // Def="u8 menuTimezoneStart_Midnight_Minute"
        /// <summary>
        /// Menu Timezone - Midnight: Minute (u8)
        /// </summary>
        /// <remarks>
        /// Menu time zone display_midnight_start time_minute (SEQ22108)
        /// </remarks>
        public byte MenuTimezoneMidnightMinute
        {
            get => (byte)CellsByName["MenuTimezoneMidnightMinute"].Value;
            set => CellsByName["MenuTimezoneMidnightMinute"].Value = value;
        }


        // Def="u16 remotePlayerThreatLvNotify_ThreatLv"
        /// <summary>
        /// Network Player Threat Notification - Threat Level (u16)
        /// </summary>
        /// <remarks>
        /// Network PC Threat Level Notification_Threat Level (SEQ21950)
        /// </remarks>
        public ushort NetworkPlayerThreatNotificationThreatLevel
        {
            get => (ushort)CellsByName["NetworkPlayerThreatNotificationThreatLevel"].Value;
            set => CellsByName["NetworkPlayerThreatNotificationThreatLevel"].Value = value;
        }


        // Def="f32 remotePlayerThreatLvNotify_NotifyDist"
        /// <summary>
        /// Network Player Threat Notification - Notify Distance (f32)
        /// </summary>
        /// <remarks>
        /// Network PC Threat Level Notification_Notification Distance [m] (SEQ21950)
        /// </remarks>
        public float NetworkPlayerThreatNotificationNotifyDistance
        {
            get => (float)CellsByName["NetworkPlayerThreatNotificationNotifyDistance"].Value;
            set => CellsByName["NetworkPlayerThreatNotificationNotifyDistance"].Value = value;
        }


        // Def="f32 remotePlayerThreatLvNotify_EndNotifyDist"
        /// <summary>
        /// Network Player Threat Notification - Max Notify Distance (f32)
        /// </summary>
        /// <remarks>
        /// Network PC threat level notification_notification end distance [m] (SEQ21950)
        /// </remarks>
        public float NetworkPlayerThreatNotificationMaxNotifyDistance
        {
            get => (float)CellsByName["NetworkPlayerThreatNotificationMaxNotifyDistance"].Value;
            set => CellsByName["NetworkPlayerThreatNotificationMaxNotifyDistance"].Value = value;
        }


        // Def="f32 worldMapPointDiscoveryExpandRange"
        /// <summary>
        /// World Map Point - Discovery Expand Range (f32)
        /// </summary>
        /// <remarks>
        /// The default extended distance for the map point discovery area. When the "discovery area overwrite area" of the map point is invalid (-1), the discovery area is generated by expanding from its own area. Its extended distance
        /// </remarks>
        public float WorldMapPointDiscoveryExpandRange
        {
            get => (float)CellsByName["WorldMapPointDiscoveryExpandRange"].Value;
            set => CellsByName["WorldMapPointDiscoveryExpandRange"].Value = value;
        }


        // Def="f32 worldMapPointReentryExpandRange"
        /// <summary>
        /// World Map Point - Re-entry Expand Range (f32)
        /// </summary>
        /// <remarks>
        /// The default extended distance for the map point's entry area. When the "participation area overwrite area" of the map point is invalid (-1), the participation area is generated by expanding from its own area. Its extended distance
        /// </remarks>
        public float WorldMapPointReEntryExpandRange
        {
            get => (float)CellsByName["WorldMapPointReEntryExpandRange"].Value;
            set => CellsByName["WorldMapPointReEntryExpandRange"].Value = value;
        }


        // Def="u16 remotePlayerThreatLvNotify_NotifyTime"
        /// <summary>
        /// Network Player Threat Notification - Notify Time (u16)
        /// </summary>
        /// <remarks>
        /// Network PC Threat Level Notification_Notification Time [seconds] (SEQ21950)
        /// </remarks>
        public ushort NetworkPlayerThreatNotificationNotifyTime
        {
            get => (ushort)CellsByName["NetworkPlayerThreatNotificationNotifyTime"].Value;
            set => CellsByName["NetworkPlayerThreatNotificationNotifyTime"].Value = value;
        }


        // Def="u16 breakIn_A_rebreakInGoodsNum"
        /// <summary>
        /// Phantom Bloody Finger - Count (u16)
        /// </summary>
        /// <remarks>
        /// Number of "re-invasion items" to be given at the time of intrusion: Intrusion item_Greater system (ID102)
        /// </remarks>
        public ushort PhantomBloodyFingerCount
        {
            get => (ushort)CellsByName["PhantomBloodyFingerCount"].Value;
            set => CellsByName["PhantomBloodyFingerCount"].Value = value;
        }


        // Def="s32 breakIn_A_rebreakInGoodsId = -1"
        /// <summary>
        /// Phantom Bloody Finger - Goods ID (s32)
        /// </summary>
        /// <remarks>
        /// Tool item ID of "re-invasion item" given at the time of intrusion: Invasion item_Greater system (ID102)
        /// </remarks>
        public int PhantomBloodyFingerGoodsID
        {
            get => (int)CellsByName["PhantomBloodyFingerGoodsID"].Value;
            set => CellsByName["PhantomBloodyFingerGoodsID"].Value = value;
        }


        // Def="s32 rideJumpoff_SfxId = -1"
        /// <summary>
        /// Spiritspring SFX ID (s32)
        /// </summary>
        /// <remarks>
        /// Big jump to get off _ sky SFXID
        /// </remarks>
        public int SpiritspringSFXID
        {
            get => (int)CellsByName["SpiritspringSFXID"].Value;
            set => CellsByName["SpiritspringSFXID"].Value = value;
        }


        // Def="f32 rideJumpoff_SfxHeightOffset"
        /// <summary>
        /// Spiritspring SFX Height Offset (f32)
        /// </summary>
        /// <remarks>
        /// Big jump to get off_SFX base point offset in the sky
        /// </remarks>
        public float SpiritspringSFXHeightOffset
        {
            get => (float)CellsByName["SpiritspringSFXHeightOffset"].Value;
            set => CellsByName["SpiritspringSFXHeightOffset"].Value = value;
        }


        // Def="s32 rideJumpoff_SpEffectId = -1"
        /// <summary>
        /// Spiritspring SpEffect ID (Horse) (s32)
        /// </summary>
        /// <remarks>
        /// In the big jump area to get off _ Special effect ID for PC horse
        /// </remarks>
        public int SpiritspringSpEffectIDHorse
        {
            get => (int)CellsByName["SpiritspringSpEffectIDHorse"].Value;
            set => CellsByName["SpiritspringSpEffectIDHorse"].Value = value;
        }


        // Def="s32 rideJumpoff_SpEffectIdPc = -1"
        /// <summary>
        /// Spiritspring SpEffect ID (Player) (s32)
        /// </summary>
        /// <remarks>
        /// Special effect ID for _PC in the big jump area to get off
        /// </remarks>
        public int SpiritspringSpEffectIDPlayer
        {
            get => (int)CellsByName["SpiritspringSpEffectIDPlayer"].Value;
            set => CellsByName["SpiritspringSpEffectIDPlayer"].Value = value;
        }


        // Def="u32 unlockExchangeMenuEventFlagId"
        /// <summary>
        /// Unlock Exchange Menu - Event Flag ID (u32)
        /// </summary>
        /// <remarks>
        /// Main menu → Event flag to unlock the item creation menu
        /// </remarks>
        public uint UnlockExchangeMenuEventFlagID
        {
            get => (uint)CellsByName["UnlockExchangeMenuEventFlagID"].Value;
            set => CellsByName["UnlockExchangeMenuEventFlagID"].Value = value;
        }


        // Def="u32 unlockMessageMenuEventFlagId"
        /// <summary>
        /// Unlock Message Menu - Event Flag ID (u32)
        /// </summary>
        /// <remarks>
        /// Main menu → Event flag to unlock the message menu
        /// </remarks>
        public uint UnlockMessageMenuEventFlagID
        {
            get => (uint)CellsByName["UnlockMessageMenuEventFlagID"].Value;
            set => CellsByName["UnlockMessageMenuEventFlagID"].Value = value;
        }



        // Def="u16 breakIn_B_rebreakInGoodsNum"
        /// <summary>
        /// Phantom Recusant Finger - Count (u16)
        /// </summary>
        /// <remarks>
        /// Number of "re-invasion items" to be given at the time of invasion: Invasion item_Volcano building system (ID112)
        /// </remarks>
        public ushort PhantomRecusantFingerCount
        {
            get => (ushort)CellsByName["PhantomRecusantFingerCount"].Value;
            set => CellsByName["PhantomRecusantFingerCount"].Value = value;
        }



        // Def="s32 breakIn_B_rebreakInGoodsId = -1"
        /// <summary>
        /// Phantom Recusant Finger - Goods ID (s32)
        /// </summary>
        /// <remarks>
        /// Tool item ID of "re-invasion item" given at the time of invasion: Invasion item_Volcano building system (ID112)
        /// </remarks>
        public int PhantomRecusantFingerGoodsID
        {
            get => (int)CellsByName["PhantomRecusantFingerGoodsID"].Value;
            set => CellsByName["PhantomRecusantFingerGoodsID"].Value = value;
        }


        // Def="f32 actionButtonInputCancelTime = -1"
        /// <summary>
        /// Action Button Input Cancel Time (f32)
        /// </summary>
        /// <remarks>
        /// Time to disable action button operation by holding down the action button
        /// </remarks>
        public float ActionButtonInputCancelTime
        {
            get => (float)CellsByName["ActionButtonInputCancelTime"].Value;
            set => CellsByName["ActionButtonInputCancelTime"].Value = value;
        }


        // Def="f32 blockClearBonusDelayTime = 7"
        /// <summary>
        /// Boss Kill - Rune Acquisition Delay Time (f32)
        /// </summary>
        /// <remarks>
        /// Clear bonus acquisition delay time after boss defeat processing
        /// </remarks>
        public float BossKillRuneAcquisitionDelayTime
        {
            get => (float)CellsByName["BossKillRuneAcquisitionDelayTime"].Value;
            set => CellsByName["BossKillRuneAcquisitionDelayTime"].Value = value;
        }


        // Def="f32 bonfireCheckEnemyRange = -1"
        /// <summary>
        /// Bonfire Check Enemy Range (f32)
        /// </summary>
        /// <remarks>
        /// [Unused] (Refer to SEQ25048) Distance from PC to bonfire that determines invalidation of bonfire by enemy [m] (0 or less: PC distance is not checked. Checked at all distances)
        /// </remarks>
        public float BonfireCheckEnemyRange
        {
            get => (float)CellsByName["BonfireCheckEnemyRange"].Value;
            set => CellsByName["BonfireCheckEnemyRange"].Value = value;
        }


    }
}

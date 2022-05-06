
namespace StronglyTypedParams
{
    public class AiSoundParam : ParamRow
    {
        public AiSoundParam() : base()
        {
        }


        // Def="f32 radius"
        /// <summary>
        /// Radius (f32)
        /// </summary>
        /// <remarks>
        /// AI sound radius
        /// </remarks>
        public float Radius
        {
            get => (float)CellsByName["Radius"].Value;
            set => CellsByName["Radius"].Value = value;
        }


        // Def="f32 lifeFrame"
        /// <summary>
        /// Duration (f32)
        /// </summary>
        /// <remarks>
        /// Time for AI sound to remain
        /// </remarks>
        public float Duration
        {
            get => (float)CellsByName["Duration"].Value;
            set => CellsByName["Duration"].Value = value;
        }


        // Def="u8 bSpEffectEnable"
        /// <summary>
        /// Is Affected by Sound Radius Magnification (u8)
        /// </summary>
        /// <remarks>
        /// Whether it is affected by the special effect "Sound Radius Magnification"
        /// </remarks>
        public byte IsAffectedBySoundRadiusMagnification
        {
            get => (byte)CellsByName["IsAffectedBySoundRadiusMagnification"].Value;
            set => CellsByName["IsAffectedBySoundRadiusMagnification"].Value = value;
        }


        // Def="u8 type"
        /// <summary>
        /// Rate Type (u8)
        /// </summary>
        /// <remarks>
        /// AI sound type
        /// </remarks>
        public byte RateType
        {
            get => (byte)CellsByName["RateType"].Value;
            set => CellsByName["RateType"].Value = value;
        }


        // Def="u8 opposeTarget:1 = 1"
        /// <summary>
        /// Target: Hostile (u8)
        /// </summary>
        /// <remarks>
        /// Target: ● Hostile
        /// </remarks>
        public byte TargetHostile
        {
            get => (byte)CellsByName["TargetHostile"].Value;
            set => CellsByName["TargetHostile"].Value = value;
        }


        // Def="u8 friendlyTarget:1"
        /// <summary>
        /// Target: Friendly (u8)
        /// </summary>
        /// <remarks>
        /// Target: ○ Allies
        /// </remarks>
        public byte TargetFriendly
        {
            get => (byte)CellsByName["TargetFriendly"].Value;
            set => CellsByName["TargetFriendly"].Value = value;
        }


        // Def="u8 selfTarget:1"
        /// <summary>
        /// Target: Self (u8)
        /// </summary>
        /// <remarks>
        /// Target: myself
        /// </remarks>
        public byte TargetSelf
        {
            get => (byte)CellsByName["TargetSelf"].Value;
            set => CellsByName["TargetSelf"].Value = value;
        }


        // Def="u8 disableOnTargetPCompany:1"
        /// <summary>
        /// Disable on Targeting Player (u8)
        /// </summary>
        /// <remarks>
        /// You can't listen while targeting your PC
        /// </remarks>
        public byte DisableOnTargetingPlayer
        {
            get => (byte)CellsByName["DisableOnTargetingPlayer"].Value;
            set => CellsByName["DisableOnTargetingPlayer"].Value = value;
        }


        // Def="u8 rank"
        /// <summary>
        /// Rank (u8)
        /// </summary>
        /// <remarks>
        /// Character behavior (former: sound type)
        /// </remarks>
        public byte Rank
        {
            get => (byte)CellsByName["Rank"].Value;
            set => CellsByName["Rank"].Value = value;
        }


        // Def="f32 forgetTime = -1"
        /// <summary>
        /// Forget Time (f32)
        /// </summary>
        /// <remarks>
        /// Time to forget the sound target (overwrite) [sec]
        /// </remarks>
        public float ForgetTime
        {
            get => (float)CellsByName["ForgetTime"].Value;
            set => CellsByName["ForgetTime"].Value = value;
        }


        // Def="s32 priority = 100"
        /// <summary>
        /// Priority (s32)
        /// </summary>
        /// <remarks>
        /// AI sound priority
        /// </remarks>
        public int Priority
        {
            get => (int)CellsByName["Priority"].Value;
            set => CellsByName["Priority"].Value = value;
        }


        // Def="s32 soundBehaviorId = -1"
        /// <summary>
        /// Sound Behavior ID (s32)
        /// </summary>
        /// <remarks>
        /// Behavior ID
        /// </remarks>
        public int SoundBehaviorID
        {
            get => (int)CellsByName["SoundBehaviorID"].Value;
            set => CellsByName["SoundBehaviorID"].Value = value;
        }


        // Def="u8 aiSoundLevel"
        /// <summary>
        /// AI Sound Level (u8)
        /// </summary>
        /// <remarks>
        /// How hard it is to hear
        /// </remarks>
        public byte AISoundLevel
        {
            get => (byte)CellsByName["AISoundLevel"].Value;
            set => CellsByName["AISoundLevel"].Value = value;
        }


        // Def="u8 replaningState"
        /// <summary>
        /// Replanning State (u8)
        /// </summary>
        /// <remarks>
        /// AI state setting to run replanning when listening to AI sound
        /// </remarks>
        public byte ReplanningState
        {
            get => (byte)CellsByName["ReplanningState"].Value;
            set => CellsByName["ReplanningState"].Value = value;
        }


        // Def="dummy8 pad1[6]"
        /// <summary>
        /// pad (dummy8)
        /// </summary>
        /// <remarks>
        /// pad
        /// </remarks>
        public object Pad
        {
            get => (object)CellsByName["Pad"].Value;
            set => CellsByName["Pad"].Value = value;
        }

    }
}

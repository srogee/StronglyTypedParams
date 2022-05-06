
namespace StronglyTypedParams
{
    public class SoundCutsceneParam : ParamRow
    {
        public SoundCutsceneParam() : base()
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


        // Def="u8 ReverbType"
        /// <summary>
        /// Reverb Type (u8)
        /// </summary>
        /// <remarks>
        /// Specifies the reverb type to apply during the cutscene
        /// </remarks>
        public byte ReverbType
        {
            get => (byte)CellsByName["ReverbType"].Value;
            set => CellsByName["ReverbType"].Value = value;
        }


        // Def="dummy8 pad0[3]"
        /// <summary>
        /// pad0 (dummy8)
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        public object Pad0
        {
            get => (object)CellsByName["Pad0"].Value;
            set => CellsByName["Pad0"].Value = value;
        }


        // Def="s16 BgmBehaviorTypeOnStart"
        /// <summary>
        /// BGM Behavior Type On Start (s16)
        /// </summary>
        /// <remarks>
        /// Specifies normal BGM behavior at the start of cutscenes
        /// </remarks>
        public short BGMBehaviorTypeOnStart
        {
            get => (short)CellsByName["BGMBehaviorTypeOnStart"].Value;
            set => CellsByName["BGMBehaviorTypeOnStart"].Value = value;
        }


        // Def="s16 OneShotBgmBehaviorOnStart"
        /// <summary>
        /// One-shot BGM Behavior Type On Start (s16)
        /// </summary>
        /// <remarks>
        /// Specifies the one-shot BGM behavior at the start of the cutscene
        /// </remarks>
        public short OneShotBGMBehaviorTypeOnStart
        {
            get => (short)CellsByName["OneShotBGMBehaviorTypeOnStart"].Value;
            set => CellsByName["OneShotBGMBehaviorTypeOnStart"].Value = value;
        }


        // Def="s32 PostPlaySeId = -1"
        /// <summary>
        /// Post Play SE ID (s32)
        /// </summary>
        /// <remarks>
        /// SEID (category: p) specification to post at the end of the cutscene (-1: do not post)
        /// </remarks>
        public int PostPlaySEID
        {
            get => (int)CellsByName["PostPlaySEID"].Value;
            set => CellsByName["PostPlaySEID"].Value = value;
        }


        // Def="s32 PostPlaySeIdForSkip = -1"
        /// <summary>
        /// Post Play SE ID for Skip (s32)
        /// </summary>
        /// <remarks>
        /// SEID_ for skipping to post at the end of the cutscene (category: p) specified (-1: not posted)
        /// </remarks>
        public int PostPlaySEIDForSkip
        {
            get => (int)CellsByName["PostPlaySEIDForSkip"].Value;
            set => CellsByName["PostPlaySEIDForSkip"].Value = value;
        }


        // Def="f32 EnterMapMuteStopTimeOnDrawCutscene = -1"
        /// <summary>
        /// Enter Map Mute Stop Time on Draw Cutscene (f32)
        /// </summary>
        /// <remarks>
        /// Cutscene drawing time to unmute immediately after entering [seconds] (less than 0: not canceled in drawing time)
        /// </remarks>
        public float EnterMapMuteStopTimeOnDrawCutscene
        {
            get => (float)CellsByName["EnterMapMuteStopTimeOnDrawCutscene"].Value;
            set => CellsByName["EnterMapMuteStopTimeOnDrawCutscene"].Value = value;
        }


        // Def="dummy8 reserved[8]"
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

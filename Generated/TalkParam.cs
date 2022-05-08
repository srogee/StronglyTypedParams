
            namespace StronglyTypedParams
            {
                // TALK_PARAM_ST
                public class TalkParam : ParamRow
                {
                    public TalkParam() : base()
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
            

            // Def="s32 msgId = -1"
            /// <summary>
            /// Male - Message ID (s32)
            /// </summary>
            /// <remarks>
            /// PC Gender is Male: Specify Message-> Menu
            /// </remarks>
            public int MaleMessageID 
            {
                get => (int)CellsByName["MaleMessageID"].Value;
                set => CellsByName["MaleMessageID"].Value = (int)value;
            }
            

            // Def="s32 voiceId = -1"
            /// <summary>
            /// Male - Voice ID (s32)
            /// </summary>
            /// <remarks>
            /// PC Gender is Male: Specify Voice-> Sound
            /// </remarks>
            public int MaleVoiceID 
            {
                get => (int)CellsByName["MaleVoiceID"].Value;
                set => CellsByName["MaleVoiceID"].Value = (int)value;
            }
            

            // Def="s32 spEffectId0 = -1"
            /// <summary>
            /// SpEffect ID [0] (s32)
            /// </summary>
            /// <remarks>
            /// Specify special effects-> Character
            /// </remarks>
            public int SpEffectID0 
            {
                get => (int)CellsByName["SpEffectID0"].Value;
                set => CellsByName["SpEffectID0"].Value = (int)value;
            }
            

            // Def="s32 motionId0 = -1"
            /// <summary>
            /// Motion ID [0] (s32)
            /// </summary>
            /// <remarks>
            /// Specify motion-> Character
            /// </remarks>
            public int MotionID0 
            {
                get => (int)CellsByName["MotionID0"].Value;
                set => CellsByName["MotionID0"].Value = (int)value;
            }
            

            // Def="s32 spEffectId1 = -1"
            /// <summary>
            /// SpEffect ID [1] (s32)
            /// </summary>
            /// <remarks>
            /// Specify special effects-> Character
            /// </remarks>
            public int SpEffectID1 
            {
                get => (int)CellsByName["SpEffectID1"].Value;
                set => CellsByName["SpEffectID1"].Value = (int)value;
            }
            

            // Def="s32 motionId1 = -1"
            /// <summary>
            /// Motion ID [1] (s32)
            /// </summary>
            /// <remarks>
            /// Specify motion-> Character
            /// </remarks>
            public int MotionID1 
            {
                get => (int)CellsByName["MotionID1"].Value;
                set => CellsByName["MotionID1"].Value = (int)value;
            }
            

            // Def="s32 returnPos = -1"
            /// <summary>
            /// Return Position (s32)
            /// </summary>
            /// <remarks>
            /// Relative position of returning conversation-> Conversation
            /// </remarks>
            public int ReturnPosition 
            {
                get => (int)CellsByName["ReturnPosition"].Value;
                set => CellsByName["ReturnPosition"].Value = (int)value;
            }
            

            // Def="s32 reactionId = -1"
            /// <summary>
            /// Reaction ID (s32)
            /// </summary>
            /// <remarks>
            /// Conversation specification when returning-> Conversation
            /// </remarks>
            public int ReactionID 
            {
                get => (int)CellsByName["ReactionID"].Value;
                set => CellsByName["ReactionID"].Value = (int)value;
            }
            

            // Def="s32 eventId = -1"
            /// <summary>
            /// Event ID (s32)
            /// </summary>
            /// <remarks>
            /// Event ID-> Event
            /// </remarks>
            public int EventID 
            {
                get => (int)CellsByName["EventID"].Value;
                set => CellsByName["EventID"].Value = (int)value;
            }
            

            // Def="s32 msgId_female = -1"
            /// <summary>
            /// Female - Message ID (s32)
            /// </summary>
            /// <remarks>
            /// PC Gender is Female: Specify Message-> Menu
            /// </remarks>
            public int FemaleMessageID 
            {
                get => (int)CellsByName["FemaleMessageID"].Value;
                set => CellsByName["FemaleMessageID"].Value = (int)value;
            }
            

            // Def="s32 voiceId_female = -1"
            /// <summary>
            /// Female - Voice ID (s32)
            /// </summary>
            /// <remarks>
            /// PC Gender is Female: Specify Voice-> Sound
            /// </remarks>
            public int FemaleVoiceID 
            {
                get => (int)CellsByName["FemaleVoiceID"].Value;
                set => CellsByName["FemaleVoiceID"].Value = (int)value;
            }
            

            // Def="s16 lipSyncStart = -1"
            /// <summary>
            /// Lip Sync Start (s16)
            /// </summary>
            /// <remarks>
            /// Speaker: Lip-sync start time. -1 with no lip-sync
            /// </remarks>
            public short LipSyncStart 
            {
                get => (short)CellsByName["LipSyncStart"].Value;
                set => CellsByName["LipSyncStart"].Value = (short)value;
            }
            

            // Def="s16 lipSyncTime = -1"
            /// <summary>
            /// Lip Sync Time (s16)
            /// </summary>
            /// <remarks>
            /// Speaker: Lip-sync duration. Lip-sync at -1 continues forever
            /// </remarks>
            public short LipSyncTime 
            {
                get => (short)CellsByName["LipSyncTime"].Value;
                set => CellsByName["LipSyncTime"].Value = (short)value;
            }
            

            // Def="dummy8 pad2[4]"
            /// <summary>
            /// Padding (dummy8)
            /// </summary>
            /// <remarks>
            /// 
            /// </remarks>
            public object Padding 
            {
                get => (object)CellsByName["Padding"].Value;
                set => CellsByName["Padding"].Value = (object)value;
            }
            

            // Def="f32 timeout = -1"
            /// <summary>
            /// Voice Playback Timeout (f32)
            /// </summary>
            /// <remarks>
            /// Voice playback timeout period. In case of -1, time-out processing is performed in "NPC conversation voice playback timeout time" of "Common_Game system parameter".
            /// </remarks>
            public float VoicePlaybackTimeout 
            {
                get => (float)CellsByName["VoicePlaybackTimeout"].Value;
                set => CellsByName["VoicePlaybackTimeout"].Value = (float)value;
            }
            

            // Def="s32 talkAnimationId = -1"
            /// <summary>
            /// Talk Animation ID (s32)
            /// </summary>
            /// <remarks>
            /// Speaker: Animation ID during conversation
            /// </remarks>
            public int TalkAnimationID 
            {
                get => (int)CellsByName["TalkAnimationID"].Value;
                set => CellsByName["TalkAnimationID"].Value = (int)value;
            }
            

            // Def="u8 isForceDisp:1"
            /// <summary>
            /// Force Subtitle Display (u8)
            /// </summary>
            /// <remarks>
            /// Do you want to force the display of subtitles? Display subtitles even when subtitles are turned off as an option
            /// </remarks>
            public BoolCirclecrossType ForceSubtitleDisplay 
            {
                get => (BoolCirclecrossType)CellsByName["ForceSubtitleDisplay"].Value;
                set => CellsByName["ForceSubtitleDisplay"].Value = (byte)value;
            }
            


                }
            }
            
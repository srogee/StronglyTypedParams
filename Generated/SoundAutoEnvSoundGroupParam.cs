
            namespace StronglyTypedParams
            {
                public class SoundAutoEnvSoundGroupParam : ParamRow
                {
                    public SoundAutoEnvSoundGroupParam() : base()
                    {
                    }
            

            // Def="s32 SoundNo = -1"
            /// <summary>
            /// Sound Number (s32)
            /// </summary>
            /// <remarks>
            /// Sound No to play (sound type is fixed to a)
            /// </remarks>
            public int SoundNumber 
            {
                get => (int)CellsByName["SoundNumber"].Value;
                set => CellsByName["SoundNumber"].Value = value;
            }
            

            // Def="f32 ExpandRange = 100"
            /// <summary>
            /// Expand Range (f32)
            /// </summary>
            /// <remarks>
            /// Extended distance of playback judgment area
            /// </remarks>
            public float ExpandRange 
            {
                get => (float)CellsByName["ExpandRange"].Value;
                set => CellsByName["ExpandRange"].Value = value;
            }
            

            // Def="f32 FollowSpeed = 0.1"
            /// <summary>
            /// Follow Speed (f32)
            /// </summary>
            /// <remarks>
            /// Follow-up speed (fixed speed) to the target position of the actual sound source
            /// </remarks>
            public float FollowSpeed 
            {
                get => (float)CellsByName["FollowSpeed"].Value;
                set => CellsByName["FollowSpeed"].Value = value;
            }
            

            // Def="f32 FollowRate = 0.015"
            /// <summary>
            /// Follow Rate (f32)
            /// </summary>
            /// <remarks>
            /// Follow-up speed (difference ratio) to the target position of the actual sound source
            /// </remarks>
            public float FollowRate 
            {
                get => (float)CellsByName["FollowRate"].Value;
                set => CellsByName["FollowRate"].Value = value;
            }
            
                }
            }
            
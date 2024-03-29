
            namespace StronglyTypedParams
            {
                // SOUND_ASSET_SOUND_OBJ_ENABLE_DIST_PARAM_ST
                public class SoundAssetSoundObjEnableDistParam : ParamRow
                {
                    public SoundAssetSoundObjEnableDistParam() : base()
                    {
                    }
            

            // Def="f32 SoundObjEnableDist = -1"
            /// <summary>
            /// Sound Object - Enable Distance (f32)
            /// </summary>
            /// <remarks>
            /// Asset sound sound source effective distance [m] (less than 0: invalid)
            /// </remarks>
            public float SoundObjectEnableDistance 
            {
                get => (float)CellsByName["SoundObjectEnableDistance"].Value;
                set => CellsByName["SoundObjectEnableDistance"].Value = (float)value;
            }
            
                }
            }
            
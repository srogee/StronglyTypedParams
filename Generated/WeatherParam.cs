
            namespace StronglyTypedParams
            {
                public class WeatherParam : ParamRow
                {
                    public WeatherParam() : base()
                    {
                    }
            

            // Def="s32 SfxId = -1"
            /// <summary>
            /// Weather SFX ID (s32)
            /// </summary>
            /// <remarks>
            /// SfxId for weather -1: No weather Sfx Set for indoor and outdoor use. Items that can be erased with Above Shadow, such as raindrops of interactive particles, are OK here.
            /// </remarks>
            public int WeatherSFXID 
            {
                get => (int)CellsByName["WeatherSFXID"].Value;
                set => CellsByName["WeatherSFXID"].Value = value;
            }
            

            // Def="s32 WindSfxId = -1"
            /// <summary>
            /// Wind SFX ID (s32)
            /// </summary>
            /// <remarks>
            /// Wind SfxId -1: No wind Sfx Created only outdoors
            /// </remarks>
            public int WindSFXID 
            {
                get => (int)CellsByName["WindSFXID"].Value;
                set => CellsByName["WindSFXID"].Value = value;
            }
            

            // Def="s32 GroundHitSfxId = -1"
            /// <summary>
            /// Ground Hit SFX ID (s32)
            /// </summary>
            /// <remarks>
            /// SfxId for ground hit effect -1: None for ground hit effect
            /// </remarks>
            public int GroundHitSFXID 
            {
                get => (int)CellsByName["GroundHitSFXID"].Value;
                set => CellsByName["GroundHitSFXID"].Value = value;
            }
            

            // Def="s32 SoundId = -1"
            /// <summary>
            /// Sound ID (s32)
            /// </summary>
            /// <remarks>
            /// SoundId for weather -1: No Sound
            /// </remarks>
            public int SoundID 
            {
                get => (int)CellsByName["SoundID"].Value;
                set => CellsByName["SoundID"].Value = value;
            }
            

            // Def="f32 WetTime = -1"
            /// <summary>
            /// Wet Time (f32)
            /// </summary>
            /// <remarks>
            /// Time to get completely wet (time until the weight of m00_00_0000_WeatherBase reaches 1.0) -1: No wetness (m00_00_0000_WeatherBase remains 0.0)
            /// </remarks>
            public float WetTime 
            {
                get => (float)CellsByName["WetTime"].Value;
                set => CellsByName["WetTime"].Value = value;
            }
            

            // Def="u32 GparamId"
            /// <summary>
            /// GPARAM ID (u32)
            /// </summary>
            /// <remarks>
            /// Specify the XXX part of Gparam (m00_00_? XXX_WeatherOutdoor.gparamxml) for outdoor weather. Gparam to be used can be shared between weather.
            /// </remarks>
            public uint GPARAMID 
            {
                get => (uint)CellsByName["GPARAMID"].Value;
                set => CellsByName["GPARAMID"].Value = value;
            }
            

            // Def="u32 NextLotIngameSecondsMin = 3600"
            /// <summary>
            /// Next Weather Lot - Min Duration (u32)
            /// </summary>
            /// <remarks>
            /// Specify the minimum time to the next weather lottery in in-game seconds. When transitioning to this weather, the time to the next weather will be a random time between the minimum and maximum.
            /// </remarks>
            public uint NextWeatherLotMinDuration 
            {
                get => (uint)CellsByName["NextWeatherLotMinDuration"].Value;
                set => CellsByName["NextWeatherLotMinDuration"].Value = value;
            }
            

            // Def="u32 NextLotIngameSecondsMax = 7200"
            /// <summary>
            /// Next Weather Lot - Max Duration (u32)
            /// </summary>
            /// <remarks>
            /// Specify the maximum time until the next weather lottery in in-game seconds. When transitioning to this weather, the time to the next weather will be a random time between the minimum and maximum.
            /// </remarks>
            public uint NextWeatherLotMaxDuration 
            {
                get => (uint)CellsByName["NextWeatherLotMaxDuration"].Value;
                set => CellsByName["NextWeatherLotMaxDuration"].Value = value;
            }
            

            // Def="s32 WetSpEffectId00 = -1"
            /// <summary>
            /// Wet SpEffect [0] (s32)
            /// </summary>
            /// <remarks>
            /// Special effect ID on the character (-1: None)
            /// </remarks>
            public int WetSpEffect0 
            {
                get => (int)CellsByName["WetSpEffect0"].Value;
                set => CellsByName["WetSpEffect0"].Value = value;
            }
            

            // Def="s32 WetSpEffectId01 = -1"
            /// <summary>
            /// Wet SpEffect [1] (s32)
            /// </summary>
            /// <remarks>
            /// Special effect ID on the character (-1: None)
            /// </remarks>
            public int WetSpEffect1 
            {
                get => (int)CellsByName["WetSpEffect1"].Value;
                set => CellsByName["WetSpEffect1"].Value = value;
            }
            

            // Def="s32 WetSpEffectId02 = -1"
            /// <summary>
            /// Wet SpEffect [2] (s32)
            /// </summary>
            /// <remarks>
            /// Special effect ID on the character (-1: None)
            /// </remarks>
            public int WetSpEffect2 
            {
                get => (int)CellsByName["WetSpEffect2"].Value;
                set => CellsByName["WetSpEffect2"].Value = value;
            }
            

            // Def="s32 WetSpEffectId03 = -1"
            /// <summary>
            /// Wet SpEffect [3] (s32)
            /// </summary>
            /// <remarks>
            /// Special effect ID on the character (-1: None)
            /// </remarks>
            public int WetSpEffect3 
            {
                get => (int)CellsByName["WetSpEffect3"].Value;
                set => CellsByName["WetSpEffect3"].Value = value;
            }
            

            // Def="s32 WetSpEffectId04 = -1"
            /// <summary>
            /// Wet SpEffect [4] (s32)
            /// </summary>
            /// <remarks>
            /// Special effect ID on the character (-1: None)
            /// </remarks>
            public int WetSpEffect4 
            {
                get => (int)CellsByName["WetSpEffect4"].Value;
                set => CellsByName["WetSpEffect4"].Value = value;
            }
            

            // Def="s32 SfxIdInoor = -1"
            /// <summary>
            /// Weather SFX - Indoors Only - SFX ID (s32)
            /// </summary>
            /// <remarks>
            /// Weather SfxId -1: No weather Sfx indoors only
            /// </remarks>
            public int WeatherSFXIndoorsOnlySFXID 
            {
                get => (int)CellsByName["WeatherSFXIndoorsOnlySFXID"].Value;
                set => CellsByName["WeatherSFXIndoorsOnlySFXID"].Value = value;
            }
            

            // Def="s32 SfxIdOutdoor = -1"
            /// <summary>
            /// Weather SFX - Outdoors Only - SFX ID (s32)
            /// </summary>
            /// <remarks>
            /// Weather SfxId -1: No weather Sfx, outdoor only
            /// </remarks>
            public int WeatherSFXOutdoorsOnlySFXID 
            {
                get => (int)CellsByName["WeatherSFXOutdoorsOnlySFXID"].Value;
                set => CellsByName["WeatherSFXOutdoorsOnlySFXID"].Value = value;
            }
            

            // Def="f32 aiSightRate = 1"
            /// <summary>
            /// AI Sight Rate (f32)
            /// </summary>
            /// <remarks>
            /// AI field of view magnification
            /// </remarks>
            public float AISightRate 
            {
                get => (float)CellsByName["AISightRate"].Value;
                set => CellsByName["AISightRate"].Value = value;
            }
            

            // Def="f32 DistViewWeatherGparamOverrideWeight = -1"
            /// <summary>
            /// Overwrite Weight Valuue in Distant View Camera (f32)
            /// </summary>
            /// <remarks>
            /// Overwrite weight value in distant view camera (SEQ16724)
            /// </remarks>
            public float OverwriteWeightValuueInDistantViewCamera 
            {
                get => (float)CellsByName["OverwriteWeightValuueInDistantViewCamera"].Value;
                set => CellsByName["OverwriteWeightValuueInDistantViewCamera"].Value = value;
            }
            
                }
            }
            
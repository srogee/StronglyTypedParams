
            namespace StronglyTypedParams
            {
                // AUTO_CREATE_ENV_SOUND_PARAM_ST
                public class AutoCreateEnvSoundParam : ParamRow
                {
                    public AutoCreateEnvSoundParam() : base()
                    {
                    }
            

            // Def="f32 RangeMin = 10"
            /// <summary>
            /// Appearance Distance - Min (f32)
            /// </summary>
            /// <remarks>
            /// Appearance distance Min [m]
            /// </remarks>
            public float AppearanceDistanceMin 
            {
                get => (float)CellsByName["AppearanceDistanceMin"].Value;
                set => CellsByName["AppearanceDistanceMin"].Value = (float)value;
            }
            

            // Def="f32 RangeMax = 25"
            /// <summary>
            /// Appearance Distance - Max (f32)
            /// </summary>
            /// <remarks>
            /// Appearance distance Max [
            /// </remarks>
            public float AppearanceDistanceMax 
            {
                get => (float)CellsByName["AppearanceDistanceMax"].Value;
                set => CellsByName["AppearanceDistanceMax"].Value = (float)value;
            }
            

            // Def="f32 LifeTimeMin = 30"
            /// <summary>
            /// Duration - Min (f32)
            /// </summary>
            /// <remarks>
            /// Lifespan Min [seconds]
            /// </remarks>
            public float DurationMin 
            {
                get => (float)CellsByName["DurationMin"].Value;
                set => CellsByName["DurationMin"].Value = (float)value;
            }
            

            // Def="f32 LifeTimeMax = 30"
            /// <summary>
            /// Duration - Max (f32)
            /// </summary>
            /// <remarks>
            /// Lifespan Max [seconds]
            /// </remarks>
            public float DurationMax 
            {
                get => (float)CellsByName["DurationMax"].Value;
                set => CellsByName["DurationMax"].Value = (float)value;
            }
            

            // Def="f32 DeleteDist = 30"
            /// <summary>
            /// Delete Distance (f32)
            /// </summary>
            /// <remarks>
            /// Delete distance [m]
            /// </remarks>
            public float DeleteDistance 
            {
                get => (float)CellsByName["DeleteDistance"].Value;
                set => CellsByName["DeleteDistance"].Value = (float)value;
            }
            

            // Def="f32 NearDist = 15"
            /// <summary>
            /// Near Distance (f32)
            /// </summary>
            /// <remarks>
            /// Neighborhood judgment distance [m]
            /// </remarks>
            public float NearDistance 
            {
                get => (float)CellsByName["NearDistance"].Value;
                set => CellsByName["NearDistance"].Value = (float)value;
            }
            

            // Def="f32 LimiteRotateMin"
            /// <summary>
            /// Generation Angle Limit - Min (f32)
            /// </summary>
            /// <remarks>
            /// Angle limit Min [degree] (Specify the Y-axis angle +-in front of the camera. 180 is omnidirectional)
            /// </remarks>
            public float GenerationAngleLimitMin 
            {
                get => (float)CellsByName["GenerationAngleLimitMin"].Value;
                set => CellsByName["GenerationAngleLimitMin"].Value = (float)value;
            }
            

            // Def="f32 LimiteRotateMax = 180"
            /// <summary>
            /// Generation Angle Limit - Max (f32)
            /// </summary>
            /// <remarks>
            /// Angle limit Max [degree] (Specify the Y-axis angle +-in front of the camera. 180 is omnidirectional)
            /// </remarks>
            public float GenerationAngleLimitMax 
            {
                get => (float)CellsByName["GenerationAngleLimitMax"].Value;
                set => CellsByName["GenerationAngleLimitMax"].Value = (float)value;
            }
            
                }
            }
            

            namespace StronglyTypedParams
            {
                public class WeatherAssetCreateParam : ParamRow
                {
                    public WeatherAssetCreateParam() : base()
                    {
                    }
            

            // Def="u32 AssetId"
            /// <summary>
            /// Asset ID (u32)
            /// </summary>
            /// <remarks>
            /// Specify the asset ID to generate. AEG999_999-> 999999
            /// </remarks>
            public uint AssetID 
            {
                get => (uint)CellsByName["AssetID"].Value;
                set => CellsByName["AssetID"].Value = value;
            }
            

            // Def="u32 SlotNo"
            /// <summary>
            /// Slot Number (u32)
            /// </summary>
            /// <remarks>
            /// This is the number for generation control. Only one asset can be generated in the same slot. You can control whether you want to generate duplicates or not.
            /// </remarks>
            public uint SlotNumber 
            {
                get => (uint)CellsByName["SlotNumber"].Value;
                set => CellsByName["SlotNumber"].Value = value;
            }
            

            // Def="u8 CreateConditionType"
            /// <summary>
            /// Create Condition Type (u8)
            /// </summary>
            /// <remarks>
            /// The type of condition of occurrence
            /// </remarks>
            public byte CreateConditionType 
            {
                get => (byte)CellsByName["CreateConditionType"].Value;
                set => CellsByName["CreateConditionType"].Value = value;
            }
            

            // Def="dummy8 padding0[3]"
            /// <summary>
            /// padding0 (dummy8)
            /// </summary>
            /// <remarks>
            /// 
            /// </remarks>
            public object Padding0 
            {
                get => (object)CellsByName["Padding0"].Value;
                set => CellsByName["Padding0"].Value = value;
            }
            

            // Def="s16 TransitionSrcWeather"
            /// <summary>
            /// Transition Source Weather (s16)
            /// </summary>
            /// <remarks>
            /// Specify the transition source weather. It is referenced only when the occurrence condition is "transition".
            /// </remarks>
            public short TransitionSourceWeather 
            {
                get => (short)CellsByName["TransitionSourceWeather"].Value;
                set => CellsByName["TransitionSourceWeather"].Value = value;
            }
            

            // Def="s16 TransitionDstWeather"
            /// <summary>
            /// Transition Destination Weather (s16)
            /// </summary>
            /// <remarks>
            /// Specify the transition destination weather. It is referenced only when the occurrence condition is "transition".
            /// </remarks>
            public short TransitionDestinationWeather 
            {
                get => (short)CellsByName["TransitionDestinationWeather"].Value;
                set => CellsByName["TransitionDestinationWeather"].Value = value;
            }
            

            // Def="s16 ElapsedTimeCheckweather"
            /// <summary>
            /// Check Weather Elapsed Time (s16)
            /// </summary>
            /// <remarks>
            /// Specify the weather to check the elapsed time.
            /// </remarks>
            public short CheckWeatherElapsedTime 
            {
                get => (short)CellsByName["CheckWeatherElapsedTime"].Value;
                set => CellsByName["CheckWeatherElapsedTime"].Value = value;
            }
            

            // Def="dummy8 padding1[2]"
            /// <summary>
            /// padding1 (dummy8)
            /// </summary>
            /// <remarks>
            /// 
            /// </remarks>
            public object Padding1 
            {
                get => (object)CellsByName["Padding1"].Value;
                set => CellsByName["Padding1"].Value = value;
            }
            

            // Def="f32 ElapsedTime"
            /// <summary>
            /// Elapsed Time (f32)
            /// </summary>
            /// <remarks>
            /// Specify the elapsed time. It is referenced only when the occurrence condition is "time elapsed". Real time Specify in seconds.
            /// </remarks>
            public float ElapsedTime 
            {
                get => (float)CellsByName["ElapsedTime"].Value;
                set => CellsByName["ElapsedTime"].Value = value;
            }
            

            // Def="f32 CreateDelayTime = -1"
            /// <summary>
            /// Create Delay Time (f32)
            /// </summary>
            /// <remarks>
            /// Specifies the time to delay after the generation is determined. The created slot will be in use while it is delayed. Created immediately with 0 or less.
            /// </remarks>
            public float CreateDelayTime 
            {
                get => (float)CellsByName["CreateDelayTime"].Value;
                set => CellsByName["CreateDelayTime"].Value = value;
            }
            

            // Def="u32 CreateProbability = 100"
            /// <summary>
            /// Create Probability (u32)
            /// </summary>
            /// <remarks>
            /// Specifies the probability of occurrence when conditions for weather transitions or elapsed time are met.
            /// </remarks>
            public uint CreateProbability 
            {
                get => (uint)CellsByName["CreateProbability"].Value;
                set => CellsByName["CreateProbability"].Value = value;
            }
            

            // Def="f32 LifeTime = 600"
            /// <summary>
            /// Duration (f32)
            /// </summary>
            /// <remarks>
            /// Specifies the life of the generated asset. Real time Specify in seconds.
            /// </remarks>
            public float Duration 
            {
                get => (float)CellsByName["Duration"].Value;
                set => CellsByName["Duration"].Value = value;
            }
            

            // Def="f32 FadeTime = 1"
            /// <summary>
            /// Fade Time (f32)
            /// </summary>
            /// <remarks>
            /// Time [seconds] used for fade-in and fade-out. No fade below 0.
            /// </remarks>
            public float FadeTime 
            {
                get => (float)CellsByName["FadeTime"].Value;
                set => CellsByName["FadeTime"].Value = value;
            }
            

            // Def="f32 EnableCreateTimeMin = -1"
            /// <summary>
            /// Enable Create Time Min (f32)
            /// </summary>
            /// <remarks>
            /// Specifies a start time that can be generated [0.0 --24.0]. If you put -1 in either the start or the end, it will be treated as unlimited (can be generated in all time).
            /// </remarks>
            public float EnableCreateTimeMin 
            {
                get => (float)CellsByName["EnableCreateTimeMin"].Value;
                set => CellsByName["EnableCreateTimeMin"].Value = value;
            }
            

            // Def="f32 EnableCreateTimeMax = -1"
            /// <summary>
            /// Enable Create Time Max (f32)
            /// </summary>
            /// <remarks>
            /// Specifies the end time that can be generated [0.0 --24.0]. If you put -1 in either the start or the end, it will be treated as unlimited (can be generated in all time).
            /// </remarks>
            public float EnableCreateTimeMax 
            {
                get => (float)CellsByName["EnableCreateTimeMax"].Value;
                set => CellsByName["EnableCreateTimeMax"].Value = value;
            }
            

            // Def="s16 CreatePoint0 = -1"
            /// <summary>
            /// Create Point [0] (s16)
            /// </summary>
            /// <remarks>
            /// Specify the generation point number. Specify the last 3 digits of the "Weather Asset Generation Point" in MapStudio. -1 will be invalid
            /// </remarks>
            public short CreatePoint0 
            {
                get => (short)CellsByName["CreatePoint0"].Value;
                set => CellsByName["CreatePoint0"].Value = value;
            }
            

            // Def="s16 CreatePoint1 = -1"
            /// <summary>
            /// Create Point [1] (s16)
            /// </summary>
            /// <remarks>
            /// Specify the generation point number. Specify the last 3 digits of the "Weather Asset Generation Point" in MapStudio. -1 will be invalid
            /// </remarks>
            public short CreatePoint1 
            {
                get => (short)CellsByName["CreatePoint1"].Value;
                set => CellsByName["CreatePoint1"].Value = value;
            }
            

            // Def="s16 CreatePoint2 = -1"
            /// <summary>
            /// Create Point [2] (s16)
            /// </summary>
            /// <remarks>
            /// Specify the generation point number. Specify the last 3 digits of the "Weather Asset Generation Point" in MapStudio. -1 will be invalid
            /// </remarks>
            public short CreatePoint2 
            {
                get => (short)CellsByName["CreatePoint2"].Value;
                set => CellsByName["CreatePoint2"].Value = value;
            }
            

            // Def="s16 CreatePoint3 = -1"
            /// <summary>
            /// Create Point [3] (s16)
            /// </summary>
            /// <remarks>
            /// Specify the generation point number. Specify the last 3 digits of the "Weather Asset Generation Point" in MapStudio. -1 will be invalid
            /// </remarks>
            public short CreatePoint3 
            {
                get => (short)CellsByName["CreatePoint3"].Value;
                set => CellsByName["CreatePoint3"].Value = value;
            }
            

            // Def="s8 CreateAssetLimitId0 = -1"
            /// <summary>
            /// Create Asset Limit ID [0] (s8)
            /// </summary>
            /// <remarks>
            /// ID for production restriction. -1: Unlimited. Generation is allowed only if it matches the generation limit ID in "Map default parameter .xlsm" (SEQ08921).
            /// </remarks>
            public sbyte CreateAssetLimitID0 
            {
                get => (sbyte)CellsByName["CreateAssetLimitID0"].Value;
                set => CellsByName["CreateAssetLimitID0"].Value = value;
            }
            

            // Def="s8 CreateAssetLimitId1 = -1"
            /// <summary>
            /// Create Asset Limit ID [1] (s8)
            /// </summary>
            /// <remarks>
            /// ID for production restriction. -1: Unlimited. Generation is allowed only if it matches the generation limit ID in "Map default parameter .xlsm" (SEQ08921).
            /// </remarks>
            public sbyte CreateAssetLimitID1 
            {
                get => (sbyte)CellsByName["CreateAssetLimitID1"].Value;
                set => CellsByName["CreateAssetLimitID1"].Value = value;
            }
            

            // Def="s8 CreateAssetLimitId2 = -1"
            /// <summary>
            /// Create Asset Limit ID [2] (s8)
            /// </summary>
            /// <remarks>
            /// ID for production restriction. -1: Unlimited. Generation is allowed only if it matches the generation limit ID in "Map default parameter .xlsm" (SEQ08921).
            /// </remarks>
            public sbyte CreateAssetLimitID2 
            {
                get => (sbyte)CellsByName["CreateAssetLimitID2"].Value;
                set => CellsByName["CreateAssetLimitID2"].Value = value;
            }
            

            // Def="s8 CreateAssetLimitId3 = -1"
            /// <summary>
            /// Create Asset Limit ID [3] (s8)
            /// </summary>
            /// <remarks>
            /// ID for production restriction. -1: Unlimited. Generation is allowed only if it matches the generation limit ID in "Map default parameter .xlsm" (SEQ08921).
            /// </remarks>
            public sbyte CreateAssetLimitID3 
            {
                get => (sbyte)CellsByName["CreateAssetLimitID3"].Value;
                set => CellsByName["CreateAssetLimitID3"].Value = value;
            }
            

            // Def="dummy8 Reserved2[4]"
            /// <summary>
            /// Reserved2 (dummy8)
            /// </summary>
            /// <remarks>
            /// 
            /// </remarks>
            public object Reserved2 
            {
                get => (object)CellsByName["Reserved2"].Value;
                set => CellsByName["Reserved2"].Value = value;
            }
            
                }
            }
            
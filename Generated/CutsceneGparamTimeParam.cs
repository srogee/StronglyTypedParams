
            namespace StronglyTypedParams
            {
                // CUTSCENE_GPARAM_TIME_PARAM_ST
                public class CutsceneGparamTimeParam : ParamRow
                {
                    public CutsceneGparamTimeParam() : base()
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
            

            // Def="u8 disableParam_Debug:1"
            /// <summary>
            /// Disable Param - Debug (u8)
            /// </summary>
            /// <remarks>
            /// Parameters marked with a circle are excluded from all packages (because they are for debugging).
            /// </remarks>
            public BoolCirclecrossType DisableParamDebug 
            {
                get => (BoolCirclecrossType)CellsByName["DisableParamDebug"].Value;
                set => CellsByName["DisableParamDebug"].Value = (byte)value;
            }
            

            // Def="dummy8 disableParamReserve1:6"
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
            

            // Def="u8 DstTimezone_Morning"
            /// <summary>
            /// Destination Timezone: Morning (u8)
            /// </summary>
            /// <remarks>
            /// Morning (Refer to the cutscene time conversion setting sheet for the conversion time)
            /// </remarks>
            public CutsceneTimezoneType DestinationTimezoneMorning 
            {
                get => (CutsceneTimezoneType)CellsByName["DestinationTimezoneMorning"].Value;
                set => CellsByName["DestinationTimezoneMorning"].Value = (byte)value;
            }
            

            // Def="u8 DstTimezone_Noon"
            /// <summary>
            /// Destination Timezone: Noon (u8)
            /// </summary>
            /// <remarks>
            /// Day A (Refer to the cutscene time conversion setting sheet for the conversion time)
            /// </remarks>
            public CutsceneTimezoneType DestinationTimezoneNoon 
            {
                get => (CutsceneTimezoneType)CellsByName["DestinationTimezoneNoon"].Value;
                set => CellsByName["DestinationTimezoneNoon"].Value = (byte)value;
            }
            

            // Def="u8 DstTimezone_AfterNoon"
            /// <summary>
            /// Destination Timezone: Afternoon (u8)
            /// </summary>
            /// <remarks>
            /// Noon-B (Refer to the cutscene time conversion setting sheet for the conversion time)
            /// </remarks>
            public CutsceneTimezoneType DestinationTimezoneAfternoon 
            {
                get => (CutsceneTimezoneType)CellsByName["DestinationTimezoneAfternoon"].Value;
                set => CellsByName["DestinationTimezoneAfternoon"].Value = (byte)value;
            }
            

            // Def="u8 DstTimezone_Evening"
            /// <summary>
            /// Destination Timezone: Evening (u8)
            /// </summary>
            /// <remarks>
            /// Evening (Refer to the cutscene time conversion setting sheet for the conversion time)
            /// </remarks>
            public CutsceneTimezoneType DestinationTimezoneEvening 
            {
                get => (CutsceneTimezoneType)CellsByName["DestinationTimezoneEvening"].Value;
                set => CellsByName["DestinationTimezoneEvening"].Value = (byte)value;
            }
            

            // Def="u8 DstTimezone_Night"
            /// <summary>
            /// Destination Timezone: Night (u8)
            /// </summary>
            /// <remarks>
            /// Night (Refer to the cutscene time conversion setting sheet for the conversion time)
            /// </remarks>
            public CutsceneTimezoneType DestinationTimezoneNight 
            {
                get => (CutsceneTimezoneType)CellsByName["DestinationTimezoneNight"].Value;
                set => CellsByName["DestinationTimezoneNight"].Value = (byte)value;
            }
            

            // Def="u8 DstTimezone_DeepNightA"
            /// <summary>
            /// Destination Timezone: Deep Night A (u8)
            /// </summary>
            /// <remarks>
            /// Midnight A (Refer to the cutscene time conversion setting sheet for the conversion time)
            /// </remarks>
            public CutsceneTimezoneType DestinationTimezoneDeepNightA 
            {
                get => (CutsceneTimezoneType)CellsByName["DestinationTimezoneDeepNightA"].Value;
                set => CellsByName["DestinationTimezoneDeepNightA"].Value = (byte)value;
            }
            

            // Def="u8 DstTimezone_DeepNightB"
            /// <summary>
            /// Destination Timezone: Deep Night B (u8)
            /// </summary>
            /// <remarks>
            /// Midnight B (Refer to the cutscene time conversion setting sheet for the conversion time)
            /// </remarks>
            public CutsceneTimezoneType DestinationTimezoneDeepNightB 
            {
                get => (CutsceneTimezoneType)CellsByName["DestinationTimezoneDeepNightB"].Value;
                set => CellsByName["DestinationTimezoneDeepNightB"].Value = (byte)value;
            }
            

            // Def="dummy8 reserved[1]"
            /// <summary>
            /// reserved (dummy8)
            /// </summary>
            /// <remarks>
            /// reserved
            /// </remarks>
            public object Reserved 
            {
                get => (object)CellsByName["Reserved"].Value;
                set => CellsByName["Reserved"].Value = (object)value;
            }
            

            // Def="f32 PostPlayIngameTime = -1"
            /// <summary>
            /// Post Cutscene In-game Time (f32)
            /// </summary>
            /// <remarks>
            /// Specify in-game time at the end of playback [hour] [-1.0 to 24.0] (-1 (less than 0): do nothing)
            /// </remarks>
            public float PostCutsceneInGameTime 
            {
                get => (float)CellsByName["PostCutsceneInGameTime"].Value;
                set => CellsByName["PostCutsceneInGameTime"].Value = (float)value;
            }
            
                }
            }
            

            namespace StronglyTypedParams
            {
                public class TutorialParam : ParamRow
                {
                    public TutorialParam() : base()
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
            

            // Def="u8 menuType"
            /// <summary>
            /// Menu Type (u8)
            /// </summary>
            /// <remarks>
            /// Specifies the type of tutorial menu to display
            /// </remarks>
            public byte MenuType 
            {
                get => (byte)CellsByName["MenuType"].Value;
                set => CellsByName["MenuType"].Value = value;
            }
            

            // Def="u8 triggerType"
            /// <summary>
            /// Trigger Type (u8)
            /// </summary>
            /// <remarks>
            /// Display timing (default: 0: "-"). You will see this tutorial when you open this menu. Specify 0: "-" if you do not want to display it when you open the menu.
            /// </remarks>
            public byte TriggerType 
            {
                get => (byte)CellsByName["TriggerType"].Value;
                set => CellsByName["TriggerType"].Value = value;
            }
            

            // Def="u8 repeatType"
            /// <summary>
            /// Repeat Type (u8)
            /// </summary>
            /// <remarks>
            /// Number of times to display (default: 0: once in the game)
            /// </remarks>
            public byte RepeatType 
            {
                get => (byte)CellsByName["RepeatType"].Value;
                set => CellsByName["RepeatType"].Value = value;
            }
            

            // Def="dummy8 pad1[1]"
            /// <summary>
            /// Padding (dummy8)
            /// </summary>
            /// <remarks>
            /// 
            /// </remarks>
            public object Padding 
            {
                get => (object)CellsByName["Padding"].Value;
                set => CellsByName["Padding"].Value = value;
            }
            

            // Def="u16 imageId"
            /// <summary>
            /// Image ID (u16)
            /// </summary>
            /// <remarks>
            /// Specifies the tutorial image ID to display (default: 0). Specify 0 if you do not want to display the image
            /// </remarks>
            public ushort ImageID 
            {
                get => (ushort)CellsByName["ImageID"].Value;
                set => CellsByName["ImageID"].Value = value;
            }
            


            // Def="u32 unlockEventFlagId"
            /// <summary>
            /// Unlock Event Flag ID (u32)
            /// </summary>
            /// <remarks>
            /// Event flag ID for display permission (default: 0). It will not be displayed until this flag is set. Specify 0 if you always want to allow
            /// </remarks>
            public uint UnlockEventFlagID 
            {
                get => (uint)CellsByName["UnlockEventFlagID"].Value;
                set => CellsByName["UnlockEventFlagID"].Value = value;
            }
            

            // Def="s32 textId = -1"
            /// <summary>
            /// Text ID (s32)
            /// </summary>
            /// <remarks>
            /// ID of the text to be displayed in the tutorial [TutorialText.xlsm]. This text ID is used for both "Title" and "Body"
            /// </remarks>
            public int TextID 
            {
                get => (int)CellsByName["TextID"].Value;
                set => CellsByName["TextID"].Value = value;
            }
            

            // Def="f32 displayMinTime = 1"
            /// <summary>
            /// Display Minimum Time (f32)
            /// </summary>
            /// <remarks>
            /// Shortest display guaranteed time [seconds]. Even if it is closed due to an event etc., it will be closed after displaying at least this time. It's only for toast, so it's ignored in modals
            /// </remarks>
            public float DisplayMinimumTime 
            {
                get => (float)CellsByName["DisplayMinimumTime"].Value;
                set => CellsByName["DisplayMinimumTime"].Value = value;
            }
            

            // Def="f32 displayTime = 3"
            /// <summary>
            /// Display Time (f32)
            /// </summary>
            /// <remarks>
            /// Display time [seconds]. It will close automatically after this time has passed since the toast was displayed. It's only for toast, so it's ignored in modals
            /// </remarks>
            public float DisplayTime 
            {
                get => (float)CellsByName["DisplayTime"].Value;
                set => CellsByName["DisplayTime"].Value = value;
            }
            

                }
            }
            
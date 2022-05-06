
            namespace StronglyTypedParams
            {
                public class BaseChrSelectMenuParam : ParamRow
                {
                    public BaseChrSelectMenuParam() : base()
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
            

            // Def="u32 chrInitParam"
            /// <summary>
            /// Chr Init Param ID - Class (u32)
            /// </summary>
            /// <remarks>
            /// Specify the initial parameter ID for each architype for which face para is set.
            /// </remarks>
            public uint ChrInitParamIDClass 
            {
                get => (uint)CellsByName["ChrInitParamIDClass"].Value;
                set => CellsByName["ChrInitParamIDClass"].Value = value;
            }
            

            // Def="u32 originChrInitParam"
            /// <summary>
            /// Chr Init Param ID - Origin (u32)
            /// </summary>
            /// <remarks>
            /// Specify the initial parameter ID for each feature archetype
            /// </remarks>
            public uint ChrInitParamIDOrigin 
            {
                get => (uint)CellsByName["ChrInitParamIDOrigin"].Value;
                set => CellsByName["ChrInitParamIDOrigin"].Value = value;
            }
            

            // Def="s32 imageId"
            /// <summary>
            /// Image ID (s32)
            /// </summary>
            /// <remarks>
            /// Images lined up on the base character selection screen. Specify the number of frames of resources embedded in Fla
            /// </remarks>
            public int ImageID 
            {
                get => (int)CellsByName["ImageID"].Value;
                set => CellsByName["ImageID"].Value = value;
            }
            

            // Def="s32 textId"
            /// <summary>
            /// Text ID (s32)
            /// </summary>
            /// <remarks>
            /// Occupation name menu text ID
            /// </remarks>
            public int TextID 
            {
                get => (int)CellsByName["TextID"].Value;
                set => CellsByName["TextID"].Value = value;
            }
            

            // Def="dummy8 reserve[12]"
            /// <summary>
            /// Reserve (dummy8)
            /// </summary>
            /// <remarks>
            /// 
            /// </remarks>
            public object Reserve 
            {
                get => (object)CellsByName["Reserve"].Value;
                set => CellsByName["Reserve"].Value = value;
            }
            
                }
            }
            

            namespace StronglyTypedParams
            {
                // CHR_MODEL_PARAM_ST
                public class ChrModelParam : ParamRow
                {
                    public ChrModelParam() : base()
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
            

            // Def="u8 modelMemoryType"
            /// <summary>
            /// Model Memory Type (u8)
            /// </summary>
            /// <remarks>
            /// Model used memory type
            /// </remarks>
            public ChrMemoryType ModelMemoryType 
            {
                get => (ChrMemoryType)CellsByName["ModelMemoryType"].Value;
                set => CellsByName["ModelMemoryType"].Value = (byte)value;
            }
            

            // Def="u8 texMemoryType"
            /// <summary>
            /// Texture Memory Type (u8)
            /// </summary>
            /// <remarks>
            /// Texture usage memory type
            /// </remarks>
            public ChrMemoryType TextureMemoryType 
            {
                get => (ChrMemoryType)CellsByName["TextureMemoryType"].Value;
                set => CellsByName["TextureMemoryType"].Value = (byte)value;
            }
            

            // Def="s16 cameraDitherFadeId"
            /// <summary>
            /// Camera Dither Fade ID (s16)
            /// </summary>
            /// <remarks>
            /// Camera fade parameter ID (-1: refer to material, 0: do not disappear, 1 ~: parameter ID)
            /// </remarks>
            public short CameraDitherFadeID 
            {
                get => (short)CellsByName["CameraDitherFadeID"].Value;
                set => CellsByName["CameraDitherFadeID"].Value = (short)value;
            }
            

            // Def="f32 reportAnimMemSizeMb = 12"
            /// <summary>
            /// Send Report - Animation Memory Size MB (f32)
            /// </summary>
            /// <remarks>
            /// If this value is exceeded, a report will be sent by the reporting system.
            /// </remarks>
            public float SendReportAnimationMemorySizeMB 
            {
                get => (float)CellsByName["SendReportAnimationMemorySizeMB"].Value;
                set => CellsByName["SendReportAnimationMemorySizeMB"].Value = (float)value;
            }
            
                }
            }
            

            namespace StronglyTypedParams
            {
                // CUTSCENE_TEXTURE_LOAD_PARAM_ST
                public class CutSceneTextureLoadParam : ParamRow
                {
                    public CutSceneTextureLoadParam() : base()
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
            

            // Def="fixstr texName_00[16]"
            /// <summary>
            /// Texture DisplayName [00] (fixstr)
            /// </summary>
            /// <remarks>
            /// Texture DisplayName [00]
            /// </remarks>
            public object TextureDisplayName00 
            {
                get => (object)CellsByName["TextureDisplayName00"].Value;
                set => CellsByName["TextureDisplayName00"].Value = (object)value;
            }
            

            // Def="fixstr texName_01[16]"
            /// <summary>
            /// Texture DisplayName [01] (fixstr)
            /// </summary>
            /// <remarks>
            /// Texture DisplayName [01]
            /// </remarks>
            public object TextureDisplayName01 
            {
                get => (object)CellsByName["TextureDisplayName01"].Value;
                set => CellsByName["TextureDisplayName01"].Value = (object)value;
            }
            

            // Def="fixstr texName_02[16]"
            /// <summary>
            /// Texture DisplayName [02] (fixstr)
            /// </summary>
            /// <remarks>
            /// Texture DisplayName [02]
            /// </remarks>
            public object TextureDisplayName02 
            {
                get => (object)CellsByName["TextureDisplayName02"].Value;
                set => CellsByName["TextureDisplayName02"].Value = (object)value;
            }
            

            // Def="fixstr texName_03[16]"
            /// <summary>
            /// Texture DisplayName [03] (fixstr)
            /// </summary>
            /// <remarks>
            /// Texture DisplayName [03]
            /// </remarks>
            public object TextureDisplayName03 
            {
                get => (object)CellsByName["TextureDisplayName03"].Value;
                set => CellsByName["TextureDisplayName03"].Value = (object)value;
            }
            

            // Def="fixstr texName_04[16]"
            /// <summary>
            /// Texture DisplayName [04] (fixstr)
            /// </summary>
            /// <remarks>
            /// Texture DisplayName [04]
            /// </remarks>
            public object TextureDisplayName04 
            {
                get => (object)CellsByName["TextureDisplayName04"].Value;
                set => CellsByName["TextureDisplayName04"].Value = (object)value;
            }
            

            // Def="fixstr texName_05[16]"
            /// <summary>
            /// Texture DisplayName [05] (fixstr)
            /// </summary>
            /// <remarks>
            /// Texture DisplayName [05]
            /// </remarks>
            public object TextureDisplayName05 
            {
                get => (object)CellsByName["TextureDisplayName05"].Value;
                set => CellsByName["TextureDisplayName05"].Value = (object)value;
            }
            

            // Def="fixstr texName_06[16]"
            /// <summary>
            /// Texture DisplayName [06] (fixstr)
            /// </summary>
            /// <remarks>
            /// Texture DisplayName [06]
            /// </remarks>
            public object TextureDisplayName06 
            {
                get => (object)CellsByName["TextureDisplayName06"].Value;
                set => CellsByName["TextureDisplayName06"].Value = (object)value;
            }
            

            // Def="fixstr texName_07[16]"
            /// <summary>
            /// Texture DisplayName [07] (fixstr)
            /// </summary>
            /// <remarks>
            /// Texture DisplayName [07]
            /// </remarks>
            public object TextureDisplayName07 
            {
                get => (object)CellsByName["TextureDisplayName07"].Value;
                set => CellsByName["TextureDisplayName07"].Value = (object)value;
            }
            

            // Def="fixstr texName_08[16]"
            /// <summary>
            /// Texture DisplayName [08] (fixstr)
            /// </summary>
            /// <remarks>
            /// Texture DisplayName [08]
            /// </remarks>
            public object TextureDisplayName08 
            {
                get => (object)CellsByName["TextureDisplayName08"].Value;
                set => CellsByName["TextureDisplayName08"].Value = (object)value;
            }
            

            // Def="fixstr texName_09[16]"
            /// <summary>
            /// Texture DisplayName [09] (fixstr)
            /// </summary>
            /// <remarks>
            /// Texture DisplayName [09]
            /// </remarks>
            public object TextureDisplayName09 
            {
                get => (object)CellsByName["TextureDisplayName09"].Value;
                set => CellsByName["TextureDisplayName09"].Value = (object)value;
            }
            

            // Def="fixstr texName_10[16]"
            /// <summary>
            /// Texture DisplayName [10] (fixstr)
            /// </summary>
            /// <remarks>
            /// Texture DisplayName [10]
            /// </remarks>
            public object TextureDisplayName10 
            {
                get => (object)CellsByName["TextureDisplayName10"].Value;
                set => CellsByName["TextureDisplayName10"].Value = (object)value;
            }
            

            // Def="fixstr texName_11[16]"
            /// <summary>
            /// Texture DisplayName [11] (fixstr)
            /// </summary>
            /// <remarks>
            /// Texture DisplayName [11]
            /// </remarks>
            public object TextureDisplayName11 
            {
                get => (object)CellsByName["TextureDisplayName11"].Value;
                set => CellsByName["TextureDisplayName11"].Value = (object)value;
            }
            

            // Def="fixstr texName_12[16]"
            /// <summary>
            /// Texture DisplayName [12] (fixstr)
            /// </summary>
            /// <remarks>
            /// Texture DisplayName [12]
            /// </remarks>
            public object TextureDisplayName12 
            {
                get => (object)CellsByName["TextureDisplayName12"].Value;
                set => CellsByName["TextureDisplayName12"].Value = (object)value;
            }
            

            // Def="fixstr texName_13[16]"
            /// <summary>
            /// Texture DisplayName [13] (fixstr)
            /// </summary>
            /// <remarks>
            /// Texture DisplayName [13]
            /// </remarks>
            public object TextureDisplayName13 
            {
                get => (object)CellsByName["TextureDisplayName13"].Value;
                set => CellsByName["TextureDisplayName13"].Value = (object)value;
            }
            

            // Def="fixstr texName_14[16]"
            /// <summary>
            /// Texture DisplayName [14] (fixstr)
            /// </summary>
            /// <remarks>
            /// Texture DisplayName [14]
            /// </remarks>
            public object TextureDisplayName14 
            {
                get => (object)CellsByName["TextureDisplayName14"].Value;
                set => CellsByName["TextureDisplayName14"].Value = (object)value;
            }
            

            // Def="fixstr texName_15[16]"
            /// <summary>
            /// Texture DisplayName [15] (fixstr)
            /// </summary>
            /// <remarks>
            /// Texture DisplayName [15]
            /// </remarks>
            public object TextureDisplayName15 
            {
                get => (object)CellsByName["TextureDisplayName15"].Value;
                set => CellsByName["TextureDisplayName15"].Value = (object)value;
            }
            
                }
            }
            
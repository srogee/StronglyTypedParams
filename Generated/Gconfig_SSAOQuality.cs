
            namespace StronglyTypedParams
            {
                // CS_SSAO_QUALITY_DETAIL
                public class Gconfig_SSAOQuality : ParamRow
                {
                    public Gconfig_SSAOQuality() : base()
                    {
                    }
            

            // Def="u8 enabled = 1"
            /// <summary>
            /// SSAO Enabled (u8)
            /// </summary>
            /// <remarks>
            /// SSAO enabled
            /// </remarks>
            public OnOff SSAOEnabled 
            {
                get => (OnOff)CellsByName["SSAOEnabled"].Value;
                set => CellsByName["SSAOEnabled"].Value = (byte)value;
            }
            

            // Def="u8 cs_reprojEnabledType = 1"
            /// <summary>
            /// Reprojection Enabled (u8)
            /// </summary>
            /// <remarks>
            /// When reprojection is forcibly enabled, Prevent Ghost is also enabled.
            /// </remarks>
            public CsGconfigEnabledType ReprojectionEnabled 
            {
                get => (CsGconfigEnabledType)CellsByName["ReprojectionEnabled"].Value;
                set => CellsByName["ReprojectionEnabled"].Value = (byte)value;
            }
            

            // Def="u8 cs_upScaleEnabledType"
            /// <summary>
            /// Bilateral Upscale Enable Type (u8)
            /// </summary>
            /// <remarks>
            /// Bilateral upscale effective
            /// </remarks>
            public CsGconfigEnabledType BilateralUpscaleEnableType 
            {
                get => (CsGconfigEnabledType)CellsByName["BilateralUpscaleEnableType"].Value;
                set => CellsByName["BilateralUpscaleEnableType"].Value = (byte)value;
            }
            

            // Def="u8 cs_useNormalEnabledType = 1"
            /// <summary>
            /// Use Normal Enabled Type (u8)
            /// </summary>
            /// <remarks>
            /// Valid to use normals
            /// </remarks>
            public CsGconfigEnabledType UseNormalEnabledType 
            {
                get => (CsGconfigEnabledType)CellsByName["UseNormalEnabledType"].Value;
                set => CellsByName["UseNormalEnabledType"].Value = (byte)value;
            }
            

            // Def="dummy8 dmy[1]"
            /// <summary>
            /// dmy (dummy8)
            /// </summary>
            /// <remarks>
            /// 
            /// </remarks>
            public object Dmy 
            {
                get => (object)CellsByName["Dmy"].Value;
                set => CellsByName["Dmy"].Value = (object)value;
            }
            
                }
            }
            

            namespace StronglyTypedParams
            {
                // CS_GRAPHICS_CONFIG_PARAM_ST
                public class GraphicsConfig : ParamRow
                {
                    public GraphicsConfig() : base()
                    {
                    }
            

            // Def="u8 m_textureFilterQuality = 2"
            /// <summary>
            /// Texture Filter Quality (u8)
            /// </summary>
            /// <remarks>
            /// Texture filter quality (default Midele)
            /// </remarks>
            public GxQualityLevelEnum TextureFilterQuality 
            {
                get => (GxQualityLevelEnum)CellsByName["TextureFilterQuality"].Value;
                set => CellsByName["TextureFilterQuality"].Value = (byte)value;
            }
            

            // Def="u8 m_aaQuality = 3"
            /// <summary>
            /// AA Quality (u8)
            /// </summary>
            /// <remarks>
            /// AA quality (default High)
            /// </remarks>
            public GxQualityLevelEnum AAQuality 
            {
                get => (GxQualityLevelEnum)CellsByName["AAQuality"].Value;
                set => CellsByName["AAQuality"].Value = (byte)value;
            }
            

            // Def="u8 m_ssaoQuality = 3"
            /// <summary>
            /// SSAO Quality (u8)
            /// </summary>
            /// <remarks>
            /// SSAO quality (default High)
            /// </remarks>
            public GxQualityLevelEnum SSAOQuality 
            {
                get => (GxQualityLevelEnum)CellsByName["SSAOQuality"].Value;
                set => CellsByName["SSAOQuality"].Value = (byte)value;
            }
            

            // Def="u8 m_dofQuality = 3"
            /// <summary>
            /// Depth of Field Quality (u8)
            /// </summary>
            /// <remarks>
            /// Depth of field quality (default High)
            /// </remarks>
            public GxQualityLevelEnum DepthOfFieldQuality 
            {
                get => (GxQualityLevelEnum)CellsByName["DepthOfFieldQuality"].Value;
                set => CellsByName["DepthOfFieldQuality"].Value = (byte)value;
            }
            

            // Def="u8 m_motionBlurQuality = 3"
            /// <summary>
            /// Motion Blur Quality (u8)
            /// </summary>
            /// <remarks>
            /// Motion blur quality (default High)
            /// </remarks>
            public GxQualityLevelEnum MotionBlurQuality 
            {
                get => (GxQualityLevelEnum)CellsByName["MotionBlurQuality"].Value;
                set => CellsByName["MotionBlurQuality"].Value = (byte)value;
            }
            

            // Def="u8 m_shadowQuality = 3"
            /// <summary>
            /// Shadow Quality (u8)
            /// </summary>
            /// <remarks>
            /// Shadow quality (default High)
            /// </remarks>
            public GxQualityLevelEnum ShadowQuality 
            {
                get => (GxQualityLevelEnum)CellsByName["ShadowQuality"].Value;
                set => CellsByName["ShadowQuality"].Value = (byte)value;
            }
            

            // Def="u8 m_lightingQuality = 3"
            /// <summary>
            /// Lighting Quality (u8)
            /// </summary>
            /// <remarks>
            /// Lighting quality (default High)
            /// </remarks>
            public GxQualityLevelEnum LightingQuality 
            {
                get => (GxQualityLevelEnum)CellsByName["LightingQuality"].Value;
                set => CellsByName["LightingQuality"].Value = (byte)value;
            }
            

            // Def="u8 m_effectQuality = 3"
            /// <summary>
            /// Effect Quality (u8)
            /// </summary>
            /// <remarks>
            /// Effect quality (default High)
            /// </remarks>
            public GxQualityLevelEnum EffectQuality 
            {
                get => (GxQualityLevelEnum)CellsByName["EffectQuality"].Value;
                set => CellsByName["EffectQuality"].Value = (byte)value;
            }
            

            // Def="u8 m_decalQuality = 3"
            /// <summary>
            /// Decal Quality (u8)
            /// </summary>
            /// <remarks>
            /// Decal quality (default High)
            /// </remarks>
            public GxQualityLevelEnum DecalQuality 
            {
                get => (GxQualityLevelEnum)CellsByName["DecalQuality"].Value;
                set => CellsByName["DecalQuality"].Value = (byte)value;
            }
            

            // Def="u8 m_reflectionQuality = 3"
            /// <summary>
            /// Reflection Quality (u8)
            /// </summary>
            /// <remarks>
            /// Reflection quality (default High)
            /// </remarks>
            public GxQualityLevelEnum ReflectionQuality 
            {
                get => (GxQualityLevelEnum)CellsByName["ReflectionQuality"].Value;
                set => CellsByName["ReflectionQuality"].Value = (byte)value;
            }
            

            // Def="u8 m_waterQuality = 3"
            /// <summary>
            /// Water Quality (u8)
            /// </summary>
            /// <remarks>
            /// Water quality (default High)
            /// </remarks>
            public GxQualityLevelEnum WaterQuality 
            {
                get => (GxQualityLevelEnum)CellsByName["WaterQuality"].Value;
                set => CellsByName["WaterQuality"].Value = (byte)value;
            }
            

            // Def="u8 m_shaderQuality = 3"
            /// <summary>
            /// Shader Quality (u8)
            /// </summary>
            /// <remarks>
            /// Shader quality (default High)
            /// </remarks>
            public GxQualityLevelEnum ShaderQuality 
            {
                get => (GxQualityLevelEnum)CellsByName["ShaderQuality"].Value;
                set => CellsByName["ShaderQuality"].Value = (byte)value;
            }
            

            // Def="u8 m_volumetricEffectQuality = 3"
            /// <summary>
            /// Volumetric Effect Quality (u8)
            /// </summary>
            /// <remarks>
            /// Volumetric effect quality (default High)
            /// </remarks>
            public GxQualityLevelEnum VolumetricEffectQuality 
            {
                get => (GxQualityLevelEnum)CellsByName["VolumetricEffectQuality"].Value;
                set => CellsByName["VolumetricEffectQuality"].Value = (byte)value;
            }
            

            // Def="dummy8 m_dummy[3]"
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
            
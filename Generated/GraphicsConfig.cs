
            namespace StronglyTypedParams
            {
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
            public byte TextureFilterQuality 
            {
                get => (byte)CellsByName["TextureFilterQuality"].Value;
                set => CellsByName["TextureFilterQuality"].Value = value;
            }
            

            // Def="u8 m_aaQuality = 3"
            /// <summary>
            /// AA Quality (u8)
            /// </summary>
            /// <remarks>
            /// AA quality (default High)
            /// </remarks>
            public byte AAQuality 
            {
                get => (byte)CellsByName["AAQuality"].Value;
                set => CellsByName["AAQuality"].Value = value;
            }
            

            // Def="u8 m_ssaoQuality = 3"
            /// <summary>
            /// SSAO Quality (u8)
            /// </summary>
            /// <remarks>
            /// SSAO quality (default High)
            /// </remarks>
            public byte SSAOQuality 
            {
                get => (byte)CellsByName["SSAOQuality"].Value;
                set => CellsByName["SSAOQuality"].Value = value;
            }
            

            // Def="u8 m_dofQuality = 3"
            /// <summary>
            /// Depth of Field Quality (u8)
            /// </summary>
            /// <remarks>
            /// Depth of field quality (default High)
            /// </remarks>
            public byte DepthOfFieldQuality 
            {
                get => (byte)CellsByName["DepthOfFieldQuality"].Value;
                set => CellsByName["DepthOfFieldQuality"].Value = value;
            }
            

            // Def="u8 m_motionBlurQuality = 3"
            /// <summary>
            /// Motion Blur Quality (u8)
            /// </summary>
            /// <remarks>
            /// Motion blur quality (default High)
            /// </remarks>
            public byte MotionBlurQuality 
            {
                get => (byte)CellsByName["MotionBlurQuality"].Value;
                set => CellsByName["MotionBlurQuality"].Value = value;
            }
            

            // Def="u8 m_shadowQuality = 3"
            /// <summary>
            /// Shadow Quality (u8)
            /// </summary>
            /// <remarks>
            /// Shadow quality (default High)
            /// </remarks>
            public byte ShadowQuality 
            {
                get => (byte)CellsByName["ShadowQuality"].Value;
                set => CellsByName["ShadowQuality"].Value = value;
            }
            

            // Def="u8 m_lightingQuality = 3"
            /// <summary>
            /// Lighting Quality (u8)
            /// </summary>
            /// <remarks>
            /// Lighting quality (default High)
            /// </remarks>
            public byte LightingQuality 
            {
                get => (byte)CellsByName["LightingQuality"].Value;
                set => CellsByName["LightingQuality"].Value = value;
            }
            

            // Def="u8 m_effectQuality = 3"
            /// <summary>
            /// Effect Quality (u8)
            /// </summary>
            /// <remarks>
            /// Effect quality (default High)
            /// </remarks>
            public byte EffectQuality 
            {
                get => (byte)CellsByName["EffectQuality"].Value;
                set => CellsByName["EffectQuality"].Value = value;
            }
            

            // Def="u8 m_decalQuality = 3"
            /// <summary>
            /// Decal Quality (u8)
            /// </summary>
            /// <remarks>
            /// Decal quality (default High)
            /// </remarks>
            public byte DecalQuality 
            {
                get => (byte)CellsByName["DecalQuality"].Value;
                set => CellsByName["DecalQuality"].Value = value;
            }
            

            // Def="u8 m_reflectionQuality = 3"
            /// <summary>
            /// Reflection Quality (u8)
            /// </summary>
            /// <remarks>
            /// Reflection quality (default High)
            /// </remarks>
            public byte ReflectionQuality 
            {
                get => (byte)CellsByName["ReflectionQuality"].Value;
                set => CellsByName["ReflectionQuality"].Value = value;
            }
            

            // Def="u8 m_waterQuality = 3"
            /// <summary>
            /// Water Quality (u8)
            /// </summary>
            /// <remarks>
            /// Water quality (default High)
            /// </remarks>
            public byte WaterQuality 
            {
                get => (byte)CellsByName["WaterQuality"].Value;
                set => CellsByName["WaterQuality"].Value = value;
            }
            

            // Def="u8 m_shaderQuality = 3"
            /// <summary>
            /// Shader Quality (u8)
            /// </summary>
            /// <remarks>
            /// Shader quality (default High)
            /// </remarks>
            public byte ShaderQuality 
            {
                get => (byte)CellsByName["ShaderQuality"].Value;
                set => CellsByName["ShaderQuality"].Value = value;
            }
            

            // Def="u8 m_volumetricEffectQuality = 3"
            /// <summary>
            /// Volumetric Effect Quality (u8)
            /// </summary>
            /// <remarks>
            /// Volumetric effect quality (default High)
            /// </remarks>
            public byte VolumetricEffectQuality 
            {
                get => (byte)CellsByName["VolumetricEffectQuality"].Value;
                set => CellsByName["VolumetricEffectQuality"].Value = value;
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
                set => CellsByName["Dmy"].Value = value;
            }
            
                }
            }
            
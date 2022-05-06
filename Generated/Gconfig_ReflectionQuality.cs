
            namespace StronglyTypedParams
            {
                public class Gconfig_ReflectionQuality : ParamRow
                {
                    public Gconfig_ReflectionQuality() : base()
                    {
                    }
            

            // Def="u8 enabled = 1"
            /// <summary>
            /// Reflection Enabled (u8)
            /// </summary>
            /// <remarks>
            /// Reflective effective
            /// </remarks>
            public byte ReflectionEnabled 
            {
                get => (byte)CellsByName["ReflectionEnabled"].Value;
                set => CellsByName["ReflectionEnabled"].Value = value;
            }
            

            // Def="u8 localLightEnabled = 1"
            /// <summary>
            /// Local Light Enabled (u8)
            /// </summary>
            /// <remarks>
            /// Local light enabled
            /// </remarks>
            public byte LocalLightEnabled 
            {
                get => (byte)CellsByName["LocalLightEnabled"].Value;
                set => CellsByName["LocalLightEnabled"].Value = value;
            }
            

            // Def="u8 localLightForceEnabled"
            /// <summary>
            /// Local Light Forced Enabled (u8)
            /// </summary>
            /// <remarks>
            /// Local light forced enable
            /// </remarks>
            public byte LocalLightForcedEnabled 
            {
                get => (byte)CellsByName["LocalLightForcedEnabled"].Value;
                set => CellsByName["LocalLightForcedEnabled"].Value = value;
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
                set => CellsByName["Dmy"].Value = value;
            }
            

            // Def="u32 resolutionDivider = 2"
            /// <summary>
            /// Resolution Scale (u32)
            /// </summary>
            /// <remarks>
            /// Resolution scale
            /// </remarks>
            public uint ResolutionScale 
            {
                get => (uint)CellsByName["ResolutionScale"].Value;
                set => CellsByName["ResolutionScale"].Value = value;
            }
            

            // Def="u8 ssrEnabled = 1"
            /// <summary>
            /// SSR Enabled (u8)
            /// </summary>
            /// <remarks>
            /// SSR enabled
            /// </remarks>
            public byte SSREnabled 
            {
                get => (byte)CellsByName["SSREnabled"].Value;
                set => CellsByName["SSREnabled"].Value = value;
            }
            

            // Def="u8 ssrGaussianBlurEnabled = 1"
            /// <summary>
            /// Gaussian Blur Enabled (u8)
            /// </summary>
            /// <remarks>
            /// Gaussian blur permission
            /// </remarks>
            public byte GaussianBlurEnabled 
            {
                get => (byte)CellsByName["GaussianBlurEnabled"].Value;
                set => CellsByName["GaussianBlurEnabled"].Value = value;
            }
            


            // Def="f32 ssrDepthRejectThresholdScale = 1"
            /// <summary>
            /// Calculated Distance Scale (f32)
            /// </summary>
            /// <remarks>
            /// Calculated distance scale
            /// </remarks>
            public float CalculatedDistanceScale 
            {
                get => (float)CellsByName["CalculatedDistanceScale"].Value;
                set => CellsByName["CalculatedDistanceScale"].Value = value;
            }
            

            // Def="f32 ssrRayTraceStepScale = 1"
            /// <summary>
            /// Raytrace Step Scale (f32)
            /// </summary>
            /// <remarks>
            /// Raytrace step factor (multiply by SSR parameter)
            /// </remarks>
            public float RaytraceStepScale 
            {
                get => (float)CellsByName["RaytraceStepScale"].Value;
                set => CellsByName["RaytraceStepScale"].Value = value;
            }
            

            // Def="f32 ssrFadeToViewerBias"
            /// <summary>
            /// Fade Angle Bias (f32)
            /// </summary>
            /// <remarks>
            /// Fade angle bias. High quality when made smaller
            /// </remarks>
            public float FadeAngleBias 
            {
                get => (float)CellsByName["FadeAngleBias"].Value;
                set => CellsByName["FadeAngleBias"].Value = value;
            }
            

            // Def="f32 ssrFresnelRejectBias"
            /// <summary>
            /// Fresnel Reject Bias (f32)
            /// </summary>
            /// <remarks>
            /// Fresnel reject bias. High quality when made smaller
            /// </remarks>
            public float FresnelRejectBias 
            {
                get => (float)CellsByName["FresnelRejectBias"].Value;
                set => CellsByName["FresnelRejectBias"].Value = value;
            }
            
                }
            }
            
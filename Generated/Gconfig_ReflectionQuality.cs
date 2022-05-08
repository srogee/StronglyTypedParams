
            namespace StronglyTypedParams
            {
                // CS_REFLECTION_QUALITY_DETAIL
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
            public OnOff ReflectionEnabled 
            {
                get => (OnOff)CellsByName["ReflectionEnabled"].Value;
                set => CellsByName["ReflectionEnabled"].Value = (byte)value;
            }
            

            // Def="u8 localLightEnabled = 1"
            /// <summary>
            /// Local Light Enabled (u8)
            /// </summary>
            /// <remarks>
            /// Local light enabled
            /// </remarks>
            public OnOff LocalLightEnabled 
            {
                get => (OnOff)CellsByName["LocalLightEnabled"].Value;
                set => CellsByName["LocalLightEnabled"].Value = (byte)value;
            }
            

            // Def="u8 localLightForceEnabled"
            /// <summary>
            /// Local Light Forced Enabled (u8)
            /// </summary>
            /// <remarks>
            /// Local light forced enable
            /// </remarks>
            public OnOff LocalLightForcedEnabled 
            {
                get => (OnOff)CellsByName["LocalLightForcedEnabled"].Value;
                set => CellsByName["LocalLightForcedEnabled"].Value = (byte)value;
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
                set => CellsByName["ResolutionScale"].Value = (uint)value;
            }
            

            // Def="u8 ssrEnabled = 1"
            /// <summary>
            /// SSR Enabled (u8)
            /// </summary>
            /// <remarks>
            /// SSR enabled
            /// </remarks>
            public OnOff SSREnabled 
            {
                get => (OnOff)CellsByName["SSREnabled"].Value;
                set => CellsByName["SSREnabled"].Value = (byte)value;
            }
            

            // Def="u8 ssrGaussianBlurEnabled = 1"
            /// <summary>
            /// Gaussian Blur Enabled (u8)
            /// </summary>
            /// <remarks>
            /// Gaussian blur permission
            /// </remarks>
            public OnOff GaussianBlurEnabled 
            {
                get => (OnOff)CellsByName["GaussianBlurEnabled"].Value;
                set => CellsByName["GaussianBlurEnabled"].Value = (byte)value;
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
                set => CellsByName["CalculatedDistanceScale"].Value = (float)value;
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
                set => CellsByName["RaytraceStepScale"].Value = (float)value;
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
                set => CellsByName["FadeAngleBias"].Value = (float)value;
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
                set => CellsByName["FresnelRejectBias"].Value = (float)value;
            }
            
                }
            }
            
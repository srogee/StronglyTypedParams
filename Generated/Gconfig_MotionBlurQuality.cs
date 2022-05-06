
            namespace StronglyTypedParams
            {
                public class Gconfig_MotionBlurQuality : ParamRow
                {
                    public Gconfig_MotionBlurQuality() : base()
                    {
                    }
            

            // Def="u8 Enabled = 1"
            /// <summary>
            /// Motion Blur Enabled (u8)
            /// </summary>
            /// <remarks>
            /// Motion blur Enabled
            /// </remarks>
            public byte MotionBlurEnabled 
            {
                get => (byte)CellsByName["MotionBlurEnabled"].Value;
                set => CellsByName["MotionBlurEnabled"].Value = value;
            }
            

            // Def="u8 ombEnabled = 1"
            /// <summary>
            /// Object Motion Blur Enabled (u8)
            /// </summary>
            /// <remarks>
            /// OMB (object motion blur) Enabled
            /// </remarks>
            public byte ObjectMotionBlurEnabled 
            {
                get => (byte)CellsByName["ObjectMotionBlurEnabled"].Value;
                set => CellsByName["ObjectMotionBlurEnabled"].Value = value;
            }
            

            // Def="u8 forceScaleVelocityBuffer = 1"
            /// <summary>
            /// Force Scale Velocity Buffer (u8)
            /// </summary>
            /// <remarks>
            /// Decrease the resolution of the velocity buffer used internally. Not effective if you are not using precision velocity buffers
            /// </remarks>
            public byte ForceScaleVelocityBuffer 
            {
                get => (byte)CellsByName["ForceScaleVelocityBuffer"].Value;
                set => CellsByName["ForceScaleVelocityBuffer"].Value = value;
            }
            

            // Def="u8 cheapFilterMode"
            /// <summary>
            /// Cheap Filter Mode (u8)
            /// </summary>
            /// <remarks>
            /// Normally processed by the Reconstruction filter, but downgraded to a lighter process
            /// </remarks>
            public byte CheapFilterMode 
            {
                get => (byte)CellsByName["CheapFilterMode"].Value;
                set => CellsByName["CheapFilterMode"].Value = value;
            }
            

            // Def="s32 sampleCountBias = -2"
            /// <summary>
            /// Sample Count Bias (s32)
            /// </summary>
            /// <remarks>
            /// Give an offset to the sample count * Set to a multiple of 2
            /// </remarks>
            public int SampleCountBias 
            {
                get => (int)CellsByName["SampleCountBias"].Value;
                set => CellsByName["SampleCountBias"].Value = value;
            }
            

            // Def="s32 recurrenceCountBias"
            /// <summary>
            /// Recurrence Count Bias (s32)
            /// </summary>
            /// <remarks>
            /// Give an offset to the number of recursive blurs
            /// </remarks>
            public int RecurrenceCountBias 
            {
                get => (int)CellsByName["RecurrenceCountBias"].Value;
                set => CellsByName["RecurrenceCountBias"].Value = value;
            }
            

            // Def="f32 blurMaxLengthScale = 0.75"
            /// <summary>
            /// Blur Max Length Scale (f32)
            /// </summary>
            /// <remarks>
            /// Scale value for blur maximum length parameter
            /// </remarks>
            public float BlurMaxLengthScale 
            {
                get => (float)CellsByName["BlurMaxLengthScale"].Value;
                set => CellsByName["BlurMaxLengthScale"].Value = value;
            }
            
                }
            }
            
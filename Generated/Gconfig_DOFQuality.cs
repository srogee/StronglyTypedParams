
            namespace StronglyTypedParams
            {
                public class Gconfig_DOFQuality : ParamRow
                {
                    public Gconfig_DOFQuality() : base()
                    {
                    }
            

            // Def="u8 enabled = 1"
            /// <summary>
            /// Depth of Field Enabled (u8)
            /// </summary>
            /// <remarks>
            /// DOF permission
            /// </remarks>
            public byte DepthOfFieldEnabled 
            {
                get => (byte)CellsByName["DepthOfFieldEnabled"].Value;
                set => CellsByName["DepthOfFieldEnabled"].Value = value;
            }
            

            // Def="dummy8 dmy[3]"
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
            

            // Def="s32 forceHiResoBlur = -1"
            /// <summary>
            /// Force High Resolution Blur (s32)
            /// </summary>
            /// <remarks>
            /// Change the HiResolutionBlur setting (-1: forced off, 0: as-is, 1: forced on)
            /// </remarks>
            public int ForceHighResolutionBlur 
            {
                get => (int)CellsByName["ForceHighResolutionBlur"].Value;
                set => CellsByName["ForceHighResolutionBlur"].Value = value;
            }
            

            // Def="s32 maxBlurLevel = 1"
            /// <summary>
            /// Maximum Blur Level (s32)
            /// </summary>
            /// <remarks>
            /// Maximum blur level. 2: Maximum, 1: Level to one paragraph, 0: Further reduce accuracy
            /// </remarks>
            public int MaximumBlurLevel 
            {
                get => (int)CellsByName["MaximumBlurLevel"].Value;
                set => CellsByName["MaximumBlurLevel"].Value = value;
            }
            
                }
            }
            
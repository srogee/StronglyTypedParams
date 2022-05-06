
            namespace StronglyTypedParams
            {
                public class Gconfig_ShadowQuality : ParamRow
                {
                    public Gconfig_ShadowQuality() : base()
                    {
                    }
            

            // Def="u8 enabled = 1"
            /// <summary>
            /// Shadow Enabled (u8)
            /// </summary>
            /// <remarks>
            /// Shadow is enabled
            /// </remarks>
            public byte ShadowEnabled 
            {
                get => (byte)CellsByName["ShadowEnabled"].Value;
                set => CellsByName["ShadowEnabled"].Value = value;
            }
            

            // Def="u8 maxFilterLevel = 1"
            /// <summary>
            /// Maximum Filter Level (u8)
            /// </summary>
            /// <remarks>
            /// Maximum filter quality allowed
            /// </remarks>
            public byte MaximumFilterLevel 
            {
                get => (byte)CellsByName["MaximumFilterLevel"].Value;
                set => CellsByName["MaximumFilterLevel"].Value = value;
            }
            

            // Def="dummy8 dmy[2]"
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
            

            // Def="u32 textureSizeScaler = 1"
            /// <summary>
            /// Texture Size Scalar (u32)
            /// </summary>
            /// <remarks>
            /// Scaler with set shadow map resolution
            /// </remarks>
            public uint TextureSizeScalar 
            {
                get => (uint)CellsByName["TextureSizeScalar"].Value;
                set => CellsByName["TextureSizeScalar"].Value = value;
            }
            

            // Def="u32 textureSizeDivider = 2"
            /// <summary>
            /// Texture Size Division (u32)
            /// </summary>
            /// <remarks>
            /// Divide the set shadow map resolution
            /// </remarks>
            public uint TextureSizeDivision 
            {
                get => (uint)CellsByName["TextureSizeDivision"].Value;
                set => CellsByName["TextureSizeDivision"].Value = value;
            }
            

            // Def="u32 textureMinSize = 128"
            /// <summary>
            /// Minimum Resolution (u32)
            /// </summary>
            /// <remarks>
            /// Clamp resolution
            /// </remarks>
            public uint MinimumResolution 
            {
                get => (uint)CellsByName["MinimumResolution"].Value;
                set => CellsByName["MinimumResolution"].Value = value;
            }
            

            // Def="u32 textureMaxSize = 1024"
            /// <summary>
            /// Maximum Resolution (u32)
            /// </summary>
            /// <remarks>
            /// Clamp the resolution. It will be the resolution judgment for each cascade
            /// </remarks>
            public uint MaximumResolution 
            {
                get => (uint)CellsByName["MaximumResolution"].Value;
                set => CellsByName["MaximumResolution"].Value = value;
            }
            

            // Def="s32 blurCountBias = -1"
            /// <summary>
            /// Blur Count Bias (s32)
            /// </summary>
            /// <remarks>
            /// Blur count bias (set count bias, unchanged at 0)
            /// </remarks>
            public int BlurCountBias 
            {
                get => (int)CellsByName["BlurCountBias"].Value;
                set => CellsByName["BlurCountBias"].Value = value;
            }
            
                }
            }
            
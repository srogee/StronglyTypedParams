
            namespace StronglyTypedParams
            {
                public class LoadBalancerParam : ParamRow
                {
                    public LoadBalancerParam() : base()
                    {
                    }
            

            // Def="f32 lowerFpsThreshold = 23"
            /// <summary>
            /// Lower FPS Threshold - Raise Balance Level (f32)
            /// </summary>
            /// <remarks>
            /// If it falls below this FPS, increase the load balance level by 1.
            /// </remarks>
            public float LowerFPSThresholdRaiseBalanceLevel 
            {
                get => (float)CellsByName["LowerFPSThresholdRaiseBalanceLevel"].Value;
                set => CellsByName["LowerFPSThresholdRaiseBalanceLevel"].Value = value;
            }
            

            // Def="f32 upperFpsThreshold = 27"
            /// <summary>
            /// Upper FPS Threshold - Lower Balance Level (f32)
            /// </summary>
            /// <remarks>
            /// If you exceed this FPS, lower the load balance level by 1.
            /// </remarks>
            public float UpperFPSThresholdLowerBalanceLevel 
            {
                get => (float)CellsByName["UpperFPSThresholdLowerBalanceLevel"].Value;
                set => CellsByName["UpperFPSThresholdLowerBalanceLevel"].Value = value;
            }
            

            // Def="u32 lowerFpsContinousCount = 5"
            /// <summary>
            /// Lower FPS Continous - Raise Balance Level (u32)
            /// </summary>
            /// <remarks>
            /// If this frame continues below the threshold, level up
            /// </remarks>
            public uint LowerFPSContinousRaiseBalanceLevel 
            {
                get => (uint)CellsByName["LowerFPSContinousRaiseBalanceLevel"].Value;
                set => CellsByName["LowerFPSContinousRaiseBalanceLevel"].Value = value;
            }
            

            // Def="u32 upperFpsContinousCount = 20"
            /// <summary>
            /// Upper FPS Continous - Lower Balance Level (u32)
            /// </summary>
            /// <remarks>
            /// If the threshold is exceeded continuously for this frame, level down
            /// </remarks>
            public uint UpperFPSContinousLowerBalanceLevel 
            {
                get => (uint)CellsByName["UpperFPSContinousLowerBalanceLevel"].Value;
                set => CellsByName["UpperFPSContinousLowerBalanceLevel"].Value = value;
            }
            

            // Def="u32 downAfterChangeSleep = 30"
            /// <summary>
            /// Sleep Frame Count after Level Lower (u32)
            /// </summary>
            /// <remarks>
            /// Sleep frame count after level down
            /// </remarks>
            public uint SleepFrameCountAfterLevelLower 
            {
                get => (uint)CellsByName["SleepFrameCountAfterLevelLower"].Value;
                set => CellsByName["SleepFrameCountAfterLevelLower"].Value = value;
            }
            

            // Def="u32 upAfterChangeSleep = 10"
            /// <summary>
            /// Sleep Frame Count after Level Raise (u32)
            /// </summary>
            /// <remarks>
            /// Sleep frame count after leveling up
            /// </remarks>
            public uint SleepFrameCountAfterLevelRaise 
            {
                get => (uint)CellsByName["SleepFrameCountAfterLevelRaise"].Value;
                set => CellsByName["SleepFrameCountAfterLevelRaise"].Value = value;
            }
            

            // Def="u8 postProcessLightShaft = 20"
            /// <summary>
            /// Post Process: Light Shaft (u8)
            /// </summary>
            /// <remarks>
            /// Light shaft of filter
            /// </remarks>
            public byte PostProcessLightShaft 
            {
                get => (byte)CellsByName["PostProcessLightShaft"].Value;
                set => CellsByName["PostProcessLightShaft"].Value = value;
            }
            

            // Def="u8 postProcessBloom = 20"
            /// <summary>
            /// Post Process: Bloom (u8)
            /// </summary>
            /// <remarks>
            /// Bloom
            /// </remarks>
            public byte PostProcessBloom 
            {
                get => (byte)CellsByName["PostProcessBloom"].Value;
                set => CellsByName["PostProcessBloom"].Value = value;
            }
            

            // Def="u8 postProcessGlow = 20"
            /// <summary>
            /// Post Process: Glow (u8)
            /// </summary>
            /// <remarks>
            /// Glow
            /// </remarks>
            public byte PostProcessGlow 
            {
                get => (byte)CellsByName["PostProcessGlow"].Value;
                set => CellsByName["PostProcessGlow"].Value = value;
            }
            

            // Def="u8 postProcessAA = 20"
            /// <summary>
            /// Post Process: Anti-Aliasing (u8)
            /// </summary>
            /// <remarks>
            /// Antialiasing
            /// </remarks>
            public byte PostProcessAntiAliasing 
            {
                get => (byte)CellsByName["PostProcessAntiAliasing"].Value;
                set => CellsByName["PostProcessAntiAliasing"].Value = value;
            }
            

            // Def="u8 postProcessSSAO = 20"
            /// <summary>
            /// Post Process: SSAO (u8)
            /// </summary>
            /// <remarks>
            /// SSAO
            /// </remarks>
            public byte PostProcessSSAO 
            {
                get => (byte)CellsByName["PostProcessSSAO"].Value;
                set => CellsByName["PostProcessSSAO"].Value = value;
            }
            

            // Def="u8 postProcessDOF = 20"
            /// <summary>
            /// Post Process: Depth of Field (u8)
            /// </summary>
            /// <remarks>
            /// DOF
            /// </remarks>
            public byte PostProcessDepthOfField 
            {
                get => (byte)CellsByName["PostProcessDepthOfField"].Value;
                set => CellsByName["PostProcessDepthOfField"].Value = value;
            }
            

            // Def="u8 postProcessMotionBlur = 20"
            /// <summary>
            /// Post Process: Motion Blur (u8)
            /// </summary>
            /// <remarks>
            /// Motion Blur
            /// </remarks>
            public byte PostProcessMotionBlur 
            {
                get => (byte)CellsByName["PostProcessMotionBlur"].Value;
                set => CellsByName["PostProcessMotionBlur"].Value = value;
            }
            

            // Def="u8 postProcessMotionBlurIteration = 20"
            /// <summary>
            /// Post Process: Motion Blur Iteration (u8)
            /// </summary>
            /// <remarks>
            /// Reduce the number of Motion Blur iterations
            /// </remarks>
            public byte PostProcessMotionBlurIteration 
            {
                get => (byte)CellsByName["PostProcessMotionBlurIteration"].Value;
                set => CellsByName["PostProcessMotionBlurIteration"].Value = value;
            }
            

            // Def="dummy8 reserve0[1]"
            /// <summary>
            /// Reserve (dummy8)
            /// </summary>
            /// <remarks>
            /// Reserve
            /// </remarks>
            public object Reserve 
            {
                get => (object)CellsByName["Reserve"].Value;
                set => CellsByName["Reserve"].Value = value;
            }
            

            // Def="u8 shadowBlur = 20"
            /// <summary>
            /// Cut Shadow Blur (u8)
            /// </summary>
            /// <remarks>
            /// Cut the shadow blur
            /// </remarks>
            public byte CutShadowBlur 
            {
                get => (byte)CellsByName["CutShadowBlur"].Value;
                set => CellsByName["CutShadowBlur"].Value = value;
            }
            

            // Def="u8 sfxParticleHalf = 20"
            /// <summary>
            /// Halve SFX Particle (u8)
            /// </summary>
            /// <remarks>
            /// Emit interval, number of emits, LOD distance halved in graphics config
            /// </remarks>
            public byte HalveSFXParticle 
            {
                get => (byte)CellsByName["HalveSFXParticle"].Value;
                set => CellsByName["HalveSFXParticle"].Value = value;
            }
            

            // Def="u8 sfxReflection = 20"
            /// <summary>
            /// Omit SFX Reflection (u8)
            /// </summary>
            /// <remarks>
            /// Omit the reflection scene SFX
            /// </remarks>
            public byte OmitSFXReflection 
            {
                get => (byte)CellsByName["OmitSFXReflection"].Value;
                set => CellsByName["OmitSFXReflection"].Value = value;
            }
            

            // Def="u8 sfxWaterInteraction = 20"
            /// <summary>
            /// Omit Water Surface SFX Interaction (u8)
            /// </summary>
            /// <remarks>
            /// Omit water surface interact SFX
            /// </remarks>
            public byte OmitWaterSurfaceSFXInteraction 
            {
                get => (byte)CellsByName["OmitWaterSurfaceSFXInteraction"].Value;
                set => CellsByName["OmitWaterSurfaceSFXInteraction"].Value = value;
            }
            

            // Def="u8 sfxGlow = 20"
            /// <summary>
            /// Omit SFX Glow (u8)
            /// </summary>
            /// <remarks>
            /// Omit Glow playing with SFX
            /// </remarks>
            public byte OmitSFXGlow 
            {
                get => (byte)CellsByName["OmitSFXGlow"].Value;
                set => CellsByName["OmitSFXGlow"].Value = value;
            }
            

            // Def="u8 sfxDistortion = 20"
            /// <summary>
            /// Omit SFX Distortion (u8)
            /// </summary>
            /// <remarks>
            /// Omit of distortion applied by SFX
            /// </remarks>
            public byte OmitSFXDistortion 
            {
                get => (byte)CellsByName["OmitSFXDistortion"].Value;
                set => CellsByName["OmitSFXDistortion"].Value = value;
            }
            

            // Def="u8 sftSoftSprite = 20"
            /// <summary>
            /// Omit SFX Soft Sprite (u8)
            /// </summary>
            /// <remarks>
            /// Soft sprite omit with SFX
            /// </remarks>
            public byte OmitSFXSoftSprite 
            {
                get => (byte)CellsByName["OmitSFXSoftSprite"].Value;
                set => CellsByName["OmitSFXSoftSprite"].Value = value;
            }
            

            // Def="u8 sfxLightShaft = 20"
            /// <summary>
            /// Omit SFX Light Shaft (u8)
            /// </summary>
            /// <remarks>
            /// SFX Light Shaft Omit
            /// </remarks>
            public byte OmitSFXLightShaft 
            {
                get => (byte)CellsByName["OmitSFXLightShaft"].Value;
                set => CellsByName["OmitSFXLightShaft"].Value = value;
            }
            

            // Def="u8 sfxScaleRenderDistanceScale = 20"
            /// <summary>
            /// SFX Scale - Render Distance Scale (u8)
            /// </summary>
            /// <remarks>
            /// Scale to the distance judgment of the effect dynamically registered in the reduction buffer by the distance of SFX
            /// </remarks>
            public byte SFXScaleRenderDistanceScale 
            {
                get => (byte)CellsByName["SFXScaleRenderDistanceScale"].Value;
                set => CellsByName["SFXScaleRenderDistanceScale"].Value = value;
            }
            

            // Def="u8 dynamicResolution = 1"
            /// <summary>
            /// Dynamic Resolution (u8)
            /// </summary>
            /// <remarks>
            /// Dynamic resolution
            /// </remarks>
            public byte DynamicResolution 
            {
                get => (byte)CellsByName["DynamicResolution"].Value;
                set => CellsByName["DynamicResolution"].Value = value;
            }
            

            // Def="u8 shadowCascade0ResolutionHalf"
            /// <summary>
            /// Halve Shadow Cascade [0] Resolution (u8)
            /// </summary>
            /// <remarks>
            /// Cut the shadow (cascade 0) resolution in half
            /// </remarks>
            public byte HalveShadowCascade0Resolution 
            {
                get => (byte)CellsByName["HalveShadowCascade0Resolution"].Value;
                set => CellsByName["HalveShadowCascade0Resolution"].Value = value;
            }
            

            // Def="u8 shadowCascade1ResolutionHalf = 13"
            /// <summary>
            /// Halve Shadow Cascade [1] Resolution (u8)
            /// </summary>
            /// <remarks>
            /// Cut the shadow (cascade 1) resolution in half
            /// </remarks>
            public byte HalveShadowCascade1Resolution 
            {
                get => (byte)CellsByName["HalveShadowCascade1Resolution"].Value;
                set => CellsByName["HalveShadowCascade1Resolution"].Value = value;
            }
            

            // Def="u8 chrWetDisablePlayer = 21"
            /// <summary>
            /// Disable Wetness for Player (u8)
            /// </summary>
            /// <remarks>
            /// Turn off the water wetting process for local players
            /// </remarks>
            public byte DisableWetnessForPlayer 
            {
                get => (byte)CellsByName["DisableWetnessForPlayer"].Value;
                set => CellsByName["DisableWetnessForPlayer"].Value = value;
            }
            

            // Def="u8 chrWetDisableRemotePlayer = 21"
            /// <summary>
            /// Disable Wetness for Remote Player (u8)
            /// </summary>
            /// <remarks>
            /// Turn off the water wetting process of the remote player
            /// </remarks>
            public byte DisableWetnessForRemotePlayer 
            {
                get => (byte)CellsByName["DisableWetnessForRemotePlayer"].Value;
                set => CellsByName["DisableWetnessForRemotePlayer"].Value = value;
            }
            

            // Def="u8 chrWetDisableEnemy = 21"
            /// <summary>
            /// Disable Wetness for NPC (u8)
            /// </summary>
            /// <remarks>
            /// Turn off the water wetting process of enemy characters
            /// </remarks>
            public byte DisableWetnessForNPC 
            {
                get => (byte)CellsByName["DisableWetnessForNPC"].Value;
                set => CellsByName["DisableWetnessForNPC"].Value = value;
            }
            

            // Def="u8 dynamicResolutionPercentageMin = 100"
            /// <summary>
            /// Lower Limit of Resolution Reduction (u8)
            /// </summary>
            /// <remarks>
            /// Resolution reduction lower limit (%)
            /// </remarks>
            public byte LowerLimitOfResolutionReduction 
            {
                get => (byte)CellsByName["LowerLimitOfResolutionReduction"].Value;
                set => CellsByName["LowerLimitOfResolutionReduction"].Value = value;
            }
            

            // Def="u8 dynamicResolutionPercentageMax = 100"
            /// <summary>
            /// Upper Limit of Resolution Reduction (u8)
            /// </summary>
            /// <remarks>
            /// Resolution reduction upper limit (%)
            /// </remarks>
            public byte UpperLimitOfResolutionReduction 
            {
                get => (byte)CellsByName["UpperLimitOfResolutionReduction"].Value;
                set => CellsByName["UpperLimitOfResolutionReduction"].Value = value;
            }
            

                }
            }
            
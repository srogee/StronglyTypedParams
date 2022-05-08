
            namespace StronglyTypedParams
            {
                // CS_VOLUMETRIC_EFFECT_QUALITY_DETAIL
                public class Gconfig_VolumetricEffectQuality : ParamRow
                {
                    public Gconfig_VolumetricEffectQuality() : base()
                    {
                    }
            

            // Def="u8 fogEnabled = 1"
            /// <summary>
            /// Fog Enabled (u8)
            /// </summary>
            /// <remarks>
            /// Fog enabled
            /// </remarks>
            public OnOff FogEnabled 
            {
                get => (OnOff)CellsByName["FogEnabled"].Value;
                set => CellsByName["FogEnabled"].Value = (byte)value;
            }
            

            // Def="u8 fogShadowEnabled = 1"
            /// <summary>
            /// Fog Shadow Enabled (u8)
            /// </summary>
            /// <remarks>
            /// Fog shadow permission
            /// </remarks>
            public OnOff FogShadowEnabled 
            {
                get => (OnOff)CellsByName["FogShadowEnabled"].Value;
                set => CellsByName["FogShadowEnabled"].Value = (byte)value;
            }
            

            // Def="dummy8 dmy[2]"
            /// <summary>
            /// dmy (dummy8)
            /// </summary>
            /// <remarks>
            /// dmy
            /// </remarks>
            public object Dmy 
            {
                get => (object)CellsByName["Dmy"].Value;
                set => CellsByName["Dmy"].Value = (object)value;
            }
            

            // Def="s32 fogShadowSampleCountBias"
            /// <summary>
            /// Shadow Sample Count Offset (s32)
            /// </summary>
            /// <remarks>
            /// Shadow sample count offset.
            /// </remarks>
            public int ShadowSampleCountOffset 
            {
                get => (int)CellsByName["ShadowSampleCountOffset"].Value;
                set => CellsByName["ShadowSampleCountOffset"].Value = (int)value;
            }
            

            // Def="f32 fogLocalLightDistScale"
            /// <summary>
            /// Local Light Distance Scale (f32)
            /// </summary>
            /// <remarks>
            /// Local light calculation distance scale (0 does not calculate local light)
            /// </remarks>
            public float LocalLightDistanceScale 
            {
                get => (float)CellsByName["LocalLightDistanceScale"].Value;
                set => CellsByName["LocalLightDistanceScale"].Value = (float)value;
            }
            

            // Def="u32 fogVolueSizeScaler = 1"
            /// <summary>
            /// Fog Volume Size Scaler (u32)
            /// </summary>
            /// <remarks>
            /// Fog volume size scaler
            /// </remarks>
            public uint FogVolumeSizeScaler 
            {
                get => (uint)CellsByName["FogVolumeSizeScaler"].Value;
                set => CellsByName["FogVolumeSizeScaler"].Value = (uint)value;
            }
            

            // Def="u32 fogVolueSizeDivider = 1"
            /// <summary>
            /// Fog Volume Size Division (u32)
            /// </summary>
            /// <remarks>
            /// Fog volume size division
            /// </remarks>
            public uint FogVolumeSizeDivision 
            {
                get => (uint)CellsByName["FogVolumeSizeDivision"].Value;
                set => CellsByName["FogVolumeSizeDivision"].Value = (uint)value;
            }
            

            // Def="u32 fogVolumeDepthScaler = 1"
            /// <summary>
            /// Fog Volume Depth Slice Scaler (u32)
            /// </summary>
            /// <remarks>
            /// Fog Volume Depth Slice Scaler
            /// </remarks>
            public uint FogVolumeDepthSliceScaler 
            {
                get => (uint)CellsByName["FogVolumeDepthSliceScaler"].Value;
                set => CellsByName["FogVolumeDepthSliceScaler"].Value = (uint)value;
            }
            

            // Def="u32 fogVolumeDepthDivider = 1"
            /// <summary>
            /// Fog Volume Depth Slice Division (u32)
            /// </summary>
            /// <remarks>
            /// Fog volume depth slice division
            /// </remarks>
            public uint FogVolumeDepthSliceDivision 
            {
                get => (uint)CellsByName["FogVolumeDepthSliceDivision"].Value;
                set => CellsByName["FogVolumeDepthSliceDivision"].Value = (uint)value;
            }
            

            // Def="u8 fogVolumeEnabled = 1"
            /// <summary>
            /// Arranged Fog Volume Enabled (u8)
            /// </summary>
            /// <remarks>
            /// Arranged fog volume enabled
            /// </remarks>
            public OnOff ArrangedFogVolumeEnabled 
            {
                get => (OnOff)CellsByName["ArrangedFogVolumeEnabled"].Value;
                set => CellsByName["ArrangedFogVolumeEnabled"].Value = (byte)value;
            }
            

            // Def="u8 fogVolumeUpScaleType = 1"
            /// <summary>
            /// Upscale Type (u8)
            /// </summary>
            /// <remarks>
            /// Method type at the time of upscale
            /// </remarks>
            public GraphicsConfigCsGconfigFogVolumeUpscaleType UpscaleType 
            {
                get => (GraphicsConfigCsGconfigFogVolumeUpscaleType)CellsByName["UpscaleType"].Value;
                set => CellsByName["UpscaleType"].Value = (byte)value;
            }
            

            // Def="u8 fogVolumeEdgeCorrectionLevel = 2"
            /// <summary>
            /// Edge Correction Level (u8)
            /// </summary>
            /// <remarks>
            /// Edge correction level performed only at bilateral (0: invalid, edge redraw permission at 1: 1 / 2x1 / 2 resolution, edge redraw permission with parameter reduction at 2: 1 / 2x1 / 2 + 1x1 resolution, 3 : 1 / 2x1 / 2 + 1x1 resolution edge redraw permission)
            /// </remarks>
            public GraphicsConfigCsGconfigFogVolumeEdgeCorrectionLevel EdgeCorrectionLevel 
            {
                get => (GraphicsConfigCsGconfigFogVolumeEdgeCorrectionLevel)CellsByName["EdgeCorrectionLevel"].Value;
                set => CellsByName["EdgeCorrectionLevel"].Value = (byte)value;
            }
            

            // Def="s8 fogVolumeRayMarcingSampleCountOffset"
            /// <summary>
            /// Ray Sample Count Offset (s8)
            /// </summary>
            /// <remarks>
            /// Offset of sampling number during ray marching
            /// </remarks>
            public sbyte RaySampleCountOffset 
            {
                get => (sbyte)CellsByName["RaySampleCountOffset"].Value;
                set => CellsByName["RaySampleCountOffset"].Value = (sbyte)value;
            }
            

            // Def="u8 fogVolumeShadowEnabled = 1"
            /// <summary>
            /// Fog Volume Shadow Enabled (u8)
            /// </summary>
            /// <remarks>
            /// Shadow permission (refers to shadow processing due to density changes in the area, where shadows are cast on the area)
            /// </remarks>
            public OnOff FogVolumeShadowEnabled 
            {
                get => (OnOff)CellsByName["FogVolumeShadowEnabled"].Value;
                set => CellsByName["FogVolumeShadowEnabled"].Value = (byte)value;
            }
            

            // Def="u8 fogVolumeForceShadowing"
            /// <summary>
            /// Fog Volume - Force Shadowing (u8)
            /// </summary>
            /// <remarks>
            /// Forcibly casts a shadow on the area regardless of the setting when shadow is permitted (shadow processing is not affected)
            /// </remarks>
            public OnOff FogVolumeForceShadowing 
            {
                get => (OnOff)CellsByName["FogVolumeForceShadowing"].Value;
                set => CellsByName["FogVolumeForceShadowing"].Value = (byte)value;
            }
            

            // Def="u8 fogVolumeResolution"
            /// <summary>
            /// Fog Volume Resolution (u8)
            /// </summary>
            /// <remarks>
            /// 
            /// </remarks>
            public GraphicsConfigCsGconfigFogVolumeResolution FogVolumeResolution 
            {
                get => (GraphicsConfigCsGconfigFogVolumeResolution)CellsByName["FogVolumeResolution"].Value;
                set => CellsByName["FogVolumeResolution"].Value = (byte)value;
            }
            

            // Def="dummy8 pad2[1]"
            /// <summary>
            /// pad (dummy8)
            /// </summary>
            /// <remarks>
            /// 
            /// </remarks>
            public object Pad 
            {
                get => (object)CellsByName["Pad"].Value;
                set => CellsByName["Pad"].Value = (object)value;
            }
            
                }
            }
            

namespace StronglyTypedParams
{
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
        public byte FogEnabled
        {
            get => (byte)CellsByName["FogEnabled"].Value;
            set => CellsByName["FogEnabled"].Value = value;
        }


        // Def="u8 fogShadowEnabled = 1"
        /// <summary>
        /// Fog Shadow Enabled (u8)
        /// </summary>
        /// <remarks>
        /// Fog shadow permission
        /// </remarks>
        public byte FogShadowEnabled
        {
            get => (byte)CellsByName["FogShadowEnabled"].Value;
            set => CellsByName["FogShadowEnabled"].Value = value;
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
            set => CellsByName["Dmy"].Value = value;
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
            set => CellsByName["ShadowSampleCountOffset"].Value = value;
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
            set => CellsByName["LocalLightDistanceScale"].Value = value;
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
            set => CellsByName["FogVolumeSizeScaler"].Value = value;
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
            set => CellsByName["FogVolumeSizeDivision"].Value = value;
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
            set => CellsByName["FogVolumeDepthSliceScaler"].Value = value;
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
            set => CellsByName["FogVolumeDepthSliceDivision"].Value = value;
        }


        // Def="u8 fogVolumeEnabled = 1"
        /// <summary>
        /// Arranged Fog Volume Enabled (u8)
        /// </summary>
        /// <remarks>
        /// Arranged fog volume enabled
        /// </remarks>
        public byte ArrangedFogVolumeEnabled
        {
            get => (byte)CellsByName["ArrangedFogVolumeEnabled"].Value;
            set => CellsByName["ArrangedFogVolumeEnabled"].Value = value;
        }


        // Def="u8 fogVolumeUpScaleType = 1"
        /// <summary>
        /// Upscale Type (u8)
        /// </summary>
        /// <remarks>
        /// Method type at the time of upscale
        /// </remarks>
        public byte UpscaleType
        {
            get => (byte)CellsByName["UpscaleType"].Value;
            set => CellsByName["UpscaleType"].Value = value;
        }


        // Def="u8 fogVolumeEdgeCorrectionLevel = 2"
        /// <summary>
        /// Edge Correction Level (u8)
        /// </summary>
        /// <remarks>
        /// Edge correction level performed only at bilateral (0: invalid, edge redraw permission at 1: 1 / 2x1 / 2 resolution, edge redraw permission with parameter reduction at 2: 1 / 2x1 / 2 + 1x1 resolution, 3 : 1 / 2x1 / 2 + 1x1 resolution edge redraw permission)
        /// </remarks>
        public byte EdgeCorrectionLevel
        {
            get => (byte)CellsByName["EdgeCorrectionLevel"].Value;
            set => CellsByName["EdgeCorrectionLevel"].Value = value;
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
            set => CellsByName["RaySampleCountOffset"].Value = value;
        }


        // Def="u8 fogVolumeShadowEnabled = 1"
        /// <summary>
        /// Fog Volume Shadow Enabled (u8)
        /// </summary>
        /// <remarks>
        /// Shadow permission (refers to shadow processing due to density changes in the area, where shadows are cast on the area)
        /// </remarks>
        public byte FogVolumeShadowEnabled
        {
            get => (byte)CellsByName["FogVolumeShadowEnabled"].Value;
            set => CellsByName["FogVolumeShadowEnabled"].Value = value;
        }


        // Def="u8 fogVolumeForceShadowing"
        /// <summary>
        /// Fog Volume - Force Shadowing (u8)
        /// </summary>
        /// <remarks>
        /// Forcibly casts a shadow on the area regardless of the setting when shadow is permitted (shadow processing is not affected)
        /// </remarks>
        public byte FogVolumeForceShadowing
        {
            get => (byte)CellsByName["FogVolumeForceShadowing"].Value;
            set => CellsByName["FogVolumeForceShadowing"].Value = value;
        }


        // Def="u8 fogVolumeResolution"
        /// <summary>
        /// Fog Volume Resolution (u8)
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        public byte FogVolumeResolution
        {
            get => (byte)CellsByName["FogVolumeResolution"].Value;
            set => CellsByName["FogVolumeResolution"].Value = value;
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
            set => CellsByName["Pad"].Value = value;
        }

    }
}

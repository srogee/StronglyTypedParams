
namespace StronglyTypedParams
{
    public class Gconfig_EffectQuality : ParamRow
    {
        public Gconfig_EffectQuality() : base()
        {
        }


        // Def="u8 softParticleEnabled = 1"
        /// <summary>
        /// Soft Particles Enabled (u8)
        /// </summary>
        /// <remarks>
        /// Soft particles Enabled
        /// </remarks>
        public byte SoftParticlesEnabled
        {
            get => (byte)CellsByName["SoftParticlesEnabled"].Value;
            set => CellsByName["SoftParticlesEnabled"].Value = value;
        }


        // Def="u8 glowEnabled = 1"
        /// <summary>
        /// Glow Enabled (u8)
        /// </summary>
        /// <remarks>
        /// Glow effective
        /// </remarks>
        public byte GlowEnabled
        {
            get => (byte)CellsByName["GlowEnabled"].Value;
            set => CellsByName["GlowEnabled"].Value = value;
        }


        // Def="u8 distortionEnable = 1"
        /// <summary>
        /// Distortion Enabled (u8)
        /// </summary>
        /// <remarks>
        /// Distortion effective
        /// </remarks>
        public byte DistortionEnabled
        {
            get => (byte)CellsByName["DistortionEnabled"].Value;
            set => CellsByName["DistortionEnabled"].Value = value;
        }


        // Def="u8 cs_upScaleEnabledType"
        /// <summary>
        /// Enable Bilateral Upscale (u8)
        /// </summary>
        /// <remarks>
        /// Bilateral upscale effective
        /// </remarks>
        public byte EnableBilateralUpscale
        {
            get => (byte)CellsByName["EnableBilateralUpscale"].Value;
            set => CellsByName["EnableBilateralUpscale"].Value = value;
        }


        // Def="f32 fNumOnceEmitsScale = 0.9"
        /// <summary>
        /// Number of Emits in Instance (f32)
        /// </summary>
        /// <remarks>
        /// Number of Emits at one time
        /// </remarks>
        public float NumberOfEmitsInInstance
        {
            get => (float)CellsByName["NumberOfEmitsInInstance"].Value;
            set => CellsByName["NumberOfEmitsInInstance"].Value = value;
        }


        // Def="f32 fEmitSpanScale = 1.1"
        /// <summary>
        /// Emit Interval (f32)
        /// </summary>
        /// <remarks>
        /// Emit interval
        /// </remarks>
        public float EmitInterval
        {
            get => (float)CellsByName["EmitInterval"].Value;
            set => CellsByName["EmitInterval"].Value = value;
        }


        // Def="f32 fLodDistance1Scale = 0.9"
        /// <summary>
        /// 1st LOD Distance Scale (f32)
        /// </summary>
        /// <remarks>
        /// 1st stage LOD distance scale
        /// </remarks>
        public float _1stLODDistanceScale
        {
            get => (float)CellsByName["_1stLODDistanceScale"].Value;
            set => CellsByName["_1stLODDistanceScale"].Value = value;
        }


        // Def="f32 fLodDistance2Scale = 0.9"
        /// <summary>
        /// 2nd LOD Distance Scale (f32)
        /// </summary>
        /// <remarks>
        /// Second stage LOD distance scale
        /// </remarks>
        public float _2ndLODDistanceScale
        {
            get => (float)CellsByName["_2ndLODDistanceScale"].Value;
            set => CellsByName["_2ndLODDistanceScale"].Value = value;
        }


        // Def="f32 fLodDistance3Scale = 0.9"
        /// <summary>
        /// 3rd LOD Distance Scale (f32)
        /// </summary>
        /// <remarks>
        /// 3rd stage LOD distance scale
        /// </remarks>
        public float _3rdLODDistanceScale
        {
            get => (float)CellsByName["_3rdLODDistanceScale"].Value;
            set => CellsByName["_3rdLODDistanceScale"].Value = value;
        }


        // Def="f32 fLodDistance4Scale = 0.9"
        /// <summary>
        /// 4th LOD Distance Scale (f32)
        /// </summary>
        /// <remarks>
        /// 4th stage LOD distance scale
        /// </remarks>
        public float _4thLODDistanceScale
        {
            get => (float)CellsByName["_4thLODDistanceScale"].Value;
            set => CellsByName["_4thLODDistanceScale"].Value = value;
        }


        // Def="f32 fScaleRenderDistanceScale = 1.2"
        /// <summary>
        /// Scale Render Distance Scale (f32)
        /// </summary>
        /// <remarks>
        /// Magnification to the distance registered in the reduction buffer
        /// </remarks>
        public float ScaleRenderDistanceScale
        {
            get => (float)CellsByName["ScaleRenderDistanceScale"].Value;
            set => CellsByName["ScaleRenderDistanceScale"].Value = value;
        }


        // Def="dummy8 dmy[4]"
        /// <summary>
        /// dummy (dummy8)
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        public object Dummy
        {
            get => (object)CellsByName["Dummy"].Value;
            set => CellsByName["Dummy"].Value = value;
        }

    }
}

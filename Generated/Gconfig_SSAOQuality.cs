
namespace StronglyTypedParams
{
    public class Gconfig_SSAOQuality : ParamRow
    {
        public Gconfig_SSAOQuality() : base()
        {
        }


        // Def="u8 enabled = 1"
        /// <summary>
        /// SSAO Enabled (u8)
        /// </summary>
        /// <remarks>
        /// SSAO enabled
        /// </remarks>
        public byte SSAOEnabled
        {
            get => (byte)CellsByName["SSAOEnabled"].Value;
            set => CellsByName["SSAOEnabled"].Value = value;
        }


        // Def="u8 cs_reprojEnabledType = 1"
        /// <summary>
        /// Reprojection Enabled (u8)
        /// </summary>
        /// <remarks>
        /// When reprojection is forcibly enabled, Prevent Ghost is also enabled.
        /// </remarks>
        public byte ReprojectionEnabled
        {
            get => (byte)CellsByName["ReprojectionEnabled"].Value;
            set => CellsByName["ReprojectionEnabled"].Value = value;
        }


        // Def="u8 cs_upScaleEnabledType"
        /// <summary>
        /// Bilateral Upscale Enable Type (u8)
        /// </summary>
        /// <remarks>
        /// Bilateral upscale effective
        /// </remarks>
        public byte BilateralUpscaleEnableType
        {
            get => (byte)CellsByName["BilateralUpscaleEnableType"].Value;
            set => CellsByName["BilateralUpscaleEnableType"].Value = value;
        }


        // Def="u8 cs_useNormalEnabledType = 1"
        /// <summary>
        /// Use Normal Enabled Type (u8)
        /// </summary>
        /// <remarks>
        /// Valid to use normals
        /// </remarks>
        public byte UseNormalEnabledType
        {
            get => (byte)CellsByName["UseNormalEnabledType"].Value;
            set => CellsByName["UseNormalEnabledType"].Value = value;
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

    }
}

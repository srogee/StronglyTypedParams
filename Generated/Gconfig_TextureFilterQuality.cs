
namespace StronglyTypedParams
{
    public class Gconfig_TextureFilterQuality : ParamRow
    {
        public Gconfig_TextureFilterQuality() : base()
        {
        }


        // Def="u8 filter = 3"
        /// <summary>
        /// Texture Filter (u8)
        /// </summary>
        /// <remarks>
        /// filter
        /// </remarks>
        public byte TextureFilter
        {
            get => (byte)CellsByName["TextureFilter"].Value;
            set => CellsByName["TextureFilter"].Value = value;
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


        // Def="u32 maxAnisoLevel = 4"
        /// <summary>
        /// Anisotropic Level (u32)
        /// </summary>
        /// <remarks>
        /// Aniso level
        /// </remarks>
        public uint AnisotropicLevel
        {
            get => (uint)CellsByName["AnisotropicLevel"].Value;
            set => CellsByName["AnisotropicLevel"].Value = value;
        }

    }
}

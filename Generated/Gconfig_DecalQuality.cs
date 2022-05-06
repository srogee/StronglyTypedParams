
namespace StronglyTypedParams
{
    public class Gconfig_DecalQuality : ParamRow
    {
        public Gconfig_DecalQuality() : base()
        {
        }


        // Def="u8 enabled = 1"
        /// <summary>
        /// Decal Enabled (u8)
        /// </summary>
        /// <remarks>
        /// Decal valid
        /// </remarks>
        public byte DecalEnabled
        {
            get => (byte)CellsByName["DecalEnabled"].Value;
            set => CellsByName["DecalEnabled"].Value = value;
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

    }
}

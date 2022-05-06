
namespace StronglyTypedParams
{
    public class Gconfig_ShaderQuality : ParamRow
    {
        public Gconfig_ShaderQuality() : base()
        {
        }


        // Def="u8 sssEnabled = 1"
        /// <summary>
        /// SSS Enabled (u8)
        /// </summary>
        /// <remarks>
        /// SSS enabled
        /// </remarks>
        public byte SSSEnabled
        {
            get => (byte)CellsByName["SSSEnabled"].Value;
            set => CellsByName["SSSEnabled"].Value = value;
        }


        // Def="u8 tessellationEnabled"
        /// <summary>
        /// Tessellation Enabled (u8)
        /// </summary>
        /// <remarks>
        /// Tessellation enabled
        /// </remarks>
        public byte TessellationEnabled
        {
            get => (byte)CellsByName["TessellationEnabled"].Value;
            set => CellsByName["TessellationEnabled"].Value = value;
        }


        // Def="u8 highPrecisionNormalEnabled"
        /// <summary>
        /// High Precision Normal Enabled (u8)
        /// </summary>
        /// <remarks>
        /// High precision normal valid (setting the accuracy of the normal stored in G-Buffer)
        /// </remarks>
        public byte HighPrecisionNormalEnabled
        {
            get => (byte)CellsByName["HighPrecisionNormalEnabled"].Value;
            set => CellsByName["HighPrecisionNormalEnabled"].Value = value;
        }


        // Def="fixstr dmy[1]"
        /// <summary>
        /// dmy (fixstr)
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

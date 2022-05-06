
namespace StronglyTypedParams
{
    public class SeMaterialConvertParam : ParamRow
    {
        public SeMaterialConvertParam() : base()
        {
        }


        // Def="u8 seMaterialId"
        /// <summary>
        /// SE Material ID (u8)
        /// </summary>
        /// <remarks>
        /// Conversion from SFX material ID (3 digits) to SE material ID (2 digits)
        /// </remarks>
        public byte SEMaterialID
        {
            get => (byte)CellsByName["SEMaterialID"].Value;
            set => CellsByName["SEMaterialID"].Value = value;
        }


        // Def="dummy8 pad[3]"
        /// <summary>
        /// Padding (dummy8)
        /// </summary>
        /// <remarks>
        /// Padding
        /// </remarks>
        public object Padding
        {
            get => (object)CellsByName["Padding"].Value;
            set => CellsByName["Padding"].Value = value;
        }

    }
}

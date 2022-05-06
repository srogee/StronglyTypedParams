
namespace StronglyTypedParams
{
    public class WetAspectParam : ParamRow
    {
        public WetAspectParam() : base()
        {
        }


        // Def="u8 baseColorR"
        /// <summary>
        /// Base Color: R (u8)
        /// </summary>
        /// <remarks>
        /// Base color color R.
        /// </remarks>
        public byte BaseColorR
        {
            get => (byte)CellsByName["BaseColorR"].Value;
            set => CellsByName["BaseColorR"].Value = value;
        }


        // Def="u8 baseColorG"
        /// <summary>
        /// Base Color: G (u8)
        /// </summary>
        /// <remarks>
        /// Base color color G.
        /// </remarks>
        public byte BaseColorG
        {
            get => (byte)CellsByName["BaseColorG"].Value;
            set => CellsByName["BaseColorG"].Value = value;
        }


        // Def="u8 baseColorB"
        /// <summary>
        /// Base Color: B (u8)
        /// </summary>
        /// <remarks>
        /// Base color color B.
        /// </remarks>
        public byte BaseColorB
        {
            get => (byte)CellsByName["BaseColorB"].Value;
            set => CellsByName["BaseColorB"].Value = value;
        }


        // Def="dummy8 reserve_0[1]"
        /// <summary>
        /// Spare 1 (dummy8)
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        public object Spare1
        {
            get => (object)CellsByName["Spare1"].Value;
            set => CellsByName["Spare1"].Value = value;
        }


        // Def="f32 baseColorA"
        /// <summary>
        /// Base Color: Alpha (f32)
        /// </summary>
        /// <remarks>
        /// Base color override rate.
        /// </remarks>
        public float BaseColorAlpha
        {
            get => (float)CellsByName["BaseColorAlpha"].Value;
            set => CellsByName["BaseColorAlpha"].Value = value;
        }


        // Def="u8 metallic"
        /// <summary>
        /// Metallic (u8)
        /// </summary>
        /// <remarks>
        /// It's metallic.
        /// </remarks>
        public byte Metallic
        {
            get => (byte)CellsByName["Metallic"].Value;
            set => CellsByName["Metallic"].Value = value;
        }


        // Def="dummy8 reserve_1[1]"
        /// <summary>
        /// Spare 2 (dummy8)
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        public object Spare2
        {
            get => (object)CellsByName["Spare2"].Value;
            set => CellsByName["Spare2"].Value = value;
        }


        // Def="dummy8 reserve_2[1]"
        /// <summary>
        /// Spare 3 (dummy8)
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        public object Spare3
        {
            get => (object)CellsByName["Spare3"].Value;
            set => CellsByName["Spare3"].Value = value;
        }


        // Def="dummy8 reserve_3[1]"
        /// <summary>
        /// Spare 4 (dummy8)
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        public object Spare4
        {
            get => (object)CellsByName["Spare4"].Value;
            set => CellsByName["Spare4"].Value = value;
        }


        // Def="f32 metallicRate"
        /// <summary>
        /// Metallic Override Rate (f32)
        /// </summary>
        /// <remarks>
        /// Metallic override rate.
        /// </remarks>
        public float MetallicOverrideRate
        {
            get => (float)CellsByName["MetallicOverrideRate"].Value;
            set => CellsByName["MetallicOverrideRate"].Value = value;
        }


        // Def="f32 shininessRate"
        /// <summary>
        /// Shininess Override Rate (f32)
        /// </summary>
        /// <remarks>
        /// Shininess override rate.
        /// </remarks>
        public float ShininessOverrideRate
        {
            get => (float)CellsByName["ShininessOverrideRate"].Value;
            set => CellsByName["ShininessOverrideRate"].Value = value;
        }


        // Def="u8 shininess"
        /// <summary>
        /// Shininess (u8)
        /// </summary>
        /// <remarks>
        /// Shininess.
        /// </remarks>
        public byte Shininess
        {
            get => (byte)CellsByName["Shininess"].Value;
            set => CellsByName["Shininess"].Value = value;
        }


        // Def="dummy8 reserve_4[11]"
        /// <summary>
        /// Spare 5 (dummy8)
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        public object Spare5
        {
            get => (object)CellsByName["Spare5"].Value;
            set => CellsByName["Spare5"].Value = value;
        }

    }
}

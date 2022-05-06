
namespace StronglyTypedParams
{
    public class HitEffectSfxConceptParam : ParamRow
    {
        public HitEffectSfxConceptParam() : base()
        {
        }


        // Def="s16 atkIron_1"
        /// <summary>
        /// Iron [1] (s16)
        /// </summary>
        /// <remarks>
        /// Iron: Concept 1
        /// </remarks>
        public short Iron1
        {
            get => (short)CellsByName["Iron1"].Value;
            set => CellsByName["Iron1"].Value = value;
        }


        // Def="s16 atkIron_2"
        /// <summary>
        /// Iron [2] (s16)
        /// </summary>
        /// <remarks>
        /// Iron: Concept 2
        /// </remarks>
        public short Iron2
        {
            get => (short)CellsByName["Iron2"].Value;
            set => CellsByName["Iron2"].Value = value;
        }


        // Def="s16 atkLeather_1"
        /// <summary>
        /// Leather [1] (s16)
        /// </summary>
        /// <remarks>
        /// Leather: Concept 1
        /// </remarks>
        public short Leather1
        {
            get => (short)CellsByName["Leather1"].Value;
            set => CellsByName["Leather1"].Value = value;
        }


        // Def="s16 atkLeather_2"
        /// <summary>
        /// Leather [2] (s16)
        /// </summary>
        /// <remarks>
        /// Leather: Concept 2
        /// </remarks>
        public short Leather2
        {
            get => (short)CellsByName["Leather2"].Value;
            set => CellsByName["Leather2"].Value = value;
        }


        // Def="s16 atkWood_1"
        /// <summary>
        /// Wood [1] (s16)
        /// </summary>
        /// <remarks>
        /// Wooden: Concept 1
        /// </remarks>
        public short Wood1
        {
            get => (short)CellsByName["Wood1"].Value;
            set => CellsByName["Wood1"].Value = value;
        }


        // Def="s16 atkWood_2"
        /// <summary>
        /// Wood [2] (s16)
        /// </summary>
        /// <remarks>
        /// Wooden: Concept 2
        /// </remarks>
        public short Wood2
        {
            get => (short)CellsByName["Wood2"].Value;
            set => CellsByName["Wood2"].Value = value;
        }


        // Def="s16 atkBody_1"
        /// <summary>
        /// Flesh [1] (s16)
        /// </summary>
        /// <remarks>
        /// Meat: Concept 1
        /// </remarks>
        public short Flesh1
        {
            get => (short)CellsByName["Flesh1"].Value;
            set => CellsByName["Flesh1"].Value = value;
        }


        // Def="s16 atkBody_2"
        /// <summary>
        /// Flesh [2] (s16)
        /// </summary>
        /// <remarks>
        /// Meat: Concept 2
        /// </remarks>
        public short Flesh2
        {
            get => (short)CellsByName["Flesh2"].Value;
            set => CellsByName["Flesh2"].Value = value;
        }


        // Def="s16 atkStone_1"
        /// <summary>
        /// Stone [1] (s16)
        /// </summary>
        /// <remarks>
        /// Corrosion: Concept 1
        /// </remarks>
        public short Stone1
        {
            get => (short)CellsByName["Stone1"].Value;
            set => CellsByName["Stone1"].Value = value;
        }


        // Def="s16 atkStone_2"
        /// <summary>
        /// Stone [2] (s16)
        /// </summary>
        /// <remarks>
        /// Corrosion: Concept 2
        /// </remarks>
        public short Stone2
        {
            get => (short)CellsByName["Stone2"].Value;
            set => CellsByName["Stone2"].Value = value;
        }


        // Def="dummy8 pad[4]"
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


        // Def="s16 atkNone_1"
        /// <summary>
        /// None [1] (s16)
        /// </summary>
        /// <remarks>
        /// None: Concept 1
        /// </remarks>
        public short None1
        {
            get => (short)CellsByName["None1"].Value;
            set => CellsByName["None1"].Value = value;
        }


        // Def="s16 atkNone_2"
        /// <summary>
        /// None [2] (s16)
        /// </summary>
        /// <remarks>
        /// None: Concept 2
        /// </remarks>
        public short None2
        {
            get => (short)CellsByName["None2"].Value;
            set => CellsByName["None2"].Value = value;
        }


        // Def="dummy8 reserve[52]"
        /// <summary>
        /// Reserved area (dummy8)
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        public object ReservedArea
        {
            get => (object)CellsByName["ReservedArea"].Value;
            set => CellsByName["ReservedArea"].Value = value;
        }

    }
}

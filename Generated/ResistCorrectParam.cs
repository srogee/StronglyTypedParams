
namespace StronglyTypedParams
{
    public class ResistCorrectParam : ParamRow
    {
        public ResistCorrectParam() : base()
        {
        }


        // Def="f32 addPoint1"
        /// <summary>
        /// Additional Resistance - First Activation (f32)
        /// </summary>
        /// <remarks>
        /// A value that is added to the resistance value after the abnormal condition is activated once.
        /// </remarks>
        public float AdditionalResistanceFirstActivation
        {
            get => (float)CellsByName["AdditionalResistanceFirstActivation"].Value;
            set => CellsByName["AdditionalResistanceFirstActivation"].Value = value;
        }


        // Def="f32 addPoint2"
        /// <summary>
        /// Additional Resistance - Second Activation (f32)
        /// </summary>
        /// <remarks>
        /// A value that is added to the resistance value after the abnormal condition is activated twice.
        /// </remarks>
        public float AdditionalResistanceSecondActivation
        {
            get => (float)CellsByName["AdditionalResistanceSecondActivation"].Value;
            set => CellsByName["AdditionalResistanceSecondActivation"].Value = value;
        }


        // Def="f32 addPoint3"
        /// <summary>
        /// Additional Resistance - Third Activation (f32)
        /// </summary>
        /// <remarks>
        /// A value that is added to the resistance value after the abnormal condition is activated 3 times.
        /// </remarks>
        public float AdditionalResistanceThirdActivation
        {
            get => (float)CellsByName["AdditionalResistanceThirdActivation"].Value;
            set => CellsByName["AdditionalResistanceThirdActivation"].Value = value;
        }


        // Def="f32 addPoint4"
        /// <summary>
        /// Additional Resistance - Fourth Activation (f32)
        /// </summary>
        /// <remarks>
        /// A value that is added to the resistance value after the abnormal condition is activated 4 times.
        /// </remarks>
        public float AdditionalResistanceFourthActivation
        {
            get => (float)CellsByName["AdditionalResistanceFourthActivation"].Value;
            set => CellsByName["AdditionalResistanceFourthActivation"].Value = value;
        }


        // Def="f32 addPoint5"
        /// <summary>
        /// Additional Resistance - Fifth Activation (f32)
        /// </summary>
        /// <remarks>
        /// A value that is added to the resistance value after the abnormal condition is activated 5 times.
        /// </remarks>
        public float AdditionalResistanceFifthActivation
        {
            get => (float)CellsByName["AdditionalResistanceFifthActivation"].Value;
            set => CellsByName["AdditionalResistanceFifthActivation"].Value = value;
        }


        // Def="f32 addRate1 = 1"
        /// <summary>
        /// Resistance Multiplier - First Activation (f32)
        /// </summary>
        /// <remarks>
        /// Magnification applied to the resistance value after the abnormal condition is activated once
        /// </remarks>
        public float ResistanceMultiplierFirstActivation
        {
            get => (float)CellsByName["ResistanceMultiplierFirstActivation"].Value;
            set => CellsByName["ResistanceMultiplierFirstActivation"].Value = value;
        }


        // Def="f32 addRate2 = 1"
        /// <summary>
        /// Resistance Multiplier - Second Activation (f32)
        /// </summary>
        /// <remarks>
        /// Magnification applied to the resistance value after the abnormal condition is activated twice
        /// </remarks>
        public float ResistanceMultiplierSecondActivation
        {
            get => (float)CellsByName["ResistanceMultiplierSecondActivation"].Value;
            set => CellsByName["ResistanceMultiplierSecondActivation"].Value = value;
        }


        // Def="f32 addRate3 = 1"
        /// <summary>
        /// Resistance Multiplier - Third Activation (f32)
        /// </summary>
        /// <remarks>
        /// Magnification applied to the resistance value after the abnormal condition is activated 3 times
        /// </remarks>
        public float ResistanceMultiplierThirdActivation
        {
            get => (float)CellsByName["ResistanceMultiplierThirdActivation"].Value;
            set => CellsByName["ResistanceMultiplierThirdActivation"].Value = value;
        }


        // Def="f32 addRate4 = 1"
        /// <summary>
        /// Resistance Multiplier - Fourth Activation (f32)
        /// </summary>
        /// <remarks>
        /// Magnification applied to the resistance value after the abnormal condition is activated 4 times
        /// </remarks>
        public float ResistanceMultiplierFourthActivation
        {
            get => (float)CellsByName["ResistanceMultiplierFourthActivation"].Value;
            set => CellsByName["ResistanceMultiplierFourthActivation"].Value = value;
        }


        // Def="f32 addRate5 = 1"
        /// <summary>
        /// Resistance Multiplier - Fifth Activation (f32)
        /// </summary>
        /// <remarks>
        /// Magnification applied to the resistance value after the abnormal condition is activated 5 times
        /// </remarks>
        public float ResistanceMultiplierFifthActivation
        {
            get => (float)CellsByName["ResistanceMultiplierFifthActivation"].Value;
            set => CellsByName["ResistanceMultiplierFifthActivation"].Value = value;
        }

    }
}

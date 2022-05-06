
namespace StronglyTypedParams
{
    public class ReinforceParamProtector : ParamRow
    {
        public ReinforceParamProtector() : base()
        {
        }


        // Def="f32 physicsDefRate = 1"
        /// <summary>
        /// Defence %: Physical (f32)
        /// </summary>
        /// <remarks>
        /// Physical defense correction value
        /// </remarks>
        public float DefencePercentPhysical
        {
            get => (float)CellsByName["DefencePercentPhysical"].Value;
            set => CellsByName["DefencePercentPhysical"].Value = value;
        }


        // Def="f32 magicDefRate = 1"
        /// <summary>
        /// Defence %: Magic (f32)
        /// </summary>
        /// <remarks>
        /// Magic defense correction value
        /// </remarks>
        public float DefencePercentMagic
        {
            get => (float)CellsByName["DefencePercentMagic"].Value;
            set => CellsByName["DefencePercentMagic"].Value = value;
        }


        // Def="f32 fireDefRate = 1"
        /// <summary>
        /// Defence %: Fire (f32)
        /// </summary>
        /// <remarks>
        /// Fire defense correction value
        /// </remarks>
        public float DefencePercentFire
        {
            get => (float)CellsByName["DefencePercentFire"].Value;
            set => CellsByName["DefencePercentFire"].Value = value;
        }


        // Def="f32 thunderDefRate = 1"
        /// <summary>
        /// Defence %: Lightning (f32)
        /// </summary>
        /// <remarks>
        /// Electric shock defense correction value
        /// </remarks>
        public float DefencePercentLightning
        {
            get => (float)CellsByName["DefencePercentLightning"].Value;
            set => CellsByName["DefencePercentLightning"].Value = value;
        }


        // Def="f32 slashDefRate = 1"
        /// <summary>
        /// Defence %: Slash (f32)
        /// </summary>
        /// <remarks>
        /// Slash defense correction value
        /// </remarks>
        public float DefencePercentSlash
        {
            get => (float)CellsByName["DefencePercentSlash"].Value;
            set => CellsByName["DefencePercentSlash"].Value = value;
        }


        // Def="f32 blowDefRate = 1"
        /// <summary>
        /// Defence %: Strike (f32)
        /// </summary>
        /// <remarks>
        /// Impact defense correction value
        /// </remarks>
        public float DefencePercentStrike
        {
            get => (float)CellsByName["DefencePercentStrike"].Value;
            set => CellsByName["DefencePercentStrike"].Value = value;
        }


        // Def="f32 thrustDefRate = 1"
        /// <summary>
        /// Defence %: Thrust (f32)
        /// </summary>
        /// <remarks>
        /// Correction value of piercing defense power
        /// </remarks>
        public float DefencePercentThrust
        {
            get => (float)CellsByName["DefencePercentThrust"].Value;
            set => CellsByName["DefencePercentThrust"].Value = value;
        }


        // Def="f32 resistPoisonRate = 1"
        /// <summary>
        /// Aux Resist %: Poison (f32)
        /// </summary>
        /// <remarks>
        /// Poison resistance correction value
        /// </remarks>
        public float AuxResistPercentPoison
        {
            get => (float)CellsByName["AuxResistPercentPoison"].Value;
            set => CellsByName["AuxResistPercentPoison"].Value = value;
        }


        // Def="f32 resistDiseaseRate = 1"
        /// <summary>
        /// Aux Resist %: Scarlet Rot (f32)
        /// </summary>
        /// <remarks>
        /// Epidemic resistance correction value
        /// </remarks>
        public float AuxResistPercentScarletRot
        {
            get => (float)CellsByName["AuxResistPercentScarletRot"].Value;
            set => CellsByName["AuxResistPercentScarletRot"].Value = value;
        }


        // Def="f32 resistBloodRate = 1"
        /// <summary>
        /// Aux Resist %: Hemorrhage (f32)
        /// </summary>
        /// <remarks>
        /// Bleeding resistance correction value
        /// </remarks>
        public float AuxResistPercentHemorrhage
        {
            get => (float)CellsByName["AuxResistPercentHemorrhage"].Value;
            set => CellsByName["AuxResistPercentHemorrhage"].Value = value;
        }


        // Def="f32 resistCurseRate = 1"
        /// <summary>
        /// Aux Resist %: Blight (f32)
        /// </summary>
        /// <remarks>
        /// Curse resistance correction value
        /// </remarks>
        public float AuxResistPercentBlight
        {
            get => (float)CellsByName["AuxResistPercentBlight"].Value;
            set => CellsByName["AuxResistPercentBlight"].Value = value;
        }


        // Def="u8 residentSpEffectId1"
        /// <summary>
        /// Passive SpEffect ID [1] Offset (u8)
        /// </summary>
        /// <remarks>
        /// Addition correction value for resident special effect ID1
        /// </remarks>
        public byte PassiveSpEffectID1Offset
        {
            get => (byte)CellsByName["PassiveSpEffectID1Offset"].Value;
            set => CellsByName["PassiveSpEffectID1Offset"].Value = value;
        }


        // Def="u8 residentSpEffectId2"
        /// <summary>
        /// Passive SpEffect ID [2] Offset (u8)
        /// </summary>
        /// <remarks>
        /// Addition correction value for resident special effect ID2
        /// </remarks>
        public byte PassiveSpEffectID2Offset
        {
            get => (byte)CellsByName["PassiveSpEffectID2Offset"].Value;
            set => CellsByName["PassiveSpEffectID2Offset"].Value = value;
        }


        // Def="u8 residentSpEffectId3"
        /// <summary>
        /// Passive SpEffect ID [3] Offset (u8)
        /// </summary>
        /// <remarks>
        /// Addition correction value for resident special effect ID3
        /// </remarks>
        public byte PassiveSpEffectID3Offset
        {
            get => (byte)CellsByName["PassiveSpEffectID3Offset"].Value;
            set => CellsByName["PassiveSpEffectID3Offset"].Value = value;
        }


        // Def="u8 materialSetId"
        /// <summary>
        /// Reinforcement Material Set ID (u8)
        /// </summary>
        /// <remarks>
        /// Addition correction value of material parameter ID
        /// </remarks>
        public byte ReinforcementMaterialSetID
        {
            get => (byte)CellsByName["ReinforcementMaterialSetID"].Value;
            set => CellsByName["ReinforcementMaterialSetID"].Value = value;
        }


        // Def="f32 darkDefRate = 1"
        /// <summary>
        /// Absorption %: Holy (f32)
        /// </summary>
        /// <remarks>
        /// Dark defense correction value
        /// </remarks>
        public float AbsorptionPercentHoly
        {
            get => (float)CellsByName["AbsorptionPercentHoly"].Value;
            set => CellsByName["AbsorptionPercentHoly"].Value = value;
        }


        // Def="f32 resistFreezeRate = 1"
        /// <summary>
        /// Aux Resist %: Frost (f32)
        /// </summary>
        /// <remarks>
        /// Cold resistance correction value
        /// </remarks>
        public float AuxResistPercentFrost
        {
            get => (float)CellsByName["AuxResistPercentFrost"].Value;
            set => CellsByName["AuxResistPercentFrost"].Value = value;
        }


        // Def="f32 resistSleepRate = 1"
        /// <summary>
        /// Aux Resist %: Sleep (f32)
        /// </summary>
        /// <remarks>
        /// Correction value for sleep tolerance
        /// </remarks>
        public float AuxResistPercentSleep
        {
            get => (float)CellsByName["AuxResistPercentSleep"].Value;
            set => CellsByName["AuxResistPercentSleep"].Value = value;
        }


        // Def="f32 resistMadnessRate = 1"
        /// <summary>
        /// Aux Resist %: Madness (f32)
        /// </summary>
        /// <remarks>
        /// Madness resistance correction value
        /// </remarks>
        public float AuxResistPercentMadness
        {
            get => (float)CellsByName["AuxResistPercentMadness"].Value;
            set => CellsByName["AuxResistPercentMadness"].Value = value;
        }

    }
}

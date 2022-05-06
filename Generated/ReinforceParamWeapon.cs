
namespace StronglyTypedParams
{
    public class ReinforceParamWeapon : ParamRow
    {
        public ReinforceParamWeapon() : base()
        {
        }


        // Def="f32 physicsAtkRate = 1"
        /// <summary>
        /// Damage %: Physical (f32)
        /// </summary>
        /// <remarks>
        /// Physical attack power correction value
        /// </remarks>
        public float DamagePercentPhysical
        {
            get => (float)CellsByName["DamagePercentPhysical"].Value;
            set => CellsByName["DamagePercentPhysical"].Value = value;
        }


        // Def="f32 magicAtkRate = 1"
        /// <summary>
        /// Damage %: Magic (f32)
        /// </summary>
        /// <remarks>
        /// Magic attack power correction value
        /// </remarks>
        public float DamagePercentMagic
        {
            get => (float)CellsByName["DamagePercentMagic"].Value;
            set => CellsByName["DamagePercentMagic"].Value = value;
        }


        // Def="f32 fireAtkRate = 1"
        /// <summary>
        /// Damage %: Fire (f32)
        /// </summary>
        /// <remarks>
        /// Fire attack power correction value
        /// </remarks>
        public float DamagePercentFire
        {
            get => (float)CellsByName["DamagePercentFire"].Value;
            set => CellsByName["DamagePercentFire"].Value = value;
        }


        // Def="f32 thunderAtkRate = 1"
        /// <summary>
        /// Damage %: Lightning (f32)
        /// </summary>
        /// <remarks>
        /// Correction value of electric shock attack power
        /// </remarks>
        public float DamagePercentLightning
        {
            get => (float)CellsByName["DamagePercentLightning"].Value;
            set => CellsByName["DamagePercentLightning"].Value = value;
        }


        // Def="f32 staminaAtkRate = 1"
        /// <summary>
        /// Damage %: Stamina (f32)
        /// </summary>
        /// <remarks>
        /// Stamina attack power correction value
        /// </remarks>
        public float DamagePercentStamina
        {
            get => (float)CellsByName["DamagePercentStamina"].Value;
            set => CellsByName["DamagePercentStamina"].Value = value;
        }


        // Def="f32 saWeaponAtkRate = 1"
        /// <summary>
        /// Damage %: Poise (f32)
        /// </summary>
        /// <remarks>
        /// Super Armor Weapon Attack Color Correction Value
        /// </remarks>
        public float DamagePercentPoise
        {
            get => (float)CellsByName["DamagePercentPoise"].Value;
            set => CellsByName["DamagePercentPoise"].Value = value;
        }


        // Def="f32 saDurabilityRate = 1"
        /// <summary>
        /// Poise Durability (f32)
        /// </summary>
        /// <remarks>
        /// SA endurance correction value
        /// </remarks>
        public float PoiseDurability
        {
            get => (float)CellsByName["PoiseDurability"].Value;
            set => CellsByName["PoiseDurability"].Value = value;
        }


        // Def="f32 correctStrengthRate = 1"
        /// <summary>
        /// Correction %: STR (f32)
        /// </summary>
        /// <remarks>
        /// Correction value of muscle strength correction
        /// </remarks>
        public float CorrectionPercentSTR
        {
            get => (float)CellsByName["CorrectionPercentSTR"].Value;
            set => CellsByName["CorrectionPercentSTR"].Value = value;
        }


        // Def="f32 correctAgilityRate = 1"
        /// <summary>
        /// Correction %: DEX (f32)
        /// </summary>
        /// <remarks>
        /// Correction value of agility correction
        /// </remarks>
        public float CorrectionPercentDEX
        {
            get => (float)CellsByName["CorrectionPercentDEX"].Value;
            set => CellsByName["CorrectionPercentDEX"].Value = value;
        }


        // Def="f32 correctMagicRate = 1"
        /// <summary>
        /// Correction %: INT (f32)
        /// </summary>
        /// <remarks>
        /// Correction value of magic power correction
        /// </remarks>
        public float CorrectionPercentINT
        {
            get => (float)CellsByName["CorrectionPercentINT"].Value;
            set => CellsByName["CorrectionPercentINT"].Value = value;
        }


        // Def="f32 correctFaithRate = 1"
        /// <summary>
        /// Correction %: FTH (f32)
        /// </summary>
        /// <remarks>
        /// Correction value of faith correction
        /// </remarks>
        public float CorrectionPercentFTH
        {
            get => (float)CellsByName["CorrectionPercentFTH"].Value;
            set => CellsByName["CorrectionPercentFTH"].Value = value;
        }


        // Def="f32 physicsGuardCutRate = 1"
        /// <summary>
        /// Guard Absorption %: Physical (f32)
        /// </summary>
        /// <remarks>
        /// Correction value of physical attack cut rate when guarding
        /// </remarks>
        public float GuardAbsorptionPercentPhysical
        {
            get => (float)CellsByName["GuardAbsorptionPercentPhysical"].Value;
            set => CellsByName["GuardAbsorptionPercentPhysical"].Value = value;
        }


        // Def="f32 magicGuardCutRate = 1"
        /// <summary>
        /// Guard Absorption %: Magic (f32)
        /// </summary>
        /// <remarks>
        /// Correction value of magic attack cut rate when guarding
        /// </remarks>
        public float GuardAbsorptionPercentMagic
        {
            get => (float)CellsByName["GuardAbsorptionPercentMagic"].Value;
            set => CellsByName["GuardAbsorptionPercentMagic"].Value = value;
        }


        // Def="f32 fireGuardCutRate = 1"
        /// <summary>
        /// Guard Absorption %: Fire (f32)
        /// </summary>
        /// <remarks>
        /// Correction value of flame attack cut rate when guarding
        /// </remarks>
        public float GuardAbsorptionPercentFire
        {
            get => (float)CellsByName["GuardAbsorptionPercentFire"].Value;
            set => CellsByName["GuardAbsorptionPercentFire"].Value = value;
        }


        // Def="f32 thunderGuardCutRate = 1"
        /// <summary>
        /// Guard Absorption %: Lightning (f32)
        /// </summary>
        /// <remarks>
        /// Correction value of electric shock attack cut rate when guarding
        /// </remarks>
        public float GuardAbsorptionPercentLightning
        {
            get => (float)CellsByName["GuardAbsorptionPercentLightning"].Value;
            set => CellsByName["GuardAbsorptionPercentLightning"].Value = value;
        }


        // Def="f32 poisonGuardResistRate = 1"
        /// <summary>
        /// Guard Absorption %: Poison (f32)
        /// </summary>
        /// <remarks>
        /// Correction value of poison attack cut rate when guarding
        /// </remarks>
        public float GuardAbsorptionPercentPoison
        {
            get => (float)CellsByName["GuardAbsorptionPercentPoison"].Value;
            set => CellsByName["GuardAbsorptionPercentPoison"].Value = value;
        }


        // Def="f32 diseaseGuardResistRate = 1"
        /// <summary>
        /// Guard Absorption %: Scarlet Rot (f32)
        /// </summary>
        /// <remarks>
        /// Correction value of plague attack cut rate when guarding
        /// </remarks>
        public float GuardAbsorptionPercentScarletRot
        {
            get => (float)CellsByName["GuardAbsorptionPercentScarletRot"].Value;
            set => CellsByName["GuardAbsorptionPercentScarletRot"].Value = value;
        }


        // Def="f32 bloodGuardResistRate = 1"
        /// <summary>
        /// Guard Absorption %: Hemorrhage (f32)
        /// </summary>
        /// <remarks>
        /// Correction value for bleeding attack cut rate when guarding
        /// </remarks>
        public float GuardAbsorptionPercentHemorrhage
        {
            get => (float)CellsByName["GuardAbsorptionPercentHemorrhage"].Value;
            set => CellsByName["GuardAbsorptionPercentHemorrhage"].Value = value;
        }


        // Def="f32 curseGuardResistRate = 1"
        /// <summary>
        /// Guard Absorption %: Blight (f32)
        /// </summary>
        /// <remarks>
        /// Correction value of curse attack cut rate when guarding
        /// </remarks>
        public float GuardAbsorptionPercentBlight
        {
            get => (float)CellsByName["GuardAbsorptionPercentBlight"].Value;
            set => CellsByName["GuardAbsorptionPercentBlight"].Value = value;
        }


        // Def="f32 staminaGuardDefRate = 1"
        /// <summary>
        /// Guard Absorption %: Stability (f32)
        /// </summary>
        /// <remarks>
        /// Correction value of stamina defense power when guarding
        /// </remarks>
        public float GuardAbsorptionPercentStability
        {
            get => (float)CellsByName["GuardAbsorptionPercentStability"].Value;
            set => CellsByName["GuardAbsorptionPercentStability"].Value = value;
        }


        // Def="u8 spEffectId1"
        /// <summary>
        /// Behavior SpEffect [1] Offset (u8)
        /// </summary>
        /// <remarks>
        /// Addition correction value for special effect ID1
        /// </remarks>
        public byte BehaviorSpEffect1Offset
        {
            get => (byte)CellsByName["BehaviorSpEffect1Offset"].Value;
            set => CellsByName["BehaviorSpEffect1Offset"].Value = value;
        }


        // Def="u8 spEffectId2"
        /// <summary>
        /// Behavior SpEffect [2] Offset (u8)
        /// </summary>
        /// <remarks>
        /// Addition correction value for special effect ID2
        /// </remarks>
        public byte BehaviorSpEffect2Offset
        {
            get => (byte)CellsByName["BehaviorSpEffect2Offset"].Value;
            set => CellsByName["BehaviorSpEffect2Offset"].Value = value;
        }


        // Def="u8 spEffectId3"
        /// <summary>
        /// Behavior SpEffect [3] Offset (u8)
        /// </summary>
        /// <remarks>
        /// Addition correction value for special effect ID3
        /// </remarks>
        public byte BehaviorSpEffect3Offset
        {
            get => (byte)CellsByName["BehaviorSpEffect3Offset"].Value;
            set => CellsByName["BehaviorSpEffect3Offset"].Value = value;
        }


        // Def="u8 residentSpEffectId1"
        /// <summary>
        /// Passive SpEffect [1] Offset (u8)
        /// </summary>
        /// <remarks>
        /// Addition correction value for resident special effect ID1
        /// </remarks>
        public byte PassiveSpEffect1Offset
        {
            get => (byte)CellsByName["PassiveSpEffect1Offset"].Value;
            set => CellsByName["PassiveSpEffect1Offset"].Value = value;
        }


        // Def="u8 residentSpEffectId2"
        /// <summary>
        /// Passive SpEffect [2] Offset (u8)
        /// </summary>
        /// <remarks>
        /// Addition correction value for resident special effect ID2
        /// </remarks>
        public byte PassiveSpEffect2Offset
        {
            get => (byte)CellsByName["PassiveSpEffect2Offset"].Value;
            set => CellsByName["PassiveSpEffect2Offset"].Value = value;
        }


        // Def="u8 residentSpEffectId3"
        /// <summary>
        /// Passive SpEffect [3] Offset (u8)
        /// </summary>
        /// <remarks>
        /// Addition correction value for resident special effect ID3
        /// </remarks>
        public byte PassiveSpEffect3Offset
        {
            get => (byte)CellsByName["PassiveSpEffect3Offset"].Value;
            set => CellsByName["PassiveSpEffect3Offset"].Value = value;
        }


        // Def="u8 materialSetId"
        /// <summary>
        /// Reinforcement Material Set Offset (u8)
        /// </summary>
        /// <remarks>
        /// Addition correction value of material parameter ID
        /// </remarks>
        public byte ReinforcementMaterialSetOffset
        {
            get => (byte)CellsByName["ReinforcementMaterialSetOffset"].Value;
            set => CellsByName["ReinforcementMaterialSetOffset"].Value = value;
        }


        // Def="u8 maxReinforceLevel"
        /// <summary>
        /// Max Reinforcement Level (u8)
        /// </summary>
        /// <remarks>
        /// Level value for maximum enhanced weapon level
        /// </remarks>
        public byte MaxReinforcementLevel
        {
            get => (byte)CellsByName["MaxReinforcementLevel"].Value;
            set => CellsByName["MaxReinforcementLevel"].Value = value;
        }


        // Def="f32 darkAtkRate = 1"
        /// <summary>
        /// Damage %: Holy (f32)
        /// </summary>
        /// <remarks>
        /// Dark attack power correction value
        /// </remarks>
        public float DamagePercentHoly
        {
            get => (float)CellsByName["DamagePercentHoly"].Value;
            set => CellsByName["DamagePercentHoly"].Value = value;
        }


        // Def="f32 darkGuardCutRate = 1"
        /// <summary>
        /// Guard Absorption %: Holy (f32)
        /// </summary>
        /// <remarks>
        /// Correction value of darkness attack cut rate when guarding
        /// </remarks>
        public float GuardAbsorptionPercentHoly
        {
            get => (float)CellsByName["GuardAbsorptionPercentHoly"].Value;
            set => CellsByName["GuardAbsorptionPercentHoly"].Value = value;
        }


        // Def="f32 correctLuckRate = 1"
        /// <summary>
        /// Correction %: ARC (f32)
        /// </summary>
        /// <remarks>
        /// Correction value of luck correction
        /// </remarks>
        public float CorrectionPercentARC
        {
            get => (float)CellsByName["CorrectionPercentARC"].Value;
            set => CellsByName["CorrectionPercentARC"].Value = value;
        }


        // Def="f32 freezeGuardDefRate = 1"
        /// <summary>
        /// Guard Absorption %: Frostbite (f32)
        /// </summary>
        /// <remarks>
        /// Correction value of cold air attack cut rate when guarding
        /// </remarks>
        public float GuardAbsorptionPercentFrostbite
        {
            get => (float)CellsByName["GuardAbsorptionPercentFrostbite"].Value;
            set => CellsByName["GuardAbsorptionPercentFrostbite"].Value = value;
        }


        // Def="f32 reinforcePriceRate = 1"
        /// <summary>
        /// Reinforce Price Rate (f32)
        /// </summary>
        /// <remarks>
        /// Correction value to multiply the enhancement price of the weapon parameter
        /// </remarks>
        public float ReinforcePriceRate
        {
            get => (float)CellsByName["ReinforcePriceRate"].Value;
            set => CellsByName["ReinforcePriceRate"].Value = value;
        }


        // Def="f32 baseChangePriceRate = 1"
        /// <summary>
        /// Base Change Price Rate (f32)
        /// </summary>
        /// <remarks>
        /// Correction value to multiply the evolution price of the weapon parameter
        /// </remarks>
        public float BaseChangePriceRate
        {
            get => (float)CellsByName["BaseChangePriceRate"].Value;
            set => CellsByName["BaseChangePriceRate"].Value = value;
        }


        // Def="s8 enableGemRank"
        /// <summary>
        /// Ash of War Rank (s8)
        /// </summary>
        /// <remarks>
        /// Mountable magic stone rank
        /// </remarks>
        public sbyte AshOfWarRank
        {
            get => (sbyte)CellsByName["AshOfWarRank"].Value;
            set => CellsByName["AshOfWarRank"].Value = value;
        }


        // Def="dummy8 pad2[3]"
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


        // Def="f32 sleepGuardDefRate = 1"
        /// <summary>
        /// Guard Absorption %: Sleep (f32)
        /// </summary>
        /// <remarks>
        /// Correction value of sleep attack cut rate when guarding
        /// </remarks>
        public float GuardAbsorptionPercentSleep
        {
            get => (float)CellsByName["GuardAbsorptionPercentSleep"].Value;
            set => CellsByName["GuardAbsorptionPercentSleep"].Value = value;
        }


        // Def="f32 madnessGuardDefRate = 1"
        /// <summary>
        /// Guard Absorption %: Madness (f32)
        /// </summary>
        /// <remarks>
        /// Correction value of mad attack cut rate when guarding
        /// </remarks>
        public float GuardAbsorptionPercentMadness
        {
            get => (float)CellsByName["GuardAbsorptionPercentMadness"].Value;
            set => CellsByName["GuardAbsorptionPercentMadness"].Value = value;
        }


        // Def="f32 baseAtkRate = 1"
        /// <summary>
        /// Base Damage %: Overall (f32)
        /// </summary>
        /// <remarks>
        /// Additional attack power multiplier
        /// </remarks>
        public float BaseDamagePercentOverall
        {
            get => (float)CellsByName["BaseDamagePercentOverall"].Value;
            set => CellsByName["BaseDamagePercentOverall"].Value = value;
        }

    }
}

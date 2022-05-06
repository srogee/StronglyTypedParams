
namespace StronglyTypedParams
{
    public class EquipParamProtector : ParamRow
    {
        public EquipParamProtector() : base()
        {
        }


        // Def="u8 disableParam_NT:1"
        /// <summary>
        /// Disable Param - Network Test (u8)
        /// </summary>
        /// <remarks>
        /// Parameters marked with ○ are excluded in the NT version package.
        /// </remarks>
        public byte DisableParamNetworkTest
        {
            get => (byte)CellsByName["DisableParamNetworkTest"].Value;
            set => CellsByName["DisableParamNetworkTest"].Value = value;
        }


        // Def="dummy8 disableParamReserve1:7"
        /// <summary>
        /// Reserve for package output 1 (dummy8)
        /// </summary>
        /// <remarks>
        /// Reserve for package output 1
        /// </remarks>
        public object ReserveForPackageOutput1
        {
            get => (object)CellsByName["ReserveForPackageOutput1"].Value;
            set => CellsByName["ReserveForPackageOutput1"].Value = value;
        }


        // Def="dummy8 disableParamReserve2[3]"
        /// <summary>
        /// Reserve for package output 2 (dummy8)
        /// </summary>
        /// <remarks>
        /// Reserve for package output 2
        /// </remarks>
        public object ReserveForPackageOutput2
        {
            get => (object)CellsByName["ReserveForPackageOutput2"].Value;
            set => CellsByName["ReserveForPackageOutput2"].Value = value;
        }


        // Def="s32 sortId"
        /// <summary>
        /// Sort ID (s32)
        /// </summary>
        /// <remarks>
        /// Sort ID (7 digits is the limit for s32 because the enhancement level is added in the program)
        /// </remarks>
        public int SortID
        {
            get => (int)CellsByName["SortID"].Value;
            set => CellsByName["SortID"].Value = value;
        }


        // Def="u32 wanderingEquipId"
        /// <summary>
        /// Wandering Equip ID (u32)
        /// </summary>
        /// <remarks>
        /// Replacement equipment ID for wandering ghosts.
        /// </remarks>
        public uint WanderingEquipID
        {
            get => (uint)CellsByName["WanderingEquipID"].Value;
            set => CellsByName["WanderingEquipID"].Value = value;
        }


        // Def="u16 resistSleep"
        /// <summary>
        /// Resist - Sleep (u16)
        /// </summary>
        /// <remarks>
        /// Difficulty in getting sleep abnormalities
        /// </remarks>
        public ushort ResistSleep
        {
            get => (ushort)CellsByName["ResistSleep"].Value;
            set => CellsByName["ResistSleep"].Value = value;
        }


        // Def="u16 resistMadness"
        /// <summary>
        /// Resist - Madness (u16)
        /// </summary>
        /// <remarks>
        /// Difficulty in getting mad
        /// </remarks>
        public ushort ResistMadness
        {
            get => (ushort)CellsByName["ResistMadness"].Value;
            set => CellsByName["ResistMadness"].Value = value;
        }


        // Def="f32 saDurability"
        /// <summary>
        /// Poise Durability (f32)
        /// </summary>
        /// <remarks>
        /// Super armor endurance
        /// </remarks>
        public float PoiseDurability
        {
            get => (float)CellsByName["PoiseDurability"].Value;
            set => CellsByName["PoiseDurability"].Value = value;
        }


        // Def="f32 toughnessCorrectRate"
        /// <summary>
        /// Toughness Correction (f32)
        /// </summary>
        /// <remarks>
        /// It is a magnification that corrects the basic value of toughness.
        /// </remarks>
        public float ToughnessCorrection
        {
            get => (float)CellsByName["ToughnessCorrection"].Value;
            set => CellsByName["ToughnessCorrection"].Value = value;
        }


        // Def="s32 fixPrice"
        /// <summary>
        /// Repair Price (s32)
        /// </summary>
        /// <remarks>
        /// Basic repair price
        /// </remarks>
        public int RepairPrice
        {
            get => (int)CellsByName["RepairPrice"].Value;
            set => CellsByName["RepairPrice"].Value = value;
        }


        // Def="s32 basicPrice"
        /// <summary>
        /// Basic Price (s32)
        /// </summary>
        /// <remarks>
        /// Basic price
        /// </remarks>
        public int BasicPrice
        {
            get => (int)CellsByName["BasicPrice"].Value;
            set => CellsByName["BasicPrice"].Value = value;
        }


        // Def="s32 sellValue"
        /// <summary>
        /// Sell Value (s32)
        /// </summary>
        /// <remarks>
        /// Selling price
        /// </remarks>
        public int SellValue
        {
            get => (int)CellsByName["SellValue"].Value;
            set => CellsByName["SellValue"].Value = value;
        }


        // Def="f32 weight = 1"
        /// <summary>
        /// Weight (f32)
        /// </summary>
        /// <remarks>
        /// Weight [kg].
        /// </remarks>
        public float Weight
        {
            get => (float)CellsByName["Weight"].Value;
            set => CellsByName["Weight"].Value = value;
        }


        // Def="s32 residentSpEffectId"
        /// <summary>
        /// Resident SpEffect ID [1] (s32)
        /// </summary>
        /// <remarks>
        /// Resident special effect ID1
        /// </remarks>
        public int ResidentSpEffectID1
        {
            get => (int)CellsByName["ResidentSpEffectID1"].Value;
            set => CellsByName["ResidentSpEffectID1"].Value = value;
        }


        // Def="s32 residentSpEffectId2"
        /// <summary>
        /// Resident SpEffect ID [2] (s32)
        /// </summary>
        /// <remarks>
        /// Resident special effect ID2
        /// </remarks>
        public int ResidentSpEffectID2
        {
            get => (int)CellsByName["ResidentSpEffectID2"].Value;
            set => CellsByName["ResidentSpEffectID2"].Value = value;
        }


        // Def="s32 residentSpEffectId3"
        /// <summary>
        /// Resident SpEffect ID [3] (s32)
        /// </summary>
        /// <remarks>
        /// Resident special effect ID3
        /// </remarks>
        public int ResidentSpEffectID3
        {
            get => (int)CellsByName["ResidentSpEffectID3"].Value;
            set => CellsByName["ResidentSpEffectID3"].Value = value;
        }


        // Def="s32 materialSetId = -1"
        /// <summary>
        /// Upgrade Material ID (s32)
        /// </summary>
        /// <remarks>
        /// Material parameter ID required for weapon enhancement
        /// </remarks>
        public int UpgradeMaterialID
        {
            get => (int)CellsByName["UpgradeMaterialID"].Value;
            set => CellsByName["UpgradeMaterialID"].Value = value;
        }


        // Def="f32 partsDamageRate = 1"
        /// <summary>
        /// Weak Parts Damage % (f32)
        /// </summary>
        /// <remarks>
        /// Part damage rate
        /// </remarks>
        public float WeakPartsDamagePercent
        {
            get => (float)CellsByName["WeakPartsDamagePercent"].Value;
            set => CellsByName["WeakPartsDamagePercent"].Value = value;
        }


        // Def="f32 corectSARecover"
        /// <summary>
        /// Poise Recovery Correction (f32)
        /// </summary>
        /// <remarks>
        /// Super Armor Recovery Time Correction Value
        /// </remarks>
        public float PoiseRecoveryCorrection
        {
            get => (float)CellsByName["PoiseRecoveryCorrection"].Value;
            set => CellsByName["PoiseRecoveryCorrection"].Value = value;
        }


        // Def="s32 originEquipPro = -1"
        /// <summary>
        /// Origin Armor +0 (s32)
        /// </summary>
        /// <remarks>
        /// Strengthening of this armor Original armor ID
        /// </remarks>
        public int OriginArmor0
        {
            get => (int)CellsByName["OriginArmor0"].Value;
            set => CellsByName["OriginArmor0"].Value = value;
        }


        // Def="s32 originEquipPro1 = -1"
        /// <summary>
        /// Origin Armor +1 (s32)
        /// </summary>
        /// <remarks>
        /// Strengthening this armor Original armor ID1
        /// </remarks>
        public int OriginArmor1
        {
            get => (int)CellsByName["OriginArmor1"].Value;
            set => CellsByName["OriginArmor1"].Value = value;
        }


        // Def="s32 originEquipPro2 = -1"
        /// <summary>
        /// Origin Armor +2 (s32)
        /// </summary>
        /// <remarks>
        /// Strengthening this armor Original armor ID2
        /// </remarks>
        public int OriginArmor2
        {
            get => (int)CellsByName["OriginArmor2"].Value;
            set => CellsByName["OriginArmor2"].Value = value;
        }


        // Def="s32 originEquipPro3 = -1"
        /// <summary>
        /// Origin Armor +3 (s32)
        /// </summary>
        /// <remarks>
        /// Strengthening this armor Original armor ID3
        /// </remarks>
        public int OriginArmor3
        {
            get => (int)CellsByName["OriginArmor3"].Value;
            set => CellsByName["OriginArmor3"].Value = value;
        }


        // Def="s32 originEquipPro4 = -1"
        /// <summary>
        /// Origin Armor +4 (s32)
        /// </summary>
        /// <remarks>
        /// Strengthening this armor Original armor ID4
        /// </remarks>
        public int OriginArmor4
        {
            get => (int)CellsByName["OriginArmor4"].Value;
            set => CellsByName["OriginArmor4"].Value = value;
        }


        // Def="s32 originEquipPro5 = -1"
        /// <summary>
        /// Origin Armor +5 (s32)
        /// </summary>
        /// <remarks>
        /// Strengthening this armor Original armor ID5
        /// </remarks>
        public int OriginArmor5
        {
            get => (int)CellsByName["OriginArmor5"].Value;
            set => CellsByName["OriginArmor5"].Value = value;
        }


        // Def="s32 originEquipPro6 = -1"
        /// <summary>
        /// Origin Armor +6 (s32)
        /// </summary>
        /// <remarks>
        /// Strengthening this armor Original armor ID6
        /// </remarks>
        public int OriginArmor6
        {
            get => (int)CellsByName["OriginArmor6"].Value;
            set => CellsByName["OriginArmor6"].Value = value;
        }


        // Def="s32 originEquipPro7 = -1"
        /// <summary>
        /// Origin Armor +7 (s32)
        /// </summary>
        /// <remarks>
        /// Strengthening this armor Original armor ID7
        /// </remarks>
        public int OriginArmor7
        {
            get => (int)CellsByName["OriginArmor7"].Value;
            set => CellsByName["OriginArmor7"].Value = value;
        }


        // Def="s32 originEquipPro8 = -1"
        /// <summary>
        /// Origin Armor +8 (s32)
        /// </summary>
        /// <remarks>
        /// Strengthening this armor Original armor ID8
        /// </remarks>
        public int OriginArmor8
        {
            get => (int)CellsByName["OriginArmor8"].Value;
            set => CellsByName["OriginArmor8"].Value = value;
        }


        // Def="s32 originEquipPro9 = -1"
        /// <summary>
        /// Origin Armor +9 (s32)
        /// </summary>
        /// <remarks>
        /// Strengthening this armor Original armor ID9
        /// </remarks>
        public int OriginArmor9
        {
            get => (int)CellsByName["OriginArmor9"].Value;
            set => CellsByName["OriginArmor9"].Value = value;
        }


        // Def="s32 originEquipPro10 = -1"
        /// <summary>
        /// Origin Armor +10 (s32)
        /// </summary>
        /// <remarks>
        /// Strengthening this armor Original armor ID10
        /// </remarks>
        public int OriginArmor10
        {
            get => (int)CellsByName["OriginArmor10"].Value;
            set => CellsByName["OriginArmor10"].Value = value;
        }


        // Def="s32 originEquipPro11 = -1"
        /// <summary>
        /// Origin Armor +11 (s32)
        /// </summary>
        /// <remarks>
        /// Strengthening this armor Original armor ID11
        /// </remarks>
        public int OriginArmor11
        {
            get => (int)CellsByName["OriginArmor11"].Value;
            set => CellsByName["OriginArmor11"].Value = value;
        }


        // Def="s32 originEquipPro12 = -1"
        /// <summary>
        /// Origin Armor +12 (s32)
        /// </summary>
        /// <remarks>
        /// Strengthening this armor Original armor ID12
        /// </remarks>
        public int OriginArmor12
        {
            get => (int)CellsByName["OriginArmor12"].Value;
            set => CellsByName["OriginArmor12"].Value = value;
        }


        // Def="s32 originEquipPro13 = -1"
        /// <summary>
        /// Origin Armor +13 (s32)
        /// </summary>
        /// <remarks>
        /// Strengthening this armor Original armor ID13
        /// </remarks>
        public int OriginArmor13
        {
            get => (int)CellsByName["OriginArmor13"].Value;
            set => CellsByName["OriginArmor13"].Value = value;
        }


        // Def="s32 originEquipPro14 = -1"
        /// <summary>
        /// Origin Armor +14 (s32)
        /// </summary>
        /// <remarks>
        /// Strengthening this armor Original armor ID14
        /// </remarks>
        public int OriginArmor14
        {
            get => (int)CellsByName["OriginArmor14"].Value;
            set => CellsByName["OriginArmor14"].Value = value;
        }


        // Def="s32 originEquipPro15 = -1"
        /// <summary>
        /// Origin Armor +15 (s32)
        /// </summary>
        /// <remarks>
        /// Strengthening this armor Original armor ID15
        /// </remarks>
        public int OriginArmor15
        {
            get => (int)CellsByName["OriginArmor15"].Value;
            set => CellsByName["OriginArmor15"].Value = value;
        }


        // Def="f32 faceScaleM_ScaleX = 1"
        /// <summary>
        /// Facescale - Male - Scale X (f32)
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        public float FacescaleMaleScaleX
        {
            get => (float)CellsByName["FacescaleMaleScaleX"].Value;
            set => CellsByName["FacescaleMaleScaleX"].Value = value;
        }


        // Def="f32 faceScaleM_ScaleZ = 1"
        /// <summary>
        /// Facescale - Male - Scale Z (f32)
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        public float FacescaleMaleScaleZ
        {
            get => (float)CellsByName["FacescaleMaleScaleZ"].Value;
            set => CellsByName["FacescaleMaleScaleZ"].Value = value;
        }


        // Def="f32 faceScaleM_MaxX = 1"
        /// <summary>
        /// Facescale - Male - Max X (f32)
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        public float FacescaleMaleMaxX
        {
            get => (float)CellsByName["FacescaleMaleMaxX"].Value;
            set => CellsByName["FacescaleMaleMaxX"].Value = value;
        }


        // Def="f32 faceScaleM_MaxZ = 1"
        /// <summary>
        /// Facescale - Male - Max Z (f32)
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        public float FacescaleMaleMaxZ
        {
            get => (float)CellsByName["FacescaleMaleMaxZ"].Value;
            set => CellsByName["FacescaleMaleMaxZ"].Value = value;
        }


        // Def="f32 faceScaleF_ScaleX = 1"
        /// <summary>
        /// Facescale - Female - Scale X (f32)
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        public float FacescaleFemaleScaleX
        {
            get => (float)CellsByName["FacescaleFemaleScaleX"].Value;
            set => CellsByName["FacescaleFemaleScaleX"].Value = value;
        }


        // Def="f32 faceScaleF_ScaleZ = 1"
        /// <summary>
        /// Facescale - Female - Scale Z (f32)
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        public float FacescaleFemaleScaleZ
        {
            get => (float)CellsByName["FacescaleFemaleScaleZ"].Value;
            set => CellsByName["FacescaleFemaleScaleZ"].Value = value;
        }


        // Def="f32 faceScaleF_MaxX = 1"
        /// <summary>
        /// Facescale - Female - Max X (f32)
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        public float FacescaleFemaleMaxX
        {
            get => (float)CellsByName["FacescaleFemaleMaxX"].Value;
            set => CellsByName["FacescaleFemaleMaxX"].Value = value;
        }


        // Def="f32 faceScaleF_MaxZ = 1"
        /// <summary>
        /// Facescale - Female - Max Z (f32)
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        public float FacescaleFemaleMaxZ
        {
            get => (float)CellsByName["FacescaleFemaleMaxZ"].Value;
            set => CellsByName["FacescaleFemaleMaxZ"].Value = value;
        }


        // Def="s32 qwcId = -1"
        /// <summary>
        /// QWC ID (s32)
        /// </summary>
        /// <remarks>
        /// QWC parameter ID
        /// </remarks>
        public int QWCID
        {
            get => (int)CellsByName["QWCID"].Value;
            set => CellsByName["QWCID"].Value = value;
        }


        // Def="u16 equipModelId"
        /// <summary>
        /// Equip Model ID (u16)
        /// </summary>
        /// <remarks>
        /// Equipment model number.
        /// </remarks>
        public ushort EquipModelID
        {
            get => (ushort)CellsByName["EquipModelID"].Value;
            set => CellsByName["EquipModelID"].Value = value;
        }


        // Def="u16 iconIdM"
        /// <summary>
        /// Icon ID - Male (u16)
        /// </summary>
        /// <remarks>
        /// Men's menu icon ID.
        /// </remarks>
        public ushort IconIDMale
        {
            get => (ushort)CellsByName["IconIDMale"].Value;
            set => CellsByName["IconIDMale"].Value = value;
        }


        // Def="u16 iconIdF"
        /// <summary>
        /// Icon ID - Female (u16)
        /// </summary>
        /// <remarks>
        /// Women's menu icon ID.
        /// </remarks>
        public ushort IconIDFemale
        {
            get => (ushort)CellsByName["IconIDFemale"].Value;
            set => CellsByName["IconIDFemale"].Value = value;
        }


        // Def="u16 knockBack"
        /// <summary>
        /// Knockback (u16)
        /// </summary>
        /// <remarks>
        /// Knockback reduction value.
        /// </remarks>
        public ushort Knockback
        {
            get => (ushort)CellsByName["Knockback"].Value;
            set => CellsByName["Knockback"].Value = value;
        }


        // Def="u16 knockbackBounceRate"
        /// <summary>
        /// Knockback Bounce Rate (u16)
        /// </summary>
        /// <remarks>
        /// Knockback repulsion rate.
        /// </remarks>
        public ushort KnockbackBounceRate
        {
            get => (ushort)CellsByName["KnockbackBounceRate"].Value;
            set => CellsByName["KnockbackBounceRate"].Value = value;
        }


        // Def="u16 durability = 100"
        /// <summary>
        /// Durability (u16)
        /// </summary>
        /// <remarks>
        /// Initial durability.
        /// </remarks>
        public ushort Durability
        {
            get => (ushort)CellsByName["Durability"].Value;
            set => CellsByName["Durability"].Value = value;
        }


        // Def="u16 durabilityMax = 100"
        /// <summary>
        /// Max Durability (u16)
        /// </summary>
        /// <remarks>
        /// New durability.
        /// </remarks>
        public ushort MaxDurability
        {
            get => (ushort)CellsByName["MaxDurability"].Value;
            set => CellsByName["MaxDurability"].Value = value;
        }


        // Def="dummy8 pad03[2]"
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


        // Def="u16 defFlickPower"
        /// <summary>
        /// Weapon Repel Power (u16)
        /// </summary>
        /// <remarks>
        /// Used to determine the repulsion of enemy attacks.
        /// </remarks>
        public ushort WeaponRepelPower
        {
            get => (ushort)CellsByName["WeaponRepelPower"].Value;
            set => CellsByName["WeaponRepelPower"].Value = value;
        }


        // Def="u16 defensePhysics = 100"
        /// <summary>
        /// Defence - Physical (u16)
        /// </summary>
        /// <remarks>
        /// Physical attack damage protection.
        /// </remarks>
        public ushort DefencePhysical
        {
            get => (ushort)CellsByName["DefencePhysical"].Value;
            set => CellsByName["DefencePhysical"].Value = value;
        }


        // Def="u16 defenseMagic = 100"
        /// <summary>
        /// Defence - Magic (u16)
        /// </summary>
        /// <remarks>
        /// Magic attack damage protection.
        /// </remarks>
        public ushort DefenceMagic
        {
            get => (ushort)CellsByName["DefenceMagic"].Value;
            set => CellsByName["DefenceMagic"].Value = value;
        }


        // Def="u16 defenseFire = 100"
        /// <summary>
        /// Defence - Fire (u16)
        /// </summary>
        /// <remarks>
        /// Fire attack damage protection.
        /// </remarks>
        public ushort DefenceFire
        {
            get => (ushort)CellsByName["DefenceFire"].Value;
            set => CellsByName["DefenceFire"].Value = value;
        }


        // Def="u16 defenseThunder = 100"
        /// <summary>
        /// Defence - Lightning (u16)
        /// </summary>
        /// <remarks>
        /// Damage protection for electric shock attacks.
        /// </remarks>
        public ushort DefenceLightning
        {
            get => (ushort)CellsByName["DefenceLightning"].Value;
            set => CellsByName["DefenceLightning"].Value = value;
        }


        // Def="s16 defenseSlash"
        /// <summary>
        /// Defence - Slash (s16)
        /// </summary>
        /// <remarks>
        /// Look at the attack type, and if it is a slashing attribute, reduce the defense power
        /// </remarks>
        public short DefenceSlash
        {
            get => (short)CellsByName["DefenceSlash"].Value;
            set => CellsByName["DefenceSlash"].Value = value;
        }


        // Def="s16 defenseBlow"
        /// <summary>
        /// Defence - Strike (s16)
        /// </summary>
        /// <remarks>
        /// Look at the attack attribute, and if it is a hit attribute, reduce the defense power.
        /// </remarks>
        public short DefenceStrike
        {
            get => (short)CellsByName["DefenceStrike"].Value;
            set => CellsByName["DefenceStrike"].Value = value;
        }


        // Def="s16 defenseThrust"
        /// <summary>
        /// Defence - Thrust (s16)
        /// </summary>
        /// <remarks>
        /// Look at the attack attribute, and if it is a hit attribute, reduce the defense power.
        /// </remarks>
        public short DefenceThrust
        {
            get => (short)CellsByName["DefenceThrust"].Value;
            set => CellsByName["DefenceThrust"].Value = value;
        }


        // Def="u16 resistPoison = 100"
        /// <summary>
        /// Resist - Poison (u16)
        /// </summary>
        /// <remarks>
        /// Difficulty in getting poisonous
        /// </remarks>
        public ushort ResistPoison
        {
            get => (ushort)CellsByName["ResistPoison"].Value;
            set => CellsByName["ResistPoison"].Value = value;
        }


        // Def="u16 resistDisease = 100"
        /// <summary>
        /// Resist - Scarlet Rot (u16)
        /// </summary>
        /// <remarks>
        /// Difficulty in getting sick
        /// </remarks>
        public ushort ResistScarletRot
        {
            get => (ushort)CellsByName["ResistScarletRot"].Value;
            set => CellsByName["ResistScarletRot"].Value = value;
        }


        // Def="u16 resistBlood = 100"
        /// <summary>
        /// Resist - Hemorrhage (u16)
        /// </summary>
        /// <remarks>
        /// Difficulty in getting bleeding abnormalities
        /// </remarks>
        public ushort ResistHemorrhage
        {
            get => (ushort)CellsByName["ResistHemorrhage"].Value;
            set => CellsByName["ResistHemorrhage"].Value = value;
        }


        // Def="u16 resistCurse = 100"
        /// <summary>
        /// Resist - Blight (u16)
        /// </summary>
        /// <remarks>
        /// Difficulty in getting a curse condition
        /// </remarks>
        public ushort ResistBlight
        {
            get => (ushort)CellsByName["ResistBlight"].Value;
            set => CellsByName["ResistBlight"].Value = value;
        }


        // Def="s16 reinforceTypeId"
        /// <summary>
        /// Reinforce Type ID (s16)
        /// </summary>
        /// <remarks>
        /// Enhanced type ID
        /// </remarks>
        public short ReinforceTypeID
        {
            get => (short)CellsByName["ReinforceTypeID"].Value;
            set => CellsByName["ReinforceTypeID"].Value = value;
        }


        // Def="s16 trophySGradeId = -1"
        /// <summary>
        /// Achievement ID (s16)
        /// </summary>
        /// <remarks>
        /// Is it related to the trophy system?
        /// </remarks>
        public short AchievementID
        {
            get => (short)CellsByName["AchievementID"].Value;
            set => CellsByName["AchievementID"].Value = value;
        }


        // Def="s16 shopLv"
        /// <summary>
        /// Shop Level (s16)
        /// </summary>
        /// <remarks>
        /// Level that can be sold at the store
        /// </remarks>
        public short ShopLevel
        {
            get => (short)CellsByName["ShopLevel"].Value;
            set => CellsByName["ShopLevel"].Value = value;
        }


        // Def="u8 knockbackParamId"
        /// <summary>
        /// Knockback Param ID (u8)
        /// </summary>
        /// <remarks>
        /// ID of the parameter used for knockback
        /// </remarks>
        public byte KnockbackParamID
        {
            get => (byte)CellsByName["KnockbackParamID"].Value;
            set => CellsByName["KnockbackParamID"].Value = value;
        }


        // Def="u8 flickDamageCutRate"
        /// <summary>
        /// Weapon Repel Damage % (u8)
        /// </summary>
        /// <remarks>
        /// Used for damage attenuation rate when repelling
        /// </remarks>
        public byte WeaponRepelDamagePercent
        {
            get => (byte)CellsByName["WeaponRepelDamagePercent"].Value;
            set => CellsByName["WeaponRepelDamagePercent"].Value = value;
        }


        // Def="u8 equipModelCategory = 1"
        /// <summary>
        /// Equip Model Category (u8)
        /// </summary>
        /// <remarks>
        /// Equipment model type.
        /// </remarks>
        public byte EquipModelCategory
        {
            get => (byte)CellsByName["EquipModelCategory"].Value;
            set => CellsByName["EquipModelCategory"].Value = value;
        }


        // Def="u8 equipModelGender"
        /// <summary>
        /// Equip Model Gender (u8)
        /// </summary>
        /// <remarks>
        /// Gender of equipment model.
        /// </remarks>
        public byte EquipModelGender
        {
            get => (byte)CellsByName["EquipModelGender"].Value;
            set => CellsByName["EquipModelGender"].Value = value;
        }


        // Def="u8 protectorCategory"
        /// <summary>
        /// Armor Category (u8)
        /// </summary>
        /// <remarks>
        /// Armor category.
        /// </remarks>
        public byte ArmorCategory
        {
            get => (byte)CellsByName["ArmorCategory"].Value;
            set => CellsByName["ArmorCategory"].Value = value;
        }


        // Def="u8 rarity"
        /// <summary>
        /// Rarity (u8)
        /// </summary>
        /// <remarks>
        /// Rarity used in item acquisition logs
        /// </remarks>
        public byte Rarity
        {
            get => (byte)CellsByName["Rarity"].Value;
            set => CellsByName["Rarity"].Value = value;
        }


        // Def="u8 sortGroupId = 255"
        /// <summary>
        /// Sort Group ID (u8)
        /// </summary>
        /// <remarks>
        /// Sort item type ID. In the sort "Item type order", the same ID is displayed together as the same group.
        /// </remarks>
        public byte SortGroupID
        {
            get => (byte)CellsByName["SortGroupID"].Value;
            set => CellsByName["SortGroupID"].Value = value;
        }


        // Def="u8 partsDmgType"
        /// <summary>
        /// Parts Damage Type (u8)
        /// </summary>
        /// <remarks>
        /// Set the attack type to judge the part damage
        /// </remarks>
        public byte PartsDamageType
        {
            get => (byte)CellsByName["PartsDamageType"].Value;
            set => CellsByName["PartsDamageType"].Value = value;
        }


        // Def="dummy8 pad04[2]"
        /// <summary>
        /// Padding (dummy8)
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        public object Padding
        {
            get => (object)CellsByName["Padding"].Value;
            set => CellsByName["Padding"].Value = value;
        }


        // Def="u8 isDeposit:1"
        /// <summary>
        /// Can Deposit (u8)
        /// </summary>
        /// <remarks>
        /// Can you leave it in the warehouse?
        /// </remarks>
        public byte CanDeposit
        {
            get => (byte)CellsByName["CanDeposit"].Value;
            set => CellsByName["CanDeposit"].Value = value;
        }


        // Def="u8 headEquip:1"
        /// <summary>
        /// Is Head Equipment (u8)
        /// </summary>
        /// <remarks>
        /// Is it head equipment?
        /// </remarks>
        public byte IsHeadEquipment
        {
            get => (byte)CellsByName["IsHeadEquipment"].Value;
            set => CellsByName["IsHeadEquipment"].Value = value;
        }


        // Def="u8 bodyEquip:1"
        /// <summary>
        /// Is Body Equipment (u8)
        /// </summary>
        /// <remarks>
        /// Is it torso equipment?
        /// </remarks>
        public byte IsBodyEquipment
        {
            get => (byte)CellsByName["IsBodyEquipment"].Value;
            set => CellsByName["IsBodyEquipment"].Value = value;
        }


        // Def="u8 armEquip:1"
        /// <summary>
        /// Is Arm Equipment (u8)
        /// </summary>
        /// <remarks>
        /// Is it arm equipment?
        /// </remarks>
        public byte IsArmEquipment
        {
            get => (byte)CellsByName["IsArmEquipment"].Value;
            set => CellsByName["IsArmEquipment"].Value = value;
        }


        // Def="u8 legEquip:1"
        /// <summary>
        /// Is Leg Equipment (u8)
        /// </summary>
        /// <remarks>
        /// Is it leg equipment?
        /// </remarks>
        public byte IsLegEquipment
        {
            get => (byte)CellsByName["IsLegEquipment"].Value;
            set => CellsByName["IsLegEquipment"].Value = value;
        }


        // Def="u8 useFaceScale:1"
        /// <summary>
        /// Use Facescale (u8)
        /// </summary>
        /// <remarks>
        /// Whether to use a face scale
        /// </remarks>
        public byte UseFacescale
        {
            get => (byte)CellsByName["UseFacescale"].Value;
            set => CellsByName["UseFacescale"].Value = value;
        }


        // Def="u8 isSkipWeakDamageAnim:1"
        /// <summary>
        /// Skip Weak Damage Anim (u8)
        /// </summary>
        /// <remarks>
        /// Weakness damage Whether to skip animation playback. "Part damage rate" and "defense material" are treated as weak points just by not playing the animation.
        /// </remarks>
        public byte SkipWeakDamageAnim
        {
            get => (byte)CellsByName["SkipWeakDamageAnim"].Value;
            set => CellsByName["SkipWeakDamageAnim"].Value = value;
        }



        // Def="u8 defenseMaterialVariationValue_Weak"
        /// <summary>
        /// Defence Material - Variation Value - Weak (u8)
        /// </summary>
        /// <remarks>
        /// It is a value used for variation of abnormal condition, damage SFX, SE in combination with weak point defense material. SEQ16473
        /// </remarks>
        public byte DefenceMaterialVariationValueWeak
        {
            get => (byte)CellsByName["DefenceMaterialVariationValueWeak"].Value;
            set => CellsByName["DefenceMaterialVariationValueWeak"].Value = value;
        }


        // Def="s16 autoFootEffectDecalBaseId2 = -1"
        /// <summary>
        /// Auto Foot Effect Decal Base ID [2] (s16)
        /// </summary>
        /// <remarks>
        /// Decal ID for automatic foot effects. Floor material is also considered. Only used when the "armor category" is "legs".
        /// </remarks>
        public short AutoFootEffectDecalBaseID2
        {
            get => (short)CellsByName["AutoFootEffectDecalBaseID2"].Value;
            set => CellsByName["AutoFootEffectDecalBaseID2"].Value = value;
        }


        // Def="s16 autoFootEffectDecalBaseId3 = -1"
        /// <summary>
        /// Auto Foot Effect Decal Base ID [3] (s16)
        /// </summary>
        /// <remarks>
        /// Decal ID for automatic foot effects. Floor material is also considered. Only used when the "armor category" is "legs".
        /// </remarks>
        public short AutoFootEffectDecalBaseID3
        {
            get => (short)CellsByName["AutoFootEffectDecalBaseID3"].Value;
            set => CellsByName["AutoFootEffectDecalBaseID3"].Value = value;
        }


        // Def="u8 defenseMaterialVariationValue"
        /// <summary>
        /// Defence Material - Variation Value (u8)
        /// </summary>
        /// <remarks>
        /// It is a value used in combination with the defense material to classify abnormal conditions, damage SFX, and SE. SEQ16473
        /// </remarks>
        public byte DefenceMaterialVariationValue
        {
            get => (byte)CellsByName["DefenceMaterialVariationValue"].Value;
            set => CellsByName["DefenceMaterialVariationValue"].Value = value;
        }


        // Def="u8 isDiscard:1"
        /// <summary>
        /// Can Discard (u8)
        /// </summary>
        /// <remarks>
        /// Can you throw away the item? TRUE = thrown away
        /// </remarks>
        public byte CanDiscard
        {
            get => (byte)CellsByName["CanDiscard"].Value;
            set => CellsByName["CanDiscard"].Value = value;
        }


        // Def="u8 isDrop:1"
        /// <summary>
        /// Can Drop (u8)
        /// </summary>
        /// <remarks>
        /// Can I put the item on the spot? TRUE = can be placed
        /// </remarks>
        public byte CanDrop
        {
            get => (byte)CellsByName["CanDrop"].Value;
            set => CellsByName["CanDrop"].Value = value;
        }


        // Def="u8 disableMultiDropShare:1"
        /// <summary>
        /// Cannot Drop in Multiplayer (u8)
        /// </summary>
        /// <remarks>
        /// Is multi-drop sharing prohibited?
        /// </remarks>
        public byte CannotDropInMultiplayer
        {
            get => (byte)CellsByName["CannotDropInMultiplayer"].Value;
            set => CellsByName["CannotDropInMultiplayer"].Value = value;
        }


        // Def="u8 simpleModelForDlc:1"
        /// <summary>
        /// Simple Model for DLC1 (u8)
        /// </summary>
        /// <remarks>
        /// Is there a simple model for DLC?
        /// </remarks>
        public byte SimpleModelForDLC1
        {
            get => (byte)CellsByName["SimpleModelForDLC1"].Value;
            set => CellsByName["SimpleModelForDLC1"].Value = value;
        }


        // Def="u8 showLogCondType:1 = 1"
        /// <summary>
        /// Item Acquisition Log Condition Type (u8)
        /// </summary>
        /// <remarks>
        /// Whether to display in the item acquisition log when acquiring the item (not entered: ○)
        /// </remarks>
        public byte ItemAcquisitionLogConditionType
        {
            get => (byte)CellsByName["ItemAcquisitionLogConditionType"].Value;
            set => CellsByName["ItemAcquisitionLogConditionType"].Value = value;
        }


        // Def="u8 showDialogCondType:2 = 2"
        /// <summary>
        /// Item Acquisition Dialog Condition Type  (u8)
        /// </summary>
        /// <remarks>
        /// Whether to display it in the item acquisition dialog when acquiring an item (not entered: new only)
        /// </remarks>
        public byte ItemAcquisitionDialogConditionType
        {
            get => (byte)CellsByName["ItemAcquisitionDialogConditionType"].Value;
            set => CellsByName["ItemAcquisitionDialogConditionType"].Value = value;
        }



        // Def="f32 neutralDamageCutRate = 1"
        /// <summary>
        /// Absorption - Physical (f32)
        /// </summary>
        /// <remarks>
        /// Non-attribute damage multiplier
        /// </remarks>
        public float AbsorptionPhysical
        {
            get => (float)CellsByName["AbsorptionPhysical"].Value;
            set => CellsByName["AbsorptionPhysical"].Value = value;
        }


        // Def="f32 slashDamageCutRate = 1"
        /// <summary>
        /// Absorption - Slash (f32)
        /// </summary>
        /// <remarks>
        /// Slash damage multiplier
        /// </remarks>
        public float AbsorptionSlash
        {
            get => (float)CellsByName["AbsorptionSlash"].Value;
            set => CellsByName["AbsorptionSlash"].Value = value;
        }


        // Def="f32 blowDamageCutRate = 1"
        /// <summary>
        /// Absorption - Strike (f32)
        /// </summary>
        /// <remarks>
        /// Batter damage multiplier
        /// </remarks>
        public float AbsorptionStrike
        {
            get => (float)CellsByName["AbsorptionStrike"].Value;
            set => CellsByName["AbsorptionStrike"].Value = value;
        }


        // Def="f32 thrustDamageCutRate = 1"
        /// <summary>
        /// Absorption - Thrust (f32)
        /// </summary>
        /// <remarks>
        /// Puncture damage ratio
        /// </remarks>
        public float AbsorptionThrust
        {
            get => (float)CellsByName["AbsorptionThrust"].Value;
            set => CellsByName["AbsorptionThrust"].Value = value;
        }


        // Def="f32 magicDamageCutRate = 1"
        /// <summary>
        /// Absorption - Magic (f32)
        /// </summary>
        /// <remarks>
        /// Magic damage multiplier
        /// </remarks>
        public float AbsorptionMagic
        {
            get => (float)CellsByName["AbsorptionMagic"].Value;
            set => CellsByName["AbsorptionMagic"].Value = value;
        }


        // Def="f32 fireDamageCutRate = 1"
        /// <summary>
        /// Absorption - Fire (f32)
        /// </summary>
        /// <remarks>
        /// Flame damage multiplier
        /// </remarks>
        public float AbsorptionFire
        {
            get => (float)CellsByName["AbsorptionFire"].Value;
            set => CellsByName["AbsorptionFire"].Value = value;
        }


        // Def="f32 thunderDamageCutRate = 1"
        /// <summary>
        /// Absorption - Lightning (f32)
        /// </summary>
        /// <remarks>
        /// Electric shock damage ratio
        /// </remarks>
        public float AbsorptionLightning
        {
            get => (float)CellsByName["AbsorptionLightning"].Value;
            set => CellsByName["AbsorptionLightning"].Value = value;
        }


        // Def="u16 defenseMaterialSfx1 = 50"
        /// <summary>
        /// Defence Material SFX [1] (u16)
        /// </summary>
        /// <remarks>
        /// For SFX when moving / defending. 1
        /// </remarks>
        public ushort DefenceMaterialSFX1
        {
            get => (ushort)CellsByName["DefenceMaterialSFX1"].Value;
            set => CellsByName["DefenceMaterialSFX1"].Value = value;
        }


        // Def="u16 defenseMaterialSfx_Weak1 = 50"
        /// <summary>
        /// Defence Material SFX - Weakness [1] (u16)
        /// </summary>
        /// <remarks>
        /// For SFX when weak points are damaged 1
        /// </remarks>
        public ushort DefenceMaterialSFXWeakness1
        {
            get => (ushort)CellsByName["DefenceMaterialSFXWeakness1"].Value;
            set => CellsByName["DefenceMaterialSFXWeakness1"].Value = value;
        }


        // Def="u16 defenseMaterial1 = 50"
        /// <summary>
        /// Defence Material - SE [1] (u16)
        /// </summary>
        /// <remarks>
        /// For SE when moving / defending. 1
        /// </remarks>
        public ushort DefenceMaterialSE1
        {
            get => (ushort)CellsByName["DefenceMaterialSE1"].Value;
            set => CellsByName["DefenceMaterialSE1"].Value = value;
        }


        // Def="u16 defenseMaterial_Weak1 = 50"
        /// <summary>
        /// Defence Material SE - Weakness [1] (u16)
        /// </summary>
        /// <remarks>
        /// For SE when weak points are damaged 1
        /// </remarks>
        public ushort DefenceMaterialSEWeakness1
        {
            get => (ushort)CellsByName["DefenceMaterialSEWeakness1"].Value;
            set => CellsByName["DefenceMaterialSEWeakness1"].Value = value;
        }


        // Def="u16 defenseMaterialSfx2 = 50"
        /// <summary>
        /// Defence Material SFX [2] (u16)
        /// </summary>
        /// <remarks>
        /// For SFX when moving / defending. 2
        /// </remarks>
        public ushort DefenceMaterialSFX2
        {
            get => (ushort)CellsByName["DefenceMaterialSFX2"].Value;
            set => CellsByName["DefenceMaterialSFX2"].Value = value;
        }


        // Def="u16 defenseMaterialSfx_Weak2 = 50"
        /// <summary>
        /// Defence Material SFX - Weakness [2] (u16)
        /// </summary>
        /// <remarks>
        /// 2 for SFX when weak points are damaged
        /// </remarks>
        public ushort DefenceMaterialSFXWeakness2
        {
            get => (ushort)CellsByName["DefenceMaterialSFXWeakness2"].Value;
            set => CellsByName["DefenceMaterialSFXWeakness2"].Value = value;
        }


        // Def="u16 footMaterialSe = 139"
        /// <summary>
        /// Foot Material SE (u16)
        /// </summary>
        /// <remarks>
        /// Material for foot equipment SE. Only foot equipment is referenced. ([GR] SEQ10061) In the case of "139: None", the defense material 1 [SE] is referred to.
        /// </remarks>
        public ushort FootMaterialSE
        {
            get => (ushort)CellsByName["FootMaterialSE"].Value;
            set => CellsByName["FootMaterialSE"].Value = value;
        }


        // Def="u16 defenseMaterial_Weak2 = 50"
        /// <summary>
        /// Defence Material SE - Weakness [2] (u16)
        /// </summary>
        /// <remarks>
        /// 2 for SE when weak points are damaged
        /// </remarks>
        public ushort DefenceMaterialSEWeakness2
        {
            get => (ushort)CellsByName["DefenceMaterialSEWeakness2"].Value;
            set => CellsByName["DefenceMaterialSEWeakness2"].Value = value;
        }


        // Def="s32 autoFootEffectDecalBaseId1 = -1"
        /// <summary>
        /// Auto Foot Effect Decal Base ID [1] (s32)
        /// </summary>
        /// <remarks>
        /// Decal ID for automatic foot effects. Floor material is also considered. Only used when the "armor category" is "legs".
        /// </remarks>
        public int AutoFootEffectDecalBaseID1
        {
            get => (int)CellsByName["AutoFootEffectDecalBaseID1"].Value;
            set => CellsByName["AutoFootEffectDecalBaseID1"].Value = value;
        }


        // Def="f32 toughnessDamageCutRate = 1"
        /// <summary>
        /// Toughness Absorption (f32)
        /// </summary>
        /// <remarks>
        /// Toughness version cut rate
        /// </remarks>
        public float ToughnessAbsorption
        {
            get => (float)CellsByName["ToughnessAbsorption"].Value;
            set => CellsByName["ToughnessAbsorption"].Value = value;
        }


        // Def="f32 toughnessRecoverCorrection"
        /// <summary>
        /// Toughness Recovery Correction (f32)
        /// </summary>
        /// <remarks>
        /// Correction value for toughness recovery time
        /// </remarks>
        public float ToughnessRecoveryCorrection
        {
            get => (float)CellsByName["ToughnessRecoveryCorrection"].Value;
            set => CellsByName["ToughnessRecoveryCorrection"].Value = value;
        }


        // Def="f32 darkDamageCutRate = 1"
        /// <summary>
        /// Absorption - Holy (f32)
        /// </summary>
        /// <remarks>
        /// Dark damage multiplier
        /// </remarks>
        public float AbsorptionHoly
        {
            get => (float)CellsByName["AbsorptionHoly"].Value;
            set => CellsByName["AbsorptionHoly"].Value = value;
        }


        // Def="u16 defenseDark = 100"
        /// <summary>
        /// Defence - Holy (u16)
        /// </summary>
        /// <remarks>
        /// Dark attack damage protection.
        /// </remarks>
        public ushort DefenceHoly
        {
            get => (ushort)CellsByName["DefenceHoly"].Value;
            set => CellsByName["DefenceHoly"].Value = value;
        }


        // Def="dummy8 invisibleFlag48:1"
        /// <summary>
        /// PAD_original_ # 48 # hidden (dummy8)
        /// </summary>
        /// <remarks>
        /// Original _ # 48 # hidden
        /// </remarks>
        public object PAD_original_48Hidden
        {
            get => (object)CellsByName["PAD_original_48Hidden"].Value;
            set => CellsByName["PAD_original_48Hidden"].Value = value;
        }


        // Def="dummy8 invisibleFlag49:1"
        /// <summary>
        /// PAD_original_ # 49 # hidden (dummy8)
        /// </summary>
        /// <remarks>
        /// Original _ # 49 # hidden
        /// </remarks>
        public object PAD_original_49Hidden
        {
            get => (object)CellsByName["PAD_original_49Hidden"].Value;
            set => CellsByName["PAD_original_49Hidden"].Value = value;
        }


        // Def="dummy8 invisibleFlag50:1"
        /// <summary>
        /// PAD_original_ # 50 # hidden (dummy8)
        /// </summary>
        /// <remarks>
        /// Original _ # 50 # hidden
        /// </remarks>
        public object PAD_original_50Hidden
        {
            get => (object)CellsByName["PAD_original_50Hidden"].Value;
            set => CellsByName["PAD_original_50Hidden"].Value = value;
        }


        // Def="dummy8 invisibleFlag51:1"
        /// <summary>
        /// PAD_original_ # 51 # hidden (dummy8)
        /// </summary>
        /// <remarks>
        /// Original _ # 51 # hidden
        /// </remarks>
        public object PAD_original_51Hidden
        {
            get => (object)CellsByName["PAD_original_51Hidden"].Value;
            set => CellsByName["PAD_original_51Hidden"].Value = value;
        }


        // Def="dummy8 invisibleFlag52:1"
        /// <summary>
        /// PAD_original_ # 52 # hidden (dummy8)
        /// </summary>
        /// <remarks>
        /// Original _ # 52 # hidden
        /// </remarks>
        public object PAD_original_52Hidden
        {
            get => (object)CellsByName["PAD_original_52Hidden"].Value;
            set => CellsByName["PAD_original_52Hidden"].Value = value;
        }


        // Def="dummy8 invisibleFlag53:1"
        /// <summary>
        /// PAD_original_ # 53 # hidden (dummy8)
        /// </summary>
        /// <remarks>
        /// Original _ # 53 # hidden
        /// </remarks>
        public object PAD_original_53Hidden
        {
            get => (object)CellsByName["PAD_original_53Hidden"].Value;
            set => CellsByName["PAD_original_53Hidden"].Value = value;
        }


        // Def="dummy8 invisibleFlag54:1"
        /// <summary>
        /// PAD_original_ # 54 # hidden (dummy8)
        /// </summary>
        /// <remarks>
        /// Original _ # 54 # hidden
        /// </remarks>
        public object PAD_original_54Hidden
        {
            get => (object)CellsByName["PAD_original_54Hidden"].Value;
            set => CellsByName["PAD_original_54Hidden"].Value = value;
        }


        // Def="dummy8 invisibleFlag55:1"
        /// <summary>
        /// PAD_original_ # 55 # hidden (dummy8)
        /// </summary>
        /// <remarks>
        /// Original _ # 55 # hidden
        /// </remarks>
        public object PAD_original_55Hidden
        {
            get => (object)CellsByName["PAD_original_55Hidden"].Value;
            set => CellsByName["PAD_original_55Hidden"].Value = value;
        }


        // Def="dummy8 invisibleFlag56:1"
        /// <summary>
        /// PAD_original_ # 56 # hidden (dummy8)
        /// </summary>
        /// <remarks>
        /// Original _ # 56 # hidden
        /// </remarks>
        public object PAD_original_56Hidden
        {
            get => (object)CellsByName["PAD_original_56Hidden"].Value;
            set => CellsByName["PAD_original_56Hidden"].Value = value;
        }


        // Def="dummy8 invisibleFlag57:1"
        /// <summary>
        /// PAD_original_ # 57 # hidden (dummy8)
        /// </summary>
        /// <remarks>
        /// Original _ # 57 # hidden
        /// </remarks>
        public object PAD_original_57Hidden
        {
            get => (object)CellsByName["PAD_original_57Hidden"].Value;
            set => CellsByName["PAD_original_57Hidden"].Value = value;
        }


        // Def="dummy8 invisibleFlag58:1"
        /// <summary>
        /// PAD_original_ # 58 # hidden (dummy8)
        /// </summary>
        /// <remarks>
        /// Original _ # 58 # hidden
        /// </remarks>
        public object PAD_original_58Hidden
        {
            get => (object)CellsByName["PAD_original_58Hidden"].Value;
            set => CellsByName["PAD_original_58Hidden"].Value = value;
        }


        // Def="dummy8 invisibleFlag59:1"
        /// <summary>
        /// PAD_original_ # 59 # hidden (dummy8)
        /// </summary>
        /// <remarks>
        /// Original _ # 59 # hidden
        /// </remarks>
        public object PAD_original_59Hidden
        {
            get => (object)CellsByName["PAD_original_59Hidden"].Value;
            set => CellsByName["PAD_original_59Hidden"].Value = value;
        }


        // Def="dummy8 invisibleFlag60:1"
        /// <summary>
        /// PAD_original_ # 60 # hidden (dummy8)
        /// </summary>
        /// <remarks>
        /// Original _ # 60 # hidden
        /// </remarks>
        public object PAD_original_60Hidden
        {
            get => (object)CellsByName["PAD_original_60Hidden"].Value;
            set => CellsByName["PAD_original_60Hidden"].Value = value;
        }


        // Def="dummy8 invisibleFlag61:1"
        /// <summary>
        /// PAD_original_ # 61 # hidden (dummy8)
        /// </summary>
        /// <remarks>
        /// Original _ # 61 # Hidden
        /// </remarks>
        public object PAD_original_61Hidden
        {
            get => (object)CellsByName["PAD_original_61Hidden"].Value;
            set => CellsByName["PAD_original_61Hidden"].Value = value;
        }


        // Def="dummy8 invisibleFlag62:1"
        /// <summary>
        /// PAD_original_ # 62 # hidden (dummy8)
        /// </summary>
        /// <remarks>
        /// Original _ # 62 # hidden
        /// </remarks>
        public object PAD_original_62Hidden
        {
            get => (object)CellsByName["PAD_original_62Hidden"].Value;
            set => CellsByName["PAD_original_62Hidden"].Value = value;
        }


        // Def="dummy8 invisibleFlag63:1"
        /// <summary>
        /// PAD_original_ # 63 # hidden (dummy8)
        /// </summary>
        /// <remarks>
        /// Original _ # 63 # hidden
        /// </remarks>
        public object PAD_original_63Hidden
        {
            get => (object)CellsByName["PAD_original_63Hidden"].Value;
            set => CellsByName["PAD_original_63Hidden"].Value = value;
        }


        // Def="dummy8 invisibleFlag64:1"
        /// <summary>
        /// PAD_original_ # 64 # hidden (dummy8)
        /// </summary>
        /// <remarks>
        /// Original _ # 64 # hidden
        /// </remarks>
        public object PAD_original_64Hidden
        {
            get => (object)CellsByName["PAD_original_64Hidden"].Value;
            set => CellsByName["PAD_original_64Hidden"].Value = value;
        }


        // Def="dummy8 invisibleFlag65:1"
        /// <summary>
        /// PAD_original_ # 65 # hidden (dummy8)
        /// </summary>
        /// <remarks>
        /// Original _ # 65 # hidden
        /// </remarks>
        public object PAD_original_65Hidden
        {
            get => (object)CellsByName["PAD_original_65Hidden"].Value;
            set => CellsByName["PAD_original_65Hidden"].Value = value;
        }


        // Def="dummy8 invisibleFlag66:1"
        /// <summary>
        /// PAD_original_ # 66 # hidden (dummy8)
        /// </summary>
        /// <remarks>
        /// Original _ # 66 # hidden
        /// </remarks>
        public object PAD_original_66Hidden
        {
            get => (object)CellsByName["PAD_original_66Hidden"].Value;
            set => CellsByName["PAD_original_66Hidden"].Value = value;
        }


        // Def="dummy8 invisibleFlag67:1"
        /// <summary>
        /// PAD_original_ # 67 # hidden (dummy8)
        /// </summary>
        /// <remarks>
        /// Original _ # 67 # hidden
        /// </remarks>
        public object PAD_original_67Hidden
        {
            get => (object)CellsByName["PAD_original_67Hidden"].Value;
            set => CellsByName["PAD_original_67Hidden"].Value = value;
        }


        // Def="dummy8 invisibleFlag68:1"
        /// <summary>
        /// PAD_original_ # 68 # hidden (dummy8)
        /// </summary>
        /// <remarks>
        /// Original _ # 68 # hidden
        /// </remarks>
        public object PAD_original_68Hidden
        {
            get => (object)CellsByName["PAD_original_68Hidden"].Value;
            set => CellsByName["PAD_original_68Hidden"].Value = value;
        }


        // Def="dummy8 invisibleFlag69:1"
        /// <summary>
        /// PAD_original_ # 69 # hidden (dummy8)
        /// </summary>
        /// <remarks>
        /// Original _ # 69 # hidden
        /// </remarks>
        public object PAD_original_69Hidden
        {
            get => (object)CellsByName["PAD_original_69Hidden"].Value;
            set => CellsByName["PAD_original_69Hidden"].Value = value;
        }


        // Def="dummy8 invisibleFlag70:1"
        /// <summary>
        /// PAD_original_ # 70 # hidden (dummy8)
        /// </summary>
        /// <remarks>
        /// Original _ # 70 # hidden
        /// </remarks>
        public object PAD_original_70Hidden
        {
            get => (object)CellsByName["PAD_original_70Hidden"].Value;
            set => CellsByName["PAD_original_70Hidden"].Value = value;
        }


        // Def="dummy8 invisibleFlag71:1"
        /// <summary>
        /// PAD_original_ # 71 # hidden (dummy8)
        /// </summary>
        /// <remarks>
        /// Original _ # 71 # hidden
        /// </remarks>
        public object PAD_original_71Hidden
        {
            get => (object)CellsByName["PAD_original_71Hidden"].Value;
            set => CellsByName["PAD_original_71Hidden"].Value = value;
        }


        // Def="dummy8 invisibleFlag72:1"
        /// <summary>
        /// PAD_original_ # 72 # hidden (dummy8)
        /// </summary>
        /// <remarks>
        /// Original _ # 72 # hidden
        /// </remarks>
        public object PAD_original_72Hidden
        {
            get => (object)CellsByName["PAD_original_72Hidden"].Value;
            set => CellsByName["PAD_original_72Hidden"].Value = value;
        }


        // Def="dummy8 invisibleFlag73:1"
        /// <summary>
        /// PAD_original_ # 73 # hidden (dummy8)
        /// </summary>
        /// <remarks>
        /// Original _ # 73 # hidden
        /// </remarks>
        public object PAD_original_73Hidden
        {
            get => (object)CellsByName["PAD_original_73Hidden"].Value;
            set => CellsByName["PAD_original_73Hidden"].Value = value;
        }


        // Def="dummy8 invisibleFlag74:1"
        /// <summary>
        /// PAD_original_ # 74 # hidden (dummy8)
        /// </summary>
        /// <remarks>
        /// Original _ # 74 # hidden
        /// </remarks>
        public object PAD_original_74Hidden
        {
            get => (object)CellsByName["PAD_original_74Hidden"].Value;
            set => CellsByName["PAD_original_74Hidden"].Value = value;
        }


        // Def="dummy8 invisibleFlag75:1"
        /// <summary>
        /// PAD_original_ # 75 # hidden (dummy8)
        /// </summary>
        /// <remarks>
        /// Original _ # 75 # hidden
        /// </remarks>
        public object PAD_original_75Hidden
        {
            get => (object)CellsByName["PAD_original_75Hidden"].Value;
            set => CellsByName["PAD_original_75Hidden"].Value = value;
        }


        // Def="dummy8 invisibleFlag76:1"
        /// <summary>
        /// PAD_original_ # 76 # hidden (dummy8)
        /// </summary>
        /// <remarks>
        /// Original _ # 76 # hidden
        /// </remarks>
        public object PAD_original_76Hidden
        {
            get => (object)CellsByName["PAD_original_76Hidden"].Value;
            set => CellsByName["PAD_original_76Hidden"].Value = value;
        }


        // Def="dummy8 invisibleFlag77:1"
        /// <summary>
        /// PAD_original_ # 77 # hidden (dummy8)
        /// </summary>
        /// <remarks>
        /// Original _ # 77 # hidden
        /// </remarks>
        public object PAD_original_77Hidden
        {
            get => (object)CellsByName["PAD_original_77Hidden"].Value;
            set => CellsByName["PAD_original_77Hidden"].Value = value;
        }


        // Def="dummy8 invisibleFlag78:1"
        /// <summary>
        /// PAD_original_ # 78 # hidden (dummy8)
        /// </summary>
        /// <remarks>
        /// Original _ # 78 # hidden
        /// </remarks>
        public object PAD_original_78Hidden
        {
            get => (object)CellsByName["PAD_original_78Hidden"].Value;
            set => CellsByName["PAD_original_78Hidden"].Value = value;
        }


        // Def="dummy8 invisibleFlag79:1"
        /// <summary>
        /// PAD_original_ # 79 # hidden (dummy8)
        /// </summary>
        /// <remarks>
        /// Original _ # 79 # hidden
        /// </remarks>
        public object PAD_original_79Hidden
        {
            get => (object)CellsByName["PAD_original_79Hidden"].Value;
            set => CellsByName["PAD_original_79Hidden"].Value = value;
        }


        // Def="dummy8 invisibleFlag80:1"
        /// <summary>
        /// PAD_original_ # 80 # hidden (dummy8)
        /// </summary>
        /// <remarks>
        /// Original _ # 80 # hidden
        /// </remarks>
        public object PAD_original_80Hidden
        {
            get => (object)CellsByName["PAD_original_80Hidden"].Value;
            set => CellsByName["PAD_original_80Hidden"].Value = value;
        }



        // Def="u8 postureControlId"
        /// <summary>
        /// Posture Control ID (u8)
        /// </summary>
        /// <remarks>
        /// Attitude control ID (torso)
        /// </remarks>
        public byte PostureControlID
        {
            get => (byte)CellsByName["PostureControlID"].Value;
            set => CellsByName["PostureControlID"].Value = value;
        }



        // Def="s32 saleValue = -1"
        /// <summary>
        /// Shop Price (s32)
        /// </summary>
        /// <remarks>
        /// Selling price
        /// </remarks>
        public int ShopPrice
        {
            get => (int)CellsByName["ShopPrice"].Value;
            set => CellsByName["ShopPrice"].Value = value;
        }


        // Def="u16 resistFreeze"
        /// <summary>
        /// Resist - Frost (u16)
        /// </summary>
        /// <remarks>
        /// Difficulty in getting cold air condition abnormal
        /// </remarks>
        public ushort ResistFrost
        {
            get => (ushort)CellsByName["ResistFrost"].Value;
            set => CellsByName["ResistFrost"].Value = value;
        }


        // Def="u8 invisibleFlag_SexVer00"
        /// <summary>
        /// Mask 00 - Hide upper front face (u8)
        /// </summary>
        /// <remarks>
        /// Bangs tip
        /// </remarks>
        public byte Mask00HideUpperFrontFace
        {
            get => (byte)CellsByName["Mask00HideUpperFrontFace"].Value;
            set => CellsByName["Mask00HideUpperFrontFace"].Value = value;
        }


        // Def="u8 invisibleFlag_SexVer01"
        /// <summary>
        /// Mask 01 - Hide lower front face (u8)
        /// </summary>
        /// <remarks>
        /// Bangs root
        /// </remarks>
        public byte Mask01HideLowerFrontFace
        {
            get => (byte)CellsByName["Mask01HideLowerFrontFace"].Value;
            set => CellsByName["Mask01HideLowerFrontFace"].Value = value;
        }


        // Def="u8 invisibleFlag_SexVer02"
        /// <summary>
        /// Mask 02 - Hide middle front face (u8)
        /// </summary>
        /// <remarks>
        /// Sideburns
        /// </remarks>
        public byte Mask02HideMiddleFrontFace
        {
            get => (byte)CellsByName["Mask02HideMiddleFrontFace"].Value;
            set => CellsByName["Mask02HideMiddleFrontFace"].Value = value;
        }


        // Def="u8 invisibleFlag_SexVer03"
        /// <summary>
        /// Mask 03 - Hide top and back of head (u8)
        /// </summary>
        /// <remarks>
        /// Top of the head
        /// </remarks>
        public byte Mask03HideTopAndBackOfHead
        {
            get => (byte)CellsByName["Mask03HideTopAndBackOfHead"].Value;
            set => CellsByName["Mask03HideTopAndBackOfHead"].Value = value;
        }


        // Def="u8 invisibleFlag_SexVer04"
        /// <summary>
        /// Mask 04 - Hide neck (u8)
        /// </summary>
        /// <remarks>
        /// Top of the head
        /// </remarks>
        public byte Mask04HideNeck
        {
            get => (byte)CellsByName["Mask04HideNeck"].Value;
            set => CellsByName["Mask04HideNeck"].Value = value;
        }


        // Def="u8 invisibleFlag_SexVer05"
        /// <summary>
        /// Mask 05 - Hide neckline and shoulders (u8)
        /// </summary>
        /// <remarks>
        /// Back hair
        /// </remarks>
        public byte Mask05HideNecklineAndShoulders
        {
            get => (byte)CellsByName["Mask05HideNecklineAndShoulders"].Value;
            set => CellsByName["Mask05HideNecklineAndShoulders"].Value = value;
        }


        // Def="u8 invisibleFlag_SexVer06"
        /// <summary>
        /// Mask 06 - Hide upper torso area, reduce back size (u8)
        /// </summary>
        /// <remarks>
        /// The tip of the back hair
        /// </remarks>
        public byte Mask06HideUpperTorsoAreaReduceBackSize
        {
            get => (byte)CellsByName["Mask06HideUpperTorsoAreaReduceBackSize"].Value;
            set => CellsByName["Mask06HideUpperTorsoAreaReduceBackSize"].Value = value;
        }


        // Def="u8 invisibleFlag_SexVer07"
        /// <summary>
        /// Mask 07 - Reduce bicep size (u8)
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        public byte Mask07ReduceBicepSize
        {
            get => (byte)CellsByName["Mask07ReduceBicepSize"].Value;
            set => CellsByName["Mask07ReduceBicepSize"].Value = value;
        }


        // Def="u8 invisibleFlag_SexVer08"
        /// <summary>
        /// Mask 08 - Reduce shoulder and upper bicep size (u8)
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        public byte Mask08ReduceShoulderAndUpperBicepSize
        {
            get => (byte)CellsByName["Mask08ReduceShoulderAndUpperBicepSize"].Value;
            set => CellsByName["Mask08ReduceShoulderAndUpperBicepSize"].Value = value;
        }


        // Def="u8 invisibleFlag_SexVer09"
        /// <summary>
        /// Mask 09 - Hide elbows (u8)
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        public byte Mask09HideElbows
        {
            get => (byte)CellsByName["Mask09HideElbows"].Value;
            set => CellsByName["Mask09HideElbows"].Value = value;
        }


        // Def="u8 invisibleFlag_SexVer10"
        /// <summary>
        /// Mask 10 - Hide lower forearms (u8)
        /// </summary>
        /// <remarks>
        /// collar
        /// </remarks>
        public byte Mask10HideLowerForearms
        {
            get => (byte)CellsByName["Mask10HideLowerForearms"].Value;
            set => CellsByName["Mask10HideLowerForearms"].Value = value;
        }


        // Def="u8 invisibleFlag_SexVer11"
        /// <summary>
        /// Mask 11 - Hide right hand (u8)
        /// </summary>
        /// <remarks>
        /// Around the collar
        /// </remarks>
        public byte Mask11HideRightHand
        {
            get => (byte)CellsByName["Mask11HideRightHand"].Value;
            set => CellsByName["Mask11HideRightHand"].Value = value;
        }


        // Def="u8 invisibleFlag_SexVer12"
        /// <summary>
        /// Mask 12 - Hide upper leg area (u8)
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        public byte Mask12HideUpperLegArea
        {
            get => (byte)CellsByName["Mask12HideUpperLegArea"].Value;
            set => CellsByName["Mask12HideUpperLegArea"].Value = value;
        }


        // Def="u8 invisibleFlag_SexVer13"
        /// <summary>
        /// Mask 13 - Hide left hand (u8)
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        public byte Mask13HideLeftHand
        {
            get => (byte)CellsByName["Mask13HideLeftHand"].Value;
            set => CellsByName["Mask13HideLeftHand"].Value = value;
        }


        // Def="u8 invisibleFlag_SexVer14"
        /// <summary>
        /// Mask 14 - Hide lower leg area (u8)
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        public byte Mask14HideLowerLegArea
        {
            get => (byte)CellsByName["Mask14HideLowerLegArea"].Value;
            set => CellsByName["Mask14HideLowerLegArea"].Value = value;
        }


        // Def="u8 invisibleFlag_SexVer15"
        /// <summary>
        /// Mask 15 - Hide calves (u8)
        /// </summary>
        /// <remarks>
        /// Hood hem
        /// </remarks>
        public byte Mask15HideCalves
        {
            get => (byte)CellsByName["Mask15HideCalves"].Value;
            set => CellsByName["Mask15HideCalves"].Value = value;
        }


        // Def="u8 invisibleFlag_SexVer16"
        /// <summary>
        /// Mask 16 - Hide feet (u8)
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        public byte Mask16HideFeet
        {
            get => (byte)CellsByName["Mask16HideFeet"].Value;
            set => CellsByName["Mask16HideFeet"].Value = value;
        }


        // Def="u8 invisibleFlag_SexVer17"
        /// <summary>
        /// Mask 17 - Alter Armor Part (u8)
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        public byte Mask17AlterArmorPart
        {
            get => (byte)CellsByName["Mask17AlterArmorPart"].Value;
            set => CellsByName["Mask17AlterArmorPart"].Value = value;
        }


        // Def="u8 invisibleFlag_SexVer18"
        /// <summary>
        /// Mask 18 - Alter Armor Part (u8)
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        public byte Mask18AlterArmorPart
        {
            get => (byte)CellsByName["Mask18AlterArmorPart"].Value;
            set => CellsByName["Mask18AlterArmorPart"].Value = value;
        }


        // Def="u8 invisibleFlag_SexVer19"
        /// <summary>
        /// Mask 19 - Alter Armor Part (u8)
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        public byte Mask19AlterArmorPart
        {
            get => (byte)CellsByName["Mask19AlterArmorPart"].Value;
            set => CellsByName["Mask19AlterArmorPart"].Value = value;
        }


        // Def="u8 invisibleFlag_SexVer20"
        /// <summary>
        /// Mask 20 - Alter Armor Part (u8)
        /// </summary>
        /// <remarks>
        /// Sleeve A
        /// </remarks>
        public byte Mask20AlterArmorPart
        {
            get => (byte)CellsByName["Mask20AlterArmorPart"].Value;
            set => CellsByName["Mask20AlterArmorPart"].Value = value;
        }


        // Def="u8 invisibleFlag_SexVer21"
        /// <summary>
        /// Mask 21 - Alter Armor Part (u8)
        /// </summary>
        /// <remarks>
        /// Sleeve B
        /// </remarks>
        public byte Mask21AlterArmorPart
        {
            get => (byte)CellsByName["Mask21AlterArmorPart"].Value;
            set => CellsByName["Mask21AlterArmorPart"].Value = value;
        }


        // Def="u8 invisibleFlag_SexVer22"
        /// <summary>
        /// Mask 22 - Alter Armor Part (u8)
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        public byte Mask22AlterArmorPart
        {
            get => (byte)CellsByName["Mask22AlterArmorPart"].Value;
            set => CellsByName["Mask22AlterArmorPart"].Value = value;
        }


        // Def="u8 invisibleFlag_SexVer23"
        /// <summary>
        /// Mask 23 - Alter Armor Part (u8)
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        public byte Mask23AlterArmorPart
        {
            get => (byte)CellsByName["Mask23AlterArmorPart"].Value;
            set => CellsByName["Mask23AlterArmorPart"].Value = value;
        }


        // Def="u8 invisibleFlag_SexVer24"
        /// <summary>
        /// Mask 24 - Alter Armor Part (u8)
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        public byte Mask24AlterArmorPart
        {
            get => (byte)CellsByName["Mask24AlterArmorPart"].Value;
            set => CellsByName["Mask24AlterArmorPart"].Value = value;
        }


        // Def="u8 invisibleFlag_SexVer25"
        /// <summary>
        /// Mask 25 - Alter Armor Part (u8)
        /// </summary>
        /// <remarks>
        /// arm
        /// </remarks>
        public byte Mask25AlterArmorPart
        {
            get => (byte)CellsByName["Mask25AlterArmorPart"].Value;
            set => CellsByName["Mask25AlterArmorPart"].Value = value;
        }


        // Def="u8 invisibleFlag_SexVer26"
        /// <summary>
        /// Mask 26 - Hide arms (for specific chest armor) (u8)
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        public byte Mask26HideArmsForSpecificChestArmor
        {
            get => (byte)CellsByName["Mask26HideArmsForSpecificChestArmor"].Value;
            set => CellsByName["Mask26HideArmsForSpecificChestArmor"].Value = value;
        }


        // Def="u8 invisibleFlag_SexVer27"
        /// <summary>
        /// Mask 27 - Alter Armor Part (u8)
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        public byte Mask27AlterArmorPart
        {
            get => (byte)CellsByName["Mask27AlterArmorPart"].Value;
            set => CellsByName["Mask27AlterArmorPart"].Value = value;
        }


        // Def="u8 invisibleFlag_SexVer28"
        /// <summary>
        /// Mask 28 - Hide shoulders and shoulder armor (u8)
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        public byte Mask28HideShouldersAndShoulderArmor
        {
            get => (byte)CellsByName["Mask28HideShouldersAndShoulderArmor"].Value;
            set => CellsByName["Mask28HideShouldersAndShoulderArmor"].Value = value;
        }


        // Def="u8 invisibleFlag_SexVer29"
        /// <summary>
        /// Mask 29 - Hide wrist cloth (u8)
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        public byte Mask29HideWristCloth
        {
            get => (byte)CellsByName["Mask29HideWristCloth"].Value;
            set => CellsByName["Mask29HideWristCloth"].Value = value;
        }


        // Def="u8 invisibleFlag_SexVer30"
        /// <summary>
        /// Mask 30 - Alter Armor Part (u8)
        /// </summary>
        /// <remarks>
        /// belt
        /// </remarks>
        public byte Mask30AlterArmorPart
        {
            get => (byte)CellsByName["Mask30AlterArmorPart"].Value;
            set => CellsByName["Mask30AlterArmorPart"].Value = value;
        }


        // Def="u8 invisibleFlag_SexVer31"
        /// <summary>
        /// Mask 31 - Alter Armor Part (u8)
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        public byte Mask31AlterArmorPart
        {
            get => (byte)CellsByName["Mask31AlterArmorPart"].Value;
            set => CellsByName["Mask31AlterArmorPart"].Value = value;
        }


        // Def="u8 invisibleFlag_SexVer32"
        /// <summary>
        /// Mask 32 - Alter Armor Part (u8)
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        public byte Mask32AlterArmorPart
        {
            get => (byte)CellsByName["Mask32AlterArmorPart"].Value;
            set => CellsByName["Mask32AlterArmorPart"].Value = value;
        }


        // Def="u8 invisibleFlag_SexVer33"
        /// <summary>
        /// Mask 33 - Alter Armor Part (u8)
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        public byte Mask33AlterArmorPart
        {
            get => (byte)CellsByName["Mask33AlterArmorPart"].Value;
            set => CellsByName["Mask33AlterArmorPart"].Value = value;
        }


        // Def="u8 invisibleFlag_SexVer34"
        /// <summary>
        /// Mask 34 - Alter Neck/Shoulder Part (u8)
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        public byte Mask34AlterNeckShoulderPart
        {
            get => (byte)CellsByName["Mask34AlterNeckShoulderPart"].Value;
            set => CellsByName["Mask34AlterNeckShoulderPart"].Value = value;
        }


        // Def="u8 invisibleFlag_SexVer35"
        /// <summary>
        /// Mask 35 - Alter Lower Stomach Part (u8)
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        public byte Mask35AlterLowerStomachPart
        {
            get => (byte)CellsByName["Mask35AlterLowerStomachPart"].Value;
            set => CellsByName["Mask35AlterLowerStomachPart"].Value = value;
        }


        // Def="u8 invisibleFlag_SexVer36"
        /// <summary>
        /// Mask 36 - Alter Hood Part (u8)
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        public byte Mask36AlterHoodPart
        {
            get => (byte)CellsByName["Mask36AlterHoodPart"].Value;
            set => CellsByName["Mask36AlterHoodPart"].Value = value;
        }


        // Def="u8 invisibleFlag_SexVer37"
        /// <summary>
        /// Mask 37 - Alter Armor Part (u8)
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        public byte Mask37AlterArmorPart
        {
            get => (byte)CellsByName["Mask37AlterArmorPart"].Value;
            set => CellsByName["Mask37AlterArmorPart"].Value = value;
        }


        // Def="u8 invisibleFlag_SexVer38"
        /// <summary>
        /// Mask 38 - Hide Left Shoulder Part (u8)
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        public byte Mask38HideLeftShoulderPart
        {
            get => (byte)CellsByName["Mask38HideLeftShoulderPart"].Value;
            set => CellsByName["Mask38HideLeftShoulderPart"].Value = value;
        }


        // Def="u8 invisibleFlag_SexVer39"
        /// <summary>
        /// Mask 39 - Hide Right Shoulder Part (u8)
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        public byte Mask39HideRightShoulderPart
        {
            get => (byte)CellsByName["Mask39HideRightShoulderPart"].Value;
            set => CellsByName["Mask39HideRightShoulderPart"].Value = value;
        }


        // Def="u8 invisibleFlag_SexVer40"
        /// <summary>
        /// Mask 40 - Alter Armor Part (u8)
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        public byte Mask40AlterArmorPart
        {
            get => (byte)CellsByName["Mask40AlterArmorPart"].Value;
            set => CellsByName["Mask40AlterArmorPart"].Value = value;
        }


        // Def="u8 invisibleFlag_SexVer41"
        /// <summary>
        /// Mask 41 - Alter Armor Part (u8)
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        public byte Mask41AlterArmorPart
        {
            get => (byte)CellsByName["Mask41AlterArmorPart"].Value;
            set => CellsByName["Mask41AlterArmorPart"].Value = value;
        }


        // Def="u8 invisibleFlag_SexVer42"
        /// <summary>
        /// Mask 42 - Alter Armor Part (u8)
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        public byte Mask42AlterArmorPart
        {
            get => (byte)CellsByName["Mask42AlterArmorPart"].Value;
            set => CellsByName["Mask42AlterArmorPart"].Value = value;
        }


        // Def="u8 invisibleFlag_SexVer43"
        /// <summary>
        /// Mask 43 - Alter Armor Part (u8)
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        public byte Mask43AlterArmorPart
        {
            get => (byte)CellsByName["Mask43AlterArmorPart"].Value;
            set => CellsByName["Mask43AlterArmorPart"].Value = value;
        }


        // Def="u8 invisibleFlag_SexVer44"
        /// <summary>
        /// Mask 44 - Alter Armor Part (u8)
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        public byte Mask44AlterArmorPart
        {
            get => (byte)CellsByName["Mask44AlterArmorPart"].Value;
            set => CellsByName["Mask44AlterArmorPart"].Value = value;
        }


        // Def="u8 invisibleFlag_SexVer45"
        /// <summary>
        /// Mask 45 - Alter Armor Part (u8)
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        public byte Mask45AlterArmorPart
        {
            get => (byte)CellsByName["Mask45AlterArmorPart"].Value;
            set => CellsByName["Mask45AlterArmorPart"].Value = value;
        }


        // Def="u8 invisibleFlag_SexVer46"
        /// <summary>
        /// Mask 46 - Alter Armor Part (u8)
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        public byte Mask46AlterArmorPart
        {
            get => (byte)CellsByName["Mask46AlterArmorPart"].Value;
            set => CellsByName["Mask46AlterArmorPart"].Value = value;
        }


        // Def="u8 invisibleFlag_SexVer47"
        /// <summary>
        /// Mask 47 - Alter Armor Part (u8)
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        public byte Mask47AlterArmorPart
        {
            get => (byte)CellsByName["Mask47AlterArmorPart"].Value;
            set => CellsByName["Mask47AlterArmorPart"].Value = value;
        }


        // Def="u8 invisibleFlag_SexVer48"
        /// <summary>
        /// Mask 48 - Alter Armor Part (u8)
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        public byte Mask48AlterArmorPart
        {
            get => (byte)CellsByName["Mask48AlterArmorPart"].Value;
            set => CellsByName["Mask48AlterArmorPart"].Value = value;
        }


        // Def="u8 invisibleFlag_SexVer49"
        /// <summary>
        /// Mask 49 - Alter Armor Part (u8)
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        public byte Mask49AlterArmorPart
        {
            get => (byte)CellsByName["Mask49AlterArmorPart"].Value;
            set => CellsByName["Mask49AlterArmorPart"].Value = value;
        }


        // Def="u8 invisibleFlag_SexVer50"
        /// <summary>
        /// Mask 50 - Alter Armor Part (u8)
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        public byte Mask50AlterArmorPart
        {
            get => (byte)CellsByName["Mask50AlterArmorPart"].Value;
            set => CellsByName["Mask50AlterArmorPart"].Value = value;
        }


        // Def="u8 invisibleFlag_SexVer51"
        /// <summary>
        /// Mask 51 - Head: Hide Leg Part (u8)
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        public byte Mask51HeadHideLegPart
        {
            get => (byte)CellsByName["Mask51HeadHideLegPart"].Value;
            set => CellsByName["Mask51HeadHideLegPart"].Value = value;
        }


        // Def="u8 invisibleFlag_SexVer52"
        /// <summary>
        /// Mask 52 - Alter Armor Part (u8)
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        public byte Mask52AlterArmorPart
        {
            get => (byte)CellsByName["Mask52AlterArmorPart"].Value;
            set => CellsByName["Mask52AlterArmorPart"].Value = value;
        }


        // Def="u8 invisibleFlag_SexVer53"
        /// <summary>
        /// Mask 53 - Head: Hide Knee Part (u8)
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        public byte Mask53HeadHideKneePart
        {
            get => (byte)CellsByName["Mask53HeadHideKneePart"].Value;
            set => CellsByName["Mask53HeadHideKneePart"].Value = value;
        }


        // Def="u8 invisibleFlag_SexVer54"
        /// <summary>
        /// Mask 54 - Alter Armor Part (u8)
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        public byte Mask54AlterArmorPart
        {
            get => (byte)CellsByName["Mask54AlterArmorPart"].Value;
            set => CellsByName["Mask54AlterArmorPart"].Value = value;
        }


        // Def="u8 invisibleFlag_SexVer55"
        /// <summary>
        /// Mask 55 - Head: Hide Belt Part (u8)
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        public byte Mask55HeadHideBeltPart
        {
            get => (byte)CellsByName["Mask55HeadHideBeltPart"].Value;
            set => CellsByName["Mask55HeadHideBeltPart"].Value = value;
        }


        // Def="u8 invisibleFlag_SexVer56"
        /// <summary>
        /// Mask 56 - Alter Armor Part (u8)
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        public byte Mask56AlterArmorPart
        {
            get => (byte)CellsByName["Mask56AlterArmorPart"].Value;
            set => CellsByName["Mask56AlterArmorPart"].Value = value;
        }


        // Def="u8 invisibleFlag_SexVer57"
        /// <summary>
        /// Mask 57 - Head: Hide Skirt Part (u8)
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        public byte Mask57HeadHideSkirtPart
        {
            get => (byte)CellsByName["Mask57HeadHideSkirtPart"].Value;
            set => CellsByName["Mask57HeadHideSkirtPart"].Value = value;
        }


        // Def="u8 invisibleFlag_SexVer58"
        /// <summary>
        /// Mask 58 - Alter Armor Part (u8)
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        public byte Mask58AlterArmorPart
        {
            get => (byte)CellsByName["Mask58AlterArmorPart"].Value;
            set => CellsByName["Mask58AlterArmorPart"].Value = value;
        }


        // Def="u8 invisibleFlag_SexVer59"
        /// <summary>
        /// Mask 59 - Alter Armor Part (u8)
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        public byte Mask59AlterArmorPart
        {
            get => (byte)CellsByName["Mask59AlterArmorPart"].Value;
            set => CellsByName["Mask59AlterArmorPart"].Value = value;
        }


        // Def="u8 invisibleFlag_SexVer60"
        /// <summary>
        /// Mask 60 - Hide hair scalp (u8)
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        public byte Mask60HideHairScalp
        {
            get => (byte)CellsByName["Mask60HideHairScalp"].Value;
            set => CellsByName["Mask60HideHairScalp"].Value = value;
        }


        // Def="u8 invisibleFlag_SexVer61"
        /// <summary>
        /// Mask 61 - Hide hair low (u8)
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        public byte Mask61HideHairLow
        {
            get => (byte)CellsByName["Mask61HideHairLow"].Value;
            set => CellsByName["Mask61HideHairLow"].Value = value;
        }


        // Def="u8 invisibleFlag_SexVer62"
        /// <summary>
        /// Mask 62 - Alter Armor Part (u8)
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        public byte Mask62AlterArmorPart
        {
            get => (byte)CellsByName["Mask62AlterArmorPart"].Value;
            set => CellsByName["Mask62AlterArmorPart"].Value = value;
        }


        // Def="u8 invisibleFlag_SexVer63"
        /// <summary>
        /// Mask 63 - Hide hair top in (u8)
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        public byte Mask63HideHairTopIn
        {
            get => (byte)CellsByName["Mask63HideHairTopIn"].Value;
            set => CellsByName["Mask63HideHairTopIn"].Value = value;
        }


        // Def="u8 invisibleFlag_SexVer64"
        /// <summary>
        /// Mask 64 - Hide hair top out (u8)
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        public byte Mask64HideHairTopOut
        {
            get => (byte)CellsByName["Mask64HideHairTopOut"].Value;
            set => CellsByName["Mask64HideHairTopOut"].Value = value;
        }


        // Def="u8 invisibleFlag_SexVer65"
        /// <summary>
        /// Mask 65 - Hide hair front in (u8)
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        public byte Mask65HideHairFrontIn
        {
            get => (byte)CellsByName["Mask65HideHairFrontIn"].Value;
            set => CellsByName["Mask65HideHairFrontIn"].Value = value;
        }


        // Def="u8 invisibleFlag_SexVer66"
        /// <summary>
        /// Mask 66 - Hide hair front out (u8)
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        public byte Mask66HideHairFrontOut
        {
            get => (byte)CellsByName["Mask66HideHairFrontOut"].Value;
            set => CellsByName["Mask66HideHairFrontOut"].Value = value;
        }


        // Def="u8 invisibleFlag_SexVer67"
        /// <summary>
        /// Mask 67 - Hide hair sides (u8)
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        public byte Mask67HideHairSides
        {
            get => (byte)CellsByName["Mask67HideHairSides"].Value;
            set => CellsByName["Mask67HideHairSides"].Value = value;
        }


        // Def="u8 invisibleFlag_SexVer68"
        /// <summary>
        /// Mask 68 - Hide hair back (u8)
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        public byte Mask68HideHairBack
        {
            get => (byte)CellsByName["Mask68HideHairBack"].Value;
            set => CellsByName["Mask68HideHairBack"].Value = value;
        }


        // Def="u8 invisibleFlag_SexVer69"
        /// <summary>
        /// Mask 69 - Hide ponytail (u8)
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        public byte Mask69HidePonytail
        {
            get => (byte)CellsByName["Mask69HidePonytail"].Value;
            set => CellsByName["Mask69HidePonytail"].Value = value;
        }


        // Def="u8 invisibleFlag_SexVer70"
        /// <summary>
        /// Mask 70 - Alter Armor Part (u8)
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        public byte Mask70AlterArmorPart
        {
            get => (byte)CellsByName["Mask70AlterArmorPart"].Value;
            set => CellsByName["Mask70AlterArmorPart"].Value = value;
        }


        // Def="u8 invisibleFlag_SexVer71"
        /// <summary>
        /// Mask 71 - Alter Armor Part (u8)
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        public byte Mask71AlterArmorPart
        {
            get => (byte)CellsByName["Mask71AlterArmorPart"].Value;
            set => CellsByName["Mask71AlterArmorPart"].Value = value;
        }


        // Def="u8 invisibleFlag_SexVer72"
        /// <summary>
        /// Mask 72 - Alter Prisoner Part (u8)
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        public byte Mask72AlterPrisonerPart
        {
            get => (byte)CellsByName["Mask72AlterPrisonerPart"].Value;
            set => CellsByName["Mask72AlterPrisonerPart"].Value = value;
        }


        // Def="u8 invisibleFlag_SexVer73"
        /// <summary>
        /// Mask 73 - Alter Fia Clothing Part (u8)
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        public byte Mask73AlterFiaClothingPart
        {
            get => (byte)CellsByName["Mask73AlterFiaClothingPart"].Value;
            set => CellsByName["Mask73AlterFiaClothingPart"].Value = value;
        }


        // Def="u8 invisibleFlag_SexVer74"
        /// <summary>
        /// Mask 74 - Alter Armor Part (u8)
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        public byte Mask74AlterArmorPart
        {
            get => (byte)CellsByName["Mask74AlterArmorPart"].Value;
            set => CellsByName["Mask74AlterArmorPart"].Value = value;
        }


        // Def="u8 invisibleFlag_SexVer75"
        /// <summary>
        /// Mask 75 - Alter Armor Part (u8)
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        public byte Mask75AlterArmorPart
        {
            get => (byte)CellsByName["Mask75AlterArmorPart"].Value;
            set => CellsByName["Mask75AlterArmorPart"].Value = value;
        }


        // Def="u8 invisibleFlag_SexVer76"
        /// <summary>
        /// Mask 76 - Alter Armor Part (u8)
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        public byte Mask76AlterArmorPart
        {
            get => (byte)CellsByName["Mask76AlterArmorPart"].Value;
            set => CellsByName["Mask76AlterArmorPart"].Value = value;
        }


        // Def="u8 invisibleFlag_SexVer77"
        /// <summary>
        /// Mask 77 - Alter Armor Part (u8)
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        public byte Mask77AlterArmorPart
        {
            get => (byte)CellsByName["Mask77AlterArmorPart"].Value;
            set => CellsByName["Mask77AlterArmorPart"].Value = value;
        }


        // Def="u8 invisibleFlag_SexVer78"
        /// <summary>
        /// Mask 78 - Alter Armor Part (u8)
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        public byte Mask78AlterArmorPart
        {
            get => (byte)CellsByName["Mask78AlterArmorPart"].Value;
            set => CellsByName["Mask78AlterArmorPart"].Value = value;
        }


        // Def="u8 invisibleFlag_SexVer79"
        /// <summary>
        /// Mask 79 - Alter Armor Part (u8)
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        public byte Mask79AlterArmorPart
        {
            get => (byte)CellsByName["Mask79AlterArmorPart"].Value;
            set => CellsByName["Mask79AlterArmorPart"].Value = value;
        }


        // Def="u8 invisibleFlag_SexVer80"
        /// <summary>
        /// Mask 80 - Alter Armor Part (u8)
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        public byte Mask80AlterArmorPart
        {
            get => (byte)CellsByName["Mask80AlterArmorPart"].Value;
            set => CellsByName["Mask80AlterArmorPart"].Value = value;
        }


        // Def="u8 invisibleFlag_SexVer81"
        /// <summary>
        /// Mask 81 - Alter Armor Part (u8)
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        public byte Mask81AlterArmorPart
        {
            get => (byte)CellsByName["Mask81AlterArmorPart"].Value;
            set => CellsByName["Mask81AlterArmorPart"].Value = value;
        }


        // Def="u8 invisibleFlag_SexVer82"
        /// <summary>
        /// Mask 82 - Alter Armor Part (u8)
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        public byte Mask82AlterArmorPart
        {
            get => (byte)CellsByName["Mask82AlterArmorPart"].Value;
            set => CellsByName["Mask82AlterArmorPart"].Value = value;
        }


        // Def="u8 invisibleFlag_SexVer83"
        /// <summary>
        /// Mask 83 - Alter Armor Part (u8)
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        public byte Mask83AlterArmorPart
        {
            get => (byte)CellsByName["Mask83AlterArmorPart"].Value;
            set => CellsByName["Mask83AlterArmorPart"].Value = value;
        }


        // Def="u8 invisibleFlag_SexVer84"
        /// <summary>
        /// Mask 84 - Alter Armor Part (u8)
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        public byte Mask84AlterArmorPart
        {
            get => (byte)CellsByName["Mask84AlterArmorPart"].Value;
            set => CellsByName["Mask84AlterArmorPart"].Value = value;
        }


        // Def="u8 invisibleFlag_SexVer85"
        /// <summary>
        /// Mask 85 - Alter Armor Part (u8)
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        public byte Mask85AlterArmorPart
        {
            get => (byte)CellsByName["Mask85AlterArmorPart"].Value;
            set => CellsByName["Mask85AlterArmorPart"].Value = value;
        }


        // Def="u8 invisibleFlag_SexVer86"
        /// <summary>
        /// Mask 86 - Alter Armor Part (u8)
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        public byte Mask86AlterArmorPart
        {
            get => (byte)CellsByName["Mask86AlterArmorPart"].Value;
            set => CellsByName["Mask86AlterArmorPart"].Value = value;
        }


        // Def="u8 invisibleFlag_SexVer87"
        /// <summary>
        /// Mask 87 - Alter Armor Part (u8)
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        public byte Mask87AlterArmorPart
        {
            get => (byte)CellsByName["Mask87AlterArmorPart"].Value;
            set => CellsByName["Mask87AlterArmorPart"].Value = value;
        }


        // Def="u8 invisibleFlag_SexVer88"
        /// <summary>
        /// Mask 88 - Alter Armor Part (u8)
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        public byte Mask88AlterArmorPart
        {
            get => (byte)CellsByName["Mask88AlterArmorPart"].Value;
            set => CellsByName["Mask88AlterArmorPart"].Value = value;
        }


        // Def="u8 invisibleFlag_SexVer89"
        /// <summary>
        /// Mask 89 - Alter Armor Part (u8)
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        public byte Mask89AlterArmorPart
        {
            get => (byte)CellsByName["Mask89AlterArmorPart"].Value;
            set => CellsByName["Mask89AlterArmorPart"].Value = value;
        }


        // Def="u8 invisibleFlag_SexVer90"
        /// <summary>
        /// Mask 90 - Alter Armor Part (u8)
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        public byte Mask90AlterArmorPart
        {
            get => (byte)CellsByName["Mask90AlterArmorPart"].Value;
            set => CellsByName["Mask90AlterArmorPart"].Value = value;
        }


        // Def="u8 invisibleFlag_SexVer91"
        /// <summary>
        /// Mask 91 - Alter Armor Part (u8)
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        public byte Mask91AlterArmorPart
        {
            get => (byte)CellsByName["Mask91AlterArmorPart"].Value;
            set => CellsByName["Mask91AlterArmorPart"].Value = value;
        }


        // Def="u8 invisibleFlag_SexVer92"
        /// <summary>
        /// Mask 92 - Alter Armor Part (u8)
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        public byte Mask92AlterArmorPart
        {
            get => (byte)CellsByName["Mask92AlterArmorPart"].Value;
            set => CellsByName["Mask92AlterArmorPart"].Value = value;
        }


        // Def="u8 invisibleFlag_SexVer93"
        /// <summary>
        /// Mask 93 - Alter Armor Part (u8)
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        public byte Mask93AlterArmorPart
        {
            get => (byte)CellsByName["Mask93AlterArmorPart"].Value;
            set => CellsByName["Mask93AlterArmorPart"].Value = value;
        }


        // Def="u8 invisibleFlag_SexVer94"
        /// <summary>
        /// Mask 94 - Alter Armor Part (u8)
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        public byte Mask94AlterArmorPart
        {
            get => (byte)CellsByName["Mask94AlterArmorPart"].Value;
            set => CellsByName["Mask94AlterArmorPart"].Value = value;
        }


        // Def="u8 invisibleFlag_SexVer95"
        /// <summary>
        /// Mask 95 - Alter Armor Part (u8)
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        public byte Mask95AlterArmorPart
        {
            get => (byte)CellsByName["Mask95AlterArmorPart"].Value;
            set => CellsByName["Mask95AlterArmorPart"].Value = value;
        }


    }
}

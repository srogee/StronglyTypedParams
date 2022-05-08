
            namespace StronglyTypedParams
            {
                // EQUIP_PARAM_WEAPON_ST
                public class EquipParamWeapon : ParamRow
                {
                    public EquipParamWeapon() : base()
                    {
                    }
            

            // Def="u8 disableParam_NT:1"
            /// <summary>
            /// Disable Param - Network Test (u8)
            /// </summary>
            /// <remarks>
            /// Parameters marked with ○ are excluded in the NT version package.
            /// </remarks>
            public BoolCirclecrossType DisableParamNetworkTest 
            {
                get => (BoolCirclecrossType)CellsByName["DisableParamNetworkTest"].Value;
                set => CellsByName["DisableParamNetworkTest"].Value = (byte)value;
            }
            

            // Def="dummy8 disableParamReserve1:7"
            /// <summary>
            /// Reserve for Package Output [1] (dummy8)
            /// </summary>
            /// <remarks>
            /// Reserve for package output 1
            /// </remarks>
            public object ReserveForPackageOutput1 
            {
                get => (object)CellsByName["ReserveForPackageOutput1"].Value;
                set => CellsByName["ReserveForPackageOutput1"].Value = (object)value;
            }
            

            // Def="dummy8 disableParamReserve2[3]"
            /// <summary>
            /// Reserve for Package Output [2] (dummy8)
            /// </summary>
            /// <remarks>
            /// Reserve for package output 2
            /// </remarks>
            public object ReserveForPackageOutput2 
            {
                get => (object)CellsByName["ReserveForPackageOutput2"].Value;
                set => CellsByName["ReserveForPackageOutput2"].Value = (object)value;
            }
            

            // Def="s32 behaviorVariationId"
            /// <summary>
            /// Behavior Variation ID (s32)
            /// </summary>
            /// <remarks>
            /// Used when determining the action parameter ID to be referenced during an attack
            /// </remarks>
            public int BehaviorVariationID 
            {
                get => (int)CellsByName["BehaviorVariationID"].Value;
                set => CellsByName["BehaviorVariationID"].Value = (int)value;
            }
            

            // Def="s32 sortId"
            /// <summary>
            /// Sort ID (s32)
            /// </summary>
            /// <remarks>
            /// Sort ID (-1: Do not collect) (7 digits is the limit in s32 to add the enhancement level in the program)
            /// </remarks>
            public int SortID 
            {
                get => (int)CellsByName["SortID"].Value;
                set => CellsByName["SortID"].Value = (int)value;
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
                set => CellsByName["WanderingEquipID"].Value = (uint)value;
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
                set => CellsByName["Weight"].Value = (float)value;
            }
            

            // Def="f32 weaponWeightRate"
            /// <summary>
            /// Weapon Weight % (f32)
            /// </summary>
            /// <remarks>
            /// Equipment weight ratio
            /// </remarks>
            public float WeaponWeightPercent 
            {
                get => (float)CellsByName["WeaponWeightPercent"].Value;
                set => CellsByName["WeaponWeightPercent"].Value = (float)value;
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
                set => CellsByName["RepairPrice"].Value = (int)value;
            }
            

            // Def="s32 reinforcePrice"
            /// <summary>
            /// Reinforcement Price (s32)
            /// </summary>
            /// <remarks>
            /// Enhanced price
            /// </remarks>
            public int ReinforcementPrice 
            {
                get => (int)CellsByName["ReinforcementPrice"].Value;
                set => CellsByName["ReinforcementPrice"].Value = (int)value;
            }
            

            // Def="s32 sellValue"
            /// <summary>
            /// Sell Price (s32)
            /// </summary>
            /// <remarks>
            /// Selling price
            /// </remarks>
            public int SellPrice 
            {
                get => (int)CellsByName["SellPrice"].Value;
                set => CellsByName["SellPrice"].Value = (int)value;
            }
            

            // Def="f32 correctStrength"
            /// <summary>
            /// Correction: STR (f32)
            /// </summary>
            /// <remarks>
            /// Charapara correction value.
            /// </remarks>
            public float CorrectionSTR 
            {
                get => (float)CellsByName["CorrectionSTR"].Value;
                set => CellsByName["CorrectionSTR"].Value = (float)value;
            }
            

            // Def="f32 correctAgility"
            /// <summary>
            /// Correction: DEX (f32)
            /// </summary>
            /// <remarks>
            /// Charapara correction value.
            /// </remarks>
            public float CorrectionDEX 
            {
                get => (float)CellsByName["CorrectionDEX"].Value;
                set => CellsByName["CorrectionDEX"].Value = (float)value;
            }
            

            // Def="f32 correctMagic"
            /// <summary>
            /// Correction: INT (f32)
            /// </summary>
            /// <remarks>
            /// Charapara correction value.
            /// </remarks>
            public float CorrectionINT 
            {
                get => (float)CellsByName["CorrectionINT"].Value;
                set => CellsByName["CorrectionINT"].Value = (float)value;
            }
            

            // Def="f32 correctFaith"
            /// <summary>
            /// Correction: FTH (f32)
            /// </summary>
            /// <remarks>
            /// Charapara correction value.
            /// </remarks>
            public float CorrectionFTH 
            {
                get => (float)CellsByName["CorrectionFTH"].Value;
                set => CellsByName["CorrectionFTH"].Value = (float)value;
            }
            

            // Def="f32 physGuardCutRate"
            /// <summary>
            /// Guard Absorption: Physical (f32)
            /// </summary>
            /// <remarks>
            /// Set the damage cut rate when guarding for each attack
            /// </remarks>
            public float GuardAbsorptionPhysical 
            {
                get => (float)CellsByName["GuardAbsorptionPhysical"].Value;
                set => CellsByName["GuardAbsorptionPhysical"].Value = (float)value;
            }
            

            // Def="f32 magGuardCutRate"
            /// <summary>
            /// Guard Absorption: Magic (f32)
            /// </summary>
            /// <remarks>
            /// If it is not a guard attack, enter 0
            /// </remarks>
            public float GuardAbsorptionMagic 
            {
                get => (float)CellsByName["GuardAbsorptionMagic"].Value;
                set => CellsByName["GuardAbsorptionMagic"].Value = (float)value;
            }
            

            // Def="f32 fireGuardCutRate"
            /// <summary>
            /// Guard Absorption: Fire (f32)
            /// </summary>
            /// <remarks>
            /// How much to cut the fire attack?
            /// </remarks>
            public float GuardAbsorptionFire 
            {
                get => (float)CellsByName["GuardAbsorptionFire"].Value;
                set => CellsByName["GuardAbsorptionFire"].Value = (float)value;
            }
            

            // Def="f32 thunGuardCutRate"
            /// <summary>
            /// Guard Absorption: Lightning (f32)
            /// </summary>
            /// <remarks>
            /// How much to cut the electric shock attack?
            /// </remarks>
            public float GuardAbsorptionLightning 
            {
                get => (float)CellsByName["GuardAbsorptionLightning"].Value;
                set => CellsByName["GuardAbsorptionLightning"].Value = (float)value;
            }
            

            // Def="s32 spEffectBehaviorId0 = -1"
            /// <summary>
            /// Behavior SpEffect 1 (s32)
            /// </summary>
            /// <remarks>
            /// Register when adding special effects to weapons
            /// </remarks>
            public int BehaviorSpEffect1 
            {
                get => (int)CellsByName["BehaviorSpEffect1"].Value;
                set => CellsByName["BehaviorSpEffect1"].Value = (int)value;
            }
            

            // Def="s32 spEffectBehaviorId1 = -1"
            /// <summary>
            /// Behavior SpEffect 2 (s32)
            /// </summary>
            /// <remarks>
            /// Register when adding special effects to weapons
            /// </remarks>
            public int BehaviorSpEffect2 
            {
                get => (int)CellsByName["BehaviorSpEffect2"].Value;
                set => CellsByName["BehaviorSpEffect2"].Value = (int)value;
            }
            

            // Def="s32 spEffectBehaviorId2 = -1"
            /// <summary>
            /// Behavior SpEffect 3 (s32)
            /// </summary>
            /// <remarks>
            /// Register when adding special effects to weapons
            /// </remarks>
            public int BehaviorSpEffect3 
            {
                get => (int)CellsByName["BehaviorSpEffect3"].Value;
                set => CellsByName["BehaviorSpEffect3"].Value = (int)value;
            }
            

            // Def="s32 residentSpEffectId = -1"
            /// <summary>
            /// Passive SpEffect 1 (s32)
            /// </summary>
            /// <remarks>
            /// Resident special effect ID0
            /// </remarks>
            public int PassiveSpEffect1 
            {
                get => (int)CellsByName["PassiveSpEffect1"].Value;
                set => CellsByName["PassiveSpEffect1"].Value = (int)value;
            }
            

            // Def="s32 residentSpEffectId1 = -1"
            /// <summary>
            /// Passive SpEffect 2 (s32)
            /// </summary>
            /// <remarks>
            /// Resident special effect ID1
            /// </remarks>
            public int PassiveSpEffect2 
            {
                get => (int)CellsByName["PassiveSpEffect2"].Value;
                set => CellsByName["PassiveSpEffect2"].Value = (int)value;
            }
            

            // Def="s32 residentSpEffectId2 = -1"
            /// <summary>
            /// Passive SpEffect 3 (s32)
            /// </summary>
            /// <remarks>
            /// Resident special effect ID2
            /// </remarks>
            public int PassiveSpEffect3 
            {
                get => (int)CellsByName["PassiveSpEffect3"].Value;
                set => CellsByName["PassiveSpEffect3"].Value = (int)value;
            }
            

            // Def="s32 materialSetId = -1"
            /// <summary>
            /// Reinforcement Material Set ID (s32)
            /// </summary>
            /// <remarks>
            /// Material parameter ID required for weapon enhancement
            /// </remarks>
            public int ReinforcementMaterialSetID 
            {
                get => (int)CellsByName["ReinforcementMaterialSetID"].Value;
                set => CellsByName["ReinforcementMaterialSetID"].Value = (int)value;
            }
            

            // Def="s32 originEquipWep = -1"
            /// <summary>
            /// Origin Weapon +0 (s32)
            /// </summary>
            /// <remarks>
            /// This weapon's enhancement source weapon ID
            /// </remarks>
            public int OriginWeapon0 
            {
                get => (int)CellsByName["OriginWeapon0"].Value;
                set => CellsByName["OriginWeapon0"].Value = (int)value;
            }
            

            // Def="s32 originEquipWep1 = -1"
            /// <summary>
            /// Origin Weapon +1 (s32)
            /// </summary>
            /// <remarks>
            /// This weapon's enhancement source weapon ID1
            /// </remarks>
            public int OriginWeapon1 
            {
                get => (int)CellsByName["OriginWeapon1"].Value;
                set => CellsByName["OriginWeapon1"].Value = (int)value;
            }
            

            // Def="s32 originEquipWep2 = -1"
            /// <summary>
            /// Origin Weapon +2 (s32)
            /// </summary>
            /// <remarks>
            /// This weapon's enhancement source weapon ID2
            /// </remarks>
            public int OriginWeapon2 
            {
                get => (int)CellsByName["OriginWeapon2"].Value;
                set => CellsByName["OriginWeapon2"].Value = (int)value;
            }
            

            // Def="s32 originEquipWep3 = -1"
            /// <summary>
            /// Origin Weapon +3 (s32)
            /// </summary>
            /// <remarks>
            /// This weapon's enhancement source weapon ID3
            /// </remarks>
            public int OriginWeapon3 
            {
                get => (int)CellsByName["OriginWeapon3"].Value;
                set => CellsByName["OriginWeapon3"].Value = (int)value;
            }
            

            // Def="s32 originEquipWep4 = -1"
            /// <summary>
            /// Origin Weapon +4 (s32)
            /// </summary>
            /// <remarks>
            /// This weapon's enhancement source weapon ID 4
            /// </remarks>
            public int OriginWeapon4 
            {
                get => (int)CellsByName["OriginWeapon4"].Value;
                set => CellsByName["OriginWeapon4"].Value = (int)value;
            }
            

            // Def="s32 originEquipWep5 = -1"
            /// <summary>
            /// Origin Weapon +5 (s32)
            /// </summary>
            /// <remarks>
            /// This weapon's enhancement source weapon ID 5
            /// </remarks>
            public int OriginWeapon5 
            {
                get => (int)CellsByName["OriginWeapon5"].Value;
                set => CellsByName["OriginWeapon5"].Value = (int)value;
            }
            

            // Def="s32 originEquipWep6 = -1"
            /// <summary>
            /// Origin Weapon +6 (s32)
            /// </summary>
            /// <remarks>
            /// This weapon's enhancement source weapon ID 6
            /// </remarks>
            public int OriginWeapon6 
            {
                get => (int)CellsByName["OriginWeapon6"].Value;
                set => CellsByName["OriginWeapon6"].Value = (int)value;
            }
            

            // Def="s32 originEquipWep7 = -1"
            /// <summary>
            /// Origin Weapon +7 (s32)
            /// </summary>
            /// <remarks>
            /// This weapon's enhancement source weapon ID 7
            /// </remarks>
            public int OriginWeapon7 
            {
                get => (int)CellsByName["OriginWeapon7"].Value;
                set => CellsByName["OriginWeapon7"].Value = (int)value;
            }
            

            // Def="s32 originEquipWep8 = -1"
            /// <summary>
            /// Origin Weapon +8 (s32)
            /// </summary>
            /// <remarks>
            /// This weapon's enhancement source weapon ID8
            /// </remarks>
            public int OriginWeapon8 
            {
                get => (int)CellsByName["OriginWeapon8"].Value;
                set => CellsByName["OriginWeapon8"].Value = (int)value;
            }
            

            // Def="s32 originEquipWep9 = -1"
            /// <summary>
            /// Origin Weapon +9 (s32)
            /// </summary>
            /// <remarks>
            /// This weapon's enhancement source weapon ID 9
            /// </remarks>
            public int OriginWeapon9 
            {
                get => (int)CellsByName["OriginWeapon9"].Value;
                set => CellsByName["OriginWeapon9"].Value = (int)value;
            }
            

            // Def="s32 originEquipWep10 = -1"
            /// <summary>
            /// Origin Weapon +10 (s32)
            /// </summary>
            /// <remarks>
            /// This weapon's enhancement source weapon ID 10
            /// </remarks>
            public int OriginWeapon10 
            {
                get => (int)CellsByName["OriginWeapon10"].Value;
                set => CellsByName["OriginWeapon10"].Value = (int)value;
            }
            

            // Def="s32 originEquipWep11 = -1"
            /// <summary>
            /// Origin Weapon +11 (s32)
            /// </summary>
            /// <remarks>
            /// This weapon's enhancement source weapon ID 11
            /// </remarks>
            public int OriginWeapon11 
            {
                get => (int)CellsByName["OriginWeapon11"].Value;
                set => CellsByName["OriginWeapon11"].Value = (int)value;
            }
            

            // Def="s32 originEquipWep12 = -1"
            /// <summary>
            /// Origin Weapon +12 (s32)
            /// </summary>
            /// <remarks>
            /// This weapon's enhancement source weapon ID 12
            /// </remarks>
            public int OriginWeapon12 
            {
                get => (int)CellsByName["OriginWeapon12"].Value;
                set => CellsByName["OriginWeapon12"].Value = (int)value;
            }
            

            // Def="s32 originEquipWep13 = -1"
            /// <summary>
            /// Origin Weapon +13 (s32)
            /// </summary>
            /// <remarks>
            /// This weapon's enhancement source weapon ID 13
            /// </remarks>
            public int OriginWeapon13 
            {
                get => (int)CellsByName["OriginWeapon13"].Value;
                set => CellsByName["OriginWeapon13"].Value = (int)value;
            }
            

            // Def="s32 originEquipWep14 = -1"
            /// <summary>
            /// Origin Weapon +14 (s32)
            /// </summary>
            /// <remarks>
            /// This weapon's enhancement source weapon ID14
            /// </remarks>
            public int OriginWeapon14 
            {
                get => (int)CellsByName["OriginWeapon14"].Value;
                set => CellsByName["OriginWeapon14"].Value = (int)value;
            }
            

            // Def="s32 originEquipWep15 = -1"
            /// <summary>
            /// Origin Weapon +15 (s32)
            /// </summary>
            /// <remarks>
            /// This weapon's enhancement source weapon ID 15
            /// </remarks>
            public int OriginWeapon15 
            {
                get => (int)CellsByName["OriginWeapon15"].Value;
                set => CellsByName["OriginWeapon15"].Value = (int)value;
            }
            

            // Def="f32 weakA_DamageRate = 1"
            /// <summary>
            /// Damage Multiplier %: Type A (f32)
            /// </summary>
            /// <remarks>
            /// Damage multiplier for special attack A
            /// </remarks>
            public float DamageMultiplierPercentTypeA 
            {
                get => (float)CellsByName["DamageMultiplierPercentTypeA"].Value;
                set => CellsByName["DamageMultiplierPercentTypeA"].Value = (float)value;
            }
            

            // Def="f32 weakB_DamageRate = 1"
            /// <summary>
            /// Damage Multiplier %: Type B (f32)
            /// </summary>
            /// <remarks>
            /// Damage multiplier for special attack B
            /// </remarks>
            public float DamageMultiplierPercentTypeB 
            {
                get => (float)CellsByName["DamageMultiplierPercentTypeB"].Value;
                set => CellsByName["DamageMultiplierPercentTypeB"].Value = (float)value;
            }
            

            // Def="f32 weakC_DamageRate = 1"
            /// <summary>
            /// Damage Multiplier %: Type C (f32)
            /// </summary>
            /// <remarks>
            /// Damage multiplier for special attack C
            /// </remarks>
            public float DamageMultiplierPercentTypeC 
            {
                get => (float)CellsByName["DamageMultiplierPercentTypeC"].Value;
                set => CellsByName["DamageMultiplierPercentTypeC"].Value = (float)value;
            }
            

            // Def="f32 weakD_DamageRate = 1"
            /// <summary>
            /// Damage Multiplier %: Type D (f32)
            /// </summary>
            /// <remarks>
            /// Damage multiplier for special attack D
            /// </remarks>
            public float DamageMultiplierPercentTypeD 
            {
                get => (float)CellsByName["DamageMultiplierPercentTypeD"].Value;
                set => CellsByName["DamageMultiplierPercentTypeD"].Value = (float)value;
            }
            

            // Def="f32 sleepGuardResist_MaxCorrect"
            /// <summary>
            /// Max Correction: Sleep Guard Resist (f32)
            /// </summary>
            /// <remarks>
            /// Maximum value of cut rate correction value for attack power against sleep (set as special effect parameter)
            /// </remarks>
            public float MaxCorrectionSleepGuardResist 
            {
                get => (float)CellsByName["MaxCorrectionSleepGuardResist"].Value;
                set => CellsByName["MaxCorrectionSleepGuardResist"].Value = (float)value;
            }
            

            // Def="f32 madnessGuardResist_MaxCorrect"
            /// <summary>
            /// Max Correction: Madness Guard Resist (f32)
            /// </summary>
            /// <remarks>
            /// Maximum value of cut rate correction value for attack power against madness (set as special effect parameter)
            /// </remarks>
            public float MaxCorrectionMadnessGuardResist 
            {
                get => (float)CellsByName["MaxCorrectionMadnessGuardResist"].Value;
                set => CellsByName["MaxCorrectionMadnessGuardResist"].Value = (float)value;
            }
            

            // Def="f32 saWeaponDamage"
            /// <summary>
            /// Poise Damage (f32)
            /// </summary>
            /// <remarks>
            /// Super Armor Basic Attack Power
            /// </remarks>
            public float PoiseDamage 
            {
                get => (float)CellsByName["PoiseDamage"].Value;
                set => CellsByName["PoiseDamage"].Value = (float)value;
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
                set => CellsByName["EquipModelID"].Value = (ushort)value;
            }
            

            // Def="u16 iconId"
            /// <summary>
            /// Icon ID (u16)
            /// </summary>
            /// <remarks>
            /// Menu icon ID.
            /// </remarks>
            public ushort IconID 
            {
                get => (ushort)CellsByName["IconID"].Value;
                set => CellsByName["IconID"].Value = (ushort)value;
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
                set => CellsByName["Durability"].Value = (ushort)value;
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
                set => CellsByName["MaxDurability"].Value = (ushort)value;
            }
            

            // Def="u16 attackThrowEscape"
            /// <summary>
            /// Throw Escape Damage (u16)
            /// </summary>
            /// <remarks>
            /// Basic value of throw-through attack power
            /// </remarks>
            public ushort ThrowEscapeDamage 
            {
                get => (ushort)CellsByName["ThrowEscapeDamage"].Value;
                set => CellsByName["ThrowEscapeDamage"].Value = (ushort)value;
            }
            

            // Def="s16 parryDamageLife = -1"
            /// <summary>
            /// Parry Occurrence Duration (s16)
            /// </summary>
            /// <remarks>
            /// Limit the life of parry damage. It does not last longer than it is set in TimeAct.
            /// </remarks>
            public short ParryOccurrenceDuration 
            {
                get => (short)CellsByName["ParryOccurrenceDuration"].Value;
                set => CellsByName["ParryOccurrenceDuration"].Value = (short)value;
            }
            

            // Def="u16 attackBasePhysics = 100"
            /// <summary>
            /// Damage: Physical (u16)
            /// </summary>
            /// <remarks>
            /// Basic value of physical attribute attack that damages the enemy's HP
            /// </remarks>
            public ushort DamagePhysical 
            {
                get => (ushort)CellsByName["DamagePhysical"].Value;
                set => CellsByName["DamagePhysical"].Value = (ushort)value;
            }
            

            // Def="u16 attackBaseMagic = 100"
            /// <summary>
            /// Damage: Magic (u16)
            /// </summary>
            /// <remarks>
            /// Basic value of magic attribute attack that damages the enemy's HP
            /// </remarks>
            public ushort DamageMagic 
            {
                get => (ushort)CellsByName["DamageMagic"].Value;
                set => CellsByName["DamageMagic"].Value = (ushort)value;
            }
            

            // Def="u16 attackBaseFire = 100"
            /// <summary>
            /// Damage: Fire (u16)
            /// </summary>
            /// <remarks>
            /// Basic value of fire attribute attack that damages the enemy's HP
            /// </remarks>
            public ushort DamageFire 
            {
                get => (ushort)CellsByName["DamageFire"].Value;
                set => CellsByName["DamageFire"].Value = (ushort)value;
            }
            

            // Def="u16 attackBaseThunder = 100"
            /// <summary>
            /// Damage: Lightning (u16)
            /// </summary>
            /// <remarks>
            /// Basic value of electric shock attribute attack that damages the enemy's HP
            /// </remarks>
            public ushort DamageLightning 
            {
                get => (ushort)CellsByName["DamageLightning"].Value;
                set => CellsByName["DamageLightning"].Value = (ushort)value;
            }
            

            // Def="u16 attackBaseStamina = 100"
            /// <summary>
            /// Damage: Stamina (u16)
            /// </summary>
            /// <remarks>
            /// Stamina attack power against the enemy
            /// </remarks>
            public ushort DamageStamina 
            {
                get => (ushort)CellsByName["DamageStamina"].Value;
                set => CellsByName["DamageStamina"].Value = (ushort)value;
            }
            

            // Def="s16 guardAngle"
            /// <summary>
            /// Guard Angle (s16)
            /// </summary>
            /// <remarks>
            /// Defense occurrence range angle when guarding weapons
            /// </remarks>
            public short GuardAngle 
            {
                get => (short)CellsByName["GuardAngle"].Value;
                set => CellsByName["GuardAngle"].Value = (short)value;
            }
            

            // Def="f32 saDurability"
            /// <summary>
            /// Poise Durability (f32)
            /// </summary>
            /// <remarks>
            /// Additional SA durability used during attack motion
            /// </remarks>
            public float PoiseDurability 
            {
                get => (float)CellsByName["PoiseDurability"].Value;
                set => CellsByName["PoiseDurability"].Value = (float)value;
            }
            

            // Def="s16 staminaGuardDef"
            /// <summary>
            /// Guard Stability (s16)
            /// </summary>
            /// <remarks>
            /// Defense against enemy stamina attacks when guarding successfully
            /// </remarks>
            public short GuardStability 
            {
                get => (short)CellsByName["GuardStability"].Value;
                set => CellsByName["GuardStability"].Value = (short)value;
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
                set => CellsByName["ReinforceTypeID"].Value = (short)value;
            }
            

            // Def="s16 trophySGradeId = -1"
            /// <summary>
            /// Achievement ID [1] (s16)
            /// </summary>
            /// <remarks>
            /// Is it related to the trophy system?
            /// </remarks>
            public short AchievementID1 
            {
                get => (short)CellsByName["AchievementID1"].Value;
                set => CellsByName["AchievementID1"].Value = (short)value;
            }
            

            // Def="s16 trophySeqId = -1"
            /// <summary>
            /// Achievement ID [2] (s16)
            /// </summary>
            /// <remarks>
            /// Trophy SEQ number (13-29)
            /// </remarks>
            public short AchievementID2 
            {
                get => (short)CellsByName["AchievementID2"].Value;
                set => CellsByName["AchievementID2"].Value = (short)value;
            }
            

            // Def="s16 throwAtkRate"
            /// <summary>
            /// Critical Multiplier (s16)
            /// </summary>
            /// <remarks>
            /// Throw attack power multiplier
            /// </remarks>
            public short CriticalMultiplier 
            {
                get => (short)CellsByName["CriticalMultiplier"].Value;
                set => CellsByName["CriticalMultiplier"].Value = (short)value;
            }
            

            // Def="s16 bowDistRate"
            /// <summary>
            /// Bow Distance % (s16)
            /// </summary>
            /// <remarks>
            /// Up% to extend the flight distance
            /// </remarks>
            public short BowDistancePercent 
            {
                get => (short)CellsByName["BowDistancePercent"].Value;
                set => CellsByName["BowDistancePercent"].Value = (short)value;
            }
            

            // Def="u8 equipModelCategory = 7"
            /// <summary>
            /// Equip Model Category (u8)
            /// </summary>
            /// <remarks>
            /// Equipment model type.
            /// </remarks>
            public EquipModelCategory EquipModelCategory 
            {
                get => (EquipModelCategory)CellsByName["EquipModelCategory"].Value;
                set => CellsByName["EquipModelCategory"].Value = (byte)value;
            }
            

            // Def="u8 equipModelGender"
            /// <summary>
            /// Equip Model Gender (u8)
            /// </summary>
            /// <remarks>
            /// Gender of equipment model.
            /// </remarks>
            public EquipModelGender EquipModelGender 
            {
                get => (EquipModelGender)CellsByName["EquipModelGender"].Value;
                set => CellsByName["EquipModelGender"].Value = (byte)value;
            }
            

            // Def="u8 weaponCategory"
            /// <summary>
            /// Weapon Category (u8)
            /// </summary>
            /// <remarks>
            /// Weapon category.
            /// </remarks>
            public WeaponCategory WeaponCategory 
            {
                get => (WeaponCategory)CellsByName["WeaponCategory"].Value;
                set => CellsByName["WeaponCategory"].Value = (byte)value;
            }
            

            // Def="u8 wepmotionCategory"
            /// <summary>
            /// Weapon Motion Category (u8)
            /// </summary>
            /// <remarks>
            /// Weapon motion category.
            /// </remarks>
            public WepmotionCategory WeaponMotionCategory 
            {
                get => (WepmotionCategory)CellsByName["WeaponMotionCategory"].Value;
                set => CellsByName["WeaponMotionCategory"].Value = (byte)value;
            }
            

            // Def="u8 guardmotionCategory"
            /// <summary>
            /// Guard Motion Category (u8)
            /// </summary>
            /// <remarks>
            /// Guard motion category
            /// </remarks>
            public GuardmotionCategory GuardMotionCategory 
            {
                get => (GuardmotionCategory)CellsByName["GuardMotionCategory"].Value;
                set => CellsByName["GuardMotionCategory"].Value = (byte)value;
            }
            

            // Def="u8 atkMaterial"
            /// <summary>
            /// Attack Material (u8)
            /// </summary>
            /// <remarks>
            /// Attack material used from attack para
            /// </remarks>
            public WepMaterialAtk AttackMaterial 
            {
                get => (WepMaterialAtk)CellsByName["AttackMaterial"].Value;
                set => CellsByName["AttackMaterial"].Value = (byte)value;
            }
            

            // Def="u16 defSeMaterial1"
            /// <summary>
            /// Defence SE Material [1] (u16)
            /// </summary>
            /// <remarks>
            /// Defense SE material used from attack para 1
            /// </remarks>
            public WepMaterialDef DefenceSEMaterial1 
            {
                get => (WepMaterialDef)CellsByName["DefenceSEMaterial1"].Value;
                set => CellsByName["DefenceSEMaterial1"].Value = (ushort)value;
            }
            

            // Def="u8 correctType_Physics"
            /// <summary>
            /// Correction Type: Physical (u8)
            /// </summary>
            /// <remarks>
            /// Correcting physical attack power by primary parameters Determines the type of graph
            /// </remarks>
            public byte CorrectionTypePhysical 
            {
                get => (byte)CellsByName["CorrectionTypePhysical"].Value;
                set => CellsByName["CorrectionTypePhysical"].Value = (byte)value;
            }
            

            // Def="u8 spAttribute"
            /// <summary>
            /// Speical Attribute (u8)
            /// </summary>
            /// <remarks>
            /// Weapon special attribute value
            /// </remarks>
            public AtkparamSpattrType SpeicalAttribute 
            {
                get => (AtkparamSpattrType)CellsByName["SpeicalAttribute"].Value;
                set => CellsByName["SpeicalAttribute"].Value = (byte)value;
            }
            

            // Def="u16 spAtkcategory"
            /// <summary>
            /// Special Motion Category (u16)
            /// </summary>
            /// <remarks>
            /// Special attack category (possible from 50 to 999)
            /// </remarks>
            public WepmotionOverrideCategory SpecialMotionCategory 
            {
                get => (WepmotionOverrideCategory)CellsByName["SpecialMotionCategory"].Value;
                set => CellsByName["SpecialMotionCategory"].Value = (ushort)value;
            }
            

            // Def="u8 wepmotionOneHandId"
            /// <summary>
            /// Weapon Motion Position - 1H (u8)
            /// </summary>
            /// <remarks>
            /// Basic motion ID when equipped with one hand.
            /// </remarks>
            public byte WeaponMotionPosition1H 
            {
                get => (byte)CellsByName["WeaponMotionPosition1H"].Value;
                set => CellsByName["WeaponMotionPosition1H"].Value = (byte)value;
            }
            

            // Def="u8 wepmotionBothHandId"
            /// <summary>
            /// Weapon Motion Position - 2H (u8)
            /// </summary>
            /// <remarks>
            /// Basic motion ID when equipped with both hands.
            /// </remarks>
            public byte WeaponMotionPosition2H 
            {
                get => (byte)CellsByName["WeaponMotionPosition2H"].Value;
                set => CellsByName["WeaponMotionPosition2H"].Value = (byte)value;
            }
            

            // Def="u8 properStrength"
            /// <summary>
            /// Requirement: STR (u8)
            /// </summary>
            /// <remarks>
            /// Equipment appropriate value.
            /// </remarks>
            public byte RequirementSTR 
            {
                get => (byte)CellsByName["RequirementSTR"].Value;
                set => CellsByName["RequirementSTR"].Value = (byte)value;
            }
            

            // Def="u8 properAgility"
            /// <summary>
            /// Requirement: DEX (u8)
            /// </summary>
            /// <remarks>
            /// Equipment appropriate value.
            /// </remarks>
            public byte RequirementDEX 
            {
                get => (byte)CellsByName["RequirementDEX"].Value;
                set => CellsByName["RequirementDEX"].Value = (byte)value;
            }
            

            // Def="u8 properMagic"
            /// <summary>
            /// Requirement: INT (u8)
            /// </summary>
            /// <remarks>
            /// Equipment appropriate value.
            /// </remarks>
            public byte RequirementINT 
            {
                get => (byte)CellsByName["RequirementINT"].Value;
                set => CellsByName["RequirementINT"].Value = (byte)value;
            }
            

            // Def="u8 properFaith"
            /// <summary>
            /// Requirement: FTH (u8)
            /// </summary>
            /// <remarks>
            /// Equipment appropriate value.
            /// </remarks>
            public byte RequirementFTH 
            {
                get => (byte)CellsByName["RequirementFTH"].Value;
                set => CellsByName["RequirementFTH"].Value = (byte)value;
            }
            

            // Def="u8 overStrength"
            /// <summary>
            /// Strength over Start Value (u8)
            /// </summary>
            /// <remarks>
            /// Strength over start value
            /// </remarks>
            public byte StrengthOverStartValue 
            {
                get => (byte)CellsByName["StrengthOverStartValue"].Value;
                set => CellsByName["StrengthOverStartValue"].Value = (byte)value;
            }
            

            // Def="u8 attackBaseParry"
            /// <summary>
            /// Base Parry Attack (u8)
            /// </summary>
            /// <remarks>
            /// Basic value to defeat the enemy's parry
            /// </remarks>
            public byte BaseParryAttack 
            {
                get => (byte)CellsByName["BaseParryAttack"].Value;
                set => CellsByName["BaseParryAttack"].Value = (byte)value;
            }
            

            // Def="u8 defenseBaseParry"
            /// <summary>
            /// Base Parry Defens (u8)
            /// </summary>
            /// <remarks>
            /// Used to judge whether to be a parry or a guard at the time of parry judgment
            /// </remarks>
            public byte BaseParryDefens 
            {
                get => (byte)CellsByName["BaseParryDefens"].Value;
                set => CellsByName["BaseParryDefens"].Value = (byte)value;
            }
            

            // Def="u8 guardBaseRepel"
            /// <summary>
            /// Base Guard Repel (u8)
            /// </summary>
            /// <remarks>
            /// Used to determine if it will pop when guarding an enemy attack
            /// </remarks>
            public byte BaseGuardRepel 
            {
                get => (byte)CellsByName["BaseGuardRepel"].Value;
                set => CellsByName["BaseGuardRepel"].Value = (byte)value;
            }
            

            // Def="u8 attackBaseRepel"
            /// <summary>
            /// Base Attack Repel (u8)
            /// </summary>
            /// <remarks>
            /// Guard Used to determine whether or not to be repelled when attacking an enemy
            /// </remarks>
            public byte BaseAttackRepel 
            {
                get => (byte)CellsByName["BaseAttackRepel"].Value;
                set => CellsByName["BaseAttackRepel"].Value = (byte)value;
            }
            

            // Def="s8 guardCutCancelRate"
            /// <summary>
            /// Guard Bypass % (s8)
            /// </summary>
            /// <remarks>
            /// Magnification that invalidates the opponent's guard cut. -100 is completely invalid. Double the defense effect of the opponent at 100.
            /// </remarks>
            public sbyte GuardBypassPercent 
            {
                get => (sbyte)CellsByName["GuardBypassPercent"].Value;
                set => CellsByName["GuardBypassPercent"].Value = (sbyte)value;
            }
            

            // Def="s8 guardLevel"
            /// <summary>
            /// Guard Level (s8)
            /// </summary>
            /// <remarks>
            /// When guarding, which guard motion will the enemy attack? Decide
            /// </remarks>
            public sbyte GuardLevel 
            {
                get => (sbyte)CellsByName["GuardLevel"].Value;
                set => CellsByName["GuardLevel"].Value = (sbyte)value;
            }
            

            // Def="s8 slashGuardCutRate"
            /// <summary>
            /// Guard Absorption: Slash (s8)
            /// </summary>
            /// <remarks>
            /// Looking at the attack type, what percentage of the damage of the slashing attribute is cut? Specify
            /// </remarks>
            public sbyte GuardAbsorptionSlash 
            {
                get => (sbyte)CellsByName["GuardAbsorptionSlash"].Value;
                set => CellsByName["GuardAbsorptionSlash"].Value = (sbyte)value;
            }
            

            // Def="s8 blowGuardCutRate"
            /// <summary>
            /// Guard Absorption: Strike (s8)
            /// </summary>
            /// <remarks>
            /// Looking at the attack type, what percentage of the damage of the hit attribute is cut? Specify
            /// </remarks>
            public sbyte GuardAbsorptionStrike 
            {
                get => (sbyte)CellsByName["GuardAbsorptionStrike"].Value;
                set => CellsByName["GuardAbsorptionStrike"].Value = (sbyte)value;
            }
            

            // Def="s8 thrustGuardCutRate"
            /// <summary>
            /// Guard Absorption: Thrust (s8)
            /// </summary>
            /// <remarks>
            /// Looking at the attack type, what percentage of the damage of the piercing attribute is cut? Specify
            /// </remarks>
            public sbyte GuardAbsorptionThrust 
            {
                get => (sbyte)CellsByName["GuardAbsorptionThrust"].Value;
                set => CellsByName["GuardAbsorptionThrust"].Value = (sbyte)value;
            }
            

            // Def="s8 poisonGuardResist"
            /// <summary>
            /// Guard Resist: Poison (s8)
            /// </summary>
            /// <remarks>
            /// How much to cut the attack power to poison (set to the special effect parameter)
            /// </remarks>
            public sbyte GuardResistPoison 
            {
                get => (sbyte)CellsByName["GuardResistPoison"].Value;
                set => CellsByName["GuardResistPoison"].Value = (sbyte)value;
            }
            

            // Def="s8 diseaseGuardResist"
            /// <summary>
            /// Guard Resist: Scarlet Rot (s8)
            /// </summary>
            /// <remarks>
            /// How much to cut the attack power (set as a special effect parameter) to make it a plague
            /// </remarks>
            public sbyte GuardResistScarletRot 
            {
                get => (sbyte)CellsByName["GuardResistScarletRot"].Value;
                set => CellsByName["GuardResistScarletRot"].Value = (sbyte)value;
            }
            

            // Def="s8 bloodGuardResist"
            /// <summary>
            /// Guard Resist: Hemorrhage (s8)
            /// </summary>
            /// <remarks>
            /// How much to cut the attack power (set as a special effect parameter) to make bleeding
            /// </remarks>
            public sbyte GuardResistHemorrhage 
            {
                get => (sbyte)CellsByName["GuardResistHemorrhage"].Value;
                set => CellsByName["GuardResistHemorrhage"].Value = (sbyte)value;
            }
            

            // Def="s8 curseGuardResist"
            /// <summary>
            /// Guard Resist: Blight (s8)
            /// </summary>
            /// <remarks>
            /// How much to cut the attack power (set as a special effect parameter) to curse
            /// </remarks>
            public sbyte GuardResistBlight 
            {
                get => (sbyte)CellsByName["GuardResistBlight"].Value;
                set => CellsByName["GuardResistBlight"].Value = (sbyte)value;
            }
            

            // Def="u8 atkAttribute"
            /// <summary>
            /// Attack Attribute (u8)
            /// </summary>
            /// <remarks>
            /// Physical attribute 1
            /// </remarks>
            public AtkparamAtkattrType AttackAttribute 
            {
                get => (AtkparamAtkattrType)CellsByName["AttackAttribute"].Value;
                set => CellsByName["AttackAttribute"].Value = (byte)value;
            }
            

            // Def="u8 rightHandEquipable:1"
            /// <summary>
            /// Can wield in Right Hand (u8)
            /// </summary>
            /// <remarks>
            /// Is it possible to equip it with the right hand?
            /// </remarks>
            public EquipBool CanWieldInRightHand 
            {
                get => (EquipBool)CellsByName["CanWieldInRightHand"].Value;
                set => CellsByName["CanWieldInRightHand"].Value = (byte)value;
            }
            

            // Def="u8 leftHandEquipable:1"
            /// <summary>
            /// Can wield in Left Hand (u8)
            /// </summary>
            /// <remarks>
            /// Is it possible to equip it with the left hand?
            /// </remarks>
            public EquipBool CanWieldInLeftHand 
            {
                get => (EquipBool)CellsByName["CanWieldInLeftHand"].Value;
                set => CellsByName["CanWieldInLeftHand"].Value = (byte)value;
            }
            

            // Def="u8 bothHandEquipable:1"
            /// <summary>
            /// Can wield in Both Hands (u8)
            /// </summary>
            /// <remarks>
            /// Is it possible to equip with both hands?
            /// </remarks>
            public EquipBool CanWieldInBothHands 
            {
                get => (EquipBool)CellsByName["CanWieldInBothHands"].Value;
                set => CellsByName["CanWieldInBothHands"].Value = (byte)value;
            }
            

            // Def="u8 arrowSlotEquipable:1"
            /// <summary>
            /// Can wield in Arrow Slot (u8)
            /// </summary>
            /// <remarks>
            /// Is it possible to equip a bow bullet?
            /// </remarks>
            public EquipBool CanWieldInArrowSlot 
            {
                get => (EquipBool)CellsByName["CanWieldInArrowSlot"].Value;
                set => CellsByName["CanWieldInArrowSlot"].Value = (byte)value;
            }
            

            // Def="u8 boltSlotEquipable:1"
            /// <summary>
            /// Can wield in Bolt Slot (u8)
            /// </summary>
            /// <remarks>
            /// Is it possible to equip a crossbow bullet?
            /// </remarks>
            public EquipBool CanWieldInBoltSlot 
            {
                get => (EquipBool)CellsByName["CanWieldInBoltSlot"].Value;
                set => CellsByName["CanWieldInBoltSlot"].Value = (byte)value;
            }
            

            // Def="u8 enableGuard:1"
            /// <summary>
            /// Enables Guard (u8)
            /// </summary>
            /// <remarks>
            /// Guard with L1 when equipped with left hand
            /// </remarks>
            public EquipBool EnablesGuard 
            {
                get => (EquipBool)CellsByName["EnablesGuard"].Value;
                set => CellsByName["EnablesGuard"].Value = (byte)value;
            }
            

            // Def="u8 enableParry:1"
            /// <summary>
            /// Enables Parry (u8)
            /// </summary>
            /// <remarks>
            /// Parry with L2 when equipped with left hand
            /// </remarks>
            public EquipBool EnablesParry 
            {
                get => (EquipBool)CellsByName["EnablesParry"].Value;
                set => CellsByName["EnablesParry"].Value = (byte)value;
            }
            

            // Def="u8 enableMagic:1"
            /// <summary>
            /// Enables Sorcery (u8)
            /// </summary>
            /// <remarks>
            /// Activates magic when attacking
            /// </remarks>
            public EquipBool EnablesSorcery 
            {
                get => (EquipBool)CellsByName["EnablesSorcery"].Value;
                set => CellsByName["EnablesSorcery"].Value = (byte)value;
            }
            

            // Def="u8 enableSorcery:1"
            /// <summary>
            /// Enables Pyromancy (u8)
            /// </summary>
            /// <remarks>
            /// Cast magic when attacking
            /// </remarks>
            public EquipBool EnablesPyromancy 
            {
                get => (EquipBool)CellsByName["EnablesPyromancy"].Value;
                set => CellsByName["EnablesPyromancy"].Value = (byte)value;
            }
            

            // Def="u8 enableMiracle:1"
            /// <summary>
            /// Enables Incantations (u8)
            /// </summary>
            /// <remarks>
            /// Miracle activated when attacking
            /// </remarks>
            public EquipBool EnablesIncantations 
            {
                get => (EquipBool)CellsByName["EnablesIncantations"].Value;
                set => CellsByName["EnablesIncantations"].Value = (byte)value;
            }
            

            // Def="u8 enableVowMagic:1"
            /// <summary>
            /// Enables Vow Magic (u8)
            /// </summary>
            /// <remarks>
            /// Activates pledge magic when attacking
            /// </remarks>
            public EquipBool EnablesVowMagic 
            {
                get => (EquipBool)CellsByName["EnablesVowMagic"].Value;
                set => CellsByName["EnablesVowMagic"].Value = (byte)value;
            }
            

            // Def="u8 isNormalAttackType:1"
            /// <summary>
            /// Type Display: Normal (u8)
            /// </summary>
            /// <remarks>
            /// Attack type for menu display. Is it normal?
            /// </remarks>
            public EquipBool TypeDisplayNormal 
            {
                get => (EquipBool)CellsByName["TypeDisplayNormal"].Value;
                set => CellsByName["TypeDisplayNormal"].Value = (byte)value;
            }
            

            // Def="u8 isBlowAttackType:1"
            /// <summary>
            /// Type Display: Strike (u8)
            /// </summary>
            /// <remarks>
            /// Attack type for menu display. Is it a blow?
            /// </remarks>
            public EquipBool TypeDisplayStrike 
            {
                get => (EquipBool)CellsByName["TypeDisplayStrike"].Value;
                set => CellsByName["TypeDisplayStrike"].Value = (byte)value;
            }
            

            // Def="u8 isSlashAttackType:1"
            /// <summary>
            /// Type Display: Slash (u8)
            /// </summary>
            /// <remarks>
            /// Attack type for menu display. Is it a slash?
            /// </remarks>
            public EquipBool TypeDisplaySlash 
            {
                get => (EquipBool)CellsByName["TypeDisplaySlash"].Value;
                set => CellsByName["TypeDisplaySlash"].Value = (byte)value;
            }
            

            // Def="u8 isThrustAttackType:1"
            /// <summary>
            /// Type Display: Thrust (u8)
            /// </summary>
            /// <remarks>
            /// Attack type for menu display. Is it a piercing?
            /// </remarks>
            public EquipBool TypeDisplayThrust 
            {
                get => (EquipBool)CellsByName["TypeDisplayThrust"].Value;
                set => CellsByName["TypeDisplayThrust"].Value = (byte)value;
            }
            

            // Def="u8 isEnhance:1"
            /// <summary>
            /// Is Buffable (u8)
            /// </summary>
            /// <remarks>
            /// Can it be strengthened with pine fat?
            /// </remarks>
            public EquipBool IsBuffable 
            {
                get => (EquipBool)CellsByName["IsBuffable"].Value;
                set => CellsByName["IsBuffable"].Value = (byte)value;
            }
            

            // Def="u8 isHeroPointCorrect:1"
            /// <summary>
            /// Is Arcane Correction (u8)
            /// </summary>
            /// <remarks>
            /// Is there an attack power correction by human nature?
            /// </remarks>
            public EquipBool IsArcaneCorrection 
            {
                get => (EquipBool)CellsByName["IsArcaneCorrection"].Value;
                set => CellsByName["IsArcaneCorrection"].Value = (byte)value;
            }
            

            // Def="u8 isCustom:1"
            /// <summary>
            /// Is Reinforcable (u8)
            /// </summary>
            /// <remarks>
            /// Listed in the enhancement target list at the enhancement shop (may be deleted due to specification changes?)
            /// </remarks>
            public EquipBool IsReinforcable 
            {
                get => (EquipBool)CellsByName["IsReinforcable"].Value;
                set => CellsByName["IsReinforcable"].Value = (byte)value;
            }
            

            // Def="u8 disableBaseChangeReset:1"
            /// <summary>
            /// Disable Base Change Reset (u8)
            /// </summary>
            /// <remarks>
            /// Is job change reset prohibited?
            /// </remarks>
            public EquipBool DisableBaseChangeReset 
            {
                get => (EquipBool)CellsByName["DisableBaseChangeReset"].Value;
                set => CellsByName["DisableBaseChangeReset"].Value = (byte)value;
            }
            

            // Def="u8 disableRepair:1"
            /// <summary>
            /// Repair is Disabled (u8)
            /// </summary>
            /// <remarks>
            /// Is repair prohibited?
            /// </remarks>
            public EquipBool RepairIsDisabled 
            {
                get => (EquipBool)CellsByName["RepairIsDisabled"].Value;
                set => CellsByName["RepairIsDisabled"].Value = (byte)value;
            }
            

            // Def="u8 isDarkHand:1"
            /// <summary>
            /// Is Dark Hand (u8)
            /// </summary>
            /// <remarks>
            /// Is it a dark hand?
            /// </remarks>
            public EquipBool IsDarkHand 
            {
                get => (EquipBool)CellsByName["IsDarkHand"].Value;
                set => CellsByName["IsDarkHand"].Value = (byte)value;
            }
            

            // Def="u8 simpleModelForDlc:1"
            /// <summary>
            /// Is Simple Model for DLC (u8)
            /// </summary>
            /// <remarks>
            /// Is there a simple model for DLC?
            /// </remarks>
            public EquipBool IsSimpleModelForDLC 
            {
                get => (EquipBool)CellsByName["IsSimpleModelForDLC"].Value;
                set => CellsByName["IsSimpleModelForDLC"].Value = (byte)value;
            }
            

            // Def="u8 lanternWep:1"
            /// <summary>
            /// Is a Light Source (u8)
            /// </summary>
            /// <remarks>
            /// Is it a lantern weapon?
            /// </remarks>
            public EquipBool IsALightSource 
            {
                get => (EquipBool)CellsByName["IsALightSource"].Value;
                set => CellsByName["IsALightSource"].Value = (byte)value;
            }
            

            // Def="u8 isVersusGhostWep:1"
            /// <summary>
            /// Can Hit Ghost Enemy (u8)
            /// </summary>
            /// <remarks>
            /// NPC Para's "spirit body" will now hit the opponent of ○. Also, the attack para "Is it a ghost attack?" Will be able to guard the attack of ○.
            /// </remarks>
            public EquipBool CanHitGhostEnemy 
            {
                get => (EquipBool)CellsByName["CanHitGhostEnemy"].Value;
                set => CellsByName["CanHitGhostEnemy"].Value = (byte)value;
            }
            

            // Def="u8 baseChangeCategory:6"
            /// <summary>
            /// Base Change Category (u8)
            /// </summary>
            /// <remarks>
            /// Weapon career change category. Used to display the attribute icon.
            /// </remarks>
            public WepBaseChangeCategory BaseChangeCategory 
            {
                get => (WepBaseChangeCategory)CellsByName["BaseChangeCategory"].Value;
                set => CellsByName["BaseChangeCategory"].Value = (byte)value;
            }
            

            // Def="u8 isDragonSlayer:1"
            /// <summary>
            /// Is Dragonslayer (u8)
            /// </summary>
            /// <remarks>
            /// Is it a dragon hunting weapon?
            /// </remarks>
            public EquipBool IsDragonslayer 
            {
                get => (EquipBool)CellsByName["IsDragonslayer"].Value;
                set => CellsByName["IsDragonslayer"].Value = (byte)value;
            }
            

            // Def="u8 isDeposit:1"
            /// <summary>
            /// Can Deposit (u8)
            /// </summary>
            /// <remarks>
            /// Can you leave it in the warehouse?
            /// </remarks>
            public EquipBool CanDeposit 
            {
                get => (EquipBool)CellsByName["CanDeposit"].Value;
                set => CellsByName["CanDeposit"].Value = (byte)value;
            }
            

            // Def="u8 disableMultiDropShare:1"
            /// <summary>
            /// Cannot Drop in Multiplayer (u8)
            /// </summary>
            /// <remarks>
            /// Is multi-drop sharing prohibited?
            /// </remarks>
            public EquipBool CannotDropInMultiplayer 
            {
                get => (EquipBool)CellsByName["CannotDropInMultiplayer"].Value;
                set => CellsByName["CannotDropInMultiplayer"].Value = (byte)value;
            }
            

            // Def="u8 isDiscard:1"
            /// <summary>
            /// Can Discard (u8)
            /// </summary>
            /// <remarks>
            /// Can you throw away the item? TRUE = thrown away
            /// </remarks>
            public EquipBool CanDiscard 
            {
                get => (EquipBool)CellsByName["CanDiscard"].Value;
                set => CellsByName["CanDiscard"].Value = (byte)value;
            }
            

            // Def="u8 isDrop:1"
            /// <summary>
            /// Can Drop (u8)
            /// </summary>
            /// <remarks>
            /// Can I put the item on the spot? TRUE = can be placed
            /// </remarks>
            public EquipBool CanDrop 
            {
                get => (EquipBool)CellsByName["CanDrop"].Value;
                set => CellsByName["CanDrop"].Value = (byte)value;
            }
            

            // Def="u8 showLogCondType:1 = 1"
            /// <summary>
            /// Item Acquisition Log Condition Type (u8)
            /// </summary>
            /// <remarks>
            /// Whether to display in the item acquisition log when acquiring the item (not entered: ○)
            /// </remarks>
            public EquipBool ItemAcquisitionLogConditionType 
            {
                get => (EquipBool)CellsByName["ItemAcquisitionLogConditionType"].Value;
                set => CellsByName["ItemAcquisitionLogConditionType"].Value = (byte)value;
            }
            

            // Def="u8 enableThrow:1"
            /// <summary>
            /// Enable Throw (u8)
            /// </summary>
            /// <remarks>
            /// Whether it is a throwable weapon
            /// </remarks>
            public EquipBool EnableThrow 
            {
                get => (EquipBool)CellsByName["EnableThrow"].Value;
                set => CellsByName["EnableThrow"].Value = (byte)value;
            }
            

            // Def="u8 showDialogCondType:2 = 2"
            /// <summary>
            /// Item Acquisition Dialog Condition Type (u8)
            /// </summary>
            /// <remarks>
            /// Whether to display it in the item acquisition dialog when acquiring an item (not entered: new only)
            /// </remarks>
            public GetDialogConditionType ItemAcquisitionDialogConditionType 
            {
                get => (GetDialogConditionType)CellsByName["ItemAcquisitionDialogConditionType"].Value;
                set => CellsByName["ItemAcquisitionDialogConditionType"].Value = (byte)value;
            }
            

            // Def="u8 disableGemAttr:1"
            /// <summary>
            /// Prevent Affinity Change (u8)
            /// </summary>
            /// <remarks>
            /// Is it prohibited to change the magic stone attribute?
            /// </remarks>
            public EquipBool PreventAffinityChange 
            {
                get => (EquipBool)CellsByName["PreventAffinityChange"].Value;
                set => CellsByName["PreventAffinityChange"].Value = (byte)value;
            }
            

            // Def="u16 defSfxMaterial1"
            /// <summary>
            /// Defence SFX Material [1] (u16)
            /// </summary>
            /// <remarks>
            /// Defensive SFX material used from attack para 1
            /// </remarks>
            public WepMaterialDefSfx DefenceSFXMaterial1 
            {
                get => (WepMaterialDefSfx)CellsByName["DefenceSFXMaterial1"].Value;
                set => CellsByName["DefenceSFXMaterial1"].Value = (ushort)value;
            }
            

            // Def="u8 wepCollidableType0 = 1"
            /// <summary>
            /// Weapon Collidable Type [0] (u8)
            /// </summary>
            /// <remarks>
            /// Weapon collaborative setting
            /// </remarks>
            public WepCollidableType WeaponCollidableType0 
            {
                get => (WepCollidableType)CellsByName["WeaponCollidableType0"].Value;
                set => CellsByName["WeaponCollidableType0"].Value = (byte)value;
            }
            

            // Def="u8 wepCollidableType1 = 1"
            /// <summary>
            /// Weapon Collidable Type [1] (u8)
            /// </summary>
            /// <remarks>
            /// Weapon 1 collaborative setting
            /// </remarks>
            public WepCollidableType WeaponCollidableType1 
            {
                get => (WepCollidableType)CellsByName["WeaponCollidableType1"].Value;
                set => CellsByName["WeaponCollidableType1"].Value = (byte)value;
            }
            

            // Def="u8 postureControlId_Right"
            /// <summary>
            /// Posture Control ID - Weapon Right (u8)
            /// </summary>
            /// <remarks>
            /// Attitude control ID (right hand)
            /// </remarks>
            public byte PostureControlIDWeaponRight 
            {
                get => (byte)CellsByName["PostureControlIDWeaponRight"].Value;
                set => CellsByName["PostureControlIDWeaponRight"].Value = (byte)value;
            }
            

            // Def="u8 postureControlId_Left"
            /// <summary>
            /// Posture Control ID - Weapon Left (u8)
            /// </summary>
            /// <remarks>
            /// Attitude control ID (left hand)
            /// </remarks>
            public byte PostureControlIDWeaponLeft 
            {
                get => (byte)CellsByName["PostureControlIDWeaponLeft"].Value;
                set => CellsByName["PostureControlIDWeaponLeft"].Value = (byte)value;
            }
            

            // Def="s32 traceSfxId0 = -1"
            /// <summary>
            /// Trace SFX ID [0] (s32)
            /// </summary>
            /// <remarks>
            /// Sword flash SfxID_0 (-1 invalid)
            /// </remarks>
            public int TraceSFXID0 
            {
                get => (int)CellsByName["TraceSFXID0"].Value;
                set => CellsByName["TraceSFXID0"].Value = (int)value;
            }
            

            // Def="s32 traceDmyIdHead0 = -1"
            /// <summary>
            /// Trace SFX ID [0] - Dummy Poly ID - Head (s32)
            /// </summary>
            /// <remarks>
            /// Sword flash root Damipoli ID_0 (-1 invalid)
            /// </remarks>
            public int TraceSFXID0DummyPolyIDHead 
            {
                get => (int)CellsByName["TraceSFXID0DummyPolyIDHead"].Value;
                set => CellsByName["TraceSFXID0DummyPolyIDHead"].Value = (int)value;
            }
            

            // Def="s32 traceDmyIdTail0 = -1"
            /// <summary>
            /// Trace SFX ID [0] - Dummy Poly ID - Tail (s32)
            /// </summary>
            /// <remarks>
            /// Sword Flash Sword Tip Damipoli ID_0
            /// </remarks>
            public int TraceSFXID0DummyPolyIDTail 
            {
                get => (int)CellsByName["TraceSFXID0DummyPolyIDTail"].Value;
                set => CellsByName["TraceSFXID0DummyPolyIDTail"].Value = (int)value;
            }
            

            // Def="s32 traceSfxId1 = -1"
            /// <summary>
            /// Trace SFX ID [1] (s32)
            /// </summary>
            /// <remarks>
            /// Sword flash SfxID_1 (-1 invalid)
            /// </remarks>
            public int TraceSFXID1 
            {
                get => (int)CellsByName["TraceSFXID1"].Value;
                set => CellsByName["TraceSFXID1"].Value = (int)value;
            }
            

            // Def="s32 traceDmyIdHead1 = -1"
            /// <summary>
            /// Trace SFX ID [1] - Dummy Poly ID - Head (s32)
            /// </summary>
            /// <remarks>
            /// Sword Flash Root Damipoli ID_1 (-1 invalid)
            /// </remarks>
            public int TraceSFXID1DummyPolyIDHead 
            {
                get => (int)CellsByName["TraceSFXID1DummyPolyIDHead"].Value;
                set => CellsByName["TraceSFXID1DummyPolyIDHead"].Value = (int)value;
            }
            

            // Def="s32 traceDmyIdTail1 = -1"
            /// <summary>
            /// Trace SFX ID [1] - Dummy Poly ID - Tail (s32)
            /// </summary>
            /// <remarks>
            /// Sword Flash Sword Tip Damipoli ID_1
            /// </remarks>
            public int TraceSFXID1DummyPolyIDTail 
            {
                get => (int)CellsByName["TraceSFXID1DummyPolyIDTail"].Value;
                set => CellsByName["TraceSFXID1DummyPolyIDTail"].Value = (int)value;
            }
            

            // Def="s32 traceSfxId2 = -1"
            /// <summary>
            /// Trace SFX ID [2] (s32)
            /// </summary>
            /// <remarks>
            /// Sword flash SfxID_2 (-1 invalid)
            /// </remarks>
            public int TraceSFXID2 
            {
                get => (int)CellsByName["TraceSFXID2"].Value;
                set => CellsByName["TraceSFXID2"].Value = (int)value;
            }
            

            // Def="s32 traceDmyIdHead2 = -1"
            /// <summary>
            /// Trace SFX ID [2] - Dummy Poly ID - Head (s32)
            /// </summary>
            /// <remarks>
            /// Sword Flash Root Damipoli ID_2 (-1 invalid)
            /// </remarks>
            public int TraceSFXID2DummyPolyIDHead 
            {
                get => (int)CellsByName["TraceSFXID2DummyPolyIDHead"].Value;
                set => CellsByName["TraceSFXID2DummyPolyIDHead"].Value = (int)value;
            }
            

            // Def="s32 traceDmyIdTail2 = -1"
            /// <summary>
            /// Trace SFX ID [2] - Dummy Poly ID - Tail (s32)
            /// </summary>
            /// <remarks>
            /// Sword Flash Sword Tip Damipoli ID_2
            /// </remarks>
            public int TraceSFXID2DummyPolyIDTail 
            {
                get => (int)CellsByName["TraceSFXID2DummyPolyIDTail"].Value;
                set => CellsByName["TraceSFXID2DummyPolyIDTail"].Value = (int)value;
            }
            

            // Def="s32 traceSfxId3 = -1"
            /// <summary>
            /// Trace SFX ID [3] (s32)
            /// </summary>
            /// <remarks>
            /// Sword Flash SfxID_3 (-1 invalid)
            /// </remarks>
            public int TraceSFXID3 
            {
                get => (int)CellsByName["TraceSFXID3"].Value;
                set => CellsByName["TraceSFXID3"].Value = (int)value;
            }
            

            // Def="s32 traceDmyIdHead3 = -1"
            /// <summary>
            /// Trace SFX ID [3] - Dummy Poly ID - Head (s32)
            /// </summary>
            /// <remarks>
            /// Sword flash root Damipoli ID_3 (-1 invalid)
            /// </remarks>
            public int TraceSFXID3DummyPolyIDHead 
            {
                get => (int)CellsByName["TraceSFXID3DummyPolyIDHead"].Value;
                set => CellsByName["TraceSFXID3DummyPolyIDHead"].Value = (int)value;
            }
            

            // Def="s32 traceDmyIdTail3 = -1"
            /// <summary>
            /// Trace SFX ID [3] - Dummy Poly ID - Tail (s32)
            /// </summary>
            /// <remarks>
            /// Sword Flash Sword Tip Damipoli ID_3
            /// </remarks>
            public int TraceSFXID3DummyPolyIDTail 
            {
                get => (int)CellsByName["TraceSFXID3DummyPolyIDTail"].Value;
                set => CellsByName["TraceSFXID3DummyPolyIDTail"].Value = (int)value;
            }
            

            // Def="s32 traceSfxId4 = -1"
            /// <summary>
            /// Trace SFX ID [4] (s32)
            /// </summary>
            /// <remarks>
            /// Sword Flash SfxID_4 (-1 invalid)
            /// </remarks>
            public int TraceSFXID4 
            {
                get => (int)CellsByName["TraceSFXID4"].Value;
                set => CellsByName["TraceSFXID4"].Value = (int)value;
            }
            

            // Def="s32 traceDmyIdHead4 = -1"
            /// <summary>
            /// Trace SFX ID [4] - Dummy Poly ID - Head (s32)
            /// </summary>
            /// <remarks>
            /// Sword flash root Damipoli ID_4 (-1 invalid)
            /// </remarks>
            public int TraceSFXID4DummyPolyIDHead 
            {
                get => (int)CellsByName["TraceSFXID4DummyPolyIDHead"].Value;
                set => CellsByName["TraceSFXID4DummyPolyIDHead"].Value = (int)value;
            }
            

            // Def="s32 traceDmyIdTail4 = -1"
            /// <summary>
            /// Trace SFX ID [4] - Dummy Poly ID - Tail (s32)
            /// </summary>
            /// <remarks>
            /// Sword Flash Sword Tip Damipoli ID_4
            /// </remarks>
            public int TraceSFXID4DummyPolyIDTail 
            {
                get => (int)CellsByName["TraceSFXID4DummyPolyIDTail"].Value;
                set => CellsByName["TraceSFXID4DummyPolyIDTail"].Value = (int)value;
            }
            

            // Def="s32 traceSfxId5 = -1"
            /// <summary>
            /// Trace SFX ID [5] (s32)
            /// </summary>
            /// <remarks>
            /// Sword Flash SfxID_5 (-1 invalid)
            /// </remarks>
            public int TraceSFXID5 
            {
                get => (int)CellsByName["TraceSFXID5"].Value;
                set => CellsByName["TraceSFXID5"].Value = (int)value;
            }
            

            // Def="s32 traceDmyIdHead5 = -1"
            /// <summary>
            /// Trace SFX ID [5] - Dummy Poly ID - Head (s32)
            /// </summary>
            /// <remarks>
            /// Sword Flash Root Damipoli ID_5 (-1 invalid)
            /// </remarks>
            public int TraceSFXID5DummyPolyIDHead 
            {
                get => (int)CellsByName["TraceSFXID5DummyPolyIDHead"].Value;
                set => CellsByName["TraceSFXID5DummyPolyIDHead"].Value = (int)value;
            }
            

            // Def="s32 traceDmyIdTail5 = -1"
            /// <summary>
            /// Trace SFX ID [5] - Dummy Poly ID - Tail (s32)
            /// </summary>
            /// <remarks>
            /// Sword Flash Sword Tip Damipoli ID_5
            /// </remarks>
            public int TraceSFXID5DummyPolyIDTail 
            {
                get => (int)CellsByName["TraceSFXID5DummyPolyIDTail"].Value;
                set => CellsByName["TraceSFXID5DummyPolyIDTail"].Value = (int)value;
            }
            

            // Def="s32 traceSfxId6 = -1"
            /// <summary>
            /// Trace SFX ID [6] (s32)
            /// </summary>
            /// <remarks>
            /// Sword Flash SfxID_6 (-1 invalid)
            /// </remarks>
            public int TraceSFXID6 
            {
                get => (int)CellsByName["TraceSFXID6"].Value;
                set => CellsByName["TraceSFXID6"].Value = (int)value;
            }
            

            // Def="s32 traceDmyIdHead6 = -1"
            /// <summary>
            /// Trace SFX ID [6] - Dummy Poly ID - Head (s32)
            /// </summary>
            /// <remarks>
            /// Sword Flash Root Damipoli ID_6 (-1 invalid)
            /// </remarks>
            public int TraceSFXID6DummyPolyIDHead 
            {
                get => (int)CellsByName["TraceSFXID6DummyPolyIDHead"].Value;
                set => CellsByName["TraceSFXID6DummyPolyIDHead"].Value = (int)value;
            }
            

            // Def="s32 traceDmyIdTail6 = -1"
            /// <summary>
            /// Trace SFX ID [6] - Dummy Poly ID - Tail (s32)
            /// </summary>
            /// <remarks>
            /// Sword Flash Sword Tip Damipoli ID_6
            /// </remarks>
            public int TraceSFXID6DummyPolyIDTail 
            {
                get => (int)CellsByName["TraceSFXID6DummyPolyIDTail"].Value;
                set => CellsByName["TraceSFXID6DummyPolyIDTail"].Value = (int)value;
            }
            

            // Def="s32 traceSfxId7 = -1"
            /// <summary>
            /// Trace SFX ID [7] (s32)
            /// </summary>
            /// <remarks>
            /// Sword Flash SfxID_7 (-1 invalid)
            /// </remarks>
            public int TraceSFXID7 
            {
                get => (int)CellsByName["TraceSFXID7"].Value;
                set => CellsByName["TraceSFXID7"].Value = (int)value;
            }
            

            // Def="s32 traceDmyIdHead7 = -1"
            /// <summary>
            /// Trace SFX ID [7] - Dummy Poly ID - Head (s32)
            /// </summary>
            /// <remarks>
            /// Sword Flash Root Damipoli ID_7 (-1 invalid)
            /// </remarks>
            public int TraceSFXID7DummyPolyIDHead 
            {
                get => (int)CellsByName["TraceSFXID7DummyPolyIDHead"].Value;
                set => CellsByName["TraceSFXID7DummyPolyIDHead"].Value = (int)value;
            }
            

            // Def="s32 traceDmyIdTail7 = -1"
            /// <summary>
            /// Trace SFX ID [7] - Dummy Poly ID - Tail (s32)
            /// </summary>
            /// <remarks>
            /// Sword Flash Sword Tip Damipoli ID_7
            /// </remarks>
            public int TraceSFXID7DummyPolyIDTail 
            {
                get => (int)CellsByName["TraceSFXID7DummyPolyIDTail"].Value;
                set => CellsByName["TraceSFXID7DummyPolyIDTail"].Value = (int)value;
            }
            

            // Def="u16 defSfxMaterial2"
            /// <summary>
            /// Defence SFX Material [2] (u16)
            /// </summary>
            /// <remarks>
            /// Defensive SFX material used from attack para 2
            /// </remarks>
            public WepMaterialDefSfx DefenceSFXMaterial2 
            {
                get => (WepMaterialDefSfx)CellsByName["DefenceSFXMaterial2"].Value;
                set => CellsByName["DefenceSFXMaterial2"].Value = (ushort)value;
            }
            

            // Def="u16 defSeMaterial2"
            /// <summary>
            /// Defence SE Material [2] (u16)
            /// </summary>
            /// <remarks>
            /// Defense SE material used from attack para 2
            /// </remarks>
            public WepMaterialDef DefenceSEMaterial2 
            {
                get => (WepMaterialDef)CellsByName["DefenceSEMaterial2"].Value;
                set => CellsByName["DefenceSEMaterial2"].Value = (ushort)value;
            }
            

            // Def="s32 absorpParamId = -1"
            /// <summary>
            /// Weapon Sheath Position ID (s32)
            /// </summary>
            /// <remarks>
            /// Weapon adsorption position parameter Id. This value determines the position where the weapon is attracted (-1: Refer to the value written directly in the old source code).
            /// </remarks>
            public int WeaponSheathPositionID 
            {
                get => (int)CellsByName["WeaponSheathPositionID"].Value;
                set => CellsByName["WeaponSheathPositionID"].Value = (int)value;
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
                set => CellsByName["ToughnessCorrection"].Value = (float)value;
            }
            

            // Def="u8 isValidTough_ProtSADmg:1"
            /// <summary>
            /// Is Toughness Perfomed if Poise is Initial Value (u8)
            /// </summary>
            /// <remarks>
            /// Whether the toughness calculation is performed even if the armor SA is the initial value. Check the toughness specification .xlsx for details
            /// </remarks>
            public EquipBool IsToughnessPerfomedIfPoiseIsInitialValue 
            {
                get => (EquipBool)CellsByName["IsToughnessPerfomedIfPoiseIsInitialValue"].Value;
                set => CellsByName["IsToughnessPerfomedIfPoiseIsInitialValue"].Value = (byte)value;
            }
            

            // Def="u8 isDualBlade:1"
            /// <summary>
            /// Is Dual Weapon (u8)
            /// </summary>
            /// <remarks>
            /// Is this weapon a twin sword?
            /// </remarks>
            public EquipBool IsDualWeapon 
            {
                get => (EquipBool)CellsByName["IsDualWeapon"].Value;
                set => CellsByName["IsDualWeapon"].Value = (byte)value;
            }
            

            // Def="u8 isAutoEquip:1"
            /// <summary>
            /// Is Auto Equipped (u8)
            /// </summary>
            /// <remarks>
            /// Only valid for arrows and bolts. Whether to automatically equip this weapon if the target equipment slot is empty when picking up this weapon
            /// </remarks>
            public EquipBool IsAutoEquipped 
            {
                get => (EquipBool)CellsByName["IsAutoEquipped"].Value;
                set => CellsByName["IsAutoEquipped"].Value = (byte)value;
            }
            

            // Def="u8 isEnableEmergencyStep:1"
            /// <summary>
            /// Is Emergency Avoidance Possible (u8)
            /// </summary>
            /// <remarks>
            /// Is it an emergency avoidable weapon? Pass it to the behavior script.
            /// </remarks>
            public EquipBool IsEmergencyAvoidancePossible 
            {
                get => (EquipBool)CellsByName["IsEmergencyAvoidancePossible"].Value;
                set => CellsByName["IsEmergencyAvoidancePossible"].Value = (byte)value;
            }
            

            // Def="u8 invisibleOnRemo:1"
            /// <summary>
            /// Is Hidden in Cutscene (u8)
            /// </summary>
            /// <remarks>
            /// Is it hidden during cutscenes?
            /// </remarks>
            public EquipBool IsHiddenInCutscene 
            {
                get => (EquipBool)CellsByName["IsHiddenInCutscene"].Value;
                set => CellsByName["IsHiddenInCutscene"].Value = (byte)value;
            }
            

            // Def="dummy8 pad2:3"
            /// <summary>
            /// pad (dummy8)
            /// </summary>
            /// <remarks>
            /// 
            /// </remarks>
            public object Pad 
            {
                get => (object)CellsByName["Pad"].Value;
                set => CellsByName["Pad"].Value = (object)value;
            }
            

            // Def="u8 correctType_Magic"
            /// <summary>
            /// Correction Type: Magic (u8)
            /// </summary>
            /// <remarks>
            /// Determining the type of magic attack power correction graph with primary parameters
            /// </remarks>
            public byte CorrectionTypeMagic 
            {
                get => (byte)CellsByName["CorrectionTypeMagic"].Value;
                set => CellsByName["CorrectionTypeMagic"].Value = (byte)value;
            }
            

            // Def="u8 correctType_Fire"
            /// <summary>
            /// Correction Type: Fire (u8)
            /// </summary>
            /// <remarks>
            /// Determine the type of flame attack power correction graph with primary parameters
            /// </remarks>
            public byte CorrectionTypeFire 
            {
                get => (byte)CellsByName["CorrectionTypeFire"].Value;
                set => CellsByName["CorrectionTypeFire"].Value = (byte)value;
            }
            

            // Def="u8 correctType_Thunder"
            /// <summary>
            /// Correction Type: Lightning (u8)
            /// </summary>
            /// <remarks>
            /// Determine the type of lightning attack power correction graph with primary parameters
            /// </remarks>
            public byte CorrectionTypeLightning 
            {
                get => (byte)CellsByName["CorrectionTypeLightning"].Value;
                set => CellsByName["CorrectionTypeLightning"].Value = (byte)value;
            }
            

            // Def="f32 weakE_DamageRate = 1"
            /// <summary>
            /// Damage Multiplier %: Type E (f32)
            /// </summary>
            /// <remarks>
            /// Damage multiplier for special attack E
            /// </remarks>
            public float DamageMultiplierPercentTypeE 
            {
                get => (float)CellsByName["DamageMultiplierPercentTypeE"].Value;
                set => CellsByName["DamageMultiplierPercentTypeE"].Value = (float)value;
            }
            

            // Def="f32 weakF_DamageRate = 1"
            /// <summary>
            /// Damage Multiplier %: Type F (f32)
            /// </summary>
            /// <remarks>
            /// Damage multiplier for special attack F
            /// </remarks>
            public float DamageMultiplierPercentTypeF 
            {
                get => (float)CellsByName["DamageMultiplierPercentTypeF"].Value;
                set => CellsByName["DamageMultiplierPercentTypeF"].Value = (float)value;
            }
            

            // Def="f32 darkGuardCutRate"
            /// <summary>
            /// Guard Absorption: Holy (f32)
            /// </summary>
            /// <remarks>
            /// How much to cut the dark attack?
            /// </remarks>
            public float GuardAbsorptionHoly 
            {
                get => (float)CellsByName["GuardAbsorptionHoly"].Value;
                set => CellsByName["GuardAbsorptionHoly"].Value = (float)value;
            }
            

            // Def="u16 attackBaseDark"
            /// <summary>
            /// Damage: Holy (u16)
            /// </summary>
            /// <remarks>
            /// Basic value of darkness attack that damages the enemy's HP
            /// </remarks>
            public ushort DamageHoly 
            {
                get => (ushort)CellsByName["DamageHoly"].Value;
                set => CellsByName["DamageHoly"].Value = (ushort)value;
            }
            

            // Def="u8 correctType_Dark"
            /// <summary>
            /// Correction Type: Holy (u8)
            /// </summary>
            /// <remarks>
            /// Determine the type of darkness attack power correction graph with primary parameters
            /// </remarks>
            public byte CorrectionTypeHoly 
            {
                get => (byte)CellsByName["CorrectionTypeHoly"].Value;
                set => CellsByName["CorrectionTypeHoly"].Value = (byte)value;
            }
            

            // Def="u8 correctType_Poison"
            /// <summary>
            /// Correction Type: Poison (u8)
            /// </summary>
            /// <remarks>
            /// Determining the type of poison attack power correction graph with primary parameters
            /// </remarks>
            public byte CorrectionTypePoison 
            {
                get => (byte)CellsByName["CorrectionTypePoison"].Value;
                set => CellsByName["CorrectionTypePoison"].Value = (byte)value;
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
                set => CellsByName["SortGroupID"].Value = (byte)value;
            }
            

            // Def="u8 atkAttribute2"
            /// <summary>
            /// Attack Attribute [2] (u8)
            /// </summary>
            /// <remarks>
            /// Physical attribute 2
            /// </remarks>
            public AtkparamAtkattrType AttackAttribute2 
            {
                get => (AtkparamAtkattrType)CellsByName["AttackAttribute2"].Value;
                set => CellsByName["AttackAttribute2"].Value = (byte)value;
            }
            

            // Def="s8 sleepGuardResist"
            /// <summary>
            /// Guard Resist: Sleep (s8)
            /// </summary>
            /// <remarks>
            /// How much to cut the attack power (set as a special effect parameter) to sleep
            /// </remarks>
            public sbyte GuardResistSleep 
            {
                get => (sbyte)CellsByName["GuardResistSleep"].Value;
                set => CellsByName["GuardResistSleep"].Value = (sbyte)value;
            }
            

            // Def="s8 madnessGuardResist"
            /// <summary>
            /// Guard Resist: Madness (s8)
            /// </summary>
            /// <remarks>
            /// How much to cut the attack power (set to the special effect parameter) that makes you go mad
            /// </remarks>
            public sbyte GuardResistMadness 
            {
                get => (sbyte)CellsByName["GuardResistMadness"].Value;
                set => CellsByName["GuardResistMadness"].Value = (sbyte)value;
            }
            

            // Def="u8 correctType_Blood"
            /// <summary>
            /// Correction Type: Hemorrhage (u8)
            /// </summary>
            /// <remarks>
            /// Determine the type of bleeding attack power correction graph with primary parameters
            /// </remarks>
            public byte CorrectionTypeHemorrhage 
            {
                get => (byte)CellsByName["CorrectionTypeHemorrhage"].Value;
                set => CellsByName["CorrectionTypeHemorrhage"].Value = (byte)value;
            }
            

            // Def="u8 properLuck"
            /// <summary>
            /// Requirement: ARC (u8)
            /// </summary>
            /// <remarks>
            /// Equipment appropriate value.
            /// </remarks>
            public byte RequirementARC 
            {
                get => (byte)CellsByName["RequirementARC"].Value;
                set => CellsByName["RequirementARC"].Value = (byte)value;
            }
            

            // Def="s8 freezeGuardResist"
            /// <summary>
            /// Guard Resist: Frostbite (s8)
            /// </summary>
            /// <remarks>
            /// How much to cut the attack power (set to the special effect parameter) to cool down
            /// </remarks>
            public sbyte GuardResistFrostbite 
            {
                get => (sbyte)CellsByName["GuardResistFrostbite"].Value;
                set => CellsByName["GuardResistFrostbite"].Value = (sbyte)value;
            }
            

            // Def="u8 autoReplenishType"
            /// <summary>
            /// Auto Replenish Type (u8)
            /// </summary>
            /// <remarks>
            /// Controls whether or not to automatically replenish and default settings
            /// </remarks>
            public AutoReplenishType AutoReplenishType 
            {
                get => (AutoReplenishType)CellsByName["AutoReplenishType"].Value;
                set => CellsByName["AutoReplenishType"].Value = (byte)value;
            }
            

            // Def="s32 swordArtsParamId"
            /// <summary>
            /// Sword Arts Param ID (s32)
            /// </summary>
            /// <remarks>
            /// Arts parameter ID
            /// </remarks>
            public int SwordArtsParamID 
            {
                get => (int)CellsByName["SwordArtsParamID"].Value;
                set => CellsByName["SwordArtsParamID"].Value = (int)value;
            }
            

            // Def="f32 correctLuck"
            /// <summary>
            /// Correction: ARC (f32)
            /// </summary>
            /// <remarks>
            /// Charapara correction value.
            /// </remarks>
            public float CorrectionARC 
            {
                get => (float)CellsByName["CorrectionARC"].Value;
                set => CellsByName["CorrectionARC"].Value = (float)value;
            }
            

            // Def="u32 arrowBoltEquipId"
            /// <summary>
            /// Ammunition Equip ID (u32)
            /// </summary>
            /// <remarks>
            /// Equipment number of the quiver (magazine) display model. In the case of a bow, it is displayed as a quiver, and in the case of a crossbow, it is displayed as a magazine.
            /// </remarks>
            public uint AmmunitionEquipID 
            {
                get => (uint)CellsByName["AmmunitionEquipID"].Value;
                set => CellsByName["AmmunitionEquipID"].Value = (uint)value;
            }
            

            // Def="u8 DerivationLevelType"
            /// <summary>
            /// Derivation Level Type (u8)
            /// </summary>
            /// <remarks>
            /// Type of how to set the enhancement level when returning or deriving a weapon
            /// </remarks>
            public WeaponDerivationLevelType DerivationLevelType 
            {
                get => (WeaponDerivationLevelType)CellsByName["DerivationLevelType"].Value;
                set => CellsByName["DerivationLevelType"].Value = (byte)value;
            }
            

            // Def="u8 enchantSfxSize"
            /// <summary>
            /// Enchantment SFX Size (u8)
            /// </summary>
            /// <remarks>
            /// Value offset to enchantment SfxId
            /// </remarks>
            public WepEnchantSfxSize EnchantmentSFXSize 
            {
                get => (WepEnchantSfxSize)CellsByName["EnchantmentSFXSize"].Value;
                set => CellsByName["EnchantmentSFXSize"].Value = (byte)value;
            }
            

            // Def="u16 wepType"
            /// <summary>
            /// Weapon Type (u16)
            /// </summary>
            /// <remarks>
            /// Weapon type. Used for linking text and magic stones (* It is now used for other than text)
            /// </remarks>
            public WepType WeaponType 
            {
                get => (WepType)CellsByName["WeaponType"].Value;
                set => CellsByName["WeaponType"].Value = (ushort)value;
            }
            

            // Def="f32 physGuardCutRate_MaxCorrect"
            /// <summary>
            /// Max Correction: Physical Guard Absorption (f32)
            /// </summary>
            /// <remarks>
            /// Maximum damage physical cut rate correction value when guarding
            /// </remarks>
            public float MaxCorrectionPhysicalGuardAbsorption 
            {
                get => (float)CellsByName["MaxCorrectionPhysicalGuardAbsorption"].Value;
                set => CellsByName["MaxCorrectionPhysicalGuardAbsorption"].Value = (float)value;
            }
            

            // Def="f32 magGuardCutRate_MaxCorrect"
            /// <summary>
            /// Max Correction: Magic Guard Absorption (f32)
            /// </summary>
            /// <remarks>
            /// Maximum value of correction value of damage magic cut rate when guarding
            /// </remarks>
            public float MaxCorrectionMagicGuardAbsorption 
            {
                get => (float)CellsByName["MaxCorrectionMagicGuardAbsorption"].Value;
                set => CellsByName["MaxCorrectionMagicGuardAbsorption"].Value = (float)value;
            }
            

            // Def="f32 fireGuardCutRate_MaxCorrect"
            /// <summary>
            /// Max Correction: Fire Guard Absorption (f32)
            /// </summary>
            /// <remarks>
            /// Maximum value of correction value of damage flame cut rate when guarding
            /// </remarks>
            public float MaxCorrectionFireGuardAbsorption 
            {
                get => (float)CellsByName["MaxCorrectionFireGuardAbsorption"].Value;
                set => CellsByName["MaxCorrectionFireGuardAbsorption"].Value = (float)value;
            }
            

            // Def="f32 thunGuardCutRate_MaxCorrect"
            /// <summary>
            /// Max Correction: Lightning Guard Absorption (f32)
            /// </summary>
            /// <remarks>
            /// Maximum value of correction value of damage electric shock cut rate when guarding
            /// </remarks>
            public float MaxCorrectionLightningGuardAbsorption 
            {
                get => (float)CellsByName["MaxCorrectionLightningGuardAbsorption"].Value;
                set => CellsByName["MaxCorrectionLightningGuardAbsorption"].Value = (float)value;
            }
            

            // Def="f32 darkGuardCutRate_MaxCorrect"
            /// <summary>
            /// Max Correction: Holy Guard Absorption (f32)
            /// </summary>
            /// <remarks>
            /// Maximum value of correction value of damage darkness cut rate when guarding
            /// </remarks>
            public float MaxCorrectionHolyGuardAbsorption 
            {
                get => (float)CellsByName["MaxCorrectionHolyGuardAbsorption"].Value;
                set => CellsByName["MaxCorrectionHolyGuardAbsorption"].Value = (float)value;
            }
            

            // Def="f32 poisonGuardResist_MaxCorrect"
            /// <summary>
            /// Max Correction: Poison Guard Absorption (f32)
            /// </summary>
            /// <remarks>
            /// Maximum value of cut rate correction value for attack power against poison (set as special effect parameter)
            /// </remarks>
            public float MaxCorrectionPoisonGuardAbsorption 
            {
                get => (float)CellsByName["MaxCorrectionPoisonGuardAbsorption"].Value;
                set => CellsByName["MaxCorrectionPoisonGuardAbsorption"].Value = (float)value;
            }
            

            // Def="f32 diseaseGuardResist_MaxCorrect"
            /// <summary>
            /// Max Correction: Scarlet Rot Guard Absorption (f32)
            /// </summary>
            /// <remarks>
            /// Maximum value of cut rate correction value for attack power against plague (set as special effect parameter)
            /// </remarks>
            public float MaxCorrectionScarletRotGuardAbsorption 
            {
                get => (float)CellsByName["MaxCorrectionScarletRotGuardAbsorption"].Value;
                set => CellsByName["MaxCorrectionScarletRotGuardAbsorption"].Value = (float)value;
            }
            

            // Def="f32 bloodGuardResist_MaxCorrect"
            /// <summary>
            /// Max Correction: Hemorrhage Guard Absorption (f32)
            /// </summary>
            /// <remarks>
            /// Maximum value of cut rate correction value for attack power against bleeding (set as special effect parameter)
            /// </remarks>
            public float MaxCorrectionHemorrhageGuardAbsorption 
            {
                get => (float)CellsByName["MaxCorrectionHemorrhageGuardAbsorption"].Value;
                set => CellsByName["MaxCorrectionHemorrhageGuardAbsorption"].Value = (float)value;
            }
            

            // Def="f32 curseGuardResist_MaxCorrect"
            /// <summary>
            /// Max Correction: Blight Guard Absorption (f32)
            /// </summary>
            /// <remarks>
            /// Maximum value of cut rate correction value for attack power against curse (set as special effect parameter)
            /// </remarks>
            public float MaxCorrectionBlightGuardAbsorption 
            {
                get => (float)CellsByName["MaxCorrectionBlightGuardAbsorption"].Value;
                set => CellsByName["MaxCorrectionBlightGuardAbsorption"].Value = (float)value;
            }
            

            // Def="f32 freezeGuardResist_MaxCorrect"
            /// <summary>
            /// Max Correction: Frostbite Guard Absorption (f32)
            /// </summary>
            /// <remarks>
            /// Maximum value of cut rate correction value for attack power against cold air (set as special effect parameter)
            /// </remarks>
            public float MaxCorrectionFrostbiteGuardAbsorption 
            {
                get => (float)CellsByName["MaxCorrectionFrostbiteGuardAbsorption"].Value;
                set => CellsByName["MaxCorrectionFrostbiteGuardAbsorption"].Value = (float)value;
            }
            

            // Def="f32 staminaGuardDef_MaxCorrect"
            /// <summary>
            /// Max Correction: Guard Stability (f32)
            /// </summary>
            /// <remarks>
            /// When the guard is successful, the maximum value of the defense power correction value against the enemy's stamina attack
            /// </remarks>
            public float MaxCorrectionGuardStability 
            {
                get => (float)CellsByName["MaxCorrectionGuardStability"].Value;
                set => CellsByName["MaxCorrectionGuardStability"].Value = (float)value;
            }
            

            // Def="s32 residentSfxId_1 = -1"
            /// <summary>
            /// Resident SFX [1] (s32)
            /// </summary>
            /// <remarks>
            /// Resident SfxId1
            /// </remarks>
            public int ResidentSFX1 
            {
                get => (int)CellsByName["ResidentSFX1"].Value;
                set => CellsByName["ResidentSFX1"].Value = (int)value;
            }
            

            // Def="s32 residentSfxId_2 = -1"
            /// <summary>
            /// Resident SFX [2] (s32)
            /// </summary>
            /// <remarks>
            /// Resident SfxId2
            /// </remarks>
            public int ResidentSFX2 
            {
                get => (int)CellsByName["ResidentSFX2"].Value;
                set => CellsByName["ResidentSFX2"].Value = (int)value;
            }
            

            // Def="s32 residentSfxId_3 = -1"
            /// <summary>
            /// Resident SFX [3] (s32)
            /// </summary>
            /// <remarks>
            /// Resident SfxId3
            /// </remarks>
            public int ResidentSFX3 
            {
                get => (int)CellsByName["ResidentSFX3"].Value;
                set => CellsByName["ResidentSFX3"].Value = (int)value;
            }
            

            // Def="s32 residentSfxId_4 = -1"
            /// <summary>
            /// Resident SFX [4] (s32)
            /// </summary>
            /// <remarks>
            /// Resident SfxId4
            /// </remarks>
            public int ResidentSFX4 
            {
                get => (int)CellsByName["ResidentSFX4"].Value;
                set => CellsByName["ResidentSFX4"].Value = (int)value;
            }
            

            // Def="s32 residentSfx_DmyId_1 = -1"
            /// <summary>
            /// Resident SFX - Dummy Poly [1] (s32)
            /// </summary>
            /// <remarks>
            /// Resident Sfx Damipoli Id1
            /// </remarks>
            public int ResidentSFXDummyPoly1 
            {
                get => (int)CellsByName["ResidentSFXDummyPoly1"].Value;
                set => CellsByName["ResidentSFXDummyPoly1"].Value = (int)value;
            }
            

            // Def="s32 residentSfx_DmyId_2 = -1"
            /// <summary>
            /// Resident SFX - Dummy Poly [2] (s32)
            /// </summary>
            /// <remarks>
            /// Resident Sfx Damipoli Id2
            /// </remarks>
            public int ResidentSFXDummyPoly2 
            {
                get => (int)CellsByName["ResidentSFXDummyPoly2"].Value;
                set => CellsByName["ResidentSFXDummyPoly2"].Value = (int)value;
            }
            

            // Def="s32 residentSfx_DmyId_3 = -1"
            /// <summary>
            /// Resident SFX - Dummy Poly [3] (s32)
            /// </summary>
            /// <remarks>
            /// Resident Sfx Damipoli Id3
            /// </remarks>
            public int ResidentSFXDummyPoly3 
            {
                get => (int)CellsByName["ResidentSFXDummyPoly3"].Value;
                set => CellsByName["ResidentSFXDummyPoly3"].Value = (int)value;
            }
            

            // Def="s32 residentSfx_DmyId_4 = -1"
            /// <summary>
            /// Resident SFX - Dummy Poly [4] (s32)
            /// </summary>
            /// <remarks>
            /// Resident Sfx Damipoli Id4
            /// </remarks>
            public int ResidentSFXDummyPoly4 
            {
                get => (int)CellsByName["ResidentSFXDummyPoly4"].Value;
                set => CellsByName["ResidentSFXDummyPoly4"].Value = (int)value;
            }
            

            // Def="f32 staminaConsumptionRate = 1"
            /// <summary>
            /// Stamina Consumption % (f32)
            /// </summary>
            /// <remarks>
            /// Stamina consumption ratio
            /// </remarks>
            public float StaminaConsumptionPercent 
            {
                get => (float)CellsByName["StaminaConsumptionPercent"].Value;
                set => CellsByName["StaminaConsumptionPercent"].Value = (float)value;
            }
            

            // Def="f32 vsPlayerDmgCorrectRate_Physics = 1"
            /// <summary>
            /// Vs. Player - Physical Damage % (f32)
            /// </summary>
            /// <remarks>
            /// Only attacks on the player will correct the damage done.
            /// </remarks>
            public float VsPlayerPhysicalDamagePercent 
            {
                get => (float)CellsByName["VsPlayerPhysicalDamagePercent"].Value;
                set => CellsByName["VsPlayerPhysicalDamagePercent"].Value = (float)value;
            }
            

            // Def="f32 vsPlayerDmgCorrectRate_Magic = 1"
            /// <summary>
            /// Vs. Player - Magic Damage % (f32)
            /// </summary>
            /// <remarks>
            /// Only attacks on the player will correct the damage done.
            /// </remarks>
            public float VsPlayerMagicDamagePercent 
            {
                get => (float)CellsByName["VsPlayerMagicDamagePercent"].Value;
                set => CellsByName["VsPlayerMagicDamagePercent"].Value = (float)value;
            }
            

            // Def="f32 vsPlayerDmgCorrectRate_Fire = 1"
            /// <summary>
            /// Vs. Player - Fire Damage % (f32)
            /// </summary>
            /// <remarks>
            /// Only attacks on the player will correct the damage done.
            /// </remarks>
            public float VsPlayerFireDamagePercent 
            {
                get => (float)CellsByName["VsPlayerFireDamagePercent"].Value;
                set => CellsByName["VsPlayerFireDamagePercent"].Value = (float)value;
            }
            

            // Def="f32 vsPlayerDmgCorrectRate_Thunder = 1"
            /// <summary>
            /// Vs. Player - Lightning Damage % (f32)
            /// </summary>
            /// <remarks>
            /// Only attacks on the player will correct the damage done.
            /// </remarks>
            public float VsPlayerLightningDamagePercent 
            {
                get => (float)CellsByName["VsPlayerLightningDamagePercent"].Value;
                set => CellsByName["VsPlayerLightningDamagePercent"].Value = (float)value;
            }
            

            // Def="f32 vsPlayerDmgCorrectRate_Dark = 1"
            /// <summary>
            /// Vs. Player - Holy Damage % (f32)
            /// </summary>
            /// <remarks>
            /// Only attacks on the player will correct the damage done.
            /// </remarks>
            public float VsPlayerHolyDamagePercent 
            {
                get => (float)CellsByName["VsPlayerHolyDamagePercent"].Value;
                set => CellsByName["VsPlayerHolyDamagePercent"].Value = (float)value;
            }
            

            // Def="f32 vsPlayerDmgCorrectRate_Poison = 1"
            /// <summary>
            /// Vs. Player - Poison Damage % (f32)
            /// </summary>
            /// <remarks>
            /// Only attacks on the player will correct the damage done.
            /// </remarks>
            public float VsPlayerPoisonDamagePercent 
            {
                get => (float)CellsByName["VsPlayerPoisonDamagePercent"].Value;
                set => CellsByName["VsPlayerPoisonDamagePercent"].Value = (float)value;
            }
            

            // Def="f32 vsPlayerDmgCorrectRate_Blood = 1"
            /// <summary>
            /// Vs. Player - Hemorrhage Damage % (f32)
            /// </summary>
            /// <remarks>
            /// Only attacks on the player will correct the damage done.
            /// </remarks>
            public float VsPlayerHemorrhageDamagePercent 
            {
                get => (float)CellsByName["VsPlayerHemorrhageDamagePercent"].Value;
                set => CellsByName["VsPlayerHemorrhageDamagePercent"].Value = (float)value;
            }
            

            // Def="f32 vsPlayerDmgCorrectRate_Freeze = 1"
            /// <summary>
            /// Vs. Player - Frostbite Damage % (f32)
            /// </summary>
            /// <remarks>
            /// Only attacks on the player will correct the damage done.
            /// </remarks>
            public float VsPlayerFrostbiteDamagePercent 
            {
                get => (float)CellsByName["VsPlayerFrostbiteDamagePercent"].Value;
                set => CellsByName["VsPlayerFrostbiteDamagePercent"].Value = (float)value;
            }
            

            // Def="s32 attainmentWepStatusStr = -1"
            /// <summary>
            /// Unique R2 Attack - STR Requirement (s32)
            /// </summary>
            /// <remarks>
            /// To change the R2 attack into a special action when the status is X or higher when using a specific weapon.
            /// </remarks>
            public int UniqueR2AttackSTRRequirement 
            {
                get => (int)CellsByName["UniqueR2AttackSTRRequirement"].Value;
                set => CellsByName["UniqueR2AttackSTRRequirement"].Value = (int)value;
            }
            

            // Def="s32 attainmentWepStatusDex = -1"
            /// <summary>
            /// Unique R2 Attack - DEX Requirement (s32)
            /// </summary>
            /// <remarks>
            /// To change the R2 attack into a special action when the status is X or higher when using a specific weapon.
            /// </remarks>
            public int UniqueR2AttackDEXRequirement 
            {
                get => (int)CellsByName["UniqueR2AttackDEXRequirement"].Value;
                set => CellsByName["UniqueR2AttackDEXRequirement"].Value = (int)value;
            }
            

            // Def="s32 attainmentWepStatusMag = -1"
            /// <summary>
            /// Unique R2 Attack - INT Requirement (s32)
            /// </summary>
            /// <remarks>
            /// To change the R2 attack into a special action when the status is X or higher when using a specific weapon.
            /// </remarks>
            public int UniqueR2AttackINTRequirement 
            {
                get => (int)CellsByName["UniqueR2AttackINTRequirement"].Value;
                set => CellsByName["UniqueR2AttackINTRequirement"].Value = (int)value;
            }
            

            // Def="s32 attainmentWepStatusFai = -1"
            /// <summary>
            /// Unique R2 Attack - FTH Requirement (s32)
            /// </summary>
            /// <remarks>
            /// This is to change the R2 attack into a special action when the status is X or higher when using a specific weapon.
            /// </remarks>
            public int UniqueR2AttackFTHRequirement 
            {
                get => (int)CellsByName["UniqueR2AttackFTHRequirement"].Value;
                set => CellsByName["UniqueR2AttackFTHRequirement"].Value = (int)value;
            }
            

            // Def="s32 attainmentWepStatusLuc = -1"
            /// <summary>
            /// Unique R2 Attack - ARC Requirement (s32)
            /// </summary>
            /// <remarks>
            /// This is to change the R2 attack into a special action when the status is X or higher when using a specific weapon.
            /// </remarks>
            public int UniqueR2AttackARCRequirement 
            {
                get => (int)CellsByName["UniqueR2AttackARCRequirement"].Value;
                set => CellsByName["UniqueR2AttackARCRequirement"].Value = (int)value;
            }
            

            // Def="s32 attackElementCorrectId"
            /// <summary>
            /// Attack Element Correct ID (s32)
            /// </summary>
            /// <remarks>
            /// ID of the parameter that corrects the attack attribute
            /// </remarks>
            public int AttackElementCorrectID 
            {
                get => (int)CellsByName["AttackElementCorrectID"].Value;
                set => CellsByName["AttackElementCorrectID"].Value = (int)value;
            }
            

            // Def="s32 saleValue = -1"
            /// <summary>
            /// Sale Value (s32)
            /// </summary>
            /// <remarks>
            /// Selling price
            /// </remarks>
            public int SaleValue 
            {
                get => (int)CellsByName["SaleValue"].Value;
                set => CellsByName["SaleValue"].Value = (int)value;
            }
            

            // Def="u8 reinforceShopCategory"
            /// <summary>
            /// Reinforcement Menu Type (u8)
            /// </summary>
            /// <remarks>
            /// Enhanced shop category
            /// </remarks>
            public ReinforceShopCategory ReinforcementMenuType 
            {
                get => (ReinforceShopCategory)CellsByName["ReinforcementMenuType"].Value;
                set => CellsByName["ReinforcementMenuType"].Value = (byte)value;
            }
            

            // Def="u8 maxArrowQuantity = 1"
            /// <summary>
            /// Max Ammunition Held (u8)
            /// </summary>
            /// <remarks>
            /// Maximum number of arrows
            /// </remarks>
            public byte MaxAmmunitionHeld 
            {
                get => (byte)CellsByName["MaxAmmunitionHeld"].Value;
                set => CellsByName["MaxAmmunitionHeld"].Value = (byte)value;
            }
            

            // Def="u8 residentSfx_1_IsVisibleForHang:1"
            /// <summary>
            /// Hide Resident SFX [1] when Sheathed (u8)
            /// </summary>
            /// <remarks>
            /// If "Do you want to display when resident SFX1 is delivered?" Is true, hide the SFX set to "resident SFX ID1" when the weapon is delivered.
            /// </remarks>
            public EquipBool HideResidentSFX1WhenSheathed 
            {
                get => (EquipBool)CellsByName["HideResidentSFX1WhenSheathed"].Value;
                set => CellsByName["HideResidentSFX1WhenSheathed"].Value = (byte)value;
            }
            

            // Def="u8 residentSfx_2_IsVisibleForHang:1"
            /// <summary>
            /// Hide Resident SFX [2] when Sheathed (u8)
            /// </summary>
            /// <remarks>
            /// If "Do you want to display when resident SFX2 is delivered?" Is true, hide the SFX set to "resident SFX ID2" when the weapon is delivered.
            /// </remarks>
            public EquipBool HideResidentSFX2WhenSheathed 
            {
                get => (EquipBool)CellsByName["HideResidentSFX2WhenSheathed"].Value;
                set => CellsByName["HideResidentSFX2WhenSheathed"].Value = (byte)value;
            }
            

            // Def="u8 residentSfx_3_IsVisibleForHang:1"
            /// <summary>
            /// Hide Resident SFX [3] when Sheathed (u8)
            /// </summary>
            /// <remarks>
            /// If "Do you want to display when resident SFX3 is delivered?" Is true, hide the SFX set to "resident SFX ID3" when the weapon is delivered.
            /// </remarks>
            public EquipBool HideResidentSFX3WhenSheathed 
            {
                get => (EquipBool)CellsByName["HideResidentSFX3WhenSheathed"].Value;
                set => CellsByName["HideResidentSFX3WhenSheathed"].Value = (byte)value;
            }
            

            // Def="u8 residentSfx_4_IsVisibleForHang:1"
            /// <summary>
            /// Hide Resident SFX [4] when Sheathed (u8)
            /// </summary>
            /// <remarks>
            /// If "Do you want to display when resident SFX4 is delivered?" Is true, hide the SFX set to "resident SFX ID 4" when the weapon is delivered.
            /// </remarks>
            public EquipBool HideResidentSFX4WhenSheathed 
            {
                get => (EquipBool)CellsByName["HideResidentSFX4WhenSheathed"].Value;
                set => CellsByName["HideResidentSFX4WhenSheathed"].Value = (byte)value;
            }
            

            // Def="u8 isSoulParamIdChange_model0:1 = 1"
            /// <summary>
            /// Apply Weapon VFX Parameters [0] (u8)
            /// </summary>
            /// <remarks>
            /// Whether the vfx parameter "Soul Param ID for Weapon Enchantment" and "Invisible Weapon for Weapon Enchantment" settings are applied
            /// </remarks>
            public EquipBool ApplyWeaponVFXParameters0 
            {
                get => (EquipBool)CellsByName["ApplyWeaponVFXParameters0"].Value;
                set => CellsByName["ApplyWeaponVFXParameters0"].Value = (byte)value;
            }
            

            // Def="u8 isSoulParamIdChange_model1:1 = 1"
            /// <summary>
            /// Apply Weapon VFX Parameters [1] (u8)
            /// </summary>
            /// <remarks>
            /// Whether the vfx parameter "Soul Param ID for Weapon Enchantment" and "Invisible Weapon for Weapon Enchantment" settings are applied
            /// </remarks>
            public EquipBool ApplyWeaponVFXParameters1 
            {
                get => (EquipBool)CellsByName["ApplyWeaponVFXParameters1"].Value;
                set => CellsByName["ApplyWeaponVFXParameters1"].Value = (byte)value;
            }
            

            // Def="u8 isSoulParamIdChange_model2:1 = 1"
            /// <summary>
            /// Apply Weapon VFX Parameters [2] (u8)
            /// </summary>
            /// <remarks>
            /// Whether the vfx parameter "Soul Param ID for Weapon Enchantment" and "Invisible Weapon for Weapon Enchantment" settings are applied
            /// </remarks>
            public EquipBool ApplyWeaponVFXParameters2 
            {
                get => (EquipBool)CellsByName["ApplyWeaponVFXParameters2"].Value;
                set => CellsByName["ApplyWeaponVFXParameters2"].Value = (byte)value;
            }
            

            // Def="u8 isSoulParamIdChange_model3:1 = 1"
            /// <summary>
            /// Apply Weapon VFX Parameters [3] (u8)
            /// </summary>
            /// <remarks>
            /// Whether the vfx parameter "Soul Param ID for Weapon Enchantment" and "Invisible Weapon for Weapon Enchantment" settings are applied
            /// </remarks>
            public EquipBool ApplyWeaponVFXParameters3 
            {
                get => (EquipBool)CellsByName["ApplyWeaponVFXParameters3"].Value;
                set => CellsByName["ApplyWeaponVFXParameters3"].Value = (byte)value;
            }
            

            // Def="s8 wepSeIdOffset"
            /// <summary>
            /// Weapon SE ID Offset (s8)
            /// </summary>
            /// <remarks>
            /// SEID offset value
            /// </remarks>
            public sbyte WeaponSEIDOffset 
            {
                get => (sbyte)CellsByName["WeaponSEIDOffset"].Value;
                set => CellsByName["WeaponSEIDOffset"].Value = (sbyte)value;
            }
            

            // Def="s32 baseChangePrice"
            /// <summary>
            /// Affinity Price (s32)
            /// </summary>
            /// <remarks>
            /// Evolution price
            /// </remarks>
            public int AffinityPrice 
            {
                get => (int)CellsByName["AffinityPrice"].Value;
                set => CellsByName["AffinityPrice"].Value = (int)value;
            }
            

            // Def="s16 levelSyncCorrectId = -1"
            /// <summary>
            /// Level Sync Correction ID (s16)
            /// </summary>
            /// <remarks>
            /// Level sync correction ID
            /// </remarks>
            public short LevelSyncCorrectionID 
            {
                get => (short)CellsByName["LevelSyncCorrectionID"].Value;
                set => CellsByName["LevelSyncCorrectionID"].Value = (short)value;
            }
            

            // Def="u8 correctType_Sleep"
            /// <summary>
            /// Correction Type: Sleep (u8)
            /// </summary>
            /// <remarks>
            /// Determine the type of sleep attack correction graph with primary parameters
            /// </remarks>
            public byte CorrectionTypeSleep 
            {
                get => (byte)CellsByName["CorrectionTypeSleep"].Value;
                set => CellsByName["CorrectionTypeSleep"].Value = (byte)value;
            }
            

            // Def="u8 correctType_Madness"
            /// <summary>
            /// Correction Type: Mandesss (u8)
            /// </summary>
            /// <remarks>
            /// Determining the type of mad attack power correction graph with primary parameters
            /// </remarks>
            public byte CorrectionTypeMandesss 
            {
                get => (byte)CellsByName["CorrectionTypeMandesss"].Value;
                set => CellsByName["CorrectionTypeMandesss"].Value = (byte)value;
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
                set => CellsByName["Rarity"].Value = (byte)value;
            }
            

            // Def="u8 gemMountType"
            /// <summary>
            /// Ash of War Type (u8)
            /// </summary>
            /// <remarks>
            /// Is it possible to attach magic stones?
            /// </remarks>
            public GemMountType AshOfWarType 
            {
                get => (GemMountType)CellsByName["AshOfWarType"].Value;
                set => CellsByName["AshOfWarType"].Value = (byte)value;
            }
            

            // Def="u16 wepRegainHp"
            /// <summary>
            /// Weapon Regain HP Amount (u16)
            /// </summary>
            /// <remarks>
            /// Weapon regain amount
            /// </remarks>
            public ushort WeaponRegainHPAmount 
            {
                get => (ushort)CellsByName["WeaponRegainHPAmount"].Value;
                set => CellsByName["WeaponRegainHPAmount"].Value = (ushort)value;
            }
            

            // Def="s32 spEffectMsgId0 = -1"
            /// <summary>
            /// SpEffect Message ID [0] (s32)
            /// </summary>
            /// <remarks>
            /// Effect text ID 00 (Weapon_Effect). Weapon-specific effect text to display in status
            /// </remarks>
            public int SpEffectMessageID0 
            {
                get => (int)CellsByName["SpEffectMessageID0"].Value;
                set => CellsByName["SpEffectMessageID0"].Value = (int)value;
            }
            

            // Def="s32 spEffectMsgId1 = -1"
            /// <summary>
            /// SpEffect Message ID [1] (s32)
            /// </summary>
            /// <remarks>
            /// Effect text ID 01 (Weapon_Effect). Weapon-specific effect text to display in status
            /// </remarks>
            public int SpEffectMessageID1 
            {
                get => (int)CellsByName["SpEffectMessageID1"].Value;
                set => CellsByName["SpEffectMessageID1"].Value = (int)value;
            }
            

            // Def="s32 spEffectMsgId2 = -1"
            /// <summary>
            /// SpEffect Message ID [2] (s32)
            /// </summary>
            /// <remarks>
            /// Effect text ID 02 (Weapon_Effect). Weapon-specific effect text to display in status
            /// </remarks>
            public int SpEffectMessageID2 
            {
                get => (int)CellsByName["SpEffectMessageID2"].Value;
                set => CellsByName["SpEffectMessageID2"].Value = (int)value;
            }
            

            // Def="s32 originEquipWep16 = -1"
            /// <summary>
            /// Origin Weapon +16 (s32)
            /// </summary>
            /// <remarks>
            /// This weapon's enhancement source weapon ID 16
            /// </remarks>
            public int OriginWeapon16 
            {
                get => (int)CellsByName["OriginWeapon16"].Value;
                set => CellsByName["OriginWeapon16"].Value = (int)value;
            }
            

            // Def="s32 originEquipWep17 = -1"
            /// <summary>
            /// Origin Weapon +17 (s32)
            /// </summary>
            /// <remarks>
            /// This weapon's enhancement source weapon ID 17
            /// </remarks>
            public int OriginWeapon17 
            {
                get => (int)CellsByName["OriginWeapon17"].Value;
                set => CellsByName["OriginWeapon17"].Value = (int)value;
            }
            

            // Def="s32 originEquipWep18 = -1"
            /// <summary>
            /// Origin Weapon +18 (s32)
            /// </summary>
            /// <remarks>
            /// This weapon's enhancement source weapon ID18
            /// </remarks>
            public int OriginWeapon18 
            {
                get => (int)CellsByName["OriginWeapon18"].Value;
                set => CellsByName["OriginWeapon18"].Value = (int)value;
            }
            

            // Def="s32 originEquipWep19 = -1"
            /// <summary>
            /// Origin Weapon +19 (s32)
            /// </summary>
            /// <remarks>
            /// This weapon's enhancement source weapon ID 19
            /// </remarks>
            public int OriginWeapon19 
            {
                get => (int)CellsByName["OriginWeapon19"].Value;
                set => CellsByName["OriginWeapon19"].Value = (int)value;
            }
            

            // Def="s32 originEquipWep20 = -1"
            /// <summary>
            /// Origin Weapon +20 (s32)
            /// </summary>
            /// <remarks>
            /// This weapon's enhancement source weapon ID 20
            /// </remarks>
            public int OriginWeapon20 
            {
                get => (int)CellsByName["OriginWeapon20"].Value;
                set => CellsByName["OriginWeapon20"].Value = (int)value;
            }
            

            // Def="s32 originEquipWep21 = -1"
            /// <summary>
            /// Origin Weapon +21 (s32)
            /// </summary>
            /// <remarks>
            /// This weapon's enhancement source weapon ID21
            /// </remarks>
            public int OriginWeapon21 
            {
                get => (int)CellsByName["OriginWeapon21"].Value;
                set => CellsByName["OriginWeapon21"].Value = (int)value;
            }
            

            // Def="s32 originEquipWep22 = -1"
            /// <summary>
            /// Origin Weapon +22 (s32)
            /// </summary>
            /// <remarks>
            /// This weapon's enhancement source weapon ID 22
            /// </remarks>
            public int OriginWeapon22 
            {
                get => (int)CellsByName["OriginWeapon22"].Value;
                set => CellsByName["OriginWeapon22"].Value = (int)value;
            }
            

            // Def="s32 originEquipWep23 = -1"
            /// <summary>
            /// Origin Weapon +23 (s32)
            /// </summary>
            /// <remarks>
            /// This weapon's enhancement source weapon ID 23
            /// </remarks>
            public int OriginWeapon23 
            {
                get => (int)CellsByName["OriginWeapon23"].Value;
                set => CellsByName["OriginWeapon23"].Value = (int)value;
            }
            

            // Def="s32 originEquipWep24 = -1"
            /// <summary>
            /// Origin Weapon +24 (s32)
            /// </summary>
            /// <remarks>
            /// This weapon's enhancement source weapon ID 24
            /// </remarks>
            public int OriginWeapon24 
            {
                get => (int)CellsByName["OriginWeapon24"].Value;
                set => CellsByName["OriginWeapon24"].Value = (int)value;
            }
            

            // Def="s32 originEquipWep25 = -1"
            /// <summary>
            /// Origin Weapon +25 (s32)
            /// </summary>
            /// <remarks>
            /// This weapon's enhancement source weapon ID 25
            /// </remarks>
            public int OriginWeapon25 
            {
                get => (int)CellsByName["OriginWeapon25"].Value;
                set => CellsByName["OriginWeapon25"].Value = (int)value;
            }
            

            // Def="f32 vsPlayerDmgCorrectRate_Sleep = 1"
            /// <summary>
            /// Vs. Player - Sleep Damage % (f32)
            /// </summary>
            /// <remarks>
            /// Only attacks on the player will correct the damage done.
            /// </remarks>
            public float VsPlayerSleepDamagePercent 
            {
                get => (float)CellsByName["VsPlayerSleepDamagePercent"].Value;
                set => CellsByName["VsPlayerSleepDamagePercent"].Value = (float)value;
            }
            

            // Def="f32 vsPlayerDmgCorrectRate_Madness = 1"
            /// <summary>
            /// Vs. Player - Madness Damage % (f32)
            /// </summary>
            /// <remarks>
            /// Only attacks on the player will correct the damage done.
            /// </remarks>
            public float VsPlayerMadnessDamagePercent 
            {
                get => (float)CellsByName["VsPlayerMadnessDamagePercent"].Value;
                set => CellsByName["VsPlayerMadnessDamagePercent"].Value = (float)value;
            }
            

            // Def="f32 saGuardCutRate"
            /// <summary>
            /// Poise Damage - Guard Absorption (f32)
            /// </summary>
            /// <remarks>
            /// SA damage cut rate when guard is successful
            /// </remarks>
            public float PoiseDamageGuardAbsorption 
            {
                get => (float)CellsByName["PoiseDamageGuardAbsorption"].Value;
                set => CellsByName["PoiseDamageGuardAbsorption"].Value = (float)value;
            }
            

            // Def="u8 defMaterialVariationValue"
            /// <summary>
            /// Defence Material - Variation Value (u8)
            /// </summary>
            /// <remarks>
            /// It is a value used to divide the damage SFX and SE into variations in combination with the defense material used when guarding. SEQ16473
            /// </remarks>
            public byte DefenceMaterialVariationValue 
            {
                get => (byte)CellsByName["DefenceMaterialVariationValue"].Value;
                set => CellsByName["DefenceMaterialVariationValue"].Value = (byte)value;
            }
            

            // Def="u8 spAttributeVariationValue"
            /// <summary>
            /// Special Attribute - Variation Value (u8)
            /// </summary>
            /// <remarks>
            /// It is a value used to give variation to abnormal state SFX, SE, etc. in combination with the special attribute of the weapon. SEQ16473
            /// </remarks>
            public byte SpecialAttributeVariationValue 
            {
                get => (byte)CellsByName["SpecialAttributeVariationValue"].Value;
                set => CellsByName["SpecialAttributeVariationValue"].Value = (byte)value;
            }
            

            // Def="s16 stealthAtkRate"
            /// <summary>
            /// Stealth Attack Multiplier (s16)
            /// </summary>
            /// <remarks>
            /// Stealth attack power multiplier
            /// </remarks>
            public short StealthAttackMultiplier 
            {
                get => (short)CellsByName["StealthAttackMultiplier"].Value;
                set => CellsByName["StealthAttackMultiplier"].Value = (short)value;
            }
            

            // Def="f32 vsPlayerDmgCorrectRate_Disease = 1"
            /// <summary>
            /// Vs. Player - Scarlet Rot Damage % (f32)
            /// </summary>
            /// <remarks>
            /// Only attacks on the player will correct the damage done.
            /// </remarks>
            public float VsPlayerScarletRotDamagePercent 
            {
                get => (float)CellsByName["VsPlayerScarletRotDamagePercent"].Value;
                set => CellsByName["VsPlayerScarletRotDamagePercent"].Value = (float)value;
            }
            

            // Def="f32 vsPlayerDmgCorrectRate_Curse = 1"
            /// <summary>
            /// Vs. Player - Blight Damage % (f32)
            /// </summary>
            /// <remarks>
            /// Only attacks on the player will correct the damage done.
            /// </remarks>
            public float VsPlayerBlightDamagePercent 
            {
                get => (float)CellsByName["VsPlayerBlightDamagePercent"].Value;
                set => CellsByName["VsPlayerBlightDamagePercent"].Value = (float)value;
            }
            

                }
            }
            
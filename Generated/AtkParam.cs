
namespace StronglyTypedParams
{
    public class AtkParam : ParamRow
    {
        public AtkParam() : base()
        {
        }


        // Def="f32 hit0_Radius"
        /// <summary>
        /// Hit 0: Radius (f32)
        /// </summary>
        /// <remarks>
        /// Sphere, capsule radius
        /// </remarks>
        public float Hit0Radius
        {
            get => (float)CellsByName["Hit0Radius"].Value;
            set => CellsByName["Hit0Radius"].Value = value;
        }


        // Def="f32 hit1_Radius"
        /// <summary>
        /// Hit 1: Radius (f32)
        /// </summary>
        /// <remarks>
        /// Sphere, capsule radius
        /// </remarks>
        public float Hit1Radius
        {
            get => (float)CellsByName["Hit1Radius"].Value;
            set => CellsByName["Hit1Radius"].Value = value;
        }


        // Def="f32 hit2_Radius"
        /// <summary>
        /// Hit 2: Radius (f32)
        /// </summary>
        /// <remarks>
        /// Sphere, capsule radius
        /// </remarks>
        public float Hit2Radius
        {
            get => (float)CellsByName["Hit2Radius"].Value;
            set => CellsByName["Hit2Radius"].Value = value;
        }


        // Def="f32 hit3_Radius"
        /// <summary>
        /// Hit 3: Radius (f32)
        /// </summary>
        /// <remarks>
        /// Sphere, capsule radius
        /// </remarks>
        public float Hit3Radius
        {
            get => (float)CellsByName["Hit3Radius"].Value;
            set => CellsByName["Hit3Radius"].Value = value;
        }


        // Def="f32 knockbackDist"
        /// <summary>
        /// Knockback Distance (f32)
        /// </summary>
        /// <remarks>
        /// Knockback distance [m]
        /// </remarks>
        public float KnockbackDistance
        {
            get => (float)CellsByName["KnockbackDistance"].Value;
            set => CellsByName["KnockbackDistance"].Value = value;
        }


        // Def="f32 hitStopTime"
        /// <summary>
        /// Hit Stop Time (f32)
        /// </summary>
        /// <remarks>
        /// Hit stop stop time [s]
        /// </remarks>
        public float HitStopTime
        {
            get => (float)CellsByName["HitStopTime"].Value;
            set => CellsByName["HitStopTime"].Value = value;
        }


        // Def="s32 spEffectId0 = -1"
        /// <summary>
        /// Target SpEffect [0] (s32)
        /// </summary>
        /// <remarks>
        /// Enter the ID created with the special effects parameter
        /// </remarks>
        public int TargetSpEffect0
        {
            get => (int)CellsByName["TargetSpEffect0"].Value;
            set => CellsByName["TargetSpEffect0"].Value = value;
        }


        // Def="s32 spEffectId1 = -1"
        /// <summary>
        /// Target SpEffect [1] (s32)
        /// </summary>
        /// <remarks>
        /// Enter the ID created with the special effects parameter
        /// </remarks>
        public int TargetSpEffect1
        {
            get => (int)CellsByName["TargetSpEffect1"].Value;
            set => CellsByName["TargetSpEffect1"].Value = value;
        }


        // Def="s32 spEffectId2 = -1"
        /// <summary>
        /// Target SpEffect [2] (s32)
        /// </summary>
        /// <remarks>
        /// Enter the ID created with the special effects parameter
        /// </remarks>
        public int TargetSpEffect2
        {
            get => (int)CellsByName["TargetSpEffect2"].Value;
            set => CellsByName["TargetSpEffect2"].Value = value;
        }


        // Def="s32 spEffectId3 = -1"
        /// <summary>
        /// Target SpEffect [3] (s32)
        /// </summary>
        /// <remarks>
        /// Enter the ID created with the special effects parameter
        /// </remarks>
        public int TargetSpEffect3
        {
            get => (int)CellsByName["TargetSpEffect3"].Value;
            set => CellsByName["TargetSpEffect3"].Value = value;
        }


        // Def="s32 spEffectId4 = -1"
        /// <summary>
        /// Target SpEffect [4] (s32)
        /// </summary>
        /// <remarks>
        /// Enter the ID created with the special effects parameter
        /// </remarks>
        public int TargetSpEffect4
        {
            get => (int)CellsByName["TargetSpEffect4"].Value;
            set => CellsByName["TargetSpEffect4"].Value = value;
        }


        // Def="s16 hit0_DmyPoly1"
        /// <summary>
        /// Hit 0: Dummy Poly [1] (s16)
        /// </summary>
        /// <remarks>
        /// Damipoli in sphere, capsule position
        /// </remarks>
        public short Hit0DummyPoly1
        {
            get => (short)CellsByName["Hit0DummyPoly1"].Value;
            set => CellsByName["Hit0DummyPoly1"].Value = value;
        }


        // Def="s16 hit1_DmyPoly1"
        /// <summary>
        /// Hit 1: Dummy Poly [1] (s16)
        /// </summary>
        /// <remarks>
        /// Damipoli in sphere, capsule position
        /// </remarks>
        public short Hit1DummyPoly1
        {
            get => (short)CellsByName["Hit1DummyPoly1"].Value;
            set => CellsByName["Hit1DummyPoly1"].Value = value;
        }


        // Def="s16 hit2_DmyPoly1"
        /// <summary>
        /// Hit 2: Dummy Poly [1] (s16)
        /// </summary>
        /// <remarks>
        /// Damipoli in sphere, capsule position
        /// </remarks>
        public short Hit2DummyPoly1
        {
            get => (short)CellsByName["Hit2DummyPoly1"].Value;
            set => CellsByName["Hit2DummyPoly1"].Value = value;
        }


        // Def="s16 hit3_DmyPoly1"
        /// <summary>
        /// Hit 3: Dummy Poly [1] (s16)
        /// </summary>
        /// <remarks>
        /// Damipoli in sphere, capsule position
        /// </remarks>
        public short Hit3DummyPoly1
        {
            get => (short)CellsByName["Hit3DummyPoly1"].Value;
            set => CellsByName["Hit3DummyPoly1"].Value = value;
        }


        // Def="s16 hit0_DmyPoly2"
        /// <summary>
        /// Hit 0: Dummy Poly [2] (s16)
        /// </summary>
        /// <remarks>
        /// The position of another point on the capsule Damipoli. -1 makes it a sphere
        /// </remarks>
        public short Hit0DummyPoly2
        {
            get => (short)CellsByName["Hit0DummyPoly2"].Value;
            set => CellsByName["Hit0DummyPoly2"].Value = value;
        }


        // Def="s16 hit1_DmyPoly2"
        /// <summary>
        /// Hit 1: Dummy Poly [2] (s16)
        /// </summary>
        /// <remarks>
        /// The position of another point on the capsule Damipoli. -1 makes it a sphere
        /// </remarks>
        public short Hit1DummyPoly2
        {
            get => (short)CellsByName["Hit1DummyPoly2"].Value;
            set => CellsByName["Hit1DummyPoly2"].Value = value;
        }


        // Def="s16 hit2_DmyPoly2"
        /// <summary>
        /// Hit 2: Dummy Poly [2] (s16)
        /// </summary>
        /// <remarks>
        /// The position of another point on the capsule Damipoli. -1 makes it a sphere
        /// </remarks>
        public short Hit2DummyPoly2
        {
            get => (short)CellsByName["Hit2DummyPoly2"].Value;
            set => CellsByName["Hit2DummyPoly2"].Value = value;
        }


        // Def="s16 hit3_DmyPoly2"
        /// <summary>
        /// Hit 3: Dummy Poly [2] (s16)
        /// </summary>
        /// <remarks>
        /// The position of another point on the capsule Damipoli. -1 makes it a sphere
        /// </remarks>
        public short Hit3DummyPoly2
        {
            get => (short)CellsByName["Hit3DummyPoly2"].Value;
            set => CellsByName["Hit3DummyPoly2"].Value = value;
        }


        // Def="u16 blowingCorrection"
        /// <summary>
        /// Attack Correction: Blowing (u16)
        /// </summary>
        /// <remarks>
        /// Correction value when blowing off
        /// </remarks>
        public ushort AttackCorrectionBlowing
        {
            get => (ushort)CellsByName["AttackCorrectionBlowing"].Value;
            set => CellsByName["AttackCorrectionBlowing"].Value = value;
        }


        // Def="u16 atkPhysCorrection"
        /// <summary>
        /// Attack Correction: Physical (u16)
        /// </summary>
        /// <remarks>
        /// PC only. Multiplier by multiplying the basic physical attack power
        /// </remarks>
        public ushort AttackCorrectionPhysical
        {
            get => (ushort)CellsByName["AttackCorrectionPhysical"].Value;
            set => CellsByName["AttackCorrectionPhysical"].Value = value;
        }


        // Def="u16 atkMagCorrection"
        /// <summary>
        /// Attack Correction: Magic (u16)
        /// </summary>
        /// <remarks>
        /// PC only. Multiply the magic attack power (in the case of a bow, correct the missile)
        /// </remarks>
        public ushort AttackCorrectionMagic
        {
            get => (ushort)CellsByName["AttackCorrectionMagic"].Value;
            set => CellsByName["AttackCorrectionMagic"].Value = value;
        }


        // Def="u16 atkFireCorrection"
        /// <summary>
        /// Attack Correction: Fire (u16)
        /// </summary>
        /// <remarks>
        /// PC only. Multiply the fire attack power (in the case of a bow, correct the missile)
        /// </remarks>
        public ushort AttackCorrectionFire
        {
            get => (ushort)CellsByName["AttackCorrectionFire"].Value;
            set => CellsByName["AttackCorrectionFire"].Value = value;
        }


        // Def="u16 atkThunCorrection"
        /// <summary>
        /// Attack Correction: Lightning (u16)
        /// </summary>
        /// <remarks>
        /// PC only. Multiplier for electric shock attack power (in the case of a bow, correct the missile)
        /// </remarks>
        public ushort AttackCorrectionLightning
        {
            get => (ushort)CellsByName["AttackCorrectionLightning"].Value;
            set => CellsByName["AttackCorrectionLightning"].Value = value;
        }


        // Def="u16 atkStamCorrection"
        /// <summary>
        /// Attack Correction: Stamina (u16)
        /// </summary>
        /// <remarks>
        /// PC only. Multiplier for stamina attack power
        /// </remarks>
        public ushort AttackCorrectionStamina
        {
            get => (ushort)CellsByName["AttackCorrectionStamina"].Value;
            set => CellsByName["AttackCorrectionStamina"].Value = value;
        }


        // Def="u16 guardAtkRateCorrection"
        /// <summary>
        /// Attack Correction: Guard Attack Rate (u16)
        /// </summary>
        /// <remarks>
        /// PC only. 1 only
        /// </remarks>
        public ushort AttackCorrectionGuardAttackRate
        {
            get => (ushort)CellsByName["AttackCorrectionGuardAttackRate"].Value;
            set => CellsByName["AttackCorrectionGuardAttackRate"].Value = value;
        }


        // Def="u16 guardBreakCorrection"
        /// <summary>
        /// Attack Correction: Guard Break (u16)
        /// </summary>
        /// <remarks>
        /// PC only. Multiplying the base value by the repelling of the attack
        /// </remarks>
        public ushort AttackCorrectionGuardBreak
        {
            get => (ushort)CellsByName["AttackCorrectionGuardBreak"].Value;
            set => CellsByName["AttackCorrectionGuardBreak"].Value = value;
        }


        // Def="u16 atkThrowEscapeCorrection"
        /// <summary>
        /// Attack Correction: Throw Escape (u16)
        /// </summary>
        /// <remarks>
        /// Weapon correction value for throw-through attacks
        /// </remarks>
        public ushort AttackCorrectionThrowEscape
        {
            get => (ushort)CellsByName["AttackCorrectionThrowEscape"].Value;
            set => CellsByName["AttackCorrectionThrowEscape"].Value = value;
        }


        // Def="u8 subCategory1"
        /// <summary>
        /// Conditional Category [1] (u8)
        /// </summary>
        /// <remarks>
        /// Subcategory 1
        /// </remarks>
        public byte ConditionalCategory1
        {
            get => (byte)CellsByName["ConditionalCategory1"].Value;
            set => CellsByName["ConditionalCategory1"].Value = value;
        }


        // Def="u8 subCategory2"
        /// <summary>
        /// Conditional Category [2] (u8)
        /// </summary>
        /// <remarks>
        /// Subcategory 2
        /// </remarks>
        public byte ConditionalCategory2
        {
            get => (byte)CellsByName["ConditionalCategory2"].Value;
            set => CellsByName["ConditionalCategory2"].Value = value;
        }


        // Def="u16 atkPhys"
        /// <summary>
        /// Damage: Physical (u16)
        /// </summary>
        /// <remarks>
        /// NPCs only. Basic damage of physical attack
        /// </remarks>
        public ushort DamagePhysical
        {
            get => (ushort)CellsByName["DamagePhysical"].Value;
            set => CellsByName["DamagePhysical"].Value = value;
        }


        // Def="u16 atkMag"
        /// <summary>
        /// Damage: Magic (u16)
        /// </summary>
        /// <remarks>
        /// NPCs only. Additional damage from magic attacks
        /// </remarks>
        public ushort DamageMagic
        {
            get => (ushort)CellsByName["DamageMagic"].Value;
            set => CellsByName["DamageMagic"].Value = value;
        }


        // Def="u16 atkFire"
        /// <summary>
        /// Damage: Fire (u16)
        /// </summary>
        /// <remarks>
        /// NPCs only. Additional damage from fire attacks
        /// </remarks>
        public ushort DamageFire
        {
            get => (ushort)CellsByName["DamageFire"].Value;
            set => CellsByName["DamageFire"].Value = value;
        }


        // Def="u16 atkThun"
        /// <summary>
        /// Damage: Lightning (u16)
        /// </summary>
        /// <remarks>
        /// NPCs only. Additional damage from electric shock attacks
        /// </remarks>
        public ushort DamageLightning
        {
            get => (ushort)CellsByName["DamageLightning"].Value;
            set => CellsByName["DamageLightning"].Value = value;
        }


        // Def="u16 atkStam"
        /// <summary>
        /// Damage: Stamina (u16)
        /// </summary>
        /// <remarks>
        /// NPCs only. Amount of damage to enemy (player) stamina
        /// </remarks>
        public ushort DamageStamina
        {
            get => (ushort)CellsByName["DamageStamina"].Value;
            set => CellsByName["DamageStamina"].Value = value;
        }


        // Def="u16 guardAtkRate"
        /// <summary>
        /// Damage: Guard Attack Rate (u16)
        /// </summary>
        /// <remarks>
        /// NPCs only. Flick value
        /// </remarks>
        public ushort DamageGuardAttackRate
        {
            get => (ushort)CellsByName["DamageGuardAttackRate"].Value;
            set => CellsByName["DamageGuardAttackRate"].Value = value;
        }


        // Def="u16 guardBreakRate"
        /// <summary>
        /// Damage: Guard Break Rate (u16)
        /// </summary>
        /// <remarks>
        /// NPCs only. Value used to determine if an attack is repelled
        /// </remarks>
        public ushort DamageGuardBreakRate
        {
            get => (ushort)CellsByName["DamageGuardBreakRate"].Value;
            set => CellsByName["DamageGuardBreakRate"].Value = value;
        }


        // Def="dummy8 pad6[1]"
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


        // Def="u8 isEnableCalcDamageForBushesObj"
        /// <summary>
        /// Is Considered Special Attack for Asset Destruction (u8)
        /// </summary>
        /// <remarks>
        /// Do you want to calculate damage for assets that are "Break due to bush damage"? To set. 〇: Calculate, ×: Do not calculate (that is, you cannot inflict damage) [GR] SEQ20617
        /// </remarks>
        public byte IsConsideredSpecialAttackForAssetDestruction
        {
            get => (byte)CellsByName["IsConsideredSpecialAttackForAssetDestruction"].Value;
            set => CellsByName["IsConsideredSpecialAttackForAssetDestruction"].Value = value;
        }


        // Def="u16 atkThrowEscape"
        /// <summary>
        /// Damage: Throw Escape (u16)
        /// </summary>
        /// <remarks>
        /// Throw-through attack power
        /// </remarks>
        public ushort DamageThrowEscape
        {
            get => (ushort)CellsByName["DamageThrowEscape"].Value;
            set => CellsByName["DamageThrowEscape"].Value = value;
        }


        // Def="u16 atkObj"
        /// <summary>
        /// Damage: Object (u16)
        /// </summary>
        /// <remarks>
        /// Attack power against OBJ
        /// </remarks>
        public ushort DamageObject
        {
            get => (ushort)CellsByName["DamageObject"].Value;
            set => CellsByName["DamageObject"].Value = value;
        }


        // Def="s16 guardStaminaCutRate"
        /// <summary>
        /// Guard Cut Stamina Rate (s16)
        /// </summary>
        /// <remarks>
        /// Correct the [stamina cut rate when guarding] set in the weapon parameter and NPC parameter.
        /// </remarks>
        public short GuardCutStaminaRate
        {
            get => (short)CellsByName["GuardCutStaminaRate"].Value;
            set => CellsByName["GuardCutStaminaRate"].Value = value;
        }


        // Def="s16 guardRate"
        /// <summary>
        /// Guard Rate (s16)
        /// </summary>
        /// <remarks>
        /// NPC, the guard performance set in the weapon parameter is uniformly corrected. 0, 1x / 100, 2x / -100, guard multiplier = (guard multiplier / 100) to increase / decrease the parameter to 0. + 1)
        /// </remarks>
        public short GuardRate
        {
            get => (short)CellsByName["GuardRate"].Value;
            set => CellsByName["GuardRate"].Value = value;
        }


        // Def="u16 throwTypeId"
        /// <summary>
        /// Throw Type ID (u16)
        /// </summary>
        /// <remarks>
        /// ID associated with the throw parameter
        /// </remarks>
        public ushort ThrowTypeID
        {
            get => (ushort)CellsByName["ThrowTypeID"].Value;
            set => CellsByName["ThrowTypeID"].Value = value;
        }


        // Def="u8 hit0_hitType"
        /// <summary>
        /// Hit 0: Hit Type (u8)
        /// </summary>
        /// <remarks>
        /// Hit part
        /// </remarks>
        public byte Hit0HitType
        {
            get => (byte)CellsByName["Hit0HitType"].Value;
            set => CellsByName["Hit0HitType"].Value = value;
        }


        // Def="u8 hit1_hitType"
        /// <summary>
        /// Hit 1: Hit Type (u8)
        /// </summary>
        /// <remarks>
        /// Hit part
        /// </remarks>
        public byte Hit1HitType
        {
            get => (byte)CellsByName["Hit1HitType"].Value;
            set => CellsByName["Hit1HitType"].Value = value;
        }


        // Def="u8 hit2_hitType"
        /// <summary>
        /// Hit 2: Hit Type (u8)
        /// </summary>
        /// <remarks>
        /// Hit part
        /// </remarks>
        public byte Hit2HitType
        {
            get => (byte)CellsByName["Hit2HitType"].Value;
            set => CellsByName["Hit2HitType"].Value = value;
        }


        // Def="u8 hit3_hitType"
        /// <summary>
        /// Hit 3: Hit Type (u8)
        /// </summary>
        /// <remarks>
        /// Hit part
        /// </remarks>
        public byte Hit3HitType
        {
            get => (byte)CellsByName["Hit3HitType"].Value;
            set => CellsByName["Hit3HitType"].Value = value;
        }


        // Def="u8 hti0_Priority"
        /// <summary>
        /// Hit 0: Priority (u8)
        /// </summary>
        /// <remarks>
        /// priority. If there are two or more hits at the same time, the one with the higher priority will be adopted.
        /// </remarks>
        public byte Hit0Priority
        {
            get => (byte)CellsByName["Hit0Priority"].Value;
            set => CellsByName["Hit0Priority"].Value = value;
        }


        // Def="u8 hti1_Priority"
        /// <summary>
        /// Hit 1: Priority (u8)
        /// </summary>
        /// <remarks>
        /// priority. If there are two or more hits at the same time, the one with the higher priority will be adopted.
        /// </remarks>
        public byte Hit1Priority
        {
            get => (byte)CellsByName["Hit1Priority"].Value;
            set => CellsByName["Hit1Priority"].Value = value;
        }


        // Def="u8 hti2_Priority"
        /// <summary>
        /// Hit 2: Priority (u8)
        /// </summary>
        /// <remarks>
        /// priority. If there are two or more hits at the same time, the one with the higher priority will be adopted.
        /// </remarks>
        public byte Hit2Priority
        {
            get => (byte)CellsByName["Hit2Priority"].Value;
            set => CellsByName["Hit2Priority"].Value = value;
        }


        // Def="u8 hti3_Priority"
        /// <summary>
        /// Hit 3: Priority (u8)
        /// </summary>
        /// <remarks>
        /// priority. If there are two or more hits at the same time, the one with the higher priority will be adopted.
        /// </remarks>
        public byte Hit3Priority
        {
            get => (byte)CellsByName["Hit3Priority"].Value;
            set => CellsByName["Hit3Priority"].Value = value;
        }


        // Def="u8 dmgLevel"
        /// <summary>
        /// Damage Level (u8)
        /// </summary>
        /// <remarks>
        /// Which damage motion should be played against the enemy when attacking? To decide.
        /// </remarks>
        public byte DamageLevel
        {
            get => (byte)CellsByName["DamageLevel"].Value;
            set => CellsByName["DamageLevel"].Value = value;
        }


        // Def="u8 mapHitType"
        /// <summary>
        /// Map Hit Type (u8)
        /// </summary>
        /// <remarks>
        /// Which map do you see around the attack? The set
        /// </remarks>
        public byte MapHitType
        {
            get => (byte)CellsByName["MapHitType"].Value;
            set => CellsByName["MapHitType"].Value = value;
        }


        // Def="s8 guardCutCancelRate"
        /// <summary>
        /// Guard Absorption Bypass Rate (s8)
        /// </summary>
        /// <remarks>
        /// Guard cut rate invalidation ratio (-100 to 100) → Normal at 0 / Completely invalidated at -100 / Doubles the defense effect of the opponent at 100 → -50, 100% cut shield becomes 50% cut Become 
        /// </remarks>
        public sbyte GuardAbsorptionBypassRate
        {
            get => (sbyte)CellsByName["GuardAbsorptionBypassRate"].Value;
            set => CellsByName["GuardAbsorptionBypassRate"].Value = value;
        }


        // Def="u8 atkAttribute"
        /// <summary>
        /// Attack Attribute (u8)
        /// </summary>
        /// <remarks>
        /// Physical attributes to set for attacks
        /// </remarks>
        public byte AttackAttribute
        {
            get => (byte)CellsByName["AttackAttribute"].Value;
            set => CellsByName["AttackAttribute"].Value = value;
        }


        // Def="u8 spAttribute"
        /// <summary>
        /// Special Attribute (u8)
        /// </summary>
        /// <remarks>
        /// Special attributes to set for attacks
        /// </remarks>
        public byte SpecialAttribute
        {
            get => (byte)CellsByName["SpecialAttribute"].Value;
            set => CellsByName["SpecialAttribute"].Value = value;
        }


        // Def="u8 atkType"
        /// <summary>
        /// Attack Type (u8)
        /// </summary>
        /// <remarks>
        /// Specify SFX / SE at the time of attack (1 set by attribute, material, size)
        /// </remarks>
        public byte AttackType
        {
            get => (byte)CellsByName["AttackType"].Value;
            set => CellsByName["AttackType"].Value = value;
        }


        // Def="u8 atkMaterial"
        /// <summary>
        /// Attack Material (u8)
        /// </summary>
        /// <remarks>
        /// Specify SFX / SE at the time of attack (1 set by attribute, material, size)
        /// </remarks>
        public byte AttackMaterial
        {
            get => (byte)CellsByName["AttackMaterial"].Value;
            set => CellsByName["AttackMaterial"].Value = value;
        }


        // Def="u8 guardRangeType"
        /// <summary>
        /// Guard Range Type (u8)
        /// </summary>
        /// <remarks>
        /// Guard judgment position
        /// </remarks>
        public byte GuardRangeType
        {
            get => (byte)CellsByName["GuardRangeType"].Value;
            set => CellsByName["GuardRangeType"].Value = value;
        }


        // Def="u16 defSeMaterial1"
        /// <summary>
        /// Defence SE Material (u16)
        /// </summary>
        /// <remarks>
        /// Used for SE when guarding 1
        /// </remarks>
        public ushort DefenceSEMaterial
        {
            get => (ushort)CellsByName["DefenceSEMaterial"].Value;
            set => CellsByName["DefenceSEMaterial"].Value = value;
        }


        // Def="u8 hitSourceType"
        /// <summary>
        /// Hit Source Type (u8)
        /// </summary>
        /// <remarks>
        /// Where do you get the Damipoli ID per attack? To specify
        /// </remarks>
        public byte HitSourceType
        {
            get => (byte)CellsByName["HitSourceType"].Value;
            set => CellsByName["HitSourceType"].Value = value;
        }


        // Def="u8 throwFlag"
        /// <summary>
        /// Throw Flag (u8)
        /// </summary>
        /// <remarks>
        /// Flag used for throwing information
        /// </remarks>
        public byte ThrowFlag
        {
            get => (byte)CellsByName["ThrowFlag"].Value;
            set => CellsByName["ThrowFlag"].Value = value;
        }


        // Def="u8 disableGuard:1"
        /// <summary>
        /// Disable Guard (u8)
        /// </summary>
        /// <remarks>
        /// If 1, ignore the guard on the guard side and enter the damage level
        /// </remarks>
        public byte DisableGuard
        {
            get => (byte)CellsByName["DisableGuard"].Value;
            set => CellsByName["DisableGuard"].Value = value;
        }


        // Def="u8 disableStaminaAttack:1"
        /// <summary>
        /// Disable Stamina Attack (u8)
        /// </summary>
        /// <remarks>
        /// "Destruction judgment" is performed by stamina attack power, but stamina is not actually reduced.
        /// </remarks>
        public byte DisableStaminaAttack
        {
            get => (byte)CellsByName["DisableStaminaAttack"].Value;
            set => CellsByName["DisableStaminaAttack"].Value = value;
        }


        // Def="u8 disableHitSpEffect:1"
        /// <summary>
        /// Disable Hit SpEffect (u8)
        /// </summary>
        /// <remarks>
        /// Disables special effects when an attack hits. SCE bug countermeasures
        /// </remarks>
        public byte DisableHitSpEffect
        {
            get => (byte)CellsByName["DisableHitSpEffect"].Value;
            set => CellsByName["DisableHitSpEffect"].Value = value;
        }


        // Def="u8 IgnoreNotifyMissSwingForAI:1"
        /// <summary>
        /// Disable Missed Attack Notification For AI (u8)
        /// </summary>
        /// <remarks>
        /// Do not notify AI of missed swing
        /// </remarks>
        public byte DisableMissedAttackNotificationForAI
        {
            get => (byte)CellsByName["DisableMissedAttackNotificationForAI"].Value;
            set => CellsByName["DisableMissedAttackNotificationForAI"].Value = value;
        }


        // Def="u8 repeatHitSfx:1"
        /// <summary>
        /// Repeat Hit Sound FX (u8)
        /// </summary>
        /// <remarks>
        /// Enemy only: Does SFX occur continuously when hitting a wall?
        /// </remarks>
        public byte RepeatHitSoundFX
        {
            get => (byte)CellsByName["RepeatHitSoundFX"].Value;
            set => CellsByName["RepeatHitSoundFX"].Value = value;
        }


        // Def="u8 isArrowAtk:1"
        /// <summary>
        /// Is Physical Projectile (u8)
        /// </summary>
        /// <remarks>
        /// Used for site damage judgment.
        /// </remarks>
        public byte IsPhysicalProjectile
        {
            get => (byte)CellsByName["IsPhysicalProjectile"].Value;
            set => CellsByName["IsPhysicalProjectile"].Value = value;
        }


        // Def="u8 isGhostAtk:1"
        /// <summary>
        /// Is Attack By Ghost (u8)
        /// </summary>
        /// <remarks>
        /// Used for determining spirit damage.
        /// </remarks>
        public byte IsAttackByGhost
        {
            get => (byte)CellsByName["IsAttackByGhost"].Value;
            set => CellsByName["IsAttackByGhost"].Value = value;
        }


        // Def="u8 isDisableNoDamage:1"
        /// <summary>
        /// Disable No Damage (u8)
        /// </summary>
        /// <remarks>
        /// Ignore invincible effects such as steps, TAE's complete invincibility cannot be ignored.
        /// </remarks>
        public byte DisableNoDamage
        {
            get => (byte)CellsByName["DisableNoDamage"].Value;
            set => CellsByName["DisableNoDamage"].Value = value;
        }


        // Def="s8 atkPow_forSfx"
        /// <summary>
        /// Attack Power - SFX Effect (s8)
        /// </summary>
        /// <remarks>
        /// Attack strength [SFX]
        /// </remarks>
        public sbyte AttackPowerSFXEffect
        {
            get => (sbyte)CellsByName["AttackPowerSFXEffect"].Value;
            set => CellsByName["AttackPowerSFXEffect"].Value = value;
        }


        // Def="s8 atkDir_forSfx"
        /// <summary>
        /// Attack Direction - SFX Effect (s8)
        /// </summary>
        /// <remarks>
        /// Attack direction [SFX]
        /// </remarks>
        public sbyte AttackDirectionSFXEffect
        {
            get => (sbyte)CellsByName["AttackDirectionSFXEffect"].Value;
            set => CellsByName["AttackDirectionSFXEffect"].Value = value;
        }


        // Def="u8 opposeTarget:1 = 1"
        /// <summary>
        /// Oppose Target (u8)
        /// </summary>
        /// <remarks>
        /// Target: ● Hostile
        /// </remarks>
        public byte OpposeTarget
        {
            get => (byte)CellsByName["OpposeTarget"].Value;
            set => CellsByName["OpposeTarget"].Value = value;
        }


        // Def="u8 friendlyTarget:1"
        /// <summary>
        /// Friendly Target (u8)
        /// </summary>
        /// <remarks>
        /// Target: ○ Allies
        /// </remarks>
        public byte FriendlyTarget
        {
            get => (byte)CellsByName["FriendlyTarget"].Value;
            set => CellsByName["FriendlyTarget"].Value = value;
        }


        // Def="u8 selfTarget:1"
        /// <summary>
        /// Self Target (u8)
        /// </summary>
        /// <remarks>
        /// Target: myself
        /// </remarks>
        public byte SelfTarget
        {
            get => (byte)CellsByName["SelfTarget"].Value;
            set => CellsByName["SelfTarget"].Value = value;
        }


        // Def="u8 isCheckDoorPenetration:1"
        /// <summary>
        /// Is Target Hit Through Door (u8)
        /// </summary>
        /// <remarks>
        /// Whether to check the door penetration. In the case of ○, it is judged whether or not the target through the door can be attacked.
        /// </remarks>
        public byte IsTargetHitThroughDoor
        {
            get => (byte)CellsByName["IsTargetHitThroughDoor"].Value;
            set => CellsByName["IsTargetHitThroughDoor"].Value = value;
        }


        // Def="u8 isVsRideAtk:1"
        /// <summary>
        /// Is Ride Special Attack (u8)
        /// </summary>
        /// <remarks>
        /// If you hit the target of the riding special attack while riding, the SA damage will be multiplied by the multiplier.
        /// </remarks>
        public byte IsRideSpecialAttack
        {
            get => (byte)CellsByName["IsRideSpecialAttack"].Value;
            set => CellsByName["IsRideSpecialAttack"].Value = value;
        }


        // Def="u8 isAddBaseAtk:1"
        /// <summary>
        /// Is Base Attack Added (u8)
        /// </summary>
        /// <remarks>
        /// Do you refer to the additional attack power even in weapon attacks?
        /// </remarks>
        public byte IsBaseAttackAdded
        {
            get => (byte)CellsByName["IsBaseAttackAdded"].Value;
            set => CellsByName["IsBaseAttackAdded"].Value = value;
        }


        // Def="u8 excludeThreatLvNotify:1"
        /// <summary>
        /// Is Excluded from Threat Level Notification (u8)
        /// </summary>
        /// <remarks>
        /// Is it excluded from threat level notification?
        /// </remarks>
        public byte IsExcludedFromThreatLevelNotification
        {
            get => (byte)CellsByName["IsExcludedFromThreatLevelNotification"].Value;
            set => CellsByName["IsExcludedFromThreatLevelNotification"].Value = value;
        }


        // Def="dummy8 pad1:1"
        /// <summary>
        /// pad1 (dummy8)
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        public object Pad1
        {
            get => (object)CellsByName["Pad1"].Value;
            set => CellsByName["Pad1"].Value = value;
        }


        // Def="u8 atkBehaviorId"
        /// <summary>
        /// Attack Behavior ID (u8)
        /// </summary>
        /// <remarks>
        /// Behavior identification value: Extra large damage transition
        /// </remarks>
        public byte AttackBehaviorID
        {
            get => (byte)CellsByName["AttackBehaviorID"].Value;
            set => CellsByName["AttackBehaviorID"].Value = value;
        }


        // Def="s8 atkPow_forSe"
        /// <summary>
        /// Attack Power - SE Effect (s8)
        /// </summary>
        /// <remarks>
        /// Attack strength [SE]
        /// </remarks>
        public sbyte AttackPowerSEEffect
        {
            get => (sbyte)CellsByName["AttackPowerSEEffect"].Value;
            set => CellsByName["AttackPowerSEEffect"].Value = value;
        }


        // Def="f32 atkSuperArmor"
        /// <summary>
        /// Damage: Poise (f32)
        /// </summary>
        /// <remarks>
        /// NPCs only. Value used for SA break calculation formula
        /// </remarks>
        public float DamagePoise
        {
            get => (float)CellsByName["DamagePoise"].Value;
            set => CellsByName["DamagePoise"].Value = value;
        }


        // Def="s32 decalId1 = -1"
        /// <summary>
        /// Decal ID [1] (s32)
        /// </summary>
        /// <remarks>
        /// Decal ID 1 (directly specified)
        /// </remarks>
        public int DecalID1
        {
            get => (int)CellsByName["DecalID1"].Value;
            set => CellsByName["DecalID1"].Value = value;
        }


        // Def="s32 decalId2 = -1"
        /// <summary>
        /// Decal ID [2] (s32)
        /// </summary>
        /// <remarks>
        /// Decal ID 2 (directly specified)
        /// </remarks>
        public int DecalID2
        {
            get => (int)CellsByName["DecalID2"].Value;
            set => CellsByName["DecalID2"].Value = value;
        }


        // Def="s32 AppearAiSoundId"
        /// <summary>
        /// Appear AI Sound ID (s32)
        /// </summary>
        /// <remarks>
        /// ID of AI sound generated when an attack occurs
        /// </remarks>
        public int AppearAISoundID
        {
            get => (int)CellsByName["AppearAISoundID"].Value;
            set => CellsByName["AppearAISoundID"].Value = value;
        }


        // Def="s32 HitAiSoundId"
        /// <summary>
        /// Hit AI Sound ID (s32)
        /// </summary>
        /// <remarks>
        /// ID of AI sound generated at the time of hit
        /// </remarks>
        public int HitAISoundID
        {
            get => (int)CellsByName["HitAISoundID"].Value;
            set => CellsByName["HitAISoundID"].Value = value;
        }


        // Def="s32 HitRumbleId = -1"
        /// <summary>
        /// Hit Rumble ID - Default (s32)
        /// </summary>
        /// <remarks>
        /// Vibration ID at the time of hit (-1 invalid). It is a vibration ID when none of the following three applies
        /// </remarks>
        public int HitRumbleIDDefault
        {
            get => (int)CellsByName["HitRumbleIDDefault"].Value;
            set => CellsByName["HitRumbleIDDefault"].Value = value;
        }


        // Def="s32 HitRumbleIdByNormal = -1"
        /// <summary>
        /// Hit Rumble ID - Normal (s32)
        /// </summary>
        /// <remarks>
        /// Vibration ID at the time of hit when hitting the tip (-1 invalid)
        /// </remarks>
        public int HitRumbleIDNormal
        {
            get => (int)CellsByName["HitRumbleIDNormal"].Value;
            set => CellsByName["HitRumbleIDNormal"].Value = value;
        }


        // Def="s32 HitRumbleIdByMiddle = -1"
        /// <summary>
        /// Hit Rumble ID - Middle (s32)
        /// </summary>
        /// <remarks>
        /// Vibration ID at the time of hit when hit in the middle (-1 invalid)
        /// </remarks>
        public int HitRumbleIDMiddle
        {
            get => (int)CellsByName["HitRumbleIDMiddle"].Value;
            set => CellsByName["HitRumbleIDMiddle"].Value = value;
        }


        // Def="s32 HitRumbleIdByRoot = -1"
        /// <summary>
        /// Hit Rumble ID - Root (s32)
        /// </summary>
        /// <remarks>
        /// Vibration ID at the time of hit when hitting the root (-1 invalid)
        /// </remarks>
        public int HitRumbleIDRoot
        {
            get => (int)CellsByName["HitRumbleIDRoot"].Value;
            set => CellsByName["HitRumbleIDRoot"].Value = value;
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
            set => CellsByName["TraceSFXID0"].Value = value;
        }


        // Def="s32 traceDmyIdHead0 = -1"
        /// <summary>
        /// Trace SFX ID [0] - Head Dummy Poly (s32)
        /// </summary>
        /// <remarks>
        /// Sword flash root Damipoli ID_0 (-1 invalid)
        /// </remarks>
        public int TraceSFXID0HeadDummyPoly
        {
            get => (int)CellsByName["TraceSFXID0HeadDummyPoly"].Value;
            set => CellsByName["TraceSFXID0HeadDummyPoly"].Value = value;
        }


        // Def="s32 traceDmyIdTail0 = -1"
        /// <summary>
        /// Trace SFX ID [0] - Tail Dummy Poly (s32)
        /// </summary>
        /// <remarks>
        /// Sword Flash Sword Tip Damipoli ID_0
        /// </remarks>
        public int TraceSFXID0TailDummyPoly
        {
            get => (int)CellsByName["TraceSFXID0TailDummyPoly"].Value;
            set => CellsByName["TraceSFXID0TailDummyPoly"].Value = value;
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
            set => CellsByName["TraceSFXID1"].Value = value;
        }


        // Def="s32 traceDmyIdHead1 = -1"
        /// <summary>
        /// Trace SFX ID [1] - Head Dummy Poly (s32)
        /// </summary>
        /// <remarks>
        /// Sword Flash Root Damipoli ID_1 (-1 invalid)
        /// </remarks>
        public int TraceSFXID1HeadDummyPoly
        {
            get => (int)CellsByName["TraceSFXID1HeadDummyPoly"].Value;
            set => CellsByName["TraceSFXID1HeadDummyPoly"].Value = value;
        }


        // Def="s32 traceDmyIdTail1 = -1"
        /// <summary>
        /// Trace SFX ID [1] - Tail Dummy Poly (s32)
        /// </summary>
        /// <remarks>
        /// Sword Flash Sword Tip Damipoli ID_1
        /// </remarks>
        public int TraceSFXID1TailDummyPoly
        {
            get => (int)CellsByName["TraceSFXID1TailDummyPoly"].Value;
            set => CellsByName["TraceSFXID1TailDummyPoly"].Value = value;
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
            set => CellsByName["TraceSFXID2"].Value = value;
        }


        // Def="s32 traceDmyIdHead2 = -1"
        /// <summary>
        /// Trace SFX ID [2] - Head Dummy Poly (s32)
        /// </summary>
        /// <remarks>
        /// Sword Flash Root Damipoli ID_2 (-1 invalid)
        /// </remarks>
        public int TraceSFXID2HeadDummyPoly
        {
            get => (int)CellsByName["TraceSFXID2HeadDummyPoly"].Value;
            set => CellsByName["TraceSFXID2HeadDummyPoly"].Value = value;
        }


        // Def="s32 traceDmyIdTail2 = -1"
        /// <summary>
        /// Trace SFX ID [2] - Tail Dummy Poly (s32)
        /// </summary>
        /// <remarks>
        /// Sword Flash Sword Tip Damipoli ID_2
        /// </remarks>
        public int TraceSFXID2TailDummyPoly
        {
            get => (int)CellsByName["TraceSFXID2TailDummyPoly"].Value;
            set => CellsByName["TraceSFXID2TailDummyPoly"].Value = value;
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
            set => CellsByName["TraceSFXID3"].Value = value;
        }


        // Def="s32 traceDmyIdHead3 = -1"
        /// <summary>
        /// Trace SFX ID [3] - Head Dummy Poly (s32)
        /// </summary>
        /// <remarks>
        /// Sword flash root Damipoli ID_3 (-1 invalid)
        /// </remarks>
        public int TraceSFXID3HeadDummyPoly
        {
            get => (int)CellsByName["TraceSFXID3HeadDummyPoly"].Value;
            set => CellsByName["TraceSFXID3HeadDummyPoly"].Value = value;
        }


        // Def="s32 traceDmyIdTail3 = -1"
        /// <summary>
        /// Trace SFX ID [3] - Tail Dummy Poly (s32)
        /// </summary>
        /// <remarks>
        /// Sword Flash Sword Tip Damipoli ID_3
        /// </remarks>
        public int TraceSFXID3TailDummyPoly
        {
            get => (int)CellsByName["TraceSFXID3TailDummyPoly"].Value;
            set => CellsByName["TraceSFXID3TailDummyPoly"].Value = value;
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
            set => CellsByName["TraceSFXID4"].Value = value;
        }


        // Def="s32 traceDmyIdHead4 = -1"
        /// <summary>
        /// Trace SFX ID [4] - Head Dummy Poly (s32)
        /// </summary>
        /// <remarks>
        /// Sword flash root Damipoli ID_4 (-1 invalid)
        /// </remarks>
        public int TraceSFXID4HeadDummyPoly
        {
            get => (int)CellsByName["TraceSFXID4HeadDummyPoly"].Value;
            set => CellsByName["TraceSFXID4HeadDummyPoly"].Value = value;
        }


        // Def="s32 traceDmyIdTail4 = -1"
        /// <summary>
        /// Trace SFX ID [4] - Tail Dummy Poly (s32)
        /// </summary>
        /// <remarks>
        /// Sword Flash Sword Tip Damipoli ID_4
        /// </remarks>
        public int TraceSFXID4TailDummyPoly
        {
            get => (int)CellsByName["TraceSFXID4TailDummyPoly"].Value;
            set => CellsByName["TraceSFXID4TailDummyPoly"].Value = value;
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
            set => CellsByName["TraceSFXID5"].Value = value;
        }


        // Def="s32 traceDmyIdHead5 = -1"
        /// <summary>
        /// Trace SFX ID [5] - Head Dummy Poly (s32)
        /// </summary>
        /// <remarks>
        /// Sword Flash Root Damipoli ID_5 (-1 invalid)
        /// </remarks>
        public int TraceSFXID5HeadDummyPoly
        {
            get => (int)CellsByName["TraceSFXID5HeadDummyPoly"].Value;
            set => CellsByName["TraceSFXID5HeadDummyPoly"].Value = value;
        }


        // Def="s32 traceDmyIdTail5 = -1"
        /// <summary>
        /// Trace SFX ID [5] - Tail Dummy Poly (s32)
        /// </summary>
        /// <remarks>
        /// Sword Flash Sword Tip Damipoli ID_5
        /// </remarks>
        public int TraceSFXID5TailDummyPoly
        {
            get => (int)CellsByName["TraceSFXID5TailDummyPoly"].Value;
            set => CellsByName["TraceSFXID5TailDummyPoly"].Value = value;
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
            set => CellsByName["TraceSFXID6"].Value = value;
        }


        // Def="s32 traceDmyIdHead6 = -1"
        /// <summary>
        /// Trace SFX ID [6] - Head Dummy Poly (s32)
        /// </summary>
        /// <remarks>
        /// Sword Flash Root Damipoli ID_6 (-1 invalid)
        /// </remarks>
        public int TraceSFXID6HeadDummyPoly
        {
            get => (int)CellsByName["TraceSFXID6HeadDummyPoly"].Value;
            set => CellsByName["TraceSFXID6HeadDummyPoly"].Value = value;
        }


        // Def="s32 traceDmyIdTail6 = -1"
        /// <summary>
        /// Trace SFX ID [6] - Tail Dummy Poly (s32)
        /// </summary>
        /// <remarks>
        /// Sword Flash Sword Tip Damipoli ID_6
        /// </remarks>
        public int TraceSFXID6TailDummyPoly
        {
            get => (int)CellsByName["TraceSFXID6TailDummyPoly"].Value;
            set => CellsByName["TraceSFXID6TailDummyPoly"].Value = value;
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
            set => CellsByName["TraceSFXID7"].Value = value;
        }


        // Def="s32 traceDmyIdHead7 = -1"
        /// <summary>
        /// Trace SFX ID [7] - Head Dummy Poly (s32)
        /// </summary>
        /// <remarks>
        /// Sword Flash Root Damipoli ID_7 (-1 invalid)
        /// </remarks>
        public int TraceSFXID7HeadDummyPoly
        {
            get => (int)CellsByName["TraceSFXID7HeadDummyPoly"].Value;
            set => CellsByName["TraceSFXID7HeadDummyPoly"].Value = value;
        }


        // Def="s32 traceDmyIdTail7 = -1"
        /// <summary>
        /// Trace SFX ID [7] - Tail Dummy Poly (s32)
        /// </summary>
        /// <remarks>
        /// Sword Flash Sword Tip Damipoli ID_7
        /// </remarks>
        public int TraceSFXID7TailDummyPoly
        {
            get => (int)CellsByName["TraceSFXID7TailDummyPoly"].Value;
            set => CellsByName["TraceSFXID7TailDummyPoly"].Value = value;
        }


        // Def="f32 hit4_Radius"
        /// <summary>
        /// Hit 4: Radius (f32)
        /// </summary>
        /// <remarks>
        /// Sphere, capsule radius
        /// </remarks>
        public float Hit4Radius
        {
            get => (float)CellsByName["Hit4Radius"].Value;
            set => CellsByName["Hit4Radius"].Value = value;
        }


        // Def="f32 hit5_Radius"
        /// <summary>
        /// Hit 5: Radius (f32)
        /// </summary>
        /// <remarks>
        /// Sphere, capsule radius
        /// </remarks>
        public float Hit5Radius
        {
            get => (float)CellsByName["Hit5Radius"].Value;
            set => CellsByName["Hit5Radius"].Value = value;
        }


        // Def="f32 hit6_Radius"
        /// <summary>
        /// Hit 6: Radius (f32)
        /// </summary>
        /// <remarks>
        /// Sphere, capsule radius
        /// </remarks>
        public float Hit6Radius
        {
            get => (float)CellsByName["Hit6Radius"].Value;
            set => CellsByName["Hit6Radius"].Value = value;
        }


        // Def="f32 hit7_Radius"
        /// <summary>
        /// Hit 7: Radius (f32)
        /// </summary>
        /// <remarks>
        /// Sphere, capsule radius
        /// </remarks>
        public float Hit7Radius
        {
            get => (float)CellsByName["Hit7Radius"].Value;
            set => CellsByName["Hit7Radius"].Value = value;
        }


        // Def="f32 hit8_Radius"
        /// <summary>
        /// Hit 8: Radius (f32)
        /// </summary>
        /// <remarks>
        /// Sphere, capsule radius
        /// </remarks>
        public float Hit8Radius
        {
            get => (float)CellsByName["Hit8Radius"].Value;
            set => CellsByName["Hit8Radius"].Value = value;
        }


        // Def="f32 hit9_Radius"
        /// <summary>
        /// Hit 9: Radius (f32)
        /// </summary>
        /// <remarks>
        /// Sphere, capsule radius
        /// </remarks>
        public float Hit9Radius
        {
            get => (float)CellsByName["Hit9Radius"].Value;
            set => CellsByName["Hit9Radius"].Value = value;
        }


        // Def="f32 hit10_Radius"
        /// <summary>
        /// Hit 10: Radius (f32)
        /// </summary>
        /// <remarks>
        /// Sphere, capsule radius
        /// </remarks>
        public float Hit10Radius
        {
            get => (float)CellsByName["Hit10Radius"].Value;
            set => CellsByName["Hit10Radius"].Value = value;
        }


        // Def="f32 hit11_Radius"
        /// <summary>
        /// Hit 11: Radius (f32)
        /// </summary>
        /// <remarks>
        /// Sphere, capsule radius
        /// </remarks>
        public float Hit11Radius
        {
            get => (float)CellsByName["Hit11Radius"].Value;
            set => CellsByName["Hit11Radius"].Value = value;
        }


        // Def="f32 hit12_Radius"
        /// <summary>
        /// Hit 12: Radius (f32)
        /// </summary>
        /// <remarks>
        /// Sphere, capsule radius
        /// </remarks>
        public float Hit12Radius
        {
            get => (float)CellsByName["Hit12Radius"].Value;
            set => CellsByName["Hit12Radius"].Value = value;
        }


        // Def="f32 hit13_Radius"
        /// <summary>
        /// Hit 13: Radius (f32)
        /// </summary>
        /// <remarks>
        /// Sphere, capsule radius
        /// </remarks>
        public float Hit13Radius
        {
            get => (float)CellsByName["Hit13Radius"].Value;
            set => CellsByName["Hit13Radius"].Value = value;
        }


        // Def="f32 hit14_Radius"
        /// <summary>
        /// Hit 14: Radius (f32)
        /// </summary>
        /// <remarks>
        /// Sphere, capsule radius
        /// </remarks>
        public float Hit14Radius
        {
            get => (float)CellsByName["Hit14Radius"].Value;
            set => CellsByName["Hit14Radius"].Value = value;
        }


        // Def="f32 hit15_Radius"
        /// <summary>
        /// Hit 15: Radius (f32)
        /// </summary>
        /// <remarks>
        /// Sphere, capsule radius
        /// </remarks>
        public float Hit15Radius
        {
            get => (float)CellsByName["Hit15Radius"].Value;
            set => CellsByName["Hit15Radius"].Value = value;
        }


        // Def="s16 hit4_DmyPoly1"
        /// <summary>
        /// Hit 4: Dummy Poly 1 (s16)
        /// </summary>
        /// <remarks>
        /// Damipoli in sphere, capsule position
        /// </remarks>
        public short Hit4DummyPoly1
        {
            get => (short)CellsByName["Hit4DummyPoly1"].Value;
            set => CellsByName["Hit4DummyPoly1"].Value = value;
        }


        // Def="s16 hit5_DmyPoly1"
        /// <summary>
        /// Hit 5: Dummy Poly 1 (s16)
        /// </summary>
        /// <remarks>
        /// Damipoli in sphere, capsule position
        /// </remarks>
        public short Hit5DummyPoly1
        {
            get => (short)CellsByName["Hit5DummyPoly1"].Value;
            set => CellsByName["Hit5DummyPoly1"].Value = value;
        }


        // Def="s16 hit6_DmyPoly1"
        /// <summary>
        /// Hit 6: Dummy Poly 1 (s16)
        /// </summary>
        /// <remarks>
        /// Damipoli in sphere, capsule position
        /// </remarks>
        public short Hit6DummyPoly1
        {
            get => (short)CellsByName["Hit6DummyPoly1"].Value;
            set => CellsByName["Hit6DummyPoly1"].Value = value;
        }


        // Def="s16 hit7_DmyPoly1"
        /// <summary>
        /// Hit 7: Dummy Poly 1 (s16)
        /// </summary>
        /// <remarks>
        /// Damipoli in sphere, capsule position
        /// </remarks>
        public short Hit7DummyPoly1
        {
            get => (short)CellsByName["Hit7DummyPoly1"].Value;
            set => CellsByName["Hit7DummyPoly1"].Value = value;
        }


        // Def="s16 hit8_DmyPoly1"
        /// <summary>
        /// Hit 8: Dummy Poly 1 (s16)
        /// </summary>
        /// <remarks>
        /// Damipoli in sphere, capsule position
        /// </remarks>
        public short Hit8DummyPoly1
        {
            get => (short)CellsByName["Hit8DummyPoly1"].Value;
            set => CellsByName["Hit8DummyPoly1"].Value = value;
        }


        // Def="s16 hit9_DmyPoly1"
        /// <summary>
        /// Hit 9: Dummy Poly 1 (s16)
        /// </summary>
        /// <remarks>
        /// Damipoli in sphere, capsule position
        /// </remarks>
        public short Hit9DummyPoly1
        {
            get => (short)CellsByName["Hit9DummyPoly1"].Value;
            set => CellsByName["Hit9DummyPoly1"].Value = value;
        }


        // Def="s16 hit10_DmyPoly1"
        /// <summary>
        /// Hit 10: Dummy Poly 1 (s16)
        /// </summary>
        /// <remarks>
        /// Damipoli in sphere, capsule position
        /// </remarks>
        public short Hit10DummyPoly1
        {
            get => (short)CellsByName["Hit10DummyPoly1"].Value;
            set => CellsByName["Hit10DummyPoly1"].Value = value;
        }


        // Def="s16 hit11_DmyPoly1"
        /// <summary>
        /// Hit 11: Dummy Poly 1 (s16)
        /// </summary>
        /// <remarks>
        /// Damipoli in sphere, capsule position
        /// </remarks>
        public short Hit11DummyPoly1
        {
            get => (short)CellsByName["Hit11DummyPoly1"].Value;
            set => CellsByName["Hit11DummyPoly1"].Value = value;
        }


        // Def="s16 hit12_DmyPoly1"
        /// <summary>
        /// Hit 12: Dummy Poly 1 (s16)
        /// </summary>
        /// <remarks>
        /// Damipoli in sphere, capsule position
        /// </remarks>
        public short Hit12DummyPoly1
        {
            get => (short)CellsByName["Hit12DummyPoly1"].Value;
            set => CellsByName["Hit12DummyPoly1"].Value = value;
        }


        // Def="s16 hit13_DmyPoly1"
        /// <summary>
        /// Hit 13: Dummy Poly 1 (s16)
        /// </summary>
        /// <remarks>
        /// Damipoli in sphere, capsule position
        /// </remarks>
        public short Hit13DummyPoly1
        {
            get => (short)CellsByName["Hit13DummyPoly1"].Value;
            set => CellsByName["Hit13DummyPoly1"].Value = value;
        }


        // Def="s16 hit14_DmyPoly1"
        /// <summary>
        /// Hit 14: Dummy Poly 1 (s16)
        /// </summary>
        /// <remarks>
        /// Damipoli in sphere, capsule position
        /// </remarks>
        public short Hit14DummyPoly1
        {
            get => (short)CellsByName["Hit14DummyPoly1"].Value;
            set => CellsByName["Hit14DummyPoly1"].Value = value;
        }


        // Def="s16 hit15_DmyPoly1"
        /// <summary>
        /// Hit 15: Dummy Poly 1 (s16)
        /// </summary>
        /// <remarks>
        /// Damipoli in sphere, capsule position
        /// </remarks>
        public short Hit15DummyPoly1
        {
            get => (short)CellsByName["Hit15DummyPoly1"].Value;
            set => CellsByName["Hit15DummyPoly1"].Value = value;
        }


        // Def="s16 hit4_DmyPoly2"
        /// <summary>
        /// Hit 4: Dummy Poly 2 (s16)
        /// </summary>
        /// <remarks>
        /// The position of another point on the capsule Damipoli. -1 makes it a sphere
        /// </remarks>
        public short Hit4DummyPoly2
        {
            get => (short)CellsByName["Hit4DummyPoly2"].Value;
            set => CellsByName["Hit4DummyPoly2"].Value = value;
        }


        // Def="s16 hit5_DmyPoly2"
        /// <summary>
        /// Hit 5: Dummy Poly 2 (s16)
        /// </summary>
        /// <remarks>
        /// The position of another point on the capsule Damipoli. -1 makes it a sphere
        /// </remarks>
        public short Hit5DummyPoly2
        {
            get => (short)CellsByName["Hit5DummyPoly2"].Value;
            set => CellsByName["Hit5DummyPoly2"].Value = value;
        }


        // Def="s16 hit6_DmyPoly2"
        /// <summary>
        /// Hit 6: Dummy Poly 2 (s16)
        /// </summary>
        /// <remarks>
        /// The position of another point on the capsule Damipoli. -1 makes it a sphere
        /// </remarks>
        public short Hit6DummyPoly2
        {
            get => (short)CellsByName["Hit6DummyPoly2"].Value;
            set => CellsByName["Hit6DummyPoly2"].Value = value;
        }


        // Def="s16 hit7_DmyPoly2"
        /// <summary>
        /// Hit 7: Dummy Poly 2 (s16)
        /// </summary>
        /// <remarks>
        /// The position of another point on the capsule Damipoli. -1 makes it a sphere
        /// </remarks>
        public short Hit7DummyPoly2
        {
            get => (short)CellsByName["Hit7DummyPoly2"].Value;
            set => CellsByName["Hit7DummyPoly2"].Value = value;
        }


        // Def="s16 hit8_DmyPoly2"
        /// <summary>
        /// Hit 8: Dummy Poly 2 (s16)
        /// </summary>
        /// <remarks>
        /// The position of another point on the capsule Damipoli. -1 makes it a sphere
        /// </remarks>
        public short Hit8DummyPoly2
        {
            get => (short)CellsByName["Hit8DummyPoly2"].Value;
            set => CellsByName["Hit8DummyPoly2"].Value = value;
        }


        // Def="s16 hit9_DmyPoly2"
        /// <summary>
        /// Hit 9: Dummy Poly 2 (s16)
        /// </summary>
        /// <remarks>
        /// The position of another point on the capsule Damipoli. -1 makes it a sphere
        /// </remarks>
        public short Hit9DummyPoly2
        {
            get => (short)CellsByName["Hit9DummyPoly2"].Value;
            set => CellsByName["Hit9DummyPoly2"].Value = value;
        }


        // Def="s16 hit10_DmyPoly2"
        /// <summary>
        /// Hit 10: Dummy Poly 2 (s16)
        /// </summary>
        /// <remarks>
        /// The position of another point on the capsule Damipoli. -1 makes it a sphere
        /// </remarks>
        public short Hit10DummyPoly2
        {
            get => (short)CellsByName["Hit10DummyPoly2"].Value;
            set => CellsByName["Hit10DummyPoly2"].Value = value;
        }


        // Def="s16 hit11_DmyPoly2"
        /// <summary>
        /// Hit 11: Dummy Poly 2 (s16)
        /// </summary>
        /// <remarks>
        /// The position of another point on the capsule Damipoli. -1 makes it a sphere
        /// </remarks>
        public short Hit11DummyPoly2
        {
            get => (short)CellsByName["Hit11DummyPoly2"].Value;
            set => CellsByName["Hit11DummyPoly2"].Value = value;
        }


        // Def="s16 hit12_DmyPoly2"
        /// <summary>
        /// Hit 12: Dummy Poly 2 (s16)
        /// </summary>
        /// <remarks>
        /// The position of another point on the capsule Damipoli. -1 makes it a sphere
        /// </remarks>
        public short Hit12DummyPoly2
        {
            get => (short)CellsByName["Hit12DummyPoly2"].Value;
            set => CellsByName["Hit12DummyPoly2"].Value = value;
        }


        // Def="s16 hit13_DmyPoly2"
        /// <summary>
        /// Hit 13: Dummy Poly 2 (s16)
        /// </summary>
        /// <remarks>
        /// The position of another point on the capsule Damipoli. -1 makes it a sphere
        /// </remarks>
        public short Hit13DummyPoly2
        {
            get => (short)CellsByName["Hit13DummyPoly2"].Value;
            set => CellsByName["Hit13DummyPoly2"].Value = value;
        }


        // Def="s16 hit14_DmyPoly2"
        /// <summary>
        /// Hit 14: Dummy Poly 2 (s16)
        /// </summary>
        /// <remarks>
        /// The position of another point on the capsule Damipoli. -1 makes it a sphere
        /// </remarks>
        public short Hit14DummyPoly2
        {
            get => (short)CellsByName["Hit14DummyPoly2"].Value;
            set => CellsByName["Hit14DummyPoly2"].Value = value;
        }


        // Def="s16 hit15_DmyPoly2"
        /// <summary>
        /// Hit 15: Dummy Poly 2 (s16)
        /// </summary>
        /// <remarks>
        /// The position of another point on the capsule Damipoli. -1 makes it a sphere
        /// </remarks>
        public short Hit15DummyPoly2
        {
            get => (short)CellsByName["Hit15DummyPoly2"].Value;
            set => CellsByName["Hit15DummyPoly2"].Value = value;
        }


        // Def="u8 hit4_hitType"
        /// <summary>
        /// Hit 4: Hit Type (u8)
        /// </summary>
        /// <remarks>
        /// Hit part
        /// </remarks>
        public byte Hit4HitType
        {
            get => (byte)CellsByName["Hit4HitType"].Value;
            set => CellsByName["Hit4HitType"].Value = value;
        }


        // Def="u8 hit5_hitType"
        /// <summary>
        /// Hit 5: Hit Type (u8)
        /// </summary>
        /// <remarks>
        /// Hit part
        /// </remarks>
        public byte Hit5HitType
        {
            get => (byte)CellsByName["Hit5HitType"].Value;
            set => CellsByName["Hit5HitType"].Value = value;
        }


        // Def="u8 hit6_hitType"
        /// <summary>
        /// Hit 6: Hit Type (u8)
        /// </summary>
        /// <remarks>
        /// Hit part
        /// </remarks>
        public byte Hit6HitType
        {
            get => (byte)CellsByName["Hit6HitType"].Value;
            set => CellsByName["Hit6HitType"].Value = value;
        }


        // Def="u8 hit7_hitType"
        /// <summary>
        /// Hit 7: Hit Type (u8)
        /// </summary>
        /// <remarks>
        /// Hit part
        /// </remarks>
        public byte Hit7HitType
        {
            get => (byte)CellsByName["Hit7HitType"].Value;
            set => CellsByName["Hit7HitType"].Value = value;
        }


        // Def="u8 hit8_hitType"
        /// <summary>
        /// Hit 8: Hit Type (u8)
        /// </summary>
        /// <remarks>
        /// Hit part
        /// </remarks>
        public byte Hit8HitType
        {
            get => (byte)CellsByName["Hit8HitType"].Value;
            set => CellsByName["Hit8HitType"].Value = value;
        }


        // Def="u8 hit9_hitType"
        /// <summary>
        /// Hit 9: Hit Type (u8)
        /// </summary>
        /// <remarks>
        /// Hit part
        /// </remarks>
        public byte Hit9HitType
        {
            get => (byte)CellsByName["Hit9HitType"].Value;
            set => CellsByName["Hit9HitType"].Value = value;
        }


        // Def="u8 hit10_hitType"
        /// <summary>
        /// Hit 10: Hit Type (u8)
        /// </summary>
        /// <remarks>
        /// Hit part
        /// </remarks>
        public byte Hit10HitType
        {
            get => (byte)CellsByName["Hit10HitType"].Value;
            set => CellsByName["Hit10HitType"].Value = value;
        }


        // Def="u8 hit11_hitType"
        /// <summary>
        /// Hit 11: Hit Type (u8)
        /// </summary>
        /// <remarks>
        /// Hit part
        /// </remarks>
        public byte Hit11HitType
        {
            get => (byte)CellsByName["Hit11HitType"].Value;
            set => CellsByName["Hit11HitType"].Value = value;
        }


        // Def="u8 hit12_hitType"
        /// <summary>
        /// Hit 12: Hit Type (u8)
        /// </summary>
        /// <remarks>
        /// Hit part
        /// </remarks>
        public byte Hit12HitType
        {
            get => (byte)CellsByName["Hit12HitType"].Value;
            set => CellsByName["Hit12HitType"].Value = value;
        }


        // Def="u8 hit13_hitType"
        /// <summary>
        /// Hit 13: Hit Type (u8)
        /// </summary>
        /// <remarks>
        /// Hit part
        /// </remarks>
        public byte Hit13HitType
        {
            get => (byte)CellsByName["Hit13HitType"].Value;
            set => CellsByName["Hit13HitType"].Value = value;
        }


        // Def="u8 hit14_hitType"
        /// <summary>
        /// Hit 14: Hit Type (u8)
        /// </summary>
        /// <remarks>
        /// Hit part
        /// </remarks>
        public byte Hit14HitType
        {
            get => (byte)CellsByName["Hit14HitType"].Value;
            set => CellsByName["Hit14HitType"].Value = value;
        }


        // Def="u8 hit15_hitType"
        /// <summary>
        /// Hit 15: Hit Type (u8)
        /// </summary>
        /// <remarks>
        /// Hit part
        /// </remarks>
        public byte Hit15HitType
        {
            get => (byte)CellsByName["Hit15HitType"].Value;
            set => CellsByName["Hit15HitType"].Value = value;
        }


        // Def="u8 hti4_Priority"
        /// <summary>
        /// Hit 4: Priority (u8)
        /// </summary>
        /// <remarks>
        /// priority. If there are two or more hits at the same time, the one with the higher priority will be adopted.
        /// </remarks>
        public byte Hit4Priority
        {
            get => (byte)CellsByName["Hit4Priority"].Value;
            set => CellsByName["Hit4Priority"].Value = value;
        }


        // Def="u8 hti5_Priority"
        /// <summary>
        /// Hit 5: Priority (u8)
        /// </summary>
        /// <remarks>
        /// priority. If there are two or more hits at the same time, the one with the higher priority will be adopted.
        /// </remarks>
        public byte Hit5Priority
        {
            get => (byte)CellsByName["Hit5Priority"].Value;
            set => CellsByName["Hit5Priority"].Value = value;
        }


        // Def="u8 hti6_Priority"
        /// <summary>
        /// Hit 6: Priority (u8)
        /// </summary>
        /// <remarks>
        /// priority. If there are two or more hits at the same time, the one with the higher priority will be adopted.
        /// </remarks>
        public byte Hit6Priority
        {
            get => (byte)CellsByName["Hit6Priority"].Value;
            set => CellsByName["Hit6Priority"].Value = value;
        }


        // Def="u8 hti7_Priority"
        /// <summary>
        /// Hit 7: Priority (u8)
        /// </summary>
        /// <remarks>
        /// priority. If there are two or more hits at the same time, the one with the higher priority will be adopted.
        /// </remarks>
        public byte Hit7Priority
        {
            get => (byte)CellsByName["Hit7Priority"].Value;
            set => CellsByName["Hit7Priority"].Value = value;
        }


        // Def="u8 hti8_Priority"
        /// <summary>
        /// Hit 8: Priority (u8)
        /// </summary>
        /// <remarks>
        /// priority. If there are two or more hits at the same time, the one with the higher priority will be adopted.
        /// </remarks>
        public byte Hit8Priority
        {
            get => (byte)CellsByName["Hit8Priority"].Value;
            set => CellsByName["Hit8Priority"].Value = value;
        }


        // Def="u8 hti9_Priority"
        /// <summary>
        /// Hit 9: Priority (u8)
        /// </summary>
        /// <remarks>
        /// priority. If there are two or more hits at the same time, the one with the higher priority will be adopted.
        /// </remarks>
        public byte Hit9Priority
        {
            get => (byte)CellsByName["Hit9Priority"].Value;
            set => CellsByName["Hit9Priority"].Value = value;
        }


        // Def="u8 hti10_Priority"
        /// <summary>
        /// Hit 10: Priority (u8)
        /// </summary>
        /// <remarks>
        /// priority. If there are two or more hits at the same time, the one with the higher priority will be adopted.
        /// </remarks>
        public byte Hit10Priority
        {
            get => (byte)CellsByName["Hit10Priority"].Value;
            set => CellsByName["Hit10Priority"].Value = value;
        }


        // Def="u8 hti11_Priority"
        /// <summary>
        /// Hit 11: Priority (u8)
        /// </summary>
        /// <remarks>
        /// priority. If there are two or more hits at the same time, the one with the higher priority will be adopted.
        /// </remarks>
        public byte Hit11Priority
        {
            get => (byte)CellsByName["Hit11Priority"].Value;
            set => CellsByName["Hit11Priority"].Value = value;
        }


        // Def="u8 hti12_Priority"
        /// <summary>
        /// Hit 12: Priority (u8)
        /// </summary>
        /// <remarks>
        /// priority. If there are two or more hits at the same time, the one with the higher priority will be adopted.
        /// </remarks>
        public byte Hit12Priority
        {
            get => (byte)CellsByName["Hit12Priority"].Value;
            set => CellsByName["Hit12Priority"].Value = value;
        }


        // Def="u8 hti13_Priority"
        /// <summary>
        /// Hit 13: Priority (u8)
        /// </summary>
        /// <remarks>
        /// priority. If there are two or more hits at the same time, the one with the higher priority will be adopted.
        /// </remarks>
        public byte Hit13Priority
        {
            get => (byte)CellsByName["Hit13Priority"].Value;
            set => CellsByName["Hit13Priority"].Value = value;
        }


        // Def="u8 hti14_Priority"
        /// <summary>
        /// Hit 14: Priority (u8)
        /// </summary>
        /// <remarks>
        /// priority. If there are two or more hits at the same time, the one with the higher priority will be adopted.
        /// </remarks>
        public byte Hit14Priority
        {
            get => (byte)CellsByName["Hit14Priority"].Value;
            set => CellsByName["Hit14Priority"].Value = value;
        }


        // Def="u8 hti15_Priority"
        /// <summary>
        /// Hit 15: Priority (u8)
        /// </summary>
        /// <remarks>
        /// priority. If there are two or more hits at the same time, the one with the higher priority will be adopted.
        /// </remarks>
        public byte Hit15Priority
        {
            get => (byte)CellsByName["Hit15Priority"].Value;
            set => CellsByName["Hit15Priority"].Value = value;
        }


        // Def="u16 defSfxMaterial1"
        /// <summary>
        /// Defence SFX Material [1] (u16)
        /// </summary>
        /// <remarks>
        /// Used for SFX when guarding. 1
        /// </remarks>
        public ushort DefenceSFXMaterial1
        {
            get => (ushort)CellsByName["DefenceSFXMaterial1"].Value;
            set => CellsByName["DefenceSFXMaterial1"].Value = value;
        }


        // Def="u16 defSeMaterial2"
        /// <summary>
        /// Defence SE Material [2] (u16)
        /// </summary>
        /// <remarks>
        /// Used for SE when guarding 2
        /// </remarks>
        public ushort DefenceSEMaterial2
        {
            get => (ushort)CellsByName["DefenceSEMaterial2"].Value;
            set => CellsByName["DefenceSEMaterial2"].Value = value;
        }


        // Def="u16 defSfxMaterial2"
        /// <summary>
        /// Defence SFX Material [2] (u16)
        /// </summary>
        /// <remarks>
        /// Used for SFX when guarding. 2
        /// </remarks>
        public ushort DefenceSFXMaterial2
        {
            get => (ushort)CellsByName["DefenceSFXMaterial2"].Value;
            set => CellsByName["DefenceSFXMaterial2"].Value = value;
        }


        // Def="u16 atkDarkCorrection"
        /// <summary>
        /// Attack Correction: Holy (u16)
        /// </summary>
        /// <remarks>
        /// PC only. Multiply the dark attack power (in the case of a bow, correct the missile)
        /// </remarks>
        public ushort AttackCorrectionHoly
        {
            get => (ushort)CellsByName["AttackCorrectionHoly"].Value;
            set => CellsByName["AttackCorrectionHoly"].Value = value;
        }


        // Def="u16 atkDark"
        /// <summary>
        /// Damage: Holy (u16)
        /// </summary>
        /// <remarks>
        /// NPCs only. Additional damage from dark attacks
        /// </remarks>
        public ushort DamageHoly
        {
            get => (ushort)CellsByName["DamageHoly"].Value;
            set => CellsByName["DamageHoly"].Value = value;
        }



        // Def="u8 isDisableParry:1 = 1"
        /// <summary>
        /// Is Disable Parry (u8)
        /// </summary>
        /// <remarks>
        /// This is a flag to disable the new parry control. A process that determines that the damage on the attacking side has been parried when it comes into contact with a character in the parry state on the defending side.
        /// </remarks>
        public byte IsDisableParry
        {
            get => (byte)CellsByName["IsDisableParry"].Value;
            set => CellsByName["IsDisableParry"].Value = value;
        }


        // Def="u8 isDisableBothHandsAtkBonus:1"
        /// <summary>
        /// Is Disable 2H ATK Bonus (u8)
        /// </summary>
        /// <remarks>
        /// Avoid using the 1.5x growth status adaptation with both hands
        /// </remarks>
        public byte IsDisable2HATKBonus
        {
            get => (byte)CellsByName["IsDisable2HATKBonus"].Value;
            set => CellsByName["IsDisable2HATKBonus"].Value = value;
        }


        // Def="u8 isInvalidatedByNoDamageInAir:1"
        /// <summary>
        /// Is Invalidated by No Damage in Air (u8)
        /// </summary>
        /// <remarks>
        /// If "Do you want to penetrate invincibility" is ◯, this setting will be ignored.
        /// </remarks>
        public byte IsInvalidatedByNoDamageInAir
        {
            get => (byte)CellsByName["IsInvalidatedByNoDamageInAir"].Value;
            set => CellsByName["IsInvalidatedByNoDamageInAir"].Value = value;
        }



        // Def="s8 dmgLevel_vsPlayer"
        /// <summary>
        /// Damage Level - Vs. Player (s8)
        /// </summary>
        /// <remarks>
        /// Damage level to the player. If it is "0 (default)", it is not used. The meaning of the range other than "0 (default)" is the same as "Damage level".
        /// </remarks>
        public sbyte DamageLevelVsPlayer
        {
            get => (sbyte)CellsByName["DamageLevelVsPlayer"].Value;
            set => CellsByName["DamageLevelVsPlayer"].Value = value;
        }


        // Def="u16 statusAilmentAtkPowerCorrectRate = 100"
        /// <summary>
        /// Status Ailment Correction (u16)
        /// </summary>
        /// <remarks>
        /// Magnification correction is performed for the abnormal state attack power of special effects.
        /// </remarks>
        public ushort StatusAilmentCorrection
        {
            get => (ushort)CellsByName["StatusAilmentCorrection"].Value;
            set => CellsByName["StatusAilmentCorrection"].Value = value;
        }


        // Def="u16 spEffectAtkPowerCorrectRate_byPoint = 100"
        /// <summary>
        /// Attack Correction - By SpEffect Point (u16)
        /// </summary>
        /// <remarks>
        /// Magnification correction is performed for the special effect ~ ~ attack power [point].
        /// </remarks>
        public ushort AttackCorrectionBySpEffectPoint
        {
            get => (ushort)CellsByName["AttackCorrectionBySpEffectPoint"].Value;
            set => CellsByName["AttackCorrectionBySpEffectPoint"].Value = value;
        }


        // Def="u16 spEffectAtkPowerCorrectRate_byRate = 100"
        /// <summary>
        /// Attack Correction - By SpEffect Power (u16)
        /// </summary>
        /// <remarks>
        /// Magnification is corrected for the special effect's attack power multiplier.
        /// </remarks>
        public ushort AttackCorrectionBySpEffectPower
        {
            get => (ushort)CellsByName["AttackCorrectionBySpEffectPower"].Value;
            set => CellsByName["AttackCorrectionBySpEffectPower"].Value = value;
        }


        // Def="u16 spEffectAtkPowerCorrectRate_byDmg = 100"
        /// <summary>
        /// Attack Correction - By SpEffect Damage (u16)
        /// </summary>
        /// <remarks>
        /// Attack side of special effect: ~ ~ Performs magnification correction for damage multiplier.
        /// </remarks>
        public ushort AttackCorrectionBySpEffectDamage
        {
            get => (ushort)CellsByName["AttackCorrectionBySpEffectDamage"].Value;
            set => CellsByName["AttackCorrectionBySpEffectDamage"].Value = value;
        }


        // Def="u8 atkBehaviorId_2"
        /// <summary>
        /// Attack Behavior ID [2] (u8)
        /// </summary>
        /// <remarks>
        /// Behavior identification value: Plays damage motion only at specific times
        /// </remarks>
        public byte AttackBehaviorID2
        {
            get => (byte)CellsByName["AttackBehaviorID2"].Value;
            set => CellsByName["AttackBehaviorID2"].Value = value;
        }


        // Def="u8 throwDamageAttribute"
        /// <summary>
        /// Throw Damage Attribute (u8)
        /// </summary>
        /// <remarks>
        /// Attribute of throw damage of attack judgment. Corresponding special effects will be applied. It works only when the attack ATK_PATAM_THROWFLAG_TYPE is "2: Throw".
        /// </remarks>
        public byte ThrowDamageAttribute
        {
            get => (byte)CellsByName["ThrowDamageAttribute"].Value;
            set => CellsByName["ThrowDamageAttribute"].Value = value;
        }


        // Def="u16 statusAilmentAtkPowerCorrectRate_byPoint = 100"
        /// <summary>
        /// Status Ailment Correction - By Point (u16)
        /// </summary>
        /// <remarks>
        /// Magnification correction is performed for the special effect "Whether to apply the abnormal state attack power magnification correction".
        /// </remarks>
        public ushort StatusAilmentCorrectionByPoint
        {
            get => (ushort)CellsByName["StatusAilmentCorrectionByPoint"].Value;
            set => CellsByName["StatusAilmentCorrectionByPoint"].Value = value;
        }


        // Def="s32 overwriteAttackElementCorrectId = -1"
        /// <summary>
        /// Attack Element Correct ID (s32)
        /// </summary>
        /// <remarks>
        /// For overwriting the ID of the parameter that corrects the attack attribute
        /// </remarks>
        public int AttackElementCorrectID
        {
            get => (int)CellsByName["AttackElementCorrectID"].Value;
            set => CellsByName["AttackElementCorrectID"].Value = value;
        }


        // Def="s16 decalBaseId1 = -1"
        /// <summary>
        /// Decal Base ID [1] (s16)
        /// </summary>
        /// <remarks>
        /// Decal identifier 1 (3 digits)
        /// </remarks>
        public short DecalBaseID1
        {
            get => (short)CellsByName["DecalBaseID1"].Value;
            set => CellsByName["DecalBaseID1"].Value = value;
        }


        // Def="s16 decalBaseId2 = -1"
        /// <summary>
        /// Decal Base ID [2] (s16)
        /// </summary>
        /// <remarks>
        /// Decal identifier 2 (3 digits)
        /// </remarks>
        public short DecalBaseID2
        {
            get => (short)CellsByName["DecalBaseID2"].Value;
            set => CellsByName["DecalBaseID2"].Value = value;
        }


        // Def="u16 wepRegainHpScale = 100"
        /// <summary>
        /// Weapon HP Regain Amount Scale (u16)
        /// </summary>
        /// <remarks>
        /// Weapon regain amount correction value
        /// </remarks>
        public ushort WeaponHPRegainAmountScale
        {
            get => (ushort)CellsByName["WeaponHPRegainAmountScale"].Value;
            set => CellsByName["WeaponHPRegainAmountScale"].Value = value;
        }


        // Def="u16 atkRegainHp"
        /// <summary>
        /// Attack HP Regain Amount (u16)
        /// </summary>
        /// <remarks>
        /// Amount of attack regain
        /// </remarks>
        public ushort AttackHPRegainAmount
        {
            get => (ushort)CellsByName["AttackHPRegainAmount"].Value;
            set => CellsByName["AttackHPRegainAmount"].Value = value;
        }


        // Def="f32 regainableTimeScale = 1"
        /// <summary>
        /// HP Regain Time Scale (f32)
        /// </summary>
        /// <remarks>
        /// Regainable time correction factor
        /// </remarks>
        public float HPRegainTimeScale
        {
            get => (float)CellsByName["HPRegainTimeScale"].Value;
            set => CellsByName["HPRegainTimeScale"].Value = value;
        }


        // Def="f32 regainableHpRateScale = 1"
        /// <summary>
        /// HP Regain Rate Scale (f32)
        /// </summary>
        /// <remarks>
        /// Regainable rate correction factor
        /// </remarks>
        public float HPRegainRateScale
        {
            get => (float)CellsByName["HPRegainRateScale"].Value;
            set => CellsByName["HPRegainRateScale"].Value = value;
        }


        // Def="s8 regainableSlotId = -1"
        /// <summary>
        /// Same Attack Judgment ID (s8)
        /// </summary>
        /// <remarks>
        /// Same attack judgment ID
        /// </remarks>
        public sbyte SameAttackJudgmentID
        {
            get => (sbyte)CellsByName["SameAttackJudgmentID"].Value;
            set => CellsByName["SameAttackJudgmentID"].Value = value;
        }


        // Def="u8 spAttributeVariationValue"
        /// <summary>
        /// Special Attribute VFX Variation Offset (u8)
        /// </summary>
        /// <remarks>
        /// Value for giving variation to SFX and SE generated by special attribute in combination with "special attribute" (SEQ16473)
        /// </remarks>
        public byte SpecialAttributeVFXVariationOffset
        {
            get => (byte)CellsByName["SpecialAttributeVFXVariationOffset"].Value;
            set => CellsByName["SpecialAttributeVFXVariationOffset"].Value = value;
        }


        // Def="s16 parryForwardOffset"
        /// <summary>
        /// Parry Forward Offset (s16)
        /// </summary>
        /// <remarks>
        /// Front angle offset of [collapsed side] of parry establishment condition
        /// </remarks>
        public short ParryForwardOffset
        {
            get => (short)CellsByName["ParryForwardOffset"].Value;
            set => CellsByName["ParryForwardOffset"].Value = value;
        }


        // Def="f32 atkSuperArmorCorrection"
        /// <summary>
        /// Attack Correction: Poise (f32)
        /// </summary>
        /// <remarks>
        /// PC only. Correction value to be applied to the [basic value] set for the weapon
        /// </remarks>
        public float AttackCorrectionPoise
        {
            get => (float)CellsByName["AttackCorrectionPoise"].Value;
            set => CellsByName["AttackCorrectionPoise"].Value = value;
        }


        // Def="u8 defSfxMaterialVariationValue"
        /// <summary>
        /// Defence SFX Material Variation Offset (u8)
        /// </summary>
        /// <remarks>
        /// A value to have variations of damage SFX and SE in combination with "defense material 1 or 2" used when guarding. (SEQ16473)
        /// </remarks>
        public byte DefenceSFXMaterialVariationOffset
        {
            get => (byte)CellsByName["DefenceSFXMaterialVariationOffset"].Value;
            set => CellsByName["DefenceSFXMaterialVariationOffset"].Value = value;
        }


    }
}

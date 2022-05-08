
            namespace StronglyTypedParams
            {
                // SP_EFFECT_PARAM_ST
                public class SpEffect : ParamRow
                {
                    public SpEffect() : base()
                    {
                    }
            

            // Def="s32 iconId = -1"
            /// <summary>
            /// Icon ID (s32)
            /// </summary>
            /// <remarks>
            /// Icon ID (When -1, no icon is required)
            /// </remarks>
            public int IconID 
            {
                get => (int)CellsByName["IconID"].Value;
                set => CellsByName["IconID"].Value = (int)value;
            }
            

            // Def="f32 conditionHp = -1"
            /// <summary>
            /// Trigger at HP Below % (f32)
            /// </summary>
            /// <remarks>
            /// Set what percentage of maxHP the remaining HP will be activated
            /// </remarks>
            public float TriggerAtHPBelowPercent 
            {
                get => (float)CellsByName["TriggerAtHPBelowPercent"].Value;
                set => CellsByName["TriggerAtHPBelowPercent"].Value = (float)value;
            }
            

            // Def="f32 effectEndurance"
            /// <summary>
            /// Duration (f32)
            /// </summary>
            /// <remarks>
            /// Change duration / -1 for permanent / 0 for one moment only
            /// </remarks>
            public float Duration 
            {
                get => (float)CellsByName["Duration"].Value;
                set => CellsByName["Duration"].Value = (float)value;
            }
            

            // Def="f32 motionInterval"
            /// <summary>
            /// Trigger Interval (f32)
            /// </summary>
            /// <remarks>
            /// Set how many seconds it occurs
            /// </remarks>
            public float TriggerInterval 
            {
                get => (float)CellsByName["TriggerInterval"].Value;
                set => CellsByName["TriggerInterval"].Value = (float)value;
            }
            

            // Def="f32 maxHpRate = 1"
            /// <summary>
            /// Max HP % (f32)
            /// </summary>
            /// <remarks>
            /// Correct the maximum HP
            /// </remarks>
            public float MaxHPPercent 
            {
                get => (float)CellsByName["MaxHPPercent"].Value;
                set => CellsByName["MaxHPPercent"].Value = (float)value;
            }
            

            // Def="f32 maxMpRate = 1"
            /// <summary>
            /// Max FP % (f32)
            /// </summary>
            /// <remarks>
            /// Correct the maximum MP
            /// </remarks>
            public float MaxFPPercent 
            {
                get => (float)CellsByName["MaxFPPercent"].Value;
                set => CellsByName["MaxFPPercent"].Value = (float)value;
            }
            

            // Def="f32 maxStaminaRate = 1"
            /// <summary>
            /// Max Stamina % (f32)
            /// </summary>
            /// <remarks>
            /// Correct the maximum SP
            /// </remarks>
            public float MaxStaminaPercent 
            {
                get => (float)CellsByName["MaxStaminaPercent"].Value;
                set => CellsByName["MaxStaminaPercent"].Value = (float)value;
            }
            

            // Def="f32 slashDamageCutRate = 1"
            /// <summary>
            /// Absorption %: Slash (f32)
            /// </summary>
            /// <remarks>
            /// Slash damage ratio: Correct the calculated damage by XX times. 1 is normal.
            /// </remarks>
            public float AbsorptionPercentSlash 
            {
                get => (float)CellsByName["AbsorptionPercentSlash"].Value;
                set => CellsByName["AbsorptionPercentSlash"].Value = (float)value;
            }
            

            // Def="f32 blowDamageCutRate = 1"
            /// <summary>
            /// Absorption %: Strike (f32)
            /// </summary>
            /// <remarks>
            /// Batter damage ratio: The calculated damage is corrected by XX times. 1 is normal.
            /// </remarks>
            public float AbsorptionPercentStrike 
            {
                get => (float)CellsByName["AbsorptionPercentStrike"].Value;
                set => CellsByName["AbsorptionPercentStrike"].Value = (float)value;
            }
            

            // Def="f32 thrustDamageCutRate = 1"
            /// <summary>
            /// Absorption %: Thrust (f32)
            /// </summary>
            /// <remarks>
            /// Puncture damage ratio: Correct the calculated damage by XX times. 1 is normal.
            /// </remarks>
            public float AbsorptionPercentThrust 
            {
                get => (float)CellsByName["AbsorptionPercentThrust"].Value;
                set => CellsByName["AbsorptionPercentThrust"].Value = (float)value;
            }
            

            // Def="f32 neutralDamageCutRate = 1"
            /// <summary>
            /// Absorption %: Standard (f32)
            /// </summary>
            /// <remarks>
            /// Non-attribute damage ratio: Correct the calculated damage by XX times. 1 is normal.
            /// </remarks>
            public float AbsorptionPercentStandard 
            {
                get => (float)CellsByName["AbsorptionPercentStandard"].Value;
                set => CellsByName["AbsorptionPercentStandard"].Value = (float)value;
            }
            

            // Def="f32 magicDamageCutRate = 1"
            /// <summary>
            /// Absorption %: Magic (f32)
            /// </summary>
            /// <remarks>
            /// Magic damage multiplier: The calculated damage is corrected by XX times. 1 is normal.
            /// </remarks>
            public float AbsorptionPercentMagic 
            {
                get => (float)CellsByName["AbsorptionPercentMagic"].Value;
                set => CellsByName["AbsorptionPercentMagic"].Value = (float)value;
            }
            

            // Def="f32 fireDamageCutRate = 1"
            /// <summary>
            /// Absorption %: Fire (f32)
            /// </summary>
            /// <remarks>
            /// Flame damage ratio: Correct the calculated damage by XX times. 1 is normal.
            /// </remarks>
            public float AbsorptionPercentFire 
            {
                get => (float)CellsByName["AbsorptionPercentFire"].Value;
                set => CellsByName["AbsorptionPercentFire"].Value = (float)value;
            }
            

            // Def="f32 thunderDamageCutRate = 1"
            /// <summary>
            /// Absorption %: Lightning (f32)
            /// </summary>
            /// <remarks>
            /// Electric shock damage ratio: Correct the calculated damage by XX times. 1 is normal.
            /// </remarks>
            public float AbsorptionPercentLightning 
            {
                get => (float)CellsByName["AbsorptionPercentLightning"].Value;
                set => CellsByName["AbsorptionPercentLightning"].Value = (float)value;
            }
            

            // Def="f32 physicsAttackRate = 1"
            /// <summary>
            /// Attack %: Physical (f32)
            /// </summary>
            /// <remarks>
            /// Physical damage ratio: Correct the calculated damage by XX times. 1 is normal.
            /// </remarks>
            public float AttackPercentPhysical 
            {
                get => (float)CellsByName["AttackPercentPhysical"].Value;
                set => CellsByName["AttackPercentPhysical"].Value = (float)value;
            }
            

            // Def="f32 magicAttackRate = 1"
            /// <summary>
            /// Attack %: Magic (f32)
            /// </summary>
            /// <remarks>
            /// Magic damage multiplier: The calculated damage is corrected by XX times. 1 is normal.
            /// </remarks>
            public float AttackPercentMagic 
            {
                get => (float)CellsByName["AttackPercentMagic"].Value;
                set => CellsByName["AttackPercentMagic"].Value = (float)value;
            }
            

            // Def="f32 fireAttackRate = 1"
            /// <summary>
            /// Attack %: Fire (f32)
            /// </summary>
            /// <remarks>
            /// Flame damage ratio: Correct the calculated damage by XX times. 1 is normal.
            /// </remarks>
            public float AttackPercentFire 
            {
                get => (float)CellsByName["AttackPercentFire"].Value;
                set => CellsByName["AttackPercentFire"].Value = (float)value;
            }
            

            // Def="f32 thunderAttackRate = 1"
            /// <summary>
            /// Attack %: Lightning (f32)
            /// </summary>
            /// <remarks>
            /// Electric shock damage ratio: Correct the calculated damage by XX times. 1 is normal.
            /// </remarks>
            public float AttackPercentLightning 
            {
                get => (float)CellsByName["AttackPercentLightning"].Value;
                set => CellsByName["AttackPercentLightning"].Value = (float)value;
            }
            

            // Def="f32 physicsAttackPowerRate = 1"
            /// <summary>
            /// Power %: Physical (f32)
            /// </summary>
            /// <remarks>
            /// Multiply the physical attack power by the set value
            /// </remarks>
            public float PowerPercentPhysical 
            {
                get => (float)CellsByName["PowerPercentPhysical"].Value;
                set => CellsByName["PowerPercentPhysical"].Value = (float)value;
            }
            

            // Def="f32 magicAttackPowerRate = 1"
            /// <summary>
            /// Power %: Magic (f32)
            /// </summary>
            /// <remarks>
            /// Multiply the magic attack power by the set value
            /// </remarks>
            public float PowerPercentMagic 
            {
                get => (float)CellsByName["PowerPercentMagic"].Value;
                set => CellsByName["PowerPercentMagic"].Value = (float)value;
            }
            

            // Def="f32 fireAttackPowerRate = 1"
            /// <summary>
            /// Power %: Fire (f32)
            /// </summary>
            /// <remarks>
            /// Multiply the fire attack power by the set value
            /// </remarks>
            public float PowerPercentFire 
            {
                get => (float)CellsByName["PowerPercentFire"].Value;
                set => CellsByName["PowerPercentFire"].Value = (float)value;
            }
            

            // Def="f32 thunderAttackPowerRate = 1"
            /// <summary>
            /// Power %: Lightning (f32)
            /// </summary>
            /// <remarks>
            /// Multiply the electric shock attack power by the set value
            /// </remarks>
            public float PowerPercentLightning 
            {
                get => (float)CellsByName["PowerPercentLightning"].Value;
                set => CellsByName["PowerPercentLightning"].Value = (float)value;
            }
            

            // Def="s32 physicsAttackPower"
            /// <summary>
            /// Damage +: Physical (s32)
            /// </summary>
            /// <remarks>
            /// Add or subtract the value set for physical attack power
            /// </remarks>
            public int DamagePhysical 
            {
                get => (int)CellsByName["DamagePhysical"].Value;
                set => CellsByName["DamagePhysical"].Value = (int)value;
            }
            

            // Def="s32 magicAttackPower"
            /// <summary>
            /// Damage +: Magic (s32)
            /// </summary>
            /// <remarks>
            /// Add or subtract the value set for the magic attack power
            /// </remarks>
            public int DamageMagic 
            {
                get => (int)CellsByName["DamageMagic"].Value;
                set => CellsByName["DamageMagic"].Value = (int)value;
            }
            

            // Def="s32 fireAttackPower"
            /// <summary>
            /// Damage +: Fire (s32)
            /// </summary>
            /// <remarks>
            /// Add or subtract the value set for the flame attack power
            /// </remarks>
            public int DamageFire 
            {
                get => (int)CellsByName["DamageFire"].Value;
                set => CellsByName["DamageFire"].Value = (int)value;
            }
            

            // Def="s32 thunderAttackPower"
            /// <summary>
            /// Damage +: Lighting (s32)
            /// </summary>
            /// <remarks>
            /// Add or subtract the value set for the electric shock attack power
            /// </remarks>
            public int DamageLighting 
            {
                get => (int)CellsByName["DamageLighting"].Value;
                set => CellsByName["DamageLighting"].Value = (int)value;
            }
            

            // Def="f32 physicsDiffenceRate = 1"
            /// <summary>
            /// Defence %: Physical (f32)
            /// </summary>
            /// <remarks>
            /// Multiply the set value for physical defense
            /// </remarks>
            public float DefencePercentPhysical 
            {
                get => (float)CellsByName["DefencePercentPhysical"].Value;
                set => CellsByName["DefencePercentPhysical"].Value = (float)value;
            }
            

            // Def="f32 magicDiffenceRate = 1"
            /// <summary>
            /// Defence %: Magic (f32)
            /// </summary>
            /// <remarks>
            /// Multiply the value set for magic defense
            /// </remarks>
            public float DefencePercentMagic 
            {
                get => (float)CellsByName["DefencePercentMagic"].Value;
                set => CellsByName["DefencePercentMagic"].Value = (float)value;
            }
            

            // Def="f32 fireDiffenceRate = 1"
            /// <summary>
            /// Defence %: Fire (f32)
            /// </summary>
            /// <remarks>
            /// Multiply the fire defense by the set value
            /// </remarks>
            public float DefencePercentFire 
            {
                get => (float)CellsByName["DefencePercentFire"].Value;
                set => CellsByName["DefencePercentFire"].Value = (float)value;
            }
            

            // Def="f32 thunderDiffenceRate = 1"
            /// <summary>
            /// Defence %: Lightning (f32)
            /// </summary>
            /// <remarks>
            /// Multiply the value set for the electric shock defense
            /// </remarks>
            public float DefencePercentLightning 
            {
                get => (float)CellsByName["DefencePercentLightning"].Value;
                set => CellsByName["DefencePercentLightning"].Value = (float)value;
            }
            

            // Def="s32 physicsDiffence"
            /// <summary>
            /// Defence +: Physical (s32)
            /// </summary>
            /// <remarks>
            /// Add or subtract the value set for physical defense
            /// </remarks>
            public int DefencePhysical 
            {
                get => (int)CellsByName["DefencePhysical"].Value;
                set => CellsByName["DefencePhysical"].Value = (int)value;
            }
            

            // Def="s32 magicDiffence"
            /// <summary>
            /// Defence +: Magic (s32)
            /// </summary>
            /// <remarks>
            /// Add or subtract the value set for magic defense
            /// </remarks>
            public int DefenceMagic 
            {
                get => (int)CellsByName["DefenceMagic"].Value;
                set => CellsByName["DefenceMagic"].Value = (int)value;
            }
            

            // Def="s32 fireDiffence"
            /// <summary>
            /// Defence +: Fire (s32)
            /// </summary>
            /// <remarks>
            /// Add or subtract the value set for the fire defense
            /// </remarks>
            public int DefenceFire 
            {
                get => (int)CellsByName["DefenceFire"].Value;
                set => CellsByName["DefenceFire"].Value = (int)value;
            }
            

            // Def="s32 thunderDiffence"
            /// <summary>
            /// Defence +: Lightning (s32)
            /// </summary>
            /// <remarks>
            /// Add or subtract the value set for the electric shock defense
            /// </remarks>
            public int DefenceLightning 
            {
                get => (int)CellsByName["DefenceLightning"].Value;
                set => CellsByName["DefenceLightning"].Value = (int)value;
            }
            

            // Def="f32 NoGuardDamageRate = 1"
            /// <summary>
            /// No Guard Damage % (f32)
            /// </summary>
            /// <remarks>
            /// Replace the damage ratio at the time of the gap with the set value (set on the damage side)
            /// </remarks>
            public float NoGuardDamagePercent 
            {
                get => (float)CellsByName["NoGuardDamagePercent"].Value;
                set => CellsByName["NoGuardDamagePercent"].Value = (float)value;
            }
            

            // Def="f32 vitalSpotChangeRate = -1"
            /// <summary>
            /// Vital Spot Change % (f32)
            /// </summary>
            /// <remarks>
            /// Replaces the damage calculation of the sweet spot with the specified value (key point damage correction) -Invalid at 1.0
            /// </remarks>
            public float VitalSpotChangePercent 
            {
                get => (float)CellsByName["VitalSpotChangePercent"].Value;
                set => CellsByName["VitalSpotChangePercent"].Value = (float)value;
            }
            

            // Def="f32 normalSpotChangeRate = -1"
            /// <summary>
            /// Normal Hit Change % (f32)
            /// </summary>
            /// <remarks>
            /// Replaces normal hit damage calculation with the specified number -Invalid at 1.0
            /// </remarks>
            public float NormalHitChangePercent 
            {
                get => (float)CellsByName["NormalHitChangePercent"].Value;
                set => CellsByName["NormalHitChangePercent"].Value = (float)value;
            }
            

            // Def="f32 lookAtTargetPosOffset"
            /// <summary>
            /// Look-At Target Position Offset (f32)
            /// </summary>
            /// <remarks>
            /// Offset the target position when the enemy looks at. Set to crouch or mount on the side to be seen
            /// </remarks>
            public float LookAtTargetPositionOffset 
            {
                get => (float)CellsByName["LookAtTargetPositionOffset"].Value;
                set => CellsByName["LookAtTargetPositionOffset"].Value = (float)value;
            }
            

            // Def="s32 behaviorId = -1"
            /// <summary>
            /// Behavior ID (s32)
            /// </summary>
            /// <remarks>
            /// Specified -1 when dealing damage using action ID from special effects
///NPC Behavior - Requires State Info 142
///Player Behavior - Requires State Info 275
///Bullet Behavior - Requires State Info 33
            /// </remarks>
            public int BehaviorID 
            {
                get => (int)CellsByName["BehaviorID"].Value;
                set => CellsByName["BehaviorID"].Value = (int)value;
            }
            

            // Def="f32 changeHpRate"
            /// <summary>
            /// Current HP % (f32)
            /// </summary>
            /// <remarks>
            /// Set what percentage of the maximum HP to subtract (or add) with one activation
            /// </remarks>
            public float CurrentHPPercent 
            {
                get => (float)CellsByName["CurrentHPPercent"].Value;
                set => CellsByName["CurrentHPPercent"].Value = (float)value;
            }
            

            // Def="s32 changeHpPoint"
            /// <summary>
            /// Current HP + (s32)
            /// </summary>
            /// <remarks>
            /// Set how many points to subtract (or add) with one activation
            /// </remarks>
            public int CurrentHP 
            {
                get => (int)CellsByName["CurrentHP"].Value;
                set => CellsByName["CurrentHP"].Value = (int)value;
            }
            

            // Def="f32 changeMpRate"
            /// <summary>
            /// Current FP % (f32)
            /// </summary>
            /// <remarks>
            /// Set what percentage of the maximum MP to subtract (or add) with one activation
            /// </remarks>
            public float CurrentFPPercent 
            {
                get => (float)CellsByName["CurrentFPPercent"].Value;
                set => CellsByName["CurrentFPPercent"].Value = (float)value;
            }
            

            // Def="s32 changeMpPoint"
            /// <summary>
            /// Current FP + (s32)
            /// </summary>
            /// <remarks>
            /// Set how many points to subtract (or add) with one activation
            /// </remarks>
            public int CurrentFP 
            {
                get => (int)CellsByName["CurrentFP"].Value;
                set => CellsByName["CurrentFP"].Value = (int)value;
            }
            

            // Def="s32 mpRecoverChangeSpeed"
            /// <summary>
            /// FP Recovery Speed (s32)
            /// </summary>
            /// <remarks>
            /// Change the recovery speed. Add or subtract to the standard recovery speed and initial recovery speed of the recovery formula.
            /// </remarks>
            public int FPRecoverySpeed 
            {
                get => (int)CellsByName["FPRecoverySpeed"].Value;
                set => CellsByName["FPRecoverySpeed"].Value = (int)value;
            }
            

            // Def="f32 changeStaminaRate"
            /// <summary>
            /// Current Stamina % (f32)
            /// </summary>
            /// <remarks>
            /// Set what percentage of the maximum stamina to subtract (or add) with one activation
            /// </remarks>
            public float CurrentStaminaPercent 
            {
                get => (float)CellsByName["CurrentStaminaPercent"].Value;
                set => CellsByName["CurrentStaminaPercent"].Value = (float)value;
            }
            

            // Def="s32 changeStaminaPoint"
            /// <summary>
            /// Current Stamina + (s32)
            /// </summary>
            /// <remarks>
            /// Set how many points to subtract (or add) with one activation
            /// </remarks>
            public int CurrentStamina 
            {
                get => (int)CellsByName["CurrentStamina"].Value;
                set => CellsByName["CurrentStamina"].Value = (int)value;
            }
            

            // Def="s32 staminaRecoverChangeSpeed"
            /// <summary>
            /// Stamina Recovery Speed (s32)
            /// </summary>
            /// <remarks>
            /// Change the recovery speed. Add or subtract to the standard recovery speed and initial recovery speed of the recovery formula.
            /// </remarks>
            public int StaminaRecoverySpeed 
            {
                get => (int)CellsByName["StaminaRecoverySpeed"].Value;
                set => CellsByName["StaminaRecoverySpeed"].Value = (int)value;
            }
            

            // Def="f32 magicEffectTimeChange"
            /// <summary>
            /// Magic Effect Time Change (f32)
            /// </summary>
            /// <remarks>
            /// Add / subtract the time set for the effect duration only for magic that has the effect duration set to 0.1 seconds or more.
            /// </remarks>
            public float MagicEffectTimeChange 
            {
                get => (float)CellsByName["MagicEffectTimeChange"].Value;
                set => CellsByName["MagicEffectTimeChange"].Value = (float)value;
            }
            

            // Def="s32 insideDurability"
            /// <summary>
            /// Current Durability + (s32)
            /// </summary>
            /// <remarks>
            /// Add or subtract the numerical value to the internal wear degree
            /// </remarks>
            public int CurrentDurability 
            {
                get => (int)CellsByName["CurrentDurability"].Value;
                set => CellsByName["CurrentDurability"].Value = (int)value;
            }
            

            // Def="s32 maxDurability"
            /// <summary>
            /// Max Durability (s32)
            /// </summary>
            /// <remarks>
            /// Add the set value to the maximum value of the internal wear degree of durability.
            /// </remarks>
            public int MaxDurability 
            {
                get => (int)CellsByName["MaxDurability"].Value;
                set => CellsByName["MaxDurability"].Value = (int)value;
            }
            

            // Def="f32 staminaAttackRate = 1"
            /// <summary>
            /// Attack %: Stamina (f32)
            /// </summary>
            /// <remarks>
            /// Multiply the stamina attack power by a factor (1.0 1 times 0.5 half)
            /// </remarks>
            public float AttackPercentStamina 
            {
                get => (float)CellsByName["AttackPercentStamina"].Value;
                set => CellsByName["AttackPercentStamina"].Value = (float)value;
            }
            

            // Def="s32 poizonAttackPower"
            /// <summary>
            /// Aux Inflict +: Poison (s32)
            /// </summary>
            /// <remarks>
            /// A value to be added to the target's [poison resistance value] when it hits
///Requires State Info 2
            /// </remarks>
            public int AuxInflictPoison 
            {
                get => (int)CellsByName["AuxInflictPoison"].Value;
                set => CellsByName["AuxInflictPoison"].Value = (int)value;
            }
            

            // Def="s32 diseaseAttackPower"
            /// <summary>
            /// Aux Inflict +: Scarlet Rot (s32)
            /// </summary>
            /// <remarks>
            /// Numerical value to be added to the target [Plague resistance value] when hit
///Requires State Info 5
            /// </remarks>
            public int AuxInflictScarletRot 
            {
                get => (int)CellsByName["AuxInflictScarletRot"].Value;
                set => CellsByName["AuxInflictScarletRot"].Value = (int)value;
            }
            

            // Def="s32 bloodAttackPower"
            /// <summary>
            /// Aux Inflict +: Hemorrhage (s32)
            /// </summary>
            /// <remarks>
            /// A value to be added to the target's [bleeding resistance value] when it hits
///Requires State Info 6
            /// </remarks>
            public int AuxInflictHemorrhage 
            {
                get => (int)CellsByName["AuxInflictHemorrhage"].Value;
                set => CellsByName["AuxInflictHemorrhage"].Value = (int)value;
            }
            

            // Def="s32 curseAttackPower"
            /// <summary>
            /// Aux Inflict +: Blight (s32)
            /// </summary>
            /// <remarks>
            /// A number to be added to the target [curse resistance value] when hit
///Requires State Info 116
            /// </remarks>
            public int AuxInflictBlight 
            {
                get => (int)CellsByName["AuxInflictBlight"].Value;
                set => CellsByName["AuxInflictBlight"].Value = (int)value;
            }
            

            // Def="f32 fallDamageRate"
            /// <summary>
            /// Fall Damage % (f32)
            /// </summary>
            /// <remarks>
            /// Multiply the damage calculation when falling
            /// </remarks>
            public float FallDamagePercent 
            {
                get => (float)CellsByName["FallDamagePercent"].Value;
                set => CellsByName["FallDamagePercent"].Value = (float)value;
            }
            

            // Def="f32 soulRate"
            /// <summary>
            /// Rune Gain % (f32)
            /// </summary>
            /// <remarks>
            /// The amount of soul acquired when defeating an enemy is added by the specified multiple.
///Requires State Info 76
            /// </remarks>
            public float RuneGainPercent 
            {
                get => (float)CellsByName["RuneGainPercent"].Value;
                set => CellsByName["RuneGainPercent"].Value = (float)value;
            }
            

            // Def="f32 equipWeightChangeRate"
            /// <summary>
            /// Max Equip Load % (f32)
            /// </summary>
            /// <remarks>
            /// Multiply the maximum equipment weight by the set magnification
            /// </remarks>
            public float MaxEquipLoadPercent 
            {
                get => (float)CellsByName["MaxEquipLoadPercent"].Value;
                set => CellsByName["MaxEquipLoadPercent"].Value = (float)value;
            }
            

            // Def="f32 allItemWeightChangeRate"
            /// <summary>
            /// Item Weight % (f32)
            /// </summary>
            /// <remarks>
            /// Multiply the maximum weight you have by the set magnification
            /// </remarks>
            public float ItemWeightPercent 
            {
                get => (float)CellsByName["ItemWeightPercent"].Value;
                set => CellsByName["ItemWeightPercent"].Value = (float)value;
            }
            

            // Def="s32 soul"
            /// <summary>
            /// Rune Gain + (s32)
            /// </summary>
            /// <remarks>
            /// Add the set value to the possessed soul
            /// </remarks>
            public int RuneGain 
            {
                get => (int)CellsByName["RuneGain"].Value;
                set => CellsByName["RuneGain"].Value = (int)value;
            }
            

            // Def="s32 animIdOffset = -1"
            /// <summary>
            /// Anim ID Offset (s32)
            /// </summary>
            /// <remarks>
            /// Anime ID offset (invalid-1)
            /// </remarks>
            public int AnimIDOffset 
            {
                get => (int)CellsByName["AnimIDOffset"].Value;
                set => CellsByName["AnimIDOffset"].Value = (int)value;
            }
            

            // Def="f32 haveSoulRate = 1"
            /// <summary>
            /// Rune Possession Amount % (f32)
            /// </summary>
            /// <remarks>
            /// For enemy lap effect. It is applied when the soul goes out from the set character.
            /// </remarks>
            public float RunePossessionAmountPercent 
            {
                get => (float)CellsByName["RunePossessionAmountPercent"].Value;
                set => CellsByName["RunePossessionAmountPercent"].Value = (float)value;
            }
            

            // Def="f32 targetPriority"
            /// <summary>
            /// Target Priority (f32)
            /// </summary>
            /// <remarks>
            /// During multiplayer, the enemy will give priority to being targeted as a target. Addition of priority. 0 is the default. It will be often targeted with a positive value. Minus is up to -1.
            /// </remarks>
            public float TargetPriority 
            {
                get => (float)CellsByName["TargetPriority"].Value;
                set => CellsByName["TargetPriority"].Value = (float)value;
            }
            

            // Def="f32 sightSearchEnemyRate = 1"
            /// <summary>
            /// Enemy Vision Adjustment (f32)
            /// </summary>
            /// <remarks>
            /// Correct the ease of finding by a magnification
            /// </remarks>
            public float EnemyVisionAdjustment 
            {
                get => (float)CellsByName["EnemyVisionAdjustment"].Value;
                set => CellsByName["EnemyVisionAdjustment"].Value = (float)value;
            }
            

            // Def="f32 hearingSearchEnemyRate = 1"
            /// <summary>
            /// Enemy Listen Adjustment (f32)
            /// </summary>
            /// <remarks>
            /// Correct the loudness of the AI sound emitted by the magnification
            /// </remarks>
            public float EnemyListenAdjustment 
            {
                get => (float)CellsByName["EnemyListenAdjustment"].Value;
                set => CellsByName["EnemyListenAdjustment"].Value = (float)value;
            }
            

            // Def="f32 grabityRate = 1"
            /// <summary>
            /// Gravity % (f32)
            /// </summary>
            /// <remarks>
            /// Gravity rate
            /// </remarks>
            public float GravityPercent 
            {
                get => (float)CellsByName["GravityPercent"].Value;
                set => CellsByName["GravityPercent"].Value = (float)value;
            }
            

            // Def="f32 registPoizonChangeRate = 1"
            /// <summary>
            /// Aux Resist %: Poison (f32)
            /// </summary>
            /// <remarks>
            /// Multiply the poison resistance value by the set multiplier
            /// </remarks>
            public float AuxResistPercentPoison 
            {
                get => (float)CellsByName["AuxResistPercentPoison"].Value;
                set => CellsByName["AuxResistPercentPoison"].Value = (float)value;
            }
            

            // Def="f32 registDiseaseChangeRate = 1"
            /// <summary>
            /// Aux Resist %: Scarlet Rot (f32)
            /// </summary>
            /// <remarks>
            /// Multiply the plague resistance value by the set magnification
            /// </remarks>
            public float AuxResistPercentScarletRot 
            {
                get => (float)CellsByName["AuxResistPercentScarletRot"].Value;
                set => CellsByName["AuxResistPercentScarletRot"].Value = (float)value;
            }
            

            // Def="f32 registBloodChangeRate = 1"
            /// <summary>
            /// Aux Resist %: Hemorrhage (f32)
            /// </summary>
            /// <remarks>
            /// Multiply the bleeding resistance value by the set magnification
            /// </remarks>
            public float AuxResistPercentHemorrhage 
            {
                get => (float)CellsByName["AuxResistPercentHemorrhage"].Value;
                set => CellsByName["AuxResistPercentHemorrhage"].Value = (float)value;
            }
            

            // Def="f32 registCurseChangeRate = 1"
            /// <summary>
            /// Aux Resist %: Blight (f32)
            /// </summary>
            /// <remarks>
            /// Multiply the spell resistance value by the set multiplier
            /// </remarks>
            public float AuxResistPercentBlight 
            {
                get => (float)CellsByName["AuxResistPercentBlight"].Value;
                set => CellsByName["AuxResistPercentBlight"].Value = (float)value;
            }
            

            // Def="f32 soulStealRate"
            /// <summary>
            /// Soul Steal % (f32)
            /// </summary>
            /// <remarks>
            /// Defense against HP robbed by NPCs in Soul Steel
            /// </remarks>
            public float SoulStealPercent 
            {
                get => (float)CellsByName["SoulStealPercent"].Value;
                set => CellsByName["SoulStealPercent"].Value = (float)value;
            }
            

            // Def="f32 lifeReductionRate"
            /// <summary>
            /// Effect Duration % (f32)
            /// </summary>
            /// <remarks>
            /// 
            /// </remarks>
            public float EffectDurationPercent 
            {
                get => (float)CellsByName["EffectDurationPercent"].Value;
                set => CellsByName["EffectDurationPercent"].Value = (float)value;
            }
            

            // Def="f32 hpRecoverRate"
            /// <summary>
            /// HP Recovery Effectiveness % (f32)
            /// </summary>
            /// <remarks>
            /// It doesn't work when HP decreases.
            /// </remarks>
            public float HPRecoveryEffectivenessPercent 
            {
                get => (float)CellsByName["HPRecoveryEffectivenessPercent"].Value;
                set => CellsByName["HPRecoveryEffectivenessPercent"].Value = (float)value;
            }
            

            // Def="s32 replaceSpEffectId = -1"
            /// <summary>
            /// Chain SpEffect ID (s32)
            /// </summary>
            /// <remarks>
            /// Special effect ID added at the end of life (-1 is ignored)
            /// </remarks>
            public int ChainSpEffectID 
            {
                get => (int)CellsByName["ChainSpEffectID"].Value;
                set => CellsByName["ChainSpEffectID"].Value = (int)value;
            }
            

            // Def="s32 cycleOccurrenceSpEffectId = -1"
            /// <summary>
            /// Cycle SpEffect ID (s32)
            /// </summary>
            /// <remarks>
            /// Special effect ID that occurs in each activation cycle (-1 is ignored)
            /// </remarks>
            public int CycleSpEffectID 
            {
                get => (int)CellsByName["CycleSpEffectID"].Value;
                set => CellsByName["CycleSpEffectID"].Value = (int)value;
            }
            

            // Def="s32 atkOccurrenceSpEffectId = -1"
            /// <summary>
            /// Attack SpEffect ID (s32)
            /// </summary>
            /// <remarks>
            /// Special effect ID that occurs when hitting an attack (-1 is ignored)
            /// </remarks>
            public int AttackSpEffectID 
            {
                get => (int)CellsByName["AttackSpEffectID"].Value;
                set => CellsByName["AttackSpEffectID"].Value = (int)value;
            }
            

            // Def="f32 guardDefFlickPowerRate = 1"
            /// <summary>
            /// Guard Defense - Weapon Repel Power % (f32)
            /// </summary>
            /// <remarks>
            /// Repellent defense correction value when guarding
            /// </remarks>
            public float GuardDefenseWeaponRepelPowerPercent 
            {
                get => (float)CellsByName["GuardDefenseWeaponRepelPowerPercent"].Value;
                set => CellsByName["GuardDefenseWeaponRepelPowerPercent"].Value = (float)value;
            }
            

            // Def="f32 guardStaminaCutRate = 1"
            /// <summary>
            /// Guard Stability % (f32)
            /// </summary>
            /// <remarks>
            /// Stamina cut rate correction value when guarding
            /// </remarks>
            public float GuardStabilityPercent 
            {
                get => (float)CellsByName["GuardStabilityPercent"].Value;
                set => CellsByName["GuardStabilityPercent"].Value = (float)value;
            }
            

            // Def="s16 rayCastPassedTime = -1"
            /// <summary>
            /// Raycast Passed Time (s16)
            /// </summary>
            /// <remarks>
            /// Passing the line of sight: Activation time [ms] (for evil eye)
            /// </remarks>
            public short RaycastPassedTime 
            {
                get => (short)CellsByName["RaycastPassedTime"].Value;
                set => CellsByName["RaycastPassedTime"].Value = (short)value;
            }
            

            // Def="u8 magicSubCategoryChange1"
            /// <summary>
            /// Conditional Category [1] (u8)
            /// </summary>
            /// <remarks>
            /// Vs to subcategory parameter change 1
            /// </remarks>
            public AtkSubCategory ConditionalCategory1 
            {
                get => (AtkSubCategory)CellsByName["ConditionalCategory1"].Value;
                set => CellsByName["ConditionalCategory1"].Value = (byte)value;
            }
            

            // Def="u8 magicSubCategoryChange2"
            /// <summary>
            /// Conditional Category [2] (u8)
            /// </summary>
            /// <remarks>
            /// Vs to subcategory parameter change 2
            /// </remarks>
            public AtkSubCategory ConditionalCategory2 
            {
                get => (AtkSubCategory)CellsByName["ConditionalCategory2"].Value;
                set => CellsByName["ConditionalCategory2"].Value = (byte)value;
            }
            

            // Def="s16 bowDistRate"
            /// <summary>
            /// Bow Distance % (s16)
            /// </summary>
            /// <remarks>
            /// Correction value added to the flight distance correction of the weapon
            /// </remarks>
            public short BowDistancePercent 
            {
                get => (short)CellsByName["BowDistancePercent"].Value;
                set => CellsByName["BowDistancePercent"].Value = (short)value;
            }
            

            // Def="u16 spCategory"
            /// <summary>
            /// Effect Category (u16)
            /// </summary>
            /// <remarks>
            /// Categories that determine behavior such as overwriting special effects
            /// </remarks>
            public SpEffectSpcategory EffectCategory 
            {
                get => (SpEffectSpcategory)CellsByName["EffectCategory"].Value;
                set => CellsByName["EffectCategory"].Value = (ushort)value;
            }
            

            // Def="u8 categoryPriority"
            /// <summary>
            /// Category Priority (u8)
            /// </summary>
            /// <remarks>
            /// Priority within the same category (lower one has priority)
            /// </remarks>
            public byte CategoryPriority 
            {
                get => (byte)CellsByName["CategoryPriority"].Value;
                set => CellsByName["CategoryPriority"].Value = (byte)value;
            }
            

            // Def="s8 saveCategory = -1"
            /// <summary>
            /// Save Category (s8)
            /// </summary>
            /// <remarks>
            /// Category to save special effects
            /// </remarks>
            public SpEffectSaveCategory SaveCategory 
            {
                get => (SpEffectSaveCategory)CellsByName["SaveCategory"].Value;
                set => CellsByName["SaveCategory"].Value = (sbyte)value;
            }
            

            // Def="u8 changeMagicSlot"
            /// <summary>
            /// Magic Attunement Slot (u8)
            /// </summary>
            /// <remarks>
            /// You can increase the specified number of magic registration slots
            /// </remarks>
            public byte MagicAttunementSlot 
            {
                get => (byte)CellsByName["MagicAttunementSlot"].Value;
                set => CellsByName["MagicAttunementSlot"].Value = (byte)value;
            }
            

            // Def="u8 changeMiracleSlot"
            /// <summary>
            /// Miracle Attunement Slot (u8)
            /// </summary>
            /// <remarks>
            /// You can increase the specified number of trajectory registration frames.
            /// </remarks>
            public byte MiracleAttunementSlot 
            {
                get => (byte)CellsByName["MiracleAttunementSlot"].Value;
                set => CellsByName["MiracleAttunementSlot"].Value = (byte)value;
            }
            

            // Def="s8 heroPointDamage"
            /// <summary>
            /// Humanity Damage (s8)
            /// </summary>
            /// <remarks>
            /// Damage value given to human nature value
            /// </remarks>
            public sbyte HumanityDamage 
            {
                get => (sbyte)CellsByName["HumanityDamage"].Value;
                set => CellsByName["HumanityDamage"].Value = (sbyte)value;
            }
            

            // Def="u8 defFlickPower"
            /// <summary>
            /// Weapon Repel Defence + (u8)
            /// </summary>
            /// <remarks>
            /// Set a value that overwrites the repelling defense
            /// </remarks>
            public byte WeaponRepelDefence 
            {
                get => (byte)CellsByName["WeaponRepelDefence"].Value;
                set => CellsByName["WeaponRepelDefence"].Value = (byte)value;
            }
            

            // Def="u8 flickDamageCutRate"
            /// <summary>
            /// Weapon Repel Absorption % (u8)
            /// </summary>
            /// <remarks>
            /// Set a value that overwrites the damage attenuation rate at the time of repelling
            /// </remarks>
            public byte WeaponRepelAbsorptionPercent 
            {
                get => (byte)CellsByName["WeaponRepelAbsorptionPercent"].Value;
                set => CellsByName["WeaponRepelAbsorptionPercent"].Value = (byte)value;
            }
            

            // Def="u8 bloodDamageRate = 100"
            /// <summary>
            /// Damage Correction %: Hemorrhage (u8)
            /// </summary>
            /// <remarks>
            /// Point damage of state change type [bleeding], correction value used only when% damage
            /// </remarks>
            public byte DamageCorrectionPercentHemorrhage 
            {
                get => (byte)CellsByName["DamageCorrectionPercentHemorrhage"].Value;
                set => CellsByName["DamageCorrectionPercentHemorrhage"].Value = (byte)value;
            }
            

            // Def="s8 dmgLv_None"
            /// <summary>
            /// Damage Level: No Impact (s8)
            /// </summary>
            /// <remarks>
            /// Specify the type to replace the damage Lv0
            /// </remarks>
            public AtkparamRepDmgtype DamageLevelNoImpact 
            {
                get => (AtkparamRepDmgtype)CellsByName["DamageLevelNoImpact"].Value;
                set => CellsByName["DamageLevelNoImpact"].Value = (sbyte)value;
            }
            

            // Def="s8 dmgLv_S"
            /// <summary>
            /// Damage Level: Small Impact (s8)
            /// </summary>
            /// <remarks>
            /// Specify the type to replace the damage Lv1
            /// </remarks>
            public AtkparamRepDmgtype DamageLevelSmallImpact 
            {
                get => (AtkparamRepDmgtype)CellsByName["DamageLevelSmallImpact"].Value;
                set => CellsByName["DamageLevelSmallImpact"].Value = (sbyte)value;
            }
            

            // Def="s8 dmgLv_M"
            /// <summary>
            /// Damage Level: Medium Impact (s8)
            /// </summary>
            /// <remarks>
            /// Specify the type to replace the damage Lv2
            /// </remarks>
            public AtkparamRepDmgtype DamageLevelMediumImpact 
            {
                get => (AtkparamRepDmgtype)CellsByName["DamageLevelMediumImpact"].Value;
                set => CellsByName["DamageLevelMediumImpact"].Value = (sbyte)value;
            }
            

            // Def="s8 dmgLv_L"
            /// <summary>
            /// Damage Level: Large Impact (s8)
            /// </summary>
            /// <remarks>
            /// Specify the type to replace the damage Lv3
            /// </remarks>
            public AtkparamRepDmgtype DamageLevelLargeImpact 
            {
                get => (AtkparamRepDmgtype)CellsByName["DamageLevelLargeImpact"].Value;
                set => CellsByName["DamageLevelLargeImpact"].Value = (sbyte)value;
            }
            

            // Def="s8 dmgLv_BlowM"
            /// <summary>
            /// Damage Level: Medium Blow (s8)
            /// </summary>
            /// <remarks>
            /// Specify the type to replace the damage Lv4
            /// </remarks>
            public AtkparamRepDmgtype DamageLevelMediumBlow 
            {
                get => (AtkparamRepDmgtype)CellsByName["DamageLevelMediumBlow"].Value;
                set => CellsByName["DamageLevelMediumBlow"].Value = (sbyte)value;
            }
            

            // Def="s8 dmgLv_Push"
            /// <summary>
            /// Damage Level: Push (s8)
            /// </summary>
            /// <remarks>
            /// Specify the type to replace the damage Lv5
            /// </remarks>
            public AtkparamRepDmgtype DamageLevelPush 
            {
                get => (AtkparamRepDmgtype)CellsByName["DamageLevelPush"].Value;
                set => CellsByName["DamageLevelPush"].Value = (sbyte)value;
            }
            

            // Def="s8 dmgLv_Strike"
            /// <summary>
            /// Damage Level: Strike (s8)
            /// </summary>
            /// <remarks>
            /// Specify the type to replace the damage Lv6
            /// </remarks>
            public AtkparamRepDmgtype DamageLevelStrike 
            {
                get => (AtkparamRepDmgtype)CellsByName["DamageLevelStrike"].Value;
                set => CellsByName["DamageLevelStrike"].Value = (sbyte)value;
            }
            

            // Def="s8 dmgLv_BlowS"
            /// <summary>
            /// Damage Level: Small Blow (s8)
            /// </summary>
            /// <remarks>
            /// Specify the type to replace the damage Lv7
            /// </remarks>
            public AtkparamRepDmgtype DamageLevelSmallBlow 
            {
                get => (AtkparamRepDmgtype)CellsByName["DamageLevelSmallBlow"].Value;
                set => CellsByName["DamageLevelSmallBlow"].Value = (sbyte)value;
            }
            

            // Def="s8 dmgLv_Min"
            /// <summary>
            /// Damage Level: Minimal (s8)
            /// </summary>
            /// <remarks>
            /// Specify the type to replace the damage Lv8
            /// </remarks>
            public AtkparamRepDmgtype DamageLevelMinimal 
            {
                get => (AtkparamRepDmgtype)CellsByName["DamageLevelMinimal"].Value;
                set => CellsByName["DamageLevelMinimal"].Value = (sbyte)value;
            }
            

            // Def="s8 dmgLv_Uppercut"
            /// <summary>
            /// Damage Level: Uppercut (s8)
            /// </summary>
            /// <remarks>
            /// Specify the type to replace the damage Lv9
            /// </remarks>
            public AtkparamRepDmgtype DamageLevelUppercut 
            {
                get => (AtkparamRepDmgtype)CellsByName["DamageLevelUppercut"].Value;
                set => CellsByName["DamageLevelUppercut"].Value = (sbyte)value;
            }
            

            // Def="s8 dmgLv_BlowLL"
            /// <summary>
            /// Damage Level: Blow Backward (s8)
            /// </summary>
            /// <remarks>
            /// Specify the type to replace the damage Lv10
            /// </remarks>
            public AtkparamRepDmgtype DamageLevelBlowBackward 
            {
                get => (AtkparamRepDmgtype)CellsByName["DamageLevelBlowBackward"].Value;
                set => CellsByName["DamageLevelBlowBackward"].Value = (sbyte)value;
            }
            

            // Def="s8 dmgLv_Breath"
            /// <summary>
            /// Damage Level: Breath (s8)
            /// </summary>
            /// <remarks>
            /// Specify the type to replace the damage Lv11
            /// </remarks>
            public AtkparamRepDmgtype DamageLevelBreath 
            {
                get => (AtkparamRepDmgtype)CellsByName["DamageLevelBreath"].Value;
                set => CellsByName["DamageLevelBreath"].Value = (sbyte)value;
            }
            

            // Def="u8 atkAttribute = 254"
            /// <summary>
            /// Attack Attribute (u8)
            /// </summary>
            /// <remarks>
            /// Physical attributes to set for special effects
            /// </remarks>
            public AtkparamAtkattrType AttackAttribute 
            {
                get => (AtkparamAtkattrType)CellsByName["AttackAttribute"].Value;
                set => CellsByName["AttackAttribute"].Value = (byte)value;
            }
            

            // Def="u8 spAttribute = 254"
            /// <summary>
            /// SpEffect Attribute (u8)
            /// </summary>
            /// <remarks>
            /// Special attributes to set for special effects
            /// </remarks>
            public AtkparamSpattrType SpEffectAttribute 
            {
                get => (AtkparamSpattrType)CellsByName["SpEffectAttribute"].Value;
                set => CellsByName["SpEffectAttribute"].Value = (byte)value;
            }
            

            // Def="u16 stateInfo"
            /// <summary>
            /// State Info (u16)
            /// </summary>
            /// <remarks>
            /// State change judgment flag
            /// </remarks>
            public SpEffectType StateInfo 
            {
                get => (SpEffectType)CellsByName["StateInfo"].Value;
                set => CellsByName["StateInfo"].Value = (ushort)value;
            }
            

            // Def="u8 wepParamChange"
            /// <summary>
            /// Weapon Parameter Change (u8)
            /// </summary>
            /// <remarks>
            /// Specify which weapon is effective. If there is no limit, all attacks and defenses including enemies are targeted
            /// </remarks>
            public SpEfeWepChangeParam WeaponParameterChange 
            {
                get => (SpEfeWepChangeParam)CellsByName["WeaponParameterChange"].Value;
                set => CellsByName["WeaponParameterChange"].Value = (byte)value;
            }
            

            // Def="u8 moveType"
            /// <summary>
            /// Move Type (u8)
            /// </summary>
            /// <remarks>
            /// Movement type. Change the movement speed.
            /// </remarks>
            public SpEffectMoveType MoveType 
            {
                get => (SpEffectMoveType)CellsByName["MoveType"].Value;
                set => CellsByName["MoveType"].Value = (byte)value;
            }
            

            // Def="u16 lifeReductionType"
            /// <summary>
            /// Effect Duration Multiplier - State Info (u16)
            /// </summary>
            /// <remarks>
            /// 
            /// </remarks>
            public SpEffectType EffectDurationMultiplierStateInfo 
            {
                get => (SpEffectType)CellsByName["EffectDurationMultiplierStateInfo"].Value;
                set => CellsByName["EffectDurationMultiplierStateInfo"].Value = (ushort)value;
            }
            

            // Def="u8 throwCondition"
            /// <summary>
            /// Throw Trigger (u8)
            /// </summary>
            /// <remarks>
            /// Throwing conditions. Affects the throwing mask.
            /// </remarks>
            public SpEffectThrowConditionType ThrowTrigger 
            {
                get => (SpEffectThrowConditionType)CellsByName["ThrowTrigger"].Value;
                set => CellsByName["ThrowTrigger"].Value = (byte)value;
            }
            

            // Def="s8 addBehaviorJudgeId_condition = -1"
            /// <summary>
            /// Add Behavior Judge ID - Trigger (s8)
            /// </summary>
            /// <remarks>
            /// Condition value to add a value to the action judgment ID (Def: -1)
            /// </remarks>
            public sbyte AddBehaviorJudgeIDTrigger 
            {
                get => (sbyte)CellsByName["AddBehaviorJudgeIDTrigger"].Value;
                set => CellsByName["AddBehaviorJudgeIDTrigger"].Value = (sbyte)value;
            }
            

            // Def="u8 freezeDamageRate = 100"
            /// <summary>
            /// Damage Correction %: Frostbite (u8)
            /// </summary>
            /// <remarks>
            /// Correction value used only for point damage and% damage of state change type [cold air]
            /// </remarks>
            public byte DamageCorrectionPercentFrostbite 
            {
                get => (byte)CellsByName["DamageCorrectionPercentFrostbite"].Value;
                set => CellsByName["DamageCorrectionPercentFrostbite"].Value = (byte)value;
            }
            

            // Def="u8 effectTargetSelf:1"
            /// <summary>
            /// Target Self (u8)
            /// </summary>
            /// <remarks>
            /// Only the target for which this judgment is checked is effective, the default is ×
            /// </remarks>
            public SpEffectBool TargetSelf 
            {
                get => (SpEffectBool)CellsByName["TargetSelf"].Value;
                set => CellsByName["TargetSelf"].Value = (byte)value;
            }
            

            // Def="u8 effectTargetFriend:1"
            /// <summary>
            /// Target Friend (u8)
            /// </summary>
            /// <remarks>
            /// Only the target for which this judgment is checked is effective, the default is ×
            /// </remarks>
            public SpEffectBool TargetFriend 
            {
                get => (SpEffectBool)CellsByName["TargetFriend"].Value;
                set => CellsByName["TargetFriend"].Value = (byte)value;
            }
            

            // Def="u8 effectTargetEnemy:1"
            /// <summary>
            /// Target Enemy (u8)
            /// </summary>
            /// <remarks>
            /// Only the target for which this judgment is checked is effective, the default is ×
            /// </remarks>
            public SpEffectBool TargetEnemy 
            {
                get => (SpEffectBool)CellsByName["TargetEnemy"].Value;
                set => CellsByName["TargetEnemy"].Value = (byte)value;
            }
            

            // Def="u8 effectTargetPlayer:1"
            /// <summary>
            /// Target Player (u8)
            /// </summary>
            /// <remarks>
            /// Only the target for which this judgment is checked is effective, the default is ×
            /// </remarks>
            public SpEffectBool TargetPlayer 
            {
                get => (SpEffectBool)CellsByName["TargetPlayer"].Value;
                set => CellsByName["TargetPlayer"].Value = (byte)value;
            }
            

            // Def="u8 effectTargetAI:1"
            /// <summary>
            /// Target AI (u8)
            /// </summary>
            /// <remarks>
            /// Only the target for which this judgment is checked is effective, the default is ×
            /// </remarks>
            public SpEffectBool TargetAI 
            {
                get => (SpEffectBool)CellsByName["TargetAI"].Value;
                set => CellsByName["TargetAI"].Value = (byte)value;
            }
            

            // Def="u8 effectTargetLive:1"
            /// <summary>
            /// Target Live (u8)
            /// </summary>
            /// <remarks>
            /// Only the target for which this judgment is checked is effective, the default is ×
            /// </remarks>
            public SpEffectBool TargetLive 
            {
                get => (SpEffectBool)CellsByName["TargetLive"].Value;
                set => CellsByName["TargetLive"].Value = (byte)value;
            }
            

            // Def="u8 effectTargetGhost:1"
            /// <summary>
            /// Target Ghost (u8)
            /// </summary>
            /// <remarks>
            /// Only the target for which this judgment is checked is effective, the default is ×
            /// </remarks>
            public SpEffectBool TargetGhost 
            {
                get => (SpEffectBool)CellsByName["TargetGhost"].Value;
                set => CellsByName["TargetGhost"].Value = (byte)value;
            }
            

            // Def="u8 disableSleep:1"
            /// <summary>
            /// Disable Sleep (u8)
            /// </summary>
            /// <remarks>
            /// If this effect is applied, you will not sleep
            /// </remarks>
            public SpEffectBool DisableSleep 
            {
                get => (SpEffectBool)CellsByName["DisableSleep"].Value;
                set => CellsByName["DisableSleep"].Value = (byte)value;
            }
            

            // Def="u8 disableMadness:1"
            /// <summary>
            /// Disable Madness (u8)
            /// </summary>
            /// <remarks>
            /// With this effect, you won't go mad
            /// </remarks>
            public SpEffectBool DisableMadness 
            {
                get => (SpEffectBool)CellsByName["DisableMadness"].Value;
                set => CellsByName["DisableMadness"].Value = (byte)value;
            }
            

            // Def="u8 effectTargetAttacker:1"
            /// <summary>
            /// Target Attacker (u8)
            /// </summary>
            /// <remarks>
            /// Apply special effects to attackers after damage (cannot enter defenders)
            /// </remarks>
            public SpEffectBool TargetAttacker 
            {
                get => (SpEffectBool)CellsByName["TargetAttacker"].Value;
                set => CellsByName["TargetAttacker"].Value = (byte)value;
            }
            

            // Def="u8 dispIconNonactive:1"
            /// <summary>
            /// Display Icon when Inactive (u8)
            /// </summary>
            /// <remarks>
            /// The icon is displayed even in the state of waiting for activation.
            /// </remarks>
            public SpEffectBool DisplayIconWhenInactive 
            {
                get => (SpEffectBool)CellsByName["DisplayIconWhenInactive"].Value;
                set => CellsByName["DisplayIconWhenInactive"].Value = (byte)value;
            }
            

            // Def="u8 regainGaugeDamage:1"
            /// <summary>
            /// Generate Regain Gauge (u8)
            /// </summary>
            /// <remarks>
            /// Whether to generate a regain gauge
            /// </remarks>
            public SpEffectBool GenerateRegainGauge 
            {
                get => (SpEffectBool)CellsByName["GenerateRegainGauge"].Value;
                set => CellsByName["GenerateRegainGauge"].Value = (byte)value;
            }
            

            // Def="u8 bAdjustMagicAblity:1"
            /// <summary>
            /// Use Intelligence Correction (u8)
            /// </summary>
            /// <remarks>
            /// Do you want to correct the magic power?
            /// </remarks>
            public SpEffectBool UseIntelligenceCorrection 
            {
                get => (SpEffectBool)CellsByName["UseIntelligenceCorrection"].Value;
                set => CellsByName["UseIntelligenceCorrection"].Value = (byte)value;
            }
            

            // Def="u8 bAdjustFaithAblity:1"
            /// <summary>
            /// Use Faith Correction (u8)
            /// </summary>
            /// <remarks>
            /// Do you correct your faith?
            /// </remarks>
            public SpEffectBool UseFaithCorrection 
            {
                get => (SpEffectBool)CellsByName["UseFaithCorrection"].Value;
                set => CellsByName["UseFaithCorrection"].Value = (byte)value;
            }
            

            // Def="u8 bGameClearBonus:1"
            /// <summary>
            /// Enable for Game Clear (u8)
            /// </summary>
            /// <remarks>
            /// Whether it is for the game clear lap bonus.
            /// </remarks>
            public SpEffectBool EnableForGameClear 
            {
                get => (SpEffectBool)CellsByName["EnableForGameClear"].Value;
                set => CellsByName["EnableForGameClear"].Value = (byte)value;
            }
            

            // Def="u8 magParamChange:1"
            /// <summary>
            /// Affects Sorcery (u8)
            /// </summary>
            /// <remarks>
            /// Set whether or not it is effective against magic
            /// </remarks>
            public SpEffectBool AffectsSorcery 
            {
                get => (SpEffectBool)CellsByName["AffectsSorcery"].Value;
                set => CellsByName["AffectsSorcery"].Value = (byte)value;
            }
            

            // Def="u8 miracleParamChange:1"
            /// <summary>
            /// Affects Incantation (u8)
            /// </summary>
            /// <remarks>
            /// Set whether or not it is effective against miracles
            /// </remarks>
            public SpEffectBool AffectsIncantation 
            {
                get => (SpEffectBool)CellsByName["AffectsIncantation"].Value;
                set => CellsByName["AffectsIncantation"].Value = (byte)value;
            }
            

            // Def="u8 clearSoul:1"
            /// <summary>
            /// Clear Held Runes (u8)
            /// </summary>
            /// <remarks>
            /// Possession soul becomes 0.
            /// </remarks>
            public SpEffectBool ClearHeldRunes 
            {
                get => (SpEffectBool)CellsByName["ClearHeldRunes"].Value;
                set => CellsByName["ClearHeldRunes"].Value = (byte)value;
            }
            

            // Def="u8 requestSOS:1"
            /// <summary>
            /// Request: Friendly Phantom Summon (u8)
            /// </summary>
            /// <remarks>
            /// If checked, issue an SOS sign request when activated
            /// </remarks>
            public SpEffectBool RequestFriendlyPhantomSummon 
            {
                get => (SpEffectBool)CellsByName["RequestFriendlyPhantomSummon"].Value;
                set => CellsByName["RequestFriendlyPhantomSummon"].Value = (byte)value;
            }
            

            // Def="u8 requestBlackSOS:1"
            /// <summary>
            /// Request: Hostile Phantom Summon (u8)
            /// </summary>
            /// <remarks>
            /// If checked, issue a black SOS sign request when activated
            /// </remarks>
            public SpEffectBool RequestHostilePhantomSummon 
            {
                get => (SpEffectBool)CellsByName["RequestHostilePhantomSummon"].Value;
                set => CellsByName["RequestHostilePhantomSummon"].Value = (byte)value;
            }
            

            // Def="u8 requestForceJoinBlackSOS:1"
            /// <summary>
            /// Request: Invasion (u8)
            /// </summary>
            /// <remarks>
            /// If checked, issue an intrusion_A request when activated
            /// </remarks>
            public SpEffectBool RequestInvasion 
            {
                get => (SpEffectBool)CellsByName["RequestInvasion"].Value;
                set => CellsByName["RequestInvasion"].Value = (byte)value;
            }
            

            // Def="u8 requestKickSession:1"
            /// <summary>
            /// Request: Kick (u8)
            /// </summary>
            /// <remarks>
            /// If checked, a kick request will be issued at the time of activation.
            /// </remarks>
            public SpEffectBool RequestKick 
            {
                get => (SpEffectBool)CellsByName["RequestKick"].Value;
                set => CellsByName["RequestKick"].Value = (byte)value;
            }
            

            // Def="u8 requestLeaveSession:1"
            /// <summary>
            /// Request: Return to Own World (u8)
            /// </summary>
            /// <remarks>
            /// If checked, an exit request will be issued at the time of activation.
            /// </remarks>
            public SpEffectBool RequestReturnToOwnWorld 
            {
                get => (SpEffectBool)CellsByName["RequestReturnToOwnWorld"].Value;
                set => CellsByName["RequestReturnToOwnWorld"].Value = (byte)value;
            }
            

            // Def="u8 requestNpcInveda:1"
            /// <summary>
            /// Request: NPC Invasion (u8)
            /// </summary>
            /// <remarks>
            /// If checked, an intrusion request to the NPC will be issued at the time of activation.
            /// </remarks>
            public SpEffectBool RequestNPCInvasion 
            {
                get => (SpEffectBool)CellsByName["RequestNPCInvasion"].Value;
                set => CellsByName["RequestNPCInvasion"].Value = (byte)value;
            }
            

            // Def="u8 noDead:1"
            /// <summary>
            /// Is No Dead (u8)
            /// </summary>
            /// <remarks>
            /// Whether you can be corpse. With this check, you will not be dead
            /// </remarks>
            public SpEffectBool IsNoDead 
            {
                get => (SpEffectBool)CellsByName["IsNoDead"].Value;
                set => CellsByName["IsNoDead"].Value = (byte)value;
            }
            

            // Def="u8 bCurrHPIndependeMaxHP:1"
            /// <summary>
            /// Current HP independent Max HP (u8)
            /// </summary>
            /// <remarks>
            /// Does HP now affect even if the maximum HP increases or decreases?
            /// </remarks>
            public SpEffectBool CurrentHPIndependentMaxHP 
            {
                get => (SpEffectBool)CellsByName["CurrentHPIndependentMaxHP"].Value;
                set => CellsByName["CurrentHPIndependentMaxHP"].Value = (byte)value;
            }
            

            // Def="u8 corrosionIgnore:1"
            /// <summary>
            /// Ignore Durability Loss (u8)
            /// </summary>
            /// <remarks>
            /// [State change type] ignores [Durability] decrease due to [Corrosion]
            /// </remarks>
            public SpEffectBool IgnoreDurabilityLoss 
            {
                get => (SpEffectBool)CellsByName["IgnoreDurabilityLoss"].Value;
                set => CellsByName["IgnoreDurabilityLoss"].Value = (byte)value;
            }
            

            // Def="u8 sightSearchCutIgnore:1"
            /// <summary>
            /// Ignore Vision Reductions (u8)
            /// </summary>
            /// <remarks>
            /// Ignore visual search invalidity
            /// </remarks>
            public SpEffectBool IgnoreVisionReductions 
            {
                get => (SpEffectBool)CellsByName["IgnoreVisionReductions"].Value;
                set => CellsByName["IgnoreVisionReductions"].Value = (byte)value;
            }
            

            // Def="u8 hearingSearchCutIgnore:1"
            /// <summary>
            /// Ignore Listen Reductions (u8)
            /// </summary>
            /// <remarks>
            /// Ignore auditory search invalidity
            /// </remarks>
            public SpEffectBool IgnoreListenReductions 
            {
                get => (SpEffectBool)CellsByName["IgnoreListenReductions"].Value;
                set => CellsByName["IgnoreListenReductions"].Value = (byte)value;
            }
            

            // Def="u8 antiMagicIgnore:1"
            /// <summary>
            /// Ignore Anti-Magic Effect (u8)
            /// </summary>
            /// <remarks>
            /// You can use magic even in the anti-magic range
            /// </remarks>
            public SpEffectBool IgnoreAntiMagicEffect 
            {
                get => (SpEffectBool)CellsByName["IgnoreAntiMagicEffect"].Value;
                set => CellsByName["IgnoreAntiMagicEffect"].Value = (byte)value;
            }
            

            // Def="u8 fakeTargetIgnore:1"
            /// <summary>
            /// Ignore Fake Targets (u8)
            /// </summary>
            /// <remarks>
            /// Don't get caught in the fake target that occurred
            /// </remarks>
            public SpEffectBool IgnoreFakeTargets 
            {
                get => (SpEffectBool)CellsByName["IgnoreFakeTargets"].Value;
                set => CellsByName["IgnoreFakeTargets"].Value = (byte)value;
            }
            

            // Def="u8 fakeTargetIgnoreUndead:1"
            /// <summary>
            /// Ignore Fake Human Targets (u8)
            /// </summary>
            /// <remarks>
            /// You will not be caught by the fake target of the human system that occurred
            /// </remarks>
            public SpEffectBool IgnoreFakeHumanTargets 
            {
                get => (SpEffectBool)CellsByName["IgnoreFakeHumanTargets"].Value;
                set => CellsByName["IgnoreFakeHumanTargets"].Value = (byte)value;
            }
            

            // Def="u8 fakeTargetIgnoreAnimal:1"
            /// <summary>
            /// Ignore Fake Animal Targets (u8)
            /// </summary>
            /// <remarks>
            /// You will not be caught by the fake target of the beast system that occurred
            /// </remarks>
            public SpEffectBool IgnoreFakeAnimalTargets 
            {
                get => (SpEffectBool)CellsByName["IgnoreFakeAnimalTargets"].Value;
                set => CellsByName["IgnoreFakeAnimalTargets"].Value = (byte)value;
            }
            

            // Def="u8 grabityIgnore:1"
            /// <summary>
            /// Ignore Gravity Change (u8)
            /// </summary>
            /// <remarks>
            /// Gravity effect disabled
            /// </remarks>
            public SpEffectBool IgnoreGravityChange 
            {
                get => (SpEffectBool)CellsByName["IgnoreGravityChange"].Value;
                set => CellsByName["IgnoreGravityChange"].Value = (byte)value;
            }
            

            // Def="u8 disablePoison:1"
            /// <summary>
            /// Disable Poison (u8)
            /// </summary>
            /// <remarks>
            /// If this effect is applied, it will not be poisoned.
            /// </remarks>
            public SpEffectBool DisablePoison 
            {
                get => (SpEffectBool)CellsByName["DisablePoison"].Value;
                set => CellsByName["DisablePoison"].Value = (byte)value;
            }
            

            // Def="u8 disableDisease:1"
            /// <summary>
            /// Disable Scarlet Rot (u8)
            /// </summary>
            /// <remarks>
            /// If this effect is applied, you will not get plague
            /// </remarks>
            public SpEffectBool DisableScarletRot 
            {
                get => (SpEffectBool)CellsByName["DisableScarletRot"].Value;
                set => CellsByName["DisableScarletRot"].Value = (byte)value;
            }
            

            // Def="u8 disableBlood:1"
            /// <summary>
            /// Disable Hemorrhage (u8)
            /// </summary>
            /// <remarks>
            /// With this effect, you won't get bleeding
            /// </remarks>
            public SpEffectBool DisableHemorrhage 
            {
                get => (SpEffectBool)CellsByName["DisableHemorrhage"].Value;
                set => CellsByName["DisableHemorrhage"].Value = (byte)value;
            }
            

            // Def="u8 disableCurse:1"
            /// <summary>
            /// Disable Blight (u8)
            /// </summary>
            /// <remarks>
            /// With this effect, you won't be cursed
            /// </remarks>
            public SpEffectBool DisableBlight 
            {
                get => (SpEffectBool)CellsByName["DisableBlight"].Value;
                set => CellsByName["DisableBlight"].Value = (byte)value;
            }
            

            // Def="u8 enableCharm:1"
            /// <summary>
            /// Enable Charm (u8)
            /// </summary>
            /// <remarks>
            /// If this effect is applied, you will be fascinated.
            /// </remarks>
            public SpEffectBool EnableCharm 
            {
                get => (SpEffectBool)CellsByName["EnableCharm"].Value;
                set => CellsByName["EnableCharm"].Value = (byte)value;
            }
            

            // Def="u8 enableLifeTime:1"
            /// <summary>
            /// Enable Lifetime (u8)
            /// </summary>
            /// <remarks>
            /// Will the life be extended when the flag is set by TAE?
            /// </remarks>
            public SpEffectBool EnableLifetime 
            {
                get => (SpEffectBool)CellsByName["EnableLifetime"].Value;
                set => CellsByName["EnableLifetime"].Value = (byte)value;
            }
            

            // Def="u8 bAdjustStrengthAblity:1"
            /// <summary>
            /// Use Strength Correction (u8)
            /// </summary>
            /// <remarks>
            /// Do you want to correct your strength?
            /// </remarks>
            public SpEffectBool UseStrengthCorrection 
            {
                get => (SpEffectBool)CellsByName["UseStrengthCorrection"].Value;
                set => CellsByName["UseStrengthCorrection"].Value = (byte)value;
            }
            

            // Def="u8 bAdjustAgilityAblity:1"
            /// <summary>
            /// Use Dexterity Correction (u8)
            /// </summary>
            /// <remarks>
            /// Do you want to correct your workmanship?
            /// </remarks>
            public SpEffectBool UseDexterityCorrection 
            {
                get => (SpEffectBool)CellsByName["UseDexterityCorrection"].Value;
                set => CellsByName["UseDexterityCorrection"].Value = (byte)value;
            }
            

            // Def="u8 eraseOnBonfireRecover:1"
            /// <summary>
            /// Erase on Bonfire Rest (u8)
            /// </summary>
            /// <remarks>
            /// Will it be extinguished by bonfire recovery?
            /// </remarks>
            public SpEffectBool EraseOnBonfireRest 
            {
                get => (SpEffectBool)CellsByName["EraseOnBonfireRest"].Value;
                set => CellsByName["EraseOnBonfireRest"].Value = (byte)value;
            }
            

            // Def="u8 throwAttackParamChange:1"
            /// <summary>
            /// Throw Attack Param Change (u8)
            /// </summary>
            /// <remarks>
            /// Set whether or not it is effective against throwing attacks
            /// </remarks>
            public SpEffectBool ThrowAttackParamChange 
            {
                get => (SpEffectBool)CellsByName["ThrowAttackParamChange"].Value;
                set => CellsByName["ThrowAttackParamChange"].Value = (byte)value;
            }
            

            // Def="u8 requestLeaveColiseumSession:1"
            /// <summary>
            /// Request: Leave Arena (u8)
            /// </summary>
            /// <remarks>
            /// If checked, a request to leave the arena will be issued at the time of activation.
            /// </remarks>
            public SpEffectBool RequestLeaveArena 
            {
                get => (SpEffectBool)CellsByName["RequestLeaveArena"].Value;
                set => CellsByName["RequestLeaveArena"].Value = (byte)value;
            }
            

            // Def="u8 isExtendSpEffectLife:1"
            /// <summary>
            /// Has Effect Duration Adjustment Applied (u8)
            /// </summary>
            /// <remarks>
            /// Whether to be eligible for extension when the life extension effect is applied
            /// </remarks>
            public SpEffectBool HasEffectDurationAdjustmentApplied 
            {
                get => (SpEffectBool)CellsByName["HasEffectDurationAdjustmentApplied"].Value;
                set => CellsByName["HasEffectDurationAdjustmentApplied"].Value = (byte)value;
            }
            

            // Def="u8 hasTarget:1"
            /// <summary>
            /// Has Target (u8)
            /// </summary>
            /// <remarks>
            /// Do you know the enemy? : [Activation condition] (for evil eye users)
            /// </remarks>
            public SpEffectBool HasTarget 
            {
                get => (SpEffectBool)CellsByName["HasTarget"].Value;
                set => CellsByName["HasTarget"].Value = (byte)value;
            }
            

            // Def="u8 replanningOnFire:1"
            /// <summary>
            /// Cancel on Fire Damage (u8)
            /// </summary>
            /// <remarks>
            /// Whether to replan at the time of activation
            /// </remarks>
            public BoolCirclecrossType CancelOnFireDamage 
            {
                get => (BoolCirclecrossType)CellsByName["CancelOnFireDamage"].Value;
                set => CellsByName["CancelOnFireDamage"].Value = (byte)value;
            }
            

            // Def="u8 vowType0:1"
            /// <summary>
            /// Trigger for Vow Type [0] (u8)
            /// </summary>
            /// <remarks>
            /// Pledge 0
            /// </remarks>
            public SpEffectBool TriggerForVowType0 
            {
                get => (SpEffectBool)CellsByName["TriggerForVowType0"].Value;
                set => CellsByName["TriggerForVowType0"].Value = (byte)value;
            }
            

            // Def="u8 vowType1:1"
            /// <summary>
            /// Trigger for Vow Type [1] (u8)
            /// </summary>
            /// <remarks>
            /// Pledge 1
            /// </remarks>
            public SpEffectBool TriggerForVowType1 
            {
                get => (SpEffectBool)CellsByName["TriggerForVowType1"].Value;
                set => CellsByName["TriggerForVowType1"].Value = (byte)value;
            }
            

            // Def="u8 vowType2:1"
            /// <summary>
            /// Trigger for Vow Type [2] (u8)
            /// </summary>
            /// <remarks>
            /// Pledge 2
            /// </remarks>
            public SpEffectBool TriggerForVowType2 
            {
                get => (SpEffectBool)CellsByName["TriggerForVowType2"].Value;
                set => CellsByName["TriggerForVowType2"].Value = (byte)value;
            }
            

            // Def="u8 vowType3:1"
            /// <summary>
            /// Trigger for Vow Type [3] (u8)
            /// </summary>
            /// <remarks>
            /// Pledge 3
            /// </remarks>
            public SpEffectBool TriggerForVowType3 
            {
                get => (SpEffectBool)CellsByName["TriggerForVowType3"].Value;
                set => CellsByName["TriggerForVowType3"].Value = (byte)value;
            }
            

            // Def="u8 vowType4:1"
            /// <summary>
            /// Trigger for Vow Type [4] (u8)
            /// </summary>
            /// <remarks>
            /// Pledge 4
            /// </remarks>
            public SpEffectBool TriggerForVowType4 
            {
                get => (SpEffectBool)CellsByName["TriggerForVowType4"].Value;
                set => CellsByName["TriggerForVowType4"].Value = (byte)value;
            }
            

            // Def="u8 vowType5:1"
            /// <summary>
            /// Trigger for Vow Type [5] (u8)
            /// </summary>
            /// <remarks>
            /// Pledge 5
            /// </remarks>
            public SpEffectBool TriggerForVowType5 
            {
                get => (SpEffectBool)CellsByName["TriggerForVowType5"].Value;
                set => CellsByName["TriggerForVowType5"].Value = (byte)value;
            }
            

            // Def="u8 vowType6:1"
            /// <summary>
            /// Trigger for Vow Type [6] (u8)
            /// </summary>
            /// <remarks>
            /// Pledge 6
            /// </remarks>
            public SpEffectBool TriggerForVowType6 
            {
                get => (SpEffectBool)CellsByName["TriggerForVowType6"].Value;
                set => CellsByName["TriggerForVowType6"].Value = (byte)value;
            }
            

            // Def="u8 vowType7:1"
            /// <summary>
            /// Trigger for Vow Type [7] (u8)
            /// </summary>
            /// <remarks>
            /// Pledge 7
            /// </remarks>
            public SpEffectBool TriggerForVowType7 
            {
                get => (SpEffectBool)CellsByName["TriggerForVowType7"].Value;
                set => CellsByName["TriggerForVowType7"].Value = (byte)value;
            }
            

            // Def="u8 vowType8:1"
            /// <summary>
            /// Trigger for Vow Type [8] (u8)
            /// </summary>
            /// <remarks>
            /// Pledge 8
            /// </remarks>
            public SpEffectBool TriggerForVowType8 
            {
                get => (SpEffectBool)CellsByName["TriggerForVowType8"].Value;
                set => CellsByName["TriggerForVowType8"].Value = (byte)value;
            }
            

            // Def="u8 vowType9:1"
            /// <summary>
            /// Trigger for Vow Type [9] (u8)
            /// </summary>
            /// <remarks>
            /// Pledge 9
            /// </remarks>
            public SpEffectBool TriggerForVowType9 
            {
                get => (SpEffectBool)CellsByName["TriggerForVowType9"].Value;
                set => CellsByName["TriggerForVowType9"].Value = (byte)value;
            }
            

            // Def="u8 vowType10:1"
            /// <summary>
            /// Trigger for Vow Type [10] (u8)
            /// </summary>
            /// <remarks>
            /// Pledge 10
            /// </remarks>
            public SpEffectBool TriggerForVowType10 
            {
                get => (SpEffectBool)CellsByName["TriggerForVowType10"].Value;
                set => CellsByName["TriggerForVowType10"].Value = (byte)value;
            }
            

            // Def="u8 vowType11:1"
            /// <summary>
            /// Trigger for Vow Type [11] (u8)
            /// </summary>
            /// <remarks>
            /// Pledge 11
            /// </remarks>
            public SpEffectBool TriggerForVowType11 
            {
                get => (SpEffectBool)CellsByName["TriggerForVowType11"].Value;
                set => CellsByName["TriggerForVowType11"].Value = (byte)value;
            }
            

            // Def="u8 vowType12:1"
            /// <summary>
            /// Trigger for Vow Type [12] (u8)
            /// </summary>
            /// <remarks>
            /// Pledge 12
            /// </remarks>
            public SpEffectBool TriggerForVowType12 
            {
                get => (SpEffectBool)CellsByName["TriggerForVowType12"].Value;
                set => CellsByName["TriggerForVowType12"].Value = (byte)value;
            }
            

            // Def="u8 vowType13:1"
            /// <summary>
            /// Trigger for Vow Type [13] (u8)
            /// </summary>
            /// <remarks>
            /// Pledge 13
            /// </remarks>
            public SpEffectBool TriggerForVowType13 
            {
                get => (SpEffectBool)CellsByName["TriggerForVowType13"].Value;
                set => CellsByName["TriggerForVowType13"].Value = (byte)value;
            }
            

            // Def="u8 vowType14:1"
            /// <summary>
            /// Trigger for Vow Type [14] (u8)
            /// </summary>
            /// <remarks>
            /// Pledge 14
            /// </remarks>
            public SpEffectBool TriggerForVowType14 
            {
                get => (SpEffectBool)CellsByName["TriggerForVowType14"].Value;
                set => CellsByName["TriggerForVowType14"].Value = (byte)value;
            }
            

            // Def="u8 vowType15:1"
            /// <summary>
            /// Trigger for Vow Type [15] (u8)
            /// </summary>
            /// <remarks>
            /// Pledge 15
            /// </remarks>
            public SpEffectBool TriggerForVowType15 
            {
                get => (SpEffectBool)CellsByName["TriggerForVowType15"].Value;
                set => CellsByName["TriggerForVowType15"].Value = (byte)value;
            }
            

            // Def="s8 repAtkDmgLv"
            /// <summary>
            /// Change Attacker Damage Level (s8)
            /// </summary>
            /// <remarks>
            /// The damage level of the attacking side changes to this value
            /// </remarks>
            public AtkparamRepDmgtype ChangeAttackerDamageLevel 
            {
                get => (AtkparamRepDmgtype)CellsByName["ChangeAttackerDamageLevel"].Value;
                set => CellsByName["ChangeAttackerDamageLevel"].Value = (sbyte)value;
            }
            

            // Def="f32 sightSearchRate = 1"
            /// <summary>
            /// AI Vision Correction (f32)
            /// </summary>
            /// <remarks>
            /// Correct the ease of finding with a magnification
///Requires State Info 267
            /// </remarks>
            public float AIVisionCorrection 
            {
                get => (float)CellsByName["AIVisionCorrection"].Value;
                set => CellsByName["AIVisionCorrection"].Value = (float)value;
            }
            

            // Def="u8 effectTargetOpposeTarget:1"
            /// <summary>
            /// Trigger for Opponent (u8)
            /// </summary>
            /// <remarks>
            /// Only the target for which this judgment is checked is effective, the default is ×
            /// </remarks>
            public SpEffectBool TriggerForOpponent 
            {
                get => (SpEffectBool)CellsByName["TriggerForOpponent"].Value;
                set => CellsByName["TriggerForOpponent"].Value = (byte)value;
            }
            

            // Def="u8 effectTargetFriendlyTarget:1"
            /// <summary>
            /// Trigger for Friendly (u8)
            /// </summary>
            /// <remarks>
            /// Only the target for which this judgment is checked is effective, the default is ×
            /// </remarks>
            public SpEffectBool TriggerForFriendly 
            {
                get => (SpEffectBool)CellsByName["TriggerForFriendly"].Value;
                set => CellsByName["TriggerForFriendly"].Value = (byte)value;
            }
            

            // Def="u8 effectTargetSelfTarget:1"
            /// <summary>
            /// Trigger for Self (u8)
            /// </summary>
            /// <remarks>
            /// Only the target for which this judgment is checked is effective, the default is ×
            /// </remarks>
            public SpEffectBool TriggerForSelf 
            {
                get => (SpEffectBool)CellsByName["TriggerForSelf"].Value;
                set => CellsByName["TriggerForSelf"].Value = (byte)value;
            }
            

            // Def="u8 effectTargetPcHorse:1"
            /// <summary>
            /// Trigger for Horse (u8)
            /// </summary>
            /// <remarks>
            /// Only the target for which this judgment is checked is effective, the default is ×
            /// </remarks>
            public SpEffectBool TriggerForHorse 
            {
                get => (SpEffectBool)CellsByName["TriggerForHorse"].Value;
                set => CellsByName["TriggerForHorse"].Value = (byte)value;
            }
            

            // Def="u8 effectTargetPcDeceased:1"
            /// <summary>
            /// Trigger for Dead Player (u8)
            /// </summary>
            /// <remarks>
            /// Only the target for which this judgment is checked is effective, the default is ×
            /// </remarks>
            public SpEffectBool TriggerForDeadPlayer 
            {
                get => (SpEffectBool)CellsByName["TriggerForDeadPlayer"].Value;
                set => CellsByName["TriggerForDeadPlayer"].Value = (byte)value;
            }
            

            // Def="u8 isContractSpEffectLife:1"
            /// <summary>
            /// Can Duration be Reduced (u8)
            /// </summary>
            /// <remarks>
            /// Whether it will be shortened when the life shortening effect is applied
            /// </remarks>
            public SpEffectBool CanDurationBeReduced 
            {
                get => (SpEffectBool)CellsByName["CanDurationBeReduced"].Value;
                set => CellsByName["CanDurationBeReduced"].Value = (byte)value;
            }
            

            // Def="u8 isWaitModeDelete:1"
            /// <summary>
            /// Delete in Wait Mode (u8)
            /// </summary>
            /// <remarks>
            /// Do you want to delete it the moment you are in a waiting state?
            /// </remarks>
            public SpEffectBool DeleteInWaitMode 
            {
                get => (SpEffectBool)CellsByName["DeleteInWaitMode"].Value;
                set => CellsByName["DeleteInWaitMode"].Value = (byte)value;
            }
            

            // Def="u8 isIgnoreNoDamage:1"
            /// <summary>
            /// Apply through No Damage (u8)
            /// </summary>
            /// <remarks>
            /// Whether to apply the damage from this special effect even in the invincible state only when the state change type "Apply the activation function even when invincible" is applied.
            /// </remarks>
            public SpEffectBool ApplyThroughNoDamage 
            {
                get => (SpEffectBool)CellsByName["ApplyThroughNoDamage"].Value;
                set => CellsByName["ApplyThroughNoDamage"].Value = (byte)value;
            }
            

            // Def="s8 changeTeamType = -1"
            /// <summary>
            /// Team Type (s8)
            /// </summary>
            /// <remarks>
            /// Overwrites the specified team type
///Requires State Info 132
            /// </remarks>
            public SpEffectChangeTeamType TeamType 
            {
                get => (SpEffectChangeTeamType)CellsByName["TeamType"].Value;
                set => CellsByName["TeamType"].Value = (sbyte)value;
            }
            

            // Def="s16 dmypolyId = -1"
            /// <summary>
            /// Bullet Behavior ID - DmyPoly ID (s16)
            /// </summary>
            /// <remarks>
            /// Damipoli ID. Damipoli ID range is 0 to 999.1000, 10000 is the category number.
            /// </remarks>
            public short BulletBehaviorIDDmyPolyID 
            {
                get => (short)CellsByName["BulletBehaviorIDDmyPolyID"].Value;
                set => CellsByName["BulletBehaviorIDDmyPolyID"].Value = (short)value;
            }
            

            // Def="s32 vfxId = -1"
            /// <summary>
            /// Effect VFX [0] (s32)
            /// </summary>
            /// <remarks>
            /// Special effect VfxId (-1 disabled)
            /// </remarks>
            public int EffectVFX0 
            {
                get => (int)CellsByName["EffectVFX0"].Value;
                set => CellsByName["EffectVFX0"].Value = (int)value;
            }
            

            // Def="s32 accumuOverFireId = -1"
            /// <summary>
            /// Accumulator - Over Value - SpEffect ID (s32)
            /// </summary>
            /// <remarks>
            /// Special effect Id activated at the upper limit of the spirit ball
            /// </remarks>
            public int AccumulatorOverValueSpEffectID 
            {
                get => (int)CellsByName["AccumulatorOverValueSpEffectID"].Value;
                set => CellsByName["AccumulatorOverValueSpEffectID"].Value = (int)value;
            }
            

            // Def="s32 accumuOverVal = -1"
            /// <summary>
            /// Accumulator - Over Value (s32)
            /// </summary>
            /// <remarks>
            /// Genkitama upper limit
            /// </remarks>
            public int AccumulatorOverValue 
            {
                get => (int)CellsByName["AccumulatorOverValue"].Value;
                set => CellsByName["AccumulatorOverValue"].Value = (int)value;
            }
            

            // Def="s32 accumuUnderFireId = -1"
            /// <summary>
            /// Accumulator - Under Value - SpEffect ID (s32)
            /// </summary>
            /// <remarks>
            /// Special effect Id activated at the lower limit of the spirit ball
            /// </remarks>
            public int AccumulatorUnderValueSpEffectID 
            {
                get => (int)CellsByName["AccumulatorUnderValueSpEffectID"].Value;
                set => CellsByName["AccumulatorUnderValueSpEffectID"].Value = (int)value;
            }
            

            // Def="s32 accumuUnderVal = -1"
            /// <summary>
            /// Accumulator - Under Value (s32)
            /// </summary>
            /// <remarks>
            /// Genkitama lower limit
            /// </remarks>
            public int AccumulatorUnderValue 
            {
                get => (int)CellsByName["AccumulatorUnderValue"].Value;
                set => CellsByName["AccumulatorUnderValue"].Value = (int)value;
            }
            

            // Def="s32 accumuVal"
            /// <summary>
            /// Accumulator - Increment Value (s32)
            /// </summary>
            /// <remarks>
            /// Genkitama accumulation value
            /// </remarks>
            public int AccumulatorIncrementValue 
            {
                get => (int)CellsByName["AccumulatorIncrementValue"].Value;
                set => CellsByName["AccumulatorIncrementValue"].Value = (int)value;
            }
            

            // Def="u8 eye_angX"
            /// <summary>
            /// Vision - Overwrite Height Angle (u8)
            /// </summary>
            /// <remarks>
            /// Override the findability angle x
            /// </remarks>
            public byte VisionOverwriteHeightAngle 
            {
                get => (byte)CellsByName["VisionOverwriteHeightAngle"].Value;
                set => CellsByName["VisionOverwriteHeightAngle"].Value = (byte)value;
            }
            

            // Def="u8 eye_angY"
            /// <summary>
            /// Vision - Overwrite Width Angle (u8)
            /// </summary>
            /// <remarks>
            /// Override the findability angle y
            /// </remarks>
            public byte VisionOverwriteWidthAngle 
            {
                get => (byte)CellsByName["VisionOverwriteWidthAngle"].Value;
                set => CellsByName["VisionOverwriteWidthAngle"].Value = (byte)value;
            }
            

            // Def="s16 addDeceasedLv"
            /// <summary>
            /// Add Deceased Level (s16)
            /// </summary>
            /// <remarks>
            /// Add this value to the degree of death
            /// </remarks>
            public short AddDeceasedLevel 
            {
                get => (short)CellsByName["AddDeceasedLevel"].Value;
                set => CellsByName["AddDeceasedLevel"].Value = (short)value;
            }
            

            // Def="s32 vfxId1 = -1"
            /// <summary>
            /// Effect VFX [1] (s32)
            /// </summary>
            /// <remarks>
            /// Special effect VfxId1 (-1 invalid)
            /// </remarks>
            public int EffectVFX1 
            {
                get => (int)CellsByName["EffectVFX1"].Value;
                set => CellsByName["EffectVFX1"].Value = (int)value;
            }
            

            // Def="s32 vfxId2 = -1"
            /// <summary>
            /// Effect VFX [2] (s32)
            /// </summary>
            /// <remarks>
            /// Special effect VfxId2 (-1 invalid)
            /// </remarks>
            public int EffectVFX2 
            {
                get => (int)CellsByName["EffectVFX2"].Value;
                set => CellsByName["EffectVFX2"].Value = (int)value;
            }
            

            // Def="s32 vfxId3 = -1"
            /// <summary>
            /// Effect VFX [3] (s32)
            /// </summary>
            /// <remarks>
            /// Special effect VfxId3 (-1 invalid)
            /// </remarks>
            public int EffectVFX3 
            {
                get => (int)CellsByName["EffectVFX3"].Value;
                set => CellsByName["EffectVFX3"].Value = (int)value;
            }
            

            // Def="s32 vfxId4 = -1"
            /// <summary>
            /// Effect VFX [4] (s32)
            /// </summary>
            /// <remarks>
            /// Special effect VfxId4 (-1 invalid)
            /// </remarks>
            public int EffectVFX4 
            {
                get => (int)CellsByName["EffectVFX4"].Value;
                set => CellsByName["EffectVFX4"].Value = (int)value;
            }
            

            // Def="s32 vfxId5 = -1"
            /// <summary>
            /// Effect VFX [5] (s32)
            /// </summary>
            /// <remarks>
            /// Special effect VfxId5 (-1 invalid)
            /// </remarks>
            public int EffectVFX5 
            {
                get => (int)CellsByName["EffectVFX5"].Value;
                set => CellsByName["EffectVFX5"].Value = (int)value;
            }
            

            // Def="s32 vfxId6 = -1"
            /// <summary>
            /// Effect VFX [6] (s32)
            /// </summary>
            /// <remarks>
            /// Special effect VfxId6 (-1 invalid)
            /// </remarks>
            public int EffectVFX6 
            {
                get => (int)CellsByName["EffectVFX6"].Value;
                set => CellsByName["EffectVFX6"].Value = (int)value;
            }
            

            // Def="s32 vfxId7 = -1"
            /// <summary>
            /// Effect VFX [7] (s32)
            /// </summary>
            /// <remarks>
            /// Special effect VfxId7 (-1 invalid)
            /// </remarks>
            public int EffectVFX7 
            {
                get => (int)CellsByName["EffectVFX7"].Value;
                set => CellsByName["EffectVFX7"].Value = (int)value;
            }
            

            // Def="s32 freezeAttackPower"
            /// <summary>
            /// Aux Inflict +: Frostbite (s32)
            /// </summary>
            /// <remarks>
            /// Numerical value to be added to the target [Cold air resistance value] when hit
///Requires State Info 260
            /// </remarks>
            public int AuxInflictFrostbite 
            {
                get => (int)CellsByName["AuxInflictFrostbite"].Value;
                set => CellsByName["AuxInflictFrostbite"].Value = (int)value;
            }
            

            // Def="s32 AppearAiSoundId"
            /// <summary>
            /// Generated AI Sound ID (s32)
            /// </summary>
            /// <remarks>
            /// Generates AI sound parameters with set values
            /// </remarks>
            public int GeneratedAISoundID 
            {
                get => (int)CellsByName["GeneratedAISoundID"].Value;
                set => CellsByName["GeneratedAISoundID"].Value = (int)value;
            }
            

            // Def="s16 addFootEffectSfxId = -1"
            /// <summary>
            /// Automatic Foot Effect - SFX ID Offset (s16)
            /// </summary>
            /// <remarks>
            /// The identifier of the foot effect that is additionally generated during special effects. XYYZZZ ZZZ
            /// </remarks>
            public short AutomaticFootEffectSFXIDOffset 
            {
                get => (short)CellsByName["AutomaticFootEffectSFXIDOffset"].Value;
                set => CellsByName["AutomaticFootEffectSFXIDOffset"].Value = (short)value;
            }
            

            // Def="s8 dexterityCancelSystemOnlyAddDexterity"
            /// <summary>
            /// Cast Speed + (s8)
            /// </summary>
            /// <remarks>
            /// Add this value when calculating the end timing of the TAE flag of "Skill Cancel".
            /// </remarks>
            public sbyte CastSpeed 
            {
                get => (sbyte)CellsByName["CastSpeed"].Value;
                set => CellsByName["CastSpeed"].Value = (sbyte)value;
            }
            

            // Def="s8 teamOffenseEffectivity = -1"
            /// <summary>
            /// Team Attack Effectivity (s8)
            /// </summary>
            /// <remarks>
            /// Overwrite and change the target [Team Attack Influence] value. Do not change the default value (-1).
            /// </remarks>
            public sbyte TeamAttackEffectivity 
            {
                get => (sbyte)CellsByName["TeamAttackEffectivity"].Value;
                set => CellsByName["TeamAttackEffectivity"].Value = (sbyte)value;
            }
            

            // Def="f32 toughnessDamageCutRate = 1"
            /// <summary>
            /// Toughness Absorption % (f32)
            /// </summary>
            /// <remarks>
            /// Toughness version cut rate
            /// </remarks>
            public float ToughnessAbsorptionPercent 
            {
                get => (float)CellsByName["ToughnessAbsorptionPercent"].Value;
                set => CellsByName["ToughnessAbsorptionPercent"].Value = (float)value;
            }
            

            // Def="f32 weakDmgRateA = 1"
            /// <summary>
            /// Damage Multiplier %: Type A (f32)
            /// </summary>
            /// <remarks>
            /// Special Attack A Damage multiplier is corrected. 1 is normal.
            /// </remarks>
            public float DamageMultiplierPercentTypeA 
            {
                get => (float)CellsByName["DamageMultiplierPercentTypeA"].Value;
                set => CellsByName["DamageMultiplierPercentTypeA"].Value = (float)value;
            }
            

            // Def="f32 weakDmgRateB = 1"
            /// <summary>
            /// Damage Multiplier %: Type B (f32)
            /// </summary>
            /// <remarks>
            /// Special attack B Damage multiplier is corrected. 1 is normal.
            /// </remarks>
            public float DamageMultiplierPercentTypeB 
            {
                get => (float)CellsByName["DamageMultiplierPercentTypeB"].Value;
                set => CellsByName["DamageMultiplierPercentTypeB"].Value = (float)value;
            }
            

            // Def="f32 weakDmgRateC = 1"
            /// <summary>
            /// Damage Multiplier %: Type C (f32)
            /// </summary>
            /// <remarks>
            /// Special attack C Damage multiplier is corrected. 1 is normal.
            /// </remarks>
            public float DamageMultiplierPercentTypeC 
            {
                get => (float)CellsByName["DamageMultiplierPercentTypeC"].Value;
                set => CellsByName["DamageMultiplierPercentTypeC"].Value = (float)value;
            }
            

            // Def="f32 weakDmgRateD = 1"
            /// <summary>
            /// Damage Multiplier %: Type D (f32)
            /// </summary>
            /// <remarks>
            /// Special attack D Damage multiplier is corrected. 1 is normal.
            /// </remarks>
            public float DamageMultiplierPercentTypeD 
            {
                get => (float)CellsByName["DamageMultiplierPercentTypeD"].Value;
                set => CellsByName["DamageMultiplierPercentTypeD"].Value = (float)value;
            }
            

            // Def="f32 weakDmgRateE = 1"
            /// <summary>
            /// Damage Multiplier %: Type E (f32)
            /// </summary>
            /// <remarks>
            /// Special attack E Damage multiplier is corrected. 1 is normal.
            /// </remarks>
            public float DamageMultiplierPercentTypeE 
            {
                get => (float)CellsByName["DamageMultiplierPercentTypeE"].Value;
                set => CellsByName["DamageMultiplierPercentTypeE"].Value = (float)value;
            }
            

            // Def="f32 weakDmgRateF = 1"
            /// <summary>
            /// Damage Multiplier %: Type F (f32)
            /// </summary>
            /// <remarks>
            /// Special attack F Damage multiplier is corrected. 1 is normal.
            /// </remarks>
            public float DamageMultiplierPercentTypeF 
            {
                get => (float)CellsByName["DamageMultiplierPercentTypeF"].Value;
                set => CellsByName["DamageMultiplierPercentTypeF"].Value = (float)value;
            }
            

            // Def="f32 darkDamageCutRate = 1"
            /// <summary>
            /// Absorption %: Holy (f32)
            /// </summary>
            /// <remarks>
            /// Dark damage multiplier: Correct the calculated damage by XX times. 1 is normal.
            /// </remarks>
            public float AbsorptionPercentHoly 
            {
                get => (float)CellsByName["AbsorptionPercentHoly"].Value;
                set => CellsByName["AbsorptionPercentHoly"].Value = (float)value;
            }
            

            // Def="f32 darkDiffenceRate = 1"
            /// <summary>
            /// Defence %: Holy (f32)
            /// </summary>
            /// <remarks>
            /// Multiply the darkness defense by the set value
            /// </remarks>
            public float DefencePercentHoly 
            {
                get => (float)CellsByName["DefencePercentHoly"].Value;
                set => CellsByName["DefencePercentHoly"].Value = (float)value;
            }
            

            // Def="s32 darkDiffence"
            /// <summary>
            /// Defence +: Holy (s32)
            /// </summary>
            /// <remarks>
            /// Add or subtract the value set for darkness defense
            /// </remarks>
            public int DefenceHoly 
            {
                get => (int)CellsByName["DefenceHoly"].Value;
                set => CellsByName["DefenceHoly"].Value = (int)value;
            }
            

            // Def="f32 darkAttackRate = 1"
            /// <summary>
            /// Attack %: Holy (f32)
            /// </summary>
            /// <remarks>
            /// Dark damage multiplier: Correct the calculated damage by XX times. 1 is normal.
            /// </remarks>
            public float AttackPercentHoly 
            {
                get => (float)CellsByName["AttackPercentHoly"].Value;
                set => CellsByName["AttackPercentHoly"].Value = (float)value;
            }
            

            // Def="f32 darkAttackPowerRate = 1"
            /// <summary>
            /// Power %: Holy (f32)
            /// </summary>
            /// <remarks>
            /// Multiply the dark attack power by the set value
            /// </remarks>
            public float PowerPercentHoly 
            {
                get => (float)CellsByName["PowerPercentHoly"].Value;
                set => CellsByName["PowerPercentHoly"].Value = (float)value;
            }
            

            // Def="s32 darkAttackPower"
            /// <summary>
            /// Damage +: Holy (s32)
            /// </summary>
            /// <remarks>
            /// Add or subtract the value set for the dark attack power
            /// </remarks>
            public int DamageHoly 
            {
                get => (int)CellsByName["DamageHoly"].Value;
                set => CellsByName["DamageHoly"].Value = (int)value;
            }
            

            // Def="f32 antiDarkSightRadius"
            /// <summary>
            /// Full View in Darkness - Radius (f32)
            /// </summary>
            /// <remarks>
            /// Radius of full view of darkness [m]. If you are within this distance, you will be able to see at normal distance even in the dark.
            /// </remarks>
            public float FullViewInDarknessRadius 
            {
                get => (float)CellsByName["FullViewInDarknessRadius"].Value;
                set => CellsByName["FullViewInDarknessRadius"].Value = (float)value;
            }
            

            // Def="s32 antiDarkSightDmypolyId = -1"
            /// <summary>
            /// Full View in Darkness - Dummy Poly ID (s32)
            /// </summary>
            /// <remarks>
            /// Damipoli ID (-1: Master) with full view of darkness. Create a full view area around this Damipoli
            /// </remarks>
            public int FullViewInDarknessDummyPolyID 
            {
                get => (int)CellsByName["FullViewInDarknessDummyPolyID"].Value;
                set => CellsByName["FullViewInDarknessDummyPolyID"].Value = (int)value;
            }
            

            // Def="f32 conditionHpRate = -1"
            /// <summary>
            /// Trigger on HP Above % (f32)
            /// </summary>
            /// <remarks>
            /// Activates only when you have HP above the specified value
            /// </remarks>
            public float TriggerOnHPAbovePercent 
            {
                get => (float)CellsByName["TriggerOnHPAbovePercent"].Value;
                set => CellsByName["TriggerOnHPAbovePercent"].Value = (float)value;
            }
            

            // Def="f32 consumeStaminaRate = 1"
            /// <summary>
            /// Weapon Stamina Consumption % (f32)
            /// </summary>
            /// <remarks>
            /// Multiply by multiplying the consumption stamina value of the behavior parameter
            /// </remarks>
            public float WeaponStaminaConsumptionPercent 
            {
                get => (float)CellsByName["WeaponStaminaConsumptionPercent"].Value;
                set => CellsByName["WeaponStaminaConsumptionPercent"].Value = (float)value;
            }
            

            // Def="f32 itemDropRate"
            /// <summary>
            /// Item Discovery % (f32)
            /// </summary>
            /// <remarks>
            /// The set value is added to [Item Drop Correction]
///Requires State Info 66
            /// </remarks>
            public float ItemDiscoveryPercent 
            {
                get => (float)CellsByName["ItemDiscoveryPercent"].Value;
                set => CellsByName["ItemDiscoveryPercent"].Value = (float)value;
            }
            

            // Def="s32 changePoisonResistPoint"
            /// <summary>
            /// Aux Resist +: Poison (s32)
            /// </summary>
            /// <remarks>
            /// Increase or decrease the state resistance value
            /// </remarks>
            public int AuxResistPoison 
            {
                get => (int)CellsByName["AuxResistPoison"].Value;
                set => CellsByName["AuxResistPoison"].Value = (int)value;
            }
            

            // Def="s32 changeDiseaseResistPoint"
            /// <summary>
            /// Aux Resist +: Scarlet Rot (s32)
            /// </summary>
            /// <remarks>
            /// Increase or decrease the state resistance value
            /// </remarks>
            public int AuxResistScarletRot 
            {
                get => (int)CellsByName["AuxResistScarletRot"].Value;
                set => CellsByName["AuxResistScarletRot"].Value = (int)value;
            }
            

            // Def="s32 changeBloodResistPoint"
            /// <summary>
            /// Aux Resist +: Hemorrhage (s32)
            /// </summary>
            /// <remarks>
            /// Increase or decrease the state resistance value
            /// </remarks>
            public int AuxResistHemorrhage 
            {
                get => (int)CellsByName["AuxResistHemorrhage"].Value;
                set => CellsByName["AuxResistHemorrhage"].Value = (int)value;
            }
            

            // Def="s32 changeCurseResistPoint"
            /// <summary>
            /// Aux Resist +: Blight (s32)
            /// </summary>
            /// <remarks>
            /// Increase or decrease the state resistance value
            /// </remarks>
            public int AuxResistBlight 
            {
                get => (int)CellsByName["AuxResistBlight"].Value;
                set => CellsByName["AuxResistBlight"].Value = (int)value;
            }
            

            // Def="s32 changeFreezeResistPoint"
            /// <summary>
            /// Aux Resist +: Frostbite (s32)
            /// </summary>
            /// <remarks>
            /// Increase or decrease the state resistance value
            /// </remarks>
            public int AuxResistFrostbite 
            {
                get => (int)CellsByName["AuxResistFrostbite"].Value;
                set => CellsByName["AuxResistFrostbite"].Value = (int)value;
            }
            

            // Def="f32 slashAttackRate = 1"
            /// <summary>
            /// Attack %: Slash (f32)
            /// </summary>
            /// <remarks>
            /// Slash damage ratio: Correct the calculated damage by XX times. 1 is normal.
            /// </remarks>
            public float AttackPercentSlash 
            {
                get => (float)CellsByName["AttackPercentSlash"].Value;
                set => CellsByName["AttackPercentSlash"].Value = (float)value;
            }
            

            // Def="f32 blowAttackRate = 1"
            /// <summary>
            /// Attack %: Strike (f32)
            /// </summary>
            /// <remarks>
            /// Batter damage ratio: The calculated damage is corrected by XX times. 1 is normal.
            /// </remarks>
            public float AttackPercentStrike 
            {
                get => (float)CellsByName["AttackPercentStrike"].Value;
                set => CellsByName["AttackPercentStrike"].Value = (float)value;
            }
            

            // Def="f32 thrustAttackRate = 1"
            /// <summary>
            /// Attack %: Thrust (f32)
            /// </summary>
            /// <remarks>
            /// Puncture damage ratio: Correct the calculated damage by XX times. 1 is normal.
            /// </remarks>
            public float AttackPercentThrust 
            {
                get => (float)CellsByName["AttackPercentThrust"].Value;
                set => CellsByName["AttackPercentThrust"].Value = (float)value;
            }
            

            // Def="f32 neutralAttackRate = 1"
            /// <summary>
            /// Attack %: Standard (f32)
            /// </summary>
            /// <remarks>
            /// Non-attribute damage ratio: Correct the calculated damage by XX times. 1 is normal.
            /// </remarks>
            public float AttackPercentStandard 
            {
                get => (float)CellsByName["AttackPercentStandard"].Value;
                set => CellsByName["AttackPercentStandard"].Value = (float)value;
            }
            

            // Def="f32 slashAttackPowerRate = 1"
            /// <summary>
            /// Power %: Slash (f32)
            /// </summary>
            /// <remarks>
            /// Multiply the slashing attack power by the set value
            /// </remarks>
            public float PowerPercentSlash 
            {
                get => (float)CellsByName["PowerPercentSlash"].Value;
                set => CellsByName["PowerPercentSlash"].Value = (float)value;
            }
            

            // Def="f32 blowAttackPowerRate = 1"
            /// <summary>
            /// Power %: Strike (f32)
            /// </summary>
            /// <remarks>
            /// Multiply the hit attack power by the set value
            /// </remarks>
            public float PowerPercentStrike 
            {
                get => (float)CellsByName["PowerPercentStrike"].Value;
                set => CellsByName["PowerPercentStrike"].Value = (float)value;
            }
            

            // Def="f32 thrustAttackPowerRate = 1"
            /// <summary>
            /// Power %: Thrust (f32)
            /// </summary>
            /// <remarks>
            /// Multiply the piercing attack power by the set value
            /// </remarks>
            public float PowerPercentThrust 
            {
                get => (float)CellsByName["PowerPercentThrust"].Value;
                set => CellsByName["PowerPercentThrust"].Value = (float)value;
            }
            

            // Def="f32 neutralAttackPowerRate = 1"
            /// <summary>
            /// Power %: Standard (f32)
            /// </summary>
            /// <remarks>
            /// Multiply the non-attribute attack power by the set value
            /// </remarks>
            public float PowerPercentStandard 
            {
                get => (float)CellsByName["PowerPercentStandard"].Value;
                set => CellsByName["PowerPercentStandard"].Value = (float)value;
            }
            

            // Def="s32 slashAttackPower"
            /// <summary>
            /// Damage +: Slash (s32)
            /// </summary>
            /// <remarks>
            /// Add or subtract the value set for the slashing attack power
            /// </remarks>
            public int DamageSlash 
            {
                get => (int)CellsByName["DamageSlash"].Value;
                set => CellsByName["DamageSlash"].Value = (int)value;
            }
            

            // Def="s32 blowAttackPower"
            /// <summary>
            /// Damage +: Strike (s32)
            /// </summary>
            /// <remarks>
            /// Add or subtract the value set for the batter attack power
            /// </remarks>
            public int DamageStrike 
            {
                get => (int)CellsByName["DamageStrike"].Value;
                set => CellsByName["DamageStrike"].Value = (int)value;
            }
            

            // Def="s32 thrustAttackPower"
            /// <summary>
            /// Damage +: Thrust (s32)
            /// </summary>
            /// <remarks>
            /// Add or subtract the value set for the piercing attack power
            /// </remarks>
            public int DamageThrust 
            {
                get => (int)CellsByName["DamageThrust"].Value;
                set => CellsByName["DamageThrust"].Value = (int)value;
            }
            

            // Def="s32 neutralAttackPower"
            /// <summary>
            /// Damage +: Standard (s32)
            /// </summary>
            /// <remarks>
            /// Add or subtract the value set for non-attribute attack power
            /// </remarks>
            public int DamageStandard 
            {
                get => (int)CellsByName["DamageStandard"].Value;
                set => CellsByName["DamageStandard"].Value = (int)value;
            }
            

            // Def="s32 changeStrengthPoint"
            /// <summary>
            /// Correction +: STR (s32)
            /// </summary>
            /// <remarks>
            /// Add or subtract the correction value of the weapon
            /// </remarks>
            public int CorrectionSTR 
            {
                get => (int)CellsByName["CorrectionSTR"].Value;
                set => CellsByName["CorrectionSTR"].Value = (int)value;
            }
            

            // Def="s32 changeAgilityPoint"
            /// <summary>
            /// Correction +: DEX (s32)
            /// </summary>
            /// <remarks>
            /// Add or subtract the correction value of the weapon
            /// </remarks>
            public int CorrectionDEX 
            {
                get => (int)CellsByName["CorrectionDEX"].Value;
                set => CellsByName["CorrectionDEX"].Value = (int)value;
            }
            

            // Def="s32 changeMagicPoint"
            /// <summary>
            /// Correction +: INT (s32)
            /// </summary>
            /// <remarks>
            /// Add or subtract the correction value of the weapon
            /// </remarks>
            public int CorrectionINT 
            {
                get => (int)CellsByName["CorrectionINT"].Value;
                set => CellsByName["CorrectionINT"].Value = (int)value;
            }
            

            // Def="s32 changeFaithPoint"
            /// <summary>
            /// Correction +: FTH (s32)
            /// </summary>
            /// <remarks>
            /// Add or subtract the correction value of the weapon
            /// </remarks>
            public int CorrectionFTH 
            {
                get => (int)CellsByName["CorrectionFTH"].Value;
                set => CellsByName["CorrectionFTH"].Value = (int)value;
            }
            

            // Def="s32 changeLuckPoint"
            /// <summary>
            /// Correction +: ARC (s32)
            /// </summary>
            /// <remarks>
            /// Add or subtract the correction value of the weapon
            /// </remarks>
            public int CorrectionARC 
            {
                get => (int)CellsByName["CorrectionARC"].Value;
                set => CellsByName["CorrectionARC"].Value = (int)value;
            }
            

            // Def="s8 recoverArtsPoint_Str"
            /// <summary>
            /// Weapon Art Restore: STR (s8)
            /// </summary>
            /// <remarks>
            /// Arts Point Restores strength
            /// </remarks>
            public sbyte WeaponArtRestoreSTR 
            {
                get => (sbyte)CellsByName["WeaponArtRestoreSTR"].Value;
                set => CellsByName["WeaponArtRestoreSTR"].Value = (sbyte)value;
            }
            

            // Def="s8 recoverArtsPoint_Dex"
            /// <summary>
            /// Weapon Art Restore: DEX (s8)
            /// </summary>
            /// <remarks>
            /// Restores arts point workmanship
            /// </remarks>
            public sbyte WeaponArtRestoreDEX 
            {
                get => (sbyte)CellsByName["WeaponArtRestoreDEX"].Value;
                set => CellsByName["WeaponArtRestoreDEX"].Value = (sbyte)value;
            }
            

            // Def="s8 recoverArtsPoint_Magic"
            /// <summary>
            /// Weapon Art Restore: INT (s8)
            /// </summary>
            /// <remarks>
            /// Restores arts point magic
            /// </remarks>
            public sbyte WeaponArtRestoreINT 
            {
                get => (sbyte)CellsByName["WeaponArtRestoreINT"].Value;
                set => CellsByName["WeaponArtRestoreINT"].Value = (sbyte)value;
            }
            

            // Def="s8 recoverArtsPoint_Miracle"
            /// <summary>
            /// Weapon Art Restore: FTH (s8)
            /// </summary>
            /// <remarks>
            /// Recover arts point miracles
            /// </remarks>
            public sbyte WeaponArtRestoreFTH 
            {
                get => (sbyte)CellsByName["WeaponArtRestoreFTH"].Value;
                set => CellsByName["WeaponArtRestoreFTH"].Value = (sbyte)value;
            }
            

            // Def="u8 madnessDamageRate = 100"
            /// <summary>
            /// Damage Correction %: Madness (u8)
            /// </summary>
            /// <remarks>
            /// Correction value used only for point damage and% damage of state change type [madness]
            /// </remarks>
            public byte DamageCorrectionPercentMadness 
            {
                get => (byte)CellsByName["DamageCorrectionPercentMadness"].Value;
                set => CellsByName["DamageCorrectionPercentMadness"].Value = (byte)value;
            }
            

            // Def="u8 isUseStatusAilmentAtkPowerCorrect:1"
            /// <summary>
            /// Use Status Ailment Attack Power Correction (u8)
            /// </summary>
            /// <remarks>
            /// If ○, the abnormal state attack power multiplier correction of the attack para is applied.
            /// </remarks>
            public SpEffectBool UseStatusAilmentAttackPowerCorrection 
            {
                get => (SpEffectBool)CellsByName["UseStatusAilmentAttackPowerCorrection"].Value;
                set => CellsByName["UseStatusAilmentAttackPowerCorrection"].Value = (byte)value;
            }
            

            // Def="u8 isUseAtkParamAtkPowerCorrect:1"
            /// <summary>
            /// Use AtkParam Attack Power Correction (u8)
            /// </summary>
            /// <remarks>
            /// If ○, the attack power multiplier correction of the attack para is applied.
            /// </remarks>
            public SpEffectBool UseAtkParamAttackPowerCorrection 
            {
                get => (SpEffectBool)CellsByName["UseAtkParamAttackPowerCorrection"].Value;
                set => CellsByName["UseAtkParamAttackPowerCorrection"].Value = (byte)value;
            }
            

            // Def="u8 dontDeleteOnDead:1"
            /// <summary>
            /// Don't Delete on Dead (u8)
            /// </summary>
            /// <remarks>
            /// If it is ○, it will not be deleted even if the character dies. Mainly used for death effects.
            /// </remarks>
            public SpEffectBool DonTDeleteOnDead 
            {
                get => (SpEffectBool)CellsByName["DonTDeleteOnDead"].Value;
                set => CellsByName["DonTDeleteOnDead"].Value = (byte)value;
            }
            

            // Def="u8 disableFreeze:1"
            /// <summary>
            /// Disable Frostbite (u8)
            /// </summary>
            /// <remarks>
            /// When this effect is applied, it will not be cold
            /// </remarks>
            public SpEffectBool DisableFrostbite 
            {
                get => (SpEffectBool)CellsByName["DisableFrostbite"].Value;
                set => CellsByName["DisableFrostbite"].Value = (byte)value;
            }
            

            // Def="u8 isDisableNetSync:1"
            /// <summary>
            /// Do not Sync in Multiplayer (u8)
            /// </summary>
            /// <remarks>
            /// Do not synchronize with the net. It does not mean that you will be able to call it locally, but simply do not send it online. For example, a remote character does not activate locally, so nothing happens in that case.
            /// </remarks>
            public SpEffectBool DoNotSyncInMultiplayer 
            {
                get => (SpEffectBool)CellsByName["DoNotSyncInMultiplayer"].Value;
                set => CellsByName["DoNotSyncInMultiplayer"].Value = (byte)value;
            }
            

            // Def="u8 shamanParamChange:1"
            /// <summary>
            /// Affects Pyromancy (u8)
            /// </summary>
            /// <remarks>
            /// Set whether or not it is effective against spells
            /// </remarks>
            public SpEffectBool AffectsPyromancy 
            {
                get => (SpEffectBool)CellsByName["AffectsPyromancy"].Value;
                set => CellsByName["AffectsPyromancy"].Value = (byte)value;
            }
            

            // Def="u8 isStopSearchedNotify:1"
            /// <summary>
            /// Stop Platoon Notifications (u8)
            /// </summary>
            /// <remarks>
            /// Whether to stop notifications targeting your army (used by EventMaker decisions and buddy platoons)
            /// </remarks>
            public SpEffectBool StopPlatoonNotifications 
            {
                get => (SpEffectBool)CellsByName["StopPlatoonNotifications"].Value;
                set => CellsByName["StopPlatoonNotifications"].Value = (byte)value;
            }
            

            // Def="u8 isCheckAboveShadowTest:1"
            /// <summary>
            /// Apply outside of Rain Shield (u8)
            /// </summary>
            /// <remarks>
            /// If it is ○, it will not be applied when it is judged to be shielded (× is always applied)
            /// </remarks>
            public SpEffectBool ApplyOutsideOfRainShield 
            {
                get => (SpEffectBool)CellsByName["ApplyOutsideOfRainShield"].Value;
                set => CellsByName["ApplyOutsideOfRainShield"].Value = (byte)value;
            }
            

            // Def="u16 addBehaviorJudgeId_add"
            /// <summary>
            /// Add Behavior Judgment ID - Addition Value (u16)
            /// </summary>
            /// <remarks>
            /// If the addition value of the action judgment ID is 0, the action is not switched and the action is stopped.
            /// </remarks>
            public ushort AddBehaviorJudgmentIDAdditionValue 
            {
                get => (ushort)CellsByName["AddBehaviorJudgmentIDAdditionValue"].Value;
                set => CellsByName["AddBehaviorJudgmentIDAdditionValue"].Value = (ushort)value;
            }
            

            // Def="f32 saReceiveDamageRate = 1"
            /// <summary>
            /// Absorption %: Poise Damage (f32)
            /// </summary>
            /// <remarks>
            /// Multiplier for SA damage
            /// </remarks>
            public float AbsorptionPercentPoiseDamage 
            {
                get => (float)CellsByName["AbsorptionPercentPoiseDamage"].Value;
                set => CellsByName["AbsorptionPercentPoiseDamage"].Value = (float)value;
            }
            

            // Def="f32 defPlayerDmgCorrectRate_Physics = 1"
            /// <summary>
            /// PVP Absorption %: Physical (f32)
            /// </summary>
            /// <remarks>
            /// Damage correction for the damage value received from the player.
            /// </remarks>
            public float PVPAbsorptionPercentPhysical 
            {
                get => (float)CellsByName["PVPAbsorptionPercentPhysical"].Value;
                set => CellsByName["PVPAbsorptionPercentPhysical"].Value = (float)value;
            }
            

            // Def="f32 defPlayerDmgCorrectRate_Magic = 1"
            /// <summary>
            /// PVP Absorption %: Magic (f32)
            /// </summary>
            /// <remarks>
            /// Damage correction for the damage value received from the player.
            /// </remarks>
            public float PVPAbsorptionPercentMagic 
            {
                get => (float)CellsByName["PVPAbsorptionPercentMagic"].Value;
                set => CellsByName["PVPAbsorptionPercentMagic"].Value = (float)value;
            }
            

            // Def="f32 defPlayerDmgCorrectRate_Fire = 1"
            /// <summary>
            /// PVP Absorption %: Fire (f32)
            /// </summary>
            /// <remarks>
            /// Damage correction for the damage value received from the player.
            /// </remarks>
            public float PVPAbsorptionPercentFire 
            {
                get => (float)CellsByName["PVPAbsorptionPercentFire"].Value;
                set => CellsByName["PVPAbsorptionPercentFire"].Value = (float)value;
            }
            

            // Def="f32 defPlayerDmgCorrectRate_Thunder = 1"
            /// <summary>
            /// PVP Absorption %: Lightning (f32)
            /// </summary>
            /// <remarks>
            /// Damage correction for the damage value received from the player.
            /// </remarks>
            public float PVPAbsorptionPercentLightning 
            {
                get => (float)CellsByName["PVPAbsorptionPercentLightning"].Value;
                set => CellsByName["PVPAbsorptionPercentLightning"].Value = (float)value;
            }
            

            // Def="f32 defPlayerDmgCorrectRate_Dark = 1"
            /// <summary>
            /// PVP Absorption %: Holy (f32)
            /// </summary>
            /// <remarks>
            /// Damage correction for the damage value received from the player.
            /// </remarks>
            public float PVPAbsorptionPercentHoly 
            {
                get => (float)CellsByName["PVPAbsorptionPercentHoly"].Value;
                set => CellsByName["PVPAbsorptionPercentHoly"].Value = (float)value;
            }
            

            // Def="f32 defEnemyDmgCorrectRate_Physics = 1"
            /// <summary>
            /// Absorption %: Physical (f32)
            /// </summary>
            /// <remarks>
            /// Damage correction for the damage value received from the enemy.
            /// </remarks>
            public float AbsorptionPercentPhysical 
            {
                get => (float)CellsByName["AbsorptionPercentPhysical"].Value;
                set => CellsByName["AbsorptionPercentPhysical"].Value = (float)value;
            }
            





            // Def="f32 defObjDmgCorrectRate = 1"
            /// <summary>
            /// Absorption %: Object (f32)
            /// </summary>
            /// <remarks>
            /// Damage correction for the damage value received from OBJ.
            /// </remarks>
            public float AbsorptionPercentObject 
            {
                get => (float)CellsByName["AbsorptionPercentObject"].Value;
                set => CellsByName["AbsorptionPercentObject"].Value = (float)value;
            }
            

            // Def="f32 atkPlayerDmgCorrectRate_Physics = 1"
            /// <summary>
            /// PVP Damage %: Physical (f32)
            /// </summary>
            /// <remarks>
            /// Damage correction for the damage value given to the player.
            /// </remarks>
            public float PVPDamagePercentPhysical 
            {
                get => (float)CellsByName["PVPDamagePercentPhysical"].Value;
                set => CellsByName["PVPDamagePercentPhysical"].Value = (float)value;
            }
            

            // Def="f32 atkPlayerDmgCorrectRate_Magic = 1"
            /// <summary>
            /// PVP Damage %: Magic (f32)
            /// </summary>
            /// <remarks>
            /// Damage correction for the damage value given to the player.
            /// </remarks>
            public float PVPDamagePercentMagic 
            {
                get => (float)CellsByName["PVPDamagePercentMagic"].Value;
                set => CellsByName["PVPDamagePercentMagic"].Value = (float)value;
            }
            

            // Def="f32 atkPlayerDmgCorrectRate_Fire = 1"
            /// <summary>
            /// PVP Damage %: Fire (f32)
            /// </summary>
            /// <remarks>
            /// Damage correction for the damage value given to the player.
            /// </remarks>
            public float PVPDamagePercentFire 
            {
                get => (float)CellsByName["PVPDamagePercentFire"].Value;
                set => CellsByName["PVPDamagePercentFire"].Value = (float)value;
            }
            

            // Def="f32 atkPlayerDmgCorrectRate_Thunder = 1"
            /// <summary>
            /// PVP Damage %: Lightning (f32)
            /// </summary>
            /// <remarks>
            /// Damage correction for the damage value given to the player.
            /// </remarks>
            public float PVPDamagePercentLightning 
            {
                get => (float)CellsByName["PVPDamagePercentLightning"].Value;
                set => CellsByName["PVPDamagePercentLightning"].Value = (float)value;
            }
            

            // Def="f32 atkPlayerDmgCorrectRate_Dark = 1"
            /// <summary>
            /// PVP Damage %: Holy (f32)
            /// </summary>
            /// <remarks>
            /// Damage correction for the damage value given to the player.
            /// </remarks>
            public float PVPDamagePercentHoly 
            {
                get => (float)CellsByName["PVPDamagePercentHoly"].Value;
                set => CellsByName["PVPDamagePercentHoly"].Value = (float)value;
            }
            

            // Def="f32 atkEnemyDmgCorrectRate_Physics = 1"
            /// <summary>
            /// Damage %: Physical (f32)
            /// </summary>
            /// <remarks>
            /// Damage correction for the damage value given to the enemy.
            /// </remarks>
            public float DamagePercentPhysical 
            {
                get => (float)CellsByName["DamagePercentPhysical"].Value;
                set => CellsByName["DamagePercentPhysical"].Value = (float)value;
            }
            

            // Def="f32 atkEnemyDmgCorrectRate_Magic = 1"
            /// <summary>
            /// Damage %: Magic (f32)
            /// </summary>
            /// <remarks>
            /// Damage correction for the damage value given to the enemy.
            /// </remarks>
            public float DamagePercentMagic 
            {
                get => (float)CellsByName["DamagePercentMagic"].Value;
                set => CellsByName["DamagePercentMagic"].Value = (float)value;
            }
            

            // Def="f32 atkEnemyDmgCorrectRate_Fire = 1"
            /// <summary>
            /// Damage %: Fire (f32)
            /// </summary>
            /// <remarks>
            /// Damage correction for the damage value given to the enemy.
            /// </remarks>
            public float DamagePercentFire 
            {
                get => (float)CellsByName["DamagePercentFire"].Value;
                set => CellsByName["DamagePercentFire"].Value = (float)value;
            }
            

            // Def="f32 atkEnemyDmgCorrectRate_Thunder = 1"
            /// <summary>
            /// Damage %: Lightning (f32)
            /// </summary>
            /// <remarks>
            /// Damage correction for the damage value given to the enemy.
            /// </remarks>
            public float DamagePercentLightning 
            {
                get => (float)CellsByName["DamagePercentLightning"].Value;
                set => CellsByName["DamagePercentLightning"].Value = (float)value;
            }
            

            // Def="f32 atkEnemyDmgCorrectRate_Dark = 1"
            /// <summary>
            /// Damage %: Holy (f32)
            /// </summary>
            /// <remarks>
            /// Damage correction for the damage value given to the enemy.
            /// </remarks>
            public float DamagePercentHoly 
            {
                get => (float)CellsByName["DamagePercentHoly"].Value;
                set => CellsByName["DamagePercentHoly"].Value = (float)value;
            }
            

            // Def="f32 registFreezeChangeRate = 1"
            /// <summary>
            /// Aux Resist %: Frostbite (f32)
            /// </summary>
            /// <remarks>
            /// Multiply the cold resistance value by the set magnification
            /// </remarks>
            public float AuxResistPercentFrostbite 
            {
                get => (float)CellsByName["AuxResistPercentFrostbite"].Value;
                set => CellsByName["AuxResistPercentFrostbite"].Value = (float)value;
            }
            

            // Def="u16 invocationConditionsStateChange1"
            /// <summary>
            /// Trigger on State Info [1] (u16)
            /// </summary>
            /// <remarks>
            /// Trigger condition state change type 1
            /// </remarks>
            public SpEffectType TriggerOnStateInfo1 
            {
                get => (SpEffectType)CellsByName["TriggerOnStateInfo1"].Value;
                set => CellsByName["TriggerOnStateInfo1"].Value = (ushort)value;
            }
            

            // Def="u16 invocationConditionsStateChange2"
            /// <summary>
            /// Trigger on State Info [2] (u16)
            /// </summary>
            /// <remarks>
            /// Trigger condition state change type 2
            /// </remarks>
            public SpEffectType TriggerOnStateInfo2 
            {
                get => (SpEffectType)CellsByName["TriggerOnStateInfo2"].Value;
                set => CellsByName["TriggerOnStateInfo2"].Value = (ushort)value;
            }
            

            // Def="u16 invocationConditionsStateChange3"
            /// <summary>
            /// Trigger on State Info [3] (u16)
            /// </summary>
            /// <remarks>
            /// Trigger condition state change type 3
            /// </remarks>
            public SpEffectType TriggerOnStateInfo3 
            {
                get => (SpEffectType)CellsByName["TriggerOnStateInfo3"].Value;
                set => CellsByName["TriggerOnStateInfo3"].Value = (ushort)value;
            }
            

            // Def="s16 hearingAiSoundLevel = -1"
            /// <summary>
            /// Listen - AI Sound Level (s16)
            /// </summary>
            /// <remarks>
            /// Overwrite how good your ears are
            /// </remarks>
            public short ListenAISoundLevel 
            {
                get => (short)CellsByName["ListenAISoundLevel"].Value;
                set => CellsByName["ListenAISoundLevel"].Value = (short)value;
            }
            

            // Def="f32 chrProxyHeightRate = 1"
            /// <summary>
            /// Proxy Height Capsule % (f32)
            /// </summary>
            /// <remarks>
            /// Magnification over the height of the character capsule
            /// </remarks>
            public float ProxyHeightCapsulePercent 
            {
                get => (float)CellsByName["ProxyHeightCapsulePercent"].Value;
                set => CellsByName["ProxyHeightCapsulePercent"].Value = (float)value;
            }
            

            // Def="f32 addAwarePointCorrectValue_forMe"
            /// <summary>
            /// Search Awareness - Addition Correction - Self (f32)
            /// </summary>
            /// <remarks>
            /// Search side addition correction_viewer
            /// </remarks>
            public float SearchAwarenessAdditionCorrectionSelf 
            {
                get => (float)CellsByName["SearchAwarenessAdditionCorrectionSelf"].Value;
                set => CellsByName["SearchAwarenessAdditionCorrectionSelf"].Value = (float)value;
            }
            

            // Def="f32 addAwarePointCorrectValue_forTarget"
            /// <summary>
            /// Search Awareness - Addition Correction - Target (f32)
            /// </summary>
            /// <remarks>
            /// Searching degree addition correction _ side to be seen
            /// </remarks>
            public float SearchAwarenessAdditionCorrectionTarget 
            {
                get => (float)CellsByName["SearchAwarenessAdditionCorrectionTarget"].Value;
                set => CellsByName["SearchAwarenessAdditionCorrectionTarget"].Value = (float)value;
            }
            

            // Def="f32 sightSearchEnemyAdd"
            /// <summary>
            /// Vision Search - Enemy Addition (f32)
            /// </summary>
            /// <remarks>
            /// Correct the ease of finding with a real number
            /// </remarks>
            public float VisionSearchEnemyAddition 
            {
                get => (float)CellsByName["VisionSearchEnemyAddition"].Value;
                set => CellsByName["VisionSearchEnemyAddition"].Value = (float)value;
            }
            

            // Def="f32 sightSearchAdd"
            /// <summary>
            /// Vision Search Addition (f32)
            /// </summary>
            /// <remarks>
            /// Correct the ease of finding with a real number
            /// </remarks>
            public float VisionSearchAddition 
            {
                get => (float)CellsByName["VisionSearchAddition"].Value;
                set => CellsByName["VisionSearchAddition"].Value = (float)value;
            }
            

            // Def="f32 hearingSearchAdd"
            /// <summary>
            /// Listen Search Addition (f32)
            /// </summary>
            /// <remarks>
            /// Correct the hearing of AI sounds with real numbers
            /// </remarks>
            public float ListenSearchAddition 
            {
                get => (float)CellsByName["ListenSearchAddition"].Value;
                set => CellsByName["ListenSearchAddition"].Value = (float)value;
            }
            

            // Def="f32 hearingSearchRate = 1"
            /// <summary>
            /// Listen Search Correction (f32)
            /// </summary>
            /// <remarks>
            /// Correct the audibility of AI sound by magnification
            /// </remarks>
            public float ListenSearchCorrection 
            {
                get => (float)CellsByName["ListenSearchCorrection"].Value;
                set => CellsByName["ListenSearchCorrection"].Value = (float)value;
            }
            

            // Def="f32 hearingSearchEnemyAdd"
            /// <summary>
            /// Listen Search - Enemy Addition (f32)
            /// </summary>
            /// <remarks>
            /// Correct the loudness of the emitted AI sound with a real number
            /// </remarks>
            public float ListenSearchEnemyAddition 
            {
                get => (float)CellsByName["ListenSearchEnemyAddition"].Value;
                set => CellsByName["ListenSearchEnemyAddition"].Value = (float)value;
            }
            

            // Def="f32 value_Magnification = 1"
            /// <summary>
            /// Sale Price Correction % (f32)
            /// </summary>
            /// <remarks>
            /// Sales price correction: Magnification
            /// </remarks>
            public float SalePriceCorrectionPercent 
            {
                get => (float)CellsByName["SalePriceCorrectionPercent"].Value;
                set => CellsByName["SalePriceCorrectionPercent"].Value = (float)value;
            }
            

            // Def="f32 artsConsumptionRate = 1"
            /// <summary>
            /// Skill FP Consumption % (f32)
            /// </summary>
            /// <remarks>
            /// Arts MP consumption multiplier [%]
            /// </remarks>
            public float SkillFPConsumptionPercent 
            {
                get => (float)CellsByName["SkillFPConsumptionPercent"].Value;
                set => CellsByName["SkillFPConsumptionPercent"].Value = (float)value;
            }
            

            // Def="f32 magicConsumptionRate = 1"
            /// <summary>
            /// Sorcery FP Consumption % (f32)
            /// </summary>
            /// <remarks>
            /// Magic consumption MP multiplier [%]
            /// </remarks>
            public float SorceryFPConsumptionPercent 
            {
                get => (float)CellsByName["SorceryFPConsumptionPercent"].Value;
                set => CellsByName["SorceryFPConsumptionPercent"].Value = (float)value;
            }
            

            // Def="f32 shamanConsumptionRate = 1"
            /// <summary>
            /// Pyromancy FP Consumption % (f32)
            /// </summary>
            /// <remarks>
            /// Magic consumption MP multiplier [%]
            /// </remarks>
            public float PyromancyFPConsumptionPercent 
            {
                get => (float)CellsByName["PyromancyFPConsumptionPercent"].Value;
                set => CellsByName["PyromancyFPConsumptionPercent"].Value = (float)value;
            }
            

            // Def="f32 miracleConsumptionRate = 1"
            /// <summary>
            /// Incantation FP Consumption % (f32)
            /// </summary>
            /// <remarks>
            /// Miracle consumption MP magnification [%]
            /// </remarks>
            public float IncantationFPConsumptionPercent 
            {
                get => (float)CellsByName["IncantationFPConsumptionPercent"].Value;
                set => CellsByName["IncantationFPConsumptionPercent"].Value = (float)value;
            }
            

            // Def="s32 changeHpEstusFlaskRate"
            /// <summary>
            /// HP Flask - HP Restore % (s32)
            /// </summary>
            /// <remarks>
            /// Set what percentage of the maximum HP to add (or subtract) with one activation
            /// </remarks>
            public int HPFlaskHPRestorePercent 
            {
                get => (int)CellsByName["HPFlaskHPRestorePercent"].Value;
                set => CellsByName["HPFlaskHPRestorePercent"].Value = (int)value;
            }
            

            // Def="s32 changeHpEstusFlaskPoint"
            /// <summary>
            /// HP Flask - HP Restore + (s32)
            /// </summary>
            /// <remarks>
            /// Set how many points to add (or subtract) with one activation
            /// </remarks>
            public int HPFlaskHPRestore 
            {
                get => (int)CellsByName["HPFlaskHPRestore"].Value;
                set => CellsByName["HPFlaskHPRestore"].Value = (int)value;
            }
            

            // Def="s32 changeMpEstusFlaskRate"
            /// <summary>
            /// FP Flask - FP Restore % (s32)
            /// </summary>
            /// <remarks>
            /// Set what percentage of the maximum MP to add (or subtract) with one activation
            /// </remarks>
            public int FPFlaskFPRestorePercent 
            {
                get => (int)CellsByName["FPFlaskFPRestorePercent"].Value;
                set => CellsByName["FPFlaskFPRestorePercent"].Value = (int)value;
            }
            

            // Def="s32 changeMpEstusFlaskPoint"
            /// <summary>
            /// FP Flask - FP Restore + (s32)
            /// </summary>
            /// <remarks>
            /// Set how many points to add (or subtract) with one activation
            /// </remarks>
            public int FPFlaskFPRestore 
            {
                get => (int)CellsByName["FPFlaskFPRestore"].Value;
                set => CellsByName["FPFlaskFPRestore"].Value = (int)value;
            }
            

            // Def="f32 changeHpEstusFlaskCorrectRate = 1"
            /// <summary>
            /// HP Flask - HP Restore Correction (f32)
            /// </summary>
            /// <remarks>
            /// Correct the damage amount of the HP Est bottle
            /// </remarks>
            public float HPFlaskHPRestoreCorrection 
            {
                get => (float)CellsByName["HPFlaskHPRestoreCorrection"].Value;
                set => CellsByName["HPFlaskHPRestoreCorrection"].Value = (float)value;
            }
            

            // Def="f32 changeMpEstusFlaskCorrectRate = 1"
            /// <summary>
            /// FP Flask - HP Restore Correction (f32)
            /// </summary>
            /// <remarks>
            /// Correct the damage amount of MP Est Bottle
            /// </remarks>
            public float FPFlaskHPRestoreCorrection 
            {
                get => (float)CellsByName["FPFlaskHPRestoreCorrection"].Value;
                set => CellsByName["FPFlaskHPRestoreCorrection"].Value = (float)value;
            }
            

            // Def="s32 applyIdOnGetSoul"
            /// <summary>
            /// Kill SpEffect ID (s32)
            /// </summary>
            /// <remarks>
            /// When the special effect of the state change type "HP drain" is enabled, when the enemy is defeated, the special effect ID set in the "HP drain activation special effect" of the same special effect is called (0: ignore).
            /// </remarks>
            public int KillSpEffectID 
            {
                get => (int)CellsByName["KillSpEffectID"].Value;
                set => CellsByName["KillSpEffectID"].Value = (int)value;
            }
            

            // Def="f32 extendLifeRate = 1"
            /// <summary>
            /// Extend SpEffect Duration % (f32)
            /// </summary>
            /// <remarks>
            /// Extension coefficient of state change type "life extension"
            /// </remarks>
            public float ExtendSpEffectDurationPercent 
            {
                get => (float)CellsByName["ExtendSpEffectDurationPercent"].Value;
                set => CellsByName["ExtendSpEffectDurationPercent"].Value = (float)value;
            }
            

            // Def="f32 contractLifeRate = 1"
            /// <summary>
            /// Contract SpEffect Duration % (f32)
            /// </summary>
            /// <remarks>
            /// Shortening coefficient of state change type "life shortening"
            /// </remarks>
            public float ContractSpEffectDurationPercent 
            {
                get => (float)CellsByName["ContractSpEffectDurationPercent"].Value;
                set => CellsByName["ContractSpEffectDurationPercent"].Value = (float)value;
            }
            

            // Def="f32 defObjectAttackPowerRate = 1"
            /// <summary>
            /// Object Damage % (f32)
            /// </summary>
            /// <remarks>
            /// Corrects the attack power against the damage received from OBJ. (Not damage compensation)
            /// </remarks>
            public float ObjectDamagePercent 
            {
                get => (float)CellsByName["ObjectDamagePercent"].Value;
                set => CellsByName["ObjectDamagePercent"].Value = (float)value;
            }
            

            // Def="s16 effectEndDeleteDecalGroupId = -1"
            /// <summary>
            /// Decal Deletion Group ID (s16)
            /// </summary>
            /// <remarks>
            /// When the special effect disappears (lifetime / overwritten / erased ... etc.), the paint decal is deleted if the special effect of the same group ID is not applied.
            /// </remarks>
            public short DecalDeletionGroupID 
            {
                get => (short)CellsByName["DecalDeletionGroupID"].Value;
                set => CellsByName["DecalDeletionGroupID"].Value = (short)value;
            }
            

            // Def="s8 addLifeForceStatus"
            /// <summary>
            /// Vigor (s8)
            /// </summary>
            /// <remarks>
            /// Add value to growth status
            /// </remarks>
            public sbyte Vigor 
            {
                get => (sbyte)CellsByName["Vigor"].Value;
                set => CellsByName["Vigor"].Value = (sbyte)value;
            }
            

            // Def="s8 addWillpowerStatus"
            /// <summary>
            /// Mind (s8)
            /// </summary>
            /// <remarks>
            /// Add value to growth status
            /// </remarks>
            public sbyte Mind 
            {
                get => (sbyte)CellsByName["Mind"].Value;
                set => CellsByName["Mind"].Value = (sbyte)value;
            }
            

            // Def="s8 addEndureStatus"
            /// <summary>
            /// Endurance (s8)
            /// </summary>
            /// <remarks>
            /// Add value to growth status
            /// </remarks>
            public sbyte Endurance 
            {
                get => (sbyte)CellsByName["Endurance"].Value;
                set => CellsByName["Endurance"].Value = (sbyte)value;
            }
            

            // Def="s8 addVitalityStatus"
            /// <summary>
            /// Vitality (s8)
            /// </summary>
            /// <remarks>
            /// Add value to growth status
            /// </remarks>
            public sbyte Vitality 
            {
                get => (sbyte)CellsByName["Vitality"].Value;
                set => CellsByName["Vitality"].Value = (sbyte)value;
            }
            

            // Def="s8 addStrengthStatus"
            /// <summary>
            /// Strength (s8)
            /// </summary>
            /// <remarks>
            /// Add value to growth status
            /// </remarks>
            public sbyte Strength 
            {
                get => (sbyte)CellsByName["Strength"].Value;
                set => CellsByName["Strength"].Value = (sbyte)value;
            }
            

            // Def="s8 addDexterityStatus"
            /// <summary>
            /// Dexterity (s8)
            /// </summary>
            /// <remarks>
            /// Add value to growth status
            /// </remarks>
            public sbyte Dexterity 
            {
                get => (sbyte)CellsByName["Dexterity"].Value;
                set => CellsByName["Dexterity"].Value = (sbyte)value;
            }
            

            // Def="s8 addMagicStatus"
            /// <summary>
            /// Intelligence (s8)
            /// </summary>
            /// <remarks>
            /// Add value to growth status
            /// </remarks>
            public sbyte Intelligence 
            {
                get => (sbyte)CellsByName["Intelligence"].Value;
                set => CellsByName["Intelligence"].Value = (sbyte)value;
            }
            

            // Def="s8 addFaithStatus"
            /// <summary>
            /// Faith (s8)
            /// </summary>
            /// <remarks>
            /// Add value to growth status
            /// </remarks>
            public sbyte Faith 
            {
                get => (sbyte)CellsByName["Faith"].Value;
                set => CellsByName["Faith"].Value = (sbyte)value;
            }
            

            // Def="s8 addLuckStatus"
            /// <summary>
            /// Arcane (s8)
            /// </summary>
            /// <remarks>
            /// Add value to growth status
            /// </remarks>
            public sbyte Arcane 
            {
                get => (sbyte)CellsByName["Arcane"].Value;
                set => CellsByName["Arcane"].Value = (sbyte)value;
            }
            

            // Def="u8 deleteCriteriaDamage"
            /// <summary>
            /// Delete Criteria Damage (u8)
            /// </summary>
            /// <remarks>
            /// Reason for damage under the condition to remove special effects
            /// </remarks>
            public SpEffectParamDeleteDamageType DeleteCriteriaDamage 
            {
                get => (SpEffectParamDeleteDamageType)CellsByName["DeleteCriteriaDamage"].Value;
                set => CellsByName["DeleteCriteriaDamage"].Value = (byte)value;
            }
            

            // Def="u8 magicSubCategoryChange3"
            /// <summary>
            /// Conditional Category [3] (u8)
            /// </summary>
            /// <remarks>
            /// Vs to subcategory parameter change 3
            /// </remarks>
            public AtkSubCategory ConditionalCategory3 
            {
                get => (AtkSubCategory)CellsByName["ConditionalCategory3"].Value;
                set => CellsByName["ConditionalCategory3"].Value = (byte)value;
            }
            

            // Def="u8 spAttributeVariationValue"
            /// <summary>
            /// SpEffect Attribute Variation Value (u8)
            /// </summary>
            /// <remarks>
            /// This value is used to give variation to abnormal state SFX, SE, etc. in combination with the special attribute set for the special effect. SEQ16473
            /// </remarks>
            public byte SpEffectAttributeVariationValue 
            {
                get => (byte)CellsByName["SpEffectAttributeVariationValue"].Value;
                set => CellsByName["SpEffectAttributeVariationValue"].Value = (byte)value;
            }
            

            // Def="u8 atkFlickPower"
            /// <summary>
            /// Weapon Repel Power + (u8)
            /// </summary>
            /// <remarks>
            /// Set a value that overwrites the repelling attack power
            /// </remarks>
            public byte WeaponRepelPower 
            {
                get => (byte)CellsByName["WeaponRepelPower"].Value;
                set => CellsByName["WeaponRepelPower"].Value = (byte)value;
            }
            

            // Def="u8 wetConditionDepth"
            /// <summary>
            /// Wet Condition Depth (u8)
            /// </summary>
            /// <remarks>
            /// TimeAct Determines whether special effects are applied in combination with "at what water level you get wet"
            /// </remarks>
            public SpEffectWetConditionDepth WetConditionDepth 
            {
                get => (SpEffectWetConditionDepth)CellsByName["WetConditionDepth"].Value;
                set => CellsByName["WetConditionDepth"].Value = (byte)value;
            }
            

            // Def="f32 changeSaRecoveryVelocity = 1"
            /// <summary>
            /// Poise Recovery Time % (f32)
            /// </summary>
            /// <remarks>
            /// Change the recovery speed of SA durability
            /// </remarks>
            public float PoiseRecoveryTimePercent 
            {
                get => (float)CellsByName["PoiseRecoveryTimePercent"].Value;
                set => CellsByName["PoiseRecoveryTimePercent"].Value = (float)value;
            }
            

            // Def="f32 regainRate = 1"
            /// <summary>
            /// Regain Correction % (f32)
            /// </summary>
            /// <remarks>
            /// Regain magnification
            /// </remarks>
            public float RegainCorrectionPercent 
            {
                get => (float)CellsByName["RegainCorrectionPercent"].Value;
                set => CellsByName["RegainCorrectionPercent"].Value = (float)value;
            }
            

            // Def="f32 saAttackPowerRate = 1"
            /// <summary>
            /// Poise Damage % (f32)
            /// </summary>
            /// <remarks>
            /// SA attack power multiplier
            /// </remarks>
            public float PoiseDamagePercent 
            {
                get => (float)CellsByName["PoiseDamagePercent"].Value;
                set => CellsByName["PoiseDamagePercent"].Value = (float)value;
            }
            

            // Def="s32 sleepAttackPower"
            /// <summary>
            /// Aux Inflict +: Sleep (s32)
            /// </summary>
            /// <remarks>
            /// Numerical value to be added to the target's [Sleep tolerance] when hit
            /// </remarks>
            public int AuxInflictSleep 
            {
                get => (int)CellsByName["AuxInflictSleep"].Value;
                set => CellsByName["AuxInflictSleep"].Value = (int)value;
            }
            

            // Def="s32 madnessAttackPower"
            /// <summary>
            /// Aux Inflict +: Madness (s32)
            /// </summary>
            /// <remarks>
            /// A number to be added to the target's [madness resistance value] when it hits
            /// </remarks>
            public int AuxInflictMadness 
            {
                get => (int)CellsByName["AuxInflictMadness"].Value;
                set => CellsByName["AuxInflictMadness"].Value = (int)value;
            }
            

            // Def="f32 registSleepChangeRate = 1"
            /// <summary>
            /// Aux Resist %: Sleep (f32)
            /// </summary>
            /// <remarks>
            /// Multiply the sleep tolerance value by the set magnification
            /// </remarks>
            public float AuxResistPercentSleep 
            {
                get => (float)CellsByName["AuxResistPercentSleep"].Value;
                set => CellsByName["AuxResistPercentSleep"].Value = (float)value;
            }
            

            // Def="f32 registMadnessChangeRate = 1"
            /// <summary>
            /// Aux Resist %: Madness (f32)
            /// </summary>
            /// <remarks>
            /// Multiply the madness resistance value by the set multiplier
            /// </remarks>
            public float AuxResistPercentMadness 
            {
                get => (float)CellsByName["AuxResistPercentMadness"].Value;
                set => CellsByName["AuxResistPercentMadness"].Value = (float)value;
            }
            

            // Def="s32 changeSleepResistPoint"
            /// <summary>
            /// Aux Resist +: Sleep (s32)
            /// </summary>
            /// <remarks>
            /// Increase or decrease the state resistance value
            /// </remarks>
            public int AuxResistSleep 
            {
                get => (int)CellsByName["AuxResistSleep"].Value;
                set => CellsByName["AuxResistSleep"].Value = (int)value;
            }
            

            // Def="s32 changeMadnessResistPoint"
            /// <summary>
            /// Aux Resist +: Madness (s32)
            /// </summary>
            /// <remarks>
            /// Increase or decrease the state resistance value
            /// </remarks>
            public int AuxResistMadness 
            {
                get => (int)CellsByName["AuxResistMadness"].Value;
                set => CellsByName["AuxResistMadness"].Value = (int)value;
            }
            

            // Def="u8 sleepDamageRate = 100"
            /// <summary>
            /// Damage Correction %: Sleep (u8)
            /// </summary>
            /// <remarks>
            /// Point damage of state change type [Sleep], correction value used only when% damage
            /// </remarks>
            public byte DamageCorrectionPercentSleep 
            {
                get => (byte)CellsByName["DamageCorrectionPercentSleep"].Value;
                set => CellsByName["DamageCorrectionPercentSleep"].Value = (byte)value;
            }
            

            // Def="u8 applyPartsGroup"
            /// <summary>
            /// Apply Parts Group (u8)
            /// </summary>
            /// <remarks>
            /// The effect is limited by the part where the attack hits. Only defensive items in damage calculation are subject to restriction
            /// </remarks>
            public SpEffectApplyPartsGroup ApplyPartsGroup 
            {
                get => (SpEffectApplyPartsGroup)CellsByName["ApplyPartsGroup"].Value;
                set => CellsByName["ApplyPartsGroup"].Value = (byte)value;
            }
            

            // Def="u8 clearTarget:1"
            /// <summary>
            /// Clear Target (u8)
            /// </summary>
            /// <remarks>
            /// Does not recognize the target while the special effect is applied (excluding the riding target)
            /// </remarks>
            public SpEffectBool ClearTarget 
            {
                get => (SpEffectBool)CellsByName["ClearTarget"].Value;
                set => CellsByName["ClearTarget"].Value = (byte)value;
            }
            

            // Def="u8 fakeTargetIgnoreAjin:1"
            /// <summary>
            /// Ignore Fake Target - Human (u8)
            /// </summary>
            /// <remarks>
            /// You will not be caught by the fake target of the subhuman system that occurred
            /// </remarks>
            public SpEffectBool IgnoreFakeTargetHuman 
            {
                get => (SpEffectBool)CellsByName["IgnoreFakeTargetHuman"].Value;
                set => CellsByName["IgnoreFakeTargetHuman"].Value = (byte)value;
            }
            

            // Def="u8 fakeTargetIgnoreMirageArts:1"
            /// <summary>
            /// Ignore Fake Target - Phantom (u8)
            /// </summary>
            /// <remarks>
            /// You will not be caught by the fake target of the phantom arts system that occurred
            /// </remarks>
            public SpEffectBool IgnoreFakeTargetPhantom 
            {
                get => (SpEffectBool)CellsByName["IgnoreFakeTargetPhantom"].Value;
                set => CellsByName["IgnoreFakeTargetPhantom"].Value = (byte)value;
            }
            

            // Def="u8 requestForceJoinBlackSOS_B:1"
            /// <summary>
            /// Force Invasion (u8)
            /// </summary>
            /// <remarks>
            /// If checked, issue an intrusion_B request when activated
            /// </remarks>
            public SpEffectBool ForceInvasion 
            {
                get => (SpEffectBool)CellsByName["ForceInvasion"].Value;
                set => CellsByName["ForceInvasion"].Value = (byte)value;
            }
            

            // Def="u8 unk353_4:1"
            /// <summary>
            /// Blank (u8)
            /// </summary>
            /// <remarks>
            /// 
            /// </remarks>
            public SpEffectBool Blank 
            {
                get => (SpEffectBool)CellsByName["Blank"].Value;
                set => CellsByName["Blank"].Value = (byte)value;
            }
            

            // Def="dummy8 pad2[1]"
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
            

            // Def="f32 changeSuperArmorPoint"
            /// <summary>
            /// Poise + (f32)
            /// </summary>
            /// <remarks>
            /// Value to add to the super armor value
            /// </remarks>
            public float Poise 
            {
                get => (float)CellsByName["Poise"].Value;
                set => CellsByName["Poise"].Value = (float)value;
            }
            

            // Def="f32 changeSaPoint"
            /// <summary>
            /// Apply Poise Damage + (f32)
            /// </summary>
            /// <remarks>
            /// Set how many points to subtract (or add) with one activation
            /// </remarks>
            public float ApplyPoiseDamage 
            {
                get => (float)CellsByName["ApplyPoiseDamage"].Value;
                set => CellsByName["ApplyPoiseDamage"].Value = (float)value;
            }
            

            // Def="f32 hugeEnemyPickupHeightOverwrite"
            /// <summary>
            /// Giant Enemy Height Overwrite (f32)
            /// </summary>
            /// <remarks>
            /// Giant enemy lift height overwrite [m]
            /// </remarks>
            public float GiantEnemyHeightOverwrite 
            {
                get => (float)CellsByName["GiantEnemyHeightOverwrite"].Value;
                set => CellsByName["GiantEnemyHeightOverwrite"].Value = (float)value;
            }
            

            // Def="f32 poisonDefDamageRate = 1"
            /// <summary>
            /// Aux Damage Correction %: Poison (f32)
            /// </summary>
            /// <remarks>
            /// Poison resistance damage ratio: Correct the calculated damage by XX times. 1 is normal.
            /// </remarks>
            public float AuxDamageCorrectionPercentPoison 
            {
                get => (float)CellsByName["AuxDamageCorrectionPercentPoison"].Value;
                set => CellsByName["AuxDamageCorrectionPercentPoison"].Value = (float)value;
            }
            

            // Def="f32 diseaseDefDamageRate = 1"
            /// <summary>
            /// Aux Damage Correction %: Scarlet Rot (f32)
            /// </summary>
            /// <remarks>
            /// Epidemic resistance damage ratio: Correct the calculated damage by XX times. 1 is normal.
            /// </remarks>
            public float AuxDamageCorrectionPercentScarletRot 
            {
                get => (float)CellsByName["AuxDamageCorrectionPercentScarletRot"].Value;
                set => CellsByName["AuxDamageCorrectionPercentScarletRot"].Value = (float)value;
            }
            

            // Def="f32 bloodDefDamageRate = 1"
            /// <summary>
            /// Aux Damage Correction %: Hemorrhage (f32)
            /// </summary>
            /// <remarks>
            /// Bleeding resistance damage ratio: Correct the calculated damage by XX times. 1 is normal.
            /// </remarks>
            public float AuxDamageCorrectionPercentHemorrhage 
            {
                get => (float)CellsByName["AuxDamageCorrectionPercentHemorrhage"].Value;
                set => CellsByName["AuxDamageCorrectionPercentHemorrhage"].Value = (float)value;
            }
            

            // Def="f32 curseDefDamageRate = 1"
            /// <summary>
            /// Aux Damage Correction %: Blight (f32)
            /// </summary>
            /// <remarks>
            /// Curse resistance damage multiplier: Corrects the calculated damage by XX times. 1 is normal.
            /// </remarks>
            public float AuxDamageCorrectionPercentBlight 
            {
                get => (float)CellsByName["AuxDamageCorrectionPercentBlight"].Value;
                set => CellsByName["AuxDamageCorrectionPercentBlight"].Value = (float)value;
            }
            

            // Def="f32 freezeDefDamageRate = 1"
            /// <summary>
            /// Aux Damage Correction %: Frostbite (f32)
            /// </summary>
            /// <remarks>
            /// Cold resistance damage ratio: Correct the calculated damage by XX times. 1 is normal.
            /// </remarks>
            public float AuxDamageCorrectionPercentFrostbite 
            {
                get => (float)CellsByName["AuxDamageCorrectionPercentFrostbite"].Value;
                set => CellsByName["AuxDamageCorrectionPercentFrostbite"].Value = (float)value;
            }
            

            // Def="f32 sleepDefDamageRate = 1"
            /// <summary>
            /// Aux Damage Correction %: Sleep (f32)
            /// </summary>
            /// <remarks>
            /// Sleep resistance damage ratio: Correct the calculated damage by XX times. 1 is normal.
            /// </remarks>
            public float AuxDamageCorrectionPercentSleep 
            {
                get => (float)CellsByName["AuxDamageCorrectionPercentSleep"].Value;
                set => CellsByName["AuxDamageCorrectionPercentSleep"].Value = (float)value;
            }
            

            // Def="f32 madnessDefDamageRate = 1"
            /// <summary>
            /// Aux Damage Correction %: Madness (f32)
            /// </summary>
            /// <remarks>
            /// Madness resistance damage multiplier: Correct the calculated damage by XX times. 1 is normal.
            /// </remarks>
            public float AuxDamageCorrectionPercentMadness 
            {
                get => (float)CellsByName["AuxDamageCorrectionPercentMadness"].Value;
                set => CellsByName["AuxDamageCorrectionPercentMadness"].Value = (float)value;
            }
            

            // Def="u16 overwrite_maxBackhomeDist"
            /// <summary>
            /// Override - Max Back Home Distance (u16)
            /// </summary>
            /// <remarks>
            /// Distance to go home no matter what [m] _ overwrite
            /// </remarks>
            public ushort OverrideMaxBackHomeDistance 
            {
                get => (ushort)CellsByName["OverrideMaxBackHomeDistance"].Value;
                set => CellsByName["OverrideMaxBackHomeDistance"].Value = (ushort)value;
            }
            

            // Def="u16 overwrite_backhomeDist"
            /// <summary>
            /// Override - Back Home Distance (u16)
            /// </summary>
            /// <remarks>
            /// Distance to return home while fighting [m] _ Overwrite
            /// </remarks>
            public ushort OverrideBackHomeDistance 
            {
                get => (ushort)CellsByName["OverrideBackHomeDistance"].Value;
                set => CellsByName["OverrideBackHomeDistance"].Value = (ushort)value;
            }
            

            // Def="u16 overwrite_backhomeBattleDist"
            /// <summary>
            /// Override - Back Home Battle Distance (u16)
            /// </summary>
            /// <remarks>
            /// Distance to give up and fight to return to the nest [m] _ overwrite
            /// </remarks>
            public ushort OverrideBackHomeBattleDistance 
            {
                get => (ushort)CellsByName["OverrideBackHomeBattleDistance"].Value;
                set => CellsByName["OverrideBackHomeBattleDistance"].Value = (ushort)value;
            }
            

            // Def="u16 overwrite_BackHome_LookTargetDist"
            /// <summary>
            /// Override - Look Target Distance (u16)
            /// </summary>
            /// <remarks>
            /// When returning home: Distance to see the target [m] _ Overwrite
            /// </remarks>
            public ushort OverrideLookTargetDistance 
            {
                get => (ushort)CellsByName["OverrideLookTargetDistance"].Value;
                set => CellsByName["OverrideLookTargetDistance"].Value = (ushort)value;
            }
            

            // Def="f32 goodsConsumptionRate = 1"
            /// <summary>
            /// Item FP Consumption % (f32)
            /// </summary>
            /// <remarks>
            /// Item consumption MP multiplier
            /// </remarks>
            public float ItemFPConsumptionPercent 
            {
                get => (float)CellsByName["ItemFPConsumptionPercent"].Value;
                set => CellsByName["ItemFPConsumptionPercent"].Value = (float)value;
            }
            

                }
            }
            

            namespace StronglyTypedParams
            {
                // CLEAR_COUNT_CORRECT_PARAM_ST
                public class ClearCountCorrectParam : ParamRow
                {
                    public ClearCountCorrectParam() : base()
                    {
                    }
            

            // Def="f32 MaxHpRate = 1"
            /// <summary>
            /// Max HP % (f32)
            /// </summary>
            /// <remarks>
            /// Maximum HP magnification [%]
            /// </remarks>
            public float MaxHPPercent 
            {
                get => (float)CellsByName["MaxHPPercent"].Value;
                set => CellsByName["MaxHPPercent"].Value = (float)value;
            }
            

            // Def="f32 MaxMpRate = 1"
            /// <summary>
            /// Max FP % (f32)
            /// </summary>
            /// <remarks>
            /// Maximum MP magnification [%]
            /// </remarks>
            public float MaxFPPercent 
            {
                get => (float)CellsByName["MaxFPPercent"].Value;
                set => CellsByName["MaxFPPercent"].Value = (float)value;
            }
            

            // Def="f32 MaxStaminaRate = 1"
            /// <summary>
            /// Max Stamina % (f32)
            /// </summary>
            /// <remarks>
            /// Maximum stamina magnification [%]
            /// </remarks>
            public float MaxStaminaPercent 
            {
                get => (float)CellsByName["MaxStaminaPercent"].Value;
                set => CellsByName["MaxStaminaPercent"].Value = (float)value;
            }
            

            // Def="f32 PhysicsAttackRate = 1"
            /// <summary>
            /// Damage %: Physical (f32)
            /// </summary>
            /// <remarks>
            /// Physical attack power multiplier
            /// </remarks>
            public float DamagePercentPhysical 
            {
                get => (float)CellsByName["DamagePercentPhysical"].Value;
                set => CellsByName["DamagePercentPhysical"].Value = (float)value;
            }
            

            // Def="f32 SlashAttackRate = 1"
            /// <summary>
            /// Damage %: Slash (f32)
            /// </summary>
            /// <remarks>
            /// Slash attack power multiplier
            /// </remarks>
            public float DamagePercentSlash 
            {
                get => (float)CellsByName["DamagePercentSlash"].Value;
                set => CellsByName["DamagePercentSlash"].Value = (float)value;
            }
            

            // Def="f32 BlowAttackRate = 1"
            /// <summary>
            /// Damage %: Strike (f32)
            /// </summary>
            /// <remarks>
            /// Batter attack power multiplier
            /// </remarks>
            public float DamagePercentStrike 
            {
                get => (float)CellsByName["DamagePercentStrike"].Value;
                set => CellsByName["DamagePercentStrike"].Value = (float)value;
            }
            

            // Def="f32 ThrustAttackRate = 1"
            /// <summary>
            /// Damage %: Thrust (f32)
            /// </summary>
            /// <remarks>
            /// Puncture attack power multiplier
            /// </remarks>
            public float DamagePercentThrust 
            {
                get => (float)CellsByName["DamagePercentThrust"].Value;
                set => CellsByName["DamagePercentThrust"].Value = (float)value;
            }
            

            // Def="f32 NeturalAttackRate = 1"
            /// <summary>
            /// Damage %: Standard (f32)
            /// </summary>
            /// <remarks>
            /// Non-attribute attack power multiplier
            /// </remarks>
            public float DamagePercentStandard 
            {
                get => (float)CellsByName["DamagePercentStandard"].Value;
                set => CellsByName["DamagePercentStandard"].Value = (float)value;
            }
            

            // Def="f32 MagicAttackRate = 1"
            /// <summary>
            /// Damage %: Magic (f32)
            /// </summary>
            /// <remarks>
            /// Magic attack power multiplier
            /// </remarks>
            public float DamagePercentMagic 
            {
                get => (float)CellsByName["DamagePercentMagic"].Value;
                set => CellsByName["DamagePercentMagic"].Value = (float)value;
            }
            

            // Def="f32 FireAttackRate = 1"
            /// <summary>
            /// Damage %: Fire (f32)
            /// </summary>
            /// <remarks>
            /// Fire attack power multiplier
            /// </remarks>
            public float DamagePercentFire 
            {
                get => (float)CellsByName["DamagePercentFire"].Value;
                set => CellsByName["DamagePercentFire"].Value = (float)value;
            }
            

            // Def="f32 ThunderAttackRate = 1"
            /// <summary>
            /// Damage %: Lightning (f32)
            /// </summary>
            /// <remarks>
            /// Electric shock attack power multiplier
            /// </remarks>
            public float DamagePercentLightning 
            {
                get => (float)CellsByName["DamagePercentLightning"].Value;
                set => CellsByName["DamagePercentLightning"].Value = (float)value;
            }
            

            // Def="f32 DarkAttackRate = 1"
            /// <summary>
            /// Damage %: Holy (f32)
            /// </summary>
            /// <remarks>
            /// Dark attack power multiplier
            /// </remarks>
            public float DamagePercentHoly 
            {
                get => (float)CellsByName["DamagePercentHoly"].Value;
                set => CellsByName["DamagePercentHoly"].Value = (float)value;
            }
            

            // Def="f32 PhysicsDefenseRate = 1"
            /// <summary>
            /// Defence %: Physical (f32)
            /// </summary>
            /// <remarks>
            /// Physical defense power multiplier
            /// </remarks>
            public float DefencePercentPhysical 
            {
                get => (float)CellsByName["DefencePercentPhysical"].Value;
                set => CellsByName["DefencePercentPhysical"].Value = (float)value;
            }
            

            // Def="f32 MagicDefenseRate = 1"
            /// <summary>
            /// Defence %: Magic (f32)
            /// </summary>
            /// <remarks>
            /// Magic defense multiplier
            /// </remarks>
            public float DefencePercentMagic 
            {
                get => (float)CellsByName["DefencePercentMagic"].Value;
                set => CellsByName["DefencePercentMagic"].Value = (float)value;
            }
            

            // Def="f32 FireDefenseRate = 1"
            /// <summary>
            /// Defence %: Fire (f32)
            /// </summary>
            /// <remarks>
            /// Fire defense multiplier
            /// </remarks>
            public float DefencePercentFire 
            {
                get => (float)CellsByName["DefencePercentFire"].Value;
                set => CellsByName["DefencePercentFire"].Value = (float)value;
            }
            

            // Def="f32 ThunderDefenseRate = 1"
            /// <summary>
            /// Defence %: Lightning (f32)
            /// </summary>
            /// <remarks>
            /// Electric shock defense power multiplier
            /// </remarks>
            public float DefencePercentLightning 
            {
                get => (float)CellsByName["DefencePercentLightning"].Value;
                set => CellsByName["DefencePercentLightning"].Value = (float)value;
            }
            

            // Def="f32 DarkDefenseRate = 1"
            /// <summary>
            /// Defence %: Holy (f32)
            /// </summary>
            /// <remarks>
            /// Dark defense multiplier
            /// </remarks>
            public float DefencePercentHoly 
            {
                get => (float)CellsByName["DefencePercentHoly"].Value;
                set => CellsByName["DefencePercentHoly"].Value = (float)value;
            }
            

            // Def="f32 StaminaAttackRate = 1"
            /// <summary>
            /// Damage %: Stamina (f32)
            /// </summary>
            /// <remarks>
            /// Stamina attack power multiplier
            /// </remarks>
            public float DamagePercentStamina 
            {
                get => (float)CellsByName["DamagePercentStamina"].Value;
                set => CellsByName["DamagePercentStamina"].Value = (float)value;
            }
            

            // Def="f32 SoulRate = 1"
            /// <summary>
            /// Rune Multiplier (f32)
            /// </summary>
            /// <remarks>
            /// Possession soul rate
            /// </remarks>
            public float RuneMultiplier 
            {
                get => (float)CellsByName["RuneMultiplier"].Value;
                set => CellsByName["RuneMultiplier"].Value = (float)value;
            }
            

            // Def="f32 PoisionResistRate = 1"
            /// <summary>
            /// Resist %: Poison (f32)
            /// </summary>
            /// <remarks>
            /// Poison resistance change rate
            /// </remarks>
            public float ResistPercentPoison 
            {
                get => (float)CellsByName["ResistPercentPoison"].Value;
                set => CellsByName["ResistPercentPoison"].Value = (float)value;
            }
            

            // Def="f32 DiseaseResistRate = 1"
            /// <summary>
            /// Resist %: Scarlet Rot (f32)
            /// </summary>
            /// <remarks>
            /// Epidemic resistance change rate
            /// </remarks>
            public float ResistPercentScarletRot 
            {
                get => (float)CellsByName["ResistPercentScarletRot"].Value;
                set => CellsByName["ResistPercentScarletRot"].Value = (float)value;
            }
            

            // Def="f32 BloodResistRate = 1"
            /// <summary>
            /// Resist %: Hemorrhage (f32)
            /// </summary>
            /// <remarks>
            /// Bleeding resistance change rate
            /// </remarks>
            public float ResistPercentHemorrhage 
            {
                get => (float)CellsByName["ResistPercentHemorrhage"].Value;
                set => CellsByName["ResistPercentHemorrhage"].Value = (float)value;
            }
            

            // Def="f32 CurseResistRate = 1"
            /// <summary>
            /// Resist %: Blight (f32)
            /// </summary>
            /// <remarks>
            /// Curse resistance change rate
            /// </remarks>
            public float ResistPercentBlight 
            {
                get => (float)CellsByName["ResistPercentBlight"].Value;
                set => CellsByName["ResistPercentBlight"].Value = (float)value;
            }
            

            // Def="f32 FreezeResistRate = 1"
            /// <summary>
            /// Resist %: Frostbite (f32)
            /// </summary>
            /// <remarks>
            /// Cold resistance change rate
            /// </remarks>
            public float ResistPercentFrostbite 
            {
                get => (float)CellsByName["ResistPercentFrostbite"].Value;
                set => CellsByName["ResistPercentFrostbite"].Value = (float)value;
            }
            

            // Def="f32 BloodDamageRate = 1"
            /// <summary>
            /// Damage %: Hemorrhage (f32)
            /// </summary>
            /// <remarks>
            /// Bleeding damage correction factor
            /// </remarks>
            public float DamagePercentHemorrhage 
            {
                get => (float)CellsByName["DamagePercentHemorrhage"].Value;
                set => CellsByName["DamagePercentHemorrhage"].Value = (float)value;
            }
            

            // Def="f32 SuperArmorDamageRate = 1"
            /// <summary>
            /// Damage %: Poise (f32)
            /// </summary>
            /// <remarks>
            /// SA damage correction factor
            /// </remarks>
            public float DamagePercentPoise 
            {
                get => (float)CellsByName["DamagePercentPoise"].Value;
                set => CellsByName["DamagePercentPoise"].Value = (float)value;
            }
            

            // Def="f32 FreezeDamageRate = 1"
            /// <summary>
            /// Damage %: Frostbite (f32)
            /// </summary>
            /// <remarks>
            /// Cold damage correction factor
            /// </remarks>
            public float DamagePercentFrostbite 
            {
                get => (float)CellsByName["DamagePercentFrostbite"].Value;
                set => CellsByName["DamagePercentFrostbite"].Value = (float)value;
            }
            

            // Def="f32 SleepResistRate = 1"
            /// <summary>
            /// Resist %: Sleep (f32)
            /// </summary>
            /// <remarks>
            /// Sleep tolerance change rate
            /// </remarks>
            public float ResistPercentSleep 
            {
                get => (float)CellsByName["ResistPercentSleep"].Value;
                set => CellsByName["ResistPercentSleep"].Value = (float)value;
            }
            

            // Def="f32 MadnessResistRate = 1"
            /// <summary>
            /// Resist %: Madness (f32)
            /// </summary>
            /// <remarks>
            /// Madness resistance change rate
            /// </remarks>
            public float ResistPercentMadness 
            {
                get => (float)CellsByName["ResistPercentMadness"].Value;
                set => CellsByName["ResistPercentMadness"].Value = (float)value;
            }
            

            // Def="f32 SleepDamageRate = 1"
            /// <summary>
            /// Damage %: Sleep (f32)
            /// </summary>
            /// <remarks>
            /// Sleep damage correction factor
            /// </remarks>
            public float DamagePercentSleep 
            {
                get => (float)CellsByName["DamagePercentSleep"].Value;
                set => CellsByName["DamagePercentSleep"].Value = (float)value;
            }
            

            // Def="f32 MadnessDamageRate = 1"
            /// <summary>
            /// Damage %: Madness (f32)
            /// </summary>
            /// <remarks>
            /// Mad damage correction factor
            /// </remarks>
            public float DamagePercentMadness 
            {
                get => (float)CellsByName["DamagePercentMadness"].Value;
                set => CellsByName["DamagePercentMadness"].Value = (float)value;
            }
            

            // Def="dummy8 pad1[4]"
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
            
                }
            }
            

            namespace StronglyTypedParams
            {
                // TOUGHNESS_PARAM_ST
                public class ToughnessParam : ParamRow
                {
                    public ToughnessParam() : base()
                    {
                    }
            

            // Def="f32 correctionRate = 1"
            /// <summary>
            /// Toughness Correction (f32)
            /// </summary>
            /// <remarks>
            /// It is a correction magnification applied to the "toughness correction magnification" of the weapon when calculating the toughness.
            /// </remarks>
            public float ToughnessCorrection 
            {
                get => (float)CellsByName["ToughnessCorrection"].Value;
                set => CellsByName["ToughnessCorrection"].Value = (float)value;
            }
            

            // Def="u16 minToughness"
            /// <summary>
            /// Minimum Toughness (u16)
            /// </summary>
            /// <remarks>
            /// The lower limit of current toughness applied at the beginning of the toughness period. If the toughness falls below this value at the start of toughness, it will recover to this value.
            /// </remarks>
            public ushort MinimumToughness 
            {
                get => (ushort)CellsByName["MinimumToughness"].Value;
                set => CellsByName["MinimumToughness"].Value = (ushort)value;
            }
            

            // Def="u8 isNonEffectiveCorrectionForMin"
            /// <summary>
            /// Minimum Toughness not affected by Toughness Multiplier (u8)
            /// </summary>
            /// <remarks>
            /// The toughness correction factor will no longer be applied to the minimum toughness.
            /// </remarks>
            public byte MinimumToughnessNotAffectedByToughnessMultiplier 
            {
                get => (byte)CellsByName["MinimumToughnessNotAffectedByToughnessMultiplier"].Value;
                set => CellsByName["MinimumToughnessNotAffectedByToughnessMultiplier"].Value = (byte)value;
            }
            

            // Def="dummy8 pad2[1]"
            /// <summary>
            /// pad (dummy8)
            /// </summary>
            /// <remarks>
            /// pad
            /// </remarks>
            public object Pad 
            {
                get => (object)CellsByName["Pad"].Value;
                set => CellsByName["Pad"].Value = (object)value;
            }
            

            // Def="s32 spEffectId = -1"
            /// <summary>
            /// Damage Level Replacement - SpEffect ID (s32)
            /// </summary>
            /// <remarks>
            /// Replacement special effect Id that takes place during the toughness period. If -1, the normal replacement rule applies. Only used by player characters
            /// </remarks>
            public int DamageLevelReplacementSpEffectID 
            {
                get => (int)CellsByName["DamageLevelReplacementSpEffectID"].Value;
                set => CellsByName["DamageLevelReplacementSpEffectID"].Value = (int)value;
            }
            

            // Def="f32 proCorrectionRate = 1"
            /// <summary>
            /// Armor - Toughness Correction (f32)
            /// </summary>
            /// <remarks>
            /// This is the correction factor applied to the "toughness correction factor" of the armor when determining the toughness.
            /// </remarks>
            public float ArmorToughnessCorrection 
            {
                get => (float)CellsByName["ArmorToughnessCorrection"].Value;
                set => CellsByName["ArmorToughnessCorrection"].Value = (float)value;
            }
            

                }
            }
            
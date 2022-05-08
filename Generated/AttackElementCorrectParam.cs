
            namespace StronglyTypedParams
            {
                // ATTACK_ELEMENT_CORRECT_PARAM_ST
                public class AttackElementCorrectParam : ParamRow
                {
                    public AttackElementCorrectParam() : base()
                    {
                    }
            

            // Def="u8 isStrengthCorrect_byPhysics:1"
            /// <summary>
            /// Physical Correction: STR (u8)
            /// </summary>
            /// <remarks>
            /// 
            /// </remarks>
            public BoolYesnoType PhysicalCorrectionSTR 
            {
                get => (BoolYesnoType)CellsByName["PhysicalCorrectionSTR"].Value;
                set => CellsByName["PhysicalCorrectionSTR"].Value = (byte)value;
            }
            

            // Def="u8 isDexterityCorrect_byPhysics:1"
            /// <summary>
            /// Physical Correction: DEX (u8)
            /// </summary>
            /// <remarks>
            /// 
            /// </remarks>
            public BoolYesnoType PhysicalCorrectionDEX 
            {
                get => (BoolYesnoType)CellsByName["PhysicalCorrectionDEX"].Value;
                set => CellsByName["PhysicalCorrectionDEX"].Value = (byte)value;
            }
            

            // Def="u8 isMagicCorrect_byPhysics:1"
            /// <summary>
            /// Physical Correction: INT (u8)
            /// </summary>
            /// <remarks>
            /// 
            /// </remarks>
            public BoolYesnoType PhysicalCorrectionINT 
            {
                get => (BoolYesnoType)CellsByName["PhysicalCorrectionINT"].Value;
                set => CellsByName["PhysicalCorrectionINT"].Value = (byte)value;
            }
            

            // Def="u8 isFaithCorrect_byPhysics:1"
            /// <summary>
            /// Physical Correction: FTH (u8)
            /// </summary>
            /// <remarks>
            /// 
            /// </remarks>
            public BoolYesnoType PhysicalCorrectionFTH 
            {
                get => (BoolYesnoType)CellsByName["PhysicalCorrectionFTH"].Value;
                set => CellsByName["PhysicalCorrectionFTH"].Value = (byte)value;
            }
            

            // Def="u8 isLuckCorrect_byPhysics:1"
            /// <summary>
            /// Physical Correction: ARC (u8)
            /// </summary>
            /// <remarks>
            /// 
            /// </remarks>
            public BoolYesnoType PhysicalCorrectionARC 
            {
                get => (BoolYesnoType)CellsByName["PhysicalCorrectionARC"].Value;
                set => CellsByName["PhysicalCorrectionARC"].Value = (byte)value;
            }
            

            // Def="u8 isStrengthCorrect_byMagic:1"
            /// <summary>
            /// Magic Correction: STR (u8)
            /// </summary>
            /// <remarks>
            /// 
            /// </remarks>
            public BoolYesnoType MagicCorrectionSTR 
            {
                get => (BoolYesnoType)CellsByName["MagicCorrectionSTR"].Value;
                set => CellsByName["MagicCorrectionSTR"].Value = (byte)value;
            }
            

            // Def="u8 isDexterityCorrect_byMagic:1"
            /// <summary>
            /// Magic Correction: DEX (u8)
            /// </summary>
            /// <remarks>
            /// 
            /// </remarks>
            public BoolYesnoType MagicCorrectionDEX 
            {
                get => (BoolYesnoType)CellsByName["MagicCorrectionDEX"].Value;
                set => CellsByName["MagicCorrectionDEX"].Value = (byte)value;
            }
            

            // Def="u8 isMagicCorrect_byMagic:1"
            /// <summary>
            /// Magic Correction: INT (u8)
            /// </summary>
            /// <remarks>
            /// 
            /// </remarks>
            public BoolYesnoType MagicCorrectionINT 
            {
                get => (BoolYesnoType)CellsByName["MagicCorrectionINT"].Value;
                set => CellsByName["MagicCorrectionINT"].Value = (byte)value;
            }
            

            // Def="u8 isFaithCorrect_byMagic:1"
            /// <summary>
            /// Magic Correction: FTH (u8)
            /// </summary>
            /// <remarks>
            /// 
            /// </remarks>
            public BoolYesnoType MagicCorrectionFTH 
            {
                get => (BoolYesnoType)CellsByName["MagicCorrectionFTH"].Value;
                set => CellsByName["MagicCorrectionFTH"].Value = (byte)value;
            }
            

            // Def="u8 isLuckCorrect_byMagic:1"
            /// <summary>
            /// Magic Correction: ARC (u8)
            /// </summary>
            /// <remarks>
            /// 
            /// </remarks>
            public BoolYesnoType MagicCorrectionARC 
            {
                get => (BoolYesnoType)CellsByName["MagicCorrectionARC"].Value;
                set => CellsByName["MagicCorrectionARC"].Value = (byte)value;
            }
            

            // Def="u8 isStrengthCorrect_byFire:1"
            /// <summary>
            /// Fire Correction: STR (u8)
            /// </summary>
            /// <remarks>
            /// 
            /// </remarks>
            public BoolYesnoType FireCorrectionSTR 
            {
                get => (BoolYesnoType)CellsByName["FireCorrectionSTR"].Value;
                set => CellsByName["FireCorrectionSTR"].Value = (byte)value;
            }
            

            // Def="u8 isDexterityCorrect_byFire:1"
            /// <summary>
            /// Fire Correction: DEX (u8)
            /// </summary>
            /// <remarks>
            /// 
            /// </remarks>
            public BoolYesnoType FireCorrectionDEX 
            {
                get => (BoolYesnoType)CellsByName["FireCorrectionDEX"].Value;
                set => CellsByName["FireCorrectionDEX"].Value = (byte)value;
            }
            

            // Def="u8 isMagicCorrect_byFire:1"
            /// <summary>
            /// Fire Correction: INT (u8)
            /// </summary>
            /// <remarks>
            /// 
            /// </remarks>
            public BoolYesnoType FireCorrectionINT 
            {
                get => (BoolYesnoType)CellsByName["FireCorrectionINT"].Value;
                set => CellsByName["FireCorrectionINT"].Value = (byte)value;
            }
            

            // Def="u8 isFaithCorrect_byFire:1"
            /// <summary>
            /// Fire Correction: FTH (u8)
            /// </summary>
            /// <remarks>
            /// 
            /// </remarks>
            public BoolYesnoType FireCorrectionFTH 
            {
                get => (BoolYesnoType)CellsByName["FireCorrectionFTH"].Value;
                set => CellsByName["FireCorrectionFTH"].Value = (byte)value;
            }
            

            // Def="u8 isLuckCorrect_byFire:1"
            /// <summary>
            /// Fire Correction: ARC (u8)
            /// </summary>
            /// <remarks>
            /// 
            /// </remarks>
            public BoolYesnoType FireCorrectionARC 
            {
                get => (BoolYesnoType)CellsByName["FireCorrectionARC"].Value;
                set => CellsByName["FireCorrectionARC"].Value = (byte)value;
            }
            

            // Def="u8 isStrengthCorrect_byThunder:1"
            /// <summary>
            /// Lightning Correction: STR (u8)
            /// </summary>
            /// <remarks>
            /// 
            /// </remarks>
            public BoolYesnoType LightningCorrectionSTR 
            {
                get => (BoolYesnoType)CellsByName["LightningCorrectionSTR"].Value;
                set => CellsByName["LightningCorrectionSTR"].Value = (byte)value;
            }
            

            // Def="u8 isDexterityCorrect_byThunder:1"
            /// <summary>
            /// Lightning Correction: DEX (u8)
            /// </summary>
            /// <remarks>
            /// 
            /// </remarks>
            public BoolYesnoType LightningCorrectionDEX 
            {
                get => (BoolYesnoType)CellsByName["LightningCorrectionDEX"].Value;
                set => CellsByName["LightningCorrectionDEX"].Value = (byte)value;
            }
            

            // Def="u8 isMagicCorrect_byThunder:1"
            /// <summary>
            /// Lightning Correction: INT (u8)
            /// </summary>
            /// <remarks>
            /// 
            /// </remarks>
            public BoolYesnoType LightningCorrectionINT 
            {
                get => (BoolYesnoType)CellsByName["LightningCorrectionINT"].Value;
                set => CellsByName["LightningCorrectionINT"].Value = (byte)value;
            }
            

            // Def="u8 isFaithCorrect_byThunder:1"
            /// <summary>
            /// Lightning Correction: FTH (u8)
            /// </summary>
            /// <remarks>
            /// 
            /// </remarks>
            public BoolYesnoType LightningCorrectionFTH 
            {
                get => (BoolYesnoType)CellsByName["LightningCorrectionFTH"].Value;
                set => CellsByName["LightningCorrectionFTH"].Value = (byte)value;
            }
            

            // Def="u8 isLuckCorrect_byThunder:1"
            /// <summary>
            /// Lightning Correction: ARC (u8)
            /// </summary>
            /// <remarks>
            /// 
            /// </remarks>
            public BoolYesnoType LightningCorrectionARC 
            {
                get => (BoolYesnoType)CellsByName["LightningCorrectionARC"].Value;
                set => CellsByName["LightningCorrectionARC"].Value = (byte)value;
            }
            

            // Def="u8 isStrengthCorrect_byDark:1"
            /// <summary>
            /// Holy Correction: STR (u8)
            /// </summary>
            /// <remarks>
            /// 
            /// </remarks>
            public BoolYesnoType HolyCorrectionSTR 
            {
                get => (BoolYesnoType)CellsByName["HolyCorrectionSTR"].Value;
                set => CellsByName["HolyCorrectionSTR"].Value = (byte)value;
            }
            

            // Def="u8 isDexterityCorrect_byDark:1"
            /// <summary>
            /// Holy Correction: DEX (u8)
            /// </summary>
            /// <remarks>
            /// 
            /// </remarks>
            public BoolYesnoType HolyCorrectionDEX 
            {
                get => (BoolYesnoType)CellsByName["HolyCorrectionDEX"].Value;
                set => CellsByName["HolyCorrectionDEX"].Value = (byte)value;
            }
            

            // Def="u8 isMagicCorrect_byDark:1"
            /// <summary>
            /// Holy Correction: INT (u8)
            /// </summary>
            /// <remarks>
            /// 
            /// </remarks>
            public BoolYesnoType HolyCorrectionINT 
            {
                get => (BoolYesnoType)CellsByName["HolyCorrectionINT"].Value;
                set => CellsByName["HolyCorrectionINT"].Value = (byte)value;
            }
            

            // Def="u8 isFaithCorrect_byDark:1"
            /// <summary>
            /// Holy Correction: FTH (u8)
            /// </summary>
            /// <remarks>
            /// 
            /// </remarks>
            public BoolYesnoType HolyCorrectionFTH 
            {
                get => (BoolYesnoType)CellsByName["HolyCorrectionFTH"].Value;
                set => CellsByName["HolyCorrectionFTH"].Value = (byte)value;
            }
            

            // Def="u8 isLuckCorrect_byDark:1"
            /// <summary>
            /// Holy Correction: ARC (u8)
            /// </summary>
            /// <remarks>
            /// 
            /// </remarks>
            public BoolYesnoType HolyCorrectionARC 
            {
                get => (BoolYesnoType)CellsByName["HolyCorrectionARC"].Value;
                set => CellsByName["HolyCorrectionARC"].Value = (byte)value;
            }
            

            // Def="dummy8 pad1:7"
            /// <summary>
            /// Padding (dummy8)
            /// </summary>
            /// <remarks>
            /// 
            /// </remarks>
            public object Padding 
            {
                get => (object)CellsByName["Padding"].Value;
                set => CellsByName["Padding"].Value = (object)value;
            }
            

            // Def="s16 overwriteStrengthCorrectRate_byPhysics = -1"
            /// <summary>
            /// Physical Replacement Correction: STR (s16)
            /// </summary>
            /// <remarks>
            /// 
            /// </remarks>
            public short PhysicalReplacementCorrectionSTR 
            {
                get => (short)CellsByName["PhysicalReplacementCorrectionSTR"].Value;
                set => CellsByName["PhysicalReplacementCorrectionSTR"].Value = (short)value;
            }
            

            // Def="s16 overwriteDexterityCorrectRate_byPhysics = -1"
            /// <summary>
            /// Physical Replacement Correction: DEX (s16)
            /// </summary>
            /// <remarks>
            /// 
            /// </remarks>
            public short PhysicalReplacementCorrectionDEX 
            {
                get => (short)CellsByName["PhysicalReplacementCorrectionDEX"].Value;
                set => CellsByName["PhysicalReplacementCorrectionDEX"].Value = (short)value;
            }
            

            // Def="s16 overwriteMagicCorrectRate_byPhysics = -1"
            /// <summary>
            /// Physical Replacement Correction: INT (s16)
            /// </summary>
            /// <remarks>
            /// 
            /// </remarks>
            public short PhysicalReplacementCorrectionINT 
            {
                get => (short)CellsByName["PhysicalReplacementCorrectionINT"].Value;
                set => CellsByName["PhysicalReplacementCorrectionINT"].Value = (short)value;
            }
            

            // Def="s16 overwriteFaithCorrectRate_byPhysics = -1"
            /// <summary>
            /// Physical Replacement Correction: FTH (s16)
            /// </summary>
            /// <remarks>
            /// 
            /// </remarks>
            public short PhysicalReplacementCorrectionFTH 
            {
                get => (short)CellsByName["PhysicalReplacementCorrectionFTH"].Value;
                set => CellsByName["PhysicalReplacementCorrectionFTH"].Value = (short)value;
            }
            

            // Def="s16 overwriteLuckCorrectRate_byPhysics = -1"
            /// <summary>
            /// Physical Replacement Correction: ARC (s16)
            /// </summary>
            /// <remarks>
            /// 
            /// </remarks>
            public short PhysicalReplacementCorrectionARC 
            {
                get => (short)CellsByName["PhysicalReplacementCorrectionARC"].Value;
                set => CellsByName["PhysicalReplacementCorrectionARC"].Value = (short)value;
            }
            

            // Def="s16 overwriteStrengthCorrectRate_byMagic = -1"
            /// <summary>
            /// Magic Replacement Correction: STR (s16)
            /// </summary>
            /// <remarks>
            /// 
            /// </remarks>
            public short MagicReplacementCorrectionSTR 
            {
                get => (short)CellsByName["MagicReplacementCorrectionSTR"].Value;
                set => CellsByName["MagicReplacementCorrectionSTR"].Value = (short)value;
            }
            

            // Def="s16 overwriteDexterityCorrectRate_byMagic = -1"
            /// <summary>
            /// Magic Replacement Correction: DEX (s16)
            /// </summary>
            /// <remarks>
            /// 
            /// </remarks>
            public short MagicReplacementCorrectionDEX 
            {
                get => (short)CellsByName["MagicReplacementCorrectionDEX"].Value;
                set => CellsByName["MagicReplacementCorrectionDEX"].Value = (short)value;
            }
            

            // Def="s16 overwriteMagicCorrectRate_byMagic = -1"
            /// <summary>
            /// Magic Replacement Correction: INT (s16)
            /// </summary>
            /// <remarks>
            /// 
            /// </remarks>
            public short MagicReplacementCorrectionINT 
            {
                get => (short)CellsByName["MagicReplacementCorrectionINT"].Value;
                set => CellsByName["MagicReplacementCorrectionINT"].Value = (short)value;
            }
            

            // Def="s16 overwriteFaithCorrectRate_byMagic = -1"
            /// <summary>
            /// Magic Replacement Correction: FTH (s16)
            /// </summary>
            /// <remarks>
            /// 
            /// </remarks>
            public short MagicReplacementCorrectionFTH 
            {
                get => (short)CellsByName["MagicReplacementCorrectionFTH"].Value;
                set => CellsByName["MagicReplacementCorrectionFTH"].Value = (short)value;
            }
            

            // Def="s16 overwriteLuckCorrectRate_byMagic = -1"
            /// <summary>
            /// Magic Replacement Correction: ARC (s16)
            /// </summary>
            /// <remarks>
            /// 
            /// </remarks>
            public short MagicReplacementCorrectionARC 
            {
                get => (short)CellsByName["MagicReplacementCorrectionARC"].Value;
                set => CellsByName["MagicReplacementCorrectionARC"].Value = (short)value;
            }
            

            // Def="s16 overwriteStrengthCorrectRate_byFire = -1"
            /// <summary>
            /// Fire Replacement Correction: STR (s16)
            /// </summary>
            /// <remarks>
            /// 
            /// </remarks>
            public short FireReplacementCorrectionSTR 
            {
                get => (short)CellsByName["FireReplacementCorrectionSTR"].Value;
                set => CellsByName["FireReplacementCorrectionSTR"].Value = (short)value;
            }
            

            // Def="s16 overwriteDexterityCorrectRate_byFire = -1"
            /// <summary>
            /// Fire Replacement Correction: DEX (s16)
            /// </summary>
            /// <remarks>
            /// 
            /// </remarks>
            public short FireReplacementCorrectionDEX 
            {
                get => (short)CellsByName["FireReplacementCorrectionDEX"].Value;
                set => CellsByName["FireReplacementCorrectionDEX"].Value = (short)value;
            }
            

            // Def="s16 overwriteMagicCorrectRate_byFire = -1"
            /// <summary>
            /// Fire Replacement Correction: INT (s16)
            /// </summary>
            /// <remarks>
            /// 
            /// </remarks>
            public short FireReplacementCorrectionINT 
            {
                get => (short)CellsByName["FireReplacementCorrectionINT"].Value;
                set => CellsByName["FireReplacementCorrectionINT"].Value = (short)value;
            }
            

            // Def="s16 overwriteFaithCorrectRate_byFire = -1"
            /// <summary>
            /// Fire Replacement Correction: FTH (s16)
            /// </summary>
            /// <remarks>
            /// 
            /// </remarks>
            public short FireReplacementCorrectionFTH 
            {
                get => (short)CellsByName["FireReplacementCorrectionFTH"].Value;
                set => CellsByName["FireReplacementCorrectionFTH"].Value = (short)value;
            }
            

            // Def="s16 overwriteLuckCorrectRate_byFire = -1"
            /// <summary>
            /// Fire Replacement Correction: ARC (s16)
            /// </summary>
            /// <remarks>
            /// 
            /// </remarks>
            public short FireReplacementCorrectionARC 
            {
                get => (short)CellsByName["FireReplacementCorrectionARC"].Value;
                set => CellsByName["FireReplacementCorrectionARC"].Value = (short)value;
            }
            

            // Def="s16 overwriteStrengthCorrectRate_byThunder = -1"
            /// <summary>
            /// Lightning Replacement Correction: STR (s16)
            /// </summary>
            /// <remarks>
            /// 
            /// </remarks>
            public short LightningReplacementCorrectionSTR 
            {
                get => (short)CellsByName["LightningReplacementCorrectionSTR"].Value;
                set => CellsByName["LightningReplacementCorrectionSTR"].Value = (short)value;
            }
            

            // Def="s16 overwriteDexterityCorrectRate_byThunder = -1"
            /// <summary>
            /// Lightning Replacement Correction: DEX (s16)
            /// </summary>
            /// <remarks>
            /// 
            /// </remarks>
            public short LightningReplacementCorrectionDEX 
            {
                get => (short)CellsByName["LightningReplacementCorrectionDEX"].Value;
                set => CellsByName["LightningReplacementCorrectionDEX"].Value = (short)value;
            }
            

            // Def="s16 overwriteMagicCorrectRate_byThunder = -1"
            /// <summary>
            /// Lightning Replacement Correction: INT (s16)
            /// </summary>
            /// <remarks>
            /// 
            /// </remarks>
            public short LightningReplacementCorrectionINT 
            {
                get => (short)CellsByName["LightningReplacementCorrectionINT"].Value;
                set => CellsByName["LightningReplacementCorrectionINT"].Value = (short)value;
            }
            

            // Def="s16 overwriteFaithCorrectRate_byThunder = -1"
            /// <summary>
            /// Lightning Replacement Correction: FTH (s16)
            /// </summary>
            /// <remarks>
            /// 
            /// </remarks>
            public short LightningReplacementCorrectionFTH 
            {
                get => (short)CellsByName["LightningReplacementCorrectionFTH"].Value;
                set => CellsByName["LightningReplacementCorrectionFTH"].Value = (short)value;
            }
            

            // Def="s16 overwriteLuckCorrectRate_byThunder = -1"
            /// <summary>
            /// Lightning Replacement Correction: ARC (s16)
            /// </summary>
            /// <remarks>
            /// 
            /// </remarks>
            public short LightningReplacementCorrectionARC 
            {
                get => (short)CellsByName["LightningReplacementCorrectionARC"].Value;
                set => CellsByName["LightningReplacementCorrectionARC"].Value = (short)value;
            }
            

            // Def="s16 overwriteStrengthCorrectRate_byDark = -1"
            /// <summary>
            /// Holy Replacement Correction: STR (s16)
            /// </summary>
            /// <remarks>
            /// 
            /// </remarks>
            public short HolyReplacementCorrectionSTR 
            {
                get => (short)CellsByName["HolyReplacementCorrectionSTR"].Value;
                set => CellsByName["HolyReplacementCorrectionSTR"].Value = (short)value;
            }
            

            // Def="s16 overwriteDexterityCorrectRate_byDark = -1"
            /// <summary>
            /// Holy Replacement Correction: DEX (s16)
            /// </summary>
            /// <remarks>
            /// 
            /// </remarks>
            public short HolyReplacementCorrectionDEX 
            {
                get => (short)CellsByName["HolyReplacementCorrectionDEX"].Value;
                set => CellsByName["HolyReplacementCorrectionDEX"].Value = (short)value;
            }
            

            // Def="s16 overwriteMagicCorrectRate_byDark = -1"
            /// <summary>
            /// Holy Replacement Correction: INT (s16)
            /// </summary>
            /// <remarks>
            /// 
            /// </remarks>
            public short HolyReplacementCorrectionINT 
            {
                get => (short)CellsByName["HolyReplacementCorrectionINT"].Value;
                set => CellsByName["HolyReplacementCorrectionINT"].Value = (short)value;
            }
            

            // Def="s16 overwriteFaithCorrectRate_byDark = -1"
            /// <summary>
            /// Holy Replacement Correction: FTH (s16)
            /// </summary>
            /// <remarks>
            /// 
            /// </remarks>
            public short HolyReplacementCorrectionFTH 
            {
                get => (short)CellsByName["HolyReplacementCorrectionFTH"].Value;
                set => CellsByName["HolyReplacementCorrectionFTH"].Value = (short)value;
            }
            

            // Def="s16 overwriteLuckCorrectRate_byDark = -1"
            /// <summary>
            /// Holy Replacement Correction: ARC (s16)
            /// </summary>
            /// <remarks>
            /// 
            /// </remarks>
            public short HolyReplacementCorrectionARC 
            {
                get => (short)CellsByName["HolyReplacementCorrectionARC"].Value;
                set => CellsByName["HolyReplacementCorrectionARC"].Value = (short)value;
            }
            

            // Def="s16 InfluenceStrengthCorrectRate_byPhysics = 100"
            /// <summary>
            /// Physical Correction Ratio: STR (s16)
            /// </summary>
            /// <remarks>
            /// The rate of influence of the correction factor.
            /// </remarks>
            public short PhysicalCorrectionRatioSTR 
            {
                get => (short)CellsByName["PhysicalCorrectionRatioSTR"].Value;
                set => CellsByName["PhysicalCorrectionRatioSTR"].Value = (short)value;
            }
            

            // Def="s16 InfluenceDexterityCorrectRate_byPhysics = 100"
            /// <summary>
            /// Physical Correction Ratio: DEX (s16)
            /// </summary>
            /// <remarks>
            /// The rate of influence of the correction factor.
            /// </remarks>
            public short PhysicalCorrectionRatioDEX 
            {
                get => (short)CellsByName["PhysicalCorrectionRatioDEX"].Value;
                set => CellsByName["PhysicalCorrectionRatioDEX"].Value = (short)value;
            }
            

            // Def="s16 InfluenceMagicCorrectRate_byPhysics = 100"
            /// <summary>
            /// Physical Correction Ratio: INT (s16)
            /// </summary>
            /// <remarks>
            /// The rate of influence of the correction factor.
            /// </remarks>
            public short PhysicalCorrectionRatioINT 
            {
                get => (short)CellsByName["PhysicalCorrectionRatioINT"].Value;
                set => CellsByName["PhysicalCorrectionRatioINT"].Value = (short)value;
            }
            

            // Def="s16 InfluenceFaithCorrectRate_byPhysics = 100"
            /// <summary>
            /// Physical Correction Ratio: FTH (s16)
            /// </summary>
            /// <remarks>
            /// The rate of influence of the correction factor.
            /// </remarks>
            public short PhysicalCorrectionRatioFTH 
            {
                get => (short)CellsByName["PhysicalCorrectionRatioFTH"].Value;
                set => CellsByName["PhysicalCorrectionRatioFTH"].Value = (short)value;
            }
            

            // Def="s16 InfluenceLuckCorrectRate_byPhysics = 100"
            /// <summary>
            /// Physical Correction Ratio: ARC (s16)
            /// </summary>
            /// <remarks>
            /// The rate of influence of the correction factor.
            /// </remarks>
            public short PhysicalCorrectionRatioARC 
            {
                get => (short)CellsByName["PhysicalCorrectionRatioARC"].Value;
                set => CellsByName["PhysicalCorrectionRatioARC"].Value = (short)value;
            }
            

            // Def="s16 InfluenceStrengthCorrectRate_byMagic = 100"
            /// <summary>
            /// Magic Correction Ratio: STR (s16)
            /// </summary>
            /// <remarks>
            /// The rate of influence of the correction factor.
            /// </remarks>
            public short MagicCorrectionRatioSTR 
            {
                get => (short)CellsByName["MagicCorrectionRatioSTR"].Value;
                set => CellsByName["MagicCorrectionRatioSTR"].Value = (short)value;
            }
            

            // Def="s16 InfluenceDexterityCorrectRate_byMagic = 100"
            /// <summary>
            /// Magic Correction Ratio: DEX (s16)
            /// </summary>
            /// <remarks>
            /// The rate of influence of the correction factor.
            /// </remarks>
            public short MagicCorrectionRatioDEX 
            {
                get => (short)CellsByName["MagicCorrectionRatioDEX"].Value;
                set => CellsByName["MagicCorrectionRatioDEX"].Value = (short)value;
            }
            

            // Def="s16 InfluenceMagicCorrectRate_byMagic = 100"
            /// <summary>
            /// Magic Correction Ratio: INT (s16)
            /// </summary>
            /// <remarks>
            /// The rate of influence of the correction factor.
            /// </remarks>
            public short MagicCorrectionRatioINT 
            {
                get => (short)CellsByName["MagicCorrectionRatioINT"].Value;
                set => CellsByName["MagicCorrectionRatioINT"].Value = (short)value;
            }
            

            // Def="s16 InfluenceFaithCorrectRate_byMagic = 100"
            /// <summary>
            /// Magic Correction Ratio: FTH (s16)
            /// </summary>
            /// <remarks>
            /// The rate of influence of the correction factor.
            /// </remarks>
            public short MagicCorrectionRatioFTH 
            {
                get => (short)CellsByName["MagicCorrectionRatioFTH"].Value;
                set => CellsByName["MagicCorrectionRatioFTH"].Value = (short)value;
            }
            

            // Def="s16 InfluenceLuckCorrectRate_byMagic = 100"
            /// <summary>
            /// Magic Correction Ratio: ARC (s16)
            /// </summary>
            /// <remarks>
            /// The rate of influence of the correction factor.
            /// </remarks>
            public short MagicCorrectionRatioARC 
            {
                get => (short)CellsByName["MagicCorrectionRatioARC"].Value;
                set => CellsByName["MagicCorrectionRatioARC"].Value = (short)value;
            }
            

            // Def="s16 InfluenceStrengthCorrectRate_byFire = 100"
            /// <summary>
            /// Fire Correction Ratio: STR (s16)
            /// </summary>
            /// <remarks>
            /// The rate of influence of the correction factor.
            /// </remarks>
            public short FireCorrectionRatioSTR 
            {
                get => (short)CellsByName["FireCorrectionRatioSTR"].Value;
                set => CellsByName["FireCorrectionRatioSTR"].Value = (short)value;
            }
            

            // Def="s16 InfluenceDexterityCorrectRate_byFire = 100"
            /// <summary>
            /// Fire Correction Ratio: DEX (s16)
            /// </summary>
            /// <remarks>
            /// The rate of influence of the correction factor.
            /// </remarks>
            public short FireCorrectionRatioDEX 
            {
                get => (short)CellsByName["FireCorrectionRatioDEX"].Value;
                set => CellsByName["FireCorrectionRatioDEX"].Value = (short)value;
            }
            

            // Def="s16 InfluenceMagicCorrectRate_byFire = 100"
            /// <summary>
            /// Fire Correction Ratio: INT (s16)
            /// </summary>
            /// <remarks>
            /// The rate of influence of the correction factor.
            /// </remarks>
            public short FireCorrectionRatioINT 
            {
                get => (short)CellsByName["FireCorrectionRatioINT"].Value;
                set => CellsByName["FireCorrectionRatioINT"].Value = (short)value;
            }
            

            // Def="s16 InfluenceFaithCorrectRate_byFire = 100"
            /// <summary>
            /// Fire Correction Ratio: FTH (s16)
            /// </summary>
            /// <remarks>
            /// The rate of influence of the correction factor.
            /// </remarks>
            public short FireCorrectionRatioFTH 
            {
                get => (short)CellsByName["FireCorrectionRatioFTH"].Value;
                set => CellsByName["FireCorrectionRatioFTH"].Value = (short)value;
            }
            

            // Def="s16 InfluenceLuckCorrectRate_byFire = 100"
            /// <summary>
            /// Fire Correction Ratio: ARC (s16)
            /// </summary>
            /// <remarks>
            /// The rate of influence of the correction factor.
            /// </remarks>
            public short FireCorrectionRatioARC 
            {
                get => (short)CellsByName["FireCorrectionRatioARC"].Value;
                set => CellsByName["FireCorrectionRatioARC"].Value = (short)value;
            }
            

            // Def="s16 InfluenceStrengthCorrectRate_byThunder = 100"
            /// <summary>
            /// Lightning Correction Ratio: STR (s16)
            /// </summary>
            /// <remarks>
            /// The rate of influence of the correction factor.
            /// </remarks>
            public short LightningCorrectionRatioSTR 
            {
                get => (short)CellsByName["LightningCorrectionRatioSTR"].Value;
                set => CellsByName["LightningCorrectionRatioSTR"].Value = (short)value;
            }
            

            // Def="s16 InfluenceDexterityCorrectRate_byThunder = 100"
            /// <summary>
            /// Lightning Correction Ratio: DEX (s16)
            /// </summary>
            /// <remarks>
            /// The rate of influence of the correction factor.
            /// </remarks>
            public short LightningCorrectionRatioDEX 
            {
                get => (short)CellsByName["LightningCorrectionRatioDEX"].Value;
                set => CellsByName["LightningCorrectionRatioDEX"].Value = (short)value;
            }
            

            // Def="s16 InfluenceMagicCorrectRate_byThunder = 100"
            /// <summary>
            /// Lightning Correction Ratio: INT (s16)
            /// </summary>
            /// <remarks>
            /// The rate of influence of the correction factor.
            /// </remarks>
            public short LightningCorrectionRatioINT 
            {
                get => (short)CellsByName["LightningCorrectionRatioINT"].Value;
                set => CellsByName["LightningCorrectionRatioINT"].Value = (short)value;
            }
            

            // Def="s16 InfluenceFaithCorrectRate_byThunder = 100"
            /// <summary>
            /// Lightning Correction Ratio: FTH (s16)
            /// </summary>
            /// <remarks>
            /// The rate of influence of the correction factor.
            /// </remarks>
            public short LightningCorrectionRatioFTH 
            {
                get => (short)CellsByName["LightningCorrectionRatioFTH"].Value;
                set => CellsByName["LightningCorrectionRatioFTH"].Value = (short)value;
            }
            

            // Def="s16 InfluenceLuckCorrectRate_byThunder = 100"
            /// <summary>
            /// Lightning Correction Ratio: ARC (s16)
            /// </summary>
            /// <remarks>
            /// The rate of influence of the correction factor.
            /// </remarks>
            public short LightningCorrectionRatioARC 
            {
                get => (short)CellsByName["LightningCorrectionRatioARC"].Value;
                set => CellsByName["LightningCorrectionRatioARC"].Value = (short)value;
            }
            

            // Def="s16 InfluenceStrengthCorrectRate_byDark = 100"
            /// <summary>
            /// Holy Correction Ratio: STR (s16)
            /// </summary>
            /// <remarks>
            /// The rate of influence of the correction factor.
            /// </remarks>
            public short HolyCorrectionRatioSTR 
            {
                get => (short)CellsByName["HolyCorrectionRatioSTR"].Value;
                set => CellsByName["HolyCorrectionRatioSTR"].Value = (short)value;
            }
            

            // Def="s16 InfluenceDexterityCorrectRate_byDark = 100"
            /// <summary>
            /// Holy Correction Ratio: DEX (s16)
            /// </summary>
            /// <remarks>
            /// The rate of influence of the correction factor.
            /// </remarks>
            public short HolyCorrectionRatioDEX 
            {
                get => (short)CellsByName["HolyCorrectionRatioDEX"].Value;
                set => CellsByName["HolyCorrectionRatioDEX"].Value = (short)value;
            }
            

            // Def="s16 InfluenceMagicCorrectRate_byDark = 100"
            /// <summary>
            /// Holy Correction Ratio: INT (s16)
            /// </summary>
            /// <remarks>
            /// The rate of influence of the correction factor.
            /// </remarks>
            public short HolyCorrectionRatioINT 
            {
                get => (short)CellsByName["HolyCorrectionRatioINT"].Value;
                set => CellsByName["HolyCorrectionRatioINT"].Value = (short)value;
            }
            

            // Def="s16 InfluenceFaithCorrectRate_byDark = 100"
            /// <summary>
            /// Holy Correction Ratio: FTH (s16)
            /// </summary>
            /// <remarks>
            /// The rate of influence of the correction factor.
            /// </remarks>
            public short HolyCorrectionRatioFTH 
            {
                get => (short)CellsByName["HolyCorrectionRatioFTH"].Value;
                set => CellsByName["HolyCorrectionRatioFTH"].Value = (short)value;
            }
            

            // Def="s16 InfluenceLuckCorrectRate_byDark = 100"
            /// <summary>
            /// Holy Correction Ratio: ARC (s16)
            /// </summary>
            /// <remarks>
            /// The rate of influence of the correction factor.
            /// </remarks>
            public short HolyCorrectionRatioARC 
            {
                get => (short)CellsByName["HolyCorrectionRatioARC"].Value;
                set => CellsByName["HolyCorrectionRatioARC"].Value = (short)value;
            }
            

                }
            }
            
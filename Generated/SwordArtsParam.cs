
            namespace StronglyTypedParams
            {
                // SWORD_ARTS_PARAM_ST
                public class SwordArtsParam : ParamRow
                {
                    public SwordArtsParam() : base()
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
            /// Reserve for package output 1 (dummy8)
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
            /// Reserve for package output 2 (dummy8)
            /// </summary>
            /// <remarks>
            /// Reserve for package output 2
            /// </remarks>
            public object ReserveForPackageOutput2 
            {
                get => (object)CellsByName["ReserveForPackageOutput2"].Value;
                set => CellsByName["ReserveForPackageOutput2"].Value = (object)value;
            }
            

            // Def="u8 swordArtsType"
            /// <summary>
            /// Sword Arts Type (u8)
            /// </summary>
            /// <remarks>
            /// Offset for TAE animation. 0 is a600. To pass to the behavior script to determine which swashbuckler
            /// </remarks>
            public byte SwordArtsType 
            {
                get => (byte)CellsByName["SwordArtsType"].Value;
                set => CellsByName["SwordArtsType"].Value = (byte)value;
            }
            

            // Def="u8 artsSpeedType"
            /// <summary>
            /// Arts Speed Type (u8)
            /// </summary>
            /// <remarks>
            /// Which cancellation timing do you see? 0: Normal (left hand attack) / 1: Early / 2: Slow
            /// </remarks>
            public byte ArtsSpeedType 
            {
                get => (byte)CellsByName["ArtsSpeedType"].Value;
                set => CellsByName["ArtsSpeedType"].Value = (byte)value;
            }
            

            // Def="s8 refStatus"
            /// <summary>
            /// Reference Status Type (s8)
            /// </summary>
            /// <remarks>
            /// Which system of arts points to refer to
            /// </remarks>
            public SwordArtsRefStatusType ReferenceStatusType 
            {
                get => (SwordArtsRefStatusType)CellsByName["ReferenceStatusType"].Value;
                set => CellsByName["ReferenceStatusType"].Value = (sbyte)value;
            }
            

            // Def="u8 isRefRightArts:1"
            /// <summary>
            /// Is Right-hand Arts Reference (u8)
            /// </summary>
            /// <remarks>
            /// When set to the arts of the left-handed weapon, the arts of the right-handed weapon are displayed in FE. Assumed to be used for "weapon maneuvers" etc.
            /// </remarks>
            public BoolCirclecrossType IsRightHandArtsReference 
            {
                get => (BoolCirclecrossType)CellsByName["IsRightHandArtsReference"].Value;
                set => CellsByName["IsRightHandArtsReference"].Value = (byte)value;
            }
            

            // Def="u8 isGrayoutLeftHand:1"
            /// <summary>
            /// Is Greyout Left-hand (u8)
            /// </summary>
            /// <remarks>
            /// Whether to gray out when displaying the arts name of the left hand (one-handed)
            /// </remarks>
            public BoolCirclecrossType IsGreyoutLeftHand 
            {
                get => (BoolCirclecrossType)CellsByName["IsGreyoutLeftHand"].Value;
                set => CellsByName["IsGreyoutLeftHand"].Value = (byte)value;
            }
            

            // Def="u8 isGrayoutRightHand:1"
            /// <summary>
            /// Is Greyout Right-hand (u8)
            /// </summary>
            /// <remarks>
            /// Whether to gray out when displaying the arts name of the right hand (one-handed)
            /// </remarks>
            public BoolCirclecrossType IsGreyoutRightHand 
            {
                get => (BoolCirclecrossType)CellsByName["IsGreyoutRightHand"].Value;
                set => CellsByName["IsGreyoutRightHand"].Value = (byte)value;
            }
            

            // Def="u8 isGrayoutBothHand:1"
            /// <summary>
            /// Is Greyout Both-hand (u8)
            /// </summary>
            /// <remarks>
            /// Whether to gray out when displaying the arts name of both hands
            /// </remarks>
            public BoolCirclecrossType IsGreyoutBothHand 
            {
                get => (BoolCirclecrossType)CellsByName["IsGreyoutBothHand"].Value;
                set => CellsByName["IsGreyoutBothHand"].Value = (byte)value;
            }
            

            // Def="dummy8 reserve2:4"
            /// <summary>
            /// Reserved area (dummy8)
            /// </summary>
            /// <remarks>
            /// 
            /// </remarks>
            public object ReservedArea 
            {
                get => (object)CellsByName["ReservedArea"].Value;
                set => CellsByName["ReservedArea"].Value = (object)value;
            }
            

            // Def="s8 usePoint_L1"
            /// <summary>
            /// Arts Points - L1 (s8)
            /// </summary>
            /// <remarks>
            /// Points to spend when putting out arts by L1
            /// </remarks>
            public sbyte ArtsPointsL1 
            {
                get => (sbyte)CellsByName["ArtsPointsL1"].Value;
                set => CellsByName["ArtsPointsL1"].Value = (sbyte)value;
            }
            

            // Def="s8 usePoint_L2"
            /// <summary>
            /// Arts Points - L2 (s8)
            /// </summary>
            /// <remarks>
            /// Points to spend when putting out arts by L2
            /// </remarks>
            public sbyte ArtsPointsL2 
            {
                get => (sbyte)CellsByName["ArtsPointsL2"].Value;
                set => CellsByName["ArtsPointsL2"].Value = (sbyte)value;
            }
            

            // Def="s8 usePoint_R1"
            /// <summary>
            /// Arts Points - R1 (s8)
            /// </summary>
            /// <remarks>
            /// Points to spend when putting out arts by R1
            /// </remarks>
            public sbyte ArtsPointsR1 
            {
                get => (sbyte)CellsByName["ArtsPointsR1"].Value;
                set => CellsByName["ArtsPointsR1"].Value = (sbyte)value;
            }
            

            // Def="s8 usePoint_R2"
            /// <summary>
            /// Arts Points - R2 (s8)
            /// </summary>
            /// <remarks>
            /// Points to spend when putting out arts by R2
            /// </remarks>
            public sbyte ArtsPointsR2 
            {
                get => (sbyte)CellsByName["ArtsPointsR2"].Value;
                set => CellsByName["ArtsPointsR2"].Value = (sbyte)value;
            }
            

            // Def="s32 textId"
            /// <summary>
            /// Text ID (s32)
            /// </summary>
            /// <remarks>
            /// Text ID for arts description
            /// </remarks>
            public int TextID 
            {
                get => (int)CellsByName["TextID"].Value;
                set => CellsByName["TextID"].Value = (int)value;
            }
            

            // Def="s16 useMagicPoint_L1"
            /// <summary>
            /// FP Consumption - L1 (s16)
            /// </summary>
            /// <remarks>
            /// MP consumed when issuing arts by L1
            /// </remarks>
            public short FPConsumptionL1 
            {
                get => (short)CellsByName["FPConsumptionL1"].Value;
                set => CellsByName["FPConsumptionL1"].Value = (short)value;
            }
            

            // Def="s16 useMagicPoint_L2"
            /// <summary>
            /// FP Consumption - L2 (s16)
            /// </summary>
            /// <remarks>
            /// MP consumed when issuing arts by L2
            /// </remarks>
            public short FPConsumptionL2 
            {
                get => (short)CellsByName["FPConsumptionL2"].Value;
                set => CellsByName["FPConsumptionL2"].Value = (short)value;
            }
            

            // Def="s16 useMagicPoint_R1"
            /// <summary>
            /// FP Consumption - R1 (s16)
            /// </summary>
            /// <remarks>
            /// MP consumed when issuing arts by R1
            /// </remarks>
            public short FPConsumptionR1 
            {
                get => (short)CellsByName["FPConsumptionR1"].Value;
                set => CellsByName["FPConsumptionR1"].Value = (short)value;
            }
            

            // Def="s16 useMagicPoint_R2"
            /// <summary>
            /// FP Consumption - R2 (s16)
            /// </summary>
            /// <remarks>
            /// MP consumed when issuing arts by R2
            /// </remarks>
            public short FPConsumptionR2 
            {
                get => (short)CellsByName["FPConsumptionR2"].Value;
                set => CellsByName["FPConsumptionR2"].Value = (short)value;
            }
            

            // Def="s8 shieldIconType"
            /// <summary>
            /// Shield Icon Type (s8)
            /// </summary>
            /// <remarks>
            /// If you do not overwrite it, the icon will be displayed based on the swashbuckler ID of the weapon para.
            /// </remarks>
            public SwordArtsShieldIconType ShieldIconType 
            {
                get => (SwordArtsShieldIconType)CellsByName["ShieldIconType"].Value;
                set => CellsByName["ShieldIconType"].Value = (sbyte)value;
            }
            

            // Def="dummy8 pad[1]"
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
            

            // Def="u16 iconId"
            /// <summary>
            /// Icon ID (u16)
            /// </summary>
            /// <remarks>
            /// ID of the icon displayed in FE etc.
            /// </remarks>
            public ushort IconID 
            {
                get => (ushort)CellsByName["IconID"].Value;
                set => CellsByName["IconID"].Value = (ushort)value;
            }
            

            // Def="s32 aiUsageId = -1"
            /// <summary>
            /// AI Usage Judgment ID (s32)
            /// </summary>
            /// <remarks>
            /// AI usage judgment ID
            /// </remarks>
            public int AIUsageJudgmentID 
            {
                get => (int)CellsByName["AIUsageJudgmentID"].Value;
                set => CellsByName["AIUsageJudgmentID"].Value = (int)value;
            }
            
                }
            }
            
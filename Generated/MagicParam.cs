
            namespace StronglyTypedParams
            {
                // MAGIC_PARAM_ST
                public class MagicParam : ParamRow
                {
                    public MagicParam() : base()
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
            

            // Def="s32 yesNoDialogMessageId"
            /// <summary>
            /// Dialog Message ID (s32)
            /// </summary>
            /// <remarks>
            /// Message ID of Yes / No dialog issued when using magic
            /// </remarks>
            public int DialogMessageID 
            {
                get => (int)CellsByName["DialogMessageID"].Value;
                set => CellsByName["DialogMessageID"].Value = (int)value;
            }
            

            // Def="s32 limitCancelSpEffectId = -1"
            /// <summary>
            /// Ignore Usage Restriction - SpEffect ID (s32)
            /// </summary>
            /// <remarks>
            /// Usage restrictions can be ignored when the specified special effect ID is activated
            /// </remarks>
            public int IgnoreUsageRestrictionSpEffectID 
            {
                get => (int)CellsByName["IgnoreUsageRestrictionSpEffectID"].Value;
                set => CellsByName["IgnoreUsageRestrictionSpEffectID"].Value = (int)value;
            }
            

            // Def="s16 sortId"
            /// <summary>
            /// Sort ID (s16)
            /// </summary>
            /// <remarks>
            /// Sort ID (-1: Do not collect)
            /// </remarks>
            public short SortID 
            {
                get => (short)CellsByName["SortID"].Value;
                set => CellsByName["SortID"].Value = (short)value;
            }
            

            // Def="u8 requirementLuck"
            /// <summary>
            /// Requirement: ARC (u8)
            /// </summary>
            /// <remarks>
            /// Can't be equipped without more PC luck
            /// </remarks>
            public byte RequirementARC 
            {
                get => (byte)CellsByName["RequirementARC"].Value;
                set => CellsByName["RequirementARC"].Value = (byte)value;
            }
            

            // Def="u8 aiNotifyType"
            /// <summary>
            /// AI Interrupt Type (u8)
            /// </summary>
            /// <remarks>
            /// AI interrupt occurs in act ("AI notification when magic is activated")
            /// </remarks>
            public MagicAiNotifyType AIInterruptType 
            {
                get => (MagicAiNotifyType)CellsByName["AIInterruptType"].Value;
                set => CellsByName["AIInterruptType"].Value = (byte)value;
            }
            

            // Def="s16 mp"
            /// <summary>
            /// FP Consumption - Default (s16)
            /// </summary>
            /// <remarks>
            /// MP consumption
            /// </remarks>
            public short FPConsumptionDefault 
            {
                get => (short)CellsByName["FPConsumptionDefault"].Value;
                set => CellsByName["FPConsumptionDefault"].Value = (short)value;
            }
            

            // Def="s16 stamina"
            /// <summary>
            /// Stamina Consumption - Default (s16)
            /// </summary>
            /// <remarks>
            /// Consumption stamina
            /// </remarks>
            public short StaminaConsumptionDefault 
            {
                get => (short)CellsByName["StaminaConsumptionDefault"].Value;
                set => CellsByName["StaminaConsumptionDefault"].Value = (short)value;
            }
            

            // Def="s16 iconId"
            /// <summary>
            /// Icon ID (s16)
            /// </summary>
            /// <remarks>
            /// Specify icon> For menu
            /// </remarks>
            public short IconID 
            {
                get => (short)CellsByName["IconID"].Value;
                set => CellsByName["IconID"].Value = (short)value;
            }
            

            // Def="s16 behaviorId"
            /// <summary>
            /// Behavior ID (s16)
            /// </summary>
            /// <remarks>
            /// Set the action ID
            /// </remarks>
            public short BehaviorID 
            {
                get => (short)CellsByName["BehaviorID"].Value;
                set => CellsByName["BehaviorID"].Value = (short)value;
            }
            

            // Def="s16 mtrlItemId = -1"
            /// <summary>
            /// Material Item ID (s16)
            /// </summary>
            /// <remarks>
            /// Item ID required for purchase
            /// </remarks>
            public short MaterialItemID 
            {
                get => (short)CellsByName["MaterialItemID"].Value;
                set => CellsByName["MaterialItemID"].Value = (short)value;
            }
            

            // Def="s16 replaceMagicId = -1"
            /// <summary>
            /// Replace Magic ID (s16)
            /// </summary>
            /// <remarks>
            /// ID to be replaced when the state change matches (-1: invalid)
            /// </remarks>
            public short ReplaceMagicID 
            {
                get => (short)CellsByName["ReplaceMagicID"].Value;
                set => CellsByName["ReplaceMagicID"].Value = (short)value;
            }
            

            // Def="s16 maxQuantity"
            /// <summary>
            /// Number of Uses (s16)
            /// </summary>
            /// <remarks>
            /// Number per piece (-1: infinity)
            /// </remarks>
            public short NumberOfUses 
            {
                get => (short)CellsByName["NumberOfUses"].Value;
                set => CellsByName["NumberOfUses"].Value = (short)value;
            }
            

            // Def="u8 refCategory1"
            /// <summary>
            /// Reference Category [1] (u8)
            /// </summary>
            /// <remarks>
            /// Call ID category [Attack, Projectile, Special Effects]
            /// </remarks>
            public BehaviorRefType ReferenceCategory1 
            {
                get => (BehaviorRefType)CellsByName["ReferenceCategory1"].Value;
                set => CellsByName["ReferenceCategory1"].Value = (byte)value;
            }
            

            // Def="u8 overDexterity"
            /// <summary>
            /// Dexterity over Start Value (u8)
            /// </summary>
            /// <remarks>
            /// Skill over start value
            /// </remarks>
            public byte DexterityOverStartValue 
            {
                get => (byte)CellsByName["DexterityOverStartValue"].Value;
                set => CellsByName["DexterityOverStartValue"].Value = (byte)value;
            }
            

            // Def="u8 refCategory2"
            /// <summary>
            /// Reference Category [2] (u8)
            /// </summary>
            /// <remarks>
            /// Call ID category [Attack, Projectile, Special Effects]
            /// </remarks>
            public BehaviorRefType ReferenceCategory2 
            {
                get => (BehaviorRefType)CellsByName["ReferenceCategory2"].Value;
                set => CellsByName["ReferenceCategory2"].Value = (byte)value;
            }
            

            // Def="u8 slotLength"
            /// <summary>
            /// Slot Usage (u8)
            /// </summary>
            /// <remarks>
            /// Number of slots required for equipment> For menu
            /// </remarks>
            public byte SlotUsage 
            {
                get => (byte)CellsByName["SlotUsage"].Value;
                set => CellsByName["SlotUsage"].Value = (byte)value;
            }
            

            // Def="u8 requirementIntellect"
            /// <summary>
            /// Requirement: INT (u8)
            /// </summary>
            /// <remarks>
            /// Can't be equipped without more PC intelligence
            /// </remarks>
            public byte RequirementINT 
            {
                get => (byte)CellsByName["RequirementINT"].Value;
                set => CellsByName["RequirementINT"].Value = (byte)value;
            }
            

            // Def="u8 requirementFaith"
            /// <summary>
            /// Requirement: FTH (u8)
            /// </summary>
            /// <remarks>
            /// It cannot be equipped without the power of the PC any more.
            /// </remarks>
            public byte RequirementFTH 
            {
                get => (byte)CellsByName["RequirementFTH"].Value;
                set => CellsByName["RequirementFTH"].Value = (byte)value;
            }
            

            // Def="u8 analogDexterityMin"
            /// <summary>
            /// Casting Speed - DEX Start Range (u8)
            /// </summary>
            /// <remarks>
            /// Motion cancel analog: Minimum skill value
            /// </remarks>
            public byte CastingSpeedDEXStartRange 
            {
                get => (byte)CellsByName["CastingSpeedDEXStartRange"].Value;
                set => CellsByName["CastingSpeedDEXStartRange"].Value = (byte)value;
            }
            

            // Def="u8 analogDexterityMax"
            /// <summary>
            /// Casting Speed - DEX End Range (u8)
            /// </summary>
            /// <remarks>
            /// Motion cancel analog: Maximum skill value
            /// </remarks>
            public byte CastingSpeedDEXEndRange 
            {
                get => (byte)CellsByName["CastingSpeedDEXEndRange"].Value;
                set => CellsByName["CastingSpeedDEXEndRange"].Value = (byte)value;
            }
            

            // Def="u8 ezStateBehaviorType"
            /// <summary>
            /// Magic School Type (u8)
            /// </summary>
            /// <remarks>
            /// Used for sorting> For menu
            /// </remarks>
            public MagicCategory MagicSchoolType 
            {
                get => (MagicCategory)CellsByName["MagicSchoolType"].Value;
                set => CellsByName["MagicSchoolType"].Value = (byte)value;
            }
            

            // Def="u8 refCategory3"
            /// <summary>
            /// Reference Category [3] (u8)
            /// </summary>
            /// <remarks>
            /// Call ID category [Attack, Projectile, Special Effects]
            /// </remarks>
            public BehaviorRefType ReferenceCategory3 
            {
                get => (BehaviorRefType)CellsByName["ReferenceCategory3"].Value;
                set => CellsByName["ReferenceCategory3"].Value = (byte)value;
            }
            

            // Def="u8 spEffectCategory"
            /// <summary>
            /// SpEffect Category (u8)
            /// </summary>
            /// <remarks>
            /// Since there are effects (enchantment weapons, etc.) whose parameters fluctuate depending on skills, magic, items, etc., set each action so that the determined effect can correspond to the effect such as "power up only weapon attack". Set "None" for items that do not need to be set, such as varistor.
            /// </remarks>
            public BehaviorCategory SpEffectCategory 
            {
                get => (BehaviorCategory)CellsByName["SpEffectCategory"].Value;
                set => CellsByName["SpEffectCategory"].Value = (byte)value;
            }
            

            // Def="u8 refType"
            /// <summary>
            /// Motion Category (u8)
            /// </summary>
            /// <remarks>
            /// Specify motion> For EzState
            /// </remarks>
            public MagicMotionType MotionCategory 
            {
                get => (MagicMotionType)CellsByName["MotionCategory"].Value;
                set => CellsByName["MotionCategory"].Value = (byte)value;
            }
            

            // Def="u8 opmeMenuType"
            /// <summary>
            /// Open Menu Type (u8)
            /// </summary>
            /// <remarks>
            /// Menu type to be displayed when using magic
            /// </remarks>
            public GoodsOpenMenu OpenMenuType 
            {
                get => (GoodsOpenMenu)CellsByName["OpenMenuType"].Value;
                set => CellsByName["OpenMenuType"].Value = (byte)value;
            }
            

            // Def="u8 refCategory4"
            /// <summary>
            /// Reference Category [4] (u8)
            /// </summary>
            /// <remarks>
            /// Call ID category [Attack, Projectile, Special Effects]
            /// </remarks>
            public BehaviorRefType ReferenceCategory4 
            {
                get => (BehaviorRefType)CellsByName["ReferenceCategory4"].Value;
                set => CellsByName["ReferenceCategory4"].Value = (byte)value;
            }
            

            // Def="u16 hasSpEffectType"
            /// <summary>
            /// Has SpEffect Type (u16)
            /// </summary>
            /// <remarks>
            /// Specify the state change that needs to replace the magic ID
            /// </remarks>
            public SpEffectType HasSpEffectType 
            {
                get => (SpEffectType)CellsByName["HasSpEffectType"].Value;
                set => CellsByName["HasSpEffectType"].Value = (ushort)value;
            }
            

            // Def="u8 replaceCategory"
            /// <summary>
            /// Replace Category (u8)
            /// </summary>
            /// <remarks>
            /// Additional conditions when replacing the magic ID
            /// </remarks>
            public ReplaceCategory ReplaceCategory 
            {
                get => (ReplaceCategory)CellsByName["ReplaceCategory"].Value;
                set => CellsByName["ReplaceCategory"].Value = (byte)value;
            }
            

            // Def="u8 useLimitCategory"
            /// <summary>
            /// Use Limit Category (u8)
            /// </summary>
            /// <remarks>
            /// Specified to control availability by special effects
            /// </remarks>
            public SpEffectUselimitCategory UseLimitCategory 
            {
                get => (SpEffectUselimitCategory)CellsByName["UseLimitCategory"].Value;
                set => CellsByName["UseLimitCategory"].Value = (byte)value;
            }
            

            // Def="u8 vowType0:1"
            /// <summary>
            /// Vow Type [0] (u8)
            /// </summary>
            /// <remarks>
            /// Pledge 0
            /// </remarks>
            public MagicBool VowType0 
            {
                get => (MagicBool)CellsByName["VowType0"].Value;
                set => CellsByName["VowType0"].Value = (byte)value;
            }
            

            // Def="u8 vowType1:1"
            /// <summary>
            /// Vow Type [1] (u8)
            /// </summary>
            /// <remarks>
            /// Pledge 1
            /// </remarks>
            public MagicBool VowType1 
            {
                get => (MagicBool)CellsByName["VowType1"].Value;
                set => CellsByName["VowType1"].Value = (byte)value;
            }
            

            // Def="u8 vowType2:1"
            /// <summary>
            /// Vow Type [2] (u8)
            /// </summary>
            /// <remarks>
            /// Pledge 2
            /// </remarks>
            public MagicBool VowType2 
            {
                get => (MagicBool)CellsByName["VowType2"].Value;
                set => CellsByName["VowType2"].Value = (byte)value;
            }
            

            // Def="u8 vowType3:1"
            /// <summary>
            /// Vow Type [3] (u8)
            /// </summary>
            /// <remarks>
            /// Pledge 3
            /// </remarks>
            public MagicBool VowType3 
            {
                get => (MagicBool)CellsByName["VowType3"].Value;
                set => CellsByName["VowType3"].Value = (byte)value;
            }
            

            // Def="u8 vowType4:1"
            /// <summary>
            /// Vow Type [4] (u8)
            /// </summary>
            /// <remarks>
            /// Pledge 4
            /// </remarks>
            public MagicBool VowType4 
            {
                get => (MagicBool)CellsByName["VowType4"].Value;
                set => CellsByName["VowType4"].Value = (byte)value;
            }
            

            // Def="u8 vowType5:1"
            /// <summary>
            /// Vow Type [5] (u8)
            /// </summary>
            /// <remarks>
            /// Pledge 5
            /// </remarks>
            public MagicBool VowType5 
            {
                get => (MagicBool)CellsByName["VowType5"].Value;
                set => CellsByName["VowType5"].Value = (byte)value;
            }
            

            // Def="u8 vowType6:1"
            /// <summary>
            /// Vow Type [6] (u8)
            /// </summary>
            /// <remarks>
            /// Pledge 6
            /// </remarks>
            public MagicBool VowType6 
            {
                get => (MagicBool)CellsByName["VowType6"].Value;
                set => CellsByName["VowType6"].Value = (byte)value;
            }
            

            // Def="u8 vowType7:1"
            /// <summary>
            /// Vow Type [7] (u8)
            /// </summary>
            /// <remarks>
            /// Pledge 7
            /// </remarks>
            public MagicBool VowType7 
            {
                get => (MagicBool)CellsByName["VowType7"].Value;
                set => CellsByName["VowType7"].Value = (byte)value;
            }
            

            // Def="u8 enable_multi:1"
            /// <summary>
            /// Allow in Multiplayer (u8)
            /// </summary>
            /// <remarks>
            /// Can it be used in multi? Can be used for both single and multi
            /// </remarks>
            public MagicBool AllowInMultiplayer 
            {
                get => (MagicBool)CellsByName["AllowInMultiplayer"].Value;
                set => CellsByName["AllowInMultiplayer"].Value = (byte)value;
            }
            

            // Def="u8 enable_multi_only:1"
            /// <summary>
            /// Allow only in Multiplayer (u8)
            /// </summary>
            /// <remarks>
            /// Is it only for multi? It cannot be used when it is a single. It can be used when it is multi.
            /// </remarks>
            public MagicBool AllowOnlyInMultiplayer 
            {
                get => (MagicBool)CellsByName["AllowOnlyInMultiplayer"].Value;
                set => CellsByName["AllowOnlyInMultiplayer"].Value = (byte)value;
            }
            

            // Def="u8 isEnchant:1"
            /// <summary>
            /// Is Weapon Enchantment (u8)
            /// </summary>
            /// <remarks>
            /// Is it magic to enchant?
            /// </remarks>
            public MagicBool IsWeaponEnchantment 
            {
                get => (MagicBool)CellsByName["IsWeaponEnchantment"].Value;
                set => CellsByName["IsWeaponEnchantment"].Value = (byte)value;
            }
            

            // Def="u8 isShieldEnchant:1"
            /// <summary>
            /// Is Shield Enchantment (u8)
            /// </summary>
            /// <remarks>
            /// Is it magic to enchant guards and shields?
            /// </remarks>
            public MagicBool IsShieldEnchantment 
            {
                get => (MagicBool)CellsByName["IsShieldEnchantment"].Value;
                set => CellsByName["IsShieldEnchantment"].Value = (byte)value;
            }
            

            // Def="u8 enable_live:1"
            /// <summary>
            /// Enable Live (u8)
            /// </summary>
            /// <remarks>
            /// Can surviving characters be used?
            /// </remarks>
            public MagicBool EnableLive 
            {
                get => (MagicBool)CellsByName["EnableLive"].Value;
                set => CellsByName["EnableLive"].Value = (byte)value;
            }
            

            // Def="u8 enable_gray:1"
            /// <summary>
            /// Enable Gray (u8)
            /// </summary>
            /// <remarks>
            /// Can gray characters be used?
            /// </remarks>
            public MagicBool EnableGray 
            {
                get => (MagicBool)CellsByName["EnableGray"].Value;
                set => CellsByName["EnableGray"].Value = (byte)value;
            }
            

            // Def="u8 enable_white:1"
            /// <summary>
            /// Enable White (u8)
            /// </summary>
            /// <remarks>
            /// Can white ghost characters be used?
            /// </remarks>
            public MagicBool EnableWhite 
            {
                get => (MagicBool)CellsByName["EnableWhite"].Value;
                set => CellsByName["EnableWhite"].Value = (byte)value;
            }
            

            // Def="u8 enable_black:1"
            /// <summary>
            /// Enable Black (u8)
            /// </summary>
            /// <remarks>
            /// Can black ghost characters be used?
            /// </remarks>
            public MagicBool EnableBlack 
            {
                get => (MagicBool)CellsByName["EnableBlack"].Value;
                set => CellsByName["EnableBlack"].Value = (byte)value;
            }
            

            // Def="u8 disableOffline:1"
            /// <summary>
            /// Disable Offline (u8)
            /// </summary>
            /// <remarks>
            /// Is it unavailable offline?
            /// </remarks>
            public MagicBool DisableOffline 
            {
                get => (MagicBool)CellsByName["DisableOffline"].Value;
                set => CellsByName["DisableOffline"].Value = (byte)value;
            }
            

            // Def="u8 castResonanceMagic:1"
            /// <summary>
            /// Cast Resonance Magic (u8)
            /// </summary>
            /// <remarks>
            /// Do you deliver resonance magic?
            /// </remarks>
            public MagicBool CastResonanceMagic 
            {
                get => (MagicBool)CellsByName["CastResonanceMagic"].Value;
                set => CellsByName["CastResonanceMagic"].Value = (byte)value;
            }
            

            // Def="u8 isValidTough_ProtSADmg:1"
            /// <summary>
            /// Is Toughness Perfomed if Poise is Initial Value (u8)
            /// </summary>
            /// <remarks>
            /// Whether the toughness calculation is performed even if the armor SA is the initial value. Check the toughness specification .xlsx for details
            /// </remarks>
            public MagicBool IsToughnessPerfomedIfPoiseIsInitialValue 
            {
                get => (MagicBool)CellsByName["IsToughnessPerfomedIfPoiseIsInitialValue"].Value;
                set => CellsByName["IsToughnessPerfomedIfPoiseIsInitialValue"].Value = (byte)value;
            }
            

            // Def="u8 isWarpMagic:1"
            /// <summary>
            /// Is Blocked by Warp Prohibition Effect (u8)
            /// </summary>
            /// <remarks>
            /// Is it magic to warp? Magic with a check mark here is prohibited by the special effect "Warp Prohibition".
            /// </remarks>
            public MagicBool IsBlockedByWarpProhibitionEffect 
            {
                get => (MagicBool)CellsByName["IsBlockedByWarpProhibitionEffect"].Value;
                set => CellsByName["IsBlockedByWarpProhibitionEffect"].Value = (byte)value;
            }
            

            // Def="u8 enableRiding:1"
            /// <summary>
            /// Usable while Riding (u8)
            /// </summary>
            /// <remarks>
            /// Can it be used while riding?
            /// </remarks>
            public MagicBool UsableWhileRiding 
            {
                get => (MagicBool)CellsByName["UsableWhileRiding"].Value;
                set => CellsByName["UsableWhileRiding"].Value = (byte)value;
            }
            

            // Def="u8 disableRiding:1"
            /// <summary>
            /// Not Usable while Riding (u8)
            /// </summary>
            /// <remarks>
            /// Is it prohibited to use while not riding?
            /// </remarks>
            public MagicBool NotUsableWhileRiding 
            {
                get => (MagicBool)CellsByName["NotUsableWhileRiding"].Value;
                set => CellsByName["NotUsableWhileRiding"].Value = (byte)value;
            }
            

            // Def="u8 isUseNoAttackRegion:1"
            /// <summary>
            /// Usable in No Attack Region (u8)
            /// </summary>
            /// <remarks>
            /// Can it be used in an attack-prohibited area?
            /// </remarks>
            public MagicBool UsableInNoAttackRegion 
            {
                get => (MagicBool)CellsByName["UsableInNoAttackRegion"].Value;
                set => CellsByName["UsableInNoAttackRegion"].Value = (byte)value;
            }
            

            // Def="dummy8 pad_1:1"
            /// <summary>
            /// pading (dummy8)
            /// </summary>
            /// <remarks>
            /// 
            /// </remarks>
            public object Pading 
            {
                get => (object)CellsByName["Pading"].Value;
                set => CellsByName["Pading"].Value = (object)value;
            }
            

            // Def="u8 vowType8:1"
            /// <summary>
            /// Vow Type [8] (u8)
            /// </summary>
            /// <remarks>
            /// Pledge 8
            /// </remarks>
            public MagicBool VowType8 
            {
                get => (MagicBool)CellsByName["VowType8"].Value;
                set => CellsByName["VowType8"].Value = (byte)value;
            }
            

            // Def="u8 vowType9:1"
            /// <summary>
            /// Vow Type [9] (u8)
            /// </summary>
            /// <remarks>
            /// Pledge 9
            /// </remarks>
            public MagicBool VowType9 
            {
                get => (MagicBool)CellsByName["VowType9"].Value;
                set => CellsByName["VowType9"].Value = (byte)value;
            }
            

            // Def="u8 vowType10:1"
            /// <summary>
            /// Vow Type [10] (u8)
            /// </summary>
            /// <remarks>
            /// Pledge 10
            /// </remarks>
            public MagicBool VowType10 
            {
                get => (MagicBool)CellsByName["VowType10"].Value;
                set => CellsByName["VowType10"].Value = (byte)value;
            }
            

            // Def="u8 vowType11:1"
            /// <summary>
            /// Vow Type [11] (u8)
            /// </summary>
            /// <remarks>
            /// Pledge 11
            /// </remarks>
            public MagicBool VowType11 
            {
                get => (MagicBool)CellsByName["VowType11"].Value;
                set => CellsByName["VowType11"].Value = (byte)value;
            }
            

            // Def="u8 vowType12:1"
            /// <summary>
            /// Vow Type [12] (u8)
            /// </summary>
            /// <remarks>
            /// Pledge 12
            /// </remarks>
            public MagicBool VowType12 
            {
                get => (MagicBool)CellsByName["VowType12"].Value;
                set => CellsByName["VowType12"].Value = (byte)value;
            }
            

            // Def="u8 vowType13:1"
            /// <summary>
            /// Vow Type [13] (u8)
            /// </summary>
            /// <remarks>
            /// Pledge 13
            /// </remarks>
            public MagicBool VowType13 
            {
                get => (MagicBool)CellsByName["VowType13"].Value;
                set => CellsByName["VowType13"].Value = (byte)value;
            }
            

            // Def="u8 vowType14:1"
            /// <summary>
            /// Vow Type [14] (u8)
            /// </summary>
            /// <remarks>
            /// Pledge 14
            /// </remarks>
            public MagicBool VowType14 
            {
                get => (MagicBool)CellsByName["VowType14"].Value;
                set => CellsByName["VowType14"].Value = (byte)value;
            }
            

            // Def="u8 vowType15:1"
            /// <summary>
            /// Vow Type [15] (u8)
            /// </summary>
            /// <remarks>
            /// Pledge 15
            /// </remarks>
            public MagicBool VowType15 
            {
                get => (MagicBool)CellsByName["VowType15"].Value;
                set => CellsByName["VowType15"].Value = (byte)value;
            }
            

            // Def="s32 castSfxId = -1"
            /// <summary>
            /// SFX ID - Cast (s32)
            /// </summary>
            /// <remarks>
            /// SFXID during magical chanting
            /// </remarks>
            public int SFXIDCast 
            {
                get => (int)CellsByName["SFXIDCast"].Value;
                set => CellsByName["SFXIDCast"].Value = (int)value;
            }
            

            // Def="s32 fireSfxId = -1"
            /// <summary>
            /// SFX ID - Fire (s32)
            /// </summary>
            /// <remarks>
            /// SFX ID when magic is activated
            /// </remarks>
            public int SFXIDFire 
            {
                get => (int)CellsByName["SFXIDFire"].Value;
                set => CellsByName["SFXIDFire"].Value = (int)value;
            }
            

            // Def="s32 effectSfxId = -1"
            /// <summary>
            /// SFX ID - Effect (s32)
            /// </summary>
            /// <remarks>
            /// SFXID during magic effect
            /// </remarks>
            public int SFXIDEffect 
            {
                get => (int)CellsByName["SFXIDEffect"].Value;
                set => CellsByName["SFXIDEffect"].Value = (int)value;
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
            

            // Def="u8 ReplacementStatusType"
            /// <summary>
            /// Replacement Status Type (u8)
            /// </summary>
            /// <remarks>
            /// Replacement status type
            /// </remarks>
            public MagicStatusType ReplacementStatusType 
            {
                get => (MagicStatusType)CellsByName["ReplacementStatusType"].Value;
                set => CellsByName["ReplacementStatusType"].Value = (byte)value;
            }
            

            // Def="s8 ReplacementStatus1 = -1"
            /// <summary>
            /// Replacement Threshold [1] (s8)
            /// </summary>
            /// <remarks>
            /// Replacement status value 1
            /// </remarks>
            public sbyte ReplacementThreshold1 
            {
                get => (sbyte)CellsByName["ReplacementThreshold1"].Value;
                set => CellsByName["ReplacementThreshold1"].Value = (sbyte)value;
            }
            

            // Def="s8 ReplacementStatus2 = -1"
            /// <summary>
            /// Replacement Threshold [2] (s8)
            /// </summary>
            /// <remarks>
            /// Replacement status value 2
            /// </remarks>
            public sbyte ReplacementThreshold2 
            {
                get => (sbyte)CellsByName["ReplacementThreshold2"].Value;
                set => CellsByName["ReplacementThreshold2"].Value = (sbyte)value;
            }
            

            // Def="s8 ReplacementStatus3 = -1"
            /// <summary>
            /// Replacement Threshold [3] (s8)
            /// </summary>
            /// <remarks>
            /// Replacement status value 3
            /// </remarks>
            public sbyte ReplacementThreshold3 
            {
                get => (sbyte)CellsByName["ReplacementThreshold3"].Value;
                set => CellsByName["ReplacementThreshold3"].Value = (sbyte)value;
            }
            

            // Def="s8 ReplacementStatus4 = -1"
            /// <summary>
            /// Replacement Threshold [4] (s8)
            /// </summary>
            /// <remarks>
            /// Replacement status value 4
            /// </remarks>
            public sbyte ReplacementThreshold4 
            {
                get => (sbyte)CellsByName["ReplacementThreshold4"].Value;
                set => CellsByName["ReplacementThreshold4"].Value = (sbyte)value;
            }
            

            // Def="u8 refCategory5"
            /// <summary>
            /// Reference Category [5] (u8)
            /// </summary>
            /// <remarks>
            /// Call ID category [Attack, Projectile, Special Effects]
            /// </remarks>
            public BehaviorRefType ReferenceCategory5 
            {
                get => (BehaviorRefType)CellsByName["ReferenceCategory5"].Value;
                set => CellsByName["ReferenceCategory5"].Value = (byte)value;
            }
            

            // Def="s16 consumeSA"
            /// <summary>
            /// Poise Consumption (s16)
            /// </summary>
            /// <remarks>
            /// SA consumption [normal / reservoir]
            /// </remarks>
            public short PoiseConsumption 
            {
                get => (short)CellsByName["PoiseConsumption"].Value;
                set => CellsByName["PoiseConsumption"].Value = (short)value;
            }
            

            // Def="s32 ReplacementMagic1 = -1"
            /// <summary>
            /// Replacement Magic ID [1] (s32)
            /// </summary>
            /// <remarks>
            /// Replacement ID1
            /// </remarks>
            public int ReplacementMagicID1 
            {
                get => (int)CellsByName["ReplacementMagicID1"].Value;
                set => CellsByName["ReplacementMagicID1"].Value = (int)value;
            }
            

            // Def="s32 ReplacementMagic2 = -1"
            /// <summary>
            /// Replacement Magic ID [2] (s32)
            /// </summary>
            /// <remarks>
            /// Replacement ID2
            /// </remarks>
            public int ReplacementMagicID2 
            {
                get => (int)CellsByName["ReplacementMagicID2"].Value;
                set => CellsByName["ReplacementMagicID2"].Value = (int)value;
            }
            

            // Def="s32 ReplacementMagic3 = -1"
            /// <summary>
            /// Replacement Magic ID [3] (s32)
            /// </summary>
            /// <remarks>
            /// Replacement ID3
            /// </remarks>
            public int ReplacementMagicID3 
            {
                get => (int)CellsByName["ReplacementMagicID3"].Value;
                set => CellsByName["ReplacementMagicID3"].Value = (int)value;
            }
            

            // Def="s32 ReplacementMagic4 = -1"
            /// <summary>
            /// Replacement Magic ID [4] (s32)
            /// </summary>
            /// <remarks>
            /// Replacement ID 4
            /// </remarks>
            public int ReplacementMagicID4 
            {
                get => (int)CellsByName["ReplacementMagicID4"].Value;
                set => CellsByName["ReplacementMagicID4"].Value = (int)value;
            }
            

            // Def="s16 mp_charge"
            /// <summary>
            /// FP Consumption - Charged (s16)
            /// </summary>
            /// <remarks>
            /// MP consumption [reservoir]
            /// </remarks>
            public short FPConsumptionCharged 
            {
                get => (short)CellsByName["FPConsumptionCharged"].Value;
                set => CellsByName["FPConsumptionCharged"].Value = (short)value;
            }
            

            // Def="s16 stamina_charge"
            /// <summary>
            /// Stamina Consumption - Charged (s16)
            /// </summary>
            /// <remarks>
            /// Consumption stamina [reservoir]
            /// </remarks>
            public short StaminaConsumptionCharged 
            {
                get => (short)CellsByName["StaminaConsumptionCharged"].Value;
                set => CellsByName["StaminaConsumptionCharged"].Value = (short)value;
            }
            

            // Def="u8 createLimitGroupId"
            /// <summary>
            /// Create Limit Group ID (u8)
            /// </summary>
            /// <remarks>
            /// If it is 0, it is unused. Check the number of bullets created for the specified group Id, and if the upper limit is reached, you will not be able to use magic.
            /// </remarks>
            public byte CreateLimitGroupID 
            {
                get => (byte)CellsByName["CreateLimitGroupID"].Value;
                set => CellsByName["CreateLimitGroupID"].Value = (byte)value;
            }
            

            // Def="u8 refCategory6"
            /// <summary>
            /// Reference Category [6] (u8)
            /// </summary>
            /// <remarks>
            /// Call ID category [Attack, Projectile, Special Effects]
            /// </remarks>
            public BehaviorRefType ReferenceCategory6 
            {
                get => (BehaviorRefType)CellsByName["ReferenceCategory6"].Value;
                set => CellsByName["ReferenceCategory6"].Value = (byte)value;
            }
            

            // Def="u8 subCategory1"
            /// <summary>
            /// Conditional Category [1] (u8)
            /// </summary>
            /// <remarks>
            /// Subcategory 1
            /// </remarks>
            public AtkSubCategory ConditionalCategory1 
            {
                get => (AtkSubCategory)CellsByName["ConditionalCategory1"].Value;
                set => CellsByName["ConditionalCategory1"].Value = (byte)value;
            }
            

            // Def="u8 subCategory2"
            /// <summary>
            /// Conditional Category [2] (u8)
            /// </summary>
            /// <remarks>
            /// Subcategory 2
            /// </remarks>
            public AtkSubCategory ConditionalCategory2 
            {
                get => (AtkSubCategory)CellsByName["ConditionalCategory2"].Value;
                set => CellsByName["ConditionalCategory2"].Value = (byte)value;
            }
            

            // Def="u8 refCategory7"
            /// <summary>
            /// Reference Category [7] (u8)
            /// </summary>
            /// <remarks>
            /// Call ID category [Attack, Projectile, Special Effects]
            /// </remarks>
            public BehaviorRefType ReferenceCategory7 
            {
                get => (BehaviorRefType)CellsByName["ReferenceCategory7"].Value;
                set => CellsByName["ReferenceCategory7"].Value = (byte)value;
            }
            

            // Def="u8 refCategory8"
            /// <summary>
            /// Reference Category [8] (u8)
            /// </summary>
            /// <remarks>
            /// Call ID category [Attack, Projectile, Special Effects]
            /// </remarks>
            public BehaviorRefType ReferenceCategory8 
            {
                get => (BehaviorRefType)CellsByName["ReferenceCategory8"].Value;
                set => CellsByName["ReferenceCategory8"].Value = (byte)value;
            }
            

            // Def="u8 refCategory9"
            /// <summary>
            /// Reference Category [9] (u8)
            /// </summary>
            /// <remarks>
            /// Call ID category [Attack, Projectile, Special Effects]
            /// </remarks>
            public BehaviorRefType ReferenceCategory9 
            {
                get => (BehaviorRefType)CellsByName["ReferenceCategory9"].Value;
                set => CellsByName["ReferenceCategory9"].Value = (byte)value;
            }
            

            // Def="u8 refCategory10"
            /// <summary>
            /// Reference Category [10] (u8)
            /// </summary>
            /// <remarks>
            /// Call ID category [Attack, Projectile, Special Effects]
            /// </remarks>
            public BehaviorRefType ReferenceCategory10 
            {
                get => (BehaviorRefType)CellsByName["ReferenceCategory10"].Value;
                set => CellsByName["ReferenceCategory10"].Value = (byte)value;
            }
            

            // Def="s32 refId1 = -1"
            /// <summary>
            /// Reference ID [1] (s32)
            /// </summary>
            /// <remarks>
            /// ID called from magic
            /// </remarks>
            public int ReferenceID1 
            {
                get => (int)CellsByName["ReferenceID1"].Value;
                set => CellsByName["ReferenceID1"].Value = (int)value;
            }
            

            // Def="s32 refId2 = -1"
            /// <summary>
            /// Reference ID [2] (s32)
            /// </summary>
            /// <remarks>
            /// ID called from magic
            /// </remarks>
            public int ReferenceID2 
            {
                get => (int)CellsByName["ReferenceID2"].Value;
                set => CellsByName["ReferenceID2"].Value = (int)value;
            }
            

            // Def="s32 refId3 = -1"
            /// <summary>
            /// Reference ID [3] (s32)
            /// </summary>
            /// <remarks>
            /// ID called from magic
            /// </remarks>
            public int ReferenceID3 
            {
                get => (int)CellsByName["ReferenceID3"].Value;
                set => CellsByName["ReferenceID3"].Value = (int)value;
            }
            

            // Def="s32 aiUseJudgeId = -1"
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
            

            // Def="s32 refId4 = -1"
            /// <summary>
            /// Reference ID [4] (s32)
            /// </summary>
            /// <remarks>
            /// ID called from magic
            /// </remarks>
            public int ReferenceID4 
            {
                get => (int)CellsByName["ReferenceID4"].Value;
                set => CellsByName["ReferenceID4"].Value = (int)value;
            }
            

            // Def="s32 refId5 = -1"
            /// <summary>
            /// Reference ID [5] (s32)
            /// </summary>
            /// <remarks>
            /// ID called from magic
            /// </remarks>
            public int ReferenceID5 
            {
                get => (int)CellsByName["ReferenceID5"].Value;
                set => CellsByName["ReferenceID5"].Value = (int)value;
            }
            

            // Def="s32 refId6 = -1"
            /// <summary>
            /// Reference ID [6] (s32)
            /// </summary>
            /// <remarks>
            /// ID called from magic
            /// </remarks>
            public int ReferenceID6 
            {
                get => (int)CellsByName["ReferenceID6"].Value;
                set => CellsByName["ReferenceID6"].Value = (int)value;
            }
            

            // Def="s32 refId7 = -1"
            /// <summary>
            /// Reference ID [7] (s32)
            /// </summary>
            /// <remarks>
            /// ID called from magic
            /// </remarks>
            public int ReferenceID7 
            {
                get => (int)CellsByName["ReferenceID7"].Value;
                set => CellsByName["ReferenceID7"].Value = (int)value;
            }
            

            // Def="s32 refId8 = -1"
            /// <summary>
            /// Reference ID [8] (s32)
            /// </summary>
            /// <remarks>
            /// ID called from magic
            /// </remarks>
            public int ReferenceID8 
            {
                get => (int)CellsByName["ReferenceID8"].Value;
                set => CellsByName["ReferenceID8"].Value = (int)value;
            }
            

            // Def="s32 refId9 = -1"
            /// <summary>
            /// Reference ID [9] (s32)
            /// </summary>
            /// <remarks>
            /// ID called from magic
            /// </remarks>
            public int ReferenceID9 
            {
                get => (int)CellsByName["ReferenceID9"].Value;
                set => CellsByName["ReferenceID9"].Value = (int)value;
            }
            

            // Def="s32 refId10 = -1"
            /// <summary>
            /// Reference ID [10] (s32)
            /// </summary>
            /// <remarks>
            /// ID called from magic
            /// </remarks>
            public int ReferenceID10 
            {
                get => (int)CellsByName["ReferenceID10"].Value;
                set => CellsByName["ReferenceID10"].Value = (int)value;
            }
            

            // Def="u8 consumeType1"
            /// <summary>
            /// Consumption Type [1] (u8)
            /// </summary>
            /// <remarks>
            /// Consumption type
            /// </remarks>
            public MagicConsumeType ConsumptionType1 
            {
                get => (MagicConsumeType)CellsByName["ConsumptionType1"].Value;
                set => CellsByName["ConsumptionType1"].Value = (byte)value;
            }
            

            // Def="u8 consumeType2"
            /// <summary>
            /// Consumption Type [2] (u8)
            /// </summary>
            /// <remarks>
            /// Consumption type
            /// </remarks>
            public MagicConsumeType ConsumptionType2 
            {
                get => (MagicConsumeType)CellsByName["ConsumptionType2"].Value;
                set => CellsByName["ConsumptionType2"].Value = (byte)value;
            }
            

            // Def="u8 consumeType3"
            /// <summary>
            /// Consumption Type [3] (u8)
            /// </summary>
            /// <remarks>
            /// Consumption type
            /// </remarks>
            public MagicConsumeType ConsumptionType3 
            {
                get => (MagicConsumeType)CellsByName["ConsumptionType3"].Value;
                set => CellsByName["ConsumptionType3"].Value = (byte)value;
            }
            

            // Def="u8 consumeType4"
            /// <summary>
            /// Consumption Type [4] (u8)
            /// </summary>
            /// <remarks>
            /// Consumption type
            /// </remarks>
            public MagicConsumeType ConsumptionType4 
            {
                get => (MagicConsumeType)CellsByName["ConsumptionType4"].Value;
                set => CellsByName["ConsumptionType4"].Value = (byte)value;
            }
            

            // Def="u8 consumeType5"
            /// <summary>
            /// Consumption Type [5] (u8)
            /// </summary>
            /// <remarks>
            /// Consumption type
            /// </remarks>
            public MagicConsumeType ConsumptionType5 
            {
                get => (MagicConsumeType)CellsByName["ConsumptionType5"].Value;
                set => CellsByName["ConsumptionType5"].Value = (byte)value;
            }
            

            // Def="u8 consumeType6"
            /// <summary>
            /// Consumption Type [6] (u8)
            /// </summary>
            /// <remarks>
            /// Consumption type
            /// </remarks>
            public MagicConsumeType ConsumptionType6 
            {
                get => (MagicConsumeType)CellsByName["ConsumptionType6"].Value;
                set => CellsByName["ConsumptionType6"].Value = (byte)value;
            }
            

            // Def="u8 consumeType7"
            /// <summary>
            /// Consumption Type [7] (u8)
            /// </summary>
            /// <remarks>
            /// Consumption type
            /// </remarks>
            public MagicConsumeType ConsumptionType7 
            {
                get => (MagicConsumeType)CellsByName["ConsumptionType7"].Value;
                set => CellsByName["ConsumptionType7"].Value = (byte)value;
            }
            

            // Def="u8 consumeType8"
            /// <summary>
            /// Consumption Type [8] (u8)
            /// </summary>
            /// <remarks>
            /// Consumption type
            /// </remarks>
            public MagicConsumeType ConsumptionType8 
            {
                get => (MagicConsumeType)CellsByName["ConsumptionType8"].Value;
                set => CellsByName["ConsumptionType8"].Value = (byte)value;
            }
            

            // Def="u8 consumeType9"
            /// <summary>
            /// Consumption Type [9] (u8)
            /// </summary>
            /// <remarks>
            /// Consumption type
            /// </remarks>
            public MagicConsumeType ConsumptionType9 
            {
                get => (MagicConsumeType)CellsByName["ConsumptionType9"].Value;
                set => CellsByName["ConsumptionType9"].Value = (byte)value;
            }
            

            // Def="u8 consumeType10"
            /// <summary>
            /// Consumption Type [10] (u8)
            /// </summary>
            /// <remarks>
            /// Consumption type
            /// </remarks>
            public MagicConsumeType ConsumptionType10 
            {
                get => (MagicConsumeType)CellsByName["ConsumptionType10"].Value;
                set => CellsByName["ConsumptionType10"].Value = (byte)value;
            }
            

            // Def="s16 consumeLoopMP_forMenu = -1"
            /// <summary>
            /// FP Consumption Loop - For Menu Display (s16)
            /// </summary>
            /// <remarks>
            /// MP consumption for menu supplement display
            /// </remarks>
            public short FPConsumptionLoopForMenuDisplay 
            {
                get => (short)CellsByName["FPConsumptionLoopForMenuDisplay"].Value;
                set => CellsByName["FPConsumptionLoopForMenuDisplay"].Value = (short)value;
            }
            

            // Def="dummy8 pad[8]"
            /// <summary>
            /// PAD12 (dummy8)
            /// </summary>
            /// <remarks>
            /// PAD12
            /// </remarks>
            public object PAD12 
            {
                get => (object)CellsByName["PAD12"].Value;
                set => CellsByName["PAD12"].Value = (object)value;
            }
            
                }
            }
            
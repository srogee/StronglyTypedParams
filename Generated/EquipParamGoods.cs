
namespace StronglyTypedParams
{
    public class EquipParamGoods : ParamRow
    {
        public EquipParamGoods() : base()
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


        // Def="s32 refId_default = -1"
        /// <summary>
        /// Reference ID (s32)
        /// </summary>
        /// <remarks>
        /// ID0 called from the item (default)
        /// </remarks>
        public int ReferenceID
        {
            get => (int)CellsByName["ReferenceID"].Value;
            set => CellsByName["ReferenceID"].Value = value;
        }


        // Def="s32 sfxVariationId = -1"
        /// <summary>
        /// SFX Variation ID (s32)
        /// </summary>
        /// <remarks>
        /// Specify SFX variation (used to identify SFX in combination with TimeActEditor ID)
        /// </remarks>
        public int SFXVariationID
        {
            get => (int)CellsByName["SFXVariationID"].Value;
            set => CellsByName["SFXVariationID"].Value = value;
        }


        // Def="f32 weight = 1"
        /// <summary>
        /// Weight (f32)
        /// </summary>
        /// <remarks>
        /// Weight [kg]
        /// </remarks>
        public float Weight
        {
            get => (float)CellsByName["Weight"].Value;
            set => CellsByName["Weight"].Value = value;
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


        // Def="s32 behaviorId"
        /// <summary>
        /// Behavior ID (s32)
        /// </summary>
        /// <remarks>
        /// Set the effect that occurs when using a tool
        /// </remarks>
        public int BehaviorID
        {
            get => (int)CellsByName["BehaviorID"].Value;
            set => CellsByName["BehaviorID"].Value = value;
        }


        // Def="s32 replaceItemId = -1"
        /// <summary>
        /// Replace Item ID (s32)
        /// </summary>
        /// <remarks>
        /// Item ID when replacing
        /// </remarks>
        public int ReplaceItemID
        {
            get => (int)CellsByName["ReplaceItemID"].Value;
            set => CellsByName["ReplaceItemID"].Value = value;
        }


        // Def="s32 sortId"
        /// <summary>
        /// Sort ID (s32)
        /// </summary>
        /// <remarks>
        /// Sort ID (-1: Do not collect)
        /// </remarks>
        public int SortID
        {
            get => (int)CellsByName["SortID"].Value;
            set => CellsByName["SortID"].Value = value;
        }


        // Def="s32 appearanceReplaceItemId = -1"
        /// <summary>
        /// Appearance Replace Item ID (s32)
        /// </summary>
        /// <remarks>
        /// Conditionally replace the display with another tool ID. The tool ID on the game data side does not change
        /// </remarks>
        public int AppearanceReplaceItemID
        {
            get => (int)CellsByName["AppearanceReplaceItemID"].Value;
            set => CellsByName["AppearanceReplaceItemID"].Value = value;
        }


        // Def="s32 yesNoDialogMessageId = -1"
        /// <summary>
        /// Dialog Message ID (s32)
        /// </summary>
        /// <remarks>
        /// YesNo Message ID used when displaying the dialog
        /// </remarks>
        public int DialogMessageID
        {
            get => (int)CellsByName["DialogMessageID"].Value;
            set => CellsByName["DialogMessageID"].Value = value;
        }


        // Def="u16 useEnableSpEffectType"
        /// <summary>
        /// Use Enable SpEffect Type (u16)
        /// </summary>
        /// <remarks>
        /// Allow to use only when the special effect of the set state change type is applied
        /// </remarks>
        public ushort UseEnableSpEffectType
        {
            get => (ushort)CellsByName["UseEnableSpEffectType"].Value;
            set => CellsByName["UseEnableSpEffectType"].Value = value;
        }


        // Def="s8 potGroupId = -1"
        /// <summary>
        /// Pot Group ID (s8)
        /// </summary>
        /// <remarks>
        /// "Consumable items" for which 0 or more is set for the pot group ID can be possessed by the number of "pots" with the same pot group ID.
        /// </remarks>
        public sbyte PotGroupID
        {
            get => (sbyte)CellsByName["PotGroupID"].Value;
            set => CellsByName["PotGroupID"].Value = value;
        }


        // Def="dummy8 pad[1]"
        /// <summary>
        /// PAD (dummy8)
        /// </summary>
        /// <remarks>
        /// Old (magic ID linked to a scroll)
        /// </remarks>
        public object PAD
        {
            get => (object)CellsByName["PAD"].Value;
            set => CellsByName["PAD"].Value = value;
        }


        // Def="u16 iconId"
        /// <summary>
        /// Icon ID (u16)
        /// </summary>
        /// <remarks>
        /// Menu icon ID
        /// </remarks>
        public ushort IconID
        {
            get => (ushort)CellsByName["IconID"].Value;
            set => CellsByName["IconID"].Value = value;
        }


        // Def="u16 modelId"
        /// <summary>
        /// Model ID (u16)
        /// </summary>
        /// <remarks>
        /// Model ID
        /// </remarks>
        public ushort ModelID
        {
            get => (ushort)CellsByName["ModelID"].Value;
            set => CellsByName["ModelID"].Value = value;
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


        // Def="s16 compTrophySedId = -1"
        /// <summary>
        /// Achivement ID (s16)
        /// </summary>
        /// <remarks>
        /// SEQ number of complete trophy
        /// </remarks>
        public short AchivementID
        {
            get => (short)CellsByName["AchivementID"].Value;
            set => CellsByName["AchivementID"].Value = value;
        }


        // Def="s16 trophySeqId = -1"
        /// <summary>
        /// Achivement Sequential ID (s16)
        /// </summary>
        /// <remarks>
        /// Trophy SEQ number
        /// </remarks>
        public short AchivementSequentialID
        {
            get => (short)CellsByName["AchivementSequentialID"].Value;
            set => CellsByName["AchivementSequentialID"].Value = value;
        }


        // Def="s16 maxNum"
        /// <summary>
        /// Max Amount (s16)
        /// </summary>
        /// <remarks>
        /// Maximum number of possessions
        /// </remarks>
        public short MaxAmount
        {
            get => (short)CellsByName["MaxAmount"].Value;
            set => CellsByName["MaxAmount"].Value = value;
        }


        // Def="u8 consumeHeroPoint"
        /// <summary>
        /// Consume Humanity (u8)
        /// </summary>
        /// <remarks>
        /// Consumer nature
        /// </remarks>
        public byte ConsumeHumanity
        {
            get => (byte)CellsByName["ConsumeHumanity"].Value;
            set => CellsByName["ConsumeHumanity"].Value = value;
        }


        // Def="u8 overDexterity"
        /// <summary>
        /// Over Dexterity (u8)
        /// </summary>
        /// <remarks>
        /// Skill over start value
        /// </remarks>
        public byte OverDexterity
        {
            get => (byte)CellsByName["OverDexterity"].Value;
            set => CellsByName["OverDexterity"].Value = value;
        }


        // Def="u8 goodsType"
        /// <summary>
        /// Goods Type (u8)
        /// </summary>
        /// <remarks>
        /// Types of tools
        /// </remarks>
        public byte GoodsType
        {
            get => (byte)CellsByName["GoodsType"].Value;
            set => CellsByName["GoodsType"].Value = value;
        }


        // Def="u8 refCategory"
        /// <summary>
        /// Reference Type (u8)
        /// </summary>
        /// <remarks>
        /// ↓ ID category [Attack, Projectile, Special]
        /// </remarks>
        public byte ReferenceType
        {
            get => (byte)CellsByName["ReferenceType"].Value;
            set => CellsByName["ReferenceType"].Value = value;
        }


        // Def="u8 spEffectCategory"
        /// <summary>
        /// SpEffect Category (u8)
        /// </summary>
        /// <remarks>
        /// Since there are effects (enchantment weapons, etc.) whose parameters fluctuate depending on skills, magic, items, etc., set each action so that the determined effect can correspond to the effect such as "power up only weapon attack". Set "None" for items that do not need to be set, such as varistor.
        /// </remarks>
        public byte SpEffectCategory
        {
            get => (byte)CellsByName["SpEffectCategory"].Value;
            set => CellsByName["SpEffectCategory"].Value = value;
        }


        // Def="dummy8 pad3[1]"
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


        // Def="u8 goodsUseAnim"
        /// <summary>
        /// Goods Use Animation (u8)
        /// </summary>
        /// <remarks>
        /// Set the animation to play when using the tool
        /// </remarks>
        public byte GoodsUseAnimation
        {
            get => (byte)CellsByName["GoodsUseAnimation"].Value;
            set => CellsByName["GoodsUseAnimation"].Value = value;
        }


        // Def="u8 opmeMenuType"
        /// <summary>
        /// Interaction Menu Type (u8)
        /// </summary>
        /// <remarks>
        /// Menu type that opens when using an item
        /// </remarks>
        public byte InteractionMenuType
        {
            get => (byte)CellsByName["InteractionMenuType"].Value;
            set => CellsByName["InteractionMenuType"].Value = value;
        }


        // Def="u8 useLimitCategory"
        /// <summary>
        /// Use Limit Category (u8)
        /// </summary>
        /// <remarks>
        /// Specified to control whether it can be used by the special effect applied
        /// </remarks>
        public byte UseLimitCategory
        {
            get => (byte)CellsByName["UseLimitCategory"].Value;
            set => CellsByName["UseLimitCategory"].Value = value;
        }


        // Def="u8 replaceCategory"
        /// <summary>
        /// Replace Category (u8)
        /// </summary>
        /// <remarks>
        /// Condition category to add to call ID
        /// </remarks>
        public byte ReplaceCategory
        {
            get => (byte)CellsByName["ReplaceCategory"].Value;
            set => CellsByName["ReplaceCategory"].Value = value;
        }


        // Def="dummy8 reserve4[2]"
        /// <summary>
        /// Reserve (dummy8)
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        public object Reserve
        {
            get => (object)CellsByName["Reserve"].Value;
            set => CellsByName["Reserve"].Value = value;
        }


        // Def="u8 enable_live:1"
        /// <summary>
        /// Enable Host Player (u8)
        /// </summary>
        /// <remarks>
        /// Is it possible to use a surviving player?
        /// </remarks>
        public byte EnableHostPlayer
        {
            get => (byte)CellsByName["EnableHostPlayer"].Value;
            set => CellsByName["EnableHostPlayer"].Value = value;
        }


        // Def="u8 enable_gray:1"
        /// <summary>
        /// Enable as Gray Phantom (u8)
        /// </summary>
        /// <remarks>
        /// Can Gray Ghost be used?
        /// </remarks>
        public byte EnableAsGrayPhantom
        {
            get => (byte)CellsByName["EnableAsGrayPhantom"].Value;
            set => CellsByName["EnableAsGrayPhantom"].Value = value;
        }


        // Def="u8 enable_white:1"
        /// <summary>
        /// Enable as White Phantom (u8)
        /// </summary>
        /// <remarks>
        /// Can white ghost be used?
        /// </remarks>
        public byte EnableAsWhitePhantom
        {
            get => (byte)CellsByName["EnableAsWhitePhantom"].Value;
            set => CellsByName["EnableAsWhitePhantom"].Value = value;
        }


        // Def="u8 enable_black:1"
        /// <summary>
        /// Enable as Black Phantom (u8)
        /// </summary>
        /// <remarks>
        /// Is it possible to do a black ghost?
        /// </remarks>
        public byte EnableAsBlackPhantom
        {
            get => (byte)CellsByName["EnableAsBlackPhantom"].Value;
            set => CellsByName["EnableAsBlackPhantom"].Value = value;
        }


        // Def="u8 enable_multi:1"
        /// <summary>
        /// Enable in Multiplayer (u8)
        /// </summary>
        /// <remarks>
        /// Can it be used during multiplayer?
        /// </remarks>
        public byte EnableInMultiplayer
        {
            get => (byte)CellsByName["EnableInMultiplayer"].Value;
            set => CellsByName["EnableInMultiplayer"].Value = value;
        }


        // Def="u8 disable_offline:1"
        /// <summary>
        /// Enable Online Only (u8)
        /// </summary>
        /// <remarks>
        /// Is it unavailable while offline?
        /// </remarks>
        public byte EnableOnlineOnly
        {
            get => (byte)CellsByName["EnableOnlineOnly"].Value;
            set => CellsByName["EnableOnlineOnly"].Value = value;
        }


        // Def="u8 isEquip:1"
        /// <summary>
        /// Is Equippable (u8)
        /// </summary>
        /// <remarks>
        /// Whether it can be equipped
        /// </remarks>
        public byte IsEquippable
        {
            get => (byte)CellsByName["IsEquippable"].Value;
            set => CellsByName["IsEquippable"].Value = value;
        }


        // Def="u8 isConsume:1"
        /// <summary>
        /// Is Consumed (u8)
        /// </summary>
        /// <remarks>
        /// Will it be consumed when used (whether the number of possessions will decrease)
        /// </remarks>
        public byte IsConsumed
        {
            get => (byte)CellsByName["IsConsumed"].Value;
            set => CellsByName["IsConsumed"].Value = value;
        }


        // Def="u8 isAutoEquip:1"
        /// <summary>
        /// Is Auto Equipped (u8)
        /// </summary>
        /// <remarks>
        /// Will it be equipped automatically when picked up?
        /// </remarks>
        public byte IsAutoEquipped
        {
            get => (byte)CellsByName["IsAutoEquipped"].Value;
            set => CellsByName["IsAutoEquipped"].Value = value;
        }


        // Def="u8 isEstablishment:1"
        /// <summary>
        /// Is Guidance Item (u8)
        /// </summary>
        /// <remarks>
        /// Is it a stationary item?
        /// </remarks>
        public byte IsGuidanceItem
        {
            get => (byte)CellsByName["IsGuidanceItem"].Value;
            set => CellsByName["IsGuidanceItem"].Value = value;
        }


        // Def="u8 isOnlyOne:1"
        /// <summary>
        /// Is Unique Item (u8)
        /// </summary>
        /// <remarks>
        /// Is it an item that you can only have one?
        /// </remarks>
        public byte IsUniqueItem
        {
            get => (byte)CellsByName["IsUniqueItem"].Value;
            set => CellsByName["IsUniqueItem"].Value = value;
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


        // Def="u8 isDisableHand:1"
        /// <summary>
        /// Disable if Right Hand is Empty (u8)
        /// </summary>
        /// <remarks>
        /// Can't be used when the right-handed weapon is bare-handed?
        /// </remarks>
        public byte DisableIfRightHandIsEmpty
        {
            get => (byte)CellsByName["DisableIfRightHandIsEmpty"].Value;
            set => CellsByName["DisableIfRightHandIsEmpty"].Value = value;
        }


        // Def="u8 isRemoveItem_forGameClear:1"
        /// <summary>
        /// Remove Item on Game Clear (u8)
        /// </summary>
        /// <remarks>
        /// Whether to delete at the time of lap
        /// </remarks>
        public byte RemoveItemOnGameClear
        {
            get => (byte)CellsByName["RemoveItemOnGameClear"].Value;
            set => CellsByName["RemoveItemOnGameClear"].Value = value;
        }


        // Def="u8 isSuppleItem:1"
        /// <summary>
        /// Is Regenerative Item (u8)
        /// </summary>
        /// <remarks>
        /// Used to determine replenishable items
        /// </remarks>
        public byte IsRegenerativeItem
        {
            get => (byte)CellsByName["IsRegenerativeItem"].Value;
            set => CellsByName["IsRegenerativeItem"].Value = value;
        }


        // Def="u8 isFullSuppleItem:1"
        /// <summary>
        /// Is Full Regenerative Item (u8)
        /// </summary>
        /// <remarks>
        /// Used to determine replenished items
        /// </remarks>
        public byte IsFullRegenerativeItem
        {
            get => (byte)CellsByName["IsFullRegenerativeItem"].Value;
            set => CellsByName["IsFullRegenerativeItem"].Value = value;
        }


        // Def="u8 isEnhance:1"
        /// <summary>
        /// Is Enhancement Item (u8)
        /// </summary>
        /// <remarks>
        /// Do you want to enchant your weapon?
        /// </remarks>
        public byte IsEnhancementItem
        {
            get => (byte)CellsByName["IsEnhancementItem"].Value;
            set => CellsByName["IsEnhancementItem"].Value = value;
        }


        // Def="u8 isFixItem:1"
        /// <summary>
        /// Can Repair Item (u8)
        /// </summary>
        /// <remarks>
        /// Is it an item to repair?
        /// </remarks>
        public byte CanRepairItem
        {
            get => (byte)CellsByName["CanRepairItem"].Value;
            set => CellsByName["CanRepairItem"].Value = value;
        }


        // Def="u8 disableMultiDropShare:1"
        /// <summary>
        /// Disable Dropping in Multiplayer (u8)
        /// </summary>
        /// <remarks>
        /// Is multi-drop sharing prohibited?
        /// </remarks>
        public byte DisableDroppingInMultiplayer
        {
            get => (byte)CellsByName["DisableDroppingInMultiplayer"].Value;
            set => CellsByName["DisableDroppingInMultiplayer"].Value = value;
        }


        // Def="u8 disableUseAtColiseum:1"
        /// <summary>
        /// Disable Usage in Multiplayer Arena (u8)
        /// </summary>
        /// <remarks>
        /// Is it prohibited to use in the arena?
        /// </remarks>
        public byte DisableUsageInMultiplayerArena
        {
            get => (byte)CellsByName["DisableUsageInMultiplayerArena"].Value;
            set => CellsByName["DisableUsageInMultiplayerArena"].Value = value;
        }


        // Def="u8 disableUseAtOutOfColiseum:1"
        /// <summary>
        /// Disable Usage outside of Multiplayer Arena (u8)
        /// </summary>
        /// <remarks>
        /// Is it prohibited to use outside the arena?
        /// </remarks>
        public byte DisableUsageOutsideOfMultiplayerArena
        {
            get => (byte)CellsByName["DisableUsageOutsideOfMultiplayerArena"].Value;
            set => CellsByName["DisableUsageOutsideOfMultiplayerArena"].Value = value;
        }


        // Def="u8 isEnableFastUseItem:1"
        /// <summary>
        /// Can Cancel Application Early (u8)
        /// </summary>
        /// <remarks>
        /// Is it possible to cancel early?
        /// </remarks>
        public byte CanCancelApplicationEarly
        {
            get => (byte)CellsByName["CanCancelApplicationEarly"].Value;
            set => CellsByName["CanCancelApplicationEarly"].Value = value;
        }


        // Def="u8 isApplySpecialEffect:1"
        /// <summary>
        /// Apply SpEffect Modifiers (u8)
        /// </summary>
        /// <remarks>
        /// Whether to reflect special effects (such as ability value correction)
        /// </remarks>
        public byte ApplySpEffectModifiers
        {
            get => (byte)CellsByName["ApplySpEffectModifiers"].Value;
            set => CellsByName["ApplySpEffectModifiers"].Value = value;
        }


        // Def="u8 syncNumVaryId"
        /// <summary>
        /// Synchronized Item Usage ID (u8)
        /// </summary>
        /// <remarks>
        /// When the number of items is changed, the items with the same ID will be changed at the same time. 0: Not synchronized
        /// </remarks>
        public byte SynchronizedItemUsageID
        {
            get => (byte)CellsByName["SynchronizedItemUsageID"].Value;
            set => CellsByName["SynchronizedItemUsageID"].Value = value;
        }


        // Def="s32 refId_1 = -1"
        /// <summary>
        /// Reference ID - Left Hand (s32)
        /// </summary>
        /// <remarks>
        /// ID1 called from the item
        /// </remarks>
        public int ReferenceIDLeftHand
        {
            get => (int)CellsByName["ReferenceIDLeftHand"].Value;
            set => CellsByName["ReferenceIDLeftHand"].Value = value;
        }


        // Def="s32 refVirtualWepId = -1"
        /// <summary>
        /// Weapon Reference ID (s32)
        /// </summary>
        /// <remarks>
        /// Weapon ID to refer to when using the tool
        /// </remarks>
        public int WeaponReferenceID
        {
            get => (int)CellsByName["WeaponReferenceID"].Value;
            set => CellsByName["WeaponReferenceID"].Value = value;
        }


        // Def="s32 vagrantItemLotId"
        /// <summary>
        /// Vagrant Item Lot ID (s32)
        /// </summary>
        /// <remarks>
        /// -1: No vagrant 0: No lottery 1 ~: With lottery
        /// </remarks>
        public int VagrantItemLotID
        {
            get => (int)CellsByName["VagrantItemLotID"].Value;
            set => CellsByName["VagrantItemLotID"].Value = value;
        }


        // Def="s32 vagrantBonusEneDropItemLotId"
        /// <summary>
        /// Vagrant Enemy Item Lot ID (s32)
        /// </summary>
        /// <remarks>
        /// -1: No drop 0: No lottery 1 ~: With lottery
        /// </remarks>
        public int VagrantEnemyItemLotID
        {
            get => (int)CellsByName["VagrantEnemyItemLotID"].Value;
            set => CellsByName["VagrantEnemyItemLotID"].Value = value;
        }


        // Def="s32 vagrantItemEneDropItemLotId"
        /// <summary>
        /// Vagrant Bonus Item Lot ID (s32)
        /// </summary>
        /// <remarks>
        /// -1: No drop 0: No lottery 1 ~: With lottery
        /// </remarks>
        public int VagrantBonusItemLotID
        {
            get => (int)CellsByName["VagrantBonusItemLotID"].Value;
            set => CellsByName["VagrantBonusItemLotID"].Value = value;
        }


        // Def="s32 castSfxId = -1"
        /// <summary>
        /// Usage VFX - Cast (s32)
        /// </summary>
        /// <remarks>
        /// SFXID until the effect is activated when you try to use the item
        /// </remarks>
        public int UsageVFXCast
        {
            get => (int)CellsByName["UsageVFXCast"].Value;
            set => CellsByName["UsageVFXCast"].Value = value;
        }


        // Def="s32 fireSfxId = -1"
        /// <summary>
        /// Usage VFX  - Activate (s32)
        /// </summary>
        /// <remarks>
        /// SFX ID when the item is activated
        /// </remarks>
        public int UsageVFXActivate
        {
            get => (int)CellsByName["UsageVFXActivate"].Value;
            set => CellsByName["UsageVFXActivate"].Value = value;
        }


        // Def="s32 effectSfxId = -1"
        /// <summary>
        /// Usage VFX - Effect (s32)
        /// </summary>
        /// <remarks>
        /// After the item is activated, the SFX ID in effect
        /// </remarks>
        public int UsageVFXEffect
        {
            get => (int)CellsByName["UsageVFXEffect"].Value;
            set => CellsByName["UsageVFXEffect"].Value = value;
        }


        // Def="u8 enable_ActiveBigRune:1"
        /// <summary>
        /// Usable with Great Rune Active (u8)
        /// </summary>
        /// <remarks>
        /// Can it be used with a large rune activated?
        /// </remarks>
        public byte UsableWithGreatRuneActive
        {
            get => (byte)CellsByName["UsableWithGreatRuneActive"].Value;
            set => CellsByName["UsableWithGreatRuneActive"].Value = value;
        }


        // Def="u8 isBonfireWarpItem:1"
        /// <summary>
        /// Is Bonfire Warp Item (u8)
        /// </summary>
        /// <remarks>
        /// If the state change type "Warp Prohibition" is applied when TRUE, remove the function to disable the item.
        /// </remarks>
        public byte IsBonfireWarpItem
        {
            get => (byte)CellsByName["IsBonfireWarpItem"].Value;
            set => CellsByName["IsBonfireWarpItem"].Value = value;
        }


        // Def="u8 enable_Ladder:1"
        /// <summary>
        /// Enable on Ladder (u8)
        /// </summary>
        /// <remarks>
        /// Check here for items available in the ladder
        /// </remarks>
        public byte EnableOnLadder
        {
            get => (byte)CellsByName["EnableOnLadder"].Value;
            set => CellsByName["EnableOnLadder"].Value = value;
        }


        // Def="u8 isUseMultiPlayPreparation:1"
        /// <summary>
        /// Usable before Multiplayer Session (u8)
        /// </summary>
        /// <remarks>
        /// Whether items can be used between session probability and initial synchronization
        /// </remarks>
        public byte UsableBeforeMultiplayerSession
        {
            get => (byte)CellsByName["UsableBeforeMultiplayerSession"].Value;
            set => CellsByName["UsableBeforeMultiplayerSession"].Value = value;
        }


        // Def="u8 canMultiUse:1"
        /// <summary>
        /// Usable in Multiplayer (u8)
        /// </summary>
        /// <remarks>
        /// Can it be used together?
        /// </remarks>
        public byte UsableInMultiplayer
        {
            get => (byte)CellsByName["UsableInMultiplayer"].Value;
            set => CellsByName["UsableInMultiplayer"].Value = value;
        }


        // Def="u8 isShieldEnchant:1"
        /// <summary>
        /// Is Shield Enchantment (u8)
        /// </summary>
        /// <remarks>
        /// Is it a shield enchantment?
        /// </remarks>
        public byte IsShieldEnchantment
        {
            get => (byte)CellsByName["IsShieldEnchantment"].Value;
            set => CellsByName["IsShieldEnchantment"].Value = value;
        }


        // Def="u8 isWarpProhibited:1"
        /// <summary>
        /// Is Warp Prohibited (u8)
        /// </summary>
        /// <remarks>
        /// When this is TRUE, disable the item if the state change type "Warp Prohibition" is applied.
        /// </remarks>
        public byte IsWarpProhibited
        {
            get => (byte)CellsByName["IsWarpProhibited"].Value;
            set => CellsByName["IsWarpProhibited"].Value = value;
        }


        // Def="u8 isUseMultiPenaltyOnly:1"
        /// <summary>
        /// Usable if Disconnect Penalty is Active (u8)
        /// </summary>
        /// <remarks>
        /// A flag that allows you to determine if an item is only available when a client disconnect penalty is incurred.
        /// </remarks>
        public byte UsableIfDisconnectPenaltyIsActive
        {
            get => (byte)CellsByName["UsableIfDisconnectPenaltyIsActive"].Value;
            set => CellsByName["UsableIfDisconnectPenaltyIsActive"].Value = value;
        }


        // Def="u8 suppleType"
        /// <summary>
        /// Regenerative Item Type (u8)
        /// </summary>
        /// <remarks>
        /// Replenishment item / Replenishment type when replenishing a replenished item.
        /// </remarks>
        public byte RegenerativeItemType
        {
            get => (byte)CellsByName["RegenerativeItemType"].Value;
            set => CellsByName["RegenerativeItemType"].Value = value;
        }


        // Def="u8 autoReplenishType"
        /// <summary>
        /// Auto Replenishment Type (u8)
        /// </summary>
        /// <remarks>
        /// Controls whether or not to automatically replenish and default settings
        /// </remarks>
        public byte AutoReplenishmentType
        {
            get => (byte)CellsByName["AutoReplenishmentType"].Value;
            set => CellsByName["AutoReplenishmentType"].Value = value;
        }


        // Def="u8 isDrop:1"
        /// <summary>
        /// Can be Dropped (u8)
        /// </summary>
        /// <remarks>
        /// Can I put the item on the spot? TRUE = can be placed
        /// </remarks>
        public byte CanBeDropped
        {
            get => (byte)CellsByName["CanBeDropped"].Value;
            set => CellsByName["CanBeDropped"].Value = value;
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


        // Def="u8 isSummonHorse:1"
        /// <summary>
        /// Is Horse Summon (u8)
        /// </summary>
        /// <remarks>
        /// Is it an item that summons a horse? Cannot be used if the horse died or the PC is in a horse-prohibited area
        /// </remarks>
        public byte IsHorseSummon
        {
            get => (byte)CellsByName["IsHorseSummon"].Value;
            set => CellsByName["IsHorseSummon"].Value = value;
        }


        // Def="u8 showDialogCondType:2 = 2"
        /// <summary>
        /// Item Acquisition Dialog Condition Type (u8)
        /// </summary>
        /// <remarks>
        /// Whether to display it in the item acquisition dialog when acquiring an item (not entered: new only)
        /// </remarks>
        public byte ItemAcquisitionDialogConditionType
        {
            get => (byte)CellsByName["ItemAcquisitionDialogConditionType"].Value;
            set => CellsByName["ItemAcquisitionDialogConditionType"].Value = value;
        }


        // Def="u8 isSleepCollectionItem:1"
        /// <summary>
        /// Is Sleep Collection Item (u8)
        /// </summary>
        /// <remarks>
        /// Is it a Nemuri collection item?
        /// </remarks>
        public byte IsSleepCollectionItem
        {
            get => (byte)CellsByName["IsSleepCollectionItem"].Value;
            set => CellsByName["IsSleepCollectionItem"].Value = value;
        }


        // Def="u8 enableRiding:1"
        /// <summary>
        /// Enabled while Riding (u8)
        /// </summary>
        /// <remarks>
        /// Can it be used while riding?
        /// </remarks>
        public byte EnabledWhileRiding
        {
            get => (byte)CellsByName["EnabledWhileRiding"].Value;
            set => CellsByName["EnabledWhileRiding"].Value = value;
        }


        // Def="u8 disableRiding:1"
        /// <summary>
        /// Disabled while Riding (u8)
        /// </summary>
        /// <remarks>
        /// Is it prohibited to use while not riding?
        /// </remarks>
        public byte DisabledWhileRiding
        {
            get => (byte)CellsByName["DisabledWhileRiding"].Value;
            set => CellsByName["DisabledWhileRiding"].Value = value;
        }


        // Def="s16 maxRepositoryNum"
        /// <summary>
        /// Max Number Stored in Itembox (s16)
        /// </summary>
        /// <remarks>
        /// Number of warehouses
        /// </remarks>
        public short MaxNumberStoredInItembox
        {
            get => (short)CellsByName["MaxNumberStoredInItembox"].Value;
            set => CellsByName["MaxNumberStoredInItembox"].Value = value;
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


        // Def="u8 isUseNoAttackRegion:1 = 1"
        /// <summary>
        /// Enabled in No Attack Region (u8)
        /// </summary>
        /// <remarks>
        /// Can it be used in an attack-prohibited area?
        /// </remarks>
        public byte EnabledInNoAttackRegion
        {
            get => (byte)CellsByName["EnabledInNoAttackRegion"].Value;
            set => CellsByName["EnabledInNoAttackRegion"].Value = value;
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
            set => CellsByName["SaleValue"].Value = value;
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


        // Def="u8 useLimitSummonBuddy"
        /// <summary>
        /// Use Limit - Spirit Summon (u8)
        /// </summary>
        /// <remarks>
        /// Whether there are item usage restrictions for buddy items
        /// </remarks>
        public byte UseLimitSpiritSummon
        {
            get => (byte)CellsByName["UseLimitSpiritSummon"].Value;
            set => CellsByName["UseLimitSpiritSummon"].Value = value;
        }


        // Def="u16 useLimitSpEffectType"
        /// <summary>
        /// Use Limit - SpEffect Type (u16)
        /// </summary>
        /// <remarks>
        /// Specified to control whether it can be used depending on the state change type of the special effect applied
        /// </remarks>
        public ushort UseLimitSpEffectType
        {
            get => (ushort)CellsByName["UseLimitSpEffectType"].Value;
            set => CellsByName["UseLimitSpEffectType"].Value = value;
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
            set => CellsByName["AIUsageJudgmentID"].Value = value;
        }


        // Def="s16 consumeMP"
        /// <summary>
        /// FP Cost (s16)
        /// </summary>
        /// <remarks>
        /// MP consumption
        /// </remarks>
        public short FPCost
        {
            get => (short)CellsByName["FPCost"].Value;
            set => CellsByName["FPCost"].Value = value;
        }


        // Def="s16 consumeHP = -1"
        /// <summary>
        /// HP Cost (s16)
        /// </summary>
        /// <remarks>
        /// HP consumed
        /// </remarks>
        public short HPCost
        {
            get => (short)CellsByName["HPCost"].Value;
            set => CellsByName["HPCost"].Value = value;
        }


        // Def="s32 reinforceGoodsId = -1"
        /// <summary>
        /// Reinforcement Goods ID (s32)
        /// </summary>
        /// <remarks>
        /// Strengthening tool ID
        /// </remarks>
        public int ReinforcementGoodsID
        {
            get => (int)CellsByName["ReinforcementGoodsID"].Value;
            set => CellsByName["ReinforcementGoodsID"].Value = value;
        }


        // Def="s32 reinforceMaterialId = -1"
        /// <summary>
        /// Reinforcement Material ID (s32)
        /// </summary>
        /// <remarks>
        /// Material ID at the time of strengthening
        /// </remarks>
        public int ReinforcementMaterialID
        {
            get => (int)CellsByName["ReinforcementMaterialID"].Value;
            set => CellsByName["ReinforcementMaterialID"].Value = value;
        }


        // Def="s32 reinforcePrice"
        /// <summary>
        /// Reinforcement Cost (s32)
        /// </summary>
        /// <remarks>
        /// Enhanced price
        /// </remarks>
        public int ReinforcementCost
        {
            get => (int)CellsByName["ReinforcementCost"].Value;
            set => CellsByName["ReinforcementCost"].Value = value;
        }


        // Def="s8 useLevel_vowType0"
        /// <summary>
        /// Use Level - Vow Level [0] (s8)
        /// </summary>
        /// <remarks>
        /// Pledge 0 usage level
        /// </remarks>
        public sbyte UseLevelVowLevel0
        {
            get => (sbyte)CellsByName["UseLevelVowLevel0"].Value;
            set => CellsByName["UseLevelVowLevel0"].Value = value;
        }


        // Def="s8 useLevel_vowType1"
        /// <summary>
        /// Use Level - Vow Level [1] (s8)
        /// </summary>
        /// <remarks>
        /// Pledge 1 usage level
        /// </remarks>
        public sbyte UseLevelVowLevel1
        {
            get => (sbyte)CellsByName["UseLevelVowLevel1"].Value;
            set => CellsByName["UseLevelVowLevel1"].Value = value;
        }


        // Def="s8 useLevel_vowType2"
        /// <summary>
        /// Use Level - Vow Level [2] (s8)
        /// </summary>
        /// <remarks>
        /// Pledge 2 usage level
        /// </remarks>
        public sbyte UseLevelVowLevel2
        {
            get => (sbyte)CellsByName["UseLevelVowLevel2"].Value;
            set => CellsByName["UseLevelVowLevel2"].Value = value;
        }


        // Def="s8 useLevel_vowType3"
        /// <summary>
        /// Use Level - Vow Level [3] (s8)
        /// </summary>
        /// <remarks>
        /// Pledge 3 usage level
        /// </remarks>
        public sbyte UseLevelVowLevel3
        {
            get => (sbyte)CellsByName["UseLevelVowLevel3"].Value;
            set => CellsByName["UseLevelVowLevel3"].Value = value;
        }


        // Def="s8 useLevel_vowType4"
        /// <summary>
        /// Use Level - Vow Level [4] (s8)
        /// </summary>
        /// <remarks>
        /// Pledge 4 usage level
        /// </remarks>
        public sbyte UseLevelVowLevel4
        {
            get => (sbyte)CellsByName["UseLevelVowLevel4"].Value;
            set => CellsByName["UseLevelVowLevel4"].Value = value;
        }


        // Def="s8 useLevel_vowType5"
        /// <summary>
        /// Use Level - Vow Level [5] (s8)
        /// </summary>
        /// <remarks>
        /// Pledge 5 usage level
        /// </remarks>
        public sbyte UseLevelVowLevel5
        {
            get => (sbyte)CellsByName["UseLevelVowLevel5"].Value;
            set => CellsByName["UseLevelVowLevel5"].Value = value;
        }


        // Def="s8 useLevel_vowType6"
        /// <summary>
        /// Use Level - Vow Level [6] (s8)
        /// </summary>
        /// <remarks>
        /// Pledge 6 usage level
        /// </remarks>
        public sbyte UseLevelVowLevel6
        {
            get => (sbyte)CellsByName["UseLevelVowLevel6"].Value;
            set => CellsByName["UseLevelVowLevel6"].Value = value;
        }


        // Def="s8 useLevel_vowType7"
        /// <summary>
        /// Use Level - Vow Level [7] (s8)
        /// </summary>
        /// <remarks>
        /// Pledge 7 usage level
        /// </remarks>
        public sbyte UseLevelVowLevel7
        {
            get => (sbyte)CellsByName["UseLevelVowLevel7"].Value;
            set => CellsByName["UseLevelVowLevel7"].Value = value;
        }


        // Def="s8 useLevel_vowType8"
        /// <summary>
        /// Use Level - Vow Level [8] (s8)
        /// </summary>
        /// <remarks>
        /// Pledge 8 usage level
        /// </remarks>
        public sbyte UseLevelVowLevel8
        {
            get => (sbyte)CellsByName["UseLevelVowLevel8"].Value;
            set => CellsByName["UseLevelVowLevel8"].Value = value;
        }


        // Def="s8 useLevel_vowType9"
        /// <summary>
        /// Use Level - Vow Level [9] (s8)
        /// </summary>
        /// <remarks>
        /// Pledge 9 usage level
        /// </remarks>
        public sbyte UseLevelVowLevel9
        {
            get => (sbyte)CellsByName["UseLevelVowLevel9"].Value;
            set => CellsByName["UseLevelVowLevel9"].Value = value;
        }


        // Def="s8 useLevel_vowType10"
        /// <summary>
        /// Use Level - Vow Level [10] (s8)
        /// </summary>
        /// <remarks>
        /// Pledge 10 usage level
        /// </remarks>
        public sbyte UseLevelVowLevel10
        {
            get => (sbyte)CellsByName["UseLevelVowLevel10"].Value;
            set => CellsByName["UseLevelVowLevel10"].Value = value;
        }


        // Def="s8 useLevel_vowType11"
        /// <summary>
        /// Use Level - Vow Level [11] (s8)
        /// </summary>
        /// <remarks>
        /// Pledge 11 usage level
        /// </remarks>
        public sbyte UseLevelVowLevel11
        {
            get => (sbyte)CellsByName["UseLevelVowLevel11"].Value;
            set => CellsByName["UseLevelVowLevel11"].Value = value;
        }


        // Def="s8 useLevel_vowType12"
        /// <summary>
        /// Use Level - Vow Level [12] (s8)
        /// </summary>
        /// <remarks>
        /// Pledge 12 usage level
        /// </remarks>
        public sbyte UseLevelVowLevel12
        {
            get => (sbyte)CellsByName["UseLevelVowLevel12"].Value;
            set => CellsByName["UseLevelVowLevel12"].Value = value;
        }


        // Def="s8 useLevel_vowType13"
        /// <summary>
        /// Use Level - Vow Level [13] (s8)
        /// </summary>
        /// <remarks>
        /// Pledge 13 usage level
        /// </remarks>
        public sbyte UseLevelVowLevel13
        {
            get => (sbyte)CellsByName["UseLevelVowLevel13"].Value;
            set => CellsByName["UseLevelVowLevel13"].Value = value;
        }


        // Def="s8 useLevel_vowType14"
        /// <summary>
        /// Use Level - Vow Level [14] (s8)
        /// </summary>
        /// <remarks>
        /// Pledge 14 usage level
        /// </remarks>
        public sbyte UseLevelVowLevel14
        {
            get => (sbyte)CellsByName["UseLevelVowLevel14"].Value;
            set => CellsByName["UseLevelVowLevel14"].Value = value;
        }


        // Def="s8 useLevel_vowType15"
        /// <summary>
        /// Use Level - Vow Level [15] (s8)
        /// </summary>
        /// <remarks>
        /// Pledge 15 usage level
        /// </remarks>
        public sbyte UseLevelVowLevel15
        {
            get => (sbyte)CellsByName["UseLevelVowLevel15"].Value;
            set => CellsByName["UseLevelVowLevel15"].Value = value;
        }


        // Def="u16 useLevel"
        /// <summary>
        /// Use Level (u16)
        /// </summary>
        /// <remarks>
        /// Appropriate level of use
        /// </remarks>
        public ushort UseLevel
        {
            get => (ushort)CellsByName["UseLevel"].Value;
            set => CellsByName["UseLevel"].Value = value;
        }


        // Def="dummy8 reserve5[2]"
        /// <summary>
        /// Reserved area (dummy8)
        /// </summary>
        /// <remarks>
        /// Reserved area
        /// </remarks>
        public object ReservedArea
        {
            get => (object)CellsByName["ReservedArea"].Value;
            set => CellsByName["ReservedArea"].Value = value;
        }


        // Def="u32 itemGetTutorialFlagId"
        /// <summary>
        /// Item Get Tutorial Flag ID (u32)
        /// </summary>
        /// <remarks>
        /// Event flag ID for the tutorial when you first get the item. Flag ON when item is obtained.
        /// </remarks>
        public uint ItemGetTutorialFlagID
        {
            get => (uint)CellsByName["ItemGetTutorialFlagID"].Value;
            set => CellsByName["ItemGetTutorialFlagID"].Value = value;
        }


    }
}

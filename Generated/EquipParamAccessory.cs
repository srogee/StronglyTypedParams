
namespace StronglyTypedParams
{
    public class EquipParamAccessory : ParamRow
    {
        public EquipParamAccessory() : base()
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


        // Def="s32 refId = -1"
        /// <summary>
        /// Reference ID (s32)
        /// </summary>
        /// <remarks>
        /// ID called from decorations
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


        // Def="s32 behaviorId"
        /// <summary>
        /// Behavior ID (s32)
        /// </summary>
        /// <remarks>
        /// Action ID (= Skill)
        /// </remarks>
        public int BehaviorID
        {
            get => (int)CellsByName["BehaviorID"].Value;
            set => CellsByName["BehaviorID"].Value = value;
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


        // Def="s32 sortId"
        /// <summary>
        /// Sort ID (s32)
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        public int SortID
        {
            get => (int)CellsByName["SortID"].Value;
            set => CellsByName["SortID"].Value = value;
        }


        // Def="s32 qwcId = -1"
        /// <summary>
        /// QWC ID (s32)
        /// </summary>
        /// <remarks>
        /// 
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
        /// Equipment model number
        /// </remarks>
        public ushort EquipModelID
        {
            get => (ushort)CellsByName["EquipModelID"].Value;
            set => CellsByName["EquipModelID"].Value = value;
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


        // Def="s16 trophySGradeId = -1"
        /// <summary>
        /// Achievement Grade ID (s16)
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        public short AchievementGradeID
        {
            get => (short)CellsByName["AchievementGradeID"].Value;
            set => CellsByName["AchievementGradeID"].Value = value;
        }


        // Def="s16 trophySeqId = -1"
        /// <summary>
        /// Achievement Sequential ID (s16)
        /// </summary>
        /// <remarks>
        /// Trophy SEQ number
        /// </remarks>
        public short AchievementSequentialID
        {
            get => (short)CellsByName["AchievementSequentialID"].Value;
            set => CellsByName["AchievementSequentialID"].Value = value;
        }


        // Def="u8 equipModelCategory"
        /// <summary>
        /// Equip Model Category (u8)
        /// </summary>
        /// <remarks>
        /// Equipment model type
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
        /// Gender of equipment model
        /// </remarks>
        public byte EquipModelGender
        {
            get => (byte)CellsByName["EquipModelGender"].Value;
            set => CellsByName["EquipModelGender"].Value = value;
        }


        // Def="u8 accessoryCategory"
        /// <summary>
        /// Accessory Type (u8)
        /// </summary>
        /// <remarks>
        /// Armor category
        /// </remarks>
        public byte AccessoryType
        {
            get => (byte)CellsByName["AccessoryType"].Value;
            set => CellsByName["AccessoryType"].Value = value;
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
        /// - スキルや、魔法、アイテムなどで、パラメータが変動する効果（エンチャントウェポンなど）があるので、│定した効果が、「武器攻撃のみをパワーアップする」といった効果に対応できるように行動ごとに設定するバリスタなど、設定の必要のないものは「なし」を設定する
        ///
        /// </remarks>
        public byte SpEffectCategory
        {
            get => (byte)CellsByName["SpEffectCategory"].Value;
            set => CellsByName["SpEffectCategory"].Value = value;
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


        // Def="s32 vagrantItemEneDropItemLotId"
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


        // Def="u8 isDeposit:1"
        /// <summary>
        /// Is Depositable (u8)
        /// </summary>
        /// <remarks>
        /// Can you deposit it in the warehouse?
        /// </remarks>
        public byte IsDepositable
        {
            get => (byte)CellsByName["IsDepositable"].Value;
            set => CellsByName["IsDepositable"].Value = value;
        }


        // Def="u8 isEquipOutBrake:1"
        /// <summary>
        /// Is Destroyed on Unequip (u8)
        /// </summary>
        /// <remarks>
        /// Will it break when equipped and removed?
        /// </remarks>
        public byte IsDestroyedOnUnequip
        {
            get => (byte)CellsByName["IsDestroyedOnUnequip"].Value;
            set => CellsByName["IsDestroyedOnUnequip"].Value = value;
        }


        // Def="u8 disableMultiDropShare:1"
        /// <summary>
        /// Is Dropping Disabled in Multiplayer (u8)
        /// </summary>
        /// <remarks>
        /// Is multi-drop sharing prohibited?
        /// </remarks>
        public byte IsDroppingDisabledInMultiplayer
        {
            get => (byte)CellsByName["IsDroppingDisabledInMultiplayer"].Value;
            set => CellsByName["IsDroppingDisabledInMultiplayer"].Value = value;
        }


        // Def="u8 isDiscard:1"
        /// <summary>
        /// Is Discardable (u8)
        /// </summary>
        /// <remarks>
        /// Can you throw away the item? TRUE = thrown away
        /// </remarks>
        public byte IsDiscardable
        {
            get => (byte)CellsByName["IsDiscardable"].Value;
            set => CellsByName["IsDiscardable"].Value = value;
        }


        // Def="u8 isDrop:1"
        /// <summary>
        /// Is Droppable (u8)
        /// </summary>
        /// <remarks>
        /// Can I put the item on the spot? TRUE = can be placed
        /// </remarks>
        public byte IsDroppable
        {
            get => (byte)CellsByName["IsDroppable"].Value;
            set => CellsByName["IsDroppable"].Value = value;
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


        // Def="dummy8 pad2[2]"
        /// <summary>
        /// pad (dummy8)
        /// </summary>
        /// <remarks>
        /// (Old log icon ID)
        /// </remarks>
        public object Pad
        {
            get => (object)CellsByName["Pad"].Value;
            set => CellsByName["Pad"].Value = value;
        }


        // Def="s32 saleValue = -1"
        /// <summary>
        /// Sale Price (s32)
        /// </summary>
        /// <remarks>
        /// Selling price
        /// </remarks>
        public int SalePrice
        {
            get => (int)CellsByName["SalePrice"].Value;
            set => CellsByName["SalePrice"].Value = value;
        }


        // Def="s16 accessoryGroup = -1"
        /// <summary>
        /// Accessory Group (s16)
        /// </summary>
        /// <remarks>
        /// Items of the same group cannot be equipped at the same time
        /// </remarks>
        public short AccessoryGroup
        {
            get => (short)CellsByName["AccessoryGroup"].Value;
            set => CellsByName["AccessoryGroup"].Value = value;
        }



        // Def="s8 compTrophySedId = -1"
        /// <summary>
        /// Number of Completed Achievement ID (s8)
        /// </summary>
        /// <remarks>
        /// SEQ number of complete trophy
        /// </remarks>
        public sbyte NumberOfCompletedAchievementID
        {
            get => (sbyte)CellsByName["NumberOfCompletedAchievementID"].Value;
            set => CellsByName["NumberOfCompletedAchievementID"].Value = value;
        }


        // Def="s32 residentSpEffectId1"
        /// <summary>
        /// SpEffect ID [1] (s32)
        /// </summary>
        /// <remarks>
        /// Resident special effect ID1
        /// </remarks>
        public int SpEffectID1
        {
            get => (int)CellsByName["SpEffectID1"].Value;
            set => CellsByName["SpEffectID1"].Value = value;
        }


        // Def="s32 residentSpEffectId2"
        /// <summary>
        /// SpEffect ID [2] (s32)
        /// </summary>
        /// <remarks>
        /// Resident special effect ID2
        /// </remarks>
        public int SpEffectID2
        {
            get => (int)CellsByName["SpEffectID2"].Value;
            set => CellsByName["SpEffectID2"].Value = value;
        }


        // Def="s32 residentSpEffectId3"
        /// <summary>
        /// SpEffect ID [3] (s32)
        /// </summary>
        /// <remarks>
        /// Resident special effect ID3
        /// </remarks>
        public int SpEffectID3
        {
            get => (int)CellsByName["SpEffectID3"].Value;
            set => CellsByName["SpEffectID3"].Value = value;
        }


        // Def="s32 residentSpEffectId4"
        /// <summary>
        /// SpEffect ID [4] (s32)
        /// </summary>
        /// <remarks>
        /// Resident special effect ID4
        /// </remarks>
        public int SpEffectID4
        {
            get => (int)CellsByName["SpEffectID4"].Value;
            set => CellsByName["SpEffectID4"].Value = value;
        }


    }
}

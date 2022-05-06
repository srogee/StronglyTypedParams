
            namespace StronglyTypedParams
            {
                public class EquipParamGem : ParamRow
                {
                    public EquipParamGem() : base()
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
            

            // Def="s8 rank"
            /// <summary>
            /// Rank (s8)
            /// </summary>
            /// <remarks>
            /// Magic stone rank
            /// </remarks>
            public sbyte Rank 
            {
                get => (sbyte)CellsByName["Rank"].Value;
                set => CellsByName["Rank"].Value = value;
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
            

            // Def="s32 spEffectId0 = -1"
            /// <summary>
            /// SpEffect ID [0] (s32)
            /// </summary>
            /// <remarks>
            /// Special effect ID00
            /// </remarks>
            public int SpEffectID0 
            {
                get => (int)CellsByName["SpEffectID0"].Value;
                set => CellsByName["SpEffectID0"].Value = value;
            }
            

            // Def="s32 spEffectId1 = -1"
            /// <summary>
            /// SpEffect ID [1] (s32)
            /// </summary>
            /// <remarks>
            /// Special effect ID01
            /// </remarks>
            public int SpEffectID1 
            {
                get => (int)CellsByName["SpEffectID1"].Value;
                set => CellsByName["SpEffectID1"].Value = value;
            }
            

            // Def="s32 spEffectId2 = -1"
            /// <summary>
            /// SpEffect ID [2] (s32)
            /// </summary>
            /// <remarks>
            /// Special effect ID02
            /// </remarks>
            public int SpEffectID2 
            {
                get => (int)CellsByName["SpEffectID2"].Value;
                set => CellsByName["SpEffectID2"].Value = value;
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
            

            // Def="s32 swordArtsParamId = -1"
            /// <summary>
            /// Sword Arts ID (s32)
            /// </summary>
            /// <remarks>
            /// ID of the destination arts parameter
            /// </remarks>
            public int SwordArtsID 
            {
                get => (int)CellsByName["SwordArtsID"].Value;
                set => CellsByName["SwordArtsID"].Value = value;
            }
            

            // Def="s32 mountValue"
            /// <summary>
            /// Application Cost (s32)
            /// </summary>
            /// <remarks>
            /// Installation price
            /// </remarks>
            public int ApplicationCost 
            {
                get => (int)CellsByName["ApplicationCost"].Value;
                set => CellsByName["ApplicationCost"].Value = value;
            }
            

            // Def="s32 sellValue"
            /// <summary>
            /// Sell Value (s32)
            /// </summary>
            /// <remarks>
            /// Sale price
            /// </remarks>
            public int SellValue 
            {
                get => (int)CellsByName["SellValue"].Value;
                set => CellsByName["SellValue"].Value = value;
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
            

            // Def="s16 compTrophySedId = -1"
            /// <summary>
            /// Achievement ID (s16)
            /// </summary>
            /// <remarks>
            /// SEQ number of complete trophy
            /// </remarks>
            public short AchievementID 
            {
                get => (short)CellsByName["AchievementID"].Value;
                set => CellsByName["AchievementID"].Value = value;
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
            

            // Def="u8 configurableWepAttr00:1"
            /// <summary>
            /// Affinity: Standard (u8)
            /// </summary>
            /// <remarks>
            /// Configurable weapon attribute ID 0
            /// </remarks>
            public byte AffinityStandard 
            {
                get => (byte)CellsByName["AffinityStandard"].Value;
                set => CellsByName["AffinityStandard"].Value = value;
            }
            

            // Def="u8 configurableWepAttr01:1"
            /// <summary>
            /// Affinity: Heavy (u8)
            /// </summary>
            /// <remarks>
            /// Configurable Weapon Attribute ID 1
            /// </remarks>
            public byte AffinityHeavy 
            {
                get => (byte)CellsByName["AffinityHeavy"].Value;
                set => CellsByName["AffinityHeavy"].Value = value;
            }
            

            // Def="u8 configurableWepAttr02:1"
            /// <summary>
            /// Affinity: Keen (u8)
            /// </summary>
            /// <remarks>
            /// Configurable Weapon Attribute ID 2
            /// </remarks>
            public byte AffinityKeen 
            {
                get => (byte)CellsByName["AffinityKeen"].Value;
                set => CellsByName["AffinityKeen"].Value = value;
            }
            

            // Def="u8 configurableWepAttr03:1"
            /// <summary>
            /// Affinity: Quality (u8)
            /// </summary>
            /// <remarks>
            /// Configurable Weapon Attribute ID 3
            /// </remarks>
            public byte AffinityQuality 
            {
                get => (byte)CellsByName["AffinityQuality"].Value;
                set => CellsByName["AffinityQuality"].Value = value;
            }
            

            // Def="u8 configurableWepAttr04:1"
            /// <summary>
            /// Affinity: Fire (u8)
            /// </summary>
            /// <remarks>
            /// Configurable Weapon Attribute ID 4
            /// </remarks>
            public byte AffinityFire 
            {
                get => (byte)CellsByName["AffinityFire"].Value;
                set => CellsByName["AffinityFire"].Value = value;
            }
            

            // Def="u8 configurableWepAttr05:1"
            /// <summary>
            /// Affinity: Flame Art (u8)
            /// </summary>
            /// <remarks>
            /// Configurable Weapon Attribute ID 5
            /// </remarks>
            public byte AffinityFlameArt 
            {
                get => (byte)CellsByName["AffinityFlameArt"].Value;
                set => CellsByName["AffinityFlameArt"].Value = value;
            }
            

            // Def="u8 configurableWepAttr06:1"
            /// <summary>
            /// Affinity: Lightning (u8)
            /// </summary>
            /// <remarks>
            /// Configurable Weapon Attribute ID 6
            /// </remarks>
            public byte AffinityLightning 
            {
                get => (byte)CellsByName["AffinityLightning"].Value;
                set => CellsByName["AffinityLightning"].Value = value;
            }
            

            // Def="u8 configurableWepAttr07:1"
            /// <summary>
            /// Affinity: Sacred (u8)
            /// </summary>
            /// <remarks>
            /// Configurable Weapon Attribute ID 7
            /// </remarks>
            public byte AffinitySacred 
            {
                get => (byte)CellsByName["AffinitySacred"].Value;
                set => CellsByName["AffinitySacred"].Value = value;
            }
            

            // Def="u8 configurableWepAttr08:1"
            /// <summary>
            /// Affinity: Magic (u8)
            /// </summary>
            /// <remarks>
            /// Configurable Weapon Attribute ID 8
            /// </remarks>
            public byte AffinityMagic 
            {
                get => (byte)CellsByName["AffinityMagic"].Value;
                set => CellsByName["AffinityMagic"].Value = value;
            }
            

            // Def="u8 configurableWepAttr09:1"
            /// <summary>
            /// Affinity: Cold (u8)
            /// </summary>
            /// <remarks>
            /// Configurable Weapon Attribute ID 9
            /// </remarks>
            public byte AffinityCold 
            {
                get => (byte)CellsByName["AffinityCold"].Value;
                set => CellsByName["AffinityCold"].Value = value;
            }
            

            // Def="u8 configurableWepAttr10:1"
            /// <summary>
            /// Affinity: Poison (u8)
            /// </summary>
            /// <remarks>
            /// Configurable Weapon Attribute ID 10
            /// </remarks>
            public byte AffinityPoison 
            {
                get => (byte)CellsByName["AffinityPoison"].Value;
                set => CellsByName["AffinityPoison"].Value = value;
            }
            

            // Def="u8 configurableWepAttr11:1"
            /// <summary>
            /// Affinity: Blood (u8)
            /// </summary>
            /// <remarks>
            /// Configurable Weapon Attribute ID 11
            /// </remarks>
            public byte AffinityBlood 
            {
                get => (byte)CellsByName["AffinityBlood"].Value;
                set => CellsByName["AffinityBlood"].Value = value;
            }
            

            // Def="u8 configurableWepAttr12:1"
            /// <summary>
            /// Affinity: Occult (u8)
            /// </summary>
            /// <remarks>
            /// Configurable Weapon Attribute ID 12
            /// </remarks>
            public byte AffinityOccult 
            {
                get => (byte)CellsByName["AffinityOccult"].Value;
                set => CellsByName["AffinityOccult"].Value = value;
            }
            

            // Def="u8 configurableWepAttr13:1"
            /// <summary>
            /// Affinity: Unused [13] (u8)
            /// </summary>
            /// <remarks>
            /// Configurable Weapon Attribute ID 13
            /// </remarks>
            public byte AffinityUnused13 
            {
                get => (byte)CellsByName["AffinityUnused13"].Value;
                set => CellsByName["AffinityUnused13"].Value = value;
            }
            

            // Def="u8 configurableWepAttr14:1"
            /// <summary>
            /// Affinity: Unused [14] (u8)
            /// </summary>
            /// <remarks>
            /// Configurable Weapon Attribute ID 14
            /// </remarks>
            public byte AffinityUnused14 
            {
                get => (byte)CellsByName["AffinityUnused14"].Value;
                set => CellsByName["AffinityUnused14"].Value = value;
            }
            

            // Def="u8 configurableWepAttr15:1"
            /// <summary>
            /// Affinity: Unused [15] (u8)
            /// </summary>
            /// <remarks>
            /// Configurable Weapon Attribute ID 15
            /// </remarks>
            public byte AffinityUnused15 
            {
                get => (byte)CellsByName["AffinityUnused15"].Value;
                set => CellsByName["AffinityUnused15"].Value = value;
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
            

            // Def="u8 configurableWepAttr16:1"
            /// <summary>
            /// Affinity: Unused [16] (u8)
            /// </summary>
            /// <remarks>
            /// Configurable Weapon Attribute ID 16
            /// </remarks>
            public byte AffinityUnused16 
            {
                get => (byte)CellsByName["AffinityUnused16"].Value;
                set => CellsByName["AffinityUnused16"].Value = value;
            }
            

            // Def="u8 configurableWepAttr17:1"
            /// <summary>
            /// Affinity: Unused [17] (u8)
            /// </summary>
            /// <remarks>
            /// Configurable Weapon Attribute ID 17
            /// </remarks>
            public byte AffinityUnused17 
            {
                get => (byte)CellsByName["AffinityUnused17"].Value;
                set => CellsByName["AffinityUnused17"].Value = value;
            }
            

            // Def="u8 configurableWepAttr18:1"
            /// <summary>
            /// Affinity: Unused [18] (u8)
            /// </summary>
            /// <remarks>
            /// Configurable Weapon Attribute ID 18
            /// </remarks>
            public byte AffinityUnused18 
            {
                get => (byte)CellsByName["AffinityUnused18"].Value;
                set => CellsByName["AffinityUnused18"].Value = value;
            }
            

            // Def="u8 configurableWepAttr19:1"
            /// <summary>
            /// Affinity: Unused [19] (u8)
            /// </summary>
            /// <remarks>
            /// Configurable Weapon Attribute ID 19
            /// </remarks>
            public byte AffinityUnused19 
            {
                get => (byte)CellsByName["AffinityUnused19"].Value;
                set => CellsByName["AffinityUnused19"].Value = value;
            }
            

            // Def="u8 configurableWepAttr20:1"
            /// <summary>
            /// Affinity: Unused [20] (u8)
            /// </summary>
            /// <remarks>
            /// Configurable Weapon Attribute ID 20
            /// </remarks>
            public byte AffinityUnused20 
            {
                get => (byte)CellsByName["AffinityUnused20"].Value;
                set => CellsByName["AffinityUnused20"].Value = value;
            }
            

            // Def="u8 configurableWepAttr21:1"
            /// <summary>
            /// Affinity: Unused [21] (u8)
            /// </summary>
            /// <remarks>
            /// Configurable Weapon Attribute ID 21
            /// </remarks>
            public byte AffinityUnused21 
            {
                get => (byte)CellsByName["AffinityUnused21"].Value;
                set => CellsByName["AffinityUnused21"].Value = value;
            }
            

            // Def="u8 configurableWepAttr22:1"
            /// <summary>
            /// Affinity: Unused [22] (u8)
            /// </summary>
            /// <remarks>
            /// Configurable Weapon Attribute ID 22
            /// </remarks>
            public byte AffinityUnused22 
            {
                get => (byte)CellsByName["AffinityUnused22"].Value;
                set => CellsByName["AffinityUnused22"].Value = value;
            }
            

            // Def="u8 configurableWepAttr23:1"
            /// <summary>
            /// Affinity: Unused [23] (u8)
            /// </summary>
            /// <remarks>
            /// Configurable Weapon Attribute ID 23
            /// </remarks>
            public byte AffinityUnused23 
            {
                get => (byte)CellsByName["AffinityUnused23"].Value;
                set => CellsByName["AffinityUnused23"].Value = value;
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
            

            // Def="u8 isDeposit:1"
            /// <summary>
            /// Is Depositable (u8)
            /// </summary>
            /// <remarks>
            /// Can you leave it in the warehouse?
            /// </remarks>
            public byte IsDepositable 
            {
                get => (byte)CellsByName["IsDepositable"].Value;
                set => CellsByName["IsDepositable"].Value = value;
            }
            

            // Def="u8 disableMultiDropShare:1"
            /// <summary>
            /// Is Drop Disabled in Multiplayer (u8)
            /// </summary>
            /// <remarks>
            /// Is multi-drop sharing prohibited?
            /// </remarks>
            public byte IsDropDisabledInMultiplayer 
            {
                get => (byte)CellsByName["IsDropDisabledInMultiplayer"].Value;
                set => CellsByName["IsDropDisabledInMultiplayer"].Value = value;
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
            

            // Def="u8 showLogCondType:1 = 1"
            /// <summary>
            /// Item Acquisition Show Condition Type (u8)
            /// </summary>
            /// <remarks>
            /// Whether to display in the item acquisition log when acquiring the item (not entered: ○)
            /// </remarks>
            public byte ItemAcquisitionShowConditionType 
            {
                get => (byte)CellsByName["ItemAcquisitionShowConditionType"].Value;
                set => CellsByName["ItemAcquisitionShowConditionType"].Value = value;
            }
            

            // Def="dummy8 pad:1"
            /// <summary>
            /// pad (dummy8)
            /// </summary>
            /// <remarks>
            /// pad
            /// </remarks>
            public object Pad 
            {
                get => (object)CellsByName["Pad"].Value;
                set => CellsByName["Pad"].Value = value;
            }
            

            // Def="u8 defaultWepAttr"
            /// <summary>
            /// Default Weapon Affinity (u8)
            /// </summary>
            /// <remarks>
            /// Default weapon attribute ID. Can be installed even with unopened weapon attributes
            /// </remarks>
            public byte DefaultWeaponAffinity 
            {
                get => (byte)CellsByName["DefaultWeaponAffinity"].Value;
                set => CellsByName["DefaultWeaponAffinity"].Value = value;
            }
            

            // Def="dummy8 pad2[2]"
            /// <summary>
            /// pad2 (dummy8)
            /// </summary>
            /// <remarks>
            /// pad2
            /// </remarks>
            public object Pad2 
            {
                get => (object)CellsByName["Pad2"].Value;
                set => CellsByName["Pad2"].Value = value;
            }
            

            // Def="u8 canMountWep_Dagger:1"
            /// <summary>
            /// Available: Dagger (u8)
            /// </summary>
            /// <remarks>
            /// Can it be attached to "Weapon type: Dagger"? No input becomes x
            /// </remarks>
            public byte AvailableDagger 
            {
                get => (byte)CellsByName["AvailableDagger"].Value;
                set => CellsByName["AvailableDagger"].Value = value;
            }
            

            // Def="u8 canMountWep_SwordNormal:1"
            /// <summary>
            /// Available: Straight Sword (u8)
            /// </summary>
            /// <remarks>
            /// Can it be attached to "Weapon type: Straight sword"? No input becomes x
            /// </remarks>
            public byte AvailableStraightSword 
            {
                get => (byte)CellsByName["AvailableStraightSword"].Value;
                set => CellsByName["AvailableStraightSword"].Value = value;
            }
            

            // Def="u8 canMountWep_SwordLarge:1"
            /// <summary>
            /// Available: Greatsword (u8)
            /// </summary>
            /// <remarks>
            /// Can it be attached to "Weapon Type: Large Sword"? No input becomes x
            /// </remarks>
            public byte AvailableGreatsword 
            {
                get => (byte)CellsByName["AvailableGreatsword"].Value;
                set => CellsByName["AvailableGreatsword"].Value = value;
            }
            

            // Def="u8 canMountWep_SwordGigantic:1"
            /// <summary>
            /// Available: Colossal Sword (u8)
            /// </summary>
            /// <remarks>
            /// Can it be attached to "Weapon Type: Oversized Sword"? No input becomes x
            /// </remarks>
            public byte AvailableColossalSword 
            {
                get => (byte)CellsByName["AvailableColossalSword"].Value;
                set => CellsByName["AvailableColossalSword"].Value = value;
            }
            

            // Def="u8 canMountWep_SaberNormal:1"
            /// <summary>
            /// Available: Curved Sword (u8)
            /// </summary>
            /// <remarks>
            /// Can it be attached to "Weapon Type: Curly Sword"? No input becomes x
            /// </remarks>
            public byte AvailableCurvedSword 
            {
                get => (byte)CellsByName["AvailableCurvedSword"].Value;
                set => CellsByName["AvailableCurvedSword"].Value = value;
            }
            

            // Def="u8 canMountWep_SaberLarge:1"
            /// <summary>
            /// Available: Curved Greatsword (u8)
            /// </summary>
            /// <remarks>
            /// Can it be attached to "Weapon Type: Omagari Sword"? No input becomes x
            /// </remarks>
            public byte AvailableCurvedGreatsword 
            {
                get => (byte)CellsByName["AvailableCurvedGreatsword"].Value;
                set => CellsByName["AvailableCurvedGreatsword"].Value = value;
            }
            

            // Def="u8 canMountWep_katana:1"
            /// <summary>
            /// Available: Katana (u8)
            /// </summary>
            /// <remarks>
            /// Can it be attached to "Weapon type: Sword"? No input becomes x
            /// </remarks>
            public byte AvailableKatana 
            {
                get => (byte)CellsByName["AvailableKatana"].Value;
                set => CellsByName["AvailableKatana"].Value = value;
            }
            

            // Def="u8 canMountWep_SwordDoubleEdge:1"
            /// <summary>
            /// Available: Twinblade (u8)
            /// </summary>
            /// <remarks>
            /// Can it be attached to "Weapon type: Double-edged sword"? No input becomes x
            /// </remarks>
            public byte AvailableTwinblade 
            {
                get => (byte)CellsByName["AvailableTwinblade"].Value;
                set => CellsByName["AvailableTwinblade"].Value = value;
            }
            

            // Def="u8 canMountWep_SwordPierce:1"
            /// <summary>
            /// Available: Thrusting Sword (u8)
            /// </summary>
            /// <remarks>
            /// Can it be attached to "Weapon type: Sword"? No input becomes x
            /// </remarks>
            public byte AvailableThrustingSword 
            {
                get => (byte)CellsByName["AvailableThrustingSword"].Value;
                set => CellsByName["AvailableThrustingSword"].Value = value;
            }
            

            // Def="u8 canMountWep_RapierHeavy:1"
            /// <summary>
            /// Available: Heavy Thrusting Sword (u8)
            /// </summary>
            /// <remarks>
            /// Can it be attached to "Weapon Type: Large Sword"? No input becomes x
            /// </remarks>
            public byte AvailableHeavyThrustingSword 
            {
                get => (byte)CellsByName["AvailableHeavyThrustingSword"].Value;
                set => CellsByName["AvailableHeavyThrustingSword"].Value = value;
            }
            

            // Def="u8 canMountWep_AxeNormal:1"
            /// <summary>
            /// Available: Axe (u8)
            /// </summary>
            /// <remarks>
            /// Can it be attached to "Weapon Type: Ax"? No input becomes x
            /// </remarks>
            public byte AvailableAxe 
            {
                get => (byte)CellsByName["AvailableAxe"].Value;
                set => CellsByName["AvailableAxe"].Value = value;
            }
            

            // Def="u8 canMountWep_AxeLarge:1"
            /// <summary>
            /// Available: Greataxe (u8)
            /// </summary>
            /// <remarks>
            /// Can it be attached to "Weapon Type: Large Ax"? No input becomes x
            /// </remarks>
            public byte AvailableGreataxe 
            {
                get => (byte)CellsByName["AvailableGreataxe"].Value;
                set => CellsByName["AvailableGreataxe"].Value = value;
            }
            

            // Def="u8 canMountWep_HammerNormal:1"
            /// <summary>
            /// Available: Hammer (u8)
            /// </summary>
            /// <remarks>
            /// Can it be attached to "Weapon type: Hammer"? No input becomes x
            /// </remarks>
            public byte AvailableHammer 
            {
                get => (byte)CellsByName["AvailableHammer"].Value;
                set => CellsByName["AvailableHammer"].Value = value;
            }
            

            // Def="u8 canMountWep_HammerLarge:1"
            /// <summary>
            /// Available: Great Hammer (u8)
            /// </summary>
            /// <remarks>
            /// Can it be attached to "Weapon Type: Gavel"? No input becomes x
            /// </remarks>
            public byte AvailableGreatHammer 
            {
                get => (byte)CellsByName["AvailableGreatHammer"].Value;
                set => CellsByName["AvailableGreatHammer"].Value = value;
            }
            

            // Def="u8 canMountWep_Flail:1"
            /// <summary>
            /// Available: Flail (u8)
            /// </summary>
            /// <remarks>
            /// Can it be attached to "Weapon Type: Frail"? No input becomes x
            /// </remarks>
            public byte AvailableFlail 
            {
                get => (byte)CellsByName["AvailableFlail"].Value;
                set => CellsByName["AvailableFlail"].Value = value;
            }
            

            // Def="u8 canMountWep_SpearNormal:1"
            /// <summary>
            /// Available: Spear (u8)
            /// </summary>
            /// <remarks>
            /// Can it be attached to "Weapon Type: Spear"? No input becomes x
            /// </remarks>
            public byte AvailableSpear 
            {
                get => (byte)CellsByName["AvailableSpear"].Value;
                set => CellsByName["AvailableSpear"].Value = value;
            }
            

            // Def="u8 canMountWep_SpearLarge:1"
            /// <summary>
            /// Available: Large Spear (u8)
            /// </summary>
            /// <remarks>
            /// Can it be attached to "Weapon Type: Long Spear"? No input becomes x
            /// </remarks>
            public byte AvailableLargeSpear 
            {
                get => (byte)CellsByName["AvailableLargeSpear"].Value;
                set => CellsByName["AvailableLargeSpear"].Value = value;
            }
            

            // Def="u8 canMountWep_SpearHeavy:1"
            /// <summary>
            /// Available: Heavy Spear (u8)
            /// </summary>
            /// <remarks>
            /// Can it be attached to "Weapon Type: Large Spear"? No input becomes x
            /// </remarks>
            public byte AvailableHeavySpear 
            {
                get => (byte)CellsByName["AvailableHeavySpear"].Value;
                set => CellsByName["AvailableHeavySpear"].Value = value;
            }
            

            // Def="u8 canMountWep_SpearAxe:1"
            /// <summary>
            /// Available: Halberd (u8)
            /// </summary>
            /// <remarks>
            /// Can it be attached to "Weapon Type: Halberd"? No input becomes x
            /// </remarks>
            public byte AvailableHalberd 
            {
                get => (byte)CellsByName["AvailableHalberd"].Value;
                set => CellsByName["AvailableHalberd"].Value = value;
            }
            

            // Def="u8 canMountWep_Sickle:1"
            /// <summary>
            /// Available: Reaper (u8)
            /// </summary>
            /// <remarks>
            /// Can it be attached to "Weapon type: Sickle"? No input becomes x
            /// </remarks>
            public byte AvailableReaper 
            {
                get => (byte)CellsByName["AvailableReaper"].Value;
                set => CellsByName["AvailableReaper"].Value = value;
            }
            

            // Def="u8 canMountWep_Knuckle:1"
            /// <summary>
            /// Available: Fist (u8)
            /// </summary>
            /// <remarks>
            /// Can it be attached to "Weapon type: Fist"? No input becomes x
            /// </remarks>
            public byte AvailableFist 
            {
                get => (byte)CellsByName["AvailableFist"].Value;
                set => CellsByName["AvailableFist"].Value = value;
            }
            

            // Def="u8 canMountWep_Claw:1"
            /// <summary>
            /// Available: Claw (u8)
            /// </summary>
            /// <remarks>
            /// Can it be attached to "Weapon type: Claw"? No input becomes x
            /// </remarks>
            public byte AvailableClaw 
            {
                get => (byte)CellsByName["AvailableClaw"].Value;
                set => CellsByName["AvailableClaw"].Value = value;
            }
            

            // Def="u8 canMountWep_Whip:1"
            /// <summary>
            /// Available: Whip (u8)
            /// </summary>
            /// <remarks>
            /// Can it be attached to "Weapon type: Whip"? No input becomes x
            /// </remarks>
            public byte AvailableWhip 
            {
                get => (byte)CellsByName["AvailableWhip"].Value;
                set => CellsByName["AvailableWhip"].Value = value;
            }
            

            // Def="u8 canMountWep_AxhammerLarge:1"
            /// <summary>
            /// Available: Colossal Weapon (u8)
            /// </summary>
            /// <remarks>
            /// Can it be attached to "Weapon type: Oversized ax mallet"? No input becomes x
            /// </remarks>
            public byte AvailableColossalWeapon 
            {
                get => (byte)CellsByName["AvailableColossalWeapon"].Value;
                set => CellsByName["AvailableColossalWeapon"].Value = value;
            }
            

            // Def="u8 canMountWep_BowSmall:1"
            /// <summary>
            /// Available: Light Bow (u8)
            /// </summary>
            /// <remarks>
            /// Can it be attached to "Weapon type: Small bow"? No input becomes x
            /// </remarks>
            public byte AvailableLightBow 
            {
                get => (byte)CellsByName["AvailableLightBow"].Value;
                set => CellsByName["AvailableLightBow"].Value = value;
            }
            

            // Def="u8 canMountWep_BowNormal:1"
            /// <summary>
            /// Available: Bow (u8)
            /// </summary>
            /// <remarks>
            /// Can it be attached to "Weapon Type: Bow"? No input becomes x
            /// </remarks>
            public byte AvailableBow 
            {
                get => (byte)CellsByName["AvailableBow"].Value;
                set => CellsByName["AvailableBow"].Value = value;
            }
            

            // Def="u8 canMountWep_BowLarge:1"
            /// <summary>
            /// Available: Greatbow (u8)
            /// </summary>
            /// <remarks>
            /// Can it be attached to "Weapon Type: Large Bow"? No input becomes x
            /// </remarks>
            public byte AvailableGreatbow 
            {
                get => (byte)CellsByName["AvailableGreatbow"].Value;
                set => CellsByName["AvailableGreatbow"].Value = value;
            }
            

            // Def="u8 canMountWep_ClossBow:1"
            /// <summary>
            /// Available: Crossbow (u8)
            /// </summary>
            /// <remarks>
            /// Can it be attached to "Weapon Type: Crossbow"? No input becomes x
            /// </remarks>
            public byte AvailableCrossbow 
            {
                get => (byte)CellsByName["AvailableCrossbow"].Value;
                set => CellsByName["AvailableCrossbow"].Value = value;
            }
            

            // Def="u8 canMountWep_Ballista:1"
            /// <summary>
            /// Available: Ballista (u8)
            /// </summary>
            /// <remarks>
            /// Can it be attached to "Weapon Type: Varistor"? No input becomes x
            /// </remarks>
            public byte AvailableBallista 
            {
                get => (byte)CellsByName["AvailableBallista"].Value;
                set => CellsByName["AvailableBallista"].Value = value;
            }
            

            // Def="u8 canMountWep_Staff:1"
            /// <summary>
            /// Available: Staff (u8)
            /// </summary>
            /// <remarks>
            /// Can it be attached to "Weapon type: Wand"? No input becomes x
            /// </remarks>
            public byte AvailableStaff 
            {
                get => (byte)CellsByName["AvailableStaff"].Value;
                set => CellsByName["AvailableStaff"].Value = value;
            }
            

            // Def="u8 canMountWep_Sorcery:1"
            /// <summary>
            /// Available: Unused Catalyst (u8)
            /// </summary>
            /// <remarks>
            /// Can it be attached to "Weapon type: Tattoo"? No input becomes x
            /// </remarks>
            public byte AvailableUnusedCatalyst 
            {
                get => (byte)CellsByName["AvailableUnusedCatalyst"].Value;
                set => CellsByName["AvailableUnusedCatalyst"].Value = value;
            }
            

            // Def="u8 canMountWep_Talisman:1"
            /// <summary>
            /// Available: Seal (u8)
            /// </summary>
            /// <remarks>
            /// Can it be attached to "Weapon Type: Holy Mark"? No input becomes x
            /// </remarks>
            public byte AvailableSeal 
            {
                get => (byte)CellsByName["AvailableSeal"].Value;
                set => CellsByName["AvailableSeal"].Value = value;
            }
            

            // Def="u8 canMountWep_ShieldSmall:1"
            /// <summary>
            /// Available: Small Shield (u8)
            /// </summary>
            /// <remarks>
            /// Can it be attached to "Weapon Type: Small Shield"? No input becomes x
            /// </remarks>
            public byte AvailableSmallShield 
            {
                get => (byte)CellsByName["AvailableSmallShield"].Value;
                set => CellsByName["AvailableSmallShield"].Value = value;
            }
            

            // Def="u8 canMountWep_ShieldNormal:1"
            /// <summary>
            /// Available: Medium Shield (u8)
            /// </summary>
            /// <remarks>
            /// Can it be attached to "Weapon Type: Middle Shield"? No input becomes x
            /// </remarks>
            public byte AvailableMediumShield 
            {
                get => (byte)CellsByName["AvailableMediumShield"].Value;
                set => CellsByName["AvailableMediumShield"].Value = value;
            }
            

            // Def="u8 canMountWep_ShieldLarge:1"
            /// <summary>
            /// Available: Greatshield (u8)
            /// </summary>
            /// <remarks>
            /// Can it be attached to "Weapon Type: Large Shield"? No input becomes x
            /// </remarks>
            public byte AvailableGreatshield 
            {
                get => (byte)CellsByName["AvailableGreatshield"].Value;
                set => CellsByName["AvailableGreatshield"].Value = value;
            }
            

            // Def="u8 canMountWep_Torch:1"
            /// <summary>
            /// Available: Torch (u8)
            /// </summary>
            /// <remarks>
            /// Can it be attached to "Weapon type: Torch"? No input becomes x
            /// </remarks>
            public byte AvailableTorch 
            {
                get => (byte)CellsByName["AvailableTorch"].Value;
                set => CellsByName["AvailableTorch"].Value = value;
            }
            

            // Def="dummy8 reserved_canMountWep:4"
            /// <summary>
            /// Reserved area (weapon type that can be installed) (dummy8)
            /// </summary>
            /// <remarks>
            /// Reserved area for each type of weapon that can be installed (64 bits in total)
            /// </remarks>
            public object ReservedAreaWeaponTypeThatCanBeInstalled 
            {
                get => (object)CellsByName["ReservedAreaWeaponTypeThatCanBeInstalled"].Value;
                set => CellsByName["ReservedAreaWeaponTypeThatCanBeInstalled"].Value = value;
            }
            


            // Def="s32 spEffectMsgId0 = -1"
            /// <summary>
            /// SpEffect Message ID [0] (s32)
            /// </summary>
            /// <remarks>
            /// Effect text ID 00 (Gem_Effect). Magic stone effect text to display in status
            /// </remarks>
            public int SpEffectMessageID0 
            {
                get => (int)CellsByName["SpEffectMessageID0"].Value;
                set => CellsByName["SpEffectMessageID0"].Value = value;
            }
            

            // Def="s32 spEffectMsgId1 = -1"
            /// <summary>
            /// SpEffect Message ID [1] (s32)
            /// </summary>
            /// <remarks>
            /// Effect text ID 01 (Gem_Effect). Magic stone effect text to display in status
            /// </remarks>
            public int SpEffectMessageID1 
            {
                get => (int)CellsByName["SpEffectMessageID1"].Value;
                set => CellsByName["SpEffectMessageID1"].Value = value;
            }
            

            // Def="s32 spEffectId_forAtk0 = -1"
            /// <summary>
            /// SpEffect ID - Attack Hit [0] (s32)
            /// </summary>
            /// <remarks>
            /// Special effect parameter ID for attack hit
            /// </remarks>
            public int SpEffectIDAttackHit0 
            {
                get => (int)CellsByName["SpEffectIDAttackHit0"].Value;
                set => CellsByName["SpEffectIDAttackHit0"].Value = value;
            }
            

            // Def="s32 spEffectId_forAtk1 = -1"
            /// <summary>
            /// SpEffect ID - Attack Hit [1] (s32)
            /// </summary>
            /// <remarks>
            /// Special effect parameter ID for attack hit
            /// </remarks>
            public int SpEffectIDAttackHit1 
            {
                get => (int)CellsByName["SpEffectIDAttackHit1"].Value;
                set => CellsByName["SpEffectIDAttackHit1"].Value = value;
            }
            

            // Def="s32 spEffectId_forAtk2 = -1"
            /// <summary>
            /// SpEffect ID - Attack Hit [2] (s32)
            /// </summary>
            /// <remarks>
            /// Special effect parameter ID for attack hit
            /// </remarks>
            public int SpEffectIDAttackHit2 
            {
                get => (int)CellsByName["SpEffectIDAttackHit2"].Value;
                set => CellsByName["SpEffectIDAttackHit2"].Value = value;
            }
            

            // Def="s32 mountWepTextId = -1"
            /// <summary>
            /// Mount Weapon Text ID (s32)
            /// </summary>
            /// <remarks>
            /// Corresponding Weapon Type Overwrite Text ID (-1: Do not overwrite) [Menu Text]
            /// </remarks>
            public int MountWeaponTextID 
            {
                get => (int)CellsByName["MountWeaponTextID"].Value;
                set => CellsByName["MountWeaponTextID"].Value = value;
            }
            

            // Def="dummy8 pad6[8]"
            /// <summary>
            /// pad6 (dummy8)
            /// </summary>
            /// <remarks>
            /// 
            /// </remarks>
            public object Pad6 
            {
                get => (object)CellsByName["Pad6"].Value;
                set => CellsByName["Pad6"].Value = value;
            }
            
                }
            }
            
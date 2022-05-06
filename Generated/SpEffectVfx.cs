
namespace StronglyTypedParams
{
    public class SpEffectVfx : ParamRow
    {
        public SpEffectVfx() : base()
        {
        }


        // Def="s32 midstSfxId = -1"
        /// <summary>
        /// Midst SFX ID (s32)
        /// </summary>
        /// <remarks>
        /// In effect SfxID (-1: invalid)
        /// </remarks>
        public int MidstSFXID
        {
            get => (int)CellsByName["MidstSFXID"].Value;
            set => CellsByName["MidstSFXID"].Value = value;
        }


        // Def="s32 midstSeId = -1"
        /// <summary>
        /// Midst SE ID (s32)
        /// </summary>
        /// <remarks>
        /// In effect SeID (-1: invalid)
        /// </remarks>
        public int MidstSEID
        {
            get => (int)CellsByName["MidstSEID"].Value;
            set => CellsByName["MidstSEID"].Value = value;
        }


        // Def="s32 initSfxId = -1"
        /// <summary>
        /// Start SFX ID (s32)
        /// </summary>
        /// <remarks>
        /// SfxID at activation (-1: invalid)
        /// </remarks>
        public int StartSFXID
        {
            get => (int)CellsByName["StartSFXID"].Value;
            set => CellsByName["StartSFXID"].Value = value;
        }


        // Def="s32 initSeId = -1"
        /// <summary>
        /// Start SE ID (s32)
        /// </summary>
        /// <remarks>
        /// When activated SeID (-1: invalid)
        /// </remarks>
        public int StartSEID
        {
            get => (int)CellsByName["StartSEID"].Value;
            set => CellsByName["StartSEID"].Value = value;
        }


        // Def="s32 finishSfxId = -1"
        /// <summary>
        /// End SFX ID (s32)
        /// </summary>
        /// <remarks>
        /// SfxID at the time of cancellation (-1: invalid)
        /// </remarks>
        public int EndSFXID
        {
            get => (int)CellsByName["EndSFXID"].Value;
            set => CellsByName["EndSFXID"].Value = value;
        }


        // Def="s32 finishSeId = -1"
        /// <summary>
        /// End SE ID (s32)
        /// </summary>
        /// <remarks>
        /// SeID at the time of release (-1: invalid)
        /// </remarks>
        public int EndSEID
        {
            get => (int)CellsByName["EndSEID"].Value;
            set => CellsByName["EndSEID"].Value = value;
        }


        // Def="f32 camouflageBeginDist = -1"
        /// <summary>
        /// Camouflage - Start Distance (f32)
        /// </summary>
        /// <remarks>
        /// It is the camouflage start distance
        /// </remarks>
        public float CamouflageStartDistance
        {
            get => (float)CellsByName["CamouflageStartDistance"].Value;
            set => CellsByName["CamouflageStartDistance"].Value = value;
        }


        // Def="f32 camouflageEndDist = -1"
        /// <summary>
        /// Camouflage - End Distance (f32)
        /// </summary>
        /// <remarks>
        /// It is the camouflage end distance
        /// </remarks>
        public float CamouflageEndDistance
        {
            get => (float)CellsByName["CamouflageEndDistance"].Value;
            set => CellsByName["CamouflageEndDistance"].Value = value;
        }


        // Def="s32 transformProtectorId = -1"
        /// <summary>
        /// Transform - Protector ID (s32)
        /// </summary>
        /// <remarks>
        /// Makeover Armor ID (-1: None)
        /// </remarks>
        public int TransformProtectorID
        {
            get => (int)CellsByName["TransformProtectorID"].Value;
            set => CellsByName["TransformProtectorID"].Value = value;
        }


        // Def="s16 midstDmyId = -1"
        /// <summary>
        /// Midst Dummy Poly ID (s16)
        /// </summary>
        /// <remarks>
        /// In effect Damipoli ID (-1: Root)
        /// </remarks>
        public short MidstDummyPolyID
        {
            get => (short)CellsByName["MidstDummyPolyID"].Value;
            set => CellsByName["MidstDummyPolyID"].Value = value;
        }


        // Def="s16 initDmyId = -1"
        /// <summary>
        /// Start Dummy Poly ID (s16)
        /// </summary>
        /// <remarks>
        /// Damipoli ID at the time of activation (-1: root)
        /// </remarks>
        public short StartDummyPolyID
        {
            get => (short)CellsByName["StartDummyPolyID"].Value;
            set => CellsByName["StartDummyPolyID"].Value = value;
        }


        // Def="s16 finishDmyId = -1"
        /// <summary>
        /// End Dummy Poly ID (s16)
        /// </summary>
        /// <remarks>
        /// Damipoli ID at the time of cancellation (-1: root)
        /// </remarks>
        public short EndDummyPolyID
        {
            get => (short)CellsByName["EndDummyPolyID"].Value;
            set => CellsByName["EndDummyPolyID"].Value = value;
        }


        // Def="u8 effectType"
        /// <summary>
        /// Effect Type (u8)
        /// </summary>
        /// <remarks>
        /// Effect type
        /// </remarks>
        public byte EffectType
        {
            get => (byte)CellsByName["EffectType"].Value;
            set => CellsByName["EffectType"].Value = value;
        }


        // Def="u8 soulParamIdForWepEnchant"
        /// <summary>
        /// Weapon Enchant - Soul Param ID (u8)
        /// </summary>
        /// <remarks>
        /// Soul Param ID for Weapon Enchantment (-1: None). Change the applied Phantom Param.
        /// </remarks>
        public byte WeaponEnchantSoulParamID
        {
            get => (byte)CellsByName["WeaponEnchantSoulParamID"].Value;
            set => CellsByName["WeaponEnchantSoulParamID"].Value = value;
        }


        // Def="u8 playCategory"
        /// <summary>
        /// Play Category (u8)
        /// </summary>
        /// <remarks>
        /// Controls effect playback due to duplicate effects
        /// </remarks>
        public byte PlayCategory
        {
            get => (byte)CellsByName["PlayCategory"].Value;
            set => CellsByName["PlayCategory"].Value = value;
        }


        // Def="u8 playPriority"
        /// <summary>
        /// Play Priority (u8)
        /// </summary>
        /// <remarks>
        /// Set the playback priority when the categories match (lower one has priority)
        /// </remarks>
        public byte PlayPriority
        {
            get => (byte)CellsByName["PlayPriority"].Value;
            set => CellsByName["PlayPriority"].Value = value;
        }


        // Def="u8 existEffectForLarge:1"
        /// <summary>
        /// Large Effect Exists (u8)
        /// </summary>
        /// <remarks>
        /// Is there a large effect?
        /// </remarks>
        public byte LargeEffectExists
        {
            get => (byte)CellsByName["LargeEffectExists"].Value;
            set => CellsByName["LargeEffectExists"].Value = value;
        }


        // Def="u8 existEffectForSoul:1"
        /// <summary>
        /// Soul Effect Exists (u8)
        /// </summary>
        /// <remarks>
        /// Is there an effect for the soul body?
        /// </remarks>
        public byte SoulEffectExists
        {
            get => (byte)CellsByName["SoulEffectExists"].Value;
            set => CellsByName["SoulEffectExists"].Value = value;
        }


        // Def="u8 effectInvisibleAtCamouflage:1"
        /// <summary>
        /// Camouflage - Invisible while Active (u8)
        /// </summary>
        /// <remarks>
        /// Whether to hide the effect when hiding
        /// </remarks>
        public byte CamouflageInvisibleWhileActive
        {
            get => (byte)CellsByName["CamouflageInvisibleWhileActive"].Value;
            set => CellsByName["CamouflageInvisibleWhileActive"].Value = value;
        }


        // Def="u8 useCamouflage:1"
        /// <summary>
        /// Camouflage - Enable (u8)
        /// </summary>
        /// <remarks>
        /// Do you hide
        /// </remarks>
        public byte CamouflageEnable
        {
            get => (byte)CellsByName["CamouflageEnable"].Value;
            set => CellsByName["CamouflageEnable"].Value = value;
        }


        // Def="u8 invisibleAtFriendCamouflage:1"
        /// <summary>
        /// Camouflage - Invisible for Friend (u8)
        /// </summary>
        /// <remarks>
        /// Is it hidden even by allies when hiding?
        /// </remarks>
        public byte CamouflageInvisibleForFriend
        {
            get => (byte)CellsByName["CamouflageInvisibleForFriend"].Value;
            set => CellsByName["CamouflageInvisibleForFriend"].Value = value;
        }


        // Def="u8 isHideFootEffect_forCamouflage:1"
        /// <summary>
        /// Camouflage - Hide Foot Effect (u8)
        /// </summary>
        /// <remarks>
        /// Do you want to turn off the foot effect when hiding?
        /// </remarks>
        public byte CamouflageHideFootEffect
        {
            get => (byte)CellsByName["CamouflageHideFootEffect"].Value;
            set => CellsByName["CamouflageHideFootEffect"].Value = value;
        }


        // Def="u8 halfCamouflage:1"
        /// <summary>
        /// Camouflage - Translucent Appearance (u8)
        /// </summary>
        /// <remarks>
        /// Only translucent appearance
        /// </remarks>
        public byte CamouflageTranslucentAppearance
        {
            get => (byte)CellsByName["CamouflageTranslucentAppearance"].Value;
            set => CellsByName["CamouflageTranslucentAppearance"].Value = value;
        }


        // Def="u8 isFullBodyTransformProtectorId:1"
        /// <summary>
        /// Is Full Body Protector ID (u8)
        /// </summary>
        /// <remarks>
        /// Is the transformation armor ID for the whole body?
        /// </remarks>
        public byte IsFullBodyProtectorID
        {
            get => (byte)CellsByName["IsFullBodyProtectorID"].Value;
            set => CellsByName["IsFullBodyProtectorID"].Value = value;
        }


        // Def="u8 isInvisibleWeapon:1"
        /// <summary>
        /// Is Invisible Weapon (u8)
        /// </summary>
        /// <remarks>
        /// Invisible Weapon for Weapon Enchantment (0: Weapon Show, 1: Weapon Hide)
        /// </remarks>
        public byte IsInvisibleWeapon
        {
            get => (byte)CellsByName["IsInvisibleWeapon"].Value;
            set => CellsByName["IsInvisibleWeapon"].Value = value;
        }


        // Def="u8 isSilence:1"
        /// <summary>
        /// Is Silent (u8)
        /// </summary>
        /// <remarks>
        /// Is it silence? (0: No, 1: Yes)
        /// </remarks>
        public byte IsSilent
        {
            get => (byte)CellsByName["IsSilent"].Value;
            set => CellsByName["IsSilent"].Value = value;
        }


        // Def="u8 isMidstFullbody:1"
        /// <summary>
        /// Is Midst SFX Full Body (u8)
        /// </summary>
        /// <remarks>
        /// Do you use whole body Damipoli for equipping SFX during effect? Play SFX from torso: 190, head: 191, hands: 192, legs: 193 at 1
        /// </remarks>
        public byte IsMidstSFXFullBody
        {
            get => (byte)CellsByName["IsMidstSFXFullBody"].Value;
            set => CellsByName["IsMidstSFXFullBody"].Value = value;
        }


        // Def="u8 isInitFullbody:1"
        /// <summary>
        /// Is Start SFX Full Body (u8)
        /// </summary>
        /// <remarks>
        /// Do you use the whole body Damipoli for equipping SFX during activation? Play SFX from torso: 190, head: 191, hands: 192, legs: 193 at 1
        /// </remarks>
        public byte IsStartSFXFullBody
        {
            get => (byte)CellsByName["IsStartSFXFullBody"].Value;
            set => CellsByName["IsStartSFXFullBody"].Value = value;
        }


        // Def="u8 isFinishFullbody:1"
        /// <summary>
        /// Is End SFX Full Body (u8)
        /// </summary>
        /// <remarks>
        /// Do you use the whole body Damipoli for equipping SFX at the time of release? Play SFX from torso: 190, head: 191, hands: 192, legs: 193 at 1
        /// </remarks>
        public byte IsEndSFXFullBody
        {
            get => (byte)CellsByName["IsEndSFXFullBody"].Value;
            set => CellsByName["IsEndSFXFullBody"].Value = value;
        }


        // Def="u8 isVisibleDeadChr:1"
        /// <summary>
        /// Is Visible on Dead Chr (u8)
        /// </summary>
        /// <remarks>
        /// If ○, VFX will be displayed even when the corpse is dead.
        /// </remarks>
        public byte IsVisibleOnDeadChr
        {
            get => (byte)CellsByName["IsVisibleOnDeadChr"].Value;
            set => CellsByName["IsVisibleOnDeadChr"].Value = value;
        }


        // Def="u8 isUseOffsetEnchantSfxSize:1"
        /// <summary>
        /// Use Enchant SFX Size to Offset SFX ID (u8)
        /// </summary>
        /// <remarks>
        /// Whether to offset the SfxId according to the "enchantment Sfx size" of the weapon para
        /// </remarks>
        public byte UseEnchantSFXSizeToOffsetSFXID
        {
            get => (byte)CellsByName["UseEnchantSFXSizeToOffsetSFXID"].Value;
            set => CellsByName["UseEnchantSFXSizeToOffsetSFXID"].Value = value;
        }


        // Def="dummy8 pad_1:1"
        /// <summary>
        /// Padding (dummy8)
        /// </summary>
        /// <remarks>
        /// Padding
        /// </remarks>
        public object Padding
        {
            get => (object)CellsByName["Padding"].Value;
            set => CellsByName["Padding"].Value = value;
        }


        // Def="s32 decalId1 = -1"
        /// <summary>
        /// Decal ID [0] (s32)
        /// </summary>
        /// <remarks>
        /// Decal ID 1 (-1: invalid)
        /// </remarks>
        public int DecalID0
        {
            get => (int)CellsByName["DecalID0"].Value;
            set => CellsByName["DecalID0"].Value = value;
        }


        // Def="s32 decalId2 = -1"
        /// <summary>
        /// Decal ID [1] (s32)
        /// </summary>
        /// <remarks>
        /// Decal ID 2 (-1: invalid)
        /// </remarks>
        public int DecalID1
        {
            get => (int)CellsByName["DecalID1"].Value;
            set => CellsByName["DecalID1"].Value = value;
        }


        // Def="u8 footEffectPriority"
        /// <summary>
        /// Foot Effect Priority (u8)
        /// </summary>
        /// <remarks>
        /// Foot effect offset priority (lower is higher)
        /// </remarks>
        public byte FootEffectPriority
        {
            get => (byte)CellsByName["FootEffectPriority"].Value;
            set => CellsByName["FootEffectPriority"].Value = value;
        }


        // Def="u8 footEffectOffset"
        /// <summary>
        /// Foot Effect Offset (u8)
        /// </summary>
        /// <remarks>
        /// Amount offset to foot effect ID when this special effect is applied
        /// </remarks>
        public byte FootEffectOffset
        {
            get => (byte)CellsByName["FootEffectOffset"].Value;
            set => CellsByName["FootEffectOffset"].Value = value;
        }


        // Def="u8 traceSfxIdOffsetType"
        /// <summary>
        /// Trace SFX ID Offset Type (u8)
        /// </summary>
        /// <remarks>
        /// The offset value applied to the sword flash SFX ID. Used for enchantment and sword trajectory effects
        /// </remarks>
        public byte TraceSFXIDOffsetType
        {
            get => (byte)CellsByName["TraceSFXIDOffsetType"].Value;
            set => CellsByName["TraceSFXIDOffsetType"].Value = value;
        }


        // Def="u8 forceDeceasedType"
        /// <summary>
        /// Force Deceased Type (u8)
        /// </summary>
        /// <remarks>
        /// A function that can force the appearance of a character to be alive / dead
        /// </remarks>
        public byte ForceDeceasedType
        {
            get => (byte)CellsByName["ForceDeceasedType"].Value;
            set => CellsByName["ForceDeceasedType"].Value = value;
        }


        // Def="s32 enchantStartDmyId_0 = -1"
        /// <summary>
        /// Enchant SFX Start - Dummy Poly ID [0] (s32)
        /// </summary>
        /// <remarks>
        /// Damipoli ID generated at the base of enchantment
        /// </remarks>
        public int EnchantSFXStartDummyPolyID0
        {
            get => (int)CellsByName["EnchantSFXStartDummyPolyID0"].Value;
            set => CellsByName["EnchantSFXStartDummyPolyID0"].Value = value;
        }


        // Def="s32 enchantEndDmyId_0 = -1"
        /// <summary>
        /// Enchant SFX end - Dummy Poly ID [0] (s32)
        /// </summary>
        /// <remarks>
        /// Damipoli ID generated at the tip of the sword at the time of enchantment. -1 If specified, it will be automatically put out to the point where it is a serial number.
        /// </remarks>
        public int EnchantSFXEndDummyPolyID0
        {
            get => (int)CellsByName["EnchantSFXEndDummyPolyID0"].Value;
            set => CellsByName["EnchantSFXEndDummyPolyID0"].Value = value;
        }


        // Def="s32 enchantStartDmyId_1 = -1"
        /// <summary>
        /// Enchant SFX Start - Dummy Poly ID [1] (s32)
        /// </summary>
        /// <remarks>
        /// Damipoli ID generated at the base of enchantment
        /// </remarks>
        public int EnchantSFXStartDummyPolyID1
        {
            get => (int)CellsByName["EnchantSFXStartDummyPolyID1"].Value;
            set => CellsByName["EnchantSFXStartDummyPolyID1"].Value = value;
        }


        // Def="s32 enchantEndDmyId_1 = -1"
        /// <summary>
        /// Enchant SFX End - Dummy Poly ID [1] (s32)
        /// </summary>
        /// <remarks>
        /// Damipoli ID generated at the tip of the sword at the time of enchantment. -1 If specified, it will be automatically put out to the point where it is a serial number.
        /// </remarks>
        public int EnchantSFXEndDummyPolyID1
        {
            get => (int)CellsByName["EnchantSFXEndDummyPolyID1"].Value;
            set => CellsByName["EnchantSFXEndDummyPolyID1"].Value = value;
        }


        // Def="s32 enchantStartDmyId_2 = -1"
        /// <summary>
        /// Enchant SFX Start - Dummy Poly ID [2] (s32)
        /// </summary>
        /// <remarks>
        /// Damipoli ID generated at the base of enchantment
        /// </remarks>
        public int EnchantSFXStartDummyPolyID2
        {
            get => (int)CellsByName["EnchantSFXStartDummyPolyID2"].Value;
            set => CellsByName["EnchantSFXStartDummyPolyID2"].Value = value;
        }


        // Def="s32 enchantEndDmyId_2 = -1"
        /// <summary>
        /// Enchant SFX End - Dummy Poly ID [2] (s32)
        /// </summary>
        /// <remarks>
        /// Damipoli ID generated at the tip of the sword at the time of enchantment. -1 If specified, it will be automatically put out to the point where it is a serial number.
        /// </remarks>
        public int EnchantSFXEndDummyPolyID2
        {
            get => (int)CellsByName["EnchantSFXEndDummyPolyID2"].Value;
            set => CellsByName["EnchantSFXEndDummyPolyID2"].Value = value;
        }


        // Def="s32 enchantStartDmyId_3 = -1"
        /// <summary>
        /// Enchant SFX Start - Dummy Poly ID [3] (s32)
        /// </summary>
        /// <remarks>
        /// Damipoli ID generated at the base of enchantment
        /// </remarks>
        public int EnchantSFXStartDummyPolyID3
        {
            get => (int)CellsByName["EnchantSFXStartDummyPolyID3"].Value;
            set => CellsByName["EnchantSFXStartDummyPolyID3"].Value = value;
        }


        // Def="s32 enchantEndDmyId_3 = -1"
        /// <summary>
        /// Enchant SFX End - Dummy Poly ID [3] (s32)
        /// </summary>
        /// <remarks>
        /// Damipoli ID generated at the tip of the sword at the time of enchantment. -1 If specified, it will be automatically put out to the point where it is a serial number.
        /// </remarks>
        public int EnchantSFXEndDummyPolyID3
        {
            get => (int)CellsByName["EnchantSFXEndDummyPolyID3"].Value;
            set => CellsByName["EnchantSFXEndDummyPolyID3"].Value = value;
        }


        // Def="s32 enchantStartDmyId_4 = -1"
        /// <summary>
        /// Enchant SFX Start - Dummy Poly ID [4] (s32)
        /// </summary>
        /// <remarks>
        /// Damipoli ID generated at the base of enchantment
        /// </remarks>
        public int EnchantSFXStartDummyPolyID4
        {
            get => (int)CellsByName["EnchantSFXStartDummyPolyID4"].Value;
            set => CellsByName["EnchantSFXStartDummyPolyID4"].Value = value;
        }


        // Def="s32 enchantEndDmyId_4 = -1"
        /// <summary>
        /// Enchant SFX End - Dummy Poly ID [4] (s32)
        /// </summary>
        /// <remarks>
        /// Damipoli ID generated at the tip of the sword at the time of enchantment. -1 If specified, it will be automatically put out to the point where it is a serial number.
        /// </remarks>
        public int EnchantSFXEndDummyPolyID4
        {
            get => (int)CellsByName["EnchantSFXEndDummyPolyID4"].Value;
            set => CellsByName["EnchantSFXEndDummyPolyID4"].Value = value;
        }


        // Def="s32 enchantStartDmyId_5 = -1"
        /// <summary>
        /// Enchant SFX Start - Dummy Poly ID [5] (s32)
        /// </summary>
        /// <remarks>
        /// Damipoli ID generated at the base of enchantment
        /// </remarks>
        public int EnchantSFXStartDummyPolyID5
        {
            get => (int)CellsByName["EnchantSFXStartDummyPolyID5"].Value;
            set => CellsByName["EnchantSFXStartDummyPolyID5"].Value = value;
        }


        // Def="s32 enchantEndDmyId_5 = -1"
        /// <summary>
        /// Enchant SFX End - Dummy Poly ID [5] (s32)
        /// </summary>
        /// <remarks>
        /// Damipoli ID generated at the tip of the sword at the time of enchantment. -1 If specified, it will be automatically put out to the point where it is a serial number.
        /// </remarks>
        public int EnchantSFXEndDummyPolyID5
        {
            get => (int)CellsByName["EnchantSFXEndDummyPolyID5"].Value;
            set => CellsByName["EnchantSFXEndDummyPolyID5"].Value = value;
        }


        // Def="s32 enchantStartDmyId_6 = -1"
        /// <summary>
        /// Enchant SFX Start - Dummy Poly ID [6] (s32)
        /// </summary>
        /// <remarks>
        /// Damipoli ID generated at the base of enchantment
        /// </remarks>
        public int EnchantSFXStartDummyPolyID6
        {
            get => (int)CellsByName["EnchantSFXStartDummyPolyID6"].Value;
            set => CellsByName["EnchantSFXStartDummyPolyID6"].Value = value;
        }


        // Def="s32 enchantEndDmyId_6 = -1"
        /// <summary>
        /// Enchant SFX End - Dummy Poly ID [6] (s32)
        /// </summary>
        /// <remarks>
        /// Damipoli ID generated at the tip of the sword at the time of enchantment. -1 If specified, it will be automatically put out to the point where it is a serial number.
        /// </remarks>
        public int EnchantSFXEndDummyPolyID6
        {
            get => (int)CellsByName["EnchantSFXEndDummyPolyID6"].Value;
            set => CellsByName["EnchantSFXEndDummyPolyID6"].Value = value;
        }


        // Def="s32 enchantStartDmyId_7 = -1"
        /// <summary>
        /// Enchant SFX Start - Dummy Poly ID [7] (s32)
        /// </summary>
        /// <remarks>
        /// Damipoli ID generated at the base of enchantment
        /// </remarks>
        public int EnchantSFXStartDummyPolyID7
        {
            get => (int)CellsByName["EnchantSFXStartDummyPolyID7"].Value;
            set => CellsByName["EnchantSFXStartDummyPolyID7"].Value = value;
        }


        // Def="s32 enchantEndDmyId_7 = -1"
        /// <summary>
        /// Enchant SFX End - Dummy Poly ID [7] (s32)
        /// </summary>
        /// <remarks>
        /// Damipoli ID generated at the tip of the sword at the time of enchantment. -1 If specified, it will be automatically put out to the point where it is a serial number.
        /// </remarks>
        public int EnchantSFXEndDummyPolyID7
        {
            get => (int)CellsByName["EnchantSFXEndDummyPolyID7"].Value;
            set => CellsByName["EnchantSFXEndDummyPolyID7"].Value = value;
        }


        // Def="u8 SfxIdOffsetType"
        /// <summary>
        /// SFX ID Offset Type (u8)
        /// </summary>
        /// <remarks>
        /// SfxID offset type
        /// </remarks>
        public byte SFXIDOffsetType
        {
            get => (byte)CellsByName["SFXIDOffsetType"].Value;
            set => CellsByName["SFXIDOffsetType"].Value = value;
        }


        // Def="u8 phantomParamOverwriteType"
        /// <summary>
        /// Phantom Param Overwrite Type (u8)
        /// </summary>
        /// <remarks>
        /// Forced overwrite type of phantom parameters
        /// </remarks>
        public byte PhantomParamOverwriteType
        {
            get => (byte)CellsByName["PhantomParamOverwriteType"].Value;
            set => CellsByName["PhantomParamOverwriteType"].Value = value;
        }


        // Def="u8 camouflageMinAlpha"
        /// <summary>
        /// Camouflage - Min Alpha (u8)
        /// </summary>
        /// <remarks>
        /// Minimum α value when hiding [%]
        /// </remarks>
        public byte CamouflageMinAlpha
        {
            get => (byte)CellsByName["CamouflageMinAlpha"].Value;
            set => CellsByName["CamouflageMinAlpha"].Value = value;
        }


        // Def="u8 wetAspectType"
        /// <summary>
        /// Wet Aspect Type (u8)
        /// </summary>
        /// <remarks>
        /// Generate a wet expression by referring to the wet parameter
        /// </remarks>
        public byte WetAspectType
        {
            get => (byte)CellsByName["WetAspectType"].Value;
            set => CellsByName["WetAspectType"].Value = value;
        }


        // Def="s32 phantomParamOverwriteId"
        /// <summary>
        /// Phantom Param Overwrite ID (s32)
        /// </summary>
        /// <remarks>
        /// Forced Id of phantom parameter
        /// </remarks>
        public int PhantomParamOverwriteID
        {
            get => (int)CellsByName["PhantomParamOverwriteID"].Value;
            set => CellsByName["PhantomParamOverwriteID"].Value = value;
        }


        // Def="s32 materialParamId = -1"
        /// <summary>
        /// Material Param ID (s32)
        /// </summary>
        /// <remarks>
        /// ID0-99 are GS reservation IDs. If ID100 or later is specified, the material extension parameter is referenced (-1: invalid value).
        /// </remarks>
        public int MaterialParamID
        {
            get => (int)CellsByName["MaterialParamID"].Value;
            set => CellsByName["MaterialParamID"].Value = value;
        }


        // Def="f32 materialParamInitValue"
        /// <summary>
        /// Material Param - Start Fade (f32)
        /// </summary>
        /// <remarks>
        /// The value at the start of the fade of the material parameter. The target is specified by the material parameter ID. If the material parameter ID is -1, do nothing
        /// </remarks>
        public float MaterialParamStartFade
        {
            get => (float)CellsByName["MaterialParamStartFade"].Value;
            set => CellsByName["MaterialParamStartFade"].Value = value;
        }


        // Def="f32 materialParamTargetValue"
        /// <summary>
        /// Material Param - End Fade (f32)
        /// </summary>
        /// <remarks>
        /// The value at the end of the fade of the material parameter. The target is specified by the material parameter ID. If the material parameter ID is -1, do nothing
        /// </remarks>
        public float MaterialParamEndFade
        {
            get => (float)CellsByName["MaterialParamEndFade"].Value;
            set => CellsByName["MaterialParamEndFade"].Value = value;
        }


        // Def="f32 materialParamFadeTime"
        /// <summary>
        /// Material Param - Fade Time (f32)
        /// </summary>
        /// <remarks>
        /// Fade time for material parameter values. Gradually reach the target value over this time. If the material parameter ID is -1, do nothing
        /// </remarks>
        public float MaterialParamFadeTime
        {
            get => (float)CellsByName["MaterialParamFadeTime"].Value;
            set => CellsByName["MaterialParamFadeTime"].Value = value;
        }


        // Def="s16 footDecalMaterialOffsetOverwriteId = -1"
        /// <summary>
        /// Foot Decal Material Offset Overwrite ID (s16)
        /// </summary>
        /// <remarks>
        /// Forcibly rewrite the floor material ID offset of the foot decal (-1 unused)
        /// </remarks>
        public short FootDecalMaterialOffsetOverwriteID
        {
            get => (short)CellsByName["FootDecalMaterialOffsetOverwriteID"].Value;
            set => CellsByName["FootDecalMaterialOffsetOverwriteID"].Value = value;
        }


    }
}

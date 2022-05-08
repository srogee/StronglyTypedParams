
            namespace StronglyTypedParams
            {
                // PLAYER_COMMON_PARAM_ST
                public class PlayerCommonParam : ParamRow
                {
                    public PlayerCommonParam() : base()
                    {
                    }
            

            // Def="s32 playerFootEffect_bySFX"
            /// <summary>
            /// Automatic Foot Effect SFX Identifier (s32)
            /// </summary>
            /// <remarks>
            /// The identifier used for the SFX ID of the automatic foot effect. It corresponds to ZZZ of XYYZZZ.
            /// </remarks>
            public int AutomaticFootEffectSFXIdentifier 
            {
                get => (int)CellsByName["AutomaticFootEffectSFXIdentifier"].Value;
                set => CellsByName["AutomaticFootEffectSFXIdentifier"].Value = (int)value;
            }
            

            // Def="f32 snipeModeDrawAlpha_FadeTime"
            /// <summary>
            /// Precision Shoot - Player Model Fade Time (f32)
            /// </summary>
            /// <remarks>
            /// The fade time when hiding the player during precision shooting. The unit is seconds
            /// </remarks>
            public float PrecisionShootPlayerModelFadeTime 
            {
                get => (float)CellsByName["PrecisionShootPlayerModelFadeTime"].Value;
                set => CellsByName["PrecisionShootPlayerModelFadeTime"].Value = (float)value;
            }
            

            // Def="f32 toughnessRecoverCorrection"
            /// <summary>
            /// Toughness Recovery Correction (f32)
            /// </summary>
            /// <remarks>
            /// A correction value used to calculate the player's toughness recovery time.
            /// </remarks>
            public float ToughnessRecoveryCorrection 
            {
                get => (float)CellsByName["ToughnessRecoveryCorrection"].Value;
                set => CellsByName["ToughnessRecoveryCorrection"].Value = (float)value;
            }
            

            // Def="u8 baseMagicSlotSize"
            /// <summary>
            /// Base Memory Slot Count (u8)
            /// </summary>
            /// <remarks>
            /// Magic memory slot initial value
            /// </remarks>
            public byte BaseMemorySlotCount 
            {
                get => (byte)CellsByName["BaseMemorySlotCount"].Value;
                set => CellsByName["BaseMemorySlotCount"].Value = (byte)value;
            }
            

            // Def="u8 baseAccSlotNum"
            /// <summary>
            /// Base Talisman Slot Count (u8)
            /// </summary>
            /// <remarks>
            /// Talisman equipment slot initial value
            /// </remarks>
            public byte BaseTalismanSlotCount 
            {
                get => (byte)CellsByName["BaseTalismanSlotCount"].Value;
                set => CellsByName["BaseTalismanSlotCount"].Value = (byte)value;
            }
            

            // Def="dummy8 reserved02[2]"
            /// <summary>
            /// reserve (dummy8)
            /// </summary>
            /// <remarks>
            /// (dummy8)
            /// </remarks>
            public object Reserve 
            {
                get => (object)CellsByName["Reserve"].Value;
                set => CellsByName["Reserve"].Value = (object)value;
            }
            

            // Def="s32 animeID_DropItemPick"
            /// <summary>
            /// Item Pick-up - Animation ID (s32)
            /// </summary>
            /// <remarks>
            /// Animation ID when picking up a drop item
            /// </remarks>
            public int ItemPickUpAnimationID 
            {
                get => (int)CellsByName["ItemPickUpAnimationID"].Value;
                set => CellsByName["ItemPickUpAnimationID"].Value = (int)value;
            }
            

            // Def="f32 resistRecoverPoint_Sleep_Player"
            /// <summary>
            /// Player Resist Recovery - Sleep (f32)
            /// </summary>
            /// <remarks>
            /// Player resistance value recovery amount_sleep [point / s]
            /// </remarks>
            public float PlayerResistRecoverySleep 
            {
                get => (float)CellsByName["PlayerResistRecoverySleep"].Value;
                set => CellsByName["PlayerResistRecoverySleep"].Value = (float)value;
            }
            

            // Def="s32 flareOverrideHomingAngle = -1"
            /// <summary>
            /// Flare Overwrite Homing Angle (s32)
            /// </summary>
            /// <remarks>
            /// Flare overwrite guidance performance [deg / s] (-1: no overwrite)
            /// </remarks>
            public int FlareOverwriteHomingAngle 
            {
                get => (int)CellsByName["FlareOverwriteHomingAngle"].Value;
                set => CellsByName["FlareOverwriteHomingAngle"].Value = (int)value;
            }
            

            // Def="f32 flareOverrideHomingStopRange = -1"
            /// <summary>
            /// Flare Overwrite Homing Stop Range (f32)
            /// </summary>
            /// <remarks>
            /// Flare overwrite guidance stop distance [m] (-1: no overwrite)
            /// </remarks>
            public float FlareOverwriteHomingStopRange 
            {
                get => (float)CellsByName["FlareOverwriteHomingStopRange"].Value;
                set => CellsByName["FlareOverwriteHomingStopRange"].Value = (float)value;
            }
            

            // Def="s32 animeID_SleepCollectorItemPick"
            /// <summary>
            /// Sleep Collector Item Pick-up - Animation ID (s32)
            /// </summary>
            /// <remarks>
            /// Animation ID when acquiring Nemuri item
            /// </remarks>
            public int SleepCollectorItemPickUpAnimationID 
            {
                get => (int)CellsByName["SleepCollectorItemPickUpAnimationID"].Value;
                set => CellsByName["SleepCollectorItemPickUpAnimationID"].Value = (int)value;
            }
            

            // Def="u32 unlockEventFlagBaseId_forWepAttr"
            /// <summary>
            /// Weapon Affinity Unlock - Base Event Flag ID (u32)
            /// </summary>
            /// <remarks>
            /// Weapon attribute ban event flag base ID
            /// </remarks>
            public uint WeaponAffinityUnlockBaseEventFlagID 
            {
                get => (uint)CellsByName["WeaponAffinityUnlockBaseEventFlagID"].Value;
                set => CellsByName["WeaponAffinityUnlockBaseEventFlagID"].Value = (uint)value;
            }
            

            // Def="s32 systemEnchant_BigRune"
            /// <summary>
            /// Great Rune Activation - SpEffect ID (s32)
            /// </summary>
            /// <remarks>
            /// Special effect Id to call when a large rune is activated from the system
            /// </remarks>
            public int GreatRuneActivationSpEffectID 
            {
                get => (int)CellsByName["GreatRuneActivationSpEffectID"].Value;
                set => CellsByName["GreatRuneActivationSpEffectID"].Value = (int)value;
            }
            

            // Def="f32 lowStatus_AtkPowDown"
            /// <summary>
            /// Insufficient Stats - Attack Power Reduction (f32)
            /// </summary>
            /// <remarks>
            /// Insufficient status Basic attack power reduction
            /// </remarks>
            public float InsufficientStatsAttackPowerReduction 
            {
                get => (float)CellsByName["InsufficientStatsAttackPowerReduction"].Value;
                set => CellsByName["InsufficientStatsAttackPowerReduction"].Value = (float)value;
            }
            

            // Def="f32 lowStatus_ConsumeStaminaRate"
            /// <summary>
            /// Insufficient Stats - Stamina Consumption (f32)
            /// </summary>
            /// <remarks>
            /// Insufficient status Stamina consumption ratio
            /// </remarks>
            public float InsufficientStatsStaminaConsumption 
            {
                get => (float)CellsByName["InsufficientStatsStaminaConsumption"].Value;
                set => CellsByName["InsufficientStatsStaminaConsumption"].Value = (float)value;
            }
            

            // Def="s16 lowStatus_AtkGuardBreak"
            /// <summary>
            /// Insufficient Stats - Stamina Damage Reduction (s16)
            /// </summary>
            /// <remarks>
            /// Insufficient status Playing attack power
            /// </remarks>
            public short InsufficientStatsStaminaDamageReduction 
            {
                get => (short)CellsByName["InsufficientStatsStaminaDamageReduction"].Value;
                set => CellsByName["InsufficientStatsStaminaDamageReduction"].Value = (short)value;
            }
            

            // Def="s16 guardStatusCorrect_MaxStatusVal"
            /// <summary>
            /// Guard Boost Correction - Max Value (s16)
            /// </summary>
            /// <remarks>
            /// Maximum status value to increase performance used when calculating the status correction value of shield performance
            /// </remarks>
            public short GuardBoostCorrectionMaxValue 
            {
                get => (short)CellsByName["GuardBoostCorrectionMaxValue"].Value;
                set => CellsByName["GuardBoostCorrectionMaxValue"].Value = (short)value;
            }
            

            // Def="u16 unlockEventFlagStepNum_forWepAttr = 1"
            /// <summary>
            /// Weapon Affinity Unlock - Event Flag Step Offset (u16)
            /// </summary>
            /// <remarks>
            /// How much space is left for each weapon attribute ID from the base ID. Weapon attribute ban event flag ID = << Weapon attribute ban event flag base ID >> + Weapon attribute ID x << Weapon attribute ban event flag number of steps >>
            /// </remarks>
            public ushort WeaponAffinityUnlockEventFlagStepOffset 
            {
                get => (ushort)CellsByName["WeaponAffinityUnlockEventFlagStepOffset"].Value;
                set => CellsByName["WeaponAffinityUnlockEventFlagStepOffset"].Value = (ushort)value;
            }
            

            // Def="u16 retributionMagic_damageCountNum"
            /// <summary>
            /// Retribution Magic - Damage Trigger Count (u16)
            /// </summary>
            /// <remarks>
            /// Causal Retribution_Number of Damages Before Counterattack
            /// </remarks>
            public ushort RetributionMagicDamageTriggerCount 
            {
                get => (ushort)CellsByName["RetributionMagicDamageTriggerCount"].Value;
                set => CellsByName["RetributionMagicDamageTriggerCount"].Value = (ushort)value;
            }
            

            // Def="u16 retributionMagic_damageCountRemainTime"
            /// <summary>
            /// Retribution Magic - Damage Trigger Duration (u16)
            /// </summary>
            /// <remarks>
            /// Causal response_Number of damages until counterattack Duration [s]
            /// </remarks>
            public ushort RetributionMagicDamageTriggerDuration 
            {
                get => (ushort)CellsByName["RetributionMagicDamageTriggerDuration"].Value;
                set => CellsByName["RetributionMagicDamageTriggerDuration"].Value = (ushort)value;
            }
            

            // Def="u16 retributionMagic_burstDmypolyId"
            /// <summary>
            /// Retribution Magic - Explosion Dummy Poly ID (u16)
            /// </summary>
            /// <remarks>
            /// Causal Retribution_Counterattack Magic Damipoli ID
            /// </remarks>
            public ushort RetributionMagicExplosionDummyPolyID 
            {
                get => (ushort)CellsByName["RetributionMagicExplosionDummyPolyID"].Value;
                set => CellsByName["RetributionMagicExplosionDummyPolyID"].Value = (ushort)value;
            }
            

            // Def="s32 retributionMagic_burstMagicParamId = -1"
            /// <summary>
            /// Retribution Magic - Explosion Magic Param ID (s32)
            /// </summary>
            /// <remarks>
            /// Causal Retribution_Counterattack Magic Param ID
            /// </remarks>
            public int RetributionMagicExplosionMagicParamID 
            {
                get => (int)CellsByName["RetributionMagicExplosionMagicParamID"].Value;
                set => CellsByName["RetributionMagicExplosionMagicParamID"].Value = (int)value;
            }
            

            // Def="f32 chrAimCam_rideOffsetHeight"
            /// <summary>
            /// Mounted Precision Shoot - Camera Offset Height (f32)
            /// </summary>
            /// <remarks>
            /// Riding precision shooting camera offset height
            /// </remarks>
            public float MountedPrecisionShootCameraOffsetHeight 
            {
                get => (float)CellsByName["MountedPrecisionShootCameraOffsetHeight"].Value;
                set => CellsByName["MountedPrecisionShootCameraOffsetHeight"].Value = (float)value;
            }
            


            // Def="s32 arrowCaseWepBindDmypolyId"
            /// <summary>
            /// Quiver Dummy Poly ID (s32)
            /// </summary>
            /// <remarks>
            /// Quiver adsorption Damipoly ID
            /// </remarks>
            public int QuiverDummyPolyID 
            {
                get => (int)CellsByName["QuiverDummyPolyID"].Value;
                set => CellsByName["QuiverDummyPolyID"].Value = (int)value;
            }
            

            // Def="s32 boltPouchWepBindDmypolyId"
            /// <summary>
            /// Bolt Case Dummy Poly ID (s32)
            /// </summary>
            /// <remarks>
            /// Bolt cylinder adsorption Damipoly ID (However, if the bolt cylinder is used alone, the quiver Damipoly ID is used)
            /// </remarks>
            public int BoltCaseDummyPolyID 
            {
                get => (int)CellsByName["BoltCaseDummyPolyID"].Value;
                set => CellsByName["BoltCaseDummyPolyID"].Value = (int)value;
            }
            

            // Def="f32 estusFlaskAllocateRate"
            /// <summary>
            /// Multiplayer Flask Reduction (f32)
            /// </summary>
            /// <remarks>
            /// Multi-time client bottle correction magnification (0.5 specified to halve the number of possessions)
            /// </remarks>
            public float MultiplayerFlaskReduction 
            {
                get => (float)CellsByName["MultiplayerFlaskReduction"].Value;
                set => CellsByName["MultiplayerFlaskReduction"].Value = (float)value;
            }
            


            // Def="u8 kickAcceptanceDeg"
            /// <summary>
            /// Kick Acceptance Angle (u8)
            /// </summary>
            /// <remarks>
            /// Angle at which a kick can be taken when viewed from the front of the player
            /// </remarks>
            public byte KickAcceptanceAngle 
            {
                get => (byte)CellsByName["KickAcceptanceAngle"].Value;
                set => CellsByName["KickAcceptanceAngle"].Value = (byte)value;
            }
            

            // Def="u8 npcPlayerAnalogWeightRate_Light"
            /// <summary>
            /// NPC Player - Weight Rate: Light (u8)
            /// </summary>
            /// <remarks>
            /// Analog weight ratio for NPC players [%]. lightweight.
            /// </remarks>
            public byte NPCPlayerWeightRateLight 
            {
                get => (byte)CellsByName["NPCPlayerWeightRateLight"].Value;
                set => CellsByName["NPCPlayerWeightRateLight"].Value = (byte)value;
            }
            

            // Def="u8 npcPlayerAnalogWeightRate_Normal"
            /// <summary>
            /// NPC Player - Weight Rate: Normal (u8)
            /// </summary>
            /// <remarks>
            /// Analog weight ratio for NPC players [%]. Medium weight.
            /// </remarks>
            public byte NPCPlayerWeightRateNormal 
            {
                get => (byte)CellsByName["NPCPlayerWeightRateNormal"].Value;
                set => CellsByName["NPCPlayerWeightRateNormal"].Value = (byte)value;
            }
            

            // Def="u8 npcPlayerAnalogWeightRate_Heavy"
            /// <summary>
            /// NPC Player - Weight Rate: Heavy (u8)
            /// </summary>
            /// <remarks>
            /// Analog weight ratio for NPC players [%]. weight.
            /// </remarks>
            public byte NPCPlayerWeightRateHeavy 
            {
                get => (byte)CellsByName["NPCPlayerWeightRateHeavy"].Value;
                set => CellsByName["NPCPlayerWeightRateHeavy"].Value = (byte)value;
            }
            

            // Def="u8 npcPlayerAnalogWeightRate_WeightOver"
            /// <summary>
            /// NPC Player - Weight Rate: Encumbered (u8)
            /// </summary>
            /// <remarks>
            /// Analog weight ratio for NPC players [%]. Overweight.
            /// </remarks>
            public byte NPCPlayerWeightRateEncumbered 
            {
                get => (byte)CellsByName["NPCPlayerWeightRateEncumbered"].Value;
                set => CellsByName["NPCPlayerWeightRateEncumbered"].Value = (byte)value;
            }
            

            // Def="u8 npcPlayerAnalogWeightRate_SuperLight"
            /// <summary>
            /// NPC Player - Weight Rate: Ninja (u8)
            /// </summary>
            /// <remarks>
            /// Analog weight ratio for NPC players [%]. Super lightweight.
            /// </remarks>
            public byte NPCPlayerWeightRateNinja 
            {
                get => (byte)CellsByName["NPCPlayerWeightRateNinja"].Value;
                set => CellsByName["NPCPlayerWeightRateNinja"].Value = (byte)value;
            }
            


            // Def="s32 clearCountCorrectBaseSpEffectId"
            /// <summary>
            /// Game Clear - Base SpEffect ID (s32)
            /// </summary>
            /// <remarks>
            /// Criteria ID for special effects applied for lap correction
            /// </remarks>
            public int GameClearBaseSpEffectID 
            {
                get => (int)CellsByName["GameClearBaseSpEffectID"].Value;
                set => CellsByName["GameClearBaseSpEffectID"].Value = (int)value;
            }
            

            // Def="s32 arrowBoltModelIdOffset"
            /// <summary>
            /// Ammunition Model ID Offset (s32)
            /// </summary>
            /// <remarks>
            /// Offset added to the model ID when equipped in slot 1 when displaying the arrow and bolt models. (Model Id + offset value)
            /// </remarks>
            public int AmmunitionModelIDOffset 
            {
                get => (int)CellsByName["AmmunitionModelIDOffset"].Value;
                set => CellsByName["AmmunitionModelIDOffset"].Value = (int)value;
            }
            

            // Def="s8 arrowBoltRemainingNumModelMaskThreshold1"
            /// <summary>
            /// Ammunition Count Model Mask Threshold [1] (s8)
            /// </summary>
            /// <remarks>
            /// When displaying the arrow and bolt models, the one-step judgment value [%] of the threshold value when applying the display mask by the number. (If it is more than this value, it is displayed in one step)
            /// </remarks>
            public sbyte AmmunitionCountModelMaskThreshold1 
            {
                get => (sbyte)CellsByName["AmmunitionCountModelMaskThreshold1"].Value;
                set => CellsByName["AmmunitionCountModelMaskThreshold1"].Value = (sbyte)value;
            }
            

            // Def="s8 arrowBoltRemainingNumModelMaskThreshold2"
            /// <summary>
            /// Ammunition Count Model Mask Threshold [2] (s8)
            /// </summary>
            /// <remarks>
            /// Two-step judgment value [%] of the threshold value when applying a display mask based on the number of arrows and bolt models. (If it is more than this value, it is displayed in 2 steps)
            /// </remarks>
            public sbyte AmmunitionCountModelMaskThreshold2 
            {
                get => (sbyte)CellsByName["AmmunitionCountModelMaskThreshold2"].Value;
                set => CellsByName["AmmunitionCountModelMaskThreshold2"].Value = (sbyte)value;
            }
            


            // Def="f32 resistRecoverPoint_Poision_Player"
            /// <summary>
            /// Player Resist Recovery - Poison (f32)
            /// </summary>
            /// <remarks>
            /// Player resistance recovery amount_poison [point / s]
            /// </remarks>
            public float PlayerResistRecoveryPoison 
            {
                get => (float)CellsByName["PlayerResistRecoveryPoison"].Value;
                set => CellsByName["PlayerResistRecoveryPoison"].Value = (float)value;
            }
            

            // Def="f32 resistRecoverPoint_Desease_Player"
            /// <summary>
            /// Player Resist Recovery - Scarlet Rot (f32)
            /// </summary>
            /// <remarks>
            /// Player resistance value recovery amount_plague [point / s]
            /// </remarks>
            public float PlayerResistRecoveryScarletRot 
            {
                get => (float)CellsByName["PlayerResistRecoveryScarletRot"].Value;
                set => CellsByName["PlayerResistRecoveryScarletRot"].Value = (float)value;
            }
            

            // Def="f32 resistRecoverPoint_Blood_Player"
            /// <summary>
            /// Player Resist Recovery - Hemorrhage (f32)
            /// </summary>
            /// <remarks>
            /// Player resistance recovery amount_bleeding [point / s]
            /// </remarks>
            public float PlayerResistRecoveryHemorrhage 
            {
                get => (float)CellsByName["PlayerResistRecoveryHemorrhage"].Value;
                set => CellsByName["PlayerResistRecoveryHemorrhage"].Value = (float)value;
            }
            

            // Def="f32 resistRecoverPoint_Curse_Player"
            /// <summary>
            /// Player Resist Recovery - Blight (f32)
            /// </summary>
            /// <remarks>
            /// Player resistance recovery amount_curse [point / s]
            /// </remarks>
            public float PlayerResistRecoveryBlight 
            {
                get => (float)CellsByName["PlayerResistRecoveryBlight"].Value;
                set => CellsByName["PlayerResistRecoveryBlight"].Value = (float)value;
            }
            

            // Def="f32 resistRecoverPoint_Freeze_Player"
            /// <summary>
            /// Player Resist Recovery - Frostbite (f32)
            /// </summary>
            /// <remarks>
            /// Player resistance value recovery amount_cold air [point / s]
            /// </remarks>
            public float PlayerResistRecoveryFrostbite 
            {
                get => (float)CellsByName["PlayerResistRecoveryFrostbite"].Value;
                set => CellsByName["PlayerResistRecoveryFrostbite"].Value = (float)value;
            }
            

            // Def="f32 resistRecoverPoint_Poision_Enemy"
            /// <summary>
            /// Enemy Resist Recovery - Poison (f32)
            /// </summary>
            /// <remarks>
            /// Enemy resistance recovery amount_poison [point / s]
            /// </remarks>
            public float EnemyResistRecoveryPoison 
            {
                get => (float)CellsByName["EnemyResistRecoveryPoison"].Value;
                set => CellsByName["EnemyResistRecoveryPoison"].Value = (float)value;
            }
            

            // Def="f32 resistRecoverPoint_Desease_Enemy"
            /// <summary>
            /// Enemy Resist Recovery - Scarlet Rot (f32)
            /// </summary>
            /// <remarks>
            /// Enemy resistance value recovery amount_plague [point / s]
            /// </remarks>
            public float EnemyResistRecoveryScarletRot 
            {
                get => (float)CellsByName["EnemyResistRecoveryScarletRot"].Value;
                set => CellsByName["EnemyResistRecoveryScarletRot"].Value = (float)value;
            }
            

            // Def="f32 resistRecoverPoint_Blood_Enemy"
            /// <summary>
            /// Enemy Resist Recovery - Hemorrhage (f32)
            /// </summary>
            /// <remarks>
            /// Enemy resistance recovery amount_bleeding [point / s]
            /// </remarks>
            public float EnemyResistRecoveryHemorrhage 
            {
                get => (float)CellsByName["EnemyResistRecoveryHemorrhage"].Value;
                set => CellsByName["EnemyResistRecoveryHemorrhage"].Value = (float)value;
            }
            

            // Def="f32 resistRecoverPoint_Curse_Enemy"
            /// <summary>
            /// Enemy Resist Recovery - Blight (f32)
            /// </summary>
            /// <remarks>
            /// Enemy resistance recovery amount_curse [point / s]
            /// </remarks>
            public float EnemyResistRecoveryBlight 
            {
                get => (float)CellsByName["EnemyResistRecoveryBlight"].Value;
                set => CellsByName["EnemyResistRecoveryBlight"].Value = (float)value;
            }
            

            // Def="f32 resistRecoverPoint_Freeze_Enemy"
            /// <summary>
            /// Enemy Resist Recovery - Frostbite (f32)
            /// </summary>
            /// <remarks>
            /// Enemy resistance value recovery amount_cold air [point / s]
            /// </remarks>
            public float EnemyResistRecoveryFrostbite 
            {
                get => (float)CellsByName["EnemyResistRecoveryFrostbite"].Value;
                set => CellsByName["EnemyResistRecoveryFrostbite"].Value = (float)value;
            }
            

            // Def="f32 requestTimeLeftBothHand"
            /// <summary>
            /// Button Input Time for Both-Hand Left (f32)
            /// </summary>
            /// <remarks>
            /// Button input time when holding both left hand
            /// </remarks>
            public float ButtonInputTimeForBothHandLeft 
            {
                get => (float)CellsByName["ButtonInputTimeForBothHandLeft"].Value;
                set => CellsByName["ButtonInputTimeForBothHandLeft"].Value = (float)value;
            }
            

            // Def="f32 resistRecoverPoint_Madness_Player"
            /// <summary>
            /// Player Resist Recovery - Madness (f32)
            /// </summary>
            /// <remarks>
            /// Player resistance value recovery amount_madness [point / s]
            /// </remarks>
            public float PlayerResistRecoveryMadness 
            {
                get => (float)CellsByName["PlayerResistRecoveryMadness"].Value;
                set => CellsByName["PlayerResistRecoveryMadness"].Value = (float)value;
            }
            

            // Def="s32 animeID_MaterialItemPick"
            /// <summary>
            /// Material Pick-up - Animation ID (s32)
            /// </summary>
            /// <remarks>
            /// Animation ID when picking up a material item
            /// </remarks>
            public int MaterialPickUpAnimationID 
            {
                get => (int)CellsByName["MaterialPickUpAnimationID"].Value;
                set => CellsByName["MaterialPickUpAnimationID"].Value = (int)value;
            }
            

            // Def="f32 hpEstusFlaskAllocateRateForYellowMonk"
            /// <summary>
            /// HP Flask Reduction - Yellow Monk (f32)
            /// </summary>
            /// <remarks>
            /// Yellow Cloth HP Est Bottle Correction Magnification
            /// </remarks>
            public float HPFlaskReductionYellowMonk 
            {
                get => (float)CellsByName["HPFlaskReductionYellowMonk"].Value;
                set => CellsByName["HPFlaskReductionYellowMonk"].Value = (float)value;
            }
            

            // Def="s32 hpEstusFlaskAllocateOffsetForYellowMonk"
            /// <summary>
            /// HP Flask Offset - Yellow Monk (s32)
            /// </summary>
            /// <remarks>
            /// Yellow Cloth HP Est Bottle Offset
            /// </remarks>
            public int HPFlaskOffsetYellowMonk 
            {
                get => (int)CellsByName["HPFlaskOffsetYellowMonk"].Value;
                set => CellsByName["HPFlaskOffsetYellowMonk"].Value = (int)value;
            }
            

            // Def="f32 mpEstusFlaskAllocateRateForYellowMonk"
            /// <summary>
            /// FP Flask Reduction - Yellow Monk (f32)
            /// </summary>
            /// <remarks>
            /// Yellow Cloth MP Est Bottle Correction Magnification
            /// </remarks>
            public float FPFlaskReductionYellowMonk 
            {
                get => (float)CellsByName["FPFlaskReductionYellowMonk"].Value;
                set => CellsByName["FPFlaskReductionYellowMonk"].Value = (float)value;
            }
            

            // Def="s32 mpEstusFlaskAllocateOffsetForYellowMonk"
            /// <summary>
            /// FP Flask Offset - Yellow Monk (s32)
            /// </summary>
            /// <remarks>
            /// Yellow Cloth MP Est Bottle Offset
            /// </remarks>
            public int FPFlaskOffsetYellowMonk 
            {
                get => (int)CellsByName["FPFlaskOffsetYellowMonk"].Value;
                set => CellsByName["FPFlaskOffsetYellowMonk"].Value = (int)value;
            }
            

            // Def="f32 resistRecoverPoint_Sleep_Enemy"
            /// <summary>
            /// Enemy Resist Recovery - Sleep (f32)
            /// </summary>
            /// <remarks>
            /// Enemy resistance value recovery amount_sleep [point / s]
            /// </remarks>
            public float EnemyResistRecoverySleep 
            {
                get => (float)CellsByName["EnemyResistRecoverySleep"].Value;
                set => CellsByName["EnemyResistRecoverySleep"].Value = (float)value;
            }
            

            // Def="f32 resistRecoverPoint_Madness_Enemy"
            /// <summary>
            /// Enemy Resist Recovery - Madness (f32)
            /// </summary>
            /// <remarks>
            /// Enemy resistance value recovery amount_madness [point / s]
            /// </remarks>
            public float EnemyResistRecoveryMadness 
            {
                get => (float)CellsByName["EnemyResistRecoveryMadness"].Value;
                set => CellsByName["EnemyResistRecoveryMadness"].Value = (float)value;
            }
            

            // Def="s32 resistCurseItemId = -1"
            /// <summary>
            /// Resist Blight Item ID (s32)
            /// </summary>
            /// <remarks>
            /// Abnormal condition_immediate death_immediate death Item ID
            /// </remarks>
            public int ResistBlightItemID 
            {
                get => (int)CellsByName["ResistBlightItemID"].Value;
                set => CellsByName["ResistBlightItemID"].Value = (int)value;
            }
            

            // Def="u8 resistCurseItemMaxNum"
            /// <summary>
            /// Resist Blight Item Max Count (u8)
            /// </summary>
            /// <remarks>
            /// Abnormal condition_immediate death_maximum number of instant death items
            /// </remarks>
            public byte ResistBlightItemMaxCount 
            {
                get => (byte)CellsByName["ResistBlightItemMaxCount"].Value;
                set => CellsByName["ResistBlightItemMaxCount"].Value = (byte)value;
            }
            


            // Def="s32 resistCurseItemSpEffectBaseId = -1"
            /// <summary>
            /// Resist Blight Item - Base SpEffect ID (s32)
            /// </summary>
            /// <remarks>
            /// Abnormal condition_Instant death_Instant death Item possession Special effect base ID
            /// </remarks>
            public int ResistBlightItemBaseSpEffectID 
            {
                get => (int)CellsByName["ResistBlightItemBaseSpEffectID"].Value;
                set => CellsByName["ResistBlightItemBaseSpEffectID"].Value = (int)value;
            }
            

            // Def="s32 resistCurseItemLotParamId_map = -1"
            /// <summary>
            /// Resist Blight Item - Map Item Lot ID (s32)
            /// </summary>
            /// <remarks>
            /// Abnormal condition_immediate death_immediate death item lottery ID_for map
            /// </remarks>
            public int ResistBlightItemMapItemLotID 
            {
                get => (int)CellsByName["ResistBlightItemMapItemLotID"].Value;
                set => CellsByName["ResistBlightItemMapItemLotID"].Value = (int)value;
            }
            

                }
            }
            
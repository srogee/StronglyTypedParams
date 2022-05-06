
            namespace StronglyTypedParams
            {
                public class AssetGeometryParam : ParamRow
                {
                    public AssetGeometryParam() : base()
                    {
                    }
            

            // Def="s32 soundBankId = -1"
            /// <summary>
            /// Sound Bank ID (s32)
            /// </summary>
            /// <remarks>
            /// Sound bank ID (-1: no bank, other: bank with specified ID)
            /// </remarks>
            public int SoundBankID 
            {
                get => (int)CellsByName["SoundBankID"].Value;
                set => CellsByName["SoundBankID"].Value = value;
            }
            

            // Def="s32 soundBreakSEId = -1"
            /// <summary>
            /// Sound Break SE ID (s32)
            /// </summary>
            /// <remarks>
            /// Destruction sound SEID (9 digits) -1: Generated from assetId
            /// </remarks>
            public int SoundBreakSEID 
            {
                get => (int)CellsByName["SoundBreakSEID"].Value;
                set => CellsByName["SoundBreakSEID"].Value = value;
            }
            

            // Def="s32 refDrawParamId = -1"
            /// <summary>
            /// Draw Param Reference ID (s32)
            /// </summary>
            /// <remarks>
            /// Drawing parameter reference ID. The reference ID for the part drawing parameter .xlsm.
            /// </remarks>
            public int DrawParamReferenceID 
            {
                get => (int)CellsByName["DrawParamReferenceID"].Value;
                set => CellsByName["DrawParamReferenceID"].Value = value;
            }
            

            // Def="s8 hitCreateType"
            /// <summary>
            /// Hit Create Type (s8)
            /// </summary>
            /// <remarks>
            /// Sets the hit build type for static assets. Ignored for dynamic assets.
            /// </remarks>
            public sbyte HitCreateType 
            {
                get => (sbyte)CellsByName["HitCreateType"].Value;
                set => CellsByName["HitCreateType"].Value = value;
            }
            

            // Def="u8 behaviorType = 1"
            /// <summary>
            /// Asset Behavior Type (u8)
            /// </summary>
            /// <remarks>
            /// Dynamic (all asset features available), static (light assets with limited functionality treated as old maps), partially static (partially destroyed assets)
            /// </remarks>
            public byte AssetBehaviorType 
            {
                get => (byte)CellsByName["AssetBehaviorType"].Value;
                set => CellsByName["AssetBehaviorType"].Value = value;
            }
            

            // Def="u8 collisionType"
            /// <summary>
            /// Collision Detection Type (u8)
            /// </summary>
            /// <remarks>
            /// Collision detection type. You can set what the asset will hit.
            /// </remarks>
            public byte CollisionDetectionType 
            {
                get => (byte)CellsByName["CollisionDetectionType"].Value;
                set => CellsByName["CollisionDetectionType"].Value = value;
            }
            

            // Def="u8 rainBlockingType"
            /// <summary>
            /// Rain Blocking Type (u8)
            /// </summary>
            /// <remarks>
            /// It is a type of rain blocking. You can set the blocking of SFX and wet expression.
            /// </remarks>
            public byte RainBlockingType 
            {
                get => (byte)CellsByName["RainBlockingType"].Value;
                set => CellsByName["RainBlockingType"].Value = value;
            }
            

            // Def="s16 hp = -1"
            /// <summary>
            /// HP (s16)
            /// </summary>
            /// <remarks>
            /// Durability until destruction (-1: Indestructible)
            /// </remarks>
            public short HP 
            {
                get => (short)CellsByName["HP"].Value;
                set => CellsByName["HP"].Value = value;
            }
            

            // Def="u16 defense"
            /// <summary>
            /// Defence (u16)
            /// </summary>
            /// <remarks>
            /// Attack power below this value is no damage
            /// </remarks>
            public ushort Defence 
            {
                get => (ushort)CellsByName["Defence"].Value;
                set => CellsByName["Defence"].Value = value;
            }
            

            // Def="f32 breakStopTime = 30"
            /// <summary>
            /// Destruction Stop Time (f32)
            /// </summary>
            /// <remarks>
            /// Time from destruction to forced stop of rigid body (do not force stop at 0)
            /// </remarks>
            public float DestructionStopTime 
            {
                get => (float)CellsByName["DestructionStopTime"].Value;
                set => CellsByName["DestructionStopTime"].Value = value;
            }
            

            // Def="s32 breakSfxId = -1"
            /// <summary>
            /// Destruction SFX ID (s32)
            /// </summary>
            /// <remarks>
            /// SFX ID on destruction (-1: default (810030))
            /// </remarks>
            public int DestructionSFXID 
            {
                get => (int)CellsByName["DestructionSFXID"].Value;
                set => CellsByName["DestructionSFXID"].Value = value;
            }
            

            // Def="s32 breakSfxCpId = -1"
            /// <summary>
            /// Destruction SFX Dummy Poly ID (s32)
            /// </summary>
            /// <remarks>
            /// SFX generation position at the time of destruction Damipoly ID (-1: placement position)
            /// </remarks>
            public int DestructionSFXDummyPolyID 
            {
                get => (int)CellsByName["DestructionSFXDummyPolyID"].Value;
                set => CellsByName["DestructionSFXDummyPolyID"].Value = value;
            }
            

            // Def="s32 breakLandingSfxId = -1"
            /// <summary>
            /// Destruction Landing SFX ID (s32)
            /// </summary>
            /// <remarks>
            /// Object material-dependent SFX identifier that regenerates when first landing after being destroyed (-1: does not occur)
            /// </remarks>
            public int DestructionLandingSFXID 
            {
                get => (int)CellsByName["DestructionLandingSFXID"].Value;
                set => CellsByName["DestructionLandingSFXID"].Value = value;
            }
            

            // Def="s32 breakBulletBehaviorId = -1"
            /// <summary>
            /// Destruction Bullet Behavior ID (s32)
            /// </summary>
            /// <remarks>
            /// Action parameter of [bullet] at the time of destruction (-1: does not occur). Please note that there is an offset specification due to laps. ([GR] SEQ35556)
            /// </remarks>
            public int DestructionBulletBehaviorID 
            {
                get => (int)CellsByName["DestructionBulletBehaviorID"].Value;
                set => CellsByName["DestructionBulletBehaviorID"].Value = value;
            }
            

            // Def="s32 breakBulletCpId = -1"
            /// <summary>
            /// Destruction Bullet Dummy Poly ID (s32)
            /// </summary>
            /// <remarks>
            /// Location of [bullet] at the time of destruction Damipoli ID (-1: placement position)
            /// </remarks>
            public int DestructionBulletDummyPolyID 
            {
                get => (int)CellsByName["DestructionBulletDummyPolyID"].Value;
                set => CellsByName["DestructionBulletDummyPolyID"].Value = value;
            }
            

            // Def="f32 FragmentInvisibleWaitTime"
            /// <summary>
            /// Hidden Debris - Wait Time (f32)
            /// </summary>
            /// <remarks>
            /// Hidden debris Waiting time (seconds)
            /// </remarks>
            public float HiddenDebrisWaitTime 
            {
                get => (float)CellsByName["HiddenDebrisWaitTime"].Value;
                set => CellsByName["HiddenDebrisWaitTime"].Value = value;
            }
            

            // Def="f32 FragmentInvisibleTime"
            /// <summary>
            /// Hidden Debris - Time to Hide (f32)
            /// </summary>
            /// <remarks>
            /// Time to hide debris (seconds)
            /// </remarks>
            public float HiddenDebrisTimeToHide 
            {
                get => (float)CellsByName["HiddenDebrisTimeToHide"].Value;
                set => CellsByName["HiddenDebrisTimeToHide"].Value = value;
            }
            

            // Def="s32 BreakAiSoundID"
            /// <summary>
            /// Destruction AI Sound ID (s32)
            /// </summary>
            /// <remarks>
            /// AI sound ID generated at the time of destruction
            /// </remarks>
            public int DestructionAISoundID 
            {
                get => (int)CellsByName["DestructionAISoundID"].Value;
                set => CellsByName["DestructionAISoundID"].Value = value;
            }
            

            // Def="s8 breakItemLotType"
            /// <summary>
            /// Destruction Item Lot Type (s8)
            /// </summary>
            /// <remarks>
            /// A type that decides how to obtain items drawn at the time of destruction
            /// </remarks>
            public sbyte DestructionItemLotType 
            {
                get => (sbyte)CellsByName["DestructionItemLotType"].Value;
                set => CellsByName["DestructionItemLotType"].Value = value;
            }
            

            // Def="u8 animBreakIdMax"
            /// <summary>
            /// Anim Break ID Max (u8)
            /// </summary>
            /// <remarks>
            /// What is the animation destruction ID from 0 to what?
            /// </remarks>
            public byte AnimBreakIDMax 
            {
                get => (byte)CellsByName["AnimBreakIDMax"].Value;
                set => CellsByName["AnimBreakIDMax"].Value = value;
            }
            

            // Def="s8 breakBulletAttributeDamageType"
            /// <summary>
            /// Destruction Bullet Attribute Damage Type (s8)
            /// </summary>
            /// <remarks>
            /// Generates a bullet if the last damage received when destroying an asset meets the conditions of this setting.
            /// </remarks>
            public sbyte DestructionBulletAttributeDamageType 
            {
                get => (sbyte)CellsByName["DestructionBulletAttributeDamageType"].Value;
                set => CellsByName["DestructionBulletAttributeDamageType"].Value = value;
            }
            

            // Def="u8 isBreakByPlayerCollide:1"
            /// <summary>
            /// Is Destroyed on Player Collision (u8)
            /// </summary>
            /// <remarks>
            /// Broken when the player touches (0: no, 1:)
            /// </remarks>
            public byte IsDestroyedOnPlayerCollision 
            {
                get => (byte)CellsByName["IsDestroyedOnPlayerCollision"].Value;
                set => CellsByName["IsDestroyedOnPlayerCollision"].Value = value;
            }
            

            // Def="u8 isBreakByEnemyCollide:1"
            /// <summary>
            /// Is Destroyed on Enemy Collision (u8)
            /// </summary>
            /// <remarks>
            /// Broken when an enemy character touches (0: No, 1: Ru)
            /// </remarks>
            public byte IsDestroyedOnEnemyCollision 
            {
                get => (byte)CellsByName["IsDestroyedOnEnemyCollision"].Value;
                set => CellsByName["IsDestroyedOnEnemyCollision"].Value = value;
            }
            

            // Def="u8 isBreak_ByChrRide:1"
            /// <summary>
            /// Is Destroyed by Riding (u8)
            /// </summary>
            /// <remarks>
            /// Will it break if the character gets on (0: it won't break 1: it will break)
            /// </remarks>
            public byte IsDestroyedByRiding 
            {
                get => (byte)CellsByName["IsDestroyedByRiding"].Value;
                set => CellsByName["IsDestroyedByRiding"].Value = value;
            }
            

            // Def="u8 isDisableBreakForFirstAppear:1"
            /// <summary>
            /// Is Destroyed by Default (u8)
            /// </summary>
            /// <remarks>
            /// Broken at the initial appearance of the player (0: ru, 1: no)
            /// </remarks>
            public byte IsDestroyedByDefault 
            {
                get => (byte)CellsByName["IsDestroyedByDefault"].Value;
                set => CellsByName["IsDestroyedByDefault"].Value = value;
            }
            

            // Def="u8 isAnimBreak:1"
            /// <summary>
            /// Is Animated Destruction (u8)
            /// </summary>
            /// <remarks>
            /// Is it animation destruction (0: physical destruction, 1: animation destruction)
            /// </remarks>
            public byte IsAnimatedDestruction 
            {
                get => (byte)CellsByName["IsAnimatedDestruction"].Value;
                set => CellsByName["IsAnimatedDestruction"].Value = value;
            }
            

            // Def="u8 isDamageCover:1"
            /// <summary>
            /// Is Damage Transferred (u8)
            /// </summary>
            /// <remarks>
            /// Whether to pass the damage to the other side when receiving damage (0: pass, 1: do not pass)
            /// </remarks>
            public byte IsDamageTransferred 
            {
                get => (byte)CellsByName["IsDamageTransferred"].Value;
                set => CellsByName["IsDamageTransferred"].Value = value;
            }
            

            // Def="u8 isAttackBacklash:1 = 1"
            /// <summary>
            /// Is Attack Backlash (u8)
            /// </summary>
            /// <remarks>
            /// Do you play the attack (0: do not play, 1: play)
            /// </remarks>
            public byte IsAttackBacklash 
            {
                get => (byte)CellsByName["IsAttackBacklash"].Value;
                set => CellsByName["IsAttackBacklash"].Value = value;
            }
            

            // Def="dummy8 Reserve_2:1"
            /// <summary>
            /// Reserve 2 (dummy8)
            /// </summary>
            /// <remarks>
            /// 
            /// </remarks>
            public object Reserve2 
            {
                get => (object)CellsByName["Reserve2"].Value;
                set => CellsByName["Reserve2"].Value = value;
            }
            

            // Def="u8 isLadder:1"
            /// <summary>
            /// Is Ladder (u8)
            /// </summary>
            /// <remarks>
            /// Is it a ladder (0: different, 1: yes)
            /// </remarks>
            public byte IsLadder 
            {
                get => (byte)CellsByName["IsLadder"].Value;
                set => CellsByName["IsLadder"].Value = value;
            }
            

            // Def="u8 isMoveObj:1"
            /// <summary>
            /// Is Moving Object (u8)
            /// </summary>
            /// <remarks>
            /// Is it a moving object? It is a flag used for branching of movement processing at the time of multi (0: different, 1: yes)
            /// </remarks>
            public byte IsMovingObject 
            {
                get => (byte)CellsByName["IsMovingObject"].Value;
                set => CellsByName["IsMovingObject"].Value = value;
            }
            

            // Def="u8 isSkydomeFlag:1"
            /// <summary>
            /// Is Celestial Sphere (u8)
            /// </summary>
            /// <remarks>
            /// Processing that treats the celestial sphere (player tracking, etc.) is performed (0: different, 1: yes)
            /// </remarks>
            public byte IsCelestialSphere 
            {
                get => (byte)CellsByName["IsCelestialSphere"].Value;
                set => CellsByName["IsCelestialSphere"].Value = value;
            }
            

            // Def="u8 isAnimPauseOnRemoPlay:1"
            /// <summary>
            /// Is Paused during Cutscene (u8)
            /// </summary>
            /// <remarks>
            /// Do you want to stop the animation during the poly play (0: not, 1: do)
            /// </remarks>
            public byte IsPausedDuringCutscene 
            {
                get => (byte)CellsByName["IsPausedDuringCutscene"].Value;
                set => CellsByName["IsPausedDuringCutscene"].Value = value;
            }
            

            // Def="u8 isBurn:1"
            /// <summary>
            /// Is Flammable (u8)
            /// </summary>
            /// <remarks>
            /// Will it burn (0: not, 1:)
            /// </remarks>
            public byte IsFlammable 
            {
                get => (byte)CellsByName["IsFlammable"].Value;
                set => CellsByName["IsFlammable"].Value = value;
            }
            

            // Def="u8 isEnableRepick:1"
            /// <summary>
            /// Is Repicked (u8)
            /// </summary>
            /// <remarks>
            /// If this flag is ○, the parameter "At the time of recollection _ ***" will be used for the assets to be collected again in units of placement.
            /// </remarks>
            public byte IsRepicked 
            {
                get => (byte)CellsByName["IsRepicked"].Value;
                set => CellsByName["IsRepicked"].Value = value;
            }
            

            // Def="u8 isBreakOnPickUp:1"
            /// <summary>
            /// Is Destroyed on Pickup (u8)
            /// </summary>
            /// <remarks>
            /// If ×, play the animation at the time of collection, if ○, destroy at the time of collection (destroy in all cases including replacement)
            /// </remarks>
            public byte IsDestroyedOnPickup 
            {
                get => (byte)CellsByName["IsDestroyedOnPickup"].Value;
                set => CellsByName["IsDestroyedOnPickup"].Value = value;
            }
            

            // Def="u8 isBreakByHugeenemyCollide:1"
            /// <summary>
            /// Is Destroyed by Giant Collision (u8)
            /// </summary>
            /// <remarks>
            /// Broken when a giant enemy touches (0: No, 1:)
            /// </remarks>
            public byte IsDestroyedByGiantCollision 
            {
                get => (byte)CellsByName["IsDestroyedByGiantCollision"].Value;
                set => CellsByName["IsDestroyedByGiantCollision"].Value = value;
            }
            

            // Def="u8 navimeshFlag"
            /// <summary>
            /// Pre-destruction Navmesh Flag (u8)
            /// </summary>
            /// <remarks>
            /// Navigation mesh flag set from assets before destruction
            /// </remarks>
            public byte PreDestructionNavmeshFlag 
            {
                get => (byte)CellsByName["PreDestructionNavmeshFlag"].Value;
                set => CellsByName["PreDestructionNavmeshFlag"].Value = value;
            }
            

            // Def="u16 burnBulletInterval = 30"
            /// <summary>
            /// Burn Bullet Interval (u16)
            /// </summary>
            /// <remarks>
            /// Interval (frame) to generate bullets for spreading fire
            /// </remarks>
            public ushort BurnBulletInterval 
            {
                get => (ushort)CellsByName["BurnBulletInterval"].Value;
                set => CellsByName["BurnBulletInterval"].Value = value;
            }
            

            // Def="f32 clothUpdateDist = 30"
            /// <summary>
            /// Camera Distance to Update Cloth (f32)
            /// </summary>
            /// <remarks>
            /// Distance from the camera to update havokCloth (0: always update)
            /// </remarks>
            public float CameraDistanceToUpdateCloth 
            {
                get => (float)CellsByName["CameraDistanceToUpdateCloth"].Value;
                set => CellsByName["CameraDistanceToUpdateCloth"].Value = value;
            }
            

            // Def="f32 lifeTime_forRuntimeCreate"
            /// <summary>
            /// Duration after Creation until Disappearance (f32)
            /// </summary>
            /// <remarks>
            /// Runtime-generated time after creation until disappearance (0: does not disappear)
            /// </remarks>
            public float DurationAfterCreationUntilDisappearance 
            {
                get => (float)CellsByName["DurationAfterCreationUntilDisappearance"].Value;
                set => CellsByName["DurationAfterCreationUntilDisappearance"].Value = value;
            }
            

            // Def="s32 contactSeId = -1"
            /// <summary>
            /// Contact SE ID (s32)
            /// </summary>
            /// <remarks>
            /// SE ID to play when touched by a local player operated by you (-1: Do not play)
            /// </remarks>
            public int ContactSEID 
            {
                get => (int)CellsByName["ContactSEID"].Value;
                set => CellsByName["ContactSEID"].Value = value;
            }
            

            // Def="s32 repickAnimIdOffset"
            /// <summary>
            /// Repick Anim ID Offset (s32)
            /// </summary>
            /// <remarks>
            /// When recollecting assets with "Is there a change at the time of recollection?" In units of placement, play the uncollected / collected animation with the anime ID offset by this value.
            /// </remarks>
            public int RepickAnimIDOffset 
            {
                get => (int)CellsByName["RepickAnimIDOffset"].Value;
                set => CellsByName["RepickAnimIDOffset"].Value = value;
            }
            

            // Def="f32 windEffectRate_0 = 0.5"
            /// <summary>
            /// Wind Effect Rate - Before Destruction (f32)
            /// </summary>
            /// <remarks>
            /// Wind coefficient (before destruction)
            /// </remarks>
            public float WindEffectRateBeforeDestruction 
            {
                get => (float)CellsByName["WindEffectRateBeforeDestruction"].Value;
                set => CellsByName["WindEffectRateBeforeDestruction"].Value = value;
            }
            

            // Def="f32 windEffectRate_1 = 0.5"
            /// <summary>
            /// Wind Effect Rate - After Destruction (f32)
            /// </summary>
            /// <remarks>
            /// Wind coefficient (after destruction)
            /// </remarks>
            public float WindEffectRateAfterDestruction 
            {
                get => (float)CellsByName["WindEffectRateAfterDestruction"].Value;
                set => CellsByName["WindEffectRateAfterDestruction"].Value = value;
            }
            

            // Def="u8 windEffectType_0"
            /// <summary>
            /// Wind Effect Type - Before Destruction (u8)
            /// </summary>
            /// <remarks>
            /// Wind effect type (before destruction)
            /// </remarks>
            public byte WindEffectTypeBeforeDestruction 
            {
                get => (byte)CellsByName["WindEffectTypeBeforeDestruction"].Value;
                set => CellsByName["WindEffectTypeBeforeDestruction"].Value = value;
            }
            

            // Def="u8 windEffectType_1"
            /// <summary>
            /// Wind Effect Type - After Destruction (u8)
            /// </summary>
            /// <remarks>
            /// Wind effect type (after destruction)
            /// </remarks>
            public byte WindEffectTypeAfterDestruction 
            {
                get => (byte)CellsByName["WindEffectTypeAfterDestruction"].Value;
                set => CellsByName["WindEffectTypeAfterDestruction"].Value = value;
            }
            

            // Def="s16 overrideMaterialId = -1"
            /// <summary>
            /// Override Material ID (s16)
            /// </summary>
            /// <remarks>
            /// Asset material ID overwrite setting (-1: Do not overwrite model material ID 0 or more: Material ID overwrite) On the ladder, the material ID is reflected only with this setting
            /// </remarks>
            public short OverrideMaterialID 
            {
                get => (short)CellsByName["OverrideMaterialID"].Value;
                set => CellsByName["OverrideMaterialID"].Value = value;
            }
            

            // Def="f32 autoCreateOffsetHeight = 0.1"
            /// <summary>
            /// Automatic Generation Height Offset (f32)
            /// </summary>
            /// <remarks>
            /// Height offset of how much it floats from where the raycast hits the map when it is automatically generated [m]
            /// </remarks>
            public float AutomaticGenerationHeightOffset 
            {
                get => (float)CellsByName["AutomaticGenerationHeightOffset"].Value;
                set => CellsByName["AutomaticGenerationHeightOffset"].Value = value;
            }
            

            // Def="f32 burnTime"
            /// <summary>
            /// Burn Time (f32)
            /// </summary>
            /// <remarks>
            /// Burning time (seconds) (continues to burn at 0)
            /// </remarks>
            public float BurnTime 
            {
                get => (float)CellsByName["BurnTime"].Value;
                set => CellsByName["BurnTime"].Value = value;
            }
            

            // Def="f32 burnBraekRate = 0.5"
            /// <summary>
            /// Burn Destroy Rate (f32)
            /// </summary>
            /// <remarks>
            /// Burnup threshold for switching to the ruptured state
            /// </remarks>
            public float BurnDestroyRate 
            {
                get => (float)CellsByName["BurnDestroyRate"].Value;
                set => CellsByName["BurnDestroyRate"].Value = value;
            }
            

            // Def="s32 burnSfxId = -1"
            /// <summary>
            /// Burn SFX ID [0] (s32)
            /// </summary>
            /// <remarks>
            /// SFX ID at the time of combustion: 0 (-1: No SFX)
            /// </remarks>
            public int BurnSFXID0 
            {
                get => (int)CellsByName["BurnSFXID0"].Value;
                set => CellsByName["BurnSFXID0"].Value = value;
            }
            

            // Def="s32 burnSfxId_1 = -1"
            /// <summary>
            /// Burn SFX ID [1] (s32)
            /// </summary>
            /// <remarks>
            /// SFX ID at the time of combustion: 1 (-1: No SFX)
            /// </remarks>
            public int BurnSFXID1 
            {
                get => (int)CellsByName["BurnSFXID1"].Value;
                set => CellsByName["BurnSFXID1"].Value = value;
            }
            

            // Def="s32 burnSfxId_2 = -1"
            /// <summary>
            /// Burn SFX ID [2] (s32)
            /// </summary>
            /// <remarks>
            /// SFX ID at the time of combustion: 2 (-1: No SFX)
            /// </remarks>
            public int BurnSFXID2 
            {
                get => (int)CellsByName["BurnSFXID2"].Value;
                set => CellsByName["BurnSFXID2"].Value = value;
            }
            

            // Def="s32 burnSfxId_3 = -1"
            /// <summary>
            /// Burn SFX ID [3] (s32)
            /// </summary>
            /// <remarks>
            /// SFX ID at the time of combustion: 3 (-1: No SFX)
            /// </remarks>
            public int BurnSFXID3 
            {
                get => (int)CellsByName["BurnSFXID3"].Value;
                set => CellsByName["BurnSFXID3"].Value = value;
            }
            

            // Def="f32 burnSfxDelayTimeMin"
            /// <summary>
            /// Burn SFX Minimum Delay Time [0] (f32)
            /// </summary>
            /// <remarks>
            /// SFX generation delay time during combustion Randomly determined between start and end times
            /// </remarks>
            public float BurnSFXMinimumDelayTime0 
            {
                get => (float)CellsByName["BurnSFXMinimumDelayTime0"].Value;
                set => CellsByName["BurnSFXMinimumDelayTime0"].Value = value;
            }
            

            // Def="f32 burnSfxDelayTimeMin_1"
            /// <summary>
            /// Burn SFX Minimum Delay Time [1] (f32)
            /// </summary>
            /// <remarks>
            /// SFX generation delay time during combustion Randomly determined between start and end times
            /// </remarks>
            public float BurnSFXMinimumDelayTime1 
            {
                get => (float)CellsByName["BurnSFXMinimumDelayTime1"].Value;
                set => CellsByName["BurnSFXMinimumDelayTime1"].Value = value;
            }
            

            // Def="f32 burnSfxDelayTimeMin_2"
            /// <summary>
            /// Burn SFX Minimum Delay Time [2] (f32)
            /// </summary>
            /// <remarks>
            /// SFX generation delay time during combustion Randomly determined between start and end times
            /// </remarks>
            public float BurnSFXMinimumDelayTime2 
            {
                get => (float)CellsByName["BurnSFXMinimumDelayTime2"].Value;
                set => CellsByName["BurnSFXMinimumDelayTime2"].Value = value;
            }
            

            // Def="f32 burnSfxDelayTimeMin_3"
            /// <summary>
            /// Burn SFX Minimum Delay Time [3] (f32)
            /// </summary>
            /// <remarks>
            /// SFX generation delay time during combustion Randomly determined between start and end times
            /// </remarks>
            public float BurnSFXMinimumDelayTime3 
            {
                get => (float)CellsByName["BurnSFXMinimumDelayTime3"].Value;
                set => CellsByName["BurnSFXMinimumDelayTime3"].Value = value;
            }
            

            // Def="f32 burnSfxDelayTimeMax"
            /// <summary>
            /// Burn SFX Maximum Delay Time [0] (f32)
            /// </summary>
            /// <remarks>
            /// SFX generation delay time during combustion Randomly determined between start and end times
            /// </remarks>
            public float BurnSFXMaximumDelayTime0 
            {
                get => (float)CellsByName["BurnSFXMaximumDelayTime0"].Value;
                set => CellsByName["BurnSFXMaximumDelayTime0"].Value = value;
            }
            

            // Def="f32 burnSfxDelayTimeMax_1"
            /// <summary>
            /// Burn SFX Maximum Delay Time [1] (f32)
            /// </summary>
            /// <remarks>
            /// SFX generation delay time during combustion Randomly determined between start and end times
            /// </remarks>
            public float BurnSFXMaximumDelayTime1 
            {
                get => (float)CellsByName["BurnSFXMaximumDelayTime1"].Value;
                set => CellsByName["BurnSFXMaximumDelayTime1"].Value = value;
            }
            

            // Def="f32 burnSfxDelayTimeMax_2"
            /// <summary>
            /// Burn SFX Maximum Delay Time [2] (f32)
            /// </summary>
            /// <remarks>
            /// SFX generation delay time during combustion Randomly determined between start and end times
            /// </remarks>
            public float BurnSFXMaximumDelayTime2 
            {
                get => (float)CellsByName["BurnSFXMaximumDelayTime2"].Value;
                set => CellsByName["BurnSFXMaximumDelayTime2"].Value = value;
            }
            

            // Def="f32 burnSfxDelayTimeMax_3"
            /// <summary>
            /// Burn SFX Maximum Delay Time [3] (f32)
            /// </summary>
            /// <remarks>
            /// SFX generation delay time during combustion Randomly determined between start and end times
            /// </remarks>
            public float BurnSFXMaximumDelayTime3 
            {
                get => (float)CellsByName["BurnSFXMaximumDelayTime3"].Value;
                set => CellsByName["BurnSFXMaximumDelayTime3"].Value = value;
            }
            

            // Def="s32 burnBulletBehaviorId = -1"
            /// <summary>
            /// Burn Bullet Behavior ID [0] (s32)
            /// </summary>
            /// <remarks>
            /// Bullet generation behavior parameter at the time of burning: 0 (-1: does not occur)
            /// </remarks>
            public int BurnBulletBehaviorID0 
            {
                get => (int)CellsByName["BurnBulletBehaviorID0"].Value;
                set => CellsByName["BurnBulletBehaviorID0"].Value = value;
            }
            

            // Def="s32 burnBulletBehaviorId_1 = -1"
            /// <summary>
            /// Burn Bullet Behavior ID [1] (s32)
            /// </summary>
            /// <remarks>
            /// Bullet generation behavior parameter at the time of burning: 1 (-1: does not occur)
            /// </remarks>
            public int BurnBulletBehaviorID1 
            {
                get => (int)CellsByName["BurnBulletBehaviorID1"].Value;
                set => CellsByName["BurnBulletBehaviorID1"].Value = value;
            }
            

            // Def="s32 burnBulletBehaviorId_2 = -1"
            /// <summary>
            /// Burn Bullet Behavior ID [2] (s32)
            /// </summary>
            /// <remarks>
            /// Bullet generation behavior parameter at the time of burning: 2 (-1: does not occur)
            /// </remarks>
            public int BurnBulletBehaviorID2 
            {
                get => (int)CellsByName["BurnBulletBehaviorID2"].Value;
                set => CellsByName["BurnBulletBehaviorID2"].Value = value;
            }
            

            // Def="s32 burnBulletBehaviorId_3 = -1"
            /// <summary>
            /// Burn Bullet Behavior ID [3] (s32)
            /// </summary>
            /// <remarks>
            /// Bullet generation behavior parameter at the time of burning: 3 (-1: does not occur)
            /// </remarks>
            public int BurnBulletBehaviorID3 
            {
                get => (int)CellsByName["BurnBulletBehaviorID3"].Value;
                set => CellsByName["BurnBulletBehaviorID3"].Value = value;
            }
            

            // Def="f32 burnBulletDelayTime"
            /// <summary>
            /// Burn Bullet Delay Time (f32)
            /// </summary>
            /// <remarks>
            /// Time to delay the generation of bullets for fire spread (seconds)
            /// </remarks>
            public float BurnBulletDelayTime 
            {
                get => (float)CellsByName["BurnBulletDelayTime"].Value;
                set => CellsByName["BurnBulletDelayTime"].Value = value;
            }
            

            // Def="u16 paintDecalTargetTextureSize"
            /// <summary>
            /// Paint Decal Target Texture Size (u16)
            /// </summary>
            /// <remarks>
            /// Paint decal target size 0: Decal disabled (0 to 4096 power of 2 0, 2, 4, 8,… 2048 only valid)
            /// </remarks>
            public ushort PaintDecalTargetTextureSize 
            {
                get => (ushort)CellsByName["PaintDecalTargetTextureSize"].Value;
                set => CellsByName["PaintDecalTargetTextureSize"].Value = value;
            }
            

            // Def="u8 navimeshFlag_after"
            /// <summary>
            /// Post-destruction Navmesh Flag (u8)
            /// </summary>
            /// <remarks>
            /// Navimesh flag set from the destroyed asset
            /// </remarks>
            public byte PostDestructionNavmeshFlag 
            {
                get => (byte)CellsByName["PostDestructionNavmeshFlag"].Value;
                set => CellsByName["PostDestructionNavmeshFlag"].Value = value;
            }
            

            // Def="s8 camNearBehaviorType"
            /// <summary>
            /// Near Camera Behavior Type (s8)
            /// </summary>
            /// <remarks>
            /// Drawing settings when approaching the camera. [GR] SEQ07529
            /// </remarks>
            public sbyte NearCameraBehaviorType 
            {
                get => (sbyte)CellsByName["NearCameraBehaviorType"].Value;
                set => CellsByName["NearCameraBehaviorType"].Value = value;
            }
            

            // Def="s32 breakItemLotParamId = -1"
            /// <summary>
            /// Destroyed Item Lot Param ID (s32)
            /// </summary>
            /// <remarks>
            /// Item to be drawn at the time of destruction Lottery ID_for map-1: No lottery
            /// </remarks>
            public int DestroyedItemLotParamID 
            {
                get => (int)CellsByName["DestroyedItemLotParamID"].Value;
                set => CellsByName["DestroyedItemLotParamID"].Value = value;
            }
            

            // Def="s32 pickUpActionButtonParamId = -1"
            /// <summary>
            /// Pickup Action Button Param ID (s32)
            /// </summary>
            /// <remarks>
            /// Action button ID issued for collection-1: Collection function is disabled
            /// </remarks>
            public int PickupActionButtonParamID 
            {
                get => (int)CellsByName["PickupActionButtonParamID"].Value;
                set => CellsByName["PickupActionButtonParamID"].Value = value;
            }
            

            // Def="s32 pickUpItemLotParamId = -1"
            /// <summary>
            /// Pickup Item Lot Param ID (s32)
            /// </summary>
            /// <remarks>
            /// Item to be drawn at the time of collection For lottery ID_map-1: Collection function is invalid
            /// </remarks>
            public int PickupItemLotParamID 
            {
                get => (int)CellsByName["PickupItemLotParamID"].Value;
                set => CellsByName["PickupItemLotParamID"].Value = value;
            }
            

            // Def="u8 autoDrawGroupBackFaceCheck"
            /// <summary>
            /// Auto Draw Group: Backface Check (u8)
            /// </summary>
            /// <remarks>
            /// Automatic drawing group_Back side check
            /// </remarks>
            public byte AutoDrawGroupBackfaceCheck 
            {
                get => (byte)CellsByName["AutoDrawGroupBackfaceCheck"].Value;
                set => CellsByName["AutoDrawGroupBackfaceCheck"].Value = value;
            }
            

            // Def="u8 autoDrawGroupDepthWrite"
            /// <summary>
            /// Auto Draw Group: Depth Write (u8)
            /// </summary>
            /// <remarks>
            /// Auto drawing group_shield
            /// </remarks>
            public byte AutoDrawGroupDepthWrite 
            {
                get => (byte)CellsByName["AutoDrawGroupDepthWrite"].Value;
                set => CellsByName["AutoDrawGroupDepthWrite"].Value = value;
            }
            

            // Def="u8 autoDrawGroupShadowTest"
            /// <summary>
            /// Auto Draw Group: Shadow Test (u8)
            /// </summary>
            /// <remarks>
            /// Automatic drawing group_shadow test
            /// </remarks>
            public byte AutoDrawGroupShadowTest 
            {
                get => (byte)CellsByName["AutoDrawGroupShadowTest"].Value;
                set => CellsByName["AutoDrawGroupShadowTest"].Value = value;
            }
            

            // Def="u8 debug_isHeightCheckEnable"
            /// <summary>
            /// Is Height Check Enabled (u8)
            /// </summary>
            /// <remarks>
            /// Debug_Allow Ground Height Check See SEQ07876 for details
            /// </remarks>
            public byte IsHeightCheckEnabled 
            {
                get => (byte)CellsByName["IsHeightCheckEnabled"].Value;
                set => CellsByName["IsHeightCheckEnabled"].Value = value;
            }
            

            // Def="u8 hitCarverCancelAreaFlag"
            /// <summary>
            /// Exclude from Subfloor Navmesh if below Hit (u8)
            /// </summary>
            /// <remarks>
            /// If it is placed lower than the hit on the floor (ground), set whether to exclude it from the underfloor navigation mesh deletion target Refer to from the tool
            /// </remarks>
            public byte ExcludeFromSubfloorNavmeshIfBelowHit 
            {
                get => (byte)CellsByName["ExcludeFromSubfloorNavmeshIfBelowHit"].Value;
                set => CellsByName["ExcludeFromSubfloorNavmeshIfBelowHit"].Value = value;
            }
            

            // Def="u8 assetNavimeshNoCombine"
            /// <summary>
            /// Block Navmesh Combine (u8)
            /// </summary>
            /// <remarks>
            /// The set assets are excluded from the target of joining hit parts when building the Nav Mesh.
            /// </remarks>
            public byte BlockNavmeshCombine 
            {
                get => (byte)CellsByName["BlockNavmeshCombine"].Value;
                set => CellsByName["BlockNavmeshCombine"].Value = value;
            }
            

            // Def="u8 navimeshFlagApply"
            /// <summary>
            /// Navmesh Flag Apply Type (u8)
            /// </summary>
            /// <remarks>
            /// Where to apply the navigation mesh flag set from the asset
            /// </remarks>
            public byte NavmeshFlagApplyType 
            {
                get => (byte)CellsByName["NavmeshFlagApplyType"].Value;
                set => CellsByName["NavmeshFlagApplyType"].Value = value;
            }
            

            // Def="u8 navimeshFlagApply_after"
            /// <summary>
            /// Navmesh Flag Apply Type - Destroyed (u8)
            /// </summary>
            /// <remarks>
            /// Where to apply the navigation mesh flag set from the destroyed asset
            /// </remarks>
            public byte NavmeshFlagApplyTypeDestroyed 
            {
                get => (byte)CellsByName["NavmeshFlagApplyTypeDestroyed"].Value;
                set => CellsByName["NavmeshFlagApplyTypeDestroyed"].Value = value;
            }
            

            // Def="f32 autoDrawGroupPassPixelNum = -1"
            /// <summary>
            /// Auto Draw Group: Pass Pixel Number (f32)
            /// </summary>
            /// <remarks>
            /// Automatic drawing group_Pass pixel (set to 0.0-1.0 to enlarge at the time of shooting)
            /// </remarks>
            public float AutoDrawGroupPassPixelNumber 
            {
                get => (float)CellsByName["AutoDrawGroupPassPixelNumber"].Value;
                set => CellsByName["AutoDrawGroupPassPixelNumber"].Value = value;
            }
            

            // Def="u32 pickUpReplacementEventFlag"
            /// <summary>
            /// Pickup Replacement - Event Flag (u32)
            /// </summary>
            /// <remarks>
            /// When this event flag is ON, use the ID of the subsequent replacement 0: Do not always replace
            /// </remarks>
            public uint PickupReplacementEventFlag 
            {
                get => (uint)CellsByName["PickupReplacementEventFlag"].Value;
                set => CellsByName["PickupReplacementEventFlag"].Value = value;
            }
            

            // Def="s32 pickUpReplacementAnimIdOffset"
            /// <summary>
            /// Pickup Replacement - Anim ID Offset (s32)
            /// </summary>
            /// <remarks>
            /// When "Collecting_replacement flag condition" is ON, play the uncollected / collected animation with the animation ID offset by this value.
            /// </remarks>
            public int PickupReplacementAnimIDOffset 
            {
                get => (int)CellsByName["PickupReplacementAnimIDOffset"].Value;
                set => CellsByName["PickupReplacementAnimIDOffset"].Value = value;
            }
            

            // Def="s32 pickUpReplacementActionButtonParamId = -1"
            /// <summary>
            /// Pickup Replacement - Action Button Param ID (s32)
            /// </summary>
            /// <remarks>
            /// This action button ID is used when "Collecting_replacement flag condition" is ON.
            /// </remarks>
            public int PickupReplacementActionButtonParamID 
            {
                get => (int)CellsByName["PickupReplacementActionButtonParamID"].Value;
                set => CellsByName["PickupReplacementActionButtonParamID"].Value = value;
            }
            

            // Def="s32 pickUpReplacementItemLotParamId = -1"
            /// <summary>
            /// Pickup Replacement - Item Lot Param ID (s32)
            /// </summary>
            /// <remarks>
            /// When "Collecting_replacement flag condition" is ON, this item lottery ID_map is used.
            /// </remarks>
            public int PickupReplacementItemLotParamID 
            {
                get => (int)CellsByName["PickupReplacementItemLotParamID"].Value;
                set => CellsByName["PickupReplacementItemLotParamID"].Value = value;
            }
            

            // Def="u8 slidingBulletHitType"
            /// <summary>
            /// Sliding Bullet Hit Type (u8)
            /// </summary>
            /// <remarks>
            /// When a bullet of the follow-up type "Crawling on the ground even if it collides" collides with an asset, does it bend in the direction along the landing point? Behavior
            /// </remarks>
            public byte SlidingBulletHitType 
            {
                get => (byte)CellsByName["SlidingBulletHitType"].Value;
                set => CellsByName["SlidingBulletHitType"].Value = value;
            }
            

            // Def="u8 isBushesForDamage"
            /// <summary>
            /// Is Damaged by Special Attacks (u8)
            /// </summary>
            /// <remarks>
            /// ◯ Assets can only be damaged by "damage to bushes" ◯ and "object attack power> defense power" attacks [GR] SEQ20617
            /// </remarks>
            public byte IsDamagedBySpecialAttacks 
            {
                get => (byte)CellsByName["IsDamagedBySpecialAttacks"].Value;
                set => CellsByName["IsDamagedBySpecialAttacks"].Value = value;
            }
            

            // Def="u8 penetrationBulletType"
            /// <summary>
            /// Penetration Bullet Type (u8)
            /// </summary>
            /// <remarks>
            /// Will the bullet hit and land? Which bullet para to refer to when deciding? The value that determines.
            /// </remarks>
            public byte PenetrationBulletType 
            {
                get => (byte)CellsByName["PenetrationBulletType"].Value;
                set => CellsByName["PenetrationBulletType"].Value = value;
            }
            

            // Def="dummy8 Reserve_3[1]"
            /// <summary>
            /// Reserve 3 (dummy8)
            /// </summary>
            /// <remarks>
            /// 
            /// </remarks>
            public object Reserve3 
            {
                get => (object)CellsByName["Reserve3"].Value;
                set => CellsByName["Reserve3"].Value = value;
            }
            

            // Def="dummy8 Reserve_4[4]"
            /// <summary>
            /// Reserve 4 (dummy8)
            /// </summary>
            /// <remarks>
            /// 
            /// </remarks>
            public object Reserve4 
            {
                get => (object)CellsByName["Reserve4"].Value;
                set => CellsByName["Reserve4"].Value = value;
            }
            

            // Def="s32 soundBreakSECpId = -1"
            /// <summary>
            /// Destruction - Sound SE Dummy Poly ID (s32)
            /// </summary>
            /// <remarks>
            /// Damipoli ID of the place where the destruction sound is played (-1: Placement position)
            /// </remarks>
            public int DestructionSoundSEDummyPolyID 
            {
                get => (int)CellsByName["DestructionSoundSEDummyPolyID"].Value;
                set => CellsByName["DestructionSoundSEDummyPolyID"].Value = value;
            }
            

            // Def="f32 debug_HeightCheckCapacityMin = -99"
            /// <summary>
            /// Debug - Height Check Minimum (f32)
            /// </summary>
            /// <remarks>
            /// Debug_Allowable ground height_Minimum [m] See SEQ07876 for details. Must be smaller than maximum
            /// </remarks>
            public float DebugHeightCheckMinimum 
            {
                get => (float)CellsByName["DebugHeightCheckMinimum"].Value;
                set => CellsByName["DebugHeightCheckMinimum"].Value = value;
            }
            

            // Def="f32 debug_HeightCheckCapacityMax = 99"
            /// <summary>
            /// Debug - Height Check Maximum (f32)
            /// </summary>
            /// <remarks>
            /// Debug_Allowable ground height_Max [m] See SEQ07876 for details. Must be larger than minimum
            /// </remarks>
            public float DebugHeightCheckMaximum 
            {
                get => (float)CellsByName["DebugHeightCheckMaximum"].Value;
                set => CellsByName["DebugHeightCheckMaximum"].Value = value;
            }
            

            // Def="s32 repickActionButtonParamId = -1"
            /// <summary>
            /// Repick - Action Button ID (s32)
            /// </summary>
            /// <remarks>
            /// This action button ID is used when recollecting assets whose "Is there a change at the time of recollection?"
            /// </remarks>
            public int RepickActionButtonID 
            {
                get => (int)CellsByName["RepickActionButtonID"].Value;
                set => CellsByName["RepickActionButtonID"].Value = value;
            }
            

            // Def="s32 repickItemLotParamId = -1"
            /// <summary>
            /// Repick - Item Lot Param ID (s32)
            /// </summary>
            /// <remarks>
            /// Assets with "Is there a change at the time of recollection?" Are used for this item lottery ID_map when recollecting in units of placement.
            /// </remarks>
            public int RepickItemLotParamID 
            {
                get => (int)CellsByName["RepickItemLotParamID"].Value;
                set => CellsByName["RepickItemLotParamID"].Value = value;
            }
            

            // Def="s32 repickReplacementAnimIdOffset"
            /// <summary>
            /// Repick Replacement - Anim ID Offset (s32)
            /// </summary>
            /// <remarks>
            /// Use this parameter instead of "At the time of collection_replacement animation offset" at the time of recollection for assets whose "Is there a change at the time of recollection?"
            /// </remarks>
            public int RepickReplacementAnimIDOffset 
            {
                get => (int)CellsByName["RepickReplacementAnimIDOffset"].Value;
                set => CellsByName["RepickReplacementAnimIDOffset"].Value = value;
            }
            

            // Def="s32 repickReplacementActionButtonParamId = -1"
            /// <summary>
            /// Repick Replacement - Action Button Param ID (s32)
            /// </summary>
            /// <remarks>
            /// Use this parameter instead of "At the time of collection_replacement action button ID" when recollecting assets whose "Is there a change at the time of recollection?"
            /// </remarks>
            public int RepickReplacementActionButtonParamID 
            {
                get => (int)CellsByName["RepickReplacementActionButtonParamID"].Value;
                set => CellsByName["RepickReplacementActionButtonParamID"].Value = value;
            }
            

            // Def="s32 repickReplacementItemLotParamId = -1"
            /// <summary>
            /// Repick Replacement - Item Lot ID (s32)
            /// </summary>
            /// <remarks>
            /// Use this parameter instead of "At the time of collection_Replacement item lottery ID_For map" when recollecting assets whose "Is there a change at the time of recollection?"
            /// </remarks>
            public int RepickReplacementItemLotID 
            {
                get => (int)CellsByName["RepickReplacementItemLotID"].Value;
                set => CellsByName["RepickReplacementItemLotID"].Value = value;
            }
            

            // Def="u8 noGenerateCarver"
            /// <summary>
            /// Is Hit Carver Generation Blocked (u8)
            /// </summary>
            /// <remarks>
            /// Asset with this set does not create Carver
            /// </remarks>
            public byte IsHitCarverGenerationBlocked 
            {
                get => (byte)CellsByName["IsHitCarverGenerationBlocked"].Value;
                set => CellsByName["IsHitCarverGenerationBlocked"].Value = value;
            }
            

            // Def="u8 noHitHugeAfterBreak"
            /// <summary>
            /// Is Giant Enemy Hit by Destruction (u8)
            /// </summary>
            /// <remarks>
            /// Overwrite the hit filter after destruction with a collision detection type that does not hit a huge enemy (static ○ dynamic ○)
            /// </remarks>
            public byte IsGiantEnemyHitByDestruction 
            {
                get => (byte)CellsByName["IsGiantEnemyHitByDestruction"].Value;
                set => CellsByName["IsGiantEnemyHitByDestruction"].Value = value;
            }
            

            // Def="u8 isEnabledBreakSync:1 = 1"
            /// <summary>
            /// Is Destruction Synchronized (u8)
            /// </summary>
            /// <remarks>
            /// If this is x, do not perform initial synchronization, map activation synchronization, asset destruction synchronization during in-game, and the attack of the remote PC will not hit.
            /// </remarks>
            public byte IsDestructionSynchronized 
            {
                get => (byte)CellsByName["IsDestructionSynchronized"].Value;
                set => CellsByName["IsDestructionSynchronized"].Value = value;
            }
            

            // Def="u8 isHiddenOnRepick:1"
            /// <summary>
            /// Is Hidden on Repick (u8)
            /// </summary>
            /// <remarks>
            /// Hide assets if you can't get them by lottery when recollecting by placement unit
            /// </remarks>
            public byte IsHiddenOnRepick 
            {
                get => (byte)CellsByName["IsHiddenOnRepick"].Value;
                set => CellsByName["IsHiddenOnRepick"].Value = value;
            }
            

            // Def="u8 isCreateMultiPlayOnly:1"
            /// <summary>
            /// Is Valid for Multiplayer Only (u8)
            /// </summary>
            /// <remarks>
            /// Is it valid only during multi? Only valid for dynamic assets. (Details: SEQ15087)
            /// </remarks>
            public byte IsValidForMultiplayerOnly 
            {
                get => (byte)CellsByName["IsValidForMultiplayerOnly"].Value;
                set => CellsByName["IsValidForMultiplayerOnly"].Value = value;
            }
            

            // Def="u8 isDisableBulletHitSfx:1"
            /// <summary>
            /// Is Bullet Hit SFX Disabled (u8)
            /// </summary>
            /// <remarks>
            /// In the case of ○, the landing SFX does not occur regardless of whether the hit bullet penetrates or lands.
            /// </remarks>
            public byte IsBulletHitSFXDisabled 
            {
                get => (byte)CellsByName["IsBulletHitSFXDisabled"].Value;
                set => CellsByName["IsBulletHitSFXDisabled"].Value = value;
            }
            

            // Def="u8 isEnableSignPreBreak:1 = 1"
            /// <summary>
            /// Is Bloodstain/Sign Enabled before Destruction (u8)
            /// </summary>
            /// <remarks>
            /// Set whether sign / blood character can be created when on the asset (before destruction) 〇: Possible, ×: Impossible (Details: SEQ122568)
            /// </remarks>
            public byte IsBloodstainSignEnabledBeforeDestruction 
            {
                get => (byte)CellsByName["IsBloodstainSignEnabledBeforeDestruction"].Value;
                set => CellsByName["IsBloodstainSignEnabledBeforeDestruction"].Value = value;
            }
            

            // Def="u8 isEnableSignPostBreak:1 = 1"
            /// <summary>
            /// Is Bloodstain/Sign Enabled after Destruction (u8)
            /// </summary>
            /// <remarks>
            /// Set whether sign / blood character can be created when on the asset (after destruction) 〇: Possible, ×: Impossible (Details: SEQ122568)
            /// </remarks>
            public byte IsBloodstainSignEnabledAfterDestruction 
            {
                get => (byte)CellsByName["IsBloodstainSignEnabledAfterDestruction"].Value;
                set => CellsByName["IsBloodstainSignEnabledAfterDestruction"].Value = value;
            }
            

            // Def="dummy8 Reserve_1:2"
            /// <summary>
            /// Reserve 1 (dummy8)
            /// </summary>
            /// <remarks>
            /// 
            /// </remarks>
            public object Reserve1 
            {
                get => (object)CellsByName["Reserve1"].Value;
                set => CellsByName["Reserve1"].Value = value;
            }
            

            // Def="u8 generateMultiForbiddenRegion"
            /// <summary>
            /// Multiplayer Forbidden Region Type (u8)
            /// </summary>
            /// <remarks>
            /// Summoning prohibited / intrusion prohibited area generation (Damipoli)
            /// </remarks>
            public byte MultiplayerForbiddenRegionType 
            {
                get => (byte)CellsByName["MultiplayerForbiddenRegionType"].Value;
                set => CellsByName["MultiplayerForbiddenRegionType"].Value = value;
            }
            

            // Def="s32 residentSeId0 = -1"
            /// <summary>
            /// Resident SE ID [0] (s32)
            /// </summary>
            /// <remarks>
            /// Sound ID 0 (9 digits) to be resident in the asset (-1: No resident)
            /// </remarks>
            public int ResidentSEID0 
            {
                get => (int)CellsByName["ResidentSEID0"].Value;
                set => CellsByName["ResidentSEID0"].Value = value;
            }
            

            // Def="s32 residentSeId1 = -1"
            /// <summary>
            /// Resident SE ID [1] (s32)
            /// </summary>
            /// <remarks>
            /// Sound ID 1 (9 digits) to be resident in the asset (-1: No resident)
            /// </remarks>
            public int ResidentSEID1 
            {
                get => (int)CellsByName["ResidentSEID1"].Value;
                set => CellsByName["ResidentSEID1"].Value = value;
            }
            

            // Def="s32 residentSeId2 = -1"
            /// <summary>
            /// Resident SE ID [2] (s32)
            /// </summary>
            /// <remarks>
            /// Sound ID 2 (9 digits) to be resident in the asset (-1: No resident)
            /// </remarks>
            public int ResidentSEID2 
            {
                get => (int)CellsByName["ResidentSEID2"].Value;
                set => CellsByName["ResidentSEID2"].Value = value;
            }
            

            // Def="s32 residentSeId3 = -1"
            /// <summary>
            /// Resident SE ID [3] (s32)
            /// </summary>
            /// <remarks>
            /// Sound ID 3 (9 digits) to be resident in the asset (-1: not resident)
            /// </remarks>
            public int ResidentSEID3 
            {
                get => (int)CellsByName["ResidentSEID3"].Value;
                set => CellsByName["ResidentSEID3"].Value = value;
            }
            

            // Def="s16 residentSeDmypolyId0 = -1"
            /// <summary>
            /// Resident SE ID - Dummy Poly [0] (s16)
            /// </summary>
            /// <remarks>
            /// Damipoli ID0 to attach resident sound (-1: placement position)
            /// </remarks>
            public short ResidentSEIDDummyPoly0 
            {
                get => (short)CellsByName["ResidentSEIDDummyPoly0"].Value;
                set => CellsByName["ResidentSEIDDummyPoly0"].Value = value;
            }
            

            // Def="s16 residentSeDmypolyId1 = -1"
            /// <summary>
            /// Resident SE ID - Dummy Poly [1] (s16)
            /// </summary>
            /// <remarks>
            /// Damipoli ID1 to attach resident sound (-1: placement position)
            /// </remarks>
            public short ResidentSEIDDummyPoly1 
            {
                get => (short)CellsByName["ResidentSEIDDummyPoly1"].Value;
                set => CellsByName["ResidentSEIDDummyPoly1"].Value = value;
            }
            

            // Def="s16 residentSeDmypolyId2 = -1"
            /// <summary>
            /// Resident SE ID - Dummy Poly [2] (s16)
            /// </summary>
            /// <remarks>
            /// Damipoli ID2 to attach resident sound (-1: placement position)
            /// </remarks>
            public short ResidentSEIDDummyPoly2 
            {
                get => (short)CellsByName["ResidentSEIDDummyPoly2"].Value;
                set => CellsByName["ResidentSEIDDummyPoly2"].Value = value;
            }
            

            // Def="s16 residentSeDmypolyId3 = -1"
            /// <summary>
            /// Resident SE ID - Dummy Poly [3] (s16)
            /// </summary>
            /// <remarks>
            /// Damipoli ID3 to attach resident sound (-1: placement position)
            /// </remarks>
            public short ResidentSEIDDummyPoly3 
            {
                get => (short)CellsByName["ResidentSEIDDummyPoly3"].Value;
                set => CellsByName["ResidentSEIDDummyPoly3"].Value = value;
            }
            

            // Def="u8 excludeActivateRatio_Xboxone_Grid"
            /// <summary>
            /// Exclude Activate Ratio - Xbox One Grid (u8)
            /// </summary>
            /// <remarks>
            /// Open_XB1 exclusion rate [GR] SEQ25310
            /// </remarks>
            public byte ExcludeActivateRatioXboxOneGrid 
            {
                get => (byte)CellsByName["ExcludeActivateRatioXboxOneGrid"].Value;
                set => CellsByName["ExcludeActivateRatioXboxOneGrid"].Value = value;
            }
            

            // Def="u8 excludeActivateRatio_Xboxone_Legacy"
            /// <summary>
            /// Exclude Activate Ratio - Xbox One Legacy (u8)
            /// </summary>
            /// <remarks>
            /// Legacy_XB1 exclusion rate [GR] SEQ25310
            /// </remarks>
            public byte ExcludeActivateRatioXboxOneLegacy 
            {
                get => (byte)CellsByName["ExcludeActivateRatioXboxOneLegacy"].Value;
                set => CellsByName["ExcludeActivateRatioXboxOneLegacy"].Value = value;
            }
            

            // Def="u8 excludeActivateRatio_PS4_Grid"
            /// <summary>
            /// Exclude Activate Ratio - PS4 Grid (u8)
            /// </summary>
            /// <remarks>
            /// Open_PS4 exclusion rate [GR] SEQ25310
            /// </remarks>
            public byte ExcludeActivateRatioPS4Grid 
            {
                get => (byte)CellsByName["ExcludeActivateRatioPS4Grid"].Value;
                set => CellsByName["ExcludeActivateRatioPS4Grid"].Value = value;
            }
            

            // Def="u8 excludeActivateRatio_PS4_Legacy"
            /// <summary>
            /// Exclude Activate Ratio - PS4 Legacy (u8)
            /// </summary>
            /// <remarks>
            /// Legacy_PS4 exclusion rate [GR] SEQ25310
            /// </remarks>
            public byte ExcludeActivateRatioPS4Legacy 
            {
                get => (byte)CellsByName["ExcludeActivateRatioPS4Legacy"].Value;
                set => CellsByName["ExcludeActivateRatioPS4Legacy"].Value = value;
            }
            

            // Def="dummy8 Reserve_0[32]"
            /// <summary>
            /// Reserve 0 (dummy8)
            /// </summary>
            /// <remarks>
            /// Reserve 0
            /// </remarks>
            public object Reserve0 
            {
                get => (object)CellsByName["Reserve0"].Value;
                set => CellsByName["Reserve0"].Value = value;
            }
            
                }
            }
            
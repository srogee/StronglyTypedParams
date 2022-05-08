
            namespace StronglyTypedParams
            {
                // OBJECT_PARAM_ST
                public class ObjectParam : ParamRow
                {
                    public ObjectParam() : base()
                    {
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
                set => CellsByName["HP"].Value = (short)value;
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
                set => CellsByName["Defence"].Value = (ushort)value;
            }
            

            // Def="s16 extRefTexId = -1"
            /// <summary>
            /// External Texture ID (s16)
            /// </summary>
            /// <remarks>
            /// mAA / mAA_ ????. Tpf (-1: None) (AA: Area number)
            /// </remarks>
            public short ExternalTextureID 
            {
                get => (short)CellsByName["ExternalTextureID"].Value;
                set => CellsByName["ExternalTextureID"].Value = (short)value;
            }
            

            // Def="s16 materialId = -1"
            /// <summary>
            /// Material ID (s16)
            /// </summary>
            /// <remarks>
            /// Material ID. Treated the same as the floor material. When -1, the same behavior as before
            /// </remarks>
            public short MaterialID 
            {
                get => (short)CellsByName["MaterialID"].Value;
                set => CellsByName["MaterialID"].Value = (short)value;
            }
            

            // Def="u8 animBreakIdMax"
            /// <summary>
            /// Destruction Animation ID (u8)
            /// </summary>
            /// <remarks>
            /// What is the animation destruction ID from 0 to what?
            /// </remarks>
            public byte DestructionAnimationID 
            {
                get => (byte)CellsByName["DestructionAnimationID"].Value;
                set => CellsByName["DestructionAnimationID"].Value = (byte)value;
            }
            

            // Def="u8 isCamHit:1"
            /// <summary>
            /// Is Camera Hit (u8)
            /// </summary>
            /// <remarks>
            /// Does the camera hit (0: not hit, 1: hit)
            /// </remarks>
            public byte IsCameraHit 
            {
                get => (byte)CellsByName["IsCameraHit"].Value;
                set => CellsByName["IsCameraHit"].Value = (byte)value;
            }
            

            // Def="u8 isBreakByPlayerCollide:1"
            /// <summary>
            /// Is Broken by Player Collision (u8)
            /// </summary>
            /// <remarks>
            /// Broken when the player touches (0: no, 1:)
            /// </remarks>
            public byte IsBrokenByPlayerCollision 
            {
                get => (byte)CellsByName["IsBrokenByPlayerCollision"].Value;
                set => CellsByName["IsBrokenByPlayerCollision"].Value = (byte)value;
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
                set => CellsByName["IsAnimatedDestruction"].Value = (byte)value;
            }
            

            // Def="u8 isPenetrationBulletHit:1"
            /// <summary>
            /// Is Penetrated by Bullet (u8)
            /// </summary>
            /// <remarks>
            /// Will the penetrating bullet hit (0: not hit, 1: hit)
            /// </remarks>
            public byte IsPenetratedByBullet 
            {
                get => (byte)CellsByName["IsPenetratedByBullet"].Value;
                set => CellsByName["IsPenetratedByBullet"].Value = (byte)value;
            }
            

            // Def="u8 isChrHit:1 = 1"
            /// <summary>
            /// Is Character Hit (u8)
            /// </summary>
            /// <remarks>
            /// Does the character win (0: not hit, 1: hit)
            /// </remarks>
            public byte IsCharacterHit 
            {
                get => (byte)CellsByName["IsCharacterHit"].Value;
                set => CellsByName["IsCharacterHit"].Value = (byte)value;
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
                set => CellsByName["IsAttackBacklash"].Value = (byte)value;
            }
            

            // Def="u8 isDisableBreakForFirstAppear:1"
            /// <summary>
            /// Is Disable Destruction on First Apperance (u8)
            /// </summary>
            /// <remarks>
            /// Broken at the initial appearance of the player (0: ru, 1: no)
            /// </remarks>
            public byte IsDisableDestructionOnFirstApperance 
            {
                get => (byte)CellsByName["IsDisableDestructionOnFirstApperance"].Value;
                set => CellsByName["IsDisableDestructionOnFirstApperance"].Value = (byte)value;
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
                set => CellsByName["IsLadder"].Value = (byte)value;
            }
            

            // Def="u8 isAnimPauseOnRemoPlay:1"
            /// <summary>
            /// Is Animation Paused in Cutscene (u8)
            /// </summary>
            /// <remarks>
            /// Do you want to stop the animation during the poly play (0: not, 1: do)
            /// </remarks>
            public byte IsAnimationPausedInCutscene 
            {
                get => (byte)CellsByName["IsAnimationPausedInCutscene"].Value;
                set => CellsByName["IsAnimationPausedInCutscene"].Value = (byte)value;
            }
            

            // Def="u8 isDamageNoHit:1"
            /// <summary>
            /// Is Damage No Hit (u8)
            /// </summary>
            /// <remarks>
            /// No damage (0: hit, 1: not hit)
            /// </remarks>
            public byte IsDamageNoHit 
            {
                get => (byte)CellsByName["IsDamageNoHit"].Value;
                set => CellsByName["IsDamageNoHit"].Value = (byte)value;
            }
            

            // Def="u8 isMoveObj:1"
            /// <summary>
            /// Is Moving Object (u8)
            /// </summary>
            /// <remarks>
            /// Is it a moving object (0: different, 1: yes)
            /// </remarks>
            public byte IsMovingObject 
            {
                get => (byte)CellsByName["IsMovingObject"].Value;
                set => CellsByName["IsMovingObject"].Value = (byte)value;
            }
            

            // Def="u8 isRopeBridge:1"
            /// <summary>
            /// Is Rope Bridge (u8)
            /// </summary>
            /// <remarks>
            /// Suspension bridge object (0: different, 1: yes)
            /// </remarks>
            public byte IsRopeBridge 
            {
                get => (byte)CellsByName["IsRopeBridge"].Value;
                set => CellsByName["IsRopeBridge"].Value = (byte)value;
            }
            

            // Def="u8 isAddRigidImpulse_ByDamage:1"
            /// <summary>
            /// Is Rigid Body affected by Damage Blow (u8)
            /// </summary>
            /// <remarks>
            /// Does the damage blow the rigid body (0: do not blow, 1: blow)
            /// </remarks>
            public byte IsRigidBodyAffectedByDamageBlow 
            {
                get => (byte)CellsByName["IsRigidBodyAffectedByDamageBlow"].Value;
                set => CellsByName["IsRigidBodyAffectedByDamageBlow"].Value = (byte)value;
            }
            

            // Def="u8 isBreak_ByChrRide:1"
            /// <summary>
            /// Is Destroyed by Riding Character (u8)
            /// </summary>
            /// <remarks>
            /// Will it break if the character gets on (0: it won't break 1: it will break)
            /// </remarks>
            public byte IsDestroyedByRidingCharacter 
            {
                get => (byte)CellsByName["IsDestroyedByRidingCharacter"].Value;
                set => CellsByName["IsDestroyedByRidingCharacter"].Value = (byte)value;
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
                set => CellsByName["IsFlammable"].Value = (byte)value;
            }
            

            // Def="u8 isBreakByEnemyCollide:1"
            /// <summary>
            /// Is Destroyed by Enemy Collision (u8)
            /// </summary>
            /// <remarks>
            /// Broken when an enemy character touches (0: No, 1: Ru)
            /// </remarks>
            public byte IsDestroyedByEnemyCollision 
            {
                get => (byte)CellsByName["IsDestroyedByEnemyCollision"].Value;
                set => CellsByName["IsDestroyedByEnemyCollision"].Value = (byte)value;
            }
            

            // Def="s8 defaultLodParamId = -1"
            /// <summary>
            /// Default LOD Param ID (s8)
            /// </summary>
            /// <remarks>
            /// Default LOD Param ID (-1: None)
            /// </remarks>
            public sbyte DefaultLODParamID 
            {
                get => (sbyte)CellsByName["DefaultLODParamID"].Value;
                set => CellsByName["DefaultLODParamID"].Value = (sbyte)value;
            }
            

            // Def="s32 breakSfxId = -1"
            /// <summary>
            /// Destruction - SFX ID (s32)
            /// </summary>
            /// <remarks>
            /// SFXID when destroying an object (-1: default (810030))
            /// </remarks>
            public int DestructionSFXID 
            {
                get => (int)CellsByName["DestructionSFXID"].Value;
                set => CellsByName["DestructionSFXID"].Value = (int)value;
            }
            

            // Def="s32 breakSfxCpId = -1"
            /// <summary>
            /// Destruction - Dummy Poly ID (s32)
            /// </summary>
            /// <remarks>
            /// SFX generation position when the object is destroyed Damipoly ID (-1: placement position)
            /// </remarks>
            public int DestructionDummyPolyID 
            {
                get => (int)CellsByName["DestructionDummyPolyID"].Value;
                set => CellsByName["DestructionDummyPolyID"].Value = (int)value;
            }
            

            // Def="s32 breakBulletBehaviorId = -1"
            /// <summary>
            /// Destruction - Bullet Behavior ID (s32)
            /// </summary>
            /// <remarks>
            /// Action parameter of [bullet] at the time of destruction (-1: does not occur)
            /// </remarks>
            public int DestructionBulletBehaviorID 
            {
                get => (int)CellsByName["DestructionBulletBehaviorID"].Value;
                set => CellsByName["DestructionBulletBehaviorID"].Value = (int)value;
            }
            

            // Def="s32 breakBulletCpId = -1"
            /// <summary>
            /// Destruction - Bullet Dummy Poly ID (s32)
            /// </summary>
            /// <remarks>
            /// Location of [bullet] at the time of destruction Damipoli ID (-1: placement position)
            /// </remarks>
            public int DestructionBulletDummyPolyID 
            {
                get => (int)CellsByName["DestructionBulletDummyPolyID"].Value;
                set => CellsByName["DestructionBulletDummyPolyID"].Value = (int)value;
            }
            

            // Def="u8 breakFallHeight"
            /// <summary>
            /// Fall Destruction Height (u8)
            /// </summary>
            /// <remarks>
            /// Height at which the object breaks when dropped (0: does not break when dropped)
            /// </remarks>
            public byte FallDestructionHeight 
            {
                get => (byte)CellsByName["FallDestructionHeight"].Value;
                set => CellsByName["FallDestructionHeight"].Value = (byte)value;
            }
            

            // Def="u8 windEffectType_0"
            /// <summary>
            /// Wind Effect Type - Pre-Destruction (u8)
            /// </summary>
            /// <remarks>
            /// Wind effect type (before destruction)
            /// </remarks>
            public byte WindEffectTypePreDestruction 
            {
                get => (byte)CellsByName["WindEffectTypePreDestruction"].Value;
                set => CellsByName["WindEffectTypePreDestruction"].Value = (byte)value;
            }
            

            // Def="u8 windEffectType_1"
            /// <summary>
            /// Wind Effect Type - Post-Destruction (u8)
            /// </summary>
            /// <remarks>
            /// Wind effect type (after destruction)
            /// </remarks>
            public byte WindEffectTypePostDestruction 
            {
                get => (byte)CellsByName["WindEffectTypePostDestruction"].Value;
                set => CellsByName["WindEffectTypePostDestruction"].Value = (byte)value;
            }
            

            // Def="u8 camAvoidType = 1"
            /// <summary>
            /// Camera Avoidance Type (u8)
            /// </summary>
            /// <remarks>
            /// What to do if an object blocks between the camera and player
            /// </remarks>
            public byte CameraAvoidanceType 
            {
                get => (byte)CellsByName["CameraAvoidanceType"].Value;
                set => CellsByName["CameraAvoidanceType"].Value = (byte)value;
            }
            

            // Def="f32 windEffectRate_0 = 0.5"
            /// <summary>
            /// Wind Coefficient - Pre-Destruction (f32)
            /// </summary>
            /// <remarks>
            /// Wind coefficient (before destruction)
            /// </remarks>
            public float WindCoefficientPreDestruction 
            {
                get => (float)CellsByName["WindCoefficientPreDestruction"].Value;
                set => CellsByName["WindCoefficientPreDestruction"].Value = (float)value;
            }
            

            // Def="f32 windEffectRate_1 = 0.5"
            /// <summary>
            /// Wind Coefficient - Post-Destruction (f32)
            /// </summary>
            /// <remarks>
            /// Wind coefficient (after destruction)
            /// </remarks>
            public float WindCoefficientPostDestruction 
            {
                get => (float)CellsByName["WindCoefficientPostDestruction"].Value;
                set => CellsByName["WindCoefficientPostDestruction"].Value = (float)value;
            }
            

            // Def="f32 breakStopTime"
            /// <summary>
            /// Destruction Stop time (f32)
            /// </summary>
            /// <remarks>
            /// Time from destruction to forced stop of rigid body (do not force stop at 0)
            /// </remarks>
            public float DestructionStopTime 
            {
                get => (float)CellsByName["DestructionStopTime"].Value;
                set => CellsByName["DestructionStopTime"].Value = (float)value;
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
                set => CellsByName["BurnTime"].Value = (float)value;
            }
            

            // Def="f32 burnBraekRate = 0.5"
            /// <summary>
            /// Burn Destruction Rate (f32)
            /// </summary>
            /// <remarks>
            /// Burnup threshold for switching to the ruptured state
            /// </remarks>
            public float BurnDestructionRate 
            {
                get => (float)CellsByName["BurnDestructionRate"].Value;
                set => CellsByName["BurnDestructionRate"].Value = (float)value;
            }
            

            // Def="s32 burnSfxId = -1"
            /// <summary>
            /// Burn - SFX ID [0] (s32)
            /// </summary>
            /// <remarks>
            /// SFX ID at the time of combustion: 0 (-1: No SFX)
            /// </remarks>
            public int BurnSFXID0 
            {
                get => (int)CellsByName["BurnSFXID0"].Value;
                set => CellsByName["BurnSFXID0"].Value = (int)value;
            }
            

            // Def="s32 burnSfxId_1 = -1"
            /// <summary>
            /// Burn - SFX ID [1] (s32)
            /// </summary>
            /// <remarks>
            /// SFX ID at the time of combustion: 1 (-1: No SFX)
            /// </remarks>
            public int BurnSFXID1 
            {
                get => (int)CellsByName["BurnSFXID1"].Value;
                set => CellsByName["BurnSFXID1"].Value = (int)value;
            }
            

            // Def="s32 burnSfxId_2 = -1"
            /// <summary>
            /// Burn - SFX ID [2] (s32)
            /// </summary>
            /// <remarks>
            /// SFX ID at the time of combustion: 2 (-1: No SFX)
            /// </remarks>
            public int BurnSFXID2 
            {
                get => (int)CellsByName["BurnSFXID2"].Value;
                set => CellsByName["BurnSFXID2"].Value = (int)value;
            }
            

            // Def="s32 burnSfxId_3 = -1"
            /// <summary>
            /// Burn - SFX ID [3] (s32)
            /// </summary>
            /// <remarks>
            /// SFX ID at the time of combustion: 3 (-1: No SFX)
            /// </remarks>
            public int BurnSFXID3 
            {
                get => (int)CellsByName["BurnSFXID3"].Value;
                set => CellsByName["BurnSFXID3"].Value = (int)value;
            }
            

            // Def="s32 burnBulletBehaviorId = -1"
            /// <summary>
            /// Burn - Bullet Behavior ID [0] (s32)
            /// </summary>
            /// <remarks>
            /// Bullet generation behavior parameter at the time of burning: 0 (-1: does not occur)
            /// </remarks>
            public int BurnBulletBehaviorID0 
            {
                get => (int)CellsByName["BurnBulletBehaviorID0"].Value;
                set => CellsByName["BurnBulletBehaviorID0"].Value = (int)value;
            }
            

            // Def="s32 burnBulletBehaviorId_1 = -1"
            /// <summary>
            /// Burn - Bullet Behavior ID [1] (s32)
            /// </summary>
            /// <remarks>
            /// Bullet generation behavior parameter at the time of burning: 1 (-1: does not occur)
            /// </remarks>
            public int BurnBulletBehaviorID1 
            {
                get => (int)CellsByName["BurnBulletBehaviorID1"].Value;
                set => CellsByName["BurnBulletBehaviorID1"].Value = (int)value;
            }
            

            // Def="s32 burnBulletBehaviorId_2 = -1"
            /// <summary>
            /// Burn - Bullet Behavior ID [2] (s32)
            /// </summary>
            /// <remarks>
            /// Bullet generation behavior parameter at the time of burning: 2 (-1: does not occur)
            /// </remarks>
            public int BurnBulletBehaviorID2 
            {
                get => (int)CellsByName["BurnBulletBehaviorID2"].Value;
                set => CellsByName["BurnBulletBehaviorID2"].Value = (int)value;
            }
            

            // Def="s32 burnBulletBehaviorId_3 = -1"
            /// <summary>
            /// Burn - Bullet Behavior ID [3] (s32)
            /// </summary>
            /// <remarks>
            /// Bullet generation behavior parameter at the time of burning: 3 (-1: does not occur)
            /// </remarks>
            public int BurnBulletBehaviorID3 
            {
                get => (int)CellsByName["BurnBulletBehaviorID3"].Value;
                set => CellsByName["BurnBulletBehaviorID3"].Value = (int)value;
            }
            

            // Def="u16 burnBulletInterval = 30"
            /// <summary>
            /// Burn - Bullet Interval (u16)
            /// </summary>
            /// <remarks>
            /// Interval (frame) to generate bullets for spreading fire
            /// </remarks>
            public ushort BurnBulletInterval 
            {
                get => (ushort)CellsByName["BurnBulletInterval"].Value;
                set => CellsByName["BurnBulletInterval"].Value = (ushort)value;
            }
            

            // Def="u8 navimeshFlag"
            /// <summary>
            /// Navimesh Flag (u8)
            /// </summary>
            /// <remarks>
            /// Navigation mesh flag set from the object
            /// </remarks>
            public byte NavimeshFlag 
            {
                get => (byte)CellsByName["NavimeshFlag"].Value;
                set => CellsByName["NavimeshFlag"].Value = (byte)value;
            }
            

            // Def="u8 collisionType"
            /// <summary>
            /// Collision Detection Type (u8)
            /// </summary>
            /// <remarks>
            /// Collision detection type
            /// </remarks>
            public byte CollisionDetectionType 
            {
                get => (byte)CellsByName["CollisionDetectionType"].Value;
                set => CellsByName["CollisionDetectionType"].Value = (byte)value;
            }
            

            // Def="f32 burnBulletDelayTime"
            /// <summary>
            /// Burn - Bullet Generation Delay Time (f32)
            /// </summary>
            /// <remarks>
            /// Time to delay the generation of bullets for fire spread (seconds)
            /// </remarks>
            public float BurnBulletGenerationDelayTime 
            {
                get => (float)CellsByName["BurnBulletGenerationDelayTime"].Value;
                set => CellsByName["BurnBulletGenerationDelayTime"].Value = (float)value;
            }
            

            // Def="f32 burnSfxDelayTimeMin"
            /// <summary>
            /// Burn - Bullet Generation Delay Time [0] (Minimum) (f32)
            /// </summary>
            /// <remarks>
            /// SFX generation delay time during combustion Randomly determined between start and end times
            /// </remarks>
            public float BurnBulletGenerationDelayTime0Minimum 
            {
                get => (float)CellsByName["BurnBulletGenerationDelayTime0Minimum"].Value;
                set => CellsByName["BurnBulletGenerationDelayTime0Minimum"].Value = (float)value;
            }
            

            // Def="f32 burnSfxDelayTimeMin_1"
            /// <summary>
            /// Burn - Bullet Generation Delay Time [1] (Minimum) (f32)
            /// </summary>
            /// <remarks>
            /// SFX generation delay time during combustion Randomly determined between start and end times
            /// </remarks>
            public float BurnBulletGenerationDelayTime1Minimum 
            {
                get => (float)CellsByName["BurnBulletGenerationDelayTime1Minimum"].Value;
                set => CellsByName["BurnBulletGenerationDelayTime1Minimum"].Value = (float)value;
            }
            

            // Def="f32 burnSfxDelayTimeMin_2"
            /// <summary>
            /// Burn - Bullet Generation Delay Time [2] (Minimum) (f32)
            /// </summary>
            /// <remarks>
            /// SFX generation delay time during combustion Randomly determined between start and end times
            /// </remarks>
            public float BurnBulletGenerationDelayTime2Minimum 
            {
                get => (float)CellsByName["BurnBulletGenerationDelayTime2Minimum"].Value;
                set => CellsByName["BurnBulletGenerationDelayTime2Minimum"].Value = (float)value;
            }
            

            // Def="f32 burnSfxDelayTimeMin_3"
            /// <summary>
            /// Burn - Bullet Generation Delay Time [3] (Minimum) (f32)
            /// </summary>
            /// <remarks>
            /// SFX generation delay time during combustion Randomly determined between start and end times
            /// </remarks>
            public float BurnBulletGenerationDelayTime3Minimum 
            {
                get => (float)CellsByName["BurnBulletGenerationDelayTime3Minimum"].Value;
                set => CellsByName["BurnBulletGenerationDelayTime3Minimum"].Value = (float)value;
            }
            

            // Def="f32 burnSfxDelayTimeMax"
            /// <summary>
            /// Burn - Bullet Generation Delay Time [0] (Maximum) (f32)
            /// </summary>
            /// <remarks>
            /// SFX generation delay time during combustion Randomly determined between start and end times
            /// </remarks>
            public float BurnBulletGenerationDelayTime0Maximum 
            {
                get => (float)CellsByName["BurnBulletGenerationDelayTime0Maximum"].Value;
                set => CellsByName["BurnBulletGenerationDelayTime0Maximum"].Value = (float)value;
            }
            

            // Def="f32 burnSfxDelayTimeMax_1"
            /// <summary>
            /// Burn - Bullet Generation Delay Time [1] (Maximum) (f32)
            /// </summary>
            /// <remarks>
            /// SFX generation delay time during combustion Randomly determined between start and end times
            /// </remarks>
            public float BurnBulletGenerationDelayTime1Maximum 
            {
                get => (float)CellsByName["BurnBulletGenerationDelayTime1Maximum"].Value;
                set => CellsByName["BurnBulletGenerationDelayTime1Maximum"].Value = (float)value;
            }
            

            // Def="f32 burnSfxDelayTimeMax_2"
            /// <summary>
            /// Burn - Bullet Generation Delay Time [2] (Maximum) (f32)
            /// </summary>
            /// <remarks>
            /// SFX generation delay time during combustion Randomly determined between start and end times
            /// </remarks>
            public float BurnBulletGenerationDelayTime2Maximum 
            {
                get => (float)CellsByName["BurnBulletGenerationDelayTime2Maximum"].Value;
                set => CellsByName["BurnBulletGenerationDelayTime2Maximum"].Value = (float)value;
            }
            

            // Def="f32 burnSfxDelayTimeMax_3"
            /// <summary>
            /// Burn - Bullet Generation Delay Time [3] (Maximum) (f32)
            /// </summary>
            /// <remarks>
            /// SFX generation delay time during combustion Randomly determined between start and end times
            /// </remarks>
            public float BurnBulletGenerationDelayTime3Maximum 
            {
                get => (float)CellsByName["BurnBulletGenerationDelayTime3Maximum"].Value;
                set => CellsByName["BurnBulletGenerationDelayTime3Maximum"].Value = (float)value;
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
                set => CellsByName["DestructionAISoundID"].Value = (int)value;
            }
            

            // Def="f32 FragmentInvisibleWaitTime"
            /// <summary>
            /// Hidden Debris - Wait Time (f32)
            /// </summary>
            /// <remarks>
            /// Material ID of debris (-1: Do not hide)
            /// </remarks>
            public float HiddenDebrisWaitTime 
            {
                get => (float)CellsByName["HiddenDebrisWaitTime"].Value;
                set => CellsByName["HiddenDebrisWaitTime"].Value = (float)value;
            }
            

            // Def="f32 FragmentInvisibleTime"
            /// <summary>
            /// Hidden Debris - Invisibility Time (f32)
            /// </summary>
            /// <remarks>
            /// Time to hide debris (seconds)
            /// </remarks>
            public float HiddenDebrisInvisibilityTime 
            {
                get => (float)CellsByName["HiddenDebrisInvisibilityTime"].Value;
                set => CellsByName["HiddenDebrisInvisibilityTime"].Value = (float)value;
            }
            

            // Def="dummy8 pad_3[16] = -1"
            /// <summary>
            /// Padding (dummy8)
            /// </summary>
            /// <remarks>
            /// Material ID of debris (-1: Do not hide)
            /// </remarks>
            public object Padding 
            {
                get => (object)CellsByName["Padding"].Value;
                set => CellsByName["Padding"].Value = (object)value;
            }
            

            // Def="f32 RigidPenetrationScale_Soft"
            /// <summary>
            /// Rigid Body Collision - Soft (f32)
            /// </summary>
            /// <remarks>
            /// Rigid body soft contact setting Collision point distance coefficient [soft]
            /// </remarks>
            public float RigidBodyCollisionSoft 
            {
                get => (float)CellsByName["RigidBodyCollisionSoft"].Value;
                set => CellsByName["RigidBodyCollisionSoft"].Value = (float)value;
            }
            

            // Def="f32 RigidPenetrationScale_Normal"
            /// <summary>
            /// Rigid Body Collision - Normal (f32)
            /// </summary>
            /// <remarks>
            /// Rigid soft contact setting Collision point distance coefficient [Normal]
            /// </remarks>
            public float RigidBodyCollisionNormal 
            {
                get => (float)CellsByName["RigidBodyCollisionNormal"].Value;
                set => CellsByName["RigidBodyCollisionNormal"].Value = (float)value;
            }
            

            // Def="f32 RigidPenetrationScale_Hard"
            /// <summary>
            /// Rigid Body Collision - Hard (f32)
            /// </summary>
            /// <remarks>
            /// Rigid soft contact setting Collision point distance coefficient [hard]
            /// </remarks>
            public float RigidBodyCollisionHard 
            {
                get => (float)CellsByName["RigidBodyCollisionHard"].Value;
                set => CellsByName["RigidBodyCollisionHard"].Value = (float)value;
            }
            

            // Def="s32 LandTouchSfxId = -1"
            /// <summary>
            /// Land Touch - SFX ID (s32)
            /// </summary>
            /// <remarks>
            /// SFX ID at terrain contact (-1: offset by terrain material)
            /// </remarks>
            public int LandTouchSFXID 
            {
                get => (int)CellsByName["LandTouchSFXID"].Value;
                set => CellsByName["LandTouchSFXID"].Value = (int)value;
            }
            

            // Def="u8 isDamageCover:1"
            /// <summary>
            /// Is Damage blocked after Passing Through (u8)
            /// </summary>
            /// <remarks>
            /// Whether to pass the damage to the other side when receiving damage (0: pass, 1: do not pass)
            /// </remarks>
            public byte IsDamageBlockedAfterPassingThrough 
            {
                get => (byte)CellsByName["IsDamageBlockedAfterPassingThrough"].Value;
                set => CellsByName["IsDamageBlockedAfterPassingThrough"].Value = (byte)value;
            }
            


            // Def="u16 paintDecalTargetTextureSize = 256"
            /// <summary>
            /// Paint Decal Size (u16)
            /// </summary>
            /// <remarks>
            /// Paint decal target size (only powers of 0 to 4096 2 allowed)
            /// </remarks>
            public ushort PaintDecalSize 
            {
                get => (ushort)CellsByName["PaintDecalSize"].Value;
                set => CellsByName["PaintDecalSize"].Value = (ushort)value;
            }
            

            // Def="f32 lifeTime_forDC"
            /// <summary>
            /// Dynamic Object Duration (f32)
            /// </summary>
            /// <remarks>
            /// Time until dynamically generated Obj disappears after generation (0: does not disappear)
            /// </remarks>
            public float DynamicObjectDuration 
            {
                get => (float)CellsByName["DynamicObjectDuration"].Value;
                set => CellsByName["DynamicObjectDuration"].Value = (float)value;
            }
            

            // Def="f32 clothUpdateDist"
            /// <summary>
            /// Cloth Update Distance from Camera (f32)
            /// </summary>
            /// <remarks>
            /// Distance from the camera to update havokCloth (0: always update)
            /// </remarks>
            public float ClothUpdateDistanceFromCamera 
            {
                get => (float)CellsByName["ClothUpdateDistanceFromCamera"].Value;
                set => CellsByName["ClothUpdateDistanceFromCamera"].Value = (float)value;
            }
            

            // Def="s32 contactSeId = -1"
            /// <summary>
            /// Player Touch - SE ID (s32)
            /// </summary>
            /// <remarks>
            /// SE ID to play when touched by a local player operated by you (-1: Do not play)
            /// </remarks>
            public int PlayerTouchSEID 
            {
                get => (int)CellsByName["PlayerTouchSEID"].Value;
                set => CellsByName["PlayerTouchSEID"].Value = (int)value;
            }
            

            // Def="s32 breakLandingSfxId = -1"
            /// <summary>
            /// Landing Destruction - SFX ID (s32)
            /// </summary>
            /// <remarks>
            /// Object material-dependent SFX identifier that regenerates when first landing after being destroyed (-1: does not occur)
            /// </remarks>
            public int LandingDestructionSFXID 
            {
                get => (int)CellsByName["LandingDestructionSFXID"].Value;
                set => CellsByName["LandingDestructionSFXID"].Value = (int)value;
            }
            

            // Def="s32 waypointDummyPolyId_0 = -1"
            /// <summary>
            /// Waypoint Dummy Poly ID (s32)
            /// </summary>
            /// <remarks>
            /// Waypoint Damipoli ID_0 (-1: None)
            /// </remarks>
            public int WaypointDummyPolyID 
            {
                get => (int)CellsByName["WaypointDummyPolyID"].Value;
                set => CellsByName["WaypointDummyPolyID"].Value = (int)value;
            }
            

            // Def="s32 waypointParamId_0 = -1"
            /// <summary>
            /// Waypoint Param ID (s32)
            /// </summary>
            /// <remarks>
            /// Waypoint parameter ID_0 (-1: none)
            /// </remarks>
            public int WaypointParamID 
            {
                get => (int)CellsByName["WaypointParamID"].Value;
                set => CellsByName["WaypointParamID"].Value = (int)value;
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
                set => CellsByName["SoundBankID"].Value = (int)value;
            }
            

            // Def="s32 refDrawParamId = -1"
            /// <summary>
            /// Reference Draw Param ID (s32)
            /// </summary>
            /// <remarks>
            /// Reference ID of drawing parameter
            /// </remarks>
            public int ReferenceDrawParamID 
            {
                get => (int)CellsByName["ReferenceDrawParamID"].Value;
                set => CellsByName["ReferenceDrawParamID"].Value = (int)value;
            }
            

            // Def="f32 autoCreateDynamicOffsetHeight = 0.1"
            /// <summary>
            /// Automatica Generation - Appearance Height Offset (f32)
            /// </summary>
            /// <remarks>
            /// Map automatic generation OBJ appearance height offset [m], does it float from where the ray cast hits?
            /// </remarks>
            public float AutomaticaGenerationAppearanceHeightOffset 
            {
                get => (float)CellsByName["AutomaticaGenerationAppearanceHeightOffset"].Value;
                set => CellsByName["AutomaticaGenerationAppearanceHeightOffset"].Value = (float)value;
            }
            

            // Def="s32 reserved0 = -1"
            /// <summary>
            /// Blank (s32)
            /// </summary>
            /// <remarks>
            /// Reserve
            /// </remarks>
            public int Blank 
            {
                get => (int)CellsByName["Blank"].Value;
                set => CellsByName["Blank"].Value = (int)value;
            }
            

            // Def="s32 soundBreakSEId = -1"
            /// <summary>
            /// Destruction - SE ID (s32)
            /// </summary>
            /// <remarks>
            /// Destruction sound SEID (9 digits) -1: Generated from objId
            /// </remarks>
            public int DestructionSEID 
            {
                get => (int)CellsByName["DestructionSEID"].Value;
                set => CellsByName["DestructionSEID"].Value = (int)value;
            }
            

                }
            }
            
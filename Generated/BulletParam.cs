
            namespace StronglyTypedParams
            {
                public class BulletParam : ParamRow
                {
                    public BulletParam() : base()
                    {
                    }
            

            // Def="s32 atkId_Bullet = -1"
            /// <summary>
            /// AtkParam ID (s32)
            /// </summary>
            /// <remarks>
            /// Register each attack parameter ID. → Attack type / Attack material / Physical attack power / Magic attack power / Stamina attack power / Knockback distance.
            /// </remarks>
            public int AtkParamID 
            {
                get => (int)CellsByName["AtkParamID"].Value;
                set => CellsByName["AtkParamID"].Value = value;
            }
            

            // Def="s32 sfxId_Bullet = -1"
            /// <summary>
            /// Projectile SFX ID (s32)
            /// </summary>
            /// <remarks>
            /// Enter the SFX ID for [Bullet]. -1 does not occur.
            /// </remarks>
            public int ProjectileSFXID 
            {
                get => (int)CellsByName["ProjectileSFXID"].Value;
                set => CellsByName["ProjectileSFXID"].Value = value;
            }
            

            // Def="s32 sfxId_Hit = -1"
            /// <summary>
            /// Impact SFX ID (s32)
            /// </summary>
            /// <remarks>
            /// [Impact] Enter the SFX ID. -1 does not occur.
            /// </remarks>
            public int ImpactSFXID 
            {
                get => (int)CellsByName["ImpactSFXID"].Value;
                set => CellsByName["ImpactSFXID"].Value = value;
            }
            

            // Def="s32 sfxId_Flick = -1"
            /// <summary>
            /// Repel SFX ID (s32)
            /// </summary>
            /// <remarks>
            /// [At the time of repelling] Enter the SFX ID. -1 does not occur.
            /// </remarks>
            public int RepelSFXID 
            {
                get => (int)CellsByName["RepelSFXID"].Value;
                set => CellsByName["RepelSFXID"].Value = value;
            }
            

            // Def="f32 life = -1"
            /// <summary>
            /// Duration (f32)
            /// </summary>
            /// <remarks>
            /// Time for missiles to continue to exist (-1 is infinite).
            /// </remarks>
            public float Duration 
            {
                get => (float)CellsByName["Duration"].Value;
                set => CellsByName["Duration"].Value = value;
            }
            

            // Def="f32 dist"
            /// <summary>
            /// Attenuation Range (f32)
            /// </summary>
            /// <remarks>
            /// Distance at which attenuation begins (not actual flight distance).
            /// </remarks>
            public float AttenuationRange 
            {
                get => (float)CellsByName["AttenuationRange"].Value;
                set => CellsByName["AttenuationRange"].Value = value;
            }
            

            // Def="f32 shootInterval"
            /// <summary>
            /// Shoot Interval (f32)
            /// </summary>
            /// <remarks>
            /// Specify how many seconds the missile will be fired.
            /// </remarks>
            public float ShootInterval 
            {
                get => (float)CellsByName["ShootInterval"].Value;
                set => CellsByName["ShootInterval"].Value = value;
            }
            

            // Def="f32 gravityInRange"
            /// <summary>
            /// Gravity: In Range (f32)
            /// </summary>
            /// <remarks>
            /// Downward gravity within range.
            /// </remarks>
            public float GravityInRange 
            {
                get => (float)CellsByName["GravityInRange"].Value;
                set => CellsByName["GravityInRange"].Value = value;
            }
            

            // Def="f32 gravityOutRange"
            /// <summary>
            /// Gravity: Out of Range (f32)
            /// </summary>
            /// <remarks>
            /// Gravity applied downward when damping begins (expresses the feeling of falling down.
            /// </remarks>
            public float GravityOutOfRange 
            {
                get => (float)CellsByName["GravityOutOfRange"].Value;
                set => CellsByName["GravityOutOfRange"].Value = value;
            }
            

            // Def="f32 hormingStopRange"
            /// <summary>
            /// Homing Stop Range (f32)
            /// </summary>
            /// <remarks>
            /// The distance to the target to stop the guidance. A parameter that prevents you from hitting too much with a guided bullet.
            /// </remarks>
            public float HomingStopRange 
            {
                get => (float)CellsByName["HomingStopRange"].Value;
                set => CellsByName["HomingStopRange"].Value = value;
            }
            

            // Def="f32 initVellocity"
            /// <summary>
            /// Initial Velocity (f32)
            /// </summary>
            /// <remarks>
            /// Initial speed of SFX.
            /// </remarks>
            public float InitialVelocity 
            {
                get => (float)CellsByName["InitialVelocity"].Value;
                set => CellsByName["InitialVelocity"].Value = value;
            }
            

            // Def="f32 accelInRange"
            /// <summary>
            /// Acceleration: In Range (f32)
            /// </summary>
            /// <remarks>
            /// Acceleration within SFX range.
            /// </remarks>
            public float AccelerationInRange 
            {
                get => (float)CellsByName["AccelerationInRange"].Value;
                set => CellsByName["AccelerationInRange"].Value = value;
            }
            

            // Def="f32 accelOutRange"
            /// <summary>
            /// Acceleration: Out of Range (f32)
            /// </summary>
            /// <remarks>
            /// Acceleration when SFX goes out of range.
            /// </remarks>
            public float AccelerationOutOfRange 
            {
                get => (float)CellsByName["AccelerationOutOfRange"].Value;
                set => CellsByName["AccelerationOutOfRange"].Value = value;
            }
            

            // Def="f32 maxVellocity"
            /// <summary>
            /// Max Velocity (f32)
            /// </summary>
            /// <remarks>
            /// maximum speed.
            /// </remarks>
            public float MaxVelocity 
            {
                get => (float)CellsByName["MaxVelocity"].Value;
                set => CellsByName["MaxVelocity"].Value = value;
            }
            

            // Def="f32 minVellocity"
            /// <summary>
            /// Min Velocity (f32)
            /// </summary>
            /// <remarks>
            /// Minimum guaranteed speed.
            /// </remarks>
            public float MinVelocity 
            {
                get => (float)CellsByName["MinVelocity"].Value;
                set => CellsByName["MinVelocity"].Value = value;
            }
            

            // Def="f32 accelTime"
            /// <summary>
            /// Acceleration Duration (f32)
            /// </summary>
            /// <remarks>
            /// Until this time, do not accelerate (make sure you can shoot magic like rockets).
            /// </remarks>
            public float AccelerationDuration 
            {
                get => (float)CellsByName["AccelerationDuration"].Value;
                set => CellsByName["AccelerationDuration"].Value = value;
            }
            

            // Def="f32 homingBeginDist"
            /// <summary>
            /// Homing Start Distance (f32)
            /// </summary>
            /// <remarks>
            /// How many meters should the guidance start?
            /// </remarks>
            public float HomingStartDistance 
            {
                get => (float)CellsByName["HomingStartDistance"].Value;
                set => CellsByName["HomingStartDistance"].Value = value;
            }
            

            // Def="f32 hitRadius = -1"
            /// <summary>
            /// Initial Hit Radius (f32)
            /// </summary>
            /// <remarks>
            /// Set the radius of the hit ball.
            /// </remarks>
            public float InitialHitRadius 
            {
                get => (float)CellsByName["InitialHitRadius"].Value;
                set => CellsByName["InitialHitRadius"].Value = value;
            }
            

            // Def="f32 hitRadiusMax = -1"
            /// <summary>
            /// Final Hit Radius (f32)
            /// </summary>
            /// <remarks>
            /// Maximum radius of the hit sphere (If -1, make it the same as the initial radius / default)
            /// </remarks>
            public float FinalHitRadius 
            {
                get => (float)CellsByName["FinalHitRadius"].Value;
                set => CellsByName["FinalHitRadius"].Value = value;
            }
            

            // Def="f32 spreadTime"
            /// <summary>
            /// Radius Spread Time (f32)
            /// </summary>
            /// <remarks>
            /// The time when the radius of the range expands to a small extent.
            /// </remarks>
            public float RadiusSpreadTime 
            {
                get => (float)CellsByName["RadiusSpreadTime"].Value;
                set => CellsByName["RadiusSpreadTime"].Value = value;
            }
            

            // Def="f32 expDelay"
            /// <summary>
            /// Explosion Delay (f32)
            /// </summary>
            /// <remarks>
            /// Time from landing to explosion (if 0, it explodes immediately).
            /// </remarks>
            public float ExplosionDelay 
            {
                get => (float)CellsByName["ExplosionDelay"].Value;
                set => CellsByName["ExplosionDelay"].Value = value;
            }
            

            // Def="f32 hormingOffsetRange"
            /// <summary>
            /// Homing Offset Range (f32)
            /// </summary>
            /// <remarks>
            /// It is accurate if it is 0. At the time of shooting, each component of XYZ should be aimed by shifting this amount.
            /// </remarks>
            public float HomingOffsetRange 
            {
                get => (float)CellsByName["HomingOffsetRange"].Value;
                set => CellsByName["HomingOffsetRange"].Value = value;
            }
            

            // Def="f32 dmgHitRecordLifeTime"
            /// <summary>
            /// Damage Hit Duration (f32)
            /// </summary>
            /// <remarks>
            /// Damage hit history survival time [sec] (<= 0.0f: indefinite)
            /// </remarks>
            public float DamageHitDuration 
            {
                get => (float)CellsByName["DamageHitDuration"].Value;
                set => CellsByName["DamageHitDuration"].Value = value;
            }
            

            // Def="f32 externalForce"
            /// <summary>
            /// External Force in Bullet Direction (f32)
            /// </summary>
            /// <remarks>
            /// External force applied in the direction of shooting. (Y-axis is removed)
            /// </remarks>
            public float ExternalForceInBulletDirection 
            {
                get => (float)CellsByName["ExternalForceInBulletDirection"].Value;
                set => CellsByName["ExternalForceInBulletDirection"].Value = value;
            }
            

            // Def="s32 spEffectIDForShooter = -1"
            /// <summary>
            /// Shooter SpEffect ID (s32)
            /// </summary>
            /// <remarks>
            /// Special effects on the person who shot
            /// </remarks>
            public int ShooterSpEffectID 
            {
                get => (int)CellsByName["ShooterSpEffectID"].Value;
                set => CellsByName["ShooterSpEffectID"].Value = value;
            }
            

            // Def="s32 autoSearchNPCThinkID"
            /// <summary>
            /// Bullet AI (s32)
            /// </summary>
            /// <remarks>
            /// Parameters used by the funnel to search for the target
            /// </remarks>
            public int BulletAI 
            {
                get => (int)CellsByName["BulletAI"].Value;
                set => CellsByName["BulletAI"].Value = value;
            }
            

            // Def="s32 HitBulletID = -1"
            /// <summary>
            /// Hit Bullet ID (s32)
            /// </summary>
            /// <remarks>
            /// Specify the ID when generating a new bullet parameter from the bullet parameter
            /// </remarks>
            public int HitBulletID 
            {
                get => (int)CellsByName["HitBulletID"].Value;
                set => CellsByName["HitBulletID"].Value = value;
            }
            

            // Def="s32 spEffectId0 = -1"
            /// <summary>
            /// Target SpEffect ID [0] (s32)
            /// </summary>
            /// <remarks>
            /// Register each special effect parameter ID. → General special effects.
            /// </remarks>
            public int TargetSpEffectID0 
            {
                get => (int)CellsByName["TargetSpEffectID0"].Value;
                set => CellsByName["TargetSpEffectID0"].Value = value;
            }
            

            // Def="s32 spEffectId1 = -1"
            /// <summary>
            /// Target SpEffect ID [1] (s32)
            /// </summary>
            /// <remarks>
            /// Register each special effect parameter ID. → General special effects.
            /// </remarks>
            public int TargetSpEffectID1 
            {
                get => (int)CellsByName["TargetSpEffectID1"].Value;
                set => CellsByName["TargetSpEffectID1"].Value = value;
            }
            

            // Def="s32 spEffectId2 = -1"
            /// <summary>
            /// Target SpEffect ID [2] (s32)
            /// </summary>
            /// <remarks>
            /// Register each special effect parameter ID. → General special effects.
            /// </remarks>
            public int TargetSpEffectID2 
            {
                get => (int)CellsByName["TargetSpEffectID2"].Value;
                set => CellsByName["TargetSpEffectID2"].Value = value;
            }
            

            // Def="s32 spEffectId3 = -1"
            /// <summary>
            /// Target SpEffect ID [3] (s32)
            /// </summary>
            /// <remarks>
            /// Register each special effect parameter ID. → General special effects.
            /// </remarks>
            public int TargetSpEffectID3 
            {
                get => (int)CellsByName["TargetSpEffectID3"].Value;
                set => CellsByName["TargetSpEffectID3"].Value = value;
            }
            

            // Def="s32 spEffectId4 = -1"
            /// <summary>
            /// Target SpEffect ID [4] (s32)
            /// </summary>
            /// <remarks>
            /// Register each special effect parameter ID. → General special effects.
            /// </remarks>
            public int TargetSpEffectID4 
            {
                get => (int)CellsByName["TargetSpEffectID4"].Value;
                set => CellsByName["TargetSpEffectID4"].Value = value;
            }
            

            // Def="u16 numShoot"
            /// <summary>
            /// Bullet Count (u16)
            /// </summary>
            /// <remarks>
            /// The number of missiles fired at one time.
            /// </remarks>
            public ushort BulletCount 
            {
                get => (ushort)CellsByName["BulletCount"].Value;
                set => CellsByName["BulletCount"].Value = value;
            }
            

            // Def="s16 homingAngle"
            /// <summary>
            /// Homing Angle (s16)
            /// </summary>
            /// <remarks>
            /// How many corrections per second? ..
            /// </remarks>
            public short HomingAngle 
            {
                get => (short)CellsByName["HomingAngle"].Value;
                set => CellsByName["HomingAngle"].Value = value;
            }
            

            // Def="s16 shootAngle"
            /// <summary>
            /// Launch Angle (s16)
            /// </summary>
            /// <remarks>
            /// Specify how many times the missile is fired forward.
            /// </remarks>
            public short LaunchAngle 
            {
                get => (short)CellsByName["LaunchAngle"].Value;
                set => CellsByName["LaunchAngle"].Value = value;
            }
            

            // Def="s16 shootAngleInterval"
            /// <summary>
            /// Launch Angle Interval (s16)
            /// </summary>
            /// <remarks>
            /// When firing multiple missiles, specify how often to fire them. (Y-axis)
            /// </remarks>
            public short LaunchAngleInterval 
            {
                get => (short)CellsByName["LaunchAngleInterval"].Value;
                set => CellsByName["LaunchAngleInterval"].Value = value;
            }
            

            // Def="s16 shootAngleXInterval"
            /// <summary>
            /// Launch Elevation Interval (s16)
            /// </summary>
            /// <remarks>
            /// When firing multiple missiles, specify how often to fire them. (X-axis)
            /// </remarks>
            public short LaunchElevationInterval 
            {
                get => (short)CellsByName["LaunchElevationInterval"].Value;
                set => CellsByName["LaunchElevationInterval"].Value = value;
            }
            

            // Def="s8 damageDamp"
            /// <summary>
            /// Damage Falloff %: Physical (s8)
            /// </summary>
            /// <remarks>
            /// Correction value that decreases in 1 second after the attenuation distance.
            /// </remarks>
            public sbyte DamageFalloffPercentPhysical 
            {
                get => (sbyte)CellsByName["DamageFalloffPercentPhysical"].Value;
                set => CellsByName["DamageFalloffPercentPhysical"].Value = value;
            }
            

            // Def="s8 spelDamageDamp"
            /// <summary>
            /// Damage Falloff %: Magic (s8)
            /// </summary>
            /// <remarks>
            /// Correction value that decreases in 1 second after the attenuation distance.
            /// </remarks>
            public sbyte DamageFalloffPercentMagic 
            {
                get => (sbyte)CellsByName["DamageFalloffPercentMagic"].Value;
                set => CellsByName["DamageFalloffPercentMagic"].Value = value;
            }
            

            // Def="s8 fireDamageDamp"
            /// <summary>
            /// Damage Falloff %: Fire (s8)
            /// </summary>
            /// <remarks>
            /// Correction value that decreases in 1 second after the attenuation distance.
            /// </remarks>
            public sbyte DamageFalloffPercentFire 
            {
                get => (sbyte)CellsByName["DamageFalloffPercentFire"].Value;
                set => CellsByName["DamageFalloffPercentFire"].Value = value;
            }
            

            // Def="s8 thunderDamageDamp"
            /// <summary>
            /// Damage Falloff %: Lightning (s8)
            /// </summary>
            /// <remarks>
            /// Correction value that decreases in 1 second after the attenuation distance.
            /// </remarks>
            public sbyte DamageFalloffPercentLightning 
            {
                get => (sbyte)CellsByName["DamageFalloffPercentLightning"].Value;
                set => CellsByName["DamageFalloffPercentLightning"].Value = value;
            }
            

            // Def="s8 staminaDamp"
            /// <summary>
            /// Damage Falloff %: Stamina (s8)
            /// </summary>
            /// <remarks>
            /// Correction value that decreases in 1 second after the attenuation distance.
            /// </remarks>
            public sbyte DamageFalloffPercentStamina 
            {
                get => (sbyte)CellsByName["DamageFalloffPercentStamina"].Value;
                set => CellsByName["DamageFalloffPercentStamina"].Value = value;
            }
            

            // Def="s8 knockbackDamp"
            /// <summary>
            /// Damage Falloff %: Knockback (s8)
            /// </summary>
            /// <remarks>
            /// Correction value that decreases in 1 second after the attenuation distance.
            /// </remarks>
            public sbyte DamageFalloffPercentKnockback 
            {
                get => (sbyte)CellsByName["DamageFalloffPercentKnockback"].Value;
                set => CellsByName["DamageFalloffPercentKnockback"].Value = value;
            }
            

            // Def="s8 shootAngleXZ"
            /// <summary>
            /// Launch Elevation Angle (s8)
            /// </summary>
            /// <remarks>
            /// Additional elevation angle from the horizontal.
            /// </remarks>
            public sbyte LaunchElevationAngle 
            {
                get => (sbyte)CellsByName["LaunchElevationAngle"].Value;
                set => CellsByName["LaunchElevationAngle"].Value = value;
            }
            

            // Def="u8 lockShootLimitAng"
            /// <summary>
            /// Lock Direction Limit Angle (u8)
            /// </summary>
            /// <remarks>
            /// Limit angle when facing the lock direction
            /// </remarks>
            public byte LockDirectionLimitAngle 
            {
                get => (byte)CellsByName["LockDirectionLimitAngle"].Value;
                set => CellsByName["LockDirectionLimitAngle"].Value = value;
            }
            

            // Def="dummy8 pad2[1]"
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
            

            // Def="u8 prevVelocityDirRate"
            /// <summary>
            /// Previous Velocity Direction Rate (u8)
            /// </summary>
            /// <remarks>
            /// Ratio to add the previous movement direction to the current direction when the sliding bullet hits the wall
            /// </remarks>
            public byte PreviousVelocityDirectionRate 
            {
                get => (byte)CellsByName["PreviousVelocityDirectionRate"].Value;
                set => CellsByName["PreviousVelocityDirectionRate"].Value = value;
            }
            

            // Def="u8 atkAttribute = 254"
            /// <summary>
            /// Attack Attribute (u8)
            /// </summary>
            /// <remarks>
            /// Set the physical attributes to set for the bullet
            /// </remarks>
            public byte AttackAttribute 
            {
                get => (byte)CellsByName["AttackAttribute"].Value;
                set => CellsByName["AttackAttribute"].Value = value;
            }
            

            // Def="u8 spAttribute = 254"
            /// <summary>
            /// Special Attribute (u8)
            /// </summary>
            /// <remarks>
            /// Set special attributes to set for bullets
            /// </remarks>
            public byte SpecialAttribute 
            {
                get => (byte)CellsByName["SpecialAttribute"].Value;
                set => CellsByName["SpecialAttribute"].Value = value;
            }
            

            // Def="u8 Material_AttackType = 254"
            /// <summary>
            /// Material Attack Type (u8)
            /// </summary>
            /// <remarks>
            /// Specify what the attack attribute is
            /// </remarks>
            public byte MaterialAttackType 
            {
                get => (byte)CellsByName["MaterialAttackType"].Value;
                set => CellsByName["MaterialAttackType"].Value = value;
            }
            

            // Def="u8 Material_AttackMaterial = 254"
            /// <summary>
            /// Material Attack Material (u8)
            /// </summary>
            /// <remarks>
            /// Used for SFX / SE during attack
            /// </remarks>
            public byte MaterialAttackMaterial 
            {
                get => (byte)CellsByName["MaterialAttackMaterial"].Value;
                set => CellsByName["MaterialAttackMaterial"].Value = value;
            }
            

            // Def="u8 isPenetrateChr:1"
            /// <summary>
            /// Is Penetrate Character (u8)
            /// </summary>
            /// <remarks>
            /// If it is ON, it will penetrate without landing when it hits the character.
            /// </remarks>
            public byte IsPenetrateCharacter 
            {
                get => (byte)CellsByName["IsPenetrateCharacter"].Value;
                set => CellsByName["IsPenetrateCharacter"].Value = value;
            }
            

            // Def="u8 isPenetrateObj:1"
            /// <summary>
            /// Is Penetrate Object (u8)
            /// </summary>
            /// <remarks>
            /// If it is ON, it will penetrate without landing when hitting a dynamic / partial destruction asset.
            /// </remarks>
            public byte IsPenetrateObject 
            {
                get => (byte)CellsByName["IsPenetrateObject"].Value;
                set => CellsByName["IsPenetrateObject"].Value = value;
            }
            


            // Def="u8 launchConditionType"
            /// <summary>
            /// Launch Condition Type (u8)
            /// </summary>
            /// <remarks>
            /// Specify the condition to judge whether to generate a bullet when it lands or the life is extinguished
            /// </remarks>
            public byte LaunchConditionType 
            {
                get => (byte)CellsByName["LaunchConditionType"].Value;
                set => CellsByName["LaunchConditionType"].Value = value;
            }
            

            // Def="u8 FollowType:3"
            /// <summary>
            /// Follow Type (u8)
            /// </summary>
            /// <remarks>
            /// Follow-up type. "Do not follow" is the default.
            /// </remarks>
            public byte FollowType 
            {
                get => (byte)CellsByName["FollowType"].Value;
                set => CellsByName["FollowType"].Value = value;
            }
            

            // Def="u8 EmittePosType:3"
            /// <summary>
            /// Emitter Source Type (u8)
            /// </summary>
            /// <remarks>
            /// Source type. Usually from Damipoli. (Introduced to judge meteo)
            /// </remarks>
            public byte EmitterSourceType 
            {
                get => (byte)CellsByName["EmitterSourceType"].Value;
                set => CellsByName["EmitterSourceType"].Value = value;
            }
            

            // Def="u8 isAttackSFX:1"
            /// <summary>
            /// Is Persistent Attack SFX (u8)
            /// </summary>
            /// <remarks>
            /// Set whether bullets such as arrows will remain stuck in the character
            /// </remarks>
            public byte IsPersistentAttackSFX 
            {
                get => (byte)CellsByName["IsPersistentAttackSFX"].Value;
                set => CellsByName["IsPersistentAttackSFX"].Value = value;
            }
            

            // Def="u8 isEndlessHit:1"
            /// <summary>
            /// Is Continuous Hit (u8)
            /// </summary>
            /// <remarks>
            /// Do you keep hitting?
            /// </remarks>
            public byte IsContinuousHit 
            {
                get => (byte)CellsByName["IsContinuousHit"].Value;
                set => CellsByName["IsContinuousHit"].Value = value;
            }
            

            // Def="u8 isPenetrateMap:1"
            /// <summary>
            /// Is Penetrate Map (u8)
            /// </summary>
            /// <remarks>
            /// If it is ON, it will penetrate without landing when hitting a hit / static asset.
            /// </remarks>
            public byte IsPenetrateMap 
            {
                get => (byte)CellsByName["IsPenetrateMap"].Value;
                set => CellsByName["IsPenetrateMap"].Value = value;
            }
            

            // Def="u8 isHitBothTeam:1"
            /// <summary>
            /// Is Hit Both Teams (u8)
            /// </summary>
            /// <remarks>
            /// Are you an enemy or an ally? (Not a wandering ghost)
            /// </remarks>
            public byte IsHitBothTeams 
            {
                get => (byte)CellsByName["IsHitBothTeams"].Value;
                set => CellsByName["IsHitBothTeams"].Value = value;
            }
            

            // Def="u8 isUseSharedHitList:1"
            /// <summary>
            /// Is Use Shared Hit List (u8)
            /// </summary>
            /// <remarks>
            /// Specify whether to share the hit list
            /// </remarks>
            public byte IsUseSharedHitList 
            {
                get => (byte)CellsByName["IsUseSharedHitList"].Value;
                set => CellsByName["IsUseSharedHitList"].Value = value;
            }
            

            // Def="u8 isUseMultiDmyPolyIfPlace:1"
            /// <summary>
            /// Use Multiple Dummy Polys for Placement (u8)
            /// </summary>
            /// <remarks>
            /// Do you use the same Damipoly ID more than once when placing bullets?
            /// </remarks>
            public byte UseMultipleDummyPolysForPlacement 
            {
                get => (byte)CellsByName["UseMultipleDummyPolysForPlacement"].Value;
                set => CellsByName["UseMultipleDummyPolysForPlacement"].Value = value;
            }
            

            // Def="u8 isHitOtherBulletForceEraseA:1"
            /// <summary>
            /// Force Erase Bullet A if Hit by Other Bullet (u8)
            /// </summary>
            /// <remarks>
            /// Does it hit other bullets forced erasure A?
            /// </remarks>
            public byte ForceEraseBulletAIfHitByOtherBullet 
            {
                get => (byte)CellsByName["ForceEraseBulletAIfHitByOtherBullet"].Value;
                set => CellsByName["ForceEraseBulletAIfHitByOtherBullet"].Value = value;
            }
            

            // Def="u8 isHitOtherBulletForceEraseB:1"
            /// <summary>
            /// Force Erase Bullet B if Hit by Other Bullet (u8)
            /// </summary>
            /// <remarks>
            /// Does it hit the other bullet forced erasure B?
            /// </remarks>
            public byte ForceEraseBulletBIfHitByOtherBullet 
            {
                get => (byte)CellsByName["ForceEraseBulletBIfHitByOtherBullet"].Value;
                set => CellsByName["ForceEraseBulletBIfHitByOtherBullet"].Value = value;
            }
            

            // Def="u8 isHitForceMagic:1"
            /// <summary>
            /// Is Bullet deflected by Magic (u8)
            /// </summary>
            /// <remarks>
            /// Do you hit the force magic?
            /// </remarks>
            public byte IsBulletDeflectedByMagic 
            {
                get => (byte)CellsByName["IsBulletDeflectedByMagic"].Value;
                set => CellsByName["IsBulletDeflectedByMagic"].Value = value;
            }
            

            // Def="u8 isIgnoreSfxIfHitWater:1"
            /// <summary>
            /// Is SFX ignored on Water Hit (u8)
            /// </summary>
            /// <remarks>
            /// Should I ignore the effect if it hits the surface of the water?
            /// </remarks>
            public byte IsSFXIgnoredOnWaterHit 
            {
                get => (byte)CellsByName["IsSFXIgnoredOnWaterHit"].Value;
                set => CellsByName["IsSFXIgnoredOnWaterHit"].Value = value;
            }
            

            // Def="u8 isIgnoreMoveStateIfHitWater:1"
            /// <summary>
            /// Is Move State Ignored on Water Hit (u8)
            /// </summary>
            /// <remarks>
            /// Whether to ignore the state transition even if it hits water
            /// </remarks>
            public byte IsMoveStateIgnoredOnWaterHit 
            {
                get => (byte)CellsByName["IsMoveStateIgnoredOnWaterHit"].Value;
                set => CellsByName["IsMoveStateIgnoredOnWaterHit"].Value = value;
            }
            

            // Def="u8 isHitDarkForceMagic:1"
            /// <summary>
            /// Is Bullet deflected by Bullet Deflection (u8)
            /// </summary>
            /// <remarks>
            /// Do you hit the dark force magic?
            /// </remarks>
            public byte IsBulletDeflectedByBulletDeflection 
            {
                get => (byte)CellsByName["IsBulletDeflectedByBulletDeflection"].Value;
                set => CellsByName["IsBulletDeflectedByBulletDeflection"].Value = value;
            }
            

            // Def="u8 dmgCalcSide:2"
            /// <summary>
            /// Damage Calculation Side (u8)
            /// </summary>
            /// <remarks>
            /// Damage calculation side. During multiplayer, the damage calculation is for switching between the giving side and the receiving side.
            /// </remarks>
            public byte DamageCalculationSide 
            {
                get => (byte)CellsByName["DamageCalculationSide"].Value;
                set => CellsByName["DamageCalculationSide"].Value = value;
            }
            

            // Def="u8 isEnableAutoHoming:1"
            /// <summary>
            /// Is Auto Homing Enabled (u8)
            /// </summary>
            /// <remarks>
            /// Whether to automatically follow when not locked on
            /// </remarks>
            public byte IsAutoHomingEnabled 
            {
                get => (byte)CellsByName["IsAutoHomingEnabled"].Value;
                set => CellsByName["IsAutoHomingEnabled"].Value = value;
            }
            

            // Def="u8 isSyncBulletCulcDumypolyPos:1"
            /// <summary>
            /// Is Emitter Source Synced with Bullet (u8)
            /// </summary>
            /// <remarks>
            /// In the case of a synchronously generated bullet, the emitter attitude at the time of synchronization is used without recalculating the attitude due to the Damipoli position when the bullet is generated.
            /// </remarks>
            public byte IsEmitterSourceSyncedWithBullet 
            {
                get => (byte)CellsByName["IsEmitterSourceSyncedWithBullet"].Value;
                set => CellsByName["IsEmitterSourceSyncedWithBullet"].Value = value;
            }
            

            // Def="u8 isOwnerOverrideInitAngle:1"
            /// <summary>
            /// Is Direction Inherited by Child Bullet (u8)
            /// </summary>
            /// <remarks>
            /// Only valid for sub-bullets. If it is ON, the reference direction is the owner.
            /// </remarks>
            public byte IsDirectionInheritedByChildBullet 
            {
                get => (byte)CellsByName["IsDirectionInheritedByChildBullet"].Value;
                set => CellsByName["IsDirectionInheritedByChildBullet"].Value = value;
            }
            

            // Def="u8 isInheritSfxToChild:1"
            /// <summary>
            /// Is SFX Inherited by Child Bullet (u8)
            /// </summary>
            /// <remarks>
            /// Take over the SFX of the parent bullet. Ignore the SFX ID set for the sub bullet
            /// </remarks>
            public byte IsSFXInheritedByChildBullet 
            {
                get => (byte)CellsByName["IsSFXInheritedByChildBullet"].Value;
                set => CellsByName["IsSFXInheritedByChildBullet"].Value = value;
            }
            

            // Def="s8 darkDamageDamp"
            /// <summary>
            /// Damage Falloff %: Holy (s8)
            /// </summary>
            /// <remarks>
            /// Correction value that decreases in 1 second after the attenuation distance.
            /// </remarks>
            public sbyte DamageFalloffPercentHoly 
            {
                get => (sbyte)CellsByName["DamageFalloffPercentHoly"].Value;
                set => CellsByName["DamageFalloffPercentHoly"].Value = value;
            }
            

            // Def="s8 bulletSfxDeleteType_byHit"
            /// <summary>
            /// Bullet SFX Delete Type - By Hit (s8)
            /// </summary>
            /// <remarks>
            /// Bullet SFX extinction type when landing or playing
            /// </remarks>
            public sbyte BulletSFXDeleteTypeByHit 
            {
                get => (sbyte)CellsByName["BulletSFXDeleteTypeByHit"].Value;
                set => CellsByName["BulletSFXDeleteTypeByHit"].Value = value;
            }
            

            // Def="s8 bulletSfxDeleteType_byLifeDead"
            /// <summary>
            /// Bullet SFX Delete Type - By Expiration (s8)
            /// </summary>
            /// <remarks>
            /// Bullet SFX extinction type at the end of life
            /// </remarks>
            public sbyte BulletSFXDeleteTypeByExpiration 
            {
                get => (sbyte)CellsByName["BulletSFXDeleteTypeByExpiration"].Value;
                set => CellsByName["BulletSFXDeleteTypeByExpiration"].Value = value;
            }
            

            // Def="f32 targetYOffsetRange"
            /// <summary>
            /// Target Vertical Offset (f32)
            /// </summary>
            /// <remarks>
            /// Vertical offset of landing position. Shift the target position up and down at the time of launch and during homing. (-N ~ n)
            /// </remarks>
            public float TargetVerticalOffset 
            {
                get => (float)CellsByName["TargetVerticalOffset"].Value;
                set => CellsByName["TargetVerticalOffset"].Value = value;
            }
            

            // Def="f32 shootAngleYMaxRandom"
            /// <summary>
            /// Random Launch Angle - Max (f32)
            /// </summary>
            /// <remarks>
            /// Upper limit of random number of firing angle (0 to 360)
            /// </remarks>
            public float RandomLaunchAngleMax 
            {
                get => (float)CellsByName["RandomLaunchAngleMax"].Value;
                set => CellsByName["RandomLaunchAngleMax"].Value = value;
            }
            

            // Def="f32 shootAngleXMaxRandom"
            /// <summary>
            /// Random Elevation Angle - Max (f32)
            /// </summary>
            /// <remarks>
            /// Upper limit of firing elevation random number (0 to 360)
            /// </remarks>
            public float RandomElevationAngleMax 
            {
                get => (float)CellsByName["RandomElevationAngleMax"].Value;
                set => CellsByName["RandomElevationAngleMax"].Value = value;
            }
            

            // Def="s32 intervalCreateBulletId = -1"
            /// <summary>
            /// Bullet Emitter: Bullet ID (s32)
            /// </summary>
            /// <remarks>
            /// Bullet ID used when making bullets at regular intervals
            /// </remarks>
            public int BulletEmitterBulletID 
            {
                get => (int)CellsByName["BulletEmitterBulletID"].Value;
                set => CellsByName["BulletEmitterBulletID"].Value = value;
            }
            

            // Def="f32 intervalCreateTimeMin"
            /// <summary>
            /// Bullet Emitter: Minimum Shoot Interval (f32)
            /// </summary>
            /// <remarks>
            /// Minimum interval for making bullets at regular intervals (0 to n)
            /// </remarks>
            public float BulletEmitterMinimumShootInterval 
            {
                get => (float)CellsByName["BulletEmitterMinimumShootInterval"].Value;
                set => CellsByName["BulletEmitterMinimumShootInterval"].Value = value;
            }
            

            // Def="f32 intervalCreateTimeMax"
            /// <summary>
            /// Bullet Emitter: Maximum Shoot Interval (f32)
            /// </summary>
            /// <remarks>
            /// Maximum interval for making bullets at regular intervals (function is disabled if 0 to n 0)
            /// </remarks>
            public float BulletEmitterMaximumShootInterval 
            {
                get => (float)CellsByName["BulletEmitterMaximumShootInterval"].Value;
                set => CellsByName["BulletEmitterMaximumShootInterval"].Value = value;
            }
            

            // Def="f32 predictionShootObserveTime"
            /// <summary>
            /// Prediction Shoot Observe Time (f32)
            /// </summary>
            /// <remarks>
            /// Average speed observation time of predicted shooting function (function is invalid if 0 to 40)
            /// </remarks>
            public float PredictionShootObserveTime 
            {
                get => (float)CellsByName["PredictionShootObserveTime"].Value;
                set => CellsByName["PredictionShootObserveTime"].Value = value;
            }
            

            // Def="f32 intervalCreateWaitTime"
            /// <summary>
            /// Bullet Emitter: Initial Wait Time (f32)
            /// </summary>
            /// <remarks>
            /// Waiting time to start making bullets at regular intervals
            /// </remarks>
            public float BulletEmitterInitialWaitTime 
            {
                get => (float)CellsByName["BulletEmitterInitialWaitTime"].Value;
                set => CellsByName["BulletEmitterInitialWaitTime"].Value = value;
            }
            

            // Def="u8 sfxPostureType"
            /// <summary>
            /// SFX Posture Type (u8)
            /// </summary>
            /// <remarks>
            /// Set the initial attitude of an SFX or sub-bullet created from a bullet
            /// </remarks>
            public byte SFXPostureType 
            {
                get => (byte)CellsByName["SFXPostureType"].Value;
                set => CellsByName["SFXPostureType"].Value = value;
            }
            

            // Def="u8 createLimitGroupId"
            /// <summary>
            /// Create Limit Group ID (u8)
            /// </summary>
            /// <remarks>
            /// If it is 0, it is unused. If the upper limit is reached when creating a bullet set in the same group Id, that bullet will not be created. (Bullets created synchronously on the network will be released regardless)
            /// </remarks>
            public byte CreateLimitGroupID 
            {
                get => (byte)CellsByName["CreateLimitGroupID"].Value;
                set => CellsByName["CreateLimitGroupID"].Value = value;
            }
            


            // Def="u8 isInheritSpeedToChild:1"
            /// <summary>
            /// Is Speed Inherited by Child Bullet (u8)
            /// </summary>
            /// <remarks>
            /// Take over the speed of the timing to replace the submunition. Ignore the speed set for the submunition
            /// </remarks>
            public byte IsSpeedInheritedByChildBullet 
            {
                get => (byte)CellsByName["IsSpeedInheritedByChildBullet"].Value;
                set => CellsByName["IsSpeedInheritedByChildBullet"].Value = value;
            }
            

            // Def="u8 isDisableHitSfx_byChrAndObj:1"
            /// <summary>
            /// Is SFX Disabled on Chr/Object Hit (u8)
            /// </summary>
            /// <remarks>
            /// When ON, the bullet parameter "landing SFX" does not play even if it hits a character / object.
            /// </remarks>
            public byte IsSFXDisabledOnChrObjectHit 
            {
                get => (byte)CellsByName["IsSFXDisabledOnChrObjectHit"].Value;
                set => CellsByName["IsSFXDisabledOnChrObjectHit"].Value = value;
            }
            

            // Def="u8 isCheckWall_byCenterRay:1"
            /// <summary>
            /// Is Wall Checked by Center Ray (u8)
            /// </summary>
            /// <remarks>
            /// There was a problem with the digging judgment when firing a bullet, so it is for error handling. SEQ23101 [Own character] If you use a soul short arrow or a strong soul short arrow in close contact with a character with a high lock-on position, the direction of the bullet will be reversed.
            /// </remarks>
            public byte IsWallCheckedByCenterRay 
            {
                get => (byte)CellsByName["IsWallCheckedByCenterRay"].Value;
                set => CellsByName["IsWallCheckedByCenterRay"].Value = value;
            }
            

            // Def="u8 isHitFlare:1"
            /// <summary>
            /// Is Hit Flare (u8)
            /// </summary>
            /// <remarks>
            /// Do you hit flare magic?
            /// </remarks>
            public byte IsHitFlare 
            {
                get => (byte)CellsByName["IsHitFlare"].Value;
                set => CellsByName["IsHitFlare"].Value = value;
            }
            

            // Def="u8 isUseBulletWallFilter:1"
            /// <summary>
            /// Is Bullet Wall Filter Used (u8)
            /// </summary>
            /// <remarks>
            /// Do you use primitive magic Atari? It will change to a filter that corresponds to the Atari dedicated to primitive magic.
            /// </remarks>
            public byte IsBulletWallFilterUsed 
            {
                get => (byte)CellsByName["IsBulletWallFilterUsed"].Value;
                set => CellsByName["IsBulletWallFilterUsed"].Value = value;
            }
            


            // Def="u8 isNonDependenceMagicForFunnleNum:1"
            /// <summary>
            /// Is Follow Bullet Count not scaled by INT (u8)
            /// </summary>
            /// <remarks>
            /// The number of funnels on the PC does not fluctuate by force. Become the number of shots
            /// </remarks>
            public byte IsFollowBulletCountNotScaledByINT 
            {
                get => (byte)CellsByName["IsFollowBulletCountNotScaledByINT"].Value;
                set => CellsByName["IsFollowBulletCountNotScaledByINT"].Value = value;
            }
            

            // Def="u8 isAiInterruptShootNoDamageBullet:1"
            /// <summary>
            /// Is AI Interrupted by Bullet (u8)
            /// </summary>
            /// <remarks>
            /// Does it react to AI bullets (even with 0 attack power)?
            /// </remarks>
            public byte IsAIInterruptedByBullet 
            {
                get => (byte)CellsByName["IsAIInterruptedByBullet"].Value;
                set => CellsByName["IsAIInterruptedByBullet"].Value = value;
            }
            

            // Def="f32 randomCreateRadius"
            /// <summary>
            /// Emitter Source Radius (f32)
            /// </summary>
            /// <remarks>
            /// The range of bullets used when the source type is set to occur at random locations.
            /// </remarks>
            public float EmitterSourceRadius 
            {
                get => (float)CellsByName["EmitterSourceRadius"].Value;
                set => CellsByName["EmitterSourceRadius"].Value = value;
            }
            

            // Def="f32 followOffset_BaseHeight"
            /// <summary>
            /// Follow Bullet - Height Offset (f32)
            /// </summary>
            /// <remarks>
            /// Funnel tracking position_base point height [m]
            /// </remarks>
            public float FollowBulletHeightOffset 
            {
                get => (float)CellsByName["FollowBulletHeightOffset"].Value;
                set => CellsByName["FollowBulletHeightOffset"].Value = value;
            }
            

            // Def="s32 assetNo_Hit = -1"
            /// <summary>
            /// Asset Generated on Hit (s32)
            /// </summary>
            /// <remarks>
            /// The number of the asset to be generated at the time of landing. -1: Do not generate. The asset number is the last 6 digits of the asset. Example: AEG999_999 = 999999
            /// </remarks>
            public int AssetGeneratedOnHit 
            {
                get => (int)CellsByName["AssetGeneratedOnHit"].Value;
                set => CellsByName["AssetGeneratedOnHit"].Value = value;
            }
            

            // Def="f32 lifeRandomRange"
            /// <summary>
            /// Duration - Random Range (f32)
            /// </summary>
            /// <remarks>
            /// Add a random number of seconds with a set time fluctuation range to the "lifetime [s]".
            /// </remarks>
            public float DurationRandomRange 
            {
                get => (float)CellsByName["DurationRandomRange"].Value;
                set => CellsByName["DurationRandomRange"].Value = value;
            }
            

            // Def="s16 homingAngleX = -1"
            /// <summary>
            /// Homing Angle: X (s16)
            /// </summary>
            /// <remarks>
            /// Only the X-axis component of the inductive performance is changed. Do not change with -1
            /// </remarks>
            public short HomingAngleX 
            {
                get => (short)CellsByName["HomingAngleX"].Value;
                set => CellsByName["HomingAngleX"].Value = value;
            }
            

            // Def="u8 ballisticCalcType"
            /// <summary>
            /// Ballistic Calculation Type (u8)
            /// </summary>
            /// <remarks>
            /// Ballistic calculation type
            /// </remarks>
            public byte BallisticCalculationType 
            {
                get => (byte)CellsByName["BallisticCalculationType"].Value;
                set => CellsByName["BallisticCalculationType"].Value = value;
            }
            

            // Def="u8 attachEffectType"
            /// <summary>
            /// Attach Effect Type (u8)
            /// </summary>
            /// <remarks>
            /// Effect type to attach
            /// </remarks>
            public byte AttachEffectType 
            {
                get => (byte)CellsByName["AttachEffectType"].Value;
                set => CellsByName["AttachEffectType"].Value = value;
            }
            

            // Def="s32 seId_Bullet1 = -1"
            /// <summary>
            /// Insert SE ID - Bullet [1] (s32)
            /// </summary>
            /// <remarks>
            /// Insert SE ID1 for [Bullet]. -1: Not generated 9 digits. Sound type is fixed to s: SFX.
            /// </remarks>
            public int InsertSEIDBullet1 
            {
                get => (int)CellsByName["InsertSEIDBullet1"].Value;
                set => CellsByName["InsertSEIDBullet1"].Value = value;
            }
            

            // Def="s32 seId_Bullet2 = -1"
            /// <summary>
            /// Insert SE ID - Bullet [2] (s32)
            /// </summary>
            /// <remarks>
            /// Insert SE ID 2 for [Bullet]. -1: Not generated 9 digits. Sound type is fixed to s: SFX.
            /// </remarks>
            public int InsertSEIDBullet2 
            {
                get => (int)CellsByName["InsertSEIDBullet2"].Value;
                set => CellsByName["InsertSEIDBullet2"].Value = value;
            }
            

            // Def="s32 seId_Hit = -1"
            /// <summary>
            /// Insert SE ID - Hit (s32)
            /// </summary>
            /// <remarks>
            /// Insert SE ID 1 for [landing]. -1 does not occur. 9 digits. Sound type is fixed to s: SFX.
            /// </remarks>
            public int InsertSEIDHit 
            {
                get => (int)CellsByName["InsertSEIDHit"].Value;
                set => CellsByName["InsertSEIDHit"].Value = value;
            }
            

            // Def="s32 seId_Flick = -1"
            /// <summary>
            /// Insert SE ID - Repel (s32)
            /// </summary>
            /// <remarks>
            /// [At the time of repelling] Enter SE ID1 for. -1 does not occur. 9 digits. Sound type is fixed to s: SFX.
            /// </remarks>
            public int InsertSEIDRepel 
            {
                get => (int)CellsByName["InsertSEIDRepel"].Value;
                set => CellsByName["InsertSEIDRepel"].Value = value;
            }
            

            // Def="s16 howitzerShootAngleXMin"
            /// <summary>
            /// Howitzer - Launch Elevation Limit - Min (s16)
            /// </summary>
            /// <remarks>
            /// [Curly fire] The lower limit [deg] with the firing elevation angle as a reference (0 deg) before applying the curve fire calculation.
            /// </remarks>
            public short HowitzerLaunchElevationLimitMin 
            {
                get => (short)CellsByName["HowitzerLaunchElevationLimitMin"].Value;
                set => CellsByName["HowitzerLaunchElevationLimitMin"].Value = value;
            }
            

            // Def="s16 howitzerShootAngleXMax"
            /// <summary>
            /// Howitzer - Launch Elevation Limit - Max (s16)
            /// </summary>
            /// <remarks>
            /// [Sky firing] The upper limit [deg] based on the firing elevation angle (0deg) before applying the bending firing calculation.
            /// </remarks>
            public short HowitzerLaunchElevationLimitMax 
            {
                get => (short)CellsByName["HowitzerLaunchElevationLimitMax"].Value;
                set => CellsByName["HowitzerLaunchElevationLimitMax"].Value = value;
            }
            

            // Def="f32 howitzerInitMinVelocity"
            /// <summary>
            /// Howitzer - Initial Min Velocity (f32)
            /// </summary>
            /// <remarks>
            /// [Song firing] The minimum speed limit for song firing calculation [m / s].
            /// </remarks>
            public float HowitzerInitialMinVelocity 
            {
                get => (float)CellsByName["HowitzerInitialMinVelocity"].Value;
                set => CellsByName["HowitzerInitialMinVelocity"].Value = value;
            }
            

            // Def="f32 howitzerInitMaxVelocity"
            /// <summary>
            /// Howitzer - Initial Max Velocity (f32)
            /// </summary>
            /// <remarks>
            /// [Song firing] Maximum speed limit for song firing calculation [m / s].
            /// </remarks>
            public float HowitzerInitialMaxVelocity 
            {
                get => (float)CellsByName["HowitzerInitialMaxVelocity"].Value;
                set => CellsByName["HowitzerInitialMaxVelocity"].Value = value;
            }
            

            // Def="s32 sfxId_ForceErase = -1"
            /// <summary>
            /// SFX ID - Force Erase (s32)
            /// </summary>
            /// <remarks>
            /// SFX ID at the time of forced erasure. -1 does not occur.
            /// </remarks>
            public int SFXIDForceErase 
            {
                get => (int)CellsByName["SFXIDForceErase"].Value;
                set => CellsByName["SFXIDForceErase"].Value = value;
            }
            

            // Def="s8 bulletSfxDeleteType_byForceErase"
            /// <summary>
            /// Bullet SFX Delete Type - By Force Erase (s8)
            /// </summary>
            /// <remarks>
            /// Bullet SFX extinction type at the time of forced erasure
            /// </remarks>
            public sbyte BulletSFXDeleteTypeByForceErase 
            {
                get => (sbyte)CellsByName["BulletSFXDeleteTypeByForceErase"].Value;
                set => CellsByName["BulletSFXDeleteTypeByForceErase"].Value = value;
            }
            

            // Def="dummy8 pad3[1]"
            /// <summary>
            /// Padding 3 (dummy8)
            /// </summary>
            /// <remarks>
            /// pad3
            /// </remarks>
            public object Padding3 
            {
                get => (object)CellsByName["Padding3"].Value;
                set => CellsByName["Padding3"].Value = value;
            }
            

            // Def="s16 followDmypoly_forSfxPose = -1"
            /// <summary>
            /// Follow Bullet - Dummy Poly for SFX Pose (s16)
            /// </summary>
            /// <remarks>
            /// SFX direction specification when following Damipoli
            /// </remarks>
            public short FollowBulletDummyPolyForSFXPose 
            {
                get => (short)CellsByName["FollowBulletDummyPolyForSFXPose"].Value;
                set => CellsByName["FollowBulletDummyPolyForSFXPose"].Value = value;
            }
            

            // Def="f32 followOffset_Radius"
            /// <summary>
            /// Follow Bullet - Radius Offset (f32)
            /// </summary>
            /// <remarks>
            /// Funnel tracking position_radius [m]
            /// </remarks>
            public float FollowBulletRadiusOffset 
            {
                get => (float)CellsByName["FollowBulletRadiusOffset"].Value;
                set => CellsByName["FollowBulletRadiusOffset"].Value = value;
            }
            

            // Def="f32 spBulletDistUpRate = 1"
            /// <summary>
            /// SpEffect Bullet Distance - Magnification (f32)
            /// </summary>
            /// <remarks>
            /// Special effect flight distance correction magnification
            /// </remarks>
            public float SpEffectBulletDistanceMagnification 
            {
                get => (float)CellsByName["SpEffectBulletDistanceMagnification"].Value;
                set => CellsByName["SpEffectBulletDistanceMagnification"].Value = value;
            }
            

            // Def="f32 nolockTargetDist"
            /// <summary>
            /// Target Range when Unlocked (f32)
            /// </summary>
            /// <remarks>
            /// Target range when unlocked (-1: Refer to "range", 0: No target)
            /// </remarks>
            public float TargetRangeWhenUnlocked 
            {
                get => (float)CellsByName["TargetRangeWhenUnlocked"].Value;
                set => CellsByName["TargetRangeWhenUnlocked"].Value = value;
            }
            

                }
            }
            
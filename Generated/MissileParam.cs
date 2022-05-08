
            namespace StronglyTypedParams
            {
                // MISSILE_PARAM_ST
                public class MissileParam : ParamRow
                {
                    public MissileParam() : base()
                    {
                    }
            

            // Def="s32 FFXID"
            /// <summary>
            /// FFXID (s32)
            /// </summary>
            /// <remarks>
            /// ID on the FFX editor
            /// </remarks>
            public int FFXID 
            {
                get => (int)CellsByName["FFXID"].Value;
                set => CellsByName["FFXID"].Value = (int)value;
            }
            

            // Def="u16 LifeTime"
            /// <summary>
            /// Survival time [frame] (u16)
            /// </summary>
            /// <remarks>
            /// Survival time.
            /// </remarks>
            public ushort SurvivalTimeFrame 
            {
                get => (ushort)CellsByName["SurvivalTimeFrame"].Value;
                set => CellsByName["SurvivalTimeFrame"].Value = (ushort)value;
            }
            

            // Def="u16 HitSphereRadius"
            /// <summary>
            /// Hit ball radius [cm] (u16)
            /// </summary>
            /// <remarks>
            /// Hit ball radius. Unit cm
            /// </remarks>
            public ushort HitBallRadiusCm 
            {
                get => (ushort)CellsByName["HitBallRadiusCm"].Value;
                set => CellsByName["HitBallRadiusCm"].Value = (ushort)value;
            }
            

            // Def="u16 HitDamage"
            /// <summary>
            /// Landing damage (u16)
            /// </summary>
            /// <remarks>
            /// Amount of damage at the time of landing
            /// </remarks>
            public ushort LandingDamage 
            {
                get => (ushort)CellsByName["LandingDamage"].Value;
                set => CellsByName["LandingDamage"].Value = (ushort)value;
            }
            

            // Def="dummy8 reserve0[6]"
            /// <summary>
            /// reserve (dummy8)
            /// </summary>
            /// <remarks>
            /// 
            /// </remarks>
            public object Reserve 
            {
                get => (object)CellsByName["Reserve"].Value;
                set => CellsByName["Reserve"].Value = (object)value;
            }
            

            // Def="f32 InitVelocity"
            /// <summary>
            /// Initial speed [m / s] (f32)
            /// </summary>
            /// <remarks>
            /// Initial speed [m / s]
            /// </remarks>
            public float InitialSpeedMS 
            {
                get => (float)CellsByName["InitialSpeedMS"].Value;
                set => CellsByName["InitialSpeedMS"].Value = (float)value;
            }
            

            // Def="f32 distance"
            /// <summary>
            /// Range distance (f32)
            /// </summary>
            /// <remarks>
            /// Range distance
            /// </remarks>
            public float RangeDistance 
            {
                get => (float)CellsByName["RangeDistance"].Value;
                set => CellsByName["RangeDistance"].Value = (float)value;
            }
            

            // Def="f32 gravityInRange"
            /// <summary>
            /// Gravity within range (f32)
            /// </summary>
            /// <remarks>
            /// Gravity within range
            /// </remarks>
            public float GravityWithinRange 
            {
                get => (float)CellsByName["GravityWithinRange"].Value;
                set => CellsByName["GravityWithinRange"].Value = (float)value;
            }
            

            // Def="f32 gravityOutRange"
            /// <summary>
            /// Out-of-range gravity (f32)
            /// </summary>
            /// <remarks>
            /// Out-of-range gravity
            /// </remarks>
            public float OutOfRangeGravity 
            {
                get => (float)CellsByName["OutOfRangeGravity"].Value;
                set => CellsByName["OutOfRangeGravity"].Value = (float)value;
            }
            

            // Def="s32 mp"
            /// <summary>
            /// MP consumption (s32)
            /// </summary>
            /// <remarks>
            /// MP consumption
            /// </remarks>
            public int MPConsumption 
            {
                get => (int)CellsByName["MPConsumption"].Value;
                set => CellsByName["MPConsumption"].Value = (int)value;
            }
            

            // Def="f32 accelInRange"
            /// <summary>
            /// Acceleration within range (f32)
            /// </summary>
            /// <remarks>
            /// Acceleration within range
            /// </remarks>
            public float AccelerationWithinRange 
            {
                get => (float)CellsByName["AccelerationWithinRange"].Value;
                set => CellsByName["AccelerationWithinRange"].Value = (float)value;
            }
            

            // Def="f32 accelOutRange"
            /// <summary>
            /// Out-of-range acceleration (f32)
            /// </summary>
            /// <remarks>
            /// Out-of-range acceleration
            /// </remarks>
            public float OutOfRangeAcceleration 
            {
                get => (float)CellsByName["OutOfRangeAcceleration"].Value;
                set => CellsByName["OutOfRangeAcceleration"].Value = (float)value;
            }
            


            // Def="u16 HitMissileID"
            /// <summary>
            /// Landing ID (u16)
            /// </summary>
            /// <remarks>
            /// Landing ID
            /// </remarks>
            public ushort LandingID 
            {
                get => (ushort)CellsByName["LandingID"].Value;
                set => CellsByName["LandingID"].Value = (ushort)value;
            }
            

            // Def="u8 DiedNaturaly"
            /// <summary>
            /// Will you die at the end of your life? (u8)
            /// </summary>
            /// <remarks>
            /// Will it use up its life without dying even if it lands?
            /// </remarks>
            public OnOff WillYouDieAtTheEndOfYourLife 
            {
                get => (OnOff)CellsByName["WillYouDieAtTheEndOfYourLife"].Value;
                set => CellsByName["WillYouDieAtTheEndOfYourLife"].Value = (byte)value;
            }
            

            // Def="u8 ExplosionDie"
            /// <summary>
            /// Will it land when the life has expired? (u8)
            /// </summary>
            /// <remarks>
            /// Will it land when the life has expired?
            /// </remarks>
            public OnOff WillItLandWhenTheLifeHasExpired 
            {
                get => (OnOff)CellsByName["WillItLandWhenTheLifeHasExpired"].Value;
                set => CellsByName["WillItLandWhenTheLifeHasExpired"].Value = (byte)value;
            }
            

            // Def="s32 behaviorId"
            /// <summary>
            /// Action ID on hit (s32)
            /// </summary>
            /// <remarks>
            /// Action ID given to the opponent when doing damage
            /// </remarks>
            public int ActionIDOnHit 
            {
                get => (int)CellsByName["ActionIDOnHit"].Value;
                set => CellsByName["ActionIDOnHit"].Value = (int)value;
            }
            

                }
            }
            
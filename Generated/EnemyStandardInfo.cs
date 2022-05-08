
            namespace StronglyTypedParams
            {
                // ENEMY_STANDARD_INFO_BANK
                public class EnemyStandardInfo : ParamRow
                {
                    public EnemyStandardInfo() : base()
                    {
                    }
            

            // Def="s32 EnemyBehaviorID"
            /// <summary>
            /// Behavior id (s32)
            /// </summary>
            /// <remarks>
            /// Enemy behavior ID
            /// </remarks>
            public int BehaviorId 
            {
                get => (int)CellsByName["BehaviorId"].Value;
                set => CellsByName["BehaviorId"].Value = (int)value;
            }
            

            // Def="u16 HP = 1"
            /// <summary>
            /// Hit points (u16)
            /// </summary>
            /// <remarks>
            /// Hit points
            /// </remarks>
            public ushort HitPoints 
            {
                get => (ushort)CellsByName["HitPoints"].Value;
                set => CellsByName["HitPoints"].Value = (ushort)value;
            }
            

            // Def="u16 AttackPower = 1"
            /// <summary>
            /// Offensive power (u16)
            /// </summary>
            /// <remarks>
            /// Attack power (for proto only)
            /// </remarks>
            public ushort OffensivePower 
            {
                get => (ushort)CellsByName["OffensivePower"].Value;
                set => CellsByName["OffensivePower"].Value = (ushort)value;
            }
            

            // Def="s32 ChrType = 5"
            /// <summary>
            /// Character type (s32)
            /// </summary>
            /// <remarks>
            /// Character type
            /// </remarks>
            public int CharacterType 
            {
                get => (int)CellsByName["CharacterType"].Value;
                set => CellsByName["CharacterType"].Value = (int)value;
            }
            

            // Def="f32 HitHeight = 2"
            /// <summary>
            /// Height per [m] (f32)
            /// </summary>
            /// <remarks>
            /// Height per (Please specify a size larger than the diameter)
            /// </remarks>
            public float HeightPerM 
            {
                get => (float)CellsByName["HeightPerM"].Value;
                set => CellsByName["HeightPerM"].Value = (float)value;
            }
            

            // Def="f32 HitRadius = 0.4"
            /// <summary>
            /// Radius around [m] (f32)
            /// </summary>
            /// <remarks>
            /// Radius around
            /// </remarks>
            public float RadiusAroundM 
            {
                get => (float)CellsByName["RadiusAroundM"].Value;
                set => CellsByName["RadiusAroundM"].Value = (float)value;
            }
            

            // Def="f32 Weight = 60"
            /// <summary>
            /// Weight [kg] (f32)
            /// </summary>
            /// <remarks>
            /// The weight of the character
            /// </remarks>
            public float WeightKg 
            {
                get => (float)CellsByName["WeightKg"].Value;
                set => CellsByName["WeightKg"].Value = (float)value;
            }
            

            // Def="f32 DynamicFriction"
            /// <summary>
            /// Dynamic friction force (f32)
            /// </summary>
            /// <remarks>
            /// Dynamic friction force
            /// </remarks>
            public float DynamicFrictionForce 
            {
                get => (float)CellsByName["DynamicFrictionForce"].Value;
                set => CellsByName["DynamicFrictionForce"].Value = (float)value;
            }
            

            // Def="f32 StaticFriction"
            /// <summary>
            /// Static friction (f32)
            /// </summary>
            /// <remarks>
            /// Static friction force
            /// </remarks>
            public float StaticFriction 
            {
                get => (float)CellsByName["StaticFriction"].Value;
                set => CellsByName["StaticFriction"].Value = (float)value;
            }
            

            // Def="s32 UpperDefState"
            /// <summary>
            /// Upper body initial state (s32)
            /// </summary>
            /// <remarks>
            /// Upper body initial state (PG input)
            /// </remarks>
            public int UpperBodyInitialState 
            {
                get => (int)CellsByName["UpperBodyInitialState"].Value;
                set => CellsByName["UpperBodyInitialState"].Value = (int)value;
            }
            

            // Def="s32 ActionDefState"
            /// <summary>
            /// Initial state of action (s32)
            /// </summary>
            /// <remarks>
            /// Action initial state (PG input)
            /// </remarks>
            public int InitialStateOfAction 
            {
                get => (int)CellsByName["InitialStateOfAction"].Value;
                set => CellsByName["InitialStateOfAction"].Value = (int)value;
            }
            

            // Def="f32 RotY_per_Second = 10"
            /// <summary>
            /// Angle that can be turned per unit time [deg / s] (f32)
            /// </summary>
            /// <remarks>
            /// Y-axis turning angle per unit time [deg / s]
            /// </remarks>
            public float AngleThatCanBeTurnedPerUnitTimeDegS 
            {
                get => (float)CellsByName["AngleThatCanBeTurnedPerUnitTimeDegS"].Value;
                set => CellsByName["AngleThatCanBeTurnedPerUnitTimeDegS"].Value = (float)value;
            }
            

            // Def="dummy8 reserve0[20]"
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
            

            // Def="u8 RotY_per_Second_old"
            /// <summary>
            /// unused (u8)
            /// </summary>
            /// <remarks>
            /// unused
            /// </remarks>
            public byte Unused 
            {
                get => (byte)CellsByName["Unused"].Value;
                set => CellsByName["Unused"].Value = (byte)value;
            }
            

            // Def="u8 EnableSideStep"
            /// <summary>
            /// Can you move left and right? (u8)
            /// </summary>
            /// <remarks>
            /// Can you move left and right?
            /// </remarks>
            public byte CanYouMoveLeftAndRight 
            {
                get => (byte)CellsByName["CanYouMoveLeftAndRight"].Value;
                set => CellsByName["CanYouMoveLeftAndRight"].Value = (byte)value;
            }
            

            // Def="u8 UseRagdollHit"
            /// <summary>
            /// Whether to use a ragdoll per character (u8)
            /// </summary>
            /// <remarks>
            /// Whether to use a ragdoll per character
            /// </remarks>
            public byte WhetherToUseARagdollPerCharacter 
            {
                get => (byte)CellsByName["WhetherToUseARagdollPerCharacter"].Value;
                set => CellsByName["WhetherToUseARagdollPerCharacter"].Value = (byte)value;
            }
            


            // Def="u16 stamina"
            /// <summary>
            /// Amount of stamina (u16)
            /// </summary>
            /// <remarks>
            /// Total amount of stamina
            /// </remarks>
            public ushort AmountOfStamina 
            {
                get => (ushort)CellsByName["AmountOfStamina"].Value;
                set => CellsByName["AmountOfStamina"].Value = (ushort)value;
            }
            

            // Def="u16 staminaRecover"
            /// <summary>
            /// Stamina recovery (u16)
            /// </summary>
            /// <remarks>
            /// Stamina recovery amount per second
            /// </remarks>
            public ushort StaminaRecovery 
            {
                get => (ushort)CellsByName["StaminaRecovery"].Value;
                set => CellsByName["StaminaRecovery"].Value = (ushort)value;
            }
            

            // Def="u16 staminaConsumption"
            /// <summary>
            /// Stamina basic consumption (u16)
            /// </summary>
            /// <remarks>
            /// Basic value of stamina consumption used when attacking and guarding
            /// </remarks>
            public ushort StaminaBasicConsumption 
            {
                get => (ushort)CellsByName["StaminaBasicConsumption"].Value;
                set => CellsByName["StaminaBasicConsumption"].Value = (ushort)value;
            }
            

            // Def="u16 deffenct_Phys"
            /// <summary>
            /// Physical defense (u16)
            /// </summary>
            /// <remarks>
            /// Damage reduction base value for physical attacks
            /// </remarks>
            public ushort PhysicalDefense 
            {
                get => (ushort)CellsByName["PhysicalDefense"].Value;
                set => CellsByName["PhysicalDefense"].Value = (ushort)value;
            }
            

            // Def="dummy8 reserve_last2[48]"
            /// <summary>
            /// Reservation 1 (dummy8)
            /// </summary>
            /// <remarks>
            /// 
            /// </remarks>
            public object Reservation1 
            {
                get => (object)CellsByName["Reservation1"].Value;
                set => CellsByName["Reservation1"].Value = (object)value;
            }
            
                }
            }
            
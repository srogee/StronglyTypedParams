
            namespace StronglyTypedParams
            {
                // BEHAVIOR_PARAM_ST
                public class BehaviorParam : ParamRow
                {
                    public BehaviorParam() : base()
                    {
                    }
            

            // Def="s32 variationId"
            /// <summary>
            /// Behavior Variation ID (s32)
            /// </summary>
            /// <remarks>
            /// Used when calculating the ID for attack parameters. It is not used directly on the actual machine.
            /// </remarks>
            public int BehaviorVariationID 
            {
                get => (int)CellsByName["BehaviorVariationID"].Value;
                set => CellsByName["BehaviorVariationID"].Value = (int)value;
            }
            

            // Def="s32 behaviorJudgeId"
            /// <summary>
            /// Behavior Judge ID (s32)
            /// </summary>
            /// <remarks>
            /// Used when calculating the ID for attack parameters. This ID matches the action judgment ID entered in TimeActEditor. It is not used directly on the actual machine.
            /// </remarks>
            public int BehaviorJudgeID 
            {
                get => (int)CellsByName["BehaviorJudgeID"].Value;
                set => CellsByName["BehaviorJudgeID"].Value = (int)value;
            }
            

            // Def="u8 ezStateBehaviorType_old"
            /// <summary>
            /// State Behavior Type (u8)
            /// </summary>
            /// <remarks>
            /// For ID calculation rules
            /// </remarks>
            public byte StateBehaviorType 
            {
                get => (byte)CellsByName["StateBehaviorType"].Value;
                set => CellsByName["StateBehaviorType"].Value = (byte)value;
            }
            

            // Def="u8 refType"
            /// <summary>
            /// Reference Type (u8)
            /// </summary>
            /// <remarks>
            /// Specify the reference ID so that it is correct.
            /// </remarks>
            public BehaviorRefType ReferenceType 
            {
                get => (BehaviorRefType)CellsByName["ReferenceType"].Value;
                set => CellsByName["ReferenceType"].Value = (byte)value;
            }
            

            // Def="dummy8 pad2[2]"
            /// <summary>
            /// pad (dummy8)
            /// </summary>
            /// <remarks>
            /// 
            /// </remarks>
            public object Pad 
            {
                get => (object)CellsByName["Pad"].Value;
                set => CellsByName["Pad"].Value = (object)value;
            }
            

            // Def="s32 refId = -1"
            /// <summary>
            /// Reference ID (s32)
            /// </summary>
            /// <remarks>
            /// It can be used properly according to the attack power, missile, ID of special effect parameter, and refType.
            /// </remarks>
            public int ReferenceID 
            {
                get => (int)CellsByName["ReferenceID"].Value;
                set => CellsByName["ReferenceID"].Value = (int)value;
            }
            

            // Def="f32 consumeSA"
            /// <summary>
            /// Poise Cost (f32)
            /// </summary>
            /// <remarks>
            /// Set the amount of SA consumed during action.
            /// </remarks>
            public float PoiseCost 
            {
                get => (float)CellsByName["PoiseCost"].Value;
                set => CellsByName["PoiseCost"].Value = (float)value;
            }
            

            // Def="s32 stamina"
            /// <summary>
            /// Stamina Cost (s32)
            /// </summary>
            /// <remarks>
            /// Set the amount of stamina consumed during action.
            /// </remarks>
            public int StaminaCost 
            {
                get => (int)CellsByName["StaminaCost"].Value;
                set => CellsByName["StaminaCost"].Value = (int)value;
            }
            

            // Def="s32 consumeDurability"
            /// <summary>
            /// Durability Cost (s32)
            /// </summary>
            /// <remarks>
            /// Set the durability of weapons consumed during action.
            /// </remarks>
            public int DurabilityCost 
            {
                get => (int)CellsByName["DurabilityCost"].Value;
                set => CellsByName["DurabilityCost"].Value = (int)value;
            }
            

            // Def="u8 category"
            /// <summary>
            /// Category (u8)
            /// </summary>
            /// <remarks>
            /// Since there are effects (enchantment weapons, etc.) whose parameters fluctuate depending on skills, magic, items, etc., set each action so that the determined effect can correspond to the effect such as "power up only weapon attack". Set "None" for items that do not need to be set, such as varistor.
            /// </remarks>
            public BehaviorCategory Category 
            {
                get => (BehaviorCategory)CellsByName["Category"].Value;
                set => CellsByName["Category"].Value = (byte)value;
            }
            

            // Def="u8 heroPoint"
            /// <summary>
            /// Humanity Cost (u8)
            /// </summary>
            /// <remarks>
            /// Set the amount of humanity consumed during action
            /// </remarks>
            public byte HumanityCost 
            {
                get => (byte)CellsByName["HumanityCost"].Value;
                set => CellsByName["HumanityCost"].Value = (byte)value;
            }
            

                }
            }
            
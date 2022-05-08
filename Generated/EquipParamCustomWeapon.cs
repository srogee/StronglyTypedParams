
            namespace StronglyTypedParams
            {
                // EQUIP_PARAM_CUSTOM_WEAPON_ST
                public class EquipParamCustomWeapon : ParamRow
                {
                    public EquipParamCustomWeapon() : base()
                    {
                    }
            

            // Def="s32 baseWepId"
            /// <summary>
            /// Base Weapon ID (s32)
            /// </summary>
            /// <remarks>
            /// Weapon base ID
            /// </remarks>
            public int BaseWeaponID 
            {
                get => (int)CellsByName["BaseWeaponID"].Value;
                set => CellsByName["BaseWeaponID"].Value = (int)value;
            }
            

            // Def="s32 gemId"
            /// <summary>
            /// Gem ID (s32)
            /// </summary>
            /// <remarks>
            /// Magic stone ID
            /// </remarks>
            public int GemID 
            {
                get => (int)CellsByName["GemID"].Value;
                set => CellsByName["GemID"].Value = (int)value;
            }
            

            // Def="u8 reinforceLv"
            /// <summary>
            /// Reinforcement Level (u8)
            /// </summary>
            /// <remarks>
            /// Enhancement value
            /// </remarks>
            public byte ReinforcementLevel 
            {
                get => (byte)CellsByName["ReinforcementLevel"].Value;
                set => CellsByName["ReinforcementLevel"].Value = (byte)value;
            }
            

            // Def="dummy8 pad[7]"
            /// <summary>
            /// pad (dummy8)
            /// </summary>
            /// <remarks>
            /// pad
            /// </remarks>
            public object Pad 
            {
                get => (object)CellsByName["Pad"].Value;
                set => CellsByName["Pad"].Value = (object)value;
            }
            
                }
            }
            
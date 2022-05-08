
            namespace StronglyTypedParams
            {
                // CHARACTER_INIT_PARAM
                public class CharaInitParam : ParamRow
                {
                    public CharaInitParam() : base()
                    {
                    }
            

            // Def="f32 baseRec_mp"
            /// <summary>
            /// Base FP Recovery Time (f32)
            /// </summary>
            /// <remarks>
            /// Time until MP recovers 1 point (first decimal place)
            /// </remarks>
            public float BaseFPRecoveryTime 
            {
                get => (float)CellsByName["BaseFPRecoveryTime"].Value;
                set => CellsByName["BaseFPRecoveryTime"].Value = (float)value;
            }
            

            // Def="f32 baseRec_sp"
            /// <summary>
            /// Base Stamina Recovery Time (f32)
            /// </summary>
            /// <remarks>
            /// Time to recover 1 point of stamina (first decimal place)
            /// </remarks>
            public float BaseStaminaRecoveryTime 
            {
                get => (float)CellsByName["BaseStaminaRecoveryTime"].Value;
                set => CellsByName["BaseStaminaRecoveryTime"].Value = (float)value;
            }
            

            // Def="f32 red_Falldam"
            /// <summary>
            /// Characer Head Land - Damage Reduction (f32)
            /// </summary>
            /// <remarks>
            /// Damage reduction amount (%) that can be a cushion when scolded by another character from above (first decimal place)
            /// </remarks>
            public float CharacerHeadLandDamageReduction 
            {
                get => (float)CellsByName["CharacerHeadLandDamageReduction"].Value;
                set => CellsByName["CharacerHeadLandDamageReduction"].Value = (float)value;
            }
            

            // Def="s32 soul"
            /// <summary>
            /// Runes (s32)
            /// </summary>
            /// <remarks>
            /// The amount of soul you have at the beginning
            /// </remarks>
            public int Runes 
            {
                get => (int)CellsByName["Runes"].Value;
                set => CellsByName["Runes"].Value = (int)value;
            }
            

            // Def="s32 equip_Wep_Right = -1"
            /// <summary>
            /// Equipped Weapon: Right Primary (s32)
            /// </summary>
            /// <remarks>
            /// Weapon ID of equipment parameter (right hand slot 1)
            /// </remarks>
            public int EquippedWeaponRightPrimary 
            {
                get => (int)CellsByName["EquippedWeaponRightPrimary"].Value;
                set => CellsByName["EquippedWeaponRightPrimary"].Value = (int)value;
            }
            

            // Def="s32 equip_Subwep_Right = -1"
            /// <summary>
            /// Equipped Weapon: Right Secondary (s32)
            /// </summary>
            /// <remarks>
            /// Weapon ID of equipment parameter (right hand slot 2)
            /// </remarks>
            public int EquippedWeaponRightSecondary 
            {
                get => (int)CellsByName["EquippedWeaponRightSecondary"].Value;
                set => CellsByName["EquippedWeaponRightSecondary"].Value = (int)value;
            }
            

            // Def="s32 equip_Wep_Left = -1"
            /// <summary>
            /// Equipped Weapon: Left Primary (s32)
            /// </summary>
            /// <remarks>
            /// Weapon ID of equipment parameter (left hand slot 1)
            /// </remarks>
            public int EquippedWeaponLeftPrimary 
            {
                get => (int)CellsByName["EquippedWeaponLeftPrimary"].Value;
                set => CellsByName["EquippedWeaponLeftPrimary"].Value = (int)value;
            }
            

            // Def="s32 equip_Subwep_Left = -1"
            /// <summary>
            /// Equipped Weapon: Left Secondary (s32)
            /// </summary>
            /// <remarks>
            /// Weapon ID of equipment parameter (left hand slot 2)
            /// </remarks>
            public int EquippedWeaponLeftSecondary 
            {
                get => (int)CellsByName["EquippedWeaponLeftSecondary"].Value;
                set => CellsByName["EquippedWeaponLeftSecondary"].Value = (int)value;
            }
            

            // Def="s32 equip_Helm = -1"
            /// <summary>
            /// Equipped Armor: Head (s32)
            /// </summary>
            /// <remarks>
            /// Equipment parameter armor ID (head armor)
            /// </remarks>
            public int EquippedArmorHead 
            {
                get => (int)CellsByName["EquippedArmorHead"].Value;
                set => CellsByName["EquippedArmorHead"].Value = (int)value;
            }
            

            // Def="s32 equip_Armer = -1"
            /// <summary>
            /// Equipped Armor: Chest (s32)
            /// </summary>
            /// <remarks>
            /// Equipment parameter armor ID (torso armor)
            /// </remarks>
            public int EquippedArmorChest 
            {
                get => (int)CellsByName["EquippedArmorChest"].Value;
                set => CellsByName["EquippedArmorChest"].Value = (int)value;
            }
            

            // Def="s32 equip_Gaunt = -1"
            /// <summary>
            /// Equipped Armor: Arms (s32)
            /// </summary>
            /// <remarks>
            /// Equipment parameter armor ID (arm armor)
            /// </remarks>
            public int EquippedArmorArms 
            {
                get => (int)CellsByName["EquippedArmorArms"].Value;
                set => CellsByName["EquippedArmorArms"].Value = (int)value;
            }
            

            // Def="s32 equip_Leg = -1"
            /// <summary>
            /// Equipped Armor: Legs (s32)
            /// </summary>
            /// <remarks>
            /// Equipment parameter armor ID (leg armor)
            /// </remarks>
            public int EquippedArmorLegs 
            {
                get => (int)CellsByName["EquippedArmorLegs"].Value;
                set => CellsByName["EquippedArmorLegs"].Value = (int)value;
            }
            

            // Def="s32 equip_Arrow = -1"
            /// <summary>
            /// Equipped Ammunition: Arrow Primary (s32)
            /// </summary>
            /// <remarks>
            /// Weapon ID (arrow) of equipment parameter
            /// </remarks>
            public int EquippedAmmunitionArrowPrimary 
            {
                get => (int)CellsByName["EquippedAmmunitionArrowPrimary"].Value;
                set => CellsByName["EquippedAmmunitionArrowPrimary"].Value = (int)value;
            }
            

            // Def="s32 equip_Bolt = -1"
            /// <summary>
            /// Equipped Ammunition: Bolt Primary (s32)
            /// </summary>
            /// <remarks>
            /// Weapon ID (bolt) of equipment parameter
            /// </remarks>
            public int EquippedAmmunitionBoltPrimary 
            {
                get => (int)CellsByName["EquippedAmmunitionBoltPrimary"].Value;
                set => CellsByName["EquippedAmmunitionBoltPrimary"].Value = (int)value;
            }
            

            // Def="s32 equip_SubArrow = -1"
            /// <summary>
            /// Equipped Ammunition: Arrow Secondary (s32)
            /// </summary>
            /// <remarks>
            /// Weapon ID of equipment parameter (arrow reserve)
            /// </remarks>
            public int EquippedAmmunitionArrowSecondary 
            {
                get => (int)CellsByName["EquippedAmmunitionArrowSecondary"].Value;
                set => CellsByName["EquippedAmmunitionArrowSecondary"].Value = (int)value;
            }
            

            // Def="s32 equip_SubBolt = -1"
            /// <summary>
            /// Equipped Ammunition: Bolt Secondary (s32)
            /// </summary>
            /// <remarks>
            /// Weapon ID of equipment parameter (spare bolt)
            /// </remarks>
            public int EquippedAmmunitionBoltSecondary 
            {
                get => (int)CellsByName["EquippedAmmunitionBoltSecondary"].Value;
                set => CellsByName["EquippedAmmunitionBoltSecondary"].Value = (int)value;
            }
            

            // Def="s32 equip_Accessory01 = -1"
            /// <summary>
            /// Equipped Accessory: Slot 1 (s32)
            /// </summary>
            /// <remarks>
            /// Equipment parameter decoration ID01
            /// </remarks>
            public int EquippedAccessorySlot1 
            {
                get => (int)CellsByName["EquippedAccessorySlot1"].Value;
                set => CellsByName["EquippedAccessorySlot1"].Value = (int)value;
            }
            

            // Def="s32 equip_Accessory02 = -1"
            /// <summary>
            /// Equipped Accessory: Slot 2 (s32)
            /// </summary>
            /// <remarks>
            /// Equipment parameter decoration ID02
            /// </remarks>
            public int EquippedAccessorySlot2 
            {
                get => (int)CellsByName["EquippedAccessorySlot2"].Value;
                set => CellsByName["EquippedAccessorySlot2"].Value = (int)value;
            }
            

            // Def="s32 equip_Accessory03 = -1"
            /// <summary>
            /// Equipped Accessory: Slot 3 (s32)
            /// </summary>
            /// <remarks>
            /// Equipment parameter decoration ID03
            /// </remarks>
            public int EquippedAccessorySlot3 
            {
                get => (int)CellsByName["EquippedAccessorySlot3"].Value;
                set => CellsByName["EquippedAccessorySlot3"].Value = (int)value;
            }
            

            // Def="s32 equip_Accessory04 = -1"
            /// <summary>
            /// Equipped Accessory: Slot 4 (s32)
            /// </summary>
            /// <remarks>
            /// Equipment parameter decoration ID04
            /// </remarks>
            public int EquippedAccessorySlot4 
            {
                get => (int)CellsByName["EquippedAccessorySlot4"].Value;
                set => CellsByName["EquippedAccessorySlot4"].Value = (int)value;
            }
            

            // Def="dummy8 pad8[4]"
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
            

            // Def="s32 elixir_material00 = -1"
            /// <summary>
            /// Elixir Material 1 (s32)
            /// </summary>
            /// <remarks>
            /// Material ID1 for Elixir
            /// </remarks>
            public int ElixirMaterial1 
            {
                get => (int)CellsByName["ElixirMaterial1"].Value;
                set => CellsByName["ElixirMaterial1"].Value = (int)value;
            }
            

            // Def="s32 elixir_material01 = -1"
            /// <summary>
            /// Elixir Material 2 (s32)
            /// </summary>
            /// <remarks>
            /// Material ID2 for Elixir
            /// </remarks>
            public int ElixirMaterial2 
            {
                get => (int)CellsByName["ElixirMaterial2"].Value;
                set => CellsByName["ElixirMaterial2"].Value = (int)value;
            }
            

            // Def="s32 elixir_material02 = -1"
            /// <summary>
            /// Elixir Material 3 (s32)
            /// </summary>
            /// <remarks>
            /// Material ID3 for Elixir
            /// </remarks>
            public int ElixirMaterial3 
            {
                get => (int)CellsByName["ElixirMaterial3"].Value;
                set => CellsByName["ElixirMaterial3"].Value = (int)value;
            }
            

            // Def="s32 equip_Spell_01 = -1"
            /// <summary>
            /// Equipped Spell: Slot 1 (s32)
            /// </summary>
            /// <remarks>
            /// Initial placement magic / miracle ID01
            /// </remarks>
            public int EquippedSpellSlot1 
            {
                get => (int)CellsByName["EquippedSpellSlot1"].Value;
                set => CellsByName["EquippedSpellSlot1"].Value = (int)value;
            }
            

            // Def="s32 equip_Spell_02 = -1"
            /// <summary>
            /// Equipped Spell: Slot 2 (s32)
            /// </summary>
            /// <remarks>
            /// Initial placement magic / miracle ID02
            /// </remarks>
            public int EquippedSpellSlot2 
            {
                get => (int)CellsByName["EquippedSpellSlot2"].Value;
                set => CellsByName["EquippedSpellSlot2"].Value = (int)value;
            }
            

            // Def="s32 equip_Spell_03 = -1"
            /// <summary>
            /// Equipped Spell: Slot 3 (s32)
            /// </summary>
            /// <remarks>
            /// Initial placement magic / miracle ID03
            /// </remarks>
            public int EquippedSpellSlot3 
            {
                get => (int)CellsByName["EquippedSpellSlot3"].Value;
                set => CellsByName["EquippedSpellSlot3"].Value = (int)value;
            }
            

            // Def="s32 equip_Spell_04 = -1"
            /// <summary>
            /// Equipped Spell: Slot 4 (s32)
            /// </summary>
            /// <remarks>
            /// Initial placement magic / miracle ID04
            /// </remarks>
            public int EquippedSpellSlot4 
            {
                get => (int)CellsByName["EquippedSpellSlot4"].Value;
                set => CellsByName["EquippedSpellSlot4"].Value = (int)value;
            }
            

            // Def="s32 equip_Spell_05 = -1"
            /// <summary>
            /// Equipped Spell: Slot 5 (s32)
            /// </summary>
            /// <remarks>
            /// Initial placement magic / miracle ID05
            /// </remarks>
            public int EquippedSpellSlot5 
            {
                get => (int)CellsByName["EquippedSpellSlot5"].Value;
                set => CellsByName["EquippedSpellSlot5"].Value = (int)value;
            }
            

            // Def="s32 equip_Spell_06 = -1"
            /// <summary>
            /// Equipped Spell: Slot 6 (s32)
            /// </summary>
            /// <remarks>
            /// Initial placement magic / miracle ID06
            /// </remarks>
            public int EquippedSpellSlot6 
            {
                get => (int)CellsByName["EquippedSpellSlot6"].Value;
                set => CellsByName["EquippedSpellSlot6"].Value = (int)value;
            }
            

            // Def="s32 equip_Spell_07 = -1"
            /// <summary>
            /// Equipped Spell: Slot 7 (s32)
            /// </summary>
            /// <remarks>
            /// Initial placement magic / miracle ID07
            /// </remarks>
            public int EquippedSpellSlot7 
            {
                get => (int)CellsByName["EquippedSpellSlot7"].Value;
                set => CellsByName["EquippedSpellSlot7"].Value = (int)value;
            }
            

            // Def="s32 item_01 = -1"
            /// <summary>
            /// Equipped Item: Slot 1 (s32)
            /// </summary>
            /// <remarks>
            /// Initial possession item ID 01
            /// </remarks>
            public int EquippedItemSlot1 
            {
                get => (int)CellsByName["EquippedItemSlot1"].Value;
                set => CellsByName["EquippedItemSlot1"].Value = (int)value;
            }
            

            // Def="s32 item_02 = -1"
            /// <summary>
            /// Equipped Item: Slot 2 (s32)
            /// </summary>
            /// <remarks>
            /// Initial possession item ID 02
            /// </remarks>
            public int EquippedItemSlot2 
            {
                get => (int)CellsByName["EquippedItemSlot2"].Value;
                set => CellsByName["EquippedItemSlot2"].Value = (int)value;
            }
            

            // Def="s32 item_03 = -1"
            /// <summary>
            /// Equipped Item: Slot 3 (s32)
            /// </summary>
            /// <remarks>
            /// Initial possession item ID 03
            /// </remarks>
            public int EquippedItemSlot3 
            {
                get => (int)CellsByName["EquippedItemSlot3"].Value;
                set => CellsByName["EquippedItemSlot3"].Value = (int)value;
            }
            

            // Def="s32 item_04 = -1"
            /// <summary>
            /// Equipped Item: Slot 4 (s32)
            /// </summary>
            /// <remarks>
            /// Initial possession item ID 04
            /// </remarks>
            public int EquippedItemSlot4 
            {
                get => (int)CellsByName["EquippedItemSlot4"].Value;
                set => CellsByName["EquippedItemSlot4"].Value = (int)value;
            }
            

            // Def="s32 item_05 = -1"
            /// <summary>
            /// Equipped Item: Slot 5 (s32)
            /// </summary>
            /// <remarks>
            /// Initial possession item ID 05
            /// </remarks>
            public int EquippedItemSlot5 
            {
                get => (int)CellsByName["EquippedItemSlot5"].Value;
                set => CellsByName["EquippedItemSlot5"].Value = (int)value;
            }
            

            // Def="s32 item_06 = -1"
            /// <summary>
            /// Equipped Item: Slot 6 (s32)
            /// </summary>
            /// <remarks>
            /// Initial possession item ID 06
            /// </remarks>
            public int EquippedItemSlot6 
            {
                get => (int)CellsByName["EquippedItemSlot6"].Value;
                set => CellsByName["EquippedItemSlot6"].Value = (int)value;
            }
            

            // Def="s32 item_07 = -1"
            /// <summary>
            /// Equipped Item: Slot 7 (s32)
            /// </summary>
            /// <remarks>
            /// Initial possession item ID 07
            /// </remarks>
            public int EquippedItemSlot7 
            {
                get => (int)CellsByName["EquippedItemSlot7"].Value;
                set => CellsByName["EquippedItemSlot7"].Value = (int)value;
            }
            

            // Def="s32 item_08 = -1"
            /// <summary>
            /// Equipped Item: Slot 8 (s32)
            /// </summary>
            /// <remarks>
            /// Initial possession item ID 08
            /// </remarks>
            public int EquippedItemSlot8 
            {
                get => (int)CellsByName["EquippedItemSlot8"].Value;
                set => CellsByName["EquippedItemSlot8"].Value = (int)value;
            }
            

            // Def="s32 item_09 = -1"
            /// <summary>
            /// Equipped Item: Slot 9 (s32)
            /// </summary>
            /// <remarks>
            /// Initial possession item ID 09
            /// </remarks>
            public int EquippedItemSlot9 
            {
                get => (int)CellsByName["EquippedItemSlot9"].Value;
                set => CellsByName["EquippedItemSlot9"].Value = (int)value;
            }
            

            // Def="s32 item_10 = -1"
            /// <summary>
            /// Equipped Item: Slot 10 (s32)
            /// </summary>
            /// <remarks>
            /// Initial possession item ID 10
            /// </remarks>
            public int EquippedItemSlot10 
            {
                get => (int)CellsByName["EquippedItemSlot10"].Value;
                set => CellsByName["EquippedItemSlot10"].Value = (int)value;
            }
            

            // Def="s32 npcPlayerFaceGenId"
            /// <summary>
            /// NPC Player - Face Gen ID (s32)
            /// </summary>
            /// <remarks>
            /// Facegen parameter ID used by NPC players. Not used by normal players.
            /// </remarks>
            public int NPCPlayerFaceGenID 
            {
                get => (int)CellsByName["NPCPlayerFaceGenID"].Value;
                set => CellsByName["NPCPlayerFaceGenID"].Value = (int)value;
            }
            

            // Def="s32 npcPlayerThinkId"
            /// <summary>
            /// NPC Player - Think ID (s32)
            /// </summary>
            /// <remarks>
            /// NPC Thinking Parameter ID used by NPC players. Not used by normal players.
            /// </remarks>
            public int NPCPlayerThinkID 
            {
                get => (int)CellsByName["NPCPlayerThinkID"].Value;
                set => CellsByName["NPCPlayerThinkID"].Value = (int)value;
            }
            

            // Def="u16 baseHp"
            /// <summary>
            /// Base HP (u16)
            /// </summary>
            /// <remarks>
            /// Basic value of HP (actually, it is corrected by the calculation formula)
            /// </remarks>
            public ushort BaseHP 
            {
                get => (ushort)CellsByName["BaseHP"].Value;
                set => CellsByName["BaseHP"].Value = (ushort)value;
            }
            

            // Def="u16 baseMp"
            /// <summary>
            /// Base FP (u16)
            /// </summary>
            /// <remarks>
            /// Basic value of MP (actually, it is corrected by the calculation formula)
            /// </remarks>
            public ushort BaseFP 
            {
                get => (ushort)CellsByName["BaseFP"].Value;
                set => CellsByName["BaseFP"].Value = (ushort)value;
            }
            

            // Def="u16 baseSp"
            /// <summary>
            /// Base Stamina (u16)
            /// </summary>
            /// <remarks>
            /// Basic value of stamina (actually, it is corrected by the formula)
            /// </remarks>
            public ushort BaseStamina 
            {
                get => (ushort)CellsByName["BaseStamina"].Value;
                set => CellsByName["BaseStamina"].Value = (ushort)value;
            }
            

            // Def="u16 arrowNum"
            /// <summary>
            /// Equipped Ammunition: Arrow Primary Count (u16)
            /// </summary>
            /// <remarks>
            /// Initial number of arrows
            /// </remarks>
            public ushort EquippedAmmunitionArrowPrimaryCount 
            {
                get => (ushort)CellsByName["EquippedAmmunitionArrowPrimaryCount"].Value;
                set => CellsByName["EquippedAmmunitionArrowPrimaryCount"].Value = (ushort)value;
            }
            

            // Def="u16 boltNum"
            /// <summary>
            /// Equipped Ammunition: Bolt Primary Count (u16)
            /// </summary>
            /// <remarks>
            /// Initial number of bolts
            /// </remarks>
            public ushort EquippedAmmunitionBoltPrimaryCount 
            {
                get => (ushort)CellsByName["EquippedAmmunitionBoltPrimaryCount"].Value;
                set => CellsByName["EquippedAmmunitionBoltPrimaryCount"].Value = (ushort)value;
            }
            

            // Def="u16 subArrowNum"
            /// <summary>
            /// Equipped Ammunition: Arrow Secondary Count (u16)
            /// </summary>
            /// <remarks>
            /// Initial number of arrows
            /// </remarks>
            public ushort EquippedAmmunitionArrowSecondaryCount 
            {
                get => (ushort)CellsByName["EquippedAmmunitionArrowSecondaryCount"].Value;
                set => CellsByName["EquippedAmmunitionArrowSecondaryCount"].Value = (ushort)value;
            }
            

            // Def="u16 subBoltNum"
            /// <summary>
            /// Equipped Ammunition: Bolt Secondary Count (u16)
            /// </summary>
            /// <remarks>
            /// Initial number of bolts
            /// </remarks>
            public ushort EquippedAmmunitionBoltSecondaryCount 
            {
                get => (ushort)CellsByName["EquippedAmmunitionBoltSecondaryCount"].Value;
                set => CellsByName["EquippedAmmunitionBoltSecondaryCount"].Value = (ushort)value;
            }
            


            // Def="s16 soulLv"
            /// <summary>
            /// Level (s16)
            /// </summary>
            /// <remarks>
            /// Initial Lv
            /// </remarks>
            public short Level 
            {
                get => (short)CellsByName["Level"].Value;
                set => CellsByName["Level"].Value = (short)value;
            }
            

            // Def="u8 baseVit"
            /// <summary>
            /// Vigor (u8)
            /// </summary>
            /// <remarks>
            /// Basic value of physical fitness
            /// </remarks>
            public byte Vigor 
            {
                get => (byte)CellsByName["Vigor"].Value;
                set => CellsByName["Vigor"].Value = (byte)value;
            }
            

            // Def="u8 baseWil"
            /// <summary>
            /// Attunement (u8)
            /// </summary>
            /// <remarks>
            /// Basic value of spirit
            /// </remarks>
            public byte Attunement 
            {
                get => (byte)CellsByName["Attunement"].Value;
                set => CellsByName["Attunement"].Value = (byte)value;
            }
            

            // Def="u8 baseEnd"
            /// <summary>
            /// Endurance (u8)
            /// </summary>
            /// <remarks>
            /// Robust base value
            /// </remarks>
            public byte Endurance 
            {
                get => (byte)CellsByName["Endurance"].Value;
                set => CellsByName["Endurance"].Value = (byte)value;
            }
            

            // Def="u8 baseStr"
            /// <summary>
            /// Strength (u8)
            /// </summary>
            /// <remarks>
            /// Basic value of muscle strength
            /// </remarks>
            public byte Strength 
            {
                get => (byte)CellsByName["Strength"].Value;
                set => CellsByName["Strength"].Value = (byte)value;
            }
            

            // Def="u8 baseDex"
            /// <summary>
            /// Dexterity (u8)
            /// </summary>
            /// <remarks>
            /// Basic value of agility
            /// </remarks>
            public byte Dexterity 
            {
                get => (byte)CellsByName["Dexterity"].Value;
                set => CellsByName["Dexterity"].Value = (byte)value;
            }
            

            // Def="u8 baseMag"
            /// <summary>
            /// Intelligence (u8)
            /// </summary>
            /// <remarks>
            /// Basic value of magic power
            /// </remarks>
            public byte Intelligence 
            {
                get => (byte)CellsByName["Intelligence"].Value;
                set => CellsByName["Intelligence"].Value = (byte)value;
            }
            

            // Def="u8 baseFai"
            /// <summary>
            /// Faith (u8)
            /// </summary>
            /// <remarks>
            /// Basic value of faith
            /// </remarks>
            public byte Faith 
            {
                get => (byte)CellsByName["Faith"].Value;
                set => CellsByName["Faith"].Value = (byte)value;
            }
            

            // Def="u8 baseLuc"
            /// <summary>
            /// Arcane (u8)
            /// </summary>
            /// <remarks>
            /// Basic value of luck
            /// </remarks>
            public byte Arcane 
            {
                get => (byte)CellsByName["Arcane"].Value;
                set => CellsByName["Arcane"].Value = (byte)value;
            }
            

            // Def="u8 baseHeroPoint"
            /// <summary>
            /// Humanity (u8)
            /// </summary>
            /// <remarks>
            /// Basic value of human nature
            /// </remarks>
            public byte Humanity 
            {
                get => (byte)CellsByName["Humanity"].Value;
                set => CellsByName["Humanity"].Value = (byte)value;
            }
            

            // Def="u8 baseDurability"
            /// <summary>
            /// Vitality (u8)
            /// </summary>
            /// <remarks>
            /// Basic value of endurance
            /// </remarks>
            public byte Vitality 
            {
                get => (byte)CellsByName["Vitality"].Value;
                set => CellsByName["Vitality"].Value = (byte)value;
            }
            

            // Def="u8 itemNum_01"
            /// <summary>
            /// Equipped Item: Slot 1 Amount (u8)
            /// </summary>
            /// <remarks>
            /// Initial possession number of items 01
            /// </remarks>
            public byte EquippedItemSlot1Amount 
            {
                get => (byte)CellsByName["EquippedItemSlot1Amount"].Value;
                set => CellsByName["EquippedItemSlot1Amount"].Value = (byte)value;
            }
            

            // Def="u8 itemNum_02"
            /// <summary>
            /// Equipped Item: Slot 2 Amount (u8)
            /// </summary>
            /// <remarks>
            /// Initial possession number of items 02
            /// </remarks>
            public byte EquippedItemSlot2Amount 
            {
                get => (byte)CellsByName["EquippedItemSlot2Amount"].Value;
                set => CellsByName["EquippedItemSlot2Amount"].Value = (byte)value;
            }
            

            // Def="u8 itemNum_03"
            /// <summary>
            /// Equipped Item: Slot 3 Amount (u8)
            /// </summary>
            /// <remarks>
            /// Initial possession number of items 03
            /// </remarks>
            public byte EquippedItemSlot3Amount 
            {
                get => (byte)CellsByName["EquippedItemSlot3Amount"].Value;
                set => CellsByName["EquippedItemSlot3Amount"].Value = (byte)value;
            }
            

            // Def="u8 itemNum_04"
            /// <summary>
            /// Equipped Item: Slot 4 Amount (u8)
            /// </summary>
            /// <remarks>
            /// Initial possession number of items 04
            /// </remarks>
            public byte EquippedItemSlot4Amount 
            {
                get => (byte)CellsByName["EquippedItemSlot4Amount"].Value;
                set => CellsByName["EquippedItemSlot4Amount"].Value = (byte)value;
            }
            

            // Def="u8 itemNum_05"
            /// <summary>
            /// Equipped Item: Slot 5 Amount (u8)
            /// </summary>
            /// <remarks>
            /// Initial possession number of items 05
            /// </remarks>
            public byte EquippedItemSlot5Amount 
            {
                get => (byte)CellsByName["EquippedItemSlot5Amount"].Value;
                set => CellsByName["EquippedItemSlot5Amount"].Value = (byte)value;
            }
            

            // Def="u8 itemNum_06"
            /// <summary>
            /// Equipped Item: Slot 6 Amount (u8)
            /// </summary>
            /// <remarks>
            /// Initial possession number of items 06
            /// </remarks>
            public byte EquippedItemSlot6Amount 
            {
                get => (byte)CellsByName["EquippedItemSlot6Amount"].Value;
                set => CellsByName["EquippedItemSlot6Amount"].Value = (byte)value;
            }
            

            // Def="u8 itemNum_07"
            /// <summary>
            /// Equipped Item: Slot 7 Amount (u8)
            /// </summary>
            /// <remarks>
            /// Initial possession number of items 07
            /// </remarks>
            public byte EquippedItemSlot7Amount 
            {
                get => (byte)CellsByName["EquippedItemSlot7Amount"].Value;
                set => CellsByName["EquippedItemSlot7Amount"].Value = (byte)value;
            }
            

            // Def="u8 itemNum_08"
            /// <summary>
            /// Equipped Item: Slot 8 Amount (u8)
            /// </summary>
            /// <remarks>
            /// Initial possession number of items 08
            /// </remarks>
            public byte EquippedItemSlot8Amount 
            {
                get => (byte)CellsByName["EquippedItemSlot8Amount"].Value;
                set => CellsByName["EquippedItemSlot8Amount"].Value = (byte)value;
            }
            

            // Def="u8 itemNum_09"
            /// <summary>
            /// Equipped Item: Slot 9 Amount (u8)
            /// </summary>
            /// <remarks>
            /// Initial possession number of items 09
            /// </remarks>
            public byte EquippedItemSlot9Amount 
            {
                get => (byte)CellsByName["EquippedItemSlot9Amount"].Value;
                set => CellsByName["EquippedItemSlot9Amount"].Value = (byte)value;
            }
            

            // Def="u8 itemNum_10"
            /// <summary>
            /// Equipped Item: Slot 10 Amount (u8)
            /// </summary>
            /// <remarks>
            /// Initial possession number of items 10
            /// </remarks>
            public byte EquippedItemSlot10Amount 
            {
                get => (byte)CellsByName["EquippedItemSlot10Amount"].Value;
                set => CellsByName["EquippedItemSlot10Amount"].Value = (byte)value;
            }
            


            // Def="s8 gestureId0 = -1"
            /// <summary>
            /// Equipped Gesture: Slot 0 (s8)
            /// </summary>
            /// <remarks>
            /// Gesture 0th (0 if you want to play EzState gesture 0)
            /// </remarks>
            public sbyte EquippedGestureSlot0 
            {
                get => (sbyte)CellsByName["EquippedGestureSlot0"].Value;
                set => CellsByName["EquippedGestureSlot0"].Value = (sbyte)value;
            }
            

            // Def="s8 gestureId1 = -1"
            /// <summary>
            /// Equipped Gesture: Slot 1 (s8)
            /// </summary>
            /// <remarks>
            /// Gesture 1st (0 if you want to play EzState gesture 0)
            /// </remarks>
            public sbyte EquippedGestureSlot1 
            {
                get => (sbyte)CellsByName["EquippedGestureSlot1"].Value;
                set => CellsByName["EquippedGestureSlot1"].Value = (sbyte)value;
            }
            

            // Def="s8 gestureId2 = -1"
            /// <summary>
            /// Equipped Gesture: Slot 2 (s8)
            /// </summary>
            /// <remarks>
            /// Gesture 2nd (0 if you want to play EzState's gesture 0)
            /// </remarks>
            public sbyte EquippedGestureSlot2 
            {
                get => (sbyte)CellsByName["EquippedGestureSlot2"].Value;
                set => CellsByName["EquippedGestureSlot2"].Value = (sbyte)value;
            }
            

            // Def="s8 gestureId3 = -1"
            /// <summary>
            /// Equipped Gesture: Slot 3 (s8)
            /// </summary>
            /// <remarks>
            /// Gesture 3rd (0 if you want to play EzState gesture 0)
            /// </remarks>
            public sbyte EquippedGestureSlot3 
            {
                get => (sbyte)CellsByName["EquippedGestureSlot3"].Value;
                set => CellsByName["EquippedGestureSlot3"].Value = (sbyte)value;
            }
            

            // Def="s8 gestureId4 = -1"
            /// <summary>
            /// Equipped Gesture: Slot 4 (s8)
            /// </summary>
            /// <remarks>
            /// Gesture 4th (0 if you want to play EzState's gesture 0)
            /// </remarks>
            public sbyte EquippedGestureSlot4 
            {
                get => (sbyte)CellsByName["EquippedGestureSlot4"].Value;
                set => CellsByName["EquippedGestureSlot4"].Value = (sbyte)value;
            }
            

            // Def="s8 gestureId5 = -1"
            /// <summary>
            /// Equipped Gesture: Slot 5 (s8)
            /// </summary>
            /// <remarks>
            /// Gesture 5th (0 if you want to play EzState gesture 0)
            /// </remarks>
            public sbyte EquippedGestureSlot5 
            {
                get => (sbyte)CellsByName["EquippedGestureSlot5"].Value;
                set => CellsByName["EquippedGestureSlot5"].Value = (sbyte)value;
            }
            

            // Def="s8 gestureId6 = -1"
            /// <summary>
            /// Equipped Gesture: Slot 6 (s8)
            /// </summary>
            /// <remarks>
            /// Gesture 6th (0 if you want to play EzState gesture 0)
            /// </remarks>
            public sbyte EquippedGestureSlot6 
            {
                get => (sbyte)CellsByName["EquippedGestureSlot6"].Value;
                set => CellsByName["EquippedGestureSlot6"].Value = (sbyte)value;
            }
            

            // Def="u8 npcPlayerType"
            /// <summary>
            /// NPC Player - Type (u8)
            /// </summary>
            /// <remarks>
            /// NPC type used by NPC players. Not used by normal players.
            /// </remarks>
            public NpcType NPCPlayerType 
            {
                get => (NpcType)CellsByName["NPCPlayerType"].Value;
                set => CellsByName["NPCPlayerType"].Value = (byte)value;
            }
            

            // Def="s8 npcPlayerDrawType"
            /// <summary>
            /// NPC Player - Draw Type (s8)
            /// </summary>
            /// <remarks>
            /// Drawing type used by NPC players. Not used by normal players.
            /// </remarks>
            public NpcDrawType NPCPlayerDrawType 
            {
                get => (NpcDrawType)CellsByName["NPCPlayerDrawType"].Value;
                set => CellsByName["NPCPlayerDrawType"].Value = (sbyte)value;
            }
            

            // Def="u8 npcPlayerSex"
            /// <summary>
            /// NPC Player - Sex (u8)
            /// </summary>
            /// <remarks>
            /// The gender used by NPC players. It is not reflected to normal players.
            /// </remarks>
            public CharacterInitSex NPCPlayerSex 
            {
                get => (CharacterInitSex)CellsByName["NPCPlayerSex"].Value;
                set => CellsByName["NPCPlayerSex"].Value = (byte)value;
            }
            

            // Def="u8 vowType:4"
            /// <summary>
            /// Vow Type (u8)
            /// </summary>
            /// <remarks>
            /// Pledge type (None: 0)
            /// </remarks>
            public VowType VowType 
            {
                get => (VowType)CellsByName["VowType"].Value;
                set => CellsByName["VowType"].Value = (byte)value;
            }
            

            // Def="u8 isSyncTarget:1"
            /// <summary>
            /// Is Sync Target (u8)
            /// </summary>
            /// <remarks>
            /// Is it a send / receive target (for copy NPCs)?
            /// </remarks>
            public BoolCirclecrossType IsSyncTarget 
            {
                get => (BoolCirclecrossType)CellsByName["IsSyncTarget"].Value;
                set => CellsByName["IsSyncTarget"].Value = (byte)value;
            }
            



            // Def="u8 wepParamType_Right1"
            /// <summary>
            /// Weapon Param Type - Right Primary (u8)
            /// </summary>
            /// <remarks>
            /// Right-handed weapon slot 1 parameter reference
            /// </remarks>
            public CharaInitWepType WeaponParamTypeRightPrimary 
            {
                get => (CharaInitWepType)CellsByName["WeaponParamTypeRightPrimary"].Value;
                set => CellsByName["WeaponParamTypeRightPrimary"].Value = (byte)value;
            }
            

            // Def="u8 wepParamType_Right2"
            /// <summary>
            /// Weapon Param Type - Right Secondary (u8)
            /// </summary>
            /// <remarks>
            /// Right-handed weapon slot 2 parameter reference
            /// </remarks>
            public CharaInitWepType WeaponParamTypeRightSecondary 
            {
                get => (CharaInitWepType)CellsByName["WeaponParamTypeRightSecondary"].Value;
                set => CellsByName["WeaponParamTypeRightSecondary"].Value = (byte)value;
            }
            

            // Def="u8 wepParamType_Right3"
            /// <summary>
            /// Weapon Param Type - Right Tertiary (u8)
            /// </summary>
            /// <remarks>
            /// Right-handed weapon slot 3 parameter reference
            /// </remarks>
            public CharaInitWepType WeaponParamTypeRightTertiary 
            {
                get => (CharaInitWepType)CellsByName["WeaponParamTypeRightTertiary"].Value;
                set => CellsByName["WeaponParamTypeRightTertiary"].Value = (byte)value;
            }
            

            // Def="u8 wepParamType_Left1"
            /// <summary>
            /// Weapon Param Type - Left Primary (u8)
            /// </summary>
            /// <remarks>
            /// Parameter reference for left-handed weapon slot 1
            /// </remarks>
            public CharaInitWepType WeaponParamTypeLeftPrimary 
            {
                get => (CharaInitWepType)CellsByName["WeaponParamTypeLeftPrimary"].Value;
                set => CellsByName["WeaponParamTypeLeftPrimary"].Value = (byte)value;
            }
            

            // Def="u8 wepParamType_Left2"
            /// <summary>
            /// Weapon Param Type - Left Secondary (u8)
            /// </summary>
            /// <remarks>
            /// Parameter reference for left-handed weapon slot 2
            /// </remarks>
            public CharaInitWepType WeaponParamTypeLeftSecondary 
            {
                get => (CharaInitWepType)CellsByName["WeaponParamTypeLeftSecondary"].Value;
                set => CellsByName["WeaponParamTypeLeftSecondary"].Value = (byte)value;
            }
            

            // Def="u8 wepParamType_Left3"
            /// <summary>
            /// Weapon Param Type - Left Tertiary (u8)
            /// </summary>
            /// <remarks>
            /// Parameter reference for left-handed weapon slot 3
            /// </remarks>
            public CharaInitWepType WeaponParamTypeLeftTertiary 
            {
                get => (CharaInitWepType)CellsByName["WeaponParamTypeLeftTertiary"].Value;
                set => CellsByName["WeaponParamTypeLeftTertiary"].Value = (byte)value;
            }
            


            // Def="s32 equip_Subwep_Right3 = -1"
            /// <summary>
            /// Equipped Weapon: Right Tertiary (s32)
            /// </summary>
            /// <remarks>
            /// Weapon ID of equipment parameter (right hand slot 3)
            /// </remarks>
            public int EquippedWeaponRightTertiary 
            {
                get => (int)CellsByName["EquippedWeaponRightTertiary"].Value;
                set => CellsByName["EquippedWeaponRightTertiary"].Value = (int)value;
            }
            

            // Def="s32 equip_Subwep_Left3 = -1"
            /// <summary>
            /// Equipped Weapon: Left Tertiary (s32)
            /// </summary>
            /// <remarks>
            /// Weapon ID of equipment parameter (left hand slot 3)
            /// </remarks>
            public int EquippedWeaponLeftTertiary 
            {
                get => (int)CellsByName["EquippedWeaponLeftTertiary"].Value;
                set => CellsByName["EquippedWeaponLeftTertiary"].Value = (int)value;
            }
            


            // Def="s32 secondaryItem_01 = -1"
            /// <summary>
            /// Stored Item: Slot 1 (s32)
            /// </summary>
            /// <remarks>
            /// Item ID 01 of the second shortcut initial possession
            /// </remarks>
            public int StoredItemSlot1 
            {
                get => (int)CellsByName["StoredItemSlot1"].Value;
                set => CellsByName["StoredItemSlot1"].Value = (int)value;
            }
            

            // Def="s32 secondaryItem_02 = -1"
            /// <summary>
            /// Stored Item: Slot 2 (s32)
            /// </summary>
            /// <remarks>
            /// Item ID 02 of the second shortcut initial possession
            /// </remarks>
            public int StoredItemSlot2 
            {
                get => (int)CellsByName["StoredItemSlot2"].Value;
                set => CellsByName["StoredItemSlot2"].Value = (int)value;
            }
            

            // Def="s32 secondaryItem_03 = -1"
            /// <summary>
            /// Stored Item: Slot 3 (s32)
            /// </summary>
            /// <remarks>
            /// Item ID 03 of the second shortcut initial possession
            /// </remarks>
            public int StoredItemSlot3 
            {
                get => (int)CellsByName["StoredItemSlot3"].Value;
                set => CellsByName["StoredItemSlot3"].Value = (int)value;
            }
            

            // Def="s32 secondaryItem_04 = -1"
            /// <summary>
            /// Stored Item: Slot 4 (s32)
            /// </summary>
            /// <remarks>
            /// Item ID 04 of the second shortcut initial possession
            /// </remarks>
            public int StoredItemSlot4 
            {
                get => (int)CellsByName["StoredItemSlot4"].Value;
                set => CellsByName["StoredItemSlot4"].Value = (int)value;
            }
            

            // Def="s32 secondaryItem_05 = -1"
            /// <summary>
            /// Stored Item: Slot 5 (s32)
            /// </summary>
            /// <remarks>
            /// Item ID 05 of the second shortcut initial possession
            /// </remarks>
            public int StoredItemSlot5 
            {
                get => (int)CellsByName["StoredItemSlot5"].Value;
                set => CellsByName["StoredItemSlot5"].Value = (int)value;
            }
            

            // Def="s32 secondaryItem_06 = -1"
            /// <summary>
            /// Stored Item: Slot 6 (s32)
            /// </summary>
            /// <remarks>
            /// Item ID 06 of the second shortcut initial possession
            /// </remarks>
            public int StoredItemSlot6 
            {
                get => (int)CellsByName["StoredItemSlot6"].Value;
                set => CellsByName["StoredItemSlot6"].Value = (int)value;
            }
            

            // Def="u8 secondaryItemNum_01"
            /// <summary>
            /// Stored Item: Slot 1 Count (u8)
            /// </summary>
            /// <remarks>
            /// 2nd Shortcut Initial possession number of items 01
            /// </remarks>
            public byte StoredItemSlot1Count 
            {
                get => (byte)CellsByName["StoredItemSlot1Count"].Value;
                set => CellsByName["StoredItemSlot1Count"].Value = (byte)value;
            }
            

            // Def="u8 secondaryItemNum_02"
            /// <summary>
            /// Stored Item: Slot 2 Count (u8)
            /// </summary>
            /// <remarks>
            /// 2nd Shortcut Initial possession number of items 02
            /// </remarks>
            public byte StoredItemSlot2Count 
            {
                get => (byte)CellsByName["StoredItemSlot2Count"].Value;
                set => CellsByName["StoredItemSlot2Count"].Value = (byte)value;
            }
            

            // Def="u8 secondaryItemNum_03"
            /// <summary>
            /// Stored Item: Slot 3 Count (u8)
            /// </summary>
            /// <remarks>
            /// 2nd Shortcut Initial possession number of items 03
            /// </remarks>
            public byte StoredItemSlot3Count 
            {
                get => (byte)CellsByName["StoredItemSlot3Count"].Value;
                set => CellsByName["StoredItemSlot3Count"].Value = (byte)value;
            }
            

            // Def="u8 secondaryItemNum_04"
            /// <summary>
            /// Stored Item: Slot 4 Count (u8)
            /// </summary>
            /// <remarks>
            /// 2nd Shortcut Initial possession number of items 04
            /// </remarks>
            public byte StoredItemSlot4Count 
            {
                get => (byte)CellsByName["StoredItemSlot4Count"].Value;
                set => CellsByName["StoredItemSlot4Count"].Value = (byte)value;
            }
            

            // Def="u8 secondaryItemNum_05"
            /// <summary>
            /// Stored Item: Slot 5 Count (u8)
            /// </summary>
            /// <remarks>
            /// 2nd Shortcut Initial possession number of items 05
            /// </remarks>
            public byte StoredItemSlot5Count 
            {
                get => (byte)CellsByName["StoredItemSlot5Count"].Value;
                set => CellsByName["StoredItemSlot5Count"].Value = (byte)value;
            }
            

            // Def="u8 secondaryItemNum_06"
            /// <summary>
            /// Stored Item: Slot 6 Count (u8)
            /// </summary>
            /// <remarks>
            /// 2nd Shortcut Initial possession number of items 06
            /// </remarks>
            public byte StoredItemSlot6Count 
            {
                get => (byte)CellsByName["StoredItemSlot6Count"].Value;
                set => CellsByName["StoredItemSlot6Count"].Value = (byte)value;
            }
            

            // Def="s8 HpEstMax = -1"
            /// <summary>
            /// HP Flask - Max Possession Limit (s8)
            /// </summary>
            /// <remarks>
            /// HP Est Bottle Possession Limit
            /// </remarks>
            public sbyte HPFlaskMaxPossessionLimit 
            {
                get => (sbyte)CellsByName["HPFlaskMaxPossessionLimit"].Value;
                set => CellsByName["HPFlaskMaxPossessionLimit"].Value = (sbyte)value;
            }
            

            // Def="s8 MpEstMax = -1"
            /// <summary>
            /// FP Flask - Max Possession Limit (s8)
            /// </summary>
            /// <remarks>
            /// MP Est Bottle Possession Limit
            /// </remarks>
            public sbyte FPFlaskMaxPossessionLimit 
            {
                get => (sbyte)CellsByName["FPFlaskMaxPossessionLimit"].Value;
                set => CellsByName["FPFlaskMaxPossessionLimit"].Value = (sbyte)value;
            }
            


            // Def="u8 voiceType"
            /// <summary>
            /// Voice Type (u8)
            /// </summary>
            /// <remarks>
            /// Voice type
            /// </remarks>
            public byte VoiceType 
            {
                get => (byte)CellsByName["VoiceType"].Value;
                set => CellsByName["VoiceType"].Value = (byte)value;
            }
            

            // Def="dummy8 reserve[6]"
            /// <summary>
            /// Reserved area (dummy8)
            /// </summary>
            /// <remarks>
            /// Reserved area
            /// </remarks>
            public object ReservedArea 
            {
                get => (object)CellsByName["ReservedArea"].Value;
                set => CellsByName["ReservedArea"].Value = (object)value;
            }
            
                }
            }
            
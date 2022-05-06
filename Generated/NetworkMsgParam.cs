
            namespace StronglyTypedParams
            {
                public class NetworkMsgParam : ParamRow
                {
                    public NetworkMsgParam() : base()
                    {
                    }
            

            // Def="u16 priority"
            /// <summary>
            /// Priority (u16)
            /// </summary>
            /// <remarks>
            /// priority
            /// </remarks>
            public ushort Priority 
            {
                get => (ushort)CellsByName["Priority"].Value;
                set => CellsByName["Priority"].Value = value;
            }
            

            // Def="u8 forcePlay"
            /// <summary>
            /// Force Play (u8)
            /// </summary>
            /// <remarks>
            /// Forced interrupt
            /// </remarks>
            public byte ForcePlay 
            {
                get => (byte)CellsByName["ForcePlay"].Value;
                set => CellsByName["ForcePlay"].Value = value;
            }
            

            // Def="dummy8 pad1[1]"
            /// <summary>
            /// reserve (dummy8)
            /// </summary>
            /// <remarks>
            /// reserve
            /// </remarks>
            public object Reserve 
            {
                get => (object)CellsByName["Reserve"].Value;
                set => CellsByName["Reserve"].Value = value;
            }
            

            // Def="s32 normalWhite = -1"
            /// <summary>
            /// White Phantom - Normal (s32)
            /// </summary>
            /// <remarks>
            /// White spirit (white sign)
            /// </remarks>
            public int WhitePhantomNormal 
            {
                get => (int)CellsByName["WhitePhantomNormal"].Value;
                set => CellsByName["WhitePhantomNormal"].Value = value;
            }
            

            // Def="s32 umbasaWhite = -1"
            /// <summary>
            /// White Phantom - Gold (s32)
            /// </summary>
            /// <remarks>
            /// Sun spirit (white sign)
            /// </remarks>
            public int WhitePhantomGold 
            {
                get => (int)CellsByName["WhitePhantomGold"].Value;
                set => CellsByName["WhitePhantomGold"].Value = value;
            }
            

            // Def="s32 berserkerWhite = -1"
            /// <summary>
            /// White Phantom - Berseker (s32)
            /// </summary>
            /// <remarks>
            /// Berserker spirit (white sign)
            /// </remarks>
            public int WhitePhantomBerseker 
            {
                get => (int)CellsByName["WhitePhantomBerseker"].Value;
                set => CellsByName["WhitePhantomBerseker"].Value = value;
            }
            

            // Def="s32 sinnerHeroWhite = -1"
            /// <summary>
            /// White Phantom - Sinner Hero (s32)
            /// </summary>
            /// <remarks>
            /// Sinner Hero Spirit (white sign)
            /// </remarks>
            public int WhitePhantomSinnerHero 
            {
                get => (int)CellsByName["WhitePhantomSinnerHero"].Value;
                set => CellsByName["WhitePhantomSinnerHero"].Value = value;
            }
            

            // Def="s32 normalBlack = -1"
            /// <summary>
            /// Black Phantom - Normal (s32)
            /// </summary>
            /// <remarks>
            /// Dark spirit (red sign)
            /// </remarks>
            public int BlackPhantomNormal 
            {
                get => (int)CellsByName["BlackPhantomNormal"].Value;
                set => CellsByName["BlackPhantomNormal"].Value = value;
            }
            

            // Def="s32 umbasaBlack = -1"
            /// <summary>
            /// Black Phantom - Gold (s32)
            /// </summary>
            /// <remarks>
            /// Sun spirit (red sign)
            /// </remarks>
            public int BlackPhantomGold 
            {
                get => (int)CellsByName["BlackPhantomGold"].Value;
                set => CellsByName["BlackPhantomGold"].Value = value;
            }
            

            // Def="s32 berserkerBlack = -1"
            /// <summary>
            /// Black Phantom - Berserker (s32)
            /// </summary>
            /// <remarks>
            /// Berserker spirit (red sign)
            /// </remarks>
            public int BlackPhantomBerserker 
            {
                get => (int)CellsByName["BlackPhantomBerserker"].Value;
                set => CellsByName["BlackPhantomBerserker"].Value = value;
            }
            

            // Def="s32 forceJoinBlack = -1"
            /// <summary>
            /// Invasion - Black Phantom - Normal (s32)
            /// </summary>
            /// <remarks>
            /// Intrusion_A
            /// </remarks>
            public int InvasionBlackPhantomNormal 
            {
                get => (int)CellsByName["InvasionBlackPhantomNormal"].Value;
                set => CellsByName["InvasionBlackPhantomNormal"].Value = value;
            }
            

            // Def="s32 forceJoinUmbasaBlack = -1"
            /// <summary>
            /// Invasion - Black Phantom - Gold (s32)
            /// </summary>
            /// <remarks>
            /// Sun spirit (intrusion)
            /// </remarks>
            public int InvasionBlackPhantomGold 
            {
                get => (int)CellsByName["InvasionBlackPhantomGold"].Value;
                set => CellsByName["InvasionBlackPhantomGold"].Value = value;
            }
            

            // Def="s32 forceJoinBerserkerBlack = -1"
            /// <summary>
            /// Invasion - Black Phantom - Berserker (s32)
            /// </summary>
            /// <remarks>
            /// Berserker spirit (intrusion)
            /// </remarks>
            public int InvasionBlackPhantomBerserker 
            {
                get => (int)CellsByName["InvasionBlackPhantomBerserker"].Value;
                set => CellsByName["InvasionBlackPhantomBerserker"].Value = value;
            }
            

            // Def="s32 sinnerHunterVisitor = -1"
            /// <summary>
            /// Sinner Hunter Visitor (s32)
            /// </summary>
            /// <remarks>
            /// Sinner hunting spirit (visit)
            /// </remarks>
            public int SinnerHunterVisitor 
            {
                get => (int)CellsByName["SinnerHunterVisitor"].Value;
                set => CellsByName["SinnerHunterVisitor"].Value = value;
            }
            

            // Def="s32 redHunterVisitor = -1"
            /// <summary>
            /// Red Hunter 1 Visitor (s32)
            /// </summary>
            /// <remarks>
            /// Red Scare Spirit (Visit)
            /// </remarks>
            public int RedHunter1Visitor 
            {
                get => (int)CellsByName["RedHunter1Visitor"].Value;
                set => CellsByName["RedHunter1Visitor"].Value = value;
            }
            

            // Def="s32 guardianOfBossVisitor = -1"
            /// <summary>
            /// Boss Guardian Visitor (s32)
            /// </summary>
            /// <remarks>
            /// Boss guardian spirit (visit)
            /// </remarks>
            public int BossGuardianVisitor 
            {
                get => (int)CellsByName["BossGuardianVisitor"].Value;
                set => CellsByName["BossGuardianVisitor"].Value = value;
            }
            

            // Def="s32 guardianOfForestMapVisitor = -1"
            /// <summary>
            /// Forest Hunter Visitor (s32)
            /// </summary>
            /// <remarks>
            /// Map Guardian Spirit_Forest (Visit)
            /// </remarks>
            public int ForestHunterVisitor 
            {
                get => (int)CellsByName["ForestHunterVisitor"].Value;
                set => CellsByName["ForestHunterVisitor"].Value = value;
            }
            

            // Def="s32 guardianOfAnolisVisitor = -1"
            /// <summary>
            /// Darkmoon Blade Visitor (s32)
            /// </summary>
            /// <remarks>
            /// Map Guardian_Anor (Visit)
            /// </remarks>
            public int DarkmoonBladeVisitor 
            {
                get => (int)CellsByName["DarkmoonBladeVisitor"].Value;
                set => CellsByName["DarkmoonBladeVisitor"].Value = value;
            }
            

            // Def="s32 rosaliaBlack = -1"
            /// <summary>
            /// Black Phantom - Rosalia (s32)
            /// </summary>
            /// <remarks>
            /// Rosalia spirit (red sign)
            /// </remarks>
            public int BlackPhantomRosalia 
            {
                get => (int)CellsByName["BlackPhantomRosalia"].Value;
                set => CellsByName["BlackPhantomRosalia"].Value = value;
            }
            

            // Def="s32 forceJoinRosaliaBlack = -1"
            /// <summary>
            /// Invasion - Black Phantom - Rosalia (s32)
            /// </summary>
            /// <remarks>
            /// Rosalia spirit (intrusion)
            /// </remarks>
            public int InvasionBlackPhantomRosalia 
            {
                get => (int)CellsByName["InvasionBlackPhantomRosalia"].Value;
                set => CellsByName["InvasionBlackPhantomRosalia"].Value = value;
            }
            

            // Def="s32 redHunterVisitor2 = -1"
            /// <summary>
            /// Red Hunter 2 Visitor (s32)
            /// </summary>
            /// <remarks>
            /// Red Scare Spirit 2 (Visit)
            /// </remarks>
            public int RedHunter2Visitor 
            {
                get => (int)CellsByName["RedHunter2Visitor"].Value;
                set => CellsByName["RedHunter2Visitor"].Value = value;
            }
            

            // Def="s32 npc1 = -1"
            /// <summary>
            /// NPC [1] (s32)
            /// </summary>
            /// <remarks>
            /// NPC Pseudo Multi 1
            /// </remarks>
            public int NPC1 
            {
                get => (int)CellsByName["NPC1"].Value;
                set => CellsByName["NPC1"].Value = value;
            }
            

            // Def="s32 npc2 = -1"
            /// <summary>
            /// NPC [2] (s32)
            /// </summary>
            /// <remarks>
            /// NPC Pseudo Multi 2
            /// </remarks>
            public int NPC2 
            {
                get => (int)CellsByName["NPC2"].Value;
                set => CellsByName["NPC2"].Value = value;
            }
            

            // Def="s32 npc3 = -1"
            /// <summary>
            /// NPC [3] (s32)
            /// </summary>
            /// <remarks>
            /// NPC Pseudo Multi 3
            /// </remarks>
            public int NPC3 
            {
                get => (int)CellsByName["NPC3"].Value;
                set => CellsByName["NPC3"].Value = value;
            }
            

            // Def="s32 npc4 = -1"
            /// <summary>
            /// NPC [4] (s32)
            /// </summary>
            /// <remarks>
            /// NPC Pseudo Multi 4
            /// </remarks>
            public int NPC4 
            {
                get => (int)CellsByName["NPC4"].Value;
                set => CellsByName["NPC4"].Value = value;
            }
            

            // Def="s32 battleRoyal = -1"
            /// <summary>
            /// Arena (s32)
            /// </summary>
            /// <remarks>
            /// Battle royale
            /// </remarks>
            public int Arena 
            {
                get => (int)CellsByName["Arena"].Value;
                set => CellsByName["Arena"].Value = value;
            }
            

            // Def="s32 npc5 = -1"
            /// <summary>
            /// NPC [5] (s32)
            /// </summary>
            /// <remarks>
            /// NPC Pseudo Multi 5
            /// </remarks>
            public int NPC5 
            {
                get => (int)CellsByName["NPC5"].Value;
                set => CellsByName["NPC5"].Value = value;
            }
            

            // Def="s32 npc6 = -1"
            /// <summary>
            /// NPC [6] (s32)
            /// </summary>
            /// <remarks>
            /// NPC Pseudo Multi 6
            /// </remarks>
            public int NPC6 
            {
                get => (int)CellsByName["NPC6"].Value;
                set => CellsByName["NPC6"].Value = value;
            }
            

            // Def="s32 npc7 = -1"
            /// <summary>
            /// NPC [7] (s32)
            /// </summary>
            /// <remarks>
            /// NPC Pseudo Multi 7
            /// </remarks>
            public int NPC7 
            {
                get => (int)CellsByName["NPC7"].Value;
                set => CellsByName["NPC7"].Value = value;
            }
            

            // Def="s32 npc8 = -1"
            /// <summary>
            /// NPC [8] (s32)
            /// </summary>
            /// <remarks>
            /// NPC Pseudo Multi 8
            /// </remarks>
            public int NPC8 
            {
                get => (int)CellsByName["NPC8"].Value;
                set => CellsByName["NPC8"].Value = value;
            }
            

            // Def="s32 npc9 = -1"
            /// <summary>
            /// NPC [9] (s32)
            /// </summary>
            /// <remarks>
            /// NPC Pseudo Multi 9
            /// </remarks>
            public int NPC9 
            {
                get => (int)CellsByName["NPC9"].Value;
                set => CellsByName["NPC9"].Value = value;
            }
            

            // Def="s32 npc10 = -1"
            /// <summary>
            /// NPC [10] (s32)
            /// </summary>
            /// <remarks>
            /// NPC Pseudo Multi 10
            /// </remarks>
            public int NPC10 
            {
                get => (int)CellsByName["NPC10"].Value;
                set => CellsByName["NPC10"].Value = value;
            }
            

            // Def="s32 npc11 = -1"
            /// <summary>
            /// NPC [11] (s32)
            /// </summary>
            /// <remarks>
            /// NPC Pseudo Multi 11
            /// </remarks>
            public int NPC11 
            {
                get => (int)CellsByName["NPC11"].Value;
                set => CellsByName["NPC11"].Value = value;
            }
            

            // Def="s32 npc12 = -1"
            /// <summary>
            /// NPC [12] (s32)
            /// </summary>
            /// <remarks>
            /// NPC Pseudo Multi 12
            /// </remarks>
            public int NPC12 
            {
                get => (int)CellsByName["NPC12"].Value;
                set => CellsByName["NPC12"].Value = value;
            }
            

            // Def="s32 npc13 = -1"
            /// <summary>
            /// NPC [13] (s32)
            /// </summary>
            /// <remarks>
            /// NPC Pseudo Multi 13
            /// </remarks>
            public int NPC13 
            {
                get => (int)CellsByName["NPC13"].Value;
                set => CellsByName["NPC13"].Value = value;
            }
            

            // Def="s32 npc14 = -1"
            /// <summary>
            /// NPC [14] (s32)
            /// </summary>
            /// <remarks>
            /// NPC Pseudo Multi 14
            /// </remarks>
            public int NPC14 
            {
                get => (int)CellsByName["NPC14"].Value;
                set => CellsByName["NPC14"].Value = value;
            }
            

            // Def="s32 npc15 = -1"
            /// <summary>
            /// NPC [15] (s32)
            /// </summary>
            /// <remarks>
            /// NPC Pseudo Multi 15
            /// </remarks>
            public int NPC15 
            {
                get => (int)CellsByName["NPC15"].Value;
                set => CellsByName["NPC15"].Value = value;
            }
            

            // Def="s32 npc16 = -1"
            /// <summary>
            /// NPC [16] (s32)
            /// </summary>
            /// <remarks>
            /// NPC Pseudo Multi 16
            /// </remarks>
            public int NPC16 
            {
                get => (int)CellsByName["NPC16"].Value;
                set => CellsByName["NPC16"].Value = value;
            }
            

            // Def="s32 forceJoinBlack_B = -1"
            /// <summary>
            /// Invasion - Black Phantom - B (s32)
            /// </summary>
            /// <remarks>
            /// Intrusion_B
            /// </remarks>
            public int InvasionBlackPhantomB 
            {
                get => (int)CellsByName["InvasionBlackPhantomB"].Value;
                set => CellsByName["InvasionBlackPhantomB"].Value = value;
            }
            

            // Def="s32 normalWhite_Npc = -1"
            /// <summary>
            /// NPC - White Phantom (s32)
            /// </summary>
            /// <remarks>
            /// White spirit (white sign) for NPCs
            /// </remarks>
            public int NPCWhitePhantom 
            {
                get => (int)CellsByName["NPCWhitePhantom"].Value;
                set => CellsByName["NPCWhitePhantom"].Value = value;
            }
            

            // Def="s32 forceJoinBlack_Npc = -1"
            /// <summary>
            /// NPC - Black Phantom - Invasion (s32)
            /// </summary>
            /// <remarks>
            /// For intrusion_A_NPCs
            /// </remarks>
            public int NPCBlackPhantomInvasion 
            {
                get => (int)CellsByName["NPCBlackPhantomInvasion"].Value;
                set => CellsByName["NPCBlackPhantomInvasion"].Value = value;
            }
            

            // Def="s32 forceJoinBlack_B_Npc = -1"
            /// <summary>
            /// NPC - Black Phantom B - Invasion (s32)
            /// </summary>
            /// <remarks>
            /// For intrusion_B_NPCs
            /// </remarks>
            public int NPCBlackPhantomBInvasion 
            {
                get => (int)CellsByName["NPCBlackPhantomBInvasion"].Value;
                set => CellsByName["NPCBlackPhantomBInvasion"].Value = value;
            }
            

            // Def="s32 forceJoinBlack_C_Npc = -1"
            /// <summary>
            /// NPC - Black Phantom C - Invasion (s32)
            /// </summary>
            /// <remarks>
            /// For intrusion_C_NPCs
            /// </remarks>
            public int NPCBlackPhantomCInvasion 
            {
                get => (int)CellsByName["NPCBlackPhantomCInvasion"].Value;
                set => CellsByName["NPCBlackPhantomCInvasion"].Value = value;
            }
            

                }
            }
            
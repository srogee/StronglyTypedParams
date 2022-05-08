
            namespace StronglyTypedParams
            {
                // MULTI_ESTUS_FLASK_BONUS_PARAM_ST
                public class MultiEstusFlaskBonusParam : ParamRow
                {
                    public MultiEstusFlaskBonusParam() : base()
                    {
                    }
            

            // Def="u8 host"
            /// <summary>
            /// Flask Recovery - Host (u8)
            /// </summary>
            /// <remarks>
            /// Number of host est recovery
            /// </remarks>
            public byte FlaskRecoveryHost 
            {
                get => (byte)CellsByName["FlaskRecoveryHost"].Value;
                set => CellsByName["FlaskRecoveryHost"].Value = (byte)value;
            }
            

            // Def="u8 WhiteGhost_None"
            /// <summary>
            /// Flask Recovery - White Phantom - None (u8)
            /// </summary>
            /// <remarks>
            /// Number of white spirits recovering from the cooperation sign
            /// </remarks>
            public byte FlaskRecoveryWhitePhantomNone 
            {
                get => (byte)CellsByName["FlaskRecoveryWhitePhantomNone"].Value;
                set => CellsByName["FlaskRecoveryWhitePhantomNone"].Value = (byte)value;
            }
            

            // Def="u8 WhiteGhost_Umbasa"
            /// <summary>
            /// Flask Recovery - White Phantom - Gold (u8)
            /// </summary>
            /// <remarks>
            /// Number of est recovery of gold spirits of cooperation sign
            /// </remarks>
            public byte FlaskRecoveryWhitePhantomGold 
            {
                get => (byte)CellsByName["FlaskRecoveryWhitePhantomGold"].Value;
                set => CellsByName["FlaskRecoveryWhitePhantomGold"].Value = (byte)value;
            }
            

            // Def="u8 WhiteGhost_Berserker"
            /// <summary>
            /// Flask Recovery - White Phantom - Berserker (u8)
            /// </summary>
            /// <remarks>
            /// Number of recovery of white Berserker's est of cooperation sign
            /// </remarks>
            public byte FlaskRecoveryWhitePhantomBerserker 
            {
                get => (byte)CellsByName["FlaskRecoveryWhitePhantomBerserker"].Value;
                set => CellsByName["FlaskRecoveryWhitePhantomBerserker"].Value = (byte)value;
            }
            

            // Def="u8 BlackGhost_None_Sign"
            /// <summary>
            /// Flask Recovery - Black Phantom - None (u8)
            /// </summary>
            /// <remarks>
            /// Number of est recovery of red spirits of hostile sign
            /// </remarks>
            public byte FlaskRecoveryBlackPhantomNone 
            {
                get => (byte)CellsByName["FlaskRecoveryBlackPhantomNone"].Value;
                set => CellsByName["FlaskRecoveryBlackPhantomNone"].Value = (byte)value;
            }
            

            // Def="u8 BlackGhost_Umbasa_Sign"
            /// <summary>
            /// Flask Recovery - Black Phantom - Gold (u8)
            /// </summary>
            /// <remarks>
            /// Number of est recovery of red gold spirit of hostile sign
            /// </remarks>
            public byte FlaskRecoveryBlackPhantomGold 
            {
                get => (byte)CellsByName["FlaskRecoveryBlackPhantomGold"].Value;
                set => CellsByName["FlaskRecoveryBlackPhantomGold"].Value = (byte)value;
            }
            

            // Def="u8 BlackGhost_Berserker_Sign"
            /// <summary>
            /// Flask Recovery - Black Phantom - Berserker (u8)
            /// </summary>
            /// <remarks>
            /// Number of est recovery of red Berserker of hostile sign
            /// </remarks>
            public byte FlaskRecoveryBlackPhantomBerserker 
            {
                get => (byte)CellsByName["FlaskRecoveryBlackPhantomBerserker"].Value;
                set => CellsByName["FlaskRecoveryBlackPhantomBerserker"].Value = (byte)value;
            }
            

            // Def="u8 BlackGhost_None_Invade"
            /// <summary>
            /// Flask Recovery - Black Phantom - None - Invasion (u8)
            /// </summary>
            /// <remarks>
            /// Number of intrusion est recovery
            /// </remarks>
            public byte FlaskRecoveryBlackPhantomNoneInvasion 
            {
                get => (byte)CellsByName["FlaskRecoveryBlackPhantomNoneInvasion"].Value;
                set => CellsByName["FlaskRecoveryBlackPhantomNoneInvasion"].Value = (byte)value;
            }
            

            // Def="u8 BlackGhost_Umbasa_Invade"
            /// <summary>
            /// Flask Recovery - Black Phantom - Gold - Invasion (u8)
            /// </summary>
            /// <remarks>
            /// Number of est recovery of red gold spirits of invading orbs
            /// </remarks>
            public byte FlaskRecoveryBlackPhantomGoldInvasion 
            {
                get => (byte)CellsByName["FlaskRecoveryBlackPhantomGoldInvasion"].Value;
                set => CellsByName["FlaskRecoveryBlackPhantomGoldInvasion"].Value = (byte)value;
            }
            

            // Def="u8 BlackGhost_Berserker_Invade"
            /// <summary>
            /// Flask Recovery - Black Phantom - Berserker - Invasion (u8)
            /// </summary>
            /// <remarks>
            /// Invasion Orb Red Berserker Est Recovery Number
            /// </remarks>
            public byte FlaskRecoveryBlackPhantomBerserkerInvasion 
            {
                get => (byte)CellsByName["FlaskRecoveryBlackPhantomBerserkerInvasion"].Value;
                set => CellsByName["FlaskRecoveryBlackPhantomBerserkerInvasion"].Value = (byte)value;
            }
            

            // Def="u8 RedHunter1"
            /// <summary>
            /// Flask Recovery - Red Hunter [1] (u8)
            /// </summary>
            /// <remarks>
            /// Number of rescue guests' est recovery
            /// </remarks>
            public byte FlaskRecoveryRedHunter1 
            {
                get => (byte)CellsByName["FlaskRecoveryRedHunter1"].Value;
                set => CellsByName["FlaskRecoveryRedHunter1"].Value = (byte)value;
            }
            

            // Def="u8 RedHunter2"
            /// <summary>
            /// Flask Recovery - Red Hunter [2] (u8)
            /// </summary>
            /// <remarks>
            /// Number of est recovery of Red Scare Spirit 2
            /// </remarks>
            public byte FlaskRecoveryRedHunter2 
            {
                get => (byte)CellsByName["FlaskRecoveryRedHunter2"].Value;
                set => CellsByName["FlaskRecoveryRedHunter2"].Value = (byte)value;
            }
            

            // Def="u8 GuardianOfForest"
            /// <summary>
            /// Flask Recovery - Forest Guardian (u8)
            /// </summary>
            /// <remarks>
            /// Map guardian spirit (forest) est recovery number
            /// </remarks>
            public byte FlaskRecoveryForestGuardian 
            {
                get => (byte)CellsByName["FlaskRecoveryForestGuardian"].Value;
                set => CellsByName["FlaskRecoveryForestGuardian"].Value = (byte)value;
            }
            

            // Def="u8 GuardianOfAnor"
            /// <summary>
            /// Flask Recovery - Darkmoon Blade (u8)
            /// </summary>
            /// <remarks>
            /// Map Guardian Spirit (Anor) Est Recovery Number
            /// </remarks>
            public byte FlaskRecoveryDarkmoonBlade 
            {
                get => (byte)CellsByName["FlaskRecoveryDarkmoonBlade"].Value;
                set => CellsByName["FlaskRecoveryDarkmoonBlade"].Value = (byte)value;
            }
            

            // Def="u8 BattleRoyal"
            /// <summary>
            /// Flask Recovery - Arena (u8)
            /// </summary>
            /// <remarks>
            /// Number of est recovery in the arena
            /// </remarks>
            public byte FlaskRecoveryArena 
            {
                get => (byte)CellsByName["FlaskRecoveryArena"].Value;
                set => CellsByName["FlaskRecoveryArena"].Value = (byte)value;
            }
            

            // Def="u8 YellowMonk"
            /// <summary>
            /// Flask Recovery - Yellow Monk (u8)
            /// </summary>
            /// <remarks>
            /// The number of est recovery of the old man in yellow
            /// </remarks>
            public byte FlaskRecoveryYellowMonk 
            {
                get => (byte)CellsByName["FlaskRecoveryYellowMonk"].Value;
                set => CellsByName["FlaskRecoveryYellowMonk"].Value = (byte)value;
            }
            

            // Def="dummy8 pad1[48]"
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
            
                }
            }
            
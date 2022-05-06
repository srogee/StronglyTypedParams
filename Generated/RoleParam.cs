
            namespace StronglyTypedParams
            {
                public class RoleParam : ParamRow
                {
                    public RoleParam() : base()
                    {
                    }
            

            // Def="u8 teamType"
            /// <summary>
            /// Team Type (u8)
            /// </summary>
            /// <remarks>
            /// Team type
            /// </remarks>
            public byte TeamType 
            {
                get => (byte)CellsByName["TeamType"].Value;
                set => CellsByName["TeamType"].Value = value;
            }
            

            // Def="dummy8 pad10[3]"
            /// <summary>
            /// pad10 (dummy8)
            /// </summary>
            /// <remarks>
            /// 
            /// </remarks>
            public object Pad10 
            {
                get => (object)CellsByName["Pad10"].Value;
                set => CellsByName["Pad10"].Value = value;
            }
            

            // Def="s32 phantomParamId = -1"
            /// <summary>
            /// Phantom Param ID - Vow [0] (s32)
            /// </summary>
            /// <remarks>
            /// Phantom parameter ID when pledge rank is 0
            /// </remarks>
            public int PhantomParamIDVow0 
            {
                get => (int)CellsByName["PhantomParamIDVow0"].Value;
                set => CellsByName["PhantomParamIDVow0"].Value = value;
            }
            

            // Def="s32 spEffectID0 = -1"
            /// <summary>
            /// SpEffect ID [0] (s32)
            /// </summary>
            /// <remarks>
            /// Resident special effect 0
            /// </remarks>
            public int SpEffectID0 
            {
                get => (int)CellsByName["SpEffectID0"].Value;
                set => CellsByName["SpEffectID0"].Value = value;
            }
            

            // Def="s32 spEffectID1 = -1"
            /// <summary>
            /// SpEffect ID [1] (s32)
            /// </summary>
            /// <remarks>
            /// Resident special effect 1
            /// </remarks>
            public int SpEffectID1 
            {
                get => (int)CellsByName["SpEffectID1"].Value;
                set => CellsByName["SpEffectID1"].Value = value;
            }
            

            // Def="s32 spEffectID2 = -1"
            /// <summary>
            /// SpEffect ID [2] (s32)
            /// </summary>
            /// <remarks>
            /// Resident special effect 2
            /// </remarks>
            public int SpEffectID2 
            {
                get => (int)CellsByName["SpEffectID2"].Value;
                set => CellsByName["SpEffectID2"].Value = value;
            }
            

            // Def="s32 spEffectID3 = -1"
            /// <summary>
            /// SpEffect ID [3] (s32)
            /// </summary>
            /// <remarks>
            /// Resident special effect 3
            /// </remarks>
            public int SpEffectID3 
            {
                get => (int)CellsByName["SpEffectID3"].Value;
                set => CellsByName["SpEffectID3"].Value = value;
            }
            

            // Def="s32 spEffectID4 = -1"
            /// <summary>
            /// SpEffect ID [4] (s32)
            /// </summary>
            /// <remarks>
            /// Resident special effect 4
            /// </remarks>
            public int SpEffectID4 
            {
                get => (int)CellsByName["SpEffectID4"].Value;
                set => CellsByName["SpEffectID4"].Value = value;
            }
            

            // Def="s32 spEffectID5 = -1"
            /// <summary>
            /// SpEffect ID [5] (s32)
            /// </summary>
            /// <remarks>
            /// Resident special effect 5
            /// </remarks>
            public int SpEffectID5 
            {
                get => (int)CellsByName["SpEffectID5"].Value;
                set => CellsByName["SpEffectID5"].Value = value;
            }
            

            // Def="s32 spEffectID6 = -1"
            /// <summary>
            /// SpEffect ID [6] (s32)
            /// </summary>
            /// <remarks>
            /// Resident special effect 6
            /// </remarks>
            public int SpEffectID6 
            {
                get => (int)CellsByName["SpEffectID6"].Value;
                set => CellsByName["SpEffectID6"].Value = value;
            }
            

            // Def="s32 spEffectID7 = -1"
            /// <summary>
            /// SpEffect ID [7] (s32)
            /// </summary>
            /// <remarks>
            /// Resident special effect 7
            /// </remarks>
            public int SpEffectID7 
            {
                get => (int)CellsByName["SpEffectID7"].Value;
                set => CellsByName["SpEffectID7"].Value = value;
            }
            

            // Def="s32 spEffectID8 = -1"
            /// <summary>
            /// SpEffect ID [8] (s32)
            /// </summary>
            /// <remarks>
            /// Resident special effect 8
            /// </remarks>
            public int SpEffectID8 
            {
                get => (int)CellsByName["SpEffectID8"].Value;
                set => CellsByName["SpEffectID8"].Value = value;
            }
            

            // Def="s32 spEffectID9 = -1"
            /// <summary>
            /// SpEffect ID [9] (s32)
            /// </summary>
            /// <remarks>
            /// Resident special effect 9
            /// </remarks>
            public int SpEffectID9 
            {
                get => (int)CellsByName["SpEffectID9"].Value;
                set => CellsByName["SpEffectID9"].Value = value;
            }
            

            // Def="s32 sosSignSfxId"
            /// <summary>
            /// Summon Sign - SFX ID (s32)
            /// </summary>
            /// <remarks>
            /// SOS sign SFX ID issued by another person
            /// </remarks>
            public int SummonSignSFXID 
            {
                get => (int)CellsByName["SummonSignSFXID"].Value;
                set => CellsByName["SummonSignSFXID"].Value = value;
            }
            

            // Def="s32 mySosSignSfxId"
            /// <summary>
            /// Personal Summon Sign - SFX ID (s32)
            /// </summary>
            /// <remarks>
            /// SOS sign SFX ID issued by me
            /// </remarks>
            public int PersonalSummonSignSFXID 
            {
                get => (int)CellsByName["PersonalSummonSignSFXID"].Value;
                set => CellsByName["PersonalSummonSignSFXID"].Value = value;
            }
            

            // Def="s32 summonStartAnimId"
            /// <summary>
            /// Player Summon Start - Animation ID (s32)
            /// </summary>
            /// <remarks>
            /// Anime ID to play when the player is summoned and the game starts
            /// </remarks>
            public int PlayerSummonStartAnimationID 
            {
                get => (int)CellsByName["PlayerSummonStartAnimationID"].Value;
                set => CellsByName["PlayerSummonStartAnimationID"].Value = value;
            }
            

            // Def="s32 itemlotParamId = -1"
            /// <summary>
            /// Map Itemlot Param ID (s32)
            /// </summary>
            /// <remarks>
            /// Acquisition reward item lottery parameter ID_for map (not -1)
            /// </remarks>
            public int MapItemlotParamID 
            {
                get => (int)CellsByName["MapItemlotParamID"].Value;
                set => CellsByName["MapItemlotParamID"].Value = value;
            }
            

            // Def="u8 voiceChatGroup"
            /// <summary>
            /// Voice Chat Group (u8)
            /// </summary>
            /// <remarks>
            /// Voice chat group
            /// </remarks>
            public byte VoiceChatGroup 
            {
                get => (byte)CellsByName["VoiceChatGroup"].Value;
                set => CellsByName["VoiceChatGroup"].Value = value;
            }
            

            // Def="u8 roleNameColor"
            /// <summary>
            /// Role Name Color (u8)
            /// </summary>
            /// <remarks>
            /// The color of the role name text displayed on the FE of the network PC
            /// </remarks>
            public byte RoleNameColor 
            {
                get => (byte)CellsByName["RoleNameColor"].Value;
                set => CellsByName["RoleNameColor"].Value = value;
            }
            

            // Def="dummy8 pad1[2]"
            /// <summary>
            /// pad1 (dummy8)
            /// </summary>
            /// <remarks>
            /// 
            /// </remarks>
            public object Pad1 
            {
                get => (object)CellsByName["Pad1"].Value;
                set => CellsByName["Pad1"].Value = value;
            }
            

            // Def="s32 roleNameId"
            /// <summary>
            /// Role Name - Text ID (s32)
            /// </summary>
            /// <remarks>
            /// Text ID of the role name to be displayed on the FE of the network PC
            /// </remarks>
            public int RoleNameTextID 
            {
                get => (int)CellsByName["RoleNameTextID"].Value;
                set => CellsByName["RoleNameTextID"].Value = value;
            }
            

            // Def="u32 threatLv"
            /// <summary>
            /// Threat Level (u32)
            /// </summary>
            /// <remarks>
            /// Threat level
            /// </remarks>
            public uint ThreatLevel 
            {
                get => (uint)CellsByName["ThreatLevel"].Value;
                set => CellsByName["ThreatLevel"].Value = value;
            }
            

            // Def="s32 phantomParamId_vowRank1 = -1"
            /// <summary>
            /// Phantom Param ID - Vow Rank [1] (s32)
            /// </summary>
            /// <remarks>
            /// Phantom parameter ID when pledge rank is 1
            /// </remarks>
            public int PhantomParamIDVowRank1 
            {
                get => (int)CellsByName["PhantomParamIDVowRank1"].Value;
                set => CellsByName["PhantomParamIDVowRank1"].Value = value;
            }
            

            // Def="s32 phantomParamId_vowRank2 = -1"
            /// <summary>
            /// Phantom Param ID - Vow Rank [2] (s32)
            /// </summary>
            /// <remarks>
            /// Phantom parameter ID when pledge rank is 2
            /// </remarks>
            public int PhantomParamIDVowRank2 
            {
                get => (int)CellsByName["PhantomParamIDVowRank2"].Value;
                set => CellsByName["PhantomParamIDVowRank2"].Value = value;
            }
            

            // Def="s32 phantomParamId_vowRank3 = -1"
            /// <summary>
            /// Phantom Param ID - Vow Rank [3] (s32)
            /// </summary>
            /// <remarks>
            /// Phantom parameter ID when pledge rank is 3
            /// </remarks>
            public int PhantomParamIDVowRank3 
            {
                get => (int)CellsByName["PhantomParamIDVowRank3"].Value;
                set => CellsByName["PhantomParamIDVowRank3"].Value = value;
            }
            

            // Def="s32 spEffectID_vowRank0 = -1"
            /// <summary>
            /// Phantom Param ID - Vow Rank [4] (s32)
            /// </summary>
            /// <remarks>
            /// Special effect ID for SFX when pledge rank 0
            /// </remarks>
            public int PhantomParamIDVowRank4 
            {
                get => (int)CellsByName["PhantomParamIDVowRank4"].Value;
                set => CellsByName["PhantomParamIDVowRank4"].Value = value;
            }
            

            // Def="s32 spEffectID_vowRank1 = -1"
            /// <summary>
            /// Phantom Param ID - Vow Rank [5] (s32)
            /// </summary>
            /// <remarks>
            /// Special effect ID for SFX when pledge rank 1
            /// </remarks>
            public int PhantomParamIDVowRank5 
            {
                get => (int)CellsByName["PhantomParamIDVowRank5"].Value;
                set => CellsByName["PhantomParamIDVowRank5"].Value = value;
            }
            

            // Def="s32 spEffectID_vowRank2 = -1"
            /// <summary>
            /// Phantom Param ID - Vow Rank [6] (s32)
            /// </summary>
            /// <remarks>
            /// Special effect ID for SFX when pledge rank 2
            /// </remarks>
            public int PhantomParamIDVowRank6 
            {
                get => (int)CellsByName["PhantomParamIDVowRank6"].Value;
                set => CellsByName["PhantomParamIDVowRank6"].Value = value;
            }
            

            // Def="s32 spEffectID_vowRank3 = -1"
            /// <summary>
            /// Phantom Param ID - Vow Rank [7] (s32)
            /// </summary>
            /// <remarks>
            /// Special effect ID for SFX when pledge rank 3
            /// </remarks>
            public int PhantomParamIDVowRank7 
            {
                get => (int)CellsByName["PhantomParamIDVowRank7"].Value;
                set => CellsByName["PhantomParamIDVowRank7"].Value = value;
            }
            

            // Def="s32 signPhantomId = -1"
            /// <summary>
            /// Ghost Phantom ID (s32)
            /// </summary>
            /// <remarks>
            /// Multiplayer pledge ghost body sign phantom ID designation for illusion
            /// </remarks>
            public int GhostPhantomID 
            {
                get => (int)CellsByName["GhostPhantomID"].Value;
                set => CellsByName["GhostPhantomID"].Value = value;
            }
            

            // Def="s32 nonPlayerSummonStartAnimId"
            /// <summary>
            /// NPC Summon Start - Animation ID (s32)
            /// </summary>
            /// <remarks>
            /// Anime ID to play when a player other than the player is summoned and the game starts
            /// </remarks>
            public int NPCSummonStartAnimationID 
            {
                get => (int)CellsByName["NPCSummonStartAnimationID"].Value;
                set => CellsByName["NPCSummonStartAnimationID"].Value = value;
            }
            

            // Def="dummy8 pad2[16]"
            /// <summary>
            /// pad2 (dummy8)
            /// </summary>
            /// <remarks>
            /// 
            /// </remarks>
            public object Pad2 
            {
                get => (object)CellsByName["Pad2"].Value;
                set => CellsByName["Pad2"].Value = value;
            }
            
                }
            }
            
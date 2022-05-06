
            namespace StronglyTypedParams
            {
                public class BuddyStoneParam : ParamRow
                {
                    public BuddyStoneParam() : base()
                    {
                    }
            

            // Def="u8 disableParam_NT:1"
            /// <summary>
            /// Disable Param - Network Test (u8)
            /// </summary>
            /// <remarks>
            /// Parameters marked with ○ are excluded in the NT version package.
            /// </remarks>
            public byte DisableParamNetworkTest 
            {
                get => (byte)CellsByName["DisableParamNetworkTest"].Value;
                set => CellsByName["DisableParamNetworkTest"].Value = value;
            }
            

            // Def="dummy8 disableParamReserve1:7"
            /// <summary>
            /// Reserve for package output 1 (dummy8)
            /// </summary>
            /// <remarks>
            /// Reserve for package output 1
            /// </remarks>
            public object ReserveForPackageOutput1 
            {
                get => (object)CellsByName["ReserveForPackageOutput1"].Value;
                set => CellsByName["ReserveForPackageOutput1"].Value = value;
            }
            

            // Def="dummy8 disableParamReserve2[3]"
            /// <summary>
            /// Reserve for package output 2 (dummy8)
            /// </summary>
            /// <remarks>
            /// Reserve for package output 2
            /// </remarks>
            public object ReserveForPackageOutput2 
            {
                get => (object)CellsByName["ReserveForPackageOutput2"].Value;
                set => CellsByName["ReserveForPackageOutput2"].Value = value;
            }
            

            // Def="u32 talkChrEntityId"
            /// <summary>
            /// Talk Character Entity ID (u32)
            /// </summary>
            /// <remarks>
            /// Used as a foreign key when referencing from a conversation.
            /// </remarks>
            public uint TalkCharacterEntityID 
            {
                get => (uint)CellsByName["TalkCharacterEntityID"].Value;
                set => CellsByName["TalkCharacterEntityID"].Value = value;
            }
            

            // Def="u32 eliminateTargetEntityId"
            /// <summary>
            /// Defeat Target List Entity ID (u32)
            /// </summary>
            /// <remarks>
            /// Entity ID of the character / group to be defeated by the buddy when summoned from this stele
            /// </remarks>
            public uint DefeatTargetListEntityID 
            {
                get => (uint)CellsByName["DefeatTargetListEntityID"].Value;
                set => CellsByName["DefeatTargetListEntityID"].Value = value;
            }
            

            // Def="u32 summonedEventFlagId"
            /// <summary>
            /// Summoned Event Flag ID (u32)
            /// </summary>
            /// <remarks>
            /// Flag ID that stands when summoned from a stone monument. When this flag is set, the stone monument cannot be summoned.
            /// </remarks>
            public uint SummonedEventFlagID 
            {
                get => (uint)CellsByName["SummonedEventFlagID"].Value;
                set => CellsByName["SummonedEventFlagID"].Value = value;
            }
            

            // Def="u8 isSpecial:1"
            /// <summary>
            /// Is Special Monument (u8)
            /// </summary>
            /// <remarks>
            /// Is the stone monument an SP stone monument or a general-purpose stone monument? A bool that distinguishes.
            /// </remarks>
            public byte IsSpecialMonument 
            {
                get => (byte)CellsByName["IsSpecialMonument"].Value;
                set => CellsByName["IsSpecialMonument"].Value = value;
            }
            

            // Def="dummy8 pad1:7"
            /// <summary>
            /// Padding (dummy8)
            /// </summary>
            /// <remarks>
            /// 
            /// </remarks>
            public object Padding 
            {
                get => (object)CellsByName["Padding"].Value;
                set => CellsByName["Padding"].Value = value;
            }
            


            // Def="s32 buddyId"
            /// <summary>
            /// Buddy ID (s32)
            /// </summary>
            /// <remarks>
            /// ID of the buddy parameter. If "Special" is ○, this buddy ID will be summoned.
            /// </remarks>
            public int BuddyID 
            {
                get => (int)CellsByName["BuddyID"].Value;
                set => CellsByName["BuddyID"].Value = value;
            }
            

            // Def="s32 dopingSpEffectId = -1"
            /// <summary>
            /// Applied SpEffect ID (s32)
            /// </summary>
            /// <remarks>
            /// Special effect ID applied to the buddy when summoning the buddy.
            /// </remarks>
            public int AppliedSpEffectID 
            {
                get => (int)CellsByName["AppliedSpEffectID"].Value;
                set => CellsByName["AppliedSpEffectID"].Value = value;
            }
            

            // Def="u16 activateRange = 100"
            /// <summary>
            /// Activation Distance (u16)
            /// </summary>
            /// <remarks>
            /// If there is at least one character to be defeated in this range, you can summon a buddy at that stone monument.
            /// </remarks>
            public ushort ActivationDistance 
            {
                get => (ushort)CellsByName["ActivationDistance"].Value;
                set => CellsByName["ActivationDistance"].Value = value;
            }
            

            // Def="s16 overwriteReturnRange = -1"
            /// <summary>
            /// Overwrite Return Range (s16)
            /// </summary>
            /// <remarks>
            /// Buddy's homecoming distance can be overridden
            /// </remarks>
            public short OverwriteReturnRange 
            {
                get => (short)CellsByName["OverwriteReturnRange"].Value;
                set => CellsByName["OverwriteReturnRange"].Value = value;
            }
            

            // Def="u32 overwriteActivateRegionEntityId"
            /// <summary>
            /// Overwrite Activation Region Entity ID (u32)
            /// </summary>
            /// <remarks>
            /// The range where the buddy can be summoned can be overwritten in the area of the specified entity ID.
            /// </remarks>
            public uint OverwriteActivationRegionEntityID 
            {
                get => (uint)CellsByName["OverwriteActivationRegionEntityID"].Value;
                set => CellsByName["OverwriteActivationRegionEntityID"].Value = value;
            }
            

            // Def="u32 warnRegionEntityId"
            /// <summary>
            /// Warn Region Entity ID (u32)
            /// </summary>
            /// <remarks>
            /// Warning area entity ID
            /// </remarks>
            public uint WarnRegionEntityID 
            {
                get => (uint)CellsByName["WarnRegionEntityID"].Value;
                set => CellsByName["WarnRegionEntityID"].Value = value;
            }
            

                }
            }
            
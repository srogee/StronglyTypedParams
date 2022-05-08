
            namespace StronglyTypedParams
            {
                // CUTSCENE_MAP_ID_PARAM_ST
                public class CutsceneMapIdParam : ParamRow
                {
                    public CutsceneMapIdParam() : base()
                    {
                    }
            

            // Def="u8 disableParam_NT:1"
            /// <summary>
            /// Disable Param - Network Test (u8)
            /// </summary>
            /// <remarks>
            /// Parameters marked with ○ are excluded in the NT version package.
            /// </remarks>
            public BoolCirclecrossType DisableParamNetworkTest 
            {
                get => (BoolCirclecrossType)CellsByName["DisableParamNetworkTest"].Value;
                set => CellsByName["DisableParamNetworkTest"].Value = (byte)value;
            }
            

            // Def="u8 disableParam_Debug:1"
            /// <summary>
            /// Disable Param - Debug (u8)
            /// </summary>
            /// <remarks>
            /// Parameters marked with a circle are excluded from all packages (because they are for debugging).
            /// </remarks>
            public BoolCirclecrossType DisableParamDebug 
            {
                get => (BoolCirclecrossType)CellsByName["DisableParamDebug"].Value;
                set => CellsByName["DisableParamDebug"].Value = (byte)value;
            }
            

            // Def="dummy8 disableParamReserve1:6"
            /// <summary>
            /// Reserve for package output 1 (dummy8)
            /// </summary>
            /// <remarks>
            /// Reserve for package output 1
            /// </remarks>
            public object ReserveForPackageOutput1 
            {
                get => (object)CellsByName["ReserveForPackageOutput1"].Value;
                set => CellsByName["ReserveForPackageOutput1"].Value = (object)value;
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
                set => CellsByName["ReserveForPackageOutput2"].Value = (object)value;
            }
            

            // Def="u32 PlayMapId"
            /// <summary>
            /// Play Map ID (u32)
            /// </summary>
            /// <remarks>
            /// Please enter the map number to be played back as an 8-digit number. This is the map number used as the reference in the cutscene. If you do not specify the correct map number, the playback position will shift.
            /// </remarks>
            public uint PlayMapID 
            {
                get => (uint)CellsByName["PlayMapID"].Value;
                set => CellsByName["PlayMapID"].Value = (uint)value;
            }
            

            // Def="u32 RequireMapId0"
            /// <summary>
            /// Require Map ID 0 (u32)
            /// </summary>
            /// <remarks>
            /// Please enter the map number required for display as an 8-digit number. This parameter is used by the guest as a list to determine if the cutscene can be played. If you don't need it, you can leave it as 0 or blank.
            /// </remarks>
            public uint RequireMapID0 
            {
                get => (uint)CellsByName["RequireMapID0"].Value;
                set => CellsByName["RequireMapID0"].Value = (uint)value;
            }
            

            // Def="u32 RequireMapId1"
            /// <summary>
            /// Require Map ID 1 (u32)
            /// </summary>
            /// <remarks>
            /// Please enter the map number required for display as an 8-digit number. This parameter is used by the guest as a list to determine if the cutscene can be played. If you don't need it, you can leave it as 0 or blank.
            /// </remarks>
            public uint RequireMapID1 
            {
                get => (uint)CellsByName["RequireMapID1"].Value;
                set => CellsByName["RequireMapID1"].Value = (uint)value;
            }
            

            // Def="u32 RequireMapId2"
            /// <summary>
            /// Require Map ID 2 (u32)
            /// </summary>
            /// <remarks>
            /// Please enter the map number required for display as an 8-digit number. This parameter is used by the guest as a list to determine if the cutscene can be played. If you don't need it, you can leave it as 0 or blank.
            /// </remarks>
            public uint RequireMapID2 
            {
                get => (uint)CellsByName["RequireMapID2"].Value;
                set => CellsByName["RequireMapID2"].Value = (uint)value;
            }
            

            // Def="s32 RefCamPosHitPartsID = -1"
            /// <summary>
            /// Hit Part ID for Reference Camera (s32)
            /// </summary>
            /// <remarks>
            /// Hit part ID for calculating camera position during loading
            /// </remarks>
            public int HitPartIDForReferenceCamera 
            {
                get => (int)CellsByName["HitPartIDForReferenceCamera"].Value;
                set => CellsByName["HitPartIDForReferenceCamera"].Value = (int)value;
            }
            

            // Def="dummy8 reserved_2[12]"
            /// <summary>
            /// Reserve (dummy8)
            /// </summary>
            /// <remarks>
            /// 
            /// </remarks>
            public object Reserve 
            {
                get => (object)CellsByName["Reserve"].Value;
                set => CellsByName["Reserve"].Value = (object)value;
            }
            

            // Def="u16 ClientDisableViewTimeForProgress"
            /// <summary>
            /// Client Load View - Progress Bar Time (u16)
            /// </summary>
            /// <remarks>
            /// The number of seconds used to display the progress of the loading screen progress bar that is displayed when the guest side cannot play in the multi. [GR] SEQ22843 [Cutscene] Players who have not read the map number required for display during cutscene playback will see the screen go dark.
            /// </remarks>
            public ushort ClientLoadViewProgressBarTime 
            {
                get => (ushort)CellsByName["ClientLoadViewProgressBarTime"].Value;
                set => CellsByName["ClientLoadViewProgressBarTime"].Value = (ushort)value;
            }
            

            // Def="dummy8 reserved[2]"
            /// <summary>
            /// reserved (dummy8)
            /// </summary>
            /// <remarks>
            /// reserved
            /// </remarks>
            public object Reserved 
            {
                get => (object)CellsByName["Reserved"].Value;
                set => CellsByName["Reserved"].Value = (object)value;
            }
            

            // Def="s32 HitParts_0 = -1"
            /// <summary>
            /// Hit Parts [0] (s32)
            /// </summary>
            /// <remarks>
            /// Hit parts waiting to be read 0
            /// </remarks>
            public int HitParts0 
            {
                get => (int)CellsByName["HitParts0"].Value;
                set => CellsByName["HitParts0"].Value = (int)value;
            }
            

            // Def="s32 HitParts_1 = -1"
            /// <summary>
            /// Hit Parts [1] (s32)
            /// </summary>
            /// <remarks>
            /// Hit parts waiting to be read 1
            /// </remarks>
            public int HitParts1 
            {
                get => (int)CellsByName["HitParts1"].Value;
                set => CellsByName["HitParts1"].Value = (int)value;
            }
            
                }
            }
            

            namespace StronglyTypedParams
            {
                public class MapPieceTexParam : ParamRow
                {
                    public MapPieceTexParam() : base()
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
            

            // Def="u8 srcR"
            /// <summary>
            /// Pre-conversion - Map Image: R (u8)
            /// </summary>
            /// <remarks>
            /// Color information (R) of the map image before conversion. Pixels with matching RGB values are associated with this parameter
            /// </remarks>
            public byte PreConversionMapImageR 
            {
                get => (byte)CellsByName["PreConversionMapImageR"].Value;
                set => CellsByName["PreConversionMapImageR"].Value = value;
            }
            

            // Def="u8 srcG"
            /// <summary>
            /// Pre-conversion - Map Image: G (u8)
            /// </summary>
            /// <remarks>
            /// Color information (G) of the map image before conversion. Pixels with matching RGB values are associated with this parameter
            /// </remarks>
            public byte PreConversionMapImageG 
            {
                get => (byte)CellsByName["PreConversionMapImageG"].Value;
                set => CellsByName["PreConversionMapImageG"].Value = value;
            }
            

            // Def="u8 srcB"
            /// <summary>
            /// Pre-conversion - Map Image: B (u8)
            /// </summary>
            /// <remarks>
            /// Color information (B) of the map image before conversion. Pixels with matching RGB values are associated with this parameter
            /// </remarks>
            public byte PreConversionMapImageB 
            {
                get => (byte)CellsByName["PreConversionMapImageB"].Value;
                set => CellsByName["PreConversionMapImageB"].Value = value;
            }
            

            // Def="dummy8 pad1[1]"
            /// <summary>
            /// pad (dummy8)
            /// </summary>
            /// <remarks>
            /// pad. For the time being, leave it open for "image color information (A)"
            /// </remarks>
            public object Pad 
            {
                get => (object)CellsByName["Pad"].Value;
                set => CellsByName["Pad"].Value = value;
            }
            

            // Def="s32 saveMapNameId = -1"
            /// <summary>
            /// Save Map Name ID (s32)
            /// </summary>
            /// <remarks>
            /// Map name ID for displaying save data [PlaceName] (0: invalid value)
            /// </remarks>
            public int SaveMapNameID 
            {
                get => (int)CellsByName["SaveMapNameID"].Value;
                set => CellsByName["SaveMapNameID"].Value = value;
            }
            

            // Def="s32 multiPlayAreaId = -1"
            /// <summary>
            /// Multiplayer Area ID (s32)
            /// </summary>
            /// <remarks>
            /// Multiplayer area ID (-1: invalid value)
            /// </remarks>
            public int MultiplayerAreaID 
            {
                get => (int)CellsByName["MultiplayerAreaID"].Value;
                set => CellsByName["MultiplayerAreaID"].Value = value;
            }
            
                }
            }
            
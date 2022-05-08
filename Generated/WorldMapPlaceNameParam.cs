
            namespace StronglyTypedParams
            {
                // WORLD_MAP_PLACE_NAME_PARAM_ST
                public class WorldMapPlaceNameParam : ParamRow
                {
                    public WorldMapPlaceNameParam() : base()
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
            

            // Def="s32 worldMapPieceId = -1"
            /// <summary>
            /// World Map Piece ID (s32)
            /// </summary>
            /// <remarks>
            /// Map fragment parameter ID. Display text if you have this map fragment
            /// </remarks>
            public int WorldMapPieceID 
            {
                get => (int)CellsByName["WorldMapPieceID"].Value;
                set => CellsByName["WorldMapPieceID"].Value = (int)value;
            }
            

            // Def="s32 textId = -1"
            /// <summary>
            /// Place Name - Text ID (s32)
            /// </summary>
            /// <remarks>
            /// The text ID to display. PlaceName.xlsm
            /// </remarks>
            public int PlaceNameTextID 
            {
                get => (int)CellsByName["PlaceNameTextID"].Value;
                set => CellsByName["PlaceNameTextID"].Value = (int)value;
            }
            

            // Def="dummy8 pad1[4]"
            /// <summary>
            /// Padding (dummy8)
            /// </summary>
            /// <remarks>
            /// 
            /// </remarks>
            public object Padding 
            {
                get => (object)CellsByName["Padding"].Value;
                set => CellsByName["Padding"].Value = (object)value;
            }
            

            // Def="u8 areaNo"
            /// <summary>
            /// Map Area (u8)
            /// </summary>
            /// <remarks>
            /// AA part of mAA_BB_CC_DD
            /// </remarks>
            public byte MapArea 
            {
                get => (byte)CellsByName["MapArea"].Value;
                set => CellsByName["MapArea"].Value = (byte)value;
            }
            

            // Def="u8 gridXNo"
            /// <summary>
            /// Map Block (u8)
            /// </summary>
            /// <remarks>
            /// BB part of mAA_BB_CC_DD
            /// </remarks>
            public byte MapBlock 
            {
                get => (byte)CellsByName["MapBlock"].Value;
                set => CellsByName["MapBlock"].Value = (byte)value;
            }
            

            // Def="u8 gridZNo"
            /// <summary>
            /// Map Region (u8)
            /// </summary>
            /// <remarks>
            /// CC part of mAA_BB_CC_DD
            /// </remarks>
            public byte MapRegion 
            {
                get => (byte)CellsByName["MapRegion"].Value;
                set => CellsByName["MapRegion"].Value = (byte)value;
            }
            


            // Def="f32 posX"
            /// <summary>
            /// Map Coodinate: X (f32)
            /// </summary>
            /// <remarks>
            /// X coordinate
            /// </remarks>
            public float MapCoodinateX 
            {
                get => (float)CellsByName["MapCoodinateX"].Value;
                set => CellsByName["MapCoodinateX"].Value = (float)value;
            }
            

            // Def="f32 posY"
            /// <summary>
            /// Map Coodinate: Y (f32)
            /// </summary>
            /// <remarks>
            /// Y coordinate (not used)
            /// </remarks>
            public float MapCoodinateY 
            {
                get => (float)CellsByName["MapCoodinateY"].Value;
                set => CellsByName["MapCoodinateY"].Value = (float)value;
            }
            

            // Def="f32 posZ"
            /// <summary>
            /// Map Coodinate: Z (f32)
            /// </summary>
            /// <remarks>
            /// Z coordinate
            /// </remarks>
            public float MapCoodinateZ 
            {
                get => (float)CellsByName["MapCoodinateZ"].Value;
                set => CellsByName["MapCoodinateZ"].Value = (float)value;
            }
            
                }
            }
            
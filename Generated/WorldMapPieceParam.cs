
            namespace StronglyTypedParams
            {
                public class WorldMapPieceParam : ParamRow
                {
                    public WorldMapPieceParam() : base()
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
            

            // Def="u32 openEventFlagId"
            /// <summary>
            /// Open - Event Flag ID (u32)
            /// </summary>
            /// <remarks>
            /// Event flag ID of open condition
            /// </remarks>
            public uint OpenEventFlagID 
            {
                get => (uint)CellsByName["OpenEventFlagID"].Value;
                set => CellsByName["OpenEventFlagID"].Value = value;
            }
            

            // Def="f32 openTravelAreaLeft"
            /// <summary>
            /// Open - Traversal Area - X Min (f32)
            /// </summary>
            /// <remarks>
            /// Coordinates of the traversal area that expands when opened (Xmin)
            /// </remarks>
            public float OpenTraversalAreaXMin 
            {
                get => (float)CellsByName["OpenTraversalAreaXMin"].Value;
                set => CellsByName["OpenTraversalAreaXMin"].Value = value;
            }
            

            // Def="f32 openTravelAreaRight"
            /// <summary>
            /// Open - Traversal Area - X Max (f32)
            /// </summary>
            /// <remarks>
            /// Coordinates of the traversal area that expands when opened (Xmax)
            /// </remarks>
            public float OpenTraversalAreaXMax 
            {
                get => (float)CellsByName["OpenTraversalAreaXMax"].Value;
                set => CellsByName["OpenTraversalAreaXMax"].Value = value;
            }
            

            // Def="f32 openTravelAreaTop"
            /// <summary>
            /// Open - Traversal Area - Y Min (f32)
            /// </summary>
            /// <remarks>
            /// Coordinates of the traversal area that expands when opened (Ymin)
            /// </remarks>
            public float OpenTraversalAreaYMin 
            {
                get => (float)CellsByName["OpenTraversalAreaYMin"].Value;
                set => CellsByName["OpenTraversalAreaYMin"].Value = value;
            }
            

            // Def="f32 openTravelAreaBottom"
            /// <summary>
            /// Open - Traversal Area - Y Max (f32)
            /// </summary>
            /// <remarks>
            /// Coordinates of the traversal area that expands when opened (Ymax)
            /// </remarks>
            public float OpenTraversalAreaYMax 
            {
                get => (float)CellsByName["OpenTraversalAreaYMax"].Value;
                set => CellsByName["OpenTraversalAreaYMax"].Value = value;
            }
            

            // Def="u32 acquisitionEventFlagId"
            /// <summary>
            /// Acquisition - Event Flag ID (u32)
            /// </summary>
            /// <remarks>
            /// Event flag ID of the acquisition production start condition. Assuming that only one of the map fragments is On
            /// </remarks>
            public uint AcquisitionEventFlagID 
            {
                get => (uint)CellsByName["AcquisitionEventFlagID"].Value;
                set => CellsByName["AcquisitionEventFlagID"].Value = value;
            }
            

            // Def="f32 acquisitionEventScale = 1"
            /// <summary>
            /// Acquisition - Display Scale (f32)
            /// </summary>
            /// <remarks>
            /// Display magnification at the time of acquisition production
            /// </remarks>
            public float AcquisitionDisplayScale 
            {
                get => (float)CellsByName["AcquisitionDisplayScale"].Value;
                set => CellsByName["AcquisitionDisplayScale"].Value = value;
            }
            

            // Def="f32 acquisitionEventCenterX"
            /// <summary>
            /// Acquisition - Center X Coordinate (f32)
            /// </summary>
            /// <remarks>
            /// Center coordinates (X) at the time of acquisition production
            /// </remarks>
            public float AcquisitionCenterXCoordinate 
            {
                get => (float)CellsByName["AcquisitionCenterXCoordinate"].Value;
                set => CellsByName["AcquisitionCenterXCoordinate"].Value = value;
            }
            

            // Def="f32 acquisitionEventCenterY"
            /// <summary>
            /// Acquisition - Center Y Coordinate (f32)
            /// </summary>
            /// <remarks>
            /// For the central seat at the time of acquisition production (Y)
            /// </remarks>
            public float AcquisitionCenterYCoordinate 
            {
                get => (float)CellsByName["AcquisitionCenterYCoordinate"].Value;
                set => CellsByName["AcquisitionCenterYCoordinate"].Value = value;
            }
            

            // Def="f32 acquisitionEventResScale = 1"
            /// <summary>
            /// Acquisition - Display Resource Scale (f32)
            /// </summary>
            /// <remarks>
            /// Display magnification of blindfold resources for acquisition production
            /// </remarks>
            public float AcquisitionDisplayResourceScale 
            {
                get => (float)CellsByName["AcquisitionDisplayResourceScale"].Value;
                set => CellsByName["AcquisitionDisplayResourceScale"].Value = value;
            }
            

            // Def="f32 acquisitionEventResOffsetX"
            /// <summary>
            /// Acquisition - Resource Offset X (f32)
            /// </summary>
            /// <remarks>
            /// Display position offset (X) of blindfold resource for acquisition production
            /// </remarks>
            public float AcquisitionResourceOffsetX 
            {
                get => (float)CellsByName["AcquisitionResourceOffsetX"].Value;
                set => CellsByName["AcquisitionResourceOffsetX"].Value = value;
            }
            

            // Def="f32 acquisitionEventResOffsetY"
            /// <summary>
            /// Acquisition - Resource Offset Y (f32)
            /// </summary>
            /// <remarks>
            /// Offset of display position of blindfold resource for acquisition production (Y)
            /// </remarks>
            public float AcquisitionResourceOffsetY 
            {
                get => (float)CellsByName["AcquisitionResourceOffsetY"].Value;
                set => CellsByName["AcquisitionResourceOffsetY"].Value = value;
            }
            

            // Def="dummy8 pad[12]"
            /// <summary>
            /// pad (dummy8)
            /// </summary>
            /// <remarks>
            /// 
            /// </remarks>
            public object Pad 
            {
                get => (object)CellsByName["Pad"].Value;
                set => CellsByName["Pad"].Value = value;
            }
            
                }
            }
            
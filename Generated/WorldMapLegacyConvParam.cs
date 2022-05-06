
            namespace StronglyTypedParams
            {
                public class WorldMapLegacyConvParam : ParamRow
                {
                    public WorldMapLegacyConvParam() : base()
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
            

            // Def="u8 srcAreaNo"
            /// <summary>
            /// Source Map Area (u8)
            /// </summary>
            /// <remarks>
            /// Conversion source map ID: Area number
            /// </remarks>
            public byte SourceMapArea 
            {
                get => (byte)CellsByName["SourceMapArea"].Value;
                set => CellsByName["SourceMapArea"].Value = value;
            }
            

            // Def="u8 srcGridXNo"
            /// <summary>
            /// Source Map Block (u8)
            /// </summary>
            /// <remarks>
            /// Source map ID: Grid X
            /// </remarks>
            public byte SourceMapBlock 
            {
                get => (byte)CellsByName["SourceMapBlock"].Value;
                set => CellsByName["SourceMapBlock"].Value = value;
            }
            

            // Def="u8 srcGridZNo"
            /// <summary>
            /// Source Map Region (u8)
            /// </summary>
            /// <remarks>
            /// Source map ID: Grid Z
            /// </remarks>
            public byte SourceMapRegion 
            {
                get => (byte)CellsByName["SourceMapRegion"].Value;
                set => CellsByName["SourceMapRegion"].Value = value;
            }
            

            // Def="dummy8 pad1[1]"
            /// <summary>
            /// Padding 1 (dummy8)
            /// </summary>
            /// <remarks>
            /// Padding 1
            /// </remarks>
            public object Padding1 
            {
                get => (object)CellsByName["Padding1"].Value;
                set => CellsByName["Padding1"].Value = value;
            }
            

            // Def="f32 srcPosX"
            /// <summary>
            /// Source Map Coordinate: X (f32)
            /// </summary>
            /// <remarks>
            /// Source map reference coordinates X
            /// </remarks>
            public float SourceMapCoordinateX 
            {
                get => (float)CellsByName["SourceMapCoordinateX"].Value;
                set => CellsByName["SourceMapCoordinateX"].Value = value;
            }
            

            // Def="f32 srcPosY"
            /// <summary>
            /// Source Map Coordinate: Y (f32)
            /// </summary>
            /// <remarks>
            /// Source map reference coordinates Y
            /// </remarks>
            public float SourceMapCoordinateY 
            {
                get => (float)CellsByName["SourceMapCoordinateY"].Value;
                set => CellsByName["SourceMapCoordinateY"].Value = value;
            }
            

            // Def="f32 srcPosZ"
            /// <summary>
            /// Source Map Coordinate: Z (f32)
            /// </summary>
            /// <remarks>
            /// Source map reference coordinates Z
            /// </remarks>
            public float SourceMapCoordinateZ 
            {
                get => (float)CellsByName["SourceMapCoordinateZ"].Value;
                set => CellsByName["SourceMapCoordinateZ"].Value = value;
            }
            

            // Def="u8 dstAreaNo"
            /// <summary>
            /// Destination Map Area (u8)
            /// </summary>
            /// <remarks>
            /// Conversion destination map ID: Area number
            /// </remarks>
            public byte DestinationMapArea 
            {
                get => (byte)CellsByName["DestinationMapArea"].Value;
                set => CellsByName["DestinationMapArea"].Value = value;
            }
            

            // Def="u8 dstGridXNo"
            /// <summary>
            /// Destination Map Block (u8)
            /// </summary>
            /// <remarks>
            /// Destination map ID: Grid X
            /// </remarks>
            public byte DestinationMapBlock 
            {
                get => (byte)CellsByName["DestinationMapBlock"].Value;
                set => CellsByName["DestinationMapBlock"].Value = value;
            }
            

            // Def="u8 dstGridZNo"
            /// <summary>
            /// Destination Map Region (u8)
            /// </summary>
            /// <remarks>
            /// Destination map ID: Grid Z
            /// </remarks>
            public byte DestinationMapRegion 
            {
                get => (byte)CellsByName["DestinationMapRegion"].Value;
                set => CellsByName["DestinationMapRegion"].Value = value;
            }
            

            // Def="dummy8 pad2[1]"
            /// <summary>
            /// Padding 2 (dummy8)
            /// </summary>
            /// <remarks>
            /// Padding 2
            /// </remarks>
            public object Padding2 
            {
                get => (object)CellsByName["Padding2"].Value;
                set => CellsByName["Padding2"].Value = value;
            }
            

            // Def="f32 dstPosX"
            /// <summary>
            /// Destination Map Coordinate: X (f32)
            /// </summary>
            /// <remarks>
            /// Destination map reference coordinates X
            /// </remarks>
            public float DestinationMapCoordinateX 
            {
                get => (float)CellsByName["DestinationMapCoordinateX"].Value;
                set => CellsByName["DestinationMapCoordinateX"].Value = value;
            }
            

            // Def="f32 dstPosY"
            /// <summary>
            /// Destination Map Coordinate: Y (f32)
            /// </summary>
            /// <remarks>
            /// Destination map reference coordinates Y
            /// </remarks>
            public float DestinationMapCoordinateY 
            {
                get => (float)CellsByName["DestinationMapCoordinateY"].Value;
                set => CellsByName["DestinationMapCoordinateY"].Value = value;
            }
            

            // Def="f32 dstPosZ"
            /// <summary>
            /// Destination Map Coordinate: Z (f32)
            /// </summary>
            /// <remarks>
            /// Destination map reference coordinates Z
            /// </remarks>
            public float DestinationMapCoordinateZ 
            {
                get => (float)CellsByName["DestinationMapCoordinateZ"].Value;
                set => CellsByName["DestinationMapCoordinateZ"].Value = value;
            }
            

            // Def="u8 isBasePoint:1"
            /// <summary>
            /// Is Reference Connection Point (u8)
            /// </summary>
            /// <remarks>
            /// Is it a reference connection point? One reference connection point is always set for one conversion source map ID.
            /// </remarks>
            public byte IsReferenceConnectionPoint 
            {
                get => (byte)CellsByName["IsReferenceConnectionPoint"].Value;
                set => CellsByName["IsReferenceConnectionPoint"].Value = value;
            }
            

            // Def="dummy8 pad3:7"
            /// <summary>
            /// Padding 3 (dummy8)
            /// </summary>
            /// <remarks>
            /// Padding 3
            /// </remarks>
            public object Padding3 
            {
                get => (object)CellsByName["Padding3"].Value;
                set => CellsByName["Padding3"].Value = value;
            }
            

            // Def="dummy8 pad4[11]"
            /// <summary>
            /// Padding 4 (dummy8)
            /// </summary>
            /// <remarks>
            /// Padding 4
            /// </remarks>
            public object Padding4 
            {
                get => (object)CellsByName["Padding4"].Value;
                set => CellsByName["Padding4"].Value = value;
            }
            
                }
            }
            
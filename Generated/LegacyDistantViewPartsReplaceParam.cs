
            namespace StronglyTypedParams
            {
                public class LegacyDistantViewPartsReplaceParam : ParamRow
                {
                    public LegacyDistantViewPartsReplaceParam() : base()
                    {
                    }
            

            // Def="s32 TargetMapId = -1"
            /// <summary>
            /// Target Map ID (s32)
            /// </summary>
            /// <remarks>
            /// Specify the target map ID. Legacy only. (m12_34_56_78 → 12345678). Initially it was only legacy, but it also supports open celestial sphere maps
            /// </remarks>
            public int TargetMapID 
            {
                get => (int)CellsByName["TargetMapID"].Value;
                set => CellsByName["TargetMapID"].Value = value;
            }
            

            // Def="u32 TargetEventId"
            /// <summary>
            /// Target Event ID (u32)
            /// </summary>
            /// <remarks>
            /// If you enter the target natural disaster event ID from "300, 310, 311 and 312", it will be [natural disaster replacement data]. If it is 0 or blank, it will be [Regional ID switching data] (SEQ16039).
            /// </remarks>
            public uint TargetEventID 
            {
                get => (uint)CellsByName["TargetEventID"].Value;
                set => CellsByName["TargetEventID"].Value = value;
            }
            

            // Def="s32 SrcAssetId = -1"
            /// <summary>
            /// Replacement Source Asset ID (s32)
            /// </summary>
            /// <remarks>
            /// Replacement source AssetId: AEG123_456_9999 → 123456
            /// </remarks>
            public int ReplacementSourceAssetID 
            {
                get => (int)CellsByName["ReplacementSourceAssetID"].Value;
                set => CellsByName["ReplacementSourceAssetID"].Value = value;
            }
            

            // Def="s32 SrcAssetPartsNo = -1"
            /// <summary>
            /// Replacement Source Asset Part ID (s32)
            /// </summary>
            /// <remarks>
            /// Replacement source PartsNo: AEG123_456_9999 → 9999
            /// </remarks>
            public int ReplacementSourceAssetPartID 
            {
                get => (int)CellsByName["ReplacementSourceAssetPartID"].Value;
                set => CellsByName["ReplacementSourceAssetPartID"].Value = value;
            }
            

            // Def="s32 DstAssetId = -1"
            /// <summary>
            /// Replacement Destination Asset ID (s32)
            /// </summary>
            /// <remarks>
            /// Replacement destination AssetId: AEG123_456_9999 → 123456
            /// </remarks>
            public int ReplacementDestinationAssetID 
            {
                get => (int)CellsByName["ReplacementDestinationAssetID"].Value;
                set => CellsByName["ReplacementDestinationAssetID"].Value = value;
            }
            

            // Def="s32 DstAssetPartsNo = -1"
            /// <summary>
            /// Replacement Destination Asset Part ID (s32)
            /// </summary>
            /// <remarks>
            /// Replacement destination PartsNo: AEG123_456_9999 → 9999
            /// </remarks>
            public int ReplacementDestinationAssetPartID 
            {
                get => (int)CellsByName["ReplacementDestinationAssetPartID"].Value;
                set => CellsByName["ReplacementDestinationAssetPartID"].Value = value;
            }
            

            // Def="s32 SrcAssetIdRangeMin = -1"
            /// <summary>
            /// Replacement Source Asset ID - Min Range (s32)
            /// </summary>
            /// <remarks>
            /// Replacement source asset ID range specification Min
            /// </remarks>
            public int ReplacementSourceAssetIDMinRange 
            {
                get => (int)CellsByName["ReplacementSourceAssetIDMinRange"].Value;
                set => CellsByName["ReplacementSourceAssetIDMinRange"].Value = value;
            }
            

            // Def="s32 SrcAssetIdRangeMax = -1"
            /// <summary>
            /// Replacement Source Asset ID - Max Range (s32)
            /// </summary>
            /// <remarks>
            /// Replacement source asset ID range specification Max
            /// </remarks>
            public int ReplacementSourceAssetIDMaxRange 
            {
                get => (int)CellsByName["ReplacementSourceAssetIDMaxRange"].Value;
                set => CellsByName["ReplacementSourceAssetIDMaxRange"].Value = value;
            }
            

            // Def="s32 DstAssetIdRangeMin = -1"
            /// <summary>
            /// Replacement Destination Asset ID - Min Range (s32)
            /// </summary>
            /// <remarks>
            /// Replacement destination asset ID range specification Min
            /// </remarks>
            public int ReplacementDestinationAssetIDMinRange 
            {
                get => (int)CellsByName["ReplacementDestinationAssetIDMinRange"].Value;
                set => CellsByName["ReplacementDestinationAssetIDMinRange"].Value = value;
            }
            

            // Def="s32 DstAssetIdRangeMax = -1"
            /// <summary>
            /// Replacement Destination Asset ID - Max Range (s32)
            /// </summary>
            /// <remarks>
            /// Replacement destination asset ID range specification Max
            /// </remarks>
            public int ReplacementDestinationAssetIDMaxRange 
            {
                get => (int)CellsByName["ReplacementDestinationAssetIDMaxRange"].Value;
                set => CellsByName["ReplacementDestinationAssetIDMaxRange"].Value = value;
            }
            

            // Def="s8 LimitedMapRegionId0 = -1"
            /// <summary>
            /// Limited Map Region ID [0] (s8)
            /// </summary>
            /// <remarks>
            /// MapGD Local ID restriction 0: Valid only when "Natural disaster event ID" is 0. The part is valid only with the MapGD local ID you set (SEQ16039).
            /// </remarks>
            public sbyte LimitedMapRegionID0 
            {
                get => (sbyte)CellsByName["LimitedMapRegionID0"].Value;
                set => CellsByName["LimitedMapRegionID0"].Value = value;
            }
            

            // Def="s8 LimitedMapRegionId1 = -1"
            /// <summary>
            /// Limited Map Region ID [1] (s8)
            /// </summary>
            /// <remarks>
            /// MapGD Local ID Restriction 1: Valid only when "Natural Disaster Event ID" is 0. The part is valid only with the MapGD local ID you set (SEQ16039).
            /// </remarks>
            public sbyte LimitedMapRegionID1 
            {
                get => (sbyte)CellsByName["LimitedMapRegionID1"].Value;
                set => CellsByName["LimitedMapRegionID1"].Value = value;
            }
            

            // Def="s8 LimitedMapRegionId2 = -1"
            /// <summary>
            /// Limited Map Region ID [2] (s8)
            /// </summary>
            /// <remarks>
            /// MapGD Local ID restriction 2: Valid only when "Natural disaster event ID" is 0. The part is valid only with the MapGD local ID you set (SEQ16039).
            /// </remarks>
            public sbyte LimitedMapRegionID2 
            {
                get => (sbyte)CellsByName["LimitedMapRegionID2"].Value;
                set => CellsByName["LimitedMapRegionID2"].Value = value;
            }
            

            // Def="s8 LimitedMapRegionId3 = -1"
            /// <summary>
            /// Limited Map Region ID [3] (s8)
            /// </summary>
            /// <remarks>
            /// MapGD Local ID restriction 3: Valid only when "Natural disaster event ID" is 0. The part is valid only with the MapGD local ID you set (SEQ16039).
            /// </remarks>
            public sbyte LimitedMapRegionID3 
            {
                get => (sbyte)CellsByName["LimitedMapRegionID3"].Value;
                set => CellsByName["LimitedMapRegionID3"].Value = value;
            }
            

            // Def="dummy8 reserve[4]"
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
            

            // Def="s32 LimitedMapRegionAssetId = -1"
            /// <summary>
            /// Limited Map Region Asset ID (s32)
            /// </summary>
            /// <remarks>
            /// MapGD Valid assets specified by local ID: AssetId: AEG123_456_9999 → 123456
            /// </remarks>
            public int LimitedMapRegionAssetID 
            {
                get => (int)CellsByName["LimitedMapRegionAssetID"].Value;
                set => CellsByName["LimitedMapRegionAssetID"].Value = value;
            }
            

            // Def="s32 LimitedMapRegioAssetPartsNo = -1"
            /// <summary>
            /// Limited Map Region Parts ID (s32)
            /// </summary>
            /// <remarks>
            /// MapGD Valid assets specified by local ID: PartsNo: AEG123_456_9999 → 9999
            /// </remarks>
            public int LimitedMapRegionPartsID 
            {
                get => (int)CellsByName["LimitedMapRegionPartsID"].Value;
                set => CellsByName["LimitedMapRegionPartsID"].Value = value;
            }
            

            // Def="s32 LimitedMapRegioAssetIdRangeMin = -1"
            /// <summary>
            /// Limited Map Region Asset ID - Range Min (s32)
            /// </summary>
            /// <remarks>
            /// MapGD Valid asset specification with local ID: Asset ID range specification Min
            /// </remarks>
            public int LimitedMapRegionAssetIDRangeMin 
            {
                get => (int)CellsByName["LimitedMapRegionAssetIDRangeMin"].Value;
                set => CellsByName["LimitedMapRegionAssetIDRangeMin"].Value = value;
            }
            

            // Def="s32 LimitedMapRegioAssetIdRangeMax = -1"
            /// <summary>
            /// Limited Map Region Asset ID - Range Max (s32)
            /// </summary>
            /// <remarks>
            /// MapGD Valid asset specification for local ID: Asset ID range specification Max
            /// </remarks>
            public int LimitedMapRegionAssetIDRangeMax 
            {
                get => (int)CellsByName["LimitedMapRegionAssetIDRangeMax"].Value;
                set => CellsByName["LimitedMapRegionAssetIDRangeMax"].Value = value;
            }
            
                }
            }
            
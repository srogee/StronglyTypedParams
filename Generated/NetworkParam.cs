
            namespace StronglyTypedParams
            {
                public class NetworkParam : ParamRow
                {
                    public NetworkParam() : base()
                    {
                    }
            

            // Def="f32 signVerticalOffset"
            /// <summary>
            /// Common - Sign Height Offset (f32)
            /// </summary>
            /// <remarks>
            /// 
            /// </remarks>
            public float CommonSignHeightOffset 
            {
                get => (float)CellsByName["CommonSignHeightOffset"].Value;
                set => CellsByName["CommonSignHeightOffset"].Value = value;
            }
            

            // Def="f32 maxSignPosCorrectionRange"
            /// <summary>
            /// Common - Max Sign Position Correction Range (f32)
            /// </summary>
            /// <remarks>
            /// 
            /// </remarks>
            public float CommonMaxSignPositionCorrectionRange 
            {
                get => (float)CellsByName["CommonMaxSignPositionCorrectionRange"].Value;
                set => CellsByName["CommonMaxSignPositionCorrectionRange"].Value = value;
            }
            

            // Def="f32 summonTimeoutTime"
            /// <summary>
            /// Common - Summon Timeout Time (f32)
            /// </summary>
            /// <remarks>
            /// 
            /// </remarks>
            public float CommonSummonTimeoutTime 
            {
                get => (float)CellsByName["CommonSummonTimeoutTime"].Value;
                set => CellsByName["CommonSummonTimeoutTime"].Value = value;
            }
            

            // Def="dummy8 pad[4]"
            /// <summary>
            /// reserve (dummy8)
            /// </summary>
            /// <remarks>
            /// 
            /// </remarks>
            public object Reserve 
            {
                get => (object)CellsByName["Reserve"].Value;
                set => CellsByName["Reserve"].Value = value;
            }
            

            // Def="f32 signPuddleActiveMessageIntervalSec = 1"
            /// <summary>
            /// Summon Sign - Sign Puddle Active Message Interval (f32)
            /// </summary>
            /// <remarks>
            /// 
            /// </remarks>
            public float SummonSignSignPuddleActiveMessageInterval 
            {
                get => (float)CellsByName["SummonSignSignPuddleActiveMessageInterval"].Value;
                set => CellsByName["SummonSignSignPuddleActiveMessageInterval"].Value = value;
            }
            

            // Def="f32 keyGuideHeight = 1"
            /// <summary>
            /// Summon Sign - Key Guide Height (f32)
            /// </summary>
            /// <remarks>
            /// 
            /// </remarks>
            public float SummonSignKeyGuideHeight 
            {
                get => (float)CellsByName["SummonSignKeyGuideHeight"].Value;
                set => CellsByName["SummonSignKeyGuideHeight"].Value = value;
            }
            

            // Def="f32 reloadSignIntervalTime1 = 1"
            /// <summary>
            /// Summon Sign - Reload Sign Interval Time [1] (f32)
            /// </summary>
            /// <remarks>
            /// 
            /// </remarks>
            public float SummonSignReloadSignIntervalTime1 
            {
                get => (float)CellsByName["SummonSignReloadSignIntervalTime1"].Value;
                set => CellsByName["SummonSignReloadSignIntervalTime1"].Value = value;
            }
            

            // Def="f32 reloadSignIntervalTime2 = 1"
            /// <summary>
            /// Summon Sign - Reload Sign Interval Time [2] (f32)
            /// </summary>
            /// <remarks>
            /// 
            /// </remarks>
            public float SummonSignReloadSignIntervalTime2 
            {
                get => (float)CellsByName["SummonSignReloadSignIntervalTime2"].Value;
                set => CellsByName["SummonSignReloadSignIntervalTime2"].Value = value;
            }
            

            // Def="u32 reloadSignTotalCount = 1"
            /// <summary>
            /// Summon Sign - Reload Sign Total Count (u32)
            /// </summary>
            /// <remarks>
            /// Actually u8 is enough
            /// </remarks>
            public uint SummonSignReloadSignTotalCount 
            {
                get => (uint)CellsByName["SummonSignReloadSignTotalCount"].Value;
                set => CellsByName["SummonSignReloadSignTotalCount"].Value = value;
            }
            

            // Def="u32 reloadSignCellCount = 1"
            /// <summary>
            /// Summon Sign - Reload Sign Cell Count (u32)
            /// </summary>
            /// <remarks>
            /// Actually u8 is enough
            /// </remarks>
            public uint SummonSignReloadSignCellCount 
            {
                get => (uint)CellsByName["SummonSignReloadSignCellCount"].Value;
                set => CellsByName["SummonSignReloadSignCellCount"].Value = value;
            }
            

            // Def="f32 updateSignIntervalTime = 1"
            /// <summary>
            /// Summon Sign - Update Sign Interval Time (f32)
            /// </summary>
            /// <remarks>
            /// 
            /// </remarks>
            public float SummonSignUpdateSignIntervalTime 
            {
                get => (float)CellsByName["SummonSignUpdateSignIntervalTime"].Value;
                set => CellsByName["SummonSignUpdateSignIntervalTime"].Value = value;
            }
            

            // Def="f32 basicExclusiveRange = 1"
            /// <summary>
            /// Summon Sign - Basic Horizontal Drawing Range (f32)
            /// </summary>
            /// <remarks>
            /// 
            /// </remarks>
            public float SummonSignBasicHorizontalDrawingRange 
            {
                get => (float)CellsByName["SummonSignBasicHorizontalDrawingRange"].Value;
                set => CellsByName["SummonSignBasicHorizontalDrawingRange"].Value = value;
            }
            

            // Def="f32 basicExclusiveHeight = 1"
            /// <summary>
            /// Summon Sign - Basic Vertical Drawing Height (f32)
            /// </summary>
            /// <remarks>
            /// 
            /// </remarks>
            public float SummonSignBasicVerticalDrawingHeight 
            {
                get => (float)CellsByName["SummonSignBasicVerticalDrawingHeight"].Value;
                set => CellsByName["SummonSignBasicVerticalDrawingHeight"].Value = value;
            }
            

            // Def="f32 previewChrWaitingTime = 1"
            /// <summary>
            /// Summon Sign - Preview Chr Waiting Time (f32)
            /// </summary>
            /// <remarks>
            /// 
            /// </remarks>
            public float SummonSignPreviewChrWaitingTime 
            {
                get => (float)CellsByName["SummonSignPreviewChrWaitingTime"].Value;
                set => CellsByName["SummonSignPreviewChrWaitingTime"].Value = value;
            }
            

            // Def="f32 signVisibleRange = 1"
            /// <summary>
            /// Summon Sign - Sign Visible Range (f32)
            /// </summary>
            /// <remarks>
            /// 
            /// </remarks>
            public float SummonSignSignVisibleRange 
            {
                get => (float)CellsByName["SummonSignSignVisibleRange"].Value;
                set => CellsByName["SummonSignSignVisibleRange"].Value = value;
            }
            

            // Def="u32 cellGroupHorizontalRange = 1"
            /// <summary>
            /// Summon Sign - Acquisition Cell Range (Horizontal) (u32)
            /// </summary>
            /// <remarks>
            /// Actually u8 is enough
            /// </remarks>
            public uint SummonSignAcquisitionCellRangeHorizontal 
            {
                get => (uint)CellsByName["SummonSignAcquisitionCellRangeHorizontal"].Value;
                set => CellsByName["SummonSignAcquisitionCellRangeHorizontal"].Value = value;
            }
            

            // Def="u32 cellGroupTopRange = 1"
            /// <summary>
            /// Summon Sign - Acquisition Cell Range (Top) (u32)
            /// </summary>
            /// <remarks>
            /// Actually u8 is enough
            /// </remarks>
            public uint SummonSignAcquisitionCellRangeTop 
            {
                get => (uint)CellsByName["SummonSignAcquisitionCellRangeTop"].Value;
                set => CellsByName["SummonSignAcquisitionCellRangeTop"].Value = value;
            }
            

            // Def="u32 cellGroupBottomRange = 1"
            /// <summary>
            /// Summon Sign - Acquisition Cell Range (Bottom) (u32)
            /// </summary>
            /// <remarks>
            /// Actually u8 is enough
            /// </remarks>
            public uint SummonSignAcquisitionCellRangeBottom 
            {
                get => (uint)CellsByName["SummonSignAcquisitionCellRangeBottom"].Value;
                set => CellsByName["SummonSignAcquisitionCellRangeBottom"].Value = value;
            }
            

            // Def="f32 minWhitePhantomLimitTimeScale = 1"
            /// <summary>
            /// Summon Sign - Min White Phantom Limit Time Scale (f32)
            /// </summary>
            /// <remarks>
            /// 
            /// </remarks>
            public float SummonSignMinWhitePhantomLimitTimeScale 
            {
                get => (float)CellsByName["SummonSignMinWhitePhantomLimitTimeScale"].Value;
                set => CellsByName["SummonSignMinWhitePhantomLimitTimeScale"].Value = value;
            }
            

            // Def="f32 minSmallPhantomLimitTimeScale = 1"
            /// <summary>
            /// Summon Sign - Min Small Phantom Limit Time Scale (f32)
            /// </summary>
            /// <remarks>
            /// 
            /// </remarks>
            public float SummonSignMinSmallPhantomLimitTimeScale 
            {
                get => (float)CellsByName["SummonSignMinSmallPhantomLimitTimeScale"].Value;
                set => CellsByName["SummonSignMinSmallPhantomLimitTimeScale"].Value = value;
            }
            

            // Def="f32 whiteKeywordLimitTimeScale = 1"
            /// <summary>
            /// Summon Sign - White Keyword Limit Time Scale (f32)
            /// </summary>
            /// <remarks>
            /// 
            /// </remarks>
            public float SummonSignWhiteKeywordLimitTimeScale 
            {
                get => (float)CellsByName["SummonSignWhiteKeywordLimitTimeScale"].Value;
                set => CellsByName["SummonSignWhiteKeywordLimitTimeScale"].Value = value;
            }
            

            // Def="f32 smallKeywordLimitTimeScale = 1"
            /// <summary>
            /// Summon Sign - Small Keyword Limit Time Scale (f32)
            /// </summary>
            /// <remarks>
            /// 
            /// </remarks>
            public float SummonSignSmallKeywordLimitTimeScale 
            {
                get => (float)CellsByName["SummonSignSmallKeywordLimitTimeScale"].Value;
                set => CellsByName["SummonSignSmallKeywordLimitTimeScale"].Value = value;
            }
            

            // Def="f32 blackKeywordLimitTimeScale = 1"
            /// <summary>
            /// Summon Sign - Black Keyword Limit Time Scale (f32)
            /// </summary>
            /// <remarks>
            /// 
            /// </remarks>
            public float SummonSignBlackKeywordLimitTimeScale 
            {
                get => (float)CellsByName["SummonSignBlackKeywordLimitTimeScale"].Value;
                set => CellsByName["SummonSignBlackKeywordLimitTimeScale"].Value = value;
            }
            

            // Def="f32 dragonKeywordLimitTimeScale = 1"
            /// <summary>
            /// Summon Sign - Dragon Keyword Limit Time Scale (f32)
            /// </summary>
            /// <remarks>
            /// 
            /// </remarks>
            public float SummonSignDragonKeywordLimitTimeScale 
            {
                get => (float)CellsByName["SummonSignDragonKeywordLimitTimeScale"].Value;
                set => CellsByName["SummonSignDragonKeywordLimitTimeScale"].Value = value;
            }
            

            // Def="u32 singGetMax = 1"
            /// <summary>
            /// Summon Sign - Sign Get Max (u32)
            /// </summary>
            /// <remarks>
            /// Actually u8 is enough
            /// </remarks>
            public uint SummonSignSignGetMax 
            {
                get => (uint)CellsByName["SummonSignSignGetMax"].Value;
                set => CellsByName["SummonSignSignGetMax"].Value = value;
            }
            

            // Def="f32 signDownloadSpan = 1"
            /// <summary>
            /// Summon Sign - Sign Download Span (f32)
            /// </summary>
            /// <remarks>
            /// 
            /// </remarks>
            public float SummonSignSignDownloadSpan 
            {
                get => (float)CellsByName["SummonSignSignDownloadSpan"].Value;
                set => CellsByName["SummonSignSignDownloadSpan"].Value = value;
            }
            

            // Def="f32 signUpdateSpan = 1"
            /// <summary>
            /// Summon Sign - Sign Update Span (f32)
            /// </summary>
            /// <remarks>
            /// 
            /// </remarks>
            public float SummonSignSignUpdateSpan 
            {
                get => (float)CellsByName["SummonSignSignUpdateSpan"].Value;
                set => CellsByName["SummonSignSignUpdateSpan"].Value = value;
            }
            


            // Def="u32 maxBreakInTargetListCount = 1"
            /// <summary>
            /// Intrusion - Max Intruder List Count (u32)
            /// </summary>
            /// <remarks>
            /// 
            /// </remarks>
            public uint IntrusionMaxIntruderListCount 
            {
                get => (uint)CellsByName["IntrusionMaxIntruderListCount"].Value;
                set => CellsByName["IntrusionMaxIntruderListCount"].Value = value;
            }
            

            // Def="f32 breakInRequestIntervalTimeSec = 4"
            /// <summary>
            /// Intrusion - Intruder Request Interval Time (f32)
            /// </summary>
            /// <remarks>
            /// 
            /// </remarks>
            public float IntrusionIntruderRequestIntervalTime 
            {
                get => (float)CellsByName["IntrusionIntruderRequestIntervalTime"].Value;
                set => CellsByName["IntrusionIntruderRequestIntervalTime"].Value = value;
            }
            

            // Def="f32 breakInRequestTimeOutSec = 20"
            /// <summary>
            /// Intrusion - Intruder Request Timeout (f32)
            /// </summary>
            /// <remarks>
            /// 
            /// </remarks>
            public float IntrusionIntruderRequestTimeout 
            {
                get => (float)CellsByName["IntrusionIntruderRequestTimeout"].Value;
                set => CellsByName["IntrusionIntruderRequestTimeout"].Value = value;
            }
            


            // Def="f32 keyGuideRange = 1"
            /// <summary>
            /// Blood Message - Key Guide Horionztal Range (f32)
            /// </summary>
            /// <remarks>
            /// 
            /// </remarks>
            public float BloodMessageKeyGuideHorionztalRange 
            {
                get => (float)CellsByName["BloodMessageKeyGuideHorionztalRange"].Value;
                set => CellsByName["BloodMessageKeyGuideHorionztalRange"].Value = value;
            }
            

            // Def="f32 keyGuideHeight = 1"
            /// <summary>
            /// Blood Message - Key Guide Vertical Range (f32)
            /// </summary>
            /// <remarks>
            /// 
            /// </remarks>
            public float BloodMessageKeyGuideVerticalRange 
            {
                get => (float)CellsByName["BloodMessageKeyGuideVerticalRange"].Value;
                set => CellsByName["BloodMessageKeyGuideVerticalRange"].Value = value;
            }
            

            // Def="u32 reloadSignTotalCount = 1"
            /// <summary>
            /// Blood Message - Reload Sign Total Count (u32)
            /// </summary>
            /// <remarks>
            /// Actually u8 is enough
            /// </remarks>
            public uint BloodMessageReloadSignTotalCount 
            {
                get => (uint)CellsByName["BloodMessageReloadSignTotalCount"].Value;
                set => CellsByName["BloodMessageReloadSignTotalCount"].Value = value;
            }
            

            // Def="u32 reloadNewSignCellCount = 1"
            /// <summary>
            /// Blood Message - Reload New Sign Cell Count (u32)
            /// </summary>
            /// <remarks>
            /// Actually u8 is enough
            /// </remarks>
            public uint BloodMessageReloadNewSignCellCount 
            {
                get => (uint)CellsByName["BloodMessageReloadNewSignCellCount"].Value;
                set => CellsByName["BloodMessageReloadNewSignCellCount"].Value = value;
            }
            

            // Def="u32 reloadRandomSignCellCount = 1"
            /// <summary>
            /// Blood Message - Reload Random Sign Cell Count (u32)
            /// </summary>
            /// <remarks>
            /// Actually u8 is enough
            /// </remarks>
            public uint BloodMessageReloadRandomSignCellCount 
            {
                get => (uint)CellsByName["BloodMessageReloadRandomSignCellCount"].Value;
                set => CellsByName["BloodMessageReloadRandomSignCellCount"].Value = value;
            }
            

            // Def="u32 maxSignTotalCount = 1"
            /// <summary>
            /// Blood Message - Max Sign Total Count (u32)
            /// </summary>
            /// <remarks>
            /// Actually u16 is enough
            /// </remarks>
            public uint BloodMessageMaxSignTotalCount 
            {
                get => (uint)CellsByName["BloodMessageMaxSignTotalCount"].Value;
                set => CellsByName["BloodMessageMaxSignTotalCount"].Value = value;
            }
            

            // Def="u32 maxSignCellCount = 1"
            /// <summary>
            /// Blood Message - Max Sign Cell Count (u32)
            /// </summary>
            /// <remarks>
            /// Actually u8 is enough
            /// </remarks>
            public uint BloodMessageMaxSignCellCount 
            {
                get => (uint)CellsByName["BloodMessageMaxSignCellCount"].Value;
                set => CellsByName["BloodMessageMaxSignCellCount"].Value = value;
            }
            

            // Def="f32 basicExclusiveRange = 1"
            /// <summary>
            /// Blood Message - Basic Exclusive Range (f32)
            /// </summary>
            /// <remarks>
            /// 
            /// </remarks>
            public float BloodMessageBasicExclusiveRange 
            {
                get => (float)CellsByName["BloodMessageBasicExclusiveRange"].Value;
                set => CellsByName["BloodMessageBasicExclusiveRange"].Value = value;
            }
            

            // Def="f32 basicExclusiveHeight = 1"
            /// <summary>
            /// Blood Message - Basic Exclusive Height (f32)
            /// </summary>
            /// <remarks>
            /// 
            /// </remarks>
            public float BloodMessageBasicExclusiveHeight 
            {
                get => (float)CellsByName["BloodMessageBasicExclusiveHeight"].Value;
                set => CellsByName["BloodMessageBasicExclusiveHeight"].Value = value;
            }
            

            // Def="f32 signVisibleRange = 1"
            /// <summary>
            /// Blood Message - Sign Visible Range (f32)
            /// </summary>
            /// <remarks>
            /// 
            /// </remarks>
            public float BloodMessageSignVisibleRange 
            {
                get => (float)CellsByName["BloodMessageSignVisibleRange"].Value;
                set => CellsByName["BloodMessageSignVisibleRange"].Value = value;
            }
            

            // Def="u32 maxWriteSignCount = 1"
            /// <summary>
            /// Blood Message - Max Write Sign Count (u32)
            /// </summary>
            /// <remarks>
            /// Actually u8 is enough
            /// </remarks>
            public uint BloodMessageMaxWriteSignCount 
            {
                get => (uint)CellsByName["BloodMessageMaxWriteSignCount"].Value;
                set => CellsByName["BloodMessageMaxWriteSignCount"].Value = value;
            }
            

            // Def="u32 maxReadSignCount = 1"
            /// <summary>
            /// Blood Message - Max Read Sign Count (u32)
            /// </summary>
            /// <remarks>
            /// Actually u8 is enough
            /// </remarks>
            public uint BloodMessageMaxReadSignCount 
            {
                get => (uint)CellsByName["BloodMessageMaxReadSignCount"].Value;
                set => CellsByName["BloodMessageMaxReadSignCount"].Value = value;
            }
            

            // Def="f32 reloadSignIntervalTime = 1"
            /// <summary>
            /// Blood Message - Reload Sign Interval Time (f32)
            /// </summary>
            /// <remarks>
            /// 
            /// </remarks>
            public float BloodMessageReloadSignIntervalTime 
            {
                get => (float)CellsByName["BloodMessageReloadSignIntervalTime"].Value;
                set => CellsByName["BloodMessageReloadSignIntervalTime"].Value = value;
            }
            

            // Def="u32 cellGroupHorizontalRange = 1"
            /// <summary>
            /// Blood Message - Cell Group Horizontal Range (u32)
            /// </summary>
            /// <remarks>
            /// Actually u8 is enough
            /// </remarks>
            public uint BloodMessageCellGroupHorizontalRange 
            {
                get => (uint)CellsByName["BloodMessageCellGroupHorizontalRange"].Value;
                set => CellsByName["BloodMessageCellGroupHorizontalRange"].Value = value;
            }
            

            // Def="u32 cellGroupTopRange = 1"
            /// <summary>
            /// Blood Message - Cell Group Top Range (u32)
            /// </summary>
            /// <remarks>
            /// Actually u8 is enough
            /// </remarks>
            public uint BloodMessageCellGroupTopRange 
            {
                get => (uint)CellsByName["BloodMessageCellGroupTopRange"].Value;
                set => CellsByName["BloodMessageCellGroupTopRange"].Value = value;
            }
            

            // Def="u32 cellGroupBottomRange = 1"
            /// <summary>
            /// Blood Message - Cell Group Bottom Range (u32)
            /// </summary>
            /// <remarks>
            /// Actually u8 is enough
            /// </remarks>
            public uint BloodMessageCellGroupBottomRange 
            {
                get => (uint)CellsByName["BloodMessageCellGroupBottomRange"].Value;
                set => CellsByName["BloodMessageCellGroupBottomRange"].Value = value;
            }
            

            // Def="u32 lifeTime = 1"
            /// <summary>
            /// Blood Message - Lifetime (u32)
            /// </summary>
            /// <remarks>
            /// Actually u16 is enough
            /// </remarks>
            public uint BloodMessageLifetime 
            {
                get => (uint)CellsByName["BloodMessageLifetime"].Value;
                set => CellsByName["BloodMessageLifetime"].Value = value;
            }
            

            // Def="f32 downloadSpan"
            /// <summary>
            /// Blood Message - Download Span (f32)
            /// </summary>
            /// <remarks>
            /// 
            /// </remarks>
            public float BloodMessageDownloadSpan 
            {
                get => (float)CellsByName["BloodMessageDownloadSpan"].Value;
                set => CellsByName["BloodMessageDownloadSpan"].Value = value;
            }
            

            // Def="f32 downloadEvaluationSpan"
            /// <summary>
            /// Blood Message - Download Evaluation Span (f32)
            /// </summary>
            /// <remarks>
            /// 
            /// </remarks>
            public float BloodMessageDownloadEvaluationSpan 
            {
                get => (float)CellsByName["BloodMessageDownloadEvaluationSpan"].Value;
                set => CellsByName["BloodMessageDownloadEvaluationSpan"].Value = value;
            }
            


            // Def="f32 deadingGhostStartPosThreshold = 1"
            /// <summary>
            /// Bloodstain - Dead Ghost Start Position Threshold (f32)
            /// </summary>
            /// <remarks>
            /// If the distance between the bloodstain position and the illusion start position is farther than this value, the server will not be registered.
            /// </remarks>
            public float BloodstainDeadGhostStartPositionThreshold 
            {
                get => (float)CellsByName["BloodstainDeadGhostStartPositionThreshold"].Value;
                set => CellsByName["BloodstainDeadGhostStartPositionThreshold"].Value = value;
            }
            

            // Def="f32 keyGuideHeight = 1"
            /// <summary>
            /// Bloodstain - Key Guide Height (f32)
            /// </summary>
            /// <remarks>
            /// 
            /// </remarks>
            public float BloodstainKeyGuideHeight 
            {
                get => (float)CellsByName["BloodstainKeyGuideHeight"].Value;
                set => CellsByName["BloodstainKeyGuideHeight"].Value = value;
            }
            

            // Def="f32 keyGuideRangePlayer = 1"
            /// <summary>
            /// Bloodstain - Key Guide Range Player (f32)
            /// </summary>
            /// <remarks>
            /// 
            /// </remarks>
            public float BloodstainKeyGuideRangePlayer 
            {
                get => (float)CellsByName["BloodstainKeyGuideRangePlayer"].Value;
                set => CellsByName["BloodstainKeyGuideRangePlayer"].Value = value;
            }
            

            // Def="f32 keyGuideHeightPlayer = 1"
            /// <summary>
            /// Bloodstain - Key Guide Height Player (f32)
            /// </summary>
            /// <remarks>
            /// 
            /// </remarks>
            public float BloodstainKeyGuideHeightPlayer 
            {
                get => (float)CellsByName["BloodstainKeyGuideHeightPlayer"].Value;
                set => CellsByName["BloodstainKeyGuideHeightPlayer"].Value = value;
            }
            

            // Def="u32 reloadSignTotalCount = 1"
            /// <summary>
            /// Bloodstain - Reload Sign Total Count (u32)
            /// </summary>
            /// <remarks>
            /// Actually u8 is enough
            /// </remarks>
            public uint BloodstainReloadSignTotalCount 
            {
                get => (uint)CellsByName["BloodstainReloadSignTotalCount"].Value;
                set => CellsByName["BloodstainReloadSignTotalCount"].Value = value;
            }
            

            // Def="u32 reloadSignCellCount = 1"
            /// <summary>
            /// Bloodstain - Reload Sign Cell Count (u32)
            /// </summary>
            /// <remarks>
            /// Actually u8 is enough
            /// </remarks>
            public uint BloodstainReloadSignCellCount 
            {
                get => (uint)CellsByName["BloodstainReloadSignCellCount"].Value;
                set => CellsByName["BloodstainReloadSignCellCount"].Value = value;
            }
            

            // Def="u32 maxSignTotalCount = 1"
            /// <summary>
            /// Bloodstain - Max Sign Total Count (u32)
            /// </summary>
            /// <remarks>
            /// Actually u16 is enough
            /// </remarks>
            public uint BloodstainMaxSignTotalCount 
            {
                get => (uint)CellsByName["BloodstainMaxSignTotalCount"].Value;
                set => CellsByName["BloodstainMaxSignTotalCount"].Value = value;
            }
            

            // Def="u32 maxSignCellCount = 1"
            /// <summary>
            /// Bloodstain - Max Sign Cell Count (u32)
            /// </summary>
            /// <remarks>
            /// Actually u8 is enough
            /// </remarks>
            public uint BloodstainMaxSignCellCount 
            {
                get => (uint)CellsByName["BloodstainMaxSignCellCount"].Value;
                set => CellsByName["BloodstainMaxSignCellCount"].Value = value;
            }
            

            // Def="f32 reloadSignIntervalTime = 1"
            /// <summary>
            /// Bloodstain - Reload Sign Interval Time (f32)
            /// </summary>
            /// <remarks>
            /// 
            /// </remarks>
            public float BloodstainReloadSignIntervalTime 
            {
                get => (float)CellsByName["BloodstainReloadSignIntervalTime"].Value;
                set => CellsByName["BloodstainReloadSignIntervalTime"].Value = value;
            }
            

            // Def="f32 signVisibleRange = 1"
            /// <summary>
            /// Bloodstain - Sign Visible Range (f32)
            /// </summary>
            /// <remarks>
            /// 
            /// </remarks>
            public float BloodstainSignVisibleRange 
            {
                get => (float)CellsByName["BloodstainSignVisibleRange"].Value;
                set => CellsByName["BloodstainSignVisibleRange"].Value = value;
            }
            

            // Def="f32 basicExclusiveRange = 1"
            /// <summary>
            /// Bloodstain - Basic Exclusive Range (f32)
            /// </summary>
            /// <remarks>
            /// 
            /// </remarks>
            public float BloodstainBasicExclusiveRange 
            {
                get => (float)CellsByName["BloodstainBasicExclusiveRange"].Value;
                set => CellsByName["BloodstainBasicExclusiveRange"].Value = value;
            }
            

            // Def="f32 basicExclusiveHeight = 1"
            /// <summary>
            /// Bloodstain - Basic Exclusive Height (f32)
            /// </summary>
            /// <remarks>
            /// 
            /// </remarks>
            public float BloodstainBasicExclusiveHeight 
            {
                get => (float)CellsByName["BloodstainBasicExclusiveHeight"].Value;
                set => CellsByName["BloodstainBasicExclusiveHeight"].Value = value;
            }
            

            // Def="u32 cellGroupHorizontalRange = 1"
            /// <summary>
            /// Bloodstain - Cell Group Horizontal Range (u32)
            /// </summary>
            /// <remarks>
            /// Actually u8 is enough
            /// </remarks>
            public uint BloodstainCellGroupHorizontalRange 
            {
                get => (uint)CellsByName["BloodstainCellGroupHorizontalRange"].Value;
                set => CellsByName["BloodstainCellGroupHorizontalRange"].Value = value;
            }
            

            // Def="u32 cellGroupTopRange = 1"
            /// <summary>
            /// Bloodstain - Cell Group Top Range (u32)
            /// </summary>
            /// <remarks>
            /// Actually u8 is enough
            /// </remarks>
            public uint BloodstainCellGroupTopRange 
            {
                get => (uint)CellsByName["BloodstainCellGroupTopRange"].Value;
                set => CellsByName["BloodstainCellGroupTopRange"].Value = value;
            }
            

            // Def="u32 cellGroupBottomRange = 1"
            /// <summary>
            /// Bloodstain - Cell Group Bottom Range (u32)
            /// </summary>
            /// <remarks>
            /// Actually u8 is enough
            /// </remarks>
            public uint BloodstainCellGroupBottomRange 
            {
                get => (uint)CellsByName["BloodstainCellGroupBottomRange"].Value;
                set => CellsByName["BloodstainCellGroupBottomRange"].Value = value;
            }
            

            // Def="u32 lifeTime = 1"
            /// <summary>
            /// Bloodstain - Lifetime (u32)
            /// </summary>
            /// <remarks>
            /// Actually u16 is enough
            /// </remarks>
            public uint BloodstainLifetime 
            {
                get => (uint)CellsByName["BloodstainLifetime"].Value;
                set => CellsByName["BloodstainLifetime"].Value = value;
            }
            

            // Def="f32 recordDeadingGhostTotalTime"
            /// <summary>
            /// Bloodstain - Record Dead Ghost Total Time (f32)
            /// </summary>
            /// <remarks>
            /// 
            /// </remarks>
            public float BloodstainRecordDeadGhostTotalTime 
            {
                get => (float)CellsByName["BloodstainRecordDeadGhostTotalTime"].Value;
                set => CellsByName["BloodstainRecordDeadGhostTotalTime"].Value = value;
            }
            

            // Def="f32 recordDeadingGhostMinTime = 5"
            /// <summary>
            /// Bloodstain - Record Dead Ghost Min Time (f32)
            /// </summary>
            /// <remarks>
            /// Death illusions less than this recording time will not register the server
            /// </remarks>
            public float BloodstainRecordDeadGhostMinTime 
            {
                get => (float)CellsByName["BloodstainRecordDeadGhostMinTime"].Value;
                set => CellsByName["BloodstainRecordDeadGhostMinTime"].Value = value;
            }
            

            // Def="f32 downloadSpan"
            /// <summary>
            /// Bloodstain - Download Span (f32)
            /// </summary>
            /// <remarks>
            /// 
            /// </remarks>
            public float BloodstainDownloadSpan 
            {
                get => (float)CellsByName["BloodstainDownloadSpan"].Value;
                set => CellsByName["BloodstainDownloadSpan"].Value = value;
            }
            

            // Def="f32 statueCreatableDistance = 80"
            /// <summary>
            /// Bloodstain - Statue Creatable Distance (f32)
            /// </summary>
            /// <remarks>
            /// For open fields. When a stone statue is generated, it can be generated if the distance between the PC and the generation position is greater than or equal to this value.
            /// </remarks>
            public float BloodstainStatueCreatableDistance 
            {
                get => (float)CellsByName["BloodstainStatueCreatableDistance"].Value;
                set => CellsByName["BloodstainStatueCreatableDistance"].Value = value;
            }
            

            // Def="u32 reloadGhostTotalCount = 1"
            /// <summary>
            /// Ghost - Reload Ghost Total Count (u32)
            /// </summary>
            /// <remarks>
            /// Actually u8 is enough
            /// </remarks>
            public uint GhostReloadGhostTotalCount 
            {
                get => (uint)CellsByName["GhostReloadGhostTotalCount"].Value;
                set => CellsByName["GhostReloadGhostTotalCount"].Value = value;
            }
            

            // Def="u32 reloadGhostCellCount = 1"
            /// <summary>
            /// Ghost - Reload Ghost Cell Count (u32)
            /// </summary>
            /// <remarks>
            /// Actually u8 is enough
            /// </remarks>
            public uint GhostReloadGhostCellCount 
            {
                get => (uint)CellsByName["GhostReloadGhostCellCount"].Value;
                set => CellsByName["GhostReloadGhostCellCount"].Value = value;
            }
            

            // Def="u32 maxGhostTotalCount = 1"
            /// <summary>
            /// Ghost - Max Ghost Total Count (u32)
            /// </summary>
            /// <remarks>
            /// Actually u16 is enough
            /// </remarks>
            public uint GhostMaxGhostTotalCount 
            {
                get => (uint)CellsByName["GhostMaxGhostTotalCount"].Value;
                set => CellsByName["GhostMaxGhostTotalCount"].Value = value;
            }
            

            // Def="f32 distanceOfBeginRecordVersus = 1"
            /// <summary>
            /// Ghost - Begin Record Distance (Versus) (f32)
            /// </summary>
            /// <remarks>
            /// 
            /// </remarks>
            public float GhostBeginRecordDistanceVersus 
            {
                get => (float)CellsByName["GhostBeginRecordDistanceVersus"].Value;
                set => CellsByName["GhostBeginRecordDistanceVersus"].Value = value;
            }
            

            // Def="f32 distanceOfEndRecordVersus = 1"
            /// <summary>
            /// Ghost - End Record Distance (Versus) (f32)
            /// </summary>
            /// <remarks>
            /// 
            /// </remarks>
            public float GhostEndRecordDistanceVersus 
            {
                get => (float)CellsByName["GhostEndRecordDistanceVersus"].Value;
                set => CellsByName["GhostEndRecordDistanceVersus"].Value = value;
            }
            

            // Def="f32 updateWanderGhostIntervalTime = 1"
            /// <summary>
            /// Ghost - Update Wandering Ghost Interval Time (f32)
            /// </summary>
            /// <remarks>
            /// 
            /// </remarks>
            public float GhostUpdateWanderingGhostIntervalTime 
            {
                get => (float)CellsByName["GhostUpdateWanderingGhostIntervalTime"].Value;
                set => CellsByName["GhostUpdateWanderingGhostIntervalTime"].Value = value;
            }
            

            // Def="f32 updateVersusGhostIntervalTime = 1"
            /// <summary>
            /// Ghost - Update Versus Ghost Interval Time (f32)
            /// </summary>
            /// <remarks>
            /// 
            /// </remarks>
            public float GhostUpdateVersusGhostIntervalTime 
            {
                get => (float)CellsByName["GhostUpdateVersusGhostIntervalTime"].Value;
                set => CellsByName["GhostUpdateVersusGhostIntervalTime"].Value = value;
            }
            

            // Def="f32 recordWanderingGhostTime = 1"
            /// <summary>
            /// Ghost - Record Wandering Ghost Time (f32)
            /// </summary>
            /// <remarks>
            /// 
            /// </remarks>
            public float GhostRecordWanderingGhostTime 
            {
                get => (float)CellsByName["GhostRecordWanderingGhostTime"].Value;
                set => CellsByName["GhostRecordWanderingGhostTime"].Value = value;
            }
            

            // Def="f32 recordWanderingGhostMinTime = 5"
            /// <summary>
            /// Ghost - Record Wandering Ghost Min Time (f32)
            /// </summary>
            /// <remarks>
            /// Wandering illusions less than this recording time do not register the server
            /// </remarks>
            public float GhostRecordWanderingGhostMinTime 
            {
                get => (float)CellsByName["GhostRecordWanderingGhostMinTime"].Value;
                set => CellsByName["GhostRecordWanderingGhostMinTime"].Value = value;
            }
            

            // Def="f32 updateBonfireGhostIntervalTime = 1"
            /// <summary>
            /// Ghost - Update Bonfire Ghost Interval Time (f32)
            /// </summary>
            /// <remarks>
            /// 
            /// </remarks>
            public float GhostUpdateBonfireGhostIntervalTime 
            {
                get => (float)CellsByName["GhostUpdateBonfireGhostIntervalTime"].Value;
                set => CellsByName["GhostUpdateBonfireGhostIntervalTime"].Value = value;
            }
            

            // Def="f32 replayGhostRangeOnView = 1"
            /// <summary>
            /// Ghost - Replay Ghost Range On View (f32)
            /// </summary>
            /// <remarks>
            /// 
            /// </remarks>
            public float GhostReplayGhostRangeOnView 
            {
                get => (float)CellsByName["GhostReplayGhostRangeOnView"].Value;
                set => CellsByName["GhostReplayGhostRangeOnView"].Value = value;
            }
            

            // Def="f32 replayGhostRangeOutView = 1"
            /// <summary>
            /// Ghost - Replay Ghost Range Out View (f32)
            /// </summary>
            /// <remarks>
            /// 
            /// </remarks>
            public float GhostReplayGhostRangeOutView 
            {
                get => (float)CellsByName["GhostReplayGhostRangeOutView"].Value;
                set => CellsByName["GhostReplayGhostRangeOutView"].Value = value;
            }
            

            // Def="f32 replayBonfireGhostTime = 1"
            /// <summary>
            /// Ghost - Replay Bonfire Ghost Time (f32)
            /// </summary>
            /// <remarks>
            /// 
            /// </remarks>
            public float GhostReplayBonfireGhostTime 
            {
                get => (float)CellsByName["GhostReplayBonfireGhostTime"].Value;
                set => CellsByName["GhostReplayBonfireGhostTime"].Value = value;
            }
            

            // Def="f32 minBonfireGhostValidRange = 1"
            /// <summary>
            /// Ghost - Bonfire Ghost Min Valid Range (f32)
            /// </summary>
            /// <remarks>
            /// Do not place bonfire illusions less than this distance from the bonfire
            /// </remarks>
            public float GhostBonfireGhostMinValidRange 
            {
                get => (float)CellsByName["GhostBonfireGhostMinValidRange"].Value;
                set => CellsByName["GhostBonfireGhostMinValidRange"].Value = value;
            }
            

            // Def="f32 maxBonfireGhostValidRange = 1"
            /// <summary>
            /// Ghost - Bonfire Ghost Max Valid Range (f32)
            /// </summary>
            /// <remarks>
            /// Do not place bonfire illusions beyond this distance from the bonfire
            /// </remarks>
            public float GhostBonfireGhostMaxValidRange 
            {
                get => (float)CellsByName["GhostBonfireGhostMaxValidRange"].Value;
                set => CellsByName["GhostBonfireGhostMaxValidRange"].Value = value;
            }
            

            // Def="f32 minReplayIntervalTime = 1"
            /// <summary>
            /// Ghost - Replay Interval Min Time (f32)
            /// </summary>
            /// <remarks>
            /// 
            /// </remarks>
            public float GhostReplayIntervalMinTime 
            {
                get => (float)CellsByName["GhostReplayIntervalMinTime"].Value;
                set => CellsByName["GhostReplayIntervalMinTime"].Value = value;
            }
            

            // Def="f32 maxReplayIntervalTime = 1"
            /// <summary>
            /// Ghost - Replay Interval Max Time (f32)
            /// </summary>
            /// <remarks>
            /// 
            /// </remarks>
            public float GhostReplayIntervalMaxTime 
            {
                get => (float)CellsByName["GhostReplayIntervalMaxTime"].Value;
                set => CellsByName["GhostReplayIntervalMaxTime"].Value = value;
            }
            

            // Def="f32 reloadGhostIntervalTime = 1"
            /// <summary>
            /// Ghost - Reload Ghost Interval Time (f32)
            /// </summary>
            /// <remarks>
            /// 
            /// </remarks>
            public float GhostReloadGhostIntervalTime 
            {
                get => (float)CellsByName["GhostReloadGhostIntervalTime"].Value;
                set => CellsByName["GhostReloadGhostIntervalTime"].Value = value;
            }
            

            // Def="u32 cellGroupHorizontalRange = 1"
            /// <summary>
            /// Ghost - Cell Group Horizontal Range (u32)
            /// </summary>
            /// <remarks>
            /// Actually u8 is enough
            /// </remarks>
            public uint GhostCellGroupHorizontalRange 
            {
                get => (uint)CellsByName["GhostCellGroupHorizontalRange"].Value;
                set => CellsByName["GhostCellGroupHorizontalRange"].Value = value;
            }
            

            // Def="u32 cellGroupTopRange = 1"
            /// <summary>
            /// Ghost - Cell Group Top Range (u32)
            /// </summary>
            /// <remarks>
            /// Actually u8 is enough
            /// </remarks>
            public uint GhostCellGroupTopRange 
            {
                get => (uint)CellsByName["GhostCellGroupTopRange"].Value;
                set => CellsByName["GhostCellGroupTopRange"].Value = value;
            }
            

            // Def="s32 replayBonfirePhantomParamIdForCodename"
            /// <summary>
            /// Ghost - Replay Bonfire Phantom Param ID (CodeDisplayName) (s32)
            /// </summary>
            /// <remarks>
            /// Phantom bonfire mode phantom parameter ID used when codename matches
            /// </remarks>
            public int GhostReplayBonfirePhantomParamIDCodeDisplayName 
            {
                get => (int)CellsByName["GhostReplayBonfirePhantomParamIDCodeDisplayName"].Value;
                set => CellsByName["GhostReplayBonfirePhantomParamIDCodeDisplayName"].Value = value;
            }
            

            // Def="f32 replayBonfireModeRange = 1"
            /// <summary>
            /// Ghost - Replay Bonfire Mode Range (f32)
            /// </summary>
            /// <remarks>
            /// 
            /// </remarks>
            public float GhostReplayBonfireModeRange 
            {
                get => (float)CellsByName["GhostReplayBonfireModeRange"].Value;
                set => CellsByName["GhostReplayBonfireModeRange"].Value = value;
            }
            

            // Def="s32 replayBonfirePhantomParamId"
            /// <summary>
            /// Ghost - Replay Bonfire Phantom Param ID (s32)
            /// </summary>
            /// <remarks>
            /// Phantom bonfire mode phantom parameter ID
            /// </remarks>
            public int GhostReplayBonfirePhantomParamID 
            {
                get => (int)CellsByName["GhostReplayBonfirePhantomParamID"].Value;
                set => CellsByName["GhostReplayBonfirePhantomParamID"].Value = value;
            }
            


            // Def="f32 reloadVisitListCoolTime = 1"
            /// <summary>
            /// Visit - Reload Visit List Cool time (f32)
            /// </summary>
            /// <remarks>
            /// 
            /// </remarks>
            public float VisitReloadVisitListCoolTime 
            {
                get => (float)CellsByName["VisitReloadVisitListCoolTime"].Value;
                set => CellsByName["VisitReloadVisitListCoolTime"].Value = value;
            }
            

            // Def="u32 maxCoopBlueSummonCount = 1"
            /// <summary>
            /// Visit - Max Coop Blue Summon Count (u32)
            /// </summary>
            /// <remarks>
            /// Actually u8 is enough
            /// </remarks>
            public uint VisitMaxCoopBlueSummonCount 
            {
                get => (uint)CellsByName["VisitMaxCoopBlueSummonCount"].Value;
                set => CellsByName["VisitMaxCoopBlueSummonCount"].Value = value;
            }
            

            // Def="u32 maxBellGuardSummonCount = 1"
            /// <summary>
            /// Visit - Max Bell Guard Summon Count (u32)
            /// </summary>
            /// <remarks>
            /// Actually u8 is enough
            /// </remarks>
            public uint VisitMaxBellGuardSummonCount 
            {
                get => (uint)CellsByName["VisitMaxBellGuardSummonCount"].Value;
                set => CellsByName["VisitMaxBellGuardSummonCount"].Value = value;
            }
            

            // Def="u32 maxVisitListCount = 1"
            /// <summary>
            /// Visit - Max Visit List Count (u32)
            /// </summary>
            /// <remarks>
            /// 
            /// </remarks>
            public uint VisitMaxVisitListCount 
            {
                get => (uint)CellsByName["VisitMaxVisitListCount"].Value;
                set => CellsByName["VisitMaxVisitListCount"].Value = value;
            }
            

            // Def="f32 reloadSearch_CoopBlue_Min"
            /// <summary>
            /// Visit - Reload Search - Coop Blue - Min (f32)
            /// </summary>
            /// <remarks>
            /// 
            /// </remarks>
            public float VisitReloadSearchCoopBlueMin 
            {
                get => (float)CellsByName["VisitReloadSearchCoopBlueMin"].Value;
                set => CellsByName["VisitReloadSearchCoopBlueMin"].Value = value;
            }
            

            // Def="f32 reloadSearch_CoopBlue_Max"
            /// <summary>
            /// Visit - Reload Search - Coop Blue - Max (f32)
            /// </summary>
            /// <remarks>
            /// 
            /// </remarks>
            public float VisitReloadSearchCoopBlueMax 
            {
                get => (float)CellsByName["VisitReloadSearchCoopBlueMax"].Value;
                set => CellsByName["VisitReloadSearchCoopBlueMax"].Value = value;
            }
            

            // Def="f32 reloadSearch_BellGuard_Min"
            /// <summary>
            /// Visit - Reload Search - Bell Guard - Min (f32)
            /// </summary>
            /// <remarks>
            /// 
            /// </remarks>
            public float VisitReloadSearchBellGuardMin 
            {
                get => (float)CellsByName["VisitReloadSearchBellGuardMin"].Value;
                set => CellsByName["VisitReloadSearchBellGuardMin"].Value = value;
            }
            

            // Def="f32 reloadSearch_BellGuard_Max"
            /// <summary>
            /// Visit - Reload Search - Bell Guard - Max (f32)
            /// </summary>
            /// <remarks>
            /// 
            /// </remarks>
            public float VisitReloadSearchBellGuardMax 
            {
                get => (float)CellsByName["VisitReloadSearchBellGuardMax"].Value;
                set => CellsByName["VisitReloadSearchBellGuardMax"].Value = value;
            }
            

            // Def="f32 reloadSearch_RatKing_Min"
            /// <summary>
            /// Visit - Reload Search - Rat King - Min (f32)
            /// </summary>
            /// <remarks>
            /// 
            /// </remarks>
            public float VisitReloadSearchRatKingMin 
            {
                get => (float)CellsByName["VisitReloadSearchRatKingMin"].Value;
                set => CellsByName["VisitReloadSearchRatKingMin"].Value = value;
            }
            

            // Def="f32 reloadSearch_RatKing_Max"
            /// <summary>
            /// Visit - Reload Search - Rat King - Max (f32)
            /// </summary>
            /// <remarks>
            /// 
            /// </remarks>
            public float VisitReloadSearchRatKingMax 
            {
                get => (float)CellsByName["VisitReloadSearchRatKingMax"].Value;
                set => CellsByName["VisitReloadSearchRatKingMax"].Value = value;
            }
            


            // Def="f32 srttMaxLimit = 1000"
            /// <summary>
            /// Extra - SSRT Max Limit (f32)
            /// </summary>
            /// <remarks>
            /// 
            /// </remarks>
            public float ExtraSSRTMaxLimit 
            {
                get => (float)CellsByName["ExtraSSRTMaxLimit"].Value;
                set => CellsByName["ExtraSSRTMaxLimit"].Value = value;
            }
            

            // Def="f32 srttMeanLimit = 1000"
            /// <summary>
            /// Extra - SSRT Mean Limit (f32)
            /// </summary>
            /// <remarks>
            /// 
            /// </remarks>
            public float ExtraSSRTMeanLimit 
            {
                get => (float)CellsByName["ExtraSSRTMeanLimit"].Value;
                set => CellsByName["ExtraSSRTMeanLimit"].Value = value;
            }
            

            // Def="f32 srttMeanDeviationLimit = 1000"
            /// <summary>
            /// Extra - SSRT Mean Deviation Limit (f32)
            /// </summary>
            /// <remarks>
            /// 
            /// </remarks>
            public float ExtraSSRTMeanDeviationLimit 
            {
                get => (float)CellsByName["ExtraSSRTMeanDeviationLimit"].Value;
                set => CellsByName["ExtraSSRTMeanDeviationLimit"].Value = value;
            }
            

            // Def="f32 darkPhantomLimitBoostTime = 1000"
            /// <summary>
            /// Extra - Dark Phantom Limit Boost Time (f32)
            /// </summary>
            /// <remarks>
            /// 
            /// </remarks>
            public float ExtraDarkPhantomLimitBoostTime 
            {
                get => (float)CellsByName["ExtraDarkPhantomLimitBoostTime"].Value;
                set => CellsByName["ExtraDarkPhantomLimitBoostTime"].Value = value;
            }
            

            // Def="f32 darkPhantomLimitBoostScale = 1000"
            /// <summary>
            /// Extra - Dark Phantom Limit Boost Scale (f32)
            /// </summary>
            /// <remarks>
            /// 
            /// </remarks>
            public float ExtraDarkPhantomLimitBoostScale 
            {
                get => (float)CellsByName["ExtraDarkPhantomLimitBoostScale"].Value;
                set => CellsByName["ExtraDarkPhantomLimitBoostScale"].Value = value;
            }
            

            // Def="f32 multiplayDisableLifeTime = 1"
            /// <summary>
            /// Extra - Multiplayer Disable Lifetime (f32)
            /// </summary>
            /// <remarks>
            /// 
            /// </remarks>
            public float ExtraMultiplayerDisableLifetime 
            {
                get => (float)CellsByName["ExtraMultiplayerDisableLifetime"].Value;
                set => CellsByName["ExtraMultiplayerDisableLifetime"].Value = value;
            }
            

            // Def="u8 abyssMultiplayLimit = 10"
            /// <summary>
            /// Extra - Abyss Multiplayer Limit (u8)
            /// </summary>
            /// <remarks>
            /// The number of times the abyss spirit enters the host in the abyss area
            /// </remarks>
            public byte ExtraAbyssMultiplayerLimit 
            {
                get => (byte)CellsByName["ExtraAbyssMultiplayerLimit"].Value;
                set => CellsByName["ExtraAbyssMultiplayerLimit"].Value = value;
            }
            

            // Def="u8 phantomWarpMinimumTime = 5"
            /// <summary>
            /// Extra - Phantom Warp Minimum Time (u8)
            /// </summary>
            /// <remarks>
            /// 
            /// </remarks>
            public byte ExtraPhantomWarpMinimumTime 
            {
                get => (byte)CellsByName["ExtraPhantomWarpMinimumTime"].Value;
                set => CellsByName["ExtraPhantomWarpMinimumTime"].Value = value;
            }
            

            // Def="u8 phantomReturnDelayTime = 5"
            /// <summary>
            /// Extra - Phantom Return Delay Time (u8)
            /// </summary>
            /// <remarks>
            /// 
            /// </remarks>
            public byte ExtraPhantomReturnDelayTime 
            {
                get => (byte)CellsByName["ExtraPhantomReturnDelayTime"].Value;
                set => CellsByName["ExtraPhantomReturnDelayTime"].Value = value;
            }
            

            // Def="u8 terminateTimeoutTime = 30"
            /// <summary>
            /// Extra - Terminate Timeout Time (u8)
            /// </summary>
            /// <remarks>
            /// 
            /// </remarks>
            public byte ExtraTerminateTimeoutTime 
            {
                get => (byte)CellsByName["ExtraTerminateTimeoutTime"].Value;
                set => CellsByName["ExtraTerminateTimeoutTime"].Value = value;
            }
            

            // Def="u16 penaltyPointLanDisconnect"
            /// <summary>
            /// Extra - Penalty Point LAN Disconnet (u16)
            /// </summary>
            /// <remarks>
            /// 
            /// </remarks>
            public ushort ExtraPenaltyPointLANDisconnet 
            {
                get => (ushort)CellsByName["ExtraPenaltyPointLANDisconnet"].Value;
                set => CellsByName["ExtraPenaltyPointLANDisconnet"].Value = value;
            }
            

            // Def="u16 penaltyPointSignout"
            /// <summary>
            /// Extra - Penalty Point Signout (u16)
            /// </summary>
            /// <remarks>
            /// 
            /// </remarks>
            public ushort ExtraPenaltyPointSignout 
            {
                get => (ushort)CellsByName["ExtraPenaltyPointSignout"].Value;
                set => CellsByName["ExtraPenaltyPointSignout"].Value = value;
            }
            

            // Def="u16 penaltyPointReboot"
            /// <summary>
            /// Extra - Penalty Point Reboot (u16)
            /// </summary>
            /// <remarks>
            /// 
            /// </remarks>
            public ushort ExtraPenaltyPointReboot 
            {
                get => (ushort)CellsByName["ExtraPenaltyPointReboot"].Value;
                set => CellsByName["ExtraPenaltyPointReboot"].Value = value;
            }
            

            // Def="u16 penaltyPointBeginPenalize"
            /// <summary>
            /// Extra - Penalty Point Begin Penalize (u16)
            /// </summary>
            /// <remarks>
            /// 
            /// </remarks>
            public ushort ExtraPenaltyPointBeginPenalize 
            {
                get => (ushort)CellsByName["ExtraPenaltyPointBeginPenalize"].Value;
                set => CellsByName["ExtraPenaltyPointBeginPenalize"].Value = value;
            }
            

            // Def="f32 penaltyForgiveItemLimitTime"
            /// <summary>
            /// Extra - Penalty Forgive Item Limit Time (f32)
            /// </summary>
            /// <remarks>
            /// 
            /// </remarks>
            public float ExtraPenaltyForgiveItemLimitTime 
            {
                get => (float)CellsByName["ExtraPenaltyForgiveItemLimitTime"].Value;
                set => CellsByName["ExtraPenaltyForgiveItemLimitTime"].Value = value;
            }
            

            // Def="u8 allAreaSearchRate_CoopBlue"
            /// <summary>
            /// Extra - All Area Search Rate - Coop Blue (u8)
            /// </summary>
            /// <remarks>
            /// Percentage of searching for intrusion targets from all areas (%)
            /// </remarks>
            public byte ExtraAllAreaSearchRateCoopBlue 
            {
                get => (byte)CellsByName["ExtraAllAreaSearchRateCoopBlue"].Value;
                set => CellsByName["ExtraAllAreaSearchRateCoopBlue"].Value = value;
            }
            

            // Def="u8 allAreaSearchRate_VsBlue"
            /// <summary>
            /// Extra - All Area Search Rate - Vs. Coop Blue (u8)
            /// </summary>
            /// <remarks>
            /// Percentage of searching for intrusion targets from all areas (%)
            /// </remarks>
            public byte ExtraAllAreaSearchRateVsCoopBlue 
            {
                get => (byte)CellsByName["ExtraAllAreaSearchRateVsCoopBlue"].Value;
                set => CellsByName["ExtraAllAreaSearchRateVsCoopBlue"].Value = value;
            }
            

            // Def="u8 allAreaSearchRate_BellGuard"
            /// <summary>
            /// Extra - All Area Search Rate - Bell Guard (u8)
            /// </summary>
            /// <remarks>
            /// Percentage of searching for intrusion targets from all areas (%)
            /// </remarks>
            public byte ExtraAllAreaSearchRateBellGuard 
            {
                get => (byte)CellsByName["ExtraAllAreaSearchRateBellGuard"].Value;
                set => CellsByName["ExtraAllAreaSearchRateBellGuard"].Value = value;
            }
            

            // Def="u8 bloodMessageEvalHealRate = 100"
            /// <summary>
            /// Extra - Blood Message Eval Heal Rate (u8)
            /// </summary>
            /// <remarks>
            /// 
            /// </remarks>
            public byte ExtraBloodMessageEvalHealRate 
            {
                get => (byte)CellsByName["ExtraBloodMessageEvalHealRate"].Value;
                set => CellsByName["ExtraBloodMessageEvalHealRate"].Value = value;
            }
            

            // Def="u32 smallGoldSuccessHostRewardId"
            /// <summary>
            /// Extra - Small Gold Success Host Reward ID (u32)
            /// </summary>
            /// <remarks>
            /// 
            /// </remarks>
            public uint ExtraSmallGoldSuccessHostRewardID 
            {
                get => (uint)CellsByName["ExtraSmallGoldSuccessHostRewardID"].Value;
                set => CellsByName["ExtraSmallGoldSuccessHostRewardID"].Value = value;
            }
            

            // Def="f32 doorInvalidPlayAreaExtents = 1"
            /// <summary>
            /// Extra - Door Invalid Play Area Extents (f32)
            /// </summary>
            /// <remarks>
            /// The area around the black door that separates the multiplayer area is set to the systematically invalid play area (-1). At that time, make the invalid area thicker with this parameter on the thinner side of the OBJ's bounding box with a black door.
            /// </remarks>
            public float ExtraDoorInvalidPlayAreaExtents 
            {
                get => (float)CellsByName["ExtraDoorInvalidPlayAreaExtents"].Value;
                set => CellsByName["ExtraDoorInvalidPlayAreaExtents"].Value = value;
            }
            

            // Def="u8 signDisplayMax = 10"
            /// <summary>
            /// Extra - Sign Display Max (u8)
            /// </summary>
            /// <remarks>
            /// 
            /// </remarks>
            public byte ExtraSignDisplayMax 
            {
                get => (byte)CellsByName["ExtraSignDisplayMax"].Value;
                set => CellsByName["ExtraSignDisplayMax"].Value = value;
            }
            

            // Def="u8 bloodStainDisplayMax = 7"
            /// <summary>
            /// Extra - Bloodstain Display Max (u8)
            /// </summary>
            /// <remarks>
            /// 
            /// </remarks>
            public byte ExtraBloodstainDisplayMax 
            {
                get => (byte)CellsByName["ExtraBloodstainDisplayMax"].Value;
                set => CellsByName["ExtraBloodstainDisplayMax"].Value = value;
            }
            

            // Def="u8 bloodMessageDisplayMax = 3"
            /// <summary>
            /// Extra - Blood Message Display Max (u8)
            /// </summary>
            /// <remarks>
            /// 
            /// </remarks>
            public byte ExtraBloodMessageDisplayMax 
            {
                get => (byte)CellsByName["ExtraBloodMessageDisplayMax"].Value;
                set => CellsByName["ExtraBloodMessageDisplayMax"].Value = value;
            }
            



            // Def="f32 summonMessageInterval = 1"
            /// <summary>
            /// Quick Match - Summon Message Interval (f32)
            /// </summary>
            /// <remarks>
            /// 
            /// </remarks>
            public float QuickMatchSummonMessageInterval 
            {
                get => (float)CellsByName["QuickMatchSummonMessageInterval"].Value;
                set => CellsByName["QuickMatchSummonMessageInterval"].Value = value;
            }
            

            // Def="f32 hostRegisterUpdateTime = 1"
            /// <summary>
            /// Quick Match - Host Register Update Time (f32)
            /// </summary>
            /// <remarks>
            /// 
            /// </remarks>
            public float QuickMatchHostRegisterUpdateTime 
            {
                get => (float)CellsByName["QuickMatchHostRegisterUpdateTime"].Value;
                set => CellsByName["QuickMatchHostRegisterUpdateTime"].Value = value;
            }
            

            // Def="f32 hostTimeOutTime = 1"
            /// <summary>
            /// Quick Match - Host Time Out Time (f32)
            /// </summary>
            /// <remarks>
            /// 
            /// </remarks>
            public float QuickMatchHostTimeOutTime 
            {
                get => (float)CellsByName["QuickMatchHostTimeOutTime"].Value;
                set => CellsByName["QuickMatchHostTimeOutTime"].Value = value;
            }
            

            // Def="f32 guestUpdateTime = 1"
            /// <summary>
            /// Quick Match - Guest Update Time (f32)
            /// </summary>
            /// <remarks>
            /// 
            /// </remarks>
            public float QuickMatchGuestUpdateTime 
            {
                get => (float)CellsByName["QuickMatchGuestUpdateTime"].Value;
                set => CellsByName["QuickMatchGuestUpdateTime"].Value = value;
            }
            

            // Def="f32 guestPlayerNoTimeOutTime = 1"
            /// <summary>
            /// Quick Match - Guest Player No Time Out Time (f32)
            /// </summary>
            /// <remarks>
            /// 
            /// </remarks>
            public float QuickMatchGuestPlayerNoTimeOutTime 
            {
                get => (float)CellsByName["QuickMatchGuestPlayerNoTimeOutTime"].Value;
                set => CellsByName["QuickMatchGuestPlayerNoTimeOutTime"].Value = value;
            }
            

            // Def="f32 hostPlayerNoTimeOutTime = 1"
            /// <summary>
            /// Quick Match - Host Player No Time Out Time (f32)
            /// </summary>
            /// <remarks>
            /// 
            /// </remarks>
            public float QuickMatchHostPlayerNoTimeOutTime 
            {
                get => (float)CellsByName["QuickMatchHostPlayerNoTimeOutTime"].Value;
                set => CellsByName["QuickMatchHostPlayerNoTimeOutTime"].Value = value;
            }
            

            // Def="u32 requestSearchQuickMatchLimit = 1"
            /// <summary>
            /// Quick Match - Request Search Quick Match Limit (u32)
            /// </summary>
            /// <remarks>
            /// Actually u8 is enough
            /// </remarks>
            public uint QuickMatchRequestSearchQuickMatchLimit 
            {
                get => (uint)CellsByName["QuickMatchRequestSearchQuickMatchLimit"].Value;
                set => CellsByName["QuickMatchRequestSearchQuickMatchLimit"].Value = value;
            }
            

            // Def="u32 AvatarMatchSearchMax = 1"
            /// <summary>
            /// Quick Match - Avatar Match Search Max (u32)
            /// </summary>
            /// <remarks>
            /// Actually u8 is enough
            /// </remarks>
            public uint QuickMatchAvatarMatchSearchMax 
            {
                get => (uint)CellsByName["QuickMatchAvatarMatchSearchMax"].Value;
                set => CellsByName["QuickMatchAvatarMatchSearchMax"].Value = value;
            }
            

            // Def="u32 BattleRoyalMatchSearchMin = 1"
            /// <summary>
            /// Quick Match - Battle Royale Match Search Min (u32)
            /// </summary>
            /// <remarks>
            /// Actually u8 is enough
            /// </remarks>
            public uint QuickMatchBattleRoyaleMatchSearchMin 
            {
                get => (uint)CellsByName["QuickMatchBattleRoyaleMatchSearchMin"].Value;
                set => CellsByName["QuickMatchBattleRoyaleMatchSearchMin"].Value = value;
            }
            

            // Def="u32 BattleRoyalMatchSearchMax = 1"
            /// <summary>
            /// Quick Match - Battle Royale Match Search Max (u32)
            /// </summary>
            /// <remarks>
            /// Actually u8 is enough
            /// </remarks>
            public uint QuickMatchBattleRoyaleMatchSearchMax 
            {
                get => (uint)CellsByName["QuickMatchBattleRoyaleMatchSearchMax"].Value;
                set => CellsByName["QuickMatchBattleRoyaleMatchSearchMax"].Value = value;
            }
            


            // Def="u32 VisitorListMax = 1"
            /// <summary>
            /// Visitor - Visitor List Max (u32)
            /// </summary>
            /// <remarks>
            /// Actually u8 is enough
            /// </remarks>
            public uint VisitorVisitorListMax 
            {
                get => (uint)CellsByName["VisitorVisitorListMax"].Value;
                set => CellsByName["VisitorVisitorListMax"].Value = value;
            }
            

            // Def="f32 VisitorTimeOutTime = 1"
            /// <summary>
            /// Visitor - Visitor Time Out Time (f32)
            /// </summary>
            /// <remarks>
            /// 
            /// </remarks>
            public float VisitorVisitorTimeOutTime 
            {
                get => (float)CellsByName["VisitorVisitorTimeOutTime"].Value;
                set => CellsByName["VisitorVisitorTimeOutTime"].Value = value;
            }
            

            // Def="f32 DownloadSpan = 1"
            /// <summary>
            /// Visitor - Download Span (f32)
            /// </summary>
            /// <remarks>
            /// 
            /// </remarks>
            public float VisitorDownloadSpan 
            {
                get => (float)CellsByName["VisitorDownloadSpan"].Value;
                set => CellsByName["VisitorDownloadSpan"].Value = value;
            }
            

            // Def="f32 VisitorGuestRequestMessageIntervalSec = 1"
            /// <summary>
            /// Visitor - Visitor Guest Request Message Interval (f32)
            /// </summary>
            /// <remarks>
            /// Display interval [seconds] of messages sent by visiting guests while searching for a destination
            /// </remarks>
            public float VisitorVisitorGuestRequestMessageInterval 
            {
                get => (float)CellsByName["VisitorVisitorGuestRequestMessageInterval"].Value;
                set => CellsByName["VisitorVisitorGuestRequestMessageInterval"].Value = value;
            }
            

            // Def="f32 wanderGhostIntervalLifeTime = 40"
            /// <summary>
            /// Ghost Addition - Wandering Ghost Interval Lifetime (f32)
            /// </summary>
            /// <remarks>
            /// Wandering illusion life
            /// </remarks>
            public float GhostAdditionWanderingGhostIntervalLifetime 
            {
                get => (float)CellsByName["GhostAdditionWanderingGhostIntervalLifetime"].Value;
                set => CellsByName["GhostAdditionWanderingGhostIntervalLifetime"].Value = value;
            }
            


            // Def="f32 YellowMonkTimeOutTime = 1"
            /// <summary>
            /// Yellow Monk - Yellow Monk Timeout Time (f32)
            /// </summary>
            /// <remarks>
            /// 
            /// </remarks>
            public float YellowMonkYellowMonkTimeoutTime 
            {
                get => (float)CellsByName["YellowMonkYellowMonkTimeoutTime"].Value;
                set => CellsByName["YellowMonkYellowMonkTimeoutTime"].Value = value;
            }
            

            // Def="f32 YellowMonkDownloadSpan = 1"
            /// <summary>
            /// Yellow Monk - Yellow Monk Download Span (f32)
            /// </summary>
            /// <remarks>
            /// 
            /// </remarks>
            public float YellowMonkYellowMonkDownloadSpan 
            {
                get => (float)CellsByName["YellowMonkYellowMonkDownloadSpan"].Value;
                set => CellsByName["YellowMonkYellowMonkDownloadSpan"].Value = value;
            }
            

            // Def="f32 YellowMonkOverallFlowTimeOutTime = 1"
            /// <summary>
            /// Yellow Monk - Yellow Monk Overall Flow Time Out Time (f32)
            /// </summary>
            /// <remarks>
            /// 
            /// </remarks>
            public float YellowMonkYellowMonkOverallFlowTimeOutTime 
            {
                get => (float)CellsByName["YellowMonkYellowMonkOverallFlowTimeOutTime"].Value;
                set => CellsByName["YellowMonkYellowMonkOverallFlowTimeOutTime"].Value = value;
            }
            


                }
            }
            
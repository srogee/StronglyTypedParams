
            namespace StronglyTypedParams
            {
                public class BonfireWarpParam : ParamRow
                {
                    public BonfireWarpParam() : base()
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
            

            // Def="u32 eventflagId"
            /// <summary>
            /// Event Flag ID (u32)
            /// </summary>
            /// <remarks>
            /// Release condition event flag ID
            /// </remarks>
            public uint EventFlagID 
            {
                get => (uint)CellsByName["EventFlagID"].Value;
                set => CellsByName["EventFlagID"].Value = value;
            }
            

            // Def="u32 bonfireEntityId"
            /// <summary>
            /// Bonfire Entity ID (u32)
            /// </summary>
            /// <remarks>
            /// Bonfire entity ID
            /// </remarks>
            public uint BonfireEntityID 
            {
                get => (uint)CellsByName["BonfireEntityID"].Value;
                set => CellsByName["BonfireEntityID"].Value = value;
            }
            

            // Def="dummy8 pad4[2]"
            /// <summary>
            /// pad (dummy8)
            /// </summary>
            /// <remarks>
            /// Padding. The place where the deleted old work origin data was defined
            /// </remarks>
            public object Pad 
            {
                get => (object)CellsByName["Pad"].Value;
                set => CellsByName["Pad"].Value = value;
            }
            

            // Def="u16 bonfireSubCategorySortId"
            /// <summary>
            /// Sort ID (u16)
            /// </summary>
            /// <remarks>
            /// Bonfire Warp Subcategory Sort ID. Specify the order (ascending order) in the same subcategory
            /// </remarks>
            public ushort SortID 
            {
                get => (ushort)CellsByName["SortID"].Value;
                set => CellsByName["SortID"].Value = value;
            }
            

            // Def="u16 forbiddenIconId"
            /// <summary>
            /// Warp Prohibition Icon ID (u16)
            /// </summary>
            /// <remarks>
            /// Icon ID when warp is prohibited
            /// </remarks>
            public ushort WarpProhibitionIconID 
            {
                get => (ushort)CellsByName["WarpProhibitionIconID"].Value;
                set => CellsByName["WarpProhibitionIconID"].Value = value;
            }
            

            // Def="u8 dispMinZoomStep"
            /// <summary>
            /// Display Zoom Step (u8)
            /// </summary>
            /// <remarks>
            /// Zoom step to display the bonfire (0 when zoomed out most, +1 for each zoom). Displayed when "<< Display zoom step >> ≤ Current zoom step". Default is 0 (always displayed)
            /// </remarks>
            public byte DisplayZoomStep 
            {
                get => (byte)CellsByName["DisplayZoomStep"].Value;
                set => CellsByName["DisplayZoomStep"].Value = value;
            }
            

            // Def="u8 selectMinZoomStep"
            /// <summary>
            /// Selectable Zoom Step (u8)
            /// </summary>
            /// <remarks>
            /// A zoom step that allows you to select and snap a bonfire (0 for the most zoomed out state, +1 for each zoom). Can be selected and snapped when "<< Selectable zoom step >> ≤ current enlargement stage". The default is 0 (always selectable / snappable)
            /// </remarks>
            public byte SelectableZoomStep 
            {
                get => (byte)CellsByName["SelectableZoomStep"].Value;
                set => CellsByName["SelectableZoomStep"].Value = value;
            }
            

            // Def="s32 bonfireSubCategoryId = -1"
            /// <summary>
            /// Subcategory ID (s32)
            /// </summary>
            /// <remarks>
            /// Bonfire Warp Subcategory Parameter ID (-1: Invalid). Set which subcategory it belongs to. If it is invalid, it will not be displayed in the bonfire list.
            /// </remarks>
            public int SubcategoryID 
            {
                get => (int)CellsByName["SubcategoryID"].Value;
                set => CellsByName["SubcategoryID"].Value = value;
            }
            

            // Def="u32 clearedEventFlagId"
            /// <summary>
            /// Cleared Event Flag ID (u32)
            /// </summary>
            /// <remarks>
            /// Cleared event flag ID (0: always treated as cleared)
            /// </remarks>
            public uint ClearedEventFlagID 
            {
                get => (uint)CellsByName["ClearedEventFlagID"].Value;
                set => CellsByName["ClearedEventFlagID"].Value = value;
            }
            

            // Def="u16 iconId"
            /// <summary>
            /// Icon ID (u16)
            /// </summary>
            /// <remarks>
            /// Icon ID
            /// </remarks>
            public ushort IconID 
            {
                get => (ushort)CellsByName["IconID"].Value;
                set => CellsByName["IconID"].Value = value;
            }
            

            // Def="u8 dispMask00:1"
            /// <summary>
            /// Display Setting M00 (u8)
            /// </summary>
            /// <remarks>
            /// Whether to display with M00
            /// </remarks>
            public byte DisplaySettingM00 
            {
                get => (byte)CellsByName["DisplaySettingM00"].Value;
                set => CellsByName["DisplaySettingM00"].Value = value;
            }
            

            // Def="u8 dispMask01:1"
            /// <summary>
            /// Display Setting M01 (u8)
            /// </summary>
            /// <remarks>
            /// Whether to display with M01
            /// </remarks>
            public byte DisplaySettingM01 
            {
                get => (byte)CellsByName["DisplaySettingM01"].Value;
                set => CellsByName["DisplaySettingM01"].Value = value;
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
                set => CellsByName["MapArea"].Value = value;
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
                set => CellsByName["MapBlock"].Value = value;
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
                set => CellsByName["MapRegion"].Value = value;
            }
            

            // Def="dummy8 pad3[1]"
            /// <summary>
            /// Padding (dummy8)
            /// </summary>
            /// <remarks>
            /// pad3
            /// </remarks>
            public object Padding 
            {
                get => (object)CellsByName["Padding"].Value;
                set => CellsByName["Padding"].Value = value;
            }
            

            // Def="f32 posX"
            /// <summary>
            /// Coordinate: X (f32)
            /// </summary>
            /// <remarks>
            /// X coordinate
            /// </remarks>
            public float CoordinateX 
            {
                get => (float)CellsByName["CoordinateX"].Value;
                set => CellsByName["CoordinateX"].Value = value;
            }
            

            // Def="f32 posY"
            /// <summary>
            /// Coordinate: Y (f32)
            /// </summary>
            /// <remarks>
            /// Y coordinate (not used)
            /// </remarks>
            public float CoordinateY 
            {
                get => (float)CellsByName["CoordinateY"].Value;
                set => CellsByName["CoordinateY"].Value = value;
            }
            

            // Def="f32 posZ"
            /// <summary>
            /// Coordinate: Z (f32)
            /// </summary>
            /// <remarks>
            /// Z coordinate
            /// </remarks>
            public float CoordinateZ 
            {
                get => (float)CellsByName["CoordinateZ"].Value;
                set => CellsByName["CoordinateZ"].Value = value;
            }
            

            // Def="s32 textId1 = -1"
            /// <summary>
            /// Text ID [1] (s32)
            /// </summary>
            /// <remarks>
            /// The text ID to display. If the value is invalid (-1), nothing is displayed.
            /// </remarks>
            public int TextID1 
            {
                get => (int)CellsByName["TextID1"].Value;
                set => CellsByName["TextID1"].Value = value;
            }
            

            // Def="u32 textEnableFlagId1"
            /// <summary>
            /// Text Enable Flag ID [1] (u32)
            /// </summary>
            /// <remarks>
            /// Display text Event flag ID. Display if the event flag is On. If the event flag ID (0) is invalid, it will be treated as On.
            /// </remarks>
            public uint TextEnableFlagID1 
            {
                get => (uint)CellsByName["TextEnableFlagID1"].Value;
                set => CellsByName["TextEnableFlagID1"].Value = value;
            }
            

            // Def="u32 textDisableFlagId1"
            /// <summary>
            /// Text Disable Flag ID [1] (u32)
            /// </summary>
            /// <remarks>
            /// Hidden event flag ID of the text. If the event flag is On, it will not be displayed. It takes precedence over the display event flag ID. If the event flag ID (0) is invalid, it will be treated as Off.
            /// </remarks>
            public uint TextDisableFlagID1 
            {
                get => (uint)CellsByName["TextDisableFlagID1"].Value;
                set => CellsByName["TextDisableFlagID1"].Value = value;
            }
            

            // Def="s32 textId2 = -1"
            /// <summary>
            /// Text ID [2] (s32)
            /// </summary>
            /// <remarks>
            /// The text ID to display. If it is an invalid value (-2), nothing is displayed.
            /// </remarks>
            public int TextID2 
            {
                get => (int)CellsByName["TextID2"].Value;
                set => CellsByName["TextID2"].Value = value;
            }
            

            // Def="u32 textEnableFlagId2"
            /// <summary>
            /// Text Enable Flag ID [2] (u32)
            /// </summary>
            /// <remarks>
            /// Display text Event flag ID. Display if the event flag is On. If the event flag ID (1) is invalid, it will be treated as On.
            /// </remarks>
            public uint TextEnableFlagID2 
            {
                get => (uint)CellsByName["TextEnableFlagID2"].Value;
                set => CellsByName["TextEnableFlagID2"].Value = value;
            }
            

            // Def="u32 textDisableFlagId2"
            /// <summary>
            /// Text Disable Flag ID [2] (u32)
            /// </summary>
            /// <remarks>
            /// Hidden event flag ID of the text. If the event flag is On, it will not be displayed. It takes precedence over the display event flag ID. If the event flag ID (1) is invalid, it will be treated as Off.
            /// </remarks>
            public uint TextDisableFlagID2 
            {
                get => (uint)CellsByName["TextDisableFlagID2"].Value;
                set => CellsByName["TextDisableFlagID2"].Value = value;
            }
            

            // Def="s32 textId3 = -1"
            /// <summary>
            /// Text ID [3] (s32)
            /// </summary>
            /// <remarks>
            /// The text ID to display. If it is an invalid value (-3), nothing is displayed.
            /// </remarks>
            public int TextID3 
            {
                get => (int)CellsByName["TextID3"].Value;
                set => CellsByName["TextID3"].Value = value;
            }
            

            // Def="u32 textEnableFlagId3"
            /// <summary>
            /// Text Enable Flag ID [3] (u32)
            /// </summary>
            /// <remarks>
            /// Display text Event flag ID. Display if the event flag is On. If the event flag ID (2) is invalid, it will be treated as On.
            /// </remarks>
            public uint TextEnableFlagID3 
            {
                get => (uint)CellsByName["TextEnableFlagID3"].Value;
                set => CellsByName["TextEnableFlagID3"].Value = value;
            }
            

            // Def="u32 textDisableFlagId3"
            /// <summary>
            /// Text Disable Flag ID [3] (u32)
            /// </summary>
            /// <remarks>
            /// Hidden event flag ID of the text. If the event flag is On, it will not be displayed. It takes precedence over the display event flag ID. If the event flag ID (2) is invalid, it will be treated as Off.
            /// </remarks>
            public uint TextDisableFlagID3 
            {
                get => (uint)CellsByName["TextDisableFlagID3"].Value;
                set => CellsByName["TextDisableFlagID3"].Value = value;
            }
            

            // Def="s32 textId4 = -1"
            /// <summary>
            /// Text ID [4] (s32)
            /// </summary>
            /// <remarks>
            /// The text ID to display. If it is an invalid value (-4), nothing is displayed.
            /// </remarks>
            public int TextID4 
            {
                get => (int)CellsByName["TextID4"].Value;
                set => CellsByName["TextID4"].Value = value;
            }
            

            // Def="u32 textEnableFlagId4"
            /// <summary>
            /// Text Enable Flag ID [4] (u32)
            /// </summary>
            /// <remarks>
            /// Display text Event flag ID. Display if the event flag is On. If the event flag ID (3) is invalid, it will be treated as On.
            /// </remarks>
            public uint TextEnableFlagID4 
            {
                get => (uint)CellsByName["TextEnableFlagID4"].Value;
                set => CellsByName["TextEnableFlagID4"].Value = value;
            }
            

            // Def="u32 textDisableFlagId4"
            /// <summary>
            /// Text Disable Flag ID [4] (u32)
            /// </summary>
            /// <remarks>
            /// Hidden event flag ID of the text. If the event flag is On, it will not be displayed. It takes precedence over the display event flag ID. If the event flag ID (3) is invalid, it will be treated as Off.
            /// </remarks>
            public uint TextDisableFlagID4 
            {
                get => (uint)CellsByName["TextDisableFlagID4"].Value;
                set => CellsByName["TextDisableFlagID4"].Value = value;
            }
            

            // Def="s32 textId5 = -1"
            /// <summary>
            /// Text ID [5] (s32)
            /// </summary>
            /// <remarks>
            /// The text ID to display. If it is an invalid value (-5), nothing is displayed.
            /// </remarks>
            public int TextID5 
            {
                get => (int)CellsByName["TextID5"].Value;
                set => CellsByName["TextID5"].Value = value;
            }
            

            // Def="u32 textEnableFlagId5"
            /// <summary>
            /// Text Enable Flag ID [5] (u32)
            /// </summary>
            /// <remarks>
            /// Display text Event flag ID. Display if the event flag is On. If the event flag ID (4) is invalid, it will be treated as On.
            /// </remarks>
            public uint TextEnableFlagID5 
            {
                get => (uint)CellsByName["TextEnableFlagID5"].Value;
                set => CellsByName["TextEnableFlagID5"].Value = value;
            }
            

            // Def="u32 textDisableFlagId5"
            /// <summary>
            /// Text Disable Flag ID [5] (u32)
            /// </summary>
            /// <remarks>
            /// Hidden event flag ID of the text. If the event flag is On, it will not be displayed. It takes precedence over the display event flag ID. If the event flag ID (4) is invalid, it will be treated as Off.
            /// </remarks>
            public uint TextDisableFlagID5 
            {
                get => (uint)CellsByName["TextDisableFlagID5"].Value;
                set => CellsByName["TextDisableFlagID5"].Value = value;
            }
            

            // Def="s32 textId6 = -1"
            /// <summary>
            /// Text ID [6] (s32)
            /// </summary>
            /// <remarks>
            /// The text ID to display. If it is an invalid value (-6), nothing is displayed.
            /// </remarks>
            public int TextID6 
            {
                get => (int)CellsByName["TextID6"].Value;
                set => CellsByName["TextID6"].Value = value;
            }
            

            // Def="u32 textEnableFlagId6"
            /// <summary>
            /// Text Enable Flag ID [6] (u32)
            /// </summary>
            /// <remarks>
            /// Display text Event flag ID. Display if the event flag is On. If the event flag ID (5) is invalid, it will be treated as On.
            /// </remarks>
            public uint TextEnableFlagID6 
            {
                get => (uint)CellsByName["TextEnableFlagID6"].Value;
                set => CellsByName["TextEnableFlagID6"].Value = value;
            }
            

            // Def="u32 textDisableFlagId6"
            /// <summary>
            /// Text Disable Flag ID [6] (u32)
            /// </summary>
            /// <remarks>
            /// Hidden event flag ID of the text. If the event flag is On, it will not be displayed. It takes precedence over the display event flag ID. If the event flag ID (5) is invalid, it will be treated as Off.
            /// </remarks>
            public uint TextDisableFlagID6 
            {
                get => (uint)CellsByName["TextDisableFlagID6"].Value;
                set => CellsByName["TextDisableFlagID6"].Value = value;
            }
            

            // Def="s32 textId7 = -1"
            /// <summary>
            /// Text ID [7] (s32)
            /// </summary>
            /// <remarks>
            /// The text ID to display. If it is an invalid value (-7), nothing is displayed.
            /// </remarks>
            public int TextID7 
            {
                get => (int)CellsByName["TextID7"].Value;
                set => CellsByName["TextID7"].Value = value;
            }
            

            // Def="u32 textEnableFlagId7"
            /// <summary>
            /// Text Enable Flag ID [7] (u32)
            /// </summary>
            /// <remarks>
            /// Display text Event flag ID. Display if the event flag is On. If the event flag ID (6) is invalid, it will be treated as On.
            /// </remarks>
            public uint TextEnableFlagID7 
            {
                get => (uint)CellsByName["TextEnableFlagID7"].Value;
                set => CellsByName["TextEnableFlagID7"].Value = value;
            }
            

            // Def="u32 textDisableFlagId7"
            /// <summary>
            /// Text Disable Flag ID [7] (u32)
            /// </summary>
            /// <remarks>
            /// Hidden event flag ID of the text. If the event flag is On, it will not be displayed. It takes precedence over the display event flag ID. If the event flag ID (6) is invalid, it will be treated as Off.
            /// </remarks>
            public uint TextDisableFlagID7 
            {
                get => (uint)CellsByName["TextDisableFlagID7"].Value;
                set => CellsByName["TextDisableFlagID7"].Value = value;
            }
            

            // Def="s32 textId8 = -1"
            /// <summary>
            /// Text ID [8] (s32)
            /// </summary>
            /// <remarks>
            /// The text ID to display. If it is an invalid value (-8), nothing is displayed.
            /// </remarks>
            public int TextID8 
            {
                get => (int)CellsByName["TextID8"].Value;
                set => CellsByName["TextID8"].Value = value;
            }
            

            // Def="u32 textEnableFlagId8"
            /// <summary>
            /// Text Enable Flag ID [8] (u32)
            /// </summary>
            /// <remarks>
            /// Display text Event flag ID. Display if the event flag is On. If the event flag ID (7) is invalid, it will be treated as On.
            /// </remarks>
            public uint TextEnableFlagID8 
            {
                get => (uint)CellsByName["TextEnableFlagID8"].Value;
                set => CellsByName["TextEnableFlagID8"].Value = value;
            }
            

            // Def="u32 textDisableFlagId8"
            /// <summary>
            /// Text Disable Flag ID [8] (u32)
            /// </summary>
            /// <remarks>
            /// Hidden event flag ID of the text. If the event flag is On, it will not be displayed. It takes precedence over the display event flag ID. If the event flag ID (7) is invalid, it will be treated as Off.
            /// </remarks>
            public uint TextDisableFlagID8 
            {
                get => (uint)CellsByName["TextDisableFlagID8"].Value;
                set => CellsByName["TextDisableFlagID8"].Value = value;
            }
            

            // Def="u8 textType1"
            /// <summary>
            /// Text Type [1] (u8)
            /// </summary>
            /// <remarks>
            /// Text type (place name, NPC name, ...)
            /// </remarks>
            public byte TextType1 
            {
                get => (byte)CellsByName["TextType1"].Value;
                set => CellsByName["TextType1"].Value = value;
            }
            

            // Def="u8 textType2"
            /// <summary>
            /// Text Type [2] (u8)
            /// </summary>
            /// <remarks>
            /// Text type (place name, NPC name, ...)
            /// </remarks>
            public byte TextType2 
            {
                get => (byte)CellsByName["TextType2"].Value;
                set => CellsByName["TextType2"].Value = value;
            }
            

            // Def="u8 textType3"
            /// <summary>
            /// Text Type [3] (u8)
            /// </summary>
            /// <remarks>
            /// Text type (place name, NPC name, ...)
            /// </remarks>
            public byte TextType3 
            {
                get => (byte)CellsByName["TextType3"].Value;
                set => CellsByName["TextType3"].Value = value;
            }
            

            // Def="u8 textType4"
            /// <summary>
            /// Text Type [4] (u8)
            /// </summary>
            /// <remarks>
            /// Text type (place name, NPC name, ...)
            /// </remarks>
            public byte TextType4 
            {
                get => (byte)CellsByName["TextType4"].Value;
                set => CellsByName["TextType4"].Value = value;
            }
            

            // Def="u8 textType5"
            /// <summary>
            /// Text Type [5] (u8)
            /// </summary>
            /// <remarks>
            /// Text type (place name, NPC name, ...)
            /// </remarks>
            public byte TextType5 
            {
                get => (byte)CellsByName["TextType5"].Value;
                set => CellsByName["TextType5"].Value = value;
            }
            

            // Def="u8 textType6"
            /// <summary>
            /// Text Type [6] (u8)
            /// </summary>
            /// <remarks>
            /// Text type (place name, NPC name, ...)
            /// </remarks>
            public byte TextType6 
            {
                get => (byte)CellsByName["TextType6"].Value;
                set => CellsByName["TextType6"].Value = value;
            }
            

            // Def="u8 textType7"
            /// <summary>
            /// Text Type [7] (u8)
            /// </summary>
            /// <remarks>
            /// Text type (place name, NPC name, ...)
            /// </remarks>
            public byte TextType7 
            {
                get => (byte)CellsByName["TextType7"].Value;
                set => CellsByName["TextType7"].Value = value;
            }
            

            // Def="u8 textType8"
            /// <summary>
            /// Text Type [8] (u8)
            /// </summary>
            /// <remarks>
            /// Text type (place name, NPC name, ...)
            /// </remarks>
            public byte TextType8 
            {
                get => (byte)CellsByName["TextType8"].Value;
                set => CellsByName["TextType8"].Value = value;
            }
            

            // Def="s32 noIgnitionSfxDmypolyId_0 = -1"
            /// <summary>
            /// Bonfire Ignition - Dummy Poly ID [0] (s32)
            /// </summary>
            /// <remarks>
            /// Damipoli ID that issues SFX before bonfire ignition
            /// </remarks>
            public int BonfireIgnitionDummyPolyID0 
            {
                get => (int)CellsByName["BonfireIgnitionDummyPolyID0"].Value;
                set => CellsByName["BonfireIgnitionDummyPolyID0"].Value = value;
            }
            

            // Def="s32 noIgnitionSfxId_0 = -1"
            /// <summary>
            /// Bonfire Ignition - SFX ID [0] (s32)
            /// </summary>
            /// <remarks>
            /// SFX ID issued before bonfire ignition. It goes out when ignited. In case of -1, SFX is not issued.
            /// </remarks>
            public int BonfireIgnitionSFXID0 
            {
                get => (int)CellsByName["BonfireIgnitionSFXID0"].Value;
                set => CellsByName["BonfireIgnitionSFXID0"].Value = value;
            }
            

            // Def="s32 noIgnitionSfxDmypolyId_1 = -1"
            /// <summary>
            /// Bonfire Ignition - Dummy Poly ID [1] (s32)
            /// </summary>
            /// <remarks>
            /// Damipoli ID that issues SFX before bonfire ignition
            /// </remarks>
            public int BonfireIgnitionDummyPolyID1 
            {
                get => (int)CellsByName["BonfireIgnitionDummyPolyID1"].Value;
                set => CellsByName["BonfireIgnitionDummyPolyID1"].Value = value;
            }
            

            // Def="s32 noIgnitionSfxId_1 = -1"
            /// <summary>
            /// Bonfire Ignition - SFX ID [1] (s32)
            /// </summary>
            /// <remarks>
            /// SFX ID issued before bonfire ignition. It goes out when ignited. In case of -1, SFX is not issued.
            /// </remarks>
            public int BonfireIgnitionSFXID1 
            {
                get => (int)CellsByName["BonfireIgnitionSFXID1"].Value;
                set => CellsByName["BonfireIgnitionSFXID1"].Value = value;
            }
            

            // Def="s32 unkA8"
            /// <summary>
            /// unkA8 (s32)
            /// </summary>
            /// <remarks>
            /// 
            /// </remarks>
            public int UnkA8 
            {
                get => (int)CellsByName["UnkA8"].Value;
                set => CellsByName["UnkA8"].Value = value;
            }
            

            // Def="s32 unkAC"
            /// <summary>
            /// unkAC (s32)
            /// </summary>
            /// <remarks>
            /// 
            /// </remarks>
            public int UnkAC 
            {
                get => (int)CellsByName["UnkAC"].Value;
                set => CellsByName["UnkAC"].Value = value;
            }
            

            // Def="s32 unkB0"
            /// <summary>
            /// unkB0 (s32)
            /// </summary>
            /// <remarks>
            /// 
            /// </remarks>
            public int UnkB0 
            {
                get => (int)CellsByName["UnkB0"].Value;
                set => CellsByName["UnkB0"].Value = value;
            }
            

            // Def="s32 unkB4"
            /// <summary>
            /// unkB4 (s32)
            /// </summary>
            /// <remarks>
            /// 
            /// </remarks>
            public int UnkB4 
            {
                get => (int)CellsByName["UnkB4"].Value;
                set => CellsByName["UnkB4"].Value = value;
            }
            

            // Def="s32 unkB8"
            /// <summary>
            /// unkB8 (s32)
            /// </summary>
            /// <remarks>
            /// 
            /// </remarks>
            public int UnkB8 
            {
                get => (int)CellsByName["UnkB8"].Value;
                set => CellsByName["UnkB8"].Value = value;
            }
            

            // Def="s32 unkBC"
            /// <summary>
            /// unkBC (s32)
            /// </summary>
            /// <remarks>
            /// 
            /// </remarks>
            public int UnkBC 
            {
                get => (int)CellsByName["UnkBC"].Value;
                set => CellsByName["UnkBC"].Value = value;
            }
            

            // Def="s32 unkC0"
            /// <summary>
            /// unkC0 (s32)
            /// </summary>
            /// <remarks>
            /// 
            /// </remarks>
            public int UnkC0 
            {
                get => (int)CellsByName["UnkC0"].Value;
                set => CellsByName["UnkC0"].Value = value;
            }
            

            // Def="s32 unkC4"
            /// <summary>
            /// unkC4 (s32)
            /// </summary>
            /// <remarks>
            /// 
            /// </remarks>
            public int UnkC4 
            {
                get => (int)CellsByName["UnkC4"].Value;
                set => CellsByName["UnkC4"].Value = value;
            }
            

            // Def="s32 unkC8"
            /// <summary>
            /// unkC8 (s32)
            /// </summary>
            /// <remarks>
            /// 
            /// </remarks>
            public int UnkC8 
            {
                get => (int)CellsByName["UnkC8"].Value;
                set => CellsByName["UnkC8"].Value = value;
            }
            

            // Def="s32 unkCC"
            /// <summary>
            /// unkCC (s32)
            /// </summary>
            /// <remarks>
            /// 
            /// </remarks>
            public int UnkCC 
            {
                get => (int)CellsByName["UnkCC"].Value;
                set => CellsByName["UnkCC"].Value = value;
            }
            

            // Def="s32 unkD0"
            /// <summary>
            /// unkD0 (s32)
            /// </summary>
            /// <remarks>
            /// 
            /// </remarks>
            public int UnkD0 
            {
                get => (int)CellsByName["UnkD0"].Value;
                set => CellsByName["UnkD0"].Value = value;
            }
            

            // Def="s32 unkD4"
            /// <summary>
            /// unkD4 (s32)
            /// </summary>
            /// <remarks>
            /// 
            /// </remarks>
            public int UnkD4 
            {
                get => (int)CellsByName["UnkD4"].Value;
                set => CellsByName["UnkD4"].Value = value;
            }
            

            // Def="s32 unkD8"
            /// <summary>
            /// unkD8 (s32)
            /// </summary>
            /// <remarks>
            /// 
            /// </remarks>
            public int UnkD8 
            {
                get => (int)CellsByName["UnkD8"].Value;
                set => CellsByName["UnkD8"].Value = value;
            }
            

            // Def="s32 unkDC"
            /// <summary>
            /// unkDC (s32)
            /// </summary>
            /// <remarks>
            /// 
            /// </remarks>
            public int UnkDC 
            {
                get => (int)CellsByName["UnkDC"].Value;
                set => CellsByName["UnkDC"].Value = value;
            }
            

            // Def="s32 unkE0"
            /// <summary>
            /// unkE0 (s32)
            /// </summary>
            /// <remarks>
            /// 
            /// </remarks>
            public int UnkE0 
            {
                get => (int)CellsByName["UnkE0"].Value;
                set => CellsByName["UnkE0"].Value = value;
            }
            

            // Def="s32 unkE4"
            /// <summary>
            /// unkE4 (s32)
            /// </summary>
            /// <remarks>
            /// 
            /// </remarks>
            public int UnkE4 
            {
                get => (int)CellsByName["UnkE4"].Value;
                set => CellsByName["UnkE4"].Value = value;
            }
            

            // Def="s32 unkE8"
            /// <summary>
            /// unkE8 (s32)
            /// </summary>
            /// <remarks>
            /// 
            /// </remarks>
            public int UnkE8 
            {
                get => (int)CellsByName["UnkE8"].Value;
                set => CellsByName["UnkE8"].Value = value;
            }
            
                }
            }
            

namespace StronglyTypedParams
{
    public class WorldMapPointParam : ParamRow
    {
        public WorldMapPointParam() : base()
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


        // Def="u32 eventFlagId"
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


        // Def="u32 distViewEventFlagId"
        /// <summary>
        /// Distant View - Event Flag ID (u32)
        /// </summary>
        /// <remarks>
        /// Event flag ID to be set when found on the distant view
        /// </remarks>
        public uint DistantViewEventFlagID
        {
            get => (uint)CellsByName["DistantViewEventFlagID"].Value;
            set => CellsByName["DistantViewEventFlagID"].Value = value;
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


        // Def="s16 bgmPlaceType"
        /// <summary>
        /// BGM Location Type (s16)
        /// </summary>
        /// <remarks>
        /// Bgm location type
        /// </remarks>
        public short BGMLocationType
        {
            get => (short)CellsByName["BGMLocationType"].Value;
            set => CellsByName["BGMLocationType"].Value = value;
        }


        // Def="u8 isAreaIcon:1"
        /// <summary>
        /// Is Area Icon (u8)
        /// </summary>
        /// <remarks>
        /// Is it an icon that represents a range? Same size as the map
        /// </remarks>
        public byte IsAreaIcon
        {
            get => (byte)CellsByName["IsAreaIcon"].Value;
            set => CellsByName["IsAreaIcon"].Value = value;
        }


        // Def="u8 isOverrideDistViewMarkPos:1"
        /// <summary>
        /// Overwrite Coordinates when Distant View Marker (u8)
        /// </summary>
        /// <remarks>
        /// Whether to overwrite the coordinates when using it as a distant view marker
        /// </remarks>
        public byte OverwriteCoordinatesWhenDistantViewMarker
        {
            get => (byte)CellsByName["OverwriteCoordinatesWhenDistantViewMarker"].Value;
            set => CellsByName["OverwriteCoordinatesWhenDistantViewMarker"].Value = value;
        }


        // Def="u8 isEnableNoText:1"
        /// <summary>
        /// Enable with No Text (u8)
        /// </summary>
        /// <remarks>
        /// Do you want to display it even when there is no text? Basically, points are not displayed without text. Display without text when this flag is enabled
        /// </remarks>
        public byte EnableWithNoText
        {
            get => (byte)CellsByName["EnableWithNoText"].Value;
            set => CellsByName["EnableWithNoText"].Value = value;
        }


        // Def="dummy8 pad3:5"
        /// <summary>
        /// Pad 3 (dummy8)
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        public object Pad3
        {
            get => (object)CellsByName["Pad3"].Value;
            set => CellsByName["Pad3"].Value = value;
        }


        // Def="u8 areaNo_forDistViewMark"
        /// <summary>
        /// Distant View Marker - Map Area (u8)
        /// </summary>
        /// <remarks>
        /// AA part of mAA_BB_CC_DD
        /// </remarks>
        public byte DistantViewMarkerMapArea
        {
            get => (byte)CellsByName["DistantViewMarkerMapArea"].Value;
            set => CellsByName["DistantViewMarkerMapArea"].Value = value;
        }


        // Def="u8 gridXNo_forDistViewMark"
        /// <summary>
        /// Distant View Marker - Map Block (u8)
        /// </summary>
        /// <remarks>
        /// BB part of mAA_BB_CC_DD
        /// </remarks>
        public byte DistantViewMarkerMapBlock
        {
            get => (byte)CellsByName["DistantViewMarkerMapBlock"].Value;
            set => CellsByName["DistantViewMarkerMapBlock"].Value = value;
        }


        // Def="u8 gridZNo_forDistViewMark"
        /// <summary>
        /// Distant View Marker - Map Region (u8)
        /// </summary>
        /// <remarks>
        /// CC part of mAA_BB_CC_DD
        /// </remarks>
        public byte DistantViewMarkerMapRegion
        {
            get => (byte)CellsByName["DistantViewMarkerMapRegion"].Value;
            set => CellsByName["DistantViewMarkerMapRegion"].Value = value;
        }


        // Def="u32 clearedEventFlagId"
        /// <summary>
        /// Cleared - Event Flag ID (u32)
        /// </summary>
        /// <remarks>
        /// Cleared event flag ID (0: always treated as cleared)
        /// </remarks>
        public uint ClearedEventFlagID
        {
            get => (uint)CellsByName["ClearedEventFlagID"].Value;
            set => CellsByName["ClearedEventFlagID"].Value = value;
        }


        // Def="u8 dispMask00:1"
        /// <summary>
        /// Display Mask M00 (u8)
        /// </summary>
        /// <remarks>
        /// Whether to display with M00
        /// </remarks>
        public byte DisplayMaskM00
        {
            get => (byte)CellsByName["DisplayMaskM00"].Value;
            set => CellsByName["DisplayMaskM00"].Value = value;
        }


        // Def="u8 dispMask01:1"
        /// <summary>
        /// Display Mask M01 (u8)
        /// </summary>
        /// <remarks>
        /// Whether to display with M01
        /// </remarks>
        public byte DisplayMaskM01
        {
            get => (byte)CellsByName["DisplayMaskM01"].Value;
            set => CellsByName["DisplayMaskM01"].Value = value;
        }


        // Def="dummy8 pad2_0:6"
        /// <summary>
        /// pad (dummy8)
        /// </summary>
        /// <remarks>
        /// pad2_0
        /// </remarks>
        public object Pad
        {
            get => (object)CellsByName["Pad"].Value;
            set => CellsByName["Pad"].Value = value;
        }



        // Def="u16 distViewIconId"
        /// <summary>
        /// Distant View - Icon ID (u16)
        /// </summary>
        /// <remarks>
        /// Icon ID when distant view is found
        /// </remarks>
        public ushort DistantViewIconID
        {
            get => (ushort)CellsByName["DistantViewIconID"].Value;
            set => CellsByName["DistantViewIconID"].Value = value;
        }


        // Def="f32 angle"
        /// <summary>
        /// Display Icon Angle (f32)
        /// </summary>
        /// <remarks>
        /// Display icon rotation angle [deg]
        /// </remarks>
        public float DisplayIconAngle
        {
            get => (float)CellsByName["DisplayIconAngle"].Value;
            set => CellsByName["DisplayIconAngle"].Value = value;
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


        // Def="dummy8 pad[1]"
        /// <summary>
        /// Padding (dummy8)
        /// </summary>
        /// <remarks>
        /// Padding
        /// </remarks>
        public object Padding
        {
            get => (object)CellsByName["Padding"].Value;
            set => CellsByName["Padding"].Value = value;
        }


        // Def="f32 posX"
        /// <summary>
        /// Map Coordinate: X (f32)
        /// </summary>
        /// <remarks>
        /// X coordinate
        /// </remarks>
        public float MapCoordinateX
        {
            get => (float)CellsByName["MapCoordinateX"].Value;
            set => CellsByName["MapCoordinateX"].Value = value;
        }


        // Def="f32 posY"
        /// <summary>
        /// Map Coordinate: Y (f32)
        /// </summary>
        /// <remarks>
        /// Y coordinate (not used)
        /// </remarks>
        public float MapCoordinateY
        {
            get => (float)CellsByName["MapCoordinateY"].Value;
            set => CellsByName["MapCoordinateY"].Value = value;
        }


        // Def="f32 posZ"
        /// <summary>
        /// Map Coordinate: Z (f32)
        /// </summary>
        /// <remarks>
        /// Z coordinate
        /// </remarks>
        public float MapCoordinateZ
        {
            get => (float)CellsByName["MapCoordinateZ"].Value;
            set => CellsByName["MapCoordinateZ"].Value = value;
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
        /// Text Enable Flag [1] (u32)
        /// </summary>
        /// <remarks>
        /// Display text Event flag ID. Display if the event flag is On. If the event flag ID (0) is invalid, it will be treated as On.
        /// </remarks>
        public uint TextEnableFlag1
        {
            get => (uint)CellsByName["TextEnableFlag1"].Value;
            set => CellsByName["TextEnableFlag1"].Value = value;
        }


        // Def="u32 textDisableFlagId1"
        /// <summary>
        /// Text Disable Flag [1] (u32)
        /// </summary>
        /// <remarks>
        /// Hidden event flag ID of the text. If the event flag is On, it will not be displayed. It takes precedence over the display event flag ID. If the event flag ID (0) is invalid, it will be treated as Off.
        /// </remarks>
        public uint TextDisableFlag1
        {
            get => (uint)CellsByName["TextDisableFlag1"].Value;
            set => CellsByName["TextDisableFlag1"].Value = value;
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
        /// Text Enable Flag [2] (u32)
        /// </summary>
        /// <remarks>
        /// Display text Event flag ID. Display if the event flag is On. If the event flag ID (1) is invalid, it will be treated as On.
        /// </remarks>
        public uint TextEnableFlag2
        {
            get => (uint)CellsByName["TextEnableFlag2"].Value;
            set => CellsByName["TextEnableFlag2"].Value = value;
        }


        // Def="u32 textDisableFlagId2"
        /// <summary>
        /// Text Disable Flag [2] (u32)
        /// </summary>
        /// <remarks>
        /// Hidden event flag ID of the text. If the event flag is On, it will not be displayed. It takes precedence over the display event flag ID. If the event flag ID (1) is invalid, it will be treated as Off.
        /// </remarks>
        public uint TextDisableFlag2
        {
            get => (uint)CellsByName["TextDisableFlag2"].Value;
            set => CellsByName["TextDisableFlag2"].Value = value;
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
        /// Text Enable Flag [3] (u32)
        /// </summary>
        /// <remarks>
        /// Display text Event flag ID. Display if the event flag is On. If the event flag ID (2) is invalid, it will be treated as On.
        /// </remarks>
        public uint TextEnableFlag3
        {
            get => (uint)CellsByName["TextEnableFlag3"].Value;
            set => CellsByName["TextEnableFlag3"].Value = value;
        }


        // Def="u32 textDisableFlagId3"
        /// <summary>
        /// Text Disable Flag [3] (u32)
        /// </summary>
        /// <remarks>
        /// Hidden event flag ID of the text. If the event flag is On, it will not be displayed. It takes precedence over the display event flag ID. If the event flag ID (2) is invalid, it will be treated as Off.
        /// </remarks>
        public uint TextDisableFlag3
        {
            get => (uint)CellsByName["TextDisableFlag3"].Value;
            set => CellsByName["TextDisableFlag3"].Value = value;
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
        /// Text Enable Flag [4] (u32)
        /// </summary>
        /// <remarks>
        /// Display text Event flag ID. Display if the event flag is On. If the event flag ID (3) is invalid, it will be treated as On.
        /// </remarks>
        public uint TextEnableFlag4
        {
            get => (uint)CellsByName["TextEnableFlag4"].Value;
            set => CellsByName["TextEnableFlag4"].Value = value;
        }


        // Def="u32 textDisableFlagId4"
        /// <summary>
        /// Text Disable Flag [4] (u32)
        /// </summary>
        /// <remarks>
        /// Hidden event flag ID of the text. If the event flag is On, it will not be displayed. It takes precedence over the display event flag ID. If the event flag ID (3) is invalid, it will be treated as Off.
        /// </remarks>
        public uint TextDisableFlag4
        {
            get => (uint)CellsByName["TextDisableFlag4"].Value;
            set => CellsByName["TextDisableFlag4"].Value = value;
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
        /// Text Enable Flag [5] (u32)
        /// </summary>
        /// <remarks>
        /// Display text Event flag ID. Display if the event flag is On. If the event flag ID (4) is invalid, it will be treated as On.
        /// </remarks>
        public uint TextEnableFlag5
        {
            get => (uint)CellsByName["TextEnableFlag5"].Value;
            set => CellsByName["TextEnableFlag5"].Value = value;
        }


        // Def="u32 textDisableFlagId5"
        /// <summary>
        /// Text Disable Flag [5] (u32)
        /// </summary>
        /// <remarks>
        /// Hidden event flag ID of the text. If the event flag is On, it will not be displayed. It takes precedence over the display event flag ID. If the event flag ID (4) is invalid, it will be treated as Off.
        /// </remarks>
        public uint TextDisableFlag5
        {
            get => (uint)CellsByName["TextDisableFlag5"].Value;
            set => CellsByName["TextDisableFlag5"].Value = value;
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
        /// Text Enable Flag [6] (u32)
        /// </summary>
        /// <remarks>
        /// Display text Event flag ID. Display if the event flag is On. If the event flag ID (5) is invalid, it will be treated as On.
        /// </remarks>
        public uint TextEnableFlag6
        {
            get => (uint)CellsByName["TextEnableFlag6"].Value;
            set => CellsByName["TextEnableFlag6"].Value = value;
        }


        // Def="u32 textDisableFlagId6"
        /// <summary>
        /// Text Disable Flag [6] (u32)
        /// </summary>
        /// <remarks>
        /// Hidden event flag ID of the text. If the event flag is On, it will not be displayed. It takes precedence over the display event flag ID. If the event flag ID (5) is invalid, it will be treated as Off.
        /// </remarks>
        public uint TextDisableFlag6
        {
            get => (uint)CellsByName["TextDisableFlag6"].Value;
            set => CellsByName["TextDisableFlag6"].Value = value;
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
        /// Text Enable Flag [7] (u32)
        /// </summary>
        /// <remarks>
        /// Display text Event flag ID. Display if the event flag is On. If the event flag ID (6) is invalid, it will be treated as On.
        /// </remarks>
        public uint TextEnableFlag7
        {
            get => (uint)CellsByName["TextEnableFlag7"].Value;
            set => CellsByName["TextEnableFlag7"].Value = value;
        }


        // Def="u32 textDisableFlagId7"
        /// <summary>
        /// Text Disable Flag [7] (u32)
        /// </summary>
        /// <remarks>
        /// Hidden event flag ID of the text. If the event flag is On, it will not be displayed. It takes precedence over the display event flag ID. If the event flag ID (6) is invalid, it will be treated as Off.
        /// </remarks>
        public uint TextDisableFlag7
        {
            get => (uint)CellsByName["TextDisableFlag7"].Value;
            set => CellsByName["TextDisableFlag7"].Value = value;
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
        /// Text Enable Flag [8] (u32)
        /// </summary>
        /// <remarks>
        /// Display text Event flag ID. Display if the event flag is On. If the event flag ID (7) is invalid, it will be treated as On.
        /// </remarks>
        public uint TextEnableFlag8
        {
            get => (uint)CellsByName["TextEnableFlag8"].Value;
            set => CellsByName["TextEnableFlag8"].Value = value;
        }


        // Def="u32 textDisableFlagId8"
        /// <summary>
        /// Text Disable Flag [8] (u32)
        /// </summary>
        /// <remarks>
        /// Hidden event flag ID of the text. If the event flag is On, it will not be displayed. It takes precedence over the display event flag ID. If the event flag ID (7) is invalid, it will be treated as Off.
        /// </remarks>
        public uint TextDisableFlag8
        {
            get => (uint)CellsByName["TextDisableFlag8"].Value;
            set => CellsByName["TextDisableFlag8"].Value = value;
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


        // Def="s32 distViewId = -1"
        /// <summary>
        /// Distant View ID [0] (s32)
        /// </summary>
        /// <remarks>
        /// Distance stand ID
        /// </remarks>
        public int DistantViewID0
        {
            get => (int)CellsByName["DistantViewID0"].Value;
            set => CellsByName["DistantViewID0"].Value = value;
        }


        // Def="f32 posX_forDistViewMark"
        /// <summary>
        /// Distant View Marker - Coordinate: X (f32)
        /// </summary>
        /// <remarks>
        /// X coordinate
        /// </remarks>
        public float DistantViewMarkerCoordinateX
        {
            get => (float)CellsByName["DistantViewMarkerCoordinateX"].Value;
            set => CellsByName["DistantViewMarkerCoordinateX"].Value = value;
        }


        // Def="f32 posY_forDistViewMark"
        /// <summary>
        /// Distant View Marker - Coordinate: Y (f32)
        /// </summary>
        /// <remarks>
        /// Y coordinate
        /// </remarks>
        public float DistantViewMarkerCoordinateY
        {
            get => (float)CellsByName["DistantViewMarkerCoordinateY"].Value;
            set => CellsByName["DistantViewMarkerCoordinateY"].Value = value;
        }


        // Def="f32 posZ_forDistViewMark"
        /// <summary>
        /// Distant View Marker - Coordinate: Z (f32)
        /// </summary>
        /// <remarks>
        /// Z coordinate
        /// </remarks>
        public float DistantViewMarkerCoordinateZ
        {
            get => (float)CellsByName["DistantViewMarkerCoordinateZ"].Value;
            set => CellsByName["DistantViewMarkerCoordinateZ"].Value = value;
        }


        // Def="s32 distViewId1 = -1"
        /// <summary>
        /// Distant View ID [1] (s32)
        /// </summary>
        /// <remarks>
        /// Distance stand ID
        /// </remarks>
        public int DistantViewID1
        {
            get => (int)CellsByName["DistantViewID1"].Value;
            set => CellsByName["DistantViewID1"].Value = value;
        }


        // Def="s32 distViewId2 = -1"
        /// <summary>
        /// Distant View ID [2] (s32)
        /// </summary>
        /// <remarks>
        /// Distance stand ID
        /// </remarks>
        public int DistantViewID2
        {
            get => (int)CellsByName["DistantViewID2"].Value;
            set => CellsByName["DistantViewID2"].Value = value;
        }


        // Def="s32 distViewId3 = -1"
        /// <summary>
        /// Distant View ID [3] (s32)
        /// </summary>
        /// <remarks>
        /// Distance stand ID
        /// </remarks>
        public int DistantViewID3
        {
            get => (int)CellsByName["DistantViewID3"].Value;
            set => CellsByName["DistantViewID3"].Value = value;
        }


        // Def="u8 dispMinZoomStep"
        /// <summary>
        /// Display - Min Zoom Step (u8)
        /// </summary>
        /// <remarks>
        /// Zoom step to display map points (0 when zoomed out most, +1 for each zoom). Displayed when "<< Display zoom step >> ≤ Current zoom step". Default is 0 (always displayed)
        /// </remarks>
        public byte DisplayMinZoomStep
        {
            get => (byte)CellsByName["DisplayMinZoomStep"].Value;
            set => CellsByName["DisplayMinZoomStep"].Value = value;
        }


        // Def="u8 selectMinZoomStep"
        /// <summary>
        /// Selection - Min Zoom Step (u8)
        /// </summary>
        /// <remarks>
        /// Zoom step where map points can be selected (0 when zoomed out most, +1 for each zoom). Selectable when "<< Selectable zoom step >> ≤ Current enlargement stage". Default is 0 (always selectable)
        /// </remarks>
        public byte SelectionMinZoomStep
        {
            get => (byte)CellsByName["SelectionMinZoomStep"].Value;
            set => CellsByName["SelectionMinZoomStep"].Value = value;
        }


        // Def="u8 entryFEType"
        /// <summary>
        /// Entry FE Type (u8)
        /// </summary>
        /// <remarks>
        /// Admission display format. Map points to be displayed at the time of admission Types of admission FE
        /// </remarks>
        public byte EntryFEType
        {
            get => (byte)CellsByName["EntryFEType"].Value;
            set => CellsByName["EntryFEType"].Value = value;
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


        // Def="s32 unkEC"
        /// <summary>
        /// unkEC (s32)
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        public int UnkEC
        {
            get => (int)CellsByName["UnkEC"].Value;
            set => CellsByName["UnkEC"].Value = value;
        }


        // Def="s32 unkF0"
        /// <summary>
        /// unkF0 (s32)
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        public int UnkF0
        {
            get => (int)CellsByName["UnkF0"].Value;
            set => CellsByName["UnkF0"].Value = value;
        }


        // Def="s32 unkF4"
        /// <summary>
        /// unkF4 (s32)
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        public int UnkF4
        {
            get => (int)CellsByName["UnkF4"].Value;
            set => CellsByName["UnkF4"].Value = value;
        }


        // Def="s32 unkF8"
        /// <summary>
        /// unkF8 (s32)
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        public int UnkF8
        {
            get => (int)CellsByName["UnkF8"].Value;
            set => CellsByName["UnkF8"].Value = value;
        }


        // Def="s32 unkFC"
        /// <summary>
        /// unkFC (s32)
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        public int UnkFC
        {
            get => (int)CellsByName["UnkFC"].Value;
            set => CellsByName["UnkFC"].Value = value;
        }

    }
}

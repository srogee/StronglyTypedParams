
            namespace StronglyTypedParams
            {
                public class ActionButtonParam : ParamRow
                {
                    public ActionButtonParam() : base()
                    {
                    }
            

            // Def="u8 regionType"
            /// <summary>
            /// Region Type (u8)
            /// </summary>
            /// <remarks>
            /// Range shape (cylinder, prism, capsule)
            /// </remarks>
            public byte RegionType 
            {
                get => (byte)CellsByName["RegionType"].Value;
                set => CellsByName["RegionType"].Value = value;
            }
            

            // Def="u8 category"
            /// <summary>
            /// Category (u8)
            /// </summary>
            /// <remarks>
            /// category. The number on the left side of the name is the priority when multiple action buttons overlap (the closer it is to 0, the higher the priority is displayed).
            /// </remarks>
            public byte Category 
            {
                get => (byte)CellsByName["Category"].Value;
                set => CellsByName["Category"].Value = value;
            }
            

            // Def="dummy8 padding1[2]"
            /// <summary>
            /// Padding 1 (dummy8)
            /// </summary>
            /// <remarks>
            /// 
            /// </remarks>
            public object Padding1 
            {
                get => (object)CellsByName["Padding1"].Value;
                set => CellsByName["Padding1"].Value = value;
            }
            

            // Def="s32 dummyPoly1 = -1"
            /// <summary>
            /// Dummy Poly [1] (s32)
            /// </summary>
            /// <remarks>
            /// Specify the Damipoli ID that is the center of the bottom of the range. If there is no Damipoly or -1 is entered, the center coordinates will be the reference.
            /// </remarks>
            public int DummyPoly1 
            {
                get => (int)CellsByName["DummyPoly1"].Value;
                set => CellsByName["DummyPoly1"].Value = value;
            }
            

            // Def="s32 dummyPoly2 = -1"
            /// <summary>
            /// Dummy Poly [2] (s32)
            /// </summary>
            /// <remarks>
            /// Used only when the range type is a capsule. Additional Damipoly (capsule) that creates a line segment with two Damipoly
            /// </remarks>
            public int DummyPoly2 
            {
                get => (int)CellsByName["DummyPoly2"].Value;
                set => CellsByName["DummyPoly2"].Value = value;
            }
            

            // Def="f32 radius"
            /// <summary>
            /// Radius (f32)
            /// </summary>
            /// <remarks>
            /// Radius (cylinder / capsule)
            /// </remarks>
            public float Radius 
            {
                get => (float)CellsByName["Radius"].Value;
                set => CellsByName["Radius"].Value = value;
            }
            

            // Def="s32 angle = 180"
            /// <summary>
            /// Angle (s32)
            /// </summary>
            /// <remarks>
            /// Angle (cylinder)
            /// </remarks>
            public int Angle 
            {
                get => (int)CellsByName["Angle"].Value;
                set => CellsByName["Angle"].Value = value;
            }
            

            // Def="f32 depth"
            /// <summary>
            /// Depth (f32)
            /// </summary>
            /// <remarks>
            /// Depth (prism)
            /// </remarks>
            public float Depth 
            {
                get => (float)CellsByName["Depth"].Value;
                set => CellsByName["Depth"].Value = value;
            }
            

            // Def="f32 width"
            /// <summary>
            /// Width (f32)
            /// </summary>
            /// <remarks>
            /// Width (prism)
            /// </remarks>
            public float Width 
            {
                get => (float)CellsByName["Width"].Value;
                set => CellsByName["Width"].Value = value;
            }
            

            // Def="f32 height"
            /// <summary>
            /// Height (f32)
            /// </summary>
            /// <remarks>
            /// Height (cylinder / prism)
            /// </remarks>
            public float Height 
            {
                get => (float)CellsByName["Height"].Value;
                set => CellsByName["Height"].Value = value;
            }
            

            // Def="f32 baseHeightOffset"
            /// <summary>
            /// Bottom Height Offset (f32)
            /// </summary>
            /// <remarks>
            /// How much to raise or lower the Y coordinate of the bottom (cylinder / prism)
            /// </remarks>
            public float BottomHeightOffset 
            {
                get => (float)CellsByName["BottomHeightOffset"].Value;
                set => CellsByName["BottomHeightOffset"].Value = value;
            }
            

            // Def="u8 angleCheckType"
            /// <summary>
            /// Angle Difference Check Type (u8)
            /// </summary>
            /// <remarks>
            /// Angle difference judgment type (cylinder / prism)
            /// </remarks>
            public byte AngleDifferenceCheckType 
            {
                get => (byte)CellsByName["AngleDifferenceCheckType"].Value;
                set => CellsByName["AngleDifferenceCheckType"].Value = value;
            }
            

            // Def="dummy8 padding2[3]"
            /// <summary>
            /// Padding 2 (dummy8)
            /// </summary>
            /// <remarks>
            /// 
            /// </remarks>
            public object Padding2 
            {
                get => (object)CellsByName["Padding2"].Value;
                set => CellsByName["Padding2"].Value = value;
            }
            

            // Def="s32 allowAngle = 180"
            /// <summary>
            /// Allowable Angle Difference (s32)
            /// </summary>
            /// <remarks>
            /// Allowable angle difference (cylinder / prism)
            /// </remarks>
            public int AllowableAngleDifference 
            {
                get => (int)CellsByName["AllowableAngleDifference"].Value;
                set => CellsByName["AllowableAngleDifference"].Value = value;
            }
            

            // Def="s32 spotDummyPoly = -1"
            /// <summary>
            /// Action Spot Dummy Poly (s32)
            /// </summary>
            /// <remarks>
            /// If there is no Damipoli that specifies the Damipoli ID that will be the position of the action spot, or if -1 is entered, the center coordinates will be the reference.
            /// </remarks>
            public int ActionSpotDummyPoly 
            {
                get => (int)CellsByName["ActionSpotDummyPoly"].Value;
                set => CellsByName["ActionSpotDummyPoly"].Value = value;
            }
            

            // Def="u8 textBoxType"
            /// <summary>
            /// Textbox Type (u8)
            /// </summary>
            /// <remarks>
            /// Text box type
            /// </remarks>
            public byte TextboxType 
            {
                get => (byte)CellsByName["TextboxType"].Value;
                set => CellsByName["TextboxType"].Value = value;
            }
            

            // Def="dummy8 padding3[2]"
            /// <summary>
            /// Padding 3 (dummy8)
            /// </summary>
            /// <remarks>
            /// 
            /// </remarks>
            public object Padding3 
            {
                get => (object)CellsByName["Padding3"].Value;
                set => CellsByName["Padding3"].Value = value;
            }
            

            // Def="dummy8 padding5:1"
            /// <summary>
            /// Padding 5 (dummy8)
            /// </summary>
            /// <remarks>
            /// 
            /// </remarks>
            public object Padding5 
            {
                get => (object)CellsByName["Padding5"].Value;
                set => CellsByName["Padding5"].Value = value;
            }
            

            // Def="u8 isInvalidForRide:1"
            /// <summary>
            /// Invalid for Ride (u8)
            /// </summary>
            /// <remarks>
            /// If this item is YES, the action button will not appear when riding and no judgment will be made.
            /// </remarks>
            public byte InvalidForRide 
            {
                get => (byte)CellsByName["InvalidForRide"].Value;
                set => CellsByName["InvalidForRide"].Value = value;
            }
            

            // Def="u8 isGrayoutForRide:1"
            /// <summary>
            /// Greyout for Ride (u8)
            /// </summary>
            /// <remarks>
            /// If this item is YES, the action button will be grayed out when riding and no judgment will be made.
            /// </remarks>
            public byte GreyoutForRide 
            {
                get => (byte)CellsByName["GreyoutForRide"].Value;
                set => CellsByName["GreyoutForRide"].Value = value;
            }
            

            // Def="u8 isInvalidForCrouching:1"
            /// <summary>
            /// Invalid for Crouching (u8)
            /// </summary>
            /// <remarks>
            /// If this item is YES, the action button will not appear when crouching, and no judgment will be made.
            /// </remarks>
            public byte InvalidForCrouching 
            {
                get => (byte)CellsByName["InvalidForCrouching"].Value;
                set => CellsByName["InvalidForCrouching"].Value = value;
            }
            

            // Def="u8 isGrayoutForCrouching:1"
            /// <summary>
            /// Greyout for Crouching (u8)
            /// </summary>
            /// <remarks>
            /// If this item is YES, the action button will be grayed out when crouching and no judgment will be made.
            /// </remarks>
            public byte GreyoutForCrouching 
            {
                get => (byte)CellsByName["GreyoutForCrouching"].Value;
                set => CellsByName["GreyoutForCrouching"].Value = value;
            }
            

            // Def="dummy8 padding4:3"
            /// <summary>
            /// Padding 4 (dummy8)
            /// </summary>
            /// <remarks>
            /// 
            /// </remarks>
            public object Padding4 
            {
                get => (object)CellsByName["Padding4"].Value;
                set => CellsByName["Padding4"].Value = value;
            }
            

            // Def="s32 textId = -1"
            /// <summary>
            /// Text ID (s32)
            /// </summary>
            /// <remarks>
            /// Text ID to display
            /// </remarks>
            public int TextID 
            {
                get => (int)CellsByName["TextID"].Value;
                set => CellsByName["TextID"].Value = value;
            }
            

            // Def="u32 invalidFlag"
            /// <summary>
            /// Invalid Flag (u32)
            /// </summary>
            /// <remarks>
            /// If this flag is ON, the action button will not appear and no judgment will be made.
            /// </remarks>
            public uint InvalidFlag 
            {
                get => (uint)CellsByName["InvalidFlag"].Value;
                set => CellsByName["InvalidFlag"].Value = value;
            }
            

            // Def="u32 grayoutFlag"
            /// <summary>
            /// Grayout Flag (u32)
            /// </summary>
            /// <remarks>
            /// If this flag is ON, the action button will be grayed out and no judgment will be made.
            /// </remarks>
            public uint GrayoutFlag 
            {
                get => (uint)CellsByName["GrayoutFlag"].Value;
                set => CellsByName["GrayoutFlag"].Value = value;
            }
            

            // Def="s32 overrideActionButtonIdForRide = -1"
            /// <summary>
            /// Override Button ID for Ride (s32)
            /// </summary>
            /// <remarks>
            /// Replace with this action button ID parameter while riding (-1: No replacement)
            /// </remarks>
            public int OverrideButtonIDForRide 
            {
                get => (int)CellsByName["OverrideButtonIDForRide"].Value;
                set => CellsByName["OverrideButtonIDForRide"].Value = value;
            }
            

            // Def="f32 execInvalidTime"
            /// <summary>
            /// Execution Invalid Time (f32)
            /// </summary>
            /// <remarks>
            /// Invalid time after execution (-infinite by value)
            /// </remarks>
            public float ExecutionInvalidTime 
            {
                get => (float)CellsByName["ExecutionInvalidTime"].Value;
                set => CellsByName["ExecutionInvalidTime"].Value = value;
            }
            

            // Def="dummy8 padding6[28]"
            /// <summary>
            /// Padding 6 (dummy8)
            /// </summary>
            /// <remarks>
            /// 
            /// </remarks>
            public object Padding6 
            {
                get => (object)CellsByName["Padding6"].Value;
                set => CellsByName["Padding6"].Value = value;
            }
            
                }
            }
            
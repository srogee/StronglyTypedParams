
            namespace StronglyTypedParams
            {
                public class WepAbsorpPosParam : ParamRow
                {
                    public WepAbsorpPosParam() : base()
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
            

            // Def="u8 hangPosType"
            /// <summary>
            /// Sheath Position Type (u8)
            /// </summary>
            /// <remarks>
            /// The animation at the time of sword delivery changes depending on this value
            /// </remarks>
            public byte SheathPositionType 
            {
                get => (byte)CellsByName["SheathPositionType"].Value;
                set => CellsByName["SheathPositionType"].Value = value;
            }
            

            // Def="u8 isSkeletonBind"
            /// <summary>
            /// Is Skeleton Bind (u8)
            /// </summary>
            /// <remarks>
            /// Do you want to combine skeletons?
            /// </remarks>
            public byte IsSkeletonBind 
            {
                get => (byte)CellsByName["IsSkeletonBind"].Value;
                set => CellsByName["IsSkeletonBind"].Value = value;
            }
            

            // Def="dummy8 pad0[2]"
            /// <summary>
            /// Padding (dummy8)
            /// </summary>
            /// <remarks>
            /// 
            /// </remarks>
            public object Padding 
            {
                get => (object)CellsByName["Padding"].Value;
                set => CellsByName["Padding"].Value = value;
            }
            

            // Def="s16 right_0"
            /// <summary>
            /// Right Hand - Dummy Poly - Model [0] (s16)
            /// </summary>
            /// <remarks>
            /// Model 0 adsorption Damipoli when holding the weapon in one hand.
            /// </remarks>
            public short RightHandDummyPolyModel0 
            {
                get => (short)CellsByName["RightHandDummyPolyModel0"].Value;
                set => CellsByName["RightHandDummyPolyModel0"].Value = value;
            }
            

            // Def="s16 left_0"
            /// <summary>
            /// Left Hand - Dummy Poly - Model [0] (s16)
            /// </summary>
            /// <remarks>
            /// Model 0 adsorption Damipoli when holding the weapon in one hand.
            /// </remarks>
            public short LeftHandDummyPolyModel0 
            {
                get => (short)CellsByName["LeftHandDummyPolyModel0"].Value;
                set => CellsByName["LeftHandDummyPolyModel0"].Value = value;
            }
            

            // Def="s16 both_0"
            /// <summary>
            /// Both Hand - Dummy Poly - Model [0] (s16)
            /// </summary>
            /// <remarks>
            /// Model 0 adsorption Damipoli when holding a right-handed weapon with both hands.
            /// </remarks>
            public short BothHandDummyPolyModel0 
            {
                get => (short)CellsByName["BothHandDummyPolyModel0"].Value;
                set => CellsByName["BothHandDummyPolyModel0"].Value = value;
            }
            

            // Def="s16 leftHang_0"
            /// <summary>
            /// Left Sheath - Dummy Poly - Model [0] (s16)
            /// </summary>
            /// <remarks>
            /// Model 0 adsorption Damipoli when holding a weapon in the left hand and delivering the weapon.
            /// </remarks>
            public short LeftSheathDummyPolyModel0 
            {
                get => (short)CellsByName["LeftSheathDummyPolyModel0"].Value;
                set => CellsByName["LeftSheathDummyPolyModel0"].Value = value;
            }
            

            // Def="s16 rightHang_0"
            /// <summary>
            /// Right Sheath - Dummy Poly - Model [0] (s16)
            /// </summary>
            /// <remarks>
            /// Model 0 adsorption Damipoli when holding a weapon in the right hand and delivering the weapon.
            /// </remarks>
            public short RightSheathDummyPolyModel0 
            {
                get => (short)CellsByName["RightSheathDummyPolyModel0"].Value;
                set => CellsByName["RightSheathDummyPolyModel0"].Value = value;
            }
            

            // Def="s16 right_1"
            /// <summary>
            /// Right Hand - Dummy Poly - Model [1] (s16)
            /// </summary>
            /// <remarks>
            /// Model 1 adsorption Damipoli when holding the weapon in one hand.
            /// </remarks>
            public short RightHandDummyPolyModel1 
            {
                get => (short)CellsByName["RightHandDummyPolyModel1"].Value;
                set => CellsByName["RightHandDummyPolyModel1"].Value = value;
            }
            

            // Def="s16 left_1"
            /// <summary>
            /// Left Hand - Dummy Poly - Model [1] (s16)
            /// </summary>
            /// <remarks>
            /// Model 1 adsorption Damipoli when holding the weapon in one hand.
            /// </remarks>
            public short LeftHandDummyPolyModel1 
            {
                get => (short)CellsByName["LeftHandDummyPolyModel1"].Value;
                set => CellsByName["LeftHandDummyPolyModel1"].Value = value;
            }
            

            // Def="s16 both_1"
            /// <summary>
            /// Both Hand - Dummy Poly - Model [1] (s16)
            /// </summary>
            /// <remarks>
            /// Model 1 adsorption Damipoli when holding a right-handed weapon with both hands.
            /// </remarks>
            public short BothHandDummyPolyModel1 
            {
                get => (short)CellsByName["BothHandDummyPolyModel1"].Value;
                set => CellsByName["BothHandDummyPolyModel1"].Value = value;
            }
            

            // Def="s16 leftHang_1"
            /// <summary>
            /// Left Sheath - Dummy Poly - Model [1] (s16)
            /// </summary>
            /// <remarks>
            /// Model 1 adsorption Damipoli when holding a weapon in the left hand and delivering the weapon.
            /// </remarks>
            public short LeftSheathDummyPolyModel1 
            {
                get => (short)CellsByName["LeftSheathDummyPolyModel1"].Value;
                set => CellsByName["LeftSheathDummyPolyModel1"].Value = value;
            }
            

            // Def="s16 rightHang_1"
            /// <summary>
            /// Right Sheath - Dummy Poly - Model [1] (s16)
            /// </summary>
            /// <remarks>
            /// Model 1 adsorption Damipoli when holding a weapon in the right hand and delivering the weapon.
            /// </remarks>
            public short RightSheathDummyPolyModel1 
            {
                get => (short)CellsByName["RightSheathDummyPolyModel1"].Value;
                set => CellsByName["RightSheathDummyPolyModel1"].Value = value;
            }
            

            // Def="s16 right_2"
            /// <summary>
            /// Right Hand - Dummy Poly - Model [2] (s16)
            /// </summary>
            /// <remarks>
            /// Model 2 adsorption Damipoli when holding the weapon in one hand.
            /// </remarks>
            public short RightHandDummyPolyModel2 
            {
                get => (short)CellsByName["RightHandDummyPolyModel2"].Value;
                set => CellsByName["RightHandDummyPolyModel2"].Value = value;
            }
            

            // Def="s16 left_2"
            /// <summary>
            /// Left Hand - Dummy Poly - Model [2] (s16)
            /// </summary>
            /// <remarks>
            /// Model 2 adsorption Damipoli when holding the weapon in one hand.
            /// </remarks>
            public short LeftHandDummyPolyModel2 
            {
                get => (short)CellsByName["LeftHandDummyPolyModel2"].Value;
                set => CellsByName["LeftHandDummyPolyModel2"].Value = value;
            }
            

            // Def="s16 both_2"
            /// <summary>
            /// Both Hand - Dummy Poly - Model [2] (s16)
            /// </summary>
            /// <remarks>
            /// Model 2 adsorption Damipoli when holding a right-handed weapon with both hands.
            /// </remarks>
            public short BothHandDummyPolyModel2 
            {
                get => (short)CellsByName["BothHandDummyPolyModel2"].Value;
                set => CellsByName["BothHandDummyPolyModel2"].Value = value;
            }
            

            // Def="s16 leftHang_2"
            /// <summary>
            /// Left Sheath - Dummy Poly - Model [2] (s16)
            /// </summary>
            /// <remarks>
            /// Model 2 adsorption Damipoli when holding a weapon in the left hand and delivering the weapon.
            /// </remarks>
            public short LeftSheathDummyPolyModel2 
            {
                get => (short)CellsByName["LeftSheathDummyPolyModel2"].Value;
                set => CellsByName["LeftSheathDummyPolyModel2"].Value = value;
            }
            

            // Def="s16 rightHang_2"
            /// <summary>
            /// Right Sheath - Dummy Poly - Model [2] (s16)
            /// </summary>
            /// <remarks>
            /// Model 2 adsorption Damipoli when holding a weapon in the right hand and delivering the weapon.
            /// </remarks>
            public short RightSheathDummyPolyModel2 
            {
                get => (short)CellsByName["RightSheathDummyPolyModel2"].Value;
                set => CellsByName["RightSheathDummyPolyModel2"].Value = value;
            }
            

            // Def="s16 right_3"
            /// <summary>
            /// Right Hand - Dummy Poly - Model [3] (s16)
            /// </summary>
            /// <remarks>
            /// Model 3 adsorption Damipoli when holding the weapon in one hand.
            /// </remarks>
            public short RightHandDummyPolyModel3 
            {
                get => (short)CellsByName["RightHandDummyPolyModel3"].Value;
                set => CellsByName["RightHandDummyPolyModel3"].Value = value;
            }
            

            // Def="s16 left_3"
            /// <summary>
            /// Left Hand - Dummy Poly - Model [3] (s16)
            /// </summary>
            /// <remarks>
            /// Model 3 adsorption Damipoli when holding the weapon in one hand.
            /// </remarks>
            public short LeftHandDummyPolyModel3 
            {
                get => (short)CellsByName["LeftHandDummyPolyModel3"].Value;
                set => CellsByName["LeftHandDummyPolyModel3"].Value = value;
            }
            

            // Def="s16 both_3"
            /// <summary>
            /// Both Hand - Dummy Poly - Model [3] (s16)
            /// </summary>
            /// <remarks>
            /// Model 3 adsorption Damipoli when holding a right-handed weapon with both hands.
            /// </remarks>
            public short BothHandDummyPolyModel3 
            {
                get => (short)CellsByName["BothHandDummyPolyModel3"].Value;
                set => CellsByName["BothHandDummyPolyModel3"].Value = value;
            }
            

            // Def="s16 leftHang_3"
            /// <summary>
            /// Left Sheath - Dummy Poly - Model [3] (s16)
            /// </summary>
            /// <remarks>
            /// Model 3 Adsorption Damipoli when holding a weapon in the left hand and delivering the weapon.
            /// </remarks>
            public short LeftSheathDummyPolyModel3 
            {
                get => (short)CellsByName["LeftSheathDummyPolyModel3"].Value;
                set => CellsByName["LeftSheathDummyPolyModel3"].Value = value;
            }
            

            // Def="s16 rightHang_3"
            /// <summary>
            /// Right Sheath - Dummy Poly - Model [3] (s16)
            /// </summary>
            /// <remarks>
            /// Model 3 Adsorption Damipoli when holding a weapon in his right hand and delivering the weapon.
            /// </remarks>
            public short RightSheathDummyPolyModel3 
            {
                get => (short)CellsByName["RightSheathDummyPolyModel3"].Value;
                set => CellsByName["RightSheathDummyPolyModel3"].Value = value;
            }
            

            // Def="u8 wepInvisibleType_0"
            /// <summary>
            /// Hidden Type - Model [0] (u8)
            /// </summary>
            /// <remarks>
            /// Hidden type of model 0. When hiding a weapon with TAE, erase the one that matches this
            /// </remarks>
            public byte HiddenTypeModel0 
            {
                get => (byte)CellsByName["HiddenTypeModel0"].Value;
                set => CellsByName["HiddenTypeModel0"].Value = value;
            }
            

            // Def="u8 wepInvisibleType_1"
            /// <summary>
            /// Hidden Type - Model [1] (u8)
            /// </summary>
            /// <remarks>
            /// Hidden type of model 1. When hiding a weapon with TAE, erase the one that matches this
            /// </remarks>
            public byte HiddenTypeModel1 
            {
                get => (byte)CellsByName["HiddenTypeModel1"].Value;
                set => CellsByName["HiddenTypeModel1"].Value = value;
            }
            

            // Def="u8 wepInvisibleType_2"
            /// <summary>
            /// Hidden Type - Model [2] (u8)
            /// </summary>
            /// <remarks>
            /// Hidden type of model 2. When hiding a weapon with TAE, erase the one that matches this
            /// </remarks>
            public byte HiddenTypeModel2 
            {
                get => (byte)CellsByName["HiddenTypeModel2"].Value;
                set => CellsByName["HiddenTypeModel2"].Value = value;
            }
            

            // Def="u8 wepInvisibleType_3"
            /// <summary>
            /// Hidden Type - Model [3] (u8)
            /// </summary>
            /// <remarks>
            /// Model 3 hidden type. When hiding a weapon with TAE, erase the one that matches this
            /// </remarks>
            public byte HiddenTypeModel3 
            {
                get => (byte)CellsByName["HiddenTypeModel3"].Value;
                set => CellsByName["HiddenTypeModel3"].Value = value;
            }
            

            // Def="s16 leftBoth_0"
            /// <summary>
            /// Left Both-Hand - Dummy Poly - Model [0] (s16)
            /// </summary>
            /// <remarks>
            /// Model 0 adsorption Damipoli when holding a left-handed weapon with both hands.
            /// </remarks>
            public short LeftBothHandDummyPolyModel0 
            {
                get => (short)CellsByName["LeftBothHandDummyPolyModel0"].Value;
                set => CellsByName["LeftBothHandDummyPolyModel0"].Value = value;
            }
            

            // Def="s16 leftBoth_1"
            /// <summary>
            /// Left Both-Hand - Dummy Poly - Model [1] (s16)
            /// </summary>
            /// <remarks>
            /// Model 1 adsorption Damipoli when holding a left-handed weapon with both hands.
            /// </remarks>
            public short LeftBothHandDummyPolyModel1 
            {
                get => (short)CellsByName["LeftBothHandDummyPolyModel1"].Value;
                set => CellsByName["LeftBothHandDummyPolyModel1"].Value = value;
            }
            

            // Def="s16 leftBoth_2"
            /// <summary>
            /// Left Both-Hand - Dummy Poly - Model [2] (s16)
            /// </summary>
            /// <remarks>
            /// Model 2 adsorption Damipoli when holding a left-handed weapon with both hands.
            /// </remarks>
            public short LeftBothHandDummyPolyModel2 
            {
                get => (short)CellsByName["LeftBothHandDummyPolyModel2"].Value;
                set => CellsByName["LeftBothHandDummyPolyModel2"].Value = value;
            }
            

            // Def="s16 leftBoth_3"
            /// <summary>
            /// Left Both-Hand - Dummy Poly - Model [3] (s16)
            /// </summary>
            /// <remarks>
            /// Model 3 adsorption Damipoli when holding a left-handed weapon with both hands.
            /// </remarks>
            public short LeftBothHandDummyPolyModel3 
            {
                get => (short)CellsByName["LeftBothHandDummyPolyModel3"].Value;
                set => CellsByName["LeftBothHandDummyPolyModel3"].Value = value;
            }
            

            // Def="u8 dispPosType_right_0"
            /// <summary>
            /// Display Position - Right Hand - Model [0] (u8)
            /// </summary>
            /// <remarks>
            /// Model 0_ Right-hand display position (used to specify hidden position from TAE)
            /// </remarks>
            public byte DisplayPositionRightHandModel0 
            {
                get => (byte)CellsByName["DisplayPositionRightHandModel0"].Value;
                set => CellsByName["DisplayPositionRightHandModel0"].Value = value;
            }
            

            // Def="u8 dispPosType_left_0"
            /// <summary>
            /// Display Position - Left Hand - Model [0] (u8)
            /// </summary>
            /// <remarks>
            /// Model 0_Left hand display position (used to specify hidden position from TAE)
            /// </remarks>
            public byte DisplayPositionLeftHandModel0 
            {
                get => (byte)CellsByName["DisplayPositionLeftHandModel0"].Value;
                set => CellsByName["DisplayPositionLeftHandModel0"].Value = value;
            }
            

            // Def="u8 dispPosType_rightBoth_0"
            /// <summary>
            /// Display Position - Right Both-hand - Model [0] (u8)
            /// </summary>
            /// <remarks>
            /// Model 0_Right-handed two-handed display position (used to specify hidden position from TAE)
            /// </remarks>
            public byte DisplayPositionRightBothHandModel0 
            {
                get => (byte)CellsByName["DisplayPositionRightBothHandModel0"].Value;
                set => CellsByName["DisplayPositionRightBothHandModel0"].Value = value;
            }
            

            // Def="u8 dispPosType_leftBoth_0"
            /// <summary>
            /// Display Position - Left Both-Hand - Model [0] (u8)
            /// </summary>
            /// <remarks>
            /// Model 0_ Left-handed two-handed display position (used to specify hidden position from TAE)
            /// </remarks>
            public byte DisplayPositionLeftBothHandModel0 
            {
                get => (byte)CellsByName["DisplayPositionLeftBothHandModel0"].Value;
                set => CellsByName["DisplayPositionLeftBothHandModel0"].Value = value;
            }
            

            // Def="u8 dispPosType_rightHang_0"
            /// <summary>
            /// Display Position - Right Sheath - Model [0] (u8)
            /// </summary>
            /// <remarks>
            /// Model 0_ Right-handed sword display position (used to specify the non-display position from TAE)
            /// </remarks>
            public byte DisplayPositionRightSheathModel0 
            {
                get => (byte)CellsByName["DisplayPositionRightSheathModel0"].Value;
                set => CellsByName["DisplayPositionRightSheathModel0"].Value = value;
            }
            

            // Def="u8 dispPosType_leftHang_0"
            /// <summary>
            /// Display Position - Left Sheath - Model [0] (u8)
            /// </summary>
            /// <remarks>
            /// Model 0_ Left hand sword display position (used to specify the non-display position from TAE)
            /// </remarks>
            public byte DisplayPositionLeftSheathModel0 
            {
                get => (byte)CellsByName["DisplayPositionLeftSheathModel0"].Value;
                set => CellsByName["DisplayPositionLeftSheathModel0"].Value = value;
            }
            

            // Def="u8 dispPosType_right_1"
            /// <summary>
            /// Display Position - Right Hand - Model [1] (u8)
            /// </summary>
            /// <remarks>
            /// Model 1_ Right-hand display position (used to specify hidden position from TAE)
            /// </remarks>
            public byte DisplayPositionRightHandModel1 
            {
                get => (byte)CellsByName["DisplayPositionRightHandModel1"].Value;
                set => CellsByName["DisplayPositionRightHandModel1"].Value = value;
            }
            

            // Def="u8 dispPosType_left_1"
            /// <summary>
            /// Display Position - Left Hand - Model [1] (u8)
            /// </summary>
            /// <remarks>
            /// Model 1_Left hand display position (used to specify hidden position from TAE)
            /// </remarks>
            public byte DisplayPositionLeftHandModel1 
            {
                get => (byte)CellsByName["DisplayPositionLeftHandModel1"].Value;
                set => CellsByName["DisplayPositionLeftHandModel1"].Value = value;
            }
            

            // Def="u8 dispPosType_rightBoth_1"
            /// <summary>
            /// Display Position - Right Both-hand - Model [1] (u8)
            /// </summary>
            /// <remarks>
            /// Model 1_Right-handed two-handed display position (used to specify hidden position from TAE)
            /// </remarks>
            public byte DisplayPositionRightBothHandModel1 
            {
                get => (byte)CellsByName["DisplayPositionRightBothHandModel1"].Value;
                set => CellsByName["DisplayPositionRightBothHandModel1"].Value = value;
            }
            

            // Def="u8 dispPosType_leftBoth_1"
            /// <summary>
            /// Display Position - Left Both-Hand - Model [1] (u8)
            /// </summary>
            /// <remarks>
            /// Model 1_ Left-handed two-handed display position (used to specify hidden position from TAE)
            /// </remarks>
            public byte DisplayPositionLeftBothHandModel1 
            {
                get => (byte)CellsByName["DisplayPositionLeftBothHandModel1"].Value;
                set => CellsByName["DisplayPositionLeftBothHandModel1"].Value = value;
            }
            

            // Def="u8 dispPosType_rightHang_1"
            /// <summary>
            /// Display Position - Right Sheath - Model [1] (u8)
            /// </summary>
            /// <remarks>
            /// Model 1_ Right-handed sword display position (used to specify the non-display position from TAE)
            /// </remarks>
            public byte DisplayPositionRightSheathModel1 
            {
                get => (byte)CellsByName["DisplayPositionRightSheathModel1"].Value;
                set => CellsByName["DisplayPositionRightSheathModel1"].Value = value;
            }
            

            // Def="u8 dispPosType_leftHang_1"
            /// <summary>
            /// Display Position - Left Sheath - Model [1] (u8)
            /// </summary>
            /// <remarks>
            /// Model 1_ Left hand sword display position (used to specify the non-display position from TAE)
            /// </remarks>
            public byte DisplayPositionLeftSheathModel1 
            {
                get => (byte)CellsByName["DisplayPositionLeftSheathModel1"].Value;
                set => CellsByName["DisplayPositionLeftSheathModel1"].Value = value;
            }
            

            // Def="u8 dispPosType_right_2"
            /// <summary>
            /// Display Position - Right Hand - Model [2] (u8)
            /// </summary>
            /// <remarks>
            /// Model 2_ Right-hand display position (used to specify hidden position from TAE)
            /// </remarks>
            public byte DisplayPositionRightHandModel2 
            {
                get => (byte)CellsByName["DisplayPositionRightHandModel2"].Value;
                set => CellsByName["DisplayPositionRightHandModel2"].Value = value;
            }
            

            // Def="u8 dispPosType_left_2"
            /// <summary>
            /// Display Position - Left Hand - Model [2] (u8)
            /// </summary>
            /// <remarks>
            /// Model 2_Left hand display position (used to specify hidden position from TAE)
            /// </remarks>
            public byte DisplayPositionLeftHandModel2 
            {
                get => (byte)CellsByName["DisplayPositionLeftHandModel2"].Value;
                set => CellsByName["DisplayPositionLeftHandModel2"].Value = value;
            }
            

            // Def="u8 dispPosType_rightBoth_2"
            /// <summary>
            /// Display Position - Right Both-hand - Model [2] (u8)
            /// </summary>
            /// <remarks>
            /// Model 2_Right-handed two-handed display position (used to specify hidden position from TAE)
            /// </remarks>
            public byte DisplayPositionRightBothHandModel2 
            {
                get => (byte)CellsByName["DisplayPositionRightBothHandModel2"].Value;
                set => CellsByName["DisplayPositionRightBothHandModel2"].Value = value;
            }
            

            // Def="u8 dispPosType_leftBoth_2"
            /// <summary>
            /// Display Position - Left Both-Hand - Model [2] (u8)
            /// </summary>
            /// <remarks>
            /// Model 2_ Left-handed two-handed display position (used to specify hidden position from TAE)
            /// </remarks>
            public byte DisplayPositionLeftBothHandModel2 
            {
                get => (byte)CellsByName["DisplayPositionLeftBothHandModel2"].Value;
                set => CellsByName["DisplayPositionLeftBothHandModel2"].Value = value;
            }
            

            // Def="u8 dispPosType_rightHang_2"
            /// <summary>
            /// Display Position - Right Sheath - Model [2] (u8)
            /// </summary>
            /// <remarks>
            /// Model 2_Right-handed sword display position (used to specify the non-display position from TAE)
            /// </remarks>
            public byte DisplayPositionRightSheathModel2 
            {
                get => (byte)CellsByName["DisplayPositionRightSheathModel2"].Value;
                set => CellsByName["DisplayPositionRightSheathModel2"].Value = value;
            }
            

            // Def="u8 dispPosType_leftHang_2"
            /// <summary>
            /// Display Position - Left Sheath - Model [2] (u8)
            /// </summary>
            /// <remarks>
            /// Model 2_ Left hand sword display position (used to specify the non-display position from TAE)
            /// </remarks>
            public byte DisplayPositionLeftSheathModel2 
            {
                get => (byte)CellsByName["DisplayPositionLeftSheathModel2"].Value;
                set => CellsByName["DisplayPositionLeftSheathModel2"].Value = value;
            }
            

            // Def="u8 dispPosType_right_3"
            /// <summary>
            /// Display Position - Right Hand - Model [3] (u8)
            /// </summary>
            /// <remarks>
            /// Model 3_ Right-hand display position (used to specify hidden position from TAE)
            /// </remarks>
            public byte DisplayPositionRightHandModel3 
            {
                get => (byte)CellsByName["DisplayPositionRightHandModel3"].Value;
                set => CellsByName["DisplayPositionRightHandModel3"].Value = value;
            }
            

            // Def="u8 dispPosType_left_3"
            /// <summary>
            /// Display Position - Left Hand - Model [3] (u8)
            /// </summary>
            /// <remarks>
            /// Model 3_Left hand display position (used to specify hidden position from TAE)
            /// </remarks>
            public byte DisplayPositionLeftHandModel3 
            {
                get => (byte)CellsByName["DisplayPositionLeftHandModel3"].Value;
                set => CellsByName["DisplayPositionLeftHandModel3"].Value = value;
            }
            

            // Def="u8 dispPosType_rightBoth_3"
            /// <summary>
            /// Display Position - Right Both-hand - Model [3] (u8)
            /// </summary>
            /// <remarks>
            /// Model 3_Right-handed two-handed display position (used to specify hidden position from TAE)
            /// </remarks>
            public byte DisplayPositionRightBothHandModel3 
            {
                get => (byte)CellsByName["DisplayPositionRightBothHandModel3"].Value;
                set => CellsByName["DisplayPositionRightBothHandModel3"].Value = value;
            }
            

            // Def="u8 dispPosType_leftBoth_3"
            /// <summary>
            /// Display Position - Left Both-Hand - Model [3] (u8)
            /// </summary>
            /// <remarks>
            /// Model 3_ Left-handed two-handed display position (used to specify hidden position from TAE)
            /// </remarks>
            public byte DisplayPositionLeftBothHandModel3 
            {
                get => (byte)CellsByName["DisplayPositionLeftBothHandModel3"].Value;
                set => CellsByName["DisplayPositionLeftBothHandModel3"].Value = value;
            }
            

            // Def="u8 dispPosType_rightHang_3"
            /// <summary>
            /// Display Position - Right Sheath - Model [3] (u8)
            /// </summary>
            /// <remarks>
            /// Model 3_Right-handed sword display position (used to specify the non-display position from TAE)
            /// </remarks>
            public byte DisplayPositionRightSheathModel3 
            {
                get => (byte)CellsByName["DisplayPositionRightSheathModel3"].Value;
                set => CellsByName["DisplayPositionRightSheathModel3"].Value = value;
            }
            

            // Def="u8 dispPosType_leftHang_3"
            /// <summary>
            /// Display Position - Left Sheath - Model [3] (u8)
            /// </summary>
            /// <remarks>
            /// Model 3_ Left hand sword display position (used to specify the non-display position from TAE)
            /// </remarks>
            public byte DisplayPositionLeftSheathModel3 
            {
                get => (byte)CellsByName["DisplayPositionLeftSheathModel3"].Value;
                set => CellsByName["DisplayPositionLeftSheathModel3"].Value = value;
            }
            

            // Def="dummy8 reserve[12]"
            /// <summary>
            /// Reserved area (dummy8)
            /// </summary>
            /// <remarks>
            /// 
            /// </remarks>
            public object ReservedArea 
            {
                get => (object)CellsByName["ReservedArea"].Value;
                set => CellsByName["ReservedArea"].Value = value;
            }
            
                }
            }
            
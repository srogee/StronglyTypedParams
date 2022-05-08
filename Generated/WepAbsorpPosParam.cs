
            namespace StronglyTypedParams
            {
                // WEP_ABSORP_POS_PARAM_ST
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
            

            // Def="u8 hangPosType"
            /// <summary>
            /// Sheath Position Type (u8)
            /// </summary>
            /// <remarks>
            /// The animation at the time of sword delivery changes depending on this value
            /// </remarks>
            public WepHangPosType SheathPositionType 
            {
                get => (WepHangPosType)CellsByName["SheathPositionType"].Value;
                set => CellsByName["SheathPositionType"].Value = (byte)value;
            }
            

            // Def="u8 isSkeletonBind"
            /// <summary>
            /// Is Skeleton Bind (u8)
            /// </summary>
            /// <remarks>
            /// Do you want to combine skeletons?
            /// </remarks>
            public BoolCirclecrossType IsSkeletonBind 
            {
                get => (BoolCirclecrossType)CellsByName["IsSkeletonBind"].Value;
                set => CellsByName["IsSkeletonBind"].Value = (byte)value;
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
                set => CellsByName["Padding"].Value = (object)value;
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
                set => CellsByName["RightHandDummyPolyModel0"].Value = (short)value;
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
                set => CellsByName["LeftHandDummyPolyModel0"].Value = (short)value;
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
                set => CellsByName["BothHandDummyPolyModel0"].Value = (short)value;
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
                set => CellsByName["LeftSheathDummyPolyModel0"].Value = (short)value;
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
                set => CellsByName["RightSheathDummyPolyModel0"].Value = (short)value;
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
                set => CellsByName["RightHandDummyPolyModel1"].Value = (short)value;
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
                set => CellsByName["LeftHandDummyPolyModel1"].Value = (short)value;
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
                set => CellsByName["BothHandDummyPolyModel1"].Value = (short)value;
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
                set => CellsByName["LeftSheathDummyPolyModel1"].Value = (short)value;
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
                set => CellsByName["RightSheathDummyPolyModel1"].Value = (short)value;
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
                set => CellsByName["RightHandDummyPolyModel2"].Value = (short)value;
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
                set => CellsByName["LeftHandDummyPolyModel2"].Value = (short)value;
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
                set => CellsByName["BothHandDummyPolyModel2"].Value = (short)value;
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
                set => CellsByName["LeftSheathDummyPolyModel2"].Value = (short)value;
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
                set => CellsByName["RightSheathDummyPolyModel2"].Value = (short)value;
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
                set => CellsByName["RightHandDummyPolyModel3"].Value = (short)value;
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
                set => CellsByName["LeftHandDummyPolyModel3"].Value = (short)value;
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
                set => CellsByName["BothHandDummyPolyModel3"].Value = (short)value;
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
                set => CellsByName["LeftSheathDummyPolyModel3"].Value = (short)value;
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
                set => CellsByName["RightSheathDummyPolyModel3"].Value = (short)value;
            }
            

            // Def="u8 wepInvisibleType_0"
            /// <summary>
            /// Hidden Type - Model [0] (u8)
            /// </summary>
            /// <remarks>
            /// Hidden type of model 0. When hiding a weapon with TAE, erase the one that matches this
            /// </remarks>
            public WepInvisibleType HiddenTypeModel0 
            {
                get => (WepInvisibleType)CellsByName["HiddenTypeModel0"].Value;
                set => CellsByName["HiddenTypeModel0"].Value = (byte)value;
            }
            

            // Def="u8 wepInvisibleType_1"
            /// <summary>
            /// Hidden Type - Model [1] (u8)
            /// </summary>
            /// <remarks>
            /// Hidden type of model 1. When hiding a weapon with TAE, erase the one that matches this
            /// </remarks>
            public WepInvisibleType HiddenTypeModel1 
            {
                get => (WepInvisibleType)CellsByName["HiddenTypeModel1"].Value;
                set => CellsByName["HiddenTypeModel1"].Value = (byte)value;
            }
            

            // Def="u8 wepInvisibleType_2"
            /// <summary>
            /// Hidden Type - Model [2] (u8)
            /// </summary>
            /// <remarks>
            /// Hidden type of model 2. When hiding a weapon with TAE, erase the one that matches this
            /// </remarks>
            public WepInvisibleType HiddenTypeModel2 
            {
                get => (WepInvisibleType)CellsByName["HiddenTypeModel2"].Value;
                set => CellsByName["HiddenTypeModel2"].Value = (byte)value;
            }
            

            // Def="u8 wepInvisibleType_3"
            /// <summary>
            /// Hidden Type - Model [3] (u8)
            /// </summary>
            /// <remarks>
            /// Model 3 hidden type. When hiding a weapon with TAE, erase the one that matches this
            /// </remarks>
            public WepInvisibleType HiddenTypeModel3 
            {
                get => (WepInvisibleType)CellsByName["HiddenTypeModel3"].Value;
                set => CellsByName["HiddenTypeModel3"].Value = (byte)value;
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
                set => CellsByName["LeftBothHandDummyPolyModel0"].Value = (short)value;
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
                set => CellsByName["LeftBothHandDummyPolyModel1"].Value = (short)value;
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
                set => CellsByName["LeftBothHandDummyPolyModel2"].Value = (short)value;
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
                set => CellsByName["LeftBothHandDummyPolyModel3"].Value = (short)value;
            }
            

            // Def="u8 dispPosType_right_0"
            /// <summary>
            /// Display Position - Right Hand - Model [0] (u8)
            /// </summary>
            /// <remarks>
            /// Model 0_ Right-hand display position (used to specify hidden position from TAE)
            /// </remarks>
            public WepDispPosType DisplayPositionRightHandModel0 
            {
                get => (WepDispPosType)CellsByName["DisplayPositionRightHandModel0"].Value;
                set => CellsByName["DisplayPositionRightHandModel0"].Value = (byte)value;
            }
            

            // Def="u8 dispPosType_left_0"
            /// <summary>
            /// Display Position - Left Hand - Model [0] (u8)
            /// </summary>
            /// <remarks>
            /// Model 0_Left hand display position (used to specify hidden position from TAE)
            /// </remarks>
            public WepDispPosType DisplayPositionLeftHandModel0 
            {
                get => (WepDispPosType)CellsByName["DisplayPositionLeftHandModel0"].Value;
                set => CellsByName["DisplayPositionLeftHandModel0"].Value = (byte)value;
            }
            

            // Def="u8 dispPosType_rightBoth_0"
            /// <summary>
            /// Display Position - Right Both-hand - Model [0] (u8)
            /// </summary>
            /// <remarks>
            /// Model 0_Right-handed two-handed display position (used to specify hidden position from TAE)
            /// </remarks>
            public WepDispPosType DisplayPositionRightBothHandModel0 
            {
                get => (WepDispPosType)CellsByName["DisplayPositionRightBothHandModel0"].Value;
                set => CellsByName["DisplayPositionRightBothHandModel0"].Value = (byte)value;
            }
            

            // Def="u8 dispPosType_leftBoth_0"
            /// <summary>
            /// Display Position - Left Both-Hand - Model [0] (u8)
            /// </summary>
            /// <remarks>
            /// Model 0_ Left-handed two-handed display position (used to specify hidden position from TAE)
            /// </remarks>
            public WepDispPosType DisplayPositionLeftBothHandModel0 
            {
                get => (WepDispPosType)CellsByName["DisplayPositionLeftBothHandModel0"].Value;
                set => CellsByName["DisplayPositionLeftBothHandModel0"].Value = (byte)value;
            }
            

            // Def="u8 dispPosType_rightHang_0"
            /// <summary>
            /// Display Position - Right Sheath - Model [0] (u8)
            /// </summary>
            /// <remarks>
            /// Model 0_ Right-handed sword display position (used to specify the non-display position from TAE)
            /// </remarks>
            public WepDispPosType DisplayPositionRightSheathModel0 
            {
                get => (WepDispPosType)CellsByName["DisplayPositionRightSheathModel0"].Value;
                set => CellsByName["DisplayPositionRightSheathModel0"].Value = (byte)value;
            }
            

            // Def="u8 dispPosType_leftHang_0"
            /// <summary>
            /// Display Position - Left Sheath - Model [0] (u8)
            /// </summary>
            /// <remarks>
            /// Model 0_ Left hand sword display position (used to specify the non-display position from TAE)
            /// </remarks>
            public WepDispPosType DisplayPositionLeftSheathModel0 
            {
                get => (WepDispPosType)CellsByName["DisplayPositionLeftSheathModel0"].Value;
                set => CellsByName["DisplayPositionLeftSheathModel0"].Value = (byte)value;
            }
            

            // Def="u8 dispPosType_right_1"
            /// <summary>
            /// Display Position - Right Hand - Model [1] (u8)
            /// </summary>
            /// <remarks>
            /// Model 1_ Right-hand display position (used to specify hidden position from TAE)
            /// </remarks>
            public WepDispPosType DisplayPositionRightHandModel1 
            {
                get => (WepDispPosType)CellsByName["DisplayPositionRightHandModel1"].Value;
                set => CellsByName["DisplayPositionRightHandModel1"].Value = (byte)value;
            }
            

            // Def="u8 dispPosType_left_1"
            /// <summary>
            /// Display Position - Left Hand - Model [1] (u8)
            /// </summary>
            /// <remarks>
            /// Model 1_Left hand display position (used to specify hidden position from TAE)
            /// </remarks>
            public WepDispPosType DisplayPositionLeftHandModel1 
            {
                get => (WepDispPosType)CellsByName["DisplayPositionLeftHandModel1"].Value;
                set => CellsByName["DisplayPositionLeftHandModel1"].Value = (byte)value;
            }
            

            // Def="u8 dispPosType_rightBoth_1"
            /// <summary>
            /// Display Position - Right Both-hand - Model [1] (u8)
            /// </summary>
            /// <remarks>
            /// Model 1_Right-handed two-handed display position (used to specify hidden position from TAE)
            /// </remarks>
            public WepDispPosType DisplayPositionRightBothHandModel1 
            {
                get => (WepDispPosType)CellsByName["DisplayPositionRightBothHandModel1"].Value;
                set => CellsByName["DisplayPositionRightBothHandModel1"].Value = (byte)value;
            }
            

            // Def="u8 dispPosType_leftBoth_1"
            /// <summary>
            /// Display Position - Left Both-Hand - Model [1] (u8)
            /// </summary>
            /// <remarks>
            /// Model 1_ Left-handed two-handed display position (used to specify hidden position from TAE)
            /// </remarks>
            public WepDispPosType DisplayPositionLeftBothHandModel1 
            {
                get => (WepDispPosType)CellsByName["DisplayPositionLeftBothHandModel1"].Value;
                set => CellsByName["DisplayPositionLeftBothHandModel1"].Value = (byte)value;
            }
            

            // Def="u8 dispPosType_rightHang_1"
            /// <summary>
            /// Display Position - Right Sheath - Model [1] (u8)
            /// </summary>
            /// <remarks>
            /// Model 1_ Right-handed sword display position (used to specify the non-display position from TAE)
            /// </remarks>
            public WepDispPosType DisplayPositionRightSheathModel1 
            {
                get => (WepDispPosType)CellsByName["DisplayPositionRightSheathModel1"].Value;
                set => CellsByName["DisplayPositionRightSheathModel1"].Value = (byte)value;
            }
            

            // Def="u8 dispPosType_leftHang_1"
            /// <summary>
            /// Display Position - Left Sheath - Model [1] (u8)
            /// </summary>
            /// <remarks>
            /// Model 1_ Left hand sword display position (used to specify the non-display position from TAE)
            /// </remarks>
            public WepDispPosType DisplayPositionLeftSheathModel1 
            {
                get => (WepDispPosType)CellsByName["DisplayPositionLeftSheathModel1"].Value;
                set => CellsByName["DisplayPositionLeftSheathModel1"].Value = (byte)value;
            }
            

            // Def="u8 dispPosType_right_2"
            /// <summary>
            /// Display Position - Right Hand - Model [2] (u8)
            /// </summary>
            /// <remarks>
            /// Model 2_ Right-hand display position (used to specify hidden position from TAE)
            /// </remarks>
            public WepDispPosType DisplayPositionRightHandModel2 
            {
                get => (WepDispPosType)CellsByName["DisplayPositionRightHandModel2"].Value;
                set => CellsByName["DisplayPositionRightHandModel2"].Value = (byte)value;
            }
            

            // Def="u8 dispPosType_left_2"
            /// <summary>
            /// Display Position - Left Hand - Model [2] (u8)
            /// </summary>
            /// <remarks>
            /// Model 2_Left hand display position (used to specify hidden position from TAE)
            /// </remarks>
            public WepDispPosType DisplayPositionLeftHandModel2 
            {
                get => (WepDispPosType)CellsByName["DisplayPositionLeftHandModel2"].Value;
                set => CellsByName["DisplayPositionLeftHandModel2"].Value = (byte)value;
            }
            

            // Def="u8 dispPosType_rightBoth_2"
            /// <summary>
            /// Display Position - Right Both-hand - Model [2] (u8)
            /// </summary>
            /// <remarks>
            /// Model 2_Right-handed two-handed display position (used to specify hidden position from TAE)
            /// </remarks>
            public WepDispPosType DisplayPositionRightBothHandModel2 
            {
                get => (WepDispPosType)CellsByName["DisplayPositionRightBothHandModel2"].Value;
                set => CellsByName["DisplayPositionRightBothHandModel2"].Value = (byte)value;
            }
            

            // Def="u8 dispPosType_leftBoth_2"
            /// <summary>
            /// Display Position - Left Both-Hand - Model [2] (u8)
            /// </summary>
            /// <remarks>
            /// Model 2_ Left-handed two-handed display position (used to specify hidden position from TAE)
            /// </remarks>
            public WepDispPosType DisplayPositionLeftBothHandModel2 
            {
                get => (WepDispPosType)CellsByName["DisplayPositionLeftBothHandModel2"].Value;
                set => CellsByName["DisplayPositionLeftBothHandModel2"].Value = (byte)value;
            }
            

            // Def="u8 dispPosType_rightHang_2"
            /// <summary>
            /// Display Position - Right Sheath - Model [2] (u8)
            /// </summary>
            /// <remarks>
            /// Model 2_Right-handed sword display position (used to specify the non-display position from TAE)
            /// </remarks>
            public WepDispPosType DisplayPositionRightSheathModel2 
            {
                get => (WepDispPosType)CellsByName["DisplayPositionRightSheathModel2"].Value;
                set => CellsByName["DisplayPositionRightSheathModel2"].Value = (byte)value;
            }
            

            // Def="u8 dispPosType_leftHang_2"
            /// <summary>
            /// Display Position - Left Sheath - Model [2] (u8)
            /// </summary>
            /// <remarks>
            /// Model 2_ Left hand sword display position (used to specify the non-display position from TAE)
            /// </remarks>
            public WepDispPosType DisplayPositionLeftSheathModel2 
            {
                get => (WepDispPosType)CellsByName["DisplayPositionLeftSheathModel2"].Value;
                set => CellsByName["DisplayPositionLeftSheathModel2"].Value = (byte)value;
            }
            

            // Def="u8 dispPosType_right_3"
            /// <summary>
            /// Display Position - Right Hand - Model [3] (u8)
            /// </summary>
            /// <remarks>
            /// Model 3_ Right-hand display position (used to specify hidden position from TAE)
            /// </remarks>
            public WepDispPosType DisplayPositionRightHandModel3 
            {
                get => (WepDispPosType)CellsByName["DisplayPositionRightHandModel3"].Value;
                set => CellsByName["DisplayPositionRightHandModel3"].Value = (byte)value;
            }
            

            // Def="u8 dispPosType_left_3"
            /// <summary>
            /// Display Position - Left Hand - Model [3] (u8)
            /// </summary>
            /// <remarks>
            /// Model 3_Left hand display position (used to specify hidden position from TAE)
            /// </remarks>
            public WepDispPosType DisplayPositionLeftHandModel3 
            {
                get => (WepDispPosType)CellsByName["DisplayPositionLeftHandModel3"].Value;
                set => CellsByName["DisplayPositionLeftHandModel3"].Value = (byte)value;
            }
            

            // Def="u8 dispPosType_rightBoth_3"
            /// <summary>
            /// Display Position - Right Both-hand - Model [3] (u8)
            /// </summary>
            /// <remarks>
            /// Model 3_Right-handed two-handed display position (used to specify hidden position from TAE)
            /// </remarks>
            public WepDispPosType DisplayPositionRightBothHandModel3 
            {
                get => (WepDispPosType)CellsByName["DisplayPositionRightBothHandModel3"].Value;
                set => CellsByName["DisplayPositionRightBothHandModel3"].Value = (byte)value;
            }
            

            // Def="u8 dispPosType_leftBoth_3"
            /// <summary>
            /// Display Position - Left Both-Hand - Model [3] (u8)
            /// </summary>
            /// <remarks>
            /// Model 3_ Left-handed two-handed display position (used to specify hidden position from TAE)
            /// </remarks>
            public WepDispPosType DisplayPositionLeftBothHandModel3 
            {
                get => (WepDispPosType)CellsByName["DisplayPositionLeftBothHandModel3"].Value;
                set => CellsByName["DisplayPositionLeftBothHandModel3"].Value = (byte)value;
            }
            

            // Def="u8 dispPosType_rightHang_3"
            /// <summary>
            /// Display Position - Right Sheath - Model [3] (u8)
            /// </summary>
            /// <remarks>
            /// Model 3_Right-handed sword display position (used to specify the non-display position from TAE)
            /// </remarks>
            public WepDispPosType DisplayPositionRightSheathModel3 
            {
                get => (WepDispPosType)CellsByName["DisplayPositionRightSheathModel3"].Value;
                set => CellsByName["DisplayPositionRightSheathModel3"].Value = (byte)value;
            }
            

            // Def="u8 dispPosType_leftHang_3"
            /// <summary>
            /// Display Position - Left Sheath - Model [3] (u8)
            /// </summary>
            /// <remarks>
            /// Model 3_ Left hand sword display position (used to specify the non-display position from TAE)
            /// </remarks>
            public WepDispPosType DisplayPositionLeftSheathModel3 
            {
                get => (WepDispPosType)CellsByName["DisplayPositionLeftSheathModel3"].Value;
                set => CellsByName["DisplayPositionLeftSheathModel3"].Value = (byte)value;
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
                set => CellsByName["ReservedArea"].Value = (object)value;
            }
            
                }
            }
            
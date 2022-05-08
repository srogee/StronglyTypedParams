
            namespace StronglyTypedParams
            {
                // BONFIRE_WARP_SUB_CATEGORY_PARAM_ST
                public class BonfireWarpSubCategoryParam : ParamRow
                {
                    public BonfireWarpSubCategoryParam() : base()
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
            

            // Def="s32 textId"
            /// <summary>
            /// Text ID (s32)
            /// </summary>
            /// <remarks>
            /// Subcategory display name Text ID [MenuText]
            /// </remarks>
            public int TextID 
            {
                get => (int)CellsByName["TextID"].Value;
                set => CellsByName["TextID"].Value = (int)value;
            }
            

            // Def="u16 tabId"
            /// <summary>
            /// Tab ID (u16)
            /// </summary>
            /// <remarks>
            /// Kagaribi Warp Tab ID. ID of the tab to which this subcategory belongs
            /// </remarks>
            public ushort TabID 
            {
                get => (ushort)CellsByName["TabID"].Value;
                set => CellsByName["TabID"].Value = (ushort)value;
            }
            

            // Def="u16 sortId"
            /// <summary>
            /// Tab Sort ID (u16)
            /// </summary>
            /// <remarks>
            /// Bonfire Warp Tab Sort ID. Display order of subcategories in tabs
            /// </remarks>
            public ushort TabSortID 
            {
                get => (ushort)CellsByName["TabSortID"].Value;
                set => CellsByName["TabSortID"].Value = (ushort)value;
            }
            

            // Def="dummy8 pad[4]"
            /// <summary>
            /// pad (dummy8)
            /// </summary>
            /// <remarks>
            /// 
            /// </remarks>
            public object Pad 
            {
                get => (object)CellsByName["Pad"].Value;
                set => CellsByName["Pad"].Value = (object)value;
            }
            
                }
            }
            
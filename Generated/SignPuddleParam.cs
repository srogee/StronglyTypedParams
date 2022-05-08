
            namespace StronglyTypedParams
            {
                // SIGN_PUDDLE_PARAM_ST
                public class SignPuddleParam : ParamRow
                {
                    public SignPuddleParam() : base()
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
            

            // Def="s32 matchAreaId"
            /// <summary>
            /// Match Area ID (s32)
            /// </summary>
            /// <remarks>
            /// ID of the simple match area to which it belongs
            /// </remarks>
            public int MatchAreaID 
            {
                get => (int)CellsByName["MatchAreaID"].Value;
                set => CellsByName["MatchAreaID"].Value = (int)value;
            }
            

            // Def="dummy8 pad1[24]"
            /// <summary>
            /// pad1 (dummy8)
            /// </summary>
            /// <remarks>
            /// 
            /// </remarks>
            public object Pad1 
            {
                get => (object)CellsByName["Pad1"].Value;
                set => CellsByName["Pad1"].Value = (object)value;
            }
            
                }
            }
            
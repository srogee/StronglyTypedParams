
            namespace StronglyTypedParams
            {
                // GESTURE_PARAM_ST
                public class GestureParam : ParamRow
                {
                    public GestureParam() : base()
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
            

            // Def="s32 itemId"
            /// <summary>
            /// Item ID (s32)
            /// </summary>
            /// <remarks>
            /// Reference item ID. Used to bring in the gesture text ID, icon ID, and sort ID for each menu. Register the tool ID of the equipment parameter
            /// </remarks>
            public int ItemID 
            {
                get => (int)CellsByName["ItemID"].Value;
                set => CellsByName["ItemID"].Value = (int)value;
            }
            

            // Def="s32 msgAnimId"
            /// <summary>
            /// Message Anim ID (s32)
            /// </summary>
            /// <remarks>
            /// Anime ID for attaching messages. Specify the animation ID when attaching a message
            /// </remarks>
            public int MessageAnimID 
            {
                get => (int)CellsByName["MessageAnimID"].Value;
                set => CellsByName["MessageAnimID"].Value = (int)value;
            }
            

            // Def="u8 cannotUseRiding:1"
            /// <summary>
            /// Cannot Use while Riding (u8)
            /// </summary>
            /// <remarks>
            /// Is it prohibited to use while riding (default: ×)? If ○, it cannot be used while riding
            /// </remarks>
            public BoolCirclecrossType CannotUseWhileRiding 
            {
                get => (BoolCirclecrossType)CellsByName["CannotUseWhileRiding"].Value;
                set => CellsByName["CannotUseWhileRiding"].Value = (byte)value;
            }
            

            // Def="dummy8 pad2:7"
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
            

            namespace StronglyTypedParams
            {
                // WAYPOINT_PARAM_ST
                public class WaypointParam : ParamRow
                {
                    public WaypointParam() : base()
                    {
                    }
            

            // Def="s16 attribute1 = -1"
            /// <summary>
            /// Attribute [1] (s16)
            /// </summary>
            /// <remarks>
            /// 
            /// </remarks>
            public WaypointAttribute Attribute1 
            {
                get => (WaypointAttribute)CellsByName["Attribute1"].Value;
                set => CellsByName["Attribute1"].Value = (short)value;
            }
            

            // Def="s16 attribute2 = -1"
            /// <summary>
            /// Attribute [2] (s16)
            /// </summary>
            /// <remarks>
            /// 
            /// </remarks>
            public WaypointAttribute Attribute2 
            {
                get => (WaypointAttribute)CellsByName["Attribute2"].Value;
                set => CellsByName["Attribute2"].Value = (short)value;
            }
            

            // Def="s16 attribute3 = -1"
            /// <summary>
            /// Attribute [3] (s16)
            /// </summary>
            /// <remarks>
            /// 
            /// </remarks>
            public WaypointAttribute Attribute3 
            {
                get => (WaypointAttribute)CellsByName["Attribute3"].Value;
                set => CellsByName["Attribute3"].Value = (short)value;
            }
            

            // Def="s16 attribute4 = -1"
            /// <summary>
            /// Attribute [4] (s16)
            /// </summary>
            /// <remarks>
            /// 
            /// </remarks>
            public WaypointAttribute Attribute4 
            {
                get => (WaypointAttribute)CellsByName["Attribute4"].Value;
                set => CellsByName["Attribute4"].Value = (short)value;
            }
            

            // Def="dummy8 padding4[8]"
            /// <summary>
            /// Padding 4 (dummy8)
            /// </summary>
            /// <remarks>
            /// 
            /// </remarks>
            public object Padding4 
            {
                get => (object)CellsByName["Padding4"].Value;
                set => CellsByName["Padding4"].Value = (object)value;
            }
            
                }
            }
            
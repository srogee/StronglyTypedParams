
            namespace StronglyTypedParams
            {
                // PERFORMANCE_CHECK_PARAM
                public class PerformanceCheckParam : ParamRow
                {
                    public PerformanceCheckParam() : base()
                    {
                    }
            

            // Def="u8 workTag"
            /// <summary>
            /// Report destination_Job type tag (u8)
            /// </summary>
            /// <remarks>
            /// Report destination_Job type tag
            /// </remarks>
            public byte ReportDestination_JobTypeTag 
            {
                get => (byte)CellsByName["ReportDestination_JobTypeTag"].Value;
                set => CellsByName["ReportDestination_JobTypeTag"].Value = (byte)value;
            }
            

            // Def="u8 categoryTag"
            /// <summary>
            /// Report destination_category tag (u8)
            /// </summary>
            /// <remarks>
            /// Report destination_category tag
            /// </remarks>
            public byte ReportDestination_categoryTag 
            {
                get => (byte)CellsByName["ReportDestination_categoryTag"].Value;
                set => CellsByName["ReportDestination_categoryTag"].Value = (byte)value;
            }
            

            // Def="u8 compareType"
            /// <summary>
            /// Comparison symbol (u8)
            /// </summary>
            /// <remarks>
            /// Comparison symbol
            /// </remarks>
            public byte ComparisonSymbol 
            {
                get => (byte)CellsByName["ComparisonSymbol"].Value;
                set => CellsByName["ComparisonSymbol"].Value = (byte)value;
            }
            

            // Def="dummy8 dummy1[1]"
            /// <summary>
            /// Reservation 1 (dummy8)
            /// </summary>
            /// <remarks>
            /// Reservation 1
            /// </remarks>
            public object Reservation1 
            {
                get => (object)CellsByName["Reservation1"].Value;
                set => CellsByName["Reservation1"].Value = (object)value;
            }
            

            // Def="f32 compareValue"
            /// <summary>
            /// Comparison value (f32)
            /// </summary>
            /// <remarks>
            /// Comparison value
            /// </remarks>
            public float ComparisonValue 
            {
                get => (float)CellsByName["ComparisonValue"].Value;
                set => CellsByName["ComparisonValue"].Value = (float)value;
            }
            

            // Def="dummy8 dummy2[8]"
            /// <summary>
            /// Reservation 2 (dummy8)
            /// </summary>
            /// <remarks>
            /// Reservation 2
            /// </remarks>
            public object Reservation2 
            {
                get => (object)CellsByName["Reservation2"].Value;
                set => CellsByName["Reservation2"].Value = (object)value;
            }
            

            // Def="fixstrW userTag[16]"
            /// <summary>
            /// Report destination_user tag (fixstrW)
            /// </summary>
            /// <remarks>
            /// Report to_Performance person tag
            /// </remarks>
            public object ReportDestination_userTag 
            {
                get => (object)CellsByName["ReportDestination_userTag"].Value;
                set => CellsByName["ReportDestination_userTag"].Value = (object)value;
            }
            
                }
            }
            
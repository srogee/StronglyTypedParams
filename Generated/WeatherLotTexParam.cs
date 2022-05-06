
            namespace StronglyTypedParams
            {
                public class WeatherLotTexParam : ParamRow
                {
                    public WeatherLotTexParam() : base()
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
            

            // Def="u8 srcR"
            /// <summary>
            /// Pre-conversion - Map Color: R (u8)
            /// </summary>
            /// <remarks>
            /// Color information (R) of the map image before conversion. Pixels with matching RGB values are associated with this parameter
            /// </remarks>
            public byte PreConversionMapColorR 
            {
                get => (byte)CellsByName["PreConversionMapColorR"].Value;
                set => CellsByName["PreConversionMapColorR"].Value = value;
            }
            

            // Def="u8 srcG"
            /// <summary>
            /// Pre-conversion - Map Color: G (u8)
            /// </summary>
            /// <remarks>
            /// Color information (G) of the map image before conversion. Pixels with matching RGB values are associated with this parameter
            /// </remarks>
            public byte PreConversionMapColorG 
            {
                get => (byte)CellsByName["PreConversionMapColorG"].Value;
                set => CellsByName["PreConversionMapColorG"].Value = value;
            }
            

            // Def="u8 srcB"
            /// <summary>
            /// Pre-conversion - Map Color: B (u8)
            /// </summary>
            /// <remarks>
            /// Color information (B) of the map image before conversion. Pixels with matching RGB values are associated with this parameter
            /// </remarks>
            public byte PreConversionMapColorB 
            {
                get => (byte)CellsByName["PreConversionMapColorB"].Value;
                set => CellsByName["PreConversionMapColorB"].Value = value;
            }
            

            // Def="dummy8 pad1[1]"
            /// <summary>
            /// pad (dummy8)
            /// </summary>
            /// <remarks>
            /// pad. For the time being, leave it open for "image color information (A)"
            /// </remarks>
            public object Pad 
            {
                get => (object)CellsByName["Pad"].Value;
                set => CellsByName["Pad"].Value = value;
            }
            

            // Def="s32 weatherLogId = -1"
            /// <summary>
            /// Weather Lottery ID (s32)
            /// </summary>
            /// <remarks>
            /// Weather lottery ID (-1: No setting (default value))
            /// </remarks>
            public int WeatherLotteryID 
            {
                get => (int)CellsByName["WeatherLotteryID"].Value;
                set => CellsByName["WeatherLotteryID"].Value = value;
            }
            

            // Def="dummy8 pad2[4]"
            /// <summary>
            /// Pad 2 (dummy8)
            /// </summary>
            /// <remarks>
            /// 
            /// </remarks>
            public object Pad2 
            {
                get => (object)CellsByName["Pad2"].Value;
                set => CellsByName["Pad2"].Value = value;
            }
            
                }
            }
            
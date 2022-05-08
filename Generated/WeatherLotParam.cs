
            namespace StronglyTypedParams
            {
                // WEATHER_LOT_PARAM_ST
                public class WeatherLotParam : ParamRow
                {
                    public WeatherLotParam() : base()
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
            

            // Def="s16 weatherType0 = -1"
            /// <summary>
            /// Weather Type [0] (s16)
            /// </summary>
            /// <remarks>
            /// Weather type 0
            /// </remarks>
            public WeatherType WeatherType0 
            {
                get => (WeatherType)CellsByName["WeatherType0"].Value;
                set => CellsByName["WeatherType0"].Value = (short)value;
            }
            

            // Def="s16 weatherType1 = -1"
            /// <summary>
            /// Weather Type [1] (s16)
            /// </summary>
            /// <remarks>
            /// Weather type 1
            /// </remarks>
            public WeatherType WeatherType1 
            {
                get => (WeatherType)CellsByName["WeatherType1"].Value;
                set => CellsByName["WeatherType1"].Value = (short)value;
            }
            

            // Def="s16 weatherType2 = -1"
            /// <summary>
            /// Weather Type [2] (s16)
            /// </summary>
            /// <remarks>
            /// Weather type 2
            /// </remarks>
            public WeatherType WeatherType2 
            {
                get => (WeatherType)CellsByName["WeatherType2"].Value;
                set => CellsByName["WeatherType2"].Value = (short)value;
            }
            

            // Def="s16 weatherType3 = -1"
            /// <summary>
            /// Weather Type [3] (s16)
            /// </summary>
            /// <remarks>
            /// Weather type 3
            /// </remarks>
            public WeatherType WeatherType3 
            {
                get => (WeatherType)CellsByName["WeatherType3"].Value;
                set => CellsByName["WeatherType3"].Value = (short)value;
            }
            

            // Def="s16 weatherType4 = -1"
            /// <summary>
            /// Weather Type [4] (s16)
            /// </summary>
            /// <remarks>
            /// Weather type 4
            /// </remarks>
            public WeatherType WeatherType4 
            {
                get => (WeatherType)CellsByName["WeatherType4"].Value;
                set => CellsByName["WeatherType4"].Value = (short)value;
            }
            

            // Def="s16 weatherType5 = -1"
            /// <summary>
            /// Weather Type [5] (s16)
            /// </summary>
            /// <remarks>
            /// Weather type 5
            /// </remarks>
            public WeatherType WeatherType5 
            {
                get => (WeatherType)CellsByName["WeatherType5"].Value;
                set => CellsByName["WeatherType5"].Value = (short)value;
            }
            

            // Def="s16 weatherType6 = -1"
            /// <summary>
            /// Weather Type [6] (s16)
            /// </summary>
            /// <remarks>
            /// Weather type 6
            /// </remarks>
            public WeatherType WeatherType6 
            {
                get => (WeatherType)CellsByName["WeatherType6"].Value;
                set => CellsByName["WeatherType6"].Value = (short)value;
            }
            

            // Def="s16 weatherType7 = -1"
            /// <summary>
            /// Weather Type [7] (s16)
            /// </summary>
            /// <remarks>
            /// Weather type 7
            /// </remarks>
            public WeatherType WeatherType7 
            {
                get => (WeatherType)CellsByName["WeatherType7"].Value;
                set => CellsByName["WeatherType7"].Value = (short)value;
            }
            

            // Def="s16 weatherType8 = -1"
            /// <summary>
            /// Weather Type [8] (s16)
            /// </summary>
            /// <remarks>
            /// Weather type 8
            /// </remarks>
            public WeatherType WeatherType8 
            {
                get => (WeatherType)CellsByName["WeatherType8"].Value;
                set => CellsByName["WeatherType8"].Value = (short)value;
            }
            

            // Def="s16 weatherType9 = -1"
            /// <summary>
            /// Weather Type [9] (s16)
            /// </summary>
            /// <remarks>
            /// Weather type 9
            /// </remarks>
            public WeatherType WeatherType9 
            {
                get => (WeatherType)CellsByName["WeatherType9"].Value;
                set => CellsByName["WeatherType9"].Value = (short)value;
            }
            

            // Def="s16 weatherType10 = -1"
            /// <summary>
            /// Weather Type [10] (s16)
            /// </summary>
            /// <remarks>
            /// Weather type 10
            /// </remarks>
            public WeatherType WeatherType10 
            {
                get => (WeatherType)CellsByName["WeatherType10"].Value;
                set => CellsByName["WeatherType10"].Value = (short)value;
            }
            

            // Def="s16 weatherType11 = -1"
            /// <summary>
            /// Weather Type [11] (s16)
            /// </summary>
            /// <remarks>
            /// Weather type 11
            /// </remarks>
            public WeatherType WeatherType11 
            {
                get => (WeatherType)CellsByName["WeatherType11"].Value;
                set => CellsByName["WeatherType11"].Value = (short)value;
            }
            

            // Def="s16 weatherType12 = -1"
            /// <summary>
            /// Weather Type [12] (s16)
            /// </summary>
            /// <remarks>
            /// Weather type 12
            /// </remarks>
            public WeatherType WeatherType12 
            {
                get => (WeatherType)CellsByName["WeatherType12"].Value;
                set => CellsByName["WeatherType12"].Value = (short)value;
            }
            

            // Def="s16 weatherType13 = -1"
            /// <summary>
            /// Weather Type [13] (s16)
            /// </summary>
            /// <remarks>
            /// Weather type 13
            /// </remarks>
            public WeatherType WeatherType13 
            {
                get => (WeatherType)CellsByName["WeatherType13"].Value;
                set => CellsByName["WeatherType13"].Value = (short)value;
            }
            

            // Def="s16 weatherType14 = -1"
            /// <summary>
            /// Weather Type [14] (s16)
            /// </summary>
            /// <remarks>
            /// Weather type 14
            /// </remarks>
            public WeatherType WeatherType14 
            {
                get => (WeatherType)CellsByName["WeatherType14"].Value;
                set => CellsByName["WeatherType14"].Value = (short)value;
            }
            

            // Def="s16 weatherType15 = -1"
            /// <summary>
            /// Weather Type [15] (s16)
            /// </summary>
            /// <remarks>
            /// Weather type 15
            /// </remarks>
            public WeatherType WeatherType15 
            {
                get => (WeatherType)CellsByName["WeatherType15"].Value;
                set => CellsByName["WeatherType15"].Value = (short)value;
            }
            

            // Def="u16 lotteryWeight0"
            /// <summary>
            /// Lottery Weight [0] (u16)
            /// </summary>
            /// <remarks>
            /// Lottery weight 0
            /// </remarks>
            public ushort LotteryWeight0 
            {
                get => (ushort)CellsByName["LotteryWeight0"].Value;
                set => CellsByName["LotteryWeight0"].Value = (ushort)value;
            }
            

            // Def="u16 lotteryWeight1"
            /// <summary>
            /// Lottery Weight [1] (u16)
            /// </summary>
            /// <remarks>
            /// Lottery weight 1
            /// </remarks>
            public ushort LotteryWeight1 
            {
                get => (ushort)CellsByName["LotteryWeight1"].Value;
                set => CellsByName["LotteryWeight1"].Value = (ushort)value;
            }
            

            // Def="u16 lotteryWeight2"
            /// <summary>
            /// Lottery Weight [2] (u16)
            /// </summary>
            /// <remarks>
            /// Lottery weight 2
            /// </remarks>
            public ushort LotteryWeight2 
            {
                get => (ushort)CellsByName["LotteryWeight2"].Value;
                set => CellsByName["LotteryWeight2"].Value = (ushort)value;
            }
            

            // Def="u16 lotteryWeight3"
            /// <summary>
            /// Lottery Weight [3] (u16)
            /// </summary>
            /// <remarks>
            /// Lottery weight 3
            /// </remarks>
            public ushort LotteryWeight3 
            {
                get => (ushort)CellsByName["LotteryWeight3"].Value;
                set => CellsByName["LotteryWeight3"].Value = (ushort)value;
            }
            

            // Def="u16 lotteryWeight4"
            /// <summary>
            /// Lottery Weight [4] (u16)
            /// </summary>
            /// <remarks>
            /// Lottery weight 4
            /// </remarks>
            public ushort LotteryWeight4 
            {
                get => (ushort)CellsByName["LotteryWeight4"].Value;
                set => CellsByName["LotteryWeight4"].Value = (ushort)value;
            }
            

            // Def="u16 lotteryWeight5"
            /// <summary>
            /// Lottery Weight [5] (u16)
            /// </summary>
            /// <remarks>
            /// Lottery weight 5
            /// </remarks>
            public ushort LotteryWeight5 
            {
                get => (ushort)CellsByName["LotteryWeight5"].Value;
                set => CellsByName["LotteryWeight5"].Value = (ushort)value;
            }
            

            // Def="u16 lotteryWeight6"
            /// <summary>
            /// Lottery Weight [6] (u16)
            /// </summary>
            /// <remarks>
            /// Lottery weight 6
            /// </remarks>
            public ushort LotteryWeight6 
            {
                get => (ushort)CellsByName["LotteryWeight6"].Value;
                set => CellsByName["LotteryWeight6"].Value = (ushort)value;
            }
            

            // Def="u16 lotteryWeight7"
            /// <summary>
            /// Lottery Weight [7] (u16)
            /// </summary>
            /// <remarks>
            /// Lottery weight 7
            /// </remarks>
            public ushort LotteryWeight7 
            {
                get => (ushort)CellsByName["LotteryWeight7"].Value;
                set => CellsByName["LotteryWeight7"].Value = (ushort)value;
            }
            

            // Def="u16 lotteryWeight8"
            /// <summary>
            /// Lottery Weight [8] (u16)
            /// </summary>
            /// <remarks>
            /// Lottery weight 8
            /// </remarks>
            public ushort LotteryWeight8 
            {
                get => (ushort)CellsByName["LotteryWeight8"].Value;
                set => CellsByName["LotteryWeight8"].Value = (ushort)value;
            }
            

            // Def="u16 lotteryWeight9"
            /// <summary>
            /// Lottery Weight [9] (u16)
            /// </summary>
            /// <remarks>
            /// Lottery weight 9
            /// </remarks>
            public ushort LotteryWeight9 
            {
                get => (ushort)CellsByName["LotteryWeight9"].Value;
                set => CellsByName["LotteryWeight9"].Value = (ushort)value;
            }
            

            // Def="u16 lotteryWeight10"
            /// <summary>
            /// Lottery Weight [10] (u16)
            /// </summary>
            /// <remarks>
            /// Lottery weight 10
            /// </remarks>
            public ushort LotteryWeight10 
            {
                get => (ushort)CellsByName["LotteryWeight10"].Value;
                set => CellsByName["LotteryWeight10"].Value = (ushort)value;
            }
            

            // Def="u16 lotteryWeight11"
            /// <summary>
            /// Lottery Weight [11] (u16)
            /// </summary>
            /// <remarks>
            /// Lottery weight 11
            /// </remarks>
            public ushort LotteryWeight11 
            {
                get => (ushort)CellsByName["LotteryWeight11"].Value;
                set => CellsByName["LotteryWeight11"].Value = (ushort)value;
            }
            

            // Def="u16 lotteryWeight12"
            /// <summary>
            /// Lottery Weight [12] (u16)
            /// </summary>
            /// <remarks>
            /// Lottery weight 12
            /// </remarks>
            public ushort LotteryWeight12 
            {
                get => (ushort)CellsByName["LotteryWeight12"].Value;
                set => CellsByName["LotteryWeight12"].Value = (ushort)value;
            }
            

            // Def="u16 lotteryWeight13"
            /// <summary>
            /// Lottery Weight [13] (u16)
            /// </summary>
            /// <remarks>
            /// Lottery weight 13
            /// </remarks>
            public ushort LotteryWeight13 
            {
                get => (ushort)CellsByName["LotteryWeight13"].Value;
                set => CellsByName["LotteryWeight13"].Value = (ushort)value;
            }
            

            // Def="u16 lotteryWeight14"
            /// <summary>
            /// Lottery Weight [14] (u16)
            /// </summary>
            /// <remarks>
            /// Lottery weight 14
            /// </remarks>
            public ushort LotteryWeight14 
            {
                get => (ushort)CellsByName["LotteryWeight14"].Value;
                set => CellsByName["LotteryWeight14"].Value = (ushort)value;
            }
            

            // Def="u16 lotteryWeight15"
            /// <summary>
            /// Lottery Weight [15] (u16)
            /// </summary>
            /// <remarks>
            /// Lottery weight 15
            /// </remarks>
            public ushort LotteryWeight15 
            {
                get => (ushort)CellsByName["LotteryWeight15"].Value;
                set => CellsByName["LotteryWeight15"].Value = (ushort)value;
            }
            

            // Def="u8 timezoneLimit"
            /// <summary>
            /// Timezone Limit (u8)
            /// </summary>
            /// <remarks>
            /// Time zone condition list
            /// </remarks>
            public WeatherLotTimezoneType TimezoneLimit 
            {
                get => (WeatherLotTimezoneType)CellsByName["TimezoneLimit"].Value;
                set => CellsByName["TimezoneLimit"].Value = (byte)value;
            }
            

            // Def="u8 timezoneStartHour"
            /// <summary>
            /// Timezone Start Hour (u8)
            /// </summary>
            /// <remarks>
            /// Direct time specification_start_hour
            /// </remarks>
            public byte TimezoneStartHour 
            {
                get => (byte)CellsByName["TimezoneStartHour"].Value;
                set => CellsByName["TimezoneStartHour"].Value = (byte)value;
            }
            

            // Def="u8 timezoneStartMinute"
            /// <summary>
            /// Timezone Start Minute (u8)
            /// </summary>
            /// <remarks>
            /// Direct time specification_start_minute
            /// </remarks>
            public byte TimezoneStartMinute 
            {
                get => (byte)CellsByName["TimezoneStartMinute"].Value;
                set => CellsByName["TimezoneStartMinute"].Value = (byte)value;
            }
            

            // Def="u8 timezoneEndHour"
            /// <summary>
            /// Timezone End Hour (u8)
            /// </summary>
            /// <remarks>
            /// Direct time specification_start_hour
            /// </remarks>
            public byte TimezoneEndHour 
            {
                get => (byte)CellsByName["TimezoneEndHour"].Value;
                set => CellsByName["TimezoneEndHour"].Value = (byte)value;
            }
            

            // Def="u8 timezoneEndMinute"
            /// <summary>
            /// Timezone End Minute (u8)
            /// </summary>
            /// <remarks>
            /// Direct time specification_start_minute
            /// </remarks>
            public byte TimezoneEndMinute 
            {
                get => (byte)CellsByName["TimezoneEndMinute"].Value;
                set => CellsByName["TimezoneEndMinute"].Value = (byte)value;
            }
            

            // Def="dummy8 reserve[9]"
            /// <summary>
            /// Reserve (dummy8)
            /// </summary>
            /// <remarks>
            /// Reserved area
            /// </remarks>
            public object Reserve 
            {
                get => (object)CellsByName["Reserve"].Value;
                set => CellsByName["Reserve"].Value = (object)value;
            }
            
                }
            }
            
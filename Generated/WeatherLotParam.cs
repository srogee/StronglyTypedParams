
            namespace StronglyTypedParams
            {
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
            

            // Def="s16 weatherType0 = -1"
            /// <summary>
            /// Weather Type [0] (s16)
            /// </summary>
            /// <remarks>
            /// Weather type 0
            /// </remarks>
            public short WeatherType0 
            {
                get => (short)CellsByName["WeatherType0"].Value;
                set => CellsByName["WeatherType0"].Value = value;
            }
            

            // Def="s16 weatherType1 = -1"
            /// <summary>
            /// Weather Type [1] (s16)
            /// </summary>
            /// <remarks>
            /// Weather type 1
            /// </remarks>
            public short WeatherType1 
            {
                get => (short)CellsByName["WeatherType1"].Value;
                set => CellsByName["WeatherType1"].Value = value;
            }
            

            // Def="s16 weatherType2 = -1"
            /// <summary>
            /// Weather Type [2] (s16)
            /// </summary>
            /// <remarks>
            /// Weather type 2
            /// </remarks>
            public short WeatherType2 
            {
                get => (short)CellsByName["WeatherType2"].Value;
                set => CellsByName["WeatherType2"].Value = value;
            }
            

            // Def="s16 weatherType3 = -1"
            /// <summary>
            /// Weather Type [3] (s16)
            /// </summary>
            /// <remarks>
            /// Weather type 3
            /// </remarks>
            public short WeatherType3 
            {
                get => (short)CellsByName["WeatherType3"].Value;
                set => CellsByName["WeatherType3"].Value = value;
            }
            

            // Def="s16 weatherType4 = -1"
            /// <summary>
            /// Weather Type [4] (s16)
            /// </summary>
            /// <remarks>
            /// Weather type 4
            /// </remarks>
            public short WeatherType4 
            {
                get => (short)CellsByName["WeatherType4"].Value;
                set => CellsByName["WeatherType4"].Value = value;
            }
            

            // Def="s16 weatherType5 = -1"
            /// <summary>
            /// Weather Type [5] (s16)
            /// </summary>
            /// <remarks>
            /// Weather type 5
            /// </remarks>
            public short WeatherType5 
            {
                get => (short)CellsByName["WeatherType5"].Value;
                set => CellsByName["WeatherType5"].Value = value;
            }
            

            // Def="s16 weatherType6 = -1"
            /// <summary>
            /// Weather Type [6] (s16)
            /// </summary>
            /// <remarks>
            /// Weather type 6
            /// </remarks>
            public short WeatherType6 
            {
                get => (short)CellsByName["WeatherType6"].Value;
                set => CellsByName["WeatherType6"].Value = value;
            }
            

            // Def="s16 weatherType7 = -1"
            /// <summary>
            /// Weather Type [7] (s16)
            /// </summary>
            /// <remarks>
            /// Weather type 7
            /// </remarks>
            public short WeatherType7 
            {
                get => (short)CellsByName["WeatherType7"].Value;
                set => CellsByName["WeatherType7"].Value = value;
            }
            

            // Def="s16 weatherType8 = -1"
            /// <summary>
            /// Weather Type [8] (s16)
            /// </summary>
            /// <remarks>
            /// Weather type 8
            /// </remarks>
            public short WeatherType8 
            {
                get => (short)CellsByName["WeatherType8"].Value;
                set => CellsByName["WeatherType8"].Value = value;
            }
            

            // Def="s16 weatherType9 = -1"
            /// <summary>
            /// Weather Type [9] (s16)
            /// </summary>
            /// <remarks>
            /// Weather type 9
            /// </remarks>
            public short WeatherType9 
            {
                get => (short)CellsByName["WeatherType9"].Value;
                set => CellsByName["WeatherType9"].Value = value;
            }
            

            // Def="s16 weatherType10 = -1"
            /// <summary>
            /// Weather Type [10] (s16)
            /// </summary>
            /// <remarks>
            /// Weather type 10
            /// </remarks>
            public short WeatherType10 
            {
                get => (short)CellsByName["WeatherType10"].Value;
                set => CellsByName["WeatherType10"].Value = value;
            }
            

            // Def="s16 weatherType11 = -1"
            /// <summary>
            /// Weather Type [11] (s16)
            /// </summary>
            /// <remarks>
            /// Weather type 11
            /// </remarks>
            public short WeatherType11 
            {
                get => (short)CellsByName["WeatherType11"].Value;
                set => CellsByName["WeatherType11"].Value = value;
            }
            

            // Def="s16 weatherType12 = -1"
            /// <summary>
            /// Weather Type [12] (s16)
            /// </summary>
            /// <remarks>
            /// Weather type 12
            /// </remarks>
            public short WeatherType12 
            {
                get => (short)CellsByName["WeatherType12"].Value;
                set => CellsByName["WeatherType12"].Value = value;
            }
            

            // Def="s16 weatherType13 = -1"
            /// <summary>
            /// Weather Type [13] (s16)
            /// </summary>
            /// <remarks>
            /// Weather type 13
            /// </remarks>
            public short WeatherType13 
            {
                get => (short)CellsByName["WeatherType13"].Value;
                set => CellsByName["WeatherType13"].Value = value;
            }
            

            // Def="s16 weatherType14 = -1"
            /// <summary>
            /// Weather Type [14] (s16)
            /// </summary>
            /// <remarks>
            /// Weather type 14
            /// </remarks>
            public short WeatherType14 
            {
                get => (short)CellsByName["WeatherType14"].Value;
                set => CellsByName["WeatherType14"].Value = value;
            }
            

            // Def="s16 weatherType15 = -1"
            /// <summary>
            /// Weather Type [15] (s16)
            /// </summary>
            /// <remarks>
            /// Weather type 15
            /// </remarks>
            public short WeatherType15 
            {
                get => (short)CellsByName["WeatherType15"].Value;
                set => CellsByName["WeatherType15"].Value = value;
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
                set => CellsByName["LotteryWeight0"].Value = value;
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
                set => CellsByName["LotteryWeight1"].Value = value;
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
                set => CellsByName["LotteryWeight2"].Value = value;
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
                set => CellsByName["LotteryWeight3"].Value = value;
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
                set => CellsByName["LotteryWeight4"].Value = value;
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
                set => CellsByName["LotteryWeight5"].Value = value;
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
                set => CellsByName["LotteryWeight6"].Value = value;
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
                set => CellsByName["LotteryWeight7"].Value = value;
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
                set => CellsByName["LotteryWeight8"].Value = value;
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
                set => CellsByName["LotteryWeight9"].Value = value;
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
                set => CellsByName["LotteryWeight10"].Value = value;
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
                set => CellsByName["LotteryWeight11"].Value = value;
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
                set => CellsByName["LotteryWeight12"].Value = value;
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
                set => CellsByName["LotteryWeight13"].Value = value;
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
                set => CellsByName["LotteryWeight14"].Value = value;
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
                set => CellsByName["LotteryWeight15"].Value = value;
            }
            

            // Def="u8 timezoneLimit"
            /// <summary>
            /// Timezone Limit (u8)
            /// </summary>
            /// <remarks>
            /// Time zone condition list
            /// </remarks>
            public byte TimezoneLimit 
            {
                get => (byte)CellsByName["TimezoneLimit"].Value;
                set => CellsByName["TimezoneLimit"].Value = value;
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
                set => CellsByName["TimezoneStartHour"].Value = value;
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
                set => CellsByName["TimezoneStartMinute"].Value = value;
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
                set => CellsByName["TimezoneEndHour"].Value = value;
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
                set => CellsByName["TimezoneEndMinute"].Value = value;
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
                set => CellsByName["Reserve"].Value = value;
            }
            
                }
            }
            

            namespace StronglyTypedParams
            {
                // CUTSCENE_GPARAM_WEATHER_PARAM_ST
                public class CutsceneGparamWeatherParam : ParamRow
                {
                    public CutsceneGparamWeatherParam() : base()
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
            

            // Def="u8 disableParam_Debug:1"
            /// <summary>
            /// Disable Param - Debug (u8)
            /// </summary>
            /// <remarks>
            /// Parameters marked with a circle are excluded from all packages (because they are for debugging).
            /// </remarks>
            public BoolCirclecrossType DisableParamDebug 
            {
                get => (BoolCirclecrossType)CellsByName["DisableParamDebug"].Value;
                set => CellsByName["DisableParamDebug"].Value = (byte)value;
            }
            

            // Def="dummy8 disableParamReserve1:6"
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
            

            // Def="s16 DstWeather_Sunny"
            /// <summary>
            /// Destination Weather: Sunny (s16)
            /// </summary>
            /// <remarks>
            /// Sunny
            /// </remarks>
            public WeatherType DestinationWeatherSunny 
            {
                get => (WeatherType)CellsByName["DestinationWeatherSunny"].Value;
                set => CellsByName["DestinationWeatherSunny"].Value = (short)value;
            }
            

            // Def="s16 DstWeather_ClearSky"
            /// <summary>
            /// Destination Weather: Clear Sky (s16)
            /// </summary>
            /// <remarks>
            /// Sunny
            /// </remarks>
            public WeatherType DestinationWeatherClearSky 
            {
                get => (WeatherType)CellsByName["DestinationWeatherClearSky"].Value;
                set => CellsByName["DestinationWeatherClearSky"].Value = (short)value;
            }
            

            // Def="s16 DstWeather_WeakCloudy"
            /// <summary>
            /// Destination Weather: Light Cloud (s16)
            /// </summary>
            /// <remarks>
            /// Light cloudy
            /// </remarks>
            public WeatherType DestinationWeatherLightCloud 
            {
                get => (WeatherType)CellsByName["DestinationWeatherLightCloud"].Value;
                set => CellsByName["DestinationWeatherLightCloud"].Value = (short)value;
            }
            

            // Def="s16 DstWeather_Cloud"
            /// <summary>
            /// Destination Weather: Cloud (s16)
            /// </summary>
            /// <remarks>
            /// cloudy
            /// </remarks>
            public WeatherType DestinationWeatherCloud 
            {
                get => (WeatherType)CellsByName["DestinationWeatherCloud"].Value;
                set => CellsByName["DestinationWeatherCloud"].Value = (short)value;
            }
            

            // Def="s16 DstWeather_Rain"
            /// <summary>
            /// Destination Weather: Rain (s16)
            /// </summary>
            /// <remarks>
            /// rain
            /// </remarks>
            public WeatherType DestinationWeatherRain 
            {
                get => (WeatherType)CellsByName["DestinationWeatherRain"].Value;
                set => CellsByName["DestinationWeatherRain"].Value = (short)value;
            }
            

            // Def="s16 DstWeather_HeavyRain"
            /// <summary>
            /// Destination Weather: Heavy Rain (s16)
            /// </summary>
            /// <remarks>
            /// Heavy rain
            /// </remarks>
            public WeatherType DestinationWeatherHeavyRain 
            {
                get => (WeatherType)CellsByName["DestinationWeatherHeavyRain"].Value;
                set => CellsByName["DestinationWeatherHeavyRain"].Value = (short)value;
            }
            

            // Def="s16 DstWeather_Storm"
            /// <summary>
            /// Destination Weather: Storm (s16)
            /// </summary>
            /// <remarks>
            /// storm
            /// </remarks>
            public WeatherType DestinationWeatherStorm 
            {
                get => (WeatherType)CellsByName["DestinationWeatherStorm"].Value;
                set => CellsByName["DestinationWeatherStorm"].Value = (short)value;
            }
            

            // Def="s16 DstWeather_StormForBattle"
            /// <summary>
            /// Destination Weather: Storm for Battle (s16)
            /// </summary>
            /// <remarks>
            /// Storm (for combat with the descendants of the guardian)
            /// </remarks>
            public WeatherType DestinationWeatherStormForBattle 
            {
                get => (WeatherType)CellsByName["DestinationWeatherStormForBattle"].Value;
                set => CellsByName["DestinationWeatherStormForBattle"].Value = (short)value;
            }
            

            // Def="s16 DstWeather_Snow"
            /// <summary>
            /// Destination Weather: Snow (s16)
            /// </summary>
            /// <remarks>
            /// snow
            /// </remarks>
            public WeatherType DestinationWeatherSnow 
            {
                get => (WeatherType)CellsByName["DestinationWeatherSnow"].Value;
                set => CellsByName["DestinationWeatherSnow"].Value = (short)value;
            }
            

            // Def="s16 DstWeather_HeavySnow"
            /// <summary>
            /// Destination Weather: Heavy Snow (s16)
            /// </summary>
            /// <remarks>
            /// heavy snow
            /// </remarks>
            public WeatherType DestinationWeatherHeavySnow 
            {
                get => (WeatherType)CellsByName["DestinationWeatherHeavySnow"].Value;
                set => CellsByName["DestinationWeatherHeavySnow"].Value = (short)value;
            }
            

            // Def="s16 DstWeather_Fog"
            /// <summary>
            /// Destination Weather: Fog (s16)
            /// </summary>
            /// <remarks>
            /// fog
            /// </remarks>
            public WeatherType DestinationWeatherFog 
            {
                get => (WeatherType)CellsByName["DestinationWeatherFog"].Value;
                set => CellsByName["DestinationWeatherFog"].Value = (short)value;
            }
            

            // Def="s16 DstWeather_HeavyFog"
            /// <summary>
            /// Destination Weather: Heavy Fog (s16)
            /// </summary>
            /// <remarks>
            /// Thick fog
            /// </remarks>
            public WeatherType DestinationWeatherHeavyFog 
            {
                get => (WeatherType)CellsByName["DestinationWeatherHeavyFog"].Value;
                set => CellsByName["DestinationWeatherHeavyFog"].Value = (short)value;
            }
            

            // Def="s16 DstWeather_SandStorm"
            /// <summary>
            /// Destination Weather: Sandstorm (s16)
            /// </summary>
            /// <remarks>
            /// Sandstorm
            /// </remarks>
            public WeatherType DestinationWeatherSandstorm 
            {
                get => (WeatherType)CellsByName["DestinationWeatherSandstorm"].Value;
                set => CellsByName["DestinationWeatherSandstorm"].Value = (short)value;
            }
            

            // Def="s16 DstWeather_HeavyFogRain"
            /// <summary>
            /// Destination Weather: Heavy Fog and Rain (s16)
            /// </summary>
            /// <remarks>
            /// Thick fog (rain)
            /// </remarks>
            public WeatherType DestinationWeatherHeavyFogAndRain 
            {
                get => (WeatherType)CellsByName["DestinationWeatherHeavyFogAndRain"].Value;
                set => CellsByName["DestinationWeatherHeavyFogAndRain"].Value = (short)value;
            }
            

            // Def="s16 PostPlayIngameWeather = -1"
            /// <summary>
            /// Post Cutscene In-game Weather (s16)
            /// </summary>
            /// <remarks>
            /// In-game weather specifications at the end of playback (nothing is done if blank or "invalid")
            /// </remarks>
            public WeatherType PostCutsceneInGameWeather 
            {
                get => (WeatherType)CellsByName["PostCutsceneInGameWeather"].Value;
                set => CellsByName["PostCutsceneInGameWeather"].Value = (short)value;
            }
            

            // Def="u8 IndoorOutdoorType"
            /// <summary>
            /// Indoor/Outdoor Type (u8)
            /// </summary>
            /// <remarks>
            /// When indoors, the SFX specified by "Weather SfxId (Outdoor)" and "Wind SfxId (Outdoor)" in "Weather Parameter.xlsm" will be invalid in the cutscene.
            /// </remarks>
            public CutsceneIndoorOutdoorType IndoorOutdoorType 
            {
                get => (CutsceneIndoorOutdoorType)CellsByName["IndoorOutdoorType"].Value;
                set => CellsByName["IndoorOutdoorType"].Value = (byte)value;
            }
            

            // Def="u8 TakeOverDstWeather_Sunny = 1"
            /// <summary>
            /// Replacement Weather: Sunny (u8)
            /// </summary>
            /// <remarks>
            /// In-game weather SFX to take over? _Sunny
            /// </remarks>
            public BoolCirclecrossType ReplacementWeatherSunny 
            {
                get => (BoolCirclecrossType)CellsByName["ReplacementWeatherSunny"].Value;
                set => CellsByName["ReplacementWeatherSunny"].Value = (byte)value;
            }
            

            // Def="u8 TakeOverDstWeather_ClearSky = 1"
            /// <summary>
            /// Replacement Weather: Clear Sky (u8)
            /// </summary>
            /// <remarks>
            /// In-game weather SFX to take over? _ Sunny
            /// </remarks>
            public BoolCirclecrossType ReplacementWeatherClearSky 
            {
                get => (BoolCirclecrossType)CellsByName["ReplacementWeatherClearSky"].Value;
                set => CellsByName["ReplacementWeatherClearSky"].Value = (byte)value;
            }
            

            // Def="u8 TakeOverDstWeather_WeakCloudy = 1"
            /// <summary>
            /// Replacement Weather: Light Cloud (u8)
            /// </summary>
            /// <remarks>
            /// Will the in-game weather SFX be taken over? _ Light cloudy
            /// </remarks>
            public BoolCirclecrossType ReplacementWeatherLightCloud 
            {
                get => (BoolCirclecrossType)CellsByName["ReplacementWeatherLightCloud"].Value;
                set => CellsByName["ReplacementWeatherLightCloud"].Value = (byte)value;
            }
            

            // Def="u8 TakeOverDstWeather_Cloud = 1"
            /// <summary>
            /// Replacement Weather: Cloud (u8)
            /// </summary>
            /// <remarks>
            /// Will the in-game weather SFX be taken over? _cloudy
            /// </remarks>
            public BoolCirclecrossType ReplacementWeatherCloud 
            {
                get => (BoolCirclecrossType)CellsByName["ReplacementWeatherCloud"].Value;
                set => CellsByName["ReplacementWeatherCloud"].Value = (byte)value;
            }
            

            // Def="u8 TakeOverDstWeather_Rain = 1"
            /// <summary>
            /// Replacement Weather: Rain (u8)
            /// </summary>
            /// <remarks>
            /// In-game weather SFX to take over? _rain
            /// </remarks>
            public BoolCirclecrossType ReplacementWeatherRain 
            {
                get => (BoolCirclecrossType)CellsByName["ReplacementWeatherRain"].Value;
                set => CellsByName["ReplacementWeatherRain"].Value = (byte)value;
            }
            

            // Def="u8 TakeOverDstWeather_HeavyRain = 1"
            /// <summary>
            /// Replacement Weather: Heavy Rain (u8)
            /// </summary>
            /// <remarks>
            /// In-game weather SFX to take over? _ Heavy rain
            /// </remarks>
            public BoolCirclecrossType ReplacementWeatherHeavyRain 
            {
                get => (BoolCirclecrossType)CellsByName["ReplacementWeatherHeavyRain"].Value;
                set => CellsByName["ReplacementWeatherHeavyRain"].Value = (byte)value;
            }
            

            // Def="u8 TakeOverDstWeather_Storm = 1"
            /// <summary>
            /// Replacement Weather: Storm (u8)
            /// </summary>
            /// <remarks>
            /// In-game weather SFX to take over? _storm
            /// </remarks>
            public BoolCirclecrossType ReplacementWeatherStorm 
            {
                get => (BoolCirclecrossType)CellsByName["ReplacementWeatherStorm"].Value;
                set => CellsByName["ReplacementWeatherStorm"].Value = (byte)value;
            }
            

            // Def="u8 TakeOverDstWeather_StormForBattle = 1"
            /// <summary>
            /// Replacement Weather: Storm for Battle (u8)
            /// </summary>
            /// <remarks>
            /// In-game weather SFX to take over? _ Storm (for battle with the descendants of the guardian)
            /// </remarks>
            public BoolCirclecrossType ReplacementWeatherStormForBattle 
            {
                get => (BoolCirclecrossType)CellsByName["ReplacementWeatherStormForBattle"].Value;
                set => CellsByName["ReplacementWeatherStormForBattle"].Value = (byte)value;
            }
            

            // Def="u8 TakeOverDstWeather_Snow = 1"
            /// <summary>
            /// Replacement Weather: Snow (u8)
            /// </summary>
            /// <remarks>
            /// In-game weather SFX to take over? _snow
            /// </remarks>
            public BoolCirclecrossType ReplacementWeatherSnow 
            {
                get => (BoolCirclecrossType)CellsByName["ReplacementWeatherSnow"].Value;
                set => CellsByName["ReplacementWeatherSnow"].Value = (byte)value;
            }
            

            // Def="u8 TakeOverDstWeather_HeavySnow = 1"
            /// <summary>
            /// Replacement Weather: Heavy Snow (u8)
            /// </summary>
            /// <remarks>
            /// In-game weather SFX to take over? _heavy snow
            /// </remarks>
            public BoolCirclecrossType ReplacementWeatherHeavySnow 
            {
                get => (BoolCirclecrossType)CellsByName["ReplacementWeatherHeavySnow"].Value;
                set => CellsByName["ReplacementWeatherHeavySnow"].Value = (byte)value;
            }
            

            // Def="u8 TakeOverDstWeather_Fog = 1"
            /// <summary>
            /// Replacement Weather: Fog (u8)
            /// </summary>
            /// <remarks>
            /// Will the in-game weather SFX be taken over? _fog
            /// </remarks>
            public BoolCirclecrossType ReplacementWeatherFog 
            {
                get => (BoolCirclecrossType)CellsByName["ReplacementWeatherFog"].Value;
                set => CellsByName["ReplacementWeatherFog"].Value = (byte)value;
            }
            

            // Def="u8 TakeOverDstWeather_HeavyFog = 1"
            /// <summary>
            /// Replacement Weather: Heavy Fog (u8)
            /// </summary>
            /// <remarks>
            /// Will the in-game weather SFX be taken over? _ Thick fog
            /// </remarks>
            public BoolCirclecrossType ReplacementWeatherHeavyFog 
            {
                get => (BoolCirclecrossType)CellsByName["ReplacementWeatherHeavyFog"].Value;
                set => CellsByName["ReplacementWeatherHeavyFog"].Value = (byte)value;
            }
            

            // Def="u8 TakeOverDstWeather_SandStorm = 1"
            /// <summary>
            /// Replacement Weather: Sandstorm (u8)
            /// </summary>
            /// <remarks>
            /// In-game weather SFX to take over? _ Sandstorm
            /// </remarks>
            public BoolCirclecrossType ReplacementWeatherSandstorm 
            {
                get => (BoolCirclecrossType)CellsByName["ReplacementWeatherSandstorm"].Value;
                set => CellsByName["ReplacementWeatherSandstorm"].Value = (byte)value;
            }
            

            // Def="u8 TakeOverDstWeather_HeavyFogRain = 1"
            /// <summary>
            /// Replacement Weather: Heavy Fog and Rain (u8)
            /// </summary>
            /// <remarks>
            /// In-game weather SFX to take over? _ Thick fog (rain)
            /// </remarks>
            public BoolCirclecrossType ReplacementWeatherHeavyFogAndRain 
            {
                get => (BoolCirclecrossType)CellsByName["ReplacementWeatherHeavyFogAndRain"].Value;
                set => CellsByName["ReplacementWeatherHeavyFogAndRain"].Value = (byte)value;
            }
            

            // Def="dummy8 reserved[7]"
            /// <summary>
            /// reserved (dummy8)
            /// </summary>
            /// <remarks>
            /// reserved
            /// </remarks>
            public object Reserved 
            {
                get => (object)CellsByName["Reserved"].Value;
                set => CellsByName["Reserved"].Value = (object)value;
            }
            

            // Def="s16 DstWeather_Snowstorm"
            /// <summary>
            /// Destination Weather: Snowstorm (s16)
            /// </summary>
            /// <remarks>
            /// Snowstorm
            /// </remarks>
            public WeatherType DestinationWeatherSnowstorm 
            {
                get => (WeatherType)CellsByName["DestinationWeatherSnowstorm"].Value;
                set => CellsByName["DestinationWeatherSnowstorm"].Value = (short)value;
            }
            

            // Def="s16 DstWeather_LightningStorm"
            /// <summary>
            /// Destination Weather: Lightning Storm (s16)
            /// </summary>
            /// <remarks>
            /// Preliminary weather 2
            /// </remarks>
            public WeatherType DestinationWeatherLightningStorm 
            {
                get => (WeatherType)CellsByName["DestinationWeatherLightningStorm"].Value;
                set => CellsByName["DestinationWeatherLightningStorm"].Value = (short)value;
            }
            

            // Def="s16 DstWeather_Reserved3"
            /// <summary>
            /// Destination Weather: Reserved 3 (s16)
            /// </summary>
            /// <remarks>
            /// Preliminary weather 3
            /// </remarks>
            public WeatherType DestinationWeatherReserved3 
            {
                get => (WeatherType)CellsByName["DestinationWeatherReserved3"].Value;
                set => CellsByName["DestinationWeatherReserved3"].Value = (short)value;
            }
            

            // Def="s16 DstWeather_Reserved4"
            /// <summary>
            /// Destination Weather: Reserved 4 (s16)
            /// </summary>
            /// <remarks>
            /// Preliminary weather 4
            /// </remarks>
            public WeatherType DestinationWeatherReserved4 
            {
                get => (WeatherType)CellsByName["DestinationWeatherReserved4"].Value;
                set => CellsByName["DestinationWeatherReserved4"].Value = (short)value;
            }
            

            // Def="s16 DstWeather_Reserved5"
            /// <summary>
            /// Destination Weather: Reserved 5 (s16)
            /// </summary>
            /// <remarks>
            /// Preliminary weather 5
            /// </remarks>
            public WeatherType DestinationWeatherReserved5 
            {
                get => (WeatherType)CellsByName["DestinationWeatherReserved5"].Value;
                set => CellsByName["DestinationWeatherReserved5"].Value = (short)value;
            }
            

            // Def="s16 DstWeather_Reserved6"
            /// <summary>
            /// Destination Weather: Reserved 6 (s16)
            /// </summary>
            /// <remarks>
            /// Preliminary weather 6
            /// </remarks>
            public WeatherType DestinationWeatherReserved6 
            {
                get => (WeatherType)CellsByName["DestinationWeatherReserved6"].Value;
                set => CellsByName["DestinationWeatherReserved6"].Value = (short)value;
            }
            

            // Def="s16 DstWeather_Reserved7"
            /// <summary>
            /// Destination Weather: Reserved 7 (s16)
            /// </summary>
            /// <remarks>
            /// Preliminary weather 7
            /// </remarks>
            public WeatherType DestinationWeatherReserved7 
            {
                get => (WeatherType)CellsByName["DestinationWeatherReserved7"].Value;
                set => CellsByName["DestinationWeatherReserved7"].Value = (short)value;
            }
            

            // Def="s16 DstWeather_Reserved8"
            /// <summary>
            /// Destination Weather: Reserved 8 (s16)
            /// </summary>
            /// <remarks>
            /// Preliminary weather 8
            /// </remarks>
            public WeatherType DestinationWeatherReserved8 
            {
                get => (WeatherType)CellsByName["DestinationWeatherReserved8"].Value;
                set => CellsByName["DestinationWeatherReserved8"].Value = (short)value;
            }
            

            // Def="u8 TakeOverDstWeather_Snowstorm = 1"
            /// <summary>
            /// Replacement Weather: Snowstorm (u8)
            /// </summary>
            /// <remarks>
            /// In-game weather SFX to take over? _ Snowstorm
            /// </remarks>
            public BoolCirclecrossType ReplacementWeatherSnowstorm 
            {
                get => (BoolCirclecrossType)CellsByName["ReplacementWeatherSnowstorm"].Value;
                set => CellsByName["ReplacementWeatherSnowstorm"].Value = (byte)value;
            }
            

            // Def="u8 TakeOverDstWeather_LightningStorm = 1"
            /// <summary>
            /// Replacement Weather: Lightning Storm (u8)
            /// </summary>
            /// <remarks>
            /// In-game weather SFX to take over? _ Storm (thunder)
            /// </remarks>
            public BoolCirclecrossType ReplacementWeatherLightningStorm 
            {
                get => (BoolCirclecrossType)CellsByName["ReplacementWeatherLightningStorm"].Value;
                set => CellsByName["ReplacementWeatherLightningStorm"].Value = (byte)value;
            }
            

            // Def="u8 TakeOverDstWeather_Reserved3 = 1"
            /// <summary>
            /// Replacement Weather: Reserved 3 (u8)
            /// </summary>
            /// <remarks>
            /// Will the in-game weather SFX be taken over? _ Preliminary weather 3
            /// </remarks>
            public BoolCirclecrossType ReplacementWeatherReserved3 
            {
                get => (BoolCirclecrossType)CellsByName["ReplacementWeatherReserved3"].Value;
                set => CellsByName["ReplacementWeatherReserved3"].Value = (byte)value;
            }
            

            // Def="u8 TakeOverDstWeather_Reserved4 = 1"
            /// <summary>
            /// Replacement Weather: Reserved 4 (u8)
            /// </summary>
            /// <remarks>
            /// In-game weather SFX to take over? _ Preliminary weather 4
            /// </remarks>
            public BoolCirclecrossType ReplacementWeatherReserved4 
            {
                get => (BoolCirclecrossType)CellsByName["ReplacementWeatherReserved4"].Value;
                set => CellsByName["ReplacementWeatherReserved4"].Value = (byte)value;
            }
            

            // Def="u8 TakeOverDstWeather_Reserved5 = 1"
            /// <summary>
            /// Replacement Weather: Reserved 5 (u8)
            /// </summary>
            /// <remarks>
            /// Will the in-game weather SFX be taken over? _ Preliminary weather 5
            /// </remarks>
            public BoolCirclecrossType ReplacementWeatherReserved5 
            {
                get => (BoolCirclecrossType)CellsByName["ReplacementWeatherReserved5"].Value;
                set => CellsByName["ReplacementWeatherReserved5"].Value = (byte)value;
            }
            

            // Def="u8 TakeOverDstWeather_Reserved6 = 1"
            /// <summary>
            /// Replacement Weather: Reserved 6 (u8)
            /// </summary>
            /// <remarks>
            /// Will the in-game weather SFX be taken over? _ Preliminary weather 6
            /// </remarks>
            public BoolCirclecrossType ReplacementWeatherReserved6 
            {
                get => (BoolCirclecrossType)CellsByName["ReplacementWeatherReserved6"].Value;
                set => CellsByName["ReplacementWeatherReserved6"].Value = (byte)value;
            }
            

            // Def="u8 TakeOverDstWeather_Reserved7 = 1"
            /// <summary>
            /// Replacement Weather: Reserved 7 (u8)
            /// </summary>
            /// <remarks>
            /// Will the in-game weather SFX be taken over? _ Preliminary weather 7
            /// </remarks>
            public BoolCirclecrossType ReplacementWeatherReserved7 
            {
                get => (BoolCirclecrossType)CellsByName["ReplacementWeatherReserved7"].Value;
                set => CellsByName["ReplacementWeatherReserved7"].Value = (byte)value;
            }
            

            // Def="u8 TakeOverDstWeather_Reserved8 = 1"
            /// <summary>
            /// Replacement Weather: Reserved 8 (u8)
            /// </summary>
            /// <remarks>
            /// In-game weather SFX to take over? _ Preliminary weather 8
            /// </remarks>
            public BoolCirclecrossType ReplacementWeatherReserved8 
            {
                get => (BoolCirclecrossType)CellsByName["ReplacementWeatherReserved8"].Value;
                set => CellsByName["ReplacementWeatherReserved8"].Value = (byte)value;
            }
            

            // Def="u8 IsEnableApplyMapGdRegionIdForGparam"
            /// <summary>
            /// Apply MapGdRegionID for GPARAM Enabled (u8)
            /// </summary>
            /// <remarks>
            /// Do you want to apply the mapGD local ID changes to the cutscene weather Gparam as in the in-game? ([GR] SEQ30194)
            /// </remarks>
            public BoolCirclecrossType ApplyMapGdRegionIDForGPARAMEnabled 
            {
                get => (BoolCirclecrossType)CellsByName["ApplyMapGdRegionIDForGPARAMEnabled"].Value;
                set => CellsByName["ApplyMapGdRegionIDForGPARAMEnabled"].Value = (byte)value;
            }
            

            // Def="dummy8 reserved2[1]"
            /// <summary>
            /// reserved1 (dummy8)
            /// </summary>
            /// <remarks>
            /// reserved1 ver4-> 5 64-> 96
            /// </remarks>
            public object Reserved1 
            {
                get => (object)CellsByName["Reserved1"].Value;
                set => CellsByName["Reserved1"].Value = (object)value;
            }
            

            // Def="s16 OverrideMapGdRegionId = -1"
            /// <summary>
            /// Override MapGdRegion ID (s16)
            /// </summary>
            /// <remarks>
            /// Overwrite the ID used for cutscene weather Gparam (-1: No overwrite. MapGD local ID during cutscene playback is used). If "Do you want to apply MapGD local ID to weather Gparam?" Is x, it is not referenced.
            /// </remarks>
            public short OverrideMapGdRegionID 
            {
                get => (short)CellsByName["OverrideMapGdRegionID"].Value;
                set => CellsByName["OverrideMapGdRegionID"].Value = (short)value;
            }
            

                }
            }
            
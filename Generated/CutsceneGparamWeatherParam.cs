
            namespace StronglyTypedParams
            {
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
            public byte DisableParamNetworkTest 
            {
                get => (byte)CellsByName["DisableParamNetworkTest"].Value;
                set => CellsByName["DisableParamNetworkTest"].Value = value;
            }
            

            // Def="u8 disableParam_Debug:1"
            /// <summary>
            /// Disable Param - Debug (u8)
            /// </summary>
            /// <remarks>
            /// Parameters marked with a circle are excluded from all packages (because they are for debugging).
            /// </remarks>
            public byte DisableParamDebug 
            {
                get => (byte)CellsByName["DisableParamDebug"].Value;
                set => CellsByName["DisableParamDebug"].Value = value;
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
            

            // Def="s16 DstWeather_Sunny"
            /// <summary>
            /// Destination Weather: Sunny (s16)
            /// </summary>
            /// <remarks>
            /// Sunny
            /// </remarks>
            public short DestinationWeatherSunny 
            {
                get => (short)CellsByName["DestinationWeatherSunny"].Value;
                set => CellsByName["DestinationWeatherSunny"].Value = value;
            }
            

            // Def="s16 DstWeather_ClearSky"
            /// <summary>
            /// Destination Weather: Clear Sky (s16)
            /// </summary>
            /// <remarks>
            /// Sunny
            /// </remarks>
            public short DestinationWeatherClearSky 
            {
                get => (short)CellsByName["DestinationWeatherClearSky"].Value;
                set => CellsByName["DestinationWeatherClearSky"].Value = value;
            }
            

            // Def="s16 DstWeather_WeakCloudy"
            /// <summary>
            /// Destination Weather: Light Cloud (s16)
            /// </summary>
            /// <remarks>
            /// Light cloudy
            /// </remarks>
            public short DestinationWeatherLightCloud 
            {
                get => (short)CellsByName["DestinationWeatherLightCloud"].Value;
                set => CellsByName["DestinationWeatherLightCloud"].Value = value;
            }
            

            // Def="s16 DstWeather_Cloud"
            /// <summary>
            /// Destination Weather: Cloud (s16)
            /// </summary>
            /// <remarks>
            /// cloudy
            /// </remarks>
            public short DestinationWeatherCloud 
            {
                get => (short)CellsByName["DestinationWeatherCloud"].Value;
                set => CellsByName["DestinationWeatherCloud"].Value = value;
            }
            

            // Def="s16 DstWeather_Rain"
            /// <summary>
            /// Destination Weather: Rain (s16)
            /// </summary>
            /// <remarks>
            /// rain
            /// </remarks>
            public short DestinationWeatherRain 
            {
                get => (short)CellsByName["DestinationWeatherRain"].Value;
                set => CellsByName["DestinationWeatherRain"].Value = value;
            }
            

            // Def="s16 DstWeather_HeavyRain"
            /// <summary>
            /// Destination Weather: Heavy Rain (s16)
            /// </summary>
            /// <remarks>
            /// Heavy rain
            /// </remarks>
            public short DestinationWeatherHeavyRain 
            {
                get => (short)CellsByName["DestinationWeatherHeavyRain"].Value;
                set => CellsByName["DestinationWeatherHeavyRain"].Value = value;
            }
            

            // Def="s16 DstWeather_Storm"
            /// <summary>
            /// Destination Weather: Storm (s16)
            /// </summary>
            /// <remarks>
            /// storm
            /// </remarks>
            public short DestinationWeatherStorm 
            {
                get => (short)CellsByName["DestinationWeatherStorm"].Value;
                set => CellsByName["DestinationWeatherStorm"].Value = value;
            }
            

            // Def="s16 DstWeather_StormForBattle"
            /// <summary>
            /// Destination Weather: Storm for Battle (s16)
            /// </summary>
            /// <remarks>
            /// Storm (for combat with the descendants of the guardian)
            /// </remarks>
            public short DestinationWeatherStormForBattle 
            {
                get => (short)CellsByName["DestinationWeatherStormForBattle"].Value;
                set => CellsByName["DestinationWeatherStormForBattle"].Value = value;
            }
            

            // Def="s16 DstWeather_Snow"
            /// <summary>
            /// Destination Weather: Snow (s16)
            /// </summary>
            /// <remarks>
            /// snow
            /// </remarks>
            public short DestinationWeatherSnow 
            {
                get => (short)CellsByName["DestinationWeatherSnow"].Value;
                set => CellsByName["DestinationWeatherSnow"].Value = value;
            }
            

            // Def="s16 DstWeather_HeavySnow"
            /// <summary>
            /// Destination Weather: Heavy Snow (s16)
            /// </summary>
            /// <remarks>
            /// heavy snow
            /// </remarks>
            public short DestinationWeatherHeavySnow 
            {
                get => (short)CellsByName["DestinationWeatherHeavySnow"].Value;
                set => CellsByName["DestinationWeatherHeavySnow"].Value = value;
            }
            

            // Def="s16 DstWeather_Fog"
            /// <summary>
            /// Destination Weather: Fog (s16)
            /// </summary>
            /// <remarks>
            /// fog
            /// </remarks>
            public short DestinationWeatherFog 
            {
                get => (short)CellsByName["DestinationWeatherFog"].Value;
                set => CellsByName["DestinationWeatherFog"].Value = value;
            }
            

            // Def="s16 DstWeather_HeavyFog"
            /// <summary>
            /// Destination Weather: Heavy Fog (s16)
            /// </summary>
            /// <remarks>
            /// Thick fog
            /// </remarks>
            public short DestinationWeatherHeavyFog 
            {
                get => (short)CellsByName["DestinationWeatherHeavyFog"].Value;
                set => CellsByName["DestinationWeatherHeavyFog"].Value = value;
            }
            

            // Def="s16 DstWeather_SandStorm"
            /// <summary>
            /// Destination Weather: Sandstorm (s16)
            /// </summary>
            /// <remarks>
            /// Sandstorm
            /// </remarks>
            public short DestinationWeatherSandstorm 
            {
                get => (short)CellsByName["DestinationWeatherSandstorm"].Value;
                set => CellsByName["DestinationWeatherSandstorm"].Value = value;
            }
            

            // Def="s16 DstWeather_HeavyFogRain"
            /// <summary>
            /// Destination Weather: Heavy Fog and Rain (s16)
            /// </summary>
            /// <remarks>
            /// Thick fog (rain)
            /// </remarks>
            public short DestinationWeatherHeavyFogAndRain 
            {
                get => (short)CellsByName["DestinationWeatherHeavyFogAndRain"].Value;
                set => CellsByName["DestinationWeatherHeavyFogAndRain"].Value = value;
            }
            

            // Def="s16 PostPlayIngameWeather = -1"
            /// <summary>
            /// Post Cutscene In-game Weather (s16)
            /// </summary>
            /// <remarks>
            /// In-game weather specifications at the end of playback (nothing is done if blank or "invalid")
            /// </remarks>
            public short PostCutsceneInGameWeather 
            {
                get => (short)CellsByName["PostCutsceneInGameWeather"].Value;
                set => CellsByName["PostCutsceneInGameWeather"].Value = value;
            }
            

            // Def="u8 IndoorOutdoorType"
            /// <summary>
            /// Indoor/Outdoor Type (u8)
            /// </summary>
            /// <remarks>
            /// When indoors, the SFX specified by "Weather SfxId (Outdoor)" and "Wind SfxId (Outdoor)" in "Weather Parameter.xlsm" will be invalid in the cutscene.
            /// </remarks>
            public byte IndoorOutdoorType 
            {
                get => (byte)CellsByName["IndoorOutdoorType"].Value;
                set => CellsByName["IndoorOutdoorType"].Value = value;
            }
            

            // Def="u8 TakeOverDstWeather_Sunny = 1"
            /// <summary>
            /// Replacement Weather: Sunny (u8)
            /// </summary>
            /// <remarks>
            /// In-game weather SFX to take over? _Sunny
            /// </remarks>
            public byte ReplacementWeatherSunny 
            {
                get => (byte)CellsByName["ReplacementWeatherSunny"].Value;
                set => CellsByName["ReplacementWeatherSunny"].Value = value;
            }
            

            // Def="u8 TakeOverDstWeather_ClearSky = 1"
            /// <summary>
            /// Replacement Weather: Clear Sky (u8)
            /// </summary>
            /// <remarks>
            /// In-game weather SFX to take over? _ Sunny
            /// </remarks>
            public byte ReplacementWeatherClearSky 
            {
                get => (byte)CellsByName["ReplacementWeatherClearSky"].Value;
                set => CellsByName["ReplacementWeatherClearSky"].Value = value;
            }
            

            // Def="u8 TakeOverDstWeather_WeakCloudy = 1"
            /// <summary>
            /// Replacement Weather: Light Cloud (u8)
            /// </summary>
            /// <remarks>
            /// Will the in-game weather SFX be taken over? _ Light cloudy
            /// </remarks>
            public byte ReplacementWeatherLightCloud 
            {
                get => (byte)CellsByName["ReplacementWeatherLightCloud"].Value;
                set => CellsByName["ReplacementWeatherLightCloud"].Value = value;
            }
            

            // Def="u8 TakeOverDstWeather_Cloud = 1"
            /// <summary>
            /// Replacement Weather: Cloud (u8)
            /// </summary>
            /// <remarks>
            /// Will the in-game weather SFX be taken over? _cloudy
            /// </remarks>
            public byte ReplacementWeatherCloud 
            {
                get => (byte)CellsByName["ReplacementWeatherCloud"].Value;
                set => CellsByName["ReplacementWeatherCloud"].Value = value;
            }
            

            // Def="u8 TakeOverDstWeather_Rain = 1"
            /// <summary>
            /// Replacement Weather: Rain (u8)
            /// </summary>
            /// <remarks>
            /// In-game weather SFX to take over? _rain
            /// </remarks>
            public byte ReplacementWeatherRain 
            {
                get => (byte)CellsByName["ReplacementWeatherRain"].Value;
                set => CellsByName["ReplacementWeatherRain"].Value = value;
            }
            

            // Def="u8 TakeOverDstWeather_HeavyRain = 1"
            /// <summary>
            /// Replacement Weather: Heavy Rain (u8)
            /// </summary>
            /// <remarks>
            /// In-game weather SFX to take over? _ Heavy rain
            /// </remarks>
            public byte ReplacementWeatherHeavyRain 
            {
                get => (byte)CellsByName["ReplacementWeatherHeavyRain"].Value;
                set => CellsByName["ReplacementWeatherHeavyRain"].Value = value;
            }
            

            // Def="u8 TakeOverDstWeather_Storm = 1"
            /// <summary>
            /// Replacement Weather: Storm (u8)
            /// </summary>
            /// <remarks>
            /// In-game weather SFX to take over? _storm
            /// </remarks>
            public byte ReplacementWeatherStorm 
            {
                get => (byte)CellsByName["ReplacementWeatherStorm"].Value;
                set => CellsByName["ReplacementWeatherStorm"].Value = value;
            }
            

            // Def="u8 TakeOverDstWeather_StormForBattle = 1"
            /// <summary>
            /// Replacement Weather: Storm for Battle (u8)
            /// </summary>
            /// <remarks>
            /// In-game weather SFX to take over? _ Storm (for battle with the descendants of the guardian)
            /// </remarks>
            public byte ReplacementWeatherStormForBattle 
            {
                get => (byte)CellsByName["ReplacementWeatherStormForBattle"].Value;
                set => CellsByName["ReplacementWeatherStormForBattle"].Value = value;
            }
            

            // Def="u8 TakeOverDstWeather_Snow = 1"
            /// <summary>
            /// Replacement Weather: Snow (u8)
            /// </summary>
            /// <remarks>
            /// In-game weather SFX to take over? _snow
            /// </remarks>
            public byte ReplacementWeatherSnow 
            {
                get => (byte)CellsByName["ReplacementWeatherSnow"].Value;
                set => CellsByName["ReplacementWeatherSnow"].Value = value;
            }
            

            // Def="u8 TakeOverDstWeather_HeavySnow = 1"
            /// <summary>
            /// Replacement Weather: Heavy Snow (u8)
            /// </summary>
            /// <remarks>
            /// In-game weather SFX to take over? _heavy snow
            /// </remarks>
            public byte ReplacementWeatherHeavySnow 
            {
                get => (byte)CellsByName["ReplacementWeatherHeavySnow"].Value;
                set => CellsByName["ReplacementWeatherHeavySnow"].Value = value;
            }
            

            // Def="u8 TakeOverDstWeather_Fog = 1"
            /// <summary>
            /// Replacement Weather: Fog (u8)
            /// </summary>
            /// <remarks>
            /// Will the in-game weather SFX be taken over? _fog
            /// </remarks>
            public byte ReplacementWeatherFog 
            {
                get => (byte)CellsByName["ReplacementWeatherFog"].Value;
                set => CellsByName["ReplacementWeatherFog"].Value = value;
            }
            

            // Def="u8 TakeOverDstWeather_HeavyFog = 1"
            /// <summary>
            /// Replacement Weather: Heavy Fog (u8)
            /// </summary>
            /// <remarks>
            /// Will the in-game weather SFX be taken over? _ Thick fog
            /// </remarks>
            public byte ReplacementWeatherHeavyFog 
            {
                get => (byte)CellsByName["ReplacementWeatherHeavyFog"].Value;
                set => CellsByName["ReplacementWeatherHeavyFog"].Value = value;
            }
            

            // Def="u8 TakeOverDstWeather_SandStorm = 1"
            /// <summary>
            /// Replacement Weather: Sandstorm (u8)
            /// </summary>
            /// <remarks>
            /// In-game weather SFX to take over? _ Sandstorm
            /// </remarks>
            public byte ReplacementWeatherSandstorm 
            {
                get => (byte)CellsByName["ReplacementWeatherSandstorm"].Value;
                set => CellsByName["ReplacementWeatherSandstorm"].Value = value;
            }
            

            // Def="u8 TakeOverDstWeather_HeavyFogRain = 1"
            /// <summary>
            /// Replacement Weather: Heavy Fog and Rain (u8)
            /// </summary>
            /// <remarks>
            /// In-game weather SFX to take over? _ Thick fog (rain)
            /// </remarks>
            public byte ReplacementWeatherHeavyFogAndRain 
            {
                get => (byte)CellsByName["ReplacementWeatherHeavyFogAndRain"].Value;
                set => CellsByName["ReplacementWeatherHeavyFogAndRain"].Value = value;
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
                set => CellsByName["Reserved"].Value = value;
            }
            

            // Def="s16 DstWeather_Snowstorm"
            /// <summary>
            /// Destination Weather: Snowstorm (s16)
            /// </summary>
            /// <remarks>
            /// Snowstorm
            /// </remarks>
            public short DestinationWeatherSnowstorm 
            {
                get => (short)CellsByName["DestinationWeatherSnowstorm"].Value;
                set => CellsByName["DestinationWeatherSnowstorm"].Value = value;
            }
            

            // Def="s16 DstWeather_LightningStorm"
            /// <summary>
            /// Destination Weather: Lightning Storm (s16)
            /// </summary>
            /// <remarks>
            /// Preliminary weather 2
            /// </remarks>
            public short DestinationWeatherLightningStorm 
            {
                get => (short)CellsByName["DestinationWeatherLightningStorm"].Value;
                set => CellsByName["DestinationWeatherLightningStorm"].Value = value;
            }
            

            // Def="s16 DstWeather_Reserved3"
            /// <summary>
            /// Destination Weather: Reserved 3 (s16)
            /// </summary>
            /// <remarks>
            /// Preliminary weather 3
            /// </remarks>
            public short DestinationWeatherReserved3 
            {
                get => (short)CellsByName["DestinationWeatherReserved3"].Value;
                set => CellsByName["DestinationWeatherReserved3"].Value = value;
            }
            

            // Def="s16 DstWeather_Reserved4"
            /// <summary>
            /// Destination Weather: Reserved 4 (s16)
            /// </summary>
            /// <remarks>
            /// Preliminary weather 4
            /// </remarks>
            public short DestinationWeatherReserved4 
            {
                get => (short)CellsByName["DestinationWeatherReserved4"].Value;
                set => CellsByName["DestinationWeatherReserved4"].Value = value;
            }
            

            // Def="s16 DstWeather_Reserved5"
            /// <summary>
            /// Destination Weather: Reserved 5 (s16)
            /// </summary>
            /// <remarks>
            /// Preliminary weather 5
            /// </remarks>
            public short DestinationWeatherReserved5 
            {
                get => (short)CellsByName["DestinationWeatherReserved5"].Value;
                set => CellsByName["DestinationWeatherReserved5"].Value = value;
            }
            

            // Def="s16 DstWeather_Reserved6"
            /// <summary>
            /// Destination Weather: Reserved 6 (s16)
            /// </summary>
            /// <remarks>
            /// Preliminary weather 6
            /// </remarks>
            public short DestinationWeatherReserved6 
            {
                get => (short)CellsByName["DestinationWeatherReserved6"].Value;
                set => CellsByName["DestinationWeatherReserved6"].Value = value;
            }
            

            // Def="s16 DstWeather_Reserved7"
            /// <summary>
            /// Destination Weather: Reserved 7 (s16)
            /// </summary>
            /// <remarks>
            /// Preliminary weather 7
            /// </remarks>
            public short DestinationWeatherReserved7 
            {
                get => (short)CellsByName["DestinationWeatherReserved7"].Value;
                set => CellsByName["DestinationWeatherReserved7"].Value = value;
            }
            

            // Def="s16 DstWeather_Reserved8"
            /// <summary>
            /// Destination Weather: Reserved 8 (s16)
            /// </summary>
            /// <remarks>
            /// Preliminary weather 8
            /// </remarks>
            public short DestinationWeatherReserved8 
            {
                get => (short)CellsByName["DestinationWeatherReserved8"].Value;
                set => CellsByName["DestinationWeatherReserved8"].Value = value;
            }
            

            // Def="u8 TakeOverDstWeather_Snowstorm = 1"
            /// <summary>
            /// Replacement Weather: Snowstorm (u8)
            /// </summary>
            /// <remarks>
            /// In-game weather SFX to take over? _ Snowstorm
            /// </remarks>
            public byte ReplacementWeatherSnowstorm 
            {
                get => (byte)CellsByName["ReplacementWeatherSnowstorm"].Value;
                set => CellsByName["ReplacementWeatherSnowstorm"].Value = value;
            }
            

            // Def="u8 TakeOverDstWeather_LightningStorm = 1"
            /// <summary>
            /// Replacement Weather: Lightning Storm (u8)
            /// </summary>
            /// <remarks>
            /// In-game weather SFX to take over? _ Storm (thunder)
            /// </remarks>
            public byte ReplacementWeatherLightningStorm 
            {
                get => (byte)CellsByName["ReplacementWeatherLightningStorm"].Value;
                set => CellsByName["ReplacementWeatherLightningStorm"].Value = value;
            }
            

            // Def="u8 TakeOverDstWeather_Reserved3 = 1"
            /// <summary>
            /// Replacement Weather: Reserved 3 (u8)
            /// </summary>
            /// <remarks>
            /// Will the in-game weather SFX be taken over? _ Preliminary weather 3
            /// </remarks>
            public byte ReplacementWeatherReserved3 
            {
                get => (byte)CellsByName["ReplacementWeatherReserved3"].Value;
                set => CellsByName["ReplacementWeatherReserved3"].Value = value;
            }
            

            // Def="u8 TakeOverDstWeather_Reserved4 = 1"
            /// <summary>
            /// Replacement Weather: Reserved 4 (u8)
            /// </summary>
            /// <remarks>
            /// In-game weather SFX to take over? _ Preliminary weather 4
            /// </remarks>
            public byte ReplacementWeatherReserved4 
            {
                get => (byte)CellsByName["ReplacementWeatherReserved4"].Value;
                set => CellsByName["ReplacementWeatherReserved4"].Value = value;
            }
            

            // Def="u8 TakeOverDstWeather_Reserved5 = 1"
            /// <summary>
            /// Replacement Weather: Reserved 5 (u8)
            /// </summary>
            /// <remarks>
            /// Will the in-game weather SFX be taken over? _ Preliminary weather 5
            /// </remarks>
            public byte ReplacementWeatherReserved5 
            {
                get => (byte)CellsByName["ReplacementWeatherReserved5"].Value;
                set => CellsByName["ReplacementWeatherReserved5"].Value = value;
            }
            

            // Def="u8 TakeOverDstWeather_Reserved6 = 1"
            /// <summary>
            /// Replacement Weather: Reserved 6 (u8)
            /// </summary>
            /// <remarks>
            /// Will the in-game weather SFX be taken over? _ Preliminary weather 6
            /// </remarks>
            public byte ReplacementWeatherReserved6 
            {
                get => (byte)CellsByName["ReplacementWeatherReserved6"].Value;
                set => CellsByName["ReplacementWeatherReserved6"].Value = value;
            }
            

            // Def="u8 TakeOverDstWeather_Reserved7 = 1"
            /// <summary>
            /// Replacement Weather: Reserved 7 (u8)
            /// </summary>
            /// <remarks>
            /// Will the in-game weather SFX be taken over? _ Preliminary weather 7
            /// </remarks>
            public byte ReplacementWeatherReserved7 
            {
                get => (byte)CellsByName["ReplacementWeatherReserved7"].Value;
                set => CellsByName["ReplacementWeatherReserved7"].Value = value;
            }
            

            // Def="u8 TakeOverDstWeather_Reserved8 = 1"
            /// <summary>
            /// Replacement Weather: Reserved 8 (u8)
            /// </summary>
            /// <remarks>
            /// In-game weather SFX to take over? _ Preliminary weather 8
            /// </remarks>
            public byte ReplacementWeatherReserved8 
            {
                get => (byte)CellsByName["ReplacementWeatherReserved8"].Value;
                set => CellsByName["ReplacementWeatherReserved8"].Value = value;
            }
            

            // Def="u8 IsEnableApplyMapGdRegionIdForGparam"
            /// <summary>
            /// Apply MapGdRegionID for GPARAM Enabled (u8)
            /// </summary>
            /// <remarks>
            /// Do you want to apply the mapGD local ID changes to the cutscene weather Gparam as in the in-game? ([GR] SEQ30194)
            /// </remarks>
            public byte ApplyMapGdRegionIDForGPARAMEnabled 
            {
                get => (byte)CellsByName["ApplyMapGdRegionIDForGPARAMEnabled"].Value;
                set => CellsByName["ApplyMapGdRegionIDForGPARAMEnabled"].Value = value;
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
                set => CellsByName["Reserved1"].Value = value;
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
                set => CellsByName["OverrideMapGdRegionID"].Value = value;
            }
            

                }
            }
            

namespace StronglyTypedParams
{
    public class ChrActivateConditionParam : ParamRow
    {
        public ChrActivateConditionParam() : base()
        {
        }


        // Def="u8 weatherSunny:1 = 1"
        /// <summary>
        /// Appear during Weather: Sunny (u8)
        /// </summary>
        /// <remarks>
        /// Will it appear when the weather is "sunny"?
        /// </remarks>
        public byte AppearDuringWeatherSunny
        {
            get => (byte)CellsByName["AppearDuringWeatherSunny"].Value;
            set => CellsByName["AppearDuringWeatherSunny"].Value = value;
        }


        // Def="u8 weatherClearSky:1 = 1"
        /// <summary>
        /// Appear during Weather: Clear Sky (u8)
        /// </summary>
        /// <remarks>
        /// Will it appear when the weather is "clear"?
        /// </remarks>
        public byte AppearDuringWeatherClearSky
        {
            get => (byte)CellsByName["AppearDuringWeatherClearSky"].Value;
            set => CellsByName["AppearDuringWeatherClearSky"].Value = value;
        }


        // Def="u8 weatherWeakCloudy:1 = 1"
        /// <summary>
        /// Appear during Weather: Light Cloud (u8)
        /// </summary>
        /// <remarks>
        /// Will it appear when the weather is "lightly cloudy"?
        /// </remarks>
        public byte AppearDuringWeatherLightCloud
        {
            get => (byte)CellsByName["AppearDuringWeatherLightCloud"].Value;
            set => CellsByName["AppearDuringWeatherLightCloud"].Value = value;
        }


        // Def="u8 weatherCloudy:1 = 1"
        /// <summary>
        /// Appear during Weather: Cloud (u8)
        /// </summary>
        /// <remarks>
        /// Will it appear when the weather is "cloudy"?
        /// </remarks>
        public byte AppearDuringWeatherCloud
        {
            get => (byte)CellsByName["AppearDuringWeatherCloud"].Value;
            set => CellsByName["AppearDuringWeatherCloud"].Value = value;
        }


        // Def="u8 weatherRain:1 = 1"
        /// <summary>
        /// Appear during Weather: Rain (u8)
        /// </summary>
        /// <remarks>
        /// Will it appear when the weather is "rainy"?
        /// </remarks>
        public byte AppearDuringWeatherRain
        {
            get => (byte)CellsByName["AppearDuringWeatherRain"].Value;
            set => CellsByName["AppearDuringWeatherRain"].Value = value;
        }


        // Def="u8 weatherHeavyRain:1 = 1"
        /// <summary>
        /// Appear during Weather: Heavy Rain (u8)
        /// </summary>
        /// <remarks>
        /// Will it appear when the weather is "heavy rain"?
        /// </remarks>
        public byte AppearDuringWeatherHeavyRain
        {
            get => (byte)CellsByName["AppearDuringWeatherHeavyRain"].Value;
            set => CellsByName["AppearDuringWeatherHeavyRain"].Value = value;
        }


        // Def="u8 weatherStorm:1 = 1"
        /// <summary>
        /// Appear during Weather: Storm (u8)
        /// </summary>
        /// <remarks>
        /// Will it appear when the weather is "stormy"?
        /// </remarks>
        public byte AppearDuringWeatherStorm
        {
            get => (byte)CellsByName["AppearDuringWeatherStorm"].Value;
            set => CellsByName["AppearDuringWeatherStorm"].Value = value;
        }


        // Def="u8 weatherStormForBattle:1 = 1"
        /// <summary>
        /// Appear during Weather: Storm for Battle (u8)
        /// </summary>
        /// <remarks>
        /// Will it appear when the weather is "storm (for combat with the descendants of the guardian)"?
        /// </remarks>
        public byte AppearDuringWeatherStormForBattle
        {
            get => (byte)CellsByName["AppearDuringWeatherStormForBattle"].Value;
            set => CellsByName["AppearDuringWeatherStormForBattle"].Value = value;
        }


        // Def="u8 weatherSnow:1 = 1"
        /// <summary>
        /// Appear during Weather: Snow (u8)
        /// </summary>
        /// <remarks>
        /// Will it appear when the weather is "snow"?
        /// </remarks>
        public byte AppearDuringWeatherSnow
        {
            get => (byte)CellsByName["AppearDuringWeatherSnow"].Value;
            set => CellsByName["AppearDuringWeatherSnow"].Value = value;
        }


        // Def="u8 weatherHeavySnow:1 = 1"
        /// <summary>
        /// Appear during Weather: Heavy Snow (u8)
        /// </summary>
        /// <remarks>
        /// Will it appear when the weather is "heavy snow"?
        /// </remarks>
        public byte AppearDuringWeatherHeavySnow
        {
            get => (byte)CellsByName["AppearDuringWeatherHeavySnow"].Value;
            set => CellsByName["AppearDuringWeatherHeavySnow"].Value = value;
        }


        // Def="u8 weatherFog:1 = 1"
        /// <summary>
        /// Appear during Weather: Fog (u8)
        /// </summary>
        /// <remarks>
        /// Will it appear when the weather is "fog"?
        /// </remarks>
        public byte AppearDuringWeatherFog
        {
            get => (byte)CellsByName["AppearDuringWeatherFog"].Value;
            set => CellsByName["AppearDuringWeatherFog"].Value = value;
        }


        // Def="u8 weatherHeavyFog:1 = 1"
        /// <summary>
        /// Appear during Weather: Heavy Fog (u8)
        /// </summary>
        /// <remarks>
        /// Will it appear when the weather is "dense fog"?
        /// </remarks>
        public byte AppearDuringWeatherHeavyFog
        {
            get => (byte)CellsByName["AppearDuringWeatherHeavyFog"].Value;
            set => CellsByName["AppearDuringWeatherHeavyFog"].Value = value;
        }


        // Def="u8 weatherHeavyFogRain:1 = 1"
        /// <summary>
        /// Appear during Weather: Heavy Fog and Rain (u8)
        /// </summary>
        /// <remarks>
        /// Does it appear when the weather is "dense fog (rain)"?
        /// </remarks>
        public byte AppearDuringWeatherHeavyFogAndRain
        {
            get => (byte)CellsByName["AppearDuringWeatherHeavyFogAndRain"].Value;
            set => CellsByName["AppearDuringWeatherHeavyFogAndRain"].Value = value;
        }


        // Def="u8 weatherSandStorm:1 = 1"
        /// <summary>
        /// Appear during Weather: Sandstorm (u8)
        /// </summary>
        /// <remarks>
        /// Will it appear when the weather is a "sandstorm"?
        /// </remarks>
        public byte AppearDuringWeatherSandstorm
        {
            get => (byte)CellsByName["AppearDuringWeatherSandstorm"].Value;
            set => CellsByName["AppearDuringWeatherSandstorm"].Value = value;
        }


        // Def="dummy8 pad1:2"
        /// <summary>
        /// pad (dummy8)
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        public object Pad
        {
            get => (object)CellsByName["Pad"].Value;
            set => CellsByName["Pad"].Value = value;
        }


        // Def="u8 timeStartHour"
        /// <summary>
        /// Time: Start Hour (u8)
        /// </summary>
        /// <remarks>
        /// Appearance start in game time_hour
        /// </remarks>
        public byte TimeStartHour
        {
            get => (byte)CellsByName["TimeStartHour"].Value;
            set => CellsByName["TimeStartHour"].Value = value;
        }


        // Def="u8 timeStartMin"
        /// <summary>
        /// Time: Start Minute (u8)
        /// </summary>
        /// <remarks>
        /// Appearance start in-game time_minutes
        /// </remarks>
        public byte TimeStartMinute
        {
            get => (byte)CellsByName["TimeStartMinute"].Value;
            set => CellsByName["TimeStartMinute"].Value = value;
        }


        // Def="u8 timeEndHour"
        /// <summary>
        /// Time: End Hour (u8)
        /// </summary>
        /// <remarks>
        /// Appearance end in game time_hour
        /// </remarks>
        public byte TimeEndHour
        {
            get => (byte)CellsByName["TimeEndHour"].Value;
            set => CellsByName["TimeEndHour"].Value = value;
        }


        // Def="u8 timeEndMin"
        /// <summary>
        /// Time: End Minute (u8)
        /// </summary>
        /// <remarks>
        /// End of appearance In-game time_minutes
        /// </remarks>
        public byte TimeEndMinute
        {
            get => (byte)CellsByName["TimeEndMinute"].Value;
            set => CellsByName["TimeEndMinute"].Value = value;
        }


    }
}

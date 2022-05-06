
            namespace StronglyTypedParams
            {
                public class CutsceneWeatherOverrideGparamIdConvertParam : ParamRow
                {
                    public CutsceneWeatherOverrideGparamIdConvertParam() : base()
                    {
                    }
            

            // Def="u32 weatherOverrideGparamId"
            /// <summary>
            /// Weather Override GPARAM ID (u32)
            /// </summary>
            /// <remarks>
            /// The ID of the ?? part of s00_00_0000_WeatherOverride_ ??. Gparam
            /// </remarks>
            public uint WeatherOverrideGPARAMID 
            {
                get => (uint)CellsByName["WeatherOverrideGPARAMID"].Value;
                set => CellsByName["WeatherOverrideGPARAMID"].Value = value;
            }
            
                }
            }
            

            namespace StronglyTypedParams
            {
                public class CutsceneTimezoneConvertParam : ParamRow
                {
                    public CutsceneTimezoneConvertParam() : base()
                    {
                    }
            

            // Def="f32 SrcTimezoneStart"
            /// <summary>
            /// Source - Timezone Start (f32)
            /// </summary>
            /// <remarks>
            /// Start time of the time zone to be converted to cutscene time [hour]
            /// </remarks>
            public float SourceTimezoneStart 
            {
                get => (float)CellsByName["SourceTimezoneStart"].Value;
                set => CellsByName["SourceTimezoneStart"].Value = value;
            }
            

            // Def="f32 DstCutscenTime"
            /// <summary>
            /// Destination - Cutscene Time (f32)
            /// </summary>
            /// <remarks>
            /// Enter the time used during cutscene playback in hours [hour]
            /// </remarks>
            public float DestinationCutsceneTime 
            {
                get => (float)CellsByName["DestinationCutsceneTime"].Value;
                set => CellsByName["DestinationCutsceneTime"].Value = value;
            }
            
                }
            }
            
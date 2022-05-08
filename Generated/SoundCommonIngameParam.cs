
            namespace StronglyTypedParams
            {
                // SOUND_COMMON_INGAME_PARAM_ST
                public class SoundCommonIngameParam : ParamRow
                {
                    public SoundCommonIngameParam() : base()
                    {
                    }
            

            // Def="fixstr ParamKeyStr[32]"
            /// <summary>
            /// Param Key (fixstr)
            /// </summary>
            /// <remarks>
            /// Key string of the parameter
            /// </remarks>
            public object ParamKey 
            {
                get => (object)CellsByName["ParamKey"].Value;
                set => CellsByName["ParamKey"].Value = (object)value;
            }
            

            // Def="fixstr ParamValueStr[32]"
            /// <summary>
            /// Param Value (fixstr)
            /// </summary>
            /// <remarks>
            /// Value string of the parameter
            /// </remarks>
            public object ParamValue 
            {
                get => (object)CellsByName["ParamValue"].Value;
                set => CellsByName["ParamValue"].Value = (object)value;
            }
            
                }
            }
            
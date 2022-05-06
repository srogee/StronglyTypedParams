
            namespace StronglyTypedParams
            {
                public class ReverbAuxSendBusParam : ParamRow
                {
                    public ReverbAuxSendBusParam() : base()
                    {
                    }
            

            // Def="fixstr ReverbAuxSendBusName[32]"
            /// <summary>
            /// Reverb Aux Send Bus Name (fixstr)
            /// </summary>
            /// <remarks>
            /// ReverbAuxSendBus name
            /// </remarks>
            public object ReverbAuxSendBusName 
            {
                get => (object)CellsByName["ReverbAuxSendBusName"].Value;
                set => CellsByName["ReverbAuxSendBusName"].Value = value;
            }
            
                }
            }
            
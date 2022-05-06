
            namespace StronglyTypedParams
            {
                public class MaterialEx : ParamRow
                {
                    public MaterialEx() : base()
                    {
                    }
            

            // Def="fixstrW paramName[32]"
            /// <summary>
            /// Material Param Name (fixstrW)
            /// </summary>
            /// <remarks>
            /// Set the parameter name of the material. Up to 31 characters
            /// </remarks>
            public object MaterialParamName 
            {
                get => (object)CellsByName["MaterialParamName"].Value;
                set => CellsByName["MaterialParamName"].Value = value;
            }
            

            // Def="s32 materialId = -1"
            /// <summary>
            /// Material ID (s32)
            /// </summary>
            /// <remarks>
            /// NPC Para: Resident Material Expansion Para ID setting -1 for all materials
            /// </remarks>
            public int MaterialID 
            {
                get => (int)CellsByName["MaterialID"].Value;
                set => CellsByName["MaterialID"].Value = value;
            }
            

            // Def="f32 materialParamValue0"
            /// <summary>
            /// Material Param Value: R (f32)
            /// </summary>
            /// <remarks>
            /// NPC Para: Resident Material Extended Para ID Settings
            /// </remarks>
            public float MaterialParamValueR 
            {
                get => (float)CellsByName["MaterialParamValueR"].Value;
                set => CellsByName["MaterialParamValueR"].Value = value;
            }
            

            // Def="f32 materialParamValue1"
            /// <summary>
            /// Material Param Value: G (f32)
            /// </summary>
            /// <remarks>
            /// NPC Para: Resident Material Expansion Para ID Settings
            /// </remarks>
            public float MaterialParamValueG 
            {
                get => (float)CellsByName["MaterialParamValueG"].Value;
                set => CellsByName["MaterialParamValueG"].Value = value;
            }
            

            // Def="f32 materialParamValue2"
            /// <summary>
            /// Material Param Value: B (f32)
            /// </summary>
            /// <remarks>
            /// NPC Para: Resident Material Expansion Para ID Settings
            /// </remarks>
            public float MaterialParamValueB 
            {
                get => (float)CellsByName["MaterialParamValueB"].Value;
                set => CellsByName["MaterialParamValueB"].Value = value;
            }
            

            // Def="f32 materialParamValue3"
            /// <summary>
            /// Material Param Value: A (f32)
            /// </summary>
            /// <remarks>
            /// NPC Para: Resident Material Extended Para ID Settings
            /// </remarks>
            public float MaterialParamValueA 
            {
                get => (float)CellsByName["MaterialParamValueA"].Value;
                set => CellsByName["MaterialParamValueA"].Value = value;
            }
            

            // Def="f32 materialParamValue4 = 1"
            /// <summary>
            /// Material Param Value: I (f32)
            /// </summary>
            /// <remarks>
            /// NPC Para: Resident Material Expansion Para ID Settings
            /// </remarks>
            public float MaterialParamValueI 
            {
                get => (float)CellsByName["MaterialParamValueI"].Value;
                set => CellsByName["MaterialParamValueI"].Value = value;
            }
            

            // Def="dummy8 pad[8]"
            /// <summary>
            /// Padding (dummy8)
            /// </summary>
            /// <remarks>
            /// Padding
            /// </remarks>
            public object Padding 
            {
                get => (object)CellsByName["Padding"].Value;
                set => CellsByName["Padding"].Value = value;
            }
            
                }
            }
            
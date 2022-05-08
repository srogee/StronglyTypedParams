
            namespace StronglyTypedParams
            {
                // MENU_PARAM_COLOR_TABLE_ST
                public class MenuParamColorTable : ParamRow
                {
                    public MenuParamColorTable() : base()
                    {
                    }
            

            // Def="u8 lerpMode"
            /// <summary>
            /// Lerp Mode (u8)
            /// </summary>
            /// <remarks>
            /// Interpolation method
            /// </remarks>
            public MenuColorLerpMode LerpMode 
            {
                get => (MenuColorLerpMode)CellsByName["LerpMode"].Value;
                set => CellsByName["LerpMode"].Value = (byte)value;
            }
            

            // Def="dummy8 pad1[3]"
            /// <summary>
            /// pad (dummy8)
            /// </summary>
            /// <remarks>
            /// 
            /// </remarks>
            public object Pad 
            {
                get => (object)CellsByName["Pad"].Value;
                set => CellsByName["Pad"].Value = (object)value;
            }
            

            // Def="u16 h"
            /// <summary>
            /// Hue (u16)
            /// </summary>
            /// <remarks>
            /// Hue. Treat as a fixed value in interpolation
            /// </remarks>
            public ushort Hue 
            {
                get => (ushort)CellsByName["Hue"].Value;
                set => CellsByName["Hue"].Value = (ushort)value;
            }
            


            // Def="f32 s1 = 1"
            /// <summary>
            /// Saturation [1] (f32)
            /// </summary>
            /// <remarks>
            /// Saturation 1. Treated as the first point of interpolation
            /// </remarks>
            public float Saturation1 
            {
                get => (float)CellsByName["Saturation1"].Value;
                set => CellsByName["Saturation1"].Value = (float)value;
            }
            

            // Def="f32 v1 = 1"
            /// <summary>
            /// Brightness [1] (f32)
            /// </summary>
            /// <remarks>
            /// Brightness 1. Treated as the first point of interpolation
            /// </remarks>
            public float Brightness1 
            {
                get => (float)CellsByName["Brightness1"].Value;
                set => CellsByName["Brightness1"].Value = (float)value;
            }
            

            // Def="f32 s2 = 1"
            /// <summary>
            /// Saturation [2] (f32)
            /// </summary>
            /// <remarks>
            /// Saturation 2. Treated as the second point of interpolation
            /// </remarks>
            public float Saturation2 
            {
                get => (float)CellsByName["Saturation2"].Value;
                set => CellsByName["Saturation2"].Value = (float)value;
            }
            

            // Def="f32 v2 = 1"
            /// <summary>
            /// Brightness [2] (f32)
            /// </summary>
            /// <remarks>
            /// Brightness 2. Treated as the second point of interpolation
            /// </remarks>
            public float Brightness2 
            {
                get => (float)CellsByName["Brightness2"].Value;
                set => CellsByName["Brightness2"].Value = (float)value;
            }
            

            // Def="f32 s3 = 1"
            /// <summary>
            /// Saturation [3] (f32)
            /// </summary>
            /// <remarks>
            /// Saturation 3. Treated as the third point of interpolation
            /// </remarks>
            public float Saturation3 
            {
                get => (float)CellsByName["Saturation3"].Value;
                set => CellsByName["Saturation3"].Value = (float)value;
            }
            

            // Def="f32 v3 = 1"
            /// <summary>
            /// Brightness [3] (f32)
            /// </summary>
            /// <remarks>
            /// Brightness 3. Treated as the third point of interpolation
            /// </remarks>
            public float Brightness3 
            {
                get => (float)CellsByName["Brightness3"].Value;
                set => CellsByName["Brightness3"].Value = (float)value;
            }
            
                }
            }
            
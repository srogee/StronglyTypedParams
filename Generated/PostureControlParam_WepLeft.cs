
            namespace StronglyTypedParams
            {
                // POSTURE_CONTROL_PARAM_WEP_LEFT_ST
                public class PostureControlParam_WepLeft : ParamRow
                {
                    public PostureControlParam_WepLeft() : base()
                    {
                    }
            

            // Def="s16 a000_leftArmFB"
            /// <summary>
            /// [a000] Left Arm - Front/Back (s16)
            /// </summary>
            /// <remarks>
            /// Left arm_front and back
            /// </remarks>
            public short A000LeftArmFrontBack 
            {
                get => (short)CellsByName["A000LeftArmFrontBack"].Value;
                set => CellsByName["A000LeftArmFrontBack"].Value = (short)value;
            }
            

            // Def="s16 a000_leftWristFB"
            /// <summary>
            /// [a000] Left Wrist - Front/Back (s16)
            /// </summary>
            /// <remarks>
            /// Left wrist_front and back
            /// </remarks>
            public short A000LeftWristFrontBack 
            {
                get => (short)CellsByName["A000LeftWristFrontBack"].Value;
                set => CellsByName["A000LeftWristFrontBack"].Value = (short)value;
            }
            

            // Def="s16 a000_leftWristIO"
            /// <summary>
            /// [a000] Left Wrist - Inside/Outside (s16)
            /// </summary>
            /// <remarks>
            /// Left wrist_inside and outside
            /// </remarks>
            public short A000LeftWristInsideOutside 
            {
                get => (short)CellsByName["A000LeftWristInsideOutside"].Value;
                set => CellsByName["A000LeftWristInsideOutside"].Value = (short)value;
            }
            

            // Def="s16 a002_leftArmFB"
            /// <summary>
            /// [a002] Left Arm - Front/Back (s16)
            /// </summary>
            /// <remarks>
            /// Left arm_front and back
            /// </remarks>
            public short A002LeftArmFrontBack 
            {
                get => (short)CellsByName["A002LeftArmFrontBack"].Value;
                set => CellsByName["A002LeftArmFrontBack"].Value = (short)value;
            }
            

            // Def="s16 a002_leftWristFB"
            /// <summary>
            /// [a002] Left Wrist - Front/Back (s16)
            /// </summary>
            /// <remarks>
            /// Left wrist_front and back
            /// </remarks>
            public short A002LeftWristFrontBack 
            {
                get => (short)CellsByName["A002LeftWristFrontBack"].Value;
                set => CellsByName["A002LeftWristFrontBack"].Value = (short)value;
            }
            

            // Def="s16 a002_leftWristIO"
            /// <summary>
            /// [a002] Left Wrist - Inside/Outside (s16)
            /// </summary>
            /// <remarks>
            /// Left wrist_inside and outside
            /// </remarks>
            public short A002LeftWristInsideOutside 
            {
                get => (short)CellsByName["A002LeftWristInsideOutside"].Value;
                set => CellsByName["A002LeftWristInsideOutside"].Value = (short)value;
            }
            

            // Def="s16 a003_leftArmFB"
            /// <summary>
            /// [a003] Left Arm - Front/Back (s16)
            /// </summary>
            /// <remarks>
            /// Left arm_front and back
            /// </remarks>
            public short A003LeftArmFrontBack 
            {
                get => (short)CellsByName["A003LeftArmFrontBack"].Value;
                set => CellsByName["A003LeftArmFrontBack"].Value = (short)value;
            }
            

            // Def="s16 a003_leftWristFB"
            /// <summary>
            /// [a003] Left Wrist - Front/Back (s16)
            /// </summary>
            /// <remarks>
            /// Left wrist_front and back
            /// </remarks>
            public short A003LeftWristFrontBack 
            {
                get => (short)CellsByName["A003LeftWristFrontBack"].Value;
                set => CellsByName["A003LeftWristFrontBack"].Value = (short)value;
            }
            

            // Def="s16 a003_leftWristIO"
            /// <summary>
            /// [a003] Left Wrist - Inside/Outside (s16)
            /// </summary>
            /// <remarks>
            /// Left wrist_inside and outside
            /// </remarks>
            public short A003LeftWristInsideOutside 
            {
                get => (short)CellsByName["A003LeftWristInsideOutside"].Value;
                set => CellsByName["A003LeftWristInsideOutside"].Value = (short)value;
            }
            

            // Def="dummy8 pad[14]"
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
            
                }
            }
            
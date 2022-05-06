
            namespace StronglyTypedParams
            {
                public class RuntimeBoneControlParam : ParamRow
                {
                    public RuntimeBoneControlParam() : base()
                    {
                    }
            

            // Def="u32 chrId"
            /// <summary>
            /// Character ID (u32)
            /// </summary>
            /// <remarks>
            /// Character ID
            /// </remarks>
            public uint CharacterID 
            {
                get => (uint)CellsByName["CharacterID"].Value;
                set => CellsByName["CharacterID"].Value = value;
            }
            

            // Def="u8 ctrlType"
            /// <summary>
            /// Bone Control Type (u8)
            /// </summary>
            /// <remarks>
            /// Control type
            /// </remarks>
            public byte BoneControlType 
            {
                get => (byte)CellsByName["BoneControlType"].Value;
                set => CellsByName["BoneControlType"].Value = value;
            }
            

            // Def="dummy8 pad[11]"
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
            

            // Def="fixstr applyBone[32]"
            /// <summary>
            /// Applicable Joint (fixstr)
            /// </summary>
            /// <remarks>
            /// Applicable joint
            /// </remarks>
            public object ApplicableJoint 
            {
                get => (object)CellsByName["ApplicableJoint"].Value;
                set => CellsByName["ApplicableJoint"].Value = value;
            }
            

            // Def="fixstr targetBone1[32]"
            /// <summary>
            /// Target Joint [1] (fixstr)
            /// </summary>
            /// <remarks>
            /// Target joint 1
            /// </remarks>
            public object TargetJoint1 
            {
                get => (object)CellsByName["TargetJoint1"].Value;
                set => CellsByName["TargetJoint1"].Value = value;
            }
            

            // Def="fixstr targetBone2[32]"
            /// <summary>
            /// Target Joint [2] (fixstr)
            /// </summary>
            /// <remarks>
            /// Target joint 2
            /// </remarks>
            public object TargetJoint2 
            {
                get => (object)CellsByName["TargetJoint2"].Value;
                set => CellsByName["TargetJoint2"].Value = value;
            }
            
                }
            }
            
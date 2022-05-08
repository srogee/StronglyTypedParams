
            namespace StronglyTypedParams
            {
                // SOUND_CHR_PHYSICS_SE_PARAM_ST
                public class SoundChrPhysicsSeParam : ParamRow
                {
                    public SoundChrPhysicsSeParam() : base()
                    {
                    }
            

            // Def="u8 disableParam_NT:1"
            /// <summary>
            /// Disable Param - Network Test (u8)
            /// </summary>
            /// <remarks>
            /// Parameters marked with ○ are excluded in the NT version package.
            /// </remarks>
            public BoolCirclecrossType DisableParamNetworkTest 
            {
                get => (BoolCirclecrossType)CellsByName["DisableParamNetworkTest"].Value;
                set => CellsByName["DisableParamNetworkTest"].Value = (byte)value;
            }
            

            // Def="dummy8 disableParamReserve1:7"
            /// <summary>
            /// Reserve for package output 1 (dummy8)
            /// </summary>
            /// <remarks>
            /// Reserve for package output 1
            /// </remarks>
            public object ReserveForPackageOutput1 
            {
                get => (object)CellsByName["ReserveForPackageOutput1"].Value;
                set => CellsByName["ReserveForPackageOutput1"].Value = (object)value;
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
                set => CellsByName["ReserveForPackageOutput2"].Value = (object)value;
            }
            

            // Def="s32 ContactLandSeId = -1"
            /// <summary>
            /// Contact Land on Death - SE ID (s32)
            /// </summary>
            /// <remarks>
            /// SEID pronounced when contacting the ground after death. (-1: Invalid). SEID category is fixed to c
            /// </remarks>
            public int ContactLandOnDeathSEID 
            {
                get => (int)CellsByName["ContactLandOnDeathSEID"].Value;
                set => CellsByName["ContactLandOnDeathSEID"].Value = (int)value;
            }
            

            // Def="s32 ContactLandAddSeId = -1"
            /// <summary>
            /// Contact Land on Death - Additional SE ID (s32)
            /// </summary>
            /// <remarks>
            /// Additional SEID (for material) that sounds when it comes into contact with the ground after death. (-1: Invalid). SEID category is fixed to c
            /// </remarks>
            public int ContactLandOnDeathAdditionalSEID 
            {
                get => (int)CellsByName["ContactLandOnDeathAdditionalSEID"].Value;
                set => CellsByName["ContactLandOnDeathAdditionalSEID"].Value = (int)value;
            }
            

            // Def="s32 ContactLandPlayNum = 1"
            /// <summary>
            /// Contact Land on Death - Play Count (s32)
            /// </summary>
            /// <remarks>
            /// Number of pronunciations when touching the ground after death
            /// </remarks>
            public int ContactLandOnDeathPlayCount 
            {
                get => (int)CellsByName["ContactLandOnDeathPlayCount"].Value;
                set => CellsByName["ContactLandOnDeathPlayCount"].Value = (int)value;
            }
            

            // Def="u8 IsEnablePlayCountPerRigid"
            /// <summary>
            /// Enable Play Count per Rigid Body Unit (u8)
            /// </summary>
            /// <remarks>
            /// Do you count the number of pronunciations of surface contact after death in rigid body units? (○: Rigid body unit, ×: Character unit)
            /// </remarks>
            public BoolCirclecrossType EnablePlayCountPerRigidBodyUnit 
            {
                get => (BoolCirclecrossType)CellsByName["EnablePlayCountPerRigidBodyUnit"].Value;
                set => CellsByName["EnablePlayCountPerRigidBodyUnit"].Value = (byte)value;
            }
            

            // Def="dummy8 pad[3]"
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
            

            // Def="f32 ContactLandMinImpuse = 20"
            /// <summary>
            /// Contact Land on Death - Min Impulse (f32)
            /// </summary>
            /// <remarks>
            /// Minimum impulse value required for ground contact determination after death
            /// </remarks>
            public float ContactLandOnDeathMinImpulse 
            {
                get => (float)CellsByName["ContactLandOnDeathMinImpulse"].Value;
                set => CellsByName["ContactLandOnDeathMinImpulse"].Value = (float)value;
            }
            

            // Def="f32 ContactLandMinSpeed"
            /// <summary>
            /// Contact Land on Death - Min Speed (f32)
            /// </summary>
            /// <remarks>
            /// Minimum speed value required for ground contact determination after death
            /// </remarks>
            public float ContactLandOnDeathMinSpeed 
            {
                get => (float)CellsByName["ContactLandOnDeathMinSpeed"].Value;
                set => CellsByName["ContactLandOnDeathMinSpeed"].Value = (float)value;
            }
            

            // Def="s32 ContactPlayerSeId = -1"
            /// <summary>
            /// Contact Player on Death - SE ID (s32)
            /// </summary>
            /// <remarks>
            /// SEID that sounds when you come into contact with Player after death. (-1: Invalid). SEID category is fixed to c
            /// </remarks>
            public int ContactPlayerOnDeathSEID 
            {
                get => (int)CellsByName["ContactPlayerOnDeathSEID"].Value;
                set => CellsByName["ContactPlayerOnDeathSEID"].Value = (int)value;
            }
            

            // Def="f32 ContactPlayerMinImpuse = 20"
            /// <summary>
            /// Contact Player on Death - Min Impulse (f32)
            /// </summary>
            /// <remarks>
            /// Minimum impulse value required for Player contact judgment after death
            /// </remarks>
            public float ContactPlayerOnDeathMinImpulse 
            {
                get => (float)CellsByName["ContactPlayerOnDeathMinImpulse"].Value;
                set => CellsByName["ContactPlayerOnDeathMinImpulse"].Value = (float)value;
            }
            

            // Def="f32 ContactPlayerMinSpeed"
            /// <summary>
            /// Contact Player on Death - Min Speed (f32)
            /// </summary>
            /// <remarks>
            /// Minimum speed value required for Player contact judgment after death
            /// </remarks>
            public float ContactPlayerOnDeathMinSpeed 
            {
                get => (float)CellsByName["ContactPlayerOnDeathMinSpeed"].Value;
                set => CellsByName["ContactPlayerOnDeathMinSpeed"].Value = (float)value;
            }
            

            // Def="s8 ContactCheckRigidIdx0 = -1"
            /// <summary>
            /// Contact Check Rigid Index [0] (s8)
            /// </summary>
            /// <remarks>
            /// Specify the INDEX of the rigid body for contact judgment. Specify only the rigid body to which you want to attach SE
            /// </remarks>
            public sbyte ContactCheckRigidIndex0 
            {
                get => (sbyte)CellsByName["ContactCheckRigidIndex0"].Value;
                set => CellsByName["ContactCheckRigidIndex0"].Value = (sbyte)value;
            }
            

            // Def="s8 ContactCheckRigidIdx1 = -1"
            /// <summary>
            /// Contact Check Rigid Index [1] (s8)
            /// </summary>
            /// <remarks>
            /// Specify the INDEX of the rigid body for contact judgment. Specify only the rigid body to which you want to attach SE
            /// </remarks>
            public sbyte ContactCheckRigidIndex1 
            {
                get => (sbyte)CellsByName["ContactCheckRigidIndex1"].Value;
                set => CellsByName["ContactCheckRigidIndex1"].Value = (sbyte)value;
            }
            

            // Def="s8 ContactCheckRigidIdx2 = -1"
            /// <summary>
            /// Contact Check Rigid Index [2] (s8)
            /// </summary>
            /// <remarks>
            /// Specify the INDEX of the rigid body for contact judgment. Specify only the rigid body to which you want to attach SE
            /// </remarks>
            public sbyte ContactCheckRigidIndex2 
            {
                get => (sbyte)CellsByName["ContactCheckRigidIndex2"].Value;
                set => CellsByName["ContactCheckRigidIndex2"].Value = (sbyte)value;
            }
            

            // Def="s8 ContactCheckRigidIdx3 = -1"
            /// <summary>
            /// Contact Check Rigid Index [3] (s8)
            /// </summary>
            /// <remarks>
            /// Specify the INDEX of the rigid body for contact judgment. Specify only the rigid body to which you want to attach SE
            /// </remarks>
            public sbyte ContactCheckRigidIndex3 
            {
                get => (sbyte)CellsByName["ContactCheckRigidIndex3"].Value;
                set => CellsByName["ContactCheckRigidIndex3"].Value = (sbyte)value;
            }
            

            // Def="s8 ContactCheckRigidIdx4 = -1"
            /// <summary>
            /// Contact Check Rigid Index [4] (s8)
            /// </summary>
            /// <remarks>
            /// Specify the INDEX of the rigid body for contact judgment. Specify only the rigid body to which you want to attach SE
            /// </remarks>
            public sbyte ContactCheckRigidIndex4 
            {
                get => (sbyte)CellsByName["ContactCheckRigidIndex4"].Value;
                set => CellsByName["ContactCheckRigidIndex4"].Value = (sbyte)value;
            }
            

            // Def="s8 ContactCheckRigidIdx5 = -1"
            /// <summary>
            /// Contact Check Rigid Index [5] (s8)
            /// </summary>
            /// <remarks>
            /// Specify the INDEX of the rigid body for contact judgment. Specify only the rigid body to which you want to attach SE
            /// </remarks>
            public sbyte ContactCheckRigidIndex5 
            {
                get => (sbyte)CellsByName["ContactCheckRigidIndex5"].Value;
                set => CellsByName["ContactCheckRigidIndex5"].Value = (sbyte)value;
            }
            

            // Def="s8 ContactCheckRigidIdx6 = -1"
            /// <summary>
            /// Contact Check Rigid Index [6] (s8)
            /// </summary>
            /// <remarks>
            /// Specify the INDEX of the rigid body for contact judgment. Specify only the rigid body to which you want to attach SE
            /// </remarks>
            public sbyte ContactCheckRigidIndex6 
            {
                get => (sbyte)CellsByName["ContactCheckRigidIndex6"].Value;
                set => CellsByName["ContactCheckRigidIndex6"].Value = (sbyte)value;
            }
            

            // Def="s8 ContactCheckRigidIdx7 = -1"
            /// <summary>
            /// Contact Check Rigid Index [7] (s8)
            /// </summary>
            /// <remarks>
            /// Specify the INDEX of the rigid body for contact judgment. Specify only the rigid body to which you want to attach SE
            /// </remarks>
            public sbyte ContactCheckRigidIndex7 
            {
                get => (sbyte)CellsByName["ContactCheckRigidIndex7"].Value;
                set => CellsByName["ContactCheckRigidIndex7"].Value = (sbyte)value;
            }
            

            // Def="s8 ContactCheckRigidIdx8 = -1"
            /// <summary>
            /// Contact Check Rigid Index [8] (s8)
            /// </summary>
            /// <remarks>
            /// Specify the INDEX of the rigid body for contact judgment. Specify only the rigid body to which you want to attach SE
            /// </remarks>
            public sbyte ContactCheckRigidIndex8 
            {
                get => (sbyte)CellsByName["ContactCheckRigidIndex8"].Value;
                set => CellsByName["ContactCheckRigidIndex8"].Value = (sbyte)value;
            }
            

            // Def="s8 ContactCheckRigidIdx9 = -1"
            /// <summary>
            /// Contact Check Rigid Index [9] (s8)
            /// </summary>
            /// <remarks>
            /// Specify the INDEX of the rigid body for contact judgment. Specify only the rigid body to which you want to attach SE
            /// </remarks>
            public sbyte ContactCheckRigidIndex9 
            {
                get => (sbyte)CellsByName["ContactCheckRigidIndex9"].Value;
                set => CellsByName["ContactCheckRigidIndex9"].Value = (sbyte)value;
            }
            

            // Def="s8 ContactCheckRigidIdx10 = -1"
            /// <summary>
            /// Contact Check Rigid Index [10] (s8)
            /// </summary>
            /// <remarks>
            /// Specify the INDEX of the rigid body for contact judgment. Specify only the rigid body to which you want to attach SE
            /// </remarks>
            public sbyte ContactCheckRigidIndex10 
            {
                get => (sbyte)CellsByName["ContactCheckRigidIndex10"].Value;
                set => CellsByName["ContactCheckRigidIndex10"].Value = (sbyte)value;
            }
            

            // Def="s8 ContactCheckRigidIdx11 = -1"
            /// <summary>
            /// Contact Check Rigid Index [11] (s8)
            /// </summary>
            /// <remarks>
            /// Specify the INDEX of the rigid body for contact judgment. Specify only the rigid body to which you want to attach SE
            /// </remarks>
            public sbyte ContactCheckRigidIndex11 
            {
                get => (sbyte)CellsByName["ContactCheckRigidIndex11"].Value;
                set => CellsByName["ContactCheckRigidIndex11"].Value = (sbyte)value;
            }
            

            // Def="s8 ContactCheckRigidIdx12 = -1"
            /// <summary>
            /// Contact Check Rigid Index [12] (s8)
            /// </summary>
            /// <remarks>
            /// Specify the INDEX of the rigid body for contact judgment. Specify only the rigid body to which you want to attach SE
            /// </remarks>
            public sbyte ContactCheckRigidIndex12 
            {
                get => (sbyte)CellsByName["ContactCheckRigidIndex12"].Value;
                set => CellsByName["ContactCheckRigidIndex12"].Value = (sbyte)value;
            }
            

            // Def="s8 ContactCheckRigidIdx13 = -1"
            /// <summary>
            /// Contact Check Rigid Index [13] (s8)
            /// </summary>
            /// <remarks>
            /// Specify the INDEX of the rigid body for contact judgment. Specify only the rigid body to which you want to attach SE
            /// </remarks>
            public sbyte ContactCheckRigidIndex13 
            {
                get => (sbyte)CellsByName["ContactCheckRigidIndex13"].Value;
                set => CellsByName["ContactCheckRigidIndex13"].Value = (sbyte)value;
            }
            

            // Def="s8 ContactCheckRigidIdx14 = -1"
            /// <summary>
            /// Contact Check Rigid Index [14] (s8)
            /// </summary>
            /// <remarks>
            /// Specify the INDEX of the rigid body for contact judgment. Specify only the rigid body to which you want to attach SE
            /// </remarks>
            public sbyte ContactCheckRigidIndex14 
            {
                get => (sbyte)CellsByName["ContactCheckRigidIndex14"].Value;
                set => CellsByName["ContactCheckRigidIndex14"].Value = (sbyte)value;
            }
            

            // Def="s8 ContactCheckRigidIdx15 = -1"
            /// <summary>
            /// Contact Check Rigid Index [15] (s8)
            /// </summary>
            /// <remarks>
            /// Specify the INDEX of the rigid body for contact judgment. Specify only the rigid body to which you want to attach SE
            /// </remarks>
            public sbyte ContactCheckRigidIndex15 
            {
                get => (sbyte)CellsByName["ContactCheckRigidIndex15"].Value;
                set => CellsByName["ContactCheckRigidIndex15"].Value = (sbyte)value;
            }
            
                }
            }
            
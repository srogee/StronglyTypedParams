
            namespace StronglyTypedParams
            {
                // AI_ATTACK_PARAM_ST
                public class AIAttackParam : ParamRow
                {
                    public AIAttackParam() : base()
                    {
                    }
            

            // Def="s32 attackTableId"
            /// <summary>
            /// Reference ID (s32)
            /// </summary>
            /// <remarks>
            /// ID specified by NPC thinking parameters
            /// </remarks>
            public int ReferenceID 
            {
                get => (int)CellsByName["ReferenceID"].Value;
                set => CellsByName["ReferenceID"].Value = (int)value;
            }
            

            // Def="s32 attackId"
            /// <summary>
            /// Attack ID (s32)
            /// </summary>
            /// <remarks>
            /// Attack number
            /// </remarks>
            public int AttackID 
            {
                get => (int)CellsByName["AttackID"].Value;
                set => CellsByName["AttackID"].Value = (int)value;
            }
            

            // Def="f32 successDistance"
            /// <summary>
            /// Success judgment distance (f32)
            /// </summary>
            /// <remarks>
            /// For arguments of Common_Attack type subgoals
            /// </remarks>
            public float SuccessJudgmentDistance 
            {
                get => (float)CellsByName["SuccessJudgmentDistance"].Value;
                set => CellsByName["SuccessJudgmentDistance"].Value = (float)value;
            }
            

            // Def="f32 turnTimeBeforeAttack"
            /// <summary>
            /// Turn time before attack (f32)
            /// </summary>
            /// <remarks>
            /// For arguments of Common_Attack type subgoals
            /// </remarks>
            public float TurnTimeBeforeAttack 
            {
                get => (float)CellsByName["TurnTimeBeforeAttack"].Value;
                set => CellsByName["TurnTimeBeforeAttack"].Value = (float)value;
            }
            

            // Def="s16 frontAngleRange"
            /// <summary>
            /// Front judgment angle (s16)
            /// </summary>
            /// <remarks>
            /// For arguments of Common_Attack type subgoals
            /// </remarks>
            public short FrontJudgmentAngle 
            {
                get => (short)CellsByName["FrontJudgmentAngle"].Value;
                set => CellsByName["FrontJudgmentAngle"].Value = (short)value;
            }
            

            // Def="s16 upAngleThreshold"
            /// <summary>
            /// Upward execution threshold (s16)
            /// </summary>
            /// <remarks>
            /// For arguments of Common_Attack type subgoals
            /// </remarks>
            public short UpwardExecutionThreshold 
            {
                get => (short)CellsByName["UpwardExecutionThreshold"].Value;
                set => CellsByName["UpwardExecutionThreshold"].Value = (short)value;
            }
            

            // Def="s16 downAngleThershold"
            /// <summary>
            /// Downward execution threshold (s16)
            /// </summary>
            /// <remarks>
            /// For arguments of Common_Attack type subgoals
            /// </remarks>
            public short DownwardExecutionThreshold 
            {
                get => (short)CellsByName["DownwardExecutionThreshold"].Value;
                set => CellsByName["DownwardExecutionThreshold"].Value = (short)value;
            }
            

            // Def="u8 isFirstAttack"
            /// <summary>
            /// Is it a starting technique? (u8)
            /// </summary>
            /// <remarks>
            /// Attacks from the second stage of the combo are ×
            /// </remarks>
            public byte IsItAStartingTechnique 
            {
                get => (byte)CellsByName["IsItAStartingTechnique"].Value;
                set => CellsByName["IsItAStartingTechnique"].Value = (byte)value;
            }
            

            // Def="u8 doesSelectOnOutRange"
            /// <summary>
            /// Whether to select outside the proper distance (u8)
            /// </summary>
            /// <remarks>
            /// Whether to select when the distance is out of the proper distance
            /// </remarks>
            public byte WhetherToSelectOutsideTheProperDistance 
            {
                get => (byte)CellsByName["WhetherToSelectOutsideTheProperDistance"].Value;
                set => CellsByName["WhetherToSelectOutsideTheProperDistance"].Value = (byte)value;
            }
            

            // Def="f32 minOptimalDistance"
            /// <summary>
            /// Minimum proper distance (f32)
            /// </summary>
            /// <remarks>
            /// Minimum value of proper attack distance
            /// </remarks>
            public float MinimumProperDistance 
            {
                get => (float)CellsByName["MinimumProperDistance"].Value;
                set => CellsByName["MinimumProperDistance"].Value = (float)value;
            }
            

            // Def="f32 maxOptimalDistance"
            /// <summary>
            /// Maximum proper distance (f32)
            /// </summary>
            /// <remarks>
            /// Maximum attack suitability distance
            /// </remarks>
            public float MaximumProperDistance 
            {
                get => (float)CellsByName["MaximumProperDistance"].Value;
                set => CellsByName["MaximumProperDistance"].Value = (float)value;
            }
            

            // Def="s16 baseDirectionForOptimalAngle1"
            /// <summary>
            /// Appropriate angle reference direction 1 (s16)
            /// </summary>
            /// <remarks>
            /// Direction that serves as a reference for the proper angle of attack (XZ plane)
            /// </remarks>
            public short AppropriateAngleReferenceDirection1 
            {
                get => (short)CellsByName["AppropriateAngleReferenceDirection1"].Value;
                set => CellsByName["AppropriateAngleReferenceDirection1"].Value = (short)value;
            }
            

            // Def="s16 optimalAttackAngleRange1"
            /// <summary>
            /// Appropriate angle reference range 1 (s16)
            /// </summary>
            /// <remarks>
            /// Range of aptitude angles for attacks
            /// </remarks>
            public short AppropriateAngleReferenceRange1 
            {
                get => (short)CellsByName["AppropriateAngleReferenceRange1"].Value;
                set => CellsByName["AppropriateAngleReferenceRange1"].Value = (short)value;
            }
            

            // Def="s16 baseDirectionForOptimalAngle2"
            /// <summary>
            /// Appropriate angle reference direction 2 (s16)
            /// </summary>
            /// <remarks>
            /// Direction that serves as a reference for attack aptitude accuracy (XZ plane)
            /// </remarks>
            public short AppropriateAngleReferenceDirection2 
            {
                get => (short)CellsByName["AppropriateAngleReferenceDirection2"].Value;
                set => CellsByName["AppropriateAngleReferenceDirection2"].Value = (short)value;
            }
            

            // Def="s16 optimalAttackAngleRange2"
            /// <summary>
            /// Appropriate angle reference range 2 (s16)
            /// </summary>
            /// <remarks>
            /// Range of aptitude angles for attacks
            /// </remarks>
            public short AppropriateAngleReferenceRange2 
            {
                get => (short)CellsByName["AppropriateAngleReferenceRange2"].Value;
                set => CellsByName["AppropriateAngleReferenceRange2"].Value = (short)value;
            }
            

            // Def="f32 intervalForExec = 1"
            /// <summary>
            /// Executable interval (f32)
            /// </summary>
            /// <remarks>
            /// Time required to attack once and then use it again
            /// </remarks>
            public float ExecutableInterval 
            {
                get => (float)CellsByName["ExecutableInterval"].Value;
                set => CellsByName["ExecutableInterval"].Value = (float)value;
            }
            

            // Def="f32 selectionTendency = -1"
            /// <summary>
            /// Selection rate (f32)
            /// </summary>
            /// <remarks>
            /// Specify the ease of selection by magnification
            /// </remarks>
            public float SelectionRate 
            {
                get => (float)CellsByName["SelectionRate"].Value;
                set => CellsByName["SelectionRate"].Value = (float)value;
            }
            

            // Def="f32 shortRangeTendency = -1"
            /// <summary>
            /// Short range selection rate (f32)
            /// </summary>
            /// <remarks>
            /// Selection rate at close range
            /// </remarks>
            public float ShortRangeSelectionRate 
            {
                get => (float)CellsByName["ShortRangeSelectionRate"].Value;
                set => CellsByName["ShortRangeSelectionRate"].Value = (float)value;
            }
            

            // Def="f32 middleRangeTendency = -1"
            /// <summary>
            /// Medium range selection rate (f32)
            /// </summary>
            /// <remarks>
            /// Selection rate at medium range
            /// </remarks>
            public float MediumRangeSelectionRate 
            {
                get => (float)CellsByName["MediumRangeSelectionRate"].Value;
                set => CellsByName["MediumRangeSelectionRate"].Value = (float)value;
            }
            

            // Def="f32 farRangeTendency = -1"
            /// <summary>
            /// Distance selection rate (f32)
            /// </summary>
            /// <remarks>
            /// Selection rate at long distances
            /// </remarks>
            public float DistanceSelectionRate 
            {
                get => (float)CellsByName["DistanceSelectionRate"].Value;
                set => CellsByName["DistanceSelectionRate"].Value = (float)value;
            }
            

            // Def="f32 outRangeTendency = -1"
            /// <summary>
            /// Out of range rate (f32)
            /// </summary>
            /// <remarks>
            /// Selection rate out of range
            /// </remarks>
            public float OutOfRangeRate 
            {
                get => (float)CellsByName["OutOfRangeRate"].Value;
                set => CellsByName["OutOfRangeRate"].Value = (float)value;
            }
            

            // Def="s32 deriveAttackId1 = -1"
            /// <summary>
            /// Derived attack 1 (s32)
            /// </summary>
            /// <remarks>
            /// Derivable attack number
            /// </remarks>
            public int DerivedAttack1 
            {
                get => (int)CellsByName["DerivedAttack1"].Value;
                set => CellsByName["DerivedAttack1"].Value = (int)value;
            }
            

            // Def="s32 deriveAttackId2 = -1"
            /// <summary>
            /// Derived attack 2 (s32)
            /// </summary>
            /// <remarks>
            /// Derivable attack number
            /// </remarks>
            public int DerivedAttack2 
            {
                get => (int)CellsByName["DerivedAttack2"].Value;
                set => CellsByName["DerivedAttack2"].Value = (int)value;
            }
            

            // Def="s32 deriveAttackId3 = -1"
            /// <summary>
            /// Derived attack 3 (s32)
            /// </summary>
            /// <remarks>
            /// Derivable attack number
            /// </remarks>
            public int DerivedAttack3 
            {
                get => (int)CellsByName["DerivedAttack3"].Value;
                set => CellsByName["DerivedAttack3"].Value = (int)value;
            }
            

            // Def="s32 deriveAttackId4 = -1"
            /// <summary>
            /// Derived attack 4 (s32)
            /// </summary>
            /// <remarks>
            /// Derivable attack number
            /// </remarks>
            public int DerivedAttack4 
            {
                get => (int)CellsByName["DerivedAttack4"].Value;
                set => CellsByName["DerivedAttack4"].Value = (int)value;
            }
            

            // Def="s32 deriveAttackId5 = -1"
            /// <summary>
            /// Derived attack 5 (s32)
            /// </summary>
            /// <remarks>
            /// Derivable attack number
            /// </remarks>
            public int DerivedAttack5 
            {
                get => (int)CellsByName["DerivedAttack5"].Value;
                set => CellsByName["DerivedAttack5"].Value = (int)value;
            }
            

            // Def="s32 deriveAttackId6 = -1"
            /// <summary>
            /// Derived attack 6 (s32)
            /// </summary>
            /// <remarks>
            /// Derivable attack number
            /// </remarks>
            public int DerivedAttack6 
            {
                get => (int)CellsByName["DerivedAttack6"].Value;
                set => CellsByName["DerivedAttack6"].Value = (int)value;
            }
            

            // Def="s32 deriveAttackId7 = -1"
            /// <summary>
            /// Derived attack 7 (s32)
            /// </summary>
            /// <remarks>
            /// Derivable attack number
            /// </remarks>
            public int DerivedAttack7 
            {
                get => (int)CellsByName["DerivedAttack7"].Value;
                set => CellsByName["DerivedAttack7"].Value = (int)value;
            }
            

            // Def="s32 deriveAttackId8 = -1"
            /// <summary>
            /// Derived attack 8 (s32)
            /// </summary>
            /// <remarks>
            /// Derivable attack number
            /// </remarks>
            public int DerivedAttack8 
            {
                get => (int)CellsByName["DerivedAttack8"].Value;
                set => CellsByName["DerivedAttack8"].Value = (int)value;
            }
            

            // Def="s32 deriveAttackId9 = -1"
            /// <summary>
            /// Derived attack 9 (s32)
            /// </summary>
            /// <remarks>
            /// Derivable attack number
            /// </remarks>
            public int DerivedAttack9 
            {
                get => (int)CellsByName["DerivedAttack9"].Value;
                set => CellsByName["DerivedAttack9"].Value = (int)value;
            }
            

            // Def="s32 deriveAttackId10 = -1"
            /// <summary>
            /// Derived attack 10 (s32)
            /// </summary>
            /// <remarks>
            /// Derivable attack number
            /// </remarks>
            public int DerivedAttack10 
            {
                get => (int)CellsByName["DerivedAttack10"].Value;
                set => CellsByName["DerivedAttack10"].Value = (int)value;
            }
            

            // Def="s32 deriveAttackId11 = -1"
            /// <summary>
            /// Derived attack 11 (s32)
            /// </summary>
            /// <remarks>
            /// Derivable attack number
            /// </remarks>
            public int DerivedAttack11 
            {
                get => (int)CellsByName["DerivedAttack11"].Value;
                set => CellsByName["DerivedAttack11"].Value = (int)value;
            }
            

            // Def="s32 deriveAttackId12 = -1"
            /// <summary>
            /// Derived attack 12 (s32)
            /// </summary>
            /// <remarks>
            /// Derivable attack number
            /// </remarks>
            public int DerivedAttack12 
            {
                get => (int)CellsByName["DerivedAttack12"].Value;
                set => CellsByName["DerivedAttack12"].Value = (int)value;
            }
            

            // Def="s32 deriveAttackId13 = -1"
            /// <summary>
            /// Derived attack 13 (s32)
            /// </summary>
            /// <remarks>
            /// Derivable attack number
            /// </remarks>
            public int DerivedAttack13 
            {
                get => (int)CellsByName["DerivedAttack13"].Value;
                set => CellsByName["DerivedAttack13"].Value = (int)value;
            }
            

            // Def="s32 deriveAttackId14 = -1"
            /// <summary>
            /// Derived attack 14 (s32)
            /// </summary>
            /// <remarks>
            /// Derivable attack number
            /// </remarks>
            public int DerivedAttack14 
            {
                get => (int)CellsByName["DerivedAttack14"].Value;
                set => CellsByName["DerivedAttack14"].Value = (int)value;
            }
            

            // Def="s32 deriveAttackId15 = -1"
            /// <summary>
            /// Derived attack 15 (s32)
            /// </summary>
            /// <remarks>
            /// Derivable attack number
            /// </remarks>
            public int DerivedAttack15 
            {
                get => (int)CellsByName["DerivedAttack15"].Value;
                set => CellsByName["DerivedAttack15"].Value = (int)value;
            }
            

            // Def="s32 deriveAttackId16 = -1"
            /// <summary>
            /// Derived attack 16 (s32)
            /// </summary>
            /// <remarks>
            /// Derivable attack number
            /// </remarks>
            public int DerivedAttack16 
            {
                get => (int)CellsByName["DerivedAttack16"].Value;
                set => CellsByName["DerivedAttack16"].Value = (int)value;
            }
            

            // Def="f32 goalLifeMin"
            /// <summary>
            /// Minimum life of the goal (f32)
            /// </summary>
            /// <remarks>
            /// Minimum life of the goal
            /// </remarks>
            public float MinimumLifeOfTheGoal 
            {
                get => (float)CellsByName["MinimumLifeOfTheGoal"].Value;
                set => CellsByName["MinimumLifeOfTheGoal"].Value = (float)value;
            }
            

            // Def="f32 goalLifeMax"
            /// <summary>
            /// Maximum life span of the goal (f32)
            /// </summary>
            /// <remarks>
            /// Maximum life span of the goal
            /// </remarks>
            public float MaximumLifeSpanOfTheGoal 
            {
                get => (float)CellsByName["MaximumLifeSpanOfTheGoal"].Value;
                set => CellsByName["MaximumLifeSpanOfTheGoal"].Value = (float)value;
            }
            

            // Def="u8 doesSelectOnInnerRange"
            /// <summary>
            /// Whether to select within the appropriate distance (u8)
            /// </summary>
            /// <remarks>
            /// Whether to select when within the appropriate distance
            /// </remarks>
            public byte WhetherToSelectWithinTheAppropriateDistance 
            {
                get => (byte)CellsByName["WhetherToSelectWithinTheAppropriateDistance"].Value;
                set => CellsByName["WhetherToSelectWithinTheAppropriateDistance"].Value = (byte)value;
            }
            

            // Def="u8 enableAttackOnBattleStart = 1"
            /// <summary>
            /// Whether to use it as the first hit (u8)
            /// </summary>
            /// <remarks>
            /// Whether to use it as the first hit
            /// </remarks>
            public byte WhetherToUseItAsTheFirstHit 
            {
                get => (byte)CellsByName["WhetherToUseItAsTheFirstHit"].Value;
                set => CellsByName["WhetherToUseItAsTheFirstHit"].Value = (byte)value;
            }
            

            // Def="u8 doesSelectOnTargetDown = 1"
            /// <summary>
            /// Whether to select when the target is down (u8)
            /// </summary>
            /// <remarks>
            /// Whether to select when the target is down
            /// </remarks>
            public byte WhetherToSelectWhenTheTargetIsDown 
            {
                get => (byte)CellsByName["WhetherToSelectWhenTheTargetIsDown"].Value;
                set => CellsByName["WhetherToSelectWhenTheTargetIsDown"].Value = (byte)value;
            }
            

            // Def="dummy8 pad1[1]"
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
            

            // Def="f32 minArriveDistance"
            /// <summary>
            /// Minimum reach judgment distance (f32)
            /// </summary>
            /// <remarks>
            /// Minimum reach judgment distance
            /// </remarks>
            public float MinimumReachJudgmentDistance 
            {
                get => (float)CellsByName["MinimumReachJudgmentDistance"].Value;
                set => CellsByName["MinimumReachJudgmentDistance"].Value = (float)value;
            }
            

            // Def="f32 maxArriveDistance"
            /// <summary>
            /// Maximum reach judgment distance (f32)
            /// </summary>
            /// <remarks>
            /// Maximum reach judgment distance
            /// </remarks>
            public float MaximumReachJudgmentDistance 
            {
                get => (float)CellsByName["MaximumReachJudgmentDistance"].Value;
                set => CellsByName["MaximumReachJudgmentDistance"].Value = (float)value;
            }
            

            // Def="f32 comboExecDistance = 4"
            /// <summary>
            /// Continuous attack execution distance (f32)
            /// </summary>
            /// <remarks>
            /// Distance used to determine the execution of attacks from the second stage onward
            /// </remarks>
            public float ContinuousAttackExecutionDistance 
            {
                get => (float)CellsByName["ContinuousAttackExecutionDistance"].Value;
                set => CellsByName["ContinuousAttackExecutionDistance"].Value = (float)value;
            }
            

            // Def="f32 comboExecRange = 180"
            /// <summary>
            /// Continuous attack execution angle (f32)
            /// </summary>
            /// <remarks>
            /// Distance used to determine the execution of attacks from the second stage onward
            /// </remarks>
            public float ContinuousAttackExecutionAngle 
            {
                get => (float)CellsByName["ContinuousAttackExecutionAngle"].Value;
                set => CellsByName["ContinuousAttackExecutionAngle"].Value = (float)value;
            }
            
                }
            }
            
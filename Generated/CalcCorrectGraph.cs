
            namespace StronglyTypedParams
            {
                public class CalcCorrectGraph : ParamRow
                {
                    public CalcCorrectGraph() : base()
                    {
                    }
            

            // Def="f32 stageMaxVal0"
            /// <summary>
            /// Threshold Point [0] (f32)
            /// </summary>
            /// <remarks>
            /// Those with "nth threshold [point]" written in the specifications
            /// </remarks>
            public float ThresholdPoint0 
            {
                get => (float)CellsByName["ThresholdPoint0"].Value;
                set => CellsByName["ThresholdPoint0"].Value = value;
            }
            

            // Def="f32 stageMaxVal1"
            /// <summary>
            /// Threshold Point [1] (f32)
            /// </summary>
            /// <remarks>
            /// Those with "nth threshold [point]" written in the specifications
            /// </remarks>
            public float ThresholdPoint1 
            {
                get => (float)CellsByName["ThresholdPoint1"].Value;
                set => CellsByName["ThresholdPoint1"].Value = value;
            }
            

            // Def="f32 stageMaxVal2"
            /// <summary>
            /// Threshold Point [2] (f32)
            /// </summary>
            /// <remarks>
            /// Those with "nth threshold [point]" written in the specifications
            /// </remarks>
            public float ThresholdPoint2 
            {
                get => (float)CellsByName["ThresholdPoint2"].Value;
                set => CellsByName["ThresholdPoint2"].Value = value;
            }
            

            // Def="f32 stageMaxVal3"
            /// <summary>
            /// Threshold Point [3] (f32)
            /// </summary>
            /// <remarks>
            /// Those with "nth threshold [point]" written in the specifications
            /// </remarks>
            public float ThresholdPoint3 
            {
                get => (float)CellsByName["ThresholdPoint3"].Value;
                set => CellsByName["ThresholdPoint3"].Value = value;
            }
            

            // Def="f32 stageMaxVal4"
            /// <summary>
            /// Threshold Point [4] (f32)
            /// </summary>
            /// <remarks>
            /// Those with "nth threshold [point]" written in the specifications
            /// </remarks>
            public float ThresholdPoint4 
            {
                get => (float)CellsByName["ThresholdPoint4"].Value;
                set => CellsByName["ThresholdPoint4"].Value = value;
            }
            

            // Def="f32 stageMaxGrowVal0"
            /// <summary>
            /// Threshold Coefficient [0] (f32)
            /// </summary>
            /// <remarks>
            /// Those with "nth threshold [coefficient]" written in the specifications
            /// </remarks>
            public float ThresholdCoefficient0 
            {
                get => (float)CellsByName["ThresholdCoefficient0"].Value;
                set => CellsByName["ThresholdCoefficient0"].Value = value;
            }
            

            // Def="f32 stageMaxGrowVal1"
            /// <summary>
            /// Threshold Coefficient [1] (f32)
            /// </summary>
            /// <remarks>
            /// Those with "nth threshold [coefficient]" written in the specifications
            /// </remarks>
            public float ThresholdCoefficient1 
            {
                get => (float)CellsByName["ThresholdCoefficient1"].Value;
                set => CellsByName["ThresholdCoefficient1"].Value = value;
            }
            

            // Def="f32 stageMaxGrowVal2"
            /// <summary>
            /// Threshold Coefficient [2] (f32)
            /// </summary>
            /// <remarks>
            /// Those with "nth threshold [coefficient]" written in the specifications
            /// </remarks>
            public float ThresholdCoefficient2 
            {
                get => (float)CellsByName["ThresholdCoefficient2"].Value;
                set => CellsByName["ThresholdCoefficient2"].Value = value;
            }
            

            // Def="f32 stageMaxGrowVal3"
            /// <summary>
            /// Threshold Coefficient [3] (f32)
            /// </summary>
            /// <remarks>
            /// Those with "nth threshold [coefficient]" written in the specifications
            /// </remarks>
            public float ThresholdCoefficient3 
            {
                get => (float)CellsByName["ThresholdCoefficient3"].Value;
                set => CellsByName["ThresholdCoefficient3"].Value = value;
            }
            

            // Def="f32 stageMaxGrowVal4"
            /// <summary>
            /// Threshold Coefficient [4] (f32)
            /// </summary>
            /// <remarks>
            /// Those with "nth threshold [coefficient]" written in the specifications
            /// </remarks>
            public float ThresholdCoefficient4 
            {
                get => (float)CellsByName["ThresholdCoefficient4"].Value;
                set => CellsByName["ThresholdCoefficient4"].Value = value;
            }
            

            // Def="f32 adjPt_maxGrowVal0"
            /// <summary>
            /// Adjustment Factor [0] (f32)
            /// </summary>
            /// <remarks>
            /// Adjustment factor
            /// </remarks>
            public float AdjustmentFactor0 
            {
                get => (float)CellsByName["AdjustmentFactor0"].Value;
                set => CellsByName["AdjustmentFactor0"].Value = value;
            }
            

            // Def="f32 adjPt_maxGrowVal1"
            /// <summary>
            /// Adjustment Factor [1] (f32)
            /// </summary>
            /// <remarks>
            /// Adjustment factor
            /// </remarks>
            public float AdjustmentFactor1 
            {
                get => (float)CellsByName["AdjustmentFactor1"].Value;
                set => CellsByName["AdjustmentFactor1"].Value = value;
            }
            

            // Def="f32 adjPt_maxGrowVal2"
            /// <summary>
            /// Adjustment Factor [2] (f32)
            /// </summary>
            /// <remarks>
            /// Adjustment factor
            /// </remarks>
            public float AdjustmentFactor2 
            {
                get => (float)CellsByName["AdjustmentFactor2"].Value;
                set => CellsByName["AdjustmentFactor2"].Value = value;
            }
            

            // Def="f32 adjPt_maxGrowVal3"
            /// <summary>
            /// Adjustment Factor [3] (f32)
            /// </summary>
            /// <remarks>
            /// Adjustment factor
            /// </remarks>
            public float AdjustmentFactor3 
            {
                get => (float)CellsByName["AdjustmentFactor3"].Value;
                set => CellsByName["AdjustmentFactor3"].Value = value;
            }
            

            // Def="f32 adjPt_maxGrowVal4"
            /// <summary>
            /// Adjustment Factor [4] (f32)
            /// </summary>
            /// <remarks>
            /// Adjustment factor
            /// </remarks>
            public float AdjustmentFactor4 
            {
                get => (float)CellsByName["AdjustmentFactor4"].Value;
                set => CellsByName["AdjustmentFactor4"].Value = value;
            }
            

            // Def="f32 init_inclination_soul"
            /// <summary>
            /// Leveling Cost - Initial Cost (f32)
            /// </summary>
            /// <remarks>
            /// Growth Soul Slope of the early graph α1
            /// </remarks>
            public float LevelingCostInitialCost 
            {
                get => (float)CellsByName["LevelingCostInitialCost"].Value;
                set => CellsByName["LevelingCostInitialCost"].Value = value;
            }
            

            // Def="f32 adjustment_value"
            /// <summary>
            /// Leveling Cost - Initial Offset (f32)
            /// </summary>
            /// <remarks>
            /// Growth soul Early soul adjustment α2
            /// </remarks>
            public float LevelingCostInitialOffset 
            {
                get => (float)CellsByName["LevelingCostInitialOffset"].Value;
                set => CellsByName["LevelingCostInitialOffset"].Value = value;
            }
            

            // Def="f32 boundry_inclination_soul"
            /// <summary>
            /// Leveling Cost - Cost Increase (f32)
            /// </summary>
            /// <remarks>
            /// Affects the slope of the graph after the growth soul threshold α3
            /// </remarks>
            public float LevelingCostCostIncrease 
            {
                get => (float)CellsByName["LevelingCostCostIncrease"].Value;
                set => CellsByName["LevelingCostCostIncrease"].Value = value;
            }
            

            // Def="f32 boundry_value"
            /// <summary>
            /// Leveling Cost - Increase Interval (f32)
            /// </summary>
            /// <remarks>
            /// Growth soul threshold t
            /// </remarks>
            public float LevelingCostIncreaseInterval 
            {
                get => (float)CellsByName["LevelingCostIncreaseInterval"].Value;
                set => CellsByName["LevelingCostIncreaseInterval"].Value = value;
            }
            

            // Def="dummy8 pad[4]"
            /// <summary>
            /// Padding (dummy8)
            /// </summary>
            /// <remarks>
            /// 
            /// </remarks>
            public object Padding 
            {
                get => (object)CellsByName["Padding"].Value;
                set => CellsByName["Padding"].Value = value;
            }
            
                }
            }
            
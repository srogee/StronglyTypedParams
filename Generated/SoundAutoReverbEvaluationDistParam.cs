
            namespace StronglyTypedParams
            {
                // SOUND_AUTO_REVERB_EVALUATION_DIST_PARAM_ST
                public class SoundAutoReverbEvaluationDistParam : ParamRow
                {
                    public SoundAutoReverbEvaluationDistParam() : base()
                    {
                    }
            

            // Def="f32 NoHitDist = -1"
            /// <summary>
            /// No Hit Distance (f32)
            /// </summary>
            /// <remarks>
            /// Collision points above this distance [m] are judged as No Hit (less than 0: invalid)
            /// </remarks>
            public float NoHitDistance 
            {
                get => (float)CellsByName["NoHitDistance"].Value;
                set => CellsByName["NoHitDistance"].Value = (float)value;
            }
            

            // Def="u8 isCollectNoHitPoint"
            /// <summary>
            /// Include Collision Point of No Hit (u8)
            /// </summary>
            /// <remarks>
            /// Do you include NoHit collision points?
            /// </remarks>
            public BoolCirclecrossType IncludeCollisionPointOfNoHit 
            {
                get => (BoolCirclecrossType)CellsByName["IncludeCollisionPointOfNoHit"].Value;
                set => CellsByName["IncludeCollisionPointOfNoHit"].Value = (byte)value;
            }
            

            // Def="u8 isCollectOutdoorPoint"
            /// <summary>
            /// Include Outdoor Collision Point (u8)
            /// </summary>
            /// <remarks>
            /// Do you include outdoor collision points?
            /// </remarks>
            public BoolCirclecrossType IncludeOutdoorCollisionPoint 
            {
                get => (BoolCirclecrossType)CellsByName["IncludeOutdoorCollisionPoint"].Value;
                set => CellsByName["IncludeOutdoorCollisionPoint"].Value = (byte)value;
            }
            

            // Def="u8 isCollectFloorPoint"
            /// <summary>
            /// Include Floor Collision Point (u8)
            /// </summary>
            /// <remarks>
            /// Do you include floor collision points?
            /// </remarks>
            public BoolCirclecrossType IncludeFloorCollisionPoint 
            {
                get => (BoolCirclecrossType)CellsByName["IncludeFloorCollisionPoint"].Value;
                set => CellsByName["IncludeFloorCollisionPoint"].Value = (byte)value;
            }
            

            // Def="u8 distValCalcType"
            /// <summary>
            /// Evaluation Distance Calculation Type (u8)
            /// </summary>
            /// <remarks>
            /// Evaluation distance calculation type (0: normal, average from 1: Max)
            /// </remarks>
            public byte EvaluationDistanceCalculationType 
            {
                get => (byte)CellsByName["EvaluationDistanceCalculationType"].Value;
                set => CellsByName["EvaluationDistanceCalculationType"].Value = (byte)value;
            }
            

            // Def="f32 enableLifeTime = -1"
            /// <summary>
            /// Invalidate after Duration (f32)
            /// </summary>
            /// <remarks>
            /// Collision points longer than this life [second] are treated as invalid. Set to be less than or equal to the life of the common setting
            /// </remarks>
            public float InvalidateAfterDuration 
            {
                get => (float)CellsByName["InvalidateAfterDuration"].Value;
                set => CellsByName["InvalidateAfterDuration"].Value = (float)value;
            }
            

            // Def="u32 maxDistRecordNum = 20"
            /// <summary>
            /// Max Collision Point Count (u32)
            /// </summary>
            /// <remarks>
            /// Max Number of collision point records
            /// </remarks>
            public uint MaxCollisionPointCount 
            {
                get => (uint)CellsByName["MaxCollisionPointCount"].Value;
                set => CellsByName["MaxCollisionPointCount"].Value = (uint)value;
            }
            

            // Def="u32 ignoreDistNumForMax"
            /// <summary>
            /// Max Distance until Ignore (u32)
            /// </summary>
            /// <remarks>
            /// Max distance decimation number (0: not decimation) (must be set to the value of "Max collision point record number-1". Incorrect value will be corrected)
            /// </remarks>
            public uint MaxDistanceUntilIgnore 
            {
                get => (uint)CellsByName["MaxDistanceUntilIgnore"].Value;
                set => CellsByName["MaxDistanceUntilIgnore"].Value = (uint)value;
            }
            
                }
            }
            
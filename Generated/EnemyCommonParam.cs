
            namespace StronglyTypedParams
            {
                // ENEMY_COMMON_PARAM_ST
                public class EnemyCommonParam : ParamRow
                {
                    public EnemyCommonParam() : base()
                    {
                    }
            

            // Def="dummy8 reserved0[8]"
            /// <summary>
            /// reserve (dummy8)
            /// </summary>
            /// <remarks>
            /// (dummy8)
            /// </remarks>
            public object Reserve 
            {
                get => (object)CellsByName["Reserve"].Value;
                set => CellsByName["Reserve"].Value = (object)value;
            }
            

            // Def="s32 soundTargetTryApproachTime"
            /// <summary>
            /// Sound - Target Try Approach Time (s32)
            /// </summary>
            /// <remarks>
            /// 
            /// </remarks>
            public int SoundTargetTryApproachTime 
            {
                get => (int)CellsByName["SoundTargetTryApproachTime"].Value;
                set => CellsByName["SoundTargetTryApproachTime"].Value = (int)value;
            }
            

            // Def="s32 searchTargetTryApproachTime"
            /// <summary>
            /// Search - Target Try Approach Time (s32)
            /// </summary>
            /// <remarks>
            /// 
            /// </remarks>
            public int SearchTargetTryApproachTime 
            {
                get => (int)CellsByName["SearchTargetTryApproachTime"].Value;
                set => CellsByName["SearchTargetTryApproachTime"].Value = (int)value;
            }
            

            // Def="s32 memoryTargetTryApproachTime"
            /// <summary>
            /// Memory - Target Try Approach Time (s32)
            /// </summary>
            /// <remarks>
            /// 
            /// </remarks>
            public int MemoryTargetTryApproachTime 
            {
                get => (int)CellsByName["MemoryTargetTryApproachTime"].Value;
                set => CellsByName["MemoryTargetTryApproachTime"].Value = (int)value;
            }
            


            // Def="s32 activateChrByTime_PhantomId"
            /// <summary>
            /// Activate Chr by Time - Phantom ID (s32)
            /// </summary>
            /// <remarks>
            /// Phantom shader ID used for directing the appearance and disappearance of enemies placed in a specific time zone
            /// </remarks>
            public int ActivateChrByTimePhantomID 
            {
                get => (int)CellsByName["ActivateChrByTimePhantomID"].Value;
                set => CellsByName["ActivateChrByTimePhantomID"].Value = (int)value;
            }
            

            // Def="f32 findUnfavorableFailedPointDist"
            /// <summary>
            /// Find Unfavourable Failed Point Distance (f32)
            /// </summary>
            /// <remarks>
            /// Distance to generate an interrupt, which turns out that the enemy is likely to be cut off when going to the end of the path
            /// </remarks>
            public float FindUnfavourableFailedPointDistance 
            {
                get => (float)CellsByName["FindUnfavourableFailedPointDistance"].Value;
                set => CellsByName["FindUnfavourableFailedPointDistance"].Value = (float)value;
            }
            

            // Def="f32 findUnfavorableFailedPointHeight"
            /// <summary>
            /// Find Unfavourable Failed Point Height (f32)
            /// </summary>
            /// <remarks>
            /// The height that causes an interrupt, which turns out that the enemy is likely to be cut off when going to the end of the path
            /// </remarks>
            public float FindUnfavourableFailedPointHeight 
            {
                get => (float)CellsByName["FindUnfavourableFailedPointHeight"].Value;
                set => CellsByName["FindUnfavourableFailedPointHeight"].Value = (float)value;
            }
            

                }
            }
            
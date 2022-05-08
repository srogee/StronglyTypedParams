
            namespace StronglyTypedParams
            {
                // SPEEDTREE_MODEL_PARAM_ST
                public class SpeedtreeModel : ParamRow
                {
                    public SpeedtreeModel() : base()
                    {
                    }
            

            // Def="f32 MinFadeLeaf"
            /// <summary>
            /// Leaf - Min Fade (f32)
            /// </summary>
            /// <remarks>
            /// 
            /// </remarks>
            public float LeafMinFade 
            {
                get => (float)CellsByName["LeafMinFade"].Value;
                set => CellsByName["LeafMinFade"].Value = (float)value;
            }
            

            // Def="f32 MinFadeFrond"
            /// <summary>
            /// Frond - Min Fade (f32)
            /// </summary>
            /// <remarks>
            /// 
            /// </remarks>
            public float FrondMinFade 
            {
                get => (float)CellsByName["FrondMinFade"].Value;
                set => CellsByName["FrondMinFade"].Value = (float)value;
            }
            

            // Def="f32 MinFadeBranch"
            /// <summary>
            /// Branch - Min Fade (f32)
            /// </summary>
            /// <remarks>
            /// 
            /// </remarks>
            public float BranchMinFade 
            {
                get => (float)CellsByName["BranchMinFade"].Value;
                set => CellsByName["BranchMinFade"].Value = (float)value;
            }
            

            // Def="f32 MinTranslucencyLeaf"
            /// <summary>
            /// Leaf - Min Translucency (f32)
            /// </summary>
            /// <remarks>
            /// 
            /// </remarks>
            public float LeafMinTranslucency 
            {
                get => (float)CellsByName["LeafMinTranslucency"].Value;
                set => CellsByName["LeafMinTranslucency"].Value = (float)value;
            }
            

            // Def="f32 MaxTranslucencyLeaf = 5"
            /// <summary>
            /// Leaf - Max Translucency (f32)
            /// </summary>
            /// <remarks>
            /// 
            /// </remarks>
            public float LeafMaxTranslucency 
            {
                get => (float)CellsByName["LeafMaxTranslucency"].Value;
                set => CellsByName["LeafMaxTranslucency"].Value = (float)value;
            }
            

            // Def="f32 MinTranslucencyFrond"
            /// <summary>
            /// Frond - Min Translucency (f32)
            /// </summary>
            /// <remarks>
            /// 
            /// </remarks>
            public float FrondMinTranslucency 
            {
                get => (float)CellsByName["FrondMinTranslucency"].Value;
                set => CellsByName["FrondMinTranslucency"].Value = (float)value;
            }
            

            // Def="f32 MaxTranslucencyFrond = 5"
            /// <summary>
            /// Frond - Max Translucency (f32)
            /// </summary>
            /// <remarks>
            /// 
            /// </remarks>
            public float FrondMaxTranslucency 
            {
                get => (float)CellsByName["FrondMaxTranslucency"].Value;
                set => CellsByName["FrondMaxTranslucency"].Value = (float)value;
            }
            

            // Def="f32 MinTranslucencyBranch"
            /// <summary>
            /// Branch - Min Translucency (f32)
            /// </summary>
            /// <remarks>
            /// 
            /// </remarks>
            public float BranchMinTranslucency 
            {
                get => (float)CellsByName["BranchMinTranslucency"].Value;
                set => CellsByName["BranchMinTranslucency"].Value = (float)value;
            }
            

            // Def="f32 MaxTranslucencyBranch = 5"
            /// <summary>
            /// Branch - Max Translucency (f32)
            /// </summary>
            /// <remarks>
            /// 
            /// </remarks>
            public float BranchMaxTranslucency 
            {
                get => (float)CellsByName["BranchMaxTranslucency"].Value;
                set => CellsByName["BranchMaxTranslucency"].Value = (float)value;
            }
            

            // Def="f32 BillboardBackSpecularWeakenParam = 1"
            /// <summary>
            /// Billboard Specular Suppression Value (f32)
            /// </summary>
            /// <remarks>
            /// 
            /// </remarks>
            public float BillboardSpecularSuppressionValue 
            {
                get => (float)CellsByName["BillboardSpecularSuppressionValue"].Value;
                set => CellsByName["BillboardSpecularSuppressionValue"].Value = (float)value;
            }
            
                }
            }
            
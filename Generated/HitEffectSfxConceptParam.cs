
            namespace StronglyTypedParams
            {
                // HIT_EFFECT_SFX_CONCEPT_PARAM_ST
                public class HitEffectSfxConceptParam : ParamRow
                {
                    public HitEffectSfxConceptParam() : base()
                    {
                    }
            

            // Def="s16 atkIron_1"
            /// <summary>
            /// Iron [1] (s16)
            /// </summary>
            /// <remarks>
            /// Iron: Concept 1
            /// </remarks>
            public HitEffectSfxConceptType Iron1 
            {
                get => (HitEffectSfxConceptType)CellsByName["Iron1"].Value;
                set => CellsByName["Iron1"].Value = (short)value;
            }
            

            // Def="s16 atkIron_2"
            /// <summary>
            /// Iron [2] (s16)
            /// </summary>
            /// <remarks>
            /// Iron: Concept 2
            /// </remarks>
            public HitEffectSfxConceptType Iron2 
            {
                get => (HitEffectSfxConceptType)CellsByName["Iron2"].Value;
                set => CellsByName["Iron2"].Value = (short)value;
            }
            

            // Def="s16 atkLeather_1"
            /// <summary>
            /// Leather [1] (s16)
            /// </summary>
            /// <remarks>
            /// Leather: Concept 1
            /// </remarks>
            public HitEffectSfxConceptType Leather1 
            {
                get => (HitEffectSfxConceptType)CellsByName["Leather1"].Value;
                set => CellsByName["Leather1"].Value = (short)value;
            }
            

            // Def="s16 atkLeather_2"
            /// <summary>
            /// Leather [2] (s16)
            /// </summary>
            /// <remarks>
            /// Leather: Concept 2
            /// </remarks>
            public HitEffectSfxConceptType Leather2 
            {
                get => (HitEffectSfxConceptType)CellsByName["Leather2"].Value;
                set => CellsByName["Leather2"].Value = (short)value;
            }
            

            // Def="s16 atkWood_1"
            /// <summary>
            /// Wood [1] (s16)
            /// </summary>
            /// <remarks>
            /// Wooden: Concept 1
            /// </remarks>
            public HitEffectSfxConceptType Wood1 
            {
                get => (HitEffectSfxConceptType)CellsByName["Wood1"].Value;
                set => CellsByName["Wood1"].Value = (short)value;
            }
            

            // Def="s16 atkWood_2"
            /// <summary>
            /// Wood [2] (s16)
            /// </summary>
            /// <remarks>
            /// Wooden: Concept 2
            /// </remarks>
            public HitEffectSfxConceptType Wood2 
            {
                get => (HitEffectSfxConceptType)CellsByName["Wood2"].Value;
                set => CellsByName["Wood2"].Value = (short)value;
            }
            

            // Def="s16 atkBody_1"
            /// <summary>
            /// Flesh [1] (s16)
            /// </summary>
            /// <remarks>
            /// Meat: Concept 1
            /// </remarks>
            public HitEffectSfxConceptType Flesh1 
            {
                get => (HitEffectSfxConceptType)CellsByName["Flesh1"].Value;
                set => CellsByName["Flesh1"].Value = (short)value;
            }
            

            // Def="s16 atkBody_2"
            /// <summary>
            /// Flesh [2] (s16)
            /// </summary>
            /// <remarks>
            /// Meat: Concept 2
            /// </remarks>
            public HitEffectSfxConceptType Flesh2 
            {
                get => (HitEffectSfxConceptType)CellsByName["Flesh2"].Value;
                set => CellsByName["Flesh2"].Value = (short)value;
            }
            

            // Def="s16 atkStone_1"
            /// <summary>
            /// Stone [1] (s16)
            /// </summary>
            /// <remarks>
            /// Corrosion: Concept 1
            /// </remarks>
            public HitEffectSfxConceptType Stone1 
            {
                get => (HitEffectSfxConceptType)CellsByName["Stone1"].Value;
                set => CellsByName["Stone1"].Value = (short)value;
            }
            

            // Def="s16 atkStone_2"
            /// <summary>
            /// Stone [2] (s16)
            /// </summary>
            /// <remarks>
            /// Corrosion: Concept 2
            /// </remarks>
            public HitEffectSfxConceptType Stone2 
            {
                get => (HitEffectSfxConceptType)CellsByName["Stone2"].Value;
                set => CellsByName["Stone2"].Value = (short)value;
            }
            

            // Def="dummy8 pad[4]"
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
            

            // Def="s16 atkNone_1"
            /// <summary>
            /// None [1] (s16)
            /// </summary>
            /// <remarks>
            /// None: Concept 1
            /// </remarks>
            public HitEffectSfxConceptType None1 
            {
                get => (HitEffectSfxConceptType)CellsByName["None1"].Value;
                set => CellsByName["None1"].Value = (short)value;
            }
            

            // Def="s16 atkNone_2"
            /// <summary>
            /// None [2] (s16)
            /// </summary>
            /// <remarks>
            /// None: Concept 2
            /// </remarks>
            public HitEffectSfxConceptType None2 
            {
                get => (HitEffectSfxConceptType)CellsByName["None2"].Value;
                set => CellsByName["None2"].Value = (short)value;
            }
            

            // Def="dummy8 reserve[52]"
            /// <summary>
            /// Reserved area (dummy8)
            /// </summary>
            /// <remarks>
            /// 
            /// </remarks>
            public object ReservedArea 
            {
                get => (object)CellsByName["ReservedArea"].Value;
                set => CellsByName["ReservedArea"].Value = (object)value;
            }
            
                }
            }
            
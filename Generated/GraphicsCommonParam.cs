
            namespace StronglyTypedParams
            {
                // GRAPHICS_COMMON_PARAM_ST
                public class GraphicsCommonParam : ParamRow
                {
                    public GraphicsCommonParam() : base()
                    {
                    }
            

            // Def="f32 hitBulletDecalOffset_HitIns = 0.05"
            /// <summary>
            /// Hit Bullet Decal Offset - Hit INS (f32)
            /// </summary>
            /// <remarks>
            /// The position where the decal that occurs when hitting HIT INS is offset by this value in the normal direction.
            /// </remarks>
            public float HitBulletDecalOffsetHitINS 
            {
                get => (float)CellsByName["HitBulletDecalOffsetHitINS"].Value;
                set => CellsByName["HitBulletDecalOffsetHitINS"].Value = (float)value;
            }
            

            // Def="dummy8 reserved02[8]"
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
            

            // Def="f32 charaWetDecalFadeRange = 0.6"
            /// <summary>
            /// Character Wet Decal Fade Range (f32)
            /// </summary>
            /// <remarks>
            /// Fade range that erases decals when the character gets wet [m]
            /// </remarks>
            public float CharacterWetDecalFadeRange 
            {
                get => (float)CellsByName["CharacterWetDecalFadeRange"].Value;
                set => CellsByName["CharacterWetDecalFadeRange"].Value = (float)value;
            }
            

                }
            }
            
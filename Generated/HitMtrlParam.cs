
            namespace StronglyTypedParams
            {
                // HIT_MTRL_PARAM_ST
                public class HitMtrlParam : ParamRow
                {
                    public HitMtrlParam() : base()
                    {
                    }
            

            // Def="f32 aiVolumeRate = 1"
            /// <summary>
            /// AI Volume Rate (f32)
            /// </summary>
            /// <remarks>
            /// Normal when 1x. When set to 0, the radius of sound becomes 0 (SE and SFX are unrelated game-like parameters).
            /// </remarks>
            public float AIVolumeRate 
            {
                get => (float)CellsByName["AIVolumeRate"].Value;
                set => CellsByName["AIVolumeRate"].Value = (float)value;
            }
            

            // Def="s32 spEffectIdOnHit0 = -1"
            /// <summary>
            /// On Hit [1] - SpEffect ID (s32)
            /// </summary>
            /// <remarks>
            /// When the character steps on the hit material, the set special effect 0 is exhibited.
            /// </remarks>
            public int OnHit1SpEffectID 
            {
                get => (int)CellsByName["OnHit1SpEffectID"].Value;
                set => CellsByName["OnHit1SpEffectID"].Value = (int)value;
            }
            

            // Def="s32 spEffectIdOnHit1 = -1"
            /// <summary>
            /// On Hit [2] - SpEffect ID (s32)
            /// </summary>
            /// <remarks>
            /// When the character steps on the hit material, the set special effect 1 is exhibited.
            /// </remarks>
            public int OnHit2SpEffectID 
            {
                get => (int)CellsByName["OnHit2SpEffectID"].Value;
                set => CellsByName["OnHit2SpEffectID"].Value = (int)value;
            }
            

            // Def="u8 footEffectHeightType:2"
            /// <summary>
            /// Foot Effect Height Type (u8)
            /// </summary>
            /// <remarks>
            /// Height to generate foot effect
            /// </remarks>
            public HmpFootEffectHeightType FootEffectHeightType 
            {
                get => (HmpFootEffectHeightType)CellsByName["FootEffectHeightType"].Value;
                set => CellsByName["FootEffectHeightType"].Value = (byte)value;
            }
            

            // Def="u8 footEffectDirType:2"
            /// <summary>
            /// Foot Effect Direction Type (u8)
            /// </summary>
            /// <remarks>
            /// Direction of foot effect
            /// </remarks>
            public HmpFootEffectDirType FootEffectDirectionType 
            {
                get => (HmpFootEffectDirType)CellsByName["FootEffectDirectionType"].Value;
                set => CellsByName["FootEffectDirectionType"].Value = (byte)value;
            }
            

            // Def="u8 floorHeightType:2"
            /// <summary>
            /// Floor Height Type (u8)
            /// </summary>
            /// <remarks>
            /// For floating items such as the surface of the water
            /// </remarks>
            public HmpFloorHeightType FloorHeightType 
            {
                get => (HmpFloorHeightType)CellsByName["FloorHeightType"].Value;
                set => CellsByName["FloorHeightType"].Value = (byte)value;
            }
            

            // Def="u8 disableFallDamage:1"
            /// <summary>
            /// Disable Fall Damage (u8)
            /// </summary>
            /// <remarks>
            /// Set to 1 for floors that are not subject to fall damage
            /// </remarks>
            public byte DisableFallDamage 
            {
                get => (byte)CellsByName["DisableFallDamage"].Value;
                set => CellsByName["DisableFallDamage"].Value = (byte)value;
            }
            

            // Def="u8 isHardnessForSoundReverb:1"
            /// <summary>
            /// Is Hardness for Sound Reverb (u8)
            /// </summary>
            /// <remarks>
            /// Is it a hard material for sound echo? (0: soft, 1: hard)
            /// </remarks>
            public byte IsHardnessForSoundReverb 
            {
                get => (byte)CellsByName["IsHardnessForSoundReverb"].Value;
                set => CellsByName["IsHardnessForSoundReverb"].Value = (byte)value;
            }
            

            // Def="u8 hardnessType"
            /// <summary>
            /// Hardness Type (u8)
            /// </summary>
            /// <remarks>
            /// The hardness of the material. Used for soft contact processing of rigid bodies.
            /// </remarks>
            public HmpHardnessType HardnessType 
            {
                get => (HmpHardnessType)CellsByName["HardnessType"].Value;
                set => CellsByName["HardnessType"].Value = (byte)value;
            }
            

            // Def="dummy8 pad2[6]"
            /// <summary>
            /// pad (dummy8)
            /// </summary>
            /// <remarks>
            /// pad
            /// </remarks>
            public object Pad 
            {
                get => (object)CellsByName["Pad"].Value;
                set => CellsByName["Pad"].Value = (object)value;
            }
            

            // Def="s32 spEffectIdOnHit0_ClearCount_2 = -1"
            /// <summary>
            /// On Hit [0] - NG+1 - SpEffect ID (s32)
            /// </summary>
            /// <remarks>
            /// Special effect applied when stepping on the hit material 0 2nd lap
            /// </remarks>
            public int OnHit0NG1SpEffectID 
            {
                get => (int)CellsByName["OnHit0NG1SpEffectID"].Value;
                set => CellsByName["OnHit0NG1SpEffectID"].Value = (int)value;
            }
            

            // Def="s32 spEffectIdOnHit0_ClearCount_3 = -1"
            /// <summary>
            /// On Hit [0] - NG+2 - SpEffect ID (s32)
            /// </summary>
            /// <remarks>
            /// Special effect applied when stepping on the hit material 0 3rd lap
            /// </remarks>
            public int OnHit0NG2SpEffectID 
            {
                get => (int)CellsByName["OnHit0NG2SpEffectID"].Value;
                set => CellsByName["OnHit0NG2SpEffectID"].Value = (int)value;
            }
            

            // Def="s32 spEffectIdOnHit0_ClearCount_4 = -1"
            /// <summary>
            /// On Hit [0] - NG+3 - SpEffect ID (s32)
            /// </summary>
            /// <remarks>
            /// Special effect applied when stepping on the hit material 0 4th lap
            /// </remarks>
            public int OnHit0NG3SpEffectID 
            {
                get => (int)CellsByName["OnHit0NG3SpEffectID"].Value;
                set => CellsByName["OnHit0NG3SpEffectID"].Value = (int)value;
            }
            

            // Def="s32 spEffectIdOnHit0_ClearCount_5 = -1"
            /// <summary>
            /// On Hit [0] - NG+4 - SpEffect ID (s32)
            /// </summary>
            /// <remarks>
            /// Special effect applied when stepping on the hit material 0 5th lap
            /// </remarks>
            public int OnHit0NG4SpEffectID 
            {
                get => (int)CellsByName["OnHit0NG4SpEffectID"].Value;
                set => CellsByName["OnHit0NG4SpEffectID"].Value = (int)value;
            }
            

            // Def="s32 spEffectIdOnHit0_ClearCount_6 = -1"
            /// <summary>
            /// On Hit [0] - NG+5 - SpEffect ID (s32)
            /// </summary>
            /// <remarks>
            /// Special effect applied when stepping on the hit material 0 6th lap
            /// </remarks>
            public int OnHit0NG5SpEffectID 
            {
                get => (int)CellsByName["OnHit0NG5SpEffectID"].Value;
                set => CellsByName["OnHit0NG5SpEffectID"].Value = (int)value;
            }
            

            // Def="s32 spEffectIdOnHit0_ClearCount_7 = -1"
            /// <summary>
            /// On Hit [0] - NG+6 - SpEffect ID (s32)
            /// </summary>
            /// <remarks>
            /// Special effect applied when stepping on the hit material 0 7th lap
            /// </remarks>
            public int OnHit0NG6SpEffectID 
            {
                get => (int)CellsByName["OnHit0NG6SpEffectID"].Value;
                set => CellsByName["OnHit0NG6SpEffectID"].Value = (int)value;
            }
            

            // Def="s32 spEffectIdOnHit0_ClearCount_8 = -1"
            /// <summary>
            /// On Hit [0] - NG+7 - SpEffect ID (s32)
            /// </summary>
            /// <remarks>
            /// Special effect applied when stepping on the hit material 0 8th lap
            /// </remarks>
            public int OnHit0NG7SpEffectID 
            {
                get => (int)CellsByName["OnHit0NG7SpEffectID"].Value;
                set => CellsByName["OnHit0NG7SpEffectID"].Value = (int)value;
            }
            

            // Def="s32 spEffectIdOnHit1_ClearCount_2 = -1"
            /// <summary>
            /// On Hit [1] - NG+1 - SpEffect ID (s32)
            /// </summary>
            /// <remarks>
            /// Special effect applied when stepping on the hit material 1st lap
            /// </remarks>
            public int OnHit1NG1SpEffectID 
            {
                get => (int)CellsByName["OnHit1NG1SpEffectID"].Value;
                set => CellsByName["OnHit1NG1SpEffectID"].Value = (int)value;
            }
            

            // Def="s32 spEffectIdOnHit1_ClearCount_3 = -1"
            /// <summary>
            /// On Hit [1] - NG+2 - SpEffect ID (s32)
            /// </summary>
            /// <remarks>
            /// Special effect applied when stepping on the hit material 1 3rd lap
            /// </remarks>
            public int OnHit1NG2SpEffectID 
            {
                get => (int)CellsByName["OnHit1NG2SpEffectID"].Value;
                set => CellsByName["OnHit1NG2SpEffectID"].Value = (int)value;
            }
            

            // Def="s32 spEffectIdOnHit1_ClearCount_4 = -1"
            /// <summary>
            /// On Hit [1] - NG+3 - SpEffect ID (s32)
            /// </summary>
            /// <remarks>
            /// Special effect applied when stepping on the hit material 1 4th lap
            /// </remarks>
            public int OnHit1NG3SpEffectID 
            {
                get => (int)CellsByName["OnHit1NG3SpEffectID"].Value;
                set => CellsByName["OnHit1NG3SpEffectID"].Value = (int)value;
            }
            

            // Def="s32 spEffectIdOnHit1_ClearCount_5 = -1"
            /// <summary>
            /// On Hit [1] - NG+4 - SpEffect ID (s32)
            /// </summary>
            /// <remarks>
            /// Special effect applied when stepping on the hit material 1 5th lap
            /// </remarks>
            public int OnHit1NG4SpEffectID 
            {
                get => (int)CellsByName["OnHit1NG4SpEffectID"].Value;
                set => CellsByName["OnHit1NG4SpEffectID"].Value = (int)value;
            }
            

            // Def="s32 spEffectIdOnHit1_ClearCount_6 = -1"
            /// <summary>
            /// On Hit [1] - NG+5 - SpEffect ID (s32)
            /// </summary>
            /// <remarks>
            /// Special effect when stepping on the hit material 1 6th lap
            /// </remarks>
            public int OnHit1NG5SpEffectID 
            {
                get => (int)CellsByName["OnHit1NG5SpEffectID"].Value;
                set => CellsByName["OnHit1NG5SpEffectID"].Value = (int)value;
            }
            

            // Def="s32 spEffectIdOnHit1_ClearCount_7 = -1"
            /// <summary>
            /// On Hit [1] - NG+6 - SpEffect ID (s32)
            /// </summary>
            /// <remarks>
            /// Special effect applied when stepping on the hit material 1 7th lap
            /// </remarks>
            public int OnHit1NG6SpEffectID 
            {
                get => (int)CellsByName["OnHit1NG6SpEffectID"].Value;
                set => CellsByName["OnHit1NG6SpEffectID"].Value = (int)value;
            }
            

            // Def="s32 spEffectIdOnHit1_ClearCount_8 = -1"
            /// <summary>
            /// On Hit [1] - NG+7 - SpEffect ID (s32)
            /// </summary>
            /// <remarks>
            /// Special effect applied when stepping on the hit material 1 8th lap
            /// </remarks>
            public int OnHit1NG7SpEffectID 
            {
                get => (int)CellsByName["OnHit1NG7SpEffectID"].Value;
                set => CellsByName["OnHit1NG7SpEffectID"].Value = (int)value;
            }
            

            // Def="s16 replaceMateiralId_Rain = -1"
            /// <summary>
            /// Rain - Replace Material ID (s16)
            /// </summary>
            /// <remarks>
            /// Hit material change destination ID due to weather (rain) (-1: No change)
            /// </remarks>
            public short RainReplaceMaterialID 
            {
                get => (short)CellsByName["RainReplaceMaterialID"].Value;
                set => CellsByName["RainReplaceMaterialID"].Value = (short)value;
            }
            


            // Def="s32 spEffectId_forWet00 = -1"
            /// <summary>
            /// Wetness [0] - SpEffect ID (s32)
            /// </summary>
            /// <remarks>
            /// Special effect for wetting 00
            /// </remarks>
            public int Wetness0SpEffectID 
            {
                get => (int)CellsByName["Wetness0SpEffectID"].Value;
                set => CellsByName["Wetness0SpEffectID"].Value = (int)value;
            }
            

            // Def="s32 spEffectId_forWet01 = -1"
            /// <summary>
            /// Wetness [1] - SpEffect ID (s32)
            /// </summary>
            /// <remarks>
            /// Special effects for wetting 01
            /// </remarks>
            public int Wetness1SpEffectID 
            {
                get => (int)CellsByName["Wetness1SpEffectID"].Value;
                set => CellsByName["Wetness1SpEffectID"].Value = (int)value;
            }
            

            // Def="s32 spEffectId_forWet02 = -1"
            /// <summary>
            /// Wetness [2] - SpEffect ID (s32)
            /// </summary>
            /// <remarks>
            /// Special effects for wetting 02
            /// </remarks>
            public int Wetness2SpEffectID 
            {
                get => (int)CellsByName["Wetness2SpEffectID"].Value;
                set => CellsByName["Wetness2SpEffectID"].Value = (int)value;
            }
            

            // Def="s32 spEffectId_forWet03 = -1"
            /// <summary>
            /// Wetness [3] - SpEffect ID (s32)
            /// </summary>
            /// <remarks>
            /// Special effects for wetting 03
            /// </remarks>
            public int Wetness3SpEffectID 
            {
                get => (int)CellsByName["Wetness3SpEffectID"].Value;
                set => CellsByName["Wetness3SpEffectID"].Value = (int)value;
            }
            

            // Def="s32 spEffectId_forWet04 = -1"
            /// <summary>
            /// Wetness [4] - SpEffect ID (s32)
            /// </summary>
            /// <remarks>
            /// Special effects for wetting 04
            /// </remarks>
            public int Wetness4SpEffectID 
            {
                get => (int)CellsByName["Wetness4SpEffectID"].Value;
                set => CellsByName["Wetness4SpEffectID"].Value = (int)value;
            }
            
                }
            }
            

            namespace StronglyTypedParams
            {
                public class DecalParam : ParamRow
                {
                    public DecalParam() : base()
                    {
                    }
            

            // Def="s32 textureId = -1"
            /// <summary>
            /// Texture ID (s32)
            /// </summary>
            /// <remarks>
            /// Texture ID
            /// </remarks>
            public int TextureID 
            {
                get => (int)CellsByName["TextureID"].Value;
                set => CellsByName["TextureID"].Value = value;
            }
            

            // Def="s32 dmypolyId = -1"
            /// <summary>
            /// Dummy Poly ID (s32)
            /// </summary>
            /// <remarks>
            /// Damipoly ID of decal generation standard. If specified by TAE, it will be the value of TAE.
            /// </remarks>
            public int DummyPolyID 
            {
                get => (int)CellsByName["DummyPolyID"].Value;
                set => CellsByName["DummyPolyID"].Value = value;
            }
            

            // Def="f32 pitchAngle"
            /// <summary>
            /// Reference Angle Offset: Pitch (f32)
            /// </summary>
            /// <remarks>
            /// Reference angle offset_up / down [deg]
            /// </remarks>
            public float ReferenceAngleOffsetPitch 
            {
                get => (float)CellsByName["ReferenceAngleOffsetPitch"].Value;
                set => CellsByName["ReferenceAngleOffsetPitch"].Value = value;
            }
            

            // Def="f32 yawAngle"
            /// <summary>
            /// Reference Angle Offset: Yaw (f32)
            /// </summary>
            /// <remarks>
            /// Reference angle offset_left / right [deg]
            /// </remarks>
            public float ReferenceAngleOffsetYaw 
            {
                get => (float)CellsByName["ReferenceAngleOffsetYaw"].Value;
                set => CellsByName["ReferenceAngleOffsetYaw"].Value = value;
            }
            

            // Def="f32 nearDistance"
            /// <summary>
            /// Paste Start Distance (f32)
            /// </summary>
            /// <remarks>
            /// Pasting start distance [m]
            /// </remarks>
            public float PasteStartDistance 
            {
                get => (float)CellsByName["PasteStartDistance"].Value;
                set => CellsByName["PasteStartDistance"].Value = value;
            }
            

            // Def="f32 farDistance"
            /// <summary>
            /// Paste End Distance (f32)
            /// </summary>
            /// <remarks>
            /// Paste end distance [m]
            /// </remarks>
            public float PasteEndDistance 
            {
                get => (float)CellsByName["PasteEndDistance"].Value;
                set => CellsByName["PasteEndDistance"].Value = value;
            }
            

            // Def="f32 nearSize"
            /// <summary>
            /// Start Distance Size (f32)
            /// </summary>
            /// <remarks>
            /// Size at the start distance
            /// </remarks>
            public float StartDistanceSize 
            {
                get => (float)CellsByName["StartDistanceSize"].Value;
                set => CellsByName["StartDistanceSize"].Value = value;
            }
            

            // Def="f32 farSize"
            /// <summary>
            /// End Distance Size (f32)
            /// </summary>
            /// <remarks>
            /// Size at the end distance [m]
            /// </remarks>
            public float EndDistanceSize 
            {
                get => (float)CellsByName["EndDistanceSize"].Value;
                set => CellsByName["EndDistanceSize"].Value = value;
            }
            

            // Def="s32 maskSpeffectId = -1"
            /// <summary>
            /// Mask SpEffect ID (s32)
            /// </summary>
            /// <remarks>
            /// Monitoring special effect ID. If you enter an arbitrary special effect ID, decals will not be generated unless the special effect is applied.
            /// </remarks>
            public int MaskSpEffectID 
            {
                get => (int)CellsByName["MaskSpEffectID"].Value;
                set => CellsByName["MaskSpEffectID"].Value = value;
            }
            

            // Def="u32 pad_10:4"
            /// <summary>
            /// Padding (u32)
            /// </summary>
            /// <remarks>
            /// Padding
            /// </remarks>
            public uint Padding 
            {
                get => (uint)CellsByName["Padding"].Value;
                set => CellsByName["Padding"].Value = value;
            }
            

            // Def="u32 replaceTextureId_byMaterial:1"
            /// <summary>
            /// Texture Replacement by Material (u32)
            /// </summary>
            /// <remarks>
            /// When it is generated by an attack hit, 1 changes the texture depending on the defense material. New Texture ID = Blood Material ID * 10000000 + Original Texture ID
            /// </remarks>
            public uint TextureReplacementByMaterial 
            {
                get => (uint)CellsByName["TextureReplacementByMaterial"].Value;
                set => CellsByName["TextureReplacementByMaterial"].Value = value;
            }
            

            // Def="u32 dmypolyCategory:2"
            /// <summary>
            /// Dummy Poly Search Location (u32)
            /// </summary>
            /// <remarks>
            /// Damipoli Search Location 0: Body 1: Left Hand Weapon 2: Right Hand Weapon
            /// </remarks>
            public uint DummyPolySearchLocation 
            {
                get => (uint)CellsByName["DummyPolySearchLocation"].Value;
                set => CellsByName["DummyPolySearchLocation"].Value = value;
            }
            


            // Def="u32 useDeferredDecal:1 = 1"
            /// <summary>
            /// Use Deferred Decal (u32)
            /// </summary>
            /// <remarks>
            /// Acts as a deferred decal at 1
            /// </remarks>
            public uint UseDeferredDecal 
            {
                get => (uint)CellsByName["UseDeferredDecal"].Value;
                set => CellsByName["UseDeferredDecal"].Value = value;
            }
            

            // Def="u32 usePaintDecal:1 = 1"
            /// <summary>
            /// Use Paint Decal (u32)
            /// </summary>
            /// <remarks>
            /// Acts as a paint decal at 1
            /// </remarks>
            public uint UsePaintDecal 
            {
                get => (uint)CellsByName["UsePaintDecal"].Value;
                set => CellsByName["UsePaintDecal"].Value = value;
            }
            

            // Def="u32 bloodTypeEnable:1"
            /// <summary>
            /// Blood Type Enable (u32)
            /// </summary>
            /// <remarks>
            /// Affected by optional bloody expression, ID is +1000 in mild, do not paste if hidden
            /// </remarks>
            public uint BloodTypeEnable 
            {
                get => (uint)CellsByName["BloodTypeEnable"].Value;
                set => CellsByName["BloodTypeEnable"].Value = value;
            }
            

            // Def="u32 bUseNormal:1"
            /// <summary>
            /// Use Normal Component (u32)
            /// </summary>
            /// <remarks>
            /// 1 if normal component is used (compatible with normal and shinyness texture integration)
            /// </remarks>
            public uint UseNormalComponent 
            {
                get => (uint)CellsByName["UseNormalComponent"].Value;
                set => CellsByName["UseNormalComponent"].Value = value;
            }
            



            // Def="u32 usePom:1"
            /// <summary>
            /// Enable POM (u32)
            /// </summary>
            /// <remarks>
            /// Whether to enable POM
            /// </remarks>
            public uint EnablePOM 
            {
                get => (uint)CellsByName["EnablePOM"].Value;
                set => CellsByName["EnablePOM"].Value = value;
            }
            

            // Def="u32 useEmissive:1"
            /// <summary>
            /// Enable Emissive (u32)
            /// </summary>
            /// <remarks>
            /// Whether to update emissive
            /// </remarks>
            public uint EnableEmissive 
            {
                get => (uint)CellsByName["EnableEmissive"].Value;
                set => CellsByName["EnableEmissive"].Value = value;
            }
            

            // Def="u32 putVertical:1"
            /// <summary>
            /// Enable Vertical Paste (u32)
            /// </summary>
            /// <remarks>
            /// Whether to paste vertically
            /// </remarks>
            public uint EnableVerticalPaste 
            {
                get => (uint)CellsByName["EnableVerticalPaste"].Value;
                set => CellsByName["EnableVerticalPaste"].Value = value;
            }
            

            // Def="s16 randomSizeMin = 100"
            /// <summary>
            /// Random Scale % - Min (s16)
            /// </summary>
            /// <remarks>
            /// Random scale minimum [%]
            /// </remarks>
            public short RandomScalePercentMin 
            {
                get => (short)CellsByName["RandomScalePercentMin"].Value;
                set => CellsByName["RandomScalePercentMin"].Value = value;
            }
            

            // Def="s16 randomSizeMax = 100"
            /// <summary>
            /// Random Scale % - Max (s16)
            /// </summary>
            /// <remarks>
            /// Random scale maximum [%]
            /// </remarks>
            public short RandomScalePercentMax 
            {
                get => (short)CellsByName["RandomScalePercentMax"].Value;
                set => CellsByName["RandomScalePercentMax"].Value = value;
            }
            

            // Def="f32 randomRollMin"
            /// <summary>
            /// Random Angle Roll - Min (f32)
            /// </summary>
            /// <remarks>
            /// Random angle_minimum twist [deg]
            /// </remarks>
            public float RandomAngleRollMin 
            {
                get => (float)CellsByName["RandomAngleRollMin"].Value;
                set => CellsByName["RandomAngleRollMin"].Value = value;
            }
            

            // Def="f32 randomRollMax"
            /// <summary>
            /// Random Angle Roll - Max (f32)
            /// </summary>
            /// <remarks>
            /// Random angle _ maximum twist [deg]
            /// </remarks>
            public float RandomAngleRollMax 
            {
                get => (float)CellsByName["RandomAngleRollMax"].Value;
                set => CellsByName["RandomAngleRollMax"].Value = value;
            }
            

            // Def="f32 randomPitchMin"
            /// <summary>
            /// Random Angle Pitch - Min (f32)
            /// </summary>
            /// <remarks>
            /// Random angle_minimum top and bottom [deg]
            /// </remarks>
            public float RandomAnglePitchMin 
            {
                get => (float)CellsByName["RandomAnglePitchMin"].Value;
                set => CellsByName["RandomAnglePitchMin"].Value = value;
            }
            

            // Def="f32 randomPitchMax"
            /// <summary>
            /// Random Angle Pitch - Max (f32)
            /// </summary>
            /// <remarks>
            /// Random angle_maximum value [deg]
            /// </remarks>
            public float RandomAnglePitchMax 
            {
                get => (float)CellsByName["RandomAnglePitchMax"].Value;
                set => CellsByName["RandomAnglePitchMax"].Value = value;
            }
            

            // Def="f32 randomYawMin"
            /// <summary>
            /// Random Angle Yaw - Min (f32)
            /// </summary>
            /// <remarks>
            /// Random angle_minimum left and right [deg]
            /// </remarks>
            public float RandomAngleYawMin 
            {
                get => (float)CellsByName["RandomAngleYawMin"].Value;
                set => CellsByName["RandomAngleYawMin"].Value = value;
            }
            

            // Def="f32 randomYawMax"
            /// <summary>
            /// Random Angle Yaw - Max (f32)
            /// </summary>
            /// <remarks>
            /// Random angle_maximum left and right [deg]
            /// </remarks>
            public float RandomAngleYawMax 
            {
                get => (float)CellsByName["RandomAngleYawMax"].Value;
                set => CellsByName["RandomAngleYawMax"].Value = value;
            }
            

            // Def="f32 pomHightScale = 1"
            /// <summary>
            /// POM Height Scale (f32)
            /// </summary>
            /// <remarks>
            /// POM height scale
            /// </remarks>
            public float POMHeightScale 
            {
                get => (float)CellsByName["POMHeightScale"].Value;
                set => CellsByName["POMHeightScale"].Value = value;
            }
            

            // Def="u8 pomSampleMin = 8"
            /// <summary>
            /// POM Sample - Minimum Count (u8)
            /// </summary>
            /// <remarks>
            /// Minimum number of POM samples
            /// </remarks>
            public byte POMSampleMinimumCount 
            {
                get => (byte)CellsByName["POMSampleMinimumCount"].Value;
                set => CellsByName["POMSampleMinimumCount"].Value = value;
            }
            

            // Def="u8 pomSampleMax = 64"
            /// <summary>
            /// POM Sample - Maximum Count (u8)
            /// </summary>
            /// <remarks>
            /// Maximum number of POM samples
            /// </remarks>
            public byte POMSampleMaximumCount 
            {
                get => (byte)CellsByName["POMSampleMaximumCount"].Value;
                set => CellsByName["POMSampleMaximumCount"].Value = value;
            }
            

            // Def="s8 blendMode = 1"
            /// <summary>
            /// Blend Mode (s8)
            /// </summary>
            /// <remarks>
            /// Blend mode
            /// </remarks>
            public sbyte BlendMode 
            {
                get => (sbyte)CellsByName["BlendMode"].Value;
                set => CellsByName["BlendMode"].Value = value;
            }
            

            // Def="s8 appearDirType"
            /// <summary>
            /// Appearance Direction Type (s8)
            /// </summary>
            /// <remarks>
            /// Reference coordinates that determine the direction in which the decal is flown
            /// </remarks>
            public sbyte AppearanceDirectionType 
            {
                get => (sbyte)CellsByName["AppearanceDirectionType"].Value;
                set => CellsByName["AppearanceDirectionType"].Value = value;
            }
            

            // Def="f32 emissiveValueBegin = 1"
            /// <summary>
            /// Emissive Value: Start (f32)
            /// </summary>
            /// <remarks>
            /// Emissive starting price
            /// </remarks>
            public float EmissiveValueStart 
            {
                get => (float)CellsByName["EmissiveValueStart"].Value;
                set => CellsByName["EmissiveValueStart"].Value = value;
            }
            

            // Def="f32 emissiveValueEnd = 1"
            /// <summary>
            /// Emissive Value: End (f32)
            /// </summary>
            /// <remarks>
            /// Emissive end value
            /// </remarks>
            public float EmissiveValueEnd 
            {
                get => (float)CellsByName["EmissiveValueEnd"].Value;
                set => CellsByName["EmissiveValueEnd"].Value = value;
            }
            

            // Def="f32 emissiveTime"
            /// <summary>
            /// Emissive Update Time (f32)
            /// </summary>
            /// <remarks>
            /// Interpolation time from start value to end value
            /// </remarks>
            public float EmissiveUpdateTime 
            {
                get => (float)CellsByName["EmissiveUpdateTime"].Value;
                set => CellsByName["EmissiveUpdateTime"].Value = value;
            }
            

            // Def="u8 bIntpEnable"
            /// <summary>
            /// Enable Interpolation (u8)
            /// </summary>
            /// <remarks>
            /// Do you generate the time when the bar is extended due to the decal generation of TAE?
            /// </remarks>
            public byte EnableInterpolation 
            {
                get => (byte)CellsByName["EnableInterpolation"].Value;
                set => CellsByName["EnableInterpolation"].Value = value;
            }
            


            // Def="f32 intpIntervalDist = 0.1"
            /// <summary>
            /// Interpolation Interval Distance (f32)
            /// </summary>
            /// <remarks>
            /// Distance to interpolate decals generated between TAE bars when interpolation is enabled
            /// </remarks>
            public float InterpolationIntervalDistance 
            {
                get => (float)CellsByName["InterpolationIntervalDistance"].Value;
                set => CellsByName["InterpolationIntervalDistance"].Value = value;
            }
            

            // Def="s32 beginIntpTextureId = -1"
            /// <summary>
            /// Interpolation Start - Texture ID (s32)
            /// </summary>
            /// <remarks>
            /// Texture ID at the start of interpolation (-1 uses the same value as the texture ID)
            /// </remarks>
            public int InterpolationStartTextureID 
            {
                get => (int)CellsByName["InterpolationStartTextureID"].Value;
                set => CellsByName["InterpolationStartTextureID"].Value = value;
            }
            

            // Def="s32 endIntpTextureId = -1"
            /// <summary>
            /// Interpolation End - Texture ID (s32)
            /// </summary>
            /// <remarks>
            /// Texture at the end of interpolation Texture ID (-1 uses the same value as the texture ID)
            /// </remarks>
            public int InterpolationEndTextureID 
            {
                get => (int)CellsByName["InterpolationEndTextureID"].Value;
                set => CellsByName["InterpolationEndTextureID"].Value = value;
            }
            

            // Def="s32 appearSfxId = -1"
            /// <summary>
            /// Appearance SFX ID (s32)
            /// </summary>
            /// <remarks>
            /// SFXID issued when the decal is affixed (Nothing is issued with -1)
            /// </remarks>
            public int AppearanceSFXID 
            {
                get => (int)CellsByName["AppearanceSFXID"].Value;
                set => CellsByName["AppearanceSFXID"].Value = value;
            }
            

            // Def="f32 appearSfxOffsetPos"
            /// <summary>
            /// Appearance SFX Offset Position (f32)
            /// </summary>
            /// <remarks>
            /// Offset distance of SFX generation position
            /// </remarks>
            public float AppearanceSFXOffsetPosition 
            {
                get => (float)CellsByName["AppearanceSFXOffsetPosition"].Value;
                set => CellsByName["AppearanceSFXOffsetPosition"].Value = value;
            }
            

            // Def="s32 maskTextureId = -1"
            /// <summary>
            /// Mask Texture ID (s32)
            /// </summary>
            /// <remarks>
            /// Mask texture ID (see texture ID with -1)
            /// </remarks>
            public int MaskTextureID 
            {
                get => (int)CellsByName["MaskTextureID"].Value;
                set => CellsByName["MaskTextureID"].Value = value;
            }
            

            // Def="s32 diffuseTextureId = -1"
            /// <summary>
            /// Diffuse Texture ID (s32)
            /// </summary>
            /// <remarks>
            /// Albedo Texture ID (See Texture ID with -1)
            /// </remarks>
            public int DiffuseTextureID 
            {
                get => (int)CellsByName["DiffuseTextureID"].Value;
                set => CellsByName["DiffuseTextureID"].Value = value;
            }
            

            // Def="s32 reflecTextureId = -1"
            /// <summary>
            /// Reflect Texture ID (s32)
            /// </summary>
            /// <remarks>
            /// Reflectance texture ID (see texture ID with -1)
            /// </remarks>
            public int ReflectTextureID 
            {
                get => (int)CellsByName["ReflectTextureID"].Value;
                set => CellsByName["ReflectTextureID"].Value = value;
            }
            

            // Def="f32 maskScale = 1"
            /// <summary>
            /// Mask Strength Scale (f32)
            /// </summary>
            /// <remarks>
            /// Mask strength (currently valid only with deferred decals)
            /// </remarks>
            public float MaskStrengthScale 
            {
                get => (float)CellsByName["MaskStrengthScale"].Value;
                set => CellsByName["MaskStrengthScale"].Value = value;
            }
            

            // Def="s32 normalTextureId = -1"
            /// <summary>
            /// Normal Texture ID (s32)
            /// </summary>
            /// <remarks>
            /// Normal texture ID (see texture ID with -1)
            /// </remarks>
            public int NormalTextureID 
            {
                get => (int)CellsByName["NormalTextureID"].Value;
                set => CellsByName["NormalTextureID"].Value = value;
            }
            

            // Def="s32 heightTextureId = -1"
            /// <summary>
            /// Height Texture ID (s32)
            /// </summary>
            /// <remarks>
            /// Height texture ID (see texture ID with -1)
            /// </remarks>
            public int HeightTextureID 
            {
                get => (int)CellsByName["HeightTextureID"].Value;
                set => CellsByName["HeightTextureID"].Value = value;
            }
            

            // Def="s32 emissiveTextureId = -1"
            /// <summary>
            /// Emissive Texture ID (s32)
            /// </summary>
            /// <remarks>
            /// Emissive Texture ID (See Texture ID with -1)
            /// </remarks>
            public int EmissiveTextureID 
            {
                get => (int)CellsByName["EmissiveTextureID"].Value;
                set => CellsByName["EmissiveTextureID"].Value = value;
            }
            

            // Def="u8 diffuseColorR = 255"
            /// <summary>
            /// Diffuse Color: R (u8)
            /// </summary>
            /// <remarks>
            /// Albedo color: R
            /// </remarks>
            public byte DiffuseColorR 
            {
                get => (byte)CellsByName["DiffuseColorR"].Value;
                set => CellsByName["DiffuseColorR"].Value = value;
            }
            

            // Def="u8 diffuseColorG = 255"
            /// <summary>
            /// Diffuse Color: G (u8)
            /// </summary>
            /// <remarks>
            /// Albedo color: G
            /// </remarks>
            public byte DiffuseColorG 
            {
                get => (byte)CellsByName["DiffuseColorG"].Value;
                set => CellsByName["DiffuseColorG"].Value = value;
            }
            

            // Def="u8 diffuseColorB = 255"
            /// <summary>
            /// Diffuse Color: B (u8)
            /// </summary>
            /// <remarks>
            /// Albedo color: B
            /// </remarks>
            public byte DiffuseColorB 
            {
                get => (byte)CellsByName["DiffuseColorB"].Value;
                set => CellsByName["DiffuseColorB"].Value = value;
            }
            


            // Def="u8 reflecColorR = 255"
            /// <summary>
            /// Reflect Color: R (u8)
            /// </summary>
            /// <remarks>
            /// Reflect color: R
            /// </remarks>
            public byte ReflectColorR 
            {
                get => (byte)CellsByName["ReflectColorR"].Value;
                set => CellsByName["ReflectColorR"].Value = value;
            }
            

            // Def="u8 reflecColorG = 255"
            /// <summary>
            /// Reflect Color: G (u8)
            /// </summary>
            /// <remarks>
            /// Reflect color: G
            /// </remarks>
            public byte ReflectColorG 
            {
                get => (byte)CellsByName["ReflectColorG"].Value;
                set => CellsByName["ReflectColorG"].Value = value;
            }
            

            // Def="u8 reflecColorB = 255"
            /// <summary>
            /// Reflect Color: B (u8)
            /// </summary>
            /// <remarks>
            /// Reflect color: B
            /// </remarks>
            public byte ReflectColorB 
            {
                get => (byte)CellsByName["ReflectColorB"].Value;
                set => CellsByName["ReflectColorB"].Value = value;
            }
            

            // Def="u8 bLifeEnable"
            /// <summary>
            /// Life Enable (u8)
            /// </summary>
            /// <remarks>
            /// Is the life effective?
            /// </remarks>
            public byte LifeEnable 
            {
                get => (byte)CellsByName["LifeEnable"].Value;
                set => CellsByName["LifeEnable"].Value = value;
            }
            

            // Def="f32 siniScale = 1"
            /// <summary>
            /// Shininess Scale (f32)
            /// </summary>
            /// <remarks>
            /// The strength of shinyness
            /// </remarks>
            public float ShininessScale 
            {
                get => (float)CellsByName["ShininessScale"].Value;
                set => CellsByName["ShininessScale"].Value = value;
            }
            

            // Def="f32 lifeTimeSec"
            /// <summary>
            /// Decal Duration (f32)
            /// </summary>
            /// <remarks>
            /// Lifespan [seconds] (Time after decal is applied, fade-in time does not matter)
            /// </remarks>
            public float DecalDuration 
            {
                get => (float)CellsByName["DecalDuration"].Value;
                set => CellsByName["DecalDuration"].Value = value;
            }
            

            // Def="f32 fadeOutTimeSec"
            /// <summary>
            /// Decal Fadeout Time (f32)
            /// </summary>
            /// <remarks>
            /// Fade out time [seconds]
            /// </remarks>
            public float DecalFadeoutTime 
            {
                get => (float)CellsByName["DecalFadeoutTime"].Value;
                set => CellsByName["DecalFadeoutTime"].Value = value;
            }
            

            // Def="s16 priority = -1"
            /// <summary>
            /// Decal Priority (s16)
            /// </summary>
            /// <remarks>
            /// The larger this value, the easier it is to remain (-1 does not disappear)
            /// </remarks>
            public short DecalPriority 
            {
                get => (short)CellsByName["DecalPriority"].Value;
                set => CellsByName["DecalPriority"].Value = value;
            }
            

            // Def="u8 bDistThinOutEnable"
            /// <summary>
            /// Thin Out Nearby Decal (u8)
            /// </summary>
            /// <remarks>
            /// Whether to thin out if there is a decal nearby
            /// </remarks>
            public byte ThinOutNearbyDecal 
            {
                get => (byte)CellsByName["ThinOutNearbyDecal"].Value;
                set => CellsByName["ThinOutNearbyDecal"].Value = value;
            }
            

            // Def="u8 bAlignedTexRandomVariationEnable"
            /// <summary>
            /// Enable Aligned Texture Random Variation (u8)
            /// </summary>
            /// <remarks>
            /// If you select "Yes", one variation number randomly determined for each texture other than 0 will be applied. The number of non-zero variations must be the same.
            /// </remarks>
            public byte EnableAlignedTextureRandomVariation 
            {
                get => (byte)CellsByName["EnableAlignedTextureRandomVariation"].Value;
                set => CellsByName["EnableAlignedTextureRandomVariation"].Value = value;
            }
            

            // Def="f32 distThinOutCheckDist"
            /// <summary>
            /// Decal Thin Out - Check Distance (f32)
            /// </summary>
            /// <remarks>
            /// Candidates for thinning if there is a decal within this distance
            /// </remarks>
            public float DecalThinOutCheckDistance 
            {
                get => (float)CellsByName["DecalThinOutCheckDistance"].Value;
                set => CellsByName["DecalThinOutCheckDistance"].Value = value;
            }
            

            // Def="f32 distThinOutCheckAngleDeg"
            /// <summary>
            /// Decal Thin Out - Check Angle (f32)
            /// </summary>
            /// <remarks>
            /// Candidates for thinning if the difference in decal direction is within this angle
            /// </remarks>
            public float DecalThinOutCheckAngle 
            {
                get => (float)CellsByName["DecalThinOutCheckAngle"].Value;
                set => CellsByName["DecalThinOutCheckAngle"].Value = value;
            }
            

            // Def="u8 distThinOutMaxNum = 1"
            /// <summary>
            /// Decal Thin Out - Max Count (u8)
            /// </summary>
            /// <remarks>
            /// If the distance and angle are more than this number, thin out
            /// </remarks>
            public byte DecalThinOutMaxCount 
            {
                get => (byte)CellsByName["DecalThinOutMaxCount"].Value;
                set => CellsByName["DecalThinOutMaxCount"].Value = value;
            }
            

            // Def="u8 distThinOutCheckNum = 1"
            /// <summary>
            /// Decal Thin Out - Check Count (u8)
            /// </summary>
            /// <remarks>
            /// How many recent thinning candidates to check
            /// </remarks>
            public byte DecalThinOutCheckCount 
            {
                get => (byte)CellsByName["DecalThinOutCheckCount"].Value;
                set => CellsByName["DecalThinOutCheckCount"].Value = value;
            }
            

            // Def="s16 delayAppearFrame"
            /// <summary>
            /// Decal Spawn Delay (s16)
            /// </summary>
            /// <remarks>
            /// After trying to paste the decal, it will actually be pasted after this frame
            /// </remarks>
            public short DecalSpawnDelay 
            {
                get => (short)CellsByName["DecalSpawnDelay"].Value;
                set => CellsByName["DecalSpawnDelay"].Value = value;
            }
            

            // Def="u32 randVaria_Diffuse:4"
            /// <summary>
            /// Random Variation - Diffuse (u32)
            /// </summary>
            /// <remarks>
            /// Number of random variations of albedo texture (including 0th, 2 for 2 textures)
            /// </remarks>
            public uint RandomVariationDiffuse 
            {
                get => (uint)CellsByName["RandomVariationDiffuse"].Value;
                set => CellsByName["RandomVariationDiffuse"].Value = value;
            }
            

            // Def="u32 randVaria_Mask:4"
            /// <summary>
            /// Random Variation - Mask (u32)
            /// </summary>
            /// <remarks>
            /// Number of random variations of mask texture (including 0th, 2 for 2 textures)
            /// </remarks>
            public uint RandomVariationMask 
            {
                get => (uint)CellsByName["RandomVariationMask"].Value;
                set => CellsByName["RandomVariationMask"].Value = value;
            }
            

            // Def="u32 randVaria_Reflec:4"
            /// <summary>
            /// Random Variation - Reflect (u32)
            /// </summary>
            /// <remarks>
            /// Number of random variations of reflex textures (including 0th, 2 for 2 textures)
            /// </remarks>
            public uint RandomVariationReflect 
            {
                get => (uint)CellsByName["RandomVariationReflect"].Value;
                set => CellsByName["RandomVariationReflect"].Value = value;
            }
            


            // Def="u32 randVaria_Normal:4"
            /// <summary>
            /// Random Variation - Normal (u32)
            /// </summary>
            /// <remarks>
            /// Number of random variations of normal texture (including 0th, 2 for 2 textures)
            /// </remarks>
            public uint RandomVariationNormal 
            {
                get => (uint)CellsByName["RandomVariationNormal"].Value;
                set => CellsByName["RandomVariationNormal"].Value = value;
            }
            

            // Def="u32 randVaria_Height:4"
            /// <summary>
            /// Random Variation - Height (u32)
            /// </summary>
            /// <remarks>
            /// Number of random variations of height texture (including 0th, 2 for 2 textures)
            /// </remarks>
            public uint RandomVariationHeight 
            {
                get => (uint)CellsByName["RandomVariationHeight"].Value;
                set => CellsByName["RandomVariationHeight"].Value = value;
            }
            

            // Def="u32 randVaria_Emissive:4"
            /// <summary>
            /// Random Variation - Emissive (u32)
            /// </summary>
            /// <remarks>
            /// Number of random variations of emissive textures (including 0th, 2 for 2 textures)
            /// </remarks>
            public uint RandomVariationEmissive 
            {
                get => (uint)CellsByName["RandomVariationEmissive"].Value;
                set => CellsByName["RandomVariationEmissive"].Value = value;
            }
            


            // Def="f32 fadeInTimeSec"
            /// <summary>
            /// Fade In Spawn Delay (f32)
            /// </summary>
            /// <remarks>
            /// Fade-in time [seconds]
            /// </remarks>
            public float FadeInSpawnDelay 
            {
                get => (float)CellsByName["FadeInSpawnDelay"].Value;
                set => CellsByName["FadeInSpawnDelay"].Value = value;
            }
            

            // Def="f32 thinOutOverlapMultiRadius"
            /// <summary>
            /// Thin Out - Overlap Multiplier Radius (f32)
            /// </summary>
            /// <remarks>
            /// Determine if the decal size is duplicated by multiplying it by this value.
            /// </remarks>
            public float ThinOutOverlapMultiplierRadius 
            {
                get => (float)CellsByName["ThinOutOverlapMultiplierRadius"].Value;
                set => CellsByName["ThinOutOverlapMultiplierRadius"].Value = value;
            }
            

            // Def="f32 thinOutNeighborAddRadius"
            /// <summary>
            /// Thin Out - Neighbor Addition Radius (f32)
            /// </summary>
            /// <remarks>
            /// Judge whether it is a neighborhood within the range of adding this distance [m] to the decal size.
            /// </remarks>
            public float ThinOutNeighborAdditionRadius 
            {
                get => (float)CellsByName["ThinOutNeighborAdditionRadius"].Value;
                set => CellsByName["ThinOutNeighborAdditionRadius"].Value = value;
            }
            

            // Def="u32 thinOutOverlapLimitNum"
            /// <summary>
            /// Thin Out - Overlap Limit Number (u32)
            /// </summary>
            /// <remarks>
            /// Limit number that can be duplicated
            /// </remarks>
            public uint ThinOutOverlapLimitNumber 
            {
                get => (uint)CellsByName["ThinOutOverlapLimitNumber"].Value;
                set => CellsByName["ThinOutOverlapLimitNumber"].Value = value;
            }
            

            // Def="u32 thinOutNeighborLimitNum"
            /// <summary>
            /// Thin Out - Neighbor Limit Number (u32)
            /// </summary>
            /// <remarks>
            /// Maximum number of neighbors
            /// </remarks>
            public uint ThinOutNeighborLimitNumber 
            {
                get => (uint)CellsByName["ThinOutNeighborLimitNumber"].Value;
                set => CellsByName["ThinOutNeighborLimitNumber"].Value = value;
            }
            

            // Def="s8 thinOutMode"
            /// <summary>
            /// Thin Out Mode (s8)
            /// </summary>
            /// <remarks>
            /// Thinning mode
            /// </remarks>
            public sbyte ThinOutMode 
            {
                get => (sbyte)CellsByName["ThinOutMode"].Value;
                set => CellsByName["ThinOutMode"].Value = value;
            }
            

            // Def="u8 emissiveColorR = 255"
            /// <summary>
            /// Emissive Color: R (u8)
            /// </summary>
            /// <remarks>
            /// Emissive color: R
            /// </remarks>
            public byte EmissiveColorR 
            {
                get => (byte)CellsByName["EmissiveColorR"].Value;
                set => CellsByName["EmissiveColorR"].Value = value;
            }
            

            // Def="u8 emissiveColorG = 255"
            /// <summary>
            /// Emissive Color: G (u8)
            /// </summary>
            /// <remarks>
            /// Emissive color: G
            /// </remarks>
            public byte EmissiveColorG 
            {
                get => (byte)CellsByName["EmissiveColorG"].Value;
                set => CellsByName["EmissiveColorG"].Value = value;
            }
            

            // Def="u8 emissiveColorB = 255"
            /// <summary>
            /// Emissive Color: B (u8)
            /// </summary>
            /// <remarks>
            /// Emissive color: B
            /// </remarks>
            public byte EmissiveColorB 
            {
                get => (byte)CellsByName["EmissiveColorB"].Value;
                set => CellsByName["EmissiveColorB"].Value = value;
            }
            

            // Def="f32 maxDecalSfxCreatableSlopeAngleDeg = -1"
            /// <summary>
            /// Decal SFX Creation Max Angle (f32)
            /// </summary>
            /// <remarks>
            /// SFX generation upper limit angle
            /// </remarks>
            public float DecalSFXCreationMaxAngle 
            {
                get => (float)CellsByName["DecalSFXCreationMaxAngle"].Value;
                set => CellsByName["DecalSFXCreationMaxAngle"].Value = value;
            }
            

                }
            }
            
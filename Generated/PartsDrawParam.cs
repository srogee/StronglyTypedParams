
            namespace StronglyTypedParams
            {
                // PARTS_DRAW_PARAM_ST
                public class PartsDrawParam : ParamRow
                {
                    public PartsDrawParam() : base()
                    {
                    }
            

            // Def="f32 lv01_BorderDist = 5"
            /// <summary>
            /// LOD 0-1 Boundry Distance (f32)
            /// </summary>
            /// <remarks>
            /// Switching center
            /// </remarks>
            public float LOD01BoundryDistance 
            {
                get => (float)CellsByName["LOD01BoundryDistance"].Value;
                set => CellsByName["LOD01BoundryDistance"].Value = (float)value;
            }
            

            // Def="f32 lv01_PlayDist = 1"
            /// <summary>
            /// LOD 0-1 Play Distance (f32)
            /// </summary>
            /// <remarks>
            /// ± play at the center of the boundary
            /// </remarks>
            public float LOD01PlayDistance 
            {
                get => (float)CellsByName["LOD01PlayDistance"].Value;
                set => CellsByName["LOD01PlayDistance"].Value = (float)value;
            }
            

            // Def="f32 lv12_BorderDist = 20"
            /// <summary>
            /// LOD 1-2 Boundry Distance (f32)
            /// </summary>
            /// <remarks>
            /// Switching center
            /// </remarks>
            public float LOD12BoundryDistance 
            {
                get => (float)CellsByName["LOD12BoundryDistance"].Value;
                set => CellsByName["LOD12BoundryDistance"].Value = (float)value;
            }
            

            // Def="f32 lv12_PlayDist = 2"
            /// <summary>
            /// LOD 1-2 Play Distance (f32)
            /// </summary>
            /// <remarks>
            /// ± play at the center of the boundary
            /// </remarks>
            public float LOD12PlayDistance 
            {
                get => (float)CellsByName["LOD12PlayDistance"].Value;
                set => CellsByName["LOD12PlayDistance"].Value = (float)value;
            }
            

            // Def="f32 lv23_BorderDist = 30"
            /// <summary>
            /// LOD 2-3 Boundry Distance (f32)
            /// </summary>
            /// <remarks>
            /// Switching center
            /// </remarks>
            public float LOD23BoundryDistance 
            {
                get => (float)CellsByName["LOD23BoundryDistance"].Value;
                set => CellsByName["LOD23BoundryDistance"].Value = (float)value;
            }
            

            // Def="f32 lv23_PlayDist"
            /// <summary>
            /// LOD 2-3 Play Distance (f32)
            /// </summary>
            /// <remarks>
            /// ± play at the center of the boundary
            /// </remarks>
            public float LOD23PlayDistance 
            {
                get => (float)CellsByName["LOD23PlayDistance"].Value;
                set => CellsByName["LOD23PlayDistance"].Value = (float)value;
            }
            

            // Def="f32 lv34_BorderDist = 9999"
            /// <summary>
            /// LOD 3-4 Boundry Distance (f32)
            /// </summary>
            /// <remarks>
            /// Switching center
            /// </remarks>
            public float LOD34BoundryDistance 
            {
                get => (float)CellsByName["LOD34BoundryDistance"].Value;
                set => CellsByName["LOD34BoundryDistance"].Value = (float)value;
            }
            

            // Def="f32 lv34_PlayDist"
            /// <summary>
            /// LOD 3-4 Play Distance (f32)
            /// </summary>
            /// <remarks>
            /// ± play at the center of the boundary
            /// </remarks>
            public float LOD34PlayDistance 
            {
                get => (float)CellsByName["LOD34PlayDistance"].Value;
                set => CellsByName["LOD34PlayDistance"].Value = (float)value;
            }
            

            // Def="f32 lv45_BorderDist = 9999"
            /// <summary>
            /// LOD 4-5 Boundry Distance (f32)
            /// </summary>
            /// <remarks>
            /// Switching center
            /// </remarks>
            public float LOD45BoundryDistance 
            {
                get => (float)CellsByName["LOD45BoundryDistance"].Value;
                set => CellsByName["LOD45BoundryDistance"].Value = (float)value;
            }
            

            // Def="f32 lv45_PlayDist"
            /// <summary>
            /// LOD 4-5 Play Distance (f32)
            /// </summary>
            /// <remarks>
            /// ± play at the center of the boundary
            /// </remarks>
            public float LOD45PlayDistance 
            {
                get => (float)CellsByName["LOD45PlayDistance"].Value;
                set => CellsByName["LOD45PlayDistance"].Value = (float)value;
            }
            

            // Def="f32 tex_lv01_BorderDist = 30"
            /// <summary>
            /// Texture Switch - LOD 0-1 Boundry Distance (f32)
            /// </summary>
            /// <remarks>
            /// Texture switching center (Texure LOD disabled at 0)
            /// </remarks>
            public float TextureSwitchLOD01BoundryDistance 
            {
                get => (float)CellsByName["TextureSwitchLOD01BoundryDistance"].Value;
                set => CellsByName["TextureSwitchLOD01BoundryDistance"].Value = (float)value;
            }
            

            // Def="f32 tex_lv01_PlayDist = 1"
            /// <summary>
            /// Texture Switch - LOD 0-1 Play Distance (f32)
            /// </summary>
            /// <remarks>
            /// Texture Play around the boundary
            /// </remarks>
            public float TextureSwitchLOD01PlayDistance 
            {
                get => (float)CellsByName["TextureSwitchLOD01PlayDistance"].Value;
                set => CellsByName["TextureSwitchLOD01PlayDistance"].Value = (float)value;
            }
            

            // Def="u32 enableCrossFade:1"
            /// <summary>
            /// Enable Crossfade (u32)
            /// </summary>
            /// <remarks>
            /// Is crossfade enabled (0: disabled, 1: enabled)?
            /// </remarks>
            public uint EnableCrossfade 
            {
                get => (uint)CellsByName["EnableCrossfade"].Value;
                set => CellsByName["EnableCrossfade"].Value = (uint)value;
            }
            

            // Def="f32 drawDist = 9999"
            /// <summary>
            /// Draw - Max Distance (f32)
            /// </summary>
            /// <remarks>
            /// Maximum drawing distance. In the open, it will be used for the activation distance
            /// </remarks>
            public float DrawMaxDistance 
            {
                get => (float)CellsByName["DrawMaxDistance"].Value;
                set => CellsByName["DrawMaxDistance"].Value = (float)value;
            }
            

            // Def="f32 drawFadeRange"
            /// <summary>
            /// Draw - Fade Range (f32)
            /// </summary>
            /// <remarks>
            /// Fade distance from the maximum drawing distance to the actual disappearance
            /// </remarks>
            public float DrawFadeRange 
            {
                get => (float)CellsByName["DrawFadeRange"].Value;
                set => CellsByName["DrawFadeRange"].Value = (float)value;
            }
            

            // Def="f32 shadowDrawDist = 9999"
            /// <summary>
            /// Shadow Draw - Max Distance (f32)
            /// </summary>
            /// <remarks>
            /// Maximum shadow drawing distance
            /// </remarks>
            public float ShadowDrawMaxDistance 
            {
                get => (float)CellsByName["ShadowDrawMaxDistance"].Value;
                set => CellsByName["ShadowDrawMaxDistance"].Value = (float)value;
            }
            

            // Def="f32 shadowFadeRange"
            /// <summary>
            /// Shadow Draw - Fade Range (f32)
            /// </summary>
            /// <remarks>
            /// Fade distance from the maximum shadow drawing distance to the actual disappearance
            /// </remarks>
            public float ShadowDrawFadeRange 
            {
                get => (float)CellsByName["ShadowDrawFadeRange"].Value;
                set => CellsByName["ShadowDrawFadeRange"].Value = (float)value;
            }
            

            // Def="f32 motionBlur_BorderDist = 20"
            /// <summary>
            /// Motion Blur - Max Distance (f32)
            /// </summary>
            /// <remarks>
            /// Distance at which motion blur is enabled
            /// </remarks>
            public float MotionBlurMaxDistance 
            {
                get => (float)CellsByName["MotionBlurMaxDistance"].Value;
                set => CellsByName["MotionBlurMaxDistance"].Value = (float)value;
            }
            

            // Def="s8 isPointLightShadowSrc"
            /// <summary>
            /// Is Point Light Shadow Source (s8)
            /// </summary>
            /// <remarks>
            /// Cast the shadow of a point light source
            /// </remarks>
            public sbyte IsPointLightShadowSource 
            {
                get => (sbyte)CellsByName["IsPointLightShadowSource"].Value;
                set => CellsByName["IsPointLightShadowSource"].Value = (sbyte)value;
            }
            

            // Def="s8 isDirLightShadowSrc"
            /// <summary>
            /// Is Directional Light Shadow Source (s8)
            /// </summary>
            /// <remarks>
            /// Cast the shadow of a parallel light source
            /// </remarks>
            public sbyte IsDirectionalLightShadowSource 
            {
                get => (sbyte)CellsByName["IsDirectionalLightShadowSource"].Value;
                set => CellsByName["IsDirectionalLightShadowSource"].Value = (sbyte)value;
            }
            

            // Def="s8 isShadowDst"
            /// <summary>
            /// Is Shadow Destination (s8)
            /// </summary>
            /// <remarks>
            /// Receive a shadow
            /// </remarks>
            public sbyte IsShadowDestination 
            {
                get => (sbyte)CellsByName["IsShadowDestination"].Value;
                set => CellsByName["IsShadowDestination"].Value = (sbyte)value;
            }
            

            // Def="s8 isShadowOnly"
            /// <summary>
            /// Is Shadow Only (s8)
            /// </summary>
            /// <remarks>
            /// Shadow drawing only
            /// </remarks>
            public sbyte IsShadowOnly 
            {
                get => (sbyte)CellsByName["IsShadowOnly"].Value;
                set => CellsByName["IsShadowOnly"].Value = (sbyte)value;
            }
            

            // Def="s8 drawByReflectCam"
            /// <summary>
            /// Drawn by Reflection Camera (s8)
            /// </summary>
            /// <remarks>
            /// Reflected
            /// </remarks>
            public sbyte DrawnByReflectionCamera 
            {
                get => (sbyte)CellsByName["DrawnByReflectionCamera"].Value;
                set => CellsByName["DrawnByReflectionCamera"].Value = (sbyte)value;
            }
            

            // Def="s8 drawOnlyReflectCam"
            /// <summary>
            /// Drawn only by Reflection Camera (s8)
            /// </summary>
            /// <remarks>
            /// Reflection drawing only
            /// </remarks>
            public sbyte DrawnOnlyByReflectionCamera 
            {
                get => (sbyte)CellsByName["DrawnOnlyByReflectionCamera"].Value;
                set => CellsByName["DrawnOnlyByReflectionCamera"].Value = (sbyte)value;
            }
            

            // Def="s8 IncludeLodMapLv = -1"
            /// <summary>
            /// Include LOD Map Level (s8)
            /// </summary>
            /// <remarks>
            /// What level of LodMap to include
            /// </remarks>
            public sbyte IncludeLODMapLevel 
            {
                get => (sbyte)CellsByName["IncludeLODMapLevel"].Value;
                set => CellsByName["IncludeLODMapLevel"].Value = (sbyte)value;
            }
            

            // Def="u8 isNoFarClipDraw"
            /// <summary>
            /// Disable Far Clip Draw (u8)
            /// </summary>
            /// <remarks>
            /// Disable fur clips and always draw at the innermost depth of the clip space. Mainly for celestial sphere
            /// </remarks>
            public byte DisableFarClipDraw 
            {
                get => (byte)CellsByName["DisableFarClipDraw"].Value;
                set => CellsByName["DisableFarClipDraw"].Value = (byte)value;
            }
            

            // Def="u8 lodType"
            /// <summary>
            /// LOD Type (u8)
            /// </summary>
            /// <remarks>
            /// Type and size of LOD target
            /// </remarks>
            public PartsDrawLodType LODType 
            {
                get => (PartsDrawLodType)CellsByName["LODType"].Value;
                set => CellsByName["LODType"].Value = (byte)value;
            }
            

            // Def="s8 shadowDrawLodOffset"
            /// <summary>
            /// Shadow Draw LOD Offset (s8)
            /// </summary>
            /// <remarks>
            /// LOD level offset value when drawing shadows
            /// </remarks>
            public sbyte ShadowDrawLODOffset 
            {
                get => (sbyte)CellsByName["ShadowDrawLODOffset"].Value;
                set => CellsByName["ShadowDrawLODOffset"].Value = (sbyte)value;
            }
            

            // Def="u8 isTraceCameraXZ"
            /// <summary>
            /// Follow Camera on XZ Plane (u8)
            /// </summary>
            /// <remarks>
            /// Follow the camera on the XZ plane (GR SEQ09242)
            /// </remarks>
            public byte FollowCameraOnXZPlane 
            {
                get => (byte)CellsByName["FollowCameraOnXZPlane"].Value;
                set => CellsByName["FollowCameraOnXZPlane"].Value = (byte)value;
            }
            

            // Def="u8 isSkydomeDrawPhase"
            /// <summary>
            /// Is Celestial Sphere Draw Phase (u8)
            /// </summary>
            /// <remarks>
            /// Set the drawing phase to the celestial sphere (GR SEQ09242)
            /// </remarks>
            public byte IsCelestialSphereDrawPhase 
            {
                get => (byte)CellsByName["IsCelestialSphereDrawPhase"].Value;
                set => CellsByName["IsCelestialSphereDrawPhase"].Value = (byte)value;
            }
            

            // Def="f32 DistantViewModel_BorderDist = 30"
            /// <summary>
            /// Distant LOD - Boundry Distance (f32)
            /// </summary>
            /// <remarks>
            /// Distance switching distance [m]
            /// </remarks>
            public float DistantLODBoundryDistance 
            {
                get => (float)CellsByName["DistantLODBoundryDistance"].Value;
                set => CellsByName["DistantLODBoundryDistance"].Value = (float)value;
            }
            

            // Def="f32 DistantViewModel_PlayDist = 5"
            /// <summary>
            /// Distant LOD - Play Distance (f32)
            /// </summary>
            /// <remarks>
            /// Distant view switching play distance [m]
            /// </remarks>
            public float DistantLODPlayDistance 
            {
                get => (float)CellsByName["DistantLODPlayDistance"].Value;
                set => CellsByName["DistantLODPlayDistance"].Value = (float)value;
            }
            

            // Def="f32 LimtedActivate_BorderDist_forGrid = -1"
            /// <summary>
            /// Open-world - Minimum Boundry Distance (f32)
            /// </summary>
            /// <remarks>
            /// Construction limit distance for open [m]. If the distance to the camera is less than this distance in the open, it will not be built. This is a function for distant view assets. -1: Function disabled (default)
            /// </remarks>
            public float OpenWorldMinimumBoundryDistance 
            {
                get => (float)CellsByName["OpenWorldMinimumBoundryDistance"].Value;
                set => CellsByName["OpenWorldMinimumBoundryDistance"].Value = (float)value;
            }
            

            // Def="f32 LimtedActivate_PlayDist_forGrid = 10"
            /// <summary>
            /// Open-world - Minimum Play Distance (f32)
            /// </summary>
            /// <remarks>
            /// Open construction limit play distance [m]
            /// </remarks>
            public float OpenWorldMinimumPlayDistance 
            {
                get => (float)CellsByName["OpenWorldMinimumPlayDistance"].Value;
                set => CellsByName["OpenWorldMinimumPlayDistance"].Value = (float)value;
            }
            

            // Def="f32 zSortOffsetForNoFarClipDraw"
            /// <summary>
            /// Z Sort Offset for No Far Clip Draw (f32)
            /// </summary>
            /// <remarks>
            /// If the distance from the camera is the same in the same drawing phase, the smaller translucent system is drawn in the foreground, and the opaque system is drawn in the larger value. The base point of the offset is the origin in the celestial sphere drawing phase. Other than that, it is mainly Model AABB. (GR SEQ09242)
            /// </remarks>
            public float ZSortOffsetForNoFarClipDraw 
            {
                get => (float)CellsByName["ZSortOffsetForNoFarClipDraw"].Value;
                set => CellsByName["ZSortOffsetForNoFarClipDraw"].Value = (float)value;
            }
            

            // Def="f32 shadowDrawAlphaTestDist = 9999"
            /// <summary>
            /// Shadow Draw Alpha Test Distance (f32)
            /// </summary>
            /// <remarks>
            /// Distance to perform alpha test when drawing shadow [m]
            /// </remarks>
            public float ShadowDrawAlphaTestDistance 
            {
                get => (float)CellsByName["ShadowDrawAlphaTestDistance"].Value;
                set => CellsByName["ShadowDrawAlphaTestDistance"].Value = (float)value;
            }
            

            // Def="u8 fowardDrawEnvmapBlendType"
            /// <summary>
            /// Forward Draw Envmap Blend Type (u8)
            /// </summary>
            /// <remarks>
            /// Forward Drawing environment map Blend type
            /// </remarks>
            public PartsDrawFowardDrawEnvmapBlendType ForwardDrawEnvmapBlendType 
            {
                get => (PartsDrawFowardDrawEnvmapBlendType)CellsByName["ForwardDrawEnvmapBlendType"].Value;
                set => CellsByName["ForwardDrawEnvmapBlendType"].Value = (byte)value;
            }
            

            // Def="u8 LBDrawDistScaleParamID"
            /// <summary>
            /// Load Balancer - Draw Distance Scale Param ID (u8)
            /// </summary>
            /// <remarks>
            /// Load balancer drawing distance scale parameter ID
            /// </remarks>
            public byte LoadBalancerDrawDistanceScaleParamID 
            {
                get => (byte)CellsByName["LoadBalancerDrawDistanceScaleParamID"].Value;
                set => CellsByName["LoadBalancerDrawDistanceScaleParamID"].Value = (byte)value;
            }
            

            // Def="dummy8 resereve[34]"
            /// <summary>
            /// reserve (dummy8)
            /// </summary>
            /// <remarks>
            /// reserve
            /// </remarks>
            public object Reserve 
            {
                get => (object)CellsByName["Reserve"].Value;
                set => CellsByName["Reserve"].Value = (object)value;
            }
            
                }
            }
            

            namespace StronglyTypedParams
            {
                // RIDE_PARAM_ST
                public class RideParam : ParamRow
                {
                    public RideParam() : base()
                    {
                    }
            

            // Def="u32 atkChrId"
            /// <summary>
            /// Rider - Character ID (u32)
            /// </summary>
            /// <remarks>
            /// It is a parameter that identifies the character of the "riding side" when riding.
            /// </remarks>
            public uint RiderCharacterID 
            {
                get => (uint)CellsByName["RiderCharacterID"].Value;
                set => CellsByName["RiderCharacterID"].Value = (uint)value;
            }
            

            // Def="u32 defChrId"
            /// <summary>
            /// Mount - Character ID (u32)
            /// </summary>
            /// <remarks>
            /// It is a parameter that identifies the character of the "riding side" when riding.
            /// </remarks>
            public uint MountCharacterID 
            {
                get => (uint)CellsByName["MountCharacterID"].Value;
                set => CellsByName["MountCharacterID"].Value = (uint)value;
            }
            

            // Def="s32 rideCamParamId = -1"
            /// <summary>
            /// Ride - Camera Param ID (s32)
            /// </summary>
            /// <remarks>
            /// It is a parameter to change the camera parameter at the time of riding to a dedicated camera. It is a parameter for PC only, and it does not work even if it is set to the enemy.
            /// </remarks>
            public int RideCameraParamID 
            {
                get => (int)CellsByName["RideCameraParamID"].Value;
                set => CellsByName["RideCameraParamID"].Value = (int)value;
            }
            

            // Def="u32 atkChrAnimId"
            /// <summary>
            /// Rider - Character Animation ID (u32)
            /// </summary>
            /// <remarks>
            /// It is a parameter to rewrite the value of variable "RideOnAnimId" set in "RideOn (playback during riding) state" of the tool "HavokAnimationTool (HAT)" that controls character animation playback.
            /// </remarks>
            public uint RiderCharacterAnimationID 
            {
                get => (uint)CellsByName["RiderCharacterAnimationID"].Value;
                set => CellsByName["RiderCharacterAnimationID"].Value = (uint)value;
            }
            

            // Def="u32 defChrAnimId"
            /// <summary>
            /// Mount - Character Animation ID (u32)
            /// </summary>
            /// <remarks>
            /// It is a parameter to rewrite the value of variable "RiddenOnAnimId" set in "RiddenOn (playback when riding) state" of the tool "HavokAnimationTool (HAT)" that controls character animation playback.
            /// </remarks>
            public uint MountCharacterAnimationID 
            {
                get => (uint)CellsByName["MountCharacterAnimationID"].Value;
                set => CellsByName["MountCharacterAnimationID"].Value = (uint)value;
            }
            

            // Def="s32 defAdjustDmyId = -1"
            /// <summary>
            /// Mount - Adjust Dummy Poly ID (s32)
            /// </summary>
            /// <remarks>
            /// This is a Damipoli setting that is required only for the rider (the rider's character does not need to be set).
            /// </remarks>
            public int MountAdjustDummyPolyID 
            {
                get => (int)CellsByName["MountAdjustDummyPolyID"].Value;
                set => CellsByName["MountAdjustDummyPolyID"].Value = (int)value;
            }
            

            // Def="s32 defCheckDmyId = -1"
            /// <summary>
            /// Mount - Check Dummy Poly ID (s32)
            /// </summary>
            /// <remarks>
            /// There is no need to set Damipoli for the character on the riding side.
            /// </remarks>
            public int MountCheckDummyPolyID 
            {
                get => (int)CellsByName["MountCheckDummyPolyID"].Value;
                set => CellsByName["MountCheckDummyPolyID"].Value = (int)value;
            }
            

            // Def="f32 diffAngMyToDef"
            /// <summary>
            /// Rider/Mount - Ride Angle Tolerance (f32)
            /// </summary>
            /// <remarks>
            /// Judgment is made by the angle difference between the [direction] on the riding side and the "front judgment Damipoly ID" on the riding side. The higher the value, the more you can ride even if you are facing away.
            /// </remarks>
            public float RiderMountRideAngleTolerance 
            {
                get => (float)CellsByName["RiderMountRideAngleTolerance"].Value;
                set => CellsByName["RiderMountRideAngleTolerance"].Value = (float)value;
            }
            

            // Def="f32 dist"
            /// <summary>
            /// Mount Distance (f32)
            /// </summary>
            /// <remarks>
            /// It is a parameter that determines the "mountable distance to the target"
            /// </remarks>
            public float MountDistance 
            {
                get => (float)CellsByName["MountDistance"].Value;
                set => CellsByName["MountDistance"].Value = (float)value;
            }
            

            // Def="f32 upperYRange"
            /// <summary>
            /// Mount Distance - Max Height (f32)
            /// </summary>
            /// <remarks>
            /// Is it possible to ride even if the target to be ridden is above the target to be ridden? Is set in meters
            /// </remarks>
            public float MountDistanceMaxHeight 
            {
                get => (float)CellsByName["MountDistanceMaxHeight"].Value;
                set => CellsByName["MountDistanceMaxHeight"].Value = (float)value;
            }
            

            // Def="f32 lowerYRange"
            /// <summary>
            /// Mount Distance - Min Height (f32)
            /// </summary>
            /// <remarks>
            /// Is it possible to ride even if the target to be ridden is below the target to be ridden? Is set in meters
            /// </remarks>
            public float MountDistanceMinHeight 
            {
                get => (float)CellsByName["MountDistanceMinHeight"].Value;
                set => CellsByName["MountDistanceMinHeight"].Value = (float)value;
            }
            

            // Def="f32 diffAngMin"
            /// <summary>
            /// Ride Angle Tolerance - Min (f32)
            /// </summary>
            /// <remarks>
            /// In what range (angle) of the rider can ride? Set the minimum value of
            /// </remarks>
            public float RideAngleToleranceMin 
            {
                get => (float)CellsByName["RideAngleToleranceMin"].Value;
                set => CellsByName["RideAngleToleranceMin"].Value = (float)value;
            }
            

            // Def="f32 diffAngMax"
            /// <summary>
            /// Ride Angle Tolerance - Max (f32)
            /// </summary>
            /// <remarks>
            /// In what range (angle) of the rider can ride? Set the maximum value of
            /// </remarks>
            public float RideAngleToleranceMax 
            {
                get => (float)CellsByName["RideAngleToleranceMax"].Value;
                set => CellsByName["RideAngleToleranceMax"].Value = (float)value;
            }
            

            // Def="dummy8 pad[12]"
            /// <summary>
            /// reserve (dummy8)
            /// </summary>
            /// <remarks>
            /// Reserved area
            /// </remarks>
            public object Reserve 
            {
                get => (object)CellsByName["Reserve"].Value;
                set => CellsByName["Reserve"].Value = (object)value;
            }
            
                }
            }
            
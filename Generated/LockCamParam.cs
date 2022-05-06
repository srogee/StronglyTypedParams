
            namespace StronglyTypedParams
            {
                public class LockCamParam : ParamRow
                {
                    public LockCamParam() : base()
                    {
                    }
            

            // Def="f32 camDistTarget = 4"
            /// <summary>
            /// Camera Target Distance (f32)
            /// </summary>
            /// <remarks>
            /// Camera distance target
            /// </remarks>
            public float CameraTargetDistance 
            {
                get => (float)CellsByName["CameraTargetDistance"].Value;
                set => CellsByName["CameraTargetDistance"].Value = value;
            }
            

            // Def="f32 rotRangeMinX = -40"
            /// <summary>
            /// Rotation Range - Min X (f32)
            /// </summary>
            /// <remarks>
            /// Minimum X-axis rotation
            /// </remarks>
            public float RotationRangeMinX 
            {
                get => (float)CellsByName["RotationRangeMinX"].Value;
                set => CellsByName["RotationRangeMinX"].Value = value;
            }
            

            // Def="f32 lockRotXShiftRatio = 0.6"
            /// <summary>
            /// Lock Rotation X - Shift Ratio (f32)
            /// </summary>
            /// <remarks>
            /// Lock X rotation shift rate
            /// </remarks>
            public float LockRotationXShiftRatio 
            {
                get => (float)CellsByName["LockRotationXShiftRatio"].Value;
                set => CellsByName["LockRotationXShiftRatio"].Value = value;
            }
            

            // Def="f32 chrOrgOffset_Y = 1.42"
            /// <summary>
            /// Character Origin - Offset Z (f32)
            /// </summary>
            /// <remarks>
            /// Character base point offset
            /// </remarks>
            public float CharacterOriginOffsetZ 
            {
                get => (float)CellsByName["CharacterOriginOffsetZ"].Value;
                set => CellsByName["CharacterOriginOffsetZ"].Value = value;
            }
            

            // Def="f32 chrLockRangeMaxRadius = 15"
            /// <summary>
            /// Character Lock Range - Max Radius (f32)
            /// </summary>
            /// <remarks>
            /// Maximum radius of character range
            /// </remarks>
            public float CharacterLockRangeMaxRadius 
            {
                get => (float)CellsByName["CharacterLockRangeMaxRadius"].Value;
                set => CellsByName["CharacterLockRangeMaxRadius"].Value = value;
            }
            

            // Def="f32 camFovY = 43"
            /// <summary>
            /// Field of View - Vertical FOV (f32)
            /// </summary>
            /// <remarks>
            /// Vertical angle of view
            /// </remarks>
            public float FieldOfViewVerticalFOV 
            {
                get => (float)CellsByName["FieldOfViewVerticalFOV"].Value;
                set => CellsByName["FieldOfViewVerticalFOV"].Value = value;
            }
            

            // Def="f32 chrLockRangeMaxRadius_forD = -1"
            /// <summary>
            /// Character Lock Range - Max Radius (Darkness) (f32)
            /// </summary>
            /// <remarks>
            /// Lockable range of characters in dark places
            /// </remarks>
            public float CharacterLockRangeMaxRadiusDarkness 
            {
                get => (float)CellsByName["CharacterLockRangeMaxRadiusDarkness"].Value;
                set => CellsByName["CharacterLockRangeMaxRadiusDarkness"].Value = value;
            }
            

            // Def="f32 chrLockRangeMaxRadius_forPD = -1"
            /// <summary>
            /// Character Lock Range - Max Radius (Total Darkness) (f32)
            /// </summary>
            /// <remarks>
            /// Character lockable range in total darkness
            /// </remarks>
            public float CharacterLockRangeMaxRadiusTotalDarkness 
            {
                get => (float)CellsByName["CharacterLockRangeMaxRadiusTotalDarkness"].Value;
                set => CellsByName["CharacterLockRangeMaxRadiusTotalDarkness"].Value = value;
            }
            

            // Def="f32 closeMaxHeight"
            /// <summary>
            /// Attack Capture - Upper Limit Height (f32)
            /// </summary>
            /// <remarks>
            /// Automatic lock-on judgment height upper limit when non-lock-on is close
            /// </remarks>
            public float AttackCaptureUpperLimitHeight 
            {
                get => (float)CellsByName["AttackCaptureUpperLimitHeight"].Value;
                set => CellsByName["AttackCaptureUpperLimitHeight"].Value = value;
            }
            

            // Def="f32 closeMinHeight"
            /// <summary>
            /// Attack Capture - Lower Limit Height (f32)
            /// </summary>
            /// <remarks>
            /// Automatic lock-on judgment height lower limit when not locked on Proximity
            /// </remarks>
            public float AttackCaptureLowerLimitHeight 
            {
                get => (float)CellsByName["AttackCaptureLowerLimitHeight"].Value;
                set => CellsByName["AttackCaptureLowerLimitHeight"].Value = value;
            }
            

            // Def="f32 closeAngRange"
            /// <summary>
            /// Attack Capture - Auto Acquisition - Angle Range Left (f32)
            /// </summary>
            /// <remarks>
            /// Automatic lock-on judgment when non-lock-on Left / right angle [deg] Proximity
            /// </remarks>
            public float AttackCaptureAutoAcquisitionAngleRangeLeft 
            {
                get => (float)CellsByName["AttackCaptureAutoAcquisitionAngleRangeLeft"].Value;
                set => CellsByName["AttackCaptureAutoAcquisitionAngleRangeLeft"].Value = value;
            }
            

            // Def="f32 closeMaxRadius"
            /// <summary>
            /// Attack Capture - Auto Acquisition - Max Radius (f32)
            /// </summary>
            /// <remarks>
            /// Automatic lock-on judgment distance when non-lock-on is close
            /// </remarks>
            public float AttackCaptureAutoAcquisitionMaxRadius 
            {
                get => (float)CellsByName["AttackCaptureAutoAcquisitionMaxRadius"].Value;
                set => CellsByName["AttackCaptureAutoAcquisitionMaxRadius"].Value = value;
            }
            

            // Def="f32 closeMaxRadius_forD"
            /// <summary>
            /// Attack Capture - Auto Acquisition - Max Radius (Darkness) (f32)
            /// </summary>
            /// <remarks>
            /// Automatic lock-on judgment distance at non-lock-on _ darkness proximity
            /// </remarks>
            public float AttackCaptureAutoAcquisitionMaxRadiusDarkness 
            {
                get => (float)CellsByName["AttackCaptureAutoAcquisitionMaxRadiusDarkness"].Value;
                set => CellsByName["AttackCaptureAutoAcquisitionMaxRadiusDarkness"].Value = value;
            }
            

            // Def="f32 closeMaxRadius_forPD"
            /// <summary>
            /// Attack Capture - Auto Acquisition - Max Radius (Total Darkness) (f32)
            /// </summary>
            /// <remarks>
            /// Automatic lock-on when non-lock-on _ pitch black proximity
            /// </remarks>
            public float AttackCaptureAutoAcquisitionMaxRadiusTotalDarkness 
            {
                get => (float)CellsByName["AttackCaptureAutoAcquisitionMaxRadiusTotalDarkness"].Value;
                set => CellsByName["AttackCaptureAutoAcquisitionMaxRadiusTotalDarkness"].Value = value;
            }
            

            // Def="f32 bulletMaxRadius"
            /// <summary>
            /// Attack Capture - Bullet - Max Radius (f32)
            /// </summary>
            /// <remarks>
            /// Automatic lock-on judgment distance when non-lock-on bullet
            /// </remarks>
            public float AttackCaptureBulletMaxRadius 
            {
                get => (float)CellsByName["AttackCaptureBulletMaxRadius"].Value;
                set => CellsByName["AttackCaptureBulletMaxRadius"].Value = value;
            }
            

            // Def="f32 bulletMaxRadius_forD"
            /// <summary>
            /// Attack Capture - Bullet - Max Radius (Dark) (f32)
            /// </summary>
            /// <remarks>
            /// Automatic lock-on judgment distance at non-lock-on _ darkness bullet
            /// </remarks>
            public float AttackCaptureBulletMaxRadiusDark 
            {
                get => (float)CellsByName["AttackCaptureBulletMaxRadiusDark"].Value;
                set => CellsByName["AttackCaptureBulletMaxRadiusDark"].Value = value;
            }
            

            // Def="f32 bulletMaxRadius_forPD"
            /// <summary>
            /// Attack Capture - Bullet - Max Radius (Pitch Dark (f32)
            /// </summary>
            /// <remarks>
            /// Automatic lock-on judgment distance at non-lock-on _ pitch black bullet
            /// </remarks>
            public float AttackCaptureBulletMaxRadiusPitchDark 
            {
                get => (float)CellsByName["AttackCaptureBulletMaxRadiusPitchDark"].Value;
                set => CellsByName["AttackCaptureBulletMaxRadiusPitchDark"].Value = value;
            }
            

            // Def="f32 bulletAngRange"
            /// <summary>
            /// Attack Capture - Bullet - Angle Range Left/Right (f32)
            /// </summary>
            /// <remarks>
            /// Automatic lock-on left / right angle when non-lock-on bullet
            /// </remarks>
            public float AttackCaptureBulletAngleRangeLeftRight 
            {
                get => (float)CellsByName["AttackCaptureBulletAngleRangeLeftRight"].Value;
                set => CellsByName["AttackCaptureBulletAngleRangeLeftRight"].Value = value;
            }
            

            // Def="f32 lockTgtKeepTime = 2"
            /// <summary>
            /// Lock Target Keep Time (f32)
            /// </summary>
            /// <remarks>
            /// Time to continue locking even if the lock condition is not met (disabled at 0.0)
            /// </remarks>
            public float LockTargetKeepTime 
            {
                get => (float)CellsByName["LockTargetKeepTime"].Value;
                set => CellsByName["LockTargetKeepTime"].Value = value;
            }
            

            // Def="f32 chrTransChaseRateForNormal = -1"
            /// <summary>
            /// Transition Chase Factor for Normal Character (f32)
            /// </summary>
            /// <remarks>
            /// Normal character translation tracking rate (disabled at -1.0)
            /// </remarks>
            public float TransitionChaseFactorForNormalCharacter 
            {
                get => (float)CellsByName["TransitionChaseFactorForNormalCharacter"].Value;
                set => CellsByName["TransitionChaseFactorForNormalCharacter"].Value = value;
            }
            

            // Def="dummy8 pad[48]"
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
            
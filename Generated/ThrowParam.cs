
            namespace StronglyTypedParams
            {
                public class ThrowParam : ParamRow
                {
                    public ThrowParam() : base()
                    {
                    }
            

            // Def="s32 AtkChrId"
            /// <summary>
            /// Attacker - Character ID (s32)
            /// </summary>
            /// <remarks>
            /// Throwing side character ID
            /// </remarks>
            public int AttackerCharacterID 
            {
                get => (int)CellsByName["AttackerCharacterID"].Value;
                set => CellsByName["AttackerCharacterID"].Value = value;
            }
            

            // Def="s32 DefChrId"
            /// <summary>
            /// Defender - Character ID (s32)
            /// </summary>
            /// <remarks>
            /// Recipient character ID
            /// </remarks>
            public int DefenderCharacterID 
            {
                get => (int)CellsByName["DefenderCharacterID"].Value;
                set => CellsByName["DefenderCharacterID"].Value = value;
            }
            

            // Def="f32 Dist"
            /// <summary>
            /// Max Throw Distance (f32)
            /// </summary>
            /// <remarks>
            /// Do not throw unless the distance is closer than this value [m]
            /// </remarks>
            public float MaxThrowDistance 
            {
                get => (float)CellsByName["MaxThrowDistance"].Value;
                set => CellsByName["MaxThrowDistance"].Value = value;
            }
            

            // Def="f32 DiffAngMin"
            /// <summary>
            /// Height Angle Difference - Min (f32)
            /// </summary>
            /// <remarks>
            /// If the angle difference (Y-axis) between the throwing side and the receiving side is not larger than this angle, it will not be thrown.
            /// </remarks>
            public float HeightAngleDifferenceMin 
            {
                get => (float)CellsByName["HeightAngleDifferenceMin"].Value;
                set => CellsByName["HeightAngleDifferenceMin"].Value = value;
            }
            

            // Def="f32 DiffAngMax"
            /// <summary>
            /// Height Angle Difference - Max (f32)
            /// </summary>
            /// <remarks>
            /// If the angle difference (Y-axis) between the throwing side and the receiving side is smaller than this angle, it will not be thrown.
            /// </remarks>
            public float HeightAngleDifferenceMax 
            {
                get => (float)CellsByName["HeightAngleDifferenceMax"].Value;
                set => CellsByName["HeightAngleDifferenceMax"].Value = value;
            }
            

            // Def="f32 upperYRange = 0.2"
            /// <summary>
            /// Upper Height Range (f32)
            /// </summary>
            /// <remarks>
            /// Do not throw unless the relative distance of the Y axis from the throwing side to the receiving side is smaller than this value
            /// </remarks>
            public float UpperHeightRange 
            {
                get => (float)CellsByName["UpperHeightRange"].Value;
                set => CellsByName["UpperHeightRange"].Value = value;
            }
            

            // Def="f32 lowerYRange = 0.2"
            /// <summary>
            /// Lower Height Range (f32)
            /// </summary>
            /// <remarks>
            /// Do not throw unless the relative distance of the Y axis from the throwing side to the receiving side is smaller than this value
            /// </remarks>
            public float LowerHeightRange 
            {
                get => (float)CellsByName["LowerHeightRange"].Value;
                set => CellsByName["LowerHeightRange"].Value = value;
            }
            

            // Def="f32 diffAngMyToDef = 60"
            /// <summary>
            /// Angle Difference - To Defender (f32)
            /// </summary>
            /// <remarks>
            /// The angle difference between the vector in front of you and the vector in the direction from you to the other party. If it is larger than this value, it will not be thrown
            /// </remarks>
            public float AngleDifferenceToDefender 
            {
                get => (float)CellsByName["AngleDifferenceToDefender"].Value;
                set => CellsByName["AngleDifferenceToDefender"].Value = value;
            }
            

            // Def="s32 throwTypeId"
            /// <summary>
            /// Throw Type ID (s32)
            /// </summary>
            /// <remarks>
            /// ID that identifies the type of throw (association with attack parameter)
            /// </remarks>
            public int ThrowTypeID 
            {
                get => (int)CellsByName["ThrowTypeID"].Value;
                set => CellsByName["ThrowTypeID"].Value = value;
            }
            

            // Def="s32 atkAnimId"
            /// <summary>
            /// Attacker - Animation ID (s32)
            /// </summary>
            /// <remarks>
            /// Set attack animation ID (linked to EzState)
            /// </remarks>
            public int AttackerAnimationID 
            {
                get => (int)CellsByName["AttackerAnimationID"].Value;
                set => CellsByName["AttackerAnimationID"].Value = value;
            }
            

            // Def="s32 defAnimId"
            /// <summary>
            /// Defender - Animation ID (s32)
            /// </summary>
            /// <remarks>
            /// Set damage animation ID (linked to EzState)
            /// </remarks>
            public int DefenderAnimationID 
            {
                get => (int)CellsByName["DefenderAnimationID"].Value;
                set => CellsByName["DefenderAnimationID"].Value = value;
            }
            

            // Def="u16 escHp"
            /// <summary>
            /// Self Escape - HP (u16)
            /// </summary>
            /// <remarks>
            /// Value that can withstand throwing through
            /// </remarks>
            public ushort SelfEscapeHP 
            {
                get => (ushort)CellsByName["SelfEscapeHP"].Value;
                set => CellsByName["SelfEscapeHP"].Value = value;
            }
            

            // Def="u16 selfEscCycleTime"
            /// <summary>
            /// Self Escape - Cycle Time (u16)
            /// </summary>
            /// <remarks>
            /// Cycle time for self-throwing [ms]
            /// </remarks>
            public ushort SelfEscapeCycleTime 
            {
                get => (ushort)CellsByName["SelfEscapeCycleTime"].Value;
                set => CellsByName["SelfEscapeCycleTime"].Value = value;
            }
            

            // Def="u16 sphereCastRadiusRateTop = 80"
            /// <summary>
            /// Sphere Cast - Radius Rate Top (u16)
            /// </summary>
            /// <remarks>
            /// Ratio of upper radius of sphere cast [80-> 0.8]
            /// </remarks>
            public ushort SphereCastRadiusRateTop 
            {
                get => (ushort)CellsByName["SphereCastRadiusRateTop"].Value;
                set => CellsByName["SphereCastRadiusRateTop"].Value = value;
            }
            

            // Def="u16 sphereCastRadiusRateLow = 80"
            /// <summary>
            /// Sphere Cast - Radius Rate Low (u16)
            /// </summary>
            /// <remarks>
            /// Spherecast lower radius ratio [80-> 0.8]
            /// </remarks>
            public ushort SphereCastRadiusRateLow 
            {
                get => (ushort)CellsByName["SphereCastRadiusRateLow"].Value;
                set => CellsByName["SphereCastRadiusRateLow"].Value = value;
            }
            

            // Def="u8 PadType = 1"
            /// <summary>
            /// Operation Type (u8)
            /// </summary>
            /// <remarks>
            /// Operation type
            /// </remarks>
            public byte OperationType 
            {
                get => (byte)CellsByName["OperationType"].Value;
                set => CellsByName["OperationType"].Value = value;
            }
            

            // Def="u8 AtkEnableState"
            /// <summary>
            /// Attack Enable State (u8)
            /// </summary>
            /// <remarks>
            /// Please set the state type that can be thrown on the throwing side
            /// </remarks>
            public byte AttackEnableState 
            {
                get => (byte)CellsByName["AttackEnableState"].Value;
                set => CellsByName["AttackEnableState"].Value = value;
            }
            

            // Def="u8 throwFollowingType"
            /// <summary>
            /// Throw Following Type (u8)
            /// </summary>
            /// <remarks>
            /// How to follow the character possessed by Adsorbed Damipoli while throwing. * Follow-up period is controlled by TAE action
            /// </remarks>
            public byte ThrowFollowingType 
            {
                get => (byte)CellsByName["ThrowFollowingType"].Value;
                set => CellsByName["ThrowFollowingType"].Value = value;
            }
            

            // Def="dummy8 pad2[1]"
            /// <summary>
            /// pad (dummy8)
            /// </summary>
            /// <remarks>
            /// pad
            /// </remarks>
            public object Pad 
            {
                get => (object)CellsByName["Pad"].Value;
                set => CellsByName["Pad"].Value = value;
            }
            

            // Def="u8 throwType"
            /// <summary>
            /// Throw Type (u8)
            /// </summary>
            /// <remarks>
            /// Type of throw
            /// </remarks>
            public byte ThrowType 
            {
                get => (byte)CellsByName["ThrowType"].Value;
                set => CellsByName["ThrowType"].Value = value;
            }
            

            // Def="u8 selfEscCycleCnt"
            /// <summary>
            /// Self Escape - Cycle Count (u8)
            /// </summary>
            /// <remarks>
            /// Number of self-throwing cycles
            /// </remarks>
            public byte SelfEscapeCycleCount 
            {
                get => (byte)CellsByName["SelfEscapeCycleCount"].Value;
                set => CellsByName["SelfEscapeCycleCount"].Value = value;
            }
            

            // Def="u8 dmyHasChrDirType"
            /// <summary>
            /// Character Throw - Dummy Poly Direction Type (u8)
            /// </summary>
            /// <remarks>
            /// Direction of Damipoli possession character when throwing occurs
            /// </remarks>
            public byte CharacterThrowDummyPolyDirectionType 
            {
                get => (byte)CellsByName["CharacterThrowDummyPolyDirectionType"].Value;
                set => CellsByName["CharacterThrowDummyPolyDirectionType"].Value = value;
            }
            

            // Def="u8 isTurnAtker:1"
            /// <summary>
            /// Throw can Side Turn (u8)
            /// </summary>
            /// <remarks>
            /// Does the throwing side turn?
            /// </remarks>
            public byte ThrowCanSideTurn 
            {
                get => (byte)CellsByName["ThrowCanSideTurn"].Value;
                set => CellsByName["ThrowCanSideTurn"].Value = value;
            }
            

            // Def="u8 isSkipWepCate:1"
            /// <summary>
            /// Skip Attacker Weapon Category Check (u8)
            /// </summary>
            /// <remarks>
            /// Do you want to skip the attacker's weapon category check?
            /// </remarks>
            public byte SkipAttackerWeaponCategoryCheck 
            {
                get => (byte)CellsByName["SkipAttackerWeaponCategoryCheck"].Value;
                set => CellsByName["SkipAttackerWeaponCategoryCheck"].Value = value;
            }
            

            // Def="u8 isSkipSphereCast:1"
            /// <summary>
            /// Skip Sphere Cast (u8)
            /// </summary>
            /// <remarks>
            /// Do you want to skip the sphere cast?
            /// </remarks>
            public byte SkipSphereCast 
            {
                get => (byte)CellsByName["SkipSphereCast"].Value;
                set => CellsByName["SkipSphereCast"].Value = value;
            }
            

            // Def="u8 isEnableCorrectPos_forThrowAdjust:1 = 1"
            /// <summary>
            /// Enable Correct Position for Throw Adjustment (u8)
            /// </summary>
            /// <remarks>
            /// If it is set to ◯, the location of the throwing position will be the "position of the adsorption Damipoli that has returned to the positional relationship equivalent to the flat ground".
            /// </remarks>
            public byte EnableCorrectPositionForThrowAdjustment 
            {
                get => (byte)CellsByName["EnableCorrectPositionForThrowAdjustment"].Value;
                set => CellsByName["EnableCorrectPositionForThrowAdjustment"].Value = value;
            }
            

            // Def="u8 isEnableThrowFollowingFallAssist:1 = 1"
            /// <summary>
            /// Enable Throw Following Fall Assist (u8)
            /// </summary>
            /// <remarks>
            /// Is the same treatment as the wall removal prevention applied to the fall prevention wall so that it does not fall from the step when the follow-up is released?
            /// </remarks>
            public byte EnableThrowFollowingFallAssist 
            {
                get => (byte)CellsByName["EnableThrowFollowingFallAssist"].Value;
                set => CellsByName["EnableThrowFollowingFallAssist"].Value = value;
            }
            

            // Def="u8 isEnableThrowFollowingFeedback:1 = 1"
            /// <summary>
            /// Enable Throw Following Feedback (u8)
            /// </summary>
            /// <remarks>
            /// Do you want to return the character with the Adsorbed Damipoli when it comes in contact with a hit or fall prevention wall so that it does not look like it will get stuck in the middle wall or fall from a step?
            /// </remarks>
            public byte EnableThrowFollowingFeedback 
            {
                get => (byte)CellsByName["EnableThrowFollowingFeedback"].Value;
                set => CellsByName["EnableThrowFollowingFeedback"].Value = value;
            }
            


            // Def="s16 atkSorbDmyId"
            /// <summary>
            /// Attacker - Absorb Dummy ID (s16)
            /// </summary>
            /// <remarks>
            /// Where on the throwing side should the receiving side be attracted?
            /// </remarks>
            public short AttackerAbsorbDummyID 
            {
                get => (short)CellsByName["AttackerAbsorbDummyID"].Value;
                set => CellsByName["AttackerAbsorbDummyID"].Value = value;
            }
            

            // Def="s16 defSorbDmyId"
            /// <summary>
            /// Defender - Absorb Dummy ID (s16)
            /// </summary>
            /// <remarks>
            /// Where on the receiving side should the throwing side be adsorbed?
            /// </remarks>
            public short DefenderAbsorbDummyID 
            {
                get => (short)CellsByName["DefenderAbsorbDummyID"].Value;
                set => CellsByName["DefenderAbsorbDummyID"].Value = value;
            }
            

            // Def="f32 Dist_start"
            /// <summary>
            /// Backstab - Max Throw Distance  (f32)
            /// </summary>
            /// <remarks>
            /// Only throw at a distance closer than this value [m] Used for throwing at the start of the Backstab
            /// </remarks>
            public float BackstabMaxThrowDistance 
            {
                get => (float)CellsByName["BackstabMaxThrowDistance"].Value;
                set => CellsByName["BackstabMaxThrowDistance"].Value = value;
            }
            

            // Def="f32 DiffAngMin_start"
            /// <summary>
            /// Backstab - Height Angle Difference - Min (f32)
            /// </summary>
            /// <remarks>
            /// If the angle difference (Y-axis) between the throwing side and the receiving side is not larger than this angle, it will not be thrown. It is used for throwing at the start of the Backstab.
            /// </remarks>
            public float BackstabHeightAngleDifferenceMin 
            {
                get => (float)CellsByName["BackstabHeightAngleDifferenceMin"].Value;
                set => CellsByName["BackstabHeightAngleDifferenceMin"].Value = value;
            }
            

            // Def="f32 DiffAngMax_start"
            /// <summary>
            /// Backstab - Height Angle Difference - Max (f32)
            /// </summary>
            /// <remarks>
            /// The angle difference (Y-axis) between the throwing side and the receiving side must be smaller than this angle to throw. Used for throwing at the start of the Backstab.
            /// </remarks>
            public float BackstabHeightAngleDifferenceMax 
            {
                get => (float)CellsByName["BackstabHeightAngleDifferenceMax"].Value;
                set => CellsByName["BackstabHeightAngleDifferenceMax"].Value = value;
            }
            

            // Def="f32 upperYRange_start"
            /// <summary>
            /// Backstab - Upper Height Range (f32)
            /// </summary>
            /// <remarks>
            /// It will not be thrown unless the relative distance of the Y axis from the throwing side to the receiving side is smaller than this value. It is used for throwing at the start of the Backstab.
            /// </remarks>
            public float BackstabUpperHeightRange 
            {
                get => (float)CellsByName["BackstabUpperHeightRange"].Value;
                set => CellsByName["BackstabUpperHeightRange"].Value = value;
            }
            

            // Def="f32 lowerYRange_start"
            /// <summary>
            /// Backstab - Lower Height Range (f32)
            /// </summary>
            /// <remarks>
            /// It will not be thrown unless the relative distance of the Y axis from the throwing side to the receiving side is smaller than this value. It is used for throwing at the start of the Backstab.
            /// </remarks>
            public float BackstabLowerHeightRange 
            {
                get => (float)CellsByName["BackstabLowerHeightRange"].Value;
                set => CellsByName["BackstabLowerHeightRange"].Value = value;
            }
            

            // Def="f32 diffAngMyToDef_start"
            /// <summary>
            /// Backstab - Angle Difference - To Defender (f32)
            /// </summary>
            /// <remarks>
            /// The angle difference between the vector in front of you and the vector in the direction from you to the other party. If it is larger than this value, it will not be thrown. It will be used for throwing at the start of the Backstab.
            /// </remarks>
            public float BackstabAngleDifferenceToDefender 
            {
                get => (float)CellsByName["BackstabAngleDifferenceToDefender"].Value;
                set => CellsByName["BackstabAngleDifferenceToDefender"].Value = value;
            }
            

            // Def="s32 judgeRangeBasePosDmyId1 = -1"
            /// <summary>
            /// Attacker - Throwing Range Judgment - Dummy Poly ID (s32)
            /// </summary>
            /// <remarks>
            /// Damipoli that the thrower considers to be his position when calculating the throw range. If -1, the capsule origin
            /// </remarks>
            public int AttackerThrowingRangeJudgmentDummyPolyID 
            {
                get => (int)CellsByName["AttackerThrowingRangeJudgmentDummyPolyID"].Value;
                set => CellsByName["AttackerThrowingRangeJudgmentDummyPolyID"].Value = value;
            }
            

            // Def="s32 judgeRangeBasePosDmyId2 = -1"
            /// <summary>
            /// Defender - Throwing Range Judgment - Dummy Poly ID (s32)
            /// </summary>
            /// <remarks>
            /// Damipoli that the thrower considers to be his position when calculating the throw range. If -1, the capsule origin
            /// </remarks>
            public int DefenderThrowingRangeJudgmentDummyPolyID 
            {
                get => (int)CellsByName["DefenderThrowingRangeJudgmentDummyPolyID"].Value;
                set => CellsByName["DefenderThrowingRangeJudgmentDummyPolyID"].Value = value;
            }
            

            // Def="f32 adsrobModelPosInterpolationTime = 0.5"
            /// <summary>
            /// Absorb Model Position Interpolation Time (f32)
            /// </summary>
            /// <remarks>
            /// After the capsule is adsorbed on Damipoli, the time it takes for the character model to interpolate and move to the position according to the throwing animation data (when 0 is set, the model position is not interpolated and playback starts immediately after adsorption with the positional relationship according to the animation data. Will be)
            /// </remarks>
            public float AbsorbModelPositionInterpolationTime 
            {
                get => (float)CellsByName["AbsorbModelPositionInterpolationTime"].Value;
                set => CellsByName["AbsorbModelPositionInterpolationTime"].Value = value;
            }
            

            // Def="f32 throwFollowingEndEasingTime = 0.5"
            /// <summary>
            /// Throw Following End Easing Time (f32)
            /// </summary>
            /// <remarks>
            /// Model position interpolation time at the end of tracking
            /// </remarks>
            public float ThrowFollowingEndEasingTime 
            {
                get => (float)CellsByName["ThrowFollowingEndEasingTime"].Value;
                set => CellsByName["ThrowFollowingEndEasingTime"].Value = value;
            }
            

                }
            }
            

namespace StronglyTypedParams
{
    public class MoveParam : ParamRow
    {
        public MoveParam() : base()
        {
        }


        // Def="s32 stayId = -1"
        /// <summary>
        /// Stay ID (s32)
        /// </summary>
        /// <remarks>
        /// stand-by
        /// </remarks>
        public int StayID
        {
            get => (int)CellsByName["StayID"].Value;
            set => CellsByName["StayID"].Value = value;
        }


        // Def="s32 walkF = -1"
        /// <summary>
        /// Walk - Forward (s32)
        /// </summary>
        /// <remarks>
        /// Before walking
        /// </remarks>
        public int WalkForward
        {
            get => (int)CellsByName["WalkForward"].Value;
            set => CellsByName["WalkForward"].Value = value;
        }


        // Def="s32 walkB = -1"
        /// <summary>
        /// Walk - Backward (s32)
        /// </summary>
        /// <remarks>
        /// After walking
        /// </remarks>
        public int WalkBackward
        {
            get => (int)CellsByName["WalkBackward"].Value;
            set => CellsByName["WalkBackward"].Value = value;
        }


        // Def="s32 walkL = -1"
        /// <summary>
        /// Walk - Left (s32)
        /// </summary>
        /// <remarks>
        /// Walking left
        /// </remarks>
        public int WalkLeft
        {
            get => (int)CellsByName["WalkLeft"].Value;
            set => CellsByName["WalkLeft"].Value = value;
        }


        // Def="s32 walkR = -1"
        /// <summary>
        /// Walk - Right (s32)
        /// </summary>
        /// <remarks>
        /// Walking right
        /// </remarks>
        public int WalkRight
        {
            get => (int)CellsByName["WalkRight"].Value;
            set => CellsByName["WalkRight"].Value = value;
        }


        // Def="s32 dashF = -1"
        /// <summary>
        /// Dash - Forward (s32)
        /// </summary>
        /// <remarks>
        /// Before driving
        /// </remarks>
        public int DashForward
        {
            get => (int)CellsByName["DashForward"].Value;
            set => CellsByName["DashForward"].Value = value;
        }


        // Def="s32 dashB = -1"
        /// <summary>
        /// Dash - Backward (s32)
        /// </summary>
        /// <remarks>
        /// After running
        /// </remarks>
        public int DashBackward
        {
            get => (int)CellsByName["DashBackward"].Value;
            set => CellsByName["DashBackward"].Value = value;
        }


        // Def="s32 dashL = -1"
        /// <summary>
        /// Dash - Left (s32)
        /// </summary>
        /// <remarks>
        /// Driving left
        /// </remarks>
        public int DashLeft
        {
            get => (int)CellsByName["DashLeft"].Value;
            set => CellsByName["DashLeft"].Value = value;
        }


        // Def="s32 dashR = -1"
        /// <summary>
        /// Dash - Right (s32)
        /// </summary>
        /// <remarks>
        /// Driving right
        /// </remarks>
        public int DashRight
        {
            get => (int)CellsByName["DashRight"].Value;
            set => CellsByName["DashRight"].Value = value;
        }


        // Def="s32 superDash = -1"
        /// <summary>
        /// Sprint Dash (s32)
        /// </summary>
        /// <remarks>
        /// Dash move
        /// </remarks>
        public int SprintDash
        {
            get => (int)CellsByName["SprintDash"].Value;
            set => CellsByName["SprintDash"].Value = value;
        }


        // Def="s32 escapeF = -1"
        /// <summary>
        /// Evasion - Forward (s32)
        /// </summary>
        /// <remarks>
        /// Before emergency avoidance
        /// </remarks>
        public int EvasionForward
        {
            get => (int)CellsByName["EvasionForward"].Value;
            set => CellsByName["EvasionForward"].Value = value;
        }


        // Def="s32 escapeB = -1"
        /// <summary>
        /// Evasion - Backward (s32)
        /// </summary>
        /// <remarks>
        /// After emergency avoidance
        /// </remarks>
        public int EvasionBackward
        {
            get => (int)CellsByName["EvasionBackward"].Value;
            set => CellsByName["EvasionBackward"].Value = value;
        }


        // Def="s32 escapeL = -1"
        /// <summary>
        /// Evasion - Left (s32)
        /// </summary>
        /// <remarks>
        /// Emergency avoidance left
        /// </remarks>
        public int EvasionLeft
        {
            get => (int)CellsByName["EvasionLeft"].Value;
            set => CellsByName["EvasionLeft"].Value = value;
        }


        // Def="s32 escapeR = -1"
        /// <summary>
        /// Evasion - Right (s32)
        /// </summary>
        /// <remarks>
        /// Emergency avoidance right
        /// </remarks>
        public int EvasionRight
        {
            get => (int)CellsByName["EvasionRight"].Value;
            set => CellsByName["EvasionRight"].Value = value;
        }


        // Def="s32 turnL = -1"
        /// <summary>
        /// Turn - Left 90 (s32)
        /// </summary>
        /// <remarks>
        /// 90 degree turn left
        /// </remarks>
        public int TurnLeft90
        {
            get => (int)CellsByName["TurnLeft90"].Value;
            set => CellsByName["TurnLeft90"].Value = value;
        }


        // Def="s32 trunR = -1"
        /// <summary>
        /// Turn - Right 90 (s32)
        /// </summary>
        /// <remarks>
        /// 90 degree turn right
        /// </remarks>
        public int TurnRight90
        {
            get => (int)CellsByName["TurnRight90"].Value;
            set => CellsByName["TurnRight90"].Value = value;
        }


        // Def="s32 largeTurnL = -1"
        /// <summary>
        /// Turn - Left 180 (s32)
        /// </summary>
        /// <remarks>
        /// 180 degree turn left
        /// </remarks>
        public int TurnLeft180
        {
            get => (int)CellsByName["TurnLeft180"].Value;
            set => CellsByName["TurnLeft180"].Value = value;
        }


        // Def="s32 largeTurnR = -1"
        /// <summary>
        /// Turn - Right 180 (s32)
        /// </summary>
        /// <remarks>
        /// 180 degree turn right
        /// </remarks>
        public int TurnRight180
        {
            get => (int)CellsByName["TurnRight180"].Value;
            set => CellsByName["TurnRight180"].Value = value;
        }


        // Def="s32 stepMove = -1"
        /// <summary>
        /// Step Move (s32)
        /// </summary>
        /// <remarks>
        /// 180 degree turn right
        /// </remarks>
        public int StepMove
        {
            get => (int)CellsByName["StepMove"].Value;
            set => CellsByName["StepMove"].Value = value;
        }


        // Def="s32 flyStay = -1"
        /// <summary>
        /// Fly Stay (s32)
        /// </summary>
        /// <remarks>
        /// Flight standby
        /// </remarks>
        public int FlyStay
        {
            get => (int)CellsByName["FlyStay"].Value;
            set => CellsByName["FlyStay"].Value = value;
        }


        // Def="s32 flyWalkF = -1"
        /// <summary>
        /// Fly Walk - Forward (s32)
        /// </summary>
        /// <remarks>
        /// Flight advance
        /// </remarks>
        public int FlyWalkForward
        {
            get => (int)CellsByName["FlyWalkForward"].Value;
            set => CellsByName["FlyWalkForward"].Value = value;
        }


        // Def="s32 flyWalkFL = -1"
        /// <summary>
        /// Fly Walk - Forward Left (s32)
        /// </summary>
        /// <remarks>
        /// Fly left forward. Low rotation
        /// </remarks>
        public int FlyWalkForwardLeft
        {
            get => (int)CellsByName["FlyWalkForwardLeft"].Value;
            set => CellsByName["FlyWalkForwardLeft"].Value = value;
        }


        // Def="s32 flyWalkFR = -1"
        /// <summary>
        /// Fly Walk - Forward Right (s32)
        /// </summary>
        /// <remarks>
        /// Fly right forward. Low rotation
        /// </remarks>
        public int FlyWalkForwardRight
        {
            get => (int)CellsByName["FlyWalkForwardRight"].Value;
            set => CellsByName["FlyWalkForwardRight"].Value = value;
        }


        // Def="s32 flyWalkFL2 = -1"
        /// <summary>
        /// Fly Walk - Forward Left 2 (s32)
        /// </summary>
        /// <remarks>
        /// Flight left forward 2. High rotation
        /// </remarks>
        public int FlyWalkForwardLeft2
        {
            get => (int)CellsByName["FlyWalkForwardLeft2"].Value;
            set => CellsByName["FlyWalkForwardLeft2"].Value = value;
        }


        // Def="s32 flyWalkFR2 = -1"
        /// <summary>
        /// Fly Walk - Forward Right 2 (s32)
        /// </summary>
        /// <remarks>
        /// Flight right forward 2. High rotation
        /// </remarks>
        public int FlyWalkForwardRight2
        {
            get => (int)CellsByName["FlyWalkForwardRight2"].Value;
            set => CellsByName["FlyWalkForwardRight2"].Value = value;
        }


        // Def="s32 flyDashF = -1"
        /// <summary>
        /// Fly Dash - Forward (s32)
        /// </summary>
        /// <remarks>
        /// High speed flight advance
        /// </remarks>
        public int FlyDashForward
        {
            get => (int)CellsByName["FlyDashForward"].Value;
            set => CellsByName["FlyDashForward"].Value = value;
        }


        // Def="s32 flyDashFL = -1"
        /// <summary>
        /// Fly Dash - Forward Left (s32)
        /// </summary>
        /// <remarks>
        /// High-speed flight left forward. Low rotation
        /// </remarks>
        public int FlyDashForwardLeft
        {
            get => (int)CellsByName["FlyDashForwardLeft"].Value;
            set => CellsByName["FlyDashForwardLeft"].Value = value;
        }


        // Def="s32 flyDashFR = -1"
        /// <summary>
        /// Fly Dash - Forward Right (s32)
        /// </summary>
        /// <remarks>
        /// High speed flight right forward. Low rotation
        /// </remarks>
        public int FlyDashForwardRight
        {
            get => (int)CellsByName["FlyDashForwardRight"].Value;
            set => CellsByName["FlyDashForwardRight"].Value = value;
        }


        // Def="s32 flyDashFL2 = -1"
        /// <summary>
        /// Fly Dash - Forward Left 2 (s32)
        /// </summary>
        /// <remarks>
        /// High speed flight left forward 2. High rotation
        /// </remarks>
        public int FlyDashForwardLeft2
        {
            get => (int)CellsByName["FlyDashForwardLeft2"].Value;
            set => CellsByName["FlyDashForwardLeft2"].Value = value;
        }


        // Def="s32 flyDashFR2 = -1"
        /// <summary>
        /// Fly Dash - Forward Right 2 (s32)
        /// </summary>
        /// <remarks>
        /// High speed flight right forward 2. High rotation
        /// </remarks>
        public int FlyDashForwardRight2
        {
            get => (int)CellsByName["FlyDashForwardRight2"].Value;
            set => CellsByName["FlyDashForwardRight2"].Value = value;
        }


        // Def="s32 dashEscapeF = -1"
        /// <summary>
        /// Fly Evasion - Forward (s32)
        /// </summary>
        /// <remarks>
        /// Before dash emergency avoidance
        /// </remarks>
        public int FlyEvasionForward
        {
            get => (int)CellsByName["FlyEvasionForward"].Value;
            set => CellsByName["FlyEvasionForward"].Value = value;
        }


        // Def="s32 dashEscapeB = -1"
        /// <summary>
        /// Fly Evasion - Backward (s32)
        /// </summary>
        /// <remarks>
        /// After dash emergency avoidance
        /// </remarks>
        public int FlyEvasionBackward
        {
            get => (int)CellsByName["FlyEvasionBackward"].Value;
            set => CellsByName["FlyEvasionBackward"].Value = value;
        }


        // Def="s32 dashEscapeL = -1"
        /// <summary>
        /// Fly Evasion - Left (s32)
        /// </summary>
        /// <remarks>
        /// Dash emergency avoidance left
        /// </remarks>
        public int FlyEvasionLeft
        {
            get => (int)CellsByName["FlyEvasionLeft"].Value;
            set => CellsByName["FlyEvasionLeft"].Value = value;
        }


        // Def="s32 dashEscapeR = -1"
        /// <summary>
        /// Fly Evasion - Right (s32)
        /// </summary>
        /// <remarks>
        /// Dash emergency avoidance right
        /// </remarks>
        public int FlyEvasionRight
        {
            get => (int)CellsByName["FlyEvasionRight"].Value;
            set => CellsByName["FlyEvasionRight"].Value = value;
        }


        // Def="s32 analogMoveParamId = -1"
        /// <summary>
        /// Analog Move Param ID (s32)
        /// </summary>
        /// <remarks>
        /// Mobile animation parameter ID used in mobile animation blend
        /// </remarks>
        public int AnalogMoveParamID
        {
            get => (int)CellsByName["AnalogMoveParamID"].Value;
            set => CellsByName["AnalogMoveParamID"].Value = value;
        }


        // Def="u8 turnNoAnimAngle"
        /// <summary>
        /// No Anim Turn Angle (u8)
        /// </summary>
        /// <remarks>
        /// If the turning angle is less than this value, the turning animation will not be played (only the enemy turning control is effective).
        /// </remarks>
        public byte NoAnimTurnAngle
        {
            get => (byte)CellsByName["NoAnimTurnAngle"].Value;
            set => CellsByName["NoAnimTurnAngle"].Value = value;
        }


        // Def="u8 turn45Angle"
        /// <summary>
        /// 45 Turn Angle (u8)
        /// </summary>
        /// <remarks>
        /// If the turning angle is less than this value, the 45 degree turning animation will be played (only 2 bosses are valid).
        /// </remarks>
        public byte _45TurnAngle
        {
            get => (byte)CellsByName["_45TurnAngle"].Value;
            set => CellsByName["_45TurnAngle"].Value = value;
        }


        // Def="u8 turn90Angle"
        /// <summary>
        /// 90 Turn Angle (u8)
        /// </summary>
        /// <remarks>
        /// If the turning angle is less than this value, the 90 degree turning animation will be played (only the enemy turning control is effective).
        /// </remarks>
        public byte _90TurnAngle
        {
            get => (byte)CellsByName["_90TurnAngle"].Value;
            set => CellsByName["_90TurnAngle"].Value = value;
        }


        // Def="u8 turnWaitNoAnimAngle"
        /// <summary>
        /// Wait No Anim Turn Angle (u8)
        /// </summary>
        /// <remarks>
        /// If the turning angle is less than this value, the turning animation will not be played [when stopped] (only valid for 2 boss legs)
        /// </remarks>
        public byte WaitNoAnimTurnAngle
        {
            get => (byte)CellsByName["WaitNoAnimTurnAngle"].Value;
            set => CellsByName["WaitNoAnimTurnAngle"].Value = value;
        }

    }
}

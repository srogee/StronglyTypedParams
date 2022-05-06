
namespace StronglyTypedParams
{
    public class AiStandardInfo : ParamRow
    {
        public AiStandardInfo() : base()
        {
        }


        // Def="u16 RadarRange = 20"
        /// <summary>
        /// Recognition distance [m] (u16)
        /// </summary>
        /// <remarks>
        /// Distance to recognize hostile characters
        /// </remarks>
        public ushort RecognitionDistanceM
        {
            get => (ushort)CellsByName["RecognitionDistanceM"].Value;
            set => CellsByName["RecognitionDistanceM"].Value = value;
        }


        // Def="u8 RadarAngleX = 30"
        /// <summary>
        /// Recognition angle X [deg] (u8)
        /// </summary>
        /// <remarks>
        /// X angle for recognizing hostile characters: The current line-of-sight direction is 0 degrees, and the top is +.
        /// </remarks>
        public byte RecognitionAngleXDeg
        {
            get => (byte)CellsByName["RecognitionAngleXDeg"].Value;
            set => CellsByName["RecognitionAngleXDeg"].Value = value;
        }


        // Def="u8 RadarAngleY = 60"
        /// <summary>
        /// Recognition angle Y [deg] (u8)
        /// </summary>
        /// <remarks>
        /// Y angle for recognizing hostile characters: The current line-of-sight direction is 0 degrees, and the right is +.
        /// </remarks>
        public byte RecognitionAngleYDeg
        {
            get => (byte)CellsByName["RecognitionAngleYDeg"].Value;
            set => CellsByName["RecognitionAngleYDeg"].Value = value;
        }


        // Def="u16 TerritorySize = 20"
        /// <summary>
        /// Territory distance [m] (u16)
        /// </summary>
        /// <remarks>
        /// The distance of your territory. If the recognizing player deviates from this distance, it will return to the initial position.
        /// </remarks>
        public ushort TerritoryDistanceM
        {
            get => (ushort)CellsByName["TerritoryDistanceM"].Value;
            set => CellsByName["TerritoryDistanceM"].Value = value;
        }


        // Def="u8 ThreatBeforeAttackRate = 50"
        /// <summary>
        /// Intimidation rate before attack [0-100] (u8)
        /// </summary>
        /// <remarks>
        /// Probability of threatening before attack
        /// </remarks>
        public byte IntimidationRateBeforeAttack0100
        {
            get => (byte)CellsByName["IntimidationRateBeforeAttack0100"].Value;
            set => CellsByName["IntimidationRateBeforeAttack0100"].Value = value;
        }


        // Def="u8 ForceThreatOnFirstLocked"
        /// <summary>
        /// First recognition menacing (u8)
        /// </summary>
        /// <remarks>
        /// Whether to intimidate when recognizing the first player
        /// </remarks>
        public byte FirstRecognitionMenacing
        {
            get => (byte)CellsByName["FirstRecognitionMenacing"].Value;
            set => CellsByName["FirstRecognitionMenacing"].Value = value;
        }


        // Def="dummy8 reserve0[24]"
        /// <summary>
        /// reserve (dummy8)
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        public object Reserve
        {
            get => (object)CellsByName["Reserve"].Value;
            set => CellsByName["Reserve"].Value = value;
        }


        // Def="u16 Attack1_Distance"
        /// <summary>
        /// Attack 1 Maai [m] (u16)
        /// </summary>
        /// <remarks>
        /// Time to attack [m]
        /// </remarks>
        public ushort Attack1MaaiM
        {
            get => (ushort)CellsByName["Attack1MaaiM"].Value;
            set => CellsByName["Attack1MaaiM"].Value = value;
        }


        // Def="u16 Attack1_Margin"
        /// <summary>
        /// Attack 1 Maai play [m] (u16)
        /// </summary>
        /// <remarks>
        /// Play between attacks. Do not vibrate near the distance
        /// </remarks>
        public ushort Attack1MaaiPlayM
        {
            get => (ushort)CellsByName["Attack1MaaiPlayM"].Value;
            set => CellsByName["Attack1MaaiPlayM"].Value = value;
        }


        // Def="u8 Attack1_Rate = 50"
        /// <summary>
        /// Attack 1 ratio [0-100] (u8)
        /// </summary>
        /// <remarks>
        /// Frequency of attacks
        /// </remarks>
        public byte Attack1Ratio0100
        {
            get => (byte)CellsByName["Attack1Ratio0100"].Value;
            set => CellsByName["Attack1Ratio0100"].Value = value;
        }


        // Def="u8 Attack1_ActionID"
        /// <summary>
        /// Attack 1 type (u8)
        /// </summary>
        /// <remarks>
        /// Types of attacks
        /// </remarks>
        public byte Attack1Type
        {
            get => (byte)CellsByName["Attack1Type"].Value;
            set => CellsByName["Attack1Type"].Value = value;
        }


        // Def="u8 Attack1_DelayMin"
        /// <summary>
        /// Attack 1 Minimum delay time [frame] (u8)
        /// </summary>
        /// <remarks>
        /// The minimum delay time from the time when an attack becomes possible to the time when an attack is possible.
        /// </remarks>
        public byte Attack1MinimumDelayTimeFrame
        {
            get => (byte)CellsByName["Attack1MinimumDelayTimeFrame"].Value;
            set => CellsByName["Attack1MinimumDelayTimeFrame"].Value = value;
        }


        // Def="u8 Attack1_DelayMax"
        /// <summary>
        /// Attack 1 Maximum delay time [frame] (u8)
        /// </summary>
        /// <remarks>
        /// The longest delay time from the time when an attack becomes possible to the time when an attack is possible.
        /// </remarks>
        public byte Attack1MaximumDelayTimeFrame
        {
            get => (byte)CellsByName["Attack1MaximumDelayTimeFrame"].Value;
            set => CellsByName["Attack1MaximumDelayTimeFrame"].Value = value;
        }


        // Def="u8 Attack1_ConeAngle = 30"
        /// <summary>
        /// Attack 1 Attack permission Conical angle [deg] (u8)
        /// </summary>
        /// <remarks>
        /// If the angle between the line-of-sight direction and the direction vector to the target is within this angle, the attack is OK.
        /// </remarks>
        public byte Attack1AttackPermissionConicalAngleDeg
        {
            get => (byte)CellsByName["Attack1AttackPermissionConicalAngleDeg"].Value;
            set => CellsByName["Attack1AttackPermissionConicalAngleDeg"].Value = value;
        }



        // Def="u16 Attack2_Distance"
        /// <summary>
        /// Attack 2 Maai [m] (u16)
        /// </summary>
        /// <remarks>
        /// Time to attack [m]
        /// </remarks>
        public ushort Attack2MaaiM
        {
            get => (ushort)CellsByName["Attack2MaaiM"].Value;
            set => CellsByName["Attack2MaaiM"].Value = value;
        }


        // Def="u16 Attack2_Margin"
        /// <summary>
        /// Attack 2 Maai play [m] (u16)
        /// </summary>
        /// <remarks>
        /// Play between attacks. Do not vibrate near the distance
        /// </remarks>
        public ushort Attack2MaaiPlayM
        {
            get => (ushort)CellsByName["Attack2MaaiPlayM"].Value;
            set => CellsByName["Attack2MaaiPlayM"].Value = value;
        }



        // Def="u8 Attack2_ActionID"
        /// <summary>
        /// Attack 2 type (u8)
        /// </summary>
        /// <remarks>
        /// Types of attacks
        /// </remarks>
        public byte Attack2Type
        {
            get => (byte)CellsByName["Attack2Type"].Value;
            set => CellsByName["Attack2Type"].Value = value;
        }


        // Def="u8 Attack2_DelayMin"
        /// <summary>
        /// Attack 2 Minimum delay time [frame] (u8)
        /// </summary>
        /// <remarks>
        /// The minimum delay time from the time when an attack becomes possible to the time when an attack is possible.
        /// </remarks>
        public byte Attack2MinimumDelayTimeFrame
        {
            get => (byte)CellsByName["Attack2MinimumDelayTimeFrame"].Value;
            set => CellsByName["Attack2MinimumDelayTimeFrame"].Value = value;
        }


        // Def="u8 Attack2_DelayMax"
        /// <summary>
        /// Attack 2 Maximum delay time [frame] (u8)
        /// </summary>
        /// <remarks>
        /// The longest delay time from the time when an attack becomes possible to the time when an attack is possible.
        /// </remarks>
        public byte Attack2MaximumDelayTimeFrame
        {
            get => (byte)CellsByName["Attack2MaximumDelayTimeFrame"].Value;
            set => CellsByName["Attack2MaximumDelayTimeFrame"].Value = value;
        }


        // Def="u8 Attack2_ConeAngle = 30"
        /// <summary>
        /// Attack 2 Attack permission Conical angle [deg] (u8)
        /// </summary>
        /// <remarks>
        /// If the angle between the line-of-sight direction and the direction vector to the target is within this angle, the attack is OK.
        /// </remarks>
        public byte Attack2AttackPermissionConicalAngleDeg
        {
            get => (byte)CellsByName["Attack2AttackPermissionConicalAngleDeg"].Value;
            set => CellsByName["Attack2AttackPermissionConicalAngleDeg"].Value = value;
        }



        // Def="u16 Attack3_Distance"
        /// <summary>
        /// Attack 3 Maai [m] (u16)
        /// </summary>
        /// <remarks>
        /// Time to attack [m]
        /// </remarks>
        public ushort Attack3MaaiM
        {
            get => (ushort)CellsByName["Attack3MaaiM"].Value;
            set => CellsByName["Attack3MaaiM"].Value = value;
        }


        // Def="u16 Attack3_Margin"
        /// <summary>
        /// Attack 3 Maai play [m] (u16)
        /// </summary>
        /// <remarks>
        /// Play between attacks. Do not vibrate near the distance
        /// </remarks>
        public ushort Attack3MaaiPlayM
        {
            get => (ushort)CellsByName["Attack3MaaiPlayM"].Value;
            set => CellsByName["Attack3MaaiPlayM"].Value = value;
        }



        // Def="u8 Attack3_ActionID"
        /// <summary>
        /// Attack 3 types (u8)
        /// </summary>
        /// <remarks>
        /// Types of attacks
        /// </remarks>
        public byte Attack3Types
        {
            get => (byte)CellsByName["Attack3Types"].Value;
            set => CellsByName["Attack3Types"].Value = value;
        }


        // Def="u8 Attack3_DelayMin"
        /// <summary>
        /// Attack 3 Minimum delay time [frame] (u8)
        /// </summary>
        /// <remarks>
        /// The minimum delay time from the time when an attack becomes possible to the time when an attack is possible.
        /// </remarks>
        public byte Attack3MinimumDelayTimeFrame
        {
            get => (byte)CellsByName["Attack3MinimumDelayTimeFrame"].Value;
            set => CellsByName["Attack3MinimumDelayTimeFrame"].Value = value;
        }


        // Def="u8 Attack3_DelayMax"
        /// <summary>
        /// Attack 3 Maximum delay time [frame] (u8)
        /// </summary>
        /// <remarks>
        /// The longest delay time from the time when an attack becomes possible to the time when an attack is possible.
        /// </remarks>
        public byte Attack3MaximumDelayTimeFrame
        {
            get => (byte)CellsByName["Attack3MaximumDelayTimeFrame"].Value;
            set => CellsByName["Attack3MaximumDelayTimeFrame"].Value = value;
        }


        // Def="u8 Attack3_ConeAngle = 30"
        /// <summary>
        /// Attack 3 Attack permission Conical angle [deg] (u8)
        /// </summary>
        /// <remarks>
        /// If the angle between the line-of-sight direction and the direction vector to the target is within this angle, the attack is OK.
        /// </remarks>
        public byte Attack3AttackPermissionConicalAngleDeg
        {
            get => (byte)CellsByName["Attack3AttackPermissionConicalAngleDeg"].Value;
            set => CellsByName["Attack3AttackPermissionConicalAngleDeg"].Value = value;
        }



        // Def="u16 Attack4_Distance"
        /// <summary>
        /// Attack 4 Maai [m] (u16)
        /// </summary>
        /// <remarks>
        /// Time to attack [m]
        /// </remarks>
        public ushort Attack4MaaiM
        {
            get => (ushort)CellsByName["Attack4MaaiM"].Value;
            set => CellsByName["Attack4MaaiM"].Value = value;
        }


        // Def="u16 Attack4_Margin"
        /// <summary>
        /// Attack 4 Maai play [m] (u16)
        /// </summary>
        /// <remarks>
        /// Play between attacks. Do not vibrate near the distance
        /// </remarks>
        public ushort Attack4MaaiPlayM
        {
            get => (ushort)CellsByName["Attack4MaaiPlayM"].Value;
            set => CellsByName["Attack4MaaiPlayM"].Value = value;
        }



        // Def="u8 Attack4_ActionID"
        /// <summary>
        /// 4 types of attacks (u8)
        /// </summary>
        /// <remarks>
        /// Types of attacks
        /// </remarks>
        public byte _4TypesOfAttacks
        {
            get => (byte)CellsByName["_4TypesOfAttacks"].Value;
            set => CellsByName["_4TypesOfAttacks"].Value = value;
        }


        // Def="u8 Attack4_DelayMin"
        /// <summary>
        /// Attack 4 Minimum delay time [frame] (u8)
        /// </summary>
        /// <remarks>
        /// The minimum delay time from the time when an attack becomes possible to the time when an attack is possible.
        /// </remarks>
        public byte Attack4MinimumDelayTimeFrame
        {
            get => (byte)CellsByName["Attack4MinimumDelayTimeFrame"].Value;
            set => CellsByName["Attack4MinimumDelayTimeFrame"].Value = value;
        }


        // Def="u8 Attack4_DelayMax"
        /// <summary>
        /// Attack 4 Maximum delay time [frame] (u8)
        /// </summary>
        /// <remarks>
        /// The longest delay time from the time when an attack becomes possible to the time when an attack is possible.
        /// </remarks>
        public byte Attack4MaximumDelayTimeFrame
        {
            get => (byte)CellsByName["Attack4MaximumDelayTimeFrame"].Value;
            set => CellsByName["Attack4MaximumDelayTimeFrame"].Value = value;
        }


        // Def="u8 Attack4_ConeAngle = 30"
        /// <summary>
        /// Attack 4 Attack permission Conical angle [deg] (u8)
        /// </summary>
        /// <remarks>
        /// If the angle between the line-of-sight direction and the direction vector to the target is within this angle, the attack is OK.
        /// </remarks>
        public byte Attack4AttackPermissionConicalAngleDeg
        {
            get => (byte)CellsByName["Attack4AttackPermissionConicalAngleDeg"].Value;
            set => CellsByName["Attack4AttackPermissionConicalAngleDeg"].Value = value;
        }



    }
}

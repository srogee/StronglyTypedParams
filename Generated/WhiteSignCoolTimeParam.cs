
namespace StronglyTypedParams
{
    public class WhiteSignCoolTimeParam : ParamRow
    {
        public WhiteSignCoolTimeParam() : base()
        {
        }


        // Def="f32 limitationTime_Normal"
        /// <summary>
        /// Limitation Time - Normal (f32)
        /// </summary>
        /// <remarks>
        /// Time limit [sec] (normal, dry fingerless)
        /// </remarks>
        public float LimitationTimeNormal
        {
            get => (float)CellsByName["LimitationTimeNormal"].Value;
            set => CellsByName["LimitationTimeNormal"].Value = value;
        }


        // Def="f32 limitationTime_NormalDriedFinger"
        /// <summary>
        /// Limitation Time - Normal (Dried Finger) (f32)
        /// </summary>
        /// <remarks>
        /// Time limit [sec] (normal / dry finger)
        /// </remarks>
        public float LimitationTimeNormalDriedFinger
        {
            get => (float)CellsByName["LimitationTimeNormalDriedFinger"].Value;
            set => CellsByName["LimitationTimeNormalDriedFinger"].Value = value;
        }


        // Def="f32 limitationTime_Guardian"
        /// <summary>
        /// Limitation Time - Guardian (f32)
        /// </summary>
        /// <remarks>
        /// Time limit [sec] (Map guardian, dry fingerless)
        /// </remarks>
        public float LimitationTimeGuardian
        {
            get => (float)CellsByName["LimitationTimeGuardian"].Value;
            set => CellsByName["LimitationTimeGuardian"].Value = value;
        }


        // Def="f32 limitationTime_GuardianDriedFinger"
        /// <summary>
        /// Limitation Time - Guardian (Dried Finger) (f32)
        /// </summary>
        /// <remarks>
        /// Time limit [sec] (Map guardian / dry finger)
        /// </remarks>
        public float LimitationTimeGuardianDriedFinger
        {
            get => (float)CellsByName["LimitationTimeGuardianDriedFinger"].Value;
            set => CellsByName["LimitationTimeGuardianDriedFinger"].Value = value;
        }

    }
}

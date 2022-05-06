
namespace StronglyTypedParams
{
    public class SoundAutoReverbSelectParam : ParamRow
    {
        public SoundAutoReverbSelectParam() : base()
        {
        }


        // Def="u32 reverbType"
        /// <summary>
        /// Reverb Type (u32)
        /// </summary>
        /// <remarks>
        /// Reverb type
        /// </remarks>
        public uint ReverbType
        {
            get => (uint)CellsByName["ReverbType"].Value;
            set => CellsByName["ReverbType"].Value = value;
        }


        // Def="s32 AreaNo = -1"
        /// <summary>
        /// Condition: Area Number (s32)
        /// </summary>
        /// <remarks>
        /// Condition: Area No. (-1: Invalid)
        /// </remarks>
        public int ConditionAreaNumber
        {
            get => (int)CellsByName["ConditionAreaNumber"].Value;
            set => CellsByName["ConditionAreaNumber"].Value = value;
        }


        // Def="s8 IndoorOutdoor = -1"
        /// <summary>
        /// Condition: Indoor/Outdoor (s8)
        /// </summary>
        /// <remarks>
        /// Condition: Indoor / outdoor designation (0: outdoor, 1: indoor) (-1: invalid)
        /// </remarks>
        public sbyte ConditionIndoorOutdoor
        {
            get => (sbyte)CellsByName["ConditionIndoorOutdoor"].Value;
            set => CellsByName["ConditionIndoorOutdoor"].Value = value;
        }


        // Def="s8 useDistNoA = -1"
        /// <summary>
        /// Condition: Evaluation Distance A (s8)
        /// </summary>
        /// <remarks>
        /// Condition: Evaluation distance number A to use (-1: invalid)
        /// </remarks>
        public sbyte ConditionEvaluationDistanceA
        {
            get => (sbyte)CellsByName["ConditionEvaluationDistanceA"].Value;
            set => CellsByName["ConditionEvaluationDistanceA"].Value = value;
        }


        // Def="s8 useDistNoB = -1"
        /// <summary>
        /// Condition: Evaluation Distance B (s8)
        /// </summary>
        /// <remarks>
        /// Condition: Evaluation distance number B to be used (-1: invalid)
        /// </remarks>
        public sbyte ConditionEvaluationDistanceB
        {
            get => (sbyte)CellsByName["ConditionEvaluationDistanceB"].Value;
            set => CellsByName["ConditionEvaluationDistanceB"].Value = value;
        }


        // Def="dummy8 pad0[1]"
        /// <summary>
        /// pad0 (dummy8)
        /// </summary>
        /// <remarks>
        /// pad0
        /// </remarks>
        public object Pad0
        {
            get => (object)CellsByName["Pad0"].Value;
            set => CellsByName["Pad0"].Value = value;
        }


        // Def="f32 DistMinA = -1"
        /// <summary>
        /// Condition: Evaluation Distance A - Min (f32)
        /// </summary>
        /// <remarks>
        /// Condition: For evaluation distance minimum specification A (less than 0: invalid)
        /// </remarks>
        public float ConditionEvaluationDistanceAMin
        {
            get => (float)CellsByName["ConditionEvaluationDistanceAMin"].Value;
            set => CellsByName["ConditionEvaluationDistanceAMin"].Value = value;
        }


        // Def="f32 DistMaxA = -1"
        /// <summary>
        /// Condition: Evaluation Distance A - Max (f32)
        /// </summary>
        /// <remarks>
        /// Condition: For evaluation distance maximum specification A (less than 0: invalid)
        /// </remarks>
        public float ConditionEvaluationDistanceAMax
        {
            get => (float)CellsByName["ConditionEvaluationDistanceAMax"].Value;
            set => CellsByName["ConditionEvaluationDistanceAMax"].Value = value;
        }


        // Def="f32 DistMinB = -1"
        /// <summary>
        /// Condition: Evaluation Distance B - Min (f32)
        /// </summary>
        /// <remarks>
        /// Condition: For evaluation distance minimum specification A (less than 0: invalid)
        /// </remarks>
        public float ConditionEvaluationDistanceBMin
        {
            get => (float)CellsByName["ConditionEvaluationDistanceBMin"].Value;
            set => CellsByName["ConditionEvaluationDistanceBMin"].Value = value;
        }


        // Def="f32 DistMaxB = -1"
        /// <summary>
        /// Condition: Evaluation Distance B - Max (f32)
        /// </summary>
        /// <remarks>
        /// Condition: For evaluation distance maximum specification A (less than 0: invalid)
        /// </remarks>
        public float ConditionEvaluationDistanceBMax
        {
            get => (float)CellsByName["ConditionEvaluationDistanceBMax"].Value;
            set => CellsByName["ConditionEvaluationDistanceBMax"].Value = value;
        }


        // Def="s32 NoHitNumMin = -1"
        /// <summary>
        /// Condition: No Hit Minimum (s32)
        /// </summary>
        /// <remarks>
        /// Condition: No Hit number (-1: invalid)
        /// </remarks>
        public int ConditionNoHitMinimum
        {
            get => (int)CellsByName["ConditionNoHitMinimum"].Value;
            set => CellsByName["ConditionNoHitMinimum"].Value = value;
        }

    }
}


namespace StronglyTypedParams
{
    public class KeyAssignParam : ParamRow
    {
        public KeyAssignParam() : base()
        {
        }


        // Def="s32 padKeyId = -1"
        /// <summary>
        /// Pad Key ID (s32)
        /// </summary>
        /// <remarks>
        /// Pad (physical key)
        /// </remarks>
        public int PadKeyID
        {
            get => (int)CellsByName["PadKeyID"].Value;
            set => CellsByName["PadKeyID"].Value = value;
        }


        // Def="s32 keyboardModifyKey"
        /// <summary>
        /// Keyboard Modify Key (s32)
        /// </summary>
        /// <remarks>
        /// Keyboard modifier keys
        /// </remarks>
        public int KeyboardModifyKey
        {
            get => (int)CellsByName["KeyboardModifyKey"].Value;
            set => CellsByName["KeyboardModifyKey"].Value = value;
        }


        // Def="s32 keyboardKeyId = -1"
        /// <summary>
        /// Keyboard Key ID (s32)
        /// </summary>
        /// <remarks>
        /// Keyboard (physical keys)
        /// </remarks>
        public int KeyboardKeyID
        {
            get => (int)CellsByName["KeyboardKeyID"].Value;
            set => CellsByName["KeyboardKeyID"].Value = value;
        }


        // Def="s32 mouseModifyKey"
        /// <summary>
        /// Mouse Modify Key (s32)
        /// </summary>
        /// <remarks>
        /// Mouse modifier key
        /// </remarks>
        public int MouseModifyKey
        {
            get => (int)CellsByName["MouseModifyKey"].Value;
            set => CellsByName["MouseModifyKey"].Value = value;
        }


        // Def="s32 mouseKeyId"
        /// <summary>
        /// Mouse Key ID (s32)
        /// </summary>
        /// <remarks>
        /// Mouse (physical key)
        /// </remarks>
        public int MouseKeyID
        {
            get => (int)CellsByName["MouseKeyID"].Value;
            set => CellsByName["MouseKeyID"].Value = value;
        }


    }
}

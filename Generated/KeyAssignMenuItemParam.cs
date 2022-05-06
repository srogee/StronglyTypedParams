
namespace StronglyTypedParams
{
    public class KeyAssignMenuItemParam : ParamRow
    {
        public KeyAssignMenuItemParam() : base()
        {
        }


        // Def="s32 textID"
        /// <summary>
        /// Text ID (s32)
        /// </summary>
        /// <remarks>
        /// Key specified ⇒ Item name, 1-line help ID. No key specified ⇒ Category name ID. No text specified ⇒ Not displayed in pad / key settings (operation list display only)
        /// </remarks>
        public int TextID
        {
            get => (int)CellsByName["TextID"].Value;
            set => CellsByName["TextID"].Value = value;
        }


        // Def="s32 key = -1"
        /// <summary>
        /// Key (s32)
        /// </summary>
        /// <remarks>
        /// User input key to be assigned. If not specified, it will be treated as a category display item.
        /// </remarks>
        public int Key
        {
            get => (int)CellsByName["Key"].Value;
            set => CellsByName["Key"].Value = value;
        }


        // Def="u8 enableUnassign = 1"
        /// <summary>
        /// Allow Unassignment (u8)
        /// </summary>
        /// <remarks>
        /// Is it possible to unassign (default: possible)
        /// </remarks>
        public byte AllowUnassignment
        {
            get => (byte)CellsByName["AllowUnassignment"].Value;
            set => CellsByName["AllowUnassignment"].Value = value;
        }


        // Def="u8 enablePadConfig = 1"
        /// <summary>
        /// Allow Pad Config (u8)
        /// </summary>
        /// <remarks>
        /// Is it possible to change the pad operation assignment (default: possible)?
        /// </remarks>
        public byte AllowPadConfig
        {
            get => (byte)CellsByName["AllowPadConfig"].Value;
            set => CellsByName["AllowPadConfig"].Value = value;
        }


        // Def="u8 enableMouseConfig = 1"
        /// <summary>
        /// Allow Mouse Config (u8)
        /// </summary>
        /// <remarks>
        /// Is it possible to change the mouse operation assignment (default: possible)?
        /// </remarks>
        public byte AllowMouseConfig
        {
            get => (byte)CellsByName["AllowMouseConfig"].Value;
            set => CellsByName["AllowMouseConfig"].Value = value;
        }


        // Def="u8 group"
        /// <summary>
        /// Group (u8)
        /// </summary>
        /// <remarks>
        /// Group for determining duplicate assignments. Cannot be duplicated in the same group
        /// </remarks>
        public byte Group
        {
            get => (byte)CellsByName["Group"].Value;
            set => CellsByName["Group"].Value = value;
        }


        // Def="s32 mappingTextID"
        /// <summary>
        /// Mapping Text ID (s32)
        /// </summary>
        /// <remarks>
        /// Item name to be displayed in the operation list. 0 :: Do not display in the list
        /// </remarks>
        public int MappingTextID
        {
            get => (int)CellsByName["MappingTextID"].Value;
            set => CellsByName["MappingTextID"].Value = value;
        }


        // Def="u8 viewPad = 1"
        /// <summary>
        /// View Pad (u8)
        /// </summary>
        /// <remarks>
        /// Whether to display with key config (pad) (default: display)
        /// </remarks>
        public byte ViewPad
        {
            get => (byte)CellsByName["ViewPad"].Value;
            set => CellsByName["ViewPad"].Value = value;
        }


        // Def="u8 viewKeyboardMouse = 1"
        /// <summary>
        /// View Keyboard/Mouse (u8)
        /// </summary>
        /// <remarks>
        /// Whether to display with key config (mouse / keyboard) (default: display)
        /// </remarks>
        public byte ViewKeyboardMouse
        {
            get => (byte)CellsByName["ViewKeyboardMouse"].Value;
            set => CellsByName["ViewKeyboardMouse"].Value = value;
        }


        // Def="dummy8 padding[6]"
        /// <summary>
        /// padding (dummy8)
        /// </summary>
        /// <remarks>
        /// Is it possible to change the pad operation assignment (default: possible)?
        /// </remarks>
        public object Padding
        {
            get => (object)CellsByName["Padding"].Value;
            set => CellsByName["Padding"].Value = value;
        }

    }
}

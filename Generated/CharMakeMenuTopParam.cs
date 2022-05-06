
namespace StronglyTypedParams
{
    public class CharMakeMenuTopParam : ParamRow
    {
        public CharMakeMenuTopParam() : base()
        {
        }


        // Def="s32 commandType"
        /// <summary>
        /// Command Type (s32)
        /// </summary>
        /// <remarks>
        /// Command type
        /// </remarks>
        public int CommandType
        {
            get => (int)CellsByName["CommandType"].Value;
            set => CellsByName["CommandType"].Value = value;
        }


        // Def="s32 captionId"
        /// <summary>
        /// Caption ID (s32)
        /// </summary>
        /// <remarks>
        /// ID of the text to be displayed
        /// </remarks>
        public int CaptionID
        {
            get => (int)CellsByName["CaptionID"].Value;
            set => CellsByName["CaptionID"].Value = value;
        }


        // Def="s32 faceParamId"
        /// <summary>
        /// Face Param ID (s32)
        /// </summary>
        /// <remarks>
        /// Face Param ID
        /// </remarks>
        public int FaceParamID
        {
            get => (int)CellsByName["FaceParamID"].Value;
            set => CellsByName["FaceParamID"].Value = value;
        }


        // Def="s32 tableId"
        /// <summary>
        /// Table ID - Male (s32)
        /// </summary>
        /// <remarks>
        /// First ID (male) in the list of items to select. The command type is [Slider: Text ID of minimum label (n) and maximum label (n + 1), Color: ID of color table, Grid or text: First ID of character make list item, Other: Ignore]
        /// </remarks>
        public int TableIDMale
        {
            get => (int)CellsByName["TableIDMale"].Value;
            set => CellsByName["TableIDMale"].Value = value;
        }


        // Def="s32 viewCondition"
        /// <summary>
        /// View Condition (s32)
        /// </summary>
        /// <remarks>
        /// Conditions for displaying this command
        /// </remarks>
        public int ViewCondition
        {
            get => (int)CellsByName["ViewCondition"].Value;
            set => CellsByName["ViewCondition"].Value = value;
        }


        // Def="s8 previewMode"
        /// <summary>
        /// Preview Mode (s8)
        /// </summary>
        /// <remarks>
        /// Display mode of the character model displayed in preview
        /// </remarks>
        public sbyte PreviewMode
        {
            get => (sbyte)CellsByName["PreviewMode"].Value;
            set => CellsByName["PreviewMode"].Value = value;
        }


        // Def="dummy8 reserved2[3]"
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


        // Def="s32 tableId2 = -1"
        /// <summary>
        /// Table ID - Female (s32)
        /// </summary>
        /// <remarks>
        /// For women with table ID. If -1, refer to for men
        /// </remarks>
        public int TableIDFemale
        {
            get => (int)CellsByName["TableIDFemale"].Value;
            set => CellsByName["TableIDFemale"].Value = value;
        }


        // Def="s32 refFaceParamId = -1"
        /// <summary>
        /// Reference Face Param ID (s32)
        /// </summary>
        /// <remarks>
        /// Face param ID of the matching destination for "matching to XX"
        /// </remarks>
        public int ReferenceFaceParamID
        {
            get => (int)CellsByName["ReferenceFaceParamID"].Value;
            set => CellsByName["ReferenceFaceParamID"].Value = value;
        }


        // Def="s32 refTextId = -1"
        /// <summary>
        /// Reference Text ID (s32)
        /// </summary>
        /// <remarks>
        /// Display text ID for "fit to XX"
        /// </remarks>
        public int ReferenceTextID
        {
            get => (int)CellsByName["ReferenceTextID"].Value;
            set => CellsByName["ReferenceTextID"].Value = value;
        }


        // Def="s32 helpTextId = -1"
        /// <summary>
        /// Help Text ID (s32)
        /// </summary>
        /// <remarks>
        /// 1-line help text ID (-1: Get 1-line help with item text ID). Basically, item text ID = 1 line help text ID, but if you want to overwrite part of it, specify it with this parameter.
        /// </remarks>
        public int HelpTextID
        {
            get => (int)CellsByName["HelpTextID"].Value;
            set => CellsByName["HelpTextID"].Value = value;
        }


        // Def="u32 unlockEventFlagId"
        /// <summary>
        /// Unlock Event Flag ID (u32)
        /// </summary>
        /// <remarks>
        /// Event flag to unlock this item (0: invalid value). Invalid value will always be unlocked
        /// </remarks>
        public uint UnlockEventFlagID
        {
            get => (uint)CellsByName["UnlockEventFlagID"].Value;
            set => CellsByName["UnlockEventFlagID"].Value = value;
        }


    }
}

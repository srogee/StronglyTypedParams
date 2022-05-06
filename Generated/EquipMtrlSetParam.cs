
namespace StronglyTypedParams
{
    public class EquipMtrlSetParam : ParamRow
    {
        public EquipMtrlSetParam() : base()
        {
        }


        // Def="s32 materialId01 = -1"
        /// <summary>
        /// Material ID [1] (s32)
        /// </summary>
        /// <remarks>
        /// Material item ID required to strengthen armor.
        /// </remarks>
        public int MaterialID1
        {
            get => (int)CellsByName["MaterialID1"].Value;
            set => CellsByName["MaterialID1"].Value = value;
        }


        // Def="s32 materialId02 = -1"
        /// <summary>
        /// Material ID [2] (s32)
        /// </summary>
        /// <remarks>
        /// Material item ID required to strengthen armor.
        /// </remarks>
        public int MaterialID2
        {
            get => (int)CellsByName["MaterialID2"].Value;
            set => CellsByName["MaterialID2"].Value = value;
        }


        // Def="s32 materialId03 = -1"
        /// <summary>
        /// Material ID [3] (s32)
        /// </summary>
        /// <remarks>
        /// Material item ID required to strengthen armor.
        /// </remarks>
        public int MaterialID3
        {
            get => (int)CellsByName["MaterialID3"].Value;
            set => CellsByName["MaterialID3"].Value = value;
        }


        // Def="s32 materialId04 = -1"
        /// <summary>
        /// Material ID [4] (s32)
        /// </summary>
        /// <remarks>
        /// Material item ID required to strengthen armor.
        /// </remarks>
        public int MaterialID4
        {
            get => (int)CellsByName["MaterialID4"].Value;
            set => CellsByName["MaterialID4"].Value = value;
        }


        // Def="s32 materialId05 = -1"
        /// <summary>
        /// Material ID [5] (s32)
        /// </summary>
        /// <remarks>
        /// Material item ID required to strengthen armor.
        /// </remarks>
        public int MaterialID5
        {
            get => (int)CellsByName["MaterialID5"].Value;
            set => CellsByName["MaterialID5"].Value = value;
        }


        // Def="s32 materialId06 = -1"
        /// <summary>
        /// Material ID [6] (s32)
        /// </summary>
        /// <remarks>
        /// Material item ID required to strengthen armor.
        /// </remarks>
        public int MaterialID6
        {
            get => (int)CellsByName["MaterialID6"].Value;
            set => CellsByName["MaterialID6"].Value = value;
        }


        // Def="dummy8 pad_id[8]"
        /// <summary>
        /// Padding (dummy8)
        /// </summary>
        /// <remarks>
        /// Padding. For when the material item ID increases
        /// </remarks>
        public object Padding
        {
            get => (object)CellsByName["Padding"].Value;
            set => CellsByName["Padding"].Value = value;
        }


        // Def="s8 itemNum01 = -1"
        /// <summary>
        /// Material Amount [1] (s8)
        /// </summary>
        /// <remarks>
        /// The number of material items required to strengthen armor.
        /// </remarks>
        public sbyte MaterialAmount1
        {
            get => (sbyte)CellsByName["MaterialAmount1"].Value;
            set => CellsByName["MaterialAmount1"].Value = value;
        }


        // Def="s8 itemNum02 = -1"
        /// <summary>
        /// Material Amount [2] (s8)
        /// </summary>
        /// <remarks>
        /// The number of material items required to strengthen armor.
        /// </remarks>
        public sbyte MaterialAmount2
        {
            get => (sbyte)CellsByName["MaterialAmount2"].Value;
            set => CellsByName["MaterialAmount2"].Value = value;
        }


        // Def="s8 itemNum03 = -1"
        /// <summary>
        /// Material Amount [3] (s8)
        /// </summary>
        /// <remarks>
        /// The number of material items required to strengthen armor.
        /// </remarks>
        public sbyte MaterialAmount3
        {
            get => (sbyte)CellsByName["MaterialAmount3"].Value;
            set => CellsByName["MaterialAmount3"].Value = value;
        }


        // Def="s8 itemNum04 = -1"
        /// <summary>
        /// Material Amount [4] (s8)
        /// </summary>
        /// <remarks>
        /// The number of material items required to strengthen armor.
        /// </remarks>
        public sbyte MaterialAmount4
        {
            get => (sbyte)CellsByName["MaterialAmount4"].Value;
            set => CellsByName["MaterialAmount4"].Value = value;
        }


        // Def="s8 itemNum05 = -1"
        /// <summary>
        /// Material Amount [5] (s8)
        /// </summary>
        /// <remarks>
        /// The number of material items required to strengthen armor.
        /// </remarks>
        public sbyte MaterialAmount5
        {
            get => (sbyte)CellsByName["MaterialAmount5"].Value;
            set => CellsByName["MaterialAmount5"].Value = value;
        }


        // Def="s8 itemNum06 = -1"
        /// <summary>
        /// Material Amount [6] (s8)
        /// </summary>
        /// <remarks>
        /// The number of material items required to strengthen armor.
        /// </remarks>
        public sbyte MaterialAmount6
        {
            get => (sbyte)CellsByName["MaterialAmount6"].Value;
            set => CellsByName["MaterialAmount6"].Value = value;
        }



        // Def="u8 materialCate01 = 4"
        /// <summary>
        /// Material Category [1] (u8)
        /// </summary>
        /// <remarks>
        /// This is a category of material items required for strengthening armor.
        /// </remarks>
        public byte MaterialCategory1
        {
            get => (byte)CellsByName["MaterialCategory1"].Value;
            set => CellsByName["MaterialCategory1"].Value = value;
        }


        // Def="u8 materialCate02 = 4"
        /// <summary>
        /// Material Category [2] (u8)
        /// </summary>
        /// <remarks>
        /// This is a category of material items required for strengthening armor.
        /// </remarks>
        public byte MaterialCategory2
        {
            get => (byte)CellsByName["MaterialCategory2"].Value;
            set => CellsByName["MaterialCategory2"].Value = value;
        }


        // Def="u8 materialCate03 = 4"
        /// <summary>
        /// Material Category [3] (u8)
        /// </summary>
        /// <remarks>
        /// This is a category of material items required for strengthening armor.
        /// </remarks>
        public byte MaterialCategory3
        {
            get => (byte)CellsByName["MaterialCategory3"].Value;
            set => CellsByName["MaterialCategory3"].Value = value;
        }


        // Def="u8 materialCate04 = 4"
        /// <summary>
        /// Material Category [4] (u8)
        /// </summary>
        /// <remarks>
        /// This is a category of material items required for strengthening armor.
        /// </remarks>
        public byte MaterialCategory4
        {
            get => (byte)CellsByName["MaterialCategory4"].Value;
            set => CellsByName["MaterialCategory4"].Value = value;
        }


        // Def="u8 materialCate05 = 4"
        /// <summary>
        /// Material Category [5] (u8)
        /// </summary>
        /// <remarks>
        /// This is a category of material items required for strengthening armor.
        /// </remarks>
        public byte MaterialCategory5
        {
            get => (byte)CellsByName["MaterialCategory5"].Value;
            set => CellsByName["MaterialCategory5"].Value = value;
        }


        // Def="u8 materialCate06 = 4"
        /// <summary>
        /// Material Category [6] (u8)
        /// </summary>
        /// <remarks>
        /// This is a category of material items required for strengthening armor.
        /// </remarks>
        public byte MaterialCategory6
        {
            get => (byte)CellsByName["MaterialCategory6"].Value;
            set => CellsByName["MaterialCategory6"].Value = value;
        }



        // Def="u8 isDisableDispNum01:1"
        /// <summary>
        /// Disable Display Number [1] (u8)
        /// </summary>
        /// <remarks>
        /// Disable the number display (for enhanced shops)
        /// </remarks>
        public byte DisableDisplayNumber1
        {
            get => (byte)CellsByName["DisableDisplayNumber1"].Value;
            set => CellsByName["DisableDisplayNumber1"].Value = value;
        }


        // Def="u8 isDisableDispNum02:1"
        /// <summary>
        /// Disable Display Number [2] (u8)
        /// </summary>
        /// <remarks>
        /// Whether to disable the number display
        /// </remarks>
        public byte DisableDisplayNumber2
        {
            get => (byte)CellsByName["DisableDisplayNumber2"].Value;
            set => CellsByName["DisableDisplayNumber2"].Value = value;
        }


        // Def="u8 isDisableDispNum03:1"
        /// <summary>
        /// Disable Display Number [3] (u8)
        /// </summary>
        /// <remarks>
        /// Whether to disable the number display
        /// </remarks>
        public byte DisableDisplayNumber3
        {
            get => (byte)CellsByName["DisableDisplayNumber3"].Value;
            set => CellsByName["DisableDisplayNumber3"].Value = value;
        }


        // Def="u8 isDisableDispNum04:1"
        /// <summary>
        /// Disable Display Number [4] (u8)
        /// </summary>
        /// <remarks>
        /// Whether to disable the number display
        /// </remarks>
        public byte DisableDisplayNumber4
        {
            get => (byte)CellsByName["DisableDisplayNumber4"].Value;
            set => CellsByName["DisableDisplayNumber4"].Value = value;
        }


        // Def="u8 isDisableDispNum05:1"
        /// <summary>
        /// Disable Display Number [5] (u8)
        /// </summary>
        /// <remarks>
        /// Whether to disable the number display
        /// </remarks>
        public byte DisableDisplayNumber5
        {
            get => (byte)CellsByName["DisableDisplayNumber5"].Value;
            set => CellsByName["DisableDisplayNumber5"].Value = value;
        }


        // Def="u8 isDisableDispNum06:1"
        /// <summary>
        /// Disable Display Number [6] (u8)
        /// </summary>
        /// <remarks>
        /// Whether to disable the number display
        /// </remarks>
        public byte DisableDisplayNumber6
        {
            get => (byte)CellsByName["DisableDisplayNumber6"].Value;
            set => CellsByName["DisableDisplayNumber6"].Value = value;
        }


    }
}

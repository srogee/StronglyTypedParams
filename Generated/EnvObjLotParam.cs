
namespace StronglyTypedParams
{
    public class EnvObjLotParam : ParamRow
    {
        public EnvObjLotParam() : base()
        {
        }


        // Def="s32 AssetId_0 = -1"
        /// <summary>
        /// Asset ID [0] (s32)
        /// </summary>
        /// <remarks>
        /// AssetId_0 (-1: Ignore)
        /// </remarks>
        public int AssetID0
        {
            get => (int)CellsByName["AssetID0"].Value;
            set => CellsByName["AssetID0"].Value = value;
        }


        // Def="s32 AssetId_1 = -1"
        /// <summary>
        /// Asset ID [1] (s32)
        /// </summary>
        /// <remarks>
        /// AssetId_1 (-1: Ignore)
        /// </remarks>
        public int AssetID1
        {
            get => (int)CellsByName["AssetID1"].Value;
            set => CellsByName["AssetID1"].Value = value;
        }


        // Def="s32 AssetId_2 = -1"
        /// <summary>
        /// Asset ID [2] (s32)
        /// </summary>
        /// <remarks>
        /// AssetId_2 (-1: Ignore)
        /// </remarks>
        public int AssetID2
        {
            get => (int)CellsByName["AssetID2"].Value;
            set => CellsByName["AssetID2"].Value = value;
        }


        // Def="s32 AssetId_3 = -1"
        /// <summary>
        /// Asset ID [3] (s32)
        /// </summary>
        /// <remarks>
        /// AssetId_3 (-1: Ignore)
        /// </remarks>
        public int AssetID3
        {
            get => (int)CellsByName["AssetID3"].Value;
            set => CellsByName["AssetID3"].Value = value;
        }


        // Def="s32 AssetId_4 = -1"
        /// <summary>
        /// Asset ID [4] (s32)
        /// </summary>
        /// <remarks>
        /// AssetId_4 (-1: Ignore)
        /// </remarks>
        public int AssetID4
        {
            get => (int)CellsByName["AssetID4"].Value;
            set => CellsByName["AssetID4"].Value = value;
        }


        // Def="s32 AssetId_5 = -1"
        /// <summary>
        /// Asset ID [5] (s32)
        /// </summary>
        /// <remarks>
        /// AssetId_5 (-1: Ignore)
        /// </remarks>
        public int AssetID5
        {
            get => (int)CellsByName["AssetID5"].Value;
            set => CellsByName["AssetID5"].Value = value;
        }


        // Def="s32 AssetId_6 = -1"
        /// <summary>
        /// Asset ID [6] (s32)
        /// </summary>
        /// <remarks>
        /// AssetId_6 (-1: Ignore)
        /// </remarks>
        public int AssetID6
        {
            get => (int)CellsByName["AssetID6"].Value;
            set => CellsByName["AssetID6"].Value = value;
        }


        // Def="s32 AssetId_7 = -1"
        /// <summary>
        /// Asset ID [7] (s32)
        /// </summary>
        /// <remarks>
        /// AssetId_7 (-1: Ignore)
        /// </remarks>
        public int AssetID7
        {
            get => (int)CellsByName["AssetID7"].Value;
            set => CellsByName["AssetID7"].Value = value;
        }


        // Def="u8 CreateWeight_0"
        /// <summary>
        /// Create Weight [0] (u8)
        /// </summary>
        /// <remarks>
        /// Appearance ratio point (weight) _0: 0 is ignored
        /// </remarks>
        public byte CreateWeight0
        {
            get => (byte)CellsByName["CreateWeight0"].Value;
            set => CellsByName["CreateWeight0"].Value = value;
        }


        // Def="u8 CreateWeight_1"
        /// <summary>
        /// Create Weight [1] (u8)
        /// </summary>
        /// <remarks>
        /// Appearance ratio point (weight) _1
        /// </remarks>
        public byte CreateWeight1
        {
            get => (byte)CellsByName["CreateWeight1"].Value;
            set => CellsByName["CreateWeight1"].Value = value;
        }


        // Def="u8 CreateWeight_2"
        /// <summary>
        /// Create Weight [2] (u8)
        /// </summary>
        /// <remarks>
        /// Appearance ratio point (weight) _2
        /// </remarks>
        public byte CreateWeight2
        {
            get => (byte)CellsByName["CreateWeight2"].Value;
            set => CellsByName["CreateWeight2"].Value = value;
        }


        // Def="u8 CreateWeight_3"
        /// <summary>
        /// Create Weight [3] (u8)
        /// </summary>
        /// <remarks>
        /// Appearance ratio point (weight) _3
        /// </remarks>
        public byte CreateWeight3
        {
            get => (byte)CellsByName["CreateWeight3"].Value;
            set => CellsByName["CreateWeight3"].Value = value;
        }


        // Def="u8 CreateWeight_4"
        /// <summary>
        /// Create Weight [4] (u8)
        /// </summary>
        /// <remarks>
        /// Appearance ratio point (weight) _4
        /// </remarks>
        public byte CreateWeight4
        {
            get => (byte)CellsByName["CreateWeight4"].Value;
            set => CellsByName["CreateWeight4"].Value = value;
        }


        // Def="u8 CreateWeight_5"
        /// <summary>
        /// Create Weight [5] (u8)
        /// </summary>
        /// <remarks>
        /// Appearance ratio point (weight) _5
        /// </remarks>
        public byte CreateWeight5
        {
            get => (byte)CellsByName["CreateWeight5"].Value;
            set => CellsByName["CreateWeight5"].Value = value;
        }


        // Def="u8 CreateWeight_6"
        /// <summary>
        /// Create Weight [6] (u8)
        /// </summary>
        /// <remarks>
        /// Appearance ratio point (weight) _6
        /// </remarks>
        public byte CreateWeight6
        {
            get => (byte)CellsByName["CreateWeight6"].Value;
            set => CellsByName["CreateWeight6"].Value = value;
        }


        // Def="u8 CreateWeight_7"
        /// <summary>
        /// Create Weight [7] (u8)
        /// </summary>
        /// <remarks>
        /// Appearance ratio point (weight) _7
        /// </remarks>
        public byte CreateWeight7
        {
            get => (byte)CellsByName["CreateWeight7"].Value;
            set => CellsByName["CreateWeight7"].Value = value;
        }


        // Def="dummy8 Reserve_0[24]"
        /// <summary>
        /// Reserve (dummy8)
        /// </summary>
        /// <remarks>
        /// Reserve
        /// </remarks>
        public object Reserve
        {
            get => (object)CellsByName["Reserve"].Value;
            set => CellsByName["Reserve"].Value = value;
        }

    }
}


namespace StronglyTypedParams
{
    public class WeatherAssetReplaceParam : ParamRow
    {
        public WeatherAssetReplaceParam() : base()
        {
        }


        // Def="u32 mapId"
        /// <summary>
        /// Map ID (u32)
        /// </summary>
        /// <remarks>
        /// Specify the map number in 8 digits. Only open and legacy celestial sphere placement maps can be specified
        /// </remarks>
        public uint MapID
        {
            get => (uint)CellsByName["MapID"].Value;
            set => CellsByName["MapID"].Value = value;
        }


        // Def="s16 TransitionSrcWeather"
        /// <summary>
        /// Transition Source Weather (s16)
        /// </summary>
        /// <remarks>
        /// Specifies the assets that will be valid in this weather.
        /// </remarks>
        public short TransitionSourceWeather
        {
            get => (short)CellsByName["TransitionSourceWeather"].Value;
            set => CellsByName["TransitionSourceWeather"].Value = value;
        }


        // Def="dummy8 padding0[2]"
        /// <summary>
        /// reserved0 (dummy8)
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        public object Reserved0
        {
            get => (object)CellsByName["Reserved0"].Value;
            set => CellsByName["Reserved0"].Value = value;
        }


        // Def="u8 isFireAsh"
        /// <summary>
        /// Is Burning Ash (u8)
        /// </summary>
        /// <remarks>
        /// Specifies whether or not to adapt to the "fire ash" state of the map.
        /// </remarks>
        public byte IsBurningAsh
        {
            get => (byte)CellsByName["IsBurningAsh"].Value;
            set => CellsByName["IsBurningAsh"].Value = value;
        }


        // Def="dummy8 padding1[3]"
        /// <summary>
        /// padding0 (dummy8)
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        public object Padding0
        {
            get => (object)CellsByName["Padding0"].Value;
            set => CellsByName["Padding0"].Value = value;
        }


        // Def="u32 reserved2"
        /// <summary>
        /// reserved2 (u32)
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        public uint Reserved2
        {
            get => (uint)CellsByName["Reserved2"].Value;
            set => CellsByName["Reserved2"].Value = value;
        }


        // Def="s32 AssetId0 = -1"
        /// <summary>
        /// Asset ID [0] (s32)
        /// </summary>
        /// <remarks>
        /// -1: Invalid Specify the asset ID to generate. AEG999_999-> 999999
        /// </remarks>
        public int AssetID0
        {
            get => (int)CellsByName["AssetID0"].Value;
            set => CellsByName["AssetID0"].Value = value;
        }


        // Def="s32 AssetId1 = -1"
        /// <summary>
        /// Asset ID [1] (s32)
        /// </summary>
        /// <remarks>
        /// -1: Invalid Specify the asset ID to generate. AEG999_999-> 999999
        /// </remarks>
        public int AssetID1
        {
            get => (int)CellsByName["AssetID1"].Value;
            set => CellsByName["AssetID1"].Value = value;
        }


        // Def="s32 AssetId2 = -1"
        /// <summary>
        /// Asset ID [2] (s32)
        /// </summary>
        /// <remarks>
        /// -1: Invalid Specify the asset ID to generate. AEG999_999-> 999999
        /// </remarks>
        public int AssetID2
        {
            get => (int)CellsByName["AssetID2"].Value;
            set => CellsByName["AssetID2"].Value = value;
        }


        // Def="s32 AssetId3 = -1"
        /// <summary>
        /// Asset ID [3] (s32)
        /// </summary>
        /// <remarks>
        /// -1: Invalid Specify the asset ID to generate. AEG999_999-> 999999
        /// </remarks>
        public int AssetID3
        {
            get => (int)CellsByName["AssetID3"].Value;
            set => CellsByName["AssetID3"].Value = value;
        }


        // Def="s32 AssetId4 = -1"
        /// <summary>
        /// Asset ID [4] (s32)
        /// </summary>
        /// <remarks>
        /// -1: Invalid Specify the asset ID to generate. AEG999_999-> 999999
        /// </remarks>
        public int AssetID4
        {
            get => (int)CellsByName["AssetID4"].Value;
            set => CellsByName["AssetID4"].Value = value;
        }


        // Def="s32 AssetId5 = -1"
        /// <summary>
        /// Asset ID [5] (s32)
        /// </summary>
        /// <remarks>
        /// -1: Invalid Specify the asset ID to generate. AEG999_999-> 999999
        /// </remarks>
        public int AssetID5
        {
            get => (int)CellsByName["AssetID5"].Value;
            set => CellsByName["AssetID5"].Value = value;
        }


        // Def="s32 AssetId6 = -1"
        /// <summary>
        /// Asset ID [6] (s32)
        /// </summary>
        /// <remarks>
        /// -1: Invalid Specify the asset ID to generate. AEG999_999-> 999999
        /// </remarks>
        public int AssetID6
        {
            get => (int)CellsByName["AssetID6"].Value;
            set => CellsByName["AssetID6"].Value = value;
        }


        // Def="s32 AssetId7 = -1"
        /// <summary>
        /// Asset ID [7] (s32)
        /// </summary>
        /// <remarks>
        /// -1: Invalid Specify the asset ID to generate. AEG999_999-> 999999
        /// </remarks>
        public int AssetID7
        {
            get => (int)CellsByName["AssetID7"].Value;
            set => CellsByName["AssetID7"].Value = value;
        }



        // Def="s8 CreateAssetLimitId0 = -1"
        /// <summary>
        /// Create Asset Limit ID [0] (s8)
        /// </summary>
        /// <remarks>
        /// ID for production restriction. -1: Unlimited. Generation is allowed only if it matches the generation limit ID in "Map default parameter .xlsm" (SEQ08921).
        /// </remarks>
        public sbyte CreateAssetLimitID0
        {
            get => (sbyte)CellsByName["CreateAssetLimitID0"].Value;
            set => CellsByName["CreateAssetLimitID0"].Value = value;
        }


        // Def="s8 CreateAssetLimitId1 = -1"
        /// <summary>
        /// Create Asset Limit ID [1] (s8)
        /// </summary>
        /// <remarks>
        /// ID for production restriction. -1: Unlimited. Generation is allowed only if it matches the generation limit ID in "Map default parameter .xlsm" (SEQ08921).
        /// </remarks>
        public sbyte CreateAssetLimitID1
        {
            get => (sbyte)CellsByName["CreateAssetLimitID1"].Value;
            set => CellsByName["CreateAssetLimitID1"].Value = value;
        }


        // Def="s8 CreateAssetLimitId2 = -1"
        /// <summary>
        /// Create Asset Limit ID [2] (s8)
        /// </summary>
        /// <remarks>
        /// ID for production restriction. -1: Unlimited. Generation is allowed only if it matches the generation limit ID in "Map default parameter .xlsm" (SEQ08921).
        /// </remarks>
        public sbyte CreateAssetLimitID2
        {
            get => (sbyte)CellsByName["CreateAssetLimitID2"].Value;
            set => CellsByName["CreateAssetLimitID2"].Value = value;
        }


        // Def="s8 CreateAssetLimitId3 = -1"
        /// <summary>
        /// Create Asset Limit ID [3] (s8)
        /// </summary>
        /// <remarks>
        /// ID for production restriction. -1: Unlimited. Generation is allowed only if it matches the generation limit ID in "Map default parameter .xlsm" (SEQ08921).
        /// </remarks>
        public sbyte CreateAssetLimitID3
        {
            get => (sbyte)CellsByName["CreateAssetLimitID3"].Value;
            set => CellsByName["CreateAssetLimitID3"].Value = value;
        }


        // Def="dummy8 reserved1[4]"
        /// <summary>
        /// reserved1 (dummy8)
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        public object Reserved1
        {
            get => (object)CellsByName["Reserved1"].Value;
            set => CellsByName["Reserved1"].Value = value;
        }

    }
}

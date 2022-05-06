
namespace StronglyTypedParams
{
    public class MultiPlayCorrectionParam : ParamRow
    {
        public MultiPlayCorrectionParam() : base()
        {
        }


        // Def="u8 disableParam_NT:1"
        /// <summary>
        /// Disable Param - Network Test (u8)
        /// </summary>
        /// <remarks>
        /// Parameters marked with ○ are excluded in the NT version package.
        /// </remarks>
        public byte DisableParamNetworkTest
        {
            get => (byte)CellsByName["DisableParamNetworkTest"].Value;
            set => CellsByName["DisableParamNetworkTest"].Value = value;
        }


        // Def="dummy8 disableParamReserve1:7"
        /// <summary>
        /// Reserve for package output 1 (dummy8)
        /// </summary>
        /// <remarks>
        /// Reserve for package output 1
        /// </remarks>
        public object ReserveForPackageOutput1
        {
            get => (object)CellsByName["ReserveForPackageOutput1"].Value;
            set => CellsByName["ReserveForPackageOutput1"].Value = value;
        }


        // Def="dummy8 disableParamReserve2[3]"
        /// <summary>
        /// Reserve for package output 2 (dummy8)
        /// </summary>
        /// <remarks>
        /// Reserve for package output 2
        /// </remarks>
        public object ReserveForPackageOutput2
        {
            get => (object)CellsByName["ReserveForPackageOutput2"].Value;
            set => CellsByName["ReserveForPackageOutput2"].Value = value;
        }


        // Def="s32 client1SpEffectId = -1"
        /// <summary>
        /// Friendly Client [1] - SpEffect ID (s32)
        /// </summary>
        /// <remarks>
        /// 1 cooperating client Special effect ID
        /// </remarks>
        public int FriendlyClient1SpEffectID
        {
            get => (int)CellsByName["FriendlyClient1SpEffectID"].Value;
            set => CellsByName["FriendlyClient1SpEffectID"].Value = value;
        }


        // Def="s32 client2SpEffectId = -1"
        /// <summary>
        /// Friendly Client [2] - SpEffect ID (s32)
        /// </summary>
        /// <remarks>
        /// 2 cooperating clients Special effect ID
        /// </remarks>
        public int FriendlyClient2SpEffectID
        {
            get => (int)CellsByName["FriendlyClient2SpEffectID"].Value;
            set => CellsByName["FriendlyClient2SpEffectID"].Value = value;
        }


        // Def="s32 client3SpEffectId = -1"
        /// <summary>
        /// Friendly Client [3] - SpEffect ID (s32)
        /// </summary>
        /// <remarks>
        /// 3 cooperating clients Special effect ID
        /// </remarks>
        public int FriendlyClient3SpEffectID
        {
            get => (int)CellsByName["FriendlyClient3SpEffectID"].Value;
            set => CellsByName["FriendlyClient3SpEffectID"].Value = value;
        }


        // Def="u8 bOverrideSpEffect"
        /// <summary>
        /// Override SpEffect when Client Count Changes (u8)
        /// </summary>
        /// <remarks>
        /// Whether to overwrite when the number of cooperating people fluctuates
        /// </remarks>
        public byte OverrideSpEffectWhenClientCountChanges
        {
            get => (byte)CellsByName["OverrideSpEffectWhenClientCountChanges"].Value;
            set => CellsByName["OverrideSpEffectWhenClientCountChanges"].Value = value;
        }


        // Def="dummy8 pad3[15]"
        /// <summary>
        /// pad (dummy8)
        /// </summary>
        /// <remarks>
        /// pad
        /// </remarks>
        public object Pad
        {
            get => (object)CellsByName["Pad"].Value;
            set => CellsByName["Pad"].Value = value;
        }

    }
}

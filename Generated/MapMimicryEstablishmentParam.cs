
namespace StronglyTypedParams
{
    public class MapMimicryEstablishmentParam : ParamRow
    {
        public MapMimicryEstablishmentParam() : base()
        {
        }


        // Def="f32 mimicryEstablishment0 = -1"
        /// <summary>
        /// Mimicry Weight [0] (f32)
        /// </summary>
        /// <remarks>
        /// Mimicry weight 0
        /// </remarks>
        public float MimicryWeight0
        {
            get => (float)CellsByName["MimicryWeight0"].Value;
            set => CellsByName["MimicryWeight0"].Value = value;
        }


        // Def="f32 mimicryEstablishment1 = -1"
        /// <summary>
        /// Mimicry Weight [1] (f32)
        /// </summary>
        /// <remarks>
        /// Mimicry weight 1
        /// </remarks>
        public float MimicryWeight1
        {
            get => (float)CellsByName["MimicryWeight1"].Value;
            set => CellsByName["MimicryWeight1"].Value = value;
        }


        // Def="f32 mimicryEstablishment2 = -1"
        /// <summary>
        /// Mimicry Weight [2] (f32)
        /// </summary>
        /// <remarks>
        /// Mimicry weight 2
        /// </remarks>
        public float MimicryWeight2
        {
            get => (float)CellsByName["MimicryWeight2"].Value;
            set => CellsByName["MimicryWeight2"].Value = value;
        }


        // Def="s32 mimicryBeginSfxId0 = -1"
        /// <summary>
        /// Mimicry - Init SFX ID [0] (s32)
        /// </summary>
        /// <remarks>
        /// Mimicry 0 SFXID Forward swing
        /// </remarks>
        public int MimicryInitSFXID0
        {
            get => (int)CellsByName["MimicryInitSFXID0"].Value;
            set => CellsByName["MimicryInitSFXID0"].Value = value;
        }


        // Def="s32 mimicrySfxId0 = -1"
        /// <summary>
        /// Mimicry - Midst SFX ID [0] (s32)
        /// </summary>
        /// <remarks>
        /// Mimicry 0 SFXID body
        /// </remarks>
        public int MimicryMidstSFXID0
        {
            get => (int)CellsByName["MimicryMidstSFXID0"].Value;
            set => CellsByName["MimicryMidstSFXID0"].Value = value;
        }


        // Def="s32 mimicryEndSfxId0 = -1"
        /// <summary>
        /// Mimicry - End SFX ID [0] (s32)
        /// </summary>
        /// <remarks>
        /// Mimicry 0 SFXID release
        /// </remarks>
        public int MimicryEndSFXID0
        {
            get => (int)CellsByName["MimicryEndSFXID0"].Value;
            set => CellsByName["MimicryEndSFXID0"].Value = value;
        }


        // Def="s32 mimicryBeginSfxId1 = -1"
        /// <summary>
        /// Mimicry - Init SFX ID [1] (s32)
        /// </summary>
        /// <remarks>
        /// Mimicry 1 SFXID Forward swing
        /// </remarks>
        public int MimicryInitSFXID1
        {
            get => (int)CellsByName["MimicryInitSFXID1"].Value;
            set => CellsByName["MimicryInitSFXID1"].Value = value;
        }


        // Def="s32 mimicrySfxId1 = -1"
        /// <summary>
        /// Mimicry - Midst SFX ID [1] (s32)
        /// </summary>
        /// <remarks>
        /// Mimicry 1 SFXID body
        /// </remarks>
        public int MimicryMidstSFXID1
        {
            get => (int)CellsByName["MimicryMidstSFXID1"].Value;
            set => CellsByName["MimicryMidstSFXID1"].Value = value;
        }


        // Def="s32 mimicryEndSfxId1 = -1"
        /// <summary>
        /// Mimicry - End SFX ID [1] (s32)
        /// </summary>
        /// <remarks>
        /// Mimicry 1 SFXID release
        /// </remarks>
        public int MimicryEndSFXID1
        {
            get => (int)CellsByName["MimicryEndSFXID1"].Value;
            set => CellsByName["MimicryEndSFXID1"].Value = value;
        }


        // Def="s32 mimicryBeginSfxId2 = -1"
        /// <summary>
        /// Mimicry - Init SFX ID [2] (s32)
        /// </summary>
        /// <remarks>
        /// Mimicry 2 SFXID Forward swing
        /// </remarks>
        public int MimicryInitSFXID2
        {
            get => (int)CellsByName["MimicryInitSFXID2"].Value;
            set => CellsByName["MimicryInitSFXID2"].Value = value;
        }


        // Def="s32 mimicrySfxId2 = -1"
        /// <summary>
        /// Mimicry - Midst SFX ID [2] (s32)
        /// </summary>
        /// <remarks>
        /// Mimicry 2 SFXID body
        /// </remarks>
        public int MimicryMidstSFXID2
        {
            get => (int)CellsByName["MimicryMidstSFXID2"].Value;
            set => CellsByName["MimicryMidstSFXID2"].Value = value;
        }


        // Def="s32 mimicryEndSfxId2 = -1"
        /// <summary>
        /// Mimicry - End SFX ID [2] (s32)
        /// </summary>
        /// <remarks>
        /// Mimicry 2 SFXID cancellation
        /// </remarks>
        public int MimicryEndSFXID2
        {
            get => (int)CellsByName["MimicryEndSFXID2"].Value;
            set => CellsByName["MimicryEndSFXID2"].Value = value;
        }


        // Def="dummy8 pad1[16]"
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

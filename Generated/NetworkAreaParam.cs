
namespace StronglyTypedParams
{
    public class NetworkAreaParam : ParamRow
    {
        public NetworkAreaParam() : base()
        {
        }


        // Def="f32 cellSizeX = 30"
        /// <summary>
        /// Cell Size: X (f32)
        /// </summary>
        /// <remarks>
        /// Cell size X
        /// </remarks>
        public float CellSizeX
        {
            get => (float)CellsByName["CellSizeX"].Value;
            set => CellsByName["CellSizeX"].Value = value;
        }


        // Def="f32 cellSizeY = 8"
        /// <summary>
        /// Cell Size: Y (f32)
        /// </summary>
        /// <remarks>
        /// Cell size Y
        /// </remarks>
        public float CellSizeY
        {
            get => (float)CellsByName["CellSizeY"].Value;
            set => CellsByName["CellSizeY"].Value = value;
        }


        // Def="f32 cellSizeZ = 30"
        /// <summary>
        /// Cell Size: Z (f32)
        /// </summary>
        /// <remarks>
        /// Cell size Z
        /// </remarks>
        public float CellSizeZ
        {
            get => (float)CellsByName["CellSizeZ"].Value;
            set => CellsByName["CellSizeZ"].Value = value;
        }


        // Def="f32 cellOffsetX"
        /// <summary>
        /// Cell Offset: X (f32)
        /// </summary>
        /// <remarks>
        /// Cell offset X
        /// </remarks>
        public float CellOffsetX
        {
            get => (float)CellsByName["CellOffsetX"].Value;
            set => CellsByName["CellOffsetX"].Value = value;
        }


        // Def="f32 cellOffsetY"
        /// <summary>
        /// Cell Offset: Y (f32)
        /// </summary>
        /// <remarks>
        /// Cell offset Y
        /// </remarks>
        public float CellOffsetY
        {
            get => (float)CellsByName["CellOffsetY"].Value;
            set => CellsByName["CellOffsetY"].Value = value;
        }


        // Def="f32 cellOffsetZ"
        /// <summary>
        /// Cell Offset: Z (f32)
        /// </summary>
        /// <remarks>
        /// Cell offset Z
        /// </remarks>
        public float CellOffsetZ
        {
            get => (float)CellsByName["CellOffsetZ"].Value;
            set => CellsByName["CellOffsetZ"].Value = value;
        }


        // Def="u8 enableBloodstain:1"
        /// <summary>
        /// Enable Bloodstain (u8)
        /// </summary>
        /// <remarks>
        /// Effective bloodstain / death illusion
        /// </remarks>
        public byte EnableBloodstain
        {
            get => (byte)CellsByName["EnableBloodstain"].Value;
            set => CellsByName["EnableBloodstain"].Value = value;
        }


        // Def="u8 enableBloodMessage:1"
        /// <summary>
        /// Enable Blood Message (u8)
        /// </summary>
        /// <remarks>
        /// Blood character valid
        /// </remarks>
        public byte EnableBloodMessage
        {
            get => (byte)CellsByName["EnableBloodMessage"].Value;
            set => CellsByName["EnableBloodMessage"].Value = value;
        }


        // Def="u8 enableGhost:1"
        /// <summary>
        /// Enable Ghost (u8)
        /// </summary>
        /// <remarks>
        /// Phantom effective
        /// </remarks>
        public byte EnableGhost
        {
            get => (byte)CellsByName["EnableGhost"].Value;
            set => CellsByName["EnableGhost"].Value = value;
        }


        // Def="u8 enableMultiPlay:1"
        /// <summary>
        /// Enable Multiplayer (u8)
        /// </summary>
        /// <remarks>
        /// Multiplayer enabled
        /// </remarks>
        public byte EnableMultiplayer
        {
            get => (byte)CellsByName["EnableMultiplayer"].Value;
            set => CellsByName["EnableMultiplayer"].Value = value;
        }


        // Def="u8 enableRingSearch:1"
        /// <summary>
        /// Enable Ring Search (u8)
        /// </summary>
        /// <remarks>
        /// Is it a search target for ring search? (Area called Kanemori Ash Spirit / Relief Blue Spirit)
        /// </remarks>
        public byte EnableRingSearch
        {
            get => (byte)CellsByName["EnableRingSearch"].Value;
            set => CellsByName["EnableRingSearch"].Value = value;
        }


        // Def="u8 enableBreakInSearch:1"
        /// <summary>
        /// Enable Invasion Search (u8)
        /// </summary>
        /// <remarks>
        /// Is it the target of intrusion search?
        /// </remarks>
        public byte EnableInvasionSearch
        {
            get => (byte)CellsByName["EnableInvasionSearch"].Value;
            set => CellsByName["EnableInvasionSearch"].Value = value;
        }


        // Def="dummy8 dummy[3]"
        /// <summary>
        /// dummy (dummy8)
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        public object Dummy
        {
            get => (object)CellsByName["Dummy"].Value;
            set => CellsByName["Dummy"].Value = value;
        }

    }
}

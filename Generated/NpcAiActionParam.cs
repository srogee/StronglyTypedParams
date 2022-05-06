
namespace StronglyTypedParams
{
    public class NpcAiActionParam : ParamRow
    {
        public NpcAiActionParam() : base()
        {
        }


        // Def="u8 moveDir"
        /// <summary>
        /// Move Direction (u8)
        /// </summary>
        /// <remarks>
        /// Moving direction to enter
        /// </remarks>
        public byte MoveDirection
        {
            get => (byte)CellsByName["MoveDirection"].Value;
            set => CellsByName["MoveDirection"].Value = value;
        }


        // Def="u8 key1"
        /// <summary>
        /// Key [1] (u8)
        /// </summary>
        /// <remarks>
        /// Key to enter
        /// </remarks>
        public byte Key1
        {
            get => (byte)CellsByName["Key1"].Value;
            set => CellsByName["Key1"].Value = value;
        }


        // Def="u8 key2"
        /// <summary>
        /// Key [2] (u8)
        /// </summary>
        /// <remarks>
        /// Key to enter
        /// </remarks>
        public byte Key2
        {
            get => (byte)CellsByName["Key2"].Value;
            set => CellsByName["Key2"].Value = value;
        }


        // Def="u8 key3"
        /// <summary>
        /// Key [3] (u8)
        /// </summary>
        /// <remarks>
        /// Key to enter
        /// </remarks>
        public byte Key3
        {
            get => (byte)CellsByName["Key3"].Value;
            set => CellsByName["Key3"].Value = value;
        }


        // Def="u8 bMoveDirHold"
        /// <summary>
        /// Handle Move Direction as Long Press (u8)
        /// </summary>
        /// <remarks>
        /// Whether to handle the input movement direction as long press
        /// </remarks>
        public byte HandleMoveDirectionAsLongPress
        {
            get => (byte)CellsByName["HandleMoveDirectionAsLongPress"].Value;
            set => CellsByName["HandleMoveDirectionAsLongPress"].Value = value;
        }


        // Def="u8 bKeyHold1"
        /// <summary>
        /// Handle Key [1] Hold as Long Press (u8)
        /// </summary>
        /// <remarks>
        /// Whether to treat the key to be entered as a long press
        /// </remarks>
        public byte HandleKey1HoldAsLongPress
        {
            get => (byte)CellsByName["HandleKey1HoldAsLongPress"].Value;
            set => CellsByName["HandleKey1HoldAsLongPress"].Value = value;
        }


        // Def="u8 bKeyHold2"
        /// <summary>
        /// Handle Key [2] Hold as Long Press (u8)
        /// </summary>
        /// <remarks>
        /// Whether to treat the key to be entered as a long press
        /// </remarks>
        public byte HandleKey2HoldAsLongPress
        {
            get => (byte)CellsByName["HandleKey2HoldAsLongPress"].Value;
            set => CellsByName["HandleKey2HoldAsLongPress"].Value = value;
        }


        // Def="u8 bKeyHold3"
        /// <summary>
        /// Handle Key [3] Hold as Long Press (u8)
        /// </summary>
        /// <remarks>
        /// Whether to treat the key to be entered as a long press
        /// </remarks>
        public byte HandleKey3HoldAsLongPress
        {
            get => (byte)CellsByName["HandleKey3HoldAsLongPress"].Value;
            set => CellsByName["HandleKey3HoldAsLongPress"].Value = value;
        }


        // Def="s32 gestureId"
        /// <summary>
        /// Gesture ID (s32)
        /// </summary>
        /// <remarks>
        /// Gesture ID
        /// </remarks>
        public int GestureID
        {
            get => (int)CellsByName["GestureID"].Value;
            set => CellsByName["GestureID"].Value = value;
        }


        // Def="u8 bLifeEndSuccess"
        /// <summary>
        /// AI Goal Waits For Duration End (u8)
        /// </summary>
        /// <remarks>
        /// If this is ON, the AI goal will not be successful until the end of its life
        /// </remarks>
        public byte AIGoalWaitsForDurationEnd
        {
            get => (byte)CellsByName["AIGoalWaitsForDurationEnd"].Value;
            set => CellsByName["AIGoalWaitsForDurationEnd"].Value = value;
        }


        // Def="dummy8 pad1[3]"
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

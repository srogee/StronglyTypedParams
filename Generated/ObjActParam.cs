
namespace StronglyTypedParams
{
    public class ObjActParam : ParamRow
    {
        public ObjActParam() : base()
        {
        }


        // Def="s32 actionEnableMsgId = -1"
        /// <summary>
        /// Action Enabled - Message ID (s32)
        /// </summary>
        /// <remarks>
        /// The MsgID of the menu displayed when the action is enabled.
        /// </remarks>
        public int ActionEnabledMessageID
        {
            get => (int)CellsByName["ActionEnabledMessageID"].Value;
            set => CellsByName["ActionEnabledMessageID"].Value = value;
        }


        // Def="s32 actionFailedMsgId = -1"
        /// <summary>
        /// Action Failed - Message ID (s32)
        /// </summary>
        /// <remarks>
        /// The MsgID of the menu to display when the action fails.
        /// </remarks>
        public int ActionFailedMessageID
        {
            get => (int)CellsByName["ActionFailedMessageID"].Value;
            set => CellsByName["ActionFailedMessageID"].Value = value;
        }


        // Def="u32 spQualifiedPassEventFlag"
        /// <summary>
        /// Unconditional Qualified Event Flag ID (u32)
        /// </summary>
        /// <remarks>
        /// Event flags for unconditionally passing special conditions.
        /// </remarks>
        public uint UnconditionalQualifiedEventFlagID
        {
            get => (uint)CellsByName["UnconditionalQualifiedEventFlagID"].Value;
            set => CellsByName["UnconditionalQualifiedEventFlagID"].Value = value;
        }


        // Def="u32 playerAnimId"
        /// <summary>
        /// Player Animation ID (u32)
        /// </summary>
        /// <remarks>
        /// This is the animation ID for the action of the player character.
        /// </remarks>
        public uint PlayerAnimationID
        {
            get => (uint)CellsByName["PlayerAnimationID"].Value;
            set => CellsByName["PlayerAnimationID"].Value = value;
        }


        // Def="u32 chrAnimId"
        /// <summary>
        /// Character Animation ID (u32)
        /// </summary>
        /// <remarks>
        /// Anime ID at the time of action such as enemy
        /// </remarks>
        public uint CharacterAnimationID
        {
            get => (uint)CellsByName["CharacterAnimationID"].Value;
            set => CellsByName["CharacterAnimationID"].Value = value;
        }


        // Def="u16 validDist = 150"
        /// <summary>
        /// Valid Distance (u16)
        /// </summary>
        /// <remarks>
        /// The effective distance of the action.
        /// </remarks>
        public ushort ValidDistance
        {
            get => (ushort)CellsByName["ValidDistance"].Value;
            set => CellsByName["ValidDistance"].Value = value;
        }


        // Def="u16 spQualifiedId"
        /// <summary>
        /// Conditional Qualified Event Flag ID [1] (u16)
        /// </summary>
        /// <remarks>
        /// Special condition ID
        /// </remarks>
        public ushort ConditionalQualifiedEventFlagID1
        {
            get => (ushort)CellsByName["ConditionalQualifiedEventFlagID1"].Value;
            set => CellsByName["ConditionalQualifiedEventFlagID1"].Value = value;
        }


        // Def="u16 spQualifiedId2"
        /// <summary>
        /// Conditional Qualified Event Flag ID [2] (u16)
        /// </summary>
        /// <remarks>
        /// Special condition ID part 2
        /// </remarks>
        public ushort ConditionalQualifiedEventFlagID2
        {
            get => (ushort)CellsByName["ConditionalQualifiedEventFlagID2"].Value;
            set => CellsByName["ConditionalQualifiedEventFlagID2"].Value = value;
        }


        // Def="u8 objDummyId"
        /// <summary>
        /// Object Dummy Poly ID (u8)
        /// </summary>
        /// <remarks>
        /// Damipoli ID that is the action position of the object
        /// </remarks>
        public byte ObjectDummyPolyID
        {
            get => (byte)CellsByName["ObjectDummyPolyID"].Value;
            set => CellsByName["ObjectDummyPolyID"].Value = value;
        }


        // Def="u8 isEventKickSync"
        /// <summary>
        /// Is Event Execution Synchronized (u8)
        /// </summary>
        /// <remarks>
        /// ObjAct Whether to synchronize the events used in the execution judgment. Set to basic ×. It may be set to ○ only when the actor is not important.
        /// </remarks>
        public byte IsEventExecutionSynchronized
        {
            get => (byte)CellsByName["IsEventExecutionSynchronized"].Value;
            set => CellsByName["IsEventExecutionSynchronized"].Value = value;
        }


        // Def="u32 objAnimId"
        /// <summary>
        /// Object Animation ID (u32)
        /// </summary>
        /// <remarks>
        /// This is the animation ID for the action of the object.
        /// </remarks>
        public uint ObjectAnimationID
        {
            get => (uint)CellsByName["ObjectAnimationID"].Value;
            set => CellsByName["ObjectAnimationID"].Value = value;
        }


        // Def="u8 validPlayerAngle = 30"
        /// <summary>
        /// Valid Player Angle (u8)
        /// </summary>
        /// <remarks>
        /// The effective angle of the player's action. Effective angle difference between the player's orientation vector and the orientation vector to the object
        /// </remarks>
        public byte ValidPlayerAngle
        {
            get => (byte)CellsByName["ValidPlayerAngle"].Value;
            set => CellsByName["ValidPlayerAngle"].Value = value;
        }


        // Def="u8 spQualifiedType"
        /// <summary>
        /// Qualified ID Type [1] (u8)
        /// </summary>
        /// <remarks>
        /// Types of special conditions
        /// </remarks>
        public byte QualifiedIDType1
        {
            get => (byte)CellsByName["QualifiedIDType1"].Value;
            set => CellsByName["QualifiedIDType1"].Value = value;
        }


        // Def="u8 spQualifiedType2"
        /// <summary>
        /// Qualified ID Type [2] (u8)
        /// </summary>
        /// <remarks>
        /// Type of special condition 2
        /// </remarks>
        public byte QualifiedIDType2
        {
            get => (byte)CellsByName["QualifiedIDType2"].Value;
            set => CellsByName["QualifiedIDType2"].Value = value;
        }


        // Def="u8 validObjAngle = 30"
        /// <summary>
        /// Valid Object Angle (u8)
        /// </summary>
        /// <remarks>
        /// The action effective angle of the object. Effective angle difference between the action vector of the object and the character vector
        /// </remarks>
        public byte ValidObjectAngle
        {
            get => (byte)CellsByName["ValidObjectAngle"].Value;
            set => CellsByName["ValidObjectAngle"].Value = value;
        }


        // Def="u8 chrSorbType"
        /// <summary>
        /// Character Absorb Type (u8)
        /// </summary>
        /// <remarks>
        /// It is a method of adsorbing characters during object action.
        /// </remarks>
        public byte CharacterAbsorbType
        {
            get => (byte)CellsByName["CharacterAbsorbType"].Value;
            set => CellsByName["CharacterAbsorbType"].Value = value;
        }


        // Def="u8 eventKickTiming"
        /// <summary>
        /// Event Execution Timing (u8)
        /// </summary>
        /// <remarks>
        /// Event execution timing
        /// </remarks>
        public byte EventExecutionTiming
        {
            get => (byte)CellsByName["EventExecutionTiming"].Value;
            set => CellsByName["EventExecutionTiming"].Value = value;
        }


        // Def="dummy8 pad1[2]"
        /// <summary>
        /// pad1 (dummy8)
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        public object Pad1
        {
            get => (object)CellsByName["Pad1"].Value;
            set => CellsByName["Pad1"].Value = value;
        }


        // Def="s32 actionButtonParamId = -1"
        /// <summary>
        /// Action Button Param ID (s32)
        /// </summary>
        /// <remarks>
        /// Action button parameter ID
        /// </remarks>
        public int ActionButtonParamID
        {
            get => (int)CellsByName["ActionButtonParamID"].Value;
            set => CellsByName["ActionButtonParamID"].Value = value;
        }


        // Def="f32 enableTreasureDelaySec"
        /// <summary>
        /// Treasure Enable Delay (f32)
        /// </summary>
        /// <remarks>
        /// The number of seconds from the execution of the object action to the activation of the treasure. A setting exclusively for the object type "treasure box" of the object act.
        /// </remarks>
        public float TreasureEnableDelay
        {
            get => (float)CellsByName["TreasureEnableDelay"].Value;
            set => CellsByName["TreasureEnableDelay"].Value = value;
        }


        // Def="s32 preActionSfxDmypolyId = -1"
        /// <summary>
        /// Pre-action SFX Dummy Poly ID (s32)
        /// </summary>
        /// <remarks>
        /// Issue SFX from this Damipoli ID before executing the object. If it is -1, start from the origin.
        /// </remarks>
        public int PreActionSFXDummyPolyID
        {
            get => (int)CellsByName["PreActionSFXDummyPolyID"].Value;
            set => CellsByName["PreActionSFXDummyPolyID"].Value = value;
        }


        // Def="s32 preActionSfxId = -1"
        /// <summary>
        /// Pre-action SFX ID (s32)
        /// </summary>
        /// <remarks>
        /// SFX issued before executing the object. If it is -1, it will not be issued.
        /// </remarks>
        public int PreActionSFXID
        {
            get => (int)CellsByName["PreActionSFXID"].Value;
            set => CellsByName["PreActionSFXID"].Value = value;
        }


        // Def="dummy8 pad2[40]"
        /// <summary>
        /// pad2 (dummy8)
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        public object Pad2
        {
            get => (object)CellsByName["Pad2"].Value;
            set => CellsByName["Pad2"].Value = value;
        }

    }
}

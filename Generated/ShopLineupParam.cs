
            namespace StronglyTypedParams
            {
                public class ShopLineupParam : ParamRow
                {
                    public ShopLineupParam() : base()
                    {
                    }
            

            // Def="s32 equipId"
            /// <summary>
            /// Reference ID (s32)
            /// </summary>
            /// <remarks>
            /// ID of the equipment for sale
            /// </remarks>
            public int ReferenceID 
            {
                get => (int)CellsByName["ReferenceID"].Value;
                set => CellsByName["ReferenceID"].Value = value;
            }
            

            // Def="s32 value = -1"
            /// <summary>
            /// Sell Price Overwrite (s32)
            /// </summary>
            /// <remarks>
            /// Selling price to overwrite (-1: Do not overwrite)
            /// </remarks>
            public int SellPriceOverwrite 
            {
                get => (int)CellsByName["SellPriceOverwrite"].Value;
                set => CellsByName["SellPriceOverwrite"].Value = value;
            }
            

            // Def="s32 mtrlId = -1"
            /// <summary>
            /// Required Material ID (s32)
            /// </summary>
            /// <remarks>
            /// Material ID required for purchase (-1: None)
            /// </remarks>
            public int RequiredMaterialID 
            {
                get => (int)CellsByName["RequiredMaterialID"].Value;
                set => CellsByName["RequiredMaterialID"].Value = value;
            }
            

            // Def="u32 eventFlag_forStock"
            /// <summary>
            /// Quantity - Event Flag ID (u32)
            /// </summary>
            /// <remarks>
            /// Event flag value that holds the number
            /// </remarks>
            public uint QuantityEventFlagID 
            {
                get => (uint)CellsByName["QuantityEventFlagID"].Value;
                set => CellsByName["QuantityEventFlagID"].Value = value;
            }
            

            // Def="u32 eventFlag_forRelease"
            /// <summary>
            /// Visibility - Event Flag ID (u32)
            /// </summary>
            /// <remarks>
            /// Sales ban event flag
            /// </remarks>
            public uint VisibilityEventFlagID 
            {
                get => (uint)CellsByName["VisibilityEventFlagID"].Value;
                set => CellsByName["VisibilityEventFlagID"].Value = value;
            }
            

            // Def="s16 sellQuantity = -1"
            /// <summary>
            /// Amount to Sell (s16)
            /// </summary>
            /// <remarks>
            /// Number of units sold
            /// </remarks>
            public short AmountToSell 
            {
                get => (short)CellsByName["AmountToSell"].Value;
                set => CellsByName["AmountToSell"].Value = value;
            }
            

            // Def="dummy8 pad3[1]"
            /// <summary>
            /// Padding (dummy8)
            /// </summary>
            /// <remarks>
            /// 
            /// </remarks>
            public object Padding 
            {
                get => (object)CellsByName["Padding"].Value;
                set => CellsByName["Padding"].Value = value;
            }
            

            // Def="u8 equipType"
            /// <summary>
            /// Equipment Type (u8)
            /// </summary>
            /// <remarks>
            /// Types of equipment for sale
            /// </remarks>
            public byte EquipmentType 
            {
                get => (byte)CellsByName["EquipmentType"].Value;
                set => CellsByName["EquipmentType"].Value = value;
            }
            

            // Def="u8 costType"
            /// <summary>
            /// Currency Type (u8)
            /// </summary>
            /// <remarks>
            /// Price type. Applies only when overwriting the selling price
            /// </remarks>
            public byte CurrencyType 
            {
                get => (byte)CellsByName["CurrencyType"].Value;
                set => CellsByName["CurrencyType"].Value = value;
            }
            


            // Def="u16 setNum = 1"
            /// <summary>
            /// Amount on Purchase (u16)
            /// </summary>
            /// <remarks>
            /// Number of sets sold. Number of pieces you can get with one purchase (default: 1)
            /// </remarks>
            public ushort AmountOnPurchase 
            {
                get => (ushort)CellsByName["AmountOnPurchase"].Value;
                set => CellsByName["AmountOnPurchase"].Value = value;
            }
            

            // Def="s32 value_Add"
            /// <summary>
            /// Price Addition (s32)
            /// </summary>
            /// <remarks>
            /// Correction (addition) to the selling price of equipment. Equipment para selling price x magnification + addition
            /// </remarks>
            public int PriceAddition 
            {
                get => (int)CellsByName["PriceAddition"].Value;
                set => CellsByName["PriceAddition"].Value = value;
            }
            

            // Def="f32 value_Magnification = 1"
            /// <summary>
            /// Price Multiplier (f32)
            /// </summary>
            /// <remarks>
            /// Correction (magnification) to the selling price of equipment. Equipment para selling price x magnification + addition
            /// </remarks>
            public float PriceMultiplier 
            {
                get => (float)CellsByName["PriceMultiplier"].Value;
                set => CellsByName["PriceMultiplier"].Value = value;
            }
            

            // Def="s32 iconId = -1"
            /// <summary>
            /// Icon ID (s32)
            /// </summary>
            /// <remarks>
            /// Menu display_icon ID (-1: do not overwrite)
            /// </remarks>
            public int IconID 
            {
                get => (int)CellsByName["IconID"].Value;
                set => CellsByName["IconID"].Value = value;
            }
            

            // Def="s32 nameMsgId = -1"
            /// <summary>
            /// Name - Text ID (s32)
            /// </summary>
            /// <remarks>
            /// Menu display_text ID (-1: do not overwrite)
            /// </remarks>
            public int NameTextID 
            {
                get => (int)CellsByName["NameTextID"].Value;
                set => CellsByName["NameTextID"].Value = value;
            }
            

            // Def="s32 menuTitleMsgId = -1"
            /// <summary>
            /// Menu Title - Text ID (s32)
            /// </summary>
            /// <remarks>
            /// Text ID of the shop menu title (-1: Do not overwrite). This value of the first para found in the para ID range passed when launching the shop is referenced
            /// </remarks>
            public int MenuTitleTextID 
            {
                get => (int)CellsByName["MenuTitleTextID"].Value;
                set => CellsByName["MenuTitleTextID"].Value = value;
            }
            

            // Def="s16 menuIconId = -1"
            /// <summary>
            /// Menu Icon ID (s16)
            /// </summary>
            /// <remarks>
            /// Shop menu icon ID (-1: Do not overwrite). This value of the first para found in the para ID range passed when launching the shop is referenced
            /// </remarks>
            public short MenuIconID 
            {
                get => (short)CellsByName["MenuIconID"].Value;
                set => CellsByName["MenuIconID"].Value = value;
            }
            

                }
            }
            
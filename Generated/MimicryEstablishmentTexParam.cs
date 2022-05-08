
            namespace StronglyTypedParams
            {
                // MIMICRY_ESTABLISHMENT_TEX_PARAM_ST
                public class MimicryEstablishmentTexParam : ParamRow
                {
                    public MimicryEstablishmentTexParam() : base()
                    {
                    }
            

            // Def="u8 disableParam_NT:1"
            /// <summary>
            /// Disable Param - Network Test (u8)
            /// </summary>
            /// <remarks>
            /// Parameters marked with ○ are excluded in the NT version package.
            /// </remarks>
            public BoolCirclecrossType DisableParamNetworkTest 
            {
                get => (BoolCirclecrossType)CellsByName["DisableParamNetworkTest"].Value;
                set => CellsByName["DisableParamNetworkTest"].Value = (byte)value;
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
                set => CellsByName["ReserveForPackageOutput1"].Value = (object)value;
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
                set => CellsByName["ReserveForPackageOutput2"].Value = (object)value;
            }
            

            // Def="u8 srcR"
            /// <summary>
            /// Pre-conversion - Map Image: R (u8)
            /// </summary>
            /// <remarks>
            /// Color information (R) of the map image before conversion. Pixels with matching RGB values are associated with this parameter
            /// </remarks>
            public byte PreConversionMapImageR 
            {
                get => (byte)CellsByName["PreConversionMapImageR"].Value;
                set => CellsByName["PreConversionMapImageR"].Value = (byte)value;
            }
            

            // Def="u8 srcG"
            /// <summary>
            /// Pre-conversion - Map Image: G (u8)
            /// </summary>
            /// <remarks>
            /// Color information (G) of the map image before conversion. Pixels with matching RGB values are associated with this parameter
            /// </remarks>
            public byte PreConversionMapImageG 
            {
                get => (byte)CellsByName["PreConversionMapImageG"].Value;
                set => CellsByName["PreConversionMapImageG"].Value = (byte)value;
            }
            

            // Def="u8 srcB"
            /// <summary>
            /// Pre-conversion - Map Image: B (u8)
            /// </summary>
            /// <remarks>
            /// Color information (B) of the map image before conversion. Pixels with matching RGB values are associated with this parameter
            /// </remarks>
            public byte PreConversionMapImageB 
            {
                get => (byte)CellsByName["PreConversionMapImageB"].Value;
                set => CellsByName["PreConversionMapImageB"].Value = (byte)value;
            }
            

            // Def="dummy8 pad1[1]"
            /// <summary>
            /// pad (dummy8)
            /// </summary>
            /// <remarks>
            /// pad. For the time being, leave it open for "image color information (A)"
            /// </remarks>
            public object Pad 
            {
                get => (object)CellsByName["Pad"].Value;
                set => CellsByName["Pad"].Value = (object)value;
            }
            

            // Def="s32 mimicryEstablishmentParamId = -1"
            /// <summary>
            /// Mimicry Establishment Param ID (s32)
            /// </summary>
            /// <remarks>
            /// Mimicry probability parameter ID by map (-1: No setting (default value)). The area is combined with Map Studio
            /// </remarks>
            public int MimicryEstablishmentParamID 
            {
                get => (int)CellsByName["MimicryEstablishmentParamID"].Value;
                set => CellsByName["MimicryEstablishmentParamID"].Value = (int)value;
            }
            

            // Def="dummy8 pad2[4]"
            /// <summary>
            /// Pad 2 (dummy8)
            /// </summary>
            /// <remarks>
            /// 
            /// </remarks>
            public object Pad2 
            {
                get => (object)CellsByName["Pad2"].Value;
                set => CellsByName["Pad2"].Value = (object)value;
            }
            
                }
            }
            
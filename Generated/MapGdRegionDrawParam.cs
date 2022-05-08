
            namespace StronglyTypedParams
            {
                // MAP_GD_REGION_DRAW_PARAM
                public class MapGdRegionDrawParam : ParamRow
                {
                    public MapGdRegionDrawParam() : base()
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
            

            // Def="f32 overrideIVLocalLightScale = -1"
            /// <summary>
            /// Override Irradiance Volume Local Light Scale (f32)
            /// </summary>
            /// <remarks>
            /// Local light scale value at the time of IV shooting (0 or less: no overwrite) [GR] SEQ13338 [Irradiance volume] I want to change the indirect scale of the SFX light source uniformly.
            /// </remarks>
            public float OverrideIrradianceVolumeLocalLightScale 
            {
                get => (float)CellsByName["OverrideIrradianceVolumeLocalLightScale"].Value;
                set => CellsByName["OverrideIrradianceVolumeLocalLightScale"].Value = (float)value;
            }
            
                }
            }
            
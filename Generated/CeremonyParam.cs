
            namespace StronglyTypedParams
            {
                public class CeremonyParam : ParamRow
                {
                    public CeremonyParam() : base()
                    {
                    }
            

            // Def="s32 eventLayerId"
            /// <summary>
            /// Event Layer ID (s32)
            /// </summary>
            /// <remarks>
            /// Event maker layer ID
            /// </remarks>
            public int EventLayerID 
            {
                get => (int)CellsByName["EventLayerID"].Value;
                set => CellsByName["EventLayerID"].Value = value;
            }
            

            // Def="s32 mapStudioLayerId"
            /// <summary>
            /// Map Studio Layer ID (s32)
            /// </summary>
            /// <remarks>
            /// Map Studio Layer ID
            /// </remarks>
            public int MapStudioLayerID 
            {
                get => (int)CellsByName["MapStudioLayerID"].Value;
                set => CellsByName["MapStudioLayerID"].Value = value;
            }
            

            // Def="s32 multiPlayAreaOffset"
            /// <summary>
            /// Play Region ID Offset (s32)
            /// </summary>
            /// <remarks>
            /// Multiplayer area ID offset. For example, if you enter "100", the multiplayer area ID will be offset by "100".
            /// </remarks>
            public int PlayRegionIDOffset 
            {
                get => (int)CellsByName["PlayRegionIDOffset"].Value;
                set => CellsByName["PlayRegionIDOffset"].Value = value;
            }
            

            // Def="s32 overrideMapPlaceNameId = -1"
            /// <summary>
            /// Override Map Place Name ID (s32)
            /// </summary>
            /// <remarks>
            /// Override the map name ID_place name display with the specified ID. -1: No overwrite, -2 or less, 0 or more: Overwrite the ID.
            /// </remarks>
            public int OverrideMapPlaceNameID 
            {
                get => (int)CellsByName["OverrideMapPlaceNameID"].Value;
                set => CellsByName["OverrideMapPlaceNameID"].Value = value;
            }
            

            // Def="s32 overrideSaveMapNameId = -1"
            /// <summary>
            /// Override Save Map Name ID (s32)
            /// </summary>
            /// <remarks>
            /// Map name ID_Overwrites the save data display with the specified ID. -1: No overwrite, -2 or less, 0 or more: Overwrite the ID.
            /// </remarks>
            public int OverrideSaveMapNameID 
            {
                get => (int)CellsByName["OverrideSaveMapNameID"].Value;
                set => CellsByName["OverrideSaveMapNameID"].Value = value;
            }
            

            // Def="dummy8 pad2[16]"
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
            
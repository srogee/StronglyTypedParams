
namespace StronglyTypedParams
{
    public class BudgetParam : ParamRow
    {
        public BudgetParam() : base()
        {
        }


        // Def="f32 vram_all = 1"
        /// <summary>
        /// VRAM: ALL (f32)
        /// </summary>
        /// <remarks>
        /// VRAM: ALL (unit is MB)
        /// </remarks>
        public float VRAMALL
        {
            get => (float)CellsByName["VRAMALL"].Value;
            set => CellsByName["VRAMALL"].Value = value;
        }


        // Def="f32 vram_mapobj_tex = 1"
        /// <summary>
        /// VRAM: Map / Object Texture (f32)
        /// </summary>
        /// <remarks>
        /// VRAM: Map / Object Texture (Unit: MB)
        /// </remarks>
        public float VRAMMapObjectTexture
        {
            get => (float)CellsByName["VRAMMapObjectTexture"].Value;
            set => CellsByName["VRAMMapObjectTexture"].Value = value;
        }


        // Def="f32 vram_mapobj_mdl = 1"
        /// <summary>
        /// VRAM: Map / Object Model (f32)
        /// </summary>
        /// <remarks>
        /// VRAM: Map / object model (in MB)
        /// </remarks>
        public float VRAMMapObjectModel
        {
            get => (float)CellsByName["VRAMMapObjectModel"].Value;
            set => CellsByName["VRAMMapObjectModel"].Value = value;
        }


        // Def="f32 vram_map = 1"
        /// <summary>
        /// VRAM: map (f32)
        /// </summary>
        /// <remarks>
        /// VRAM: Map (in MB)
        /// </remarks>
        public float VRAMMap
        {
            get => (float)CellsByName["VRAMMap"].Value;
            set => CellsByName["VRAMMap"].Value = value;
        }


        // Def="f32 vram_chr = 1"
        /// <summary>
        /// VRAM: Character (f32)
        /// </summary>
        /// <remarks>
        /// VRAM: Character (unit is MB)
        /// </remarks>
        public float VRAMCharacter
        {
            get => (float)CellsByName["VRAMCharacter"].Value;
            set => CellsByName["VRAMCharacter"].Value = value;
        }


        // Def="f32 vram_parts = 1"
        /// <summary>
        /// VRAM: Parts (f32)
        /// </summary>
        /// <remarks>
        /// VRAM: Parts (unit is MB)
        /// </remarks>
        public float VRAMParts
        {
            get => (float)CellsByName["VRAMParts"].Value;
            set => CellsByName["VRAMParts"].Value = value;
        }


        // Def="f32 vram_sfx = 1"
        /// <summary>
        /// VRAM: SFX (f32)
        /// </summary>
        /// <remarks>
        /// VRAM: SFX (unit is MB)
        /// </remarks>
        public float VRAMSFX
        {
            get => (float)CellsByName["VRAMSFX"].Value;
            set => CellsByName["VRAMSFX"].Value = value;
        }


        // Def="f32 vram_chr_tex = 1"
        /// <summary>
        /// VRAM: Character texture (f32)
        /// </summary>
        /// <remarks>
        /// VRAM: Character texture (unit is MB)
        /// </remarks>
        public float VRAMCharacterTexture
        {
            get => (float)CellsByName["VRAMCharacterTexture"].Value;
            set => CellsByName["VRAMCharacterTexture"].Value = value;
        }


        // Def="f32 vram_chr_mdl = 1"
        /// <summary>
        /// VRAM: Character model (f32)
        /// </summary>
        /// <remarks>
        /// VRAM: Character model (unit is MB)
        /// </remarks>
        public float VRAMCharacterModel
        {
            get => (float)CellsByName["VRAMCharacterModel"].Value;
            set => CellsByName["VRAMCharacterModel"].Value = value;
        }


        // Def="f32 vram_parts_tex = 1"
        /// <summary>
        /// VRAM: Parts texture (f32)
        /// </summary>
        /// <remarks>
        /// VRAM: Parts texture (unit is MB)
        /// </remarks>
        public float VRAMPartsTexture
        {
            get => (float)CellsByName["VRAMPartsTexture"].Value;
            set => CellsByName["VRAMPartsTexture"].Value = value;
        }


        // Def="f32 vram_parts_mdl = 1"
        /// <summary>
        /// VRAM: Parts model (f32)
        /// </summary>
        /// <remarks>
        /// VRAM: Parts model (unit is MB)
        /// </remarks>
        public float VRAMPartsModel
        {
            get => (float)CellsByName["VRAMPartsModel"].Value;
            set => CellsByName["VRAMPartsModel"].Value = value;
        }


        // Def="f32 vram_sfx_tex = 1"
        /// <summary>
        /// VRAM: SFX texture (f32)
        /// </summary>
        /// <remarks>
        /// VRAM: SFX texture (unit is MB)
        /// </remarks>
        public float VRAMSFXTexture
        {
            get => (float)CellsByName["VRAMSFXTexture"].Value;
            set => CellsByName["VRAMSFXTexture"].Value = value;
        }


        // Def="f32 vram_sfx_mdl = 1"
        /// <summary>
        /// VRAM: SFX model (f32)
        /// </summary>
        /// <remarks>
        /// VRAM: SFX model (in MB)
        /// </remarks>
        public float VRAMSFXModel
        {
            get => (float)CellsByName["VRAMSFXModel"].Value;
            set => CellsByName["VRAMSFXModel"].Value = value;
        }


        // Def="f32 vram_gi = 1"
        /// <summary>
        /// VRAM: Gi (f32)
        /// </summary>
        /// <remarks>
        /// VRAM: Gi (unit is MB)
        /// </remarks>
        public float VRAMGi
        {
            get => (float)CellsByName["VRAMGi"].Value;
            set => CellsByName["VRAMGi"].Value = value;
        }


        // Def="f32 vram_menu_tex = 1"
        /// <summary>
        /// VRAM: Menu (f32)
        /// </summary>
        /// <remarks>
        /// VRAM: Menu (unit is MB)
        /// </remarks>
        public float VRAMMenu
        {
            get => (float)CellsByName["VRAMMenu"].Value;
            set => CellsByName["VRAMMenu"].Value = value;
        }


        // Def="f32 vram_decal_rt = 1"
        /// <summary>
        /// VRAM: DECAL_RT (f32)
        /// </summary>
        /// <remarks>
        /// VRAM: DECAL render target (unit is MB)
        /// </remarks>
        public float VRAMDECAL_RT
        {
            get => (float)CellsByName["VRAMDECAL_RT"].Value;
            set => CellsByName["VRAMDECAL_RT"].Value = value;
        }


        // Def="f32 vram_decal = 1"
        /// <summary>
        /// VRAM: DECAL (f32)
        /// </summary>
        /// <remarks>
        /// VRAM: DECAL (unit is MB)
        /// </remarks>
        public float VRAMDECAL
        {
            get => (float)CellsByName["VRAMDECAL"].Value;
            set => CellsByName["VRAMDECAL"].Value = value;
        }


        // Def="dummy8 reserve_0[4]"
        /// <summary>
        /// Reserved area (dummy8)
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        public object ReservedArea
        {
            get => (object)CellsByName["ReservedArea"].Value;
            set => CellsByName["ReservedArea"].Value = value;
        }


        // Def="f32 vram_other_tex = 1"
        /// <summary>
        /// VRAM: Other textures (f32)
        /// </summary>
        /// <remarks>
        /// VRAM: Other models (in MB)
        /// </remarks>
        public float VRAMOtherTextures
        {
            get => (float)CellsByName["VRAMOtherTextures"].Value;
            set => CellsByName["VRAMOtherTextures"].Value = value;
        }


        // Def="f32 vram_other_mdl = 1"
        /// <summary>
        /// VRAM: Other models (f32)
        /// </summary>
        /// <remarks>
        /// VRAM: Other textures (in MB)
        /// </remarks>
        public float VRAMOtherModels
        {
            get => (float)CellsByName["VRAMOtherModels"].Value;
            set => CellsByName["VRAMOtherModels"].Value = value;
        }


        // Def="f32 havok_anim = 1"
        /// <summary>
        /// HAVOK: Anime (f32)
        /// </summary>
        /// <remarks>
        /// HAVOK: Animation (unit is MB)
        /// </remarks>
        public float HAVOKAnime
        {
            get => (float)CellsByName["HAVOKAnime"].Value;
            set => CellsByName["HAVOKAnime"].Value = value;
        }


        // Def="f32 havok_ins = 1"
        /// <summary>
        /// HAVOK: Placement (f32)
        /// </summary>
        /// <remarks>
        /// HAVOK: Placement (unit is MB)
        /// </remarks>
        public float HAVOKPlacement
        {
            get => (float)CellsByName["HAVOKPlacement"].Value;
            set => CellsByName["HAVOKPlacement"].Value = value;
        }


        // Def="f32 havok_hit = 1"
        /// <summary>
        /// HAVOK: Hit (f32)
        /// </summary>
        /// <remarks>
        /// HAVOK: Hit (unit is MB)
        /// </remarks>
        public float HAVOKHit
        {
            get => (float)CellsByName["HAVOKHit"].Value;
            set => CellsByName["HAVOKHit"].Value = value;
        }


        // Def="f32 vram_other = 1"
        /// <summary>
        /// VRAM: Other (f32)
        /// </summary>
        /// <remarks>
        /// VRAM: Other (unit is MB)
        /// </remarks>
        public float VRAMOther
        {
            get => (float)CellsByName["VRAMOther"].Value;
            set => CellsByName["VRAMOther"].Value = value;
        }


        // Def="f32 vram_detail_all = 1"
        /// <summary>
        /// VRAM: Total Value (f32)
        /// </summary>
        /// <remarks>
        /// VRAM: Total value (unit is MB)
        /// </remarks>
        public float VRAMTotalValue
        {
            get => (float)CellsByName["VRAMTotalValue"].Value;
            set => CellsByName["VRAMTotalValue"].Value = value;
        }


        // Def="f32 vram_chr_and_parts = 1"
        /// <summary>
        /// VRAM: Characters and Parts (f32)
        /// </summary>
        /// <remarks>
        /// VRAM: Total value of characters and parts (unit is MB)
        /// </remarks>
        public float VRAMCharactersAndParts
        {
            get => (float)CellsByName["VRAMCharactersAndParts"].Value;
            set => CellsByName["VRAMCharactersAndParts"].Value = value;
        }


        // Def="f32 havok_navimesh = 1"
        /// <summary>
        /// HAVOK: Navimesh (f32)
        /// </summary>
        /// <remarks>
        /// HAVOK: Navimesh (unit is MB)
        /// </remarks>
        public float HAVOKNavimesh
        {
            get => (float)CellsByName["HAVOKNavimesh"].Value;
            set => CellsByName["HAVOKNavimesh"].Value = value;
        }


    }
}

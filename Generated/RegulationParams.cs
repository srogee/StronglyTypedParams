
using SoulsFormats;
using System;
using System.Collections.Generic;
using System.IO;

namespace StronglyTypedParams
{
    public class RegulationParams
    {
        private BND4 Data;
        private Dictionary<string, object> ParamsByName;

        public RegulationParams(BND4 data)
        {
            Data = data;
            ParamsByName = new Dictionary<string, object>();
        }

        private ParamCollection<T> GetOrLoadParam<T>(string paramName) where T : ParamRow, new()
        {
            if (!ParamsByName.ContainsKey(paramName))
            {
                LoadParam<T>(paramName);
            }

            return (ParamCollection<T>)ParamsByName[paramName];
        }

        private void LoadParam<T>(string paramName) where T : ParamRow, new()
        {
            Console.WriteLine("Loading param " + paramName);
            BinderFile paramFile = Data.Files.Find(file => Path.GetFileNameWithoutExtension(file.Name) == paramName);
            if (paramFile == null)
            {
                Console.WriteLine("Error when loading param " + paramName);
                ParamsByName.Add(paramName, null);
                return;
            }
            var paramCollection = new ParamCollection<T>(PARAM.Read(paramFile.Bytes), paramName);
            ParamsByName.Add(paramName, paramCollection);
        }

        public ParamCollection<ActionButtonParam> ActionButtonParam => GetOrLoadParam<ActionButtonParam>("ActionButtonParam");
        public ParamCollection<AiAnimTblParam> AiAnimTblParam => GetOrLoadParam<AiAnimTblParam>("AiAnimTblParam");
        public ParamCollection<AIAttackParam> AIAttackParam => GetOrLoadParam<AIAttackParam>("AIAttackParam");
        public ParamCollection<AiOddsParam> AiOddsParam => GetOrLoadParam<AiOddsParam>("AiOddsParam");
        public ParamCollection<AiSoundParam> AiSoundParam => GetOrLoadParam<AiSoundParam>("AiSoundParam");
        public ParamCollection<AiStandardInfo> AiStandardInfo => GetOrLoadParam<AiStandardInfo>("AiStandardInfo");
        public ParamCollection<AssetGeometryParam> AssetGeometryParam => GetOrLoadParam<AssetGeometryParam>("AssetGeometryParam");
        public ParamCollection<AssetMaterialSfxParam> AssetMaterialSfxParam => GetOrLoadParam<AssetMaterialSfxParam>("AssetMaterialSfxParam");
        public ParamCollection<AssetModelSfxParam> AssetModelSfxParam => GetOrLoadParam<AssetModelSfxParam>("AssetModelSfxParam");
        public ParamCollection<AtkParam> AtkParam => GetOrLoadParam<AtkParam>("AtkParam");
        public ParamCollection<AttackElementCorrectParam> AttackElementCorrectParam => GetOrLoadParam<AttackElementCorrectParam>("AttackElementCorrectParam");
        public ParamCollection<AutoCreateEnvSoundParam> AutoCreateEnvSoundParam => GetOrLoadParam<AutoCreateEnvSoundParam>("AutoCreateEnvSoundParam");
        public ParamCollection<BaseChrSelectMenuParam> BaseChrSelectMenuParam => GetOrLoadParam<BaseChrSelectMenuParam>("BaseChrSelectMenuParam");
        public ParamCollection<BehaviorParam> BehaviorParam => GetOrLoadParam<BehaviorParam>("BehaviorParam");
        public ParamCollection<BonfireWarpParam> BonfireWarpParam => GetOrLoadParam<BonfireWarpParam>("BonfireWarpParam");
        public ParamCollection<BonfireWarpSubCategoryParam> BonfireWarpSubCategoryParam => GetOrLoadParam<BonfireWarpSubCategoryParam>("BonfireWarpSubCategoryParam");
        public ParamCollection<BonfireWarpTabParam> BonfireWarpTabParam => GetOrLoadParam<BonfireWarpTabParam>("BonfireWarpTabParam");
        public ParamCollection<BuddyParam> BuddyParam => GetOrLoadParam<BuddyParam>("BuddyParam");
        public ParamCollection<BuddyStoneParam> BuddyStoneParam => GetOrLoadParam<BuddyStoneParam>("BuddyStoneParam");
        public ParamCollection<BudgetParam> BudgetParam => GetOrLoadParam<BudgetParam>("BudgetParam");
        public ParamCollection<BulletCreateLimitParam> BulletCreateLimitParam => GetOrLoadParam<BulletCreateLimitParam>("BulletCreateLimitParam");
        public ParamCollection<BulletParam> BulletParam => GetOrLoadParam<BulletParam>("BulletParam");
        public ParamCollection<CalcCorrectGraph> CalcCorrectGraph => GetOrLoadParam<CalcCorrectGraph>("CalcCorrectGraph");
        public ParamCollection<CameraFadeParam> CameraFadeParam => GetOrLoadParam<CameraFadeParam>("CameraFadeParam");
        public ParamCollection<CeremonyParam> CeremonyParam => GetOrLoadParam<CeremonyParam>("CeremonyParam");
        public ParamCollection<CharaInitParam> CharaInitParam => GetOrLoadParam<CharaInitParam>("CharaInitParam");
        public ParamCollection<CharMakeMenuListItemParam> CharMakeMenuListItemParam => GetOrLoadParam<CharMakeMenuListItemParam>("CharMakeMenuListItemParam");
        public ParamCollection<CharMakeMenuTopParam> CharMakeMenuTopParam => GetOrLoadParam<CharMakeMenuTopParam>("CharMakeMenuTopParam");
        public ParamCollection<ChrActivateConditionParam> ChrActivateConditionParam => GetOrLoadParam<ChrActivateConditionParam>("ChrActivateConditionParam");
        public ParamCollection<ChrModelParam> ChrModelParam => GetOrLoadParam<ChrModelParam>("ChrModelParam");
        public ParamCollection<ClearCountCorrectParam> ClearCountCorrectParam => GetOrLoadParam<ClearCountCorrectParam>("ClearCountCorrectParam");
        public ParamCollection<CommonSystemParam> CommonSystemParam => GetOrLoadParam<CommonSystemParam>("CommonSystemParam");
        public ParamCollection<CoolTimeParam> CoolTimeParam => GetOrLoadParam<CoolTimeParam>("CoolTimeParam");
        public ParamCollection<CutsceneGparamTimeParam> CutsceneGparamTimeParam => GetOrLoadParam<CutsceneGparamTimeParam>("CutsceneGparamTimeParam");
        public ParamCollection<CutsceneGparamWeatherParam> CutsceneGparamWeatherParam => GetOrLoadParam<CutsceneGparamWeatherParam>("CutsceneGparamWeatherParam");
        public ParamCollection<CutsceneMapIdParam> CutsceneMapIdParam => GetOrLoadParam<CutsceneMapIdParam>("CutsceneMapIdParam");
        public ParamCollection<CutSceneTextureLoadParam> CutSceneTextureLoadParam => GetOrLoadParam<CutSceneTextureLoadParam>("CutSceneTextureLoadParam");
        public ParamCollection<CutsceneTimezoneConvertParam> CutsceneTimezoneConvertParam => GetOrLoadParam<CutsceneTimezoneConvertParam>("CutsceneTimezoneConvertParam");
        public ParamCollection<CutsceneWeatherOverrideGparamIdConvertParam> CutsceneWeatherOverrideGparamIdConvertParam => GetOrLoadParam<CutsceneWeatherOverrideGparamIdConvertParam>("CutsceneWeatherOverrideGparamIdConvertParam");
        public ParamCollection<DecalParam> DecalParam => GetOrLoadParam<DecalParam>("DecalParam");
        public ParamCollection<DefaultKeyAssign> DefaultKeyAssign => GetOrLoadParam<DefaultKeyAssign>("DefaultKeyAssign");
        public ParamCollection<DirectionCameraParam> DirectionCameraParam => GetOrLoadParam<DirectionCameraParam>("DirectionCameraParam");
        public ParamCollection<EnemyCommonParam> EnemyCommonParam => GetOrLoadParam<EnemyCommonParam>("EnemyCommonParam");
        public ParamCollection<EnemyStandardInfo> EnemyStandardInfo => GetOrLoadParam<EnemyStandardInfo>("EnemyStandardInfo");
        public ParamCollection<EnvObjLotParam> EnvObjLotParam => GetOrLoadParam<EnvObjLotParam>("EnvObjLotParam");
        public ParamCollection<EquipMtrlSetParam> EquipMtrlSetParam => GetOrLoadParam<EquipMtrlSetParam>("EquipMtrlSetParam");
        public ParamCollection<EquipParamAccessory> EquipParamAccessory => GetOrLoadParam<EquipParamAccessory>("EquipParamAccessory");
        public ParamCollection<EquipParamCustomWeapon> EquipParamCustomWeapon => GetOrLoadParam<EquipParamCustomWeapon>("EquipParamCustomWeapon");
        public ParamCollection<EquipParamGem> EquipParamGem => GetOrLoadParam<EquipParamGem>("EquipParamGem");
        public ParamCollection<EquipParamGoods> EquipParamGoods => GetOrLoadParam<EquipParamGoods>("EquipParamGoods");
        public ParamCollection<EquipParamProtector> EquipParamProtector => GetOrLoadParam<EquipParamProtector>("EquipParamProtector");
        public ParamCollection<EquipParamWeapon> EquipParamWeapon => GetOrLoadParam<EquipParamWeapon>("EquipParamWeapon");
        public ParamCollection<EstusFlaskRecoveryParam> EstusFlaskRecoveryParam => GetOrLoadParam<EstusFlaskRecoveryParam>("EstusFlaskRecoveryParam");
        public ParamCollection<EventFlagUsageParam> EventFlagUsageParam => GetOrLoadParam<EventFlagUsageParam>("EventFlagUsageParam");
        public ParamCollection<FaceParam> FaceParam => GetOrLoadParam<FaceParam>("FaceParam");
        public ParamCollection<FaceRangeParam> FaceRangeParam => GetOrLoadParam<FaceRangeParam>("FaceRangeParam");
        public ParamCollection<FeTextEffectParam> FeTextEffectParam => GetOrLoadParam<FeTextEffectParam>("FeTextEffectParam");
        public ParamCollection<FootSfxParam> FootSfxParam => GetOrLoadParam<FootSfxParam>("FootSfxParam");
        public ParamCollection<GameAreaParam> GameAreaParam => GetOrLoadParam<GameAreaParam>("GameAreaParam");
        public ParamCollection<GameInfoParam> GameInfoParam => GetOrLoadParam<GameInfoParam>("GameInfoParam");
        public ParamCollection<GameSystemCommonParam> GameSystemCommonParam => GetOrLoadParam<GameSystemCommonParam>("GameSystemCommonParam");
        public ParamCollection<Gconfig_AAQuality> Gconfig_AAQuality => GetOrLoadParam<Gconfig_AAQuality>("Gconfig_AAQuality");
        public ParamCollection<Gconfig_DecalQuality> Gconfig_DecalQuality => GetOrLoadParam<Gconfig_DecalQuality>("Gconfig_DecalQuality");
        public ParamCollection<Gconfig_DOFQuality> Gconfig_DOFQuality => GetOrLoadParam<Gconfig_DOFQuality>("Gconfig_DOFQuality");
        public ParamCollection<Gconfig_EffectQuality> Gconfig_EffectQuality => GetOrLoadParam<Gconfig_EffectQuality>("Gconfig_EffectQuality");
        public ParamCollection<Gconfig_LightingQuality> Gconfig_LightingQuality => GetOrLoadParam<Gconfig_LightingQuality>("Gconfig_LightingQuality");
        public ParamCollection<Gconfig_MotionBlurQuality> Gconfig_MotionBlurQuality => GetOrLoadParam<Gconfig_MotionBlurQuality>("Gconfig_MotionBlurQuality");
        public ParamCollection<Gconfig_ReflectionQuality> Gconfig_ReflectionQuality => GetOrLoadParam<Gconfig_ReflectionQuality>("Gconfig_ReflectionQuality");
        public ParamCollection<Gconfig_ShaderQuality> Gconfig_ShaderQuality => GetOrLoadParam<Gconfig_ShaderQuality>("Gconfig_ShaderQuality");
        public ParamCollection<Gconfig_ShadowQuality> Gconfig_ShadowQuality => GetOrLoadParam<Gconfig_ShadowQuality>("Gconfig_ShadowQuality");
        public ParamCollection<Gconfig_SSAOQuality> Gconfig_SSAOQuality => GetOrLoadParam<Gconfig_SSAOQuality>("Gconfig_SSAOQuality");
        public ParamCollection<Gconfig_TextureFilterQuality> Gconfig_TextureFilterQuality => GetOrLoadParam<Gconfig_TextureFilterQuality>("Gconfig_TextureFilterQuality");
        public ParamCollection<Gconfig_VolumetricEffectQuality> Gconfig_VolumetricEffectQuality => GetOrLoadParam<Gconfig_VolumetricEffectQuality>("Gconfig_VolumetricEffectQuality");
        public ParamCollection<Gconfig_WaterQuality> Gconfig_WaterQuality => GetOrLoadParam<Gconfig_WaterQuality>("Gconfig_WaterQuality");
        public ParamCollection<GestureParam> GestureParam => GetOrLoadParam<GestureParam>("GestureParam");
        public ParamCollection<GparamGridRegionInfo> GparamGridRegionInfo => GetOrLoadParam<GparamGridRegionInfo>("GparamGridRegionInfo");
        public ParamCollection<GparamRefSettingsParam> GparamRefSettingsParam => GetOrLoadParam<GparamRefSettingsParam>("GparamRefSettingsParam");
        public ParamCollection<GraphicsCommonParam> GraphicsCommonParam => GetOrLoadParam<GraphicsCommonParam>("GraphicsCommonParam");
        public ParamCollection<GraphicsConfig> GraphicsConfig => GetOrLoadParam<GraphicsConfig>("GraphicsConfig");
        public ParamCollection<GrassLodRangeParam> GrassLodRangeParam => GetOrLoadParam<GrassLodRangeParam>("GrassLodRangeParam");
        public ParamCollection<GrassMapSettings> GrassMapSettings => GetOrLoadParam<GrassMapSettings>("GrassMapSettings");
        public ParamCollection<GrassTypeParam> GrassTypeParam => GetOrLoadParam<GrassTypeParam>("GrassTypeParam");
        public ParamCollection<HitEffectSeParam> HitEffectSeParam => GetOrLoadParam<HitEffectSeParam>("HitEffectSeParam");
        public ParamCollection<HitEffectSfxConceptParam> HitEffectSfxConceptParam => GetOrLoadParam<HitEffectSfxConceptParam>("HitEffectSfxConceptParam");
        public ParamCollection<HitEffectSfxParam> HitEffectSfxParam => GetOrLoadParam<HitEffectSfxParam>("HitEffectSfxParam");
        public ParamCollection<HitMtrlParam> HitMtrlParam => GetOrLoadParam<HitMtrlParam>("HitMtrlParam");
        public ParamCollection<ItemLotParam> ItemLotParam => GetOrLoadParam<ItemLotParam>("ItemLotParam");
        public ParamCollection<KeyAssignMenuItemParam> KeyAssignMenuItemParam => GetOrLoadParam<KeyAssignMenuItemParam>("KeyAssignMenuItemParam");
        public ParamCollection<KeyAssignParam> KeyAssignParam => GetOrLoadParam<KeyAssignParam>("KeyAssignParam");
        public ParamCollection<KnockBackParam> KnockBackParam => GetOrLoadParam<KnockBackParam>("KnockBackParam");
        public ParamCollection<KnowledgeLoadScreenItemParam> KnowledgeLoadScreenItemParam => GetOrLoadParam<KnowledgeLoadScreenItemParam>("KnowledgeLoadScreenItemParam");
        public ParamCollection<LegacyDistantViewPartsReplaceParam> LegacyDistantViewPartsReplaceParam => GetOrLoadParam<LegacyDistantViewPartsReplaceParam>("LegacyDistantViewPartsReplaceParam");
        public ParamCollection<LoadBalancerDrawDistScaleParam> LoadBalancerDrawDistScaleParam => GetOrLoadParam<LoadBalancerDrawDistScaleParam>("LoadBalancerDrawDistScaleParam");
        public ParamCollection<LoadBalancerNewDrawDistScaleParam> LoadBalancerNewDrawDistScaleParam => GetOrLoadParam<LoadBalancerNewDrawDistScaleParam>("LoadBalancerNewDrawDistScaleParam");
        public ParamCollection<LoadBalancerParam> LoadBalancerParam => GetOrLoadParam<LoadBalancerParam>("LoadBalancerParam");
        public ParamCollection<LockCamParam> LockCamParam => GetOrLoadParam<LockCamParam>("LockCamParam");
        public ParamCollection<MagicParam> MagicParam => GetOrLoadParam<MagicParam>("MagicParam");
        public ParamCollection<MapDefaultInfoParam> MapDefaultInfoParam => GetOrLoadParam<MapDefaultInfoParam>("MapDefaultInfoParam");
        public ParamCollection<MapGdRegionDrawParam> MapGdRegionDrawParam => GetOrLoadParam<MapGdRegionDrawParam>("MapGdRegionDrawParam");
        public ParamCollection<MapGdRegionInfo> MapGdRegionInfo => GetOrLoadParam<MapGdRegionInfo>("MapGdRegionInfo");
        public ParamCollection<MapGridCreateHeightLimitInfo> MapGridCreateHeightLimitInfo => GetOrLoadParam<MapGridCreateHeightLimitInfo>("MapGridCreateHeightLimitInfo");
        public ParamCollection<MapMimicryEstablishmentParam> MapMimicryEstablishmentParam => GetOrLoadParam<MapMimicryEstablishmentParam>("MapMimicryEstablishmentParam");
        public ParamCollection<MapNameTexParam> MapNameTexParam => GetOrLoadParam<MapNameTexParam>("MapNameTexParam");
        public ParamCollection<MapPieceTexParam> MapPieceTexParam => GetOrLoadParam<MapPieceTexParam>("MapPieceTexParam");
        public ParamCollection<MaterialEx> MaterialEx => GetOrLoadParam<MaterialEx>("MaterialEx");
        public ParamCollection<MenuCommonParam> MenuCommonParam => GetOrLoadParam<MenuCommonParam>("MenuCommonParam");
        public ParamCollection<MenuOffscrRendParam> MenuOffscrRendParam => GetOrLoadParam<MenuOffscrRendParam>("MenuOffscrRendParam");
        public ParamCollection<MenuParamColorTable> MenuParamColorTable => GetOrLoadParam<MenuParamColorTable>("MenuParamColorTable");
        public ParamCollection<MenuPropertyLayoutParam> MenuPropertyLayoutParam => GetOrLoadParam<MenuPropertyLayoutParam>("MenuPropertyLayoutParam");
        public ParamCollection<MenuPropertySpecParam> MenuPropertySpecParam => GetOrLoadParam<MenuPropertySpecParam>("MenuPropertySpecParam");
        public ParamCollection<MenuValueTableSpecParam> MenuValueTableSpecParam => GetOrLoadParam<MenuValueTableSpecParam>("MenuValueTableSpecParam");
        public ParamCollection<MimicryEstablishmentTexParam> MimicryEstablishmentTexParam => GetOrLoadParam<MimicryEstablishmentTexParam>("MimicryEstablishmentTexParam");
        public ParamCollection<MissileParam> MissileParam => GetOrLoadParam<MissileParam>("MissileParam");
        public ParamCollection<ModelSfxParam> ModelSfxParam => GetOrLoadParam<ModelSfxParam>("ModelSfxParam");
        public ParamCollection<MoveParam> MoveParam => GetOrLoadParam<MoveParam>("MoveParam");
        public ParamCollection<MultiEstusFlaskBonusParam> MultiEstusFlaskBonusParam => GetOrLoadParam<MultiEstusFlaskBonusParam>("MultiEstusFlaskBonusParam");
        public ParamCollection<MultiPlayCorrectionParam> MultiPlayCorrectionParam => GetOrLoadParam<MultiPlayCorrectionParam>("MultiPlayCorrectionParam");
        public ParamCollection<MultiSoulBonusRateParam> MultiSoulBonusRateParam => GetOrLoadParam<MultiSoulBonusRateParam>("MultiSoulBonusRateParam");
        public ParamCollection<NetworkAreaParam> NetworkAreaParam => GetOrLoadParam<NetworkAreaParam>("NetworkAreaParam");
        public ParamCollection<NetworkMsgParam> NetworkMsgParam => GetOrLoadParam<NetworkMsgParam>("NetworkMsgParam");
        public ParamCollection<NetworkParam> NetworkParam => GetOrLoadParam<NetworkParam>("NetworkParam");
        public ParamCollection<NpcAiActionParam> NpcAiActionParam => GetOrLoadParam<NpcAiActionParam>("NpcAiActionParam");
        public ParamCollection<NpcAiBehaviorProbabilityParam> NpcAiBehaviorProbabilityParam => GetOrLoadParam<NpcAiBehaviorProbabilityParam>("NpcAiBehaviorProbabilityParam");
        public ParamCollection<NpcParam> NpcParam => GetOrLoadParam<NpcParam>("NpcParam");
        public ParamCollection<NpcThinkParam> NpcThinkParam => GetOrLoadParam<NpcThinkParam>("NpcThinkParam");
        public ParamCollection<ObjActParam> ObjActParam => GetOrLoadParam<ObjActParam>("ObjActParam");
        public ParamCollection<ObjectMaterialSfxParam> ObjectMaterialSfxParam => GetOrLoadParam<ObjectMaterialSfxParam>("ObjectMaterialSfxParam");
        public ParamCollection<ObjectParam> ObjectParam => GetOrLoadParam<ObjectParam>("ObjectParam");
        public ParamCollection<PartsDrawParam> PartsDrawParam => GetOrLoadParam<PartsDrawParam>("PartsDrawParam");
        public ParamCollection<PerformanceCheckParam> PerformanceCheckParam => GetOrLoadParam<PerformanceCheckParam>("PerformanceCheckParam");
        public ParamCollection<PhantomParam> PhantomParam => GetOrLoadParam<PhantomParam>("PhantomParam");
        public ParamCollection<PlayerCommonParam> PlayerCommonParam => GetOrLoadParam<PlayerCommonParam>("PlayerCommonParam");
        public ParamCollection<PlayRegionParam> PlayRegionParam => GetOrLoadParam<PlayRegionParam>("PlayRegionParam");
        public ParamCollection<PostureControlParam_Gender> PostureControlParam_Gender => GetOrLoadParam<PostureControlParam_Gender>("PostureControlParam_Gender");
        public ParamCollection<PostureControlParam_Pro> PostureControlParam_Pro => GetOrLoadParam<PostureControlParam_Pro>("PostureControlParam_Pro");
        public ParamCollection<PostureControlParam_WepLeft> PostureControlParam_WepLeft => GetOrLoadParam<PostureControlParam_WepLeft>("PostureControlParam_WepLeft");
        public ParamCollection<PostureControlParam_WepRight> PostureControlParam_WepRight => GetOrLoadParam<PostureControlParam_WepRight>("PostureControlParam_WepRight");
        public ParamCollection<RandomAppearEditParam> RandomAppearEditParam => GetOrLoadParam<RandomAppearEditParam>("RandomAppearEditParam");
        public ParamCollection<RandomAppearParam> RandomAppearParam => GetOrLoadParam<RandomAppearParam>("RandomAppearParam");
        public ParamCollection<ReinforceParamProtector> ReinforceParamProtector => GetOrLoadParam<ReinforceParamProtector>("ReinforceParamProtector");
        public ParamCollection<ReinforceParamWeapon> ReinforceParamWeapon => GetOrLoadParam<ReinforceParamWeapon>("ReinforceParamWeapon");
        public ParamCollection<ResistCorrectParam> ResistCorrectParam => GetOrLoadParam<ResistCorrectParam>("ResistCorrectParam");
        public ParamCollection<ReverbAuxSendBusParam> ReverbAuxSendBusParam => GetOrLoadParam<ReverbAuxSendBusParam>("ReverbAuxSendBusParam");
        public ParamCollection<RideParam> RideParam => GetOrLoadParam<RideParam>("RideParam");
        public ParamCollection<RoleParam> RoleParam => GetOrLoadParam<RoleParam>("RoleParam");
        public ParamCollection<RollingObjLotParam> RollingObjLotParam => GetOrLoadParam<RollingObjLotParam>("RollingObjLotParam");
        public ParamCollection<RuntimeBoneControlParam> RuntimeBoneControlParam => GetOrLoadParam<RuntimeBoneControlParam>("RuntimeBoneControlParam");
        public ParamCollection<SeActivationRangeParam> SeActivationRangeParam => GetOrLoadParam<SeActivationRangeParam>("SeActivationRangeParam");
        public ParamCollection<SeMaterialConvertParam> SeMaterialConvertParam => GetOrLoadParam<SeMaterialConvertParam>("SeMaterialConvertParam");
        public ParamCollection<SfxBlockResShareParam> SfxBlockResShareParam => GetOrLoadParam<SfxBlockResShareParam>("SfxBlockResShareParam");
        public ParamCollection<ShopLineupParam> ShopLineupParam => GetOrLoadParam<ShopLineupParam>("ShopLineupParam");
        public ParamCollection<SignPuddleParam> SignPuddleParam => GetOrLoadParam<SignPuddleParam>("SignPuddleParam");
        public ParamCollection<SoundAssetSoundObjEnableDistParam> SoundAssetSoundObjEnableDistParam => GetOrLoadParam<SoundAssetSoundObjEnableDistParam>("SoundAssetSoundObjEnableDistParam");
        public ParamCollection<SoundAutoEnvSoundGroupParam> SoundAutoEnvSoundGroupParam => GetOrLoadParam<SoundAutoEnvSoundGroupParam>("SoundAutoEnvSoundGroupParam");
        public ParamCollection<SoundAutoReverbEvaluationDistParam> SoundAutoReverbEvaluationDistParam => GetOrLoadParam<SoundAutoReverbEvaluationDistParam>("SoundAutoReverbEvaluationDistParam");
        public ParamCollection<SoundAutoReverbSelectParam> SoundAutoReverbSelectParam => GetOrLoadParam<SoundAutoReverbSelectParam>("SoundAutoReverbSelectParam");
        public ParamCollection<SoundChrPhysicsSeParam> SoundChrPhysicsSeParam => GetOrLoadParam<SoundChrPhysicsSeParam>("SoundChrPhysicsSeParam");
        public ParamCollection<SoundCommonIngameParam> SoundCommonIngameParam => GetOrLoadParam<SoundCommonIngameParam>("SoundCommonIngameParam");
        public ParamCollection<SoundCommonSystemParam> SoundCommonSystemParam => GetOrLoadParam<SoundCommonSystemParam>("SoundCommonSystemParam");
        public ParamCollection<SoundCutsceneParam> SoundCutsceneParam => GetOrLoadParam<SoundCutsceneParam>("SoundCutsceneParam");
        public ParamCollection<SpeedtreeModel> SpeedtreeModel => GetOrLoadParam<SpeedtreeModel>("SpeedtreeModel");
        public ParamCollection<SpEffect> SpEffect => GetOrLoadParam<SpEffect>("SpEffect");
        public ParamCollection<SpEffectSetParam> SpEffectSetParam => GetOrLoadParam<SpEffectSetParam>("SpEffectSetParam");
        public ParamCollection<SpEffectVfx> SpEffectVfx => GetOrLoadParam<SpEffectVfx>("SpEffectVfx");
        public ParamCollection<SwordArtsParam> SwordArtsParam => GetOrLoadParam<SwordArtsParam>("SwordArtsParam");
        public ParamCollection<TalkParam> TalkParam => GetOrLoadParam<TalkParam>("TalkParam");
        public ParamCollection<ThrowDirectionSfxParam> ThrowDirectionSfxParam => GetOrLoadParam<ThrowDirectionSfxParam>("ThrowDirectionSfxParam");
        public ParamCollection<ThrowParam> ThrowParam => GetOrLoadParam<ThrowParam>("ThrowParam");
        public ParamCollection<ToughnessParam> ToughnessParam => GetOrLoadParam<ToughnessParam>("ToughnessParam");
        public ParamCollection<TutorialParam> TutorialParam => GetOrLoadParam<TutorialParam>("TutorialParam");
        public ParamCollection<WaypointParam> WaypointParam => GetOrLoadParam<WaypointParam>("WaypointParam");
        public ParamCollection<WeatherAssetCreateParam> WeatherAssetCreateParam => GetOrLoadParam<WeatherAssetCreateParam>("WeatherAssetCreateParam");
        public ParamCollection<WeatherAssetReplaceParam> WeatherAssetReplaceParam => GetOrLoadParam<WeatherAssetReplaceParam>("WeatherAssetReplaceParam");
        public ParamCollection<WeatherLotParam> WeatherLotParam => GetOrLoadParam<WeatherLotParam>("WeatherLotParam");
        public ParamCollection<WeatherLotTexParam> WeatherLotTexParam => GetOrLoadParam<WeatherLotTexParam>("WeatherLotTexParam");
        public ParamCollection<WeatherParam> WeatherParam => GetOrLoadParam<WeatherParam>("WeatherParam");
        public ParamCollection<WepAbsorpPosParam> WepAbsorpPosParam => GetOrLoadParam<WepAbsorpPosParam>("WepAbsorpPosParam");
        public ParamCollection<WetAspectParam> WetAspectParam => GetOrLoadParam<WetAspectParam>("WetAspectParam");
        public ParamCollection<WhiteSignCoolTimeParam> WhiteSignCoolTimeParam => GetOrLoadParam<WhiteSignCoolTimeParam>("WhiteSignCoolTimeParam");
        public ParamCollection<WorldMapLegacyConvParam> WorldMapLegacyConvParam => GetOrLoadParam<WorldMapLegacyConvParam>("WorldMapLegacyConvParam");
        public ParamCollection<WorldMapPieceParam> WorldMapPieceParam => GetOrLoadParam<WorldMapPieceParam>("WorldMapPieceParam");
        public ParamCollection<WorldMapPlaceNameParam> WorldMapPlaceNameParam => GetOrLoadParam<WorldMapPlaceNameParam>("WorldMapPlaceNameParam");
        public ParamCollection<WorldMapPointParam> WorldMapPointParam => GetOrLoadParam<WorldMapPointParam>("WorldMapPointParam");
        public ParamCollection<WwiseValueToStrConvertParamFormat> WwiseValueToStrConvertParamFormat => GetOrLoadParam<WwiseValueToStrConvertParamFormat>("WwiseValueToStrConvertParamFormat");
    }
}

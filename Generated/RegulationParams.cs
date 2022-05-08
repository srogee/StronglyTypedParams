
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

                    private RegulationParams(BND4 data)
                    {
                        Data = data;
                        ParamsByName = new Dictionary<string, object>();
                    }

                    public static RegulationParams Load(string path)
                    {
                        var data = SFUtil.DecryptERRegulation(path);
                        return new RegulationParams(data);
                    }

                    public void Save(string path)
                    {
                        SaveParam<ActionButtonParam>("ActionButtonParam");
SaveParam<AiSoundParam>("AiSoundParam");
SaveParam<AssetGeometryParam>("AssetEnvironmentGeometryParam");
SaveParam<AssetMaterialSfxParam>("AssetMaterialSfxParam");
SaveParam<AssetModelSfxParam>("AssetModelSfxParam");
SaveParam<AtkParam>("AtkParam_Npc");
SaveParam<AtkParam>("AtkParam_Pc");
SaveParam<AttackElementCorrectParam>("AttackElementCorrectParam");
SaveParam<AutoCreateEnvSoundParam>("AutoCreateEnvSoundParam");
SaveParam<BaseChrSelectMenuParam>("BaseChrSelectMenuParam");
SaveParam<BehaviorParam>("BehaviorParam");
SaveParam<BehaviorParam>("BehaviorParam_PC");
SaveParam<BonfireWarpParam>("BonfireWarpParam");
SaveParam<BonfireWarpSubCategoryParam>("BonfireWarpSubCategoryParam");
SaveParam<BonfireWarpTabParam>("BonfireWarpTabParam");
SaveParam<BuddyParam>("BuddyParam");
SaveParam<BuddyStoneParam>("BuddyStoneParam");
SaveParam<BudgetParam>("BudgetParam");
SaveParam<BulletParam>("Bullet");
SaveParam<BulletCreateLimitParam>("BulletCreateLimitParam");
SaveParam<CalcCorrectGraph>("CalcCorrectGraph");
SaveParam<CeremonyParam>("Ceremony");
SaveParam<CharaInitParam>("CharaInitParam");
SaveParam<CharMakeMenuListItemParam>("CharMakeMenuListItemParam");
SaveParam<CharMakeMenuTopParam>("CharMakeMenuTopParam");
SaveParam<ChrActivateConditionParam>("ChrActivateConditionParam");
SaveParam<ChrModelParam>("ChrModelParam");
SaveParam<ClearCountCorrectParam>("ClearCountCorrectParam");
SaveParam<CoolTimeParam>("CoolTimeParam");
SaveParam<CutsceneGparamTimeParam>("CutsceneGparamTimeParam");
SaveParam<CutsceneGparamWeatherParam>("CutsceneGparamWeatherParam");
SaveParam<CutsceneMapIdParam>("CutsceneMapIdParam");
SaveParam<CutSceneTextureLoadParam>("CutSceneTextureLoadParam");
SaveParam<CutsceneTimezoneConvertParam>("CutsceneTimezoneConvertParam");
SaveParam<CutsceneWeatherOverrideGparamIdConvertParam>("CutsceneWeatherOverrideGparamConvertParam");
SaveParam<DecalParam>("DecalParam");
SaveParam<DirectionCameraParam>("DirectionCameraParam");
SaveParam<EnemyCommonParam>("EnemyCommonParam");
SaveParam<EnvObjLotParam>("EnvObjLotParam");
SaveParam<EquipMtrlSetParam>("EquipMtrlSetParam");
SaveParam<EquipParamAccessory>("EquipParamAccessory");
SaveParam<EquipParamCustomWeapon>("EquipParamCustomWeapon");
SaveParam<EquipParamGem>("EquipParamGem");
SaveParam<EquipParamGoods>("EquipParamGoods");
SaveParam<EquipParamProtector>("EquipParamProtector");
SaveParam<EquipParamWeapon>("EquipParamWeapon");
SaveParam<FaceParam>("FaceParam");
SaveParam<FaceRangeParam>("FaceRangeParam");
SaveParam<FeTextEffectParam>("FeTextEffectParam");
SaveParam<FootSfxParam>("FootSfxParam");
SaveParam<GameAreaParam>("GameAreaParam");
SaveParam<GameSystemCommonParam>("GameSystemCommonParam");
SaveParam<GestureParam>("GestureParam");
SaveParam<GparamRefSettingsParam>("GparamRefSettings");
SaveParam<GraphicsCommonParam>("GraphicsCommonParam");
SaveParam<GraphicsConfig>("GraphicsConfig");
SaveParam<GrassLodRangeParam>("GrassLodRangeParam");
SaveParam<GrassTypeParam>("GrassTypeParam");
SaveParam<GrassTypeParam>("GrassTypeParam_Lv1");
SaveParam<GrassTypeParam>("GrassTypeParam_Lv2");
SaveParam<HitEffectSeParam>("HitEffectSeParam");
SaveParam<HitEffectSfxConceptParam>("HitEffectSfxConceptParam");
SaveParam<HitEffectSfxParam>("HitEffectSfxParam");
SaveParam<HitMtrlParam>("HitMtrlParam");
SaveParam<EstusFlaskRecoveryParam>("HPEstusFlaskRecoveryParam");
SaveParam<ItemLotParam>("ItemLotParam_enemy");
SaveParam<ItemLotParam>("ItemLotParam_map");
SaveParam<KeyAssignMenuItemParam>("KeyAssignMenuItemParam");
SaveParam<KeyAssignParam>("KeyAssignParam_TypeA");
SaveParam<KeyAssignParam>("KeyAssignParam_TypeB");
SaveParam<KeyAssignParam>("KeyAssignParam_TypeC");
SaveParam<KnockBackParam>("KnockBackParam");
SaveParam<KnowledgeLoadScreenItemParam>("KnowledgeLoadScreenItemParam");
SaveParam<LegacyDistantViewPartsReplaceParam>("LegacyDistantViewPartsReplaceParam");
SaveParam<LoadBalancerDrawDistScaleParam>("LoadBalancerDrawDistScaleParam");
SaveParam<LoadBalancerDrawDistScaleParam>("LoadBalancerDrawDistScaleParam_ps4");
SaveParam<LoadBalancerDrawDistScaleParam>("LoadBalancerDrawDistScaleParam_ps5");
SaveParam<LoadBalancerDrawDistScaleParam>("LoadBalancerDrawDistScaleParam_xb1");
SaveParam<LoadBalancerDrawDistScaleParam>("LoadBalancerDrawDistScaleParam_xb1x");
SaveParam<LoadBalancerDrawDistScaleParam>("LoadBalancerDrawDistScaleParam_xss");
SaveParam<LoadBalancerDrawDistScaleParam>("LoadBalancerDrawDistScaleParam_xsx");
SaveParam<LoadBalancerNewDrawDistScaleParam>("LoadBalancerNewDrawDistScaleParam_ps4");
SaveParam<LoadBalancerNewDrawDistScaleParam>("LoadBalancerNewDrawDistScaleParam_ps5");
SaveParam<LoadBalancerNewDrawDistScaleParam>("LoadBalancerNewDrawDistScaleParam_win64");
SaveParam<LoadBalancerNewDrawDistScaleParam>("LoadBalancerNewDrawDistScaleParam_xb1");
SaveParam<LoadBalancerNewDrawDistScaleParam>("LoadBalancerNewDrawDistScaleParam_xb1x");
SaveParam<LoadBalancerNewDrawDistScaleParam>("LoadBalancerNewDrawDistScaleParam_xss");
SaveParam<LoadBalancerNewDrawDistScaleParam>("LoadBalancerNewDrawDistScaleParam_xsx");
SaveParam<LoadBalancerParam>("LoadBalancerParam");
SaveParam<LockCamParam>("LockCamParam");
SaveParam<MagicParam>("Magic");
SaveParam<MapDefaultInfoParam>("MapDefaultInfoParam");
SaveParam<MapGdRegionDrawParam>("MapGdRegionDrawParam");
SaveParam<MapGdRegionInfo>("MapGdRegionInfoParam");
SaveParam<MapGridCreateHeightLimitInfo>("MapGridCreateHeightLimitInfoParam");
SaveParam<MapMimicryEstablishmentParam>("MapMimicryEstablishmentParam");
SaveParam<MapNameTexParam>("MapNameTexParam");
SaveParam<MapPieceTexParam>("MapPieceTexParam");
SaveParam<MaterialEx>("MaterialExParam");
SaveParam<MenuParamColorTable>("MenuColorTableParam");
SaveParam<MenuCommonParam>("MenuCommonParam");
SaveParam<MenuOffscrRendParam>("MenuOffscrRendParam");
SaveParam<MenuPropertyLayoutParam>("MenuPropertyLayoutParam");
SaveParam<MenuPropertySpecParam>("MenuPropertySpecParam");
SaveParam<MenuValueTableSpecParam>("MenuValueTableParam");
SaveParam<MimicryEstablishmentTexParam>("MimicryEstablishmentTexParam");
SaveParam<MoveParam>("MoveParam");
SaveParam<EstusFlaskRecoveryParam>("MPEstusFlaskRecoveryParam");
SaveParam<MultiEstusFlaskBonusParam>("MultiHPEstusFlaskBonusParam");
SaveParam<MultiEstusFlaskBonusParam>("MultiMPEstusFlaskBonusParam");
SaveParam<MultiPlayCorrectionParam>("MultiPlayCorrectionParam");
SaveParam<MultiSoulBonusRateParam>("MultiSoulBonusRateParam");
SaveParam<NetworkAreaParam>("NetworkAreaParam");
SaveParam<NetworkMsgParam>("NetworkMsgParam");
SaveParam<NetworkParam>("NetworkParam");
SaveParam<NpcAiActionParam>("NpcAiActionParam");
SaveParam<NpcAiBehaviorProbabilityParam>("NpcAiBehaviorProbability");
SaveParam<NpcParam>("NpcParam");
SaveParam<NpcThinkParam>("NpcThinkParam");
SaveParam<ObjActParam>("ObjActParam");
SaveParam<PartsDrawParam>("PartsDrawParam");
SaveParam<PhantomParam>("PhantomParam");
SaveParam<PlayerCommonParam>("PlayerCommonParam");
SaveParam<PlayRegionParam>("PlayRegionParam");
SaveParam<PostureControlParam_Gender>("PostureControlParam_Gender");
SaveParam<PostureControlParam_Pro>("PostureControlParam_Pro");
SaveParam<PostureControlParam_WepLeft>("PostureControlParam_WepLeft");
SaveParam<PostureControlParam_WepRight>("PostureControlParam_WepRight");
SaveParam<RandomAppearParam>("RandomAppearParam");
SaveParam<ReinforceParamProtector>("ReinforceParamProtector");
SaveParam<ReinforceParamWeapon>("ReinforceParamWeapon");
SaveParam<ResistCorrectParam>("ResistCorrectParam");
SaveParam<RideParam>("RideParam");
SaveParam<RoleParam>("RoleParam");
SaveParam<RollingObjLotParam>("RollingObjLotParam");
SaveParam<RuntimeBoneControlParam>("RuntimeBoneControlParam");
SaveParam<SeActivationRangeParam>("SeActivationRangeParam");
SaveParam<SeMaterialConvertParam>("SeMaterialConvertParam");
SaveParam<SfxBlockResShareParam>("SfxBlockResShareParam");
SaveParam<ShopLineupParam>("ShopLineupParam");
SaveParam<ShopLineupParam>("ShopLineupParam_Recipe");
SaveParam<SignPuddleParam>("SignPuddleParam");
SaveParam<SoundAssetSoundObjEnableDistParam>("SoundAssetSoundObjEnableDistParam");
SaveParam<SoundAutoEnvSoundGroupParam>("SoundAutoEnvSoundGroupParam");
SaveParam<SoundAutoReverbEvaluationDistParam>("SoundAutoReverbEvaluationDistParam");
SaveParam<SoundAutoReverbSelectParam>("SoundAutoReverbSelectParam");
SaveParam<SoundChrPhysicsSeParam>("SoundChrPhysicsSeParam");
SaveParam<SoundCommonIngameParam>("SoundCommonIngameParam");
SaveParam<SoundCutsceneParam>("SoundCutsceneParam");
SaveParam<SpeedtreeModel>("SpeedtreeParam");
SaveParam<SpEffect>("SpEffectParam");
SaveParam<SpEffectSetParam>("SpEffectSetParam");
SaveParam<SpEffectVfx>("SpEffectVfxParam");
SaveParam<SwordArtsParam>("SwordArtsParam");
SaveParam<TalkParam>("TalkParam");
SaveParam<ThrowDirectionSfxParam>("ThrowDirectionSfxParam");
SaveParam<ThrowParam>("ThrowParam");
SaveParam<ToughnessParam>("ToughnessParam");
SaveParam<TutorialParam>("TutorialParam");
SaveParam<WaypointParam>("WaypointParam");
SaveParam<WeatherAssetCreateParam>("WeatherAssetCreateParam");
SaveParam<WeatherAssetReplaceParam>("WeatherAssetReplaceParam");
SaveParam<WeatherLotParam>("WeatherLotParam");
SaveParam<WeatherLotTexParam>("WeatherLotTexParam");
SaveParam<WeatherParam>("WeatherParam");
SaveParam<WepAbsorpPosParam>("WepAbsorpPosParam");
SaveParam<WetAspectParam>("WetAspectParam");
SaveParam<WhiteSignCoolTimeParam>("WhiteSignCoolTimeParam");
SaveParam<WorldMapLegacyConvParam>("WorldMapLegacyConvParam");
SaveParam<WorldMapPieceParam>("WorldMapPieceParam");
SaveParam<WorldMapPlaceNameParam>("WorldMapPlaceNameParam");
SaveParam<WorldMapPointParam>("WorldMapPointParam");
SaveParam<WwiseValueToStrConvertParamFormat>("WwiseValueToStrParam_BgmBossChrIdConv");
SaveParam<WwiseValueToStrConvertParamFormat>("WwiseValueToStrParam_EnvPlaceType");
SaveParam<WwiseValueToStrConvertParamFormat>("WwiseValueToStrParam_Switch_AttackStrength");
SaveParam<WwiseValueToStrConvertParamFormat>("WwiseValueToStrParam_Switch_AttackType");
SaveParam<WwiseValueToStrConvertParamFormat>("WwiseValueToStrParam_Switch_DamageAmount");
SaveParam<WwiseValueToStrConvertParamFormat>("WwiseValueToStrParam_Switch_DeffensiveMaterial");
SaveParam<WwiseValueToStrConvertParamFormat>("WwiseValueToStrParam_Switch_GrassHitType");
SaveParam<WwiseValueToStrConvertParamFormat>("WwiseValueToStrParam_Switch_HitStop");
SaveParam<WwiseValueToStrConvertParamFormat>("WwiseValueToStrParam_Switch_OffensiveMaterial");
SaveParam<WwiseValueToStrConvertParamFormat>("WwiseValueToStrParam_Switch_PlayerEquipmentBottoms");
SaveParam<WwiseValueToStrConvertParamFormat>("WwiseValueToStrParam_Switch_PlayerEquipmentTops");
SaveParam<WwiseValueToStrConvertParamFormat>("WwiseValueToStrParam_Switch_PlayerShoes");
SaveParam<WwiseValueToStrConvertParamFormat>("WwiseValueToStrParam_Switch_PlayerVoiceType");
                        SFUtil.EncryptERRegulation(path, Data);
                    }

                    private ParamCollection<T> GetOrLoadParam<T>(string paramName, string paramClassName) where T : ParamRow, new()
                    {
                        if (!ParamsByName.ContainsKey(paramName)) {
                            LoadParam<T>(paramName, paramClassName);
                        }

                        return (ParamCollection<T>)ParamsByName[paramName];
                    }

                    private void LoadParam<T>(string paramName, string paramClassName) where T : ParamRow, new()
                    {
                        Console.WriteLine("Loading param " + paramName);
                        BinderFile paramFile = Data.Files.Find(file => Path.GetFileNameWithoutExtension(file.Name) == paramName);
						if (paramFile == null)
                        {
                            Console.WriteLine("Error when loading param " + paramName);
                            ParamsByName.Add(paramName, null);
                            return;
                        }
                        var paramCollection = new ParamCollection<T>(PARAM.Read(paramFile.Bytes), paramName, paramClassName);
                        ParamsByName.Add(paramName, paramCollection);
                    }

                    private void SaveParam<T>(string paramName) where T : ParamRow, new()
                    {
                        if (ParamsByName.ContainsKey(paramName))
                        {
                            BinderFile paramFile = Data.Files.Find(file => Path.GetFileNameWithoutExtension(file.Name) == paramName);
                            if (paramFile != null && ParamsByName[paramName] != null)
                            {
                                var collection = ParamsByName[paramName] as ParamCollection<T>;
                                paramFile.Bytes = collection.ToByteArray();
                            }
                        }
                    }
            
		public ParamCollection<ActionButtonParam> ActionButtonParam => GetOrLoadParam<ActionButtonParam>("ActionButtonParam","ActionButtonParam");
		public ParamCollection<AiSoundParam> AiSoundParam => GetOrLoadParam<AiSoundParam>("AiSoundParam","AiSoundParam");
		public ParamCollection<AssetGeometryParam> AssetEnvironmentGeometryParam => GetOrLoadParam<AssetGeometryParam>("AssetEnvironmentGeometryParam","AssetGeometryParam");
		public ParamCollection<AssetMaterialSfxParam> AssetMaterialSfxParam => GetOrLoadParam<AssetMaterialSfxParam>("AssetMaterialSfxParam","AssetMaterialSfxParam");
		public ParamCollection<AssetModelSfxParam> AssetModelSfxParam => GetOrLoadParam<AssetModelSfxParam>("AssetModelSfxParam","AssetModelSfxParam");
		public ParamCollection<AtkParam> AtkParam_Npc => GetOrLoadParam<AtkParam>("AtkParam_Npc","AtkParam");
		public ParamCollection<AtkParam> AtkParam_Pc => GetOrLoadParam<AtkParam>("AtkParam_Pc","AtkParam");
		public ParamCollection<AttackElementCorrectParam> AttackElementCorrectParam => GetOrLoadParam<AttackElementCorrectParam>("AttackElementCorrectParam","AttackElementCorrectParam");
		public ParamCollection<AutoCreateEnvSoundParam> AutoCreateEnvSoundParam => GetOrLoadParam<AutoCreateEnvSoundParam>("AutoCreateEnvSoundParam","AutoCreateEnvSoundParam");
		public ParamCollection<BaseChrSelectMenuParam> BaseChrSelectMenuParam => GetOrLoadParam<BaseChrSelectMenuParam>("BaseChrSelectMenuParam","BaseChrSelectMenuParam");
		public ParamCollection<BehaviorParam> BehaviorParam => GetOrLoadParam<BehaviorParam>("BehaviorParam","BehaviorParam");
		public ParamCollection<BehaviorParam> BehaviorParam_PC => GetOrLoadParam<BehaviorParam>("BehaviorParam_PC","BehaviorParam");
		public ParamCollection<BonfireWarpParam> BonfireWarpParam => GetOrLoadParam<BonfireWarpParam>("BonfireWarpParam","BonfireWarpParam");
		public ParamCollection<BonfireWarpSubCategoryParam> BonfireWarpSubCategoryParam => GetOrLoadParam<BonfireWarpSubCategoryParam>("BonfireWarpSubCategoryParam","BonfireWarpSubCategoryParam");
		public ParamCollection<BonfireWarpTabParam> BonfireWarpTabParam => GetOrLoadParam<BonfireWarpTabParam>("BonfireWarpTabParam","BonfireWarpTabParam");
		public ParamCollection<BuddyParam> BuddyParam => GetOrLoadParam<BuddyParam>("BuddyParam","BuddyParam");
		public ParamCollection<BuddyStoneParam> BuddyStoneParam => GetOrLoadParam<BuddyStoneParam>("BuddyStoneParam","BuddyStoneParam");
		public ParamCollection<BudgetParam> BudgetParam => GetOrLoadParam<BudgetParam>("BudgetParam","BudgetParam");
		public ParamCollection<BulletParam> Bullet => GetOrLoadParam<BulletParam>("Bullet","BulletParam");
		public ParamCollection<BulletCreateLimitParam> BulletCreateLimitParam => GetOrLoadParam<BulletCreateLimitParam>("BulletCreateLimitParam","BulletCreateLimitParam");
		public ParamCollection<CalcCorrectGraph> CalcCorrectGraph => GetOrLoadParam<CalcCorrectGraph>("CalcCorrectGraph","CalcCorrectGraph");
		public ParamCollection<CeremonyParam> Ceremony => GetOrLoadParam<CeremonyParam>("Ceremony","CeremonyParam");
		public ParamCollection<CharaInitParam> CharaInitParam => GetOrLoadParam<CharaInitParam>("CharaInitParam","CharaInitParam");
		public ParamCollection<CharMakeMenuListItemParam> CharMakeMenuListItemParam => GetOrLoadParam<CharMakeMenuListItemParam>("CharMakeMenuListItemParam","CharMakeMenuListItemParam");
		public ParamCollection<CharMakeMenuTopParam> CharMakeMenuTopParam => GetOrLoadParam<CharMakeMenuTopParam>("CharMakeMenuTopParam","CharMakeMenuTopParam");
		public ParamCollection<ChrActivateConditionParam> ChrActivateConditionParam => GetOrLoadParam<ChrActivateConditionParam>("ChrActivateConditionParam","ChrActivateConditionParam");
		public ParamCollection<ChrModelParam> ChrModelParam => GetOrLoadParam<ChrModelParam>("ChrModelParam","ChrModelParam");
		public ParamCollection<ClearCountCorrectParam> ClearCountCorrectParam => GetOrLoadParam<ClearCountCorrectParam>("ClearCountCorrectParam","ClearCountCorrectParam");
		public ParamCollection<CoolTimeParam> CoolTimeParam => GetOrLoadParam<CoolTimeParam>("CoolTimeParam","CoolTimeParam");
		public ParamCollection<CutsceneGparamTimeParam> CutsceneGparamTimeParam => GetOrLoadParam<CutsceneGparamTimeParam>("CutsceneGparamTimeParam","CutsceneGparamTimeParam");
		public ParamCollection<CutsceneGparamWeatherParam> CutsceneGparamWeatherParam => GetOrLoadParam<CutsceneGparamWeatherParam>("CutsceneGparamWeatherParam","CutsceneGparamWeatherParam");
		public ParamCollection<CutsceneMapIdParam> CutsceneMapIdParam => GetOrLoadParam<CutsceneMapIdParam>("CutsceneMapIdParam","CutsceneMapIdParam");
		public ParamCollection<CutSceneTextureLoadParam> CutSceneTextureLoadParam => GetOrLoadParam<CutSceneTextureLoadParam>("CutSceneTextureLoadParam","CutSceneTextureLoadParam");
		public ParamCollection<CutsceneTimezoneConvertParam> CutsceneTimezoneConvertParam => GetOrLoadParam<CutsceneTimezoneConvertParam>("CutsceneTimezoneConvertParam","CutsceneTimezoneConvertParam");
		public ParamCollection<CutsceneWeatherOverrideGparamIdConvertParam> CutsceneWeatherOverrideGparamConvertParam => GetOrLoadParam<CutsceneWeatherOverrideGparamIdConvertParam>("CutsceneWeatherOverrideGparamConvertParam","CutsceneWeatherOverrideGparamIdConvertParam");
		public ParamCollection<DecalParam> DecalParam => GetOrLoadParam<DecalParam>("DecalParam","DecalParam");
		public ParamCollection<DirectionCameraParam> DirectionCameraParam => GetOrLoadParam<DirectionCameraParam>("DirectionCameraParam","DirectionCameraParam");
		public ParamCollection<EnemyCommonParam> EnemyCommonParam => GetOrLoadParam<EnemyCommonParam>("EnemyCommonParam","EnemyCommonParam");
		public ParamCollection<EnvObjLotParam> EnvObjLotParam => GetOrLoadParam<EnvObjLotParam>("EnvObjLotParam","EnvObjLotParam");
		public ParamCollection<EquipMtrlSetParam> EquipMtrlSetParam => GetOrLoadParam<EquipMtrlSetParam>("EquipMtrlSetParam","EquipMtrlSetParam");
		public ParamCollection<EquipParamAccessory> EquipParamAccessory => GetOrLoadParam<EquipParamAccessory>("EquipParamAccessory","EquipParamAccessory");
		public ParamCollection<EquipParamCustomWeapon> EquipParamCustomWeapon => GetOrLoadParam<EquipParamCustomWeapon>("EquipParamCustomWeapon","EquipParamCustomWeapon");
		public ParamCollection<EquipParamGem> EquipParamGem => GetOrLoadParam<EquipParamGem>("EquipParamGem","EquipParamGem");
		public ParamCollection<EquipParamGoods> EquipParamGoods => GetOrLoadParam<EquipParamGoods>("EquipParamGoods","EquipParamGoods");
		public ParamCollection<EquipParamProtector> EquipParamProtector => GetOrLoadParam<EquipParamProtector>("EquipParamProtector","EquipParamProtector");
		public ParamCollection<EquipParamWeapon> EquipParamWeapon => GetOrLoadParam<EquipParamWeapon>("EquipParamWeapon","EquipParamWeapon");
		public ParamCollection<FaceParam> FaceParam => GetOrLoadParam<FaceParam>("FaceParam","FaceParam");
		public ParamCollection<FaceRangeParam> FaceRangeParam => GetOrLoadParam<FaceRangeParam>("FaceRangeParam","FaceRangeParam");
		public ParamCollection<FeTextEffectParam> FeTextEffectParam => GetOrLoadParam<FeTextEffectParam>("FeTextEffectParam","FeTextEffectParam");
		public ParamCollection<FootSfxParam> FootSfxParam => GetOrLoadParam<FootSfxParam>("FootSfxParam","FootSfxParam");
		public ParamCollection<GameAreaParam> GameAreaParam => GetOrLoadParam<GameAreaParam>("GameAreaParam","GameAreaParam");
		public ParamCollection<GameSystemCommonParam> GameSystemCommonParam => GetOrLoadParam<GameSystemCommonParam>("GameSystemCommonParam","GameSystemCommonParam");
		public ParamCollection<GestureParam> GestureParam => GetOrLoadParam<GestureParam>("GestureParam","GestureParam");
		public ParamCollection<GparamRefSettingsParam> GparamRefSettings => GetOrLoadParam<GparamRefSettingsParam>("GparamRefSettings","GparamRefSettingsParam");
		public ParamCollection<GraphicsCommonParam> GraphicsCommonParam => GetOrLoadParam<GraphicsCommonParam>("GraphicsCommonParam","GraphicsCommonParam");
		public ParamCollection<GraphicsConfig> GraphicsConfig => GetOrLoadParam<GraphicsConfig>("GraphicsConfig","GraphicsConfig");
		public ParamCollection<GrassLodRangeParam> GrassLodRangeParam => GetOrLoadParam<GrassLodRangeParam>("GrassLodRangeParam","GrassLodRangeParam");
		public ParamCollection<GrassTypeParam> GrassTypeParam => GetOrLoadParam<GrassTypeParam>("GrassTypeParam","GrassTypeParam");
		public ParamCollection<GrassTypeParam> GrassTypeParam_Lv1 => GetOrLoadParam<GrassTypeParam>("GrassTypeParam_Lv1","GrassTypeParam");
		public ParamCollection<GrassTypeParam> GrassTypeParam_Lv2 => GetOrLoadParam<GrassTypeParam>("GrassTypeParam_Lv2","GrassTypeParam");
		public ParamCollection<HitEffectSeParam> HitEffectSeParam => GetOrLoadParam<HitEffectSeParam>("HitEffectSeParam","HitEffectSeParam");
		public ParamCollection<HitEffectSfxConceptParam> HitEffectSfxConceptParam => GetOrLoadParam<HitEffectSfxConceptParam>("HitEffectSfxConceptParam","HitEffectSfxConceptParam");
		public ParamCollection<HitEffectSfxParam> HitEffectSfxParam => GetOrLoadParam<HitEffectSfxParam>("HitEffectSfxParam","HitEffectSfxParam");
		public ParamCollection<HitMtrlParam> HitMtrlParam => GetOrLoadParam<HitMtrlParam>("HitMtrlParam","HitMtrlParam");
		public ParamCollection<EstusFlaskRecoveryParam> HPEstusFlaskRecoveryParam => GetOrLoadParam<EstusFlaskRecoveryParam>("HPEstusFlaskRecoveryParam","EstusFlaskRecoveryParam");
		public ParamCollection<ItemLotParam> ItemLotParam_enemy => GetOrLoadParam<ItemLotParam>("ItemLotParam_enemy","ItemLotParam");
		public ParamCollection<ItemLotParam> ItemLotParam_map => GetOrLoadParam<ItemLotParam>("ItemLotParam_map","ItemLotParam");
		public ParamCollection<KeyAssignMenuItemParam> KeyAssignMenuItemParam => GetOrLoadParam<KeyAssignMenuItemParam>("KeyAssignMenuItemParam","KeyAssignMenuItemParam");
		public ParamCollection<KeyAssignParam> KeyAssignParam_TypeA => GetOrLoadParam<KeyAssignParam>("KeyAssignParam_TypeA","KeyAssignParam");
		public ParamCollection<KeyAssignParam> KeyAssignParam_TypeB => GetOrLoadParam<KeyAssignParam>("KeyAssignParam_TypeB","KeyAssignParam");
		public ParamCollection<KeyAssignParam> KeyAssignParam_TypeC => GetOrLoadParam<KeyAssignParam>("KeyAssignParam_TypeC","KeyAssignParam");
		public ParamCollection<KnockBackParam> KnockBackParam => GetOrLoadParam<KnockBackParam>("KnockBackParam","KnockBackParam");
		public ParamCollection<KnowledgeLoadScreenItemParam> KnowledgeLoadScreenItemParam => GetOrLoadParam<KnowledgeLoadScreenItemParam>("KnowledgeLoadScreenItemParam","KnowledgeLoadScreenItemParam");
		public ParamCollection<LegacyDistantViewPartsReplaceParam> LegacyDistantViewPartsReplaceParam => GetOrLoadParam<LegacyDistantViewPartsReplaceParam>("LegacyDistantViewPartsReplaceParam","LegacyDistantViewPartsReplaceParam");
		public ParamCollection<LoadBalancerDrawDistScaleParam> LoadBalancerDrawDistScaleParam => GetOrLoadParam<LoadBalancerDrawDistScaleParam>("LoadBalancerDrawDistScaleParam","LoadBalancerDrawDistScaleParam");
		public ParamCollection<LoadBalancerDrawDistScaleParam> LoadBalancerDrawDistScaleParam_ps4 => GetOrLoadParam<LoadBalancerDrawDistScaleParam>("LoadBalancerDrawDistScaleParam_ps4","LoadBalancerDrawDistScaleParam");
		public ParamCollection<LoadBalancerDrawDistScaleParam> LoadBalancerDrawDistScaleParam_ps5 => GetOrLoadParam<LoadBalancerDrawDistScaleParam>("LoadBalancerDrawDistScaleParam_ps5","LoadBalancerDrawDistScaleParam");
		public ParamCollection<LoadBalancerDrawDistScaleParam> LoadBalancerDrawDistScaleParam_xb1 => GetOrLoadParam<LoadBalancerDrawDistScaleParam>("LoadBalancerDrawDistScaleParam_xb1","LoadBalancerDrawDistScaleParam");
		public ParamCollection<LoadBalancerDrawDistScaleParam> LoadBalancerDrawDistScaleParam_xb1x => GetOrLoadParam<LoadBalancerDrawDistScaleParam>("LoadBalancerDrawDistScaleParam_xb1x","LoadBalancerDrawDistScaleParam");
		public ParamCollection<LoadBalancerDrawDistScaleParam> LoadBalancerDrawDistScaleParam_xss => GetOrLoadParam<LoadBalancerDrawDistScaleParam>("LoadBalancerDrawDistScaleParam_xss","LoadBalancerDrawDistScaleParam");
		public ParamCollection<LoadBalancerDrawDistScaleParam> LoadBalancerDrawDistScaleParam_xsx => GetOrLoadParam<LoadBalancerDrawDistScaleParam>("LoadBalancerDrawDistScaleParam_xsx","LoadBalancerDrawDistScaleParam");
		public ParamCollection<LoadBalancerNewDrawDistScaleParam> LoadBalancerNewDrawDistScaleParam_ps4 => GetOrLoadParam<LoadBalancerNewDrawDistScaleParam>("LoadBalancerNewDrawDistScaleParam_ps4","LoadBalancerNewDrawDistScaleParam");
		public ParamCollection<LoadBalancerNewDrawDistScaleParam> LoadBalancerNewDrawDistScaleParam_ps5 => GetOrLoadParam<LoadBalancerNewDrawDistScaleParam>("LoadBalancerNewDrawDistScaleParam_ps5","LoadBalancerNewDrawDistScaleParam");
		public ParamCollection<LoadBalancerNewDrawDistScaleParam> LoadBalancerNewDrawDistScaleParam_win64 => GetOrLoadParam<LoadBalancerNewDrawDistScaleParam>("LoadBalancerNewDrawDistScaleParam_win64","LoadBalancerNewDrawDistScaleParam");
		public ParamCollection<LoadBalancerNewDrawDistScaleParam> LoadBalancerNewDrawDistScaleParam_xb1 => GetOrLoadParam<LoadBalancerNewDrawDistScaleParam>("LoadBalancerNewDrawDistScaleParam_xb1","LoadBalancerNewDrawDistScaleParam");
		public ParamCollection<LoadBalancerNewDrawDistScaleParam> LoadBalancerNewDrawDistScaleParam_xb1x => GetOrLoadParam<LoadBalancerNewDrawDistScaleParam>("LoadBalancerNewDrawDistScaleParam_xb1x","LoadBalancerNewDrawDistScaleParam");
		public ParamCollection<LoadBalancerNewDrawDistScaleParam> LoadBalancerNewDrawDistScaleParam_xss => GetOrLoadParam<LoadBalancerNewDrawDistScaleParam>("LoadBalancerNewDrawDistScaleParam_xss","LoadBalancerNewDrawDistScaleParam");
		public ParamCollection<LoadBalancerNewDrawDistScaleParam> LoadBalancerNewDrawDistScaleParam_xsx => GetOrLoadParam<LoadBalancerNewDrawDistScaleParam>("LoadBalancerNewDrawDistScaleParam_xsx","LoadBalancerNewDrawDistScaleParam");
		public ParamCollection<LoadBalancerParam> LoadBalancerParam => GetOrLoadParam<LoadBalancerParam>("LoadBalancerParam","LoadBalancerParam");
		public ParamCollection<LockCamParam> LockCamParam => GetOrLoadParam<LockCamParam>("LockCamParam","LockCamParam");
		public ParamCollection<MagicParam> Magic => GetOrLoadParam<MagicParam>("Magic","MagicParam");
		public ParamCollection<MapDefaultInfoParam> MapDefaultInfoParam => GetOrLoadParam<MapDefaultInfoParam>("MapDefaultInfoParam","MapDefaultInfoParam");
		public ParamCollection<MapGdRegionDrawParam> MapGdRegionDrawParam => GetOrLoadParam<MapGdRegionDrawParam>("MapGdRegionDrawParam","MapGdRegionDrawParam");
		public ParamCollection<MapGdRegionInfo> MapGdRegionInfoParam => GetOrLoadParam<MapGdRegionInfo>("MapGdRegionInfoParam","MapGdRegionInfo");
		public ParamCollection<MapGridCreateHeightLimitInfo> MapGridCreateHeightLimitInfoParam => GetOrLoadParam<MapGridCreateHeightLimitInfo>("MapGridCreateHeightLimitInfoParam","MapGridCreateHeightLimitInfo");
		public ParamCollection<MapMimicryEstablishmentParam> MapMimicryEstablishmentParam => GetOrLoadParam<MapMimicryEstablishmentParam>("MapMimicryEstablishmentParam","MapMimicryEstablishmentParam");
		public ParamCollection<MapNameTexParam> MapNameTexParam => GetOrLoadParam<MapNameTexParam>("MapNameTexParam","MapNameTexParam");
		public ParamCollection<MapPieceTexParam> MapPieceTexParam => GetOrLoadParam<MapPieceTexParam>("MapPieceTexParam","MapPieceTexParam");
		public ParamCollection<MaterialEx> MaterialExParam => GetOrLoadParam<MaterialEx>("MaterialExParam","MaterialEx");
		public ParamCollection<MenuParamColorTable> MenuColorTableParam => GetOrLoadParam<MenuParamColorTable>("MenuColorTableParam","MenuParamColorTable");
		public ParamCollection<MenuCommonParam> MenuCommonParam => GetOrLoadParam<MenuCommonParam>("MenuCommonParam","MenuCommonParam");
		public ParamCollection<MenuOffscrRendParam> MenuOffscrRendParam => GetOrLoadParam<MenuOffscrRendParam>("MenuOffscrRendParam","MenuOffscrRendParam");
		public ParamCollection<MenuPropertyLayoutParam> MenuPropertyLayoutParam => GetOrLoadParam<MenuPropertyLayoutParam>("MenuPropertyLayoutParam","MenuPropertyLayoutParam");
		public ParamCollection<MenuPropertySpecParam> MenuPropertySpecParam => GetOrLoadParam<MenuPropertySpecParam>("MenuPropertySpecParam","MenuPropertySpecParam");
		public ParamCollection<MenuValueTableSpecParam> MenuValueTableParam => GetOrLoadParam<MenuValueTableSpecParam>("MenuValueTableParam","MenuValueTableSpecParam");
		public ParamCollection<MimicryEstablishmentTexParam> MimicryEstablishmentTexParam => GetOrLoadParam<MimicryEstablishmentTexParam>("MimicryEstablishmentTexParam","MimicryEstablishmentTexParam");
		public ParamCollection<MoveParam> MoveParam => GetOrLoadParam<MoveParam>("MoveParam","MoveParam");
		public ParamCollection<EstusFlaskRecoveryParam> MPEstusFlaskRecoveryParam => GetOrLoadParam<EstusFlaskRecoveryParam>("MPEstusFlaskRecoveryParam","EstusFlaskRecoveryParam");
		public ParamCollection<MultiEstusFlaskBonusParam> MultiHPEstusFlaskBonusParam => GetOrLoadParam<MultiEstusFlaskBonusParam>("MultiHPEstusFlaskBonusParam","MultiEstusFlaskBonusParam");
		public ParamCollection<MultiEstusFlaskBonusParam> MultiMPEstusFlaskBonusParam => GetOrLoadParam<MultiEstusFlaskBonusParam>("MultiMPEstusFlaskBonusParam","MultiEstusFlaskBonusParam");
		public ParamCollection<MultiPlayCorrectionParam> MultiPlayCorrectionParam => GetOrLoadParam<MultiPlayCorrectionParam>("MultiPlayCorrectionParam","MultiPlayCorrectionParam");
		public ParamCollection<MultiSoulBonusRateParam> MultiSoulBonusRateParam => GetOrLoadParam<MultiSoulBonusRateParam>("MultiSoulBonusRateParam","MultiSoulBonusRateParam");
		public ParamCollection<NetworkAreaParam> NetworkAreaParam => GetOrLoadParam<NetworkAreaParam>("NetworkAreaParam","NetworkAreaParam");
		public ParamCollection<NetworkMsgParam> NetworkMsgParam => GetOrLoadParam<NetworkMsgParam>("NetworkMsgParam","NetworkMsgParam");
		public ParamCollection<NetworkParam> NetworkParam => GetOrLoadParam<NetworkParam>("NetworkParam","NetworkParam");
		public ParamCollection<NpcAiActionParam> NpcAiActionParam => GetOrLoadParam<NpcAiActionParam>("NpcAiActionParam","NpcAiActionParam");
		public ParamCollection<NpcAiBehaviorProbabilityParam> NpcAiBehaviorProbability => GetOrLoadParam<NpcAiBehaviorProbabilityParam>("NpcAiBehaviorProbability","NpcAiBehaviorProbabilityParam");
		public ParamCollection<NpcParam> NpcParam => GetOrLoadParam<NpcParam>("NpcParam","NpcParam");
		public ParamCollection<NpcThinkParam> NpcThinkParam => GetOrLoadParam<NpcThinkParam>("NpcThinkParam","NpcThinkParam");
		public ParamCollection<ObjActParam> ObjActParam => GetOrLoadParam<ObjActParam>("ObjActParam","ObjActParam");
		public ParamCollection<PartsDrawParam> PartsDrawParam => GetOrLoadParam<PartsDrawParam>("PartsDrawParam","PartsDrawParam");
		public ParamCollection<PhantomParam> PhantomParam => GetOrLoadParam<PhantomParam>("PhantomParam","PhantomParam");
		public ParamCollection<PlayerCommonParam> PlayerCommonParam => GetOrLoadParam<PlayerCommonParam>("PlayerCommonParam","PlayerCommonParam");
		public ParamCollection<PlayRegionParam> PlayRegionParam => GetOrLoadParam<PlayRegionParam>("PlayRegionParam","PlayRegionParam");
		public ParamCollection<PostureControlParam_Gender> PostureControlParam_Gender => GetOrLoadParam<PostureControlParam_Gender>("PostureControlParam_Gender","PostureControlParam_Gender");
		public ParamCollection<PostureControlParam_Pro> PostureControlParam_Pro => GetOrLoadParam<PostureControlParam_Pro>("PostureControlParam_Pro","PostureControlParam_Pro");
		public ParamCollection<PostureControlParam_WepLeft> PostureControlParam_WepLeft => GetOrLoadParam<PostureControlParam_WepLeft>("PostureControlParam_WepLeft","PostureControlParam_WepLeft");
		public ParamCollection<PostureControlParam_WepRight> PostureControlParam_WepRight => GetOrLoadParam<PostureControlParam_WepRight>("PostureControlParam_WepRight","PostureControlParam_WepRight");
		public ParamCollection<RandomAppearParam> RandomAppearParam => GetOrLoadParam<RandomAppearParam>("RandomAppearParam","RandomAppearParam");
		public ParamCollection<ReinforceParamProtector> ReinforceParamProtector => GetOrLoadParam<ReinforceParamProtector>("ReinforceParamProtector","ReinforceParamProtector");
		public ParamCollection<ReinforceParamWeapon> ReinforceParamWeapon => GetOrLoadParam<ReinforceParamWeapon>("ReinforceParamWeapon","ReinforceParamWeapon");
		public ParamCollection<ResistCorrectParam> ResistCorrectParam => GetOrLoadParam<ResistCorrectParam>("ResistCorrectParam","ResistCorrectParam");
		public ParamCollection<RideParam> RideParam => GetOrLoadParam<RideParam>("RideParam","RideParam");
		public ParamCollection<RoleParam> RoleParam => GetOrLoadParam<RoleParam>("RoleParam","RoleParam");
		public ParamCollection<RollingObjLotParam> RollingObjLotParam => GetOrLoadParam<RollingObjLotParam>("RollingObjLotParam","RollingObjLotParam");
		public ParamCollection<RuntimeBoneControlParam> RuntimeBoneControlParam => GetOrLoadParam<RuntimeBoneControlParam>("RuntimeBoneControlParam","RuntimeBoneControlParam");
		public ParamCollection<SeActivationRangeParam> SeActivationRangeParam => GetOrLoadParam<SeActivationRangeParam>("SeActivationRangeParam","SeActivationRangeParam");
		public ParamCollection<SeMaterialConvertParam> SeMaterialConvertParam => GetOrLoadParam<SeMaterialConvertParam>("SeMaterialConvertParam","SeMaterialConvertParam");
		public ParamCollection<SfxBlockResShareParam> SfxBlockResShareParam => GetOrLoadParam<SfxBlockResShareParam>("SfxBlockResShareParam","SfxBlockResShareParam");
		public ParamCollection<ShopLineupParam> ShopLineupParam => GetOrLoadParam<ShopLineupParam>("ShopLineupParam","ShopLineupParam");
		public ParamCollection<ShopLineupParam> ShopLineupParam_Recipe => GetOrLoadParam<ShopLineupParam>("ShopLineupParam_Recipe","ShopLineupParam");
		public ParamCollection<SignPuddleParam> SignPuddleParam => GetOrLoadParam<SignPuddleParam>("SignPuddleParam","SignPuddleParam");
		public ParamCollection<SoundAssetSoundObjEnableDistParam> SoundAssetSoundObjEnableDistParam => GetOrLoadParam<SoundAssetSoundObjEnableDistParam>("SoundAssetSoundObjEnableDistParam","SoundAssetSoundObjEnableDistParam");
		public ParamCollection<SoundAutoEnvSoundGroupParam> SoundAutoEnvSoundGroupParam => GetOrLoadParam<SoundAutoEnvSoundGroupParam>("SoundAutoEnvSoundGroupParam","SoundAutoEnvSoundGroupParam");
		public ParamCollection<SoundAutoReverbEvaluationDistParam> SoundAutoReverbEvaluationDistParam => GetOrLoadParam<SoundAutoReverbEvaluationDistParam>("SoundAutoReverbEvaluationDistParam","SoundAutoReverbEvaluationDistParam");
		public ParamCollection<SoundAutoReverbSelectParam> SoundAutoReverbSelectParam => GetOrLoadParam<SoundAutoReverbSelectParam>("SoundAutoReverbSelectParam","SoundAutoReverbSelectParam");
		public ParamCollection<SoundChrPhysicsSeParam> SoundChrPhysicsSeParam => GetOrLoadParam<SoundChrPhysicsSeParam>("SoundChrPhysicsSeParam","SoundChrPhysicsSeParam");
		public ParamCollection<SoundCommonIngameParam> SoundCommonIngameParam => GetOrLoadParam<SoundCommonIngameParam>("SoundCommonIngameParam","SoundCommonIngameParam");
		public ParamCollection<SoundCutsceneParam> SoundCutsceneParam => GetOrLoadParam<SoundCutsceneParam>("SoundCutsceneParam","SoundCutsceneParam");
		public ParamCollection<SpeedtreeModel> SpeedtreeParam => GetOrLoadParam<SpeedtreeModel>("SpeedtreeParam","SpeedtreeModel");
		public ParamCollection<SpEffect> SpEffectParam => GetOrLoadParam<SpEffect>("SpEffectParam","SpEffect");
		public ParamCollection<SpEffectSetParam> SpEffectSetParam => GetOrLoadParam<SpEffectSetParam>("SpEffectSetParam","SpEffectSetParam");
		public ParamCollection<SpEffectVfx> SpEffectVfxParam => GetOrLoadParam<SpEffectVfx>("SpEffectVfxParam","SpEffectVfx");
		public ParamCollection<SwordArtsParam> SwordArtsParam => GetOrLoadParam<SwordArtsParam>("SwordArtsParam","SwordArtsParam");
		public ParamCollection<TalkParam> TalkParam => GetOrLoadParam<TalkParam>("TalkParam","TalkParam");
		public ParamCollection<ThrowDirectionSfxParam> ThrowDirectionSfxParam => GetOrLoadParam<ThrowDirectionSfxParam>("ThrowDirectionSfxParam","ThrowDirectionSfxParam");
		public ParamCollection<ThrowParam> ThrowParam => GetOrLoadParam<ThrowParam>("ThrowParam","ThrowParam");
		public ParamCollection<ToughnessParam> ToughnessParam => GetOrLoadParam<ToughnessParam>("ToughnessParam","ToughnessParam");
		public ParamCollection<TutorialParam> TutorialParam => GetOrLoadParam<TutorialParam>("TutorialParam","TutorialParam");
		public ParamCollection<WaypointParam> WaypointParam => GetOrLoadParam<WaypointParam>("WaypointParam","WaypointParam");
		public ParamCollection<WeatherAssetCreateParam> WeatherAssetCreateParam => GetOrLoadParam<WeatherAssetCreateParam>("WeatherAssetCreateParam","WeatherAssetCreateParam");
		public ParamCollection<WeatherAssetReplaceParam> WeatherAssetReplaceParam => GetOrLoadParam<WeatherAssetReplaceParam>("WeatherAssetReplaceParam","WeatherAssetReplaceParam");
		public ParamCollection<WeatherLotParam> WeatherLotParam => GetOrLoadParam<WeatherLotParam>("WeatherLotParam","WeatherLotParam");
		public ParamCollection<WeatherLotTexParam> WeatherLotTexParam => GetOrLoadParam<WeatherLotTexParam>("WeatherLotTexParam","WeatherLotTexParam");
		public ParamCollection<WeatherParam> WeatherParam => GetOrLoadParam<WeatherParam>("WeatherParam","WeatherParam");
		public ParamCollection<WepAbsorpPosParam> WepAbsorpPosParam => GetOrLoadParam<WepAbsorpPosParam>("WepAbsorpPosParam","WepAbsorpPosParam");
		public ParamCollection<WetAspectParam> WetAspectParam => GetOrLoadParam<WetAspectParam>("WetAspectParam","WetAspectParam");
		public ParamCollection<WhiteSignCoolTimeParam> WhiteSignCoolTimeParam => GetOrLoadParam<WhiteSignCoolTimeParam>("WhiteSignCoolTimeParam","WhiteSignCoolTimeParam");
		public ParamCollection<WorldMapLegacyConvParam> WorldMapLegacyConvParam => GetOrLoadParam<WorldMapLegacyConvParam>("WorldMapLegacyConvParam","WorldMapLegacyConvParam");
		public ParamCollection<WorldMapPieceParam> WorldMapPieceParam => GetOrLoadParam<WorldMapPieceParam>("WorldMapPieceParam","WorldMapPieceParam");
		public ParamCollection<WorldMapPlaceNameParam> WorldMapPlaceNameParam => GetOrLoadParam<WorldMapPlaceNameParam>("WorldMapPlaceNameParam","WorldMapPlaceNameParam");
		public ParamCollection<WorldMapPointParam> WorldMapPointParam => GetOrLoadParam<WorldMapPointParam>("WorldMapPointParam","WorldMapPointParam");
		public ParamCollection<WwiseValueToStrConvertParamFormat> WwiseValueToStrParam_BgmBossChrIdConv => GetOrLoadParam<WwiseValueToStrConvertParamFormat>("WwiseValueToStrParam_BgmBossChrIdConv","WwiseValueToStrConvertParamFormat");
		public ParamCollection<WwiseValueToStrConvertParamFormat> WwiseValueToStrParam_EnvPlaceType => GetOrLoadParam<WwiseValueToStrConvertParamFormat>("WwiseValueToStrParam_EnvPlaceType","WwiseValueToStrConvertParamFormat");
		public ParamCollection<WwiseValueToStrConvertParamFormat> WwiseValueToStrParam_Switch_AttackStrength => GetOrLoadParam<WwiseValueToStrConvertParamFormat>("WwiseValueToStrParam_Switch_AttackStrength","WwiseValueToStrConvertParamFormat");
		public ParamCollection<WwiseValueToStrConvertParamFormat> WwiseValueToStrParam_Switch_AttackType => GetOrLoadParam<WwiseValueToStrConvertParamFormat>("WwiseValueToStrParam_Switch_AttackType","WwiseValueToStrConvertParamFormat");
		public ParamCollection<WwiseValueToStrConvertParamFormat> WwiseValueToStrParam_Switch_DamageAmount => GetOrLoadParam<WwiseValueToStrConvertParamFormat>("WwiseValueToStrParam_Switch_DamageAmount","WwiseValueToStrConvertParamFormat");
		public ParamCollection<WwiseValueToStrConvertParamFormat> WwiseValueToStrParam_Switch_DeffensiveMaterial => GetOrLoadParam<WwiseValueToStrConvertParamFormat>("WwiseValueToStrParam_Switch_DeffensiveMaterial","WwiseValueToStrConvertParamFormat");
		public ParamCollection<WwiseValueToStrConvertParamFormat> WwiseValueToStrParam_Switch_GrassHitType => GetOrLoadParam<WwiseValueToStrConvertParamFormat>("WwiseValueToStrParam_Switch_GrassHitType","WwiseValueToStrConvertParamFormat");
		public ParamCollection<WwiseValueToStrConvertParamFormat> WwiseValueToStrParam_Switch_HitStop => GetOrLoadParam<WwiseValueToStrConvertParamFormat>("WwiseValueToStrParam_Switch_HitStop","WwiseValueToStrConvertParamFormat");
		public ParamCollection<WwiseValueToStrConvertParamFormat> WwiseValueToStrParam_Switch_OffensiveMaterial => GetOrLoadParam<WwiseValueToStrConvertParamFormat>("WwiseValueToStrParam_Switch_OffensiveMaterial","WwiseValueToStrConvertParamFormat");
		public ParamCollection<WwiseValueToStrConvertParamFormat> WwiseValueToStrParam_Switch_PlayerEquipmentBottoms => GetOrLoadParam<WwiseValueToStrConvertParamFormat>("WwiseValueToStrParam_Switch_PlayerEquipmentBottoms","WwiseValueToStrConvertParamFormat");
		public ParamCollection<WwiseValueToStrConvertParamFormat> WwiseValueToStrParam_Switch_PlayerEquipmentTops => GetOrLoadParam<WwiseValueToStrConvertParamFormat>("WwiseValueToStrParam_Switch_PlayerEquipmentTops","WwiseValueToStrConvertParamFormat");
		public ParamCollection<WwiseValueToStrConvertParamFormat> WwiseValueToStrParam_Switch_PlayerShoes => GetOrLoadParam<WwiseValueToStrConvertParamFormat>("WwiseValueToStrParam_Switch_PlayerShoes","WwiseValueToStrConvertParamFormat");
		public ParamCollection<WwiseValueToStrConvertParamFormat> WwiseValueToStrParam_Switch_PlayerVoiceType => GetOrLoadParam<WwiseValueToStrConvertParamFormat>("WwiseValueToStrParam_Switch_PlayerVoiceType","WwiseValueToStrConvertParamFormat");
                }
            }
            
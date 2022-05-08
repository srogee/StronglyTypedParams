
            namespace StronglyTypedParams
            {
                // MENU_COMMON_PARAM_ST
                public class MenuCommonParam : ParamRow
                {
                    public MenuCommonParam() : base()
                    {
                    }
            

            // Def="f32 soloPlayDeath_ToFadeOutTime"
            /// <summary>
            /// [YOU DIED] Fade Out Duration - Host (f32)
            /// </summary>
            /// <remarks>
            /// How many seconds have passed after "YOU DIED" is displayed at the time of death of solo play to start fading out?
            /// </remarks>
            public float YOUDIEDFadeOutDurationHost 
            {
                get => (float)CellsByName["YOUDIEDFadeOutDurationHost"].Value;
                set => CellsByName["YOUDIEDFadeOutDurationHost"].Value = (float)value;
            }
            

            // Def="f32 partyGhostDeath_ToFadeOutTime"
            /// <summary>
            /// [YOU DIED] Fade Out Duration - Phnatom (f32)
            /// </summary>
            /// <remarks>
            /// How many seconds have passed after "YOU DIED" is displayed when a white or black ghost dies to start fading out?
            /// </remarks>
            public float YOUDIEDFadeOutDurationPhnatom 
            {
                get => (float)CellsByName["YOUDIEDFadeOutDurationPhnatom"].Value;
                set => CellsByName["YOUDIEDFadeOutDurationPhnatom"].Value = (float)value;
            }
            

            // Def="s32 playerMaxHpLimit"
            /// <summary>
            /// HP Bar - Visual Scale (s32)
            /// </summary>
            /// <remarks>
            /// It is used to calculate what percentage of the gauge length provided by the resource is used when displaying the HP gauge.
            /// </remarks>
            public int HPBarVisualScale 
            {
                get => (int)CellsByName["HPBarVisualScale"].Value;
                set => CellsByName["HPBarVisualScale"].Value = (int)value;
            }
            

            // Def="s32 playerMaxMpLimit"
            /// <summary>
            /// FP Bar - Visual Scale (s32)
            /// </summary>
            /// <remarks>
            /// It is used to calculate what percentage of the gauge length provided by the resource is used when displaying the MP gauge.
            /// </remarks>
            public int FPBarVisualScale 
            {
                get => (int)CellsByName["FPBarVisualScale"].Value;
                set => CellsByName["FPBarVisualScale"].Value = (int)value;
            }
            

            // Def="s32 playerMaxSpLimit"
            /// <summary>
            /// Stamina Bar - Visual Scale (s32)
            /// </summary>
            /// <remarks>
            /// It is used to calculate what percentage of the gauge length provided by the resource is used when displaying the SP gauge.
            /// </remarks>
            public int StaminaBarVisualScale 
            {
                get => (int)CellsByName["StaminaBarVisualScale"].Value;
                set => CellsByName["StaminaBarVisualScale"].Value = (int)value;
            }
            

            // Def="f32 actionPanelChangeThreshold_Vel"
            /// <summary>
            /// Action Panel Change Threshold - Velocity (f32)
            /// </summary>
            /// <remarks>
            /// Action panel Switchable player speed. Switchable if below this speed
            /// </remarks>
            public float ActionPanelChangeThresholdVelocity 
            {
                get => (float)CellsByName["ActionPanelChangeThresholdVelocity"].Value;
                set => CellsByName["ActionPanelChangeThresholdVelocity"].Value = (float)value;
            }
            

            // Def="f32 actionPanelChangeThreshold_PassTime"
            /// <summary>
            /// Action Panel Change Threshold - Pass Time (f32)
            /// </summary>
            /// <remarks>
            /// Action panel Consideration time to increase the speed of switchable players. Use the average speed of this time (systematically up to 4 seconds)
            /// </remarks>
            public float ActionPanelChangeThresholdPassTime 
            {
                get => (float)CellsByName["ActionPanelChangeThresholdPassTime"].Value;
                set => CellsByName["ActionPanelChangeThresholdPassTime"].Value = (float)value;
            }
            

            // Def="s32 kgIconVspace"
            /// <summary>
            /// Vertical Position of Key Guide Icon (s32)
            /// </summary>
            /// <remarks>
            /// Vertical position of key guide icon (+: top,-: bottom)
            /// </remarks>
            public int VerticalPositionOfKeyGuideIcon 
            {
                get => (int)CellsByName["VerticalPositionOfKeyGuideIcon"].Value;
                set => CellsByName["VerticalPositionOfKeyGuideIcon"].Value = (int)value;
            }
            

            // Def="f32 worldMapCursorSelectRadius = 0.1"
            /// <summary>
            /// World Map - Cursor Select Radius (f32)
            /// </summary>
            /// <remarks>
            /// If the cursor position is within this radius, it means that it is selected.
            /// </remarks>
            public float WorldMapCursorSelectRadius 
            {
                get => (float)CellsByName["WorldMapCursorSelectRadius"].Value;
                set => CellsByName["WorldMapCursorSelectRadius"].Value = (float)value;
            }
            

            // Def="dummy8 reserved8[4]"
            /// <summary>
            /// reserve (dummy8)
            /// </summary>
            /// <remarks>
            /// (dummy8)
            /// </remarks>
            public object Reserve 
            {
                get => (object)CellsByName["Reserve"].Value;
                set => CellsByName["Reserve"].Value = (object)value;
            }
            

            // Def="s32 decalPosOffsetX"
            /// <summary>
            /// Decal Position Offset: X (s32)
            /// </summary>
            /// <remarks>
            /// Decal display position offset left and right
            /// </remarks>
            public int DecalPositionOffsetX 
            {
                get => (int)CellsByName["DecalPositionOffsetX"].Value;
                set => CellsByName["DecalPositionOffsetX"].Value = (int)value;
            }
            

            // Def="s32 decalPosOffsetY"
            /// <summary>
            /// Decal Position Offset: Y (s32)
            /// </summary>
            /// <remarks>
            /// Decal display position offset vertical direction
            /// </remarks>
            public int DecalPositionOffsetY 
            {
                get => (int)CellsByName["DecalPositionOffsetY"].Value;
                set => CellsByName["DecalPositionOffsetY"].Value = (int)value;
            }
            

            // Def="f32 targetStateSearchDurationTime"
            /// <summary>
            /// FE Search Icon Fade Time (f32)
            /// </summary>
            /// <remarks>
            /// The number of seconds it takes for the FE Search icon to start fading in and then fading out.
            /// </remarks>
            public float FESearchIconFadeTime 
            {
                get => (float)CellsByName["FESearchIconFadeTime"].Value;
                set => CellsByName["FESearchIconFadeTime"].Value = (float)value;
            }
            

            // Def="f32 targetStateBattleDurationTime"
            /// <summary>
            /// FE Battle Icon Fade Time (f32)
            /// </summary>
            /// <remarks>
            /// The number of seconds it takes for the FE Battle icon to start fading in and then fading out.
            /// </remarks>
            public float FEBattleIconFadeTime 
            {
                get => (float)CellsByName["FEBattleIconFadeTime"].Value;
                set => CellsByName["FEBattleIconFadeTime"].Value = (float)value;
            }
            

            // Def="f32 worldMapCursorSpeed = 1"
            /// <summary>
            /// World Map - Cursor Speed (f32)
            /// </summary>
            /// <remarks>
            /// Movement speed when moving smoothly [px]
            /// </remarks>
            public float WorldMapCursorSpeed 
            {
                get => (float)CellsByName["WorldMapCursorSpeed"].Value;
                set => CellsByName["WorldMapCursorSpeed"].Value = (float)value;
            }
            

            // Def="f32 worldMapCursorFirstDistance = 1"
            /// <summary>
            /// World Map - Cursor First Distance (f32)
            /// </summary>
            /// <remarks>
            /// Distance to move only once at the first input [px]
            /// </remarks>
            public float WorldMapCursorFirstDistance 
            {
                get => (float)CellsByName["WorldMapCursorFirstDistance"].Value;
                set => CellsByName["WorldMapCursorFirstDistance"].Value = (float)value;
            }
            

            // Def="f32 worldMapCursorFirstDelay = 0.01"
            /// <summary>
            /// World Map - Cursor First Delay (f32)
            /// </summary>
            /// <remarks>
            /// The time it takes to move only once at the first input [sec]
            /// </remarks>
            public float WorldMapCursorFirstDelay 
            {
                get => (float)CellsByName["WorldMapCursorFirstDelay"].Value;
                set => CellsByName["WorldMapCursorFirstDelay"].Value = (float)value;
            }
            

            // Def="f32 worldMapCursorWaitTime"
            /// <summary>
            /// World Map - Cursor Wait Time (f32)
            /// </summary>
            /// <remarks>
            /// Waiting time from input to smooth movement [sec]
            /// </remarks>
            public float WorldMapCursorWaitTime 
            {
                get => (float)CellsByName["WorldMapCursorWaitTime"].Value;
                set => CellsByName["WorldMapCursorWaitTime"].Value = (float)value;
            }
            

            // Def="f32 worldMapCursorSnapRadius = 0.1"
            /// <summary>
            /// World Map - Cursor Snap Radius (f32)
            /// </summary>
            /// <remarks>
            /// Move the cursor closer than this radius to start adsorption (for snap mode) [px]
            /// </remarks>
            public float WorldMapCursorSnapRadius 
            {
                get => (float)CellsByName["WorldMapCursorSnapRadius"].Value;
                set => CellsByName["WorldMapCursorSnapRadius"].Value = (float)value;
            }
            

            // Def="f32 worldMapCursorSnapTime = 0.01"
            /// <summary>
            /// World Map - Cursor Snap Time (f32)
            /// </summary>
            /// <remarks>
            /// The time it takes to start and complete adsorption [sec]
            /// </remarks>
            public float WorldMapCursorSnapTime 
            {
                get => (float)CellsByName["WorldMapCursorSnapTime"].Value;
                set => CellsByName["WorldMapCursorSnapTime"].Value = (float)value;
            }
            

            // Def="f32 itemGetLogAliveTime = 0.01"
            /// <summary>
            /// Item Get Log Alive Time (f32)
            /// </summary>
            /// <remarks>
            /// Time to add one line of log and fade out. There is a timer for each line [sec]
            /// </remarks>
            public float ItemGetLogAliveTime 
            {
                get => (float)CellsByName["ItemGetLogAliveTime"].Value;
                set => CellsByName["ItemGetLogAliveTime"].Value = (float)value;
            }
            

            // Def="s32 playerMaxSaLimit"
            /// <summary>
            /// Player Max Poise Guage Length (s32)
            /// </summary>
            /// <remarks>
            /// It is used to calculate what percentage of the gauge length provided by the resource is used when displaying the SA gauge.
            /// </remarks>
            public int PlayerMaxPoiseGuageLength 
            {
                get => (int)CellsByName["PlayerMaxPoiseGuageLength"].Value;
                set => CellsByName["PlayerMaxPoiseGuageLength"].Value = (int)value;
            }
            

            // Def="u32 worldMap_IsChangeableLayerEventFlagId"
            /// <summary>
            /// World Map - Underground Layer Event Flag ID (u32)
            /// </summary>
            /// <remarks>
            /// Specify the event flag ID that manages whether it is possible to switch to the underground map. When this event flag ID is ON, it is possible to switch to the underground map.
            /// </remarks>
            public uint WorldMapUndergroundLayerEventFlagID 
            {
                get => (uint)CellsByName["WorldMapUndergroundLayerEventFlagID"].Value;
                set => CellsByName["WorldMapUndergroundLayerEventFlagID"].Value = (uint)value;
            }
            

            // Def="f32 worldMap_TravelMargin"
            /// <summary>
            /// World Map - Travel Margin (f32)
            /// </summary>
            /// <remarks>
            /// Distance (m) that extends in four directions around the player. I decided to break through this range
            /// </remarks>
            public float WorldMapTravelMargin 
            {
                get => (float)CellsByName["WorldMapTravelMargin"].Value;
                set => CellsByName["WorldMapTravelMargin"].Value = (float)value;
            }
            

            // Def="f32 systemAnnounceScrollBufferTime"
            /// <summary>
            /// System Announcement - Scroll Buffer Time (f32)
            /// </summary>
            /// <remarks>
            /// The number of seconds to wait before and after scrolling through the long text of the operation announcement. For example, if it is 3 seconds, wait for a total of 6 seconds before and after.
            /// </remarks>
            public float SystemAnnouncementScrollBufferTime 
            {
                get => (float)CellsByName["SystemAnnouncementScrollBufferTime"].Value;
                set => CellsByName["SystemAnnouncementScrollBufferTime"].Value = (float)value;
            }
            

            // Def="s32 systemAnnounceScrollSpeed = 100"
            /// <summary>
            /// System Announcement - Scroll Speed (s32)
            /// </summary>
            /// <remarks>
            /// Scrolling speed (pixels / second) when scrolling long sentences in the operation announcement. It does not depend on the screen size. Think of the entire menu as 1920x1080
            /// </remarks>
            public int SystemAnnouncementScrollSpeed 
            {
                get => (int)CellsByName["SystemAnnouncementScrollSpeed"].Value;
                set => CellsByName["SystemAnnouncementScrollSpeed"].Value = (int)value;
            }
            

            // Def="f32 systemAnnounceNoScrollWaitTime"
            /// <summary>
            /// System Announcement - No Scroll Wait Time (f32)
            /// </summary>
            /// <remarks>
            /// The number of seconds to display when it is a short sentence that does not require scrolling of the operation announcement
            /// </remarks>
            public float SystemAnnouncementNoScrollWaitTime 
            {
                get => (float)CellsByName["SystemAnnouncementNoScrollWaitTime"].Value;
                set => CellsByName["SystemAnnouncementNoScrollWaitTime"].Value = (float)value;
            }
            

            // Def="u8 systemAnnounceScrollCount = 1"
            /// <summary>
            /// System Announcement - Scroll Count (u8)
            /// </summary>
            /// <remarks>
            /// Number of times to repeat when scrolling long sentences of management announcement
            /// </remarks>
            public byte SystemAnnouncementScrollCount 
            {
                get => (byte)CellsByName["SystemAnnouncementScrollCount"].Value;
                set => CellsByName["SystemAnnouncementScrollCount"].Value = (byte)value;
            }
            


            // Def="f32 compassMemoDispDistance = 50"
            /// <summary>
            /// Compass Memo Display Distance (f32)
            /// </summary>
            /// <remarks>
            /// Display distance [m] of the memo marker displayed on the compass. Anything closer than this distance will be displayed
            /// </remarks>
            public float CompassMemoDisplayDistance 
            {
                get => (float)CellsByName["CompassMemoDisplayDistance"].Value;
                set => CellsByName["CompassMemoDisplayDistance"].Value = (float)value;
            }
            

            // Def="f32 compassBonfireDispDistance = 50"
            /// <summary>
            /// Compass Bonfire Display Distance (f32)
            /// </summary>
            /// <remarks>
            /// The display distance of the bonfire displayed on the compass [m]. Anything closer than this distance will be displayed
            /// </remarks>
            public float CompassBonfireDisplayDistance 
            {
                get => (float)CellsByName["CompassBonfireDisplayDistance"].Value;
                set => CellsByName["CompassBonfireDisplayDistance"].Value = (float)value;
            }
            

            // Def="f32 markerGoalThreshold"
            /// <summary>
            /// Destination Marrker Threshold (f32)
            /// </summary>
            /// <remarks>
            /// Goal judgment distance [m] of the destination marker. The destination marker disappears when you get closer than this distance
            /// </remarks>
            public float DestinationMarrkerThreshold 
            {
                get => (float)CellsByName["DestinationMarrkerThreshold"].Value;
                set => CellsByName["DestinationMarrkerThreshold"].Value = (float)value;
            }
            

            // Def="f32 svSliderStep = 10"
            /// <summary>
            /// Saturation/Brightness Slider Step (f32)
            /// </summary>
            /// <remarks>
            /// Amount of movement of the saturation / brightness slider of the color control [% / sec]. Maximum amount to move in 1 second when each value is 0% to 100%. Since it is operated with an analog stick, it becomes a ratio by the input value.
            /// </remarks>
            public float SaturationBrightnessSliderStep 
            {
                get => (float)CellsByName["SaturationBrightnessSliderStep"].Value;
                set => CellsByName["SaturationBrightnessSliderStep"].Value = (float)value;
            }
            

            // Def="f32 preOpeningMovie_WaitSec"
            /// <summary>
            /// Pre-opening Movie - Wait Time (f32)
            /// </summary>
            /// <remarks>
            /// Wait time before playing the OP movie. > SEQ 15261
            /// </remarks>
            public float PreOpeningMovieWaitTime 
            {
                get => (float)CellsByName["PreOpeningMovieWaitTime"].Value;
                set => CellsByName["PreOpeningMovieWaitTime"].Value = (float)value;
            }
            

            // Def="f32 kgIconScale = 100"
            /// <summary>
            /// Key Guide Icon - Scale (f32)
            /// </summary>
            /// <remarks>
            /// The scale value of the key guide icon. 100% is the texture size as it is
            /// </remarks>
            public float KeyGuideIconScale 
            {
                get => (float)CellsByName["KeyGuideIconScale"].Value;
                set => CellsByName["KeyGuideIconScale"].Value = (float)value;
            }
            

            // Def="f32 kgIconScale_forTable = 100"
            /// <summary>
            /// Key Guide Icon for Table - Scale (f32)
            /// </summary>
            /// <remarks>
            /// Scale value of the key guide icon for the pad operation list. 100% is the texture size as it is
            /// </remarks>
            public float KeyGuideIconForTableScale 
            {
                get => (float)CellsByName["KeyGuideIconForTableScale"].Value;
                set => CellsByName["KeyGuideIconForTableScale"].Value = (float)value;
            }
            

            // Def="s32 kgIconVspace_forTable"
            /// <summary>
            /// Key Guide Icon for Table - Vertical Position (s32)
            /// </summary>
            /// <remarks>
            /// Vertical position of the key guide icon for the pad operation list (+: top,-: bottom)
            /// </remarks>
            public int KeyGuideIconForTableVerticalPosition 
            {
                get => (int)CellsByName["KeyGuideIconForTableVerticalPosition"].Value;
                set => CellsByName["KeyGuideIconForTableVerticalPosition"].Value = (int)value;
            }
            

            // Def="f32 kgIconScale_forConfig = 100"
            /// <summary>
            /// Key Guide Icon for Key Config - Scale (f32)
            /// </summary>
            /// <remarks>
            /// The scale value of the key guide icon for the key config. 100% is the texture size as it is
            /// </remarks>
            public float KeyGuideIconForKeyConfigScale 
            {
                get => (float)CellsByName["KeyGuideIconForKeyConfigScale"].Value;
                set => CellsByName["KeyGuideIconForKeyConfigScale"].Value = (float)value;
            }
            

            // Def="s32 kgIconVspace_forConfig"
            /// <summary>
            /// Key Guide Icon for Key Config - Vertical Position (s32)
            /// </summary>
            /// <remarks>
            /// Vertical position of key guide icon for key config (+: top,-: bottom)
            /// </remarks>
            public int KeyGuideIconForKeyConfigVerticalPosition 
            {
                get => (int)CellsByName["KeyGuideIconForKeyConfigVerticalPosition"].Value;
                set => CellsByName["KeyGuideIconForKeyConfigVerticalPosition"].Value = (int)value;
            }
            

            // Def="f32 worldMap_SearchRadius = 256"
            /// <summary>
            /// World Map Search Radius (f32)
            /// </summary>
            /// <remarks>
            /// Range [m] (radius) that makes unsearched masks searched. It is assumed that the circle centered on the player has been searched.
            /// </remarks>
            public float WorldMapSearchRadius 
            {
                get => (float)CellsByName["WorldMapSearchRadius"].Value;
                set => CellsByName["WorldMapSearchRadius"].Value = (float)value;
            }
            

            // Def="f32 tutorialDisplayTime = 3"
            /// <summary>
            /// Tutorial Display Time (f32)
            /// </summary>
            /// <remarks>
            /// Tutorial (toast notification) display time [sec]. It will be closed automatically after this time has passed
            /// </remarks>
            public float TutorialDisplayTime 
            {
                get => (float)CellsByName["TutorialDisplayTime"].Value;
                set => CellsByName["TutorialDisplayTime"].Value = (float)value;
            }
            

            // Def="f32 compassFriendHostInnerDistance"
            /// <summary>
            /// Compass Friendly Phantom Display Distance (f32)
            /// </summary>
            /// <remarks>
            /// Display distance [m] of other players (friendly hosts) to be displayed on the compass. If you are more than this distance, it will be displayed on the compass.
            /// </remarks>
            public float CompassFriendlyPhantomDisplayDistance 
            {
                get => (float)CellsByName["CompassFriendlyPhantomDisplayDistance"].Value;
                set => CellsByName["CompassFriendlyPhantomDisplayDistance"].Value = (float)value;
            }
            

            // Def="f32 compassEnemyHostInnerDistance"
            /// <summary>
            /// Compass Hostile Phantom Display Distance (f32)
            /// </summary>
            /// <remarks>
            /// Display distance [m] of other players (enemy hosts) displayed on the compass. If you are more than this distance, it will be displayed on the compass.
            /// </remarks>
            public float CompassHostilePhantomDisplayDistance 
            {
                get => (float)CellsByName["CompassHostilePhantomDisplayDistance"].Value;
                set => CellsByName["CompassHostilePhantomDisplayDistance"].Value = (float)value;
            }
            

            // Def="f32 compassFriendGuestInnerDistance"
            /// <summary>
            /// Compass Guest Phantom Display Distance (f32)
            /// </summary>
            /// <remarks>
            /// Display distance [m] of other players (friendly guests) to be displayed on the compass. If you are more than this distance, it will be displayed on the compass.
            /// </remarks>
            public float CompassGuestPhantomDisplayDistance 
            {
                get => (float)CellsByName["CompassGuestPhantomDisplayDistance"].Value;
                set => CellsByName["CompassGuestPhantomDisplayDistance"].Value = (float)value;
            }
            

            // Def="f32 cutsceneKeyGuideAliveTime = 5"
            /// <summary>
            /// Cutscene Key Guide - Display Time (f32)
            /// </summary>
            /// <remarks>
            /// The amount of time that the key guide will continue to be displayed after the cutscene skip has been pre-entered. Since skip input is accepted only while the key guide is displayed, it can be said that it is the skip input acceptance time.
            /// </remarks>
            public float CutsceneKeyGuideDisplayTime 
            {
                get => (float)CellsByName["CutsceneKeyGuideDisplayTime"].Value;
                set => CellsByName["CutsceneKeyGuideDisplayTime"].Value = (float)value;
            }
            

            // Def="f32 autoHideHpThresholdRatio = -1"
            /// <summary>
            /// Auto HUD: HP Ratio to display HUD (f32)
            /// </summary>
            /// <remarks>
            /// [HUD: Auto setting] HP ratio. If the HP ratio is below this value, the HP gauge will always be displayed. Percentage and current value are OR conditions (displayed if either is satisfied)
            /// </remarks>
            public float AutoHUDHPRatioToDisplayHUD 
            {
                get => (float)CellsByName["AutoHUDHPRatioToDisplayHUD"].Value;
                set => CellsByName["AutoHUDHPRatioToDisplayHUD"].Value = (float)value;
            }
            

            // Def="s32 autoHideHpThresholdValue = -1"
            /// <summary>
            /// Auto HUD: Display HUD when below X HP (s32)
            /// </summary>
            /// <remarks>
            /// [HUD: Auto setting] HP current value. If the current HP value is less than or equal to this value, the HP gauge will always be displayed. Percentage and current value are OR conditions (displayed if either is satisfied)
            /// </remarks>
            public int AutoHUDDisplayHUDWhenBelowXHP 
            {
                get => (int)CellsByName["AutoHUDDisplayHUDWhenBelowXHP"].Value;
                set => CellsByName["AutoHUDDisplayHUDWhenBelowXHP"].Value = (int)value;
            }
            

            // Def="f32 autoHideMpThresholdRatio = -1"
            /// <summary>
            /// Auto HUD: FP Ratio to display HUD (f32)
            /// </summary>
            /// <remarks>
            /// [HUD: Auto setting] MP ratio. If the MP ratio is below this value, the MP gauge is always displayed. Percentage and current value are OR conditions (displayed if either is satisfied)
            /// </remarks>
            public float AutoHUDFPRatioToDisplayHUD 
            {
                get => (float)CellsByName["AutoHUDFPRatioToDisplayHUD"].Value;
                set => CellsByName["AutoHUDFPRatioToDisplayHUD"].Value = (float)value;
            }
            

            // Def="s32 autoHideMpThresholdValue = -1"
            /// <summary>
            /// Auto HUD: Display HUD when below X FP (s32)
            /// </summary>
            /// <remarks>
            /// [HUD: Auto setting] MP current value. If the current MP value is less than or equal to this value, the MP gauge is always displayed. Percentage and current value are OR conditions (displayed if either is satisfied)
            /// </remarks>
            public int AutoHUDDisplayHUDWhenBelowXFP 
            {
                get => (int)CellsByName["AutoHUDDisplayHUDWhenBelowXFP"].Value;
                set => CellsByName["AutoHUDDisplayHUDWhenBelowXFP"].Value = (int)value;
            }
            

            // Def="f32 autoHideSpThresholdRatio = -1"
            /// <summary>
            /// Auto HUD: Stamina Ratio to display HUD (f32)
            /// </summary>
            /// <remarks>
            /// [HUD: Auto setting] SP ratio. If the SP ratio is less than or equal to this value, the SP gauge is always displayed. Percentage and current value are OR conditions (displayed if either is satisfied)
            /// </remarks>
            public float AutoHUDStaminaRatioToDisplayHUD 
            {
                get => (float)CellsByName["AutoHUDStaminaRatioToDisplayHUD"].Value;
                set => CellsByName["AutoHUDStaminaRatioToDisplayHUD"].Value = (float)value;
            }
            

            // Def="s32 autoHideSpThresholdValue = -1"
            /// <summary>
            /// Auto HUD: Display HUD when below X Stamina (s32)
            /// </summary>
            /// <remarks>
            /// [HUD: Auto setting] SP current value. If the current SP value is less than or equal to this value, the SP gauge is always displayed. Percentage and current value are OR conditions (displayed if either is satisfied)
            /// </remarks>
            public int AutoHUDDisplayHUDWhenBelowXStamina 
            {
                get => (int)CellsByName["AutoHUDDisplayHUDWhenBelowXStamina"].Value;
                set => CellsByName["AutoHUDDisplayHUDWhenBelowXStamina"].Value = (int)value;
            }
            

            // Def="f32 worldMapZoomAnimationTime = 0.5"
            /// <summary>
            /// World Map Zoom Animation Time (f32)
            /// </summary>
            /// <remarks>
            /// World map: Time to zoom animation [seconds]
            /// </remarks>
            public float WorldMapZoomAnimationTime 
            {
                get => (float)CellsByName["WorldMapZoomAnimationTime"].Value;
                set => CellsByName["WorldMapZoomAnimationTime"].Value = (float)value;
            }
            

            // Def="f32 worldMapIconScaleMin = 1"
            /// <summary>
            /// World Map Icon Minimum Scale (f32)
            /// </summary>
            /// <remarks>
            /// World map: Display magnification of the map point icon at zoom step 0 (0.0 to 1.0). 1x (1.0) at zoom step 2. From there, the icon magnification is also interpolated according to the enlargement ratio.
            /// </remarks>
            public float WorldMapIconMinimumScale 
            {
                get => (float)CellsByName["WorldMapIconMinimumScale"].Value;
                set => CellsByName["WorldMapIconMinimumScale"].Value = (float)value;
            }
            

            // Def="f32 worldMap_TravelMargin_Point"
            /// <summary>
            /// World Map - Travel Margin Point (f32)
            /// </summary>
            /// <remarks>
            /// World map: Additional ban distance [m] when the ban is lifted in map point units. When the ban on map points such as the distant view stand is lifted, the ban on the traversal range will be lifted. Distance to be additionally extended in 4 directions around the map point
            /// </remarks>
            public float WorldMapTravelMarginPoint 
            {
                get => (float)CellsByName["WorldMapTravelMarginPoint"].Value;
                set => CellsByName["WorldMapTravelMarginPoint"].Value = (float)value;
            }
            

            // Def="u16 enemyTagSafeLeft"
            /// <summary>
            /// Enemy HP Guage - Max Left Justification (u16)
            /// </summary>
            /// <remarks>
            /// How far can the center coordinates of the enemy HP gauge go to the left end? Since it is the center coordinate, the size of the gauge body is included.
            /// </remarks>
            public ushort EnemyHPGuageMaxLeftJustification 
            {
                get => (ushort)CellsByName["EnemyHPGuageMaxLeftJustification"].Value;
                set => CellsByName["EnemyHPGuageMaxLeftJustification"].Value = (ushort)value;
            }
            

            // Def="u16 enemyTagSafeRight = 1920"
            /// <summary>
            /// Enemy HP Guage - Max Right Justification (u16)
            /// </summary>
            /// <remarks>
            /// How far can the center coordinates of the enemy HP gauge go to the right end? Since it is the center coordinate, the size of the gauge body is included.
            /// </remarks>
            public ushort EnemyHPGuageMaxRightJustification 
            {
                get => (ushort)CellsByName["EnemyHPGuageMaxRightJustification"].Value;
                set => CellsByName["EnemyHPGuageMaxRightJustification"].Value = (ushort)value;
            }
            

            // Def="u16 enemyTagSafeTop"
            /// <summary>
            /// Enemy HP Guage - Max Top Justification (u16)
            /// </summary>
            /// <remarks>
            /// How far can the center coordinates of the enemy HP gauge go to the upper end? Since it is the center coordinate, the size of the gauge body is included.
            /// </remarks>
            public ushort EnemyHPGuageMaxTopJustification 
            {
                get => (ushort)CellsByName["EnemyHPGuageMaxTopJustification"].Value;
                set => CellsByName["EnemyHPGuageMaxTopJustification"].Value = (ushort)value;
            }
            

            // Def="u16 enemyTagSafeBottom = 1080"
            /// <summary>
            /// Enemy HP Guage - Max Bottom Justification (u16)
            /// </summary>
            /// <remarks>
            /// How far can the center coordinates of the enemy HP gauge go to the lower end? Since it is the center coordinate, the size of the gauge body is included.
            /// </remarks>
            public ushort EnemyHPGuageMaxBottomJustification 
            {
                get => (ushort)CellsByName["EnemyHPGuageMaxBottomJustification"].Value;
                set => CellsByName["EnemyHPGuageMaxBottomJustification"].Value = (ushort)value;
            }
            

            // Def="u32 pcHorseHpRecoverDispThreshold"
            /// <summary>
            /// HP Threshold to display Horse HP (u32)
            /// </summary>
            /// <remarks>
            /// Threshold for displaying the PC horse HP gauge at the time of recovery. "Constant value" of "Display HP bar when it increases more than a certain value at a time"
            /// </remarks>
            public uint HPThresholdToDisplayHorseHP 
            {
                get => (uint)CellsByName["HPThresholdToDisplayHorseHP"].Value;
                set => CellsByName["HPThresholdToDisplayHorseHP"].Value = (uint)value;
            }
            

                }
            }
            
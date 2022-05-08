
            namespace StronglyTypedParams
            {
                // KNOCKBACK_PARAM_ST
                public class KnockBackParam : ParamRow
                {
                    public KnockBackParam() : base()
                    {
                    }
            

            // Def="f32 damage_Min_ContTime"
            /// <summary>
            /// Damage Level: Minimum - Maintenance Time (f32)
            /// </summary>
            /// <remarks>
            /// Set the maintenance time used for tiny damage animation
            /// </remarks>
            public float DamageLevelMinimumMaintenanceTime 
            {
                get => (float)CellsByName["DamageLevelMinimumMaintenanceTime"].Value;
                set => CellsByName["DamageLevelMinimumMaintenanceTime"].Value = (float)value;
            }
            

            // Def="f32 damage_S_ContTime"
            /// <summary>
            /// Damage Level: Small - Maintenance Time (f32)
            /// </summary>
            /// <remarks>
            /// Set the maintenance time used for small damage animation
            /// </remarks>
            public float DamageLevelSmallMaintenanceTime 
            {
                get => (float)CellsByName["DamageLevelSmallMaintenanceTime"].Value;
                set => CellsByName["DamageLevelSmallMaintenanceTime"].Value = (float)value;
            }
            

            // Def="f32 damage_M_ContTime"
            /// <summary>
            /// Damage Level: Medium - Maintenance Time (f32)
            /// </summary>
            /// <remarks>
            /// Set the maintenance time used for medium damage animation
            /// </remarks>
            public float DamageLevelMediumMaintenanceTime 
            {
                get => (float)CellsByName["DamageLevelMediumMaintenanceTime"].Value;
                set => CellsByName["DamageLevelMediumMaintenanceTime"].Value = (float)value;
            }
            

            // Def="f32 damage_L_ContTime"
            /// <summary>
            /// Damage Level: Heavy - Maintenance Time (f32)
            /// </summary>
            /// <remarks>
            /// Set the maintenance time used for heavy damage animation
            /// </remarks>
            public float DamageLevelHeavyMaintenanceTime 
            {
                get => (float)CellsByName["DamageLevelHeavyMaintenanceTime"].Value;
                set => CellsByName["DamageLevelHeavyMaintenanceTime"].Value = (float)value;
            }
            

            // Def="f32 damage_BlowS_ContTime"
            /// <summary>
            /// Damage Level: Small Blow-off - Maintenance Time (f32)
            /// </summary>
            /// <remarks>
            /// Set the maintenance time used for small blow-off damage animation
            /// </remarks>
            public float DamageLevelSmallBlowOffMaintenanceTime 
            {
                get => (float)CellsByName["DamageLevelSmallBlowOffMaintenanceTime"].Value;
                set => CellsByName["DamageLevelSmallBlowOffMaintenanceTime"].Value = (float)value;
            }
            

            // Def="f32 damage_BlowM_ContTime"
            /// <summary>
            /// Damage Level: Heavy Blow-off - Maintenance Time (f32)
            /// </summary>
            /// <remarks>
            /// Set the maintenance time used during the big blow damage animation
            /// </remarks>
            public float DamageLevelHeavyBlowOffMaintenanceTime 
            {
                get => (float)CellsByName["DamageLevelHeavyBlowOffMaintenanceTime"].Value;
                set => CellsByName["DamageLevelHeavyBlowOffMaintenanceTime"].Value = (float)value;
            }
            

            // Def="f32 damage_Strike_ContTime"
            /// <summary>
            /// Damage Level: Strike - Maintenance Time (f32)
            /// </summary>
            /// <remarks>
            /// Set the maintenance time used for slamming damage animation
            /// </remarks>
            public float DamageLevelStrikeMaintenanceTime 
            {
                get => (float)CellsByName["DamageLevelStrikeMaintenanceTime"].Value;
                set => CellsByName["DamageLevelStrikeMaintenanceTime"].Value = (float)value;
            }
            

            // Def="f32 damage_Uppercut_ContTime"
            /// <summary>
            /// Damage Level: Uppercut - Maintenance Time (f32)
            /// </summary>
            /// <remarks>
            /// Set the maintenance time used for launch damage animation
            /// </remarks>
            public float DamageLevelUppercutMaintenanceTime 
            {
                get => (float)CellsByName["DamageLevelUppercutMaintenanceTime"].Value;
                set => CellsByName["DamageLevelUppercutMaintenanceTime"].Value = (float)value;
            }
            

            // Def="f32 damage_Push_ContTime"
            /// <summary>
            /// Damage Level: Push - Maintenance Time (f32)
            /// </summary>
            /// <remarks>
            /// Set the maintenance time used for push damage animation
            /// </remarks>
            public float DamageLevelPushMaintenanceTime 
            {
                get => (float)CellsByName["DamageLevelPushMaintenanceTime"].Value;
                set => CellsByName["DamageLevelPushMaintenanceTime"].Value = (float)value;
            }
            

            // Def="f32 damage_Breath_ContTime"
            /// <summary>
            /// Damage Level: Breath - Maintenance Time (f32)
            /// </summary>
            /// <remarks>
            /// Set the maintenance time used for breath damage animation
            /// </remarks>
            public float DamageLevelBreathMaintenanceTime 
            {
                get => (float)CellsByName["DamageLevelBreathMaintenanceTime"].Value;
                set => CellsByName["DamageLevelBreathMaintenanceTime"].Value = (float)value;
            }
            

            // Def="f32 damage_HeadShot_ContTime"
            /// <summary>
            /// Damage Level: Headshot - Maintenance Time (f32)
            /// </summary>
            /// <remarks>
            /// Headshot damage Set the maintenance time used during animation
            /// </remarks>
            public float DamageLevelHeadshotMaintenanceTime 
            {
                get => (float)CellsByName["DamageLevelHeadshotMaintenanceTime"].Value;
                set => CellsByName["DamageLevelHeadshotMaintenanceTime"].Value = (float)value;
            }
            

            // Def="f32 guard_S_ContTime"
            /// <summary>
            /// Guard Damage Level: Small - Maintenance Time (f32)
            /// </summary>
            /// <remarks>
            /// Set the maintenance time used for guard receiving small animation
            /// </remarks>
            public float GuardDamageLevelSmallMaintenanceTime 
            {
                get => (float)CellsByName["GuardDamageLevelSmallMaintenanceTime"].Value;
                set => CellsByName["GuardDamageLevelSmallMaintenanceTime"].Value = (float)value;
            }
            

            // Def="f32 guard_L_ContTime"
            /// <summary>
            /// Guard Damage Level: Heavy - Maintenance Time (f32)
            /// </summary>
            /// <remarks>
            /// Set the maintenance time used at the time of guard receiving large animation
            /// </remarks>
            public float GuardDamageLevelHeavyMaintenanceTime 
            {
                get => (float)CellsByName["GuardDamageLevelHeavyMaintenanceTime"].Value;
                set => CellsByName["GuardDamageLevelHeavyMaintenanceTime"].Value = (float)value;
            }
            

            // Def="f32 guard_LL_ContTime"
            /// <summary>
            /// Guard Damage Level: Very Heavy - Maintenance Time (f32)
            /// </summary>
            /// <remarks>
            /// Set the maintenance time used for guard receiving oversized animation
            /// </remarks>
            public float GuardDamageLevelVeryHeavyMaintenanceTime 
            {
                get => (float)CellsByName["GuardDamageLevelVeryHeavyMaintenanceTime"].Value;
                set => CellsByName["GuardDamageLevelVeryHeavyMaintenanceTime"].Value = (float)value;
            }
            

            // Def="f32 guardBrake_ContTime"
            /// <summary>
            /// Guard Damage Level: Break - Maintenance Time (f32)
            /// </summary>
            /// <remarks>
            /// Set the maintenance time specified at the time of guard scraping animation
            /// </remarks>
            public float GuardDamageLevelBreakMaintenanceTime 
            {
                get => (float)CellsByName["GuardDamageLevelBreakMaintenanceTime"].Value;
                set => CellsByName["GuardDamageLevelBreakMaintenanceTime"].Value = (float)value;
            }
            

            // Def="f32 damage_Min_DecTime"
            /// <summary>
            /// Damage Level: Minimum - Deceleration Time (f32)
            /// </summary>
            /// <remarks>
            /// Set the deceleration time used for minimal damage animation
            /// </remarks>
            public float DamageLevelMinimumDecelerationTime 
            {
                get => (float)CellsByName["DamageLevelMinimumDecelerationTime"].Value;
                set => CellsByName["DamageLevelMinimumDecelerationTime"].Value = (float)value;
            }
            

            // Def="f32 damage_S_DecTime"
            /// <summary>
            /// Damage Level: Small - Deceleration Time (f32)
            /// </summary>
            /// <remarks>
            /// Set the deceleration time used for small damage animation
            /// </remarks>
            public float DamageLevelSmallDecelerationTime 
            {
                get => (float)CellsByName["DamageLevelSmallDecelerationTime"].Value;
                set => CellsByName["DamageLevelSmallDecelerationTime"].Value = (float)value;
            }
            

            // Def="f32 damage_M_DecTime"
            /// <summary>
            /// Damage Level: Medium - Deceleration Time (f32)
            /// </summary>
            /// <remarks>
            /// Set the deceleration time used for medium damage animation
            /// </remarks>
            public float DamageLevelMediumDecelerationTime 
            {
                get => (float)CellsByName["DamageLevelMediumDecelerationTime"].Value;
                set => CellsByName["DamageLevelMediumDecelerationTime"].Value = (float)value;
            }
            

            // Def="f32 damage_L_DecTime"
            /// <summary>
            /// Damage Level: Heavy - Deceleration Time (f32)
            /// </summary>
            /// <remarks>
            /// Set the deceleration time used for heavy damage animation
            /// </remarks>
            public float DamageLevelHeavyDecelerationTime 
            {
                get => (float)CellsByName["DamageLevelHeavyDecelerationTime"].Value;
                set => CellsByName["DamageLevelHeavyDecelerationTime"].Value = (float)value;
            }
            

            // Def="f32 damage_BlowS_DecTime"
            /// <summary>
            /// Damage Level: Small Blow-off - Deceleration Time (f32)
            /// </summary>
            /// <remarks>
            /// Set the deceleration time used for small blow-off damage animation
            /// </remarks>
            public float DamageLevelSmallBlowOffDecelerationTime 
            {
                get => (float)CellsByName["DamageLevelSmallBlowOffDecelerationTime"].Value;
                set => CellsByName["DamageLevelSmallBlowOffDecelerationTime"].Value = (float)value;
            }
            

            // Def="f32 damage_BlowM_DecTime"
            /// <summary>
            /// Damage Level: Heavy Blow-off - Deceleration Time (f32)
            /// </summary>
            /// <remarks>
            /// Large blow-off damage Set the deceleration time used during animation
            /// </remarks>
            public float DamageLevelHeavyBlowOffDecelerationTime 
            {
                get => (float)CellsByName["DamageLevelHeavyBlowOffDecelerationTime"].Value;
                set => CellsByName["DamageLevelHeavyBlowOffDecelerationTime"].Value = (float)value;
            }
            

            // Def="f32 damage_Strike_DecTime"
            /// <summary>
            /// Damage Level: Strike - Deceleration Time (f32)
            /// </summary>
            /// <remarks>
            /// Set the deceleration time used during slamming damage animation
            /// </remarks>
            public float DamageLevelStrikeDecelerationTime 
            {
                get => (float)CellsByName["DamageLevelStrikeDecelerationTime"].Value;
                set => CellsByName["DamageLevelStrikeDecelerationTime"].Value = (float)value;
            }
            

            // Def="f32 damage_Uppercut_DecTime"
            /// <summary>
            /// Damage Level: Uppercut - Deceleration Time (f32)
            /// </summary>
            /// <remarks>
            /// Set the deceleration time used during launch damage animation
            /// </remarks>
            public float DamageLevelUppercutDecelerationTime 
            {
                get => (float)CellsByName["DamageLevelUppercutDecelerationTime"].Value;
                set => CellsByName["DamageLevelUppercutDecelerationTime"].Value = (float)value;
            }
            

            // Def="f32 damage_Push_DecTime"
            /// <summary>
            /// Damage Level: Push - Deceleration Time (f32)
            /// </summary>
            /// <remarks>
            /// Set the deceleration time used during push damage animation
            /// </remarks>
            public float DamageLevelPushDecelerationTime 
            {
                get => (float)CellsByName["DamageLevelPushDecelerationTime"].Value;
                set => CellsByName["DamageLevelPushDecelerationTime"].Value = (float)value;
            }
            

            // Def="f32 damage_Breath_DecTime"
            /// <summary>
            /// Damage Level: Breath - Deceleration Time (f32)
            /// </summary>
            /// <remarks>
            /// Set the deceleration time used during breath damage animation
            /// </remarks>
            public float DamageLevelBreathDecelerationTime 
            {
                get => (float)CellsByName["DamageLevelBreathDecelerationTime"].Value;
                set => CellsByName["DamageLevelBreathDecelerationTime"].Value = (float)value;
            }
            

            // Def="f32 damage_HeadShot_DecTime"
            /// <summary>
            /// Damage Level: Headshot - Deceleration Time (f32)
            /// </summary>
            /// <remarks>
            /// Headshot damage Set the deceleration time used during animation
            /// </remarks>
            public float DamageLevelHeadshotDecelerationTime 
            {
                get => (float)CellsByName["DamageLevelHeadshotDecelerationTime"].Value;
                set => CellsByName["DamageLevelHeadshotDecelerationTime"].Value = (float)value;
            }
            

            // Def="f32 guard_S_DecTime"
            /// <summary>
            /// Guard Damage Level: Small - Deceleration Time (f32)
            /// </summary>
            /// <remarks>
            /// Set the deceleration time used for guard receiving small animation
            /// </remarks>
            public float GuardDamageLevelSmallDecelerationTime 
            {
                get => (float)CellsByName["GuardDamageLevelSmallDecelerationTime"].Value;
                set => CellsByName["GuardDamageLevelSmallDecelerationTime"].Value = (float)value;
            }
            

            // Def="f32 guard_L_DecTime"
            /// <summary>
            /// Guard Damage Level: Heavy - Deceleration Time (f32)
            /// </summary>
            /// <remarks>
            /// Set the deceleration time used for guard receiving large animation
            /// </remarks>
            public float GuardDamageLevelHeavyDecelerationTime 
            {
                get => (float)CellsByName["GuardDamageLevelHeavyDecelerationTime"].Value;
                set => CellsByName["GuardDamageLevelHeavyDecelerationTime"].Value = (float)value;
            }
            

            // Def="f32 guard_LL_DecTime"
            /// <summary>
            /// Guard Damage Level: Very Break - Deceleration Time (f32)
            /// </summary>
            /// <remarks>
            /// Set the deceleration time used for guard receiving oversized animation
            /// </remarks>
            public float GuardDamageLevelVeryBreakDecelerationTime 
            {
                get => (float)CellsByName["GuardDamageLevelVeryBreakDecelerationTime"].Value;
                set => CellsByName["GuardDamageLevelVeryBreakDecelerationTime"].Value = (float)value;
            }
            

            // Def="f32 guardBrake_DecTime"
            /// <summary>
            /// Guard Damage Level: Break - Deceleration Time (f32)
            /// </summary>
            /// <remarks>
            /// Set the deceleration time specified at the time of guard breaking animation
            /// </remarks>
            public float GuardDamageLevelBreakDecelerationTime 
            {
                get => (float)CellsByName["GuardDamageLevelBreakDecelerationTime"].Value;
                set => CellsByName["GuardDamageLevelBreakDecelerationTime"].Value = (float)value;
            }
            

            // Def="dummy8 pad[8]"
            /// <summary>
            /// pading (dummy8)
            /// </summary>
            /// <remarks>
            /// 
            /// </remarks>
            public object Pading 
            {
                get => (object)CellsByName["Pading"].Value;
                set => CellsByName["Pading"].Value = (object)value;
            }
            
                }
            }
            
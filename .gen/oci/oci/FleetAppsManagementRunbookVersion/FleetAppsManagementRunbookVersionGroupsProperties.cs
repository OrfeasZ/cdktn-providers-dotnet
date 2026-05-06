using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.FleetAppsManagementRunbookVersion
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.fleetAppsManagementRunbookVersion.FleetAppsManagementRunbookVersionGroupsProperties")]
    public class FleetAppsManagementRunbookVersionGroupsProperties : oci.FleetAppsManagementRunbookVersion.IFleetAppsManagementRunbookVersionGroupsProperties
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/fleet_apps_management_runbook_version#action_on_failure FleetAppsManagementRunbookVersion#action_on_failure}.</summary>
        [JsiiProperty(name: "actionOnFailure", typeJson: "{\"primitive\":\"string\"}")]
        public string ActionOnFailure
        {
            get;
            set;
        }

        /// <summary>notification_preferences block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/fleet_apps_management_runbook_version#notification_preferences FleetAppsManagementRunbookVersion#notification_preferences}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "notificationPreferences", typeJson: "{\"fqn\":\"oci.fleetAppsManagementRunbookVersion.FleetAppsManagementRunbookVersionGroupsPropertiesNotificationPreferences\"}", isOptional: true)]
        public oci.FleetAppsManagementRunbookVersion.IFleetAppsManagementRunbookVersionGroupsPropertiesNotificationPreferences? NotificationPreferences
        {
            get;
            set;
        }

        /// <summary>pause_details block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/fleet_apps_management_runbook_version#pause_details FleetAppsManagementRunbookVersion#pause_details}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "pauseDetails", typeJson: "{\"fqn\":\"oci.fleetAppsManagementRunbookVersion.FleetAppsManagementRunbookVersionGroupsPropertiesPauseDetails\"}", isOptional: true)]
        public oci.FleetAppsManagementRunbookVersion.IFleetAppsManagementRunbookVersionGroupsPropertiesPauseDetails? PauseDetails
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/fleet_apps_management_runbook_version#pre_condition FleetAppsManagementRunbookVersion#pre_condition}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "preCondition", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? PreCondition
        {
            get;
            set;
        }

        /// <summary>run_on block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/fleet_apps_management_runbook_version#run_on FleetAppsManagementRunbookVersion#run_on}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "runOn", typeJson: "{\"fqn\":\"oci.fleetAppsManagementRunbookVersion.FleetAppsManagementRunbookVersionGroupsPropertiesRunOn\"}", isOptional: true)]
        public oci.FleetAppsManagementRunbookVersion.IFleetAppsManagementRunbookVersionGroupsPropertiesRunOn? RunOn
        {
            get;
            set;
        }
    }
}

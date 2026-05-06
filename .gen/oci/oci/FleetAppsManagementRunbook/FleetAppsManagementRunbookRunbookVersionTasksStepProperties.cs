using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.FleetAppsManagementRunbook
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.fleetAppsManagementRunbook.FleetAppsManagementRunbookRunbookVersionTasksStepProperties")]
    public class FleetAppsManagementRunbookRunbookVersionTasksStepProperties : oci.FleetAppsManagementRunbook.IFleetAppsManagementRunbookRunbookVersionTasksStepProperties
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/fleet_apps_management_runbook#action_on_failure FleetAppsManagementRunbook#action_on_failure}.</summary>
        [JsiiProperty(name: "actionOnFailure", typeJson: "{\"primitive\":\"string\"}")]
        public string ActionOnFailure
        {
            get;
            set;
        }

        /// <summary>notification_preferences block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/fleet_apps_management_runbook#notification_preferences FleetAppsManagementRunbook#notification_preferences}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "notificationPreferences", typeJson: "{\"fqn\":\"oci.fleetAppsManagementRunbook.FleetAppsManagementRunbookRunbookVersionTasksStepPropertiesNotificationPreferences\"}", isOptional: true)]
        public oci.FleetAppsManagementRunbook.IFleetAppsManagementRunbookRunbookVersionTasksStepPropertiesNotificationPreferences? NotificationPreferences
        {
            get;
            set;
        }

        /// <summary>pause_details block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/fleet_apps_management_runbook#pause_details FleetAppsManagementRunbook#pause_details}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "pauseDetails", typeJson: "{\"fqn\":\"oci.fleetAppsManagementRunbook.FleetAppsManagementRunbookRunbookVersionTasksStepPropertiesPauseDetails\"}", isOptional: true)]
        public oci.FleetAppsManagementRunbook.IFleetAppsManagementRunbookRunbookVersionTasksStepPropertiesPauseDetails? PauseDetails
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/fleet_apps_management_runbook#pre_condition FleetAppsManagementRunbook#pre_condition}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "preCondition", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? PreCondition
        {
            get;
            set;
        }

        /// <summary>run_on block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/fleet_apps_management_runbook#run_on FleetAppsManagementRunbook#run_on}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "runOn", typeJson: "{\"fqn\":\"oci.fleetAppsManagementRunbook.FleetAppsManagementRunbookRunbookVersionTasksStepPropertiesRunOn\"}", isOptional: true)]
        public oci.FleetAppsManagementRunbook.IFleetAppsManagementRunbookRunbookVersionTasksStepPropertiesRunOn? RunOn
        {
            get;
            set;
        }
    }
}

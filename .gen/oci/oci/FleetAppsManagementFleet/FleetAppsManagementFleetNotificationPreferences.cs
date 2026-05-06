using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.FleetAppsManagementFleet
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.fleetAppsManagementFleet.FleetAppsManagementFleetNotificationPreferences")]
    public class FleetAppsManagementFleetNotificationPreferences : oci.FleetAppsManagementFleet.IFleetAppsManagementFleetNotificationPreferences
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/fleet_apps_management_fleet#compartment_id FleetAppsManagementFleet#compartment_id}.</summary>
        [JsiiProperty(name: "compartmentId", typeJson: "{\"primitive\":\"string\"}")]
        public string CompartmentId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/fleet_apps_management_fleet#topic_id FleetAppsManagementFleet#topic_id}.</summary>
        [JsiiProperty(name: "topicId", typeJson: "{\"primitive\":\"string\"}")]
        public string TopicId
        {
            get;
            set;
        }

        /// <summary>preferences block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/fleet_apps_management_fleet#preferences FleetAppsManagementFleet#preferences}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "preferences", typeJson: "{\"fqn\":\"oci.fleetAppsManagementFleet.FleetAppsManagementFleetNotificationPreferencesPreferences\"}", isOptional: true)]
        public oci.FleetAppsManagementFleet.IFleetAppsManagementFleetNotificationPreferencesPreferences? Preferences
        {
            get;
            set;
        }
    }
}

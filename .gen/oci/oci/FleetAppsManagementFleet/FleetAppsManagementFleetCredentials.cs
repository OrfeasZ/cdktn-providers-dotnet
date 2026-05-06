using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.FleetAppsManagementFleet
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.fleetAppsManagementFleet.FleetAppsManagementFleetCredentials")]
    public class FleetAppsManagementFleetCredentials : oci.FleetAppsManagementFleet.IFleetAppsManagementFleetCredentials
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/fleet_apps_management_fleet#compartment_id FleetAppsManagementFleet#compartment_id}.</summary>
        [JsiiProperty(name: "compartmentId", typeJson: "{\"primitive\":\"string\"}")]
        public string CompartmentId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/fleet_apps_management_fleet#display_name FleetAppsManagementFleet#display_name}.</summary>
        [JsiiProperty(name: "displayName", typeJson: "{\"primitive\":\"string\"}")]
        public string DisplayName
        {
            get;
            set;
        }

        /// <summary>entity_specifics block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/fleet_apps_management_fleet#entity_specifics FleetAppsManagementFleet#entity_specifics}
        /// </remarks>
        [JsiiProperty(name: "entitySpecifics", typeJson: "{\"fqn\":\"oci.fleetAppsManagementFleet.FleetAppsManagementFleetCredentialsEntitySpecifics\"}")]
        public oci.FleetAppsManagementFleet.IFleetAppsManagementFleetCredentialsEntitySpecifics EntitySpecifics
        {
            get;
            set;
        }

        /// <summary>password block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/fleet_apps_management_fleet#password FleetAppsManagementFleet#password}
        /// </remarks>
        [JsiiProperty(name: "password", typeJson: "{\"fqn\":\"oci.fleetAppsManagementFleet.FleetAppsManagementFleetCredentialsPassword\"}")]
        public oci.FleetAppsManagementFleet.IFleetAppsManagementFleetCredentialsPassword Password
        {
            get;
            set;
        }

        /// <summary>user block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/fleet_apps_management_fleet#user FleetAppsManagementFleet#user}
        /// </remarks>
        [JsiiProperty(name: "user", typeJson: "{\"fqn\":\"oci.fleetAppsManagementFleet.FleetAppsManagementFleetCredentialsUser\"}")]
        public oci.FleetAppsManagementFleet.IFleetAppsManagementFleetCredentialsUser User
        {
            get;
            set;
        }
    }
}

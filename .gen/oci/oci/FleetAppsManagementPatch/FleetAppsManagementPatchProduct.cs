using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.FleetAppsManagementPatch
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.fleetAppsManagementPatch.FleetAppsManagementPatchProduct")]
    public class FleetAppsManagementPatchProduct : oci.FleetAppsManagementPatch.IFleetAppsManagementPatchProduct
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/fleet_apps_management_patch#platform_configuration_id FleetAppsManagementPatch#platform_configuration_id}.</summary>
        [JsiiProperty(name: "platformConfigurationId", typeJson: "{\"primitive\":\"string\"}")]
        public string PlatformConfigurationId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/fleet_apps_management_patch#version FleetAppsManagementPatch#version}.</summary>
        [JsiiProperty(name: "version", typeJson: "{\"primitive\":\"string\"}")]
        public string Version
        {
            get;
            set;
        }
    }
}

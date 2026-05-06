using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.FleetAppsManagementPlatformConfiguration
{
    [JsiiByValue(fqn: "oci.fleetAppsManagementPlatformConfiguration.FleetAppsManagementPlatformConfigurationConfigCategoryDetailsSubCategoryDetailsPatchTypes")]
    public class FleetAppsManagementPlatformConfigurationConfigCategoryDetailsSubCategoryDetailsPatchTypes : oci.FleetAppsManagementPlatformConfiguration.IFleetAppsManagementPlatformConfigurationConfigCategoryDetailsSubCategoryDetailsPatchTypes
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/fleet_apps_management_platform_configuration#display_name FleetAppsManagementPlatformConfiguration#display_name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "displayName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? DisplayName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/fleet_apps_management_platform_configuration#id FleetAppsManagementPlatformConfiguration#id}.</summary>
        /// <remarks>
        /// Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2.
        /// If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Id
        {
            get;
            set;
        }
    }
}

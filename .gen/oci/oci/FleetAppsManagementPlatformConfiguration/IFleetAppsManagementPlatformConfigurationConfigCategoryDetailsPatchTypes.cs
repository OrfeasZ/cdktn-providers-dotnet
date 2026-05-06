using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.FleetAppsManagementPlatformConfiguration
{
    [JsiiInterface(nativeType: typeof(IFleetAppsManagementPlatformConfigurationConfigCategoryDetailsPatchTypes), fullyQualifiedName: "oci.fleetAppsManagementPlatformConfiguration.FleetAppsManagementPlatformConfigurationConfigCategoryDetailsPatchTypes")]
    public interface IFleetAppsManagementPlatformConfigurationConfigCategoryDetailsPatchTypes
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/fleet_apps_management_platform_configuration#display_name FleetAppsManagementPlatformConfiguration#display_name}.</summary>
        [JsiiProperty(name: "displayName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? DisplayName
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/fleet_apps_management_platform_configuration#id FleetAppsManagementPlatformConfiguration#id}.</summary>
        /// <remarks>
        /// Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2.
        /// If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </remarks>
        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Id
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IFleetAppsManagementPlatformConfigurationConfigCategoryDetailsPatchTypes), fullyQualifiedName: "oci.fleetAppsManagementPlatformConfiguration.FleetAppsManagementPlatformConfigurationConfigCategoryDetailsPatchTypes")]
        internal sealed class _Proxy : DeputyBase, oci.FleetAppsManagementPlatformConfiguration.IFleetAppsManagementPlatformConfigurationConfigCategoryDetailsPatchTypes
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/fleet_apps_management_platform_configuration#display_name FleetAppsManagementPlatformConfiguration#display_name}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "displayName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? DisplayName
            {
                get => GetInstanceProperty<string?>();
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
                get => GetInstanceProperty<string?>();
            }
        }
    }
}

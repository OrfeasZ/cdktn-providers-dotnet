using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.FleetAppsManagementPatch
{
    [JsiiInterface(nativeType: typeof(IFleetAppsManagementPatchProduct), fullyQualifiedName: "oci.fleetAppsManagementPatch.FleetAppsManagementPatchProduct")]
    public interface IFleetAppsManagementPatchProduct
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/fleet_apps_management_patch#platform_configuration_id FleetAppsManagementPatch#platform_configuration_id}.</summary>
        [JsiiProperty(name: "platformConfigurationId", typeJson: "{\"primitive\":\"string\"}")]
        string PlatformConfigurationId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/fleet_apps_management_patch#version FleetAppsManagementPatch#version}.</summary>
        [JsiiProperty(name: "version", typeJson: "{\"primitive\":\"string\"}")]
        string Version
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IFleetAppsManagementPatchProduct), fullyQualifiedName: "oci.fleetAppsManagementPatch.FleetAppsManagementPatchProduct")]
        internal sealed class _Proxy : DeputyBase, oci.FleetAppsManagementPatch.IFleetAppsManagementPatchProduct
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/fleet_apps_management_patch#platform_configuration_id FleetAppsManagementPatch#platform_configuration_id}.</summary>
            [JsiiProperty(name: "platformConfigurationId", typeJson: "{\"primitive\":\"string\"}")]
            public string PlatformConfigurationId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/fleet_apps_management_patch#version FleetAppsManagementPatch#version}.</summary>
            [JsiiProperty(name: "version", typeJson: "{\"primitive\":\"string\"}")]
            public string Version
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}

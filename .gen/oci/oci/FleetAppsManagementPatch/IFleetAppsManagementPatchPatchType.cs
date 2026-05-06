using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.FleetAppsManagementPatch
{
    [JsiiInterface(nativeType: typeof(IFleetAppsManagementPatchPatchType), fullyQualifiedName: "oci.fleetAppsManagementPatch.FleetAppsManagementPatchPatchType")]
    public interface IFleetAppsManagementPatchPatchType
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/fleet_apps_management_patch#platform_configuration_id FleetAppsManagementPatch#platform_configuration_id}.</summary>
        [JsiiProperty(name: "platformConfigurationId", typeJson: "{\"primitive\":\"string\"}")]
        string PlatformConfigurationId
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IFleetAppsManagementPatchPatchType), fullyQualifiedName: "oci.fleetAppsManagementPatch.FleetAppsManagementPatchPatchType")]
        internal sealed class _Proxy : DeputyBase, oci.FleetAppsManagementPatch.IFleetAppsManagementPatchPatchType
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
        }
    }
}

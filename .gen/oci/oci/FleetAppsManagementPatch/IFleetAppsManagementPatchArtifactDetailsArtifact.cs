using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.FleetAppsManagementPatch
{
    [JsiiInterface(nativeType: typeof(IFleetAppsManagementPatchArtifactDetailsArtifact), fullyQualifiedName: "oci.fleetAppsManagementPatch.FleetAppsManagementPatchArtifactDetailsArtifact")]
    public interface IFleetAppsManagementPatchArtifactDetailsArtifact
    {
        /// <summary>content block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/fleet_apps_management_patch#content FleetAppsManagementPatch#content}
        /// </remarks>
        [JsiiProperty(name: "content", typeJson: "{\"fqn\":\"oci.fleetAppsManagementPatch.FleetAppsManagementPatchArtifactDetailsArtifactContent\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.FleetAppsManagementPatch.IFleetAppsManagementPatchArtifactDetailsArtifactContent? Content
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IFleetAppsManagementPatchArtifactDetailsArtifact), fullyQualifiedName: "oci.fleetAppsManagementPatch.FleetAppsManagementPatchArtifactDetailsArtifact")]
        internal sealed class _Proxy : DeputyBase, oci.FleetAppsManagementPatch.IFleetAppsManagementPatchArtifactDetailsArtifact
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>content block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/fleet_apps_management_patch#content FleetAppsManagementPatch#content}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "content", typeJson: "{\"fqn\":\"oci.fleetAppsManagementPatch.FleetAppsManagementPatchArtifactDetailsArtifactContent\"}", isOptional: true)]
            public oci.FleetAppsManagementPatch.IFleetAppsManagementPatchArtifactDetailsArtifactContent? Content
            {
                get => GetInstanceProperty<oci.FleetAppsManagementPatch.IFleetAppsManagementPatchArtifactDetailsArtifactContent?>();
            }
        }
    }
}

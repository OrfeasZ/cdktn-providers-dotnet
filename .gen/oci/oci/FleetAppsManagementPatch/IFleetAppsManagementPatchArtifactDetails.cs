using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.FleetAppsManagementPatch
{
    [JsiiInterface(nativeType: typeof(IFleetAppsManagementPatchArtifactDetails), fullyQualifiedName: "oci.fleetAppsManagementPatch.FleetAppsManagementPatchArtifactDetails")]
    public interface IFleetAppsManagementPatchArtifactDetails
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/fleet_apps_management_patch#category FleetAppsManagementPatch#category}.</summary>
        [JsiiProperty(name: "category", typeJson: "{\"primitive\":\"string\"}")]
        string Category
        {
            get;
        }

        /// <summary>artifact block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/fleet_apps_management_patch#artifact FleetAppsManagementPatch#artifact}
        /// </remarks>
        [JsiiProperty(name: "artifact", typeJson: "{\"fqn\":\"oci.fleetAppsManagementPatch.FleetAppsManagementPatchArtifactDetailsArtifact\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.FleetAppsManagementPatch.IFleetAppsManagementPatchArtifactDetailsArtifact? Artifact
        {
            get
            {
                return null;
            }
        }

        /// <summary>artifacts block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/fleet_apps_management_patch#artifacts FleetAppsManagementPatch#artifacts}
        /// </remarks>
        [JsiiProperty(name: "artifacts", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.fleetAppsManagementPatch.FleetAppsManagementPatchArtifactDetailsArtifacts\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Artifacts
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IFleetAppsManagementPatchArtifactDetails), fullyQualifiedName: "oci.fleetAppsManagementPatch.FleetAppsManagementPatchArtifactDetails")]
        internal sealed class _Proxy : DeputyBase, oci.FleetAppsManagementPatch.IFleetAppsManagementPatchArtifactDetails
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/fleet_apps_management_patch#category FleetAppsManagementPatch#category}.</summary>
            [JsiiProperty(name: "category", typeJson: "{\"primitive\":\"string\"}")]
            public string Category
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>artifact block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/fleet_apps_management_patch#artifact FleetAppsManagementPatch#artifact}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "artifact", typeJson: "{\"fqn\":\"oci.fleetAppsManagementPatch.FleetAppsManagementPatchArtifactDetailsArtifact\"}", isOptional: true)]
            public oci.FleetAppsManagementPatch.IFleetAppsManagementPatchArtifactDetailsArtifact? Artifact
            {
                get => GetInstanceProperty<oci.FleetAppsManagementPatch.IFleetAppsManagementPatchArtifactDetailsArtifact?>();
            }

            /// <summary>artifacts block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/fleet_apps_management_patch#artifacts FleetAppsManagementPatch#artifacts}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "artifacts", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.fleetAppsManagementPatch.FleetAppsManagementPatchArtifactDetailsArtifacts\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Artifacts
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}

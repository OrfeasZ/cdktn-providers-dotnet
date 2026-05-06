using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.FleetAppsManagementPatch
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.fleetAppsManagementPatch.FleetAppsManagementPatchArtifactDetails")]
    public class FleetAppsManagementPatchArtifactDetails : oci.FleetAppsManagementPatch.IFleetAppsManagementPatchArtifactDetails
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/fleet_apps_management_patch#category FleetAppsManagementPatch#category}.</summary>
        [JsiiProperty(name: "category", typeJson: "{\"primitive\":\"string\"}")]
        public string Category
        {
            get;
            set;
        }

        /// <summary>artifact block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/fleet_apps_management_patch#artifact FleetAppsManagementPatch#artifact}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "artifact", typeJson: "{\"fqn\":\"oci.fleetAppsManagementPatch.FleetAppsManagementPatchArtifactDetailsArtifact\"}", isOptional: true)]
        public oci.FleetAppsManagementPatch.IFleetAppsManagementPatchArtifactDetailsArtifact? Artifact
        {
            get;
            set;
        }

        private object? _artifacts;

        /// <summary>artifacts block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/fleet_apps_management_patch#artifacts FleetAppsManagementPatch#artifacts}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "artifacts", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.fleetAppsManagementPatch.FleetAppsManagementPatchArtifactDetailsArtifacts\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? Artifacts
        {
            get => _artifacts;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case oci.FleetAppsManagementPatch.IFleetAppsManagementPatchArtifactDetailsArtifacts[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.FleetAppsManagementPatch.IFleetAppsManagementPatchArtifactDetailsArtifacts).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _artifacts = value;
            }
        }
    }
}

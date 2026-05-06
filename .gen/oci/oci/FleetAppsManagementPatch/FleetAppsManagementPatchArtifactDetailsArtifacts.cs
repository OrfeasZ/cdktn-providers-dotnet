using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.FleetAppsManagementPatch
{
    [JsiiByValue(fqn: "oci.fleetAppsManagementPatch.FleetAppsManagementPatchArtifactDetailsArtifacts")]
    public class FleetAppsManagementPatchArtifactDetailsArtifacts : oci.FleetAppsManagementPatch.IFleetAppsManagementPatchArtifactDetailsArtifacts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/fleet_apps_management_patch#architecture FleetAppsManagementPatch#architecture}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "architecture", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Architecture
        {
            get;
            set;
        }

        /// <summary>content block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/fleet_apps_management_patch#content FleetAppsManagementPatch#content}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "content", typeJson: "{\"fqn\":\"oci.fleetAppsManagementPatch.FleetAppsManagementPatchArtifactDetailsArtifactsContent\"}", isOptional: true)]
        public oci.FleetAppsManagementPatch.IFleetAppsManagementPatchArtifactDetailsArtifactsContent? Content
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/fleet_apps_management_patch#os_type FleetAppsManagementPatch#os_type}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "osType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? OsType
        {
            get;
            set;
        }
    }
}

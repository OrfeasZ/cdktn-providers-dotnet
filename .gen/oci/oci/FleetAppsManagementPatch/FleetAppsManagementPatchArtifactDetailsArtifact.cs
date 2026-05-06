using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.FleetAppsManagementPatch
{
    [JsiiByValue(fqn: "oci.fleetAppsManagementPatch.FleetAppsManagementPatchArtifactDetailsArtifact")]
    public class FleetAppsManagementPatchArtifactDetailsArtifact : oci.FleetAppsManagementPatch.IFleetAppsManagementPatchArtifactDetailsArtifact
    {
        /// <summary>content block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/fleet_apps_management_patch#content FleetAppsManagementPatch#content}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "content", typeJson: "{\"fqn\":\"oci.fleetAppsManagementPatch.FleetAppsManagementPatchArtifactDetailsArtifactContent\"}", isOptional: true)]
        public oci.FleetAppsManagementPatch.IFleetAppsManagementPatchArtifactDetailsArtifactContent? Content
        {
            get;
            set;
        }
    }
}

using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.OsManagementHubManagedInstanceRemoveSnapsManagement
{
    [JsiiByValue(fqn: "oci.osManagementHubManagedInstanceRemoveSnapsManagement.OsManagementHubManagedInstanceRemoveSnapsManagementWorkRequestDetails")]
    public class OsManagementHubManagedInstanceRemoveSnapsManagementWorkRequestDetails : oci.OsManagementHubManagedInstanceRemoveSnapsManagement.IOsManagementHubManagedInstanceRemoveSnapsManagementWorkRequestDetails
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.26.0/docs/resources/os_management_hub_managed_instance_remove_snaps_management#description OsManagementHubManagedInstanceRemoveSnapsManagement#description}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Description
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.26.0/docs/resources/os_management_hub_managed_instance_remove_snaps_management#display_name OsManagementHubManagedInstanceRemoveSnapsManagement#display_name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "displayName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? DisplayName
        {
            get;
            set;
        }
    }
}

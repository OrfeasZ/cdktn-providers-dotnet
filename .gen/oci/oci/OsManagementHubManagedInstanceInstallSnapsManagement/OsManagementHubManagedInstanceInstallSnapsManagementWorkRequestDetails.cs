using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.OsManagementHubManagedInstanceInstallSnapsManagement
{
    [JsiiByValue(fqn: "oci.osManagementHubManagedInstanceInstallSnapsManagement.OsManagementHubManagedInstanceInstallSnapsManagementWorkRequestDetails")]
    public class OsManagementHubManagedInstanceInstallSnapsManagementWorkRequestDetails : oci.OsManagementHubManagedInstanceInstallSnapsManagement.IOsManagementHubManagedInstanceInstallSnapsManagementWorkRequestDetails
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.20.0/docs/resources/os_management_hub_managed_instance_install_snaps_management#description OsManagementHubManagedInstanceInstallSnapsManagement#description}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Description
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.20.0/docs/resources/os_management_hub_managed_instance_install_snaps_management#display_name OsManagementHubManagedInstanceInstallSnapsManagement#display_name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "displayName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? DisplayName
        {
            get;
            set;
        }
    }
}

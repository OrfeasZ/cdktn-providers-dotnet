using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.OsManagementHubManagedInstanceRemoveSnapsManagement
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.osManagementHubManagedInstanceRemoveSnapsManagement.OsManagementHubManagedInstanceRemoveSnapsManagementSnapDetails")]
    public class OsManagementHubManagedInstanceRemoveSnapsManagementSnapDetails : oci.OsManagementHubManagedInstanceRemoveSnapsManagement.IOsManagementHubManagedInstanceRemoveSnapsManagementSnapDetails
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.19.0/docs/resources/os_management_hub_managed_instance_remove_snaps_management#name OsManagementHubManagedInstanceRemoveSnapsManagement#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public string Name
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.19.0/docs/resources/os_management_hub_managed_instance_remove_snaps_management#revision OsManagementHubManagedInstanceRemoveSnapsManagement#revision}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "revision", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Revision
        {
            get;
            set;
        }
    }
}

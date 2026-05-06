using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.OsManagementHubManagedInstanceGroupAttachManagedInstancesManagement
{
    [JsiiByValue(fqn: "oci.osManagementHubManagedInstanceGroupAttachManagedInstancesManagement.OsManagementHubManagedInstanceGroupAttachManagedInstancesManagementWorkRequestDetails")]
    public class OsManagementHubManagedInstanceGroupAttachManagedInstancesManagementWorkRequestDetails : oci.OsManagementHubManagedInstanceGroupAttachManagedInstancesManagement.IOsManagementHubManagedInstanceGroupAttachManagedInstancesManagementWorkRequestDetails
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/os_management_hub_managed_instance_group_attach_managed_instances_management#description OsManagementHubManagedInstanceGroupAttachManagedInstancesManagement#description}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Description
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/os_management_hub_managed_instance_group_attach_managed_instances_management#display_name OsManagementHubManagedInstanceGroupAttachManagedInstancesManagement#display_name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "displayName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? DisplayName
        {
            get;
            set;
        }
    }
}

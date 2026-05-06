using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.OsManagementHubManagedInstanceGroupRebootManagement
{
    [JsiiByValue(fqn: "oci.osManagementHubManagedInstanceGroupRebootManagement.OsManagementHubManagedInstanceGroupRebootManagementTimeouts")]
    public class OsManagementHubManagedInstanceGroupRebootManagementTimeouts : oci.OsManagementHubManagedInstanceGroupRebootManagement.IOsManagementHubManagedInstanceGroupRebootManagementTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/os_management_hub_managed_instance_group_reboot_management#create OsManagementHubManagedInstanceGroupRebootManagement#create}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Create
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/os_management_hub_managed_instance_group_reboot_management#delete OsManagementHubManagedInstanceGroupRebootManagement#delete}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Delete
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/os_management_hub_managed_instance_group_reboot_management#update OsManagementHubManagedInstanceGroupRebootManagement#update}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "update", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Update
        {
            get;
            set;
        }
    }
}

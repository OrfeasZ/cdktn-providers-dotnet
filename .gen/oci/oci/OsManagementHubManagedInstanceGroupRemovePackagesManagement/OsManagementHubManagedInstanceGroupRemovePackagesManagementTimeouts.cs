using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.OsManagementHubManagedInstanceGroupRemovePackagesManagement
{
    [JsiiByValue(fqn: "oci.osManagementHubManagedInstanceGroupRemovePackagesManagement.OsManagementHubManagedInstanceGroupRemovePackagesManagementTimeouts")]
    public class OsManagementHubManagedInstanceGroupRemovePackagesManagementTimeouts : oci.OsManagementHubManagedInstanceGroupRemovePackagesManagement.IOsManagementHubManagedInstanceGroupRemovePackagesManagementTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/os_management_hub_managed_instance_group_remove_packages_management#create OsManagementHubManagedInstanceGroupRemovePackagesManagement#create}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Create
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/os_management_hub_managed_instance_group_remove_packages_management#delete OsManagementHubManagedInstanceGroupRemovePackagesManagement#delete}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Delete
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/os_management_hub_managed_instance_group_remove_packages_management#update OsManagementHubManagedInstanceGroupRemovePackagesManagement#update}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "update", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Update
        {
            get;
            set;
        }
    }
}

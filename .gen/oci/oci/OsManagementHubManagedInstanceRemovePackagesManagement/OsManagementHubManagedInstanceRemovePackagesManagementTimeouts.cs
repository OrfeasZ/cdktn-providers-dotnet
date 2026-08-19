using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.OsManagementHubManagedInstanceRemovePackagesManagement
{
    [JsiiByValue(fqn: "oci.osManagementHubManagedInstanceRemovePackagesManagement.OsManagementHubManagedInstanceRemovePackagesManagementTimeouts")]
    public class OsManagementHubManagedInstanceRemovePackagesManagementTimeouts : oci.OsManagementHubManagedInstanceRemovePackagesManagement.IOsManagementHubManagedInstanceRemovePackagesManagementTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.28.0/docs/resources/os_management_hub_managed_instance_remove_packages_management#create OsManagementHubManagedInstanceRemovePackagesManagement#create}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Create
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.28.0/docs/resources/os_management_hub_managed_instance_remove_packages_management#delete OsManagementHubManagedInstanceRemovePackagesManagement#delete}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Delete
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.28.0/docs/resources/os_management_hub_managed_instance_remove_packages_management#update OsManagementHubManagedInstanceRemovePackagesManagement#update}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "update", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Update
        {
            get;
            set;
        }
    }
}

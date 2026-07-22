using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.OsManagementHubManagedInstancesUpdatePackagesManagement
{
    [JsiiByValue(fqn: "oci.osManagementHubManagedInstancesUpdatePackagesManagement.OsManagementHubManagedInstancesUpdatePackagesManagementTimeouts")]
    public class OsManagementHubManagedInstancesUpdatePackagesManagementTimeouts : oci.OsManagementHubManagedInstancesUpdatePackagesManagement.IOsManagementHubManagedInstancesUpdatePackagesManagementTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.24.0/docs/resources/os_management_hub_managed_instances_update_packages_management#create OsManagementHubManagedInstancesUpdatePackagesManagement#create}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Create
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.24.0/docs/resources/os_management_hub_managed_instances_update_packages_management#delete OsManagementHubManagedInstancesUpdatePackagesManagement#delete}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Delete
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.24.0/docs/resources/os_management_hub_managed_instances_update_packages_management#update OsManagementHubManagedInstancesUpdatePackagesManagement#update}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "update", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Update
        {
            get;
            set;
        }
    }
}

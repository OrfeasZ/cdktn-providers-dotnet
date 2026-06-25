using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.OsManagementHubManagedInstanceInstallPackagesManagement
{
    [JsiiByValue(fqn: "oci.osManagementHubManagedInstanceInstallPackagesManagement.OsManagementHubManagedInstanceInstallPackagesManagementTimeouts")]
    public class OsManagementHubManagedInstanceInstallPackagesManagementTimeouts : oci.OsManagementHubManagedInstanceInstallPackagesManagement.IOsManagementHubManagedInstanceInstallPackagesManagementTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.20.0/docs/resources/os_management_hub_managed_instance_install_packages_management#create OsManagementHubManagedInstanceInstallPackagesManagement#create}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Create
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.20.0/docs/resources/os_management_hub_managed_instance_install_packages_management#delete OsManagementHubManagedInstanceInstallPackagesManagement#delete}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Delete
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.20.0/docs/resources/os_management_hub_managed_instance_install_packages_management#update OsManagementHubManagedInstanceInstallPackagesManagement#update}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "update", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Update
        {
            get;
            set;
        }
    }
}

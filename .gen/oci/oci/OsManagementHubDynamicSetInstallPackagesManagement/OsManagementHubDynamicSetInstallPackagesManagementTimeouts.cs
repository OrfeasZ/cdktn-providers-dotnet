using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.OsManagementHubDynamicSetInstallPackagesManagement
{
    [JsiiByValue(fqn: "oci.osManagementHubDynamicSetInstallPackagesManagement.OsManagementHubDynamicSetInstallPackagesManagementTimeouts")]
    public class OsManagementHubDynamicSetInstallPackagesManagementTimeouts : oci.OsManagementHubDynamicSetInstallPackagesManagement.IOsManagementHubDynamicSetInstallPackagesManagementTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.26.0/docs/resources/os_management_hub_dynamic_set_install_packages_management#create OsManagementHubDynamicSetInstallPackagesManagement#create}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Create
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.26.0/docs/resources/os_management_hub_dynamic_set_install_packages_management#delete OsManagementHubDynamicSetInstallPackagesManagement#delete}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Delete
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.26.0/docs/resources/os_management_hub_dynamic_set_install_packages_management#update OsManagementHubDynamicSetInstallPackagesManagement#update}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "update", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Update
        {
            get;
            set;
        }
    }
}

using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.OsManagementHubDynamicSetRemovePackagesManagement
{
    [JsiiByValue(fqn: "oci.osManagementHubDynamicSetRemovePackagesManagement.OsManagementHubDynamicSetRemovePackagesManagementTimeouts")]
    public class OsManagementHubDynamicSetRemovePackagesManagementTimeouts : oci.OsManagementHubDynamicSetRemovePackagesManagement.IOsManagementHubDynamicSetRemovePackagesManagementTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.23.0/docs/resources/os_management_hub_dynamic_set_remove_packages_management#create OsManagementHubDynamicSetRemovePackagesManagement#create}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Create
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.23.0/docs/resources/os_management_hub_dynamic_set_remove_packages_management#delete OsManagementHubDynamicSetRemovePackagesManagement#delete}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Delete
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.23.0/docs/resources/os_management_hub_dynamic_set_remove_packages_management#update OsManagementHubDynamicSetRemovePackagesManagement#update}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "update", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Update
        {
            get;
            set;
        }
    }
}

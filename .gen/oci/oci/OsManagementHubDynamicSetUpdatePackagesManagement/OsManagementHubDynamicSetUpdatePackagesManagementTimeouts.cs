using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.OsManagementHubDynamicSetUpdatePackagesManagement
{
    [JsiiByValue(fqn: "oci.osManagementHubDynamicSetUpdatePackagesManagement.OsManagementHubDynamicSetUpdatePackagesManagementTimeouts")]
    public class OsManagementHubDynamicSetUpdatePackagesManagementTimeouts : oci.OsManagementHubDynamicSetUpdatePackagesManagement.IOsManagementHubDynamicSetUpdatePackagesManagementTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.22.0/docs/resources/os_management_hub_dynamic_set_update_packages_management#create OsManagementHubDynamicSetUpdatePackagesManagement#create}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Create
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.22.0/docs/resources/os_management_hub_dynamic_set_update_packages_management#delete OsManagementHubDynamicSetUpdatePackagesManagement#delete}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Delete
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.22.0/docs/resources/os_management_hub_dynamic_set_update_packages_management#update OsManagementHubDynamicSetUpdatePackagesManagement#update}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "update", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Update
        {
            get;
            set;
        }
    }
}

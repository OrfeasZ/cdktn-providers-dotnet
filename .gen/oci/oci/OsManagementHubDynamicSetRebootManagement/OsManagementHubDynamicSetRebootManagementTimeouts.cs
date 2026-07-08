using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.OsManagementHubDynamicSetRebootManagement
{
    [JsiiByValue(fqn: "oci.osManagementHubDynamicSetRebootManagement.OsManagementHubDynamicSetRebootManagementTimeouts")]
    public class OsManagementHubDynamicSetRebootManagementTimeouts : oci.OsManagementHubDynamicSetRebootManagement.IOsManagementHubDynamicSetRebootManagementTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.22.0/docs/resources/os_management_hub_dynamic_set_reboot_management#create OsManagementHubDynamicSetRebootManagement#create}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Create
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.22.0/docs/resources/os_management_hub_dynamic_set_reboot_management#delete OsManagementHubDynamicSetRebootManagement#delete}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Delete
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.22.0/docs/resources/os_management_hub_dynamic_set_reboot_management#update OsManagementHubDynamicSetRebootManagement#update}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "update", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Update
        {
            get;
            set;
        }
    }
}

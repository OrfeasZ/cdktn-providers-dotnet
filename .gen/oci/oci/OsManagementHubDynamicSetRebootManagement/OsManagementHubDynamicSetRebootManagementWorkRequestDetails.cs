using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.OsManagementHubDynamicSetRebootManagement
{
    [JsiiByValue(fqn: "oci.osManagementHubDynamicSetRebootManagement.OsManagementHubDynamicSetRebootManagementWorkRequestDetails")]
    public class OsManagementHubDynamicSetRebootManagementWorkRequestDetails : oci.OsManagementHubDynamicSetRebootManagement.IOsManagementHubDynamicSetRebootManagementWorkRequestDetails
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.27.0/docs/resources/os_management_hub_dynamic_set_reboot_management#description OsManagementHubDynamicSetRebootManagement#description}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Description
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.27.0/docs/resources/os_management_hub_dynamic_set_reboot_management#display_name OsManagementHubDynamicSetRebootManagement#display_name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "displayName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? DisplayName
        {
            get;
            set;
        }
    }
}

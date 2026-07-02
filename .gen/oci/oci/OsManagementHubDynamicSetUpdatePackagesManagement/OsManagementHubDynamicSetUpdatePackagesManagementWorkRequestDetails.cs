using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.OsManagementHubDynamicSetUpdatePackagesManagement
{
    [JsiiByValue(fqn: "oci.osManagementHubDynamicSetUpdatePackagesManagement.OsManagementHubDynamicSetUpdatePackagesManagementWorkRequestDetails")]
    public class OsManagementHubDynamicSetUpdatePackagesManagementWorkRequestDetails : oci.OsManagementHubDynamicSetUpdatePackagesManagement.IOsManagementHubDynamicSetUpdatePackagesManagementWorkRequestDetails
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.21.0/docs/resources/os_management_hub_dynamic_set_update_packages_management#description OsManagementHubDynamicSetUpdatePackagesManagement#description}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Description
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.21.0/docs/resources/os_management_hub_dynamic_set_update_packages_management#display_name OsManagementHubDynamicSetUpdatePackagesManagement#display_name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "displayName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? DisplayName
        {
            get;
            set;
        }
    }
}

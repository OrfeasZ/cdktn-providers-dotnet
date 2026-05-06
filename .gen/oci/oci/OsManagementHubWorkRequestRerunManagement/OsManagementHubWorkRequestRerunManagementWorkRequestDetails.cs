using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.OsManagementHubWorkRequestRerunManagement
{
    [JsiiByValue(fqn: "oci.osManagementHubWorkRequestRerunManagement.OsManagementHubWorkRequestRerunManagementWorkRequestDetails")]
    public class OsManagementHubWorkRequestRerunManagementWorkRequestDetails : oci.OsManagementHubWorkRequestRerunManagement.IOsManagementHubWorkRequestRerunManagementWorkRequestDetails
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/os_management_hub_work_request_rerun_management#description OsManagementHubWorkRequestRerunManagement#description}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Description
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/os_management_hub_work_request_rerun_management#display_name OsManagementHubWorkRequestRerunManagement#display_name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "displayName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? DisplayName
        {
            get;
            set;
        }
    }
}

using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.OsManagementHubLifecycleStagePromoteSoftwareSourceManagement
{
    [JsiiByValue(fqn: "oci.osManagementHubLifecycleStagePromoteSoftwareSourceManagement.OsManagementHubLifecycleStagePromoteSoftwareSourceManagementWorkRequestDetails")]
    public class OsManagementHubLifecycleStagePromoteSoftwareSourceManagementWorkRequestDetails : oci.OsManagementHubLifecycleStagePromoteSoftwareSourceManagement.IOsManagementHubLifecycleStagePromoteSoftwareSourceManagementWorkRequestDetails
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/os_management_hub_lifecycle_stage_promote_software_source_management#description OsManagementHubLifecycleStagePromoteSoftwareSourceManagement#description}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Description
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/os_management_hub_lifecycle_stage_promote_software_source_management#display_name OsManagementHubLifecycleStagePromoteSoftwareSourceManagement#display_name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "displayName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? DisplayName
        {
            get;
            set;
        }
    }
}

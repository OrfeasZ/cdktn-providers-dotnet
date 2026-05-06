using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.OsManagementHubProfileAttachLifecycleStageManagement
{
    [JsiiByValue(fqn: "oci.osManagementHubProfileAttachLifecycleStageManagement.OsManagementHubProfileAttachLifecycleStageManagementTimeouts")]
    public class OsManagementHubProfileAttachLifecycleStageManagementTimeouts : oci.OsManagementHubProfileAttachLifecycleStageManagement.IOsManagementHubProfileAttachLifecycleStageManagementTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/os_management_hub_profile_attach_lifecycle_stage_management#create OsManagementHubProfileAttachLifecycleStageManagement#create}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Create
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/os_management_hub_profile_attach_lifecycle_stage_management#delete OsManagementHubProfileAttachLifecycleStageManagement#delete}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Delete
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/os_management_hub_profile_attach_lifecycle_stage_management#update OsManagementHubProfileAttachLifecycleStageManagement#update}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "update", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Update
        {
            get;
            set;
        }
    }
}

using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.OsManagementHubScheduledJob
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.osManagementHubScheduledJob.OsManagementHubScheduledJobOperationsRemoveSnapDetails")]
    public class OsManagementHubScheduledJobOperationsRemoveSnapDetails : oci.OsManagementHubScheduledJob.IOsManagementHubScheduledJobOperationsRemoveSnapDetails
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.23.0/docs/resources/os_management_hub_scheduled_job#name OsManagementHubScheduledJob#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public string Name
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.23.0/docs/resources/os_management_hub_scheduled_job#revision OsManagementHubScheduledJob#revision}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "revision", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Revision
        {
            get;
            set;
        }
    }
}

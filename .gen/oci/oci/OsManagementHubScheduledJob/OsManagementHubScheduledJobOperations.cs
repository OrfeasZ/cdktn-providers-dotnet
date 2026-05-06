using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.OsManagementHubScheduledJob
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.osManagementHubScheduledJob.OsManagementHubScheduledJobOperations")]
    public class OsManagementHubScheduledJobOperations : oci.OsManagementHubScheduledJob.IOsManagementHubScheduledJobOperations
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/os_management_hub_scheduled_job#operation_type OsManagementHubScheduledJob#operation_type}.</summary>
        [JsiiProperty(name: "operationType", typeJson: "{\"primitive\":\"string\"}")]
        public string OperationType
        {
            get;
            set;
        }

        /// <summary>manage_module_streams_details block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/os_management_hub_scheduled_job#manage_module_streams_details OsManagementHubScheduledJob#manage_module_streams_details}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "manageModuleStreamsDetails", typeJson: "{\"fqn\":\"oci.osManagementHubScheduledJob.OsManagementHubScheduledJobOperationsManageModuleStreamsDetails\"}", isOptional: true)]
        public oci.OsManagementHubScheduledJob.IOsManagementHubScheduledJobOperationsManageModuleStreamsDetails? ManageModuleStreamsDetails
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/os_management_hub_scheduled_job#package_names OsManagementHubScheduledJob#package_names}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "packageNames", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? PackageNames
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/os_management_hub_scheduled_job#reboot_timeout_in_mins OsManagementHubScheduledJob#reboot_timeout_in_mins}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "rebootTimeoutInMins", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? RebootTimeoutInMins
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/os_management_hub_scheduled_job#software_source_ids OsManagementHubScheduledJob#software_source_ids}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "softwareSourceIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? SoftwareSourceIds
        {
            get;
            set;
        }

        /// <summary>switch_module_streams_details block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/os_management_hub_scheduled_job#switch_module_streams_details OsManagementHubScheduledJob#switch_module_streams_details}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "switchModuleStreamsDetails", typeJson: "{\"fqn\":\"oci.osManagementHubScheduledJob.OsManagementHubScheduledJobOperationsSwitchModuleStreamsDetails\"}", isOptional: true)]
        public oci.OsManagementHubScheduledJob.IOsManagementHubScheduledJobOperationsSwitchModuleStreamsDetails? SwitchModuleStreamsDetails
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/os_management_hub_scheduled_job#windows_update_names OsManagementHubScheduledJob#windows_update_names}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "windowsUpdateNames", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? WindowsUpdateNames
        {
            get;
            set;
        }
    }
}

using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.StackMonitoringMaintenanceWindowsRetryFailedOperation
{
    [JsiiByValue(fqn: "oci.stackMonitoringMaintenanceWindowsRetryFailedOperation.StackMonitoringMaintenanceWindowsRetryFailedOperationTimeouts")]
    public class StackMonitoringMaintenanceWindowsRetryFailedOperationTimeouts : oci.StackMonitoringMaintenanceWindowsRetryFailedOperation.IStackMonitoringMaintenanceWindowsRetryFailedOperationTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/stack_monitoring_maintenance_windows_retry_failed_operation#create StackMonitoringMaintenanceWindowsRetryFailedOperation#create}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Create
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/stack_monitoring_maintenance_windows_retry_failed_operation#delete StackMonitoringMaintenanceWindowsRetryFailedOperation#delete}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Delete
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/stack_monitoring_maintenance_windows_retry_failed_operation#update StackMonitoringMaintenanceWindowsRetryFailedOperation#update}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "update", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Update
        {
            get;
            set;
        }
    }
}

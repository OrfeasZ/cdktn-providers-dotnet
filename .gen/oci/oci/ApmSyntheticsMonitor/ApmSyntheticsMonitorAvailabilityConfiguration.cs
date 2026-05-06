using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.ApmSyntheticsMonitor
{
    [JsiiByValue(fqn: "oci.apmSyntheticsMonitor.ApmSyntheticsMonitorAvailabilityConfiguration")]
    public class ApmSyntheticsMonitorAvailabilityConfiguration : oci.ApmSyntheticsMonitor.IApmSyntheticsMonitorAvailabilityConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/apm_synthetics_monitor#max_allowed_failures_per_interval ApmSyntheticsMonitor#max_allowed_failures_per_interval}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "maxAllowedFailuresPerInterval", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? MaxAllowedFailuresPerInterval
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/apm_synthetics_monitor#min_allowed_runs_per_interval ApmSyntheticsMonitor#min_allowed_runs_per_interval}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "minAllowedRunsPerInterval", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? MinAllowedRunsPerInterval
        {
            get;
            set;
        }
    }
}

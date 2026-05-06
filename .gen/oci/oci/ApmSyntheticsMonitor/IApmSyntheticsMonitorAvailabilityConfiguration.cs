using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.ApmSyntheticsMonitor
{
    [JsiiInterface(nativeType: typeof(IApmSyntheticsMonitorAvailabilityConfiguration), fullyQualifiedName: "oci.apmSyntheticsMonitor.ApmSyntheticsMonitorAvailabilityConfiguration")]
    public interface IApmSyntheticsMonitorAvailabilityConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/apm_synthetics_monitor#max_allowed_failures_per_interval ApmSyntheticsMonitor#max_allowed_failures_per_interval}.</summary>
        [JsiiProperty(name: "maxAllowedFailuresPerInterval", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? MaxAllowedFailuresPerInterval
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/apm_synthetics_monitor#min_allowed_runs_per_interval ApmSyntheticsMonitor#min_allowed_runs_per_interval}.</summary>
        [JsiiProperty(name: "minAllowedRunsPerInterval", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? MinAllowedRunsPerInterval
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IApmSyntheticsMonitorAvailabilityConfiguration), fullyQualifiedName: "oci.apmSyntheticsMonitor.ApmSyntheticsMonitorAvailabilityConfiguration")]
        internal sealed class _Proxy : DeputyBase, oci.ApmSyntheticsMonitor.IApmSyntheticsMonitorAvailabilityConfiguration
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/apm_synthetics_monitor#max_allowed_failures_per_interval ApmSyntheticsMonitor#max_allowed_failures_per_interval}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "maxAllowedFailuresPerInterval", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? MaxAllowedFailuresPerInterval
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/apm_synthetics_monitor#min_allowed_runs_per_interval ApmSyntheticsMonitor#min_allowed_runs_per_interval}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "minAllowedRunsPerInterval", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? MinAllowedRunsPerInterval
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}

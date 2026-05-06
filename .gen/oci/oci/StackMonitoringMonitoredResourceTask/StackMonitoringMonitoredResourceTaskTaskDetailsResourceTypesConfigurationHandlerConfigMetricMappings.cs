using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.StackMonitoringMonitoredResourceTask
{
    [JsiiByValue(fqn: "oci.stackMonitoringMonitoredResourceTask.StackMonitoringMonitoredResourceTaskTaskDetailsResourceTypesConfigurationHandlerConfigMetricMappings")]
    public class StackMonitoringMonitoredResourceTaskTaskDetailsResourceTypesConfigurationHandlerConfigMetricMappings : oci.StackMonitoringMonitoredResourceTask.IStackMonitoringMonitoredResourceTaskTaskDetailsResourceTypesConfigurationHandlerConfigMetricMappings
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/stack_monitoring_monitored_resource_task#collector_metric_name StackMonitoringMonitoredResourceTask#collector_metric_name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "collectorMetricName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? CollectorMetricName
        {
            get;
            set;
        }

        private object? _isSkipUpload;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/stack_monitoring_monitored_resource_task#is_skip_upload StackMonitoringMonitoredResourceTask#is_skip_upload}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "isSkipUpload", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? IsSkipUpload
        {
            get => _isSkipUpload;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case bool cast_cd4240:
                            break;
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _isSkipUpload = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/stack_monitoring_monitored_resource_task#metric_upload_interval_in_seconds StackMonitoringMonitoredResourceTask#metric_upload_interval_in_seconds}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "metricUploadIntervalInSeconds", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? MetricUploadIntervalInSeconds
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/stack_monitoring_monitored_resource_task#telemetry_metric_name StackMonitoringMonitoredResourceTask#telemetry_metric_name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "telemetryMetricName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? TelemetryMetricName
        {
            get;
            set;
        }
    }
}

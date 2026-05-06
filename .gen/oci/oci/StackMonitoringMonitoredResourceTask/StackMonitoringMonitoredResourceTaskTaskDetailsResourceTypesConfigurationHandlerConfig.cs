using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.StackMonitoringMonitoredResourceTask
{
    [JsiiByValue(fqn: "oci.stackMonitoringMonitoredResourceTask.StackMonitoringMonitoredResourceTaskTaskDetailsResourceTypesConfigurationHandlerConfig")]
    public class StackMonitoringMonitoredResourceTaskTaskDetailsResourceTypesConfigurationHandlerConfig : oci.StackMonitoringMonitoredResourceTask.IStackMonitoringMonitoredResourceTaskTaskDetailsResourceTypesConfigurationHandlerConfig
    {
        /// <summary>collectd_resource_name_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/stack_monitoring_monitored_resource_task#collectd_resource_name_config StackMonitoringMonitoredResourceTask#collectd_resource_name_config}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "collectdResourceNameConfig", typeJson: "{\"fqn\":\"oci.stackMonitoringMonitoredResourceTask.StackMonitoringMonitoredResourceTaskTaskDetailsResourceTypesConfigurationHandlerConfigCollectdResourceNameConfig\"}", isOptional: true)]
        public oci.StackMonitoringMonitoredResourceTask.IStackMonitoringMonitoredResourceTaskTaskDetailsResourceTypesConfigurationHandlerConfigCollectdResourceNameConfig? CollectdResourceNameConfig
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/stack_monitoring_monitored_resource_task#collector_types StackMonitoringMonitoredResourceTask#collector_types}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "collectorTypes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? CollectorTypes
        {
            get;
            set;
        }

        private object? _handlerProperties;

        /// <summary>handler_properties block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/stack_monitoring_monitored_resource_task#handler_properties StackMonitoringMonitoredResourceTask#handler_properties}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "handlerProperties", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.stackMonitoringMonitoredResourceTask.StackMonitoringMonitoredResourceTaskTaskDetailsResourceTypesConfigurationHandlerConfigHandlerProperties\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? HandlerProperties
        {
            get => _handlerProperties;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case oci.StackMonitoringMonitoredResourceTask.IStackMonitoringMonitoredResourceTaskTaskDetailsResourceTypesConfigurationHandlerConfigHandlerProperties[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.StackMonitoringMonitoredResourceTask.IStackMonitoringMonitoredResourceTaskTaskDetailsResourceTypesConfigurationHandlerConfigHandlerProperties).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _handlerProperties = value;
            }
        }

        private object? _metricMappings;

        /// <summary>metric_mappings block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/stack_monitoring_monitored_resource_task#metric_mappings StackMonitoringMonitoredResourceTask#metric_mappings}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "metricMappings", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.stackMonitoringMonitoredResourceTask.StackMonitoringMonitoredResourceTaskTaskDetailsResourceTypesConfigurationHandlerConfigMetricMappings\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? MetricMappings
        {
            get => _metricMappings;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case oci.StackMonitoringMonitoredResourceTask.IStackMonitoringMonitoredResourceTaskTaskDetailsResourceTypesConfigurationHandlerConfigMetricMappings[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.StackMonitoringMonitoredResourceTask.IStackMonitoringMonitoredResourceTaskTaskDetailsResourceTypesConfigurationHandlerConfigMetricMappings).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _metricMappings = value;
            }
        }

        /// <summary>metric_name_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/stack_monitoring_monitored_resource_task#metric_name_config StackMonitoringMonitoredResourceTask#metric_name_config}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "metricNameConfig", typeJson: "{\"fqn\":\"oci.stackMonitoringMonitoredResourceTask.StackMonitoringMonitoredResourceTaskTaskDetailsResourceTypesConfigurationHandlerConfigMetricNameConfig\"}", isOptional: true)]
        public oci.StackMonitoringMonitoredResourceTask.IStackMonitoringMonitoredResourceTaskTaskDetailsResourceTypesConfigurationHandlerConfigMetricNameConfig? MetricNameConfig
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/stack_monitoring_monitored_resource_task#metric_upload_interval_in_seconds StackMonitoringMonitoredResourceTask#metric_upload_interval_in_seconds}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "metricUploadIntervalInSeconds", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? MetricUploadIntervalInSeconds
        {
            get;
            set;
        }

        /// <summary>telegraf_resource_name_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/stack_monitoring_monitored_resource_task#telegraf_resource_name_config StackMonitoringMonitoredResourceTask#telegraf_resource_name_config}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "telegrafResourceNameConfig", typeJson: "{\"fqn\":\"oci.stackMonitoringMonitoredResourceTask.StackMonitoringMonitoredResourceTaskTaskDetailsResourceTypesConfigurationHandlerConfigTelegrafResourceNameConfig\"}", isOptional: true)]
        public oci.StackMonitoringMonitoredResourceTask.IStackMonitoringMonitoredResourceTaskTaskDetailsResourceTypesConfigurationHandlerConfigTelegrafResourceNameConfig? TelegrafResourceNameConfig
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/stack_monitoring_monitored_resource_task#telemetry_resource_group StackMonitoringMonitoredResourceTask#telemetry_resource_group}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "telemetryResourceGroup", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? TelemetryResourceGroup
        {
            get;
            set;
        }
    }
}

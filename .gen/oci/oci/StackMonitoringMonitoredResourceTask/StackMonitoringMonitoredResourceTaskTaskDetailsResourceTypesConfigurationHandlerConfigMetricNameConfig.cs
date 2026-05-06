using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.StackMonitoringMonitoredResourceTask
{
    [JsiiByValue(fqn: "oci.stackMonitoringMonitoredResourceTask.StackMonitoringMonitoredResourceTaskTaskDetailsResourceTypesConfigurationHandlerConfigMetricNameConfig")]
    public class StackMonitoringMonitoredResourceTaskTaskDetailsResourceTypesConfigurationHandlerConfigMetricNameConfig : oci.StackMonitoringMonitoredResourceTask.IStackMonitoringMonitoredResourceTaskTaskDetailsResourceTypesConfigurationHandlerConfigMetricNameConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/stack_monitoring_monitored_resource_task#exclude_pattern_on_prefix StackMonitoringMonitoredResourceTask#exclude_pattern_on_prefix}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "excludePatternOnPrefix", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ExcludePatternOnPrefix
        {
            get;
            set;
        }

        private object? _isPrefixWithCollectorType;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/stack_monitoring_monitored_resource_task#is_prefix_with_collector_type StackMonitoringMonitoredResourceTask#is_prefix_with_collector_type}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "isPrefixWithCollectorType", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? IsPrefixWithCollectorType
        {
            get => _isPrefixWithCollectorType;
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
                _isPrefixWithCollectorType = value;
            }
        }
    }
}

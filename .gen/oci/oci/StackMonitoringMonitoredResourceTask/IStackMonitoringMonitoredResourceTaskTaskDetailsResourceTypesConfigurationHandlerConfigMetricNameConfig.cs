using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.StackMonitoringMonitoredResourceTask
{
    [JsiiInterface(nativeType: typeof(IStackMonitoringMonitoredResourceTaskTaskDetailsResourceTypesConfigurationHandlerConfigMetricNameConfig), fullyQualifiedName: "oci.stackMonitoringMonitoredResourceTask.StackMonitoringMonitoredResourceTaskTaskDetailsResourceTypesConfigurationHandlerConfigMetricNameConfig")]
    public interface IStackMonitoringMonitoredResourceTaskTaskDetailsResourceTypesConfigurationHandlerConfigMetricNameConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/stack_monitoring_monitored_resource_task#exclude_pattern_on_prefix StackMonitoringMonitoredResourceTask#exclude_pattern_on_prefix}.</summary>
        [JsiiProperty(name: "excludePatternOnPrefix", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ExcludePatternOnPrefix
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/stack_monitoring_monitored_resource_task#is_prefix_with_collector_type StackMonitoringMonitoredResourceTask#is_prefix_with_collector_type}.</summary>
        [JsiiProperty(name: "isPrefixWithCollectorType", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? IsPrefixWithCollectorType
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IStackMonitoringMonitoredResourceTaskTaskDetailsResourceTypesConfigurationHandlerConfigMetricNameConfig), fullyQualifiedName: "oci.stackMonitoringMonitoredResourceTask.StackMonitoringMonitoredResourceTaskTaskDetailsResourceTypesConfigurationHandlerConfigMetricNameConfig")]
        internal sealed class _Proxy : DeputyBase, oci.StackMonitoringMonitoredResourceTask.IStackMonitoringMonitoredResourceTaskTaskDetailsResourceTypesConfigurationHandlerConfigMetricNameConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/stack_monitoring_monitored_resource_task#exclude_pattern_on_prefix StackMonitoringMonitoredResourceTask#exclude_pattern_on_prefix}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "excludePatternOnPrefix", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ExcludePatternOnPrefix
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/stack_monitoring_monitored_resource_task#is_prefix_with_collector_type StackMonitoringMonitoredResourceTask#is_prefix_with_collector_type}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "isPrefixWithCollectorType", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? IsPrefixWithCollectorType
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}

using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.StackMonitoringMonitoredResourceTask
{
    [JsiiInterface(nativeType: typeof(IStackMonitoringMonitoredResourceTaskTaskDetailsResourceTypesConfigurationHandlerConfig), fullyQualifiedName: "oci.stackMonitoringMonitoredResourceTask.StackMonitoringMonitoredResourceTaskTaskDetailsResourceTypesConfigurationHandlerConfig")]
    public interface IStackMonitoringMonitoredResourceTaskTaskDetailsResourceTypesConfigurationHandlerConfig
    {
        /// <summary>collectd_resource_name_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/stack_monitoring_monitored_resource_task#collectd_resource_name_config StackMonitoringMonitoredResourceTask#collectd_resource_name_config}
        /// </remarks>
        [JsiiProperty(name: "collectdResourceNameConfig", typeJson: "{\"fqn\":\"oci.stackMonitoringMonitoredResourceTask.StackMonitoringMonitoredResourceTaskTaskDetailsResourceTypesConfigurationHandlerConfigCollectdResourceNameConfig\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.StackMonitoringMonitoredResourceTask.IStackMonitoringMonitoredResourceTaskTaskDetailsResourceTypesConfigurationHandlerConfigCollectdResourceNameConfig? CollectdResourceNameConfig
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/stack_monitoring_monitored_resource_task#collector_types StackMonitoringMonitoredResourceTask#collector_types}.</summary>
        [JsiiProperty(name: "collectorTypes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? CollectorTypes
        {
            get
            {
                return null;
            }
        }

        /// <summary>handler_properties block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/stack_monitoring_monitored_resource_task#handler_properties StackMonitoringMonitoredResourceTask#handler_properties}
        /// </remarks>
        [JsiiProperty(name: "handlerProperties", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.stackMonitoringMonitoredResourceTask.StackMonitoringMonitoredResourceTaskTaskDetailsResourceTypesConfigurationHandlerConfigHandlerProperties\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? HandlerProperties
        {
            get
            {
                return null;
            }
        }

        /// <summary>metric_mappings block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/stack_monitoring_monitored_resource_task#metric_mappings StackMonitoringMonitoredResourceTask#metric_mappings}
        /// </remarks>
        [JsiiProperty(name: "metricMappings", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.stackMonitoringMonitoredResourceTask.StackMonitoringMonitoredResourceTaskTaskDetailsResourceTypesConfigurationHandlerConfigMetricMappings\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? MetricMappings
        {
            get
            {
                return null;
            }
        }

        /// <summary>metric_name_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/stack_monitoring_monitored_resource_task#metric_name_config StackMonitoringMonitoredResourceTask#metric_name_config}
        /// </remarks>
        [JsiiProperty(name: "metricNameConfig", typeJson: "{\"fqn\":\"oci.stackMonitoringMonitoredResourceTask.StackMonitoringMonitoredResourceTaskTaskDetailsResourceTypesConfigurationHandlerConfigMetricNameConfig\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.StackMonitoringMonitoredResourceTask.IStackMonitoringMonitoredResourceTaskTaskDetailsResourceTypesConfigurationHandlerConfigMetricNameConfig? MetricNameConfig
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/stack_monitoring_monitored_resource_task#metric_upload_interval_in_seconds StackMonitoringMonitoredResourceTask#metric_upload_interval_in_seconds}.</summary>
        [JsiiProperty(name: "metricUploadIntervalInSeconds", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? MetricUploadIntervalInSeconds
        {
            get
            {
                return null;
            }
        }

        /// <summary>telegraf_resource_name_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/stack_monitoring_monitored_resource_task#telegraf_resource_name_config StackMonitoringMonitoredResourceTask#telegraf_resource_name_config}
        /// </remarks>
        [JsiiProperty(name: "telegrafResourceNameConfig", typeJson: "{\"fqn\":\"oci.stackMonitoringMonitoredResourceTask.StackMonitoringMonitoredResourceTaskTaskDetailsResourceTypesConfigurationHandlerConfigTelegrafResourceNameConfig\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.StackMonitoringMonitoredResourceTask.IStackMonitoringMonitoredResourceTaskTaskDetailsResourceTypesConfigurationHandlerConfigTelegrafResourceNameConfig? TelegrafResourceNameConfig
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/stack_monitoring_monitored_resource_task#telemetry_resource_group StackMonitoringMonitoredResourceTask#telemetry_resource_group}.</summary>
        [JsiiProperty(name: "telemetryResourceGroup", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? TelemetryResourceGroup
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IStackMonitoringMonitoredResourceTaskTaskDetailsResourceTypesConfigurationHandlerConfig), fullyQualifiedName: "oci.stackMonitoringMonitoredResourceTask.StackMonitoringMonitoredResourceTaskTaskDetailsResourceTypesConfigurationHandlerConfig")]
        internal sealed class _Proxy : DeputyBase, oci.StackMonitoringMonitoredResourceTask.IStackMonitoringMonitoredResourceTaskTaskDetailsResourceTypesConfigurationHandlerConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>collectd_resource_name_config block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/stack_monitoring_monitored_resource_task#collectd_resource_name_config StackMonitoringMonitoredResourceTask#collectd_resource_name_config}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "collectdResourceNameConfig", typeJson: "{\"fqn\":\"oci.stackMonitoringMonitoredResourceTask.StackMonitoringMonitoredResourceTaskTaskDetailsResourceTypesConfigurationHandlerConfigCollectdResourceNameConfig\"}", isOptional: true)]
            public oci.StackMonitoringMonitoredResourceTask.IStackMonitoringMonitoredResourceTaskTaskDetailsResourceTypesConfigurationHandlerConfigCollectdResourceNameConfig? CollectdResourceNameConfig
            {
                get => GetInstanceProperty<oci.StackMonitoringMonitoredResourceTask.IStackMonitoringMonitoredResourceTaskTaskDetailsResourceTypesConfigurationHandlerConfigCollectdResourceNameConfig?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/stack_monitoring_monitored_resource_task#collector_types StackMonitoringMonitoredResourceTask#collector_types}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "collectorTypes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? CollectorTypes
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>handler_properties block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/stack_monitoring_monitored_resource_task#handler_properties StackMonitoringMonitoredResourceTask#handler_properties}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "handlerProperties", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.stackMonitoringMonitoredResourceTask.StackMonitoringMonitoredResourceTaskTaskDetailsResourceTypesConfigurationHandlerConfigHandlerProperties\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? HandlerProperties
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>metric_mappings block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/stack_monitoring_monitored_resource_task#metric_mappings StackMonitoringMonitoredResourceTask#metric_mappings}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "metricMappings", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.stackMonitoringMonitoredResourceTask.StackMonitoringMonitoredResourceTaskTaskDetailsResourceTypesConfigurationHandlerConfigMetricMappings\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? MetricMappings
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>metric_name_config block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/stack_monitoring_monitored_resource_task#metric_name_config StackMonitoringMonitoredResourceTask#metric_name_config}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "metricNameConfig", typeJson: "{\"fqn\":\"oci.stackMonitoringMonitoredResourceTask.StackMonitoringMonitoredResourceTaskTaskDetailsResourceTypesConfigurationHandlerConfigMetricNameConfig\"}", isOptional: true)]
            public oci.StackMonitoringMonitoredResourceTask.IStackMonitoringMonitoredResourceTaskTaskDetailsResourceTypesConfigurationHandlerConfigMetricNameConfig? MetricNameConfig
            {
                get => GetInstanceProperty<oci.StackMonitoringMonitoredResourceTask.IStackMonitoringMonitoredResourceTaskTaskDetailsResourceTypesConfigurationHandlerConfigMetricNameConfig?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/stack_monitoring_monitored_resource_task#metric_upload_interval_in_seconds StackMonitoringMonitoredResourceTask#metric_upload_interval_in_seconds}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "metricUploadIntervalInSeconds", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? MetricUploadIntervalInSeconds
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>telegraf_resource_name_config block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/stack_monitoring_monitored_resource_task#telegraf_resource_name_config StackMonitoringMonitoredResourceTask#telegraf_resource_name_config}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "telegrafResourceNameConfig", typeJson: "{\"fqn\":\"oci.stackMonitoringMonitoredResourceTask.StackMonitoringMonitoredResourceTaskTaskDetailsResourceTypesConfigurationHandlerConfigTelegrafResourceNameConfig\"}", isOptional: true)]
            public oci.StackMonitoringMonitoredResourceTask.IStackMonitoringMonitoredResourceTaskTaskDetailsResourceTypesConfigurationHandlerConfigTelegrafResourceNameConfig? TelegrafResourceNameConfig
            {
                get => GetInstanceProperty<oci.StackMonitoringMonitoredResourceTask.IStackMonitoringMonitoredResourceTaskTaskDetailsResourceTypesConfigurationHandlerConfigTelegrafResourceNameConfig?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/stack_monitoring_monitored_resource_task#telemetry_resource_group StackMonitoringMonitoredResourceTask#telemetry_resource_group}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "telemetryResourceGroup", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? TelemetryResourceGroup
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}

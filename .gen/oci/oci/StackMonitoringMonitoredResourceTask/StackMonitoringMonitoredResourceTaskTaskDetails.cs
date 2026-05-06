using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.StackMonitoringMonitoredResourceTask
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.stackMonitoringMonitoredResourceTask.StackMonitoringMonitoredResourceTaskTaskDetails")]
    public class StackMonitoringMonitoredResourceTaskTaskDetails : oci.StackMonitoringMonitoredResourceTask.IStackMonitoringMonitoredResourceTaskTaskDetails
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/stack_monitoring_monitored_resource_task#type StackMonitoringMonitoredResourceTask#type}.</summary>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        public string Type
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/stack_monitoring_monitored_resource_task#agent_id StackMonitoringMonitoredResourceTask#agent_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "agentId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? AgentId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/stack_monitoring_monitored_resource_task#availability_proxy_metric_collection_interval StackMonitoringMonitoredResourceTask#availability_proxy_metric_collection_interval}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "availabilityProxyMetricCollectionInterval", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? AvailabilityProxyMetricCollectionInterval
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/stack_monitoring_monitored_resource_task#availability_proxy_metrics StackMonitoringMonitoredResourceTask#availability_proxy_metrics}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "availabilityProxyMetrics", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? AvailabilityProxyMetrics
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/stack_monitoring_monitored_resource_task#console_path_prefix StackMonitoringMonitoredResourceTask#console_path_prefix}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "consolePathPrefix", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ConsolePathPrefix
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/stack_monitoring_monitored_resource_task#external_id_mapping StackMonitoringMonitoredResourceTask#external_id_mapping}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "externalIdMapping", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ExternalIdMapping
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/stack_monitoring_monitored_resource_task#handler_type StackMonitoringMonitoredResourceTask#handler_type}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "handlerType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? HandlerType
        {
            get;
            set;
        }

        private object? _isEnable;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/stack_monitoring_monitored_resource_task#is_enable StackMonitoringMonitoredResourceTask#is_enable}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "isEnable", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? IsEnable
        {
            get => _isEnable;
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
                _isEnable = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/stack_monitoring_monitored_resource_task#lifecycle_status_mappings_for_up_status StackMonitoringMonitoredResourceTask#lifecycle_status_mappings_for_up_status}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "lifecycleStatusMappingsForUpStatus", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? LifecycleStatusMappingsForUpStatus
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/stack_monitoring_monitored_resource_task#namespace StackMonitoringMonitoredResourceTask#namespace}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "namespace", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Namespace
        {
            get;
            set;
        }

        /// <summary>receiver_properties block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/stack_monitoring_monitored_resource_task#receiver_properties StackMonitoringMonitoredResourceTask#receiver_properties}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "receiverProperties", typeJson: "{\"fqn\":\"oci.stackMonitoringMonitoredResourceTask.StackMonitoringMonitoredResourceTaskTaskDetailsReceiverProperties\"}", isOptional: true)]
        public oci.StackMonitoringMonitoredResourceTask.IStackMonitoringMonitoredResourceTaskTaskDetailsReceiverProperties? ReceiverProperties
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/stack_monitoring_monitored_resource_task#resource_group StackMonitoringMonitoredResourceTask#resource_group}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "resourceGroup", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ResourceGroup
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/stack_monitoring_monitored_resource_task#resource_name_filter StackMonitoringMonitoredResourceTask#resource_name_filter}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "resourceNameFilter", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ResourceNameFilter
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/stack_monitoring_monitored_resource_task#resource_name_mapping StackMonitoringMonitoredResourceTask#resource_name_mapping}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "resourceNameMapping", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ResourceNameMapping
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/stack_monitoring_monitored_resource_task#resource_type_filter StackMonitoringMonitoredResourceTask#resource_type_filter}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "resourceTypeFilter", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ResourceTypeFilter
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/stack_monitoring_monitored_resource_task#resource_type_mapping StackMonitoringMonitoredResourceTask#resource_type_mapping}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "resourceTypeMapping", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ResourceTypeMapping
        {
            get;
            set;
        }

        private object? _resourceTypesConfiguration;

        /// <summary>resource_types_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/stack_monitoring_monitored_resource_task#resource_types_configuration StackMonitoringMonitoredResourceTask#resource_types_configuration}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "resourceTypesConfiguration", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.stackMonitoringMonitoredResourceTask.StackMonitoringMonitoredResourceTaskTaskDetailsResourceTypesConfiguration\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? ResourceTypesConfiguration
        {
            get => _resourceTypesConfiguration;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case oci.StackMonitoringMonitoredResourceTask.IStackMonitoringMonitoredResourceTaskTaskDetailsResourceTypesConfiguration[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.StackMonitoringMonitoredResourceTask.IStackMonitoringMonitoredResourceTaskTaskDetailsResourceTypesConfiguration).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _resourceTypesConfiguration = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/stack_monitoring_monitored_resource_task#service_base_url StackMonitoringMonitoredResourceTask#service_base_url}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "serviceBaseUrl", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ServiceBaseUrl
        {
            get;
            set;
        }

        private object? _shouldUseMetricsFlowForStatus;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/stack_monitoring_monitored_resource_task#should_use_metrics_flow_for_status StackMonitoringMonitoredResourceTask#should_use_metrics_flow_for_status}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "shouldUseMetricsFlowForStatus", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? ShouldUseMetricsFlowForStatus
        {
            get => _shouldUseMetricsFlowForStatus;
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
                _shouldUseMetricsFlowForStatus = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/stack_monitoring_monitored_resource_task#source StackMonitoringMonitoredResourceTask#source}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "source", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Source
        {
            get;
            set;
        }
    }
}

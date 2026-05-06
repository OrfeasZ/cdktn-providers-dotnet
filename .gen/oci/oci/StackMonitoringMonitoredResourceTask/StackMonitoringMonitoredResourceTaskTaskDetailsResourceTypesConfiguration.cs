using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.StackMonitoringMonitoredResourceTask
{
    [JsiiByValue(fqn: "oci.stackMonitoringMonitoredResourceTask.StackMonitoringMonitoredResourceTaskTaskDetailsResourceTypesConfiguration")]
    public class StackMonitoringMonitoredResourceTaskTaskDetailsResourceTypesConfiguration : oci.StackMonitoringMonitoredResourceTask.IStackMonitoringMonitoredResourceTaskTaskDetailsResourceTypesConfiguration
    {
        /// <summary>availability_metrics_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/stack_monitoring_monitored_resource_task#availability_metrics_config StackMonitoringMonitoredResourceTask#availability_metrics_config}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "availabilityMetricsConfig", typeJson: "{\"fqn\":\"oci.stackMonitoringMonitoredResourceTask.StackMonitoringMonitoredResourceTaskTaskDetailsResourceTypesConfigurationAvailabilityMetricsConfig\"}", isOptional: true)]
        public oci.StackMonitoringMonitoredResourceTask.IStackMonitoringMonitoredResourceTaskTaskDetailsResourceTypesConfigurationAvailabilityMetricsConfig? AvailabilityMetricsConfig
        {
            get;
            set;
        }

        /// <summary>handler_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/stack_monitoring_monitored_resource_task#handler_config StackMonitoringMonitoredResourceTask#handler_config}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "handlerConfig", typeJson: "{\"fqn\":\"oci.stackMonitoringMonitoredResourceTask.StackMonitoringMonitoredResourceTaskTaskDetailsResourceTypesConfigurationHandlerConfig\"}", isOptional: true)]
        public oci.StackMonitoringMonitoredResourceTask.IStackMonitoringMonitoredResourceTaskTaskDetailsResourceTypesConfigurationHandlerConfig? HandlerConfig
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/stack_monitoring_monitored_resource_task#resource_type StackMonitoringMonitoredResourceTask#resource_type}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "resourceType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ResourceType
        {
            get;
            set;
        }
    }
}

using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.StackMonitoringMonitoredResourceTask
{
    [JsiiByValue(fqn: "oci.stackMonitoringMonitoredResourceTask.StackMonitoringMonitoredResourceTaskTaskDetailsResourceTypesConfigurationHandlerConfigCollectdResourceNameConfig")]
    public class StackMonitoringMonitoredResourceTaskTaskDetailsResourceTypesConfigurationHandlerConfigCollectdResourceNameConfig : oci.StackMonitoringMonitoredResourceTask.IStackMonitoringMonitoredResourceTaskTaskDetailsResourceTypesConfigurationHandlerConfigCollectdResourceNameConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/stack_monitoring_monitored_resource_task#exclude_properties StackMonitoringMonitoredResourceTask#exclude_properties}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "excludeProperties", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? ExcludeProperties
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/stack_monitoring_monitored_resource_task#include_properties StackMonitoringMonitoredResourceTask#include_properties}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "includeProperties", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? IncludeProperties
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/stack_monitoring_monitored_resource_task#suffix StackMonitoringMonitoredResourceTask#suffix}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "suffix", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Suffix
        {
            get;
            set;
        }
    }
}

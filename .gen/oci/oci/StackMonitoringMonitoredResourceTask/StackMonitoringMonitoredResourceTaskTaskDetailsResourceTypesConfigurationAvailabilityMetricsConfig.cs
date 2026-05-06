using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.StackMonitoringMonitoredResourceTask
{
    [JsiiByValue(fqn: "oci.stackMonitoringMonitoredResourceTask.StackMonitoringMonitoredResourceTaskTaskDetailsResourceTypesConfigurationAvailabilityMetricsConfig")]
    public class StackMonitoringMonitoredResourceTaskTaskDetailsResourceTypesConfigurationAvailabilityMetricsConfig : oci.StackMonitoringMonitoredResourceTask.IStackMonitoringMonitoredResourceTaskTaskDetailsResourceTypesConfigurationAvailabilityMetricsConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/stack_monitoring_monitored_resource_task#collection_interval_in_seconds StackMonitoringMonitoredResourceTask#collection_interval_in_seconds}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "collectionIntervalInSeconds", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? CollectionIntervalInSeconds
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/stack_monitoring_monitored_resource_task#metrics StackMonitoringMonitoredResourceTask#metrics}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "metrics", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? Metrics
        {
            get;
            set;
        }
    }
}

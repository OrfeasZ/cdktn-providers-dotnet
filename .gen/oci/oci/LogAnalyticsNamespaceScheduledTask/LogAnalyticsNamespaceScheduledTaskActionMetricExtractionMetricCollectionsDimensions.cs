using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.LogAnalyticsNamespaceScheduledTask
{
    [JsiiByValue(fqn: "oci.logAnalyticsNamespaceScheduledTask.LogAnalyticsNamespaceScheduledTaskActionMetricExtractionMetricCollectionsDimensions")]
    public class LogAnalyticsNamespaceScheduledTaskActionMetricExtractionMetricCollectionsDimensions : oci.LogAnalyticsNamespaceScheduledTask.ILogAnalyticsNamespaceScheduledTaskActionMetricExtractionMetricCollectionsDimensions
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.20.0/docs/resources/log_analytics_namespace_scheduled_task#dimension_name LogAnalyticsNamespaceScheduledTask#dimension_name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "dimensionName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? DimensionName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.20.0/docs/resources/log_analytics_namespace_scheduled_task#query_field_name LogAnalyticsNamespaceScheduledTask#query_field_name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "queryFieldName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? QueryFieldName
        {
            get;
            set;
        }
    }
}

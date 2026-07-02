using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.LogAnalyticsNamespaceScheduledTask
{
    [JsiiInterface(nativeType: typeof(ILogAnalyticsNamespaceScheduledTaskActionMetricExtractionMetricCollectionsDimensions), fullyQualifiedName: "oci.logAnalyticsNamespaceScheduledTask.LogAnalyticsNamespaceScheduledTaskActionMetricExtractionMetricCollectionsDimensions")]
    public interface ILogAnalyticsNamespaceScheduledTaskActionMetricExtractionMetricCollectionsDimensions
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.21.0/docs/resources/log_analytics_namespace_scheduled_task#dimension_name LogAnalyticsNamespaceScheduledTask#dimension_name}.</summary>
        [JsiiProperty(name: "dimensionName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? DimensionName
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.21.0/docs/resources/log_analytics_namespace_scheduled_task#query_field_name LogAnalyticsNamespaceScheduledTask#query_field_name}.</summary>
        [JsiiProperty(name: "queryFieldName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? QueryFieldName
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ILogAnalyticsNamespaceScheduledTaskActionMetricExtractionMetricCollectionsDimensions), fullyQualifiedName: "oci.logAnalyticsNamespaceScheduledTask.LogAnalyticsNamespaceScheduledTaskActionMetricExtractionMetricCollectionsDimensions")]
        internal sealed class _Proxy : DeputyBase, oci.LogAnalyticsNamespaceScheduledTask.ILogAnalyticsNamespaceScheduledTaskActionMetricExtractionMetricCollectionsDimensions
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.21.0/docs/resources/log_analytics_namespace_scheduled_task#dimension_name LogAnalyticsNamespaceScheduledTask#dimension_name}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "dimensionName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? DimensionName
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.21.0/docs/resources/log_analytics_namespace_scheduled_task#query_field_name LogAnalyticsNamespaceScheduledTask#query_field_name}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "queryFieldName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? QueryFieldName
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}

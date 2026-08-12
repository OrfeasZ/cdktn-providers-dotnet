using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.LogAnalyticsNamespaceScheduledTask
{
    [JsiiInterface(nativeType: typeof(ILogAnalyticsNamespaceScheduledTaskActionMetricExtractionMetricCollections), fullyQualifiedName: "oci.logAnalyticsNamespaceScheduledTask.LogAnalyticsNamespaceScheduledTaskActionMetricExtractionMetricCollections")]
    public interface ILogAnalyticsNamespaceScheduledTaskActionMetricExtractionMetricCollections
    {
        /// <summary>dimensions block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.27.0/docs/resources/log_analytics_namespace_scheduled_task#dimensions LogAnalyticsNamespaceScheduledTask#dimensions}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="oci.LogAnalyticsNamespaceScheduledTask.ILogAnalyticsNamespaceScheduledTaskActionMetricExtractionMetricCollectionsDimensions" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "dimensions", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.logAnalyticsNamespaceScheduledTask.LogAnalyticsNamespaceScheduledTaskActionMetricExtractionMetricCollectionsDimensions\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Dimensions
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.27.0/docs/resources/log_analytics_namespace_scheduled_task#metric_name LogAnalyticsNamespaceScheduledTask#metric_name}.</summary>
        [JsiiProperty(name: "metricName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? MetricName
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.27.0/docs/resources/log_analytics_namespace_scheduled_task#metric_query_field_name LogAnalyticsNamespaceScheduledTask#metric_query_field_name}.</summary>
        [JsiiProperty(name: "metricQueryFieldName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? MetricQueryFieldName
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.27.0/docs/resources/log_analytics_namespace_scheduled_task#query_table_name LogAnalyticsNamespaceScheduledTask#query_table_name}.</summary>
        [JsiiProperty(name: "queryTableName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? QueryTableName
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ILogAnalyticsNamespaceScheduledTaskActionMetricExtractionMetricCollections), fullyQualifiedName: "oci.logAnalyticsNamespaceScheduledTask.LogAnalyticsNamespaceScheduledTaskActionMetricExtractionMetricCollections")]
        internal sealed class _Proxy : DeputyBase, oci.LogAnalyticsNamespaceScheduledTask.ILogAnalyticsNamespaceScheduledTaskActionMetricExtractionMetricCollections
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>dimensions block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.27.0/docs/resources/log_analytics_namespace_scheduled_task#dimensions LogAnalyticsNamespaceScheduledTask#dimensions}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="oci.LogAnalyticsNamespaceScheduledTask.ILogAnalyticsNamespaceScheduledTaskActionMetricExtractionMetricCollectionsDimensions" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "dimensions", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.logAnalyticsNamespaceScheduledTask.LogAnalyticsNamespaceScheduledTaskActionMetricExtractionMetricCollectionsDimensions\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Dimensions
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.27.0/docs/resources/log_analytics_namespace_scheduled_task#metric_name LogAnalyticsNamespaceScheduledTask#metric_name}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "metricName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? MetricName
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.27.0/docs/resources/log_analytics_namespace_scheduled_task#metric_query_field_name LogAnalyticsNamespaceScheduledTask#metric_query_field_name}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "metricQueryFieldName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? MetricQueryFieldName
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.27.0/docs/resources/log_analytics_namespace_scheduled_task#query_table_name LogAnalyticsNamespaceScheduledTask#query_table_name}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "queryTableName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? QueryTableName
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}

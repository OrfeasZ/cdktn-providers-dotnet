using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.LogAnalyticsNamespaceScheduledTask
{
    [JsiiByValue(fqn: "oci.logAnalyticsNamespaceScheduledTask.LogAnalyticsNamespaceScheduledTaskActionMetricExtractionMetricCollections")]
    public class LogAnalyticsNamespaceScheduledTaskActionMetricExtractionMetricCollections : oci.LogAnalyticsNamespaceScheduledTask.ILogAnalyticsNamespaceScheduledTaskActionMetricExtractionMetricCollections
    {
        private object? _dimensions;

        /// <summary>dimensions block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.29.0/docs/resources/log_analytics_namespace_scheduled_task#dimensions LogAnalyticsNamespaceScheduledTask#dimensions}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="oci.LogAnalyticsNamespaceScheduledTask.ILogAnalyticsNamespaceScheduledTaskActionMetricExtractionMetricCollectionsDimensions" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "dimensions", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.logAnalyticsNamespaceScheduledTask.LogAnalyticsNamespaceScheduledTaskActionMetricExtractionMetricCollectionsDimensions\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? Dimensions
        {
            get => _dimensions;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case oci.LogAnalyticsNamespaceScheduledTask.ILogAnalyticsNamespaceScheduledTaskActionMetricExtractionMetricCollectionsDimensions[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.LogAnalyticsNamespaceScheduledTask.ILogAnalyticsNamespaceScheduledTaskActionMetricExtractionMetricCollectionsDimensions).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _dimensions = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.29.0/docs/resources/log_analytics_namespace_scheduled_task#metric_name LogAnalyticsNamespaceScheduledTask#metric_name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "metricName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? MetricName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.29.0/docs/resources/log_analytics_namespace_scheduled_task#metric_query_field_name LogAnalyticsNamespaceScheduledTask#metric_query_field_name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "metricQueryFieldName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? MetricQueryFieldName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.29.0/docs/resources/log_analytics_namespace_scheduled_task#query_table_name LogAnalyticsNamespaceScheduledTask#query_table_name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "queryTableName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? QueryTableName
        {
            get;
            set;
        }
    }
}

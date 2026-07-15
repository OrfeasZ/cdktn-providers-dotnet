using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.LogAnalyticsNamespaceScheduledTask
{
    [JsiiByValue(fqn: "oci.logAnalyticsNamespaceScheduledTask.LogAnalyticsNamespaceScheduledTaskActionMetricExtraction")]
    public class LogAnalyticsNamespaceScheduledTaskActionMetricExtraction : oci.LogAnalyticsNamespaceScheduledTask.ILogAnalyticsNamespaceScheduledTaskActionMetricExtraction
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.23.0/docs/resources/log_analytics_namespace_scheduled_task#compartment_id LogAnalyticsNamespaceScheduledTask#compartment_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "compartmentId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? CompartmentId
        {
            get;
            set;
        }

        private object? _metricCollections;

        /// <summary>metric_collections block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.23.0/docs/resources/log_analytics_namespace_scheduled_task#metric_collections LogAnalyticsNamespaceScheduledTask#metric_collections}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="oci.LogAnalyticsNamespaceScheduledTask.ILogAnalyticsNamespaceScheduledTaskActionMetricExtractionMetricCollections" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "metricCollections", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.logAnalyticsNamespaceScheduledTask.LogAnalyticsNamespaceScheduledTaskActionMetricExtractionMetricCollections\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? MetricCollections
        {
            get => _metricCollections;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case oci.LogAnalyticsNamespaceScheduledTask.ILogAnalyticsNamespaceScheduledTaskActionMetricExtractionMetricCollections[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.LogAnalyticsNamespaceScheduledTask.ILogAnalyticsNamespaceScheduledTaskActionMetricExtractionMetricCollections).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _metricCollections = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.23.0/docs/resources/log_analytics_namespace_scheduled_task#metric_name LogAnalyticsNamespaceScheduledTask#metric_name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "metricName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? MetricName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.23.0/docs/resources/log_analytics_namespace_scheduled_task#namespace LogAnalyticsNamespaceScheduledTask#namespace}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "namespace", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Namespace
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.23.0/docs/resources/log_analytics_namespace_scheduled_task#resource_group LogAnalyticsNamespaceScheduledTask#resource_group}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "resourceGroup", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ResourceGroup
        {
            get;
            set;
        }
    }
}

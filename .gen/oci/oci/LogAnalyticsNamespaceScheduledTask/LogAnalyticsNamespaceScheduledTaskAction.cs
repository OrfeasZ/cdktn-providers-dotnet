using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.LogAnalyticsNamespaceScheduledTask
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.logAnalyticsNamespaceScheduledTask.LogAnalyticsNamespaceScheduledTaskAction")]
    public class LogAnalyticsNamespaceScheduledTaskAction : oci.LogAnalyticsNamespaceScheduledTask.ILogAnalyticsNamespaceScheduledTaskAction
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/log_analytics_namespace_scheduled_task#type LogAnalyticsNamespaceScheduledTask#type}.</summary>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        public string Type
        {
            get;
            set;
        }

        private object? _compartmentIdInSubtree;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/log_analytics_namespace_scheduled_task#compartment_id_in_subtree LogAnalyticsNamespaceScheduledTask#compartment_id_in_subtree}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "compartmentIdInSubtree", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? CompartmentIdInSubtree
        {
            get => _compartmentIdInSubtree;
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
                _compartmentIdInSubtree = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/log_analytics_namespace_scheduled_task#data_type LogAnalyticsNamespaceScheduledTask#data_type}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "dataType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? DataType
        {
            get;
            set;
        }

        /// <summary>metric_extraction block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/log_analytics_namespace_scheduled_task#metric_extraction LogAnalyticsNamespaceScheduledTask#metric_extraction}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "metricExtraction", typeJson: "{\"fqn\":\"oci.logAnalyticsNamespaceScheduledTask.LogAnalyticsNamespaceScheduledTaskActionMetricExtraction\"}", isOptional: true)]
        public oci.LogAnalyticsNamespaceScheduledTask.ILogAnalyticsNamespaceScheduledTaskActionMetricExtraction? MetricExtraction
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/log_analytics_namespace_scheduled_task#purge_compartment_id LogAnalyticsNamespaceScheduledTask#purge_compartment_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "purgeCompartmentId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? PurgeCompartmentId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/log_analytics_namespace_scheduled_task#purge_duration LogAnalyticsNamespaceScheduledTask#purge_duration}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "purgeDuration", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? PurgeDuration
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/log_analytics_namespace_scheduled_task#query_string LogAnalyticsNamespaceScheduledTask#query_string}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "queryString", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? QueryString
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/log_analytics_namespace_scheduled_task#saved_search_id LogAnalyticsNamespaceScheduledTask#saved_search_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "savedSearchId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? SavedSearchId
        {
            get;
            set;
        }

        /// <summary>template_details block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/log_analytics_namespace_scheduled_task#template_details LogAnalyticsNamespaceScheduledTask#template_details}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "templateDetails", typeJson: "{\"fqn\":\"oci.logAnalyticsNamespaceScheduledTask.LogAnalyticsNamespaceScheduledTaskActionTemplateDetails\"}", isOptional: true)]
        public oci.LogAnalyticsNamespaceScheduledTask.ILogAnalyticsNamespaceScheduledTaskActionTemplateDetails? TemplateDetails
        {
            get;
            set;
        }
    }
}

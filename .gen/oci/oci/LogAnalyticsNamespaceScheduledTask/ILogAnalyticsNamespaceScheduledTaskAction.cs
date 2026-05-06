using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.LogAnalyticsNamespaceScheduledTask
{
    [JsiiInterface(nativeType: typeof(ILogAnalyticsNamespaceScheduledTaskAction), fullyQualifiedName: "oci.logAnalyticsNamespaceScheduledTask.LogAnalyticsNamespaceScheduledTaskAction")]
    public interface ILogAnalyticsNamespaceScheduledTaskAction
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/log_analytics_namespace_scheduled_task#type LogAnalyticsNamespaceScheduledTask#type}.</summary>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        string Type
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/log_analytics_namespace_scheduled_task#compartment_id_in_subtree LogAnalyticsNamespaceScheduledTask#compartment_id_in_subtree}.</summary>
        [JsiiProperty(name: "compartmentIdInSubtree", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? CompartmentIdInSubtree
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/log_analytics_namespace_scheduled_task#data_type LogAnalyticsNamespaceScheduledTask#data_type}.</summary>
        [JsiiProperty(name: "dataType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? DataType
        {
            get
            {
                return null;
            }
        }

        /// <summary>metric_extraction block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/log_analytics_namespace_scheduled_task#metric_extraction LogAnalyticsNamespaceScheduledTask#metric_extraction}
        /// </remarks>
        [JsiiProperty(name: "metricExtraction", typeJson: "{\"fqn\":\"oci.logAnalyticsNamespaceScheduledTask.LogAnalyticsNamespaceScheduledTaskActionMetricExtraction\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.LogAnalyticsNamespaceScheduledTask.ILogAnalyticsNamespaceScheduledTaskActionMetricExtraction? MetricExtraction
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/log_analytics_namespace_scheduled_task#purge_compartment_id LogAnalyticsNamespaceScheduledTask#purge_compartment_id}.</summary>
        [JsiiProperty(name: "purgeCompartmentId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? PurgeCompartmentId
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/log_analytics_namespace_scheduled_task#purge_duration LogAnalyticsNamespaceScheduledTask#purge_duration}.</summary>
        [JsiiProperty(name: "purgeDuration", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? PurgeDuration
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/log_analytics_namespace_scheduled_task#query_string LogAnalyticsNamespaceScheduledTask#query_string}.</summary>
        [JsiiProperty(name: "queryString", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? QueryString
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/log_analytics_namespace_scheduled_task#saved_search_id LogAnalyticsNamespaceScheduledTask#saved_search_id}.</summary>
        [JsiiProperty(name: "savedSearchId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? SavedSearchId
        {
            get
            {
                return null;
            }
        }

        /// <summary>template_details block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/log_analytics_namespace_scheduled_task#template_details LogAnalyticsNamespaceScheduledTask#template_details}
        /// </remarks>
        [JsiiProperty(name: "templateDetails", typeJson: "{\"fqn\":\"oci.logAnalyticsNamespaceScheduledTask.LogAnalyticsNamespaceScheduledTaskActionTemplateDetails\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.LogAnalyticsNamespaceScheduledTask.ILogAnalyticsNamespaceScheduledTaskActionTemplateDetails? TemplateDetails
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ILogAnalyticsNamespaceScheduledTaskAction), fullyQualifiedName: "oci.logAnalyticsNamespaceScheduledTask.LogAnalyticsNamespaceScheduledTaskAction")]
        internal sealed class _Proxy : DeputyBase, oci.LogAnalyticsNamespaceScheduledTask.ILogAnalyticsNamespaceScheduledTaskAction
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/log_analytics_namespace_scheduled_task#type LogAnalyticsNamespaceScheduledTask#type}.</summary>
            [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
            public string Type
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/log_analytics_namespace_scheduled_task#compartment_id_in_subtree LogAnalyticsNamespaceScheduledTask#compartment_id_in_subtree}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "compartmentIdInSubtree", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? CompartmentIdInSubtree
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/log_analytics_namespace_scheduled_task#data_type LogAnalyticsNamespaceScheduledTask#data_type}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "dataType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? DataType
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>metric_extraction block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/log_analytics_namespace_scheduled_task#metric_extraction LogAnalyticsNamespaceScheduledTask#metric_extraction}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "metricExtraction", typeJson: "{\"fqn\":\"oci.logAnalyticsNamespaceScheduledTask.LogAnalyticsNamespaceScheduledTaskActionMetricExtraction\"}", isOptional: true)]
            public oci.LogAnalyticsNamespaceScheduledTask.ILogAnalyticsNamespaceScheduledTaskActionMetricExtraction? MetricExtraction
            {
                get => GetInstanceProperty<oci.LogAnalyticsNamespaceScheduledTask.ILogAnalyticsNamespaceScheduledTaskActionMetricExtraction?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/log_analytics_namespace_scheduled_task#purge_compartment_id LogAnalyticsNamespaceScheduledTask#purge_compartment_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "purgeCompartmentId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? PurgeCompartmentId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/log_analytics_namespace_scheduled_task#purge_duration LogAnalyticsNamespaceScheduledTask#purge_duration}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "purgeDuration", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? PurgeDuration
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/log_analytics_namespace_scheduled_task#query_string LogAnalyticsNamespaceScheduledTask#query_string}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "queryString", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? QueryString
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/log_analytics_namespace_scheduled_task#saved_search_id LogAnalyticsNamespaceScheduledTask#saved_search_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "savedSearchId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? SavedSearchId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>template_details block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/log_analytics_namespace_scheduled_task#template_details LogAnalyticsNamespaceScheduledTask#template_details}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "templateDetails", typeJson: "{\"fqn\":\"oci.logAnalyticsNamespaceScheduledTask.LogAnalyticsNamespaceScheduledTaskActionTemplateDetails\"}", isOptional: true)]
            public oci.LogAnalyticsNamespaceScheduledTask.ILogAnalyticsNamespaceScheduledTaskActionTemplateDetails? TemplateDetails
            {
                get => GetInstanceProperty<oci.LogAnalyticsNamespaceScheduledTask.ILogAnalyticsNamespaceScheduledTaskActionTemplateDetails?>();
            }
        }
    }
}

using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.StackMonitoringMetricExtension
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.stackMonitoringMetricExtension.StackMonitoringMetricExtensionQueryProperties")]
    public class StackMonitoringMetricExtensionQueryProperties : oci.StackMonitoringMetricExtension.IStackMonitoringMetricExtensionQueryProperties
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/stack_monitoring_metric_extension#collection_method StackMonitoringMetricExtension#collection_method}.</summary>
        [JsiiProperty(name: "collectionMethod", typeJson: "{\"primitive\":\"string\"}")]
        public string CollectionMethod
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/stack_monitoring_metric_extension#arguments StackMonitoringMetricExtension#arguments}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "arguments", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Arguments
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/stack_monitoring_metric_extension#auto_row_prefix StackMonitoringMetricExtension#auto_row_prefix}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "autoRowPrefix", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? AutoRowPrefix
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/stack_monitoring_metric_extension#command StackMonitoringMetricExtension#command}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "command", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Command
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/stack_monitoring_metric_extension#delimiter StackMonitoringMetricExtension#delimiter}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "delimiter", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Delimiter
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/stack_monitoring_metric_extension#identity_metric StackMonitoringMetricExtension#identity_metric}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "identityMetric", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? IdentityMetric
        {
            get;
            set;
        }

        private object? _inParamDetails;

        /// <summary>in_param_details block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/stack_monitoring_metric_extension#in_param_details StackMonitoringMetricExtension#in_param_details}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "inParamDetails", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.stackMonitoringMetricExtension.StackMonitoringMetricExtensionQueryPropertiesInParamDetails\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? InParamDetails
        {
            get => _inParamDetails;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case oci.StackMonitoringMetricExtension.IStackMonitoringMetricExtensionQueryPropertiesInParamDetails[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.StackMonitoringMetricExtension.IStackMonitoringMetricExtensionQueryPropertiesInParamDetails).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _inParamDetails = value;
            }
        }

        private object? _isMetricServiceEnabled;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/stack_monitoring_metric_extension#is_metric_service_enabled StackMonitoringMetricExtension#is_metric_service_enabled}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "isMetricServiceEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? IsMetricServiceEnabled
        {
            get => _isMetricServiceEnabled;
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
                _isMetricServiceEnabled = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/stack_monitoring_metric_extension#jmx_attributes StackMonitoringMetricExtension#jmx_attributes}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "jmxAttributes", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? JmxAttributes
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/stack_monitoring_metric_extension#managed_bean_query StackMonitoringMetricExtension#managed_bean_query}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "managedBeanQuery", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ManagedBeanQuery
        {
            get;
            set;
        }

        /// <summary>out_param_details block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/stack_monitoring_metric_extension#out_param_details StackMonitoringMetricExtension#out_param_details}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "outParamDetails", typeJson: "{\"fqn\":\"oci.stackMonitoringMetricExtension.StackMonitoringMetricExtensionQueryPropertiesOutParamDetails\"}", isOptional: true)]
        public oci.StackMonitoringMetricExtension.IStackMonitoringMetricExtensionQueryPropertiesOutParamDetails? OutParamDetails
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/stack_monitoring_metric_extension#protocol_type StackMonitoringMetricExtension#protocol_type}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "protocolType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ProtocolType
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/stack_monitoring_metric_extension#response_content_type StackMonitoringMetricExtension#response_content_type}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "responseContentType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ResponseContentType
        {
            get;
            set;
        }

        /// <summary>script_details block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/stack_monitoring_metric_extension#script_details StackMonitoringMetricExtension#script_details}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "scriptDetails", typeJson: "{\"fqn\":\"oci.stackMonitoringMetricExtension.StackMonitoringMetricExtensionQueryPropertiesScriptDetails\"}", isOptional: true)]
        public oci.StackMonitoringMetricExtension.IStackMonitoringMetricExtensionQueryPropertiesScriptDetails? ScriptDetails
        {
            get;
            set;
        }

        /// <summary>sql_details block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/stack_monitoring_metric_extension#sql_details StackMonitoringMetricExtension#sql_details}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "sqlDetails", typeJson: "{\"fqn\":\"oci.stackMonitoringMetricExtension.StackMonitoringMetricExtensionQueryPropertiesSqlDetails\"}", isOptional: true)]
        public oci.StackMonitoringMetricExtension.IStackMonitoringMetricExtensionQueryPropertiesSqlDetails? SqlDetails
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/stack_monitoring_metric_extension#sql_type StackMonitoringMetricExtension#sql_type}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "sqlType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? SqlType
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/stack_monitoring_metric_extension#starts_with StackMonitoringMetricExtension#starts_with}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "startsWith", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? StartsWith
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/stack_monitoring_metric_extension#url StackMonitoringMetricExtension#url}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "url", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Url
        {
            get;
            set;
        }
    }
}

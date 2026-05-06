using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.LogAnalyticsNamespaceIngestTimeRule
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.logAnalyticsNamespaceIngestTimeRule.LogAnalyticsNamespaceIngestTimeRuleConditions")]
    public class LogAnalyticsNamespaceIngestTimeRuleConditions : oci.LogAnalyticsNamespaceIngestTimeRule.ILogAnalyticsNamespaceIngestTimeRuleConditions
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/log_analytics_namespace_ingest_time_rule#field_name LogAnalyticsNamespaceIngestTimeRule#field_name}.</summary>
        [JsiiProperty(name: "fieldName", typeJson: "{\"primitive\":\"string\"}")]
        public string FieldName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/log_analytics_namespace_ingest_time_rule#field_operator LogAnalyticsNamespaceIngestTimeRule#field_operator}.</summary>
        [JsiiProperty(name: "fieldOperator", typeJson: "{\"primitive\":\"string\"}")]
        public string FieldOperator
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/log_analytics_namespace_ingest_time_rule#field_value LogAnalyticsNamespaceIngestTimeRule#field_value}.</summary>
        [JsiiProperty(name: "fieldValue", typeJson: "{\"primitive\":\"string\"}")]
        public string FieldValue
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/log_analytics_namespace_ingest_time_rule#kind LogAnalyticsNamespaceIngestTimeRule#kind}.</summary>
        [JsiiProperty(name: "kind", typeJson: "{\"primitive\":\"string\"}")]
        public string Kind
        {
            get;
            set;
        }

        private object? _additionalConditions;

        /// <summary>additional_conditions block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/log_analytics_namespace_ingest_time_rule#additional_conditions LogAnalyticsNamespaceIngestTimeRule#additional_conditions}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "additionalConditions", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.logAnalyticsNamespaceIngestTimeRule.LogAnalyticsNamespaceIngestTimeRuleConditionsAdditionalConditions\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? AdditionalConditions
        {
            get => _additionalConditions;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case oci.LogAnalyticsNamespaceIngestTimeRule.ILogAnalyticsNamespaceIngestTimeRuleConditionsAdditionalConditions[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.LogAnalyticsNamespaceIngestTimeRule.ILogAnalyticsNamespaceIngestTimeRuleConditionsAdditionalConditions).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _additionalConditions = value;
            }
        }
    }
}

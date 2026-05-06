using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.LogAnalyticsNamespaceIngestTimeRule
{
    [JsiiInterface(nativeType: typeof(ILogAnalyticsNamespaceIngestTimeRuleConditions), fullyQualifiedName: "oci.logAnalyticsNamespaceIngestTimeRule.LogAnalyticsNamespaceIngestTimeRuleConditions")]
    public interface ILogAnalyticsNamespaceIngestTimeRuleConditions
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/log_analytics_namespace_ingest_time_rule#field_name LogAnalyticsNamespaceIngestTimeRule#field_name}.</summary>
        [JsiiProperty(name: "fieldName", typeJson: "{\"primitive\":\"string\"}")]
        string FieldName
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/log_analytics_namespace_ingest_time_rule#field_operator LogAnalyticsNamespaceIngestTimeRule#field_operator}.</summary>
        [JsiiProperty(name: "fieldOperator", typeJson: "{\"primitive\":\"string\"}")]
        string FieldOperator
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/log_analytics_namespace_ingest_time_rule#field_value LogAnalyticsNamespaceIngestTimeRule#field_value}.</summary>
        [JsiiProperty(name: "fieldValue", typeJson: "{\"primitive\":\"string\"}")]
        string FieldValue
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/log_analytics_namespace_ingest_time_rule#kind LogAnalyticsNamespaceIngestTimeRule#kind}.</summary>
        [JsiiProperty(name: "kind", typeJson: "{\"primitive\":\"string\"}")]
        string Kind
        {
            get;
        }

        /// <summary>additional_conditions block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/log_analytics_namespace_ingest_time_rule#additional_conditions LogAnalyticsNamespaceIngestTimeRule#additional_conditions}
        /// </remarks>
        [JsiiProperty(name: "additionalConditions", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.logAnalyticsNamespaceIngestTimeRule.LogAnalyticsNamespaceIngestTimeRuleConditionsAdditionalConditions\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? AdditionalConditions
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ILogAnalyticsNamespaceIngestTimeRuleConditions), fullyQualifiedName: "oci.logAnalyticsNamespaceIngestTimeRule.LogAnalyticsNamespaceIngestTimeRuleConditions")]
        internal sealed class _Proxy : DeputyBase, oci.LogAnalyticsNamespaceIngestTimeRule.ILogAnalyticsNamespaceIngestTimeRuleConditions
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/log_analytics_namespace_ingest_time_rule#field_name LogAnalyticsNamespaceIngestTimeRule#field_name}.</summary>
            [JsiiProperty(name: "fieldName", typeJson: "{\"primitive\":\"string\"}")]
            public string FieldName
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/log_analytics_namespace_ingest_time_rule#field_operator LogAnalyticsNamespaceIngestTimeRule#field_operator}.</summary>
            [JsiiProperty(name: "fieldOperator", typeJson: "{\"primitive\":\"string\"}")]
            public string FieldOperator
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/log_analytics_namespace_ingest_time_rule#field_value LogAnalyticsNamespaceIngestTimeRule#field_value}.</summary>
            [JsiiProperty(name: "fieldValue", typeJson: "{\"primitive\":\"string\"}")]
            public string FieldValue
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/log_analytics_namespace_ingest_time_rule#kind LogAnalyticsNamespaceIngestTimeRule#kind}.</summary>
            [JsiiProperty(name: "kind", typeJson: "{\"primitive\":\"string\"}")]
            public string Kind
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>additional_conditions block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/log_analytics_namespace_ingest_time_rule#additional_conditions LogAnalyticsNamespaceIngestTimeRule#additional_conditions}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "additionalConditions", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.logAnalyticsNamespaceIngestTimeRule.LogAnalyticsNamespaceIngestTimeRuleConditionsAdditionalConditions\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? AdditionalConditions
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}

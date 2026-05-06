using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.LogAnalyticsNamespaceIngestTimeRule
{
    [JsiiInterface(nativeType: typeof(ILogAnalyticsNamespaceIngestTimeRuleConditionsAdditionalConditions), fullyQualifiedName: "oci.logAnalyticsNamespaceIngestTimeRule.LogAnalyticsNamespaceIngestTimeRuleConditionsAdditionalConditions")]
    public interface ILogAnalyticsNamespaceIngestTimeRuleConditionsAdditionalConditions
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/log_analytics_namespace_ingest_time_rule#condition_field LogAnalyticsNamespaceIngestTimeRule#condition_field}.</summary>
        [JsiiProperty(name: "conditionField", typeJson: "{\"primitive\":\"string\"}")]
        string ConditionField
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/log_analytics_namespace_ingest_time_rule#condition_operator LogAnalyticsNamespaceIngestTimeRule#condition_operator}.</summary>
        [JsiiProperty(name: "conditionOperator", typeJson: "{\"primitive\":\"string\"}")]
        string ConditionOperator
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/log_analytics_namespace_ingest_time_rule#condition_value LogAnalyticsNamespaceIngestTimeRule#condition_value}.</summary>
        [JsiiProperty(name: "conditionValue", typeJson: "{\"primitive\":\"string\"}")]
        string ConditionValue
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(ILogAnalyticsNamespaceIngestTimeRuleConditionsAdditionalConditions), fullyQualifiedName: "oci.logAnalyticsNamespaceIngestTimeRule.LogAnalyticsNamespaceIngestTimeRuleConditionsAdditionalConditions")]
        internal sealed class _Proxy : DeputyBase, oci.LogAnalyticsNamespaceIngestTimeRule.ILogAnalyticsNamespaceIngestTimeRuleConditionsAdditionalConditions
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/log_analytics_namespace_ingest_time_rule#condition_field LogAnalyticsNamespaceIngestTimeRule#condition_field}.</summary>
            [JsiiProperty(name: "conditionField", typeJson: "{\"primitive\":\"string\"}")]
            public string ConditionField
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/log_analytics_namespace_ingest_time_rule#condition_operator LogAnalyticsNamespaceIngestTimeRule#condition_operator}.</summary>
            [JsiiProperty(name: "conditionOperator", typeJson: "{\"primitive\":\"string\"}")]
            public string ConditionOperator
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/log_analytics_namespace_ingest_time_rule#condition_value LogAnalyticsNamespaceIngestTimeRule#condition_value}.</summary>
            [JsiiProperty(name: "conditionValue", typeJson: "{\"primitive\":\"string\"}")]
            public string ConditionValue
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}

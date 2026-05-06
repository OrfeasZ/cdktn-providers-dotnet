using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.LogAnalyticsNamespaceIngestTimeRule
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.logAnalyticsNamespaceIngestTimeRule.LogAnalyticsNamespaceIngestTimeRuleConditionsAdditionalConditions")]
    public class LogAnalyticsNamespaceIngestTimeRuleConditionsAdditionalConditions : oci.LogAnalyticsNamespaceIngestTimeRule.ILogAnalyticsNamespaceIngestTimeRuleConditionsAdditionalConditions
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/log_analytics_namespace_ingest_time_rule#condition_field LogAnalyticsNamespaceIngestTimeRule#condition_field}.</summary>
        [JsiiProperty(name: "conditionField", typeJson: "{\"primitive\":\"string\"}")]
        public string ConditionField
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/log_analytics_namespace_ingest_time_rule#condition_operator LogAnalyticsNamespaceIngestTimeRule#condition_operator}.</summary>
        [JsiiProperty(name: "conditionOperator", typeJson: "{\"primitive\":\"string\"}")]
        public string ConditionOperator
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/log_analytics_namespace_ingest_time_rule#condition_value LogAnalyticsNamespaceIngestTimeRule#condition_value}.</summary>
        [JsiiProperty(name: "conditionValue", typeJson: "{\"primitive\":\"string\"}")]
        public string ConditionValue
        {
            get;
            set;
        }
    }
}

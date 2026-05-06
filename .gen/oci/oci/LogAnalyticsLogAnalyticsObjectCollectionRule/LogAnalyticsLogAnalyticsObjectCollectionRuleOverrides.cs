using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.LogAnalyticsLogAnalyticsObjectCollectionRule
{
    [JsiiByValue(fqn: "oci.logAnalyticsLogAnalyticsObjectCollectionRule.LogAnalyticsLogAnalyticsObjectCollectionRuleOverrides")]
    public class LogAnalyticsLogAnalyticsObjectCollectionRuleOverrides : oci.LogAnalyticsLogAnalyticsObjectCollectionRule.ILogAnalyticsLogAnalyticsObjectCollectionRuleOverrides
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/log_analytics_log_analytics_object_collection_rule#match_type LogAnalyticsLogAnalyticsObjectCollectionRule#match_type}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "matchType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? MatchType
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/log_analytics_log_analytics_object_collection_rule#match_value LogAnalyticsLogAnalyticsObjectCollectionRule#match_value}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "matchValue", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? MatchValue
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/log_analytics_log_analytics_object_collection_rule#property_name LogAnalyticsLogAnalyticsObjectCollectionRule#property_name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "propertyName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? PropertyName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/log_analytics_log_analytics_object_collection_rule#property_value LogAnalyticsLogAnalyticsObjectCollectionRule#property_value}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "propertyValue", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? PropertyValue
        {
            get;
            set;
        }
    }
}

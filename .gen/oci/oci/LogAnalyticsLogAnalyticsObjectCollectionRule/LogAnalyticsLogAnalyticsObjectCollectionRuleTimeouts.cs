using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.LogAnalyticsLogAnalyticsObjectCollectionRule
{
    [JsiiByValue(fqn: "oci.logAnalyticsLogAnalyticsObjectCollectionRule.LogAnalyticsLogAnalyticsObjectCollectionRuleTimeouts")]
    public class LogAnalyticsLogAnalyticsObjectCollectionRuleTimeouts : oci.LogAnalyticsLogAnalyticsObjectCollectionRule.ILogAnalyticsLogAnalyticsObjectCollectionRuleTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/log_analytics_log_analytics_object_collection_rule#create LogAnalyticsLogAnalyticsObjectCollectionRule#create}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Create
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/log_analytics_log_analytics_object_collection_rule#delete LogAnalyticsLogAnalyticsObjectCollectionRule#delete}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Delete
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/log_analytics_log_analytics_object_collection_rule#update LogAnalyticsLogAnalyticsObjectCollectionRule#update}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "update", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Update
        {
            get;
            set;
        }
    }
}

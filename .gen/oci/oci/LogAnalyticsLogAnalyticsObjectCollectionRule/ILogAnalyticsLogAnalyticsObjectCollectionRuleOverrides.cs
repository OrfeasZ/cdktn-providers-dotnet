using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.LogAnalyticsLogAnalyticsObjectCollectionRule
{
    [JsiiInterface(nativeType: typeof(ILogAnalyticsLogAnalyticsObjectCollectionRuleOverrides), fullyQualifiedName: "oci.logAnalyticsLogAnalyticsObjectCollectionRule.LogAnalyticsLogAnalyticsObjectCollectionRuleOverrides")]
    public interface ILogAnalyticsLogAnalyticsObjectCollectionRuleOverrides
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/log_analytics_log_analytics_object_collection_rule#match_type LogAnalyticsLogAnalyticsObjectCollectionRule#match_type}.</summary>
        [JsiiProperty(name: "matchType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? MatchType
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/log_analytics_log_analytics_object_collection_rule#match_value LogAnalyticsLogAnalyticsObjectCollectionRule#match_value}.</summary>
        [JsiiProperty(name: "matchValue", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? MatchValue
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/log_analytics_log_analytics_object_collection_rule#property_name LogAnalyticsLogAnalyticsObjectCollectionRule#property_name}.</summary>
        [JsiiProperty(name: "propertyName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? PropertyName
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/log_analytics_log_analytics_object_collection_rule#property_value LogAnalyticsLogAnalyticsObjectCollectionRule#property_value}.</summary>
        [JsiiProperty(name: "propertyValue", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? PropertyValue
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ILogAnalyticsLogAnalyticsObjectCollectionRuleOverrides), fullyQualifiedName: "oci.logAnalyticsLogAnalyticsObjectCollectionRule.LogAnalyticsLogAnalyticsObjectCollectionRuleOverrides")]
        internal sealed class _Proxy : DeputyBase, oci.LogAnalyticsLogAnalyticsObjectCollectionRule.ILogAnalyticsLogAnalyticsObjectCollectionRuleOverrides
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/log_analytics_log_analytics_object_collection_rule#match_type LogAnalyticsLogAnalyticsObjectCollectionRule#match_type}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "matchType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? MatchType
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/log_analytics_log_analytics_object_collection_rule#match_value LogAnalyticsLogAnalyticsObjectCollectionRule#match_value}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "matchValue", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? MatchValue
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/log_analytics_log_analytics_object_collection_rule#property_name LogAnalyticsLogAnalyticsObjectCollectionRule#property_name}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "propertyName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? PropertyName
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/log_analytics_log_analytics_object_collection_rule#property_value LogAnalyticsLogAnalyticsObjectCollectionRule#property_value}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "propertyValue", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? PropertyValue
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}

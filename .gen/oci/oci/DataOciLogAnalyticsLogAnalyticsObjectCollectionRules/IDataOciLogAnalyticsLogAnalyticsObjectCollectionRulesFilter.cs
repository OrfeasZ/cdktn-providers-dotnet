using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciLogAnalyticsLogAnalyticsObjectCollectionRules
{
    [JsiiInterface(nativeType: typeof(IDataOciLogAnalyticsLogAnalyticsObjectCollectionRulesFilter), fullyQualifiedName: "oci.dataOciLogAnalyticsLogAnalyticsObjectCollectionRules.DataOciLogAnalyticsLogAnalyticsObjectCollectionRulesFilter")]
    public interface IDataOciLogAnalyticsLogAnalyticsObjectCollectionRulesFilter
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/log_analytics_log_analytics_object_collection_rules#name DataOciLogAnalyticsLogAnalyticsObjectCollectionRules#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/log_analytics_log_analytics_object_collection_rules#values DataOciLogAnalyticsLogAnalyticsObjectCollectionRules#values}.</summary>
        [JsiiProperty(name: "values", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        string[] Values
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/log_analytics_log_analytics_object_collection_rules#regex DataOciLogAnalyticsLogAnalyticsObjectCollectionRules#regex}.</summary>
        [JsiiProperty(name: "regex", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Regex
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataOciLogAnalyticsLogAnalyticsObjectCollectionRulesFilter), fullyQualifiedName: "oci.dataOciLogAnalyticsLogAnalyticsObjectCollectionRules.DataOciLogAnalyticsLogAnalyticsObjectCollectionRulesFilter")]
        internal sealed class _Proxy : DeputyBase, oci.DataOciLogAnalyticsLogAnalyticsObjectCollectionRules.IDataOciLogAnalyticsLogAnalyticsObjectCollectionRulesFilter
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/log_analytics_log_analytics_object_collection_rules#name DataOciLogAnalyticsLogAnalyticsObjectCollectionRules#name}.</summary>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/log_analytics_log_analytics_object_collection_rules#values DataOciLogAnalyticsLogAnalyticsObjectCollectionRules#values}.</summary>
            [JsiiProperty(name: "values", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
            public string[] Values
            {
                get => GetInstanceProperty<string[]>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/log_analytics_log_analytics_object_collection_rules#regex DataOciLogAnalyticsLogAnalyticsObjectCollectionRules#regex}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "regex", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? Regex
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}

using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.ElasticCloudElasticsearch
{
    [JsiiInterface(nativeType: typeof(IElasticCloudElasticsearchLogs), fullyQualifiedName: "azurerm.elasticCloudElasticsearch.ElasticCloudElasticsearchLogs")]
    public interface IElasticCloudElasticsearchLogs
    {
        /// <summary>filtering_tag block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/elastic_cloud_elasticsearch#filtering_tag ElasticCloudElasticsearch#filtering_tag}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.ElasticCloudElasticsearch.IElasticCloudElasticsearchLogsFilteringTag" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "filteringTag", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.elasticCloudElasticsearch.ElasticCloudElasticsearchLogsFilteringTag\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? FilteringTag
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/elastic_cloud_elasticsearch#send_activity_logs ElasticCloudElasticsearch#send_activity_logs}.</summary>
        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "sendActivityLogs", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? SendActivityLogs
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/elastic_cloud_elasticsearch#send_azuread_logs ElasticCloudElasticsearch#send_azuread_logs}.</summary>
        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "sendAzureadLogs", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? SendAzureadLogs
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/elastic_cloud_elasticsearch#send_subscription_logs ElasticCloudElasticsearch#send_subscription_logs}.</summary>
        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "sendSubscriptionLogs", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? SendSubscriptionLogs
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IElasticCloudElasticsearchLogs), fullyQualifiedName: "azurerm.elasticCloudElasticsearch.ElasticCloudElasticsearchLogs")]
        internal sealed class _Proxy : DeputyBase, azurerm.ElasticCloudElasticsearch.IElasticCloudElasticsearchLogs
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>filtering_tag block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/elastic_cloud_elasticsearch#filtering_tag ElasticCloudElasticsearch#filtering_tag}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.ElasticCloudElasticsearch.IElasticCloudElasticsearchLogsFilteringTag" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "filteringTag", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.elasticCloudElasticsearch.ElasticCloudElasticsearchLogsFilteringTag\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? FilteringTag
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/elastic_cloud_elasticsearch#send_activity_logs ElasticCloudElasticsearch#send_activity_logs}.</summary>
            /// <remarks>
            /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "sendActivityLogs", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? SendActivityLogs
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/elastic_cloud_elasticsearch#send_azuread_logs ElasticCloudElasticsearch#send_azuread_logs}.</summary>
            /// <remarks>
            /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "sendAzureadLogs", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? SendAzureadLogs
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/elastic_cloud_elasticsearch#send_subscription_logs ElasticCloudElasticsearch#send_subscription_logs}.</summary>
            /// <remarks>
            /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "sendSubscriptionLogs", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? SendSubscriptionLogs
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}

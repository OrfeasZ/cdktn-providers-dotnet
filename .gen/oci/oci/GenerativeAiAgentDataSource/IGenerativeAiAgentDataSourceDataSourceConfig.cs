using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.GenerativeAiAgentDataSource
{
    [JsiiInterface(nativeType: typeof(IGenerativeAiAgentDataSourceDataSourceConfig), fullyQualifiedName: "oci.generativeAiAgentDataSource.GenerativeAiAgentDataSourceDataSourceConfig")]
    public interface IGenerativeAiAgentDataSourceDataSourceConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/generative_ai_agent_data_source#data_source_config_type GenerativeAiAgentDataSource#data_source_config_type}.</summary>
        [JsiiProperty(name: "dataSourceConfigType", typeJson: "{\"primitive\":\"string\"}")]
        string DataSourceConfigType
        {
            get;
        }

        /// <summary>object_storage_prefixes block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/generative_ai_agent_data_source#object_storage_prefixes GenerativeAiAgentDataSource#object_storage_prefixes}
        /// </remarks>
        [JsiiProperty(name: "objectStoragePrefixes", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.generativeAiAgentDataSource.GenerativeAiAgentDataSourceDataSourceConfigObjectStoragePrefixes\"},\"kind\":\"array\"}}]}}")]
        object ObjectStoragePrefixes
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IGenerativeAiAgentDataSourceDataSourceConfig), fullyQualifiedName: "oci.generativeAiAgentDataSource.GenerativeAiAgentDataSourceDataSourceConfig")]
        internal sealed class _Proxy : DeputyBase, oci.GenerativeAiAgentDataSource.IGenerativeAiAgentDataSourceDataSourceConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/generative_ai_agent_data_source#data_source_config_type GenerativeAiAgentDataSource#data_source_config_type}.</summary>
            [JsiiProperty(name: "dataSourceConfigType", typeJson: "{\"primitive\":\"string\"}")]
            public string DataSourceConfigType
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>object_storage_prefixes block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/generative_ai_agent_data_source#object_storage_prefixes GenerativeAiAgentDataSource#object_storage_prefixes}
            /// </remarks>
            [JsiiProperty(name: "objectStoragePrefixes", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.generativeAiAgentDataSource.GenerativeAiAgentDataSourceDataSourceConfigObjectStoragePrefixes\"},\"kind\":\"array\"}}]}}")]
            public object ObjectStoragePrefixes
            {
                get => GetInstanceProperty<object>()!;
            }
        }
    }
}

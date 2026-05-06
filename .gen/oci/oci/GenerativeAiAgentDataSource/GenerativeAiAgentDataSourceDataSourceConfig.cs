using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.GenerativeAiAgentDataSource
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.generativeAiAgentDataSource.GenerativeAiAgentDataSourceDataSourceConfig")]
    public class GenerativeAiAgentDataSourceDataSourceConfig : oci.GenerativeAiAgentDataSource.IGenerativeAiAgentDataSourceDataSourceConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/generative_ai_agent_data_source#data_source_config_type GenerativeAiAgentDataSource#data_source_config_type}.</summary>
        [JsiiProperty(name: "dataSourceConfigType", typeJson: "{\"primitive\":\"string\"}")]
        public string DataSourceConfigType
        {
            get;
            set;
        }

        private object _objectStoragePrefixes;

        /// <summary>object_storage_prefixes block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/generative_ai_agent_data_source#object_storage_prefixes GenerativeAiAgentDataSource#object_storage_prefixes}
        /// </remarks>
        [JsiiProperty(name: "objectStoragePrefixes", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.generativeAiAgentDataSource.GenerativeAiAgentDataSourceDataSourceConfigObjectStoragePrefixes\"},\"kind\":\"array\"}}]}}")]
        public object ObjectStoragePrefixes
        {
            get => _objectStoragePrefixes;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case oci.GenerativeAiAgentDataSource.IGenerativeAiAgentDataSourceDataSourceConfigObjectStoragePrefixes[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.GenerativeAiAgentDataSource.IGenerativeAiAgentDataSourceDataSourceConfigObjectStoragePrefixes).FullName}[]; received null", nameof(value));
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.GenerativeAiAgentDataSource.IGenerativeAiAgentDataSourceDataSourceConfigObjectStoragePrefixes).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _objectStoragePrefixes = value;
            }
        }
    }
}

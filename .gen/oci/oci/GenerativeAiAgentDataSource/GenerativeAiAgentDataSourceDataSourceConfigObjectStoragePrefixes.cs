using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.GenerativeAiAgentDataSource
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.generativeAiAgentDataSource.GenerativeAiAgentDataSourceDataSourceConfigObjectStoragePrefixes")]
    public class GenerativeAiAgentDataSourceDataSourceConfigObjectStoragePrefixes : oci.GenerativeAiAgentDataSource.IGenerativeAiAgentDataSourceDataSourceConfigObjectStoragePrefixes
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/generative_ai_agent_data_source#bucket GenerativeAiAgentDataSource#bucket}.</summary>
        [JsiiProperty(name: "bucket", typeJson: "{\"primitive\":\"string\"}")]
        public string Bucket
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/generative_ai_agent_data_source#namespace GenerativeAiAgentDataSource#namespace}.</summary>
        [JsiiProperty(name: "namespace", typeJson: "{\"primitive\":\"string\"}")]
        public string Namespace
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/generative_ai_agent_data_source#prefix GenerativeAiAgentDataSource#prefix}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "prefix", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Prefix
        {
            get;
            set;
        }
    }
}

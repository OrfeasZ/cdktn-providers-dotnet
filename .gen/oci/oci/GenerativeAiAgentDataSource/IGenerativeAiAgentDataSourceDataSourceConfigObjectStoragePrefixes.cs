using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.GenerativeAiAgentDataSource
{
    [JsiiInterface(nativeType: typeof(IGenerativeAiAgentDataSourceDataSourceConfigObjectStoragePrefixes), fullyQualifiedName: "oci.generativeAiAgentDataSource.GenerativeAiAgentDataSourceDataSourceConfigObjectStoragePrefixes")]
    public interface IGenerativeAiAgentDataSourceDataSourceConfigObjectStoragePrefixes
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/generative_ai_agent_data_source#bucket GenerativeAiAgentDataSource#bucket}.</summary>
        [JsiiProperty(name: "bucket", typeJson: "{\"primitive\":\"string\"}")]
        string Bucket
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/generative_ai_agent_data_source#namespace GenerativeAiAgentDataSource#namespace}.</summary>
        [JsiiProperty(name: "namespace", typeJson: "{\"primitive\":\"string\"}")]
        string Namespace
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/generative_ai_agent_data_source#prefix GenerativeAiAgentDataSource#prefix}.</summary>
        [JsiiProperty(name: "prefix", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Prefix
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IGenerativeAiAgentDataSourceDataSourceConfigObjectStoragePrefixes), fullyQualifiedName: "oci.generativeAiAgentDataSource.GenerativeAiAgentDataSourceDataSourceConfigObjectStoragePrefixes")]
        internal sealed class _Proxy : DeputyBase, oci.GenerativeAiAgentDataSource.IGenerativeAiAgentDataSourceDataSourceConfigObjectStoragePrefixes
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/generative_ai_agent_data_source#bucket GenerativeAiAgentDataSource#bucket}.</summary>
            [JsiiProperty(name: "bucket", typeJson: "{\"primitive\":\"string\"}")]
            public string Bucket
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/generative_ai_agent_data_source#namespace GenerativeAiAgentDataSource#namespace}.</summary>
            [JsiiProperty(name: "namespace", typeJson: "{\"primitive\":\"string\"}")]
            public string Namespace
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/generative_ai_agent_data_source#prefix GenerativeAiAgentDataSource#prefix}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "prefix", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Prefix
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}

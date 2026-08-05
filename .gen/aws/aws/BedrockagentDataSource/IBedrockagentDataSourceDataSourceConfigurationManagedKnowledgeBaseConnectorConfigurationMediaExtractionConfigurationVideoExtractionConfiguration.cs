using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.BedrockagentDataSource
{
    [JsiiInterface(nativeType: typeof(IBedrockagentDataSourceDataSourceConfigurationManagedKnowledgeBaseConnectorConfigurationMediaExtractionConfigurationVideoExtractionConfiguration), fullyQualifiedName: "aws.bedrockagentDataSource.BedrockagentDataSourceDataSourceConfigurationManagedKnowledgeBaseConnectorConfigurationMediaExtractionConfigurationVideoExtractionConfiguration")]
    public interface IBedrockagentDataSourceDataSourceConfigurationManagedKnowledgeBaseConnectorConfigurationMediaExtractionConfigurationVideoExtractionConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.58.0/docs/resources/bedrockagent_data_source#video_extraction_status BedrockagentDataSource#video_extraction_status}.</summary>
        [JsiiProperty(name: "videoExtractionStatus", typeJson: "{\"primitive\":\"string\"}")]
        string VideoExtractionStatus
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IBedrockagentDataSourceDataSourceConfigurationManagedKnowledgeBaseConnectorConfigurationMediaExtractionConfigurationVideoExtractionConfiguration), fullyQualifiedName: "aws.bedrockagentDataSource.BedrockagentDataSourceDataSourceConfigurationManagedKnowledgeBaseConnectorConfigurationMediaExtractionConfigurationVideoExtractionConfiguration")]
        internal sealed class _Proxy : DeputyBase, aws.BedrockagentDataSource.IBedrockagentDataSourceDataSourceConfigurationManagedKnowledgeBaseConnectorConfigurationMediaExtractionConfigurationVideoExtractionConfiguration
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.58.0/docs/resources/bedrockagent_data_source#video_extraction_status BedrockagentDataSource#video_extraction_status}.</summary>
            [JsiiProperty(name: "videoExtractionStatus", typeJson: "{\"primitive\":\"string\"}")]
            public string VideoExtractionStatus
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}

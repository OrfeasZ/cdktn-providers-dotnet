using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.BedrockagentDataSource
{
    [JsiiInterface(nativeType: typeof(IBedrockagentDataSourceDataSourceConfigurationManagedKnowledgeBaseConnectorConfigurationMediaExtractionConfigurationImageExtractionConfiguration), fullyQualifiedName: "aws.bedrockagentDataSource.BedrockagentDataSourceDataSourceConfigurationManagedKnowledgeBaseConnectorConfigurationMediaExtractionConfigurationImageExtractionConfiguration")]
    public interface IBedrockagentDataSourceDataSourceConfigurationManagedKnowledgeBaseConnectorConfigurationMediaExtractionConfigurationImageExtractionConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.56.0/docs/resources/bedrockagent_data_source#image_extraction_status BedrockagentDataSource#image_extraction_status}.</summary>
        [JsiiProperty(name: "imageExtractionStatus", typeJson: "{\"primitive\":\"string\"}")]
        string ImageExtractionStatus
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IBedrockagentDataSourceDataSourceConfigurationManagedKnowledgeBaseConnectorConfigurationMediaExtractionConfigurationImageExtractionConfiguration), fullyQualifiedName: "aws.bedrockagentDataSource.BedrockagentDataSourceDataSourceConfigurationManagedKnowledgeBaseConnectorConfigurationMediaExtractionConfigurationImageExtractionConfiguration")]
        internal sealed class _Proxy : DeputyBase, aws.BedrockagentDataSource.IBedrockagentDataSourceDataSourceConfigurationManagedKnowledgeBaseConnectorConfigurationMediaExtractionConfigurationImageExtractionConfiguration
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.56.0/docs/resources/bedrockagent_data_source#image_extraction_status BedrockagentDataSource#image_extraction_status}.</summary>
            [JsiiProperty(name: "imageExtractionStatus", typeJson: "{\"primitive\":\"string\"}")]
            public string ImageExtractionStatus
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}

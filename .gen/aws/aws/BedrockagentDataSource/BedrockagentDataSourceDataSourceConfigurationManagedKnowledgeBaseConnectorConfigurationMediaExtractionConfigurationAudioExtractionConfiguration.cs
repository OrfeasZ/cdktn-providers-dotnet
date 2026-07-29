using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.BedrockagentDataSource
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.bedrockagentDataSource.BedrockagentDataSourceDataSourceConfigurationManagedKnowledgeBaseConnectorConfigurationMediaExtractionConfigurationAudioExtractionConfiguration")]
    public class BedrockagentDataSourceDataSourceConfigurationManagedKnowledgeBaseConnectorConfigurationMediaExtractionConfigurationAudioExtractionConfiguration : aws.BedrockagentDataSource.IBedrockagentDataSourceDataSourceConfigurationManagedKnowledgeBaseConnectorConfigurationMediaExtractionConfigurationAudioExtractionConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.57.1/docs/resources/bedrockagent_data_source#audio_extraction_status BedrockagentDataSource#audio_extraction_status}.</summary>
        [JsiiProperty(name: "audioExtractionStatus", typeJson: "{\"primitive\":\"string\"}")]
        public string AudioExtractionStatus
        {
            get;
            set;
        }
    }
}

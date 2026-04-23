using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.BedrockagentDataSource
{
    [JsiiByValue(fqn: "aws.bedrockagentDataSource.BedrockagentDataSourceVectorIngestionConfigurationParsingConfigurationBedrockDataAutomationConfiguration")]
    public class BedrockagentDataSourceVectorIngestionConfigurationParsingConfigurationBedrockDataAutomationConfiguration : aws.BedrockagentDataSource.IBedrockagentDataSourceVectorIngestionConfigurationParsingConfigurationBedrockDataAutomationConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/bedrockagent_data_source#parsing_modality BedrockagentDataSource#parsing_modality}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "parsingModality", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ParsingModality
        {
            get;
            set;
        }
    }
}

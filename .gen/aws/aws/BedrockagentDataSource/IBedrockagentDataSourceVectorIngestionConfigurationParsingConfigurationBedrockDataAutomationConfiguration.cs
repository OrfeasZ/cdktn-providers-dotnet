using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.BedrockagentDataSource
{
    [JsiiInterface(nativeType: typeof(IBedrockagentDataSourceVectorIngestionConfigurationParsingConfigurationBedrockDataAutomationConfiguration), fullyQualifiedName: "aws.bedrockagentDataSource.BedrockagentDataSourceVectorIngestionConfigurationParsingConfigurationBedrockDataAutomationConfiguration")]
    public interface IBedrockagentDataSourceVectorIngestionConfigurationParsingConfigurationBedrockDataAutomationConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/bedrockagent_data_source#parsing_modality BedrockagentDataSource#parsing_modality}.</summary>
        [JsiiProperty(name: "parsingModality", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ParsingModality
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IBedrockagentDataSourceVectorIngestionConfigurationParsingConfigurationBedrockDataAutomationConfiguration), fullyQualifiedName: "aws.bedrockagentDataSource.BedrockagentDataSourceVectorIngestionConfigurationParsingConfigurationBedrockDataAutomationConfiguration")]
        internal sealed class _Proxy : DeputyBase, aws.BedrockagentDataSource.IBedrockagentDataSourceVectorIngestionConfigurationParsingConfigurationBedrockDataAutomationConfiguration
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/bedrockagent_data_source#parsing_modality BedrockagentDataSource#parsing_modality}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "parsingModality", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ParsingModality
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}

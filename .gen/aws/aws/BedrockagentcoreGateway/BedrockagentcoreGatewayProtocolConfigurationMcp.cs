using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.BedrockagentcoreGateway
{
    [JsiiByValue(fqn: "aws.bedrockagentcoreGateway.BedrockagentcoreGatewayProtocolConfigurationMcp")]
    public class BedrockagentcoreGatewayProtocolConfigurationMcp : aws.BedrockagentcoreGateway.IBedrockagentcoreGatewayProtocolConfigurationMcp
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/bedrockagentcore_gateway#instructions BedrockagentcoreGateway#instructions}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "instructions", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Instructions
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/bedrockagentcore_gateway#search_type BedrockagentcoreGateway#search_type}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "searchType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? SearchType
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/bedrockagentcore_gateway#supported_versions BedrockagentcoreGateway#supported_versions}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "supportedVersions", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? SupportedVersions
        {
            get;
            set;
        }
    }
}

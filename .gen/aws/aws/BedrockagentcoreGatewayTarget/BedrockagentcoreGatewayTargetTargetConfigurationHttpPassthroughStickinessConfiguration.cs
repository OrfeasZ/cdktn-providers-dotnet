using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.BedrockagentcoreGatewayTarget
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.bedrockagentcoreGatewayTarget.BedrockagentcoreGatewayTargetTargetConfigurationHttpPassthroughStickinessConfiguration")]
    public class BedrockagentcoreGatewayTargetTargetConfigurationHttpPassthroughStickinessConfiguration : aws.BedrockagentcoreGatewayTarget.IBedrockagentcoreGatewayTargetTargetConfigurationHttpPassthroughStickinessConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/bedrockagentcore_gateway_target#identifier BedrockagentcoreGatewayTarget#identifier}.</summary>
        [JsiiProperty(name: "identifier", typeJson: "{\"primitive\":\"string\"}")]
        public string Identifier
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/bedrockagentcore_gateway_target#composite_identifier BedrockagentcoreGatewayTarget#composite_identifier}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "compositeIdentifier", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? CompositeIdentifier
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/bedrockagentcore_gateway_target#timeout BedrockagentcoreGatewayTarget#timeout}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "timeout", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? Timeout
        {
            get;
            set;
        }
    }
}

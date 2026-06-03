using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.BedrockagentcoreGatewayTarget
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.bedrockagentcoreGatewayTarget.BedrockagentcoreGatewayTargetTargetConfigurationHttpAgentcoreRuntime")]
    public class BedrockagentcoreGatewayTargetTargetConfigurationHttpAgentcoreRuntime : aws.BedrockagentcoreGatewayTarget.IBedrockagentcoreGatewayTargetTargetConfigurationHttpAgentcoreRuntime
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.48.0/docs/resources/bedrockagentcore_gateway_target#arn BedrockagentcoreGatewayTarget#arn}.</summary>
        [JsiiProperty(name: "arn", typeJson: "{\"primitive\":\"string\"}")]
        public string Arn
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.48.0/docs/resources/bedrockagentcore_gateway_target#qualifier BedrockagentcoreGatewayTarget#qualifier}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "qualifier", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Qualifier
        {
            get;
            set;
        }
    }
}

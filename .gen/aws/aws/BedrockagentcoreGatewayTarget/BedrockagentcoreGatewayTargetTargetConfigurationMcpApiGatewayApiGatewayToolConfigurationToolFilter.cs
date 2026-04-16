using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.BedrockagentcoreGatewayTarget
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.bedrockagentcoreGatewayTarget.BedrockagentcoreGatewayTargetTargetConfigurationMcpApiGatewayApiGatewayToolConfigurationToolFilter")]
    public class BedrockagentcoreGatewayTargetTargetConfigurationMcpApiGatewayApiGatewayToolConfigurationToolFilter : aws.BedrockagentcoreGatewayTarget.IBedrockagentcoreGatewayTargetTargetConfigurationMcpApiGatewayApiGatewayToolConfigurationToolFilter
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/bedrockagentcore_gateway_target#filter_path BedrockagentcoreGatewayTarget#filter_path}.</summary>
        [JsiiProperty(name: "filterPath", typeJson: "{\"primitive\":\"string\"}")]
        public string FilterPath
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/bedrockagentcore_gateway_target#methods BedrockagentcoreGatewayTarget#methods}.</summary>
        [JsiiProperty(name: "methods", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public string[] Methods
        {
            get;
            set;
        }
    }
}

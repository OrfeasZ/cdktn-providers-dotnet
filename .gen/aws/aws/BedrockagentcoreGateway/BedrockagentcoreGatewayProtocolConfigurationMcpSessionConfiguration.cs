using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.BedrockagentcoreGateway
{
    [JsiiByValue(fqn: "aws.bedrockagentcoreGateway.BedrockagentcoreGatewayProtocolConfigurationMcpSessionConfiguration")]
    public class BedrockagentcoreGatewayProtocolConfigurationMcpSessionConfiguration : aws.BedrockagentcoreGateway.IBedrockagentcoreGatewayProtocolConfigurationMcpSessionConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.56.0/docs/resources/bedrockagentcore_gateway#session_timeout_in_seconds BedrockagentcoreGateway#session_timeout_in_seconds}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "sessionTimeoutInSeconds", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? SessionTimeoutInSeconds
        {
            get;
            set;
        }
    }
}

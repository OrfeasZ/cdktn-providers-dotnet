using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.BedrockagentcoreGatewayTarget
{
    [JsiiByValue(fqn: "aws.bedrockagentcoreGatewayTarget.BedrockagentcoreGatewayTargetCredentialProviderConfigurationGatewayIamRole")]
    public class BedrockagentcoreGatewayTargetCredentialProviderConfigurationGatewayIamRole : aws.BedrockagentcoreGatewayTarget.IBedrockagentcoreGatewayTargetCredentialProviderConfigurationGatewayIamRole
    {
        /// <summary>AWS Region used for SigV4 signing of upstream requests.</summary>
        /// <remarks>
        /// Defaults to the gateway's Region when omitted. Only meaningful when <c>service</c> is set.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.51.0/docs/resources/bedrockagentcore_gateway_target#region BedrockagentcoreGatewayTarget#region}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "region", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Region
        {
            get;
            set;
        }

        /// <summary>The target AWS service name used for SigV4 signing of upstream requests.</summary>
        /// <remarks>
        /// Required when calling SigV4-protected endpoints such as another Bedrock AgentCore Runtime (use <c>bedrock-agentcore</c>). Omit for non-SigV4 IAM-role-based authentication.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.51.0/docs/resources/bedrockagentcore_gateway_target#service BedrockagentcoreGatewayTarget#service}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "service", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Service
        {
            get;
            set;
        }
    }
}

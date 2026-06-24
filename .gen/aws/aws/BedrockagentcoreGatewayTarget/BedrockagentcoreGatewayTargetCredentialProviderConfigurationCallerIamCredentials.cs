using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.BedrockagentcoreGatewayTarget
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.bedrockagentcoreGatewayTarget.BedrockagentcoreGatewayTargetCredentialProviderConfigurationCallerIamCredentials")]
    public class BedrockagentcoreGatewayTargetCredentialProviderConfigurationCallerIamCredentials : aws.BedrockagentcoreGatewayTarget.IBedrockagentcoreGatewayTargetCredentialProviderConfigurationCallerIamCredentials
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.52.0/docs/resources/bedrockagentcore_gateway_target#service BedrockagentcoreGatewayTarget#service}.</summary>
        [JsiiProperty(name: "service", typeJson: "{\"primitive\":\"string\"}")]
        public string Service
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.52.0/docs/resources/bedrockagentcore_gateway_target#region BedrockagentcoreGatewayTarget#region}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "region", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Region
        {
            get;
            set;
        }
    }
}

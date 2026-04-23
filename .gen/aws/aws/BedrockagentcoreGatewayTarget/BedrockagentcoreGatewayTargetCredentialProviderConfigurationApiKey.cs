using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.BedrockagentcoreGatewayTarget
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.bedrockagentcoreGatewayTarget.BedrockagentcoreGatewayTargetCredentialProviderConfigurationApiKey")]
    public class BedrockagentcoreGatewayTargetCredentialProviderConfigurationApiKey : aws.BedrockagentcoreGatewayTarget.IBedrockagentcoreGatewayTargetCredentialProviderConfigurationApiKey
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/bedrockagentcore_gateway_target#provider_arn BedrockagentcoreGatewayTarget#provider_arn}.</summary>
        [JsiiProperty(name: "providerArn", typeJson: "{\"primitive\":\"string\"}")]
        public string ProviderArn
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/bedrockagentcore_gateway_target#credential_location BedrockagentcoreGatewayTarget#credential_location}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "credentialLocation", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? CredentialLocation
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/bedrockagentcore_gateway_target#credential_parameter_name BedrockagentcoreGatewayTarget#credential_parameter_name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "credentialParameterName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? CredentialParameterName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/bedrockagentcore_gateway_target#credential_prefix BedrockagentcoreGatewayTarget#credential_prefix}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "credentialPrefix", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? CredentialPrefix
        {
            get;
            set;
        }
    }
}

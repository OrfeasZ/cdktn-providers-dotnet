using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.BedrockagentcoreGatewayTarget
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.bedrockagentcoreGatewayTarget.BedrockagentcoreGatewayTargetCredentialProviderConfigurationOauth")]
    public class BedrockagentcoreGatewayTargetCredentialProviderConfigurationOauth : aws.BedrockagentcoreGatewayTarget.IBedrockagentcoreGatewayTargetCredentialProviderConfigurationOauth
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/bedrockagentcore_gateway_target#provider_arn BedrockagentcoreGatewayTarget#provider_arn}.</summary>
        [JsiiProperty(name: "providerArn", typeJson: "{\"primitive\":\"string\"}")]
        public string ProviderArn
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/bedrockagentcore_gateway_target#scopes BedrockagentcoreGatewayTarget#scopes}.</summary>
        [JsiiProperty(name: "scopes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public string[] Scopes
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/bedrockagentcore_gateway_target#custom_parameters BedrockagentcoreGatewayTarget#custom_parameters}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "customParameters", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public System.Collections.Generic.IDictionary<string, string>? CustomParameters
        {
            get;
            set;
        }

        /// <summary>The URL where the end user's browser is redirected after obtaining the authorization code. Required when grant_type is AUTHORIZATION_CODE.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/bedrockagentcore_gateway_target#default_return_url BedrockagentcoreGatewayTarget#default_return_url}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "defaultReturnUrl", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? DefaultReturnUrl
        {
            get;
            set;
        }

        /// <summary>The OAuth grant type. Valid values are AUTHORIZATION_CODE and CLIENT_CREDENTIALS.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/bedrockagentcore_gateway_target#grant_type BedrockagentcoreGatewayTarget#grant_type}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "grantType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? GrantType
        {
            get;
            set;
        }
    }
}

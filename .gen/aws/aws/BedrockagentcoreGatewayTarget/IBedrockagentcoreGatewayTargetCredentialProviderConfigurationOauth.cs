using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.BedrockagentcoreGatewayTarget
{
    [JsiiInterface(nativeType: typeof(IBedrockagentcoreGatewayTargetCredentialProviderConfigurationOauth), fullyQualifiedName: "aws.bedrockagentcoreGatewayTarget.BedrockagentcoreGatewayTargetCredentialProviderConfigurationOauth")]
    public interface IBedrockagentcoreGatewayTargetCredentialProviderConfigurationOauth
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/bedrockagentcore_gateway_target#provider_arn BedrockagentcoreGatewayTarget#provider_arn}.</summary>
        [JsiiProperty(name: "providerArn", typeJson: "{\"primitive\":\"string\"}")]
        string ProviderArn
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/bedrockagentcore_gateway_target#scopes BedrockagentcoreGatewayTarget#scopes}.</summary>
        [JsiiProperty(name: "scopes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        string[] Scopes
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/bedrockagentcore_gateway_target#custom_parameters BedrockagentcoreGatewayTarget#custom_parameters}.</summary>
        [JsiiProperty(name: "customParameters", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        System.Collections.Generic.IDictionary<string, string>? CustomParameters
        {
            get
            {
                return null;
            }
        }

        /// <summary>The URL where the end user's browser is redirected after obtaining the authorization code. Required when grant_type is AUTHORIZATION_CODE.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/bedrockagentcore_gateway_target#default_return_url BedrockagentcoreGatewayTarget#default_return_url}
        /// </remarks>
        [JsiiProperty(name: "defaultReturnUrl", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? DefaultReturnUrl
        {
            get
            {
                return null;
            }
        }

        /// <summary>The OAuth grant type. Valid values are AUTHORIZATION_CODE and CLIENT_CREDENTIALS.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/bedrockagentcore_gateway_target#grant_type BedrockagentcoreGatewayTarget#grant_type}
        /// </remarks>
        [JsiiProperty(name: "grantType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? GrantType
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IBedrockagentcoreGatewayTargetCredentialProviderConfigurationOauth), fullyQualifiedName: "aws.bedrockagentcoreGatewayTarget.BedrockagentcoreGatewayTargetCredentialProviderConfigurationOauth")]
        internal sealed class _Proxy : DeputyBase, aws.BedrockagentcoreGatewayTarget.IBedrockagentcoreGatewayTargetCredentialProviderConfigurationOauth
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/bedrockagentcore_gateway_target#provider_arn BedrockagentcoreGatewayTarget#provider_arn}.</summary>
            [JsiiProperty(name: "providerArn", typeJson: "{\"primitive\":\"string\"}")]
            public string ProviderArn
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/bedrockagentcore_gateway_target#scopes BedrockagentcoreGatewayTarget#scopes}.</summary>
            [JsiiProperty(name: "scopes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
            public string[] Scopes
            {
                get => GetInstanceProperty<string[]>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/bedrockagentcore_gateway_target#custom_parameters BedrockagentcoreGatewayTarget#custom_parameters}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "customParameters", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, string>? CustomParameters
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
            }

            /// <summary>The URL where the end user's browser is redirected after obtaining the authorization code. Required when grant_type is AUTHORIZATION_CODE.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/bedrockagentcore_gateway_target#default_return_url BedrockagentcoreGatewayTarget#default_return_url}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "defaultReturnUrl", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? DefaultReturnUrl
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>The OAuth grant type. Valid values are AUTHORIZATION_CODE and CLIENT_CREDENTIALS.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/bedrockagentcore_gateway_target#grant_type BedrockagentcoreGatewayTarget#grant_type}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "grantType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? GrantType
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}

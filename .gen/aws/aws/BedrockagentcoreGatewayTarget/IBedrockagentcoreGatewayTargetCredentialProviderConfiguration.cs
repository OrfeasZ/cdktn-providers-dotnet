using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.BedrockagentcoreGatewayTarget
{
    [JsiiInterface(nativeType: typeof(IBedrockagentcoreGatewayTargetCredentialProviderConfiguration), fullyQualifiedName: "aws.bedrockagentcoreGatewayTarget.BedrockagentcoreGatewayTargetCredentialProviderConfiguration")]
    public interface IBedrockagentcoreGatewayTargetCredentialProviderConfiguration
    {
        /// <summary>api_key block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/bedrockagentcore_gateway_target#api_key BedrockagentcoreGatewayTarget#api_key}
        /// </remarks>
        [JsiiProperty(name: "apiKey", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.bedrockagentcoreGatewayTarget.BedrockagentcoreGatewayTargetCredentialProviderConfigurationApiKey\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? ApiKey
        {
            get
            {
                return null;
            }
        }

        /// <summary>gateway_iam_role block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/bedrockagentcore_gateway_target#gateway_iam_role BedrockagentcoreGatewayTarget#gateway_iam_role}
        /// </remarks>
        [JsiiProperty(name: "gatewayIamRole", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.bedrockagentcoreGatewayTarget.BedrockagentcoreGatewayTargetCredentialProviderConfigurationGatewayIamRole\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? GatewayIamRole
        {
            get
            {
                return null;
            }
        }

        /// <summary>oauth block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/bedrockagentcore_gateway_target#oauth BedrockagentcoreGatewayTarget#oauth}
        /// </remarks>
        [JsiiProperty(name: "oauth", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.bedrockagentcoreGatewayTarget.BedrockagentcoreGatewayTargetCredentialProviderConfigurationOauth\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Oauth
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IBedrockagentcoreGatewayTargetCredentialProviderConfiguration), fullyQualifiedName: "aws.bedrockagentcoreGatewayTarget.BedrockagentcoreGatewayTargetCredentialProviderConfiguration")]
        internal sealed class _Proxy : DeputyBase, aws.BedrockagentcoreGatewayTarget.IBedrockagentcoreGatewayTargetCredentialProviderConfiguration
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>api_key block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/bedrockagentcore_gateway_target#api_key BedrockagentcoreGatewayTarget#api_key}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "apiKey", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.bedrockagentcoreGatewayTarget.BedrockagentcoreGatewayTargetCredentialProviderConfigurationApiKey\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? ApiKey
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>gateway_iam_role block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/bedrockagentcore_gateway_target#gateway_iam_role BedrockagentcoreGatewayTarget#gateway_iam_role}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "gatewayIamRole", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.bedrockagentcoreGatewayTarget.BedrockagentcoreGatewayTargetCredentialProviderConfigurationGatewayIamRole\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? GatewayIamRole
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>oauth block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/bedrockagentcore_gateway_target#oauth BedrockagentcoreGatewayTarget#oauth}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "oauth", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.bedrockagentcoreGatewayTarget.BedrockagentcoreGatewayTargetCredentialProviderConfigurationOauth\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Oauth
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}

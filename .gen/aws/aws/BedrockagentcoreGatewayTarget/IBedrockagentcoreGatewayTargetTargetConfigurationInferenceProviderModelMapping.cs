using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.BedrockagentcoreGatewayTarget
{
    [JsiiInterface(nativeType: typeof(IBedrockagentcoreGatewayTargetTargetConfigurationInferenceProviderModelMapping), fullyQualifiedName: "aws.bedrockagentcoreGatewayTarget.BedrockagentcoreGatewayTargetTargetConfigurationInferenceProviderModelMapping")]
    public interface IBedrockagentcoreGatewayTargetTargetConfigurationInferenceProviderModelMapping
    {
        /// <summary>provider_prefix block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/bedrockagentcore_gateway_target#provider_prefix BedrockagentcoreGatewayTarget#provider_prefix}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.BedrockagentcoreGatewayTarget.IBedrockagentcoreGatewayTargetTargetConfigurationInferenceProviderModelMappingProviderPrefix" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "providerPrefix", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.bedrockagentcoreGatewayTarget.BedrockagentcoreGatewayTargetTargetConfigurationInferenceProviderModelMappingProviderPrefix\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? ProviderPrefix
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IBedrockagentcoreGatewayTargetTargetConfigurationInferenceProviderModelMapping), fullyQualifiedName: "aws.bedrockagentcoreGatewayTarget.BedrockagentcoreGatewayTargetTargetConfigurationInferenceProviderModelMapping")]
        internal sealed class _Proxy : DeputyBase, aws.BedrockagentcoreGatewayTarget.IBedrockagentcoreGatewayTargetTargetConfigurationInferenceProviderModelMapping
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>provider_prefix block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/bedrockagentcore_gateway_target#provider_prefix BedrockagentcoreGatewayTarget#provider_prefix}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.BedrockagentcoreGatewayTarget.IBedrockagentcoreGatewayTargetTargetConfigurationInferenceProviderModelMappingProviderPrefix" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "providerPrefix", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.bedrockagentcoreGatewayTarget.BedrockagentcoreGatewayTargetTargetConfigurationInferenceProviderModelMappingProviderPrefix\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? ProviderPrefix
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}

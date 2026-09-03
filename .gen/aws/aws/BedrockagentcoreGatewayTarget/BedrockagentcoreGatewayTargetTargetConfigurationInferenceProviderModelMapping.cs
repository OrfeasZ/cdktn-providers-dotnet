using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.BedrockagentcoreGatewayTarget
{
    [JsiiByValue(fqn: "aws.bedrockagentcoreGatewayTarget.BedrockagentcoreGatewayTargetTargetConfigurationInferenceProviderModelMapping")]
    public class BedrockagentcoreGatewayTargetTargetConfigurationInferenceProviderModelMapping : aws.BedrockagentcoreGatewayTarget.IBedrockagentcoreGatewayTargetTargetConfigurationInferenceProviderModelMapping
    {
        private object? _providerPrefix;

        /// <summary>provider_prefix block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/bedrockagentcore_gateway_target#provider_prefix BedrockagentcoreGatewayTarget#provider_prefix}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.BedrockagentcoreGatewayTarget.IBedrockagentcoreGatewayTargetTargetConfigurationInferenceProviderModelMappingProviderPrefix" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "providerPrefix", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.bedrockagentcoreGatewayTarget.BedrockagentcoreGatewayTargetTargetConfigurationInferenceProviderModelMappingProviderPrefix\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? ProviderPrefix
        {
            get => _providerPrefix;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.BedrockagentcoreGatewayTarget.IBedrockagentcoreGatewayTargetTargetConfigurationInferenceProviderModelMappingProviderPrefix[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.BedrockagentcoreGatewayTarget.IBedrockagentcoreGatewayTargetTargetConfigurationInferenceProviderModelMappingProviderPrefix).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _providerPrefix = value;
            }
        }
    }
}

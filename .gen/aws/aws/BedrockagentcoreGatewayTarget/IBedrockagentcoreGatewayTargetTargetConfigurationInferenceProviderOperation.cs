using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.BedrockagentcoreGatewayTarget
{
    [JsiiInterface(nativeType: typeof(IBedrockagentcoreGatewayTargetTargetConfigurationInferenceProviderOperation), fullyQualifiedName: "aws.bedrockagentcoreGatewayTarget.BedrockagentcoreGatewayTargetTargetConfigurationInferenceProviderOperation")]
    public interface IBedrockagentcoreGatewayTargetTargetConfigurationInferenceProviderOperation
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/bedrockagentcore_gateway_target#path BedrockagentcoreGatewayTarget#path}.</summary>
        [JsiiProperty(name: "path", typeJson: "{\"primitive\":\"string\"}")]
        string Path
        {
            get;
        }

        /// <summary>model block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/bedrockagentcore_gateway_target#model BedrockagentcoreGatewayTarget#model}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.BedrockagentcoreGatewayTarget.IBedrockagentcoreGatewayTargetTargetConfigurationInferenceProviderOperationModel" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "model", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.bedrockagentcoreGatewayTarget.BedrockagentcoreGatewayTargetTargetConfigurationInferenceProviderOperationModel\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Model
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/bedrockagentcore_gateway_target#provider_path BedrockagentcoreGatewayTarget#provider_path}.</summary>
        [JsiiProperty(name: "providerPath", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ProviderPath
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IBedrockagentcoreGatewayTargetTargetConfigurationInferenceProviderOperation), fullyQualifiedName: "aws.bedrockagentcoreGatewayTarget.BedrockagentcoreGatewayTargetTargetConfigurationInferenceProviderOperation")]
        internal sealed class _Proxy : DeputyBase, aws.BedrockagentcoreGatewayTarget.IBedrockagentcoreGatewayTargetTargetConfigurationInferenceProviderOperation
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/bedrockagentcore_gateway_target#path BedrockagentcoreGatewayTarget#path}.</summary>
            [JsiiProperty(name: "path", typeJson: "{\"primitive\":\"string\"}")]
            public string Path
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>model block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/bedrockagentcore_gateway_target#model BedrockagentcoreGatewayTarget#model}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.BedrockagentcoreGatewayTarget.IBedrockagentcoreGatewayTargetTargetConfigurationInferenceProviderOperationModel" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "model", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.bedrockagentcoreGatewayTarget.BedrockagentcoreGatewayTargetTargetConfigurationInferenceProviderOperationModel\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Model
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/bedrockagentcore_gateway_target#provider_path BedrockagentcoreGatewayTarget#provider_path}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "providerPath", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ProviderPath
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}

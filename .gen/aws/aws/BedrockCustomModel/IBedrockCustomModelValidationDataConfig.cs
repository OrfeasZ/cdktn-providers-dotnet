using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.BedrockCustomModel
{
    [JsiiInterface(nativeType: typeof(IBedrockCustomModelValidationDataConfig), fullyQualifiedName: "aws.bedrockCustomModel.BedrockCustomModelValidationDataConfig")]
    public interface IBedrockCustomModelValidationDataConfig
    {
        /// <summary>validator block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.58.0/docs/resources/bedrock_custom_model#validator BedrockCustomModel#validator}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.BedrockCustomModel.IBedrockCustomModelValidationDataConfigValidator" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "validator", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.bedrockCustomModel.BedrockCustomModelValidationDataConfigValidator\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Validator
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IBedrockCustomModelValidationDataConfig), fullyQualifiedName: "aws.bedrockCustomModel.BedrockCustomModelValidationDataConfig")]
        internal sealed class _Proxy : DeputyBase, aws.BedrockCustomModel.IBedrockCustomModelValidationDataConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>validator block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.58.0/docs/resources/bedrock_custom_model#validator BedrockCustomModel#validator}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.BedrockCustomModel.IBedrockCustomModelValidationDataConfigValidator" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "validator", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.bedrockCustomModel.BedrockCustomModelValidationDataConfigValidator\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Validator
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}

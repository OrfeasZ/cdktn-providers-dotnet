using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.BedrockGuardrail
{
    [JsiiInterface(nativeType: typeof(IBedrockGuardrailContentPolicyConfig), fullyQualifiedName: "aws.bedrockGuardrail.BedrockGuardrailContentPolicyConfig")]
    public interface IBedrockGuardrailContentPolicyConfig
    {
        /// <summary>filters_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.58.0/docs/resources/bedrock_guardrail#filters_config BedrockGuardrail#filters_config}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.BedrockGuardrail.IBedrockGuardrailContentPolicyConfigFiltersConfig" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "filtersConfig", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.bedrockGuardrail.BedrockGuardrailContentPolicyConfigFiltersConfig\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? FiltersConfig
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.58.0/docs/resources/bedrock_guardrail#tier_config BedrockGuardrail#tier_config}.</summary>
        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.BedrockGuardrail.IBedrockGuardrailContentPolicyConfigTierConfig" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "tierConfig", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.bedrockGuardrail.BedrockGuardrailContentPolicyConfigTierConfig\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? TierConfig
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IBedrockGuardrailContentPolicyConfig), fullyQualifiedName: "aws.bedrockGuardrail.BedrockGuardrailContentPolicyConfig")]
        internal sealed class _Proxy : DeputyBase, aws.BedrockGuardrail.IBedrockGuardrailContentPolicyConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>filters_config block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.58.0/docs/resources/bedrock_guardrail#filters_config BedrockGuardrail#filters_config}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.BedrockGuardrail.IBedrockGuardrailContentPolicyConfigFiltersConfig" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "filtersConfig", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.bedrockGuardrail.BedrockGuardrailContentPolicyConfigFiltersConfig\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? FiltersConfig
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.58.0/docs/resources/bedrock_guardrail#tier_config BedrockGuardrail#tier_config}.</summary>
            /// <remarks>
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.BedrockGuardrail.IBedrockGuardrailContentPolicyConfigTierConfig" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "tierConfig", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.bedrockGuardrail.BedrockGuardrailContentPolicyConfigTierConfig\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? TierConfig
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}

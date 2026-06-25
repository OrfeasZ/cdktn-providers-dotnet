using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.BedrockGuardrail
{
    [JsiiInterface(nativeType: typeof(IBedrockGuardrailTopicPolicyConfig), fullyQualifiedName: "aws.bedrockGuardrail.BedrockGuardrailTopicPolicyConfig")]
    public interface IBedrockGuardrailTopicPolicyConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.52.0/docs/resources/bedrock_guardrail#tier_config BedrockGuardrail#tier_config}.</summary>
        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.BedrockGuardrail.IBedrockGuardrailTopicPolicyConfigTierConfig" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "tierConfig", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.bedrockGuardrail.BedrockGuardrailTopicPolicyConfigTierConfig\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? TierConfig
        {
            get
            {
                return null;
            }
        }

        /// <summary>topics_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.52.0/docs/resources/bedrock_guardrail#topics_config BedrockGuardrail#topics_config}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.BedrockGuardrail.IBedrockGuardrailTopicPolicyConfigTopicsConfig" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "topicsConfig", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.bedrockGuardrail.BedrockGuardrailTopicPolicyConfigTopicsConfig\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? TopicsConfig
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IBedrockGuardrailTopicPolicyConfig), fullyQualifiedName: "aws.bedrockGuardrail.BedrockGuardrailTopicPolicyConfig")]
        internal sealed class _Proxy : DeputyBase, aws.BedrockGuardrail.IBedrockGuardrailTopicPolicyConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.52.0/docs/resources/bedrock_guardrail#tier_config BedrockGuardrail#tier_config}.</summary>
            /// <remarks>
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.BedrockGuardrail.IBedrockGuardrailTopicPolicyConfigTierConfig" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "tierConfig", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.bedrockGuardrail.BedrockGuardrailTopicPolicyConfigTierConfig\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? TierConfig
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>topics_config block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.52.0/docs/resources/bedrock_guardrail#topics_config BedrockGuardrail#topics_config}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.BedrockGuardrail.IBedrockGuardrailTopicPolicyConfigTopicsConfig" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "topicsConfig", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.bedrockGuardrail.BedrockGuardrailTopicPolicyConfigTopicsConfig\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? TopicsConfig
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}

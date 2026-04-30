using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.BedrockGuardrail
{
    [JsiiByValue(fqn: "aws.bedrockGuardrail.BedrockGuardrailTopicPolicyConfig")]
    public class BedrockGuardrailTopicPolicyConfig : aws.BedrockGuardrail.IBedrockGuardrailTopicPolicyConfig
    {
        private object? _tierConfig;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/bedrock_guardrail#tier_config BedrockGuardrail#tier_config}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "tierConfig", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.bedrockGuardrail.BedrockGuardrailTopicPolicyConfigTierConfig\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? TierConfig
        {
            get => _tierConfig;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.BedrockGuardrail.IBedrockGuardrailTopicPolicyConfigTierConfig[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.BedrockGuardrail.IBedrockGuardrailTopicPolicyConfigTierConfig).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _tierConfig = value;
            }
        }

        private object? _topicsConfig;

        /// <summary>topics_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/bedrock_guardrail#topics_config BedrockGuardrail#topics_config}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "topicsConfig", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.bedrockGuardrail.BedrockGuardrailTopicPolicyConfigTopicsConfig\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? TopicsConfig
        {
            get => _topicsConfig;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.BedrockGuardrail.IBedrockGuardrailTopicPolicyConfigTopicsConfig[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.BedrockGuardrail.IBedrockGuardrailTopicPolicyConfigTopicsConfig).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _topicsConfig = value;
            }
        }
    }
}

using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.BedrockGuardrail
{
    [JsiiByValue(fqn: "aws.bedrockGuardrail.BedrockGuardrailContentPolicyConfig")]
    public class BedrockGuardrailContentPolicyConfig : aws.BedrockGuardrail.IBedrockGuardrailContentPolicyConfig
    {
        private object? _filtersConfig;

        /// <summary>filters_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/bedrock_guardrail#filters_config BedrockGuardrail#filters_config}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "filtersConfig", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.bedrockGuardrail.BedrockGuardrailContentPolicyConfigFiltersConfig\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? FiltersConfig
        {
            get => _filtersConfig;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.BedrockGuardrail.IBedrockGuardrailContentPolicyConfigFiltersConfig[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.BedrockGuardrail.IBedrockGuardrailContentPolicyConfigFiltersConfig).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _filtersConfig = value;
            }
        }

        private object? _tierConfig;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/bedrock_guardrail#tier_config BedrockGuardrail#tier_config}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "tierConfig", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.bedrockGuardrail.BedrockGuardrailContentPolicyConfigTierConfig\"},\"kind\":\"array\"}}]}}", isOptional: true)]
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
                        case aws.BedrockGuardrail.IBedrockGuardrailContentPolicyConfigTierConfig[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.BedrockGuardrail.IBedrockGuardrailContentPolicyConfigTierConfig).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _tierConfig = value;
            }
        }
    }
}

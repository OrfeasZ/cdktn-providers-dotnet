using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.BedrockagentcoreMemoryStrategy
{
    [JsiiByValue(fqn: "aws.bedrockagentcoreMemoryStrategy.BedrockagentcoreMemoryStrategyConfigurationSelfManagedConfiguration")]
    public class BedrockagentcoreMemoryStrategyConfigurationSelfManagedConfiguration : aws.BedrockagentcoreMemoryStrategy.IBedrockagentcoreMemoryStrategyConfigurationSelfManagedConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/bedrockagentcore_memory_strategy#historical_context_window_size BedrockagentcoreMemoryStrategy#historical_context_window_size}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "historicalContextWindowSize", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? HistoricalContextWindowSize
        {
            get;
            set;
        }

        private object? _invocationConfiguration;

        /// <summary>invocation_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/bedrockagentcore_memory_strategy#invocation_configuration BedrockagentcoreMemoryStrategy#invocation_configuration}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.BedrockagentcoreMemoryStrategy.IBedrockagentcoreMemoryStrategyConfigurationSelfManagedConfigurationInvocationConfiguration" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "invocationConfiguration", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.bedrockagentcoreMemoryStrategy.BedrockagentcoreMemoryStrategyConfigurationSelfManagedConfigurationInvocationConfiguration\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? InvocationConfiguration
        {
            get => _invocationConfiguration;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.BedrockagentcoreMemoryStrategy.IBedrockagentcoreMemoryStrategyConfigurationSelfManagedConfigurationInvocationConfiguration[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.BedrockagentcoreMemoryStrategy.IBedrockagentcoreMemoryStrategyConfigurationSelfManagedConfigurationInvocationConfiguration).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _invocationConfiguration = value;
            }
        }

        private object? _triggerConditions;

        /// <summary>trigger_conditions block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/bedrockagentcore_memory_strategy#trigger_conditions BedrockagentcoreMemoryStrategy#trigger_conditions}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.BedrockagentcoreMemoryStrategy.IBedrockagentcoreMemoryStrategyConfigurationSelfManagedConfigurationTriggerConditions" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "triggerConditions", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.bedrockagentcoreMemoryStrategy.BedrockagentcoreMemoryStrategyConfigurationSelfManagedConfigurationTriggerConditions\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? TriggerConditions
        {
            get => _triggerConditions;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.BedrockagentcoreMemoryStrategy.IBedrockagentcoreMemoryStrategyConfigurationSelfManagedConfigurationTriggerConditions[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.BedrockagentcoreMemoryStrategy.IBedrockagentcoreMemoryStrategyConfigurationSelfManagedConfigurationTriggerConditions).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _triggerConditions = value;
            }
        }
    }
}

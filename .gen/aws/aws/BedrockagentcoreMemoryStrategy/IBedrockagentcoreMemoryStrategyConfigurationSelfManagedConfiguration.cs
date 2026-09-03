using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.BedrockagentcoreMemoryStrategy
{
    [JsiiInterface(nativeType: typeof(IBedrockagentcoreMemoryStrategyConfigurationSelfManagedConfiguration), fullyQualifiedName: "aws.bedrockagentcoreMemoryStrategy.BedrockagentcoreMemoryStrategyConfigurationSelfManagedConfiguration")]
    public interface IBedrockagentcoreMemoryStrategyConfigurationSelfManagedConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/bedrockagentcore_memory_strategy#historical_context_window_size BedrockagentcoreMemoryStrategy#historical_context_window_size}.</summary>
        [JsiiProperty(name: "historicalContextWindowSize", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? HistoricalContextWindowSize
        {
            get
            {
                return null;
            }
        }

        /// <summary>invocation_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/bedrockagentcore_memory_strategy#invocation_configuration BedrockagentcoreMemoryStrategy#invocation_configuration}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.BedrockagentcoreMemoryStrategy.IBedrockagentcoreMemoryStrategyConfigurationSelfManagedConfigurationInvocationConfiguration" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "invocationConfiguration", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.bedrockagentcoreMemoryStrategy.BedrockagentcoreMemoryStrategyConfigurationSelfManagedConfigurationInvocationConfiguration\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? InvocationConfiguration
        {
            get
            {
                return null;
            }
        }

        /// <summary>trigger_conditions block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/bedrockagentcore_memory_strategy#trigger_conditions BedrockagentcoreMemoryStrategy#trigger_conditions}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.BedrockagentcoreMemoryStrategy.IBedrockagentcoreMemoryStrategyConfigurationSelfManagedConfigurationTriggerConditions" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "triggerConditions", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.bedrockagentcoreMemoryStrategy.BedrockagentcoreMemoryStrategyConfigurationSelfManagedConfigurationTriggerConditions\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? TriggerConditions
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IBedrockagentcoreMemoryStrategyConfigurationSelfManagedConfiguration), fullyQualifiedName: "aws.bedrockagentcoreMemoryStrategy.BedrockagentcoreMemoryStrategyConfigurationSelfManagedConfiguration")]
        internal sealed class _Proxy : DeputyBase, aws.BedrockagentcoreMemoryStrategy.IBedrockagentcoreMemoryStrategyConfigurationSelfManagedConfiguration
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/bedrockagentcore_memory_strategy#historical_context_window_size BedrockagentcoreMemoryStrategy#historical_context_window_size}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "historicalContextWindowSize", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? HistoricalContextWindowSize
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>invocation_configuration block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/bedrockagentcore_memory_strategy#invocation_configuration BedrockagentcoreMemoryStrategy#invocation_configuration}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.BedrockagentcoreMemoryStrategy.IBedrockagentcoreMemoryStrategyConfigurationSelfManagedConfigurationInvocationConfiguration" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "invocationConfiguration", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.bedrockagentcoreMemoryStrategy.BedrockagentcoreMemoryStrategyConfigurationSelfManagedConfigurationInvocationConfiguration\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? InvocationConfiguration
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>trigger_conditions block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/bedrockagentcore_memory_strategy#trigger_conditions BedrockagentcoreMemoryStrategy#trigger_conditions}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.BedrockagentcoreMemoryStrategy.IBedrockagentcoreMemoryStrategyConfigurationSelfManagedConfigurationTriggerConditions" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "triggerConditions", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.bedrockagentcoreMemoryStrategy.BedrockagentcoreMemoryStrategyConfigurationSelfManagedConfigurationTriggerConditions\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? TriggerConditions
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}

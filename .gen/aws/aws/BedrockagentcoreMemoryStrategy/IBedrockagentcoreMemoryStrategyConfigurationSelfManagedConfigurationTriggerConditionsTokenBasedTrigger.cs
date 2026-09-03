using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.BedrockagentcoreMemoryStrategy
{
    [JsiiInterface(nativeType: typeof(IBedrockagentcoreMemoryStrategyConfigurationSelfManagedConfigurationTriggerConditionsTokenBasedTrigger), fullyQualifiedName: "aws.bedrockagentcoreMemoryStrategy.BedrockagentcoreMemoryStrategyConfigurationSelfManagedConfigurationTriggerConditionsTokenBasedTrigger")]
    public interface IBedrockagentcoreMemoryStrategyConfigurationSelfManagedConfigurationTriggerConditionsTokenBasedTrigger
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/bedrockagentcore_memory_strategy#token_count BedrockagentcoreMemoryStrategy#token_count}.</summary>
        [JsiiProperty(name: "tokenCount", typeJson: "{\"primitive\":\"number\"}")]
        double TokenCount
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IBedrockagentcoreMemoryStrategyConfigurationSelfManagedConfigurationTriggerConditionsTokenBasedTrigger), fullyQualifiedName: "aws.bedrockagentcoreMemoryStrategy.BedrockagentcoreMemoryStrategyConfigurationSelfManagedConfigurationTriggerConditionsTokenBasedTrigger")]
        internal sealed class _Proxy : DeputyBase, aws.BedrockagentcoreMemoryStrategy.IBedrockagentcoreMemoryStrategyConfigurationSelfManagedConfigurationTriggerConditionsTokenBasedTrigger
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/bedrockagentcore_memory_strategy#token_count BedrockagentcoreMemoryStrategy#token_count}.</summary>
            [JsiiProperty(name: "tokenCount", typeJson: "{\"primitive\":\"number\"}")]
            public double TokenCount
            {
                get => GetInstanceProperty<double>()!;
            }
        }
    }
}

using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.BedrockagentcoreMemoryStrategy
{
    [JsiiInterface(nativeType: typeof(IBedrockagentcoreMemoryStrategyConfigurationSelfManagedConfigurationTriggerConditionsMessageBasedTrigger), fullyQualifiedName: "aws.bedrockagentcoreMemoryStrategy.BedrockagentcoreMemoryStrategyConfigurationSelfManagedConfigurationTriggerConditionsMessageBasedTrigger")]
    public interface IBedrockagentcoreMemoryStrategyConfigurationSelfManagedConfigurationTriggerConditionsMessageBasedTrigger
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/bedrockagentcore_memory_strategy#message_count BedrockagentcoreMemoryStrategy#message_count}.</summary>
        [JsiiProperty(name: "messageCount", typeJson: "{\"primitive\":\"number\"}")]
        double MessageCount
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IBedrockagentcoreMemoryStrategyConfigurationSelfManagedConfigurationTriggerConditionsMessageBasedTrigger), fullyQualifiedName: "aws.bedrockagentcoreMemoryStrategy.BedrockagentcoreMemoryStrategyConfigurationSelfManagedConfigurationTriggerConditionsMessageBasedTrigger")]
        internal sealed class _Proxy : DeputyBase, aws.BedrockagentcoreMemoryStrategy.IBedrockagentcoreMemoryStrategyConfigurationSelfManagedConfigurationTriggerConditionsMessageBasedTrigger
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/bedrockagentcore_memory_strategy#message_count BedrockagentcoreMemoryStrategy#message_count}.</summary>
            [JsiiProperty(name: "messageCount", typeJson: "{\"primitive\":\"number\"}")]
            public double MessageCount
            {
                get => GetInstanceProperty<double>()!;
            }
        }
    }
}

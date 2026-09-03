using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.BedrockagentcoreMemoryStrategy
{
    [JsiiInterface(nativeType: typeof(IBedrockagentcoreMemoryStrategyConfigurationSelfManagedConfigurationTriggerConditionsTimeBasedTrigger), fullyQualifiedName: "aws.bedrockagentcoreMemoryStrategy.BedrockagentcoreMemoryStrategyConfigurationSelfManagedConfigurationTriggerConditionsTimeBasedTrigger")]
    public interface IBedrockagentcoreMemoryStrategyConfigurationSelfManagedConfigurationTriggerConditionsTimeBasedTrigger
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/bedrockagentcore_memory_strategy#idle_session_timeout BedrockagentcoreMemoryStrategy#idle_session_timeout}.</summary>
        [JsiiProperty(name: "idleSessionTimeout", typeJson: "{\"primitive\":\"number\"}")]
        double IdleSessionTimeout
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IBedrockagentcoreMemoryStrategyConfigurationSelfManagedConfigurationTriggerConditionsTimeBasedTrigger), fullyQualifiedName: "aws.bedrockagentcoreMemoryStrategy.BedrockagentcoreMemoryStrategyConfigurationSelfManagedConfigurationTriggerConditionsTimeBasedTrigger")]
        internal sealed class _Proxy : DeputyBase, aws.BedrockagentcoreMemoryStrategy.IBedrockagentcoreMemoryStrategyConfigurationSelfManagedConfigurationTriggerConditionsTimeBasedTrigger
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/bedrockagentcore_memory_strategy#idle_session_timeout BedrockagentcoreMemoryStrategy#idle_session_timeout}.</summary>
            [JsiiProperty(name: "idleSessionTimeout", typeJson: "{\"primitive\":\"number\"}")]
            public double IdleSessionTimeout
            {
                get => GetInstanceProperty<double>()!;
            }
        }
    }
}

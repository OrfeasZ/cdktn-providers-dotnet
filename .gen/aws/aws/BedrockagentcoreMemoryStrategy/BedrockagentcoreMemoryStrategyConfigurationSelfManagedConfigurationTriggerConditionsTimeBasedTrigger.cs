using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.BedrockagentcoreMemoryStrategy
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.bedrockagentcoreMemoryStrategy.BedrockagentcoreMemoryStrategyConfigurationSelfManagedConfigurationTriggerConditionsTimeBasedTrigger")]
    public class BedrockagentcoreMemoryStrategyConfigurationSelfManagedConfigurationTriggerConditionsTimeBasedTrigger : aws.BedrockagentcoreMemoryStrategy.IBedrockagentcoreMemoryStrategyConfigurationSelfManagedConfigurationTriggerConditionsTimeBasedTrigger
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/bedrockagentcore_memory_strategy#idle_session_timeout BedrockagentcoreMemoryStrategy#idle_session_timeout}.</summary>
        [JsiiProperty(name: "idleSessionTimeout", typeJson: "{\"primitive\":\"number\"}")]
        public double IdleSessionTimeout
        {
            get;
            set;
        }
    }
}

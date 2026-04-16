using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.BedrockagentcoreAgentRuntime
{
    [JsiiByValue(fqn: "aws.bedrockagentcoreAgentRuntime.BedrockagentcoreAgentRuntimeLifecycleConfiguration")]
    public class BedrockagentcoreAgentRuntimeLifecycleConfiguration : aws.BedrockagentcoreAgentRuntime.IBedrockagentcoreAgentRuntimeLifecycleConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/bedrockagentcore_agent_runtime#idle_runtime_session_timeout BedrockagentcoreAgentRuntime#idle_runtime_session_timeout}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "idleRuntimeSessionTimeout", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? IdleRuntimeSessionTimeout
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/bedrockagentcore_agent_runtime#max_lifetime BedrockagentcoreAgentRuntime#max_lifetime}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "maxLifetime", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? MaxLifetime
        {
            get;
            set;
        }
    }
}

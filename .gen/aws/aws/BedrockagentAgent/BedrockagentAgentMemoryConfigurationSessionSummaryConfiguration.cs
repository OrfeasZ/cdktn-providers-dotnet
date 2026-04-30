using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.BedrockagentAgent
{
    [JsiiByValue(fqn: "aws.bedrockagentAgent.BedrockagentAgentMemoryConfigurationSessionSummaryConfiguration")]
    public class BedrockagentAgentMemoryConfigurationSessionSummaryConfiguration : aws.BedrockagentAgent.IBedrockagentAgentMemoryConfigurationSessionSummaryConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/bedrockagent_agent#max_recent_sessions BedrockagentAgent#max_recent_sessions}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "maxRecentSessions", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? MaxRecentSessions
        {
            get;
            set;
        }
    }
}

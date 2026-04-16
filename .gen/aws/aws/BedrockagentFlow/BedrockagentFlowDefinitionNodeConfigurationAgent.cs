using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.BedrockagentFlow
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.bedrockagentFlow.BedrockagentFlowDefinitionNodeConfigurationAgent")]
    public class BedrockagentFlowDefinitionNodeConfigurationAgent : aws.BedrockagentFlow.IBedrockagentFlowDefinitionNodeConfigurationAgent
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/bedrockagent_flow#agent_alias_arn BedrockagentFlow#agent_alias_arn}.</summary>
        [JsiiProperty(name: "agentAliasArn", typeJson: "{\"primitive\":\"string\"}")]
        public string AgentAliasArn
        {
            get;
            set;
        }
    }
}

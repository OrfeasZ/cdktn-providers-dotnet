using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.BedrockagentFlow
{
    [JsiiInterface(nativeType: typeof(IBedrockagentFlowDefinitionNodeConfigurationAgent), fullyQualifiedName: "aws.bedrockagentFlow.BedrockagentFlowDefinitionNodeConfigurationAgent")]
    public interface IBedrockagentFlowDefinitionNodeConfigurationAgent
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/bedrockagent_flow#agent_alias_arn BedrockagentFlow#agent_alias_arn}.</summary>
        [JsiiProperty(name: "agentAliasArn", typeJson: "{\"primitive\":\"string\"}")]
        string AgentAliasArn
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IBedrockagentFlowDefinitionNodeConfigurationAgent), fullyQualifiedName: "aws.bedrockagentFlow.BedrockagentFlowDefinitionNodeConfigurationAgent")]
        internal sealed class _Proxy : DeputyBase, aws.BedrockagentFlow.IBedrockagentFlowDefinitionNodeConfigurationAgent
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/bedrockagent_flow#agent_alias_arn BedrockagentFlow#agent_alias_arn}.</summary>
            [JsiiProperty(name: "agentAliasArn", typeJson: "{\"primitive\":\"string\"}")]
            public string AgentAliasArn
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}

using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.BedrockagentFlow
{
    [JsiiInterface(nativeType: typeof(IBedrockagentFlowDefinitionNodeConfigurationPromptSourceConfigurationResource), fullyQualifiedName: "aws.bedrockagentFlow.BedrockagentFlowDefinitionNodeConfigurationPromptSourceConfigurationResource")]
    public interface IBedrockagentFlowDefinitionNodeConfigurationPromptSourceConfigurationResource
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/bedrockagent_flow#prompt_arn BedrockagentFlow#prompt_arn}.</summary>
        [JsiiProperty(name: "promptArn", typeJson: "{\"primitive\":\"string\"}")]
        string PromptArn
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IBedrockagentFlowDefinitionNodeConfigurationPromptSourceConfigurationResource), fullyQualifiedName: "aws.bedrockagentFlow.BedrockagentFlowDefinitionNodeConfigurationPromptSourceConfigurationResource")]
        internal sealed class _Proxy : DeputyBase, aws.BedrockagentFlow.IBedrockagentFlowDefinitionNodeConfigurationPromptSourceConfigurationResource
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/bedrockagent_flow#prompt_arn BedrockagentFlow#prompt_arn}.</summary>
            [JsiiProperty(name: "promptArn", typeJson: "{\"primitive\":\"string\"}")]
            public string PromptArn
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}

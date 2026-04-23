using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.BedrockagentFlow
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.bedrockagentFlow.BedrockagentFlowDefinitionNodeConfigurationPromptSourceConfigurationResource")]
    public class BedrockagentFlowDefinitionNodeConfigurationPromptSourceConfigurationResource : aws.BedrockagentFlow.IBedrockagentFlowDefinitionNodeConfigurationPromptSourceConfigurationResource
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/bedrockagent_flow#prompt_arn BedrockagentFlow#prompt_arn}.</summary>
        [JsiiProperty(name: "promptArn", typeJson: "{\"primitive\":\"string\"}")]
        public string PromptArn
        {
            get;
            set;
        }
    }
}

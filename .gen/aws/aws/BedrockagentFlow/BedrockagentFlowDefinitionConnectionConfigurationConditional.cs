using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.BedrockagentFlow
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.bedrockagentFlow.BedrockagentFlowDefinitionConnectionConfigurationConditional")]
    public class BedrockagentFlowDefinitionConnectionConfigurationConditional : aws.BedrockagentFlow.IBedrockagentFlowDefinitionConnectionConfigurationConditional
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/bedrockagent_flow#condition BedrockagentFlow#condition}.</summary>
        [JsiiProperty(name: "condition", typeJson: "{\"primitive\":\"string\"}")]
        public string Condition
        {
            get;
            set;
        }
    }
}

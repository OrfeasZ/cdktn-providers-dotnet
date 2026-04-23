using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.BedrockagentFlow
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.bedrockagentFlow.BedrockagentFlowDefinitionConnectionConfigurationData")]
    public class BedrockagentFlowDefinitionConnectionConfigurationData : aws.BedrockagentFlow.IBedrockagentFlowDefinitionConnectionConfigurationData
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/bedrockagent_flow#source_output BedrockagentFlow#source_output}.</summary>
        [JsiiProperty(name: "sourceOutput", typeJson: "{\"primitive\":\"string\"}")]
        public string SourceOutput
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/bedrockagent_flow#target_input BedrockagentFlow#target_input}.</summary>
        [JsiiProperty(name: "targetInput", typeJson: "{\"primitive\":\"string\"}")]
        public string TargetInput
        {
            get;
            set;
        }
    }
}

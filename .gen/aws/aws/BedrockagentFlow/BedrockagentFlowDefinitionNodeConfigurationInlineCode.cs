using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.BedrockagentFlow
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.bedrockagentFlow.BedrockagentFlowDefinitionNodeConfigurationInlineCode")]
    public class BedrockagentFlowDefinitionNodeConfigurationInlineCode : aws.BedrockagentFlow.IBedrockagentFlowDefinitionNodeConfigurationInlineCode
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/bedrockagent_flow#code BedrockagentFlow#code}.</summary>
        [JsiiProperty(name: "code", typeJson: "{\"primitive\":\"string\"}")]
        public string Code
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/bedrockagent_flow#language BedrockagentFlow#language}.</summary>
        [JsiiProperty(name: "language", typeJson: "{\"primitive\":\"string\"}")]
        public string Language
        {
            get;
            set;
        }
    }
}

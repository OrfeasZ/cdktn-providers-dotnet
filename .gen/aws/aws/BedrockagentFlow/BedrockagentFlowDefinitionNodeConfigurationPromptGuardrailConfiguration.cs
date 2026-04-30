using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.BedrockagentFlow
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.bedrockagentFlow.BedrockagentFlowDefinitionNodeConfigurationPromptGuardrailConfiguration")]
    public class BedrockagentFlowDefinitionNodeConfigurationPromptGuardrailConfiguration : aws.BedrockagentFlow.IBedrockagentFlowDefinitionNodeConfigurationPromptGuardrailConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/bedrockagent_flow#guardrail_identifier BedrockagentFlow#guardrail_identifier}.</summary>
        [JsiiProperty(name: "guardrailIdentifier", typeJson: "{\"primitive\":\"string\"}")]
        public string GuardrailIdentifier
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/bedrockagent_flow#guardrail_version BedrockagentFlow#guardrail_version}.</summary>
        [JsiiProperty(name: "guardrailVersion", typeJson: "{\"primitive\":\"string\"}")]
        public string GuardrailVersion
        {
            get;
            set;
        }
    }
}

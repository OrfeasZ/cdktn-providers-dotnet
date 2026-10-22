using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.BedrockEnforcedGuardrailConfiguration
{
    [JsiiByValue(fqn: "aws.bedrockEnforcedGuardrailConfiguration.BedrockEnforcedGuardrailConfigurationSelectiveContentGuarding")]
    public class BedrockEnforcedGuardrailConfigurationSelectiveContentGuarding : aws.BedrockEnforcedGuardrailConfiguration.IBedrockEnforcedGuardrailConfigurationSelectiveContentGuarding
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.70.0/docs/resources/bedrock_enforced_guardrail_configuration#messages BedrockEnforcedGuardrailConfiguration#messages}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "messages", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Messages
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.70.0/docs/resources/bedrock_enforced_guardrail_configuration#system BedrockEnforcedGuardrailConfiguration#system}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "systemAttribute", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? SystemAttribute
        {
            get;
            set;
        }
    }
}

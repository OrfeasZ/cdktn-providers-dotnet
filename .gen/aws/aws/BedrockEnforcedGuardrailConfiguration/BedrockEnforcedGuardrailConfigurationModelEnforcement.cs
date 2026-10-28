using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.BedrockEnforcedGuardrailConfiguration
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.bedrockEnforcedGuardrailConfiguration.BedrockEnforcedGuardrailConfigurationModelEnforcement")]
    public class BedrockEnforcedGuardrailConfigurationModelEnforcement : aws.BedrockEnforcedGuardrailConfiguration.IBedrockEnforcedGuardrailConfigurationModelEnforcement
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.71.0/docs/resources/bedrock_enforced_guardrail_configuration#excluded_models BedrockEnforcedGuardrailConfiguration#excluded_models}.</summary>
        [JsiiProperty(name: "excludedModels", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public string[] ExcludedModels
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.71.0/docs/resources/bedrock_enforced_guardrail_configuration#included_models BedrockEnforcedGuardrailConfiguration#included_models}.</summary>
        [JsiiProperty(name: "includedModels", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public string[] IncludedModels
        {
            get;
            set;
        }
    }
}

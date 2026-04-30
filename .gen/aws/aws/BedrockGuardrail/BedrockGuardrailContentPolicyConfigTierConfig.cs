using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.BedrockGuardrail
{
    [JsiiByValue(fqn: "aws.bedrockGuardrail.BedrockGuardrailContentPolicyConfigTierConfig")]
    public class BedrockGuardrailContentPolicyConfigTierConfig : aws.BedrockGuardrail.IBedrockGuardrailContentPolicyConfigTierConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/bedrock_guardrail#tier_name BedrockGuardrail#tier_name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "tierName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? TierName
        {
            get;
            set;
        }
    }
}

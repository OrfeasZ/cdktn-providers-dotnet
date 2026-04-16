using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.BedrockGuardrail
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.bedrockGuardrail.BedrockGuardrailCrossRegionConfig")]
    public class BedrockGuardrailCrossRegionConfig : aws.BedrockGuardrail.IBedrockGuardrailCrossRegionConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/bedrock_guardrail#guardrail_profile_identifier BedrockGuardrail#guardrail_profile_identifier}.</summary>
        [JsiiProperty(name: "guardrailProfileIdentifier", typeJson: "{\"primitive\":\"string\"}")]
        public string GuardrailProfileIdentifier
        {
            get;
            set;
        }
    }
}

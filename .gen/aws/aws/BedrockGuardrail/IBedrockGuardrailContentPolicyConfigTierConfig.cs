using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.BedrockGuardrail
{
    [JsiiInterface(nativeType: typeof(IBedrockGuardrailContentPolicyConfigTierConfig), fullyQualifiedName: "aws.bedrockGuardrail.BedrockGuardrailContentPolicyConfigTierConfig")]
    public interface IBedrockGuardrailContentPolicyConfigTierConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/bedrock_guardrail#tier_name BedrockGuardrail#tier_name}.</summary>
        [JsiiProperty(name: "tierName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? TierName
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IBedrockGuardrailContentPolicyConfigTierConfig), fullyQualifiedName: "aws.bedrockGuardrail.BedrockGuardrailContentPolicyConfigTierConfig")]
        internal sealed class _Proxy : DeputyBase, aws.BedrockGuardrail.IBedrockGuardrailContentPolicyConfigTierConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/bedrock_guardrail#tier_name BedrockGuardrail#tier_name}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "tierName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? TierName
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}

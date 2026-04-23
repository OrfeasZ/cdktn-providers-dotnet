using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.BedrockGuardrail
{
    [JsiiInterface(nativeType: typeof(IBedrockGuardrailCrossRegionConfig), fullyQualifiedName: "aws.bedrockGuardrail.BedrockGuardrailCrossRegionConfig")]
    public interface IBedrockGuardrailCrossRegionConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/bedrock_guardrail#guardrail_profile_identifier BedrockGuardrail#guardrail_profile_identifier}.</summary>
        [JsiiProperty(name: "guardrailProfileIdentifier", typeJson: "{\"primitive\":\"string\"}")]
        string GuardrailProfileIdentifier
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IBedrockGuardrailCrossRegionConfig), fullyQualifiedName: "aws.bedrockGuardrail.BedrockGuardrailCrossRegionConfig")]
        internal sealed class _Proxy : DeputyBase, aws.BedrockGuardrail.IBedrockGuardrailCrossRegionConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/bedrock_guardrail#guardrail_profile_identifier BedrockGuardrail#guardrail_profile_identifier}.</summary>
            [JsiiProperty(name: "guardrailProfileIdentifier", typeJson: "{\"primitive\":\"string\"}")]
            public string GuardrailProfileIdentifier
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}

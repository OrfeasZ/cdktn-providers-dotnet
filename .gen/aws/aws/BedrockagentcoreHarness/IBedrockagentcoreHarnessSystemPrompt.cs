using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.BedrockagentcoreHarness
{
    [JsiiInterface(nativeType: typeof(IBedrockagentcoreHarnessSystemPrompt), fullyQualifiedName: "aws.bedrockagentcoreHarness.BedrockagentcoreHarnessSystemPrompt")]
    public interface IBedrockagentcoreHarnessSystemPrompt
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.64.0/docs/resources/bedrockagentcore_harness#text BedrockagentcoreHarness#text}.</summary>
        [JsiiProperty(name: "text", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Text
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IBedrockagentcoreHarnessSystemPrompt), fullyQualifiedName: "aws.bedrockagentcoreHarness.BedrockagentcoreHarnessSystemPrompt")]
        internal sealed class _Proxy : DeputyBase, aws.BedrockagentcoreHarness.IBedrockagentcoreHarnessSystemPrompt
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.64.0/docs/resources/bedrockagentcore_harness#text BedrockagentcoreHarness#text}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "text", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Text
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}

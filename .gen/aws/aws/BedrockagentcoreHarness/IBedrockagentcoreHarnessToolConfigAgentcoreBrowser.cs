using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.BedrockagentcoreHarness
{
    [JsiiInterface(nativeType: typeof(IBedrockagentcoreHarnessToolConfigAgentcoreBrowser), fullyQualifiedName: "aws.bedrockagentcoreHarness.BedrockagentcoreHarnessToolConfigAgentcoreBrowser")]
    public interface IBedrockagentcoreHarnessToolConfigAgentcoreBrowser
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.46.0/docs/resources/bedrockagentcore_harness#browser_arn BedrockagentcoreHarness#browser_arn}.</summary>
        [JsiiProperty(name: "browserArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? BrowserArn
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IBedrockagentcoreHarnessToolConfigAgentcoreBrowser), fullyQualifiedName: "aws.bedrockagentcoreHarness.BedrockagentcoreHarnessToolConfigAgentcoreBrowser")]
        internal sealed class _Proxy : DeputyBase, aws.BedrockagentcoreHarness.IBedrockagentcoreHarnessToolConfigAgentcoreBrowser
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.46.0/docs/resources/bedrockagentcore_harness#browser_arn BedrockagentcoreHarness#browser_arn}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "browserArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? BrowserArn
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}

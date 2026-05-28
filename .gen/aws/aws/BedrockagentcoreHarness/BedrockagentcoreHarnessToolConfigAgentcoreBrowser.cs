using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.BedrockagentcoreHarness
{
    [JsiiByValue(fqn: "aws.bedrockagentcoreHarness.BedrockagentcoreHarnessToolConfigAgentcoreBrowser")]
    public class BedrockagentcoreHarnessToolConfigAgentcoreBrowser : aws.BedrockagentcoreHarness.IBedrockagentcoreHarnessToolConfigAgentcoreBrowser
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.47.0/docs/resources/bedrockagentcore_harness#browser_arn BedrockagentcoreHarness#browser_arn}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "browserArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? BrowserArn
        {
            get;
            set;
        }
    }
}

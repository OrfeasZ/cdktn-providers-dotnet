using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.BedrockagentcoreHarness
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.bedrockagentcoreHarness.BedrockagentcoreHarnessSystemPrompt")]
    public class BedrockagentcoreHarnessSystemPrompt : aws.BedrockagentcoreHarness.IBedrockagentcoreHarnessSystemPrompt
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.46.0/docs/resources/bedrockagentcore_harness#text BedrockagentcoreHarness#text}.</summary>
        [JsiiProperty(name: "text", typeJson: "{\"primitive\":\"string\"}")]
        public string Text
        {
            get;
            set;
        }
    }
}

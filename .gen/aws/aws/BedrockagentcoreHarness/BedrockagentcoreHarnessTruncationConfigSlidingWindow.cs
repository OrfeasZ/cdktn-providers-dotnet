using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.BedrockagentcoreHarness
{
    [JsiiByValue(fqn: "aws.bedrockagentcoreHarness.BedrockagentcoreHarnessTruncationConfigSlidingWindow")]
    public class BedrockagentcoreHarnessTruncationConfigSlidingWindow : aws.BedrockagentcoreHarness.IBedrockagentcoreHarnessTruncationConfigSlidingWindow
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.47.0/docs/resources/bedrockagentcore_harness#messages_count BedrockagentcoreHarness#messages_count}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "messagesCount", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? MessagesCount
        {
            get;
            set;
        }
    }
}

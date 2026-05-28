using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.BedrockagentcoreHarness
{
    [JsiiByValue(fqn: "aws.bedrockagentcoreHarness.BedrockagentcoreHarnessTruncationConfigSummarization")]
    public class BedrockagentcoreHarnessTruncationConfigSummarization : aws.BedrockagentcoreHarness.IBedrockagentcoreHarnessTruncationConfigSummarization
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.47.0/docs/resources/bedrockagentcore_harness#preserve_recent_messages BedrockagentcoreHarness#preserve_recent_messages}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "preserveRecentMessages", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? PreserveRecentMessages
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.47.0/docs/resources/bedrockagentcore_harness#summarization_system_prompt BedrockagentcoreHarness#summarization_system_prompt}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "summarizationSystemPrompt", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? SummarizationSystemPrompt
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.47.0/docs/resources/bedrockagentcore_harness#summary_ratio BedrockagentcoreHarness#summary_ratio}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "summaryRatio", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? SummaryRatio
        {
            get;
            set;
        }
    }
}

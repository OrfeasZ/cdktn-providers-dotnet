using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.BedrockagentcoreHarness
{
    [JsiiInterface(nativeType: typeof(IBedrockagentcoreHarnessTruncationConfigSummarization), fullyQualifiedName: "aws.bedrockagentcoreHarness.BedrockagentcoreHarnessTruncationConfigSummarization")]
    public interface IBedrockagentcoreHarnessTruncationConfigSummarization
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.46.0/docs/resources/bedrockagentcore_harness#preserve_recent_messages BedrockagentcoreHarness#preserve_recent_messages}.</summary>
        [JsiiProperty(name: "preserveRecentMessages", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? PreserveRecentMessages
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.46.0/docs/resources/bedrockagentcore_harness#summarization_system_prompt BedrockagentcoreHarness#summarization_system_prompt}.</summary>
        [JsiiProperty(name: "summarizationSystemPrompt", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? SummarizationSystemPrompt
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.46.0/docs/resources/bedrockagentcore_harness#summary_ratio BedrockagentcoreHarness#summary_ratio}.</summary>
        [JsiiProperty(name: "summaryRatio", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? SummaryRatio
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IBedrockagentcoreHarnessTruncationConfigSummarization), fullyQualifiedName: "aws.bedrockagentcoreHarness.BedrockagentcoreHarnessTruncationConfigSummarization")]
        internal sealed class _Proxy : DeputyBase, aws.BedrockagentcoreHarness.IBedrockagentcoreHarnessTruncationConfigSummarization
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.46.0/docs/resources/bedrockagentcore_harness#preserve_recent_messages BedrockagentcoreHarness#preserve_recent_messages}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "preserveRecentMessages", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? PreserveRecentMessages
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.46.0/docs/resources/bedrockagentcore_harness#summarization_system_prompt BedrockagentcoreHarness#summarization_system_prompt}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "summarizationSystemPrompt", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? SummarizationSystemPrompt
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.46.0/docs/resources/bedrockagentcore_harness#summary_ratio BedrockagentcoreHarness#summary_ratio}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "summaryRatio", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? SummaryRatio
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}

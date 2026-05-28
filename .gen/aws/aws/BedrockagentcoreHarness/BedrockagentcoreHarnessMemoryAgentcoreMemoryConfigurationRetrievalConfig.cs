using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.BedrockagentcoreHarness
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.bedrockagentcoreHarness.BedrockagentcoreHarnessMemoryAgentcoreMemoryConfigurationRetrievalConfig")]
    public class BedrockagentcoreHarnessMemoryAgentcoreMemoryConfigurationRetrievalConfig : aws.BedrockagentcoreHarness.IBedrockagentcoreHarnessMemoryAgentcoreMemoryConfigurationRetrievalConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.47.0/docs/resources/bedrockagentcore_harness#map_block_key BedrockagentcoreHarness#map_block_key}.</summary>
        [JsiiProperty(name: "mapBlockKey", typeJson: "{\"primitive\":\"string\"}")]
        public string MapBlockKey
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.47.0/docs/resources/bedrockagentcore_harness#relevance_score BedrockagentcoreHarness#relevance_score}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "relevanceScore", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? RelevanceScore
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.47.0/docs/resources/bedrockagentcore_harness#strategy_id BedrockagentcoreHarness#strategy_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "strategyId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? StrategyId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.47.0/docs/resources/bedrockagentcore_harness#top_k BedrockagentcoreHarness#top_k}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "topK", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? TopK
        {
            get;
            set;
        }
    }
}

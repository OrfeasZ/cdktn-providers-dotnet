using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.BedrockagentcoreHarness
{
    [JsiiInterface(nativeType: typeof(IBedrockagentcoreHarnessMemoryAgentcoreMemoryConfigurationRetrievalConfig), fullyQualifiedName: "aws.bedrockagentcoreHarness.BedrockagentcoreHarnessMemoryAgentcoreMemoryConfigurationRetrievalConfig")]
    public interface IBedrockagentcoreHarnessMemoryAgentcoreMemoryConfigurationRetrievalConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.46.0/docs/resources/bedrockagentcore_harness#map_block_key BedrockagentcoreHarness#map_block_key}.</summary>
        [JsiiProperty(name: "mapBlockKey", typeJson: "{\"primitive\":\"string\"}")]
        string MapBlockKey
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.46.0/docs/resources/bedrockagentcore_harness#relevance_score BedrockagentcoreHarness#relevance_score}.</summary>
        [JsiiProperty(name: "relevanceScore", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? RelevanceScore
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.46.0/docs/resources/bedrockagentcore_harness#strategy_id BedrockagentcoreHarness#strategy_id}.</summary>
        [JsiiProperty(name: "strategyId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? StrategyId
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.46.0/docs/resources/bedrockagentcore_harness#top_k BedrockagentcoreHarness#top_k}.</summary>
        [JsiiProperty(name: "topK", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? TopK
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IBedrockagentcoreHarnessMemoryAgentcoreMemoryConfigurationRetrievalConfig), fullyQualifiedName: "aws.bedrockagentcoreHarness.BedrockagentcoreHarnessMemoryAgentcoreMemoryConfigurationRetrievalConfig")]
        internal sealed class _Proxy : DeputyBase, aws.BedrockagentcoreHarness.IBedrockagentcoreHarnessMemoryAgentcoreMemoryConfigurationRetrievalConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.46.0/docs/resources/bedrockagentcore_harness#map_block_key BedrockagentcoreHarness#map_block_key}.</summary>
            [JsiiProperty(name: "mapBlockKey", typeJson: "{\"primitive\":\"string\"}")]
            public string MapBlockKey
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.46.0/docs/resources/bedrockagentcore_harness#relevance_score BedrockagentcoreHarness#relevance_score}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "relevanceScore", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? RelevanceScore
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.46.0/docs/resources/bedrockagentcore_harness#strategy_id BedrockagentcoreHarness#strategy_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "strategyId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? StrategyId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.46.0/docs/resources/bedrockagentcore_harness#top_k BedrockagentcoreHarness#top_k}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "topK", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? TopK
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}

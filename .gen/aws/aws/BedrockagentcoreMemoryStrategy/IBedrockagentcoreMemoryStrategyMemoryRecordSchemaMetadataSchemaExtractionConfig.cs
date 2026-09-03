using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.BedrockagentcoreMemoryStrategy
{
    [JsiiInterface(nativeType: typeof(IBedrockagentcoreMemoryStrategyMemoryRecordSchemaMetadataSchemaExtractionConfig), fullyQualifiedName: "aws.bedrockagentcoreMemoryStrategy.BedrockagentcoreMemoryStrategyMemoryRecordSchemaMetadataSchemaExtractionConfig")]
    public interface IBedrockagentcoreMemoryStrategyMemoryRecordSchemaMetadataSchemaExtractionConfig
    {
        /// <summary>llm_extraction_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/bedrockagentcore_memory_strategy#llm_extraction_config BedrockagentcoreMemoryStrategy#llm_extraction_config}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.BedrockagentcoreMemoryStrategy.IBedrockagentcoreMemoryStrategyMemoryRecordSchemaMetadataSchemaExtractionConfigLlmExtractionConfig" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "llmExtractionConfig", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.bedrockagentcoreMemoryStrategy.BedrockagentcoreMemoryStrategyMemoryRecordSchemaMetadataSchemaExtractionConfigLlmExtractionConfig\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? LlmExtractionConfig
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IBedrockagentcoreMemoryStrategyMemoryRecordSchemaMetadataSchemaExtractionConfig), fullyQualifiedName: "aws.bedrockagentcoreMemoryStrategy.BedrockagentcoreMemoryStrategyMemoryRecordSchemaMetadataSchemaExtractionConfig")]
        internal sealed class _Proxy : DeputyBase, aws.BedrockagentcoreMemoryStrategy.IBedrockagentcoreMemoryStrategyMemoryRecordSchemaMetadataSchemaExtractionConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>llm_extraction_config block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/bedrockagentcore_memory_strategy#llm_extraction_config BedrockagentcoreMemoryStrategy#llm_extraction_config}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.BedrockagentcoreMemoryStrategy.IBedrockagentcoreMemoryStrategyMemoryRecordSchemaMetadataSchemaExtractionConfigLlmExtractionConfig" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "llmExtractionConfig", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.bedrockagentcoreMemoryStrategy.BedrockagentcoreMemoryStrategyMemoryRecordSchemaMetadataSchemaExtractionConfigLlmExtractionConfig\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? LlmExtractionConfig
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}

using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.BedrockagentcoreMemoryStrategy
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.bedrockagentcoreMemoryStrategy.BedrockagentcoreMemoryStrategyMemoryRecordSchemaMetadataSchemaExtractionConfigLlmExtractionConfig")]
    public class BedrockagentcoreMemoryStrategyMemoryRecordSchemaMetadataSchemaExtractionConfigLlmExtractionConfig : aws.BedrockagentcoreMemoryStrategy.IBedrockagentcoreMemoryStrategyMemoryRecordSchemaMetadataSchemaExtractionConfigLlmExtractionConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/bedrockagentcore_memory_strategy#definition BedrockagentcoreMemoryStrategy#definition}.</summary>
        [JsiiProperty(name: "definition", typeJson: "{\"primitive\":\"string\"}")]
        public string Definition
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/bedrockagentcore_memory_strategy#llm_extraction_instruction BedrockagentcoreMemoryStrategy#llm_extraction_instruction}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "llmExtractionInstruction", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? LlmExtractionInstruction
        {
            get;
            set;
        }

        private object? _validation;

        /// <summary>validation block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/bedrockagentcore_memory_strategy#validation BedrockagentcoreMemoryStrategy#validation}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.BedrockagentcoreMemoryStrategy.IBedrockagentcoreMemoryStrategyMemoryRecordSchemaMetadataSchemaExtractionConfigLlmExtractionConfigValidation" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "validation", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.bedrockagentcoreMemoryStrategy.BedrockagentcoreMemoryStrategyMemoryRecordSchemaMetadataSchemaExtractionConfigLlmExtractionConfigValidation\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? Validation
        {
            get => _validation;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.BedrockagentcoreMemoryStrategy.IBedrockagentcoreMemoryStrategyMemoryRecordSchemaMetadataSchemaExtractionConfigLlmExtractionConfigValidation[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.BedrockagentcoreMemoryStrategy.IBedrockagentcoreMemoryStrategyMemoryRecordSchemaMetadataSchemaExtractionConfigLlmExtractionConfigValidation).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _validation = value;
            }
        }
    }
}

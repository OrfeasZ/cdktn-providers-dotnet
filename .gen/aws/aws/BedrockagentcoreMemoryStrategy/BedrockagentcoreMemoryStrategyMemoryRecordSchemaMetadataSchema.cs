using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.BedrockagentcoreMemoryStrategy
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.bedrockagentcoreMemoryStrategy.BedrockagentcoreMemoryStrategyMemoryRecordSchemaMetadataSchema")]
    public class BedrockagentcoreMemoryStrategyMemoryRecordSchemaMetadataSchema : aws.BedrockagentcoreMemoryStrategy.IBedrockagentcoreMemoryStrategyMemoryRecordSchemaMetadataSchema
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/bedrockagentcore_memory_strategy#key BedrockagentcoreMemoryStrategy#key}.</summary>
        [JsiiProperty(name: "key", typeJson: "{\"primitive\":\"string\"}")]
        public string Key
        {
            get;
            set;
        }

        private object? _extractionConfig;

        /// <summary>extraction_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/bedrockagentcore_memory_strategy#extraction_config BedrockagentcoreMemoryStrategy#extraction_config}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.BedrockagentcoreMemoryStrategy.IBedrockagentcoreMemoryStrategyMemoryRecordSchemaMetadataSchemaExtractionConfig" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "extractionConfig", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.bedrockagentcoreMemoryStrategy.BedrockagentcoreMemoryStrategyMemoryRecordSchemaMetadataSchemaExtractionConfig\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? ExtractionConfig
        {
            get => _extractionConfig;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.BedrockagentcoreMemoryStrategy.IBedrockagentcoreMemoryStrategyMemoryRecordSchemaMetadataSchemaExtractionConfig[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.BedrockagentcoreMemoryStrategy.IBedrockagentcoreMemoryStrategyMemoryRecordSchemaMetadataSchemaExtractionConfig).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _extractionConfig = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/bedrockagentcore_memory_strategy#extraction_type BedrockagentcoreMemoryStrategy#extraction_type}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "extractionType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ExtractionType
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/bedrockagentcore_memory_strategy#type BedrockagentcoreMemoryStrategy#type}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Type
        {
            get;
            set;
        }
    }
}

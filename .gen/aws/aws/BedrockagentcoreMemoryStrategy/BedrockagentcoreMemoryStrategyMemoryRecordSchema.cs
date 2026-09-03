using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.BedrockagentcoreMemoryStrategy
{
    [JsiiByValue(fqn: "aws.bedrockagentcoreMemoryStrategy.BedrockagentcoreMemoryStrategyMemoryRecordSchema")]
    public class BedrockagentcoreMemoryStrategyMemoryRecordSchema : aws.BedrockagentcoreMemoryStrategy.IBedrockagentcoreMemoryStrategyMemoryRecordSchema
    {
        private object? _metadataSchema;

        /// <summary>metadata_schema block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/bedrockagentcore_memory_strategy#metadata_schema BedrockagentcoreMemoryStrategy#metadata_schema}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.BedrockagentcoreMemoryStrategy.IBedrockagentcoreMemoryStrategyMemoryRecordSchemaMetadataSchema" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "metadataSchema", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.bedrockagentcoreMemoryStrategy.BedrockagentcoreMemoryStrategyMemoryRecordSchemaMetadataSchema\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? MetadataSchema
        {
            get => _metadataSchema;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.BedrockagentcoreMemoryStrategy.IBedrockagentcoreMemoryStrategyMemoryRecordSchemaMetadataSchema[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.BedrockagentcoreMemoryStrategy.IBedrockagentcoreMemoryStrategyMemoryRecordSchemaMetadataSchema).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _metadataSchema = value;
            }
        }
    }
}

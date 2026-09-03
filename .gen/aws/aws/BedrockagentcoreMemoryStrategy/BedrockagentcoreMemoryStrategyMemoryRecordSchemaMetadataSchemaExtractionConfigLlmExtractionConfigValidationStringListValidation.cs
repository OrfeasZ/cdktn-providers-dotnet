using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.BedrockagentcoreMemoryStrategy
{
    [JsiiByValue(fqn: "aws.bedrockagentcoreMemoryStrategy.BedrockagentcoreMemoryStrategyMemoryRecordSchemaMetadataSchemaExtractionConfigLlmExtractionConfigValidationStringListValidation")]
    public class BedrockagentcoreMemoryStrategyMemoryRecordSchemaMetadataSchemaExtractionConfigLlmExtractionConfigValidationStringListValidation : aws.BedrockagentcoreMemoryStrategy.IBedrockagentcoreMemoryStrategyMemoryRecordSchemaMetadataSchemaExtractionConfigLlmExtractionConfigValidationStringListValidation
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/bedrockagentcore_memory_strategy#allowed_values BedrockagentcoreMemoryStrategy#allowed_values}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "allowedValues", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? AllowedValues
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/bedrockagentcore_memory_strategy#max_items BedrockagentcoreMemoryStrategy#max_items}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "maxItems", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? MaxItems
        {
            get;
            set;
        }
    }
}

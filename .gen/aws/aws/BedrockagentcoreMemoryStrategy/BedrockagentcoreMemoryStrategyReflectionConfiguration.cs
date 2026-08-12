using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.BedrockagentcoreMemoryStrategy
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.bedrockagentcoreMemoryStrategy.BedrockagentcoreMemoryStrategyReflectionConfiguration")]
    public class BedrockagentcoreMemoryStrategyReflectionConfiguration : aws.BedrockagentcoreMemoryStrategy.IBedrockagentcoreMemoryStrategyReflectionConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.59.0/docs/resources/bedrockagentcore_memory_strategy#namespace_templates BedrockagentcoreMemoryStrategy#namespace_templates}.</summary>
        [JsiiProperty(name: "namespaceTemplates", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public string[] NamespaceTemplates
        {
            get;
            set;
        }
    }
}

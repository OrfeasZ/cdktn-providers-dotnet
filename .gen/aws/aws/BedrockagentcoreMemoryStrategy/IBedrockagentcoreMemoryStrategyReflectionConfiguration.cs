using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.BedrockagentcoreMemoryStrategy
{
    [JsiiInterface(nativeType: typeof(IBedrockagentcoreMemoryStrategyReflectionConfiguration), fullyQualifiedName: "aws.bedrockagentcoreMemoryStrategy.BedrockagentcoreMemoryStrategyReflectionConfiguration")]
    public interface IBedrockagentcoreMemoryStrategyReflectionConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/bedrockagentcore_memory_strategy#namespace_templates BedrockagentcoreMemoryStrategy#namespace_templates}.</summary>
        [JsiiProperty(name: "namespaceTemplates", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        string[] NamespaceTemplates
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IBedrockagentcoreMemoryStrategyReflectionConfiguration), fullyQualifiedName: "aws.bedrockagentcoreMemoryStrategy.BedrockagentcoreMemoryStrategyReflectionConfiguration")]
        internal sealed class _Proxy : DeputyBase, aws.BedrockagentcoreMemoryStrategy.IBedrockagentcoreMemoryStrategyReflectionConfiguration
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/bedrockagentcore_memory_strategy#namespace_templates BedrockagentcoreMemoryStrategy#namespace_templates}.</summary>
            [JsiiProperty(name: "namespaceTemplates", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
            public string[] NamespaceTemplates
            {
                get => GetInstanceProperty<string[]>()!;
            }
        }
    }
}

using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.BedrockagentcoreHarness
{
    [JsiiInterface(nativeType: typeof(IBedrockagentcoreHarnessMemory), fullyQualifiedName: "aws.bedrockagentcoreHarness.BedrockagentcoreHarnessMemory")]
    public interface IBedrockagentcoreHarnessMemory
    {
        /// <summary>agentcore_memory_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.46.0/docs/resources/bedrockagentcore_harness#agentcore_memory_configuration BedrockagentcoreHarness#agentcore_memory_configuration}
        /// </remarks>
        [JsiiProperty(name: "agentcoreMemoryConfiguration", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.bedrockagentcoreHarness.BedrockagentcoreHarnessMemoryAgentcoreMemoryConfiguration\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? AgentcoreMemoryConfiguration
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IBedrockagentcoreHarnessMemory), fullyQualifiedName: "aws.bedrockagentcoreHarness.BedrockagentcoreHarnessMemory")]
        internal sealed class _Proxy : DeputyBase, aws.BedrockagentcoreHarness.IBedrockagentcoreHarnessMemory
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>agentcore_memory_configuration block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.46.0/docs/resources/bedrockagentcore_harness#agentcore_memory_configuration BedrockagentcoreHarness#agentcore_memory_configuration}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "agentcoreMemoryConfiguration", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.bedrockagentcoreHarness.BedrockagentcoreHarnessMemoryAgentcoreMemoryConfiguration\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? AgentcoreMemoryConfiguration
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}

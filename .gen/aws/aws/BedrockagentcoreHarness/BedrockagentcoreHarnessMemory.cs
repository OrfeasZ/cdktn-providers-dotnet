using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.BedrockagentcoreHarness
{
    [JsiiByValue(fqn: "aws.bedrockagentcoreHarness.BedrockagentcoreHarnessMemory")]
    public class BedrockagentcoreHarnessMemory : aws.BedrockagentcoreHarness.IBedrockagentcoreHarnessMemory
    {
        private object? _agentcoreMemoryConfiguration;

        /// <summary>agentcore_memory_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.46.0/docs/resources/bedrockagentcore_harness#agentcore_memory_configuration BedrockagentcoreHarness#agentcore_memory_configuration}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "agentcoreMemoryConfiguration", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.bedrockagentcoreHarness.BedrockagentcoreHarnessMemoryAgentcoreMemoryConfiguration\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? AgentcoreMemoryConfiguration
        {
            get => _agentcoreMemoryConfiguration;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.BedrockagentcoreHarness.IBedrockagentcoreHarnessMemoryAgentcoreMemoryConfiguration[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.BedrockagentcoreHarness.IBedrockagentcoreHarnessMemoryAgentcoreMemoryConfiguration).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _agentcoreMemoryConfiguration = value;
            }
        }
    }
}

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
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.59.0/docs/resources/bedrockagentcore_harness#agentcore_memory_configuration BedrockagentcoreHarness#agentcore_memory_configuration}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.BedrockagentcoreHarness.IBedrockagentcoreHarnessMemoryAgentcoreMemoryConfiguration" />)[]</para>
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

        private object? _disabled;

        /// <summary>disabled block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.59.0/docs/resources/bedrockagentcore_harness#disabled BedrockagentcoreHarness#disabled}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.BedrockagentcoreHarness.IBedrockagentcoreHarnessMemoryDisabled" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "disabled", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.bedrockagentcoreHarness.BedrockagentcoreHarnessMemoryDisabled\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? Disabled
        {
            get => _disabled;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.BedrockagentcoreHarness.IBedrockagentcoreHarnessMemoryDisabled[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.BedrockagentcoreHarness.IBedrockagentcoreHarnessMemoryDisabled).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _disabled = value;
            }
        }

        private object? _managedMemoryConfiguration;

        /// <summary>managed_memory_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.59.0/docs/resources/bedrockagentcore_harness#managed_memory_configuration BedrockagentcoreHarness#managed_memory_configuration}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.BedrockagentcoreHarness.IBedrockagentcoreHarnessMemoryManagedMemoryConfiguration" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "managedMemoryConfiguration", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.bedrockagentcoreHarness.BedrockagentcoreHarnessMemoryManagedMemoryConfiguration\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? ManagedMemoryConfiguration
        {
            get => _managedMemoryConfiguration;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.BedrockagentcoreHarness.IBedrockagentcoreHarnessMemoryManagedMemoryConfiguration[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.BedrockagentcoreHarness.IBedrockagentcoreHarnessMemoryManagedMemoryConfiguration).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _managedMemoryConfiguration = value;
            }
        }
    }
}

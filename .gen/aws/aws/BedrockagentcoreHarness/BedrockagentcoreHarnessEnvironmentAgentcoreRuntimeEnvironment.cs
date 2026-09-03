using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.BedrockagentcoreHarness
{
    [JsiiByValue(fqn: "aws.bedrockagentcoreHarness.BedrockagentcoreHarnessEnvironmentAgentcoreRuntimeEnvironment")]
    public class BedrockagentcoreHarnessEnvironmentAgentcoreRuntimeEnvironment : aws.BedrockagentcoreHarness.IBedrockagentcoreHarnessEnvironmentAgentcoreRuntimeEnvironment
    {
        private object? _filesystemConfiguration;

        /// <summary>filesystem_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/bedrockagentcore_harness#filesystem_configuration BedrockagentcoreHarness#filesystem_configuration}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.BedrockagentcoreHarness.IBedrockagentcoreHarnessEnvironmentAgentcoreRuntimeEnvironmentFilesystemConfiguration" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "filesystemConfiguration", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.bedrockagentcoreHarness.BedrockagentcoreHarnessEnvironmentAgentcoreRuntimeEnvironmentFilesystemConfiguration\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? FilesystemConfiguration
        {
            get => _filesystemConfiguration;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.BedrockagentcoreHarness.IBedrockagentcoreHarnessEnvironmentAgentcoreRuntimeEnvironmentFilesystemConfiguration[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.BedrockagentcoreHarness.IBedrockagentcoreHarnessEnvironmentAgentcoreRuntimeEnvironmentFilesystemConfiguration).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _filesystemConfiguration = value;
            }
        }

        private object? _lifecycleConfiguration;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/bedrockagentcore_harness#lifecycle_configuration BedrockagentcoreHarness#lifecycle_configuration}.</summary>
        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.BedrockagentcoreHarness.IBedrockagentcoreHarnessEnvironmentAgentcoreRuntimeEnvironmentLifecycleConfiguration" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "lifecycleConfiguration", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.bedrockagentcoreHarness.BedrockagentcoreHarnessEnvironmentAgentcoreRuntimeEnvironmentLifecycleConfiguration\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? LifecycleConfiguration
        {
            get => _lifecycleConfiguration;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.BedrockagentcoreHarness.IBedrockagentcoreHarnessEnvironmentAgentcoreRuntimeEnvironmentLifecycleConfiguration[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.BedrockagentcoreHarness.IBedrockagentcoreHarnessEnvironmentAgentcoreRuntimeEnvironmentLifecycleConfiguration).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _lifecycleConfiguration = value;
            }
        }

        private object? _networkConfiguration;

        /// <summary>network_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/bedrockagentcore_harness#network_configuration BedrockagentcoreHarness#network_configuration}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.BedrockagentcoreHarness.IBedrockagentcoreHarnessEnvironmentAgentcoreRuntimeEnvironmentNetworkConfiguration" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "networkConfiguration", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.bedrockagentcoreHarness.BedrockagentcoreHarnessEnvironmentAgentcoreRuntimeEnvironmentNetworkConfiguration\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? NetworkConfiguration
        {
            get => _networkConfiguration;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.BedrockagentcoreHarness.IBedrockagentcoreHarnessEnvironmentAgentcoreRuntimeEnvironmentNetworkConfiguration[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.BedrockagentcoreHarness.IBedrockagentcoreHarnessEnvironmentAgentcoreRuntimeEnvironmentNetworkConfiguration).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _networkConfiguration = value;
            }
        }
    }
}

using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.BedrockagentcoreHarness
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.bedrockagentcoreHarness.BedrockagentcoreHarnessEnvironmentAgentcoreRuntimeEnvironmentNetworkConfiguration")]
    public class BedrockagentcoreHarnessEnvironmentAgentcoreRuntimeEnvironmentNetworkConfiguration : aws.BedrockagentcoreHarness.IBedrockagentcoreHarnessEnvironmentAgentcoreRuntimeEnvironmentNetworkConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/bedrockagentcore_harness#network_mode BedrockagentcoreHarness#network_mode}.</summary>
        [JsiiProperty(name: "networkMode", typeJson: "{\"primitive\":\"string\"}")]
        public string NetworkMode
        {
            get;
            set;
        }

        private object? _networkModeConfig;

        /// <summary>network_mode_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/bedrockagentcore_harness#network_mode_config BedrockagentcoreHarness#network_mode_config}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.BedrockagentcoreHarness.IBedrockagentcoreHarnessEnvironmentAgentcoreRuntimeEnvironmentNetworkConfigurationNetworkModeConfig" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "networkModeConfig", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.bedrockagentcoreHarness.BedrockagentcoreHarnessEnvironmentAgentcoreRuntimeEnvironmentNetworkConfigurationNetworkModeConfig\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? NetworkModeConfig
        {
            get => _networkModeConfig;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.BedrockagentcoreHarness.IBedrockagentcoreHarnessEnvironmentAgentcoreRuntimeEnvironmentNetworkConfigurationNetworkModeConfig[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.BedrockagentcoreHarness.IBedrockagentcoreHarnessEnvironmentAgentcoreRuntimeEnvironmentNetworkConfigurationNetworkModeConfig).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _networkModeConfig = value;
            }
        }
    }
}

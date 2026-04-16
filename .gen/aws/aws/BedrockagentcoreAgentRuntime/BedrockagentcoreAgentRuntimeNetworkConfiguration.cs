using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.BedrockagentcoreAgentRuntime
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.bedrockagentcoreAgentRuntime.BedrockagentcoreAgentRuntimeNetworkConfiguration")]
    public class BedrockagentcoreAgentRuntimeNetworkConfiguration : aws.BedrockagentcoreAgentRuntime.IBedrockagentcoreAgentRuntimeNetworkConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/bedrockagentcore_agent_runtime#network_mode BedrockagentcoreAgentRuntime#network_mode}.</summary>
        [JsiiProperty(name: "networkMode", typeJson: "{\"primitive\":\"string\"}")]
        public string NetworkMode
        {
            get;
            set;
        }

        private object? _networkModeConfig;

        /// <summary>network_mode_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/bedrockagentcore_agent_runtime#network_mode_config BedrockagentcoreAgentRuntime#network_mode_config}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "networkModeConfig", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.bedrockagentcoreAgentRuntime.BedrockagentcoreAgentRuntimeNetworkConfigurationNetworkModeConfig\"},\"kind\":\"array\"}}]}}", isOptional: true)]
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
                        case aws.BedrockagentcoreAgentRuntime.IBedrockagentcoreAgentRuntimeNetworkConfigurationNetworkModeConfig[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.BedrockagentcoreAgentRuntime.IBedrockagentcoreAgentRuntimeNetworkConfigurationNetworkModeConfig).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _networkModeConfig = value;
            }
        }
    }
}

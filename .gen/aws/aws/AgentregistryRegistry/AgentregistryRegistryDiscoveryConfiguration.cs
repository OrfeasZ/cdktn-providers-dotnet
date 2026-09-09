using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.AgentregistryRegistry
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.agentregistryRegistry.AgentregistryRegistryDiscoveryConfiguration")]
    public class AgentregistryRegistryDiscoveryConfiguration : aws.AgentregistryRegistry.IAgentregistryRegistryDiscoveryConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.64.0/docs/resources/agentregistry_registry#authorizer_type AgentregistryRegistry#authorizer_type}.</summary>
        [JsiiProperty(name: "authorizerType", typeJson: "{\"primitive\":\"string\"}")]
        public string AuthorizerType
        {
            get;
            set;
        }

        private object? _authorizerConfiguration;

        /// <summary>authorizer_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.64.0/docs/resources/agentregistry_registry#authorizer_configuration AgentregistryRegistry#authorizer_configuration}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.AgentregistryRegistry.IAgentregistryRegistryDiscoveryConfigurationAuthorizerConfiguration" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "authorizerConfiguration", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.agentregistryRegistry.AgentregistryRegistryDiscoveryConfigurationAuthorizerConfiguration\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? AuthorizerConfiguration
        {
            get => _authorizerConfiguration;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.AgentregistryRegistry.IAgentregistryRegistryDiscoveryConfigurationAuthorizerConfiguration[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.AgentregistryRegistry.IAgentregistryRegistryDiscoveryConfigurationAuthorizerConfiguration).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _authorizerConfiguration = value;
            }
        }
    }
}

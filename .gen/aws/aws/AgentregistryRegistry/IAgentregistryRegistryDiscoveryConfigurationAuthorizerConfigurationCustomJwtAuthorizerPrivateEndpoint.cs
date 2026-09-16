using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.AgentregistryRegistry
{
    [JsiiInterface(nativeType: typeof(IAgentregistryRegistryDiscoveryConfigurationAuthorizerConfigurationCustomJwtAuthorizerPrivateEndpoint), fullyQualifiedName: "aws.agentregistryRegistry.AgentregistryRegistryDiscoveryConfigurationAuthorizerConfigurationCustomJwtAuthorizerPrivateEndpoint")]
    public interface IAgentregistryRegistryDiscoveryConfigurationAuthorizerConfigurationCustomJwtAuthorizerPrivateEndpoint
    {
        /// <summary>managed_vpc_resource block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.65.0/docs/resources/agentregistry_registry#managed_vpc_resource AgentregistryRegistry#managed_vpc_resource}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.AgentregistryRegistry.IAgentregistryRegistryDiscoveryConfigurationAuthorizerConfigurationCustomJwtAuthorizerPrivateEndpointManagedVpcResource" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "managedVpcResource", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.agentregistryRegistry.AgentregistryRegistryDiscoveryConfigurationAuthorizerConfigurationCustomJwtAuthorizerPrivateEndpointManagedVpcResource\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? ManagedVpcResource
        {
            get
            {
                return null;
            }
        }

        /// <summary>self_managed_lattice_resource block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.65.0/docs/resources/agentregistry_registry#self_managed_lattice_resource AgentregistryRegistry#self_managed_lattice_resource}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.AgentregistryRegistry.IAgentregistryRegistryDiscoveryConfigurationAuthorizerConfigurationCustomJwtAuthorizerPrivateEndpointSelfManagedLatticeResource" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "selfManagedLatticeResource", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.agentregistryRegistry.AgentregistryRegistryDiscoveryConfigurationAuthorizerConfigurationCustomJwtAuthorizerPrivateEndpointSelfManagedLatticeResource\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? SelfManagedLatticeResource
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IAgentregistryRegistryDiscoveryConfigurationAuthorizerConfigurationCustomJwtAuthorizerPrivateEndpoint), fullyQualifiedName: "aws.agentregistryRegistry.AgentregistryRegistryDiscoveryConfigurationAuthorizerConfigurationCustomJwtAuthorizerPrivateEndpoint")]
        internal sealed class _Proxy : DeputyBase, aws.AgentregistryRegistry.IAgentregistryRegistryDiscoveryConfigurationAuthorizerConfigurationCustomJwtAuthorizerPrivateEndpoint
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>managed_vpc_resource block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.65.0/docs/resources/agentregistry_registry#managed_vpc_resource AgentregistryRegistry#managed_vpc_resource}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.AgentregistryRegistry.IAgentregistryRegistryDiscoveryConfigurationAuthorizerConfigurationCustomJwtAuthorizerPrivateEndpointManagedVpcResource" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "managedVpcResource", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.agentregistryRegistry.AgentregistryRegistryDiscoveryConfigurationAuthorizerConfigurationCustomJwtAuthorizerPrivateEndpointManagedVpcResource\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? ManagedVpcResource
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>self_managed_lattice_resource block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.65.0/docs/resources/agentregistry_registry#self_managed_lattice_resource AgentregistryRegistry#self_managed_lattice_resource}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.AgentregistryRegistry.IAgentregistryRegistryDiscoveryConfigurationAuthorizerConfigurationCustomJwtAuthorizerPrivateEndpointSelfManagedLatticeResource" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "selfManagedLatticeResource", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.agentregistryRegistry.AgentregistryRegistryDiscoveryConfigurationAuthorizerConfigurationCustomJwtAuthorizerPrivateEndpointSelfManagedLatticeResource\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? SelfManagedLatticeResource
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}

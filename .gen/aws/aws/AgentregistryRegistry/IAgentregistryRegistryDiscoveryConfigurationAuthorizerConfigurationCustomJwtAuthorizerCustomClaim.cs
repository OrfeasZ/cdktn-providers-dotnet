using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.AgentregistryRegistry
{
    [JsiiInterface(nativeType: typeof(IAgentregistryRegistryDiscoveryConfigurationAuthorizerConfigurationCustomJwtAuthorizerCustomClaim), fullyQualifiedName: "aws.agentregistryRegistry.AgentregistryRegistryDiscoveryConfigurationAuthorizerConfigurationCustomJwtAuthorizerCustomClaim")]
    public interface IAgentregistryRegistryDiscoveryConfigurationAuthorizerConfigurationCustomJwtAuthorizerCustomClaim
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.64.0/docs/resources/agentregistry_registry#inbound_token_claim_name AgentregistryRegistry#inbound_token_claim_name}.</summary>
        [JsiiProperty(name: "inboundTokenClaimName", typeJson: "{\"primitive\":\"string\"}")]
        string InboundTokenClaimName
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.64.0/docs/resources/agentregistry_registry#inbound_token_claim_value_type AgentregistryRegistry#inbound_token_claim_value_type}.</summary>
        [JsiiProperty(name: "inboundTokenClaimValueType", typeJson: "{\"primitive\":\"string\"}")]
        string InboundTokenClaimValueType
        {
            get;
        }

        /// <summary>authorizing_claim_match_value block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.64.0/docs/resources/agentregistry_registry#authorizing_claim_match_value AgentregistryRegistry#authorizing_claim_match_value}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.AgentregistryRegistry.IAgentregistryRegistryDiscoveryConfigurationAuthorizerConfigurationCustomJwtAuthorizerCustomClaimAuthorizingClaimMatchValue" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "authorizingClaimMatchValue", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.agentregistryRegistry.AgentregistryRegistryDiscoveryConfigurationAuthorizerConfigurationCustomJwtAuthorizerCustomClaimAuthorizingClaimMatchValue\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? AuthorizingClaimMatchValue
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IAgentregistryRegistryDiscoveryConfigurationAuthorizerConfigurationCustomJwtAuthorizerCustomClaim), fullyQualifiedName: "aws.agentregistryRegistry.AgentregistryRegistryDiscoveryConfigurationAuthorizerConfigurationCustomJwtAuthorizerCustomClaim")]
        internal sealed class _Proxy : DeputyBase, aws.AgentregistryRegistry.IAgentregistryRegistryDiscoveryConfigurationAuthorizerConfigurationCustomJwtAuthorizerCustomClaim
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.64.0/docs/resources/agentregistry_registry#inbound_token_claim_name AgentregistryRegistry#inbound_token_claim_name}.</summary>
            [JsiiProperty(name: "inboundTokenClaimName", typeJson: "{\"primitive\":\"string\"}")]
            public string InboundTokenClaimName
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.64.0/docs/resources/agentregistry_registry#inbound_token_claim_value_type AgentregistryRegistry#inbound_token_claim_value_type}.</summary>
            [JsiiProperty(name: "inboundTokenClaimValueType", typeJson: "{\"primitive\":\"string\"}")]
            public string InboundTokenClaimValueType
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>authorizing_claim_match_value block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.64.0/docs/resources/agentregistry_registry#authorizing_claim_match_value AgentregistryRegistry#authorizing_claim_match_value}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.AgentregistryRegistry.IAgentregistryRegistryDiscoveryConfigurationAuthorizerConfigurationCustomJwtAuthorizerCustomClaimAuthorizingClaimMatchValue" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "authorizingClaimMatchValue", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.agentregistryRegistry.AgentregistryRegistryDiscoveryConfigurationAuthorizerConfigurationCustomJwtAuthorizerCustomClaimAuthorizingClaimMatchValue\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? AuthorizingClaimMatchValue
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}

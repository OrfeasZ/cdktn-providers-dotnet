using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.BedrockagentcoreRegistry
{
    [JsiiInterface(nativeType: typeof(IBedrockagentcoreRegistryAuthorizerConfigurationCustomJwtAuthorizerCustomClaimAuthorizingClaimMatchValue), fullyQualifiedName: "aws.bedrockagentcoreRegistry.BedrockagentcoreRegistryAuthorizerConfigurationCustomJwtAuthorizerCustomClaimAuthorizingClaimMatchValue")]
    public interface IBedrockagentcoreRegistryAuthorizerConfigurationCustomJwtAuthorizerCustomClaimAuthorizingClaimMatchValue
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/bedrockagentcore_registry#claim_match_operator BedrockagentcoreRegistry#claim_match_operator}.</summary>
        [JsiiProperty(name: "claimMatchOperator", typeJson: "{\"primitive\":\"string\"}")]
        string ClaimMatchOperator
        {
            get;
        }

        /// <summary>claim_match_value block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/bedrockagentcore_registry#claim_match_value BedrockagentcoreRegistry#claim_match_value}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.BedrockagentcoreRegistry.IBedrockagentcoreRegistryAuthorizerConfigurationCustomJwtAuthorizerCustomClaimAuthorizingClaimMatchValueClaimMatchValue" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "claimMatchValue", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.bedrockagentcoreRegistry.BedrockagentcoreRegistryAuthorizerConfigurationCustomJwtAuthorizerCustomClaimAuthorizingClaimMatchValueClaimMatchValue\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? ClaimMatchValue
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IBedrockagentcoreRegistryAuthorizerConfigurationCustomJwtAuthorizerCustomClaimAuthorizingClaimMatchValue), fullyQualifiedName: "aws.bedrockagentcoreRegistry.BedrockagentcoreRegistryAuthorizerConfigurationCustomJwtAuthorizerCustomClaimAuthorizingClaimMatchValue")]
        internal sealed class _Proxy : DeputyBase, aws.BedrockagentcoreRegistry.IBedrockagentcoreRegistryAuthorizerConfigurationCustomJwtAuthorizerCustomClaimAuthorizingClaimMatchValue
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/bedrockagentcore_registry#claim_match_operator BedrockagentcoreRegistry#claim_match_operator}.</summary>
            [JsiiProperty(name: "claimMatchOperator", typeJson: "{\"primitive\":\"string\"}")]
            public string ClaimMatchOperator
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>claim_match_value block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/bedrockagentcore_registry#claim_match_value BedrockagentcoreRegistry#claim_match_value}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.BedrockagentcoreRegistry.IBedrockagentcoreRegistryAuthorizerConfigurationCustomJwtAuthorizerCustomClaimAuthorizingClaimMatchValueClaimMatchValue" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "claimMatchValue", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.bedrockagentcoreRegistry.BedrockagentcoreRegistryAuthorizerConfigurationCustomJwtAuthorizerCustomClaimAuthorizingClaimMatchValueClaimMatchValue\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? ClaimMatchValue
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}

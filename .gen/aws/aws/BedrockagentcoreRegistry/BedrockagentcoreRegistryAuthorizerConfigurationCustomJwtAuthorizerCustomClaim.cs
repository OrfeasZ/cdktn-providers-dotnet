using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.BedrockagentcoreRegistry
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.bedrockagentcoreRegistry.BedrockagentcoreRegistryAuthorizerConfigurationCustomJwtAuthorizerCustomClaim")]
    public class BedrockagentcoreRegistryAuthorizerConfigurationCustomJwtAuthorizerCustomClaim : aws.BedrockagentcoreRegistry.IBedrockagentcoreRegistryAuthorizerConfigurationCustomJwtAuthorizerCustomClaim
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/bedrockagentcore_registry#inbound_token_claim_name BedrockagentcoreRegistry#inbound_token_claim_name}.</summary>
        [JsiiProperty(name: "inboundTokenClaimName", typeJson: "{\"primitive\":\"string\"}")]
        public string InboundTokenClaimName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/bedrockagentcore_registry#inbound_token_claim_value_type BedrockagentcoreRegistry#inbound_token_claim_value_type}.</summary>
        [JsiiProperty(name: "inboundTokenClaimValueType", typeJson: "{\"primitive\":\"string\"}")]
        public string InboundTokenClaimValueType
        {
            get;
            set;
        }

        private object? _authorizingClaimMatchValue;

        /// <summary>authorizing_claim_match_value block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/bedrockagentcore_registry#authorizing_claim_match_value BedrockagentcoreRegistry#authorizing_claim_match_value}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.BedrockagentcoreRegistry.IBedrockagentcoreRegistryAuthorizerConfigurationCustomJwtAuthorizerCustomClaimAuthorizingClaimMatchValue" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "authorizingClaimMatchValue", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.bedrockagentcoreRegistry.BedrockagentcoreRegistryAuthorizerConfigurationCustomJwtAuthorizerCustomClaimAuthorizingClaimMatchValue\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? AuthorizingClaimMatchValue
        {
            get => _authorizingClaimMatchValue;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.BedrockagentcoreRegistry.IBedrockagentcoreRegistryAuthorizerConfigurationCustomJwtAuthorizerCustomClaimAuthorizingClaimMatchValue[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.BedrockagentcoreRegistry.IBedrockagentcoreRegistryAuthorizerConfigurationCustomJwtAuthorizerCustomClaimAuthorizingClaimMatchValue).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _authorizingClaimMatchValue = value;
            }
        }
    }
}

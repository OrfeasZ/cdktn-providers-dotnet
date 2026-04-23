using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.BedrockagentcoreGateway
{
    [JsiiInterface(nativeType: typeof(IBedrockagentcoreGatewayAuthorizerConfigurationCustomJwtAuthorizerCustomClaim), fullyQualifiedName: "aws.bedrockagentcoreGateway.BedrockagentcoreGatewayAuthorizerConfigurationCustomJwtAuthorizerCustomClaim")]
    public interface IBedrockagentcoreGatewayAuthorizerConfigurationCustomJwtAuthorizerCustomClaim
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/bedrockagentcore_gateway#inbound_token_claim_name BedrockagentcoreGateway#inbound_token_claim_name}.</summary>
        [JsiiProperty(name: "inboundTokenClaimName", typeJson: "{\"primitive\":\"string\"}")]
        string InboundTokenClaimName
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/bedrockagentcore_gateway#inbound_token_claim_value_type BedrockagentcoreGateway#inbound_token_claim_value_type}.</summary>
        [JsiiProperty(name: "inboundTokenClaimValueType", typeJson: "{\"primitive\":\"string\"}")]
        string InboundTokenClaimValueType
        {
            get;
        }

        /// <summary>authorizing_claim_match_value block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/bedrockagentcore_gateway#authorizing_claim_match_value BedrockagentcoreGateway#authorizing_claim_match_value}
        /// </remarks>
        [JsiiProperty(name: "authorizingClaimMatchValue", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.bedrockagentcoreGateway.BedrockagentcoreGatewayAuthorizerConfigurationCustomJwtAuthorizerCustomClaimAuthorizingClaimMatchValue\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? AuthorizingClaimMatchValue
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IBedrockagentcoreGatewayAuthorizerConfigurationCustomJwtAuthorizerCustomClaim), fullyQualifiedName: "aws.bedrockagentcoreGateway.BedrockagentcoreGatewayAuthorizerConfigurationCustomJwtAuthorizerCustomClaim")]
        internal sealed class _Proxy : DeputyBase, aws.BedrockagentcoreGateway.IBedrockagentcoreGatewayAuthorizerConfigurationCustomJwtAuthorizerCustomClaim
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/bedrockagentcore_gateway#inbound_token_claim_name BedrockagentcoreGateway#inbound_token_claim_name}.</summary>
            [JsiiProperty(name: "inboundTokenClaimName", typeJson: "{\"primitive\":\"string\"}")]
            public string InboundTokenClaimName
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/bedrockagentcore_gateway#inbound_token_claim_value_type BedrockagentcoreGateway#inbound_token_claim_value_type}.</summary>
            [JsiiProperty(name: "inboundTokenClaimValueType", typeJson: "{\"primitive\":\"string\"}")]
            public string InboundTokenClaimValueType
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>authorizing_claim_match_value block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/bedrockagentcore_gateway#authorizing_claim_match_value BedrockagentcoreGateway#authorizing_claim_match_value}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "authorizingClaimMatchValue", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.bedrockagentcoreGateway.BedrockagentcoreGatewayAuthorizerConfigurationCustomJwtAuthorizerCustomClaimAuthorizingClaimMatchValue\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? AuthorizingClaimMatchValue
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}

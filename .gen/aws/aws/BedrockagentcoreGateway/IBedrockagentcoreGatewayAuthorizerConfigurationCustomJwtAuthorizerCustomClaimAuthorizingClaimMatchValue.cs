using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.BedrockagentcoreGateway
{
    [JsiiInterface(nativeType: typeof(IBedrockagentcoreGatewayAuthorizerConfigurationCustomJwtAuthorizerCustomClaimAuthorizingClaimMatchValue), fullyQualifiedName: "aws.bedrockagentcoreGateway.BedrockagentcoreGatewayAuthorizerConfigurationCustomJwtAuthorizerCustomClaimAuthorizingClaimMatchValue")]
    public interface IBedrockagentcoreGatewayAuthorizerConfigurationCustomJwtAuthorizerCustomClaimAuthorizingClaimMatchValue
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/bedrockagentcore_gateway#claim_match_operator BedrockagentcoreGateway#claim_match_operator}.</summary>
        [JsiiProperty(name: "claimMatchOperator", typeJson: "{\"primitive\":\"string\"}")]
        string ClaimMatchOperator
        {
            get;
        }

        /// <summary>claim_match_value block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/bedrockagentcore_gateway#claim_match_value BedrockagentcoreGateway#claim_match_value}
        /// </remarks>
        [JsiiProperty(name: "claimMatchValue", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.bedrockagentcoreGateway.BedrockagentcoreGatewayAuthorizerConfigurationCustomJwtAuthorizerCustomClaimAuthorizingClaimMatchValueClaimMatchValue\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? ClaimMatchValue
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IBedrockagentcoreGatewayAuthorizerConfigurationCustomJwtAuthorizerCustomClaimAuthorizingClaimMatchValue), fullyQualifiedName: "aws.bedrockagentcoreGateway.BedrockagentcoreGatewayAuthorizerConfigurationCustomJwtAuthorizerCustomClaimAuthorizingClaimMatchValue")]
        internal sealed class _Proxy : DeputyBase, aws.BedrockagentcoreGateway.IBedrockagentcoreGatewayAuthorizerConfigurationCustomJwtAuthorizerCustomClaimAuthorizingClaimMatchValue
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/bedrockagentcore_gateway#claim_match_operator BedrockagentcoreGateway#claim_match_operator}.</summary>
            [JsiiProperty(name: "claimMatchOperator", typeJson: "{\"primitive\":\"string\"}")]
            public string ClaimMatchOperator
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>claim_match_value block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/bedrockagentcore_gateway#claim_match_value BedrockagentcoreGateway#claim_match_value}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "claimMatchValue", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.bedrockagentcoreGateway.BedrockagentcoreGatewayAuthorizerConfigurationCustomJwtAuthorizerCustomClaimAuthorizingClaimMatchValueClaimMatchValue\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? ClaimMatchValue
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}

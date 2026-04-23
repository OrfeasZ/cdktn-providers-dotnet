using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.BedrockagentcoreGateway
{
    [JsiiInterface(nativeType: typeof(IBedrockagentcoreGatewayAuthorizerConfigurationCustomJwtAuthorizerCustomClaimAuthorizingClaimMatchValueClaimMatchValue), fullyQualifiedName: "aws.bedrockagentcoreGateway.BedrockagentcoreGatewayAuthorizerConfigurationCustomJwtAuthorizerCustomClaimAuthorizingClaimMatchValueClaimMatchValue")]
    public interface IBedrockagentcoreGatewayAuthorizerConfigurationCustomJwtAuthorizerCustomClaimAuthorizingClaimMatchValueClaimMatchValue
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/bedrockagentcore_gateway#match_value_string BedrockagentcoreGateway#match_value_string}.</summary>
        [JsiiProperty(name: "matchValueString", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? MatchValueString
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/bedrockagentcore_gateway#match_value_string_list BedrockagentcoreGateway#match_value_string_list}.</summary>
        [JsiiProperty(name: "matchValueStringList", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? MatchValueStringList
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IBedrockagentcoreGatewayAuthorizerConfigurationCustomJwtAuthorizerCustomClaimAuthorizingClaimMatchValueClaimMatchValue), fullyQualifiedName: "aws.bedrockagentcoreGateway.BedrockagentcoreGatewayAuthorizerConfigurationCustomJwtAuthorizerCustomClaimAuthorizingClaimMatchValueClaimMatchValue")]
        internal sealed class _Proxy : DeputyBase, aws.BedrockagentcoreGateway.IBedrockagentcoreGatewayAuthorizerConfigurationCustomJwtAuthorizerCustomClaimAuthorizingClaimMatchValueClaimMatchValue
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/bedrockagentcore_gateway#match_value_string BedrockagentcoreGateway#match_value_string}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "matchValueString", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? MatchValueString
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/bedrockagentcore_gateway#match_value_string_list BedrockagentcoreGateway#match_value_string_list}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "matchValueStringList", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? MatchValueStringList
            {
                get => GetInstanceProperty<string[]?>();
            }
        }
    }
}

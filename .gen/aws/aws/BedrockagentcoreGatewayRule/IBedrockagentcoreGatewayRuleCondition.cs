using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.BedrockagentcoreGatewayRule
{
    [JsiiInterface(nativeType: typeof(IBedrockagentcoreGatewayRuleCondition), fullyQualifiedName: "aws.bedrockagentcoreGatewayRule.BedrockagentcoreGatewayRuleCondition")]
    public interface IBedrockagentcoreGatewayRuleCondition
    {
        /// <summary>match_paths block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/bedrockagentcore_gateway_rule#match_paths BedrockagentcoreGatewayRule#match_paths}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.BedrockagentcoreGatewayRule.IBedrockagentcoreGatewayRuleConditionMatchPaths" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "matchPaths", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.bedrockagentcoreGatewayRule.BedrockagentcoreGatewayRuleConditionMatchPaths\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? MatchPaths
        {
            get
            {
                return null;
            }
        }

        /// <summary>match_principals block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/bedrockagentcore_gateway_rule#match_principals BedrockagentcoreGatewayRule#match_principals}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.BedrockagentcoreGatewayRule.IBedrockagentcoreGatewayRuleConditionMatchPrincipals" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "matchPrincipals", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.bedrockagentcoreGatewayRule.BedrockagentcoreGatewayRuleConditionMatchPrincipals\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? MatchPrincipals
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IBedrockagentcoreGatewayRuleCondition), fullyQualifiedName: "aws.bedrockagentcoreGatewayRule.BedrockagentcoreGatewayRuleCondition")]
        internal sealed class _Proxy : DeputyBase, aws.BedrockagentcoreGatewayRule.IBedrockagentcoreGatewayRuleCondition
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>match_paths block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/bedrockagentcore_gateway_rule#match_paths BedrockagentcoreGatewayRule#match_paths}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.BedrockagentcoreGatewayRule.IBedrockagentcoreGatewayRuleConditionMatchPaths" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "matchPaths", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.bedrockagentcoreGatewayRule.BedrockagentcoreGatewayRuleConditionMatchPaths\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? MatchPaths
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>match_principals block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/bedrockagentcore_gateway_rule#match_principals BedrockagentcoreGatewayRule#match_principals}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.BedrockagentcoreGatewayRule.IBedrockagentcoreGatewayRuleConditionMatchPrincipals" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "matchPrincipals", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.bedrockagentcoreGatewayRule.BedrockagentcoreGatewayRuleConditionMatchPrincipals\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? MatchPrincipals
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}

using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.BedrockagentcoreGatewayRule
{
    [JsiiByValue(fqn: "aws.bedrockagentcoreGatewayRule.BedrockagentcoreGatewayRuleCondition")]
    public class BedrockagentcoreGatewayRuleCondition : aws.BedrockagentcoreGatewayRule.IBedrockagentcoreGatewayRuleCondition
    {
        private object? _matchPaths;

        /// <summary>match_paths block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/bedrockagentcore_gateway_rule#match_paths BedrockagentcoreGatewayRule#match_paths}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.BedrockagentcoreGatewayRule.IBedrockagentcoreGatewayRuleConditionMatchPaths" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "matchPaths", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.bedrockagentcoreGatewayRule.BedrockagentcoreGatewayRuleConditionMatchPaths\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? MatchPaths
        {
            get => _matchPaths;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.BedrockagentcoreGatewayRule.IBedrockagentcoreGatewayRuleConditionMatchPaths[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.BedrockagentcoreGatewayRule.IBedrockagentcoreGatewayRuleConditionMatchPaths).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _matchPaths = value;
            }
        }

        private object? _matchPrincipals;

        /// <summary>match_principals block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/bedrockagentcore_gateway_rule#match_principals BedrockagentcoreGatewayRule#match_principals}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.BedrockagentcoreGatewayRule.IBedrockagentcoreGatewayRuleConditionMatchPrincipals" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "matchPrincipals", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.bedrockagentcoreGatewayRule.BedrockagentcoreGatewayRuleConditionMatchPrincipals\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? MatchPrincipals
        {
            get => _matchPrincipals;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.BedrockagentcoreGatewayRule.IBedrockagentcoreGatewayRuleConditionMatchPrincipals[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.BedrockagentcoreGatewayRule.IBedrockagentcoreGatewayRuleConditionMatchPrincipals).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _matchPrincipals = value;
            }
        }
    }
}

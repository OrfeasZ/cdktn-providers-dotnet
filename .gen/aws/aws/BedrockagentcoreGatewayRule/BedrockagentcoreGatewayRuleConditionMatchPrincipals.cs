using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.BedrockagentcoreGatewayRule
{
    [JsiiByValue(fqn: "aws.bedrockagentcoreGatewayRule.BedrockagentcoreGatewayRuleConditionMatchPrincipals")]
    public class BedrockagentcoreGatewayRuleConditionMatchPrincipals : aws.BedrockagentcoreGatewayRule.IBedrockagentcoreGatewayRuleConditionMatchPrincipals
    {
        private object? _anyOf;

        /// <summary>any_of block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.62.0/docs/resources/bedrockagentcore_gateway_rule#any_of BedrockagentcoreGatewayRule#any_of}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.BedrockagentcoreGatewayRule.IBedrockagentcoreGatewayRuleConditionMatchPrincipalsAnyOf" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "anyOf", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.bedrockagentcoreGatewayRule.BedrockagentcoreGatewayRuleConditionMatchPrincipalsAnyOf\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? AnyOf
        {
            get => _anyOf;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.BedrockagentcoreGatewayRule.IBedrockagentcoreGatewayRuleConditionMatchPrincipalsAnyOf[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.BedrockagentcoreGatewayRule.IBedrockagentcoreGatewayRuleConditionMatchPrincipalsAnyOf).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _anyOf = value;
            }
        }
    }
}

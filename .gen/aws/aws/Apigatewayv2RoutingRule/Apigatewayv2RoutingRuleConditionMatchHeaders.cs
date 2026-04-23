using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Apigatewayv2RoutingRule
{
    [JsiiByValue(fqn: "aws.apigatewayv2RoutingRule.Apigatewayv2RoutingRuleConditionMatchHeaders")]
    public class Apigatewayv2RoutingRuleConditionMatchHeaders : aws.Apigatewayv2RoutingRule.IApigatewayv2RoutingRuleConditionMatchHeaders
    {
        private object? _anyOf;

        /// <summary>any_of block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/apigatewayv2_routing_rule#any_of Apigatewayv2RoutingRule#any_of}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "anyOf", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.apigatewayv2RoutingRule.Apigatewayv2RoutingRuleConditionMatchHeadersAnyOf\"},\"kind\":\"array\"}}]}}", isOptional: true)]
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
                        case aws.Apigatewayv2RoutingRule.IApigatewayv2RoutingRuleConditionMatchHeadersAnyOf[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.Apigatewayv2RoutingRule.IApigatewayv2RoutingRuleConditionMatchHeadersAnyOf).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _anyOf = value;
            }
        }
    }
}

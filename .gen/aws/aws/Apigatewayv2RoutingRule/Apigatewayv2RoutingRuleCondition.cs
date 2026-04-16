using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Apigatewayv2RoutingRule
{
    [JsiiByValue(fqn: "aws.apigatewayv2RoutingRule.Apigatewayv2RoutingRuleCondition")]
    public class Apigatewayv2RoutingRuleCondition : aws.Apigatewayv2RoutingRule.IApigatewayv2RoutingRuleCondition
    {
        private object? _matchBasePaths;

        /// <summary>match_base_paths block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/apigatewayv2_routing_rule#match_base_paths Apigatewayv2RoutingRule#match_base_paths}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "matchBasePaths", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.apigatewayv2RoutingRule.Apigatewayv2RoutingRuleConditionMatchBasePaths\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? MatchBasePaths
        {
            get => _matchBasePaths;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.Apigatewayv2RoutingRule.IApigatewayv2RoutingRuleConditionMatchBasePaths[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.Apigatewayv2RoutingRule.IApigatewayv2RoutingRuleConditionMatchBasePaths).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _matchBasePaths = value;
            }
        }

        private object? _matchHeaders;

        /// <summary>match_headers block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/apigatewayv2_routing_rule#match_headers Apigatewayv2RoutingRule#match_headers}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "matchHeaders", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.apigatewayv2RoutingRule.Apigatewayv2RoutingRuleConditionMatchHeaders\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? MatchHeaders
        {
            get => _matchHeaders;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.Apigatewayv2RoutingRule.IApigatewayv2RoutingRuleConditionMatchHeaders[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.Apigatewayv2RoutingRule.IApigatewayv2RoutingRuleConditionMatchHeaders).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _matchHeaders = value;
            }
        }
    }
}

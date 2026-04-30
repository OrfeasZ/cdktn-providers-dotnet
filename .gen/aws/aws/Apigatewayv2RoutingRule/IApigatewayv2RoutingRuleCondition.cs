using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Apigatewayv2RoutingRule
{
    [JsiiInterface(nativeType: typeof(IApigatewayv2RoutingRuleCondition), fullyQualifiedName: "aws.apigatewayv2RoutingRule.Apigatewayv2RoutingRuleCondition")]
    public interface IApigatewayv2RoutingRuleCondition
    {
        /// <summary>match_base_paths block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/apigatewayv2_routing_rule#match_base_paths Apigatewayv2RoutingRule#match_base_paths}
        /// </remarks>
        [JsiiProperty(name: "matchBasePaths", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.apigatewayv2RoutingRule.Apigatewayv2RoutingRuleConditionMatchBasePaths\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? MatchBasePaths
        {
            get
            {
                return null;
            }
        }

        /// <summary>match_headers block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/apigatewayv2_routing_rule#match_headers Apigatewayv2RoutingRule#match_headers}
        /// </remarks>
        [JsiiProperty(name: "matchHeaders", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.apigatewayv2RoutingRule.Apigatewayv2RoutingRuleConditionMatchHeaders\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? MatchHeaders
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IApigatewayv2RoutingRuleCondition), fullyQualifiedName: "aws.apigatewayv2RoutingRule.Apigatewayv2RoutingRuleCondition")]
        internal sealed class _Proxy : DeputyBase, aws.Apigatewayv2RoutingRule.IApigatewayv2RoutingRuleCondition
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>match_base_paths block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/apigatewayv2_routing_rule#match_base_paths Apigatewayv2RoutingRule#match_base_paths}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "matchBasePaths", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.apigatewayv2RoutingRule.Apigatewayv2RoutingRuleConditionMatchBasePaths\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? MatchBasePaths
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>match_headers block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/apigatewayv2_routing_rule#match_headers Apigatewayv2RoutingRule#match_headers}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "matchHeaders", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.apigatewayv2RoutingRule.Apigatewayv2RoutingRuleConditionMatchHeaders\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? MatchHeaders
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}

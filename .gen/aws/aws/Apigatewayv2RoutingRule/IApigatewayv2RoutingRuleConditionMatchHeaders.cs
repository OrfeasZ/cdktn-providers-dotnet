using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Apigatewayv2RoutingRule
{
    [JsiiInterface(nativeType: typeof(IApigatewayv2RoutingRuleConditionMatchHeaders), fullyQualifiedName: "aws.apigatewayv2RoutingRule.Apigatewayv2RoutingRuleConditionMatchHeaders")]
    public interface IApigatewayv2RoutingRuleConditionMatchHeaders
    {
        /// <summary>any_of block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/apigatewayv2_routing_rule#any_of Apigatewayv2RoutingRule#any_of}
        /// </remarks>
        [JsiiProperty(name: "anyOf", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.apigatewayv2RoutingRule.Apigatewayv2RoutingRuleConditionMatchHeadersAnyOf\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? AnyOf
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IApigatewayv2RoutingRuleConditionMatchHeaders), fullyQualifiedName: "aws.apigatewayv2RoutingRule.Apigatewayv2RoutingRuleConditionMatchHeaders")]
        internal sealed class _Proxy : DeputyBase, aws.Apigatewayv2RoutingRule.IApigatewayv2RoutingRuleConditionMatchHeaders
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>any_of block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/apigatewayv2_routing_rule#any_of Apigatewayv2RoutingRule#any_of}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "anyOf", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.apigatewayv2RoutingRule.Apigatewayv2RoutingRuleConditionMatchHeadersAnyOf\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? AnyOf
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}

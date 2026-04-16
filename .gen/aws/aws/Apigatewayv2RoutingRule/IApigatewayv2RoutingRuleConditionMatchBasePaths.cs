using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Apigatewayv2RoutingRule
{
    [JsiiInterface(nativeType: typeof(IApigatewayv2RoutingRuleConditionMatchBasePaths), fullyQualifiedName: "aws.apigatewayv2RoutingRule.Apigatewayv2RoutingRuleConditionMatchBasePaths")]
    public interface IApigatewayv2RoutingRuleConditionMatchBasePaths
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/apigatewayv2_routing_rule#any_of Apigatewayv2RoutingRule#any_of}.</summary>
        [JsiiProperty(name: "anyOf", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        string[] AnyOf
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IApigatewayv2RoutingRuleConditionMatchBasePaths), fullyQualifiedName: "aws.apigatewayv2RoutingRule.Apigatewayv2RoutingRuleConditionMatchBasePaths")]
        internal sealed class _Proxy : DeputyBase, aws.Apigatewayv2RoutingRule.IApigatewayv2RoutingRuleConditionMatchBasePaths
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/apigatewayv2_routing_rule#any_of Apigatewayv2RoutingRule#any_of}.</summary>
            [JsiiProperty(name: "anyOf", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
            public string[] AnyOf
            {
                get => GetInstanceProperty<string[]>()!;
            }
        }
    }
}

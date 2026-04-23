using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Apigatewayv2RoutingRule
{
    [JsiiInterface(nativeType: typeof(IApigatewayv2RoutingRuleConditionMatchHeadersAnyOf), fullyQualifiedName: "aws.apigatewayv2RoutingRule.Apigatewayv2RoutingRuleConditionMatchHeadersAnyOf")]
    public interface IApigatewayv2RoutingRuleConditionMatchHeadersAnyOf
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/apigatewayv2_routing_rule#header Apigatewayv2RoutingRule#header}.</summary>
        [JsiiProperty(name: "header", typeJson: "{\"primitive\":\"string\"}")]
        string Header
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/apigatewayv2_routing_rule#value_glob Apigatewayv2RoutingRule#value_glob}.</summary>
        [JsiiProperty(name: "valueGlob", typeJson: "{\"primitive\":\"string\"}")]
        string ValueGlob
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IApigatewayv2RoutingRuleConditionMatchHeadersAnyOf), fullyQualifiedName: "aws.apigatewayv2RoutingRule.Apigatewayv2RoutingRuleConditionMatchHeadersAnyOf")]
        internal sealed class _Proxy : DeputyBase, aws.Apigatewayv2RoutingRule.IApigatewayv2RoutingRuleConditionMatchHeadersAnyOf
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/apigatewayv2_routing_rule#header Apigatewayv2RoutingRule#header}.</summary>
            [JsiiProperty(name: "header", typeJson: "{\"primitive\":\"string\"}")]
            public string Header
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/apigatewayv2_routing_rule#value_glob Apigatewayv2RoutingRule#value_glob}.</summary>
            [JsiiProperty(name: "valueGlob", typeJson: "{\"primitive\":\"string\"}")]
            public string ValueGlob
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}

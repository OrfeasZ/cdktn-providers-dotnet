using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Apigatewayv2RoutingRule
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.apigatewayv2RoutingRule.Apigatewayv2RoutingRuleConditionMatchHeadersAnyOf")]
    public class Apigatewayv2RoutingRuleConditionMatchHeadersAnyOf : aws.Apigatewayv2RoutingRule.IApigatewayv2RoutingRuleConditionMatchHeadersAnyOf
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/apigatewayv2_routing_rule#header Apigatewayv2RoutingRule#header}.</summary>
        [JsiiProperty(name: "header", typeJson: "{\"primitive\":\"string\"}")]
        public string Header
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/apigatewayv2_routing_rule#value_glob Apigatewayv2RoutingRule#value_glob}.</summary>
        [JsiiProperty(name: "valueGlob", typeJson: "{\"primitive\":\"string\"}")]
        public string ValueGlob
        {
            get;
            set;
        }
    }
}

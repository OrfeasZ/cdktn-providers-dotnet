using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Apigatewayv2RoutingRule
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.apigatewayv2RoutingRule.Apigatewayv2RoutingRuleConditionMatchBasePaths")]
    public class Apigatewayv2RoutingRuleConditionMatchBasePaths : aws.Apigatewayv2RoutingRule.IApigatewayv2RoutingRuleConditionMatchBasePaths
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/apigatewayv2_routing_rule#any_of Apigatewayv2RoutingRule#any_of}.</summary>
        [JsiiProperty(name: "anyOf", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public string[] AnyOf
        {
            get;
            set;
        }
    }
}

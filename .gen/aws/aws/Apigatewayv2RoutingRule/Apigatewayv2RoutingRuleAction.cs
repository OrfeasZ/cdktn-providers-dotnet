using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Apigatewayv2RoutingRule
{
    [JsiiByValue(fqn: "aws.apigatewayv2RoutingRule.Apigatewayv2RoutingRuleAction")]
    public class Apigatewayv2RoutingRuleAction : aws.Apigatewayv2RoutingRule.IApigatewayv2RoutingRuleAction
    {
        private object? _invokeApi;

        /// <summary>invoke_api block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/apigatewayv2_routing_rule#invoke_api Apigatewayv2RoutingRule#invoke_api}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "invokeApi", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.apigatewayv2RoutingRule.Apigatewayv2RoutingRuleActionInvokeApi\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? InvokeApi
        {
            get => _invokeApi;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.Apigatewayv2RoutingRule.IApigatewayv2RoutingRuleActionInvokeApi[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.Apigatewayv2RoutingRule.IApigatewayv2RoutingRuleActionInvokeApi).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _invokeApi = value;
            }
        }
    }
}

using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Apigatewayv2RoutingRule
{
    [JsiiInterface(nativeType: typeof(IApigatewayv2RoutingRuleActionInvokeApi), fullyQualifiedName: "aws.apigatewayv2RoutingRule.Apigatewayv2RoutingRuleActionInvokeApi")]
    public interface IApigatewayv2RoutingRuleActionInvokeApi
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/apigatewayv2_routing_rule#api_id Apigatewayv2RoutingRule#api_id}.</summary>
        [JsiiProperty(name: "apiId", typeJson: "{\"primitive\":\"string\"}")]
        string ApiId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/apigatewayv2_routing_rule#stage Apigatewayv2RoutingRule#stage}.</summary>
        [JsiiProperty(name: "stage", typeJson: "{\"primitive\":\"string\"}")]
        string Stage
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/apigatewayv2_routing_rule#strip_base_path Apigatewayv2RoutingRule#strip_base_path}.</summary>
        [JsiiProperty(name: "stripBasePath", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? StripBasePath
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IApigatewayv2RoutingRuleActionInvokeApi), fullyQualifiedName: "aws.apigatewayv2RoutingRule.Apigatewayv2RoutingRuleActionInvokeApi")]
        internal sealed class _Proxy : DeputyBase, aws.Apigatewayv2RoutingRule.IApigatewayv2RoutingRuleActionInvokeApi
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/apigatewayv2_routing_rule#api_id Apigatewayv2RoutingRule#api_id}.</summary>
            [JsiiProperty(name: "apiId", typeJson: "{\"primitive\":\"string\"}")]
            public string ApiId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/apigatewayv2_routing_rule#stage Apigatewayv2RoutingRule#stage}.</summary>
            [JsiiProperty(name: "stage", typeJson: "{\"primitive\":\"string\"}")]
            public string Stage
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/apigatewayv2_routing_rule#strip_base_path Apigatewayv2RoutingRule#strip_base_path}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "stripBasePath", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? StripBasePath
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}

using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.LoadBalancer
{
    [JsiiInterface(nativeType: typeof(ILoadBalancerRulesFixedResponse), fullyQualifiedName: "cloudflare.loadBalancer.LoadBalancerRulesFixedResponse")]
    public interface ILoadBalancerRulesFixedResponse
    {
        /// <summary>The http 'Content-Type' header to include in the response.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/load_balancer#content_type LoadBalancer#content_type}
        /// </remarks>
        [JsiiProperty(name: "contentType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ContentType
        {
            get
            {
                return null;
            }
        }

        /// <summary>The http 'Location' header to include in the response.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/load_balancer#location LoadBalancer#location}
        /// </remarks>
        [JsiiProperty(name: "location", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Location
        {
            get
            {
                return null;
            }
        }

        /// <summary>Text to include as the http body.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/load_balancer#message_body LoadBalancer#message_body}
        /// </remarks>
        [JsiiProperty(name: "messageBody", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? MessageBody
        {
            get
            {
                return null;
            }
        }

        /// <summary>The http status code to respond with.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/load_balancer#status_code LoadBalancer#status_code}
        /// </remarks>
        [JsiiProperty(name: "statusCode", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? StatusCode
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ILoadBalancerRulesFixedResponse), fullyQualifiedName: "cloudflare.loadBalancer.LoadBalancerRulesFixedResponse")]
        internal sealed class _Proxy : DeputyBase, cloudflare.LoadBalancer.ILoadBalancerRulesFixedResponse
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>The http 'Content-Type' header to include in the response.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/load_balancer#content_type LoadBalancer#content_type}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "contentType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ContentType
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>The http 'Location' header to include in the response.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/load_balancer#location LoadBalancer#location}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "location", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Location
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Text to include as the http body.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/load_balancer#message_body LoadBalancer#message_body}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "messageBody", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? MessageBody
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>The http status code to respond with.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/load_balancer#status_code LoadBalancer#status_code}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "statusCode", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? StatusCode
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}

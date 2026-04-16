using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.LoadBalancerPool
{
    [JsiiInterface(nativeType: typeof(ILoadBalancerPoolOriginSteering), fullyQualifiedName: "cloudflare.loadBalancerPool.LoadBalancerPoolOriginSteering")]
    public interface ILoadBalancerPoolOriginSteering
    {
        /// <summary>The type of origin steering policy to use.</summary>
        /// <remarks>
        /// <list type="bullet">
        /// <description><c>"random"</c>: Select an origin randomly.</description>
        /// <description><c>"hash"</c>: Select an origin by computing a hash over the CF-Connecting-IP address.</description>
        /// <description><c>"least_outstanding_requests"</c>: Select an origin by taking into consideration origin weights, as well as each origin's number of outstanding requests. Origins with more pending requests are weighted proportionately less relative to others.</description>
        /// <description><c>"least_connections"</c>: Select an origin by taking into consideration origin weights, as well as each origin's number of open connections. Origins with more open connections are weighted proportionately less relative to others. Supported for HTTP/1 and HTTP/2 connections.
        /// Available values: "random", "hash", "least_outstanding_requests", "least_connections".</description>
        /// </list>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/load_balancer_pool#policy LoadBalancerPool#policy}
        /// </remarks>
        [JsiiProperty(name: "policy", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Policy
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ILoadBalancerPoolOriginSteering), fullyQualifiedName: "cloudflare.loadBalancerPool.LoadBalancerPoolOriginSteering")]
        internal sealed class _Proxy : DeputyBase, cloudflare.LoadBalancerPool.ILoadBalancerPoolOriginSteering
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>The type of origin steering policy to use.</summary>
            /// <remarks>
            /// <list type="bullet">
            /// <description><c>"random"</c>: Select an origin randomly.</description>
            /// <description><c>"hash"</c>: Select an origin by computing a hash over the CF-Connecting-IP address.</description>
            /// <description><c>"least_outstanding_requests"</c>: Select an origin by taking into consideration origin weights, as well as each origin's number of outstanding requests. Origins with more pending requests are weighted proportionately less relative to others.</description>
            /// <description><c>"least_connections"</c>: Select an origin by taking into consideration origin weights, as well as each origin's number of open connections. Origins with more open connections are weighted proportionately less relative to others. Supported for HTTP/1 and HTTP/2 connections.
            /// Available values: "random", "hash", "least_outstanding_requests", "least_connections".</description>
            /// </list>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/load_balancer_pool#policy LoadBalancerPool#policy}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "policy", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Policy
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}

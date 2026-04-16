using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.LoadBalancerPool
{
    [JsiiByValue(fqn: "cloudflare.loadBalancerPool.LoadBalancerPoolOriginsHeader")]
    public class LoadBalancerPoolOriginsHeader : cloudflare.LoadBalancerPool.ILoadBalancerPoolOriginsHeader
    {
        /// <summary>The 'Host' header allows to override the hostname set in the HTTP request.</summary>
        /// <remarks>
        /// Current support is 1 'Host' header override per origin.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/load_balancer_pool#host LoadBalancerPool#host}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "host", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? Host
        {
            get;
            set;
        }
    }
}

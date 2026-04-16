using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.LoadBalancerPool
{
    [JsiiByValue(fqn: "cloudflare.loadBalancerPool.LoadBalancerPoolNotificationFilter")]
    public class LoadBalancerPoolNotificationFilter : cloudflare.LoadBalancerPool.ILoadBalancerPoolNotificationFilter
    {
        /// <summary>Filter options for a particular resource type (pool or origin). Use null to reset.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/load_balancer_pool#origin LoadBalancerPool#origin}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "origin", typeJson: "{\"fqn\":\"cloudflare.loadBalancerPool.LoadBalancerPoolNotificationFilterOrigin\"}", isOptional: true)]
        public cloudflare.LoadBalancerPool.ILoadBalancerPoolNotificationFilterOrigin? Origin
        {
            get;
            set;
        }

        /// <summary>Filter options for a particular resource type (pool or origin). Use null to reset.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/load_balancer_pool#pool LoadBalancerPool#pool}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "pool", typeJson: "{\"fqn\":\"cloudflare.loadBalancerPool.LoadBalancerPoolNotificationFilterPool\"}", isOptional: true)]
        public cloudflare.LoadBalancerPool.ILoadBalancerPoolNotificationFilterPool? Pool
        {
            get;
            set;
        }
    }
}

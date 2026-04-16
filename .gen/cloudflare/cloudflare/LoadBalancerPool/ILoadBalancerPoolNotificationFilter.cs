using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.LoadBalancerPool
{
    [JsiiInterface(nativeType: typeof(ILoadBalancerPoolNotificationFilter), fullyQualifiedName: "cloudflare.loadBalancerPool.LoadBalancerPoolNotificationFilter")]
    public interface ILoadBalancerPoolNotificationFilter
    {
        /// <summary>Filter options for a particular resource type (pool or origin). Use null to reset.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/load_balancer_pool#origin LoadBalancerPool#origin}
        /// </remarks>
        [JsiiProperty(name: "origin", typeJson: "{\"fqn\":\"cloudflare.loadBalancerPool.LoadBalancerPoolNotificationFilterOrigin\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        cloudflare.LoadBalancerPool.ILoadBalancerPoolNotificationFilterOrigin? Origin
        {
            get
            {
                return null;
            }
        }

        /// <summary>Filter options for a particular resource type (pool or origin). Use null to reset.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/load_balancer_pool#pool LoadBalancerPool#pool}
        /// </remarks>
        [JsiiProperty(name: "pool", typeJson: "{\"fqn\":\"cloudflare.loadBalancerPool.LoadBalancerPoolNotificationFilterPool\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        cloudflare.LoadBalancerPool.ILoadBalancerPoolNotificationFilterPool? Pool
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ILoadBalancerPoolNotificationFilter), fullyQualifiedName: "cloudflare.loadBalancerPool.LoadBalancerPoolNotificationFilter")]
        internal sealed class _Proxy : DeputyBase, cloudflare.LoadBalancerPool.ILoadBalancerPoolNotificationFilter
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Filter options for a particular resource type (pool or origin). Use null to reset.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/load_balancer_pool#origin LoadBalancerPool#origin}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "origin", typeJson: "{\"fqn\":\"cloudflare.loadBalancerPool.LoadBalancerPoolNotificationFilterOrigin\"}", isOptional: true)]
            public cloudflare.LoadBalancerPool.ILoadBalancerPoolNotificationFilterOrigin? Origin
            {
                get => GetInstanceProperty<cloudflare.LoadBalancerPool.ILoadBalancerPoolNotificationFilterOrigin?>();
            }

            /// <summary>Filter options for a particular resource type (pool or origin). Use null to reset.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/load_balancer_pool#pool LoadBalancerPool#pool}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "pool", typeJson: "{\"fqn\":\"cloudflare.loadBalancerPool.LoadBalancerPoolNotificationFilterPool\"}", isOptional: true)]
            public cloudflare.LoadBalancerPool.ILoadBalancerPoolNotificationFilterPool? Pool
            {
                get => GetInstanceProperty<cloudflare.LoadBalancerPool.ILoadBalancerPoolNotificationFilterPool?>();
            }
        }
    }
}

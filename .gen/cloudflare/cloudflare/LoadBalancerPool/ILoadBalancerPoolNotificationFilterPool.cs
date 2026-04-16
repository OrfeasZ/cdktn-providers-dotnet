using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.LoadBalancerPool
{
    [JsiiInterface(nativeType: typeof(ILoadBalancerPoolNotificationFilterPool), fullyQualifiedName: "cloudflare.loadBalancerPool.LoadBalancerPoolNotificationFilterPool")]
    public interface ILoadBalancerPoolNotificationFilterPool
    {
        /// <summary>If set true, disable notifications for this type of resource (pool or origin).</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/load_balancer_pool#disable LoadBalancerPool#disable}
        /// </remarks>
        [JsiiProperty(name: "disable", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Disable
        {
            get
            {
                return null;
            }
        }

        /// <summary>If present, send notifications only for this health status (e.g. false for only DOWN events). Use null to reset (all events).</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/load_balancer_pool#healthy LoadBalancerPool#healthy}
        /// </remarks>
        [JsiiProperty(name: "healthy", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Healthy
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ILoadBalancerPoolNotificationFilterPool), fullyQualifiedName: "cloudflare.loadBalancerPool.LoadBalancerPoolNotificationFilterPool")]
        internal sealed class _Proxy : DeputyBase, cloudflare.LoadBalancerPool.ILoadBalancerPoolNotificationFilterPool
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>If set true, disable notifications for this type of resource (pool or origin).</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/load_balancer_pool#disable LoadBalancerPool#disable}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "disable", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? Disable
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>If present, send notifications only for this health status (e.g. false for only DOWN events). Use null to reset (all events).</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/load_balancer_pool#healthy LoadBalancerPool#healthy}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "healthy", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? Healthy
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}

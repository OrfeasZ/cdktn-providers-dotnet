using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.LoadBalancer
{
    [JsiiInterface(nativeType: typeof(ILoadBalancerAdaptiveRouting), fullyQualifiedName: "cloudflare.loadBalancer.LoadBalancerAdaptiveRouting")]
    public interface ILoadBalancerAdaptiveRouting
    {
        /// <summary>Extends zero-downtime failover of requests to healthy origins from alternate pools, when no healthy alternate exists in the same pool, according to the failover order defined by traffic and origin steering.</summary>
        /// <remarks>
        /// When set false (the default) zero-downtime failover will only occur between origins within the same pool. See <c>session_affinity_attributes</c> for control over when sessions are broken or reassigned.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/load_balancer#failover_across_pools LoadBalancer#failover_across_pools}
        /// </remarks>
        [JsiiProperty(name: "failoverAcrossPools", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? FailoverAcrossPools
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ILoadBalancerAdaptiveRouting), fullyQualifiedName: "cloudflare.loadBalancer.LoadBalancerAdaptiveRouting")]
        internal sealed class _Proxy : DeputyBase, cloudflare.LoadBalancer.ILoadBalancerAdaptiveRouting
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Extends zero-downtime failover of requests to healthy origins from alternate pools, when no healthy alternate exists in the same pool, according to the failover order defined by traffic and origin steering.</summary>
            /// <remarks>
            /// When set false (the default) zero-downtime failover will only occur between origins within the same pool. See <c>session_affinity_attributes</c> for control over when sessions are broken or reassigned.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/load_balancer#failover_across_pools LoadBalancer#failover_across_pools}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "failoverAcrossPools", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? FailoverAcrossPools
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}

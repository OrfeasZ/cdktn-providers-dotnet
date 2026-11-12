using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.LoadBalancer
{
    [JsiiInterface(nativeType: typeof(ILoadBalancerPoolSetsMatch), fullyQualifiedName: "cloudflare.loadBalancer.LoadBalancerPoolSetsMatch")]
    public interface ILoadBalancerPoolSetsMatch
    {
        /// <summary>When true, matches every request. Cannot be combined with `topology`.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.29.0/docs/resources/load_balancer#default LoadBalancer#default}
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "default", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Default
        {
            get
            {
                return null;
            }
        }

        /// <summary>Matches requests by location.</summary>
        /// <remarks>
        /// Set any combination of <c>pops</c>, <c>countries</c>, and <c>regions</c> (at least one is required); a request matches when its value appears in any populated list (e.g. <c>regions: ["WNAM"]</c> with <c>countries: ["US"]</c> matches a request in either WNAM or the US).
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.29.0/docs/resources/load_balancer#topology LoadBalancer#topology}
        /// </remarks>
        [JsiiProperty(name: "topology", typeJson: "{\"fqn\":\"cloudflare.loadBalancer.LoadBalancerPoolSetsMatchTopology\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        cloudflare.LoadBalancer.ILoadBalancerPoolSetsMatchTopology? Topology
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ILoadBalancerPoolSetsMatch), fullyQualifiedName: "cloudflare.loadBalancer.LoadBalancerPoolSetsMatch")]
        internal sealed class _Proxy : DeputyBase, cloudflare.LoadBalancer.ILoadBalancerPoolSetsMatch
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>When true, matches every request. Cannot be combined with `topology`.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.29.0/docs/resources/load_balancer#default LoadBalancer#default}
            /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "default", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? Default
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Matches requests by location.</summary>
            /// <remarks>
            /// Set any combination of <c>pops</c>, <c>countries</c>, and <c>regions</c> (at least one is required); a request matches when its value appears in any populated list (e.g. <c>regions: ["WNAM"]</c> with <c>countries: ["US"]</c> matches a request in either WNAM or the US).
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.29.0/docs/resources/load_balancer#topology LoadBalancer#topology}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "topology", typeJson: "{\"fqn\":\"cloudflare.loadBalancer.LoadBalancerPoolSetsMatchTopology\"}", isOptional: true)]
            public cloudflare.LoadBalancer.ILoadBalancerPoolSetsMatchTopology? Topology
            {
                get => GetInstanceProperty<cloudflare.LoadBalancer.ILoadBalancerPoolSetsMatchTopology?>();
            }
        }
    }
}

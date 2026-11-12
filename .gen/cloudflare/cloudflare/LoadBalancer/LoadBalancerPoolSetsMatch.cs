using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.LoadBalancer
{
    [JsiiByValue(fqn: "cloudflare.loadBalancer.LoadBalancerPoolSetsMatch")]
    public class LoadBalancerPoolSetsMatch : cloudflare.LoadBalancer.ILoadBalancerPoolSetsMatch
    {
        private object? _default;

        /// <summary>When true, matches every request. Cannot be combined with `topology`.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.29.0/docs/resources/load_balancer#default LoadBalancer#default}
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "default", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? Default
        {
            get => _default;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case bool cast_cd4240:
                            break;
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _default = value;
            }
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
            get;
            set;
        }
    }
}

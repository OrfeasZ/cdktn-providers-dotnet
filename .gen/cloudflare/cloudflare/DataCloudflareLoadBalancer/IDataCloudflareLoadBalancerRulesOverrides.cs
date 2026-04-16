using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.DataCloudflareLoadBalancer
{
    [JsiiInterface(nativeType: typeof(IDataCloudflareLoadBalancerRulesOverrides), fullyQualifiedName: "cloudflare.dataCloudflareLoadBalancer.DataCloudflareLoadBalancerRulesOverrides")]
    public interface IDataCloudflareLoadBalancerRulesOverrides
    {
        /// <summary>Enterprise only: A mapping of Cloudflare PoP identifiers to a list of pool IDs (ordered by their failover priority) for the PoP (datacenter).</summary>
        /// <remarks>
        /// Any PoPs not explicitly defined will fall back to using the corresponding country_pool, then region_pool mapping if it exists else to default_pools.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/data-sources/load_balancer#pop_pools DataCloudflareLoadBalancer#pop_pools}
        /// </remarks>
        [JsiiProperty(name: "popPools", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}},\"kind\":\"map\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? PopPools
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataCloudflareLoadBalancerRulesOverrides), fullyQualifiedName: "cloudflare.dataCloudflareLoadBalancer.DataCloudflareLoadBalancerRulesOverrides")]
        internal sealed class _Proxy : DeputyBase, cloudflare.DataCloudflareLoadBalancer.IDataCloudflareLoadBalancerRulesOverrides
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Enterprise only: A mapping of Cloudflare PoP identifiers to a list of pool IDs (ordered by their failover priority) for the PoP (datacenter).</summary>
            /// <remarks>
            /// Any PoPs not explicitly defined will fall back to using the corresponding country_pool, then region_pool mapping if it exists else to default_pools.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/data-sources/load_balancer#pop_pools DataCloudflareLoadBalancer#pop_pools}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "popPools", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}},\"kind\":\"map\"}}]}}", isOptional: true)]
            public object? PopPools
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}

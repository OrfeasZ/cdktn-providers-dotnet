using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.DataCloudflareLoadBalancers
{
    [JsiiInterface(nativeType: typeof(IDataCloudflareLoadBalancersResultRulesOverrides), fullyQualifiedName: "cloudflare.dataCloudflareLoadBalancers.DataCloudflareLoadBalancersResultRulesOverrides")]
    public interface IDataCloudflareLoadBalancersResultRulesOverrides
    {
        /// <summary>A mapping of country codes to a list of pool IDs (ordered by their failover priority) for the given country.</summary>
        /// <remarks>
        /// Any country not explicitly defined will fall back to using the corresponding region_pool mapping if it exists else to default_pools.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/data-sources/load_balancers#country_pools DataCloudflareLoadBalancers#country_pools}
        /// </remarks>
        [JsiiProperty(name: "countryPools", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}},\"kind\":\"map\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? CountryPools
        {
            get
            {
                return null;
            }
        }

        /// <summary>Enterprise only: A mapping of Cloudflare PoP identifiers to a list of pool IDs (ordered by their failover priority) for the PoP (datacenter).</summary>
        /// <remarks>
        /// Any PoPs not explicitly defined will fall back to using the corresponding country_pool, then region_pool mapping if it exists else to default_pools.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/data-sources/load_balancers#pop_pools DataCloudflareLoadBalancers#pop_pools}
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

        /// <summary>A mapping of region codes to a list of pool IDs (ordered by their failover priority) for the given region.</summary>
        /// <remarks>
        /// Any regions not explicitly defined will fall back to using default_pools.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/data-sources/load_balancers#region_pools DataCloudflareLoadBalancers#region_pools}
        /// </remarks>
        [JsiiProperty(name: "regionPools", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}},\"kind\":\"map\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? RegionPools
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataCloudflareLoadBalancersResultRulesOverrides), fullyQualifiedName: "cloudflare.dataCloudflareLoadBalancers.DataCloudflareLoadBalancersResultRulesOverrides")]
        internal sealed class _Proxy : DeputyBase, cloudflare.DataCloudflareLoadBalancers.IDataCloudflareLoadBalancersResultRulesOverrides
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>A mapping of country codes to a list of pool IDs (ordered by their failover priority) for the given country.</summary>
            /// <remarks>
            /// Any country not explicitly defined will fall back to using the corresponding region_pool mapping if it exists else to default_pools.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/data-sources/load_balancers#country_pools DataCloudflareLoadBalancers#country_pools}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "countryPools", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}},\"kind\":\"map\"}}]}}", isOptional: true)]
            public object? CountryPools
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Enterprise only: A mapping of Cloudflare PoP identifiers to a list of pool IDs (ordered by their failover priority) for the PoP (datacenter).</summary>
            /// <remarks>
            /// Any PoPs not explicitly defined will fall back to using the corresponding country_pool, then region_pool mapping if it exists else to default_pools.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/data-sources/load_balancers#pop_pools DataCloudflareLoadBalancers#pop_pools}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "popPools", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}},\"kind\":\"map\"}}]}}", isOptional: true)]
            public object? PopPools
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>A mapping of region codes to a list of pool IDs (ordered by their failover priority) for the given region.</summary>
            /// <remarks>
            /// Any regions not explicitly defined will fall back to using default_pools.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/data-sources/load_balancers#region_pools DataCloudflareLoadBalancers#region_pools}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "regionPools", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}},\"kind\":\"map\"}}]}}", isOptional: true)]
            public object? RegionPools
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}

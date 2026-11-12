using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.LoadBalancer
{
    [JsiiInterface(nativeType: typeof(ILoadBalancerPoolSetsOverrides), fullyQualifiedName: "cloudflare.loadBalancer.LoadBalancerPoolSetsOverrides")]
    public interface ILoadBalancerPoolSetsOverrides
    {
        /// <summary>The pool ID to use when all other pools are detected as unhealthy.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.29.0/docs/resources/load_balancer#fallback_pool LoadBalancer#fallback_pool}
        /// </remarks>
        [JsiiProperty(name: "fallbackPool", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? FallbackPool
        {
            get
            {
                return null;
            }
        }

        /// <summary>The default weight for pools not listed in `pool_weights`. The declarative alternative to `random_steering.default_weight`; mutually exclusive with `random_steering`.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.29.0/docs/resources/load_balancer#pool_default_weight LoadBalancer#pool_default_weight}
        /// </remarks>
        [JsiiProperty(name: "poolDefaultWeight", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? PoolDefaultWeight
        {
            get
            {
                return null;
            }
        }

        /// <summary>A flat, ordered list of pool IDs to route the matched audience to.</summary>
        /// <remarks>
        /// Replaces the resolved topology with exactly these pools. Mutually exclusive with <c>fixed_response</c>.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.29.0/docs/resources/load_balancer#pools LoadBalancer#pools}
        /// </remarks>
        [JsiiProperty(name: "pools", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? Pools
        {
            get
            {
                return null;
            }
        }

        /// <summary>A mapping of pool IDs to custom weights, relative to the other pools.</summary>
        /// <remarks>
        /// The declarative alternative to <c>random_steering.pool_weights</c>; mutually exclusive with <c>random_steering</c>.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.29.0/docs/resources/load_balancer#pool_weights LoadBalancer#pool_weights}
        /// </remarks>
        [JsiiProperty(name: "poolWeights", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"number\"},\"kind\":\"map\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        System.Collections.Generic.IDictionary<string, double>? PoolWeights
        {
            get
            {
                return null;
            }
        }

        /// <summary>Steering Policy for this load balancer.</summary>
        /// <remarks>
        /// <list type="bullet">
        /// <description><c>"off"</c>: Use <c>default_pools</c>.</description>
        /// <description><c>"geo"</c>: Use <c>region_pools</c>/<c>country_pools</c>/<c>pop_pools</c>. For non-proxied requests, the country for <c>country_pools</c> is determined by <c>location_strategy</c>.</description>
        /// <description><c>"random"</c>: Select a pool randomly.</description>
        /// <description><c>"dynamic_latency"</c>: Use round trip time to select the closest pool in default_pools (requires pool health checks).</description>
        /// <description><c>"proximity"</c>: Use the pools' latitude and longitude to select the closest pool using the Cloudflare PoP location for proxied requests or the location determined by <c>location_strategy</c> for non-proxied requests.</description>
        /// <description><c>"least_outstanding_requests"</c>: Select a pool by taking into consideration <c>random_steering</c> weights, as well as each pool's number of outstanding requests. Pools with more pending requests are weighted proportionately less relative to others.</description>
        /// <description><c>"least_connections"</c>: Select a pool by taking into consideration <c>random_steering</c> weights, as well as each pool's number of open connections. Pools with more open connections are weighted proportionately less relative to others. Supported for HTTP/1 and HTTP/2 connections.</description>
        /// <description><c>""</c>: Will map to <c>"geo"</c> if you use <c>region_pools</c>/<c>country_pools</c>/<c>pop_pools</c> otherwise <c>"off"</c>.
        /// Available values: "off", "geo", "random", "dynamic_latency", "proximity", "least_outstanding_requests", "least_connections", "".</description>
        /// </list>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.29.0/docs/resources/load_balancer#steering_policy LoadBalancer#steering_policy}
        /// </remarks>
        [JsiiProperty(name: "steeringPolicy", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? SteeringPolicy
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ILoadBalancerPoolSetsOverrides), fullyQualifiedName: "cloudflare.loadBalancer.LoadBalancerPoolSetsOverrides")]
        internal sealed class _Proxy : DeputyBase, cloudflare.LoadBalancer.ILoadBalancerPoolSetsOverrides
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>The pool ID to use when all other pools are detected as unhealthy.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.29.0/docs/resources/load_balancer#fallback_pool LoadBalancer#fallback_pool}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "fallbackPool", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? FallbackPool
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>The default weight for pools not listed in `pool_weights`. The declarative alternative to `random_steering.default_weight`; mutually exclusive with `random_steering`.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.29.0/docs/resources/load_balancer#pool_default_weight LoadBalancer#pool_default_weight}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "poolDefaultWeight", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? PoolDefaultWeight
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>A flat, ordered list of pool IDs to route the matched audience to.</summary>
            /// <remarks>
            /// Replaces the resolved topology with exactly these pools. Mutually exclusive with <c>fixed_response</c>.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.29.0/docs/resources/load_balancer#pools LoadBalancer#pools}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "pools", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? Pools
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>A mapping of pool IDs to custom weights, relative to the other pools.</summary>
            /// <remarks>
            /// The declarative alternative to <c>random_steering.pool_weights</c>; mutually exclusive with <c>random_steering</c>.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.29.0/docs/resources/load_balancer#pool_weights LoadBalancer#pool_weights}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "poolWeights", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"number\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, double>? PoolWeights
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, double>?>();
            }

            /// <summary>Steering Policy for this load balancer.</summary>
            /// <remarks>
            /// <list type="bullet">
            /// <description><c>"off"</c>: Use <c>default_pools</c>.</description>
            /// <description><c>"geo"</c>: Use <c>region_pools</c>/<c>country_pools</c>/<c>pop_pools</c>. For non-proxied requests, the country for <c>country_pools</c> is determined by <c>location_strategy</c>.</description>
            /// <description><c>"random"</c>: Select a pool randomly.</description>
            /// <description><c>"dynamic_latency"</c>: Use round trip time to select the closest pool in default_pools (requires pool health checks).</description>
            /// <description><c>"proximity"</c>: Use the pools' latitude and longitude to select the closest pool using the Cloudflare PoP location for proxied requests or the location determined by <c>location_strategy</c> for non-proxied requests.</description>
            /// <description><c>"least_outstanding_requests"</c>: Select a pool by taking into consideration <c>random_steering</c> weights, as well as each pool's number of outstanding requests. Pools with more pending requests are weighted proportionately less relative to others.</description>
            /// <description><c>"least_connections"</c>: Select a pool by taking into consideration <c>random_steering</c> weights, as well as each pool's number of open connections. Pools with more open connections are weighted proportionately less relative to others. Supported for HTTP/1 and HTTP/2 connections.</description>
            /// <description><c>""</c>: Will map to <c>"geo"</c> if you use <c>region_pools</c>/<c>country_pools</c>/<c>pop_pools</c> otherwise <c>"off"</c>.
            /// Available values: "off", "geo", "random", "dynamic_latency", "proximity", "least_outstanding_requests", "least_connections", "".</description>
            /// </list>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.29.0/docs/resources/load_balancer#steering_policy LoadBalancer#steering_policy}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "steeringPolicy", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? SteeringPolicy
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}

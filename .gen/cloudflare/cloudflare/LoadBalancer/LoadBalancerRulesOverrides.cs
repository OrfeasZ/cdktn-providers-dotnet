using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.LoadBalancer
{
    [JsiiByValue(fqn: "cloudflare.loadBalancer.LoadBalancerRulesOverrides")]
    public class LoadBalancerRulesOverrides : cloudflare.LoadBalancer.ILoadBalancerRulesOverrides
    {
        /// <summary>Controls features that modify the routing of requests to pools and origins in response to dynamic conditions, such as during the interval between active health monitoring requests.</summary>
        /// <remarks>
        /// For example, zero-downtime failover occurs immediately when an origin becomes unavailable due to HTTP 521, 522, or 523 response codes. If there is another healthy origin in the same pool, the request is retried once against this alternate origin.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/load_balancer#adaptive_routing LoadBalancer#adaptive_routing}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "adaptiveRouting", typeJson: "{\"fqn\":\"cloudflare.loadBalancer.LoadBalancerRulesOverridesAdaptiveRouting\"}", isOptional: true)]
        public cloudflare.LoadBalancer.ILoadBalancerRulesOverridesAdaptiveRouting? AdaptiveRouting
        {
            get;
            set;
        }

        private object? _countryPools;

        /// <summary>A mapping of country codes to a list of pool IDs (ordered by their failover priority) for the given country.</summary>
        /// <remarks>
        /// Any country not explicitly defined will fall back to using the corresponding region_pool mapping if it exists else to default_pools.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/load_balancer#country_pools LoadBalancer#country_pools}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "countryPools", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}},\"kind\":\"map\"}}]}}", isOptional: true)]
        public object? CountryPools
        {
            get => _countryPools;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case System.Collections.Generic.IDictionary<string, string[]> cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, System.Collections.Generic.IDictionary<string, string[]>; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _countryPools = value;
            }
        }

        /// <summary>A list of pool IDs ordered by their failover priority.</summary>
        /// <remarks>
        /// Pools defined here are used by default, or when region_pools are not configured for a given region.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/load_balancer#default_pools LoadBalancer#default_pools}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "defaultPools", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? DefaultPools
        {
            get;
            set;
        }

        /// <summary>The pool ID to use when all other pools are detected as unhealthy.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/load_balancer#fallback_pool LoadBalancer#fallback_pool}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "fallbackPool", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? FallbackPool
        {
            get;
            set;
        }

        /// <summary>Controls location-based steering for non-proxied requests. See `steering_policy` to learn how steering is affected.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/load_balancer#location_strategy LoadBalancer#location_strategy}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "locationStrategy", typeJson: "{\"fqn\":\"cloudflare.loadBalancer.LoadBalancerRulesOverridesLocationStrategy\"}", isOptional: true)]
        public cloudflare.LoadBalancer.ILoadBalancerRulesOverridesLocationStrategy? LocationStrategy
        {
            get;
            set;
        }

        private object? _popPools;

        /// <summary>Enterprise only: A mapping of Cloudflare PoP identifiers to a list of pool IDs (ordered by their failover priority) for the PoP (datacenter).</summary>
        /// <remarks>
        /// Any PoPs not explicitly defined will fall back to using the corresponding country_pool, then region_pool mapping if it exists else to default_pools.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/load_balancer#pop_pools LoadBalancer#pop_pools}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "popPools", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}},\"kind\":\"map\"}}]}}", isOptional: true)]
        public object? PopPools
        {
            get => _popPools;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case System.Collections.Generic.IDictionary<string, string[]> cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, System.Collections.Generic.IDictionary<string, string[]>; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _popPools = value;
            }
        }

        /// <summary>Configures pool weights.</summary>
        /// <remarks>
        /// <list type="bullet">
        /// <description><c>steering_policy="random"</c>: A random pool is selected with probability proportional to pool weights.</description>
        /// <description><c>steering_policy="least_outstanding_requests"</c>: Use pool weights to scale each pool's outstanding requests.</description>
        /// <description><c>steering_policy="least_connections"</c>: Use pool weights to scale each pool's open connections.</description>
        /// </list>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/load_balancer#random_steering LoadBalancer#random_steering}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "randomSteering", typeJson: "{\"fqn\":\"cloudflare.loadBalancer.LoadBalancerRulesOverridesRandomSteering\"}", isOptional: true)]
        public cloudflare.LoadBalancer.ILoadBalancerRulesOverridesRandomSteering? RandomSteering
        {
            get;
            set;
        }

        private object? _regionPools;

        /// <summary>A mapping of region codes to a list of pool IDs (ordered by their failover priority) for the given region.</summary>
        /// <remarks>
        /// Any regions not explicitly defined will fall back to using default_pools.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/load_balancer#region_pools LoadBalancer#region_pools}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "regionPools", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}},\"kind\":\"map\"}}]}}", isOptional: true)]
        public object? RegionPools
        {
            get => _regionPools;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case System.Collections.Generic.IDictionary<string, string[]> cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, System.Collections.Generic.IDictionary<string, string[]>; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _regionPools = value;
            }
        }

        /// <summary>Specifies the type of session affinity the load balancer should use unless specified as `"none"`.</summary>
        /// <remarks>
        /// The supported types are: - <c>"cookie"</c>: On the first request to a proxied load balancer, a cookie is generated, encoding information of which origin the request will be forwarded to. Subsequent requests, by the same client to the same load balancer, will be sent to the origin server the cookie encodes, for the duration of the cookie and as long as the origin server remains healthy. If the cookie has expired or the origin server is unhealthy, then a new origin server is calculated and used. - <c>"ip_cookie"</c>: Behaves the same as <c>"cookie"</c> except the initial origin selection is stable and based on the client's ip address. - <c>"header"</c>: On the first request to a proxied load balancer, a session key based on the configured HTTP headers (see <c>session_affinity_attributes.headers</c>) is generated, encoding the request headers used for storing in the load balancer session state which origin the request will be forwarded to. Subsequent requests to the load balancer with the same headers will be sent to the same origin server, for the duration of the session and as long as the origin server remains healthy. If the session has been idle for the duration of <c>session_affinity_ttl</c> seconds or the origin server is unhealthy, then a new origin server is calculated and used. See <c>headers</c> in <c>session_affinity_attributes</c> for additional required configuration.
        /// Available values: "none", "cookie", "ip_cookie", "header".
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/load_balancer#session_affinity LoadBalancer#session_affinity}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "sessionAffinity", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? SessionAffinity
        {
            get;
            set;
        }

        /// <summary>Configures attributes for session affinity.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/load_balancer#session_affinity_attributes LoadBalancer#session_affinity_attributes}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "sessionAffinityAttributes", typeJson: "{\"fqn\":\"cloudflare.loadBalancer.LoadBalancerRulesOverridesSessionAffinityAttributes\"}", isOptional: true)]
        public cloudflare.LoadBalancer.ILoadBalancerRulesOverridesSessionAffinityAttributes? SessionAffinityAttributes
        {
            get;
            set;
        }

        /// <summary>Time, in seconds, until a client's session expires after being created.</summary>
        /// <remarks>
        /// Once the expiry time has been reached, subsequent requests may get sent to a different origin server. The accepted ranges per <c>session_affinity</c> policy are: - <c>"cookie"</c> / <c>"ip_cookie"</c>: The current default of 23 hours will be used unless explicitly set. The accepted range of values is between [1800, 604800]. - <c>"header"</c>: The current default of 1800 seconds will be used unless explicitly set. The accepted range of values is between [30, 3600]. Note: With session affinity by header, sessions only expire after they haven't been used for the number of seconds specified.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/load_balancer#session_affinity_ttl LoadBalancer#session_affinity_ttl}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "sessionAffinityTtl", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? SessionAffinityTtl
        {
            get;
            set;
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
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/load_balancer#steering_policy LoadBalancer#steering_policy}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "steeringPolicy", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? SteeringPolicy
        {
            get;
            set;
        }

        /// <summary>Time to live (TTL) of the DNS entry for the IP address returned by this load balancer.</summary>
        /// <remarks>
        /// This only applies to gray-clouded (unproxied) load balancers.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/load_balancer#ttl LoadBalancer#ttl}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "ttl", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? Ttl
        {
            get;
            set;
        }
    }
}

using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.LoadBalancer
{
    [JsiiByValue(fqn: "cloudflare.loadBalancer.LoadBalancerRulesOverridesLocationStrategy")]
    public class LoadBalancerRulesOverridesLocationStrategy : cloudflare.LoadBalancer.ILoadBalancerRulesOverridesLocationStrategy
    {
        /// <summary>Determines the authoritative location when ECS is not preferred, does not exist in the request, or its GeoIP lookup is unsuccessful.</summary>
        /// <remarks>
        /// <list type="bullet">
        /// <description><c>"pop"</c>: Use the Cloudflare PoP location.</description>
        /// <description><c>"resolver_ip"</c>: Use the DNS resolver GeoIP location. If the GeoIP lookup is unsuccessful, use the Cloudflare PoP location.
        /// Available values: "pop", "resolver_ip".</description>
        /// </list>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/load_balancer#mode LoadBalancer#mode}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "mode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Mode
        {
            get;
            set;
        }

        /// <summary>Whether the EDNS Client Subnet (ECS) GeoIP should be preferred as the authoritative location.</summary>
        /// <remarks>
        /// <list type="bullet">
        /// <description><c>"always"</c>: Always prefer ECS.</description>
        /// <description><c>"never"</c>: Never prefer ECS.</description>
        /// <description><c>"proximity"</c>: Prefer ECS only when <c>steering_policy="proximity"</c>.</description>
        /// <description><c>"geo"</c>: Prefer ECS only when <c>steering_policy="geo"</c>.
        /// Available values: "always", "never", "proximity", "geo".</description>
        /// </list>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/load_balancer#prefer_ecs LoadBalancer#prefer_ecs}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "preferEcs", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? PreferEcs
        {
            get;
            set;
        }
    }
}

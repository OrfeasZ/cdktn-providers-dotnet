using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.LoadBalancer
{
    [JsiiByValue(fqn: "cloudflare.loadBalancer.LoadBalancerRulesOverridesRandomSteering")]
    public class LoadBalancerRulesOverridesRandomSteering : cloudflare.LoadBalancer.ILoadBalancerRulesOverridesRandomSteering
    {
        /// <summary>The default weight for pools in the load balancer that are not specified in the pool_weights map.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/load_balancer#default_weight LoadBalancer#default_weight}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "defaultWeight", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? DefaultWeight
        {
            get;
            set;
        }

        /// <summary>A mapping of pool IDs to custom weights. The weight is relative to other pools in the load balancer.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/load_balancer#pool_weights LoadBalancer#pool_weights}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "poolWeights", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"number\"},\"kind\":\"map\"}}", isOptional: true)]
        public System.Collections.Generic.IDictionary<string, double>? PoolWeights
        {
            get;
            set;
        }
    }
}

using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.DataCloudflareLoadBalancers
{
    [JsiiByValue(fqn: "cloudflare.dataCloudflareLoadBalancers.DataCloudflareLoadBalancersResultRulesOverridesSessionAffinityAttributes")]
    public class DataCloudflareLoadBalancersResultRulesOverridesSessionAffinityAttributes : cloudflare.DataCloudflareLoadBalancers.IDataCloudflareLoadBalancersResultRulesOverridesSessionAffinityAttributes
    {
        /// <summary>Configures the drain duration in seconds.</summary>
        /// <remarks>
        /// This field is only used when session affinity is enabled on the load balancer.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/data-sources/load_balancers#drain_duration DataCloudflareLoadBalancers#drain_duration}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "drainDuration", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? DrainDuration
        {
            get;
            set;
        }
    }
}

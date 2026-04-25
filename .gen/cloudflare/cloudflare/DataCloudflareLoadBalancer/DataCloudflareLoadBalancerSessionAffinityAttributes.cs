using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.DataCloudflareLoadBalancer
{
    [JsiiByValue(fqn: "cloudflare.dataCloudflareLoadBalancer.DataCloudflareLoadBalancerSessionAffinityAttributes")]
    public class DataCloudflareLoadBalancerSessionAffinityAttributes : cloudflare.DataCloudflareLoadBalancer.IDataCloudflareLoadBalancerSessionAffinityAttributes
    {
        /// <summary>Configures the drain duration in seconds.</summary>
        /// <remarks>
        /// This field is only used when session affinity is enabled on the load balancer.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/data-sources/load_balancer#drain_duration DataCloudflareLoadBalancer#drain_duration}
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

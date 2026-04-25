using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.DataCloudflareLoadBalancerPool
{
    [JsiiByValue(fqn: "cloudflare.dataCloudflareLoadBalancerPool.DataCloudflareLoadBalancerPoolFilter")]
    public class DataCloudflareLoadBalancerPoolFilter : cloudflare.DataCloudflareLoadBalancerPool.IDataCloudflareLoadBalancerPoolFilter
    {
        /// <summary>The ID of the Monitor to use for checking the health of origins within this pool.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/data-sources/load_balancer_pool#monitor DataCloudflareLoadBalancerPool#monitor}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "monitor", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Monitor
        {
            get;
            set;
        }
    }
}

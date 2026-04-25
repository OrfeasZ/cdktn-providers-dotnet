using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.DataCloudflareLoadBalancer
{
    [JsiiInterface(nativeType: typeof(IDataCloudflareLoadBalancerRulesOverridesSessionAffinityAttributes), fullyQualifiedName: "cloudflare.dataCloudflareLoadBalancer.DataCloudflareLoadBalancerRulesOverridesSessionAffinityAttributes")]
    public interface IDataCloudflareLoadBalancerRulesOverridesSessionAffinityAttributes
    {
        /// <summary>Configures the drain duration in seconds.</summary>
        /// <remarks>
        /// This field is only used when session affinity is enabled on the load balancer.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/data-sources/load_balancer#drain_duration DataCloudflareLoadBalancer#drain_duration}
        /// </remarks>
        [JsiiProperty(name: "drainDuration", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? DrainDuration
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataCloudflareLoadBalancerRulesOverridesSessionAffinityAttributes), fullyQualifiedName: "cloudflare.dataCloudflareLoadBalancer.DataCloudflareLoadBalancerRulesOverridesSessionAffinityAttributes")]
        internal sealed class _Proxy : DeputyBase, cloudflare.DataCloudflareLoadBalancer.IDataCloudflareLoadBalancerRulesOverridesSessionAffinityAttributes
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

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
                get => GetInstanceProperty<double?>();
            }
        }
    }
}

using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.DataCloudflareLoadBalancerPool
{
    [JsiiInterface(nativeType: typeof(IDataCloudflareLoadBalancerPoolFilter), fullyQualifiedName: "cloudflare.dataCloudflareLoadBalancerPool.DataCloudflareLoadBalancerPoolFilter")]
    public interface IDataCloudflareLoadBalancerPoolFilter
    {
        /// <summary>The ID of the Monitor to use for checking the health of origins within this pool.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/data-sources/load_balancer_pool#monitor DataCloudflareLoadBalancerPool#monitor}
        /// </remarks>
        [JsiiProperty(name: "monitor", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Monitor
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataCloudflareLoadBalancerPoolFilter), fullyQualifiedName: "cloudflare.dataCloudflareLoadBalancerPool.DataCloudflareLoadBalancerPoolFilter")]
        internal sealed class _Proxy : DeputyBase, cloudflare.DataCloudflareLoadBalancerPool.IDataCloudflareLoadBalancerPoolFilter
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>The ID of the Monitor to use for checking the health of origins within this pool.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/data-sources/load_balancer_pool#monitor DataCloudflareLoadBalancerPool#monitor}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "monitor", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Monitor
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}

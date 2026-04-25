using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.LoadBalancerPool
{
    [JsiiInterface(nativeType: typeof(ILoadBalancerPoolOriginsHeader), fullyQualifiedName: "cloudflare.loadBalancerPool.LoadBalancerPoolOriginsHeader")]
    public interface ILoadBalancerPoolOriginsHeader
    {
        /// <summary>The 'Host' header allows to override the hostname set in the HTTP request.</summary>
        /// <remarks>
        /// Current support is 1 'Host' header override per origin.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/load_balancer_pool#host LoadBalancerPool#host}
        /// </remarks>
        [JsiiProperty(name: "host", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? Host
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ILoadBalancerPoolOriginsHeader), fullyQualifiedName: "cloudflare.loadBalancerPool.LoadBalancerPoolOriginsHeader")]
        internal sealed class _Proxy : DeputyBase, cloudflare.LoadBalancerPool.ILoadBalancerPoolOriginsHeader
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>The 'Host' header allows to override the hostname set in the HTTP request.</summary>
            /// <remarks>
            /// Current support is 1 'Host' header override per origin.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/load_balancer_pool#host LoadBalancerPool#host}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "host", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? Host
            {
                get => GetInstanceProperty<string[]?>();
            }
        }
    }
}

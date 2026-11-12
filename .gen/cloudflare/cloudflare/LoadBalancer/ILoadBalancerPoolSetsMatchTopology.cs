using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.LoadBalancer
{
    [JsiiInterface(nativeType: typeof(ILoadBalancerPoolSetsMatchTopology), fullyQualifiedName: "cloudflare.loadBalancer.LoadBalancerPoolSetsMatchTopology")]
    public interface ILoadBalancerPoolSetsMatchTopology
    {
        /// <summary>A list of ISO 3166-1 alpha-2 country codes. Matches when the request's country is in this list.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.29.0/docs/resources/load_balancer#countries LoadBalancer#countries}
        /// </remarks>
        [JsiiProperty(name: "countries", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? Countries
        {
            get
            {
                return null;
            }
        }

        /// <summary>A list of Cloudflare PoP codes. Matches when the request's PoP is in this list.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.29.0/docs/resources/load_balancer#pops LoadBalancer#pops}
        /// </remarks>
        [JsiiProperty(name: "pops", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? Pops
        {
            get
            {
                return null;
            }
        }

        /// <summary>A list of Cloudflare region codes (e.g. `WNAM`, `ENAM`, `WEU`). Matches when the request's region is in this list.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.29.0/docs/resources/load_balancer#regions LoadBalancer#regions}
        /// </remarks>
        [JsiiProperty(name: "regions", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? Regions
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ILoadBalancerPoolSetsMatchTopology), fullyQualifiedName: "cloudflare.loadBalancer.LoadBalancerPoolSetsMatchTopology")]
        internal sealed class _Proxy : DeputyBase, cloudflare.LoadBalancer.ILoadBalancerPoolSetsMatchTopology
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>A list of ISO 3166-1 alpha-2 country codes. Matches when the request's country is in this list.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.29.0/docs/resources/load_balancer#countries LoadBalancer#countries}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "countries", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? Countries
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>A list of Cloudflare PoP codes. Matches when the request's PoP is in this list.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.29.0/docs/resources/load_balancer#pops LoadBalancer#pops}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "pops", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? Pops
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>A list of Cloudflare region codes (e.g. `WNAM`, `ENAM`, `WEU`). Matches when the request's region is in this list.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.29.0/docs/resources/load_balancer#regions LoadBalancer#regions}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "regions", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? Regions
            {
                get => GetInstanceProperty<string[]?>();
            }
        }
    }
}

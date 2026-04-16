using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace digitalocean.Loadbalancer
{
    [JsiiInterface(nativeType: typeof(ILoadbalancerStickySessions), fullyQualifiedName: "digitalocean.loadbalancer.LoadbalancerStickySessions")]
    public interface ILoadbalancerStickySessions
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/loadbalancer#cookie_name Loadbalancer#cookie_name}.</summary>
        [JsiiProperty(name: "cookieName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? CookieName
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/loadbalancer#cookie_ttl_seconds Loadbalancer#cookie_ttl_seconds}.</summary>
        [JsiiProperty(name: "cookieTtlSeconds", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? CookieTtlSeconds
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/loadbalancer#type Loadbalancer#type}.</summary>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Type
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ILoadbalancerStickySessions), fullyQualifiedName: "digitalocean.loadbalancer.LoadbalancerStickySessions")]
        internal sealed class _Proxy : DeputyBase, digitalocean.Loadbalancer.ILoadbalancerStickySessions
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/loadbalancer#cookie_name Loadbalancer#cookie_name}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "cookieName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? CookieName
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/loadbalancer#cookie_ttl_seconds Loadbalancer#cookie_ttl_seconds}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "cookieTtlSeconds", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? CookieTtlSeconds
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/loadbalancer#type Loadbalancer#type}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Type
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}

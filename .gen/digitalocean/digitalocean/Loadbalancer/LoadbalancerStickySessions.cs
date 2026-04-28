using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace digitalocean.Loadbalancer
{
    [JsiiByValue(fqn: "digitalocean.loadbalancer.LoadbalancerStickySessions")]
    public class LoadbalancerStickySessions : digitalocean.Loadbalancer.ILoadbalancerStickySessions
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/loadbalancer#cookie_name Loadbalancer#cookie_name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "cookieName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? CookieName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/loadbalancer#cookie_ttl_seconds Loadbalancer#cookie_ttl_seconds}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "cookieTtlSeconds", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? CookieTtlSeconds
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/loadbalancer#type Loadbalancer#type}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Type
        {
            get;
            set;
        }
    }
}

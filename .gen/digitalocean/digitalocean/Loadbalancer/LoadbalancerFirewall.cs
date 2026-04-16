using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace digitalocean.Loadbalancer
{
    [JsiiByValue(fqn: "digitalocean.loadbalancer.LoadbalancerFirewall")]
    public class LoadbalancerFirewall : digitalocean.Loadbalancer.ILoadbalancerFirewall
    {
        /// <summary>the rules for ALLOWING traffic to the LB (strings in the form: 'ip:1.2.3.4' or 'cidr:1.2.0.0/16').</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/loadbalancer#allow Loadbalancer#allow}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "allow", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? Allow
        {
            get;
            set;
        }

        /// <summary>the rules for DENYING traffic to the LB (strings in the form: 'ip:1.2.3.4' or 'cidr:1.2.0.0/16').</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/loadbalancer#deny Loadbalancer#deny}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "deny", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? Deny
        {
            get;
            set;
        }
    }
}

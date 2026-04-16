using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace digitalocean.DataDigitaloceanFirewall
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "digitalocean.dataDigitaloceanFirewall.DataDigitaloceanFirewallInboundRule")]
    public class DataDigitaloceanFirewallInboundRule : digitalocean.DataDigitaloceanFirewall.IDataDigitaloceanFirewallInboundRule
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/data-sources/firewall#protocol DataDigitaloceanFirewall#protocol}.</summary>
        [JsiiProperty(name: "protocol", typeJson: "{\"primitive\":\"string\"}")]
        public string Protocol
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/data-sources/firewall#port_range DataDigitaloceanFirewall#port_range}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "portRange", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? PortRange
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/data-sources/firewall#source_addresses DataDigitaloceanFirewall#source_addresses}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "sourceAddresses", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? SourceAddresses
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/data-sources/firewall#source_droplet_ids DataDigitaloceanFirewall#source_droplet_ids}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "sourceDropletIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"number\"},\"kind\":\"array\"}}", isOptional: true)]
        public double[]? SourceDropletIds
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/data-sources/firewall#source_kubernetes_ids DataDigitaloceanFirewall#source_kubernetes_ids}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "sourceKubernetesIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? SourceKubernetesIds
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/data-sources/firewall#source_load_balancer_uids DataDigitaloceanFirewall#source_load_balancer_uids}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "sourceLoadBalancerUids", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? SourceLoadBalancerUids
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/data-sources/firewall#source_tags DataDigitaloceanFirewall#source_tags}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "sourceTags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? SourceTags
        {
            get;
            set;
        }
    }
}

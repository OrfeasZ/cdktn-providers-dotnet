using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace digitalocean.Firewall
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "digitalocean.firewall.FirewallOutboundRule")]
    public class FirewallOutboundRule : digitalocean.Firewall.IFirewallOutboundRule
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/firewall#protocol Firewall#protocol}.</summary>
        [JsiiProperty(name: "protocol", typeJson: "{\"primitive\":\"string\"}")]
        public string Protocol
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/firewall#destination_addresses Firewall#destination_addresses}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "destinationAddresses", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? DestinationAddresses
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/firewall#destination_droplet_ids Firewall#destination_droplet_ids}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "destinationDropletIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"number\"},\"kind\":\"array\"}}", isOptional: true)]
        public double[]? DestinationDropletIds
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/firewall#destination_kubernetes_ids Firewall#destination_kubernetes_ids}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "destinationKubernetesIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? DestinationKubernetesIds
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/firewall#destination_load_balancer_uids Firewall#destination_load_balancer_uids}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "destinationLoadBalancerUids", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? DestinationLoadBalancerUids
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/firewall#destination_tags Firewall#destination_tags}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "destinationTags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? DestinationTags
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/firewall#port_range Firewall#port_range}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "portRange", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? PortRange
        {
            get;
            set;
        }
    }
}

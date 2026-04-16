using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace digitalocean.Firewall
{
    [JsiiInterface(nativeType: typeof(IFirewallOutboundRule), fullyQualifiedName: "digitalocean.firewall.FirewallOutboundRule")]
    public interface IFirewallOutboundRule
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/firewall#protocol Firewall#protocol}.</summary>
        [JsiiProperty(name: "protocol", typeJson: "{\"primitive\":\"string\"}")]
        string Protocol
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/firewall#destination_addresses Firewall#destination_addresses}.</summary>
        [JsiiProperty(name: "destinationAddresses", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? DestinationAddresses
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/firewall#destination_droplet_ids Firewall#destination_droplet_ids}.</summary>
        [JsiiProperty(name: "destinationDropletIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"number\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double[]? DestinationDropletIds
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/firewall#destination_kubernetes_ids Firewall#destination_kubernetes_ids}.</summary>
        [JsiiProperty(name: "destinationKubernetesIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? DestinationKubernetesIds
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/firewall#destination_load_balancer_uids Firewall#destination_load_balancer_uids}.</summary>
        [JsiiProperty(name: "destinationLoadBalancerUids", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? DestinationLoadBalancerUids
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/firewall#destination_tags Firewall#destination_tags}.</summary>
        [JsiiProperty(name: "destinationTags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? DestinationTags
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/firewall#port_range Firewall#port_range}.</summary>
        [JsiiProperty(name: "portRange", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? PortRange
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IFirewallOutboundRule), fullyQualifiedName: "digitalocean.firewall.FirewallOutboundRule")]
        internal sealed class _Proxy : DeputyBase, digitalocean.Firewall.IFirewallOutboundRule
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/firewall#protocol Firewall#protocol}.</summary>
            [JsiiProperty(name: "protocol", typeJson: "{\"primitive\":\"string\"}")]
            public string Protocol
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/firewall#destination_addresses Firewall#destination_addresses}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "destinationAddresses", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? DestinationAddresses
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/firewall#destination_droplet_ids Firewall#destination_droplet_ids}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "destinationDropletIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"number\"},\"kind\":\"array\"}}", isOptional: true)]
            public double[]? DestinationDropletIds
            {
                get => GetInstanceProperty<double[]?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/firewall#destination_kubernetes_ids Firewall#destination_kubernetes_ids}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "destinationKubernetesIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? DestinationKubernetesIds
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/firewall#destination_load_balancer_uids Firewall#destination_load_balancer_uids}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "destinationLoadBalancerUids", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? DestinationLoadBalancerUids
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/firewall#destination_tags Firewall#destination_tags}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "destinationTags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? DestinationTags
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/firewall#port_range Firewall#port_range}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "portRange", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? PortRange
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}

using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace digitalocean.Firewall
{
    [JsiiInterface(nativeType: typeof(IFirewallInboundRule), fullyQualifiedName: "digitalocean.firewall.FirewallInboundRule")]
    public interface IFirewallInboundRule
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/firewall#protocol Firewall#protocol}.</summary>
        [JsiiProperty(name: "protocol", typeJson: "{\"primitive\":\"string\"}")]
        string Protocol
        {
            get;
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

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/firewall#source_addresses Firewall#source_addresses}.</summary>
        [JsiiProperty(name: "sourceAddresses", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? SourceAddresses
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/firewall#source_droplet_ids Firewall#source_droplet_ids}.</summary>
        [JsiiProperty(name: "sourceDropletIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"number\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double[]? SourceDropletIds
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/firewall#source_kubernetes_ids Firewall#source_kubernetes_ids}.</summary>
        [JsiiProperty(name: "sourceKubernetesIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? SourceKubernetesIds
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/firewall#source_load_balancer_uids Firewall#source_load_balancer_uids}.</summary>
        [JsiiProperty(name: "sourceLoadBalancerUids", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? SourceLoadBalancerUids
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/firewall#source_tags Firewall#source_tags}.</summary>
        [JsiiProperty(name: "sourceTags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? SourceTags
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IFirewallInboundRule), fullyQualifiedName: "digitalocean.firewall.FirewallInboundRule")]
        internal sealed class _Proxy : DeputyBase, digitalocean.Firewall.IFirewallInboundRule
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

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/firewall#port_range Firewall#port_range}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "portRange", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? PortRange
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/firewall#source_addresses Firewall#source_addresses}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "sourceAddresses", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? SourceAddresses
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/firewall#source_droplet_ids Firewall#source_droplet_ids}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "sourceDropletIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"number\"},\"kind\":\"array\"}}", isOptional: true)]
            public double[]? SourceDropletIds
            {
                get => GetInstanceProperty<double[]?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/firewall#source_kubernetes_ids Firewall#source_kubernetes_ids}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "sourceKubernetesIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? SourceKubernetesIds
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/firewall#source_load_balancer_uids Firewall#source_load_balancer_uids}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "sourceLoadBalancerUids", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? SourceLoadBalancerUids
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/firewall#source_tags Firewall#source_tags}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "sourceTags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? SourceTags
            {
                get => GetInstanceProperty<string[]?>();
            }
        }
    }
}

using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.MagicTransitSiteLan
{
    [JsiiInterface(nativeType: typeof(IMagicTransitSiteLanStaticAddressing), fullyQualifiedName: "cloudflare.magicTransitSiteLan.MagicTransitSiteLanStaticAddressing")]
    public interface IMagicTransitSiteLanStaticAddressing
    {
        /// <summary>A valid CIDR notation representing an IP range.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/magic_transit_site_lan#address MagicTransitSiteLan#address}
        /// </remarks>
        [JsiiProperty(name: "address", typeJson: "{\"primitive\":\"string\"}")]
        string Address
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/magic_transit_site_lan#dhcp_relay MagicTransitSiteLan#dhcp_relay}.</summary>
        [JsiiProperty(name: "dhcpRelay", typeJson: "{\"fqn\":\"cloudflare.magicTransitSiteLan.MagicTransitSiteLanStaticAddressingDhcpRelay\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        cloudflare.MagicTransitSiteLan.IMagicTransitSiteLanStaticAddressingDhcpRelay? DhcpRelay
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/magic_transit_site_lan#dhcp_server MagicTransitSiteLan#dhcp_server}.</summary>
        [JsiiProperty(name: "dhcpServer", typeJson: "{\"fqn\":\"cloudflare.magicTransitSiteLan.MagicTransitSiteLanStaticAddressingDhcpServer\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        cloudflare.MagicTransitSiteLan.IMagicTransitSiteLanStaticAddressingDhcpServer? DhcpServer
        {
            get
            {
                return null;
            }
        }

        /// <summary>A valid CIDR notation representing an IP range.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/magic_transit_site_lan#secondary_address MagicTransitSiteLan#secondary_address}
        /// </remarks>
        [JsiiProperty(name: "secondaryAddress", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? SecondaryAddress
        {
            get
            {
                return null;
            }
        }

        /// <summary>A valid CIDR notation representing an IP range.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/magic_transit_site_lan#virtual_address MagicTransitSiteLan#virtual_address}
        /// </remarks>
        [JsiiProperty(name: "virtualAddress", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? VirtualAddress
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IMagicTransitSiteLanStaticAddressing), fullyQualifiedName: "cloudflare.magicTransitSiteLan.MagicTransitSiteLanStaticAddressing")]
        internal sealed class _Proxy : DeputyBase, cloudflare.MagicTransitSiteLan.IMagicTransitSiteLanStaticAddressing
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>A valid CIDR notation representing an IP range.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/magic_transit_site_lan#address MagicTransitSiteLan#address}
            /// </remarks>
            [JsiiProperty(name: "address", typeJson: "{\"primitive\":\"string\"}")]
            public string Address
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/magic_transit_site_lan#dhcp_relay MagicTransitSiteLan#dhcp_relay}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "dhcpRelay", typeJson: "{\"fqn\":\"cloudflare.magicTransitSiteLan.MagicTransitSiteLanStaticAddressingDhcpRelay\"}", isOptional: true)]
            public cloudflare.MagicTransitSiteLan.IMagicTransitSiteLanStaticAddressingDhcpRelay? DhcpRelay
            {
                get => GetInstanceProperty<cloudflare.MagicTransitSiteLan.IMagicTransitSiteLanStaticAddressingDhcpRelay?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/magic_transit_site_lan#dhcp_server MagicTransitSiteLan#dhcp_server}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "dhcpServer", typeJson: "{\"fqn\":\"cloudflare.magicTransitSiteLan.MagicTransitSiteLanStaticAddressingDhcpServer\"}", isOptional: true)]
            public cloudflare.MagicTransitSiteLan.IMagicTransitSiteLanStaticAddressingDhcpServer? DhcpServer
            {
                get => GetInstanceProperty<cloudflare.MagicTransitSiteLan.IMagicTransitSiteLanStaticAddressingDhcpServer?>();
            }

            /// <summary>A valid CIDR notation representing an IP range.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/magic_transit_site_lan#secondary_address MagicTransitSiteLan#secondary_address}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "secondaryAddress", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? SecondaryAddress
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>A valid CIDR notation representing an IP range.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/magic_transit_site_lan#virtual_address MagicTransitSiteLan#virtual_address}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "virtualAddress", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? VirtualAddress
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}

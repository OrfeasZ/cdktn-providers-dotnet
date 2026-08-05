using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.MagicTransitSiteLan
{
    [JsiiByValue(fqn: "cloudflare.magicTransitSiteLan.MagicTransitSiteLanStaticAddressingDhcpServer")]
    public class MagicTransitSiteLanStaticAddressingDhcpServer : cloudflare.MagicTransitSiteLan.IMagicTransitSiteLanStaticAddressingDhcpServer
    {
        private object? _dhcpOptions;

        /// <summary>Optional list of custom DHCP options to include in DHCP responses. Only valid when DHCP server is enabled.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.23.0/docs/resources/magic_transit_site_lan#dhcp_options MagicTransitSiteLan#dhcp_options}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="cloudflare.MagicTransitSiteLan.IMagicTransitSiteLanStaticAddressingDhcpServerDhcpOptions" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "dhcpOptions", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"cloudflare.magicTransitSiteLan.MagicTransitSiteLanStaticAddressingDhcpServerDhcpOptions\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? DhcpOptions
        {
            get => _dhcpOptions;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case cloudflare.MagicTransitSiteLan.IMagicTransitSiteLanStaticAddressingDhcpServerDhcpOptions[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(cloudflare.MagicTransitSiteLan.IMagicTransitSiteLanStaticAddressingDhcpServerDhcpOptions).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _dhcpOptions = value;
            }
        }

        /// <summary>A valid IPv4 address.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.23.0/docs/resources/magic_transit_site_lan#dhcp_pool_end MagicTransitSiteLan#dhcp_pool_end}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "dhcpPoolEnd", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? DhcpPoolEnd
        {
            get;
            set;
        }

        /// <summary>A valid IPv4 address.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.23.0/docs/resources/magic_transit_site_lan#dhcp_pool_start MagicTransitSiteLan#dhcp_pool_start}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "dhcpPoolStart", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? DhcpPoolStart
        {
            get;
            set;
        }

        /// <summary>A valid IPv4 address.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.23.0/docs/resources/magic_transit_site_lan#dns_server MagicTransitSiteLan#dns_server}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "dnsServer", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? DnsServer
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.23.0/docs/resources/magic_transit_site_lan#dns_servers MagicTransitSiteLan#dns_servers}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "dnsServers", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? DnsServers
        {
            get;
            set;
        }

        /// <summary>Mapping of MAC addresses to IP addresses.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.23.0/docs/resources/magic_transit_site_lan#reservations MagicTransitSiteLan#reservations}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "reservations", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public System.Collections.Generic.IDictionary<string, string>? Reservations
        {
            get;
            set;
        }
    }
}

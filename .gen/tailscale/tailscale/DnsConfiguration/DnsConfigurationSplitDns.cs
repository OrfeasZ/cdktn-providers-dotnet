using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace tailscale.DnsConfiguration
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "tailscale.dnsConfiguration.DnsConfigurationSplitDns")]
    public class DnsConfigurationSplitDns : tailscale.DnsConfiguration.IDnsConfigurationSplitDns
    {
        /// <summary>The nameservers will be used only for this domain.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/tailscale/tailscale/0.29.2/docs/resources/dns_configuration#domain DnsConfiguration#domain}
        /// </remarks>
        [JsiiProperty(name: "domain", typeJson: "{\"primitive\":\"string\"}")]
        public string Domain
        {
            get;
            set;
        }

        private object? _nameservers;

        /// <summary>nameservers block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/tailscale/tailscale/0.29.2/docs/resources/dns_configuration#nameservers DnsConfiguration#nameservers}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "nameservers", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"tailscale.dnsConfiguration.DnsConfigurationSplitDnsNameservers\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? Nameservers
        {
            get => _nameservers;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case tailscale.DnsConfiguration.IDnsConfigurationSplitDnsNameservers[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(tailscale.DnsConfiguration.IDnsConfigurationSplitDnsNameservers).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _nameservers = value;
            }
        }
    }
}

using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace tailscale.DnsConfiguration
{
    [JsiiInterface(nativeType: typeof(IDnsConfigurationSplitDns), fullyQualifiedName: "tailscale.dnsConfiguration.DnsConfigurationSplitDns")]
    public interface IDnsConfigurationSplitDns
    {
        /// <summary>The nameservers will be used only for this domain.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/tailscale/tailscale/0.29.2/docs/resources/dns_configuration#domain DnsConfiguration#domain}
        /// </remarks>
        [JsiiProperty(name: "domain", typeJson: "{\"primitive\":\"string\"}")]
        string Domain
        {
            get;
        }

        /// <summary>nameservers block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/tailscale/tailscale/0.29.2/docs/resources/dns_configuration#nameservers DnsConfiguration#nameservers}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="tailscale.DnsConfiguration.IDnsConfigurationSplitDnsNameservers" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "nameservers", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"tailscale.dnsConfiguration.DnsConfigurationSplitDnsNameservers\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Nameservers
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDnsConfigurationSplitDns), fullyQualifiedName: "tailscale.dnsConfiguration.DnsConfigurationSplitDns")]
        internal sealed class _Proxy : DeputyBase, tailscale.DnsConfiguration.IDnsConfigurationSplitDns
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>The nameservers will be used only for this domain.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/tailscale/tailscale/0.29.2/docs/resources/dns_configuration#domain DnsConfiguration#domain}
            /// </remarks>
            [JsiiProperty(name: "domain", typeJson: "{\"primitive\":\"string\"}")]
            public string Domain
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>nameservers block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/tailscale/tailscale/0.29.2/docs/resources/dns_configuration#nameservers DnsConfiguration#nameservers}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="tailscale.DnsConfiguration.IDnsConfigurationSplitDnsNameservers" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "nameservers", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"tailscale.dnsConfiguration.DnsConfigurationSplitDnsNameservers\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Nameservers
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}

using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace tailscale.DnsConfiguration
{
    [JsiiInterface(nativeType: typeof(IDnsConfigurationSplitDnsNameservers), fullyQualifiedName: "tailscale.dnsConfiguration.DnsConfigurationSplitDnsNameservers")]
    public interface IDnsConfigurationSplitDnsNameservers
    {
        /// <summary>The nameserver's IPv4 or IPv6 address.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/tailscale/tailscale/0.29.2/docs/resources/dns_configuration#address DnsConfiguration#address}
        /// </remarks>
        [JsiiProperty(name: "address", typeJson: "{\"primitive\":\"string\"}")]
        string Address
        {
            get;
        }

        /// <summary>This nameserver will continue to be used when an exit node is selected (requires Tailscale v1.88.1 or later). Defaults to false.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/tailscale/tailscale/0.29.2/docs/resources/dns_configuration#use_with_exit_node DnsConfiguration#use_with_exit_node}
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "useWithExitNode", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? UseWithExitNode
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDnsConfigurationSplitDnsNameservers), fullyQualifiedName: "tailscale.dnsConfiguration.DnsConfigurationSplitDnsNameservers")]
        internal sealed class _Proxy : DeputyBase, tailscale.DnsConfiguration.IDnsConfigurationSplitDnsNameservers
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>The nameserver's IPv4 or IPv6 address.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/tailscale/tailscale/0.29.2/docs/resources/dns_configuration#address DnsConfiguration#address}
            /// </remarks>
            [JsiiProperty(name: "address", typeJson: "{\"primitive\":\"string\"}")]
            public string Address
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>This nameserver will continue to be used when an exit node is selected (requires Tailscale v1.88.1 or later). Defaults to false.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/tailscale/tailscale/0.29.2/docs/resources/dns_configuration#use_with_exit_node DnsConfiguration#use_with_exit_node}
            /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "useWithExitNode", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? UseWithExitNode
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}

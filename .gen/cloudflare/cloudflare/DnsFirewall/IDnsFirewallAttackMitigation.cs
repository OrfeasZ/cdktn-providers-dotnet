using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.DnsFirewall
{
    [JsiiInterface(nativeType: typeof(IDnsFirewallAttackMitigation), fullyQualifiedName: "cloudflare.dnsFirewall.DnsFirewallAttackMitigation")]
    public interface IDnsFirewallAttackMitigation
    {
        /// <summary>When enabled, automatically mitigate random-prefix attacks to protect upstream DNS servers.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/dns_firewall#enabled DnsFirewall#enabled}
        /// </remarks>
        [JsiiProperty(name: "enabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Enabled
        {
            get
            {
                return null;
            }
        }

        /// <summary>Only mitigate attacks when upstream servers seem unhealthy.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/dns_firewall#only_when_upstream_unhealthy DnsFirewall#only_when_upstream_unhealthy}
        /// </remarks>
        [JsiiProperty(name: "onlyWhenUpstreamUnhealthy", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? OnlyWhenUpstreamUnhealthy
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDnsFirewallAttackMitigation), fullyQualifiedName: "cloudflare.dnsFirewall.DnsFirewallAttackMitigation")]
        internal sealed class _Proxy : DeputyBase, cloudflare.DnsFirewall.IDnsFirewallAttackMitigation
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>When enabled, automatically mitigate random-prefix attacks to protect upstream DNS servers.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/dns_firewall#enabled DnsFirewall#enabled}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "enabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? Enabled
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Only mitigate attacks when upstream servers seem unhealthy.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/dns_firewall#only_when_upstream_unhealthy DnsFirewall#only_when_upstream_unhealthy}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "onlyWhenUpstreamUnhealthy", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? OnlyWhenUpstreamUnhealthy
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}

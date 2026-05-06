using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.NetworkFirewallNetworkFirewall
{
    [JsiiInterface(nativeType: typeof(INetworkFirewallNetworkFirewallNatConfiguration), fullyQualifiedName: "oci.networkFirewallNetworkFirewall.NetworkFirewallNetworkFirewallNatConfiguration")]
    public interface INetworkFirewallNetworkFirewallNatConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/network_firewall_network_firewall#must_enable_private_nat NetworkFirewallNetworkFirewall#must_enable_private_nat}.</summary>
        [JsiiProperty(name: "mustEnablePrivateNat", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        object MustEnablePrivateNat
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(INetworkFirewallNetworkFirewallNatConfiguration), fullyQualifiedName: "oci.networkFirewallNetworkFirewall.NetworkFirewallNetworkFirewallNatConfiguration")]
        internal sealed class _Proxy : DeputyBase, oci.NetworkFirewallNetworkFirewall.INetworkFirewallNetworkFirewallNatConfiguration
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/network_firewall_network_firewall#must_enable_private_nat NetworkFirewallNetworkFirewall#must_enable_private_nat}.</summary>
            [JsiiProperty(name: "mustEnablePrivateNat", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
            public object MustEnablePrivateNat
            {
                get => GetInstanceProperty<object>()!;
            }
        }
    }
}

using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.NetworkFirewallNetworkFirewallPolicyService
{
    [JsiiInterface(nativeType: typeof(INetworkFirewallNetworkFirewallPolicyServicePortRanges), fullyQualifiedName: "oci.networkFirewallNetworkFirewallPolicyService.NetworkFirewallNetworkFirewallPolicyServicePortRanges")]
    public interface INetworkFirewallNetworkFirewallPolicyServicePortRanges
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/network_firewall_network_firewall_policy_service#minimum_port NetworkFirewallNetworkFirewallPolicyService#minimum_port}.</summary>
        [JsiiProperty(name: "minimumPort", typeJson: "{\"primitive\":\"number\"}")]
        double MinimumPort
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/network_firewall_network_firewall_policy_service#maximum_port NetworkFirewallNetworkFirewallPolicyService#maximum_port}.</summary>
        [JsiiProperty(name: "maximumPort", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? MaximumPort
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(INetworkFirewallNetworkFirewallPolicyServicePortRanges), fullyQualifiedName: "oci.networkFirewallNetworkFirewallPolicyService.NetworkFirewallNetworkFirewallPolicyServicePortRanges")]
        internal sealed class _Proxy : DeputyBase, oci.NetworkFirewallNetworkFirewallPolicyService.INetworkFirewallNetworkFirewallPolicyServicePortRanges
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/network_firewall_network_firewall_policy_service#minimum_port NetworkFirewallNetworkFirewallPolicyService#minimum_port}.</summary>
            [JsiiProperty(name: "minimumPort", typeJson: "{\"primitive\":\"number\"}")]
            public double MinimumPort
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/network_firewall_network_firewall_policy_service#maximum_port NetworkFirewallNetworkFirewallPolicyService#maximum_port}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "maximumPort", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? MaximumPort
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}

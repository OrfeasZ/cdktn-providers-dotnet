using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.NetworkFirewallNetworkFirewallPolicySecurityRule
{
    [JsiiInterface(nativeType: typeof(INetworkFirewallNetworkFirewallPolicySecurityRuleCondition), fullyQualifiedName: "oci.networkFirewallNetworkFirewallPolicySecurityRule.NetworkFirewallNetworkFirewallPolicySecurityRuleCondition")]
    public interface INetworkFirewallNetworkFirewallPolicySecurityRuleCondition
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/network_firewall_network_firewall_policy_security_rule#application NetworkFirewallNetworkFirewallPolicySecurityRule#application}.</summary>
        [JsiiProperty(name: "application", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? Application
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/network_firewall_network_firewall_policy_security_rule#destination_address NetworkFirewallNetworkFirewallPolicySecurityRule#destination_address}.</summary>
        [JsiiProperty(name: "destinationAddress", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? DestinationAddress
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/network_firewall_network_firewall_policy_security_rule#service NetworkFirewallNetworkFirewallPolicySecurityRule#service}.</summary>
        [JsiiProperty(name: "service", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? Service
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/network_firewall_network_firewall_policy_security_rule#source_address NetworkFirewallNetworkFirewallPolicySecurityRule#source_address}.</summary>
        [JsiiProperty(name: "sourceAddress", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? SourceAddress
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/network_firewall_network_firewall_policy_security_rule#url NetworkFirewallNetworkFirewallPolicySecurityRule#url}.</summary>
        [JsiiProperty(name: "url", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? Url
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(INetworkFirewallNetworkFirewallPolicySecurityRuleCondition), fullyQualifiedName: "oci.networkFirewallNetworkFirewallPolicySecurityRule.NetworkFirewallNetworkFirewallPolicySecurityRuleCondition")]
        internal sealed class _Proxy : DeputyBase, oci.NetworkFirewallNetworkFirewallPolicySecurityRule.INetworkFirewallNetworkFirewallPolicySecurityRuleCondition
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/network_firewall_network_firewall_policy_security_rule#application NetworkFirewallNetworkFirewallPolicySecurityRule#application}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "application", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? Application
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/network_firewall_network_firewall_policy_security_rule#destination_address NetworkFirewallNetworkFirewallPolicySecurityRule#destination_address}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "destinationAddress", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? DestinationAddress
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/network_firewall_network_firewall_policy_security_rule#service NetworkFirewallNetworkFirewallPolicySecurityRule#service}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "service", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? Service
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/network_firewall_network_firewall_policy_security_rule#source_address NetworkFirewallNetworkFirewallPolicySecurityRule#source_address}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "sourceAddress", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? SourceAddress
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/network_firewall_network_firewall_policy_security_rule#url NetworkFirewallNetworkFirewallPolicySecurityRule#url}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "url", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? Url
            {
                get => GetInstanceProperty<string[]?>();
            }
        }
    }
}

using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciNetworkFirewallNetworkFirewallPolicySecurityRules
{
    [JsiiInterface(nativeType: typeof(IDataOciNetworkFirewallNetworkFirewallPolicySecurityRulesFilter), fullyQualifiedName: "oci.dataOciNetworkFirewallNetworkFirewallPolicySecurityRules.DataOciNetworkFirewallNetworkFirewallPolicySecurityRulesFilter")]
    public interface IDataOciNetworkFirewallNetworkFirewallPolicySecurityRulesFilter
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/network_firewall_network_firewall_policy_security_rules#name DataOciNetworkFirewallNetworkFirewallPolicySecurityRules#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/network_firewall_network_firewall_policy_security_rules#values DataOciNetworkFirewallNetworkFirewallPolicySecurityRules#values}.</summary>
        [JsiiProperty(name: "values", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        string[] Values
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/network_firewall_network_firewall_policy_security_rules#regex DataOciNetworkFirewallNetworkFirewallPolicySecurityRules#regex}.</summary>
        [JsiiProperty(name: "regex", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Regex
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataOciNetworkFirewallNetworkFirewallPolicySecurityRulesFilter), fullyQualifiedName: "oci.dataOciNetworkFirewallNetworkFirewallPolicySecurityRules.DataOciNetworkFirewallNetworkFirewallPolicySecurityRulesFilter")]
        internal sealed class _Proxy : DeputyBase, oci.DataOciNetworkFirewallNetworkFirewallPolicySecurityRules.IDataOciNetworkFirewallNetworkFirewallPolicySecurityRulesFilter
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/network_firewall_network_firewall_policy_security_rules#name DataOciNetworkFirewallNetworkFirewallPolicySecurityRules#name}.</summary>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/network_firewall_network_firewall_policy_security_rules#values DataOciNetworkFirewallNetworkFirewallPolicySecurityRules#values}.</summary>
            [JsiiProperty(name: "values", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
            public string[] Values
            {
                get => GetInstanceProperty<string[]>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/network_firewall_network_firewall_policy_security_rules#regex DataOciNetworkFirewallNetworkFirewallPolicySecurityRules#regex}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "regex", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? Regex
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}

using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.NetworkfirewallFirewallPolicy
{
    [JsiiInterface(nativeType: typeof(INetworkfirewallFirewallPolicyFirewallPolicyRoute53ResolvedIpValidation), fullyQualifiedName: "aws.networkfirewallFirewallPolicy.NetworkfirewallFirewallPolicyFirewallPolicyRoute53ResolvedIpValidation")]
    public interface INetworkfirewallFirewallPolicyFirewallPolicyRoute53ResolvedIpValidation
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.71.0/docs/resources/networkfirewall_firewall_policy#action NetworkfirewallFirewallPolicy#action}.</summary>
        [JsiiProperty(name: "action", typeJson: "{\"primitive\":\"string\"}")]
        string Action
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.71.0/docs/resources/networkfirewall_firewall_policy#dns_expiry_exception_policy NetworkfirewallFirewallPolicy#dns_expiry_exception_policy}.</summary>
        [JsiiProperty(name: "dnsExpiryExceptionPolicy", typeJson: "{\"primitive\":\"string\"}")]
        string DnsExpiryExceptionPolicy
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.71.0/docs/resources/networkfirewall_firewall_policy#dns_firewall_rule_group_id NetworkfirewallFirewallPolicy#dns_firewall_rule_group_id}.</summary>
        [JsiiProperty(name: "dnsFirewallRuleGroupId", typeJson: "{\"primitive\":\"string\"}")]
        string DnsFirewallRuleGroupId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.71.0/docs/resources/networkfirewall_firewall_policy#bypass_destination_validation_ip_ranges NetworkfirewallFirewallPolicy#bypass_destination_validation_ip_ranges}.</summary>
        [JsiiProperty(name: "bypassDestinationValidationIpRanges", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? BypassDestinationValidationIpRanges
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.71.0/docs/resources/networkfirewall_firewall_policy#source_ip_ranges NetworkfirewallFirewallPolicy#source_ip_ranges}.</summary>
        [JsiiProperty(name: "sourceIpRanges", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? SourceIpRanges
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(INetworkfirewallFirewallPolicyFirewallPolicyRoute53ResolvedIpValidation), fullyQualifiedName: "aws.networkfirewallFirewallPolicy.NetworkfirewallFirewallPolicyFirewallPolicyRoute53ResolvedIpValidation")]
        internal sealed class _Proxy : DeputyBase, aws.NetworkfirewallFirewallPolicy.INetworkfirewallFirewallPolicyFirewallPolicyRoute53ResolvedIpValidation
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.71.0/docs/resources/networkfirewall_firewall_policy#action NetworkfirewallFirewallPolicy#action}.</summary>
            [JsiiProperty(name: "action", typeJson: "{\"primitive\":\"string\"}")]
            public string Action
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.71.0/docs/resources/networkfirewall_firewall_policy#dns_expiry_exception_policy NetworkfirewallFirewallPolicy#dns_expiry_exception_policy}.</summary>
            [JsiiProperty(name: "dnsExpiryExceptionPolicy", typeJson: "{\"primitive\":\"string\"}")]
            public string DnsExpiryExceptionPolicy
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.71.0/docs/resources/networkfirewall_firewall_policy#dns_firewall_rule_group_id NetworkfirewallFirewallPolicy#dns_firewall_rule_group_id}.</summary>
            [JsiiProperty(name: "dnsFirewallRuleGroupId", typeJson: "{\"primitive\":\"string\"}")]
            public string DnsFirewallRuleGroupId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.71.0/docs/resources/networkfirewall_firewall_policy#bypass_destination_validation_ip_ranges NetworkfirewallFirewallPolicy#bypass_destination_validation_ip_ranges}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "bypassDestinationValidationIpRanges", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? BypassDestinationValidationIpRanges
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.71.0/docs/resources/networkfirewall_firewall_policy#source_ip_ranges NetworkfirewallFirewallPolicy#source_ip_ranges}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "sourceIpRanges", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? SourceIpRanges
            {
                get => GetInstanceProperty<string[]?>();
            }
        }
    }
}

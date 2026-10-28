using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.NetworkfirewallFirewallPolicy
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.networkfirewallFirewallPolicy.NetworkfirewallFirewallPolicyFirewallPolicyRoute53ResolvedIpValidation")]
    public class NetworkfirewallFirewallPolicyFirewallPolicyRoute53ResolvedIpValidation : aws.NetworkfirewallFirewallPolicy.INetworkfirewallFirewallPolicyFirewallPolicyRoute53ResolvedIpValidation
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.71.0/docs/resources/networkfirewall_firewall_policy#action NetworkfirewallFirewallPolicy#action}.</summary>
        [JsiiProperty(name: "action", typeJson: "{\"primitive\":\"string\"}")]
        public string Action
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.71.0/docs/resources/networkfirewall_firewall_policy#dns_expiry_exception_policy NetworkfirewallFirewallPolicy#dns_expiry_exception_policy}.</summary>
        [JsiiProperty(name: "dnsExpiryExceptionPolicy", typeJson: "{\"primitive\":\"string\"}")]
        public string DnsExpiryExceptionPolicy
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.71.0/docs/resources/networkfirewall_firewall_policy#dns_firewall_rule_group_id NetworkfirewallFirewallPolicy#dns_firewall_rule_group_id}.</summary>
        [JsiiProperty(name: "dnsFirewallRuleGroupId", typeJson: "{\"primitive\":\"string\"}")]
        public string DnsFirewallRuleGroupId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.71.0/docs/resources/networkfirewall_firewall_policy#bypass_destination_validation_ip_ranges NetworkfirewallFirewallPolicy#bypass_destination_validation_ip_ranges}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "bypassDestinationValidationIpRanges", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? BypassDestinationValidationIpRanges
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.71.0/docs/resources/networkfirewall_firewall_policy#source_ip_ranges NetworkfirewallFirewallPolicy#source_ip_ranges}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "sourceIpRanges", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? SourceIpRanges
        {
            get;
            set;
        }
    }
}

using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.NetworkfirewallFirewallPolicy
{
    [JsiiInterface(nativeType: typeof(INetworkfirewallFirewallPolicyFirewallPolicyStatefulRuleGroupReference), fullyQualifiedName: "aws.networkfirewallFirewallPolicy.NetworkfirewallFirewallPolicyFirewallPolicyStatefulRuleGroupReference")]
    public interface INetworkfirewallFirewallPolicyFirewallPolicyStatefulRuleGroupReference
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/networkfirewall_firewall_policy#resource_arn NetworkfirewallFirewallPolicy#resource_arn}.</summary>
        [JsiiProperty(name: "resourceArn", typeJson: "{\"primitive\":\"string\"}")]
        string ResourceArn
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/networkfirewall_firewall_policy#deep_threat_inspection NetworkfirewallFirewallPolicy#deep_threat_inspection}.</summary>
        [JsiiProperty(name: "deepThreatInspection", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? DeepThreatInspection
        {
            get
            {
                return null;
            }
        }

        /// <summary>override block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/networkfirewall_firewall_policy#override NetworkfirewallFirewallPolicy#override}
        /// </remarks>
        [JsiiProperty(name: "override", typeJson: "{\"fqn\":\"aws.networkfirewallFirewallPolicy.NetworkfirewallFirewallPolicyFirewallPolicyStatefulRuleGroupReferenceOverride\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.NetworkfirewallFirewallPolicy.INetworkfirewallFirewallPolicyFirewallPolicyStatefulRuleGroupReferenceOverride? Override
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/networkfirewall_firewall_policy#priority NetworkfirewallFirewallPolicy#priority}.</summary>
        [JsiiProperty(name: "priority", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? Priority
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(INetworkfirewallFirewallPolicyFirewallPolicyStatefulRuleGroupReference), fullyQualifiedName: "aws.networkfirewallFirewallPolicy.NetworkfirewallFirewallPolicyFirewallPolicyStatefulRuleGroupReference")]
        internal sealed class _Proxy : DeputyBase, aws.NetworkfirewallFirewallPolicy.INetworkfirewallFirewallPolicyFirewallPolicyStatefulRuleGroupReference
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/networkfirewall_firewall_policy#resource_arn NetworkfirewallFirewallPolicy#resource_arn}.</summary>
            [JsiiProperty(name: "resourceArn", typeJson: "{\"primitive\":\"string\"}")]
            public string ResourceArn
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/networkfirewall_firewall_policy#deep_threat_inspection NetworkfirewallFirewallPolicy#deep_threat_inspection}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "deepThreatInspection", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? DeepThreatInspection
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>override block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/networkfirewall_firewall_policy#override NetworkfirewallFirewallPolicy#override}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "override", typeJson: "{\"fqn\":\"aws.networkfirewallFirewallPolicy.NetworkfirewallFirewallPolicyFirewallPolicyStatefulRuleGroupReferenceOverride\"}", isOptional: true)]
            public aws.NetworkfirewallFirewallPolicy.INetworkfirewallFirewallPolicyFirewallPolicyStatefulRuleGroupReferenceOverride? Override
            {
                get => GetInstanceProperty<aws.NetworkfirewallFirewallPolicy.INetworkfirewallFirewallPolicyFirewallPolicyStatefulRuleGroupReferenceOverride?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/networkfirewall_firewall_policy#priority NetworkfirewallFirewallPolicy#priority}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "priority", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Priority
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}

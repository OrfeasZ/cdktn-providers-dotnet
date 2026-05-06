using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.NetworkFirewallNetworkFirewallPolicyTunnelInspectionRule
{
    [JsiiInterface(nativeType: typeof(INetworkFirewallNetworkFirewallPolicyTunnelInspectionRuleConfig), fullyQualifiedName: "oci.networkFirewallNetworkFirewallPolicyTunnelInspectionRule.NetworkFirewallNetworkFirewallPolicyTunnelInspectionRuleConfig")]
    public interface INetworkFirewallNetworkFirewallPolicyTunnelInspectionRuleConfig : Io.Cdktn.ITerraformMetaArguments
    {
        /// <summary>condition block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/network_firewall_network_firewall_policy_tunnel_inspection_rule#condition NetworkFirewallNetworkFirewallPolicyTunnelInspectionRule#condition}
        /// </remarks>
        [JsiiProperty(name: "condition", typeJson: "{\"fqn\":\"oci.networkFirewallNetworkFirewallPolicyTunnelInspectionRule.NetworkFirewallNetworkFirewallPolicyTunnelInspectionRuleCondition\"}")]
        oci.NetworkFirewallNetworkFirewallPolicyTunnelInspectionRule.INetworkFirewallNetworkFirewallPolicyTunnelInspectionRuleCondition Condition
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/network_firewall_network_firewall_policy_tunnel_inspection_rule#name NetworkFirewallNetworkFirewallPolicyTunnelInspectionRule#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/network_firewall_network_firewall_policy_tunnel_inspection_rule#network_firewall_policy_id NetworkFirewallNetworkFirewallPolicyTunnelInspectionRule#network_firewall_policy_id}.</summary>
        [JsiiProperty(name: "networkFirewallPolicyId", typeJson: "{\"primitive\":\"string\"}")]
        string NetworkFirewallPolicyId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/network_firewall_network_firewall_policy_tunnel_inspection_rule#protocol NetworkFirewallNetworkFirewallPolicyTunnelInspectionRule#protocol}.</summary>
        [JsiiProperty(name: "protocol", typeJson: "{\"primitive\":\"string\"}")]
        string Protocol
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/network_firewall_network_firewall_policy_tunnel_inspection_rule#action NetworkFirewallNetworkFirewallPolicyTunnelInspectionRule#action}.</summary>
        [JsiiProperty(name: "action", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Action
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/network_firewall_network_firewall_policy_tunnel_inspection_rule#id NetworkFirewallNetworkFirewallPolicyTunnelInspectionRule#id}.</summary>
        /// <remarks>
        /// Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2.
        /// If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </remarks>
        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Id
        {
            get
            {
                return null;
            }
        }

        /// <summary>position block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/network_firewall_network_firewall_policy_tunnel_inspection_rule#position NetworkFirewallNetworkFirewallPolicyTunnelInspectionRule#position}
        /// </remarks>
        [JsiiProperty(name: "position", typeJson: "{\"fqn\":\"oci.networkFirewallNetworkFirewallPolicyTunnelInspectionRule.NetworkFirewallNetworkFirewallPolicyTunnelInspectionRulePosition\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.NetworkFirewallNetworkFirewallPolicyTunnelInspectionRule.INetworkFirewallNetworkFirewallPolicyTunnelInspectionRulePosition? Position
        {
            get
            {
                return null;
            }
        }

        /// <summary>profile block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/network_firewall_network_firewall_policy_tunnel_inspection_rule#profile NetworkFirewallNetworkFirewallPolicyTunnelInspectionRule#profile}
        /// </remarks>
        [JsiiProperty(name: "profile", typeJson: "{\"fqn\":\"oci.networkFirewallNetworkFirewallPolicyTunnelInspectionRule.NetworkFirewallNetworkFirewallPolicyTunnelInspectionRuleProfile\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.NetworkFirewallNetworkFirewallPolicyTunnelInspectionRule.INetworkFirewallNetworkFirewallPolicyTunnelInspectionRuleProfile? Profile
        {
            get
            {
                return null;
            }
        }

        /// <summary>timeouts block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/network_firewall_network_firewall_policy_tunnel_inspection_rule#timeouts NetworkFirewallNetworkFirewallPolicyTunnelInspectionRule#timeouts}
        /// </remarks>
        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"oci.networkFirewallNetworkFirewallPolicyTunnelInspectionRule.NetworkFirewallNetworkFirewallPolicyTunnelInspectionRuleTimeouts\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.NetworkFirewallNetworkFirewallPolicyTunnelInspectionRule.INetworkFirewallNetworkFirewallPolicyTunnelInspectionRuleTimeouts? Timeouts
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(INetworkFirewallNetworkFirewallPolicyTunnelInspectionRuleConfig), fullyQualifiedName: "oci.networkFirewallNetworkFirewallPolicyTunnelInspectionRule.NetworkFirewallNetworkFirewallPolicyTunnelInspectionRuleConfig")]
        internal sealed class _Proxy : DeputyBase, oci.NetworkFirewallNetworkFirewallPolicyTunnelInspectionRule.INetworkFirewallNetworkFirewallPolicyTunnelInspectionRuleConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>condition block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/network_firewall_network_firewall_policy_tunnel_inspection_rule#condition NetworkFirewallNetworkFirewallPolicyTunnelInspectionRule#condition}
            /// </remarks>
            [JsiiProperty(name: "condition", typeJson: "{\"fqn\":\"oci.networkFirewallNetworkFirewallPolicyTunnelInspectionRule.NetworkFirewallNetworkFirewallPolicyTunnelInspectionRuleCondition\"}")]
            public oci.NetworkFirewallNetworkFirewallPolicyTunnelInspectionRule.INetworkFirewallNetworkFirewallPolicyTunnelInspectionRuleCondition Condition
            {
                get => GetInstanceProperty<oci.NetworkFirewallNetworkFirewallPolicyTunnelInspectionRule.INetworkFirewallNetworkFirewallPolicyTunnelInspectionRuleCondition>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/network_firewall_network_firewall_policy_tunnel_inspection_rule#name NetworkFirewallNetworkFirewallPolicyTunnelInspectionRule#name}.</summary>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/network_firewall_network_firewall_policy_tunnel_inspection_rule#network_firewall_policy_id NetworkFirewallNetworkFirewallPolicyTunnelInspectionRule#network_firewall_policy_id}.</summary>
            [JsiiProperty(name: "networkFirewallPolicyId", typeJson: "{\"primitive\":\"string\"}")]
            public string NetworkFirewallPolicyId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/network_firewall_network_firewall_policy_tunnel_inspection_rule#protocol NetworkFirewallNetworkFirewallPolicyTunnelInspectionRule#protocol}.</summary>
            [JsiiProperty(name: "protocol", typeJson: "{\"primitive\":\"string\"}")]
            public string Protocol
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/network_firewall_network_firewall_policy_tunnel_inspection_rule#action NetworkFirewallNetworkFirewallPolicyTunnelInspectionRule#action}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "action", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Action
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/network_firewall_network_firewall_policy_tunnel_inspection_rule#id NetworkFirewallNetworkFirewallPolicyTunnelInspectionRule#id}.</summary>
            /// <remarks>
            /// Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2.
            /// If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Id
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>position block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/network_firewall_network_firewall_policy_tunnel_inspection_rule#position NetworkFirewallNetworkFirewallPolicyTunnelInspectionRule#position}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "position", typeJson: "{\"fqn\":\"oci.networkFirewallNetworkFirewallPolicyTunnelInspectionRule.NetworkFirewallNetworkFirewallPolicyTunnelInspectionRulePosition\"}", isOptional: true)]
            public oci.NetworkFirewallNetworkFirewallPolicyTunnelInspectionRule.INetworkFirewallNetworkFirewallPolicyTunnelInspectionRulePosition? Position
            {
                get => GetInstanceProperty<oci.NetworkFirewallNetworkFirewallPolicyTunnelInspectionRule.INetworkFirewallNetworkFirewallPolicyTunnelInspectionRulePosition?>();
            }

            /// <summary>profile block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/network_firewall_network_firewall_policy_tunnel_inspection_rule#profile NetworkFirewallNetworkFirewallPolicyTunnelInspectionRule#profile}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "profile", typeJson: "{\"fqn\":\"oci.networkFirewallNetworkFirewallPolicyTunnelInspectionRule.NetworkFirewallNetworkFirewallPolicyTunnelInspectionRuleProfile\"}", isOptional: true)]
            public oci.NetworkFirewallNetworkFirewallPolicyTunnelInspectionRule.INetworkFirewallNetworkFirewallPolicyTunnelInspectionRuleProfile? Profile
            {
                get => GetInstanceProperty<oci.NetworkFirewallNetworkFirewallPolicyTunnelInspectionRule.INetworkFirewallNetworkFirewallPolicyTunnelInspectionRuleProfile?>();
            }

            /// <summary>timeouts block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/network_firewall_network_firewall_policy_tunnel_inspection_rule#timeouts NetworkFirewallNetworkFirewallPolicyTunnelInspectionRule#timeouts}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"oci.networkFirewallNetworkFirewallPolicyTunnelInspectionRule.NetworkFirewallNetworkFirewallPolicyTunnelInspectionRuleTimeouts\"}", isOptional: true)]
            public oci.NetworkFirewallNetworkFirewallPolicyTunnelInspectionRule.INetworkFirewallNetworkFirewallPolicyTunnelInspectionRuleTimeouts? Timeouts
            {
                get => GetInstanceProperty<oci.NetworkFirewallNetworkFirewallPolicyTunnelInspectionRule.INetworkFirewallNetworkFirewallPolicyTunnelInspectionRuleTimeouts?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "connection", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.SSHProvisionerConnection\"},{\"fqn\":\"cdktn.WinrmProvisionerConnection\"}]}}", isOptional: true)]
            public object? Connection
            {
                get => GetInstanceProperty<object?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "count", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"number\"},{\"fqn\":\"cdktn.TerraformCount\"}]}}", isOptional: true)]
            public object? Count
            {
                get => GetInstanceProperty<object?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "dependsOn", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"cdktn.ITerraformDependable\"},\"kind\":\"array\"}}", isOptional: true)]
            public Io.Cdktn.ITerraformDependable[]? DependsOn
            {
                get => GetInstanceProperty<Io.Cdktn.ITerraformDependable[]?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "forEach", typeJson: "{\"fqn\":\"cdktn.ITerraformIterator\"}", isOptional: true)]
            public Io.Cdktn.ITerraformIterator? ForEach
            {
                get => GetInstanceProperty<Io.Cdktn.ITerraformIterator?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "lifecycle", typeJson: "{\"fqn\":\"cdktn.TerraformResourceLifecycle\"}", isOptional: true)]
            public Io.Cdktn.ITerraformResourceLifecycle? Lifecycle
            {
                get => GetInstanceProperty<Io.Cdktn.ITerraformResourceLifecycle?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "provider", typeJson: "{\"fqn\":\"cdktn.TerraformProvider\"}", isOptional: true)]
            public Io.Cdktn.TerraformProvider? Provider
            {
                get => GetInstanceProperty<Io.Cdktn.TerraformProvider?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "provisioners", typeJson: "{\"collection\":{\"elementtype\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.FileProvisioner\"},{\"fqn\":\"cdktn.LocalExecProvisioner\"},{\"fqn\":\"cdktn.RemoteExecProvisioner\"}]}},\"kind\":\"array\"}}", isOptional: true)]
            public object[]? Provisioners
            {
                get => GetInstanceProperty<object[]?>();
            }
        }
    }
}

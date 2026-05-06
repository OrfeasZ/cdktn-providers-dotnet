using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.NetworkFirewallNetworkFirewallPolicyDecryptionRule
{
    [JsiiInterface(nativeType: typeof(INetworkFirewallNetworkFirewallPolicyDecryptionRuleConfig), fullyQualifiedName: "oci.networkFirewallNetworkFirewallPolicyDecryptionRule.NetworkFirewallNetworkFirewallPolicyDecryptionRuleConfig")]
    public interface INetworkFirewallNetworkFirewallPolicyDecryptionRuleConfig : Io.Cdktn.ITerraformMetaArguments
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/network_firewall_network_firewall_policy_decryption_rule#action NetworkFirewallNetworkFirewallPolicyDecryptionRule#action}.</summary>
        [JsiiProperty(name: "action", typeJson: "{\"primitive\":\"string\"}")]
        string Action
        {
            get;
        }

        /// <summary>condition block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/network_firewall_network_firewall_policy_decryption_rule#condition NetworkFirewallNetworkFirewallPolicyDecryptionRule#condition}
        /// </remarks>
        [JsiiProperty(name: "condition", typeJson: "{\"fqn\":\"oci.networkFirewallNetworkFirewallPolicyDecryptionRule.NetworkFirewallNetworkFirewallPolicyDecryptionRuleCondition\"}")]
        oci.NetworkFirewallNetworkFirewallPolicyDecryptionRule.INetworkFirewallNetworkFirewallPolicyDecryptionRuleCondition Condition
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/network_firewall_network_firewall_policy_decryption_rule#name NetworkFirewallNetworkFirewallPolicyDecryptionRule#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/network_firewall_network_firewall_policy_decryption_rule#network_firewall_policy_id NetworkFirewallNetworkFirewallPolicyDecryptionRule#network_firewall_policy_id}.</summary>
        [JsiiProperty(name: "networkFirewallPolicyId", typeJson: "{\"primitive\":\"string\"}")]
        string NetworkFirewallPolicyId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/network_firewall_network_firewall_policy_decryption_rule#decryption_profile NetworkFirewallNetworkFirewallPolicyDecryptionRule#decryption_profile}.</summary>
        [JsiiProperty(name: "decryptionProfile", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? DecryptionProfile
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/network_firewall_network_firewall_policy_decryption_rule#id NetworkFirewallNetworkFirewallPolicyDecryptionRule#id}.</summary>
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
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/network_firewall_network_firewall_policy_decryption_rule#position NetworkFirewallNetworkFirewallPolicyDecryptionRule#position}
        /// </remarks>
        [JsiiProperty(name: "position", typeJson: "{\"fqn\":\"oci.networkFirewallNetworkFirewallPolicyDecryptionRule.NetworkFirewallNetworkFirewallPolicyDecryptionRulePosition\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.NetworkFirewallNetworkFirewallPolicyDecryptionRule.INetworkFirewallNetworkFirewallPolicyDecryptionRulePosition? Position
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/network_firewall_network_firewall_policy_decryption_rule#priority_order NetworkFirewallNetworkFirewallPolicyDecryptionRule#priority_order}.</summary>
        [JsiiProperty(name: "priorityOrder", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? PriorityOrder
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/network_firewall_network_firewall_policy_decryption_rule#secret NetworkFirewallNetworkFirewallPolicyDecryptionRule#secret}.</summary>
        [JsiiProperty(name: "secret", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Secret
        {
            get
            {
                return null;
            }
        }

        /// <summary>timeouts block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/network_firewall_network_firewall_policy_decryption_rule#timeouts NetworkFirewallNetworkFirewallPolicyDecryptionRule#timeouts}
        /// </remarks>
        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"oci.networkFirewallNetworkFirewallPolicyDecryptionRule.NetworkFirewallNetworkFirewallPolicyDecryptionRuleTimeouts\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.NetworkFirewallNetworkFirewallPolicyDecryptionRule.INetworkFirewallNetworkFirewallPolicyDecryptionRuleTimeouts? Timeouts
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(INetworkFirewallNetworkFirewallPolicyDecryptionRuleConfig), fullyQualifiedName: "oci.networkFirewallNetworkFirewallPolicyDecryptionRule.NetworkFirewallNetworkFirewallPolicyDecryptionRuleConfig")]
        internal sealed class _Proxy : DeputyBase, oci.NetworkFirewallNetworkFirewallPolicyDecryptionRule.INetworkFirewallNetworkFirewallPolicyDecryptionRuleConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/network_firewall_network_firewall_policy_decryption_rule#action NetworkFirewallNetworkFirewallPolicyDecryptionRule#action}.</summary>
            [JsiiProperty(name: "action", typeJson: "{\"primitive\":\"string\"}")]
            public string Action
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>condition block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/network_firewall_network_firewall_policy_decryption_rule#condition NetworkFirewallNetworkFirewallPolicyDecryptionRule#condition}
            /// </remarks>
            [JsiiProperty(name: "condition", typeJson: "{\"fqn\":\"oci.networkFirewallNetworkFirewallPolicyDecryptionRule.NetworkFirewallNetworkFirewallPolicyDecryptionRuleCondition\"}")]
            public oci.NetworkFirewallNetworkFirewallPolicyDecryptionRule.INetworkFirewallNetworkFirewallPolicyDecryptionRuleCondition Condition
            {
                get => GetInstanceProperty<oci.NetworkFirewallNetworkFirewallPolicyDecryptionRule.INetworkFirewallNetworkFirewallPolicyDecryptionRuleCondition>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/network_firewall_network_firewall_policy_decryption_rule#name NetworkFirewallNetworkFirewallPolicyDecryptionRule#name}.</summary>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/network_firewall_network_firewall_policy_decryption_rule#network_firewall_policy_id NetworkFirewallNetworkFirewallPolicyDecryptionRule#network_firewall_policy_id}.</summary>
            [JsiiProperty(name: "networkFirewallPolicyId", typeJson: "{\"primitive\":\"string\"}")]
            public string NetworkFirewallPolicyId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/network_firewall_network_firewall_policy_decryption_rule#decryption_profile NetworkFirewallNetworkFirewallPolicyDecryptionRule#decryption_profile}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "decryptionProfile", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? DecryptionProfile
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/network_firewall_network_firewall_policy_decryption_rule#id NetworkFirewallNetworkFirewallPolicyDecryptionRule#id}.</summary>
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
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/network_firewall_network_firewall_policy_decryption_rule#position NetworkFirewallNetworkFirewallPolicyDecryptionRule#position}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "position", typeJson: "{\"fqn\":\"oci.networkFirewallNetworkFirewallPolicyDecryptionRule.NetworkFirewallNetworkFirewallPolicyDecryptionRulePosition\"}", isOptional: true)]
            public oci.NetworkFirewallNetworkFirewallPolicyDecryptionRule.INetworkFirewallNetworkFirewallPolicyDecryptionRulePosition? Position
            {
                get => GetInstanceProperty<oci.NetworkFirewallNetworkFirewallPolicyDecryptionRule.INetworkFirewallNetworkFirewallPolicyDecryptionRulePosition?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/network_firewall_network_firewall_policy_decryption_rule#priority_order NetworkFirewallNetworkFirewallPolicyDecryptionRule#priority_order}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "priorityOrder", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? PriorityOrder
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/network_firewall_network_firewall_policy_decryption_rule#secret NetworkFirewallNetworkFirewallPolicyDecryptionRule#secret}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "secret", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Secret
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>timeouts block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/network_firewall_network_firewall_policy_decryption_rule#timeouts NetworkFirewallNetworkFirewallPolicyDecryptionRule#timeouts}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"oci.networkFirewallNetworkFirewallPolicyDecryptionRule.NetworkFirewallNetworkFirewallPolicyDecryptionRuleTimeouts\"}", isOptional: true)]
            public oci.NetworkFirewallNetworkFirewallPolicyDecryptionRule.INetworkFirewallNetworkFirewallPolicyDecryptionRuleTimeouts? Timeouts
            {
                get => GetInstanceProperty<oci.NetworkFirewallNetworkFirewallPolicyDecryptionRule.INetworkFirewallNetworkFirewallPolicyDecryptionRuleTimeouts?>();
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

using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.FirewallPolicyRuleCollectionGroup
{
    [JsiiInterface(nativeType: typeof(IFirewallPolicyRuleCollectionGroupConfig), fullyQualifiedName: "azurerm.firewallPolicyRuleCollectionGroup.FirewallPolicyRuleCollectionGroupConfig")]
    public interface IFirewallPolicyRuleCollectionGroupConfig : Io.Cdktn.ITerraformMetaArguments
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/firewall_policy_rule_collection_group#firewall_policy_id FirewallPolicyRuleCollectionGroup#firewall_policy_id}.</summary>
        [JsiiProperty(name: "firewallPolicyId", typeJson: "{\"primitive\":\"string\"}")]
        string FirewallPolicyId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/firewall_policy_rule_collection_group#name FirewallPolicyRuleCollectionGroup#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/firewall_policy_rule_collection_group#priority FirewallPolicyRuleCollectionGroup#priority}.</summary>
        [JsiiProperty(name: "priority", typeJson: "{\"primitive\":\"number\"}")]
        double Priority
        {
            get;
        }

        /// <summary>application_rule_collection block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/firewall_policy_rule_collection_group#application_rule_collection FirewallPolicyRuleCollectionGroup#application_rule_collection}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.FirewallPolicyRuleCollectionGroup.IFirewallPolicyRuleCollectionGroupApplicationRuleCollection" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "applicationRuleCollection", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.firewallPolicyRuleCollectionGroup.FirewallPolicyRuleCollectionGroupApplicationRuleCollection\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? ApplicationRuleCollection
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/firewall_policy_rule_collection_group#id FirewallPolicyRuleCollectionGroup#id}.</summary>
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

        /// <summary>nat_rule_collection block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/firewall_policy_rule_collection_group#nat_rule_collection FirewallPolicyRuleCollectionGroup#nat_rule_collection}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.FirewallPolicyRuleCollectionGroup.IFirewallPolicyRuleCollectionGroupNatRuleCollection" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "natRuleCollection", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.firewallPolicyRuleCollectionGroup.FirewallPolicyRuleCollectionGroupNatRuleCollection\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? NatRuleCollection
        {
            get
            {
                return null;
            }
        }

        /// <summary>network_rule_collection block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/firewall_policy_rule_collection_group#network_rule_collection FirewallPolicyRuleCollectionGroup#network_rule_collection}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.FirewallPolicyRuleCollectionGroup.IFirewallPolicyRuleCollectionGroupNetworkRuleCollection" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "networkRuleCollection", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.firewallPolicyRuleCollectionGroup.FirewallPolicyRuleCollectionGroupNetworkRuleCollection\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? NetworkRuleCollection
        {
            get
            {
                return null;
            }
        }

        /// <summary>timeouts block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/firewall_policy_rule_collection_group#timeouts FirewallPolicyRuleCollectionGroup#timeouts}
        /// </remarks>
        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"azurerm.firewallPolicyRuleCollectionGroup.FirewallPolicyRuleCollectionGroupTimeouts\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.FirewallPolicyRuleCollectionGroup.IFirewallPolicyRuleCollectionGroupTimeouts? Timeouts
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IFirewallPolicyRuleCollectionGroupConfig), fullyQualifiedName: "azurerm.firewallPolicyRuleCollectionGroup.FirewallPolicyRuleCollectionGroupConfig")]
        internal sealed class _Proxy : DeputyBase, azurerm.FirewallPolicyRuleCollectionGroup.IFirewallPolicyRuleCollectionGroupConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/firewall_policy_rule_collection_group#firewall_policy_id FirewallPolicyRuleCollectionGroup#firewall_policy_id}.</summary>
            [JsiiProperty(name: "firewallPolicyId", typeJson: "{\"primitive\":\"string\"}")]
            public string FirewallPolicyId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/firewall_policy_rule_collection_group#name FirewallPolicyRuleCollectionGroup#name}.</summary>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/firewall_policy_rule_collection_group#priority FirewallPolicyRuleCollectionGroup#priority}.</summary>
            [JsiiProperty(name: "priority", typeJson: "{\"primitive\":\"number\"}")]
            public double Priority
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>application_rule_collection block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/firewall_policy_rule_collection_group#application_rule_collection FirewallPolicyRuleCollectionGroup#application_rule_collection}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.FirewallPolicyRuleCollectionGroup.IFirewallPolicyRuleCollectionGroupApplicationRuleCollection" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "applicationRuleCollection", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.firewallPolicyRuleCollectionGroup.FirewallPolicyRuleCollectionGroupApplicationRuleCollection\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? ApplicationRuleCollection
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/firewall_policy_rule_collection_group#id FirewallPolicyRuleCollectionGroup#id}.</summary>
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

            /// <summary>nat_rule_collection block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/firewall_policy_rule_collection_group#nat_rule_collection FirewallPolicyRuleCollectionGroup#nat_rule_collection}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.FirewallPolicyRuleCollectionGroup.IFirewallPolicyRuleCollectionGroupNatRuleCollection" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "natRuleCollection", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.firewallPolicyRuleCollectionGroup.FirewallPolicyRuleCollectionGroupNatRuleCollection\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? NatRuleCollection
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>network_rule_collection block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/firewall_policy_rule_collection_group#network_rule_collection FirewallPolicyRuleCollectionGroup#network_rule_collection}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.FirewallPolicyRuleCollectionGroup.IFirewallPolicyRuleCollectionGroupNetworkRuleCollection" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "networkRuleCollection", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.firewallPolicyRuleCollectionGroup.FirewallPolicyRuleCollectionGroupNetworkRuleCollection\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? NetworkRuleCollection
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>timeouts block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/firewall_policy_rule_collection_group#timeouts FirewallPolicyRuleCollectionGroup#timeouts}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"azurerm.firewallPolicyRuleCollectionGroup.FirewallPolicyRuleCollectionGroupTimeouts\"}", isOptional: true)]
            public azurerm.FirewallPolicyRuleCollectionGroup.IFirewallPolicyRuleCollectionGroupTimeouts? Timeouts
            {
                get => GetInstanceProperty<azurerm.FirewallPolicyRuleCollectionGroup.IFirewallPolicyRuleCollectionGroupTimeouts?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// <para>Type union: either <see cref="Io.Cdktn.ISSHProvisionerConnection" /> or <see cref="Io.Cdktn.IWinrmProvisionerConnection" /></para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "connection", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.SSHProvisionerConnection\"},{\"fqn\":\"cdktn.WinrmProvisionerConnection\"}]}}", isOptional: true)]
            public object? Connection
            {
                get => GetInstanceProperty<object?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// <para>Type union: either double or <see cref="Io.Cdktn.TerraformCount" /></para>
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
            /// <para>Type union: (either <see cref="Io.Cdktn.IFileProvisioner" /> or <see cref="Io.Cdktn.ILocalExecProvisioner" /> or <see cref="Io.Cdktn.IRemoteExecProvisioner" />)[]</para>
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

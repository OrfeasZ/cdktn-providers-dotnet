using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataSafeSubsettingPolicySubsettingRule
{
    [JsiiInterface(nativeType: typeof(IDataSafeSubsettingPolicySubsettingRuleConfig), fullyQualifiedName: "oci.dataSafeSubsettingPolicySubsettingRule.DataSafeSubsettingPolicySubsettingRuleConfig")]
    public interface IDataSafeSubsettingPolicySubsettingRuleConfig : Io.Cdktn.ITerraformMetaArguments
    {
        /// <summary>scope block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.9.0/docs/resources/data_safe_subsetting_policy_subsetting_rule#scope DataSafeSubsettingPolicySubsettingRule#scope}
        /// </remarks>
        [JsiiProperty(name: "scope", typeJson: "{\"fqn\":\"oci.dataSafeSubsettingPolicySubsettingRule.DataSafeSubsettingPolicySubsettingRuleScope\"}")]
        oci.DataSafeSubsettingPolicySubsettingRule.IDataSafeSubsettingPolicySubsettingRuleScope Scope
        {
            get;
        }

        /// <summary>subset_rule_entry block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.9.0/docs/resources/data_safe_subsetting_policy_subsetting_rule#subset_rule_entry DataSafeSubsettingPolicySubsettingRule#subset_rule_entry}
        /// </remarks>
        [JsiiProperty(name: "subsetRuleEntry", typeJson: "{\"fqn\":\"oci.dataSafeSubsettingPolicySubsettingRule.DataSafeSubsettingPolicySubsettingRuleSubsetRuleEntry\"}")]
        oci.DataSafeSubsettingPolicySubsettingRule.IDataSafeSubsettingPolicySubsettingRuleSubsetRuleEntry SubsetRuleEntry
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.9.0/docs/resources/data_safe_subsetting_policy_subsetting_rule#subsetting_policy_id DataSafeSubsettingPolicySubsettingRule#subsetting_policy_id}.</summary>
        [JsiiProperty(name: "subsettingPolicyId", typeJson: "{\"primitive\":\"string\"}")]
        string SubsettingPolicyId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.9.0/docs/resources/data_safe_subsetting_policy_subsetting_rule#description DataSafeSubsettingPolicySubsettingRule#description}.</summary>
        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Description
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.9.0/docs/resources/data_safe_subsetting_policy_subsetting_rule#display_name DataSafeSubsettingPolicySubsettingRule#display_name}.</summary>
        [JsiiProperty(name: "displayName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? DisplayName
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.9.0/docs/resources/data_safe_subsetting_policy_subsetting_rule#id DataSafeSubsettingPolicySubsettingRule#id}.</summary>
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

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.9.0/docs/resources/data_safe_subsetting_policy_subsetting_rule#peer_tables_action DataSafeSubsettingPolicySubsettingRule#peer_tables_action}.</summary>
        [JsiiProperty(name: "peerTablesAction", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? PeerTablesAction
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.9.0/docs/resources/data_safe_subsetting_policy_subsetting_rule#related_tables_propagation DataSafeSubsettingPolicySubsettingRule#related_tables_propagation}.</summary>
        [JsiiProperty(name: "relatedTablesPropagation", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? RelatedTablesPropagation
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.9.0/docs/resources/data_safe_subsetting_policy_subsetting_rule#rule_combination_mode DataSafeSubsettingPolicySubsettingRule#rule_combination_mode}.</summary>
        [JsiiProperty(name: "ruleCombinationMode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? RuleCombinationMode
        {
            get
            {
                return null;
            }
        }

        /// <summary>timeouts block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.9.0/docs/resources/data_safe_subsetting_policy_subsetting_rule#timeouts DataSafeSubsettingPolicySubsettingRule#timeouts}
        /// </remarks>
        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"oci.dataSafeSubsettingPolicySubsettingRule.DataSafeSubsettingPolicySubsettingRuleTimeouts\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.DataSafeSubsettingPolicySubsettingRule.IDataSafeSubsettingPolicySubsettingRuleTimeouts? Timeouts
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataSafeSubsettingPolicySubsettingRuleConfig), fullyQualifiedName: "oci.dataSafeSubsettingPolicySubsettingRule.DataSafeSubsettingPolicySubsettingRuleConfig")]
        internal sealed class _Proxy : DeputyBase, oci.DataSafeSubsettingPolicySubsettingRule.IDataSafeSubsettingPolicySubsettingRuleConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>scope block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.9.0/docs/resources/data_safe_subsetting_policy_subsetting_rule#scope DataSafeSubsettingPolicySubsettingRule#scope}
            /// </remarks>
            [JsiiProperty(name: "scope", typeJson: "{\"fqn\":\"oci.dataSafeSubsettingPolicySubsettingRule.DataSafeSubsettingPolicySubsettingRuleScope\"}")]
            public oci.DataSafeSubsettingPolicySubsettingRule.IDataSafeSubsettingPolicySubsettingRuleScope Scope
            {
                get => GetInstanceProperty<oci.DataSafeSubsettingPolicySubsettingRule.IDataSafeSubsettingPolicySubsettingRuleScope>()!;
            }

            /// <summary>subset_rule_entry block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.9.0/docs/resources/data_safe_subsetting_policy_subsetting_rule#subset_rule_entry DataSafeSubsettingPolicySubsettingRule#subset_rule_entry}
            /// </remarks>
            [JsiiProperty(name: "subsetRuleEntry", typeJson: "{\"fqn\":\"oci.dataSafeSubsettingPolicySubsettingRule.DataSafeSubsettingPolicySubsettingRuleSubsetRuleEntry\"}")]
            public oci.DataSafeSubsettingPolicySubsettingRule.IDataSafeSubsettingPolicySubsettingRuleSubsetRuleEntry SubsetRuleEntry
            {
                get => GetInstanceProperty<oci.DataSafeSubsettingPolicySubsettingRule.IDataSafeSubsettingPolicySubsettingRuleSubsetRuleEntry>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.9.0/docs/resources/data_safe_subsetting_policy_subsetting_rule#subsetting_policy_id DataSafeSubsettingPolicySubsettingRule#subsetting_policy_id}.</summary>
            [JsiiProperty(name: "subsettingPolicyId", typeJson: "{\"primitive\":\"string\"}")]
            public string SubsettingPolicyId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.9.0/docs/resources/data_safe_subsetting_policy_subsetting_rule#description DataSafeSubsettingPolicySubsettingRule#description}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Description
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.9.0/docs/resources/data_safe_subsetting_policy_subsetting_rule#display_name DataSafeSubsettingPolicySubsettingRule#display_name}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "displayName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? DisplayName
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.9.0/docs/resources/data_safe_subsetting_policy_subsetting_rule#id DataSafeSubsettingPolicySubsettingRule#id}.</summary>
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

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.9.0/docs/resources/data_safe_subsetting_policy_subsetting_rule#peer_tables_action DataSafeSubsettingPolicySubsettingRule#peer_tables_action}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "peerTablesAction", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? PeerTablesAction
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.9.0/docs/resources/data_safe_subsetting_policy_subsetting_rule#related_tables_propagation DataSafeSubsettingPolicySubsettingRule#related_tables_propagation}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "relatedTablesPropagation", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? RelatedTablesPropagation
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.9.0/docs/resources/data_safe_subsetting_policy_subsetting_rule#rule_combination_mode DataSafeSubsettingPolicySubsettingRule#rule_combination_mode}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "ruleCombinationMode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? RuleCombinationMode
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>timeouts block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.9.0/docs/resources/data_safe_subsetting_policy_subsetting_rule#timeouts DataSafeSubsettingPolicySubsettingRule#timeouts}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"oci.dataSafeSubsettingPolicySubsettingRule.DataSafeSubsettingPolicySubsettingRuleTimeouts\"}", isOptional: true)]
            public oci.DataSafeSubsettingPolicySubsettingRule.IDataSafeSubsettingPolicySubsettingRuleTimeouts? Timeouts
            {
                get => GetInstanceProperty<oci.DataSafeSubsettingPolicySubsettingRule.IDataSafeSubsettingPolicySubsettingRuleTimeouts?>();
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

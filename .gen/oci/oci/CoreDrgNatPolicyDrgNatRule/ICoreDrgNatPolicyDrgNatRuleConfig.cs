using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.CoreDrgNatPolicyDrgNatRule
{
    [JsiiInterface(nativeType: typeof(ICoreDrgNatPolicyDrgNatRuleConfig), fullyQualifiedName: "oci.coreDrgNatPolicyDrgNatRule.CoreDrgNatPolicyDrgNatRuleConfig")]
    public interface ICoreDrgNatPolicyDrgNatRuleConfig : Io.Cdktn.ITerraformMetaArguments
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.8.0/docs/resources/core_drg_nat_policy_drg_nat_rule#drg_nat_policy_id CoreDrgNatPolicyDrgNatRule#drg_nat_policy_id}.</summary>
        [JsiiProperty(name: "drgNatPolicyId", typeJson: "{\"primitive\":\"string\"}")]
        string DrgNatPolicyId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.8.0/docs/resources/core_drg_nat_policy_drg_nat_rule#drg_nat_rule_priority CoreDrgNatPolicyDrgNatRule#drg_nat_rule_priority}.</summary>
        [JsiiProperty(name: "drgNatRulePriority", typeJson: "{\"primitive\":\"number\"}")]
        double DrgNatRulePriority
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.8.0/docs/resources/core_drg_nat_policy_drg_nat_rule#id CoreDrgNatPolicyDrgNatRule#id}.</summary>
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

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.8.0/docs/resources/core_drg_nat_policy_drg_nat_rule#original_destination CoreDrgNatPolicyDrgNatRule#original_destination}.</summary>
        [JsiiProperty(name: "originalDestination", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? OriginalDestination
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.8.0/docs/resources/core_drg_nat_policy_drg_nat_rule#original_source CoreDrgNatPolicyDrgNatRule#original_source}.</summary>
        [JsiiProperty(name: "originalSource", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? OriginalSource
        {
            get
            {
                return null;
            }
        }

        /// <summary>timeouts block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.8.0/docs/resources/core_drg_nat_policy_drg_nat_rule#timeouts CoreDrgNatPolicyDrgNatRule#timeouts}
        /// </remarks>
        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"oci.coreDrgNatPolicyDrgNatRule.CoreDrgNatPolicyDrgNatRuleTimeouts\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.CoreDrgNatPolicyDrgNatRule.ICoreDrgNatPolicyDrgNatRuleTimeouts? Timeouts
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.8.0/docs/resources/core_drg_nat_policy_drg_nat_rule#translated_destination CoreDrgNatPolicyDrgNatRule#translated_destination}.</summary>
        [JsiiProperty(name: "translatedDestination", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? TranslatedDestination
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.8.0/docs/resources/core_drg_nat_policy_drg_nat_rule#translated_source CoreDrgNatPolicyDrgNatRule#translated_source}.</summary>
        [JsiiProperty(name: "translatedSource", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? TranslatedSource
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ICoreDrgNatPolicyDrgNatRuleConfig), fullyQualifiedName: "oci.coreDrgNatPolicyDrgNatRule.CoreDrgNatPolicyDrgNatRuleConfig")]
        internal sealed class _Proxy : DeputyBase, oci.CoreDrgNatPolicyDrgNatRule.ICoreDrgNatPolicyDrgNatRuleConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.8.0/docs/resources/core_drg_nat_policy_drg_nat_rule#drg_nat_policy_id CoreDrgNatPolicyDrgNatRule#drg_nat_policy_id}.</summary>
            [JsiiProperty(name: "drgNatPolicyId", typeJson: "{\"primitive\":\"string\"}")]
            public string DrgNatPolicyId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.8.0/docs/resources/core_drg_nat_policy_drg_nat_rule#drg_nat_rule_priority CoreDrgNatPolicyDrgNatRule#drg_nat_rule_priority}.</summary>
            [JsiiProperty(name: "drgNatRulePriority", typeJson: "{\"primitive\":\"number\"}")]
            public double DrgNatRulePriority
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.8.0/docs/resources/core_drg_nat_policy_drg_nat_rule#id CoreDrgNatPolicyDrgNatRule#id}.</summary>
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

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.8.0/docs/resources/core_drg_nat_policy_drg_nat_rule#original_destination CoreDrgNatPolicyDrgNatRule#original_destination}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "originalDestination", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? OriginalDestination
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.8.0/docs/resources/core_drg_nat_policy_drg_nat_rule#original_source CoreDrgNatPolicyDrgNatRule#original_source}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "originalSource", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? OriginalSource
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>timeouts block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.8.0/docs/resources/core_drg_nat_policy_drg_nat_rule#timeouts CoreDrgNatPolicyDrgNatRule#timeouts}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"oci.coreDrgNatPolicyDrgNatRule.CoreDrgNatPolicyDrgNatRuleTimeouts\"}", isOptional: true)]
            public oci.CoreDrgNatPolicyDrgNatRule.ICoreDrgNatPolicyDrgNatRuleTimeouts? Timeouts
            {
                get => GetInstanceProperty<oci.CoreDrgNatPolicyDrgNatRule.ICoreDrgNatPolicyDrgNatRuleTimeouts?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.8.0/docs/resources/core_drg_nat_policy_drg_nat_rule#translated_destination CoreDrgNatPolicyDrgNatRule#translated_destination}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "translatedDestination", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? TranslatedDestination
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.8.0/docs/resources/core_drg_nat_policy_drg_nat_rule#translated_source CoreDrgNatPolicyDrgNatRule#translated_source}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "translatedSource", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? TranslatedSource
            {
                get => GetInstanceProperty<string?>();
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

using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataSafeSubsettingPolicySubsettingRuleProcessingChainObject
{
    [JsiiInterface(nativeType: typeof(IDataSafeSubsettingPolicySubsettingRuleProcessingChainObjectConfig), fullyQualifiedName: "oci.dataSafeSubsettingPolicySubsettingRuleProcessingChainObject.DataSafeSubsettingPolicySubsettingRuleProcessingChainObjectConfig")]
    public interface IDataSafeSubsettingPolicySubsettingRuleProcessingChainObjectConfig : Io.Cdktn.ITerraformMetaArguments
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.8.0/docs/resources/data_safe_subsetting_policy_subsetting_rule_processing_chain_object#is_enabled_for_processing DataSafeSubsettingPolicySubsettingRuleProcessingChainObject#is_enabled_for_processing}.</summary>
        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "isEnabledForProcessing", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        object IsEnabledForProcessing
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.8.0/docs/resources/data_safe_subsetting_policy_subsetting_rule_processing_chain_object#processing_chain_object_key DataSafeSubsettingPolicySubsettingRuleProcessingChainObject#processing_chain_object_key}.</summary>
        [JsiiProperty(name: "processingChainObjectKey", typeJson: "{\"primitive\":\"string\"}")]
        string ProcessingChainObjectKey
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.8.0/docs/resources/data_safe_subsetting_policy_subsetting_rule_processing_chain_object#subsetting_policy_id DataSafeSubsettingPolicySubsettingRuleProcessingChainObject#subsetting_policy_id}.</summary>
        [JsiiProperty(name: "subsettingPolicyId", typeJson: "{\"primitive\":\"string\"}")]
        string SubsettingPolicyId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.8.0/docs/resources/data_safe_subsetting_policy_subsetting_rule_processing_chain_object#subsetting_rule_key DataSafeSubsettingPolicySubsettingRuleProcessingChainObject#subsetting_rule_key}.</summary>
        [JsiiProperty(name: "subsettingRuleKey", typeJson: "{\"primitive\":\"string\"}")]
        string SubsettingRuleKey
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.8.0/docs/resources/data_safe_subsetting_policy_subsetting_rule_processing_chain_object#id DataSafeSubsettingPolicySubsettingRuleProcessingChainObject#id}.</summary>
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

        /// <summary>timeouts block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.8.0/docs/resources/data_safe_subsetting_policy_subsetting_rule_processing_chain_object#timeouts DataSafeSubsettingPolicySubsettingRuleProcessingChainObject#timeouts}
        /// </remarks>
        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"oci.dataSafeSubsettingPolicySubsettingRuleProcessingChainObject.DataSafeSubsettingPolicySubsettingRuleProcessingChainObjectTimeouts\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.DataSafeSubsettingPolicySubsettingRuleProcessingChainObject.IDataSafeSubsettingPolicySubsettingRuleProcessingChainObjectTimeouts? Timeouts
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataSafeSubsettingPolicySubsettingRuleProcessingChainObjectConfig), fullyQualifiedName: "oci.dataSafeSubsettingPolicySubsettingRuleProcessingChainObject.DataSafeSubsettingPolicySubsettingRuleProcessingChainObjectConfig")]
        internal sealed class _Proxy : DeputyBase, oci.DataSafeSubsettingPolicySubsettingRuleProcessingChainObject.IDataSafeSubsettingPolicySubsettingRuleProcessingChainObjectConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.8.0/docs/resources/data_safe_subsetting_policy_subsetting_rule_processing_chain_object#is_enabled_for_processing DataSafeSubsettingPolicySubsettingRuleProcessingChainObject#is_enabled_for_processing}.</summary>
            /// <remarks>
            /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
            /// </remarks>
            [JsiiProperty(name: "isEnabledForProcessing", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
            public object IsEnabledForProcessing
            {
                get => GetInstanceProperty<object>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.8.0/docs/resources/data_safe_subsetting_policy_subsetting_rule_processing_chain_object#processing_chain_object_key DataSafeSubsettingPolicySubsettingRuleProcessingChainObject#processing_chain_object_key}.</summary>
            [JsiiProperty(name: "processingChainObjectKey", typeJson: "{\"primitive\":\"string\"}")]
            public string ProcessingChainObjectKey
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.8.0/docs/resources/data_safe_subsetting_policy_subsetting_rule_processing_chain_object#subsetting_policy_id DataSafeSubsettingPolicySubsettingRuleProcessingChainObject#subsetting_policy_id}.</summary>
            [JsiiProperty(name: "subsettingPolicyId", typeJson: "{\"primitive\":\"string\"}")]
            public string SubsettingPolicyId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.8.0/docs/resources/data_safe_subsetting_policy_subsetting_rule_processing_chain_object#subsetting_rule_key DataSafeSubsettingPolicySubsettingRuleProcessingChainObject#subsetting_rule_key}.</summary>
            [JsiiProperty(name: "subsettingRuleKey", typeJson: "{\"primitive\":\"string\"}")]
            public string SubsettingRuleKey
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.8.0/docs/resources/data_safe_subsetting_policy_subsetting_rule_processing_chain_object#id DataSafeSubsettingPolicySubsettingRuleProcessingChainObject#id}.</summary>
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

            /// <summary>timeouts block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.8.0/docs/resources/data_safe_subsetting_policy_subsetting_rule_processing_chain_object#timeouts DataSafeSubsettingPolicySubsettingRuleProcessingChainObject#timeouts}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"oci.dataSafeSubsettingPolicySubsettingRuleProcessingChainObject.DataSafeSubsettingPolicySubsettingRuleProcessingChainObjectTimeouts\"}", isOptional: true)]
            public oci.DataSafeSubsettingPolicySubsettingRuleProcessingChainObject.IDataSafeSubsettingPolicySubsettingRuleProcessingChainObjectTimeouts? Timeouts
            {
                get => GetInstanceProperty<oci.DataSafeSubsettingPolicySubsettingRuleProcessingChainObject.IDataSafeSubsettingPolicySubsettingRuleProcessingChainObjectTimeouts?>();
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

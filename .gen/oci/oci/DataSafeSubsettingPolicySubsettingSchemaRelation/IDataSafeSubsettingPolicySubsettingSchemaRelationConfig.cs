using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataSafeSubsettingPolicySubsettingSchemaRelation
{
    [JsiiInterface(nativeType: typeof(IDataSafeSubsettingPolicySubsettingSchemaRelationConfig), fullyQualifiedName: "oci.dataSafeSubsettingPolicySubsettingSchemaRelation.DataSafeSubsettingPolicySubsettingSchemaRelationConfig")]
    public interface IDataSafeSubsettingPolicySubsettingSchemaRelationConfig : Io.Cdktn.ITerraformMetaArguments
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.9.0/docs/resources/data_safe_subsetting_policy_subsetting_schema_relation#child_columns DataSafeSubsettingPolicySubsettingSchemaRelation#child_columns}.</summary>
        [JsiiProperty(name: "childColumns", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        string[] ChildColumns
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.9.0/docs/resources/data_safe_subsetting_policy_subsetting_schema_relation#child_object_name DataSafeSubsettingPolicySubsettingSchemaRelation#child_object_name}.</summary>
        [JsiiProperty(name: "childObjectName", typeJson: "{\"primitive\":\"string\"}")]
        string ChildObjectName
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.9.0/docs/resources/data_safe_subsetting_policy_subsetting_schema_relation#child_schema_name DataSafeSubsettingPolicySubsettingSchemaRelation#child_schema_name}.</summary>
        [JsiiProperty(name: "childSchemaName", typeJson: "{\"primitive\":\"string\"}")]
        string ChildSchemaName
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.9.0/docs/resources/data_safe_subsetting_policy_subsetting_schema_relation#parent_columns DataSafeSubsettingPolicySubsettingSchemaRelation#parent_columns}.</summary>
        [JsiiProperty(name: "parentColumns", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        string[] ParentColumns
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.9.0/docs/resources/data_safe_subsetting_policy_subsetting_schema_relation#parent_object_name DataSafeSubsettingPolicySubsettingSchemaRelation#parent_object_name}.</summary>
        [JsiiProperty(name: "parentObjectName", typeJson: "{\"primitive\":\"string\"}")]
        string ParentObjectName
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.9.0/docs/resources/data_safe_subsetting_policy_subsetting_schema_relation#parent_schema_name DataSafeSubsettingPolicySubsettingSchemaRelation#parent_schema_name}.</summary>
        [JsiiProperty(name: "parentSchemaName", typeJson: "{\"primitive\":\"string\"}")]
        string ParentSchemaName
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.9.0/docs/resources/data_safe_subsetting_policy_subsetting_schema_relation#subsetting_policy_id DataSafeSubsettingPolicySubsettingSchemaRelation#subsetting_policy_id}.</summary>
        [JsiiProperty(name: "subsettingPolicyId", typeJson: "{\"primitive\":\"string\"}")]
        string SubsettingPolicyId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.9.0/docs/resources/data_safe_subsetting_policy_subsetting_schema_relation#child_object_key DataSafeSubsettingPolicySubsettingSchemaRelation#child_object_key}.</summary>
        [JsiiProperty(name: "childObjectKey", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ChildObjectKey
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.9.0/docs/resources/data_safe_subsetting_policy_subsetting_schema_relation#id DataSafeSubsettingPolicySubsettingSchemaRelation#id}.</summary>
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

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.9.0/docs/resources/data_safe_subsetting_policy_subsetting_schema_relation#parent_object_key DataSafeSubsettingPolicySubsettingSchemaRelation#parent_object_key}.</summary>
        [JsiiProperty(name: "parentObjectKey", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ParentObjectKey
        {
            get
            {
                return null;
            }
        }

        /// <summary>timeouts block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.9.0/docs/resources/data_safe_subsetting_policy_subsetting_schema_relation#timeouts DataSafeSubsettingPolicySubsettingSchemaRelation#timeouts}
        /// </remarks>
        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"oci.dataSafeSubsettingPolicySubsettingSchemaRelation.DataSafeSubsettingPolicySubsettingSchemaRelationTimeouts\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.DataSafeSubsettingPolicySubsettingSchemaRelation.IDataSafeSubsettingPolicySubsettingSchemaRelationTimeouts? Timeouts
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataSafeSubsettingPolicySubsettingSchemaRelationConfig), fullyQualifiedName: "oci.dataSafeSubsettingPolicySubsettingSchemaRelation.DataSafeSubsettingPolicySubsettingSchemaRelationConfig")]
        internal sealed class _Proxy : DeputyBase, oci.DataSafeSubsettingPolicySubsettingSchemaRelation.IDataSafeSubsettingPolicySubsettingSchemaRelationConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.9.0/docs/resources/data_safe_subsetting_policy_subsetting_schema_relation#child_columns DataSafeSubsettingPolicySubsettingSchemaRelation#child_columns}.</summary>
            [JsiiProperty(name: "childColumns", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
            public string[] ChildColumns
            {
                get => GetInstanceProperty<string[]>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.9.0/docs/resources/data_safe_subsetting_policy_subsetting_schema_relation#child_object_name DataSafeSubsettingPolicySubsettingSchemaRelation#child_object_name}.</summary>
            [JsiiProperty(name: "childObjectName", typeJson: "{\"primitive\":\"string\"}")]
            public string ChildObjectName
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.9.0/docs/resources/data_safe_subsetting_policy_subsetting_schema_relation#child_schema_name DataSafeSubsettingPolicySubsettingSchemaRelation#child_schema_name}.</summary>
            [JsiiProperty(name: "childSchemaName", typeJson: "{\"primitive\":\"string\"}")]
            public string ChildSchemaName
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.9.0/docs/resources/data_safe_subsetting_policy_subsetting_schema_relation#parent_columns DataSafeSubsettingPolicySubsettingSchemaRelation#parent_columns}.</summary>
            [JsiiProperty(name: "parentColumns", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
            public string[] ParentColumns
            {
                get => GetInstanceProperty<string[]>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.9.0/docs/resources/data_safe_subsetting_policy_subsetting_schema_relation#parent_object_name DataSafeSubsettingPolicySubsettingSchemaRelation#parent_object_name}.</summary>
            [JsiiProperty(name: "parentObjectName", typeJson: "{\"primitive\":\"string\"}")]
            public string ParentObjectName
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.9.0/docs/resources/data_safe_subsetting_policy_subsetting_schema_relation#parent_schema_name DataSafeSubsettingPolicySubsettingSchemaRelation#parent_schema_name}.</summary>
            [JsiiProperty(name: "parentSchemaName", typeJson: "{\"primitive\":\"string\"}")]
            public string ParentSchemaName
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.9.0/docs/resources/data_safe_subsetting_policy_subsetting_schema_relation#subsetting_policy_id DataSafeSubsettingPolicySubsettingSchemaRelation#subsetting_policy_id}.</summary>
            [JsiiProperty(name: "subsettingPolicyId", typeJson: "{\"primitive\":\"string\"}")]
            public string SubsettingPolicyId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.9.0/docs/resources/data_safe_subsetting_policy_subsetting_schema_relation#child_object_key DataSafeSubsettingPolicySubsettingSchemaRelation#child_object_key}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "childObjectKey", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ChildObjectKey
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.9.0/docs/resources/data_safe_subsetting_policy_subsetting_schema_relation#id DataSafeSubsettingPolicySubsettingSchemaRelation#id}.</summary>
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

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.9.0/docs/resources/data_safe_subsetting_policy_subsetting_schema_relation#parent_object_key DataSafeSubsettingPolicySubsettingSchemaRelation#parent_object_key}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "parentObjectKey", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ParentObjectKey
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>timeouts block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.9.0/docs/resources/data_safe_subsetting_policy_subsetting_schema_relation#timeouts DataSafeSubsettingPolicySubsettingSchemaRelation#timeouts}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"oci.dataSafeSubsettingPolicySubsettingSchemaRelation.DataSafeSubsettingPolicySubsettingSchemaRelationTimeouts\"}", isOptional: true)]
            public oci.DataSafeSubsettingPolicySubsettingSchemaRelation.IDataSafeSubsettingPolicySubsettingSchemaRelationTimeouts? Timeouts
            {
                get => GetInstanceProperty<oci.DataSafeSubsettingPolicySubsettingSchemaRelation.IDataSafeSubsettingPolicySubsettingSchemaRelationTimeouts?>();
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

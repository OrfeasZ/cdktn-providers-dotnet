using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DatabasePluggableDatabasesLocalClone
{
    [JsiiInterface(nativeType: typeof(IDatabasePluggableDatabasesLocalCloneConfig), fullyQualifiedName: "oci.databasePluggableDatabasesLocalClone.DatabasePluggableDatabasesLocalCloneConfig")]
    public interface IDatabasePluggableDatabasesLocalCloneConfig : Io.Cdktn.ITerraformMetaArguments
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_pluggable_databases_local_clone#cloned_pdb_name DatabasePluggableDatabasesLocalClone#cloned_pdb_name}.</summary>
        [JsiiProperty(name: "clonedPdbName", typeJson: "{\"primitive\":\"string\"}")]
        string ClonedPdbName
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_pluggable_databases_local_clone#pluggable_database_id DatabasePluggableDatabasesLocalClone#pluggable_database_id}.</summary>
        [JsiiProperty(name: "pluggableDatabaseId", typeJson: "{\"primitive\":\"string\"}")]
        string PluggableDatabaseId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_pluggable_databases_local_clone#id DatabasePluggableDatabasesLocalClone#id}.</summary>
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

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_pluggable_databases_local_clone#pdb_admin_password DatabasePluggableDatabasesLocalClone#pdb_admin_password}.</summary>
        [JsiiProperty(name: "pdbAdminPassword", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? PdbAdminPassword
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_pluggable_databases_local_clone#should_pdb_admin_account_be_locked DatabasePluggableDatabasesLocalClone#should_pdb_admin_account_be_locked}.</summary>
        [JsiiProperty(name: "shouldPdbAdminAccountBeLocked", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? ShouldPdbAdminAccountBeLocked
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_pluggable_databases_local_clone#target_tde_wallet_password DatabasePluggableDatabasesLocalClone#target_tde_wallet_password}.</summary>
        [JsiiProperty(name: "targetTdeWalletPassword", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? TargetTdeWalletPassword
        {
            get
            {
                return null;
            }
        }

        /// <summary>timeouts block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_pluggable_databases_local_clone#timeouts DatabasePluggableDatabasesLocalClone#timeouts}
        /// </remarks>
        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"oci.databasePluggableDatabasesLocalClone.DatabasePluggableDatabasesLocalCloneTimeouts\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.DatabasePluggableDatabasesLocalClone.IDatabasePluggableDatabasesLocalCloneTimeouts? Timeouts
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDatabasePluggableDatabasesLocalCloneConfig), fullyQualifiedName: "oci.databasePluggableDatabasesLocalClone.DatabasePluggableDatabasesLocalCloneConfig")]
        internal sealed class _Proxy : DeputyBase, oci.DatabasePluggableDatabasesLocalClone.IDatabasePluggableDatabasesLocalCloneConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_pluggable_databases_local_clone#cloned_pdb_name DatabasePluggableDatabasesLocalClone#cloned_pdb_name}.</summary>
            [JsiiProperty(name: "clonedPdbName", typeJson: "{\"primitive\":\"string\"}")]
            public string ClonedPdbName
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_pluggable_databases_local_clone#pluggable_database_id DatabasePluggableDatabasesLocalClone#pluggable_database_id}.</summary>
            [JsiiProperty(name: "pluggableDatabaseId", typeJson: "{\"primitive\":\"string\"}")]
            public string PluggableDatabaseId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_pluggable_databases_local_clone#id DatabasePluggableDatabasesLocalClone#id}.</summary>
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

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_pluggable_databases_local_clone#pdb_admin_password DatabasePluggableDatabasesLocalClone#pdb_admin_password}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "pdbAdminPassword", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? PdbAdminPassword
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_pluggable_databases_local_clone#should_pdb_admin_account_be_locked DatabasePluggableDatabasesLocalClone#should_pdb_admin_account_be_locked}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "shouldPdbAdminAccountBeLocked", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? ShouldPdbAdminAccountBeLocked
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_pluggable_databases_local_clone#target_tde_wallet_password DatabasePluggableDatabasesLocalClone#target_tde_wallet_password}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "targetTdeWalletPassword", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? TargetTdeWalletPassword
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>timeouts block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_pluggable_databases_local_clone#timeouts DatabasePluggableDatabasesLocalClone#timeouts}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"oci.databasePluggableDatabasesLocalClone.DatabasePluggableDatabasesLocalCloneTimeouts\"}", isOptional: true)]
            public oci.DatabasePluggableDatabasesLocalClone.IDatabasePluggableDatabasesLocalCloneTimeouts? Timeouts
            {
                get => GetInstanceProperty<oci.DatabasePluggableDatabasesLocalClone.IDatabasePluggableDatabasesLocalCloneTimeouts?>();
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

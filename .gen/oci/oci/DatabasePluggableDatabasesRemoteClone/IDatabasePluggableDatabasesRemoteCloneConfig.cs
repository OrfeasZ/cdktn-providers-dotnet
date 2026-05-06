using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DatabasePluggableDatabasesRemoteClone
{
    [JsiiInterface(nativeType: typeof(IDatabasePluggableDatabasesRemoteCloneConfig), fullyQualifiedName: "oci.databasePluggableDatabasesRemoteClone.DatabasePluggableDatabasesRemoteCloneConfig")]
    public interface IDatabasePluggableDatabasesRemoteCloneConfig : Io.Cdktn.ITerraformMetaArguments
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_pluggable_databases_remote_clone#cloned_pdb_name DatabasePluggableDatabasesRemoteClone#cloned_pdb_name}.</summary>
        [JsiiProperty(name: "clonedPdbName", typeJson: "{\"primitive\":\"string\"}")]
        string ClonedPdbName
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_pluggable_databases_remote_clone#pluggable_database_id DatabasePluggableDatabasesRemoteClone#pluggable_database_id}.</summary>
        [JsiiProperty(name: "pluggableDatabaseId", typeJson: "{\"primitive\":\"string\"}")]
        string PluggableDatabaseId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_pluggable_databases_remote_clone#source_container_db_admin_password DatabasePluggableDatabasesRemoteClone#source_container_db_admin_password}.</summary>
        [JsiiProperty(name: "sourceContainerDbAdminPassword", typeJson: "{\"primitive\":\"string\"}")]
        string SourceContainerDbAdminPassword
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_pluggable_databases_remote_clone#target_container_database_id DatabasePluggableDatabasesRemoteClone#target_container_database_id}.</summary>
        [JsiiProperty(name: "targetContainerDatabaseId", typeJson: "{\"primitive\":\"string\"}")]
        string TargetContainerDatabaseId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_pluggable_databases_remote_clone#id DatabasePluggableDatabasesRemoteClone#id}.</summary>
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

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_pluggable_databases_remote_clone#pdb_admin_password DatabasePluggableDatabasesRemoteClone#pdb_admin_password}.</summary>
        [JsiiProperty(name: "pdbAdminPassword", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? PdbAdminPassword
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_pluggable_databases_remote_clone#should_pdb_admin_account_be_locked DatabasePluggableDatabasesRemoteClone#should_pdb_admin_account_be_locked}.</summary>
        [JsiiProperty(name: "shouldPdbAdminAccountBeLocked", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? ShouldPdbAdminAccountBeLocked
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_pluggable_databases_remote_clone#target_tde_wallet_password DatabasePluggableDatabasesRemoteClone#target_tde_wallet_password}.</summary>
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
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_pluggable_databases_remote_clone#timeouts DatabasePluggableDatabasesRemoteClone#timeouts}
        /// </remarks>
        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"oci.databasePluggableDatabasesRemoteClone.DatabasePluggableDatabasesRemoteCloneTimeouts\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.DatabasePluggableDatabasesRemoteClone.IDatabasePluggableDatabasesRemoteCloneTimeouts? Timeouts
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDatabasePluggableDatabasesRemoteCloneConfig), fullyQualifiedName: "oci.databasePluggableDatabasesRemoteClone.DatabasePluggableDatabasesRemoteCloneConfig")]
        internal sealed class _Proxy : DeputyBase, oci.DatabasePluggableDatabasesRemoteClone.IDatabasePluggableDatabasesRemoteCloneConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_pluggable_databases_remote_clone#cloned_pdb_name DatabasePluggableDatabasesRemoteClone#cloned_pdb_name}.</summary>
            [JsiiProperty(name: "clonedPdbName", typeJson: "{\"primitive\":\"string\"}")]
            public string ClonedPdbName
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_pluggable_databases_remote_clone#pluggable_database_id DatabasePluggableDatabasesRemoteClone#pluggable_database_id}.</summary>
            [JsiiProperty(name: "pluggableDatabaseId", typeJson: "{\"primitive\":\"string\"}")]
            public string PluggableDatabaseId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_pluggable_databases_remote_clone#source_container_db_admin_password DatabasePluggableDatabasesRemoteClone#source_container_db_admin_password}.</summary>
            [JsiiProperty(name: "sourceContainerDbAdminPassword", typeJson: "{\"primitive\":\"string\"}")]
            public string SourceContainerDbAdminPassword
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_pluggable_databases_remote_clone#target_container_database_id DatabasePluggableDatabasesRemoteClone#target_container_database_id}.</summary>
            [JsiiProperty(name: "targetContainerDatabaseId", typeJson: "{\"primitive\":\"string\"}")]
            public string TargetContainerDatabaseId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_pluggable_databases_remote_clone#id DatabasePluggableDatabasesRemoteClone#id}.</summary>
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

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_pluggable_databases_remote_clone#pdb_admin_password DatabasePluggableDatabasesRemoteClone#pdb_admin_password}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "pdbAdminPassword", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? PdbAdminPassword
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_pluggable_databases_remote_clone#should_pdb_admin_account_be_locked DatabasePluggableDatabasesRemoteClone#should_pdb_admin_account_be_locked}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "shouldPdbAdminAccountBeLocked", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? ShouldPdbAdminAccountBeLocked
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_pluggable_databases_remote_clone#target_tde_wallet_password DatabasePluggableDatabasesRemoteClone#target_tde_wallet_password}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "targetTdeWalletPassword", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? TargetTdeWalletPassword
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>timeouts block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_pluggable_databases_remote_clone#timeouts DatabasePluggableDatabasesRemoteClone#timeouts}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"oci.databasePluggableDatabasesRemoteClone.DatabasePluggableDatabasesRemoteCloneTimeouts\"}", isOptional: true)]
            public oci.DatabasePluggableDatabasesRemoteClone.IDatabasePluggableDatabasesRemoteCloneTimeouts? Timeouts
            {
                get => GetInstanceProperty<oci.DatabasePluggableDatabasesRemoteClone.IDatabasePluggableDatabasesRemoteCloneTimeouts?>();
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

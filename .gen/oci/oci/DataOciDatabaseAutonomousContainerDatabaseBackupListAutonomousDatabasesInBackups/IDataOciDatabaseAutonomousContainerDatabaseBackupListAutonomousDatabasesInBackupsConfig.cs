using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciDatabaseAutonomousContainerDatabaseBackupListAutonomousDatabasesInBackups
{
    [JsiiInterface(nativeType: typeof(IDataOciDatabaseAutonomousContainerDatabaseBackupListAutonomousDatabasesInBackupsConfig), fullyQualifiedName: "oci.dataOciDatabaseAutonomousContainerDatabaseBackupListAutonomousDatabasesInBackups.DataOciDatabaseAutonomousContainerDatabaseBackupListAutonomousDatabasesInBackupsConfig")]
    public interface IDataOciDatabaseAutonomousContainerDatabaseBackupListAutonomousDatabasesInBackupsConfig : Io.Cdktn.ITerraformMetaArguments
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.27.0/docs/data-sources/database_autonomous_container_database_backup_list_autonomous_databases_in_backups#autonomous_container_database_id DataOciDatabaseAutonomousContainerDatabaseBackupListAutonomousDatabasesInBackups#autonomous_container_database_id}.</summary>
        [JsiiProperty(name: "autonomousContainerDatabaseId", typeJson: "{\"primitive\":\"string\"}")]
        string AutonomousContainerDatabaseId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.27.0/docs/data-sources/database_autonomous_container_database_backup_list_autonomous_databases_in_backups#time_stamp_requested DataOciDatabaseAutonomousContainerDatabaseBackupListAutonomousDatabasesInBackups#time_stamp_requested}.</summary>
        [JsiiProperty(name: "timeStampRequested", typeJson: "{\"primitive\":\"string\"}")]
        string TimeStampRequested
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.27.0/docs/data-sources/database_autonomous_container_database_backup_list_autonomous_databases_in_backups#compartment_id DataOciDatabaseAutonomousContainerDatabaseBackupListAutonomousDatabasesInBackups#compartment_id}.</summary>
        [JsiiProperty(name: "compartmentId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? CompartmentId
        {
            get
            {
                return null;
            }
        }

        /// <summary>filter block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.27.0/docs/data-sources/database_autonomous_container_database_backup_list_autonomous_databases_in_backups#filter DataOciDatabaseAutonomousContainerDatabaseBackupListAutonomousDatabasesInBackups#filter}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="oci.DataOciDatabaseAutonomousContainerDatabaseBackupListAutonomousDatabasesInBackups.IDataOciDatabaseAutonomousContainerDatabaseBackupListAutonomousDatabasesInBackupsFilter" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "filter", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.dataOciDatabaseAutonomousContainerDatabaseBackupListAutonomousDatabasesInBackups.DataOciDatabaseAutonomousContainerDatabaseBackupListAutonomousDatabasesInBackupsFilter\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Filter
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.27.0/docs/data-sources/database_autonomous_container_database_backup_list_autonomous_databases_in_backups#id DataOciDatabaseAutonomousContainerDatabaseBackupListAutonomousDatabasesInBackups#id}.</summary>
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

        [JsiiTypeProxy(nativeType: typeof(IDataOciDatabaseAutonomousContainerDatabaseBackupListAutonomousDatabasesInBackupsConfig), fullyQualifiedName: "oci.dataOciDatabaseAutonomousContainerDatabaseBackupListAutonomousDatabasesInBackups.DataOciDatabaseAutonomousContainerDatabaseBackupListAutonomousDatabasesInBackupsConfig")]
        internal sealed class _Proxy : DeputyBase, oci.DataOciDatabaseAutonomousContainerDatabaseBackupListAutonomousDatabasesInBackups.IDataOciDatabaseAutonomousContainerDatabaseBackupListAutonomousDatabasesInBackupsConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.27.0/docs/data-sources/database_autonomous_container_database_backup_list_autonomous_databases_in_backups#autonomous_container_database_id DataOciDatabaseAutonomousContainerDatabaseBackupListAutonomousDatabasesInBackups#autonomous_container_database_id}.</summary>
            [JsiiProperty(name: "autonomousContainerDatabaseId", typeJson: "{\"primitive\":\"string\"}")]
            public string AutonomousContainerDatabaseId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.27.0/docs/data-sources/database_autonomous_container_database_backup_list_autonomous_databases_in_backups#time_stamp_requested DataOciDatabaseAutonomousContainerDatabaseBackupListAutonomousDatabasesInBackups#time_stamp_requested}.</summary>
            [JsiiProperty(name: "timeStampRequested", typeJson: "{\"primitive\":\"string\"}")]
            public string TimeStampRequested
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.27.0/docs/data-sources/database_autonomous_container_database_backup_list_autonomous_databases_in_backups#compartment_id DataOciDatabaseAutonomousContainerDatabaseBackupListAutonomousDatabasesInBackups#compartment_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "compartmentId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? CompartmentId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>filter block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.27.0/docs/data-sources/database_autonomous_container_database_backup_list_autonomous_databases_in_backups#filter DataOciDatabaseAutonomousContainerDatabaseBackupListAutonomousDatabasesInBackups#filter}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="oci.DataOciDatabaseAutonomousContainerDatabaseBackupListAutonomousDatabasesInBackups.IDataOciDatabaseAutonomousContainerDatabaseBackupListAutonomousDatabasesInBackupsFilter" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "filter", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.dataOciDatabaseAutonomousContainerDatabaseBackupListAutonomousDatabasesInBackups.DataOciDatabaseAutonomousContainerDatabaseBackupListAutonomousDatabasesInBackupsFilter\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Filter
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.27.0/docs/data-sources/database_autonomous_container_database_backup_list_autonomous_databases_in_backups#id DataOciDatabaseAutonomousContainerDatabaseBackupListAutonomousDatabasesInBackups#id}.</summary>
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

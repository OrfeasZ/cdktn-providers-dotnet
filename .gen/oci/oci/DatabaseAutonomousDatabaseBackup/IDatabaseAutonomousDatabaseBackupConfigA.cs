using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DatabaseAutonomousDatabaseBackup
{
    [JsiiInterface(nativeType: typeof(IDatabaseAutonomousDatabaseBackupConfigA), fullyQualifiedName: "oci.databaseAutonomousDatabaseBackup.DatabaseAutonomousDatabaseBackupConfigA")]
    public interface IDatabaseAutonomousDatabaseBackupConfigA : Io.Cdktn.ITerraformMetaArguments
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_autonomous_database_backup#autonomous_database_id DatabaseAutonomousDatabaseBackup#autonomous_database_id}.</summary>
        [JsiiProperty(name: "autonomousDatabaseId", typeJson: "{\"primitive\":\"string\"}")]
        string AutonomousDatabaseId
        {
            get;
        }

        /// <summary>backup_destination_details block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_autonomous_database_backup#backup_destination_details DatabaseAutonomousDatabaseBackup#backup_destination_details}
        /// </remarks>
        [JsiiProperty(name: "backupDestinationDetails", typeJson: "{\"fqn\":\"oci.databaseAutonomousDatabaseBackup.DatabaseAutonomousDatabaseBackupBackupDestinationDetails\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.DatabaseAutonomousDatabaseBackup.IDatabaseAutonomousDatabaseBackupBackupDestinationDetails? BackupDestinationDetails
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_autonomous_database_backup#display_name DatabaseAutonomousDatabaseBackup#display_name}.</summary>
        [JsiiProperty(name: "displayName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? DisplayName
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_autonomous_database_backup#id DatabaseAutonomousDatabaseBackup#id}.</summary>
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

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_autonomous_database_backup#is_long_term_backup DatabaseAutonomousDatabaseBackup#is_long_term_backup}.</summary>
        [JsiiProperty(name: "isLongTermBackup", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? IsLongTermBackup
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_autonomous_database_backup#retention_period_in_days DatabaseAutonomousDatabaseBackup#retention_period_in_days}.</summary>
        [JsiiProperty(name: "retentionPeriodInDays", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? RetentionPeriodInDays
        {
            get
            {
                return null;
            }
        }

        /// <summary>timeouts block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_autonomous_database_backup#timeouts DatabaseAutonomousDatabaseBackup#timeouts}
        /// </remarks>
        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"oci.databaseAutonomousDatabaseBackup.DatabaseAutonomousDatabaseBackupTimeouts\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.DatabaseAutonomousDatabaseBackup.IDatabaseAutonomousDatabaseBackupTimeouts? Timeouts
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDatabaseAutonomousDatabaseBackupConfigA), fullyQualifiedName: "oci.databaseAutonomousDatabaseBackup.DatabaseAutonomousDatabaseBackupConfigA")]
        internal sealed class _Proxy : DeputyBase, oci.DatabaseAutonomousDatabaseBackup.IDatabaseAutonomousDatabaseBackupConfigA
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_autonomous_database_backup#autonomous_database_id DatabaseAutonomousDatabaseBackup#autonomous_database_id}.</summary>
            [JsiiProperty(name: "autonomousDatabaseId", typeJson: "{\"primitive\":\"string\"}")]
            public string AutonomousDatabaseId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>backup_destination_details block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_autonomous_database_backup#backup_destination_details DatabaseAutonomousDatabaseBackup#backup_destination_details}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "backupDestinationDetails", typeJson: "{\"fqn\":\"oci.databaseAutonomousDatabaseBackup.DatabaseAutonomousDatabaseBackupBackupDestinationDetails\"}", isOptional: true)]
            public oci.DatabaseAutonomousDatabaseBackup.IDatabaseAutonomousDatabaseBackupBackupDestinationDetails? BackupDestinationDetails
            {
                get => GetInstanceProperty<oci.DatabaseAutonomousDatabaseBackup.IDatabaseAutonomousDatabaseBackupBackupDestinationDetails?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_autonomous_database_backup#display_name DatabaseAutonomousDatabaseBackup#display_name}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "displayName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? DisplayName
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_autonomous_database_backup#id DatabaseAutonomousDatabaseBackup#id}.</summary>
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

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_autonomous_database_backup#is_long_term_backup DatabaseAutonomousDatabaseBackup#is_long_term_backup}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "isLongTermBackup", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? IsLongTermBackup
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_autonomous_database_backup#retention_period_in_days DatabaseAutonomousDatabaseBackup#retention_period_in_days}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "retentionPeriodInDays", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? RetentionPeriodInDays
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>timeouts block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_autonomous_database_backup#timeouts DatabaseAutonomousDatabaseBackup#timeouts}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"oci.databaseAutonomousDatabaseBackup.DatabaseAutonomousDatabaseBackupTimeouts\"}", isOptional: true)]
            public oci.DatabaseAutonomousDatabaseBackup.IDatabaseAutonomousDatabaseBackupTimeouts? Timeouts
            {
                get => GetInstanceProperty<oci.DatabaseAutonomousDatabaseBackup.IDatabaseAutonomousDatabaseBackupTimeouts?>();
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

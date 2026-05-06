using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DatabaseDbHome
{
    [JsiiInterface(nativeType: typeof(IDatabaseDbHomeDatabaseDbBackupConfig), fullyQualifiedName: "oci.databaseDbHome.DatabaseDbHomeDatabaseDbBackupConfig")]
    public interface IDatabaseDbHomeDatabaseDbBackupConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_db_home#auto_backup_enabled DatabaseDbHome#auto_backup_enabled}.</summary>
        [JsiiProperty(name: "autoBackupEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? AutoBackupEnabled
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_db_home#auto_backup_window DatabaseDbHome#auto_backup_window}.</summary>
        [JsiiProperty(name: "autoBackupWindow", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? AutoBackupWindow
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_db_home#auto_full_backup_day DatabaseDbHome#auto_full_backup_day}.</summary>
        [JsiiProperty(name: "autoFullBackupDay", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? AutoFullBackupDay
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_db_home#auto_full_backup_window DatabaseDbHome#auto_full_backup_window}.</summary>
        [JsiiProperty(name: "autoFullBackupWindow", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? AutoFullBackupWindow
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_db_home#backup_deletion_policy DatabaseDbHome#backup_deletion_policy}.</summary>
        [JsiiProperty(name: "backupDeletionPolicy", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? BackupDeletionPolicy
        {
            get
            {
                return null;
            }
        }

        /// <summary>backup_destination_details block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_db_home#backup_destination_details DatabaseDbHome#backup_destination_details}
        /// </remarks>
        [JsiiProperty(name: "backupDestinationDetails", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.databaseDbHome.DatabaseDbHomeDatabaseDbBackupConfigBackupDestinationDetails\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? BackupDestinationDetails
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_db_home#recovery_window_in_days DatabaseDbHome#recovery_window_in_days}.</summary>
        [JsiiProperty(name: "recoveryWindowInDays", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? RecoveryWindowInDays
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_db_home#run_immediate_full_backup DatabaseDbHome#run_immediate_full_backup}.</summary>
        [JsiiProperty(name: "runImmediateFullBackup", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? RunImmediateFullBackup
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDatabaseDbHomeDatabaseDbBackupConfig), fullyQualifiedName: "oci.databaseDbHome.DatabaseDbHomeDatabaseDbBackupConfig")]
        internal sealed class _Proxy : DeputyBase, oci.DatabaseDbHome.IDatabaseDbHomeDatabaseDbBackupConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_db_home#auto_backup_enabled DatabaseDbHome#auto_backup_enabled}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "autoBackupEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? AutoBackupEnabled
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_db_home#auto_backup_window DatabaseDbHome#auto_backup_window}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "autoBackupWindow", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? AutoBackupWindow
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_db_home#auto_full_backup_day DatabaseDbHome#auto_full_backup_day}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "autoFullBackupDay", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? AutoFullBackupDay
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_db_home#auto_full_backup_window DatabaseDbHome#auto_full_backup_window}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "autoFullBackupWindow", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? AutoFullBackupWindow
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_db_home#backup_deletion_policy DatabaseDbHome#backup_deletion_policy}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "backupDeletionPolicy", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? BackupDeletionPolicy
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>backup_destination_details block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_db_home#backup_destination_details DatabaseDbHome#backup_destination_details}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "backupDestinationDetails", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.databaseDbHome.DatabaseDbHomeDatabaseDbBackupConfigBackupDestinationDetails\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? BackupDestinationDetails
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_db_home#recovery_window_in_days DatabaseDbHome#recovery_window_in_days}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "recoveryWindowInDays", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? RecoveryWindowInDays
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_db_home#run_immediate_full_backup DatabaseDbHome#run_immediate_full_backup}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "runImmediateFullBackup", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? RunImmediateFullBackup
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}

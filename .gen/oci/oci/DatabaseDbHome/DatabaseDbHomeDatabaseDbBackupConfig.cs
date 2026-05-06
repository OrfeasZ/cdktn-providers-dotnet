using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DatabaseDbHome
{
    [JsiiByValue(fqn: "oci.databaseDbHome.DatabaseDbHomeDatabaseDbBackupConfig")]
    public class DatabaseDbHomeDatabaseDbBackupConfig : oci.DatabaseDbHome.IDatabaseDbHomeDatabaseDbBackupConfig
    {
        private object? _autoBackupEnabled;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_db_home#auto_backup_enabled DatabaseDbHome#auto_backup_enabled}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "autoBackupEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? AutoBackupEnabled
        {
            get => _autoBackupEnabled;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case bool cast_cd4240:
                            break;
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _autoBackupEnabled = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_db_home#auto_backup_window DatabaseDbHome#auto_backup_window}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "autoBackupWindow", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? AutoBackupWindow
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_db_home#auto_full_backup_day DatabaseDbHome#auto_full_backup_day}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "autoFullBackupDay", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? AutoFullBackupDay
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_db_home#auto_full_backup_window DatabaseDbHome#auto_full_backup_window}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "autoFullBackupWindow", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? AutoFullBackupWindow
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_db_home#backup_deletion_policy DatabaseDbHome#backup_deletion_policy}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "backupDeletionPolicy", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? BackupDeletionPolicy
        {
            get;
            set;
        }

        private object? _backupDestinationDetails;

        /// <summary>backup_destination_details block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_db_home#backup_destination_details DatabaseDbHome#backup_destination_details}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "backupDestinationDetails", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.databaseDbHome.DatabaseDbHomeDatabaseDbBackupConfigBackupDestinationDetails\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? BackupDestinationDetails
        {
            get => _backupDestinationDetails;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case oci.DatabaseDbHome.IDatabaseDbHomeDatabaseDbBackupConfigBackupDestinationDetails[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.DatabaseDbHome.IDatabaseDbHomeDatabaseDbBackupConfigBackupDestinationDetails).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _backupDestinationDetails = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_db_home#recovery_window_in_days DatabaseDbHome#recovery_window_in_days}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "recoveryWindowInDays", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? RecoveryWindowInDays
        {
            get;
            set;
        }

        private object? _runImmediateFullBackup;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_db_home#run_immediate_full_backup DatabaseDbHome#run_immediate_full_backup}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "runImmediateFullBackup", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? RunImmediateFullBackup
        {
            get => _runImmediateFullBackup;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case bool cast_cd4240:
                            break;
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _runImmediateFullBackup = value;
            }
        }
    }
}

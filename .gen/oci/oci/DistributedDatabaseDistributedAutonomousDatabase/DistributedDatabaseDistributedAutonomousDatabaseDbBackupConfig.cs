using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DistributedDatabaseDistributedAutonomousDatabase
{
    [JsiiByValue(fqn: "oci.distributedDatabaseDistributedAutonomousDatabase.DistributedDatabaseDistributedAutonomousDatabaseDbBackupConfig")]
    public class DistributedDatabaseDistributedAutonomousDatabaseDbBackupConfig : oci.DistributedDatabaseDistributedAutonomousDatabase.IDistributedDatabaseDistributedAutonomousDatabaseDbBackupConfig
    {
        private object? _backupDestinationDetails;

        /// <summary>backup_destination_details block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.23.0/docs/resources/distributed_database_distributed_autonomous_database#backup_destination_details DistributedDatabaseDistributedAutonomousDatabase#backup_destination_details}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="oci.DistributedDatabaseDistributedAutonomousDatabase.IDistributedDatabaseDistributedAutonomousDatabaseDbBackupConfigBackupDestinationDetails" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "backupDestinationDetails", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.distributedDatabaseDistributedAutonomousDatabase.DistributedDatabaseDistributedAutonomousDatabaseDbBackupConfigBackupDestinationDetails\"},\"kind\":\"array\"}}]}}", isOptional: true)]
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
                        case oci.DistributedDatabaseDistributedAutonomousDatabase.IDistributedDatabaseDistributedAutonomousDatabaseDbBackupConfigBackupDestinationDetails[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.DistributedDatabaseDistributedAutonomousDatabase.IDistributedDatabaseDistributedAutonomousDatabaseDbBackupConfigBackupDestinationDetails).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _backupDestinationDetails = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.23.0/docs/resources/distributed_database_distributed_autonomous_database#recovery_window_in_days DistributedDatabaseDistributedAutonomousDatabase#recovery_window_in_days}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "recoveryWindowInDays", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? RecoveryWindowInDays
        {
            get;
            set;
        }
    }
}

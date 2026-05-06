using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DatabaseAutonomousContainerDatabaseAddStandby
{
    [JsiiByValue(fqn: "oci.databaseAutonomousContainerDatabaseAddStandby.DatabaseAutonomousContainerDatabaseAddStandbyPeerAutonomousContainerDatabaseBackupConfig")]
    public class DatabaseAutonomousContainerDatabaseAddStandbyPeerAutonomousContainerDatabaseBackupConfig : oci.DatabaseAutonomousContainerDatabaseAddStandby.IDatabaseAutonomousContainerDatabaseAddStandbyPeerAutonomousContainerDatabaseBackupConfig
    {
        private object? _backupDestinationDetails;

        /// <summary>backup_destination_details block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_autonomous_container_database_add_standby#backup_destination_details DatabaseAutonomousContainerDatabaseAddStandby#backup_destination_details}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "backupDestinationDetails", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.databaseAutonomousContainerDatabaseAddStandby.DatabaseAutonomousContainerDatabaseAddStandbyPeerAutonomousContainerDatabaseBackupConfigBackupDestinationDetails\"},\"kind\":\"array\"}}]}}", isOptional: true)]
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
                        case oci.DatabaseAutonomousContainerDatabaseAddStandby.IDatabaseAutonomousContainerDatabaseAddStandbyPeerAutonomousContainerDatabaseBackupConfigBackupDestinationDetails[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.DatabaseAutonomousContainerDatabaseAddStandby.IDatabaseAutonomousContainerDatabaseAddStandbyPeerAutonomousContainerDatabaseBackupConfigBackupDestinationDetails).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _backupDestinationDetails = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_autonomous_container_database_add_standby#recovery_window_in_days DatabaseAutonomousContainerDatabaseAddStandby#recovery_window_in_days}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "recoveryWindowInDays", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? RecoveryWindowInDays
        {
            get;
            set;
        }
    }
}

using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DatabaseAutonomousContainerDatabase
{
    [JsiiByValue(fqn: "oci.databaseAutonomousContainerDatabase.DatabaseAutonomousContainerDatabaseBackupConfig")]
    public class DatabaseAutonomousContainerDatabaseBackupConfig : oci.DatabaseAutonomousContainerDatabase.IDatabaseAutonomousContainerDatabaseBackupConfig
    {
        /// <summary>backup_destination_details block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_autonomous_container_database#backup_destination_details DatabaseAutonomousContainerDatabase#backup_destination_details}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "backupDestinationDetails", typeJson: "{\"fqn\":\"oci.databaseAutonomousContainerDatabase.DatabaseAutonomousContainerDatabaseBackupConfigBackupDestinationDetails\"}", isOptional: true)]
        public oci.DatabaseAutonomousContainerDatabase.IDatabaseAutonomousContainerDatabaseBackupConfigBackupDestinationDetails? BackupDestinationDetails
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_autonomous_container_database#recovery_window_in_days DatabaseAutonomousContainerDatabase#recovery_window_in_days}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "recoveryWindowInDays", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? RecoveryWindowInDays
        {
            get;
            set;
        }
    }
}

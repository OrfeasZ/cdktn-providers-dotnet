using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DatabaseDatabase
{
    [JsiiByValue(fqn: "oci.databaseDatabase.DatabaseDatabaseDatabaseDbBackupConfigBackupDestinationDetailsTdeWalletBackupDestination")]
    public class DatabaseDatabaseDatabaseDbBackupConfigBackupDestinationDetailsTdeWalletBackupDestination : oci.DatabaseDatabase.IDatabaseDatabaseDatabaseDbBackupConfigBackupDestinationDetailsTdeWalletBackupDestination
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.29.0/docs/resources/database_database#backup_destination_id DatabaseDatabase#backup_destination_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "backupDestinationId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? BackupDestinationId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.29.0/docs/resources/database_database#backup_destination_type DatabaseDatabase#backup_destination_type}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "backupDestinationType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? BackupDestinationType
        {
            get;
            set;
        }
    }
}

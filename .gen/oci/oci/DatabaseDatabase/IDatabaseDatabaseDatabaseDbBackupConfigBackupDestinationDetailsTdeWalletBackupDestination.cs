using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DatabaseDatabase
{
    [JsiiInterface(nativeType: typeof(IDatabaseDatabaseDatabaseDbBackupConfigBackupDestinationDetailsTdeWalletBackupDestination), fullyQualifiedName: "oci.databaseDatabase.DatabaseDatabaseDatabaseDbBackupConfigBackupDestinationDetailsTdeWalletBackupDestination")]
    public interface IDatabaseDatabaseDatabaseDbBackupConfigBackupDestinationDetailsTdeWalletBackupDestination
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.29.0/docs/resources/database_database#backup_destination_id DatabaseDatabase#backup_destination_id}.</summary>
        [JsiiProperty(name: "backupDestinationId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? BackupDestinationId
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.29.0/docs/resources/database_database#backup_destination_type DatabaseDatabase#backup_destination_type}.</summary>
        [JsiiProperty(name: "backupDestinationType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? BackupDestinationType
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDatabaseDatabaseDatabaseDbBackupConfigBackupDestinationDetailsTdeWalletBackupDestination), fullyQualifiedName: "oci.databaseDatabase.DatabaseDatabaseDatabaseDbBackupConfigBackupDestinationDetailsTdeWalletBackupDestination")]
        internal sealed class _Proxy : DeputyBase, oci.DatabaseDatabase.IDatabaseDatabaseDatabaseDbBackupConfigBackupDestinationDetailsTdeWalletBackupDestination
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.29.0/docs/resources/database_database#backup_destination_id DatabaseDatabase#backup_destination_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "backupDestinationId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? BackupDestinationId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.29.0/docs/resources/database_database#backup_destination_type DatabaseDatabase#backup_destination_type}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "backupDestinationType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? BackupDestinationType
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}

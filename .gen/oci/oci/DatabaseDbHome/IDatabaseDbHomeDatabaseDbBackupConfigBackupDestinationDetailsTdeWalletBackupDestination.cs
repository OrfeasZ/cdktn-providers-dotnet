using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DatabaseDbHome
{
    [JsiiInterface(nativeType: typeof(IDatabaseDbHomeDatabaseDbBackupConfigBackupDestinationDetailsTdeWalletBackupDestination), fullyQualifiedName: "oci.databaseDbHome.DatabaseDbHomeDatabaseDbBackupConfigBackupDestinationDetailsTdeWalletBackupDestination")]
    public interface IDatabaseDbHomeDatabaseDbBackupConfigBackupDestinationDetailsTdeWalletBackupDestination
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.0.0/docs/resources/database_db_home#backup_destination_id DatabaseDbHome#backup_destination_id}.</summary>
        [JsiiProperty(name: "backupDestinationId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? BackupDestinationId
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.0.0/docs/resources/database_db_home#backup_destination_type DatabaseDbHome#backup_destination_type}.</summary>
        [JsiiProperty(name: "backupDestinationType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? BackupDestinationType
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDatabaseDbHomeDatabaseDbBackupConfigBackupDestinationDetailsTdeWalletBackupDestination), fullyQualifiedName: "oci.databaseDbHome.DatabaseDbHomeDatabaseDbBackupConfigBackupDestinationDetailsTdeWalletBackupDestination")]
        internal sealed class _Proxy : DeputyBase, oci.DatabaseDbHome.IDatabaseDbHomeDatabaseDbBackupConfigBackupDestinationDetailsTdeWalletBackupDestination
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.0.0/docs/resources/database_db_home#backup_destination_id DatabaseDbHome#backup_destination_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "backupDestinationId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? BackupDestinationId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.0.0/docs/resources/database_db_home#backup_destination_type DatabaseDbHome#backup_destination_type}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "backupDestinationType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? BackupDestinationType
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}

using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DatabaseAutonomousContainerDatabase
{
    [JsiiInterface(nativeType: typeof(IDatabaseAutonomousContainerDatabasePeerAutonomousContainerDatabaseBackupConfig), fullyQualifiedName: "oci.databaseAutonomousContainerDatabase.DatabaseAutonomousContainerDatabasePeerAutonomousContainerDatabaseBackupConfig")]
    public interface IDatabaseAutonomousContainerDatabasePeerAutonomousContainerDatabaseBackupConfig
    {
        /// <summary>backup_destination_details block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_autonomous_container_database#backup_destination_details DatabaseAutonomousContainerDatabase#backup_destination_details}
        /// </remarks>
        [JsiiProperty(name: "backupDestinationDetails", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.databaseAutonomousContainerDatabase.DatabaseAutonomousContainerDatabasePeerAutonomousContainerDatabaseBackupConfigBackupDestinationDetails\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? BackupDestinationDetails
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_autonomous_container_database#recovery_window_in_days DatabaseAutonomousContainerDatabase#recovery_window_in_days}.</summary>
        [JsiiProperty(name: "recoveryWindowInDays", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? RecoveryWindowInDays
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDatabaseAutonomousContainerDatabasePeerAutonomousContainerDatabaseBackupConfig), fullyQualifiedName: "oci.databaseAutonomousContainerDatabase.DatabaseAutonomousContainerDatabasePeerAutonomousContainerDatabaseBackupConfig")]
        internal sealed class _Proxy : DeputyBase, oci.DatabaseAutonomousContainerDatabase.IDatabaseAutonomousContainerDatabasePeerAutonomousContainerDatabaseBackupConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>backup_destination_details block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_autonomous_container_database#backup_destination_details DatabaseAutonomousContainerDatabase#backup_destination_details}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "backupDestinationDetails", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.databaseAutonomousContainerDatabase.DatabaseAutonomousContainerDatabasePeerAutonomousContainerDatabaseBackupConfigBackupDestinationDetails\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? BackupDestinationDetails
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_autonomous_container_database#recovery_window_in_days DatabaseAutonomousContainerDatabase#recovery_window_in_days}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "recoveryWindowInDays", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? RecoveryWindowInDays
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}

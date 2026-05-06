using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.PsqlDbSystem
{
    [JsiiInterface(nativeType: typeof(IPsqlDbSystemManagementPolicy), fullyQualifiedName: "oci.psqlDbSystem.PsqlDbSystemManagementPolicy")]
    public interface IPsqlDbSystemManagementPolicy
    {
        /// <summary>backup_policy block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/psql_db_system#backup_policy PsqlDbSystem#backup_policy}
        /// </remarks>
        [JsiiProperty(name: "backupPolicy", typeJson: "{\"fqn\":\"oci.psqlDbSystem.PsqlDbSystemManagementPolicyBackupPolicy\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.PsqlDbSystem.IPsqlDbSystemManagementPolicyBackupPolicy? BackupPolicy
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/psql_db_system#maintenance_window_start PsqlDbSystem#maintenance_window_start}.</summary>
        [JsiiProperty(name: "maintenanceWindowStart", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? MaintenanceWindowStart
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IPsqlDbSystemManagementPolicy), fullyQualifiedName: "oci.psqlDbSystem.PsqlDbSystemManagementPolicy")]
        internal sealed class _Proxy : DeputyBase, oci.PsqlDbSystem.IPsqlDbSystemManagementPolicy
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>backup_policy block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/psql_db_system#backup_policy PsqlDbSystem#backup_policy}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "backupPolicy", typeJson: "{\"fqn\":\"oci.psqlDbSystem.PsqlDbSystemManagementPolicyBackupPolicy\"}", isOptional: true)]
            public oci.PsqlDbSystem.IPsqlDbSystemManagementPolicyBackupPolicy? BackupPolicy
            {
                get => GetInstanceProperty<oci.PsqlDbSystem.IPsqlDbSystemManagementPolicyBackupPolicy?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/psql_db_system#maintenance_window_start PsqlDbSystem#maintenance_window_start}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "maintenanceWindowStart", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? MaintenanceWindowStart
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}

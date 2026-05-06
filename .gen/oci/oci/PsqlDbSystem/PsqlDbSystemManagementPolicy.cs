using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.PsqlDbSystem
{
    [JsiiByValue(fqn: "oci.psqlDbSystem.PsqlDbSystemManagementPolicy")]
    public class PsqlDbSystemManagementPolicy : oci.PsqlDbSystem.IPsqlDbSystemManagementPolicy
    {
        /// <summary>backup_policy block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/psql_db_system#backup_policy PsqlDbSystem#backup_policy}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "backupPolicy", typeJson: "{\"fqn\":\"oci.psqlDbSystem.PsqlDbSystemManagementPolicyBackupPolicy\"}", isOptional: true)]
        public oci.PsqlDbSystem.IPsqlDbSystemManagementPolicyBackupPolicy? BackupPolicy
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/psql_db_system#maintenance_window_start PsqlDbSystem#maintenance_window_start}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "maintenanceWindowStart", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? MaintenanceWindowStart
        {
            get;
            set;
        }
    }
}

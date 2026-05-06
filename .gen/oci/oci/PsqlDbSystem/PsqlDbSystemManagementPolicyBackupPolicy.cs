using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.PsqlDbSystem
{
    [JsiiByValue(fqn: "oci.psqlDbSystem.PsqlDbSystemManagementPolicyBackupPolicy")]
    public class PsqlDbSystemManagementPolicyBackupPolicy : oci.PsqlDbSystem.IPsqlDbSystemManagementPolicyBackupPolicy
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/psql_db_system#backup_start PsqlDbSystem#backup_start}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "backupStart", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? BackupStart
        {
            get;
            set;
        }

        /// <summary>copy_policy block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/psql_db_system#copy_policy PsqlDbSystem#copy_policy}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "copyPolicy", typeJson: "{\"fqn\":\"oci.psqlDbSystem.PsqlDbSystemManagementPolicyBackupPolicyCopyPolicy\"}", isOptional: true)]
        public oci.PsqlDbSystem.IPsqlDbSystemManagementPolicyBackupPolicyCopyPolicy? CopyPolicy
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/psql_db_system#days_of_the_month PsqlDbSystem#days_of_the_month}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "daysOfTheMonth", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"number\"},\"kind\":\"array\"}}", isOptional: true)]
        public double[]? DaysOfTheMonth
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/psql_db_system#days_of_the_week PsqlDbSystem#days_of_the_week}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "daysOfTheWeek", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? DaysOfTheWeek
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/psql_db_system#kind PsqlDbSystem#kind}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "kind", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Kind
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/psql_db_system#retention_days PsqlDbSystem#retention_days}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "retentionDays", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? RetentionDays
        {
            get;
            set;
        }
    }
}

using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DatabaseMigrationJobAdvisorReportCheck
{
    [JsiiByValue(fqn: "oci.databaseMigrationJobAdvisorReportCheck.DatabaseMigrationJobAdvisorReportCheckTimeouts")]
    public class DatabaseMigrationJobAdvisorReportCheckTimeouts : oci.DatabaseMigrationJobAdvisorReportCheck.IDatabaseMigrationJobAdvisorReportCheckTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.25.0/docs/resources/database_migration_job_advisor_report_check#create DatabaseMigrationJobAdvisorReportCheck#create}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Create
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.25.0/docs/resources/database_migration_job_advisor_report_check#delete DatabaseMigrationJobAdvisorReportCheck#delete}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Delete
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.25.0/docs/resources/database_migration_job_advisor_report_check#update DatabaseMigrationJobAdvisorReportCheck#update}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "update", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Update
        {
            get;
            set;
        }
    }
}

using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DatabaseMigrationJobAdvisorReportCheck
{
    [JsiiInterface(nativeType: typeof(IDatabaseMigrationJobAdvisorReportCheckTimeouts), fullyQualifiedName: "oci.databaseMigrationJobAdvisorReportCheck.DatabaseMigrationJobAdvisorReportCheckTimeouts")]
    public interface IDatabaseMigrationJobAdvisorReportCheckTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.23.0/docs/resources/database_migration_job_advisor_report_check#create DatabaseMigrationJobAdvisorReportCheck#create}.</summary>
        [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Create
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.23.0/docs/resources/database_migration_job_advisor_report_check#delete DatabaseMigrationJobAdvisorReportCheck#delete}.</summary>
        [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Delete
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.23.0/docs/resources/database_migration_job_advisor_report_check#update DatabaseMigrationJobAdvisorReportCheck#update}.</summary>
        [JsiiProperty(name: "update", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Update
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDatabaseMigrationJobAdvisorReportCheckTimeouts), fullyQualifiedName: "oci.databaseMigrationJobAdvisorReportCheck.DatabaseMigrationJobAdvisorReportCheckTimeouts")]
        internal sealed class _Proxy : DeputyBase, oci.DatabaseMigrationJobAdvisorReportCheck.IDatabaseMigrationJobAdvisorReportCheckTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.23.0/docs/resources/database_migration_job_advisor_report_check#create DatabaseMigrationJobAdvisorReportCheck#create}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Create
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.23.0/docs/resources/database_migration_job_advisor_report_check#delete DatabaseMigrationJobAdvisorReportCheck#delete}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Delete
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.23.0/docs/resources/database_migration_job_advisor_report_check#update DatabaseMigrationJobAdvisorReportCheck#update}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "update", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Update
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}

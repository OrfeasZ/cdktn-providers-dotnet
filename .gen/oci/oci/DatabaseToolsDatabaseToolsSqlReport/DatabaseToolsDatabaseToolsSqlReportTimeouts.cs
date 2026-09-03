using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DatabaseToolsDatabaseToolsSqlReport
{
    [JsiiByValue(fqn: "oci.databaseToolsDatabaseToolsSqlReport.DatabaseToolsDatabaseToolsSqlReportTimeouts")]
    public class DatabaseToolsDatabaseToolsSqlReportTimeouts : oci.DatabaseToolsDatabaseToolsSqlReport.IDatabaseToolsDatabaseToolsSqlReportTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.0.0/docs/resources/database_tools_database_tools_sql_report#create DatabaseToolsDatabaseToolsSqlReport#create}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Create
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.0.0/docs/resources/database_tools_database_tools_sql_report#delete DatabaseToolsDatabaseToolsSqlReport#delete}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Delete
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.0.0/docs/resources/database_tools_database_tools_sql_report#update DatabaseToolsDatabaseToolsSqlReport#update}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "update", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Update
        {
            get;
            set;
        }
    }
}

using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DatabaseToolsDatabaseToolsMcpToolset
{
    [JsiiByValue(fqn: "oci.databaseToolsDatabaseToolsMcpToolset.DatabaseToolsDatabaseToolsMcpToolsetReports")]
    public class DatabaseToolsDatabaseToolsMcpToolsetReports : oci.DatabaseToolsDatabaseToolsMcpToolset.IDatabaseToolsDatabaseToolsMcpToolsetReports
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.22.0/docs/resources/database_tools_database_tools_mcp_toolset#allowed_roles DatabaseToolsDatabaseToolsMcpToolset#allowed_roles}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "allowedRoles", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? AllowedRoles
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.22.0/docs/resources/database_tools_database_tools_mcp_toolset#database_tools_sql_report_id DatabaseToolsDatabaseToolsMcpToolset#database_tools_sql_report_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "databaseToolsSqlReportId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? DatabaseToolsSqlReportId
        {
            get;
            set;
        }
    }
}

using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DatabaseToolsDatabaseToolsMcpToolset
{
    [JsiiByValue(fqn: "oci.databaseToolsDatabaseToolsMcpToolset.DatabaseToolsDatabaseToolsMcpToolsetTimeouts")]
    public class DatabaseToolsDatabaseToolsMcpToolsetTimeouts : oci.DatabaseToolsDatabaseToolsMcpToolset.IDatabaseToolsDatabaseToolsMcpToolsetTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.29.0/docs/resources/database_tools_database_tools_mcp_toolset#create DatabaseToolsDatabaseToolsMcpToolset#create}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Create
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.29.0/docs/resources/database_tools_database_tools_mcp_toolset#delete DatabaseToolsDatabaseToolsMcpToolset#delete}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Delete
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.29.0/docs/resources/database_tools_database_tools_mcp_toolset#update DatabaseToolsDatabaseToolsMcpToolset#update}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "update", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Update
        {
            get;
            set;
        }
    }
}

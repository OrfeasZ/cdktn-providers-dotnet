using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DatabaseToolsDatabaseToolsMcpToolset
{
    [JsiiByValue(fqn: "oci.databaseToolsDatabaseToolsMcpToolset.DatabaseToolsDatabaseToolsMcpToolsetVariables")]
    public class DatabaseToolsDatabaseToolsMcpToolsetVariables : oci.DatabaseToolsDatabaseToolsMcpToolset.IDatabaseToolsDatabaseToolsMcpToolsetVariables
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.23.0/docs/resources/database_tools_database_tools_mcp_toolset#description DatabaseToolsDatabaseToolsMcpToolset#description}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Description
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.23.0/docs/resources/database_tools_database_tools_mcp_toolset#name DatabaseToolsDatabaseToolsMcpToolset#name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Name
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.23.0/docs/resources/database_tools_database_tools_mcp_toolset#type DatabaseToolsDatabaseToolsMcpToolset#type}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Type
        {
            get;
            set;
        }
    }
}

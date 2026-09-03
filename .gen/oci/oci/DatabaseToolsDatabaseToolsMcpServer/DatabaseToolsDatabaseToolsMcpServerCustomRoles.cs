using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DatabaseToolsDatabaseToolsMcpServer
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.databaseToolsDatabaseToolsMcpServer.DatabaseToolsDatabaseToolsMcpServerCustomRoles")]
    public class DatabaseToolsDatabaseToolsMcpServerCustomRoles : oci.DatabaseToolsDatabaseToolsMcpServer.IDatabaseToolsDatabaseToolsMcpServerCustomRoles
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.0.0/docs/resources/database_tools_database_tools_mcp_server#description DatabaseToolsDatabaseToolsMcpServer#description}.</summary>
        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}")]
        public string Description
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.0.0/docs/resources/database_tools_database_tools_mcp_server#display_name DatabaseToolsDatabaseToolsMcpServer#display_name}.</summary>
        [JsiiProperty(name: "displayName", typeJson: "{\"primitive\":\"string\"}")]
        public string DisplayName
        {
            get;
            set;
        }
    }
}

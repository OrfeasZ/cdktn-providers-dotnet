using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DatabaseToolsDatabaseToolsMcpServer
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.databaseToolsDatabaseToolsMcpServer.DatabaseToolsDatabaseToolsMcpServerStorage")]
    public class DatabaseToolsDatabaseToolsMcpServerStorage : oci.DatabaseToolsDatabaseToolsMcpServer.IDatabaseToolsDatabaseToolsMcpServerStorage
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.24.0/docs/resources/database_tools_database_tools_mcp_server#type DatabaseToolsDatabaseToolsMcpServer#type}.</summary>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        public string Type
        {
            get;
            set;
        }

        /// <summary>bucket block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.24.0/docs/resources/database_tools_database_tools_mcp_server#bucket DatabaseToolsDatabaseToolsMcpServer#bucket}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "bucket", typeJson: "{\"fqn\":\"oci.databaseToolsDatabaseToolsMcpServer.DatabaseToolsDatabaseToolsMcpServerStorageBucket\"}", isOptional: true)]
        public oci.DatabaseToolsDatabaseToolsMcpServer.IDatabaseToolsDatabaseToolsMcpServerStorageBucket? Bucket
        {
            get;
            set;
        }
    }
}

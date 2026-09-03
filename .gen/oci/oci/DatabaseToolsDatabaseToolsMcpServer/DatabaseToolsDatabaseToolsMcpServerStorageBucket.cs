using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DatabaseToolsDatabaseToolsMcpServer
{
    [JsiiByValue(fqn: "oci.databaseToolsDatabaseToolsMcpServer.DatabaseToolsDatabaseToolsMcpServerStorageBucket")]
    public class DatabaseToolsDatabaseToolsMcpServerStorageBucket : oci.DatabaseToolsDatabaseToolsMcpServer.IDatabaseToolsDatabaseToolsMcpServerStorageBucket
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.0.0/docs/resources/database_tools_database_tools_mcp_server#bucket DatabaseToolsDatabaseToolsMcpServer#bucket}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "bucket", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Bucket
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.0.0/docs/resources/database_tools_database_tools_mcp_server#namespace DatabaseToolsDatabaseToolsMcpServer#namespace}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "namespace", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Namespace
        {
            get;
            set;
        }
    }
}

using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DatabaseToolsDatabaseToolsMcpServer
{
    [JsiiInterface(nativeType: typeof(IDatabaseToolsDatabaseToolsMcpServerStorage), fullyQualifiedName: "oci.databaseToolsDatabaseToolsMcpServer.DatabaseToolsDatabaseToolsMcpServerStorage")]
    public interface IDatabaseToolsDatabaseToolsMcpServerStorage
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.26.0/docs/resources/database_tools_database_tools_mcp_server#type DatabaseToolsDatabaseToolsMcpServer#type}.</summary>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        string Type
        {
            get;
        }

        /// <summary>bucket block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.26.0/docs/resources/database_tools_database_tools_mcp_server#bucket DatabaseToolsDatabaseToolsMcpServer#bucket}
        /// </remarks>
        [JsiiProperty(name: "bucket", typeJson: "{\"fqn\":\"oci.databaseToolsDatabaseToolsMcpServer.DatabaseToolsDatabaseToolsMcpServerStorageBucket\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.DatabaseToolsDatabaseToolsMcpServer.IDatabaseToolsDatabaseToolsMcpServerStorageBucket? Bucket
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDatabaseToolsDatabaseToolsMcpServerStorage), fullyQualifiedName: "oci.databaseToolsDatabaseToolsMcpServer.DatabaseToolsDatabaseToolsMcpServerStorage")]
        internal sealed class _Proxy : DeputyBase, oci.DatabaseToolsDatabaseToolsMcpServer.IDatabaseToolsDatabaseToolsMcpServerStorage
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.26.0/docs/resources/database_tools_database_tools_mcp_server#type DatabaseToolsDatabaseToolsMcpServer#type}.</summary>
            [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
            public string Type
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>bucket block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.26.0/docs/resources/database_tools_database_tools_mcp_server#bucket DatabaseToolsDatabaseToolsMcpServer#bucket}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "bucket", typeJson: "{\"fqn\":\"oci.databaseToolsDatabaseToolsMcpServer.DatabaseToolsDatabaseToolsMcpServerStorageBucket\"}", isOptional: true)]
            public oci.DatabaseToolsDatabaseToolsMcpServer.IDatabaseToolsDatabaseToolsMcpServerStorageBucket? Bucket
            {
                get => GetInstanceProperty<oci.DatabaseToolsDatabaseToolsMcpServer.IDatabaseToolsDatabaseToolsMcpServerStorageBucket?>();
            }
        }
    }
}

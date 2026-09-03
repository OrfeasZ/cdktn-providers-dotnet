using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DatabaseToolsDatabaseToolsMcpServer
{
    [JsiiInterface(nativeType: typeof(IDatabaseToolsDatabaseToolsMcpServerTimeouts), fullyQualifiedName: "oci.databaseToolsDatabaseToolsMcpServer.DatabaseToolsDatabaseToolsMcpServerTimeouts")]
    public interface IDatabaseToolsDatabaseToolsMcpServerTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.0.0/docs/resources/database_tools_database_tools_mcp_server#create DatabaseToolsDatabaseToolsMcpServer#create}.</summary>
        [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Create
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.0.0/docs/resources/database_tools_database_tools_mcp_server#delete DatabaseToolsDatabaseToolsMcpServer#delete}.</summary>
        [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Delete
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.0.0/docs/resources/database_tools_database_tools_mcp_server#update DatabaseToolsDatabaseToolsMcpServer#update}.</summary>
        [JsiiProperty(name: "update", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Update
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDatabaseToolsDatabaseToolsMcpServerTimeouts), fullyQualifiedName: "oci.databaseToolsDatabaseToolsMcpServer.DatabaseToolsDatabaseToolsMcpServerTimeouts")]
        internal sealed class _Proxy : DeputyBase, oci.DatabaseToolsDatabaseToolsMcpServer.IDatabaseToolsDatabaseToolsMcpServerTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.0.0/docs/resources/database_tools_database_tools_mcp_server#create DatabaseToolsDatabaseToolsMcpServer#create}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Create
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.0.0/docs/resources/database_tools_database_tools_mcp_server#delete DatabaseToolsDatabaseToolsMcpServer#delete}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Delete
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.0.0/docs/resources/database_tools_database_tools_mcp_server#update DatabaseToolsDatabaseToolsMcpServer#update}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "update", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Update
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}

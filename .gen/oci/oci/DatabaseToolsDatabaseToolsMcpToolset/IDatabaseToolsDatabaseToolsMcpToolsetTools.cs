using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DatabaseToolsDatabaseToolsMcpToolset
{
    [JsiiInterface(nativeType: typeof(IDatabaseToolsDatabaseToolsMcpToolsetTools), fullyQualifiedName: "oci.databaseToolsDatabaseToolsMcpToolset.DatabaseToolsDatabaseToolsMcpToolsetTools")]
    public interface IDatabaseToolsDatabaseToolsMcpToolsetTools
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.27.0/docs/resources/database_tools_database_tools_mcp_toolset#allowed_roles DatabaseToolsDatabaseToolsMcpToolset#allowed_roles}.</summary>
        [JsiiProperty(name: "allowedRoles", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? AllowedRoles
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.27.0/docs/resources/database_tools_database_tools_mcp_toolset#name DatabaseToolsDatabaseToolsMcpToolset#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Name
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.27.0/docs/resources/database_tools_database_tools_mcp_toolset#status DatabaseToolsDatabaseToolsMcpToolset#status}.</summary>
        [JsiiProperty(name: "status", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Status
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDatabaseToolsDatabaseToolsMcpToolsetTools), fullyQualifiedName: "oci.databaseToolsDatabaseToolsMcpToolset.DatabaseToolsDatabaseToolsMcpToolsetTools")]
        internal sealed class _Proxy : DeputyBase, oci.DatabaseToolsDatabaseToolsMcpToolset.IDatabaseToolsDatabaseToolsMcpToolsetTools
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.27.0/docs/resources/database_tools_database_tools_mcp_toolset#allowed_roles DatabaseToolsDatabaseToolsMcpToolset#allowed_roles}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "allowedRoles", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? AllowedRoles
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.27.0/docs/resources/database_tools_database_tools_mcp_toolset#name DatabaseToolsDatabaseToolsMcpToolset#name}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Name
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.27.0/docs/resources/database_tools_database_tools_mcp_toolset#status DatabaseToolsDatabaseToolsMcpToolset#status}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "status", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Status
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}

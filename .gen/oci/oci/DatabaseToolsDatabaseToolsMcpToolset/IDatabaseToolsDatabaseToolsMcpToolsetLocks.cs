using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DatabaseToolsDatabaseToolsMcpToolset
{
    [JsiiInterface(nativeType: typeof(IDatabaseToolsDatabaseToolsMcpToolsetLocks), fullyQualifiedName: "oci.databaseToolsDatabaseToolsMcpToolset.DatabaseToolsDatabaseToolsMcpToolsetLocks")]
    public interface IDatabaseToolsDatabaseToolsMcpToolsetLocks
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.22.0/docs/resources/database_tools_database_tools_mcp_toolset#type DatabaseToolsDatabaseToolsMcpToolset#type}.</summary>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        string Type
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.22.0/docs/resources/database_tools_database_tools_mcp_toolset#message DatabaseToolsDatabaseToolsMcpToolset#message}.</summary>
        [JsiiProperty(name: "message", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Message
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.22.0/docs/resources/database_tools_database_tools_mcp_toolset#related_resource_id DatabaseToolsDatabaseToolsMcpToolset#related_resource_id}.</summary>
        [JsiiProperty(name: "relatedResourceId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? RelatedResourceId
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.22.0/docs/resources/database_tools_database_tools_mcp_toolset#time_created DatabaseToolsDatabaseToolsMcpToolset#time_created}.</summary>
        [JsiiProperty(name: "timeCreated", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? TimeCreated
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDatabaseToolsDatabaseToolsMcpToolsetLocks), fullyQualifiedName: "oci.databaseToolsDatabaseToolsMcpToolset.DatabaseToolsDatabaseToolsMcpToolsetLocks")]
        internal sealed class _Proxy : DeputyBase, oci.DatabaseToolsDatabaseToolsMcpToolset.IDatabaseToolsDatabaseToolsMcpToolsetLocks
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.22.0/docs/resources/database_tools_database_tools_mcp_toolset#type DatabaseToolsDatabaseToolsMcpToolset#type}.</summary>
            [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
            public string Type
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.22.0/docs/resources/database_tools_database_tools_mcp_toolset#message DatabaseToolsDatabaseToolsMcpToolset#message}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "message", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Message
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.22.0/docs/resources/database_tools_database_tools_mcp_toolset#related_resource_id DatabaseToolsDatabaseToolsMcpToolset#related_resource_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "relatedResourceId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? RelatedResourceId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.22.0/docs/resources/database_tools_database_tools_mcp_toolset#time_created DatabaseToolsDatabaseToolsMcpToolset#time_created}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "timeCreated", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? TimeCreated
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}

using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DatabaseToolsDatabaseToolsIdentity
{
    [JsiiInterface(nativeType: typeof(IDatabaseToolsDatabaseToolsIdentityLocks), fullyQualifiedName: "oci.databaseToolsDatabaseToolsIdentity.DatabaseToolsDatabaseToolsIdentityLocks")]
    public interface IDatabaseToolsDatabaseToolsIdentityLocks
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.29.0/docs/resources/database_tools_database_tools_identity#type DatabaseToolsDatabaseToolsIdentity#type}.</summary>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        string Type
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.29.0/docs/resources/database_tools_database_tools_identity#message DatabaseToolsDatabaseToolsIdentity#message}.</summary>
        [JsiiProperty(name: "message", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Message
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDatabaseToolsDatabaseToolsIdentityLocks), fullyQualifiedName: "oci.databaseToolsDatabaseToolsIdentity.DatabaseToolsDatabaseToolsIdentityLocks")]
        internal sealed class _Proxy : DeputyBase, oci.DatabaseToolsDatabaseToolsIdentity.IDatabaseToolsDatabaseToolsIdentityLocks
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.29.0/docs/resources/database_tools_database_tools_identity#type DatabaseToolsDatabaseToolsIdentity#type}.</summary>
            [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
            public string Type
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.29.0/docs/resources/database_tools_database_tools_identity#message DatabaseToolsDatabaseToolsIdentity#message}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "message", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Message
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}

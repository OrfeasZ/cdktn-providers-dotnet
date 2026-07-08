using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DatabaseToolsDatabaseToolsIdentity
{
    [JsiiInterface(nativeType: typeof(IDatabaseToolsDatabaseToolsIdentityTimeouts), fullyQualifiedName: "oci.databaseToolsDatabaseToolsIdentity.DatabaseToolsDatabaseToolsIdentityTimeouts")]
    public interface IDatabaseToolsDatabaseToolsIdentityTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.22.0/docs/resources/database_tools_database_tools_identity#create DatabaseToolsDatabaseToolsIdentity#create}.</summary>
        [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Create
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.22.0/docs/resources/database_tools_database_tools_identity#delete DatabaseToolsDatabaseToolsIdentity#delete}.</summary>
        [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Delete
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.22.0/docs/resources/database_tools_database_tools_identity#update DatabaseToolsDatabaseToolsIdentity#update}.</summary>
        [JsiiProperty(name: "update", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Update
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDatabaseToolsDatabaseToolsIdentityTimeouts), fullyQualifiedName: "oci.databaseToolsDatabaseToolsIdentity.DatabaseToolsDatabaseToolsIdentityTimeouts")]
        internal sealed class _Proxy : DeputyBase, oci.DatabaseToolsDatabaseToolsIdentity.IDatabaseToolsDatabaseToolsIdentityTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.22.0/docs/resources/database_tools_database_tools_identity#create DatabaseToolsDatabaseToolsIdentity#create}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Create
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.22.0/docs/resources/database_tools_database_tools_identity#delete DatabaseToolsDatabaseToolsIdentity#delete}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Delete
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.22.0/docs/resources/database_tools_database_tools_identity#update DatabaseToolsDatabaseToolsIdentity#update}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "update", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Update
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}

using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DatabaseToolsDatabaseToolsConnection
{
    [JsiiInterface(nativeType: typeof(IDatabaseToolsDatabaseToolsConnectionKeyStoresKeyStoreContent), fullyQualifiedName: "oci.databaseToolsDatabaseToolsConnection.DatabaseToolsDatabaseToolsConnectionKeyStoresKeyStoreContent")]
    public interface IDatabaseToolsDatabaseToolsConnectionKeyStoresKeyStoreContent
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_tools_database_tools_connection#value_type DatabaseToolsDatabaseToolsConnection#value_type}.</summary>
        [JsiiProperty(name: "valueType", typeJson: "{\"primitive\":\"string\"}")]
        string ValueType
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_tools_database_tools_connection#secret_id DatabaseToolsDatabaseToolsConnection#secret_id}.</summary>
        [JsiiProperty(name: "secretId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? SecretId
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDatabaseToolsDatabaseToolsConnectionKeyStoresKeyStoreContent), fullyQualifiedName: "oci.databaseToolsDatabaseToolsConnection.DatabaseToolsDatabaseToolsConnectionKeyStoresKeyStoreContent")]
        internal sealed class _Proxy : DeputyBase, oci.DatabaseToolsDatabaseToolsConnection.IDatabaseToolsDatabaseToolsConnectionKeyStoresKeyStoreContent
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_tools_database_tools_connection#value_type DatabaseToolsDatabaseToolsConnection#value_type}.</summary>
            [JsiiProperty(name: "valueType", typeJson: "{\"primitive\":\"string\"}")]
            public string ValueType
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_tools_database_tools_connection#secret_id DatabaseToolsDatabaseToolsConnection#secret_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "secretId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? SecretId
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}

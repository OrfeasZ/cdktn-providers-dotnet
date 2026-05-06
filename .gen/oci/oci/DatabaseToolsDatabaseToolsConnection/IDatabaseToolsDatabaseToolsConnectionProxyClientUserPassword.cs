using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DatabaseToolsDatabaseToolsConnection
{
    [JsiiInterface(nativeType: typeof(IDatabaseToolsDatabaseToolsConnectionProxyClientUserPassword), fullyQualifiedName: "oci.databaseToolsDatabaseToolsConnection.DatabaseToolsDatabaseToolsConnectionProxyClientUserPassword")]
    public interface IDatabaseToolsDatabaseToolsConnectionProxyClientUserPassword
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_tools_database_tools_connection#secret_id DatabaseToolsDatabaseToolsConnection#secret_id}.</summary>
        [JsiiProperty(name: "secretId", typeJson: "{\"primitive\":\"string\"}")]
        string SecretId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_tools_database_tools_connection#value_type DatabaseToolsDatabaseToolsConnection#value_type}.</summary>
        [JsiiProperty(name: "valueType", typeJson: "{\"primitive\":\"string\"}")]
        string ValueType
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IDatabaseToolsDatabaseToolsConnectionProxyClientUserPassword), fullyQualifiedName: "oci.databaseToolsDatabaseToolsConnection.DatabaseToolsDatabaseToolsConnectionProxyClientUserPassword")]
        internal sealed class _Proxy : DeputyBase, oci.DatabaseToolsDatabaseToolsConnection.IDatabaseToolsDatabaseToolsConnectionProxyClientUserPassword
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_tools_database_tools_connection#secret_id DatabaseToolsDatabaseToolsConnection#secret_id}.</summary>
            [JsiiProperty(name: "secretId", typeJson: "{\"primitive\":\"string\"}")]
            public string SecretId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_tools_database_tools_connection#value_type DatabaseToolsDatabaseToolsConnection#value_type}.</summary>
            [JsiiProperty(name: "valueType", typeJson: "{\"primitive\":\"string\"}")]
            public string ValueType
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}

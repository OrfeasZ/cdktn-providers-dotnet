using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DatabaseToolsDatabaseToolsConnection
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.databaseToolsDatabaseToolsConnection.DatabaseToolsDatabaseToolsConnectionKeyStoresKeyStorePassword")]
    public class DatabaseToolsDatabaseToolsConnectionKeyStoresKeyStorePassword : oci.DatabaseToolsDatabaseToolsConnection.IDatabaseToolsDatabaseToolsConnectionKeyStoresKeyStorePassword
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_tools_database_tools_connection#value_type DatabaseToolsDatabaseToolsConnection#value_type}.</summary>
        [JsiiProperty(name: "valueType", typeJson: "{\"primitive\":\"string\"}")]
        public string ValueType
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_tools_database_tools_connection#secret_id DatabaseToolsDatabaseToolsConnection#secret_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "secretId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? SecretId
        {
            get;
            set;
        }
    }
}

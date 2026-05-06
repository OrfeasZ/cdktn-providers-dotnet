using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DatabaseToolsDatabaseToolsConnection
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.databaseToolsDatabaseToolsConnection.DatabaseToolsDatabaseToolsConnectionProxyClientUserPassword")]
    public class DatabaseToolsDatabaseToolsConnectionProxyClientUserPassword : oci.DatabaseToolsDatabaseToolsConnection.IDatabaseToolsDatabaseToolsConnectionProxyClientUserPassword
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_tools_database_tools_connection#secret_id DatabaseToolsDatabaseToolsConnection#secret_id}.</summary>
        [JsiiProperty(name: "secretId", typeJson: "{\"primitive\":\"string\"}")]
        public string SecretId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_tools_database_tools_connection#value_type DatabaseToolsDatabaseToolsConnection#value_type}.</summary>
        [JsiiProperty(name: "valueType", typeJson: "{\"primitive\":\"string\"}")]
        public string ValueType
        {
            get;
            set;
        }
    }
}

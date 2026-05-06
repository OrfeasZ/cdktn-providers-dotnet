using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DatabaseToolsDatabaseToolsConnection
{
    [JsiiByValue(fqn: "oci.databaseToolsDatabaseToolsConnection.DatabaseToolsDatabaseToolsConnectionKeyStores")]
    public class DatabaseToolsDatabaseToolsConnectionKeyStores : oci.DatabaseToolsDatabaseToolsConnection.IDatabaseToolsDatabaseToolsConnectionKeyStores
    {
        /// <summary>key_store_content block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_tools_database_tools_connection#key_store_content DatabaseToolsDatabaseToolsConnection#key_store_content}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "keyStoreContent", typeJson: "{\"fqn\":\"oci.databaseToolsDatabaseToolsConnection.DatabaseToolsDatabaseToolsConnectionKeyStoresKeyStoreContent\"}", isOptional: true)]
        public oci.DatabaseToolsDatabaseToolsConnection.IDatabaseToolsDatabaseToolsConnectionKeyStoresKeyStoreContent? KeyStoreContent
        {
            get;
            set;
        }

        /// <summary>key_store_password block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_tools_database_tools_connection#key_store_password DatabaseToolsDatabaseToolsConnection#key_store_password}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "keyStorePassword", typeJson: "{\"fqn\":\"oci.databaseToolsDatabaseToolsConnection.DatabaseToolsDatabaseToolsConnectionKeyStoresKeyStorePassword\"}", isOptional: true)]
        public oci.DatabaseToolsDatabaseToolsConnection.IDatabaseToolsDatabaseToolsConnectionKeyStoresKeyStorePassword? KeyStorePassword
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_tools_database_tools_connection#key_store_type DatabaseToolsDatabaseToolsConnection#key_store_type}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "keyStoreType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? KeyStoreType
        {
            get;
            set;
        }
    }
}

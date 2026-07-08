using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DatabaseToolsRuntimeDatabaseToolsConnectionCredentialPublicSynonym
{
    [JsiiByValue(fqn: "oci.databaseToolsRuntimeDatabaseToolsConnectionCredentialPublicSynonym.DatabaseToolsRuntimeDatabaseToolsConnectionCredentialPublicSynonymTimeouts")]
    public class DatabaseToolsRuntimeDatabaseToolsConnectionCredentialPublicSynonymTimeouts : oci.DatabaseToolsRuntimeDatabaseToolsConnectionCredentialPublicSynonym.IDatabaseToolsRuntimeDatabaseToolsConnectionCredentialPublicSynonymTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.22.0/docs/resources/database_tools_runtime_database_tools_connection_credential_public_synonym#create DatabaseToolsRuntimeDatabaseToolsConnectionCredentialPublicSynonym#create}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Create
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.22.0/docs/resources/database_tools_runtime_database_tools_connection_credential_public_synonym#delete DatabaseToolsRuntimeDatabaseToolsConnectionCredentialPublicSynonym#delete}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Delete
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.22.0/docs/resources/database_tools_runtime_database_tools_connection_credential_public_synonym#update DatabaseToolsRuntimeDatabaseToolsConnectionCredentialPublicSynonym#update}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "update", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Update
        {
            get;
            set;
        }
    }
}

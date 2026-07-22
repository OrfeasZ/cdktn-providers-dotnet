using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DatabaseToolsRuntimeDatabaseToolsConnectionCredentialExecuteGrantee
{
    [JsiiByValue(fqn: "oci.databaseToolsRuntimeDatabaseToolsConnectionCredentialExecuteGrantee.DatabaseToolsRuntimeDatabaseToolsConnectionCredentialExecuteGranteeTimeouts")]
    public class DatabaseToolsRuntimeDatabaseToolsConnectionCredentialExecuteGranteeTimeouts : oci.DatabaseToolsRuntimeDatabaseToolsConnectionCredentialExecuteGrantee.IDatabaseToolsRuntimeDatabaseToolsConnectionCredentialExecuteGranteeTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.24.0/docs/resources/database_tools_runtime_database_tools_connection_credential_execute_grantee#create DatabaseToolsRuntimeDatabaseToolsConnectionCredentialExecuteGrantee#create}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Create
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.24.0/docs/resources/database_tools_runtime_database_tools_connection_credential_execute_grantee#delete DatabaseToolsRuntimeDatabaseToolsConnectionCredentialExecuteGrantee#delete}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Delete
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.24.0/docs/resources/database_tools_runtime_database_tools_connection_credential_execute_grantee#update DatabaseToolsRuntimeDatabaseToolsConnectionCredentialExecuteGrantee#update}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "update", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Update
        {
            get;
            set;
        }
    }
}

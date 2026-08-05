using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DatabaseToolsRuntimeDatabaseToolsConnectionCredentialPublicSynonym
{
    [JsiiInterface(nativeType: typeof(IDatabaseToolsRuntimeDatabaseToolsConnectionCredentialPublicSynonymTimeouts), fullyQualifiedName: "oci.databaseToolsRuntimeDatabaseToolsConnectionCredentialPublicSynonym.DatabaseToolsRuntimeDatabaseToolsConnectionCredentialPublicSynonymTimeouts")]
    public interface IDatabaseToolsRuntimeDatabaseToolsConnectionCredentialPublicSynonymTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.26.0/docs/resources/database_tools_runtime_database_tools_connection_credential_public_synonym#create DatabaseToolsRuntimeDatabaseToolsConnectionCredentialPublicSynonym#create}.</summary>
        [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Create
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.26.0/docs/resources/database_tools_runtime_database_tools_connection_credential_public_synonym#delete DatabaseToolsRuntimeDatabaseToolsConnectionCredentialPublicSynonym#delete}.</summary>
        [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Delete
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.26.0/docs/resources/database_tools_runtime_database_tools_connection_credential_public_synonym#update DatabaseToolsRuntimeDatabaseToolsConnectionCredentialPublicSynonym#update}.</summary>
        [JsiiProperty(name: "update", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Update
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDatabaseToolsRuntimeDatabaseToolsConnectionCredentialPublicSynonymTimeouts), fullyQualifiedName: "oci.databaseToolsRuntimeDatabaseToolsConnectionCredentialPublicSynonym.DatabaseToolsRuntimeDatabaseToolsConnectionCredentialPublicSynonymTimeouts")]
        internal sealed class _Proxy : DeputyBase, oci.DatabaseToolsRuntimeDatabaseToolsConnectionCredentialPublicSynonym.IDatabaseToolsRuntimeDatabaseToolsConnectionCredentialPublicSynonymTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.26.0/docs/resources/database_tools_runtime_database_tools_connection_credential_public_synonym#create DatabaseToolsRuntimeDatabaseToolsConnectionCredentialPublicSynonym#create}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Create
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.26.0/docs/resources/database_tools_runtime_database_tools_connection_credential_public_synonym#delete DatabaseToolsRuntimeDatabaseToolsConnectionCredentialPublicSynonym#delete}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Delete
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.26.0/docs/resources/database_tools_runtime_database_tools_connection_credential_public_synonym#update DatabaseToolsRuntimeDatabaseToolsConnectionCredentialPublicSynonym#update}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "update", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Update
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}

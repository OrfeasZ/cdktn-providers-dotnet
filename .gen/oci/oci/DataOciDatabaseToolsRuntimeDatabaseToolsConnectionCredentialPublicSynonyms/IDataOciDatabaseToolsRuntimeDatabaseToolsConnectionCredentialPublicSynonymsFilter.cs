using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciDatabaseToolsRuntimeDatabaseToolsConnectionCredentialPublicSynonyms
{
    [JsiiInterface(nativeType: typeof(IDataOciDatabaseToolsRuntimeDatabaseToolsConnectionCredentialPublicSynonymsFilter), fullyQualifiedName: "oci.dataOciDatabaseToolsRuntimeDatabaseToolsConnectionCredentialPublicSynonyms.DataOciDatabaseToolsRuntimeDatabaseToolsConnectionCredentialPublicSynonymsFilter")]
    public interface IDataOciDatabaseToolsRuntimeDatabaseToolsConnectionCredentialPublicSynonymsFilter
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.28.0/docs/data-sources/database_tools_runtime_database_tools_connection_credential_public_synonyms#name DataOciDatabaseToolsRuntimeDatabaseToolsConnectionCredentialPublicSynonyms#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.28.0/docs/data-sources/database_tools_runtime_database_tools_connection_credential_public_synonyms#values DataOciDatabaseToolsRuntimeDatabaseToolsConnectionCredentialPublicSynonyms#values}.</summary>
        [JsiiProperty(name: "values", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        string[] Values
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.28.0/docs/data-sources/database_tools_runtime_database_tools_connection_credential_public_synonyms#regex DataOciDatabaseToolsRuntimeDatabaseToolsConnectionCredentialPublicSynonyms#regex}.</summary>
        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "regex", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Regex
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataOciDatabaseToolsRuntimeDatabaseToolsConnectionCredentialPublicSynonymsFilter), fullyQualifiedName: "oci.dataOciDatabaseToolsRuntimeDatabaseToolsConnectionCredentialPublicSynonyms.DataOciDatabaseToolsRuntimeDatabaseToolsConnectionCredentialPublicSynonymsFilter")]
        internal sealed class _Proxy : DeputyBase, oci.DataOciDatabaseToolsRuntimeDatabaseToolsConnectionCredentialPublicSynonyms.IDataOciDatabaseToolsRuntimeDatabaseToolsConnectionCredentialPublicSynonymsFilter
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.28.0/docs/data-sources/database_tools_runtime_database_tools_connection_credential_public_synonyms#name DataOciDatabaseToolsRuntimeDatabaseToolsConnectionCredentialPublicSynonyms#name}.</summary>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.28.0/docs/data-sources/database_tools_runtime_database_tools_connection_credential_public_synonyms#values DataOciDatabaseToolsRuntimeDatabaseToolsConnectionCredentialPublicSynonyms#values}.</summary>
            [JsiiProperty(name: "values", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
            public string[] Values
            {
                get => GetInstanceProperty<string[]>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.28.0/docs/data-sources/database_tools_runtime_database_tools_connection_credential_public_synonyms#regex DataOciDatabaseToolsRuntimeDatabaseToolsConnectionCredentialPublicSynonyms#regex}.</summary>
            /// <remarks>
            /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "regex", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? Regex
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}

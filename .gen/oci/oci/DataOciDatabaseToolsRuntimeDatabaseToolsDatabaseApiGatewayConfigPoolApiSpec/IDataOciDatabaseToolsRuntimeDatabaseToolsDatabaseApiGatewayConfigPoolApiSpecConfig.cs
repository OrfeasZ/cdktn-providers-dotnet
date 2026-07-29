using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciDatabaseToolsRuntimeDatabaseToolsDatabaseApiGatewayConfigPoolApiSpec
{
    [JsiiInterface(nativeType: typeof(IDataOciDatabaseToolsRuntimeDatabaseToolsDatabaseApiGatewayConfigPoolApiSpecConfig), fullyQualifiedName: "oci.dataOciDatabaseToolsRuntimeDatabaseToolsDatabaseApiGatewayConfigPoolApiSpec.DataOciDatabaseToolsRuntimeDatabaseToolsDatabaseApiGatewayConfigPoolApiSpecConfig")]
    public interface IDataOciDatabaseToolsRuntimeDatabaseToolsDatabaseApiGatewayConfigPoolApiSpecConfig : Io.Cdktn.ITerraformMetaArguments
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.25.0/docs/data-sources/database_tools_runtime_database_tools_database_api_gateway_config_pool_api_spec#api_spec_key DataOciDatabaseToolsRuntimeDatabaseToolsDatabaseApiGatewayConfigPoolApiSpec#api_spec_key}.</summary>
        [JsiiProperty(name: "apiSpecKey", typeJson: "{\"primitive\":\"string\"}")]
        string ApiSpecKey
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.25.0/docs/data-sources/database_tools_runtime_database_tools_database_api_gateway_config_pool_api_spec#database_tools_database_api_gateway_config_id DataOciDatabaseToolsRuntimeDatabaseToolsDatabaseApiGatewayConfigPoolApiSpec#database_tools_database_api_gateway_config_id}.</summary>
        [JsiiProperty(name: "databaseToolsDatabaseApiGatewayConfigId", typeJson: "{\"primitive\":\"string\"}")]
        string DatabaseToolsDatabaseApiGatewayConfigId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.25.0/docs/data-sources/database_tools_runtime_database_tools_database_api_gateway_config_pool_api_spec#pool_key DataOciDatabaseToolsRuntimeDatabaseToolsDatabaseApiGatewayConfigPoolApiSpec#pool_key}.</summary>
        [JsiiProperty(name: "poolKey", typeJson: "{\"primitive\":\"string\"}")]
        string PoolKey
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IDataOciDatabaseToolsRuntimeDatabaseToolsDatabaseApiGatewayConfigPoolApiSpecConfig), fullyQualifiedName: "oci.dataOciDatabaseToolsRuntimeDatabaseToolsDatabaseApiGatewayConfigPoolApiSpec.DataOciDatabaseToolsRuntimeDatabaseToolsDatabaseApiGatewayConfigPoolApiSpecConfig")]
        internal sealed class _Proxy : DeputyBase, oci.DataOciDatabaseToolsRuntimeDatabaseToolsDatabaseApiGatewayConfigPoolApiSpec.IDataOciDatabaseToolsRuntimeDatabaseToolsDatabaseApiGatewayConfigPoolApiSpecConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.25.0/docs/data-sources/database_tools_runtime_database_tools_database_api_gateway_config_pool_api_spec#api_spec_key DataOciDatabaseToolsRuntimeDatabaseToolsDatabaseApiGatewayConfigPoolApiSpec#api_spec_key}.</summary>
            [JsiiProperty(name: "apiSpecKey", typeJson: "{\"primitive\":\"string\"}")]
            public string ApiSpecKey
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.25.0/docs/data-sources/database_tools_runtime_database_tools_database_api_gateway_config_pool_api_spec#database_tools_database_api_gateway_config_id DataOciDatabaseToolsRuntimeDatabaseToolsDatabaseApiGatewayConfigPoolApiSpec#database_tools_database_api_gateway_config_id}.</summary>
            [JsiiProperty(name: "databaseToolsDatabaseApiGatewayConfigId", typeJson: "{\"primitive\":\"string\"}")]
            public string DatabaseToolsDatabaseApiGatewayConfigId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.25.0/docs/data-sources/database_tools_runtime_database_tools_database_api_gateway_config_pool_api_spec#pool_key DataOciDatabaseToolsRuntimeDatabaseToolsDatabaseApiGatewayConfigPoolApiSpec#pool_key}.</summary>
            [JsiiProperty(name: "poolKey", typeJson: "{\"primitive\":\"string\"}")]
            public string PoolKey
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// <para>Type union: either <see cref="Io.Cdktn.ISSHProvisionerConnection" /> or <see cref="Io.Cdktn.IWinrmProvisionerConnection" /></para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "connection", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.SSHProvisionerConnection\"},{\"fqn\":\"cdktn.WinrmProvisionerConnection\"}]}}", isOptional: true)]
            public object? Connection
            {
                get => GetInstanceProperty<object?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// <para>Type union: either double or <see cref="Io.Cdktn.TerraformCount" /></para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "count", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"number\"},{\"fqn\":\"cdktn.TerraformCount\"}]}}", isOptional: true)]
            public object? Count
            {
                get => GetInstanceProperty<object?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "dependsOn", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"cdktn.ITerraformDependable\"},\"kind\":\"array\"}}", isOptional: true)]
            public Io.Cdktn.ITerraformDependable[]? DependsOn
            {
                get => GetInstanceProperty<Io.Cdktn.ITerraformDependable[]?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "forEach", typeJson: "{\"fqn\":\"cdktn.ITerraformIterator\"}", isOptional: true)]
            public Io.Cdktn.ITerraformIterator? ForEach
            {
                get => GetInstanceProperty<Io.Cdktn.ITerraformIterator?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "lifecycle", typeJson: "{\"fqn\":\"cdktn.TerraformResourceLifecycle\"}", isOptional: true)]
            public Io.Cdktn.ITerraformResourceLifecycle? Lifecycle
            {
                get => GetInstanceProperty<Io.Cdktn.ITerraformResourceLifecycle?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "provider", typeJson: "{\"fqn\":\"cdktn.TerraformProvider\"}", isOptional: true)]
            public Io.Cdktn.TerraformProvider? Provider
            {
                get => GetInstanceProperty<Io.Cdktn.TerraformProvider?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// <para>Type union: (either <see cref="Io.Cdktn.IFileProvisioner" /> or <see cref="Io.Cdktn.ILocalExecProvisioner" /> or <see cref="Io.Cdktn.IRemoteExecProvisioner" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "provisioners", typeJson: "{\"collection\":{\"elementtype\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.FileProvisioner\"},{\"fqn\":\"cdktn.LocalExecProvisioner\"},{\"fqn\":\"cdktn.RemoteExecProvisioner\"}]}},\"kind\":\"array\"}}", isOptional: true)]
            public object[]? Provisioners
            {
                get => GetInstanceProperty<object[]?>();
            }
        }
    }
}

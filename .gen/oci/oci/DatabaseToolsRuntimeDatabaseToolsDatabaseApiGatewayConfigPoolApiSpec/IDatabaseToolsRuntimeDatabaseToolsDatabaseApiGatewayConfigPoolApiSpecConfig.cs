using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DatabaseToolsRuntimeDatabaseToolsDatabaseApiGatewayConfigPoolApiSpec
{
    [JsiiInterface(nativeType: typeof(IDatabaseToolsRuntimeDatabaseToolsDatabaseApiGatewayConfigPoolApiSpecConfig), fullyQualifiedName: "oci.databaseToolsRuntimeDatabaseToolsDatabaseApiGatewayConfigPoolApiSpec.DatabaseToolsRuntimeDatabaseToolsDatabaseApiGatewayConfigPoolApiSpecConfig")]
    public interface IDatabaseToolsRuntimeDatabaseToolsDatabaseApiGatewayConfigPoolApiSpecConfig : Io.Cdktn.ITerraformMetaArguments
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.29.0/docs/resources/database_tools_runtime_database_tools_database_api_gateway_config_pool_api_spec#content DatabaseToolsRuntimeDatabaseToolsDatabaseApiGatewayConfigPoolApiSpec#content}.</summary>
        [JsiiProperty(name: "content", typeJson: "{\"primitive\":\"string\"}")]
        string Content
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.29.0/docs/resources/database_tools_runtime_database_tools_database_api_gateway_config_pool_api_spec#database_tools_database_api_gateway_config_id DatabaseToolsRuntimeDatabaseToolsDatabaseApiGatewayConfigPoolApiSpec#database_tools_database_api_gateway_config_id}.</summary>
        [JsiiProperty(name: "databaseToolsDatabaseApiGatewayConfigId", typeJson: "{\"primitive\":\"string\"}")]
        string DatabaseToolsDatabaseApiGatewayConfigId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.29.0/docs/resources/database_tools_runtime_database_tools_database_api_gateway_config_pool_api_spec#display_name DatabaseToolsRuntimeDatabaseToolsDatabaseApiGatewayConfigPoolApiSpec#display_name}.</summary>
        [JsiiProperty(name: "displayName", typeJson: "{\"primitive\":\"string\"}")]
        string DisplayName
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.29.0/docs/resources/database_tools_runtime_database_tools_database_api_gateway_config_pool_api_spec#pool_key DatabaseToolsRuntimeDatabaseToolsDatabaseApiGatewayConfigPoolApiSpec#pool_key}.</summary>
        [JsiiProperty(name: "poolKey", typeJson: "{\"primitive\":\"string\"}")]
        string PoolKey
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.29.0/docs/resources/database_tools_runtime_database_tools_database_api_gateway_config_pool_api_spec#type DatabaseToolsRuntimeDatabaseToolsDatabaseApiGatewayConfigPoolApiSpec#type}.</summary>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        string Type
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.29.0/docs/resources/database_tools_runtime_database_tools_database_api_gateway_config_pool_api_spec#id DatabaseToolsRuntimeDatabaseToolsDatabaseApiGatewayConfigPoolApiSpec#id}.</summary>
        /// <remarks>
        /// Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2.
        /// If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </remarks>
        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Id
        {
            get
            {
                return null;
            }
        }

        /// <summary>timeouts block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.29.0/docs/resources/database_tools_runtime_database_tools_database_api_gateway_config_pool_api_spec#timeouts DatabaseToolsRuntimeDatabaseToolsDatabaseApiGatewayConfigPoolApiSpec#timeouts}
        /// </remarks>
        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"oci.databaseToolsRuntimeDatabaseToolsDatabaseApiGatewayConfigPoolApiSpec.DatabaseToolsRuntimeDatabaseToolsDatabaseApiGatewayConfigPoolApiSpecTimeouts\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.DatabaseToolsRuntimeDatabaseToolsDatabaseApiGatewayConfigPoolApiSpec.IDatabaseToolsRuntimeDatabaseToolsDatabaseApiGatewayConfigPoolApiSpecTimeouts? Timeouts
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDatabaseToolsRuntimeDatabaseToolsDatabaseApiGatewayConfigPoolApiSpecConfig), fullyQualifiedName: "oci.databaseToolsRuntimeDatabaseToolsDatabaseApiGatewayConfigPoolApiSpec.DatabaseToolsRuntimeDatabaseToolsDatabaseApiGatewayConfigPoolApiSpecConfig")]
        internal sealed class _Proxy : DeputyBase, oci.DatabaseToolsRuntimeDatabaseToolsDatabaseApiGatewayConfigPoolApiSpec.IDatabaseToolsRuntimeDatabaseToolsDatabaseApiGatewayConfigPoolApiSpecConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.29.0/docs/resources/database_tools_runtime_database_tools_database_api_gateway_config_pool_api_spec#content DatabaseToolsRuntimeDatabaseToolsDatabaseApiGatewayConfigPoolApiSpec#content}.</summary>
            [JsiiProperty(name: "content", typeJson: "{\"primitive\":\"string\"}")]
            public string Content
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.29.0/docs/resources/database_tools_runtime_database_tools_database_api_gateway_config_pool_api_spec#database_tools_database_api_gateway_config_id DatabaseToolsRuntimeDatabaseToolsDatabaseApiGatewayConfigPoolApiSpec#database_tools_database_api_gateway_config_id}.</summary>
            [JsiiProperty(name: "databaseToolsDatabaseApiGatewayConfigId", typeJson: "{\"primitive\":\"string\"}")]
            public string DatabaseToolsDatabaseApiGatewayConfigId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.29.0/docs/resources/database_tools_runtime_database_tools_database_api_gateway_config_pool_api_spec#display_name DatabaseToolsRuntimeDatabaseToolsDatabaseApiGatewayConfigPoolApiSpec#display_name}.</summary>
            [JsiiProperty(name: "displayName", typeJson: "{\"primitive\":\"string\"}")]
            public string DisplayName
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.29.0/docs/resources/database_tools_runtime_database_tools_database_api_gateway_config_pool_api_spec#pool_key DatabaseToolsRuntimeDatabaseToolsDatabaseApiGatewayConfigPoolApiSpec#pool_key}.</summary>
            [JsiiProperty(name: "poolKey", typeJson: "{\"primitive\":\"string\"}")]
            public string PoolKey
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.29.0/docs/resources/database_tools_runtime_database_tools_database_api_gateway_config_pool_api_spec#type DatabaseToolsRuntimeDatabaseToolsDatabaseApiGatewayConfigPoolApiSpec#type}.</summary>
            [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
            public string Type
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.29.0/docs/resources/database_tools_runtime_database_tools_database_api_gateway_config_pool_api_spec#id DatabaseToolsRuntimeDatabaseToolsDatabaseApiGatewayConfigPoolApiSpec#id}.</summary>
            /// <remarks>
            /// Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2.
            /// If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Id
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>timeouts block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.29.0/docs/resources/database_tools_runtime_database_tools_database_api_gateway_config_pool_api_spec#timeouts DatabaseToolsRuntimeDatabaseToolsDatabaseApiGatewayConfigPoolApiSpec#timeouts}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"oci.databaseToolsRuntimeDatabaseToolsDatabaseApiGatewayConfigPoolApiSpec.DatabaseToolsRuntimeDatabaseToolsDatabaseApiGatewayConfigPoolApiSpecTimeouts\"}", isOptional: true)]
            public oci.DatabaseToolsRuntimeDatabaseToolsDatabaseApiGatewayConfigPoolApiSpec.IDatabaseToolsRuntimeDatabaseToolsDatabaseApiGatewayConfigPoolApiSpecTimeouts? Timeouts
            {
                get => GetInstanceProperty<oci.DatabaseToolsRuntimeDatabaseToolsDatabaseApiGatewayConfigPoolApiSpec.IDatabaseToolsRuntimeDatabaseToolsDatabaseApiGatewayConfigPoolApiSpecTimeouts?>();
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

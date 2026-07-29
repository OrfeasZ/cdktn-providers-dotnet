using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DatabaseToolsRuntimeDatabaseToolsDatabaseApiGatewayConfigPoolAutoApiSpec
{
    [JsiiInterface(nativeType: typeof(IDatabaseToolsRuntimeDatabaseToolsDatabaseApiGatewayConfigPoolAutoApiSpecConfig), fullyQualifiedName: "oci.databaseToolsRuntimeDatabaseToolsDatabaseApiGatewayConfigPoolAutoApiSpec.DatabaseToolsRuntimeDatabaseToolsDatabaseApiGatewayConfigPoolAutoApiSpecConfig")]
    public interface IDatabaseToolsRuntimeDatabaseToolsDatabaseApiGatewayConfigPoolAutoApiSpecConfig : Io.Cdktn.ITerraformMetaArguments
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.25.0/docs/resources/database_tools_runtime_database_tools_database_api_gateway_config_pool_auto_api_spec#database_object_name DatabaseToolsRuntimeDatabaseToolsDatabaseApiGatewayConfigPoolAutoApiSpec#database_object_name}.</summary>
        [JsiiProperty(name: "databaseObjectName", typeJson: "{\"primitive\":\"string\"}")]
        string DatabaseObjectName
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.25.0/docs/resources/database_tools_runtime_database_tools_database_api_gateway_config_pool_auto_api_spec#database_object_type DatabaseToolsRuntimeDatabaseToolsDatabaseApiGatewayConfigPoolAutoApiSpec#database_object_type}.</summary>
        [JsiiProperty(name: "databaseObjectType", typeJson: "{\"primitive\":\"string\"}")]
        string DatabaseObjectType
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.25.0/docs/resources/database_tools_runtime_database_tools_database_api_gateway_config_pool_auto_api_spec#database_tools_database_api_gateway_config_id DatabaseToolsRuntimeDatabaseToolsDatabaseApiGatewayConfigPoolAutoApiSpec#database_tools_database_api_gateway_config_id}.</summary>
        [JsiiProperty(name: "databaseToolsDatabaseApiGatewayConfigId", typeJson: "{\"primitive\":\"string\"}")]
        string DatabaseToolsDatabaseApiGatewayConfigId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.25.0/docs/resources/database_tools_runtime_database_tools_database_api_gateway_config_pool_auto_api_spec#display_name DatabaseToolsRuntimeDatabaseToolsDatabaseApiGatewayConfigPoolAutoApiSpec#display_name}.</summary>
        [JsiiProperty(name: "displayName", typeJson: "{\"primitive\":\"string\"}")]
        string DisplayName
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.25.0/docs/resources/database_tools_runtime_database_tools_database_api_gateway_config_pool_auto_api_spec#pool_key DatabaseToolsRuntimeDatabaseToolsDatabaseApiGatewayConfigPoolAutoApiSpec#pool_key}.</summary>
        [JsiiProperty(name: "poolKey", typeJson: "{\"primitive\":\"string\"}")]
        string PoolKey
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.25.0/docs/resources/database_tools_runtime_database_tools_database_api_gateway_config_pool_auto_api_spec#type DatabaseToolsRuntimeDatabaseToolsDatabaseApiGatewayConfigPoolAutoApiSpec#type}.</summary>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        string Type
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.25.0/docs/resources/database_tools_runtime_database_tools_database_api_gateway_config_pool_auto_api_spec#alias DatabaseToolsRuntimeDatabaseToolsDatabaseApiGatewayConfigPoolAutoApiSpec#alias}.</summary>
        [JsiiProperty(name: "alias", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Alias
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.25.0/docs/resources/database_tools_runtime_database_tools_database_api_gateway_config_pool_auto_api_spec#description DatabaseToolsRuntimeDatabaseToolsDatabaseApiGatewayConfigPoolAutoApiSpec#description}.</summary>
        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Description
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.25.0/docs/resources/database_tools_runtime_database_tools_database_api_gateway_config_pool_auto_api_spec#id DatabaseToolsRuntimeDatabaseToolsDatabaseApiGatewayConfigPoolAutoApiSpec#id}.</summary>
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

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.25.0/docs/resources/database_tools_runtime_database_tools_database_api_gateway_config_pool_auto_api_spec#operations DatabaseToolsRuntimeDatabaseToolsDatabaseApiGatewayConfigPoolAutoApiSpec#operations}.</summary>
        [JsiiProperty(name: "operations", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? Operations
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.25.0/docs/resources/database_tools_runtime_database_tools_database_api_gateway_config_pool_auto_api_spec#roles DatabaseToolsRuntimeDatabaseToolsDatabaseApiGatewayConfigPoolAutoApiSpec#roles}.</summary>
        [JsiiProperty(name: "roles", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? Roles
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.25.0/docs/resources/database_tools_runtime_database_tools_database_api_gateway_config_pool_auto_api_spec#scope DatabaseToolsRuntimeDatabaseToolsDatabaseApiGatewayConfigPoolAutoApiSpec#scope}.</summary>
        [JsiiProperty(name: "scope", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Scope
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.25.0/docs/resources/database_tools_runtime_database_tools_database_api_gateway_config_pool_auto_api_spec#security_schemes DatabaseToolsRuntimeDatabaseToolsDatabaseApiGatewayConfigPoolAutoApiSpec#security_schemes}.</summary>
        [JsiiProperty(name: "securitySchemes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? SecuritySchemes
        {
            get
            {
                return null;
            }
        }

        /// <summary>timeouts block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.25.0/docs/resources/database_tools_runtime_database_tools_database_api_gateway_config_pool_auto_api_spec#timeouts DatabaseToolsRuntimeDatabaseToolsDatabaseApiGatewayConfigPoolAutoApiSpec#timeouts}
        /// </remarks>
        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"oci.databaseToolsRuntimeDatabaseToolsDatabaseApiGatewayConfigPoolAutoApiSpec.DatabaseToolsRuntimeDatabaseToolsDatabaseApiGatewayConfigPoolAutoApiSpecTimeouts\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.DatabaseToolsRuntimeDatabaseToolsDatabaseApiGatewayConfigPoolAutoApiSpec.IDatabaseToolsRuntimeDatabaseToolsDatabaseApiGatewayConfigPoolAutoApiSpecTimeouts? Timeouts
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDatabaseToolsRuntimeDatabaseToolsDatabaseApiGatewayConfigPoolAutoApiSpecConfig), fullyQualifiedName: "oci.databaseToolsRuntimeDatabaseToolsDatabaseApiGatewayConfigPoolAutoApiSpec.DatabaseToolsRuntimeDatabaseToolsDatabaseApiGatewayConfigPoolAutoApiSpecConfig")]
        internal sealed class _Proxy : DeputyBase, oci.DatabaseToolsRuntimeDatabaseToolsDatabaseApiGatewayConfigPoolAutoApiSpec.IDatabaseToolsRuntimeDatabaseToolsDatabaseApiGatewayConfigPoolAutoApiSpecConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.25.0/docs/resources/database_tools_runtime_database_tools_database_api_gateway_config_pool_auto_api_spec#database_object_name DatabaseToolsRuntimeDatabaseToolsDatabaseApiGatewayConfigPoolAutoApiSpec#database_object_name}.</summary>
            [JsiiProperty(name: "databaseObjectName", typeJson: "{\"primitive\":\"string\"}")]
            public string DatabaseObjectName
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.25.0/docs/resources/database_tools_runtime_database_tools_database_api_gateway_config_pool_auto_api_spec#database_object_type DatabaseToolsRuntimeDatabaseToolsDatabaseApiGatewayConfigPoolAutoApiSpec#database_object_type}.</summary>
            [JsiiProperty(name: "databaseObjectType", typeJson: "{\"primitive\":\"string\"}")]
            public string DatabaseObjectType
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.25.0/docs/resources/database_tools_runtime_database_tools_database_api_gateway_config_pool_auto_api_spec#database_tools_database_api_gateway_config_id DatabaseToolsRuntimeDatabaseToolsDatabaseApiGatewayConfigPoolAutoApiSpec#database_tools_database_api_gateway_config_id}.</summary>
            [JsiiProperty(name: "databaseToolsDatabaseApiGatewayConfigId", typeJson: "{\"primitive\":\"string\"}")]
            public string DatabaseToolsDatabaseApiGatewayConfigId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.25.0/docs/resources/database_tools_runtime_database_tools_database_api_gateway_config_pool_auto_api_spec#display_name DatabaseToolsRuntimeDatabaseToolsDatabaseApiGatewayConfigPoolAutoApiSpec#display_name}.</summary>
            [JsiiProperty(name: "displayName", typeJson: "{\"primitive\":\"string\"}")]
            public string DisplayName
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.25.0/docs/resources/database_tools_runtime_database_tools_database_api_gateway_config_pool_auto_api_spec#pool_key DatabaseToolsRuntimeDatabaseToolsDatabaseApiGatewayConfigPoolAutoApiSpec#pool_key}.</summary>
            [JsiiProperty(name: "poolKey", typeJson: "{\"primitive\":\"string\"}")]
            public string PoolKey
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.25.0/docs/resources/database_tools_runtime_database_tools_database_api_gateway_config_pool_auto_api_spec#type DatabaseToolsRuntimeDatabaseToolsDatabaseApiGatewayConfigPoolAutoApiSpec#type}.</summary>
            [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
            public string Type
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.25.0/docs/resources/database_tools_runtime_database_tools_database_api_gateway_config_pool_auto_api_spec#alias DatabaseToolsRuntimeDatabaseToolsDatabaseApiGatewayConfigPoolAutoApiSpec#alias}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "alias", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Alias
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.25.0/docs/resources/database_tools_runtime_database_tools_database_api_gateway_config_pool_auto_api_spec#description DatabaseToolsRuntimeDatabaseToolsDatabaseApiGatewayConfigPoolAutoApiSpec#description}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Description
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.25.0/docs/resources/database_tools_runtime_database_tools_database_api_gateway_config_pool_auto_api_spec#id DatabaseToolsRuntimeDatabaseToolsDatabaseApiGatewayConfigPoolAutoApiSpec#id}.</summary>
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

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.25.0/docs/resources/database_tools_runtime_database_tools_database_api_gateway_config_pool_auto_api_spec#operations DatabaseToolsRuntimeDatabaseToolsDatabaseApiGatewayConfigPoolAutoApiSpec#operations}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "operations", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? Operations
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.25.0/docs/resources/database_tools_runtime_database_tools_database_api_gateway_config_pool_auto_api_spec#roles DatabaseToolsRuntimeDatabaseToolsDatabaseApiGatewayConfigPoolAutoApiSpec#roles}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "roles", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? Roles
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.25.0/docs/resources/database_tools_runtime_database_tools_database_api_gateway_config_pool_auto_api_spec#scope DatabaseToolsRuntimeDatabaseToolsDatabaseApiGatewayConfigPoolAutoApiSpec#scope}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "scope", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Scope
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.25.0/docs/resources/database_tools_runtime_database_tools_database_api_gateway_config_pool_auto_api_spec#security_schemes DatabaseToolsRuntimeDatabaseToolsDatabaseApiGatewayConfigPoolAutoApiSpec#security_schemes}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "securitySchemes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? SecuritySchemes
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>timeouts block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.25.0/docs/resources/database_tools_runtime_database_tools_database_api_gateway_config_pool_auto_api_spec#timeouts DatabaseToolsRuntimeDatabaseToolsDatabaseApiGatewayConfigPoolAutoApiSpec#timeouts}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"oci.databaseToolsRuntimeDatabaseToolsDatabaseApiGatewayConfigPoolAutoApiSpec.DatabaseToolsRuntimeDatabaseToolsDatabaseApiGatewayConfigPoolAutoApiSpecTimeouts\"}", isOptional: true)]
            public oci.DatabaseToolsRuntimeDatabaseToolsDatabaseApiGatewayConfigPoolAutoApiSpec.IDatabaseToolsRuntimeDatabaseToolsDatabaseApiGatewayConfigPoolAutoApiSpecTimeouts? Timeouts
            {
                get => GetInstanceProperty<oci.DatabaseToolsRuntimeDatabaseToolsDatabaseApiGatewayConfigPoolAutoApiSpec.IDatabaseToolsRuntimeDatabaseToolsDatabaseApiGatewayConfigPoolAutoApiSpecTimeouts?>();
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

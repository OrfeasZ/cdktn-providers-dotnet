using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DatabaseToolsRuntimeDatabaseToolsDatabaseApiGatewayConfigPool
{
    [JsiiInterface(nativeType: typeof(IDatabaseToolsRuntimeDatabaseToolsDatabaseApiGatewayConfigPoolConfig), fullyQualifiedName: "oci.databaseToolsRuntimeDatabaseToolsDatabaseApiGatewayConfigPool.DatabaseToolsRuntimeDatabaseToolsDatabaseApiGatewayConfigPoolConfig")]
    public interface IDatabaseToolsRuntimeDatabaseToolsDatabaseApiGatewayConfigPoolConfig : Io.Cdktn.ITerraformMetaArguments
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.21.0/docs/resources/database_tools_runtime_database_tools_database_api_gateway_config_pool#database_tools_connection_id DatabaseToolsRuntimeDatabaseToolsDatabaseApiGatewayConfigPool#database_tools_connection_id}.</summary>
        [JsiiProperty(name: "databaseToolsConnectionId", typeJson: "{\"primitive\":\"string\"}")]
        string DatabaseToolsConnectionId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.21.0/docs/resources/database_tools_runtime_database_tools_database_api_gateway_config_pool#database_tools_database_api_gateway_config_id DatabaseToolsRuntimeDatabaseToolsDatabaseApiGatewayConfigPool#database_tools_database_api_gateway_config_id}.</summary>
        [JsiiProperty(name: "databaseToolsDatabaseApiGatewayConfigId", typeJson: "{\"primitive\":\"string\"}")]
        string DatabaseToolsDatabaseApiGatewayConfigId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.21.0/docs/resources/database_tools_runtime_database_tools_database_api_gateway_config_pool#display_name DatabaseToolsRuntimeDatabaseToolsDatabaseApiGatewayConfigPool#display_name}.</summary>
        [JsiiProperty(name: "displayName", typeJson: "{\"primitive\":\"string\"}")]
        string DisplayName
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.21.0/docs/resources/database_tools_runtime_database_tools_database_api_gateway_config_pool#pool_route_value DatabaseToolsRuntimeDatabaseToolsDatabaseApiGatewayConfigPool#pool_route_value}.</summary>
        [JsiiProperty(name: "poolRouteValue", typeJson: "{\"primitive\":\"string\"}")]
        string PoolRouteValue
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.21.0/docs/resources/database_tools_runtime_database_tools_database_api_gateway_config_pool#type DatabaseToolsRuntimeDatabaseToolsDatabaseApiGatewayConfigPool#type}.</summary>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        string Type
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.21.0/docs/resources/database_tools_runtime_database_tools_database_api_gateway_config_pool#advanced_properties DatabaseToolsRuntimeDatabaseToolsDatabaseApiGatewayConfigPool#advanced_properties}.</summary>
        [JsiiProperty(name: "advancedProperties", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        System.Collections.Generic.IDictionary<string, string>? AdvancedProperties
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.21.0/docs/resources/database_tools_runtime_database_tools_database_api_gateway_config_pool#database_actions_status DatabaseToolsRuntimeDatabaseToolsDatabaseApiGatewayConfigPool#database_actions_status}.</summary>
        [JsiiProperty(name: "databaseActionsStatus", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? DatabaseActionsStatus
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.21.0/docs/resources/database_tools_runtime_database_tools_database_api_gateway_config_pool#id DatabaseToolsRuntimeDatabaseToolsDatabaseApiGatewayConfigPool#id}.</summary>
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

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.21.0/docs/resources/database_tools_runtime_database_tools_database_api_gateway_config_pool#initial_pool_size DatabaseToolsRuntimeDatabaseToolsDatabaseApiGatewayConfigPool#initial_pool_size}.</summary>
        [JsiiProperty(name: "initialPoolSize", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? InitialPoolSize
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.21.0/docs/resources/database_tools_runtime_database_tools_database_api_gateway_config_pool#jwt_profile_audience DatabaseToolsRuntimeDatabaseToolsDatabaseApiGatewayConfigPool#jwt_profile_audience}.</summary>
        [JsiiProperty(name: "jwtProfileAudience", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? JwtProfileAudience
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.21.0/docs/resources/database_tools_runtime_database_tools_database_api_gateway_config_pool#jwt_profile_issuer DatabaseToolsRuntimeDatabaseToolsDatabaseApiGatewayConfigPool#jwt_profile_issuer}.</summary>
        [JsiiProperty(name: "jwtProfileIssuer", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? JwtProfileIssuer
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.21.0/docs/resources/database_tools_runtime_database_tools_database_api_gateway_config_pool#jwt_profile_jwk_url DatabaseToolsRuntimeDatabaseToolsDatabaseApiGatewayConfigPool#jwt_profile_jwk_url}.</summary>
        [JsiiProperty(name: "jwtProfileJwkUrl", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? JwtProfileJwkUrl
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.21.0/docs/resources/database_tools_runtime_database_tools_database_api_gateway_config_pool#jwt_profile_role_claim_name DatabaseToolsRuntimeDatabaseToolsDatabaseApiGatewayConfigPool#jwt_profile_role_claim_name}.</summary>
        [JsiiProperty(name: "jwtProfileRoleClaimName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? JwtProfileRoleClaimName
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.21.0/docs/resources/database_tools_runtime_database_tools_database_api_gateway_config_pool#max_pool_size DatabaseToolsRuntimeDatabaseToolsDatabaseApiGatewayConfigPool#max_pool_size}.</summary>
        [JsiiProperty(name: "maxPoolSize", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? MaxPoolSize
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.21.0/docs/resources/database_tools_runtime_database_tools_database_api_gateway_config_pool#min_pool_size DatabaseToolsRuntimeDatabaseToolsDatabaseApiGatewayConfigPool#min_pool_size}.</summary>
        [JsiiProperty(name: "minPoolSize", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? MinPoolSize
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.21.0/docs/resources/database_tools_runtime_database_tools_database_api_gateway_config_pool#rest_enabled_sql_status DatabaseToolsRuntimeDatabaseToolsDatabaseApiGatewayConfigPool#rest_enabled_sql_status}.</summary>
        [JsiiProperty(name: "restEnabledSqlStatus", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? RestEnabledSqlStatus
        {
            get
            {
                return null;
            }
        }

        /// <summary>timeouts block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.21.0/docs/resources/database_tools_runtime_database_tools_database_api_gateway_config_pool#timeouts DatabaseToolsRuntimeDatabaseToolsDatabaseApiGatewayConfigPool#timeouts}
        /// </remarks>
        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"oci.databaseToolsRuntimeDatabaseToolsDatabaseApiGatewayConfigPool.DatabaseToolsRuntimeDatabaseToolsDatabaseApiGatewayConfigPoolTimeouts\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.DatabaseToolsRuntimeDatabaseToolsDatabaseApiGatewayConfigPool.IDatabaseToolsRuntimeDatabaseToolsDatabaseApiGatewayConfigPoolTimeouts? Timeouts
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDatabaseToolsRuntimeDatabaseToolsDatabaseApiGatewayConfigPoolConfig), fullyQualifiedName: "oci.databaseToolsRuntimeDatabaseToolsDatabaseApiGatewayConfigPool.DatabaseToolsRuntimeDatabaseToolsDatabaseApiGatewayConfigPoolConfig")]
        internal sealed class _Proxy : DeputyBase, oci.DatabaseToolsRuntimeDatabaseToolsDatabaseApiGatewayConfigPool.IDatabaseToolsRuntimeDatabaseToolsDatabaseApiGatewayConfigPoolConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.21.0/docs/resources/database_tools_runtime_database_tools_database_api_gateway_config_pool#database_tools_connection_id DatabaseToolsRuntimeDatabaseToolsDatabaseApiGatewayConfigPool#database_tools_connection_id}.</summary>
            [JsiiProperty(name: "databaseToolsConnectionId", typeJson: "{\"primitive\":\"string\"}")]
            public string DatabaseToolsConnectionId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.21.0/docs/resources/database_tools_runtime_database_tools_database_api_gateway_config_pool#database_tools_database_api_gateway_config_id DatabaseToolsRuntimeDatabaseToolsDatabaseApiGatewayConfigPool#database_tools_database_api_gateway_config_id}.</summary>
            [JsiiProperty(name: "databaseToolsDatabaseApiGatewayConfigId", typeJson: "{\"primitive\":\"string\"}")]
            public string DatabaseToolsDatabaseApiGatewayConfigId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.21.0/docs/resources/database_tools_runtime_database_tools_database_api_gateway_config_pool#display_name DatabaseToolsRuntimeDatabaseToolsDatabaseApiGatewayConfigPool#display_name}.</summary>
            [JsiiProperty(name: "displayName", typeJson: "{\"primitive\":\"string\"}")]
            public string DisplayName
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.21.0/docs/resources/database_tools_runtime_database_tools_database_api_gateway_config_pool#pool_route_value DatabaseToolsRuntimeDatabaseToolsDatabaseApiGatewayConfigPool#pool_route_value}.</summary>
            [JsiiProperty(name: "poolRouteValue", typeJson: "{\"primitive\":\"string\"}")]
            public string PoolRouteValue
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.21.0/docs/resources/database_tools_runtime_database_tools_database_api_gateway_config_pool#type DatabaseToolsRuntimeDatabaseToolsDatabaseApiGatewayConfigPool#type}.</summary>
            [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
            public string Type
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.21.0/docs/resources/database_tools_runtime_database_tools_database_api_gateway_config_pool#advanced_properties DatabaseToolsRuntimeDatabaseToolsDatabaseApiGatewayConfigPool#advanced_properties}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "advancedProperties", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, string>? AdvancedProperties
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.21.0/docs/resources/database_tools_runtime_database_tools_database_api_gateway_config_pool#database_actions_status DatabaseToolsRuntimeDatabaseToolsDatabaseApiGatewayConfigPool#database_actions_status}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "databaseActionsStatus", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? DatabaseActionsStatus
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.21.0/docs/resources/database_tools_runtime_database_tools_database_api_gateway_config_pool#id DatabaseToolsRuntimeDatabaseToolsDatabaseApiGatewayConfigPool#id}.</summary>
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

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.21.0/docs/resources/database_tools_runtime_database_tools_database_api_gateway_config_pool#initial_pool_size DatabaseToolsRuntimeDatabaseToolsDatabaseApiGatewayConfigPool#initial_pool_size}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "initialPoolSize", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? InitialPoolSize
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.21.0/docs/resources/database_tools_runtime_database_tools_database_api_gateway_config_pool#jwt_profile_audience DatabaseToolsRuntimeDatabaseToolsDatabaseApiGatewayConfigPool#jwt_profile_audience}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "jwtProfileAudience", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? JwtProfileAudience
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.21.0/docs/resources/database_tools_runtime_database_tools_database_api_gateway_config_pool#jwt_profile_issuer DatabaseToolsRuntimeDatabaseToolsDatabaseApiGatewayConfigPool#jwt_profile_issuer}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "jwtProfileIssuer", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? JwtProfileIssuer
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.21.0/docs/resources/database_tools_runtime_database_tools_database_api_gateway_config_pool#jwt_profile_jwk_url DatabaseToolsRuntimeDatabaseToolsDatabaseApiGatewayConfigPool#jwt_profile_jwk_url}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "jwtProfileJwkUrl", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? JwtProfileJwkUrl
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.21.0/docs/resources/database_tools_runtime_database_tools_database_api_gateway_config_pool#jwt_profile_role_claim_name DatabaseToolsRuntimeDatabaseToolsDatabaseApiGatewayConfigPool#jwt_profile_role_claim_name}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "jwtProfileRoleClaimName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? JwtProfileRoleClaimName
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.21.0/docs/resources/database_tools_runtime_database_tools_database_api_gateway_config_pool#max_pool_size DatabaseToolsRuntimeDatabaseToolsDatabaseApiGatewayConfigPool#max_pool_size}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "maxPoolSize", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? MaxPoolSize
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.21.0/docs/resources/database_tools_runtime_database_tools_database_api_gateway_config_pool#min_pool_size DatabaseToolsRuntimeDatabaseToolsDatabaseApiGatewayConfigPool#min_pool_size}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "minPoolSize", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? MinPoolSize
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.21.0/docs/resources/database_tools_runtime_database_tools_database_api_gateway_config_pool#rest_enabled_sql_status DatabaseToolsRuntimeDatabaseToolsDatabaseApiGatewayConfigPool#rest_enabled_sql_status}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "restEnabledSqlStatus", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? RestEnabledSqlStatus
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>timeouts block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.21.0/docs/resources/database_tools_runtime_database_tools_database_api_gateway_config_pool#timeouts DatabaseToolsRuntimeDatabaseToolsDatabaseApiGatewayConfigPool#timeouts}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"oci.databaseToolsRuntimeDatabaseToolsDatabaseApiGatewayConfigPool.DatabaseToolsRuntimeDatabaseToolsDatabaseApiGatewayConfigPoolTimeouts\"}", isOptional: true)]
            public oci.DatabaseToolsRuntimeDatabaseToolsDatabaseApiGatewayConfigPool.IDatabaseToolsRuntimeDatabaseToolsDatabaseApiGatewayConfigPoolTimeouts? Timeouts
            {
                get => GetInstanceProperty<oci.DatabaseToolsRuntimeDatabaseToolsDatabaseApiGatewayConfigPool.IDatabaseToolsRuntimeDatabaseToolsDatabaseApiGatewayConfigPoolTimeouts?>();
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

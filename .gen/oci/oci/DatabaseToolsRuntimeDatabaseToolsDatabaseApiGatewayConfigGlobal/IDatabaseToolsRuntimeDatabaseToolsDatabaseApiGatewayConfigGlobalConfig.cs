using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DatabaseToolsRuntimeDatabaseToolsDatabaseApiGatewayConfigGlobal
{
    [JsiiInterface(nativeType: typeof(IDatabaseToolsRuntimeDatabaseToolsDatabaseApiGatewayConfigGlobalConfig), fullyQualifiedName: "oci.databaseToolsRuntimeDatabaseToolsDatabaseApiGatewayConfigGlobal.DatabaseToolsRuntimeDatabaseToolsDatabaseApiGatewayConfigGlobalConfig")]
    public interface IDatabaseToolsRuntimeDatabaseToolsDatabaseApiGatewayConfigGlobalConfig : Io.Cdktn.ITerraformMetaArguments
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.24.0/docs/resources/database_tools_runtime_database_tools_database_api_gateway_config_global#database_tools_database_api_gateway_config_id DatabaseToolsRuntimeDatabaseToolsDatabaseApiGatewayConfigGlobal#database_tools_database_api_gateway_config_id}.</summary>
        [JsiiProperty(name: "databaseToolsDatabaseApiGatewayConfigId", typeJson: "{\"primitive\":\"string\"}")]
        string DatabaseToolsDatabaseApiGatewayConfigId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.24.0/docs/resources/database_tools_runtime_database_tools_database_api_gateway_config_global#global_key DatabaseToolsRuntimeDatabaseToolsDatabaseApiGatewayConfigGlobal#global_key}.</summary>
        [JsiiProperty(name: "globalKey", typeJson: "{\"primitive\":\"string\"}")]
        string GlobalKey
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.24.0/docs/resources/database_tools_runtime_database_tools_database_api_gateway_config_global#type DatabaseToolsRuntimeDatabaseToolsDatabaseApiGatewayConfigGlobal#type}.</summary>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        string Type
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.24.0/docs/resources/database_tools_runtime_database_tools_database_api_gateway_config_global#advanced_properties DatabaseToolsRuntimeDatabaseToolsDatabaseApiGatewayConfigGlobal#advanced_properties}.</summary>
        [JsiiProperty(name: "advancedProperties", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        System.Collections.Generic.IDictionary<string, string>? AdvancedProperties
        {
            get
            {
                return null;
            }
        }

        /// <summary>certificate_bundle block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.24.0/docs/resources/database_tools_runtime_database_tools_database_api_gateway_config_global#certificate_bundle DatabaseToolsRuntimeDatabaseToolsDatabaseApiGatewayConfigGlobal#certificate_bundle}
        /// </remarks>
        [JsiiProperty(name: "certificateBundle", typeJson: "{\"fqn\":\"oci.databaseToolsRuntimeDatabaseToolsDatabaseApiGatewayConfigGlobal.DatabaseToolsRuntimeDatabaseToolsDatabaseApiGatewayConfigGlobalCertificateBundle\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.DatabaseToolsRuntimeDatabaseToolsDatabaseApiGatewayConfigGlobal.IDatabaseToolsRuntimeDatabaseToolsDatabaseApiGatewayConfigGlobalCertificateBundle? CertificateBundle
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.24.0/docs/resources/database_tools_runtime_database_tools_database_api_gateway_config_global#database_api_status DatabaseToolsRuntimeDatabaseToolsDatabaseApiGatewayConfigGlobal#database_api_status}.</summary>
        [JsiiProperty(name: "databaseApiStatus", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? DatabaseApiStatus
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.24.0/docs/resources/database_tools_runtime_database_tools_database_api_gateway_config_global#document_root DatabaseToolsRuntimeDatabaseToolsDatabaseApiGatewayConfigGlobal#document_root}.</summary>
        [JsiiProperty(name: "documentRoot", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? DocumentRoot
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.24.0/docs/resources/database_tools_runtime_database_tools_database_api_gateway_config_global#http_port DatabaseToolsRuntimeDatabaseToolsDatabaseApiGatewayConfigGlobal#http_port}.</summary>
        [JsiiProperty(name: "httpPort", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? HttpPort
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.24.0/docs/resources/database_tools_runtime_database_tools_database_api_gateway_config_global#https_port DatabaseToolsRuntimeDatabaseToolsDatabaseApiGatewayConfigGlobal#https_port}.</summary>
        [JsiiProperty(name: "httpsPort", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? HttpsPort
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.24.0/docs/resources/database_tools_runtime_database_tools_database_api_gateway_config_global#id DatabaseToolsRuntimeDatabaseToolsDatabaseApiGatewayConfigGlobal#id}.</summary>
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

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.24.0/docs/resources/database_tools_runtime_database_tools_database_api_gateway_config_global#pool_route DatabaseToolsRuntimeDatabaseToolsDatabaseApiGatewayConfigGlobal#pool_route}.</summary>
        [JsiiProperty(name: "poolRoute", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? PoolRoute
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.24.0/docs/resources/database_tools_runtime_database_tools_database_api_gateway_config_global#pool_routing_header DatabaseToolsRuntimeDatabaseToolsDatabaseApiGatewayConfigGlobal#pool_routing_header}.</summary>
        [JsiiProperty(name: "poolRoutingHeader", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? PoolRoutingHeader
        {
            get
            {
                return null;
            }
        }

        /// <summary>timeouts block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.24.0/docs/resources/database_tools_runtime_database_tools_database_api_gateway_config_global#timeouts DatabaseToolsRuntimeDatabaseToolsDatabaseApiGatewayConfigGlobal#timeouts}
        /// </remarks>
        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"oci.databaseToolsRuntimeDatabaseToolsDatabaseApiGatewayConfigGlobal.DatabaseToolsRuntimeDatabaseToolsDatabaseApiGatewayConfigGlobalTimeouts\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.DatabaseToolsRuntimeDatabaseToolsDatabaseApiGatewayConfigGlobal.IDatabaseToolsRuntimeDatabaseToolsDatabaseApiGatewayConfigGlobalTimeouts? Timeouts
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDatabaseToolsRuntimeDatabaseToolsDatabaseApiGatewayConfigGlobalConfig), fullyQualifiedName: "oci.databaseToolsRuntimeDatabaseToolsDatabaseApiGatewayConfigGlobal.DatabaseToolsRuntimeDatabaseToolsDatabaseApiGatewayConfigGlobalConfig")]
        internal sealed class _Proxy : DeputyBase, oci.DatabaseToolsRuntimeDatabaseToolsDatabaseApiGatewayConfigGlobal.IDatabaseToolsRuntimeDatabaseToolsDatabaseApiGatewayConfigGlobalConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.24.0/docs/resources/database_tools_runtime_database_tools_database_api_gateway_config_global#database_tools_database_api_gateway_config_id DatabaseToolsRuntimeDatabaseToolsDatabaseApiGatewayConfigGlobal#database_tools_database_api_gateway_config_id}.</summary>
            [JsiiProperty(name: "databaseToolsDatabaseApiGatewayConfigId", typeJson: "{\"primitive\":\"string\"}")]
            public string DatabaseToolsDatabaseApiGatewayConfigId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.24.0/docs/resources/database_tools_runtime_database_tools_database_api_gateway_config_global#global_key DatabaseToolsRuntimeDatabaseToolsDatabaseApiGatewayConfigGlobal#global_key}.</summary>
            [JsiiProperty(name: "globalKey", typeJson: "{\"primitive\":\"string\"}")]
            public string GlobalKey
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.24.0/docs/resources/database_tools_runtime_database_tools_database_api_gateway_config_global#type DatabaseToolsRuntimeDatabaseToolsDatabaseApiGatewayConfigGlobal#type}.</summary>
            [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
            public string Type
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.24.0/docs/resources/database_tools_runtime_database_tools_database_api_gateway_config_global#advanced_properties DatabaseToolsRuntimeDatabaseToolsDatabaseApiGatewayConfigGlobal#advanced_properties}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "advancedProperties", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, string>? AdvancedProperties
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
            }

            /// <summary>certificate_bundle block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.24.0/docs/resources/database_tools_runtime_database_tools_database_api_gateway_config_global#certificate_bundle DatabaseToolsRuntimeDatabaseToolsDatabaseApiGatewayConfigGlobal#certificate_bundle}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "certificateBundle", typeJson: "{\"fqn\":\"oci.databaseToolsRuntimeDatabaseToolsDatabaseApiGatewayConfigGlobal.DatabaseToolsRuntimeDatabaseToolsDatabaseApiGatewayConfigGlobalCertificateBundle\"}", isOptional: true)]
            public oci.DatabaseToolsRuntimeDatabaseToolsDatabaseApiGatewayConfigGlobal.IDatabaseToolsRuntimeDatabaseToolsDatabaseApiGatewayConfigGlobalCertificateBundle? CertificateBundle
            {
                get => GetInstanceProperty<oci.DatabaseToolsRuntimeDatabaseToolsDatabaseApiGatewayConfigGlobal.IDatabaseToolsRuntimeDatabaseToolsDatabaseApiGatewayConfigGlobalCertificateBundle?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.24.0/docs/resources/database_tools_runtime_database_tools_database_api_gateway_config_global#database_api_status DatabaseToolsRuntimeDatabaseToolsDatabaseApiGatewayConfigGlobal#database_api_status}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "databaseApiStatus", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? DatabaseApiStatus
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.24.0/docs/resources/database_tools_runtime_database_tools_database_api_gateway_config_global#document_root DatabaseToolsRuntimeDatabaseToolsDatabaseApiGatewayConfigGlobal#document_root}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "documentRoot", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? DocumentRoot
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.24.0/docs/resources/database_tools_runtime_database_tools_database_api_gateway_config_global#http_port DatabaseToolsRuntimeDatabaseToolsDatabaseApiGatewayConfigGlobal#http_port}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "httpPort", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? HttpPort
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.24.0/docs/resources/database_tools_runtime_database_tools_database_api_gateway_config_global#https_port DatabaseToolsRuntimeDatabaseToolsDatabaseApiGatewayConfigGlobal#https_port}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "httpsPort", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? HttpsPort
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.24.0/docs/resources/database_tools_runtime_database_tools_database_api_gateway_config_global#id DatabaseToolsRuntimeDatabaseToolsDatabaseApiGatewayConfigGlobal#id}.</summary>
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

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.24.0/docs/resources/database_tools_runtime_database_tools_database_api_gateway_config_global#pool_route DatabaseToolsRuntimeDatabaseToolsDatabaseApiGatewayConfigGlobal#pool_route}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "poolRoute", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? PoolRoute
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.24.0/docs/resources/database_tools_runtime_database_tools_database_api_gateway_config_global#pool_routing_header DatabaseToolsRuntimeDatabaseToolsDatabaseApiGatewayConfigGlobal#pool_routing_header}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "poolRoutingHeader", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? PoolRoutingHeader
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>timeouts block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.24.0/docs/resources/database_tools_runtime_database_tools_database_api_gateway_config_global#timeouts DatabaseToolsRuntimeDatabaseToolsDatabaseApiGatewayConfigGlobal#timeouts}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"oci.databaseToolsRuntimeDatabaseToolsDatabaseApiGatewayConfigGlobal.DatabaseToolsRuntimeDatabaseToolsDatabaseApiGatewayConfigGlobalTimeouts\"}", isOptional: true)]
            public oci.DatabaseToolsRuntimeDatabaseToolsDatabaseApiGatewayConfigGlobal.IDatabaseToolsRuntimeDatabaseToolsDatabaseApiGatewayConfigGlobalTimeouts? Timeouts
            {
                get => GetInstanceProperty<oci.DatabaseToolsRuntimeDatabaseToolsDatabaseApiGatewayConfigGlobal.IDatabaseToolsRuntimeDatabaseToolsDatabaseApiGatewayConfigGlobalTimeouts?>();
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

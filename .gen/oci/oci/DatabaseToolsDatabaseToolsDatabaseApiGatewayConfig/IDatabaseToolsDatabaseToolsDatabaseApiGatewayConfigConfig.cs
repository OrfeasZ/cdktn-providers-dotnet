using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DatabaseToolsDatabaseToolsDatabaseApiGatewayConfig
{
    [JsiiInterface(nativeType: typeof(IDatabaseToolsDatabaseToolsDatabaseApiGatewayConfigConfig), fullyQualifiedName: "oci.databaseToolsDatabaseToolsDatabaseApiGatewayConfig.DatabaseToolsDatabaseToolsDatabaseApiGatewayConfigConfig")]
    public interface IDatabaseToolsDatabaseToolsDatabaseApiGatewayConfigConfig : Io.Cdktn.ITerraformMetaArguments
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.23.0/docs/resources/database_tools_database_tools_database_api_gateway_config#compartment_id DatabaseToolsDatabaseToolsDatabaseApiGatewayConfig#compartment_id}.</summary>
        [JsiiProperty(name: "compartmentId", typeJson: "{\"primitive\":\"string\"}")]
        string CompartmentId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.23.0/docs/resources/database_tools_database_tools_database_api_gateway_config#display_name DatabaseToolsDatabaseToolsDatabaseApiGatewayConfig#display_name}.</summary>
        [JsiiProperty(name: "displayName", typeJson: "{\"primitive\":\"string\"}")]
        string DisplayName
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.23.0/docs/resources/database_tools_database_tools_database_api_gateway_config#metadata_source DatabaseToolsDatabaseToolsDatabaseApiGatewayConfig#metadata_source}.</summary>
        [JsiiProperty(name: "metadataSource", typeJson: "{\"primitive\":\"string\"}")]
        string MetadataSource
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.23.0/docs/resources/database_tools_database_tools_database_api_gateway_config#type DatabaseToolsDatabaseToolsDatabaseApiGatewayConfig#type}.</summary>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        string Type
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.23.0/docs/resources/database_tools_database_tools_database_api_gateway_config#defined_tags DatabaseToolsDatabaseToolsDatabaseApiGatewayConfig#defined_tags}.</summary>
        [JsiiProperty(name: "definedTags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        System.Collections.Generic.IDictionary<string, string>? DefinedTags
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.23.0/docs/resources/database_tools_database_tools_database_api_gateway_config#freeform_tags DatabaseToolsDatabaseToolsDatabaseApiGatewayConfig#freeform_tags}.</summary>
        [JsiiProperty(name: "freeformTags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        System.Collections.Generic.IDictionary<string, string>? FreeformTags
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.23.0/docs/resources/database_tools_database_tools_database_api_gateway_config#id DatabaseToolsDatabaseToolsDatabaseApiGatewayConfig#id}.</summary>
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

        /// <summary>locks block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.23.0/docs/resources/database_tools_database_tools_database_api_gateway_config#locks DatabaseToolsDatabaseToolsDatabaseApiGatewayConfig#locks}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="oci.DatabaseToolsDatabaseToolsDatabaseApiGatewayConfig.IDatabaseToolsDatabaseToolsDatabaseApiGatewayConfigLocks" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "locks", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.databaseToolsDatabaseToolsDatabaseApiGatewayConfig.DatabaseToolsDatabaseToolsDatabaseApiGatewayConfigLocks\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Locks
        {
            get
            {
                return null;
            }
        }

        /// <summary>timeouts block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.23.0/docs/resources/database_tools_database_tools_database_api_gateway_config#timeouts DatabaseToolsDatabaseToolsDatabaseApiGatewayConfig#timeouts}
        /// </remarks>
        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"oci.databaseToolsDatabaseToolsDatabaseApiGatewayConfig.DatabaseToolsDatabaseToolsDatabaseApiGatewayConfigTimeouts\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.DatabaseToolsDatabaseToolsDatabaseApiGatewayConfig.IDatabaseToolsDatabaseToolsDatabaseApiGatewayConfigTimeouts? Timeouts
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDatabaseToolsDatabaseToolsDatabaseApiGatewayConfigConfig), fullyQualifiedName: "oci.databaseToolsDatabaseToolsDatabaseApiGatewayConfig.DatabaseToolsDatabaseToolsDatabaseApiGatewayConfigConfig")]
        internal sealed class _Proxy : DeputyBase, oci.DatabaseToolsDatabaseToolsDatabaseApiGatewayConfig.IDatabaseToolsDatabaseToolsDatabaseApiGatewayConfigConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.23.0/docs/resources/database_tools_database_tools_database_api_gateway_config#compartment_id DatabaseToolsDatabaseToolsDatabaseApiGatewayConfig#compartment_id}.</summary>
            [JsiiProperty(name: "compartmentId", typeJson: "{\"primitive\":\"string\"}")]
            public string CompartmentId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.23.0/docs/resources/database_tools_database_tools_database_api_gateway_config#display_name DatabaseToolsDatabaseToolsDatabaseApiGatewayConfig#display_name}.</summary>
            [JsiiProperty(name: "displayName", typeJson: "{\"primitive\":\"string\"}")]
            public string DisplayName
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.23.0/docs/resources/database_tools_database_tools_database_api_gateway_config#metadata_source DatabaseToolsDatabaseToolsDatabaseApiGatewayConfig#metadata_source}.</summary>
            [JsiiProperty(name: "metadataSource", typeJson: "{\"primitive\":\"string\"}")]
            public string MetadataSource
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.23.0/docs/resources/database_tools_database_tools_database_api_gateway_config#type DatabaseToolsDatabaseToolsDatabaseApiGatewayConfig#type}.</summary>
            [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
            public string Type
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.23.0/docs/resources/database_tools_database_tools_database_api_gateway_config#defined_tags DatabaseToolsDatabaseToolsDatabaseApiGatewayConfig#defined_tags}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "definedTags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, string>? DefinedTags
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.23.0/docs/resources/database_tools_database_tools_database_api_gateway_config#freeform_tags DatabaseToolsDatabaseToolsDatabaseApiGatewayConfig#freeform_tags}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "freeformTags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, string>? FreeformTags
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.23.0/docs/resources/database_tools_database_tools_database_api_gateway_config#id DatabaseToolsDatabaseToolsDatabaseApiGatewayConfig#id}.</summary>
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

            /// <summary>locks block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.23.0/docs/resources/database_tools_database_tools_database_api_gateway_config#locks DatabaseToolsDatabaseToolsDatabaseApiGatewayConfig#locks}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="oci.DatabaseToolsDatabaseToolsDatabaseApiGatewayConfig.IDatabaseToolsDatabaseToolsDatabaseApiGatewayConfigLocks" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "locks", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.databaseToolsDatabaseToolsDatabaseApiGatewayConfig.DatabaseToolsDatabaseToolsDatabaseApiGatewayConfigLocks\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Locks
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>timeouts block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.23.0/docs/resources/database_tools_database_tools_database_api_gateway_config#timeouts DatabaseToolsDatabaseToolsDatabaseApiGatewayConfig#timeouts}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"oci.databaseToolsDatabaseToolsDatabaseApiGatewayConfig.DatabaseToolsDatabaseToolsDatabaseApiGatewayConfigTimeouts\"}", isOptional: true)]
            public oci.DatabaseToolsDatabaseToolsDatabaseApiGatewayConfig.IDatabaseToolsDatabaseToolsDatabaseApiGatewayConfigTimeouts? Timeouts
            {
                get => GetInstanceProperty<oci.DatabaseToolsDatabaseToolsDatabaseApiGatewayConfig.IDatabaseToolsDatabaseToolsDatabaseApiGatewayConfigTimeouts?>();
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

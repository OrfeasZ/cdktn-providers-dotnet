using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DatabaseToolsDatabaseToolsMcpServer
{
    [JsiiInterface(nativeType: typeof(IDatabaseToolsDatabaseToolsMcpServerConfig), fullyQualifiedName: "oci.databaseToolsDatabaseToolsMcpServer.DatabaseToolsDatabaseToolsMcpServerConfig")]
    public interface IDatabaseToolsDatabaseToolsMcpServerConfig : Io.Cdktn.ITerraformMetaArguments
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.26.0/docs/resources/database_tools_database_tools_mcp_server#compartment_id DatabaseToolsDatabaseToolsMcpServer#compartment_id}.</summary>
        [JsiiProperty(name: "compartmentId", typeJson: "{\"primitive\":\"string\"}")]
        string CompartmentId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.26.0/docs/resources/database_tools_database_tools_mcp_server#database_tools_connection_id DatabaseToolsDatabaseToolsMcpServer#database_tools_connection_id}.</summary>
        [JsiiProperty(name: "databaseToolsConnectionId", typeJson: "{\"primitive\":\"string\"}")]
        string DatabaseToolsConnectionId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.26.0/docs/resources/database_tools_database_tools_mcp_server#display_name DatabaseToolsDatabaseToolsMcpServer#display_name}.</summary>
        [JsiiProperty(name: "displayName", typeJson: "{\"primitive\":\"string\"}")]
        string DisplayName
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.26.0/docs/resources/database_tools_database_tools_mcp_server#domain_id DatabaseToolsDatabaseToolsMcpServer#domain_id}.</summary>
        [JsiiProperty(name: "domainId", typeJson: "{\"primitive\":\"string\"}")]
        string DomainId
        {
            get;
        }

        /// <summary>storage block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.26.0/docs/resources/database_tools_database_tools_mcp_server#storage DatabaseToolsDatabaseToolsMcpServer#storage}
        /// </remarks>
        [JsiiProperty(name: "storage", typeJson: "{\"fqn\":\"oci.databaseToolsDatabaseToolsMcpServer.DatabaseToolsDatabaseToolsMcpServerStorage\"}")]
        oci.DatabaseToolsDatabaseToolsMcpServer.IDatabaseToolsDatabaseToolsMcpServerStorage Storage
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.26.0/docs/resources/database_tools_database_tools_mcp_server#type DatabaseToolsDatabaseToolsMcpServer#type}.</summary>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        string Type
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.26.0/docs/resources/database_tools_database_tools_mcp_server#access_token_expiry_in_seconds DatabaseToolsDatabaseToolsMcpServer#access_token_expiry_in_seconds}.</summary>
        [JsiiProperty(name: "accessTokenExpiryInSeconds", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? AccessTokenExpiryInSeconds
        {
            get
            {
                return null;
            }
        }

        /// <summary>custom_roles block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.26.0/docs/resources/database_tools_database_tools_mcp_server#custom_roles DatabaseToolsDatabaseToolsMcpServer#custom_roles}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="oci.DatabaseToolsDatabaseToolsMcpServer.IDatabaseToolsDatabaseToolsMcpServerCustomRoles" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "customRoles", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.databaseToolsDatabaseToolsMcpServer.DatabaseToolsDatabaseToolsMcpServerCustomRoles\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? CustomRoles
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.26.0/docs/resources/database_tools_database_tools_mcp_server#defined_tags DatabaseToolsDatabaseToolsMcpServer#defined_tags}.</summary>
        [JsiiProperty(name: "definedTags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        System.Collections.Generic.IDictionary<string, string>? DefinedTags
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.26.0/docs/resources/database_tools_database_tools_mcp_server#description DatabaseToolsDatabaseToolsMcpServer#description}.</summary>
        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Description
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.26.0/docs/resources/database_tools_database_tools_mcp_server#freeform_tags DatabaseToolsDatabaseToolsMcpServer#freeform_tags}.</summary>
        [JsiiProperty(name: "freeformTags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        System.Collections.Generic.IDictionary<string, string>? FreeformTags
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.26.0/docs/resources/database_tools_database_tools_mcp_server#id DatabaseToolsDatabaseToolsMcpServer#id}.</summary>
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
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.26.0/docs/resources/database_tools_database_tools_mcp_server#locks DatabaseToolsDatabaseToolsMcpServer#locks}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="oci.DatabaseToolsDatabaseToolsMcpServer.IDatabaseToolsDatabaseToolsMcpServerLocks" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "locks", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.databaseToolsDatabaseToolsMcpServer.DatabaseToolsDatabaseToolsMcpServerLocks\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Locks
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.26.0/docs/resources/database_tools_database_tools_mcp_server#refresh_token_expiry_in_seconds DatabaseToolsDatabaseToolsMcpServer#refresh_token_expiry_in_seconds}.</summary>
        [JsiiProperty(name: "refreshTokenExpiryInSeconds", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? RefreshTokenExpiryInSeconds
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.26.0/docs/resources/database_tools_database_tools_mcp_server#runtime_identity DatabaseToolsDatabaseToolsMcpServer#runtime_identity}.</summary>
        [JsiiProperty(name: "runtimeIdentity", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? RuntimeIdentity
        {
            get
            {
                return null;
            }
        }

        /// <summary>timeouts block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.26.0/docs/resources/database_tools_database_tools_mcp_server#timeouts DatabaseToolsDatabaseToolsMcpServer#timeouts}
        /// </remarks>
        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"oci.databaseToolsDatabaseToolsMcpServer.DatabaseToolsDatabaseToolsMcpServerTimeouts\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.DatabaseToolsDatabaseToolsMcpServer.IDatabaseToolsDatabaseToolsMcpServerTimeouts? Timeouts
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDatabaseToolsDatabaseToolsMcpServerConfig), fullyQualifiedName: "oci.databaseToolsDatabaseToolsMcpServer.DatabaseToolsDatabaseToolsMcpServerConfig")]
        internal sealed class _Proxy : DeputyBase, oci.DatabaseToolsDatabaseToolsMcpServer.IDatabaseToolsDatabaseToolsMcpServerConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.26.0/docs/resources/database_tools_database_tools_mcp_server#compartment_id DatabaseToolsDatabaseToolsMcpServer#compartment_id}.</summary>
            [JsiiProperty(name: "compartmentId", typeJson: "{\"primitive\":\"string\"}")]
            public string CompartmentId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.26.0/docs/resources/database_tools_database_tools_mcp_server#database_tools_connection_id DatabaseToolsDatabaseToolsMcpServer#database_tools_connection_id}.</summary>
            [JsiiProperty(name: "databaseToolsConnectionId", typeJson: "{\"primitive\":\"string\"}")]
            public string DatabaseToolsConnectionId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.26.0/docs/resources/database_tools_database_tools_mcp_server#display_name DatabaseToolsDatabaseToolsMcpServer#display_name}.</summary>
            [JsiiProperty(name: "displayName", typeJson: "{\"primitive\":\"string\"}")]
            public string DisplayName
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.26.0/docs/resources/database_tools_database_tools_mcp_server#domain_id DatabaseToolsDatabaseToolsMcpServer#domain_id}.</summary>
            [JsiiProperty(name: "domainId", typeJson: "{\"primitive\":\"string\"}")]
            public string DomainId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>storage block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.26.0/docs/resources/database_tools_database_tools_mcp_server#storage DatabaseToolsDatabaseToolsMcpServer#storage}
            /// </remarks>
            [JsiiProperty(name: "storage", typeJson: "{\"fqn\":\"oci.databaseToolsDatabaseToolsMcpServer.DatabaseToolsDatabaseToolsMcpServerStorage\"}")]
            public oci.DatabaseToolsDatabaseToolsMcpServer.IDatabaseToolsDatabaseToolsMcpServerStorage Storage
            {
                get => GetInstanceProperty<oci.DatabaseToolsDatabaseToolsMcpServer.IDatabaseToolsDatabaseToolsMcpServerStorage>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.26.0/docs/resources/database_tools_database_tools_mcp_server#type DatabaseToolsDatabaseToolsMcpServer#type}.</summary>
            [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
            public string Type
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.26.0/docs/resources/database_tools_database_tools_mcp_server#access_token_expiry_in_seconds DatabaseToolsDatabaseToolsMcpServer#access_token_expiry_in_seconds}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "accessTokenExpiryInSeconds", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? AccessTokenExpiryInSeconds
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>custom_roles block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.26.0/docs/resources/database_tools_database_tools_mcp_server#custom_roles DatabaseToolsDatabaseToolsMcpServer#custom_roles}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="oci.DatabaseToolsDatabaseToolsMcpServer.IDatabaseToolsDatabaseToolsMcpServerCustomRoles" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "customRoles", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.databaseToolsDatabaseToolsMcpServer.DatabaseToolsDatabaseToolsMcpServerCustomRoles\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? CustomRoles
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.26.0/docs/resources/database_tools_database_tools_mcp_server#defined_tags DatabaseToolsDatabaseToolsMcpServer#defined_tags}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "definedTags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, string>? DefinedTags
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.26.0/docs/resources/database_tools_database_tools_mcp_server#description DatabaseToolsDatabaseToolsMcpServer#description}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Description
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.26.0/docs/resources/database_tools_database_tools_mcp_server#freeform_tags DatabaseToolsDatabaseToolsMcpServer#freeform_tags}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "freeformTags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, string>? FreeformTags
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.26.0/docs/resources/database_tools_database_tools_mcp_server#id DatabaseToolsDatabaseToolsMcpServer#id}.</summary>
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
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.26.0/docs/resources/database_tools_database_tools_mcp_server#locks DatabaseToolsDatabaseToolsMcpServer#locks}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="oci.DatabaseToolsDatabaseToolsMcpServer.IDatabaseToolsDatabaseToolsMcpServerLocks" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "locks", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.databaseToolsDatabaseToolsMcpServer.DatabaseToolsDatabaseToolsMcpServerLocks\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Locks
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.26.0/docs/resources/database_tools_database_tools_mcp_server#refresh_token_expiry_in_seconds DatabaseToolsDatabaseToolsMcpServer#refresh_token_expiry_in_seconds}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "refreshTokenExpiryInSeconds", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? RefreshTokenExpiryInSeconds
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.26.0/docs/resources/database_tools_database_tools_mcp_server#runtime_identity DatabaseToolsDatabaseToolsMcpServer#runtime_identity}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "runtimeIdentity", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? RuntimeIdentity
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>timeouts block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.26.0/docs/resources/database_tools_database_tools_mcp_server#timeouts DatabaseToolsDatabaseToolsMcpServer#timeouts}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"oci.databaseToolsDatabaseToolsMcpServer.DatabaseToolsDatabaseToolsMcpServerTimeouts\"}", isOptional: true)]
            public oci.DatabaseToolsDatabaseToolsMcpServer.IDatabaseToolsDatabaseToolsMcpServerTimeouts? Timeouts
            {
                get => GetInstanceProperty<oci.DatabaseToolsDatabaseToolsMcpServer.IDatabaseToolsDatabaseToolsMcpServerTimeouts?>();
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

using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DatabaseToolsRuntimeDatabaseToolsConnectionCredentialExecuteGrantee
{
    [JsiiInterface(nativeType: typeof(IDatabaseToolsRuntimeDatabaseToolsConnectionCredentialExecuteGranteeConfig), fullyQualifiedName: "oci.databaseToolsRuntimeDatabaseToolsConnectionCredentialExecuteGrantee.DatabaseToolsRuntimeDatabaseToolsConnectionCredentialExecuteGranteeConfig")]
    public interface IDatabaseToolsRuntimeDatabaseToolsConnectionCredentialExecuteGranteeConfig : Io.Cdktn.ITerraformMetaArguments
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.26.0/docs/resources/database_tools_runtime_database_tools_connection_credential_execute_grantee#credential_key DatabaseToolsRuntimeDatabaseToolsConnectionCredentialExecuteGrantee#credential_key}.</summary>
        [JsiiProperty(name: "credentialKey", typeJson: "{\"primitive\":\"string\"}")]
        string CredentialKey
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.26.0/docs/resources/database_tools_runtime_database_tools_connection_credential_execute_grantee#database_tools_connection_id DatabaseToolsRuntimeDatabaseToolsConnectionCredentialExecuteGrantee#database_tools_connection_id}.</summary>
        [JsiiProperty(name: "databaseToolsConnectionId", typeJson: "{\"primitive\":\"string\"}")]
        string DatabaseToolsConnectionId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.26.0/docs/resources/database_tools_runtime_database_tools_connection_credential_execute_grantee#key DatabaseToolsRuntimeDatabaseToolsConnectionCredentialExecuteGrantee#key}.</summary>
        [JsiiProperty(name: "key", typeJson: "{\"primitive\":\"string\"}")]
        string Key
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.26.0/docs/resources/database_tools_runtime_database_tools_connection_credential_execute_grantee#id DatabaseToolsRuntimeDatabaseToolsConnectionCredentialExecuteGrantee#id}.</summary>
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
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.26.0/docs/resources/database_tools_runtime_database_tools_connection_credential_execute_grantee#timeouts DatabaseToolsRuntimeDatabaseToolsConnectionCredentialExecuteGrantee#timeouts}
        /// </remarks>
        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"oci.databaseToolsRuntimeDatabaseToolsConnectionCredentialExecuteGrantee.DatabaseToolsRuntimeDatabaseToolsConnectionCredentialExecuteGranteeTimeouts\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.DatabaseToolsRuntimeDatabaseToolsConnectionCredentialExecuteGrantee.IDatabaseToolsRuntimeDatabaseToolsConnectionCredentialExecuteGranteeTimeouts? Timeouts
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDatabaseToolsRuntimeDatabaseToolsConnectionCredentialExecuteGranteeConfig), fullyQualifiedName: "oci.databaseToolsRuntimeDatabaseToolsConnectionCredentialExecuteGrantee.DatabaseToolsRuntimeDatabaseToolsConnectionCredentialExecuteGranteeConfig")]
        internal sealed class _Proxy : DeputyBase, oci.DatabaseToolsRuntimeDatabaseToolsConnectionCredentialExecuteGrantee.IDatabaseToolsRuntimeDatabaseToolsConnectionCredentialExecuteGranteeConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.26.0/docs/resources/database_tools_runtime_database_tools_connection_credential_execute_grantee#credential_key DatabaseToolsRuntimeDatabaseToolsConnectionCredentialExecuteGrantee#credential_key}.</summary>
            [JsiiProperty(name: "credentialKey", typeJson: "{\"primitive\":\"string\"}")]
            public string CredentialKey
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.26.0/docs/resources/database_tools_runtime_database_tools_connection_credential_execute_grantee#database_tools_connection_id DatabaseToolsRuntimeDatabaseToolsConnectionCredentialExecuteGrantee#database_tools_connection_id}.</summary>
            [JsiiProperty(name: "databaseToolsConnectionId", typeJson: "{\"primitive\":\"string\"}")]
            public string DatabaseToolsConnectionId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.26.0/docs/resources/database_tools_runtime_database_tools_connection_credential_execute_grantee#key DatabaseToolsRuntimeDatabaseToolsConnectionCredentialExecuteGrantee#key}.</summary>
            [JsiiProperty(name: "key", typeJson: "{\"primitive\":\"string\"}")]
            public string Key
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.26.0/docs/resources/database_tools_runtime_database_tools_connection_credential_execute_grantee#id DatabaseToolsRuntimeDatabaseToolsConnectionCredentialExecuteGrantee#id}.</summary>
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
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.26.0/docs/resources/database_tools_runtime_database_tools_connection_credential_execute_grantee#timeouts DatabaseToolsRuntimeDatabaseToolsConnectionCredentialExecuteGrantee#timeouts}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"oci.databaseToolsRuntimeDatabaseToolsConnectionCredentialExecuteGrantee.DatabaseToolsRuntimeDatabaseToolsConnectionCredentialExecuteGranteeTimeouts\"}", isOptional: true)]
            public oci.DatabaseToolsRuntimeDatabaseToolsConnectionCredentialExecuteGrantee.IDatabaseToolsRuntimeDatabaseToolsConnectionCredentialExecuteGranteeTimeouts? Timeouts
            {
                get => GetInstanceProperty<oci.DatabaseToolsRuntimeDatabaseToolsConnectionCredentialExecuteGrantee.IDatabaseToolsRuntimeDatabaseToolsConnectionCredentialExecuteGranteeTimeouts?>();
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

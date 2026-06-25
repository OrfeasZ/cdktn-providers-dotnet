using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciDatabaseToolsRuntimeDatabaseToolsConnectionUserCredentials
{
    [JsiiInterface(nativeType: typeof(IDataOciDatabaseToolsRuntimeDatabaseToolsConnectionUserCredentialsConfig), fullyQualifiedName: "oci.dataOciDatabaseToolsRuntimeDatabaseToolsConnectionUserCredentials.DataOciDatabaseToolsRuntimeDatabaseToolsConnectionUserCredentialsConfig")]
    public interface IDataOciDatabaseToolsRuntimeDatabaseToolsConnectionUserCredentialsConfig : Io.Cdktn.ITerraformMetaArguments
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.19.0/docs/data-sources/database_tools_runtime_database_tools_connection_user_credentials#database_tools_connection_id DataOciDatabaseToolsRuntimeDatabaseToolsConnectionUserCredentials#database_tools_connection_id}.</summary>
        [JsiiProperty(name: "databaseToolsConnectionId", typeJson: "{\"primitive\":\"string\"}")]
        string DatabaseToolsConnectionId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.19.0/docs/data-sources/database_tools_runtime_database_tools_connection_user_credentials#user_key DataOciDatabaseToolsRuntimeDatabaseToolsConnectionUserCredentials#user_key}.</summary>
        [JsiiProperty(name: "userKey", typeJson: "{\"primitive\":\"string\"}")]
        string UserKey
        {
            get;
        }

        /// <summary>filter block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.19.0/docs/data-sources/database_tools_runtime_database_tools_connection_user_credentials#filter DataOciDatabaseToolsRuntimeDatabaseToolsConnectionUserCredentials#filter}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="oci.DataOciDatabaseToolsRuntimeDatabaseToolsConnectionUserCredentials.IDataOciDatabaseToolsRuntimeDatabaseToolsConnectionUserCredentialsFilter" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "filter", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.dataOciDatabaseToolsRuntimeDatabaseToolsConnectionUserCredentials.DataOciDatabaseToolsRuntimeDatabaseToolsConnectionUserCredentialsFilter\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Filter
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.19.0/docs/data-sources/database_tools_runtime_database_tools_connection_user_credentials#id DataOciDatabaseToolsRuntimeDatabaseToolsConnectionUserCredentials#id}.</summary>
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

        [JsiiTypeProxy(nativeType: typeof(IDataOciDatabaseToolsRuntimeDatabaseToolsConnectionUserCredentialsConfig), fullyQualifiedName: "oci.dataOciDatabaseToolsRuntimeDatabaseToolsConnectionUserCredentials.DataOciDatabaseToolsRuntimeDatabaseToolsConnectionUserCredentialsConfig")]
        internal sealed class _Proxy : DeputyBase, oci.DataOciDatabaseToolsRuntimeDatabaseToolsConnectionUserCredentials.IDataOciDatabaseToolsRuntimeDatabaseToolsConnectionUserCredentialsConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.19.0/docs/data-sources/database_tools_runtime_database_tools_connection_user_credentials#database_tools_connection_id DataOciDatabaseToolsRuntimeDatabaseToolsConnectionUserCredentials#database_tools_connection_id}.</summary>
            [JsiiProperty(name: "databaseToolsConnectionId", typeJson: "{\"primitive\":\"string\"}")]
            public string DatabaseToolsConnectionId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.19.0/docs/data-sources/database_tools_runtime_database_tools_connection_user_credentials#user_key DataOciDatabaseToolsRuntimeDatabaseToolsConnectionUserCredentials#user_key}.</summary>
            [JsiiProperty(name: "userKey", typeJson: "{\"primitive\":\"string\"}")]
            public string UserKey
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>filter block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.19.0/docs/data-sources/database_tools_runtime_database_tools_connection_user_credentials#filter DataOciDatabaseToolsRuntimeDatabaseToolsConnectionUserCredentials#filter}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="oci.DataOciDatabaseToolsRuntimeDatabaseToolsConnectionUserCredentials.IDataOciDatabaseToolsRuntimeDatabaseToolsConnectionUserCredentialsFilter" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "filter", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.dataOciDatabaseToolsRuntimeDatabaseToolsConnectionUserCredentials.DataOciDatabaseToolsRuntimeDatabaseToolsConnectionUserCredentialsFilter\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Filter
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.19.0/docs/data-sources/database_tools_runtime_database_tools_connection_user_credentials#id DataOciDatabaseToolsRuntimeDatabaseToolsConnectionUserCredentials#id}.</summary>
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

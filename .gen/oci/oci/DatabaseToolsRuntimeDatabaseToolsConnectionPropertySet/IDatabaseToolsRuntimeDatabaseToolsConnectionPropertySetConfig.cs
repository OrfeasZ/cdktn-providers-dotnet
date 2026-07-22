using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DatabaseToolsRuntimeDatabaseToolsConnectionPropertySet
{
    [JsiiInterface(nativeType: typeof(IDatabaseToolsRuntimeDatabaseToolsConnectionPropertySetConfig), fullyQualifiedName: "oci.databaseToolsRuntimeDatabaseToolsConnectionPropertySet.DatabaseToolsRuntimeDatabaseToolsConnectionPropertySetConfig")]
    public interface IDatabaseToolsRuntimeDatabaseToolsConnectionPropertySetConfig : Io.Cdktn.ITerraformMetaArguments
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.24.0/docs/resources/database_tools_runtime_database_tools_connection_property_set#database_tools_connection_id DatabaseToolsRuntimeDatabaseToolsConnectionPropertySet#database_tools_connection_id}.</summary>
        [JsiiProperty(name: "databaseToolsConnectionId", typeJson: "{\"primitive\":\"string\"}")]
        string DatabaseToolsConnectionId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.24.0/docs/resources/database_tools_runtime_database_tools_connection_property_set#key DatabaseToolsRuntimeDatabaseToolsConnectionPropertySet#key}.</summary>
        [JsiiProperty(name: "key", typeJson: "{\"primitive\":\"string\"}")]
        string Key
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.24.0/docs/resources/database_tools_runtime_database_tools_connection_property_set#property_set_key DatabaseToolsRuntimeDatabaseToolsConnectionPropertySet#property_set_key}.</summary>
        [JsiiProperty(name: "propertySetKey", typeJson: "{\"primitive\":\"string\"}")]
        string PropertySetKey
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.24.0/docs/resources/database_tools_runtime_database_tools_connection_property_set#authentication_substitutions DatabaseToolsRuntimeDatabaseToolsConnectionPropertySet#authentication_substitutions}.</summary>
        [JsiiProperty(name: "authenticationSubstitutions", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        System.Collections.Generic.IDictionary<string, string>? AuthenticationSubstitutions
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.24.0/docs/resources/database_tools_runtime_database_tools_connection_property_set#autonomous_database_resource_principal_status DatabaseToolsRuntimeDatabaseToolsConnectionPropertySet#autonomous_database_resource_principal_status}.</summary>
        [JsiiProperty(name: "autonomousDatabaseResourcePrincipalStatus", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? AutonomousDatabaseResourcePrincipalStatus
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.24.0/docs/resources/database_tools_runtime_database_tools_connection_property_set#credential_key DatabaseToolsRuntimeDatabaseToolsConnectionPropertySet#credential_key}.</summary>
        [JsiiProperty(name: "credentialKey", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? CredentialKey
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.24.0/docs/resources/database_tools_runtime_database_tools_connection_property_set#function_id DatabaseToolsRuntimeDatabaseToolsConnectionPropertySet#function_id}.</summary>
        [JsiiProperty(name: "functionId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? FunctionId
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.24.0/docs/resources/database_tools_runtime_database_tools_connection_property_set#id DatabaseToolsRuntimeDatabaseToolsConnectionPropertySet#id}.</summary>
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

        /// <summary>identity_provider block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.24.0/docs/resources/database_tools_runtime_database_tools_connection_property_set#identity_provider DatabaseToolsRuntimeDatabaseToolsConnectionPropertySet#identity_provider}
        /// </remarks>
        [JsiiProperty(name: "identityProvider", typeJson: "{\"fqn\":\"oci.databaseToolsRuntimeDatabaseToolsConnectionPropertySet.DatabaseToolsRuntimeDatabaseToolsConnectionPropertySetIdentityProvider\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.DatabaseToolsRuntimeDatabaseToolsConnectionPropertySet.IDatabaseToolsRuntimeDatabaseToolsConnectionPropertySetIdentityProvider? IdentityProvider
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.24.0/docs/resources/database_tools_runtime_database_tools_connection_property_set#instance_dbms_credential_enabled DatabaseToolsRuntimeDatabaseToolsConnectionPropertySet#instance_dbms_credential_enabled}.</summary>
        [JsiiProperty(name: "instanceDbmsCredentialEnabled", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? InstanceDbmsCredentialEnabled
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.24.0/docs/resources/database_tools_runtime_database_tools_connection_property_set#invoke_endpoint DatabaseToolsRuntimeDatabaseToolsConnectionPropertySet#invoke_endpoint}.</summary>
        [JsiiProperty(name: "invokeEndpoint", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? InvokeEndpoint
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.24.0/docs/resources/database_tools_runtime_database_tools_connection_property_set#object_storage_bucket_compartment_id DatabaseToolsRuntimeDatabaseToolsConnectionPropertySet#object_storage_bucket_compartment_id}.</summary>
        [JsiiProperty(name: "objectStorageBucketCompartmentId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ObjectStorageBucketCompartmentId
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.24.0/docs/resources/database_tools_runtime_database_tools_connection_property_set#object_storage_endpoint DatabaseToolsRuntimeDatabaseToolsConnectionPropertySet#object_storage_endpoint}.</summary>
        [JsiiProperty(name: "objectStorageEndpoint", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ObjectStorageEndpoint
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.24.0/docs/resources/database_tools_runtime_database_tools_connection_property_set#object_storage_namespace DatabaseToolsRuntimeDatabaseToolsConnectionPropertySet#object_storage_namespace}.</summary>
        [JsiiProperty(name: "objectStorageNamespace", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ObjectStorageNamespace
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.24.0/docs/resources/database_tools_runtime_database_tools_connection_property_set#print_server_type DatabaseToolsRuntimeDatabaseToolsConnectionPropertySet#print_server_type}.</summary>
        [JsiiProperty(name: "printServerType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? PrintServerType
        {
            get
            {
                return null;
            }
        }

        /// <summary>timeouts block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.24.0/docs/resources/database_tools_runtime_database_tools_connection_property_set#timeouts DatabaseToolsRuntimeDatabaseToolsConnectionPropertySet#timeouts}
        /// </remarks>
        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"oci.databaseToolsRuntimeDatabaseToolsConnectionPropertySet.DatabaseToolsRuntimeDatabaseToolsConnectionPropertySetTimeouts\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.DatabaseToolsRuntimeDatabaseToolsConnectionPropertySet.IDatabaseToolsRuntimeDatabaseToolsConnectionPropertySetTimeouts? Timeouts
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDatabaseToolsRuntimeDatabaseToolsConnectionPropertySetConfig), fullyQualifiedName: "oci.databaseToolsRuntimeDatabaseToolsConnectionPropertySet.DatabaseToolsRuntimeDatabaseToolsConnectionPropertySetConfig")]
        internal sealed class _Proxy : DeputyBase, oci.DatabaseToolsRuntimeDatabaseToolsConnectionPropertySet.IDatabaseToolsRuntimeDatabaseToolsConnectionPropertySetConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.24.0/docs/resources/database_tools_runtime_database_tools_connection_property_set#database_tools_connection_id DatabaseToolsRuntimeDatabaseToolsConnectionPropertySet#database_tools_connection_id}.</summary>
            [JsiiProperty(name: "databaseToolsConnectionId", typeJson: "{\"primitive\":\"string\"}")]
            public string DatabaseToolsConnectionId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.24.0/docs/resources/database_tools_runtime_database_tools_connection_property_set#key DatabaseToolsRuntimeDatabaseToolsConnectionPropertySet#key}.</summary>
            [JsiiProperty(name: "key", typeJson: "{\"primitive\":\"string\"}")]
            public string Key
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.24.0/docs/resources/database_tools_runtime_database_tools_connection_property_set#property_set_key DatabaseToolsRuntimeDatabaseToolsConnectionPropertySet#property_set_key}.</summary>
            [JsiiProperty(name: "propertySetKey", typeJson: "{\"primitive\":\"string\"}")]
            public string PropertySetKey
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.24.0/docs/resources/database_tools_runtime_database_tools_connection_property_set#authentication_substitutions DatabaseToolsRuntimeDatabaseToolsConnectionPropertySet#authentication_substitutions}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "authenticationSubstitutions", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, string>? AuthenticationSubstitutions
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.24.0/docs/resources/database_tools_runtime_database_tools_connection_property_set#autonomous_database_resource_principal_status DatabaseToolsRuntimeDatabaseToolsConnectionPropertySet#autonomous_database_resource_principal_status}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "autonomousDatabaseResourcePrincipalStatus", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? AutonomousDatabaseResourcePrincipalStatus
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.24.0/docs/resources/database_tools_runtime_database_tools_connection_property_set#credential_key DatabaseToolsRuntimeDatabaseToolsConnectionPropertySet#credential_key}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "credentialKey", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? CredentialKey
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.24.0/docs/resources/database_tools_runtime_database_tools_connection_property_set#function_id DatabaseToolsRuntimeDatabaseToolsConnectionPropertySet#function_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "functionId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? FunctionId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.24.0/docs/resources/database_tools_runtime_database_tools_connection_property_set#id DatabaseToolsRuntimeDatabaseToolsConnectionPropertySet#id}.</summary>
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

            /// <summary>identity_provider block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.24.0/docs/resources/database_tools_runtime_database_tools_connection_property_set#identity_provider DatabaseToolsRuntimeDatabaseToolsConnectionPropertySet#identity_provider}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "identityProvider", typeJson: "{\"fqn\":\"oci.databaseToolsRuntimeDatabaseToolsConnectionPropertySet.DatabaseToolsRuntimeDatabaseToolsConnectionPropertySetIdentityProvider\"}", isOptional: true)]
            public oci.DatabaseToolsRuntimeDatabaseToolsConnectionPropertySet.IDatabaseToolsRuntimeDatabaseToolsConnectionPropertySetIdentityProvider? IdentityProvider
            {
                get => GetInstanceProperty<oci.DatabaseToolsRuntimeDatabaseToolsConnectionPropertySet.IDatabaseToolsRuntimeDatabaseToolsConnectionPropertySetIdentityProvider?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.24.0/docs/resources/database_tools_runtime_database_tools_connection_property_set#instance_dbms_credential_enabled DatabaseToolsRuntimeDatabaseToolsConnectionPropertySet#instance_dbms_credential_enabled}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "instanceDbmsCredentialEnabled", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? InstanceDbmsCredentialEnabled
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.24.0/docs/resources/database_tools_runtime_database_tools_connection_property_set#invoke_endpoint DatabaseToolsRuntimeDatabaseToolsConnectionPropertySet#invoke_endpoint}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "invokeEndpoint", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? InvokeEndpoint
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.24.0/docs/resources/database_tools_runtime_database_tools_connection_property_set#object_storage_bucket_compartment_id DatabaseToolsRuntimeDatabaseToolsConnectionPropertySet#object_storage_bucket_compartment_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "objectStorageBucketCompartmentId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ObjectStorageBucketCompartmentId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.24.0/docs/resources/database_tools_runtime_database_tools_connection_property_set#object_storage_endpoint DatabaseToolsRuntimeDatabaseToolsConnectionPropertySet#object_storage_endpoint}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "objectStorageEndpoint", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ObjectStorageEndpoint
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.24.0/docs/resources/database_tools_runtime_database_tools_connection_property_set#object_storage_namespace DatabaseToolsRuntimeDatabaseToolsConnectionPropertySet#object_storage_namespace}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "objectStorageNamespace", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ObjectStorageNamespace
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.24.0/docs/resources/database_tools_runtime_database_tools_connection_property_set#print_server_type DatabaseToolsRuntimeDatabaseToolsConnectionPropertySet#print_server_type}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "printServerType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? PrintServerType
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>timeouts block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.24.0/docs/resources/database_tools_runtime_database_tools_connection_property_set#timeouts DatabaseToolsRuntimeDatabaseToolsConnectionPropertySet#timeouts}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"oci.databaseToolsRuntimeDatabaseToolsConnectionPropertySet.DatabaseToolsRuntimeDatabaseToolsConnectionPropertySetTimeouts\"}", isOptional: true)]
            public oci.DatabaseToolsRuntimeDatabaseToolsConnectionPropertySet.IDatabaseToolsRuntimeDatabaseToolsConnectionPropertySetTimeouts? Timeouts
            {
                get => GetInstanceProperty<oci.DatabaseToolsRuntimeDatabaseToolsConnectionPropertySet.IDatabaseToolsRuntimeDatabaseToolsConnectionPropertySetTimeouts?>();
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

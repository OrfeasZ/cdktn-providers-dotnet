using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DatabaseToolsRuntimeDatabaseToolsConnectionPropertySet
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.databaseToolsRuntimeDatabaseToolsConnectionPropertySet.DatabaseToolsRuntimeDatabaseToolsConnectionPropertySetConfig")]
    public class DatabaseToolsRuntimeDatabaseToolsConnectionPropertySetConfig : oci.DatabaseToolsRuntimeDatabaseToolsConnectionPropertySet.IDatabaseToolsRuntimeDatabaseToolsConnectionPropertySetConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.22.0/docs/resources/database_tools_runtime_database_tools_connection_property_set#database_tools_connection_id DatabaseToolsRuntimeDatabaseToolsConnectionPropertySet#database_tools_connection_id}.</summary>
        [JsiiProperty(name: "databaseToolsConnectionId", typeJson: "{\"primitive\":\"string\"}")]
        public string DatabaseToolsConnectionId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.22.0/docs/resources/database_tools_runtime_database_tools_connection_property_set#key DatabaseToolsRuntimeDatabaseToolsConnectionPropertySet#key}.</summary>
        [JsiiProperty(name: "key", typeJson: "{\"primitive\":\"string\"}")]
        public string Key
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.22.0/docs/resources/database_tools_runtime_database_tools_connection_property_set#property_set_key DatabaseToolsRuntimeDatabaseToolsConnectionPropertySet#property_set_key}.</summary>
        [JsiiProperty(name: "propertySetKey", typeJson: "{\"primitive\":\"string\"}")]
        public string PropertySetKey
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.22.0/docs/resources/database_tools_runtime_database_tools_connection_property_set#authentication_substitutions DatabaseToolsRuntimeDatabaseToolsConnectionPropertySet#authentication_substitutions}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "authenticationSubstitutions", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public System.Collections.Generic.IDictionary<string, string>? AuthenticationSubstitutions
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.22.0/docs/resources/database_tools_runtime_database_tools_connection_property_set#autonomous_database_resource_principal_status DatabaseToolsRuntimeDatabaseToolsConnectionPropertySet#autonomous_database_resource_principal_status}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "autonomousDatabaseResourcePrincipalStatus", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? AutonomousDatabaseResourcePrincipalStatus
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.22.0/docs/resources/database_tools_runtime_database_tools_connection_property_set#credential_key DatabaseToolsRuntimeDatabaseToolsConnectionPropertySet#credential_key}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "credentialKey", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? CredentialKey
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.22.0/docs/resources/database_tools_runtime_database_tools_connection_property_set#function_id DatabaseToolsRuntimeDatabaseToolsConnectionPropertySet#function_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "functionId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? FunctionId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.22.0/docs/resources/database_tools_runtime_database_tools_connection_property_set#id DatabaseToolsRuntimeDatabaseToolsConnectionPropertySet#id}.</summary>
        /// <remarks>
        /// Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2.
        /// If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Id
        {
            get;
            set;
        }

        /// <summary>identity_provider block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.22.0/docs/resources/database_tools_runtime_database_tools_connection_property_set#identity_provider DatabaseToolsRuntimeDatabaseToolsConnectionPropertySet#identity_provider}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "identityProvider", typeJson: "{\"fqn\":\"oci.databaseToolsRuntimeDatabaseToolsConnectionPropertySet.DatabaseToolsRuntimeDatabaseToolsConnectionPropertySetIdentityProvider\"}", isOptional: true)]
        public oci.DatabaseToolsRuntimeDatabaseToolsConnectionPropertySet.IDatabaseToolsRuntimeDatabaseToolsConnectionPropertySetIdentityProvider? IdentityProvider
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.22.0/docs/resources/database_tools_runtime_database_tools_connection_property_set#instance_dbms_credential_enabled DatabaseToolsRuntimeDatabaseToolsConnectionPropertySet#instance_dbms_credential_enabled}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "instanceDbmsCredentialEnabled", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? InstanceDbmsCredentialEnabled
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.22.0/docs/resources/database_tools_runtime_database_tools_connection_property_set#invoke_endpoint DatabaseToolsRuntimeDatabaseToolsConnectionPropertySet#invoke_endpoint}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "invokeEndpoint", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? InvokeEndpoint
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.22.0/docs/resources/database_tools_runtime_database_tools_connection_property_set#object_storage_bucket_compartment_id DatabaseToolsRuntimeDatabaseToolsConnectionPropertySet#object_storage_bucket_compartment_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "objectStorageBucketCompartmentId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ObjectStorageBucketCompartmentId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.22.0/docs/resources/database_tools_runtime_database_tools_connection_property_set#object_storage_endpoint DatabaseToolsRuntimeDatabaseToolsConnectionPropertySet#object_storage_endpoint}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "objectStorageEndpoint", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ObjectStorageEndpoint
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.22.0/docs/resources/database_tools_runtime_database_tools_connection_property_set#object_storage_namespace DatabaseToolsRuntimeDatabaseToolsConnectionPropertySet#object_storage_namespace}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "objectStorageNamespace", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ObjectStorageNamespace
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.22.0/docs/resources/database_tools_runtime_database_tools_connection_property_set#print_server_type DatabaseToolsRuntimeDatabaseToolsConnectionPropertySet#print_server_type}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "printServerType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? PrintServerType
        {
            get;
            set;
        }

        /// <summary>timeouts block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.22.0/docs/resources/database_tools_runtime_database_tools_connection_property_set#timeouts DatabaseToolsRuntimeDatabaseToolsConnectionPropertySet#timeouts}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"oci.databaseToolsRuntimeDatabaseToolsConnectionPropertySet.DatabaseToolsRuntimeDatabaseToolsConnectionPropertySetTimeouts\"}", isOptional: true)]
        public oci.DatabaseToolsRuntimeDatabaseToolsConnectionPropertySet.IDatabaseToolsRuntimeDatabaseToolsConnectionPropertySetTimeouts? Timeouts
        {
            get;
            set;
        }

        private object? _connection;

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// <para>Type union: either <see cref="Io.Cdktn.ISSHProvisionerConnection" /> or <see cref="Io.Cdktn.IWinrmProvisionerConnection" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "connection", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.SSHProvisionerConnection\"},{\"fqn\":\"cdktn.WinrmProvisionerConnection\"}]}}", isOptional: true)]
        public object? Connection
        {
            get => _connection;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.ISSHProvisionerConnection cast_cd4240:
                            break;
                        case Io.Cdktn.IWinrmProvisionerConnection cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.ISSHProvisionerConnection).FullName}, {typeof(Io.Cdktn.IWinrmProvisionerConnection).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _connection = value;
            }
        }

        private object? _count;

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// <para>Type union: either double or <see cref="Io.Cdktn.TerraformCount" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "count", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"number\"},{\"fqn\":\"cdktn.TerraformCount\"}]}}", isOptional: true)]
        public object? Count
        {
            get => _count;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case double cast_cd4240:
                            break;
                        case byte cast_cd4240:
                            break;
                        case decimal cast_cd4240:
                            break;
                        case float cast_cd4240:
                            break;
                        case int cast_cd4240:
                            break;
                        case long cast_cd4240:
                            break;
                        case sbyte cast_cd4240:
                            break;
                        case short cast_cd4240:
                            break;
                        case uint cast_cd4240:
                            break;
                        case ulong cast_cd4240:
                            break;
                        case ushort cast_cd4240:
                            break;
                        case Io.Cdktn.TerraformCount cast_cd4240:
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: double, {typeof(Io.Cdktn.TerraformCount).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _count = value;
            }
        }

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "dependsOn", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"cdktn.ITerraformDependable\"},\"kind\":\"array\"}}", isOptional: true)]
        public Io.Cdktn.ITerraformDependable[]? DependsOn
        {
            get;
            set;
        }

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "forEach", typeJson: "{\"fqn\":\"cdktn.ITerraformIterator\"}", isOptional: true)]
        public Io.Cdktn.ITerraformIterator? ForEach
        {
            get;
            set;
        }

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "lifecycle", typeJson: "{\"fqn\":\"cdktn.TerraformResourceLifecycle\"}", isOptional: true)]
        public Io.Cdktn.ITerraformResourceLifecycle? Lifecycle
        {
            get;
            set;
        }

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "provider", typeJson: "{\"fqn\":\"cdktn.TerraformProvider\"}", isOptional: true)]
        public Io.Cdktn.TerraformProvider? Provider
        {
            get;
            set;
        }

        private object[]? _provisioners;

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// <para>Type union: (either <see cref="Io.Cdktn.IFileProvisioner" /> or <see cref="Io.Cdktn.ILocalExecProvisioner" /> or <see cref="Io.Cdktn.IRemoteExecProvisioner" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "provisioners", typeJson: "{\"collection\":{\"elementtype\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.FileProvisioner\"},{\"fqn\":\"cdktn.LocalExecProvisioner\"},{\"fqn\":\"cdktn.RemoteExecProvisioner\"}]}},\"kind\":\"array\"}}", isOptional: true)]
        public object[]? Provisioners
        {
            get => _provisioners;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    for (var __idx_cd4240 = 0 ; __idx_cd4240 < value.Length ; __idx_cd4240++)
                    {
                        switch (value[__idx_cd4240])
                        {
                            case Io.Cdktn.IFileProvisioner cast_e9c63e:
                                break;
                            case Io.Cdktn.ILocalExecProvisioner cast_e9c63e:
                                break;
                            case Io.Cdktn.IRemoteExecProvisioner cast_e9c63e:
                                break;
                            case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_e9c63e:
                                // Not enough information to type-check...
                                break;
                            case null:
                                throw new System.ArgumentException($"Expected {nameof(value)}[{__idx_cd4240}] to be one of: {typeof(Io.Cdktn.IFileProvisioner).FullName}, {typeof(Io.Cdktn.ILocalExecProvisioner).FullName}, {typeof(Io.Cdktn.IRemoteExecProvisioner).FullName}; received null", nameof(value));
                            default:
                                throw new System.ArgumentException($"Expected {nameof(value)}[{__idx_cd4240}] to be one of: {typeof(Io.Cdktn.IFileProvisioner).FullName}, {typeof(Io.Cdktn.ILocalExecProvisioner).FullName}, {typeof(Io.Cdktn.IRemoteExecProvisioner).FullName}; received {value[__idx_cd4240].GetType().FullName}", nameof(value));
                        }
                    }
                }
                _provisioners = value;
            }
        }
    }
}

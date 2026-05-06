using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DatabaseMigrationMigration
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.databaseMigrationMigration.DatabaseMigrationMigrationConfig")]
    public class DatabaseMigrationMigrationConfig : oci.DatabaseMigrationMigration.IDatabaseMigrationMigrationConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_migration_migration#compartment_id DatabaseMigrationMigration#compartment_id}.</summary>
        [JsiiProperty(name: "compartmentId", typeJson: "{\"primitive\":\"string\"}")]
        public string CompartmentId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_migration_migration#database_combination DatabaseMigrationMigration#database_combination}.</summary>
        [JsiiProperty(name: "databaseCombination", typeJson: "{\"primitive\":\"string\"}")]
        public string DatabaseCombination
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_migration_migration#source_database_connection_id DatabaseMigrationMigration#source_database_connection_id}.</summary>
        [JsiiProperty(name: "sourceDatabaseConnectionId", typeJson: "{\"primitive\":\"string\"}")]
        public string SourceDatabaseConnectionId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_migration_migration#target_database_connection_id DatabaseMigrationMigration#target_database_connection_id}.</summary>
        [JsiiProperty(name: "targetDatabaseConnectionId", typeJson: "{\"primitive\":\"string\"}")]
        public string TargetDatabaseConnectionId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_migration_migration#type DatabaseMigrationMigration#type}.</summary>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        public string Type
        {
            get;
            set;
        }

        private object? _advancedParameters;

        /// <summary>advanced_parameters block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_migration_migration#advanced_parameters DatabaseMigrationMigration#advanced_parameters}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "advancedParameters", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.databaseMigrationMigration.DatabaseMigrationMigrationAdvancedParameters\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? AdvancedParameters
        {
            get => _advancedParameters;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case oci.DatabaseMigrationMigration.IDatabaseMigrationMigrationAdvancedParameters[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.DatabaseMigrationMigration.IDatabaseMigrationMigrationAdvancedParameters).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _advancedParameters = value;
            }
        }

        /// <summary>advisor_settings block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_migration_migration#advisor_settings DatabaseMigrationMigration#advisor_settings}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "advisorSettings", typeJson: "{\"fqn\":\"oci.databaseMigrationMigration.DatabaseMigrationMigrationAdvisorSettings\"}", isOptional: true)]
        public oci.DatabaseMigrationMigration.IDatabaseMigrationMigrationAdvisorSettings? AdvisorSettings
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_migration_migration#bulk_include_exclude_data DatabaseMigrationMigration#bulk_include_exclude_data}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "bulkIncludeExcludeData", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? BulkIncludeExcludeData
        {
            get;
            set;
        }

        /// <summary>data_transfer_medium_details block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_migration_migration#data_transfer_medium_details DatabaseMigrationMigration#data_transfer_medium_details}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "dataTransferMediumDetails", typeJson: "{\"fqn\":\"oci.databaseMigrationMigration.DatabaseMigrationMigrationDataTransferMediumDetails\"}", isOptional: true)]
        public oci.DatabaseMigrationMigration.IDatabaseMigrationMigrationDataTransferMediumDetails? DataTransferMediumDetails
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_migration_migration#defined_tags DatabaseMigrationMigration#defined_tags}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "definedTags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public System.Collections.Generic.IDictionary<string, string>? DefinedTags
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_migration_migration#description DatabaseMigrationMigration#description}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Description
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_migration_migration#display_name DatabaseMigrationMigration#display_name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "displayName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? DisplayName
        {
            get;
            set;
        }

        private object? _excludeObjects;

        /// <summary>exclude_objects block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_migration_migration#exclude_objects DatabaseMigrationMigration#exclude_objects}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "excludeObjects", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.databaseMigrationMigration.DatabaseMigrationMigrationExcludeObjects\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? ExcludeObjects
        {
            get => _excludeObjects;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case oci.DatabaseMigrationMigration.IDatabaseMigrationMigrationExcludeObjects[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.DatabaseMigrationMigration.IDatabaseMigrationMigrationExcludeObjects).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _excludeObjects = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_migration_migration#freeform_tags DatabaseMigrationMigration#freeform_tags}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "freeformTags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public System.Collections.Generic.IDictionary<string, string>? FreeformTags
        {
            get;
            set;
        }

        /// <summary>ggs_details block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_migration_migration#ggs_details DatabaseMigrationMigration#ggs_details}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "ggsDetails", typeJson: "{\"fqn\":\"oci.databaseMigrationMigration.DatabaseMigrationMigrationGgsDetails\"}", isOptional: true)]
        public oci.DatabaseMigrationMigration.IDatabaseMigrationMigrationGgsDetails? GgsDetails
        {
            get;
            set;
        }

        /// <summary>hub_details block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_migration_migration#hub_details DatabaseMigrationMigration#hub_details}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "hubDetails", typeJson: "{\"fqn\":\"oci.databaseMigrationMigration.DatabaseMigrationMigrationHubDetails\"}", isOptional: true)]
        public oci.DatabaseMigrationMigration.IDatabaseMigrationMigrationHubDetails? HubDetails
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_migration_migration#id DatabaseMigrationMigration#id}.</summary>
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

        private object? _includeObjects;

        /// <summary>include_objects block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_migration_migration#include_objects DatabaseMigrationMigration#include_objects}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "includeObjects", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.databaseMigrationMigration.DatabaseMigrationMigrationIncludeObjects\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? IncludeObjects
        {
            get => _includeObjects;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case oci.DatabaseMigrationMigration.IDatabaseMigrationMigrationIncludeObjects[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.DatabaseMigrationMigration.IDatabaseMigrationMigrationIncludeObjects).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _includeObjects = value;
            }
        }

        /// <summary>initial_load_settings block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_migration_migration#initial_load_settings DatabaseMigrationMigration#initial_load_settings}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "initialLoadSettings", typeJson: "{\"fqn\":\"oci.databaseMigrationMigration.DatabaseMigrationMigrationInitialLoadSettings\"}", isOptional: true)]
        public oci.DatabaseMigrationMigration.IDatabaseMigrationMigrationInitialLoadSettings? InitialLoadSettings
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_migration_migration#source_container_database_connection_id DatabaseMigrationMigration#source_container_database_connection_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "sourceContainerDatabaseConnectionId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? SourceContainerDatabaseConnectionId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_migration_migration#source_standby_database_connection_id DatabaseMigrationMigration#source_standby_database_connection_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "sourceStandbyDatabaseConnectionId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? SourceStandbyDatabaseConnectionId
        {
            get;
            set;
        }

        /// <summary>timeouts block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_migration_migration#timeouts DatabaseMigrationMigration#timeouts}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"oci.databaseMigrationMigration.DatabaseMigrationMigrationTimeouts\"}", isOptional: true)]
        public oci.DatabaseMigrationMigration.IDatabaseMigrationMigrationTimeouts? Timeouts
        {
            get;
            set;
        }

        private object? _connection;

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
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

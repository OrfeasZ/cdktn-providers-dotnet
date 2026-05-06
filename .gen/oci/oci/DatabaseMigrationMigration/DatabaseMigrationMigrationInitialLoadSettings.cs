using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DatabaseMigrationMigration
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.databaseMigrationMigration.DatabaseMigrationMigrationInitialLoadSettings")]
    public class DatabaseMigrationMigrationInitialLoadSettings : oci.DatabaseMigrationMigration.IDatabaseMigrationMigrationInitialLoadSettings
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_migration_migration#job_mode DatabaseMigrationMigration#job_mode}.</summary>
        [JsiiProperty(name: "jobMode", typeJson: "{\"primitive\":\"string\"}")]
        public string JobMode
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_migration_migration#compatibility DatabaseMigrationMigration#compatibility}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "compatibility", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? Compatibility
        {
            get;
            set;
        }

        /// <summary>data_pump_parameters block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_migration_migration#data_pump_parameters DatabaseMigrationMigration#data_pump_parameters}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "dataPumpParameters", typeJson: "{\"fqn\":\"oci.databaseMigrationMigration.DatabaseMigrationMigrationInitialLoadSettingsDataPumpParameters\"}", isOptional: true)]
        public oci.DatabaseMigrationMigration.IDatabaseMigrationMigrationInitialLoadSettingsDataPumpParameters? DataPumpParameters
        {
            get;
            set;
        }

        /// <summary>export_directory_object block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_migration_migration#export_directory_object DatabaseMigrationMigration#export_directory_object}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "exportDirectoryObject", typeJson: "{\"fqn\":\"oci.databaseMigrationMigration.DatabaseMigrationMigrationInitialLoadSettingsExportDirectoryObject\"}", isOptional: true)]
        public oci.DatabaseMigrationMigration.IDatabaseMigrationMigrationInitialLoadSettingsExportDirectoryObject? ExportDirectoryObject
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_migration_migration#handle_grant_errors DatabaseMigrationMigration#handle_grant_errors}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "handleGrantErrors", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? HandleGrantErrors
        {
            get;
            set;
        }

        /// <summary>import_directory_object block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_migration_migration#import_directory_object DatabaseMigrationMigration#import_directory_object}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "importDirectoryObject", typeJson: "{\"fqn\":\"oci.databaseMigrationMigration.DatabaseMigrationMigrationInitialLoadSettingsImportDirectoryObject\"}", isOptional: true)]
        public oci.DatabaseMigrationMigration.IDatabaseMigrationMigrationInitialLoadSettingsImportDirectoryObject? ImportDirectoryObject
        {
            get;
            set;
        }

        private object? _isConsistent;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_migration_migration#is_consistent DatabaseMigrationMigration#is_consistent}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "isConsistent", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? IsConsistent
        {
            get => _isConsistent;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case bool cast_cd4240:
                            break;
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _isConsistent = value;
            }
        }

        private object? _isIgnoreExistingObjects;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_migration_migration#is_ignore_existing_objects DatabaseMigrationMigration#is_ignore_existing_objects}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "isIgnoreExistingObjects", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? IsIgnoreExistingObjects
        {
            get => _isIgnoreExistingObjects;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case bool cast_cd4240:
                            break;
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _isIgnoreExistingObjects = value;
            }
        }

        private object? _isTzUtc;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_migration_migration#is_tz_utc DatabaseMigrationMigration#is_tz_utc}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "isTzUtc", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? IsTzUtc
        {
            get => _isTzUtc;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case bool cast_cd4240:
                            break;
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _isTzUtc = value;
            }
        }

        private object? _metadataRemaps;

        /// <summary>metadata_remaps block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_migration_migration#metadata_remaps DatabaseMigrationMigration#metadata_remaps}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "metadataRemaps", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.databaseMigrationMigration.DatabaseMigrationMigrationInitialLoadSettingsMetadataRemaps\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? MetadataRemaps
        {
            get => _metadataRemaps;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case oci.DatabaseMigrationMigration.IDatabaseMigrationMigrationInitialLoadSettingsMetadataRemaps[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.DatabaseMigrationMigration.IDatabaseMigrationMigrationInitialLoadSettingsMetadataRemaps).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _metadataRemaps = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_migration_migration#primary_key_compatibility DatabaseMigrationMigration#primary_key_compatibility}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "primaryKeyCompatibility", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? PrimaryKeyCompatibility
        {
            get;
            set;
        }

        /// <summary>tablespace_details block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_migration_migration#tablespace_details DatabaseMigrationMigration#tablespace_details}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "tablespaceDetails", typeJson: "{\"fqn\":\"oci.databaseMigrationMigration.DatabaseMigrationMigrationInitialLoadSettingsTablespaceDetails\"}", isOptional: true)]
        public oci.DatabaseMigrationMigration.IDatabaseMigrationMigrationInitialLoadSettingsTablespaceDetails? TablespaceDetails
        {
            get;
            set;
        }
    }
}

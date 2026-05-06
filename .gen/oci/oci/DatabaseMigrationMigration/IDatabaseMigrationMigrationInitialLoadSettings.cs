using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DatabaseMigrationMigration
{
    [JsiiInterface(nativeType: typeof(IDatabaseMigrationMigrationInitialLoadSettings), fullyQualifiedName: "oci.databaseMigrationMigration.DatabaseMigrationMigrationInitialLoadSettings")]
    public interface IDatabaseMigrationMigrationInitialLoadSettings
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_migration_migration#job_mode DatabaseMigrationMigration#job_mode}.</summary>
        [JsiiProperty(name: "jobMode", typeJson: "{\"primitive\":\"string\"}")]
        string JobMode
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_migration_migration#compatibility DatabaseMigrationMigration#compatibility}.</summary>
        [JsiiProperty(name: "compatibility", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? Compatibility
        {
            get
            {
                return null;
            }
        }

        /// <summary>data_pump_parameters block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_migration_migration#data_pump_parameters DatabaseMigrationMigration#data_pump_parameters}
        /// </remarks>
        [JsiiProperty(name: "dataPumpParameters", typeJson: "{\"fqn\":\"oci.databaseMigrationMigration.DatabaseMigrationMigrationInitialLoadSettingsDataPumpParameters\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.DatabaseMigrationMigration.IDatabaseMigrationMigrationInitialLoadSettingsDataPumpParameters? DataPumpParameters
        {
            get
            {
                return null;
            }
        }

        /// <summary>export_directory_object block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_migration_migration#export_directory_object DatabaseMigrationMigration#export_directory_object}
        /// </remarks>
        [JsiiProperty(name: "exportDirectoryObject", typeJson: "{\"fqn\":\"oci.databaseMigrationMigration.DatabaseMigrationMigrationInitialLoadSettingsExportDirectoryObject\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.DatabaseMigrationMigration.IDatabaseMigrationMigrationInitialLoadSettingsExportDirectoryObject? ExportDirectoryObject
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_migration_migration#handle_grant_errors DatabaseMigrationMigration#handle_grant_errors}.</summary>
        [JsiiProperty(name: "handleGrantErrors", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? HandleGrantErrors
        {
            get
            {
                return null;
            }
        }

        /// <summary>import_directory_object block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_migration_migration#import_directory_object DatabaseMigrationMigration#import_directory_object}
        /// </remarks>
        [JsiiProperty(name: "importDirectoryObject", typeJson: "{\"fqn\":\"oci.databaseMigrationMigration.DatabaseMigrationMigrationInitialLoadSettingsImportDirectoryObject\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.DatabaseMigrationMigration.IDatabaseMigrationMigrationInitialLoadSettingsImportDirectoryObject? ImportDirectoryObject
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_migration_migration#is_consistent DatabaseMigrationMigration#is_consistent}.</summary>
        [JsiiProperty(name: "isConsistent", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? IsConsistent
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_migration_migration#is_ignore_existing_objects DatabaseMigrationMigration#is_ignore_existing_objects}.</summary>
        [JsiiProperty(name: "isIgnoreExistingObjects", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? IsIgnoreExistingObjects
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_migration_migration#is_tz_utc DatabaseMigrationMigration#is_tz_utc}.</summary>
        [JsiiProperty(name: "isTzUtc", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? IsTzUtc
        {
            get
            {
                return null;
            }
        }

        /// <summary>metadata_remaps block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_migration_migration#metadata_remaps DatabaseMigrationMigration#metadata_remaps}
        /// </remarks>
        [JsiiProperty(name: "metadataRemaps", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.databaseMigrationMigration.DatabaseMigrationMigrationInitialLoadSettingsMetadataRemaps\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? MetadataRemaps
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_migration_migration#primary_key_compatibility DatabaseMigrationMigration#primary_key_compatibility}.</summary>
        [JsiiProperty(name: "primaryKeyCompatibility", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? PrimaryKeyCompatibility
        {
            get
            {
                return null;
            }
        }

        /// <summary>tablespace_details block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_migration_migration#tablespace_details DatabaseMigrationMigration#tablespace_details}
        /// </remarks>
        [JsiiProperty(name: "tablespaceDetails", typeJson: "{\"fqn\":\"oci.databaseMigrationMigration.DatabaseMigrationMigrationInitialLoadSettingsTablespaceDetails\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.DatabaseMigrationMigration.IDatabaseMigrationMigrationInitialLoadSettingsTablespaceDetails? TablespaceDetails
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDatabaseMigrationMigrationInitialLoadSettings), fullyQualifiedName: "oci.databaseMigrationMigration.DatabaseMigrationMigrationInitialLoadSettings")]
        internal sealed class _Proxy : DeputyBase, oci.DatabaseMigrationMigration.IDatabaseMigrationMigrationInitialLoadSettings
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_migration_migration#job_mode DatabaseMigrationMigration#job_mode}.</summary>
            [JsiiProperty(name: "jobMode", typeJson: "{\"primitive\":\"string\"}")]
            public string JobMode
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_migration_migration#compatibility DatabaseMigrationMigration#compatibility}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "compatibility", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? Compatibility
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>data_pump_parameters block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_migration_migration#data_pump_parameters DatabaseMigrationMigration#data_pump_parameters}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "dataPumpParameters", typeJson: "{\"fqn\":\"oci.databaseMigrationMigration.DatabaseMigrationMigrationInitialLoadSettingsDataPumpParameters\"}", isOptional: true)]
            public oci.DatabaseMigrationMigration.IDatabaseMigrationMigrationInitialLoadSettingsDataPumpParameters? DataPumpParameters
            {
                get => GetInstanceProperty<oci.DatabaseMigrationMigration.IDatabaseMigrationMigrationInitialLoadSettingsDataPumpParameters?>();
            }

            /// <summary>export_directory_object block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_migration_migration#export_directory_object DatabaseMigrationMigration#export_directory_object}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "exportDirectoryObject", typeJson: "{\"fqn\":\"oci.databaseMigrationMigration.DatabaseMigrationMigrationInitialLoadSettingsExportDirectoryObject\"}", isOptional: true)]
            public oci.DatabaseMigrationMigration.IDatabaseMigrationMigrationInitialLoadSettingsExportDirectoryObject? ExportDirectoryObject
            {
                get => GetInstanceProperty<oci.DatabaseMigrationMigration.IDatabaseMigrationMigrationInitialLoadSettingsExportDirectoryObject?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_migration_migration#handle_grant_errors DatabaseMigrationMigration#handle_grant_errors}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "handleGrantErrors", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? HandleGrantErrors
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>import_directory_object block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_migration_migration#import_directory_object DatabaseMigrationMigration#import_directory_object}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "importDirectoryObject", typeJson: "{\"fqn\":\"oci.databaseMigrationMigration.DatabaseMigrationMigrationInitialLoadSettingsImportDirectoryObject\"}", isOptional: true)]
            public oci.DatabaseMigrationMigration.IDatabaseMigrationMigrationInitialLoadSettingsImportDirectoryObject? ImportDirectoryObject
            {
                get => GetInstanceProperty<oci.DatabaseMigrationMigration.IDatabaseMigrationMigrationInitialLoadSettingsImportDirectoryObject?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_migration_migration#is_consistent DatabaseMigrationMigration#is_consistent}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "isConsistent", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? IsConsistent
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_migration_migration#is_ignore_existing_objects DatabaseMigrationMigration#is_ignore_existing_objects}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "isIgnoreExistingObjects", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? IsIgnoreExistingObjects
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_migration_migration#is_tz_utc DatabaseMigrationMigration#is_tz_utc}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "isTzUtc", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? IsTzUtc
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>metadata_remaps block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_migration_migration#metadata_remaps DatabaseMigrationMigration#metadata_remaps}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "metadataRemaps", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.databaseMigrationMigration.DatabaseMigrationMigrationInitialLoadSettingsMetadataRemaps\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? MetadataRemaps
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_migration_migration#primary_key_compatibility DatabaseMigrationMigration#primary_key_compatibility}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "primaryKeyCompatibility", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? PrimaryKeyCompatibility
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>tablespace_details block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_migration_migration#tablespace_details DatabaseMigrationMigration#tablespace_details}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "tablespaceDetails", typeJson: "{\"fqn\":\"oci.databaseMigrationMigration.DatabaseMigrationMigrationInitialLoadSettingsTablespaceDetails\"}", isOptional: true)]
            public oci.DatabaseMigrationMigration.IDatabaseMigrationMigrationInitialLoadSettingsTablespaceDetails? TablespaceDetails
            {
                get => GetInstanceProperty<oci.DatabaseMigrationMigration.IDatabaseMigrationMigrationInitialLoadSettingsTablespaceDetails?>();
            }
        }
    }
}

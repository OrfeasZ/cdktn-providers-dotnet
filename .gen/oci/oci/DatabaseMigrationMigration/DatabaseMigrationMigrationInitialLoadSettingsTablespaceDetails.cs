using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DatabaseMigrationMigration
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.databaseMigrationMigration.DatabaseMigrationMigrationInitialLoadSettingsTablespaceDetails")]
    public class DatabaseMigrationMigrationInitialLoadSettingsTablespaceDetails : oci.DatabaseMigrationMigration.IDatabaseMigrationMigrationInitialLoadSettingsTablespaceDetails
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_migration_migration#target_type DatabaseMigrationMigration#target_type}.</summary>
        [JsiiProperty(name: "targetType", typeJson: "{\"primitive\":\"string\"}")]
        public string TargetType
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_migration_migration#block_size_in_kbs DatabaseMigrationMigration#block_size_in_kbs}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "blockSizeInKbs", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? BlockSizeInKbs
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_migration_migration#extend_size_in_mbs DatabaseMigrationMigration#extend_size_in_mbs}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "extendSizeInMbs", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? ExtendSizeInMbs
        {
            get;
            set;
        }

        private object? _isAutoCreate;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_migration_migration#is_auto_create DatabaseMigrationMigration#is_auto_create}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "isAutoCreate", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? IsAutoCreate
        {
            get => _isAutoCreate;
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
                _isAutoCreate = value;
            }
        }

        private object? _isBigFile;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_migration_migration#is_big_file DatabaseMigrationMigration#is_big_file}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "isBigFile", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? IsBigFile
        {
            get => _isBigFile;
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
                _isBigFile = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_migration_migration#remap_target DatabaseMigrationMigration#remap_target}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "remapTarget", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? RemapTarget
        {
            get;
            set;
        }
    }
}

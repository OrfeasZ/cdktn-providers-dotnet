using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DatabaseMigrationMigration
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.databaseMigrationMigration.DatabaseMigrationMigrationExcludeObjects")]
    public class DatabaseMigrationMigrationExcludeObjects : oci.DatabaseMigrationMigration.IDatabaseMigrationMigrationExcludeObjects
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_migration_migration#object DatabaseMigrationMigration#object}.</summary>
        [JsiiProperty(name: "object", typeJson: "{\"primitive\":\"string\"}")]
        public string Object
        {
            get;
            set;
        }

        private object? _isOmitExcludedTableFromReplication;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_migration_migration#is_omit_excluded_table_from_replication DatabaseMigrationMigration#is_omit_excluded_table_from_replication}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "isOmitExcludedTableFromReplication", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? IsOmitExcludedTableFromReplication
        {
            get => _isOmitExcludedTableFromReplication;
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
                _isOmitExcludedTableFromReplication = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_migration_migration#owner DatabaseMigrationMigration#owner}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "owner", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Owner
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_migration_migration#schema DatabaseMigrationMigration#schema}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "schema", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Schema
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_migration_migration#type DatabaseMigrationMigration#type}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Type
        {
            get;
            set;
        }
    }
}

using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DatabaseMigrationMigration
{
    [JsiiByValue(fqn: "oci.databaseMigrationMigration.DatabaseMigrationMigrationInitialLoadSettingsMetadataRemaps")]
    public class DatabaseMigrationMigrationInitialLoadSettingsMetadataRemaps : oci.DatabaseMigrationMigration.IDatabaseMigrationMigrationInitialLoadSettingsMetadataRemaps
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_migration_migration#new_value DatabaseMigrationMigration#new_value}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "newValue", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? NewValue
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_migration_migration#old_value DatabaseMigrationMigration#old_value}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "oldValue", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? OldValue
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

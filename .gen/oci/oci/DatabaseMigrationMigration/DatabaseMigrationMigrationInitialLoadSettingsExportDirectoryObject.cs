using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DatabaseMigrationMigration
{
    [JsiiByValue(fqn: "oci.databaseMigrationMigration.DatabaseMigrationMigrationInitialLoadSettingsExportDirectoryObject")]
    public class DatabaseMigrationMigrationInitialLoadSettingsExportDirectoryObject : oci.DatabaseMigrationMigration.IDatabaseMigrationMigrationInitialLoadSettingsExportDirectoryObject
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_migration_migration#name DatabaseMigrationMigration#name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Name
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_migration_migration#path DatabaseMigrationMigration#path}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "path", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Path
        {
            get;
            set;
        }
    }
}

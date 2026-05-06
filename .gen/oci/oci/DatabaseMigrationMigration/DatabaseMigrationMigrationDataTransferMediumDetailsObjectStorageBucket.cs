using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DatabaseMigrationMigration
{
    [JsiiByValue(fqn: "oci.databaseMigrationMigration.DatabaseMigrationMigrationDataTransferMediumDetailsObjectStorageBucket")]
    public class DatabaseMigrationMigrationDataTransferMediumDetailsObjectStorageBucket : oci.DatabaseMigrationMigration.IDatabaseMigrationMigrationDataTransferMediumDetailsObjectStorageBucket
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_migration_migration#bucket DatabaseMigrationMigration#bucket}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "bucket", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Bucket
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_migration_migration#namespace DatabaseMigrationMigration#namespace}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "namespace", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Namespace
        {
            get;
            set;
        }
    }
}

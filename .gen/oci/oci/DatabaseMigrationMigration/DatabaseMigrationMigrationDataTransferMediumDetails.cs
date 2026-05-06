using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DatabaseMigrationMigration
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.databaseMigrationMigration.DatabaseMigrationMigrationDataTransferMediumDetails")]
    public class DatabaseMigrationMigrationDataTransferMediumDetails : oci.DatabaseMigrationMigration.IDatabaseMigrationMigrationDataTransferMediumDetails
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_migration_migration#type DatabaseMigrationMigration#type}.</summary>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        public string Type
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_migration_migration#access_key_id DatabaseMigrationMigration#access_key_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "accessKeyId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? AccessKeyId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_migration_migration#name DatabaseMigrationMigration#name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Name
        {
            get;
            set;
        }

        /// <summary>object_storage_bucket block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_migration_migration#object_storage_bucket DatabaseMigrationMigration#object_storage_bucket}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "objectStorageBucket", typeJson: "{\"fqn\":\"oci.databaseMigrationMigration.DatabaseMigrationMigrationDataTransferMediumDetailsObjectStorageBucket\"}", isOptional: true)]
        public oci.DatabaseMigrationMigration.IDatabaseMigrationMigrationDataTransferMediumDetailsObjectStorageBucket? ObjectStorageBucket
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_migration_migration#region DatabaseMigrationMigration#region}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "region", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Region
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_migration_migration#secret_access_key DatabaseMigrationMigration#secret_access_key}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "secretAccessKey", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? SecretAccessKey
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_migration_migration#shared_storage_mount_target_id DatabaseMigrationMigration#shared_storage_mount_target_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "sharedStorageMountTargetId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? SharedStorageMountTargetId
        {
            get;
            set;
        }

        /// <summary>source block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_migration_migration#source DatabaseMigrationMigration#source}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "source", typeJson: "{\"fqn\":\"oci.databaseMigrationMigration.DatabaseMigrationMigrationDataTransferMediumDetailsSource\"}", isOptional: true)]
        public oci.DatabaseMigrationMigration.IDatabaseMigrationMigrationDataTransferMediumDetailsSource? Source
        {
            get;
            set;
        }

        /// <summary>target block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_migration_migration#target DatabaseMigrationMigration#target}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "target", typeJson: "{\"fqn\":\"oci.databaseMigrationMigration.DatabaseMigrationMigrationDataTransferMediumDetailsTarget\"}", isOptional: true)]
        public oci.DatabaseMigrationMigration.IDatabaseMigrationMigrationDataTransferMediumDetailsTarget? Target
        {
            get;
            set;
        }
    }
}

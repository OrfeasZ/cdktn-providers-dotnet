using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DatabaseMigrationMigration
{
    [JsiiInterface(nativeType: typeof(IDatabaseMigrationMigrationDataTransferMediumDetails), fullyQualifiedName: "oci.databaseMigrationMigration.DatabaseMigrationMigrationDataTransferMediumDetails")]
    public interface IDatabaseMigrationMigrationDataTransferMediumDetails
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_migration_migration#type DatabaseMigrationMigration#type}.</summary>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        string Type
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_migration_migration#access_key_id DatabaseMigrationMigration#access_key_id}.</summary>
        [JsiiProperty(name: "accessKeyId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? AccessKeyId
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_migration_migration#name DatabaseMigrationMigration#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Name
        {
            get
            {
                return null;
            }
        }

        /// <summary>object_storage_bucket block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_migration_migration#object_storage_bucket DatabaseMigrationMigration#object_storage_bucket}
        /// </remarks>
        [JsiiProperty(name: "objectStorageBucket", typeJson: "{\"fqn\":\"oci.databaseMigrationMigration.DatabaseMigrationMigrationDataTransferMediumDetailsObjectStorageBucket\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.DatabaseMigrationMigration.IDatabaseMigrationMigrationDataTransferMediumDetailsObjectStorageBucket? ObjectStorageBucket
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_migration_migration#region DatabaseMigrationMigration#region}.</summary>
        [JsiiProperty(name: "region", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Region
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_migration_migration#secret_access_key DatabaseMigrationMigration#secret_access_key}.</summary>
        [JsiiProperty(name: "secretAccessKey", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? SecretAccessKey
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_migration_migration#shared_storage_mount_target_id DatabaseMigrationMigration#shared_storage_mount_target_id}.</summary>
        [JsiiProperty(name: "sharedStorageMountTargetId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? SharedStorageMountTargetId
        {
            get
            {
                return null;
            }
        }

        /// <summary>source block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_migration_migration#source DatabaseMigrationMigration#source}
        /// </remarks>
        [JsiiProperty(name: "source", typeJson: "{\"fqn\":\"oci.databaseMigrationMigration.DatabaseMigrationMigrationDataTransferMediumDetailsSource\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.DatabaseMigrationMigration.IDatabaseMigrationMigrationDataTransferMediumDetailsSource? Source
        {
            get
            {
                return null;
            }
        }

        /// <summary>target block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_migration_migration#target DatabaseMigrationMigration#target}
        /// </remarks>
        [JsiiProperty(name: "target", typeJson: "{\"fqn\":\"oci.databaseMigrationMigration.DatabaseMigrationMigrationDataTransferMediumDetailsTarget\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.DatabaseMigrationMigration.IDatabaseMigrationMigrationDataTransferMediumDetailsTarget? Target
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDatabaseMigrationMigrationDataTransferMediumDetails), fullyQualifiedName: "oci.databaseMigrationMigration.DatabaseMigrationMigrationDataTransferMediumDetails")]
        internal sealed class _Proxy : DeputyBase, oci.DatabaseMigrationMigration.IDatabaseMigrationMigrationDataTransferMediumDetails
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_migration_migration#type DatabaseMigrationMigration#type}.</summary>
            [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
            public string Type
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_migration_migration#access_key_id DatabaseMigrationMigration#access_key_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "accessKeyId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? AccessKeyId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_migration_migration#name DatabaseMigrationMigration#name}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Name
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>object_storage_bucket block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_migration_migration#object_storage_bucket DatabaseMigrationMigration#object_storage_bucket}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "objectStorageBucket", typeJson: "{\"fqn\":\"oci.databaseMigrationMigration.DatabaseMigrationMigrationDataTransferMediumDetailsObjectStorageBucket\"}", isOptional: true)]
            public oci.DatabaseMigrationMigration.IDatabaseMigrationMigrationDataTransferMediumDetailsObjectStorageBucket? ObjectStorageBucket
            {
                get => GetInstanceProperty<oci.DatabaseMigrationMigration.IDatabaseMigrationMigrationDataTransferMediumDetailsObjectStorageBucket?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_migration_migration#region DatabaseMigrationMigration#region}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "region", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Region
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_migration_migration#secret_access_key DatabaseMigrationMigration#secret_access_key}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "secretAccessKey", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? SecretAccessKey
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_migration_migration#shared_storage_mount_target_id DatabaseMigrationMigration#shared_storage_mount_target_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "sharedStorageMountTargetId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? SharedStorageMountTargetId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>source block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_migration_migration#source DatabaseMigrationMigration#source}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "source", typeJson: "{\"fqn\":\"oci.databaseMigrationMigration.DatabaseMigrationMigrationDataTransferMediumDetailsSource\"}", isOptional: true)]
            public oci.DatabaseMigrationMigration.IDatabaseMigrationMigrationDataTransferMediumDetailsSource? Source
            {
                get => GetInstanceProperty<oci.DatabaseMigrationMigration.IDatabaseMigrationMigrationDataTransferMediumDetailsSource?>();
            }

            /// <summary>target block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_migration_migration#target DatabaseMigrationMigration#target}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "target", typeJson: "{\"fqn\":\"oci.databaseMigrationMigration.DatabaseMigrationMigrationDataTransferMediumDetailsTarget\"}", isOptional: true)]
            public oci.DatabaseMigrationMigration.IDatabaseMigrationMigrationDataTransferMediumDetailsTarget? Target
            {
                get => GetInstanceProperty<oci.DatabaseMigrationMigration.IDatabaseMigrationMigrationDataTransferMediumDetailsTarget?>();
            }
        }
    }
}

using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DatabaseDbHome
{
    [JsiiInterface(nativeType: typeof(IDatabaseDbHomeDatabase), fullyQualifiedName: "oci.databaseDbHome.DatabaseDbHomeDatabase")]
    public interface IDatabaseDbHomeDatabase
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_db_home#admin_password DatabaseDbHome#admin_password}.</summary>
        [JsiiProperty(name: "adminPassword", typeJson: "{\"primitive\":\"string\"}")]
        string AdminPassword
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_db_home#backup_id DatabaseDbHome#backup_id}.</summary>
        [JsiiProperty(name: "backupId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? BackupId
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_db_home#backup_tde_password DatabaseDbHome#backup_tde_password}.</summary>
        [JsiiProperty(name: "backupTdePassword", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? BackupTdePassword
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_db_home#character_set DatabaseDbHome#character_set}.</summary>
        [JsiiProperty(name: "characterSet", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? CharacterSet
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_db_home#database_id DatabaseDbHome#database_id}.</summary>
        [JsiiProperty(name: "databaseId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? DatabaseId
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_db_home#database_software_image_id DatabaseDbHome#database_software_image_id}.</summary>
        [JsiiProperty(name: "databaseSoftwareImageId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? DatabaseSoftwareImageId
        {
            get
            {
                return null;
            }
        }

        /// <summary>db_backup_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_db_home#db_backup_config DatabaseDbHome#db_backup_config}
        /// </remarks>
        [JsiiProperty(name: "dbBackupConfig", typeJson: "{\"fqn\":\"oci.databaseDbHome.DatabaseDbHomeDatabaseDbBackupConfig\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.DatabaseDbHome.IDatabaseDbHomeDatabaseDbBackupConfig? DbBackupConfig
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_db_home#db_name DatabaseDbHome#db_name}.</summary>
        [JsiiProperty(name: "dbName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? DbName
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_db_home#db_workload DatabaseDbHome#db_workload}.</summary>
        [JsiiProperty(name: "dbWorkload", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? DbWorkload
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_db_home#defined_tags DatabaseDbHome#defined_tags}.</summary>
        [JsiiProperty(name: "definedTags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        System.Collections.Generic.IDictionary<string, string>? DefinedTags
        {
            get
            {
                return null;
            }
        }

        /// <summary>encryption_key_location_details block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_db_home#encryption_key_location_details DatabaseDbHome#encryption_key_location_details}
        /// </remarks>
        [JsiiProperty(name: "encryptionKeyLocationDetails", typeJson: "{\"fqn\":\"oci.databaseDbHome.DatabaseDbHomeDatabaseEncryptionKeyLocationDetails\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.DatabaseDbHome.IDatabaseDbHomeDatabaseEncryptionKeyLocationDetails? EncryptionKeyLocationDetails
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_db_home#freeform_tags DatabaseDbHome#freeform_tags}.</summary>
        [JsiiProperty(name: "freeformTags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        System.Collections.Generic.IDictionary<string, string>? FreeformTags
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_db_home#key_store_id DatabaseDbHome#key_store_id}.</summary>
        [JsiiProperty(name: "keyStoreId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? KeyStoreId
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_db_home#kms_key_id DatabaseDbHome#kms_key_id}.</summary>
        [JsiiProperty(name: "kmsKeyId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? KmsKeyId
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_db_home#kms_key_version_id DatabaseDbHome#kms_key_version_id}.</summary>
        [JsiiProperty(name: "kmsKeyVersionId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? KmsKeyVersionId
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_db_home#ncharacter_set DatabaseDbHome#ncharacter_set}.</summary>
        [JsiiProperty(name: "ncharacterSet", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? NcharacterSet
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_db_home#pdb_name DatabaseDbHome#pdb_name}.</summary>
        [JsiiProperty(name: "pdbName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? PdbName
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_db_home#pluggable_databases DatabaseDbHome#pluggable_databases}.</summary>
        [JsiiProperty(name: "pluggableDatabases", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? PluggableDatabases
        {
            get
            {
                return null;
            }
        }

        /// <summary>storage_size_details block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_db_home#storage_size_details DatabaseDbHome#storage_size_details}
        /// </remarks>
        [JsiiProperty(name: "storageSizeDetails", typeJson: "{\"fqn\":\"oci.databaseDbHome.DatabaseDbHomeDatabaseStorageSizeDetails\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.DatabaseDbHome.IDatabaseDbHomeDatabaseStorageSizeDetails? StorageSizeDetails
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_db_home#tde_wallet_password DatabaseDbHome#tde_wallet_password}.</summary>
        [JsiiProperty(name: "tdeWalletPassword", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? TdeWalletPassword
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_db_home#time_stamp_for_point_in_time_recovery DatabaseDbHome#time_stamp_for_point_in_time_recovery}.</summary>
        [JsiiProperty(name: "timeStampForPointInTimeRecovery", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? TimeStampForPointInTimeRecovery
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_db_home#vault_id DatabaseDbHome#vault_id}.</summary>
        [JsiiProperty(name: "vaultId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? VaultId
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDatabaseDbHomeDatabase), fullyQualifiedName: "oci.databaseDbHome.DatabaseDbHomeDatabase")]
        internal sealed class _Proxy : DeputyBase, oci.DatabaseDbHome.IDatabaseDbHomeDatabase
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_db_home#admin_password DatabaseDbHome#admin_password}.</summary>
            [JsiiProperty(name: "adminPassword", typeJson: "{\"primitive\":\"string\"}")]
            public string AdminPassword
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_db_home#backup_id DatabaseDbHome#backup_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "backupId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? BackupId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_db_home#backup_tde_password DatabaseDbHome#backup_tde_password}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "backupTdePassword", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? BackupTdePassword
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_db_home#character_set DatabaseDbHome#character_set}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "characterSet", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? CharacterSet
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_db_home#database_id DatabaseDbHome#database_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "databaseId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? DatabaseId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_db_home#database_software_image_id DatabaseDbHome#database_software_image_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "databaseSoftwareImageId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? DatabaseSoftwareImageId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>db_backup_config block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_db_home#db_backup_config DatabaseDbHome#db_backup_config}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "dbBackupConfig", typeJson: "{\"fqn\":\"oci.databaseDbHome.DatabaseDbHomeDatabaseDbBackupConfig\"}", isOptional: true)]
            public oci.DatabaseDbHome.IDatabaseDbHomeDatabaseDbBackupConfig? DbBackupConfig
            {
                get => GetInstanceProperty<oci.DatabaseDbHome.IDatabaseDbHomeDatabaseDbBackupConfig?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_db_home#db_name DatabaseDbHome#db_name}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "dbName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? DbName
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_db_home#db_workload DatabaseDbHome#db_workload}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "dbWorkload", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? DbWorkload
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_db_home#defined_tags DatabaseDbHome#defined_tags}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "definedTags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, string>? DefinedTags
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
            }

            /// <summary>encryption_key_location_details block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_db_home#encryption_key_location_details DatabaseDbHome#encryption_key_location_details}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "encryptionKeyLocationDetails", typeJson: "{\"fqn\":\"oci.databaseDbHome.DatabaseDbHomeDatabaseEncryptionKeyLocationDetails\"}", isOptional: true)]
            public oci.DatabaseDbHome.IDatabaseDbHomeDatabaseEncryptionKeyLocationDetails? EncryptionKeyLocationDetails
            {
                get => GetInstanceProperty<oci.DatabaseDbHome.IDatabaseDbHomeDatabaseEncryptionKeyLocationDetails?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_db_home#freeform_tags DatabaseDbHome#freeform_tags}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "freeformTags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, string>? FreeformTags
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_db_home#key_store_id DatabaseDbHome#key_store_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "keyStoreId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? KeyStoreId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_db_home#kms_key_id DatabaseDbHome#kms_key_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "kmsKeyId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? KmsKeyId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_db_home#kms_key_version_id DatabaseDbHome#kms_key_version_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "kmsKeyVersionId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? KmsKeyVersionId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_db_home#ncharacter_set DatabaseDbHome#ncharacter_set}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "ncharacterSet", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? NcharacterSet
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_db_home#pdb_name DatabaseDbHome#pdb_name}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "pdbName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? PdbName
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_db_home#pluggable_databases DatabaseDbHome#pluggable_databases}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "pluggableDatabases", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? PluggableDatabases
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>storage_size_details block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_db_home#storage_size_details DatabaseDbHome#storage_size_details}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "storageSizeDetails", typeJson: "{\"fqn\":\"oci.databaseDbHome.DatabaseDbHomeDatabaseStorageSizeDetails\"}", isOptional: true)]
            public oci.DatabaseDbHome.IDatabaseDbHomeDatabaseStorageSizeDetails? StorageSizeDetails
            {
                get => GetInstanceProperty<oci.DatabaseDbHome.IDatabaseDbHomeDatabaseStorageSizeDetails?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_db_home#tde_wallet_password DatabaseDbHome#tde_wallet_password}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "tdeWalletPassword", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? TdeWalletPassword
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_db_home#time_stamp_for_point_in_time_recovery DatabaseDbHome#time_stamp_for_point_in_time_recovery}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "timeStampForPointInTimeRecovery", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? TimeStampForPointInTimeRecovery
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_db_home#vault_id DatabaseDbHome#vault_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "vaultId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? VaultId
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}

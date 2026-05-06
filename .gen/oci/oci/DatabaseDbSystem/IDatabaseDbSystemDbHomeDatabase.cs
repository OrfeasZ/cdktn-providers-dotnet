using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DatabaseDbSystem
{
    [JsiiInterface(nativeType: typeof(IDatabaseDbSystemDbHomeDatabase), fullyQualifiedName: "oci.databaseDbSystem.DatabaseDbSystemDbHomeDatabase")]
    public interface IDatabaseDbSystemDbHomeDatabase
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_db_system#admin_password DatabaseDbSystem#admin_password}.</summary>
        [JsiiProperty(name: "adminPassword", typeJson: "{\"primitive\":\"string\"}")]
        string AdminPassword
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_db_system#backup_id DatabaseDbSystem#backup_id}.</summary>
        [JsiiProperty(name: "backupId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? BackupId
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_db_system#backup_tde_password DatabaseDbSystem#backup_tde_password}.</summary>
        [JsiiProperty(name: "backupTdePassword", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? BackupTdePassword
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_db_system#character_set DatabaseDbSystem#character_set}.</summary>
        [JsiiProperty(name: "characterSet", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? CharacterSet
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_db_system#database_id DatabaseDbSystem#database_id}.</summary>
        [JsiiProperty(name: "databaseId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? DatabaseId
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_db_system#database_software_image_id DatabaseDbSystem#database_software_image_id}.</summary>
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
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_db_system#db_backup_config DatabaseDbSystem#db_backup_config}
        /// </remarks>
        [JsiiProperty(name: "dbBackupConfig", typeJson: "{\"fqn\":\"oci.databaseDbSystem.DatabaseDbSystemDbHomeDatabaseDbBackupConfig\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.DatabaseDbSystem.IDatabaseDbSystemDbHomeDatabaseDbBackupConfig? DbBackupConfig
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_db_system#db_domain DatabaseDbSystem#db_domain}.</summary>
        [JsiiProperty(name: "dbDomain", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? DbDomain
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_db_system#db_name DatabaseDbSystem#db_name}.</summary>
        [JsiiProperty(name: "dbName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? DbName
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_db_system#db_unique_name DatabaseDbSystem#db_unique_name}.</summary>
        [JsiiProperty(name: "dbUniqueName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? DbUniqueName
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_db_system#db_workload DatabaseDbSystem#db_workload}.</summary>
        [JsiiProperty(name: "dbWorkload", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? DbWorkload
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_db_system#defined_tags DatabaseDbSystem#defined_tags}.</summary>
        [JsiiProperty(name: "definedTags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        System.Collections.Generic.IDictionary<string, string>? DefinedTags
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_db_system#freeform_tags DatabaseDbSystem#freeform_tags}.</summary>
        [JsiiProperty(name: "freeformTags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        System.Collections.Generic.IDictionary<string, string>? FreeformTags
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_db_system#kms_key_id DatabaseDbSystem#kms_key_id}.</summary>
        [JsiiProperty(name: "kmsKeyId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? KmsKeyId
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_db_system#kms_key_version_id DatabaseDbSystem#kms_key_version_id}.</summary>
        [JsiiProperty(name: "kmsKeyVersionId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? KmsKeyVersionId
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_db_system#ncharacter_set DatabaseDbSystem#ncharacter_set}.</summary>
        [JsiiProperty(name: "ncharacterSet", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? NcharacterSet
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_db_system#pdb_name DatabaseDbSystem#pdb_name}.</summary>
        [JsiiProperty(name: "pdbName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? PdbName
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_db_system#pluggable_databases DatabaseDbSystem#pluggable_databases}.</summary>
        [JsiiProperty(name: "pluggableDatabases", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? PluggableDatabases
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_db_system#tde_wallet_password DatabaseDbSystem#tde_wallet_password}.</summary>
        [JsiiProperty(name: "tdeWalletPassword", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? TdeWalletPassword
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_db_system#time_stamp_for_point_in_time_recovery DatabaseDbSystem#time_stamp_for_point_in_time_recovery}.</summary>
        [JsiiProperty(name: "timeStampForPointInTimeRecovery", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? TimeStampForPointInTimeRecovery
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_db_system#vault_id DatabaseDbSystem#vault_id}.</summary>
        [JsiiProperty(name: "vaultId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? VaultId
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDatabaseDbSystemDbHomeDatabase), fullyQualifiedName: "oci.databaseDbSystem.DatabaseDbSystemDbHomeDatabase")]
        internal sealed class _Proxy : DeputyBase, oci.DatabaseDbSystem.IDatabaseDbSystemDbHomeDatabase
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_db_system#admin_password DatabaseDbSystem#admin_password}.</summary>
            [JsiiProperty(name: "adminPassword", typeJson: "{\"primitive\":\"string\"}")]
            public string AdminPassword
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_db_system#backup_id DatabaseDbSystem#backup_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "backupId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? BackupId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_db_system#backup_tde_password DatabaseDbSystem#backup_tde_password}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "backupTdePassword", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? BackupTdePassword
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_db_system#character_set DatabaseDbSystem#character_set}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "characterSet", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? CharacterSet
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_db_system#database_id DatabaseDbSystem#database_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "databaseId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? DatabaseId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_db_system#database_software_image_id DatabaseDbSystem#database_software_image_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "databaseSoftwareImageId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? DatabaseSoftwareImageId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>db_backup_config block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_db_system#db_backup_config DatabaseDbSystem#db_backup_config}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "dbBackupConfig", typeJson: "{\"fqn\":\"oci.databaseDbSystem.DatabaseDbSystemDbHomeDatabaseDbBackupConfig\"}", isOptional: true)]
            public oci.DatabaseDbSystem.IDatabaseDbSystemDbHomeDatabaseDbBackupConfig? DbBackupConfig
            {
                get => GetInstanceProperty<oci.DatabaseDbSystem.IDatabaseDbSystemDbHomeDatabaseDbBackupConfig?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_db_system#db_domain DatabaseDbSystem#db_domain}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "dbDomain", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? DbDomain
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_db_system#db_name DatabaseDbSystem#db_name}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "dbName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? DbName
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_db_system#db_unique_name DatabaseDbSystem#db_unique_name}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "dbUniqueName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? DbUniqueName
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_db_system#db_workload DatabaseDbSystem#db_workload}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "dbWorkload", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? DbWorkload
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_db_system#defined_tags DatabaseDbSystem#defined_tags}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "definedTags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, string>? DefinedTags
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_db_system#freeform_tags DatabaseDbSystem#freeform_tags}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "freeformTags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, string>? FreeformTags
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_db_system#kms_key_id DatabaseDbSystem#kms_key_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "kmsKeyId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? KmsKeyId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_db_system#kms_key_version_id DatabaseDbSystem#kms_key_version_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "kmsKeyVersionId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? KmsKeyVersionId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_db_system#ncharacter_set DatabaseDbSystem#ncharacter_set}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "ncharacterSet", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? NcharacterSet
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_db_system#pdb_name DatabaseDbSystem#pdb_name}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "pdbName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? PdbName
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_db_system#pluggable_databases DatabaseDbSystem#pluggable_databases}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "pluggableDatabases", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? PluggableDatabases
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_db_system#tde_wallet_password DatabaseDbSystem#tde_wallet_password}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "tdeWalletPassword", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? TdeWalletPassword
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_db_system#time_stamp_for_point_in_time_recovery DatabaseDbSystem#time_stamp_for_point_in_time_recovery}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "timeStampForPointInTimeRecovery", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? TimeStampForPointInTimeRecovery
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_db_system#vault_id DatabaseDbSystem#vault_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "vaultId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? VaultId
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}

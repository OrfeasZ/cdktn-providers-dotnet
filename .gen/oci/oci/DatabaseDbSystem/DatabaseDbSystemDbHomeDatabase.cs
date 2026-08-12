using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DatabaseDbSystem
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.databaseDbSystem.DatabaseDbSystemDbHomeDatabase")]
    public class DatabaseDbSystemDbHomeDatabase : oci.DatabaseDbSystem.IDatabaseDbSystemDbHomeDatabase
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.27.0/docs/resources/database_db_system#admin_password DatabaseDbSystem#admin_password}.</summary>
        [JsiiProperty(name: "adminPassword", typeJson: "{\"primitive\":\"string\"}")]
        public string AdminPassword
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.27.0/docs/resources/database_db_system#backup_id DatabaseDbSystem#backup_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "backupId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? BackupId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.27.0/docs/resources/database_db_system#backup_tde_password DatabaseDbSystem#backup_tde_password}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "backupTdePassword", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? BackupTdePassword
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.27.0/docs/resources/database_db_system#character_set DatabaseDbSystem#character_set}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "characterSet", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? CharacterSet
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.27.0/docs/resources/database_db_system#database_defined_tags DatabaseDbSystem#database_defined_tags}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "databaseDefinedTags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public System.Collections.Generic.IDictionary<string, string>? DatabaseDefinedTags
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.27.0/docs/resources/database_db_system#database_freeform_tags DatabaseDbSystem#database_freeform_tags}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "databaseFreeformTags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public System.Collections.Generic.IDictionary<string, string>? DatabaseFreeformTags
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.27.0/docs/resources/database_db_system#database_id DatabaseDbSystem#database_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "databaseId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? DatabaseId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.27.0/docs/resources/database_db_system#database_software_image_id DatabaseDbSystem#database_software_image_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "databaseSoftwareImageId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? DatabaseSoftwareImageId
        {
            get;
            set;
        }

        /// <summary>db_backup_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.27.0/docs/resources/database_db_system#db_backup_config DatabaseDbSystem#db_backup_config}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "dbBackupConfig", typeJson: "{\"fqn\":\"oci.databaseDbSystem.DatabaseDbSystemDbHomeDatabaseDbBackupConfig\"}", isOptional: true)]
        public oci.DatabaseDbSystem.IDatabaseDbSystemDbHomeDatabaseDbBackupConfig? DbBackupConfig
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.27.0/docs/resources/database_db_system#db_domain DatabaseDbSystem#db_domain}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "dbDomain", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? DbDomain
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.27.0/docs/resources/database_db_system#db_name DatabaseDbSystem#db_name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "dbName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? DbName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.27.0/docs/resources/database_db_system#db_unique_name DatabaseDbSystem#db_unique_name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "dbUniqueName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? DbUniqueName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.27.0/docs/resources/database_db_system#db_workload DatabaseDbSystem#db_workload}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "dbWorkload", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? DbWorkload
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.27.0/docs/resources/database_db_system#defined_tags DatabaseDbSystem#defined_tags}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "definedTags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public System.Collections.Generic.IDictionary<string, string>? DefinedTags
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.27.0/docs/resources/database_db_system#freeform_tags DatabaseDbSystem#freeform_tags}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "freeformTags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public System.Collections.Generic.IDictionary<string, string>? FreeformTags
        {
            get;
            set;
        }

        private object? _isActiveDataGuardEnabled;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.27.0/docs/resources/database_db_system#is_active_data_guard_enabled DatabaseDbSystem#is_active_data_guard_enabled}.</summary>
        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "isActiveDataGuardEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? IsActiveDataGuardEnabled
        {
            get => _isActiveDataGuardEnabled;
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
                _isActiveDataGuardEnabled = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.27.0/docs/resources/database_db_system#key_store_id DatabaseDbSystem#key_store_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "keyStoreId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? KeyStoreId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.27.0/docs/resources/database_db_system#kms_key_id DatabaseDbSystem#kms_key_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "kmsKeyId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? KmsKeyId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.27.0/docs/resources/database_db_system#kms_key_version_id DatabaseDbSystem#kms_key_version_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "kmsKeyVersionId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? KmsKeyVersionId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.27.0/docs/resources/database_db_system#ncharacter_set DatabaseDbSystem#ncharacter_set}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "ncharacterSet", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? NcharacterSet
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.27.0/docs/resources/database_db_system#pdb_name DatabaseDbSystem#pdb_name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "pdbName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? PdbName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.27.0/docs/resources/database_db_system#pluggable_databases DatabaseDbSystem#pluggable_databases}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "pluggableDatabases", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? PluggableDatabases
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.27.0/docs/resources/database_db_system#protection_mode DatabaseDbSystem#protection_mode}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "protectionMode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ProtectionMode
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.27.0/docs/resources/database_db_system#sid_prefix DatabaseDbSystem#sid_prefix}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "sidPrefix", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? SidPrefix
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.27.0/docs/resources/database_db_system#tde_wallet_password DatabaseDbSystem#tde_wallet_password}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "tdeWalletPassword", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? TdeWalletPassword
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.27.0/docs/resources/database_db_system#time_stamp_for_point_in_time_recovery DatabaseDbSystem#time_stamp_for_point_in_time_recovery}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "timeStampForPointInTimeRecovery", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? TimeStampForPointInTimeRecovery
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.27.0/docs/resources/database_db_system#transport_type DatabaseDbSystem#transport_type}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "transportType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? TransportType
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.27.0/docs/resources/database_db_system#vault_id DatabaseDbSystem#vault_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "vaultId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? VaultId
        {
            get;
            set;
        }
    }
}

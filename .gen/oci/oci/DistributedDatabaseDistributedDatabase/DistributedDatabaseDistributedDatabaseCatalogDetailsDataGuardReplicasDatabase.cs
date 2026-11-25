using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DistributedDatabaseDistributedDatabase
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.distributedDatabaseDistributedDatabase.DistributedDatabaseDistributedDatabaseCatalogDetailsDataGuardReplicasDatabase")]
    public class DistributedDatabaseDistributedDatabaseCatalogDetailsDataGuardReplicasDatabase : oci.DistributedDatabaseDistributedDatabase.IDistributedDatabaseDistributedDatabaseCatalogDetailsDataGuardReplicasDatabase
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.15.0/docs/resources/distributed_database_distributed_database#source DistributedDatabaseDistributedDatabase#source}.</summary>
        [JsiiProperty(name: "source", typeJson: "{\"primitive\":\"string\"}")]
        public string Source
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.15.0/docs/resources/distributed_database_distributed_database#admin_password DistributedDatabaseDistributedDatabase#admin_password}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "adminPassword", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? AdminPassword
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.15.0/docs/resources/distributed_database_distributed_database#admin_password_secret_id DistributedDatabaseDistributedDatabase#admin_password_secret_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "adminPasswordSecretId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? AdminPasswordSecretId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.15.0/docs/resources/distributed_database_distributed_database#admin_password_secret_version_number DistributedDatabaseDistributedDatabase#admin_password_secret_version_number}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "adminPasswordSecretVersionNumber", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? AdminPasswordSecretVersionNumber
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.15.0/docs/resources/distributed_database_distributed_database#availability_domain DistributedDatabaseDistributedDatabase#availability_domain}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "availabilityDomain", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? AvailabilityDomain
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.15.0/docs/resources/distributed_database_distributed_database#db_home_id DistributedDatabaseDistributedDatabase#db_home_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "dbHomeId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? DbHomeId
        {
            get;
            set;
        }

        /// <summary>db_storage_vault_details block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.15.0/docs/resources/distributed_database_distributed_database#db_storage_vault_details DistributedDatabaseDistributedDatabase#db_storage_vault_details}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "dbStorageVaultDetails", typeJson: "{\"fqn\":\"oci.distributedDatabaseDistributedDatabase.DistributedDatabaseDistributedDatabaseCatalogDetailsDataGuardReplicasDatabaseDbStorageVaultDetails\"}", isOptional: true)]
        public oci.DistributedDatabaseDistributedDatabase.IDistributedDatabaseDistributedDatabaseCatalogDetailsDataGuardReplicasDatabaseDbStorageVaultDetails? DbStorageVaultDetails
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.15.0/docs/resources/distributed_database_distributed_database#exascale_db_storage_vault_id DistributedDatabaseDistributedDatabase#exascale_db_storage_vault_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "exascaleDbStorageVaultId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ExascaleDbStorageVaultId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.15.0/docs/resources/distributed_database_distributed_database#kms_key_id DistributedDatabaseDistributedDatabase#kms_key_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "kmsKeyId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? KmsKeyId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.15.0/docs/resources/distributed_database_distributed_database#kms_key_version_id DistributedDatabaseDistributedDatabase#kms_key_version_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "kmsKeyVersionId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? KmsKeyVersionId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.15.0/docs/resources/distributed_database_distributed_database#protection_mode DistributedDatabaseDistributedDatabase#protection_mode}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "protectionMode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ProtectionMode
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.15.0/docs/resources/distributed_database_distributed_database#tde_wallet_password DistributedDatabaseDistributedDatabase#tde_wallet_password}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "tdeWalletPassword", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? TdeWalletPassword
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.15.0/docs/resources/distributed_database_distributed_database#tde_wallet_password_secret_id DistributedDatabaseDistributedDatabase#tde_wallet_password_secret_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "tdeWalletPasswordSecretId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? TdeWalletPasswordSecretId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.15.0/docs/resources/distributed_database_distributed_database#tde_wallet_password_secret_version_number DistributedDatabaseDistributedDatabase#tde_wallet_password_secret_version_number}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "tdeWalletPasswordSecretVersionNumber", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? TdeWalletPasswordSecretVersionNumber
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.15.0/docs/resources/distributed_database_distributed_database#transport_type DistributedDatabaseDistributedDatabase#transport_type}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "transportType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? TransportType
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.15.0/docs/resources/distributed_database_distributed_database#vault_id DistributedDatabaseDistributedDatabase#vault_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "vaultId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? VaultId
        {
            get;
            set;
        }

        /// <summary>vm_cluster_details block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.15.0/docs/resources/distributed_database_distributed_database#vm_cluster_details DistributedDatabaseDistributedDatabase#vm_cluster_details}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "vmClusterDetails", typeJson: "{\"fqn\":\"oci.distributedDatabaseDistributedDatabase.DistributedDatabaseDistributedDatabaseCatalogDetailsDataGuardReplicasDatabaseVmClusterDetails\"}", isOptional: true)]
        public oci.DistributedDatabaseDistributedDatabase.IDistributedDatabaseDistributedDatabaseCatalogDetailsDataGuardReplicasDatabaseVmClusterDetails? VmClusterDetails
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.15.0/docs/resources/distributed_database_distributed_database#vm_cluster_id DistributedDatabaseDistributedDatabase#vm_cluster_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "vmClusterId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? VmClusterId
        {
            get;
            set;
        }
    }
}

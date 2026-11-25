using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DistributedDatabaseDistributedDatabasesInsertDg
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.distributedDatabaseDistributedDatabasesInsertDg.DistributedDatabaseDistributedDatabasesInsertDgInsertDgDatabase")]
    public class DistributedDatabaseDistributedDatabasesInsertDgInsertDgDatabase : oci.DistributedDatabaseDistributedDatabasesInsertDg.IDistributedDatabaseDistributedDatabasesInsertDgInsertDgDatabase
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.15.0/docs/resources/distributed_database_distributed_databases_insert_dg#source DistributedDatabaseDistributedDatabasesInsertDg#source}.</summary>
        [JsiiProperty(name: "source", typeJson: "{\"primitive\":\"string\"}")]
        public string Source
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.15.0/docs/resources/distributed_database_distributed_databases_insert_dg#admin_password DistributedDatabaseDistributedDatabasesInsertDg#admin_password}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "adminPassword", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? AdminPassword
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.15.0/docs/resources/distributed_database_distributed_databases_insert_dg#admin_password_secret_id DistributedDatabaseDistributedDatabasesInsertDg#admin_password_secret_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "adminPasswordSecretId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? AdminPasswordSecretId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.15.0/docs/resources/distributed_database_distributed_databases_insert_dg#admin_password_secret_version_number DistributedDatabaseDistributedDatabasesInsertDg#admin_password_secret_version_number}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "adminPasswordSecretVersionNumber", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? AdminPasswordSecretVersionNumber
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.15.0/docs/resources/distributed_database_distributed_databases_insert_dg#availability_domain DistributedDatabaseDistributedDatabasesInsertDg#availability_domain}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "availabilityDomain", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? AvailabilityDomain
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.15.0/docs/resources/distributed_database_distributed_databases_insert_dg#db_home_id DistributedDatabaseDistributedDatabasesInsertDg#db_home_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "dbHomeId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? DbHomeId
        {
            get;
            set;
        }

        /// <summary>db_storage_vault_details block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.15.0/docs/resources/distributed_database_distributed_databases_insert_dg#db_storage_vault_details DistributedDatabaseDistributedDatabasesInsertDg#db_storage_vault_details}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "dbStorageVaultDetails", typeJson: "{\"fqn\":\"oci.distributedDatabaseDistributedDatabasesInsertDg.DistributedDatabaseDistributedDatabasesInsertDgInsertDgDatabaseDbStorageVaultDetails\"}", isOptional: true)]
        public oci.DistributedDatabaseDistributedDatabasesInsertDg.IDistributedDatabaseDistributedDatabasesInsertDgInsertDgDatabaseDbStorageVaultDetails? DbStorageVaultDetails
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.15.0/docs/resources/distributed_database_distributed_databases_insert_dg#exascale_db_storage_vault_id DistributedDatabaseDistributedDatabasesInsertDg#exascale_db_storage_vault_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "exascaleDbStorageVaultId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ExascaleDbStorageVaultId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.15.0/docs/resources/distributed_database_distributed_databases_insert_dg#protection_mode DistributedDatabaseDistributedDatabasesInsertDg#protection_mode}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "protectionMode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ProtectionMode
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.15.0/docs/resources/distributed_database_distributed_databases_insert_dg#transport_type DistributedDatabaseDistributedDatabasesInsertDg#transport_type}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "transportType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? TransportType
        {
            get;
            set;
        }

        /// <summary>vm_cluster_details block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.15.0/docs/resources/distributed_database_distributed_databases_insert_dg#vm_cluster_details DistributedDatabaseDistributedDatabasesInsertDg#vm_cluster_details}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "vmClusterDetails", typeJson: "{\"fqn\":\"oci.distributedDatabaseDistributedDatabasesInsertDg.DistributedDatabaseDistributedDatabasesInsertDgInsertDgDatabaseVmClusterDetails\"}", isOptional: true)]
        public oci.DistributedDatabaseDistributedDatabasesInsertDg.IDistributedDatabaseDistributedDatabasesInsertDgInsertDgDatabaseVmClusterDetails? VmClusterDetails
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.15.0/docs/resources/distributed_database_distributed_databases_insert_dg#vm_cluster_id DistributedDatabaseDistributedDatabasesInsertDg#vm_cluster_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "vmClusterId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? VmClusterId
        {
            get;
            set;
        }
    }
}

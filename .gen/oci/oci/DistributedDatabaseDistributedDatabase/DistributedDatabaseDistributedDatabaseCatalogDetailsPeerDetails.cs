using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DistributedDatabaseDistributedDatabase
{
    [JsiiByValue(fqn: "oci.distributedDatabaseDistributedDatabase.DistributedDatabaseDistributedDatabaseCatalogDetailsPeerDetails")]
    public class DistributedDatabaseDistributedDatabaseCatalogDetailsPeerDetails : oci.DistributedDatabaseDistributedDatabase.IDistributedDatabaseDistributedDatabaseCatalogDetailsPeerDetails
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.27.0/docs/resources/distributed_database_distributed_database#availability_domain DistributedDatabaseDistributedDatabase#availability_domain}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "availabilityDomain", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? AvailabilityDomain
        {
            get;
            set;
        }

        /// <summary>db_storage_vault_details block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.27.0/docs/resources/distributed_database_distributed_database#db_storage_vault_details DistributedDatabaseDistributedDatabase#db_storage_vault_details}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "dbStorageVaultDetails", typeJson: "{\"fqn\":\"oci.distributedDatabaseDistributedDatabase.DistributedDatabaseDistributedDatabaseCatalogDetailsPeerDetailsDbStorageVaultDetails\"}", isOptional: true)]
        public oci.DistributedDatabaseDistributedDatabase.IDistributedDatabaseDistributedDatabaseCatalogDetailsPeerDetailsDbStorageVaultDetails? DbStorageVaultDetails
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.27.0/docs/resources/distributed_database_distributed_database#protection_mode DistributedDatabaseDistributedDatabase#protection_mode}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "protectionMode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ProtectionMode
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.27.0/docs/resources/distributed_database_distributed_database#transport_type DistributedDatabaseDistributedDatabase#transport_type}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "transportType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? TransportType
        {
            get;
            set;
        }

        /// <summary>vm_cluster_details block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.27.0/docs/resources/distributed_database_distributed_database#vm_cluster_details DistributedDatabaseDistributedDatabase#vm_cluster_details}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "vmClusterDetails", typeJson: "{\"fqn\":\"oci.distributedDatabaseDistributedDatabase.DistributedDatabaseDistributedDatabaseCatalogDetailsPeerDetailsVmClusterDetails\"}", isOptional: true)]
        public oci.DistributedDatabaseDistributedDatabase.IDistributedDatabaseDistributedDatabaseCatalogDetailsPeerDetailsVmClusterDetails? VmClusterDetails
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.27.0/docs/resources/distributed_database_distributed_database#vm_cluster_id DistributedDatabaseDistributedDatabase#vm_cluster_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "vmClusterId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? VmClusterId
        {
            get;
            set;
        }
    }
}

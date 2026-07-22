using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DistributedDatabaseDistributedDatabase
{
    [JsiiByValue(fqn: "oci.distributedDatabaseDistributedDatabase.DistributedDatabaseDistributedDatabaseShardDetailsPeerDetailsDbStorageVaultDetails")]
    public class DistributedDatabaseDistributedDatabaseShardDetailsPeerDetailsDbStorageVaultDetails : oci.DistributedDatabaseDistributedDatabase.IDistributedDatabaseDistributedDatabaseShardDetailsPeerDetailsDbStorageVaultDetails
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.24.0/docs/resources/distributed_database_distributed_database#additional_flash_cache_in_percent DistributedDatabaseDistributedDatabase#additional_flash_cache_in_percent}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "additionalFlashCacheInPercent", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? AdditionalFlashCacheInPercent
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.24.0/docs/resources/distributed_database_distributed_database#high_capacity_database_storage DistributedDatabaseDistributedDatabase#high_capacity_database_storage}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "highCapacityDatabaseStorage", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? HighCapacityDatabaseStorage
        {
            get;
            set;
        }
    }
}

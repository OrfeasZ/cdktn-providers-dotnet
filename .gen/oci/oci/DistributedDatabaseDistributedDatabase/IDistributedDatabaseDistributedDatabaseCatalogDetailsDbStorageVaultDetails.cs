using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DistributedDatabaseDistributedDatabase
{
    [JsiiInterface(nativeType: typeof(IDistributedDatabaseDistributedDatabaseCatalogDetailsDbStorageVaultDetails), fullyQualifiedName: "oci.distributedDatabaseDistributedDatabase.DistributedDatabaseDistributedDatabaseCatalogDetailsDbStorageVaultDetails")]
    public interface IDistributedDatabaseDistributedDatabaseCatalogDetailsDbStorageVaultDetails
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.25.0/docs/resources/distributed_database_distributed_database#additional_flash_cache_in_percent DistributedDatabaseDistributedDatabase#additional_flash_cache_in_percent}.</summary>
        [JsiiProperty(name: "additionalFlashCacheInPercent", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? AdditionalFlashCacheInPercent
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.25.0/docs/resources/distributed_database_distributed_database#high_capacity_database_storage DistributedDatabaseDistributedDatabase#high_capacity_database_storage}.</summary>
        [JsiiProperty(name: "highCapacityDatabaseStorage", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? HighCapacityDatabaseStorage
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDistributedDatabaseDistributedDatabaseCatalogDetailsDbStorageVaultDetails), fullyQualifiedName: "oci.distributedDatabaseDistributedDatabase.DistributedDatabaseDistributedDatabaseCatalogDetailsDbStorageVaultDetails")]
        internal sealed class _Proxy : DeputyBase, oci.DistributedDatabaseDistributedDatabase.IDistributedDatabaseDistributedDatabaseCatalogDetailsDbStorageVaultDetails
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.25.0/docs/resources/distributed_database_distributed_database#additional_flash_cache_in_percent DistributedDatabaseDistributedDatabase#additional_flash_cache_in_percent}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "additionalFlashCacheInPercent", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? AdditionalFlashCacheInPercent
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.25.0/docs/resources/distributed_database_distributed_database#high_capacity_database_storage DistributedDatabaseDistributedDatabase#high_capacity_database_storage}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "highCapacityDatabaseStorage", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? HighCapacityDatabaseStorage
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}

using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.RedisOciCacheBackupExportToObjectStorage
{
    [JsiiByValue(fqn: "oci.redisOciCacheBackupExportToObjectStorage.RedisOciCacheBackupExportToObjectStorageTimeouts")]
    public class RedisOciCacheBackupExportToObjectStorageTimeouts : oci.RedisOciCacheBackupExportToObjectStorage.IRedisOciCacheBackupExportToObjectStorageTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.22.0/docs/resources/redis_oci_cache_backup_export_to_object_storage#create RedisOciCacheBackupExportToObjectStorage#create}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Create
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.22.0/docs/resources/redis_oci_cache_backup_export_to_object_storage#delete RedisOciCacheBackupExportToObjectStorage#delete}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Delete
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.22.0/docs/resources/redis_oci_cache_backup_export_to_object_storage#update RedisOciCacheBackupExportToObjectStorage#update}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "update", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Update
        {
            get;
            set;
        }
    }
}

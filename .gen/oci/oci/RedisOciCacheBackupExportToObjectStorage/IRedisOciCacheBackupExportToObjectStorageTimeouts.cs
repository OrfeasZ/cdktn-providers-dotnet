using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.RedisOciCacheBackupExportToObjectStorage
{
    [JsiiInterface(nativeType: typeof(IRedisOciCacheBackupExportToObjectStorageTimeouts), fullyQualifiedName: "oci.redisOciCacheBackupExportToObjectStorage.RedisOciCacheBackupExportToObjectStorageTimeouts")]
    public interface IRedisOciCacheBackupExportToObjectStorageTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.19.0/docs/resources/redis_oci_cache_backup_export_to_object_storage#create RedisOciCacheBackupExportToObjectStorage#create}.</summary>
        [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Create
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.19.0/docs/resources/redis_oci_cache_backup_export_to_object_storage#delete RedisOciCacheBackupExportToObjectStorage#delete}.</summary>
        [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Delete
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.19.0/docs/resources/redis_oci_cache_backup_export_to_object_storage#update RedisOciCacheBackupExportToObjectStorage#update}.</summary>
        [JsiiProperty(name: "update", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Update
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IRedisOciCacheBackupExportToObjectStorageTimeouts), fullyQualifiedName: "oci.redisOciCacheBackupExportToObjectStorage.RedisOciCacheBackupExportToObjectStorageTimeouts")]
        internal sealed class _Proxy : DeputyBase, oci.RedisOciCacheBackupExportToObjectStorage.IRedisOciCacheBackupExportToObjectStorageTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.19.0/docs/resources/redis_oci_cache_backup_export_to_object_storage#create RedisOciCacheBackupExportToObjectStorage#create}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Create
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.19.0/docs/resources/redis_oci_cache_backup_export_to_object_storage#delete RedisOciCacheBackupExportToObjectStorage#delete}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Delete
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.19.0/docs/resources/redis_oci_cache_backup_export_to_object_storage#update RedisOciCacheBackupExportToObjectStorage#update}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "update", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Update
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}

using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.RedisRedisClusterDetachOciCacheUser
{
    [JsiiInterface(nativeType: typeof(IRedisRedisClusterDetachOciCacheUserTimeouts), fullyQualifiedName: "oci.redisRedisClusterDetachOciCacheUser.RedisRedisClusterDetachOciCacheUserTimeouts")]
    public interface IRedisRedisClusterDetachOciCacheUserTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/redis_redis_cluster_detach_oci_cache_user#create RedisRedisClusterDetachOciCacheUser#create}.</summary>
        [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Create
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/redis_redis_cluster_detach_oci_cache_user#delete RedisRedisClusterDetachOciCacheUser#delete}.</summary>
        [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Delete
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/redis_redis_cluster_detach_oci_cache_user#update RedisRedisClusterDetachOciCacheUser#update}.</summary>
        [JsiiProperty(name: "update", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Update
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IRedisRedisClusterDetachOciCacheUserTimeouts), fullyQualifiedName: "oci.redisRedisClusterDetachOciCacheUser.RedisRedisClusterDetachOciCacheUserTimeouts")]
        internal sealed class _Proxy : DeputyBase, oci.RedisRedisClusterDetachOciCacheUser.IRedisRedisClusterDetachOciCacheUserTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/redis_redis_cluster_detach_oci_cache_user#create RedisRedisClusterDetachOciCacheUser#create}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Create
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/redis_redis_cluster_detach_oci_cache_user#delete RedisRedisClusterDetachOciCacheUser#delete}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Delete
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/redis_redis_cluster_detach_oci_cache_user#update RedisRedisClusterDetachOciCacheUser#update}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "update", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Update
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}

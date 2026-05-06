using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.RedisRedisClusterGetOciCacheUser
{
    [JsiiInterface(nativeType: typeof(IRedisRedisClusterGetOciCacheUserTimeouts), fullyQualifiedName: "oci.redisRedisClusterGetOciCacheUser.RedisRedisClusterGetOciCacheUserTimeouts")]
    public interface IRedisRedisClusterGetOciCacheUserTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/redis_redis_cluster_get_oci_cache_user#create RedisRedisClusterGetOciCacheUser#create}.</summary>
        [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Create
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/redis_redis_cluster_get_oci_cache_user#delete RedisRedisClusterGetOciCacheUser#delete}.</summary>
        [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Delete
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/redis_redis_cluster_get_oci_cache_user#update RedisRedisClusterGetOciCacheUser#update}.</summary>
        [JsiiProperty(name: "update", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Update
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IRedisRedisClusterGetOciCacheUserTimeouts), fullyQualifiedName: "oci.redisRedisClusterGetOciCacheUser.RedisRedisClusterGetOciCacheUserTimeouts")]
        internal sealed class _Proxy : DeputyBase, oci.RedisRedisClusterGetOciCacheUser.IRedisRedisClusterGetOciCacheUserTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/redis_redis_cluster_get_oci_cache_user#create RedisRedisClusterGetOciCacheUser#create}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Create
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/redis_redis_cluster_get_oci_cache_user#delete RedisRedisClusterGetOciCacheUser#delete}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Delete
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/redis_redis_cluster_get_oci_cache_user#update RedisRedisClusterGetOciCacheUser#update}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "update", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Update
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}

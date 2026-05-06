using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.RedisOciCacheUserGetRedisCluster
{
    [JsiiInterface(nativeType: typeof(IRedisOciCacheUserGetRedisClusterTimeouts), fullyQualifiedName: "oci.redisOciCacheUserGetRedisCluster.RedisOciCacheUserGetRedisClusterTimeouts")]
    public interface IRedisOciCacheUserGetRedisClusterTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/redis_oci_cache_user_get_redis_cluster#create RedisOciCacheUserGetRedisCluster#create}.</summary>
        [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Create
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/redis_oci_cache_user_get_redis_cluster#delete RedisOciCacheUserGetRedisCluster#delete}.</summary>
        [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Delete
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/redis_oci_cache_user_get_redis_cluster#update RedisOciCacheUserGetRedisCluster#update}.</summary>
        [JsiiProperty(name: "update", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Update
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IRedisOciCacheUserGetRedisClusterTimeouts), fullyQualifiedName: "oci.redisOciCacheUserGetRedisCluster.RedisOciCacheUserGetRedisClusterTimeouts")]
        internal sealed class _Proxy : DeputyBase, oci.RedisOciCacheUserGetRedisCluster.IRedisOciCacheUserGetRedisClusterTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/redis_oci_cache_user_get_redis_cluster#create RedisOciCacheUserGetRedisCluster#create}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Create
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/redis_oci_cache_user_get_redis_cluster#delete RedisOciCacheUserGetRedisCluster#delete}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Delete
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/redis_oci_cache_user_get_redis_cluster#update RedisOciCacheUserGetRedisCluster#update}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "update", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Update
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}

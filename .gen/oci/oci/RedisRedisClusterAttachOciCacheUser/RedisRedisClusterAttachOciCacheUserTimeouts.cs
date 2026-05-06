using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.RedisRedisClusterAttachOciCacheUser
{
    [JsiiByValue(fqn: "oci.redisRedisClusterAttachOciCacheUser.RedisRedisClusterAttachOciCacheUserTimeouts")]
    public class RedisRedisClusterAttachOciCacheUserTimeouts : oci.RedisRedisClusterAttachOciCacheUser.IRedisRedisClusterAttachOciCacheUserTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/redis_redis_cluster_attach_oci_cache_user#create RedisRedisClusterAttachOciCacheUser#create}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Create
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/redis_redis_cluster_attach_oci_cache_user#delete RedisRedisClusterAttachOciCacheUser#delete}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Delete
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/redis_redis_cluster_attach_oci_cache_user#update RedisRedisClusterAttachOciCacheUser#update}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "update", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Update
        {
            get;
            set;
        }
    }
}

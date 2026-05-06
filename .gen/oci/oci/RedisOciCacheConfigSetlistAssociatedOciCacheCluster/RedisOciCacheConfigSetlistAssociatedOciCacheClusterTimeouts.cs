using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.RedisOciCacheConfigSetlistAssociatedOciCacheCluster
{
    [JsiiByValue(fqn: "oci.redisOciCacheConfigSetlistAssociatedOciCacheCluster.RedisOciCacheConfigSetlistAssociatedOciCacheClusterTimeouts")]
    public class RedisOciCacheConfigSetlistAssociatedOciCacheClusterTimeouts : oci.RedisOciCacheConfigSetlistAssociatedOciCacheCluster.IRedisOciCacheConfigSetlistAssociatedOciCacheClusterTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/redis_oci_cache_config_setlist_associated_oci_cache_cluster#create RedisOciCacheConfigSetlistAssociatedOciCacheCluster#create}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Create
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/redis_oci_cache_config_setlist_associated_oci_cache_cluster#delete RedisOciCacheConfigSetlistAssociatedOciCacheCluster#delete}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Delete
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/redis_oci_cache_config_setlist_associated_oci_cache_cluster#update RedisOciCacheConfigSetlistAssociatedOciCacheCluster#update}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "update", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Update
        {
            get;
            set;
        }
    }
}

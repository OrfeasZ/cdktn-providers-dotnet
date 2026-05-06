using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.RedisOciCacheConfigSetlistAssociatedOciCacheCluster
{
    [JsiiInterface(nativeType: typeof(IRedisOciCacheConfigSetlistAssociatedOciCacheClusterTimeouts), fullyQualifiedName: "oci.redisOciCacheConfigSetlistAssociatedOciCacheCluster.RedisOciCacheConfigSetlistAssociatedOciCacheClusterTimeouts")]
    public interface IRedisOciCacheConfigSetlistAssociatedOciCacheClusterTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/redis_oci_cache_config_setlist_associated_oci_cache_cluster#create RedisOciCacheConfigSetlistAssociatedOciCacheCluster#create}.</summary>
        [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Create
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/redis_oci_cache_config_setlist_associated_oci_cache_cluster#delete RedisOciCacheConfigSetlistAssociatedOciCacheCluster#delete}.</summary>
        [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Delete
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/redis_oci_cache_config_setlist_associated_oci_cache_cluster#update RedisOciCacheConfigSetlistAssociatedOciCacheCluster#update}.</summary>
        [JsiiProperty(name: "update", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Update
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IRedisOciCacheConfigSetlistAssociatedOciCacheClusterTimeouts), fullyQualifiedName: "oci.redisOciCacheConfigSetlistAssociatedOciCacheCluster.RedisOciCacheConfigSetlistAssociatedOciCacheClusterTimeouts")]
        internal sealed class _Proxy : DeputyBase, oci.RedisOciCacheConfigSetlistAssociatedOciCacheCluster.IRedisOciCacheConfigSetlistAssociatedOciCacheClusterTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/redis_oci_cache_config_setlist_associated_oci_cache_cluster#create RedisOciCacheConfigSetlistAssociatedOciCacheCluster#create}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Create
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/redis_oci_cache_config_setlist_associated_oci_cache_cluster#delete RedisOciCacheConfigSetlistAssociatedOciCacheCluster#delete}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Delete
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/redis_oci_cache_config_setlist_associated_oci_cache_cluster#update RedisOciCacheConfigSetlistAssociatedOciCacheCluster#update}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "update", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Update
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}

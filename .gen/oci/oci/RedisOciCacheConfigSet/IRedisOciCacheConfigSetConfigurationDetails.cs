using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.RedisOciCacheConfigSet
{
    [JsiiInterface(nativeType: typeof(IRedisOciCacheConfigSetConfigurationDetails), fullyQualifiedName: "oci.redisOciCacheConfigSet.RedisOciCacheConfigSetConfigurationDetails")]
    public interface IRedisOciCacheConfigSetConfigurationDetails
    {
        /// <summary>items block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/redis_oci_cache_config_set#items RedisOciCacheConfigSet#items}
        /// </remarks>
        [JsiiProperty(name: "items", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.redisOciCacheConfigSet.RedisOciCacheConfigSetConfigurationDetailsItems\"},\"kind\":\"array\"}}]}}")]
        object Items
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IRedisOciCacheConfigSetConfigurationDetails), fullyQualifiedName: "oci.redisOciCacheConfigSet.RedisOciCacheConfigSetConfigurationDetails")]
        internal sealed class _Proxy : DeputyBase, oci.RedisOciCacheConfigSet.IRedisOciCacheConfigSetConfigurationDetails
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>items block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/redis_oci_cache_config_set#items RedisOciCacheConfigSet#items}
            /// </remarks>
            [JsiiProperty(name: "items", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.redisOciCacheConfigSet.RedisOciCacheConfigSetConfigurationDetailsItems\"},\"kind\":\"array\"}}]}}")]
            public object Items
            {
                get => GetInstanceProperty<object>()!;
            }
        }
    }
}

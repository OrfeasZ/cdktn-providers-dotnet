using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.RedisOciCacheConfigSet
{
    [JsiiInterface(nativeType: typeof(IRedisOciCacheConfigSetConfigurationDetailsItems), fullyQualifiedName: "oci.redisOciCacheConfigSet.RedisOciCacheConfigSetConfigurationDetailsItems")]
    public interface IRedisOciCacheConfigSetConfigurationDetailsItems
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/redis_oci_cache_config_set#config_key RedisOciCacheConfigSet#config_key}.</summary>
        [JsiiProperty(name: "configKey", typeJson: "{\"primitive\":\"string\"}")]
        string ConfigKey
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/redis_oci_cache_config_set#config_value RedisOciCacheConfigSet#config_value}.</summary>
        [JsiiProperty(name: "configValue", typeJson: "{\"primitive\":\"string\"}")]
        string ConfigValue
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IRedisOciCacheConfigSetConfigurationDetailsItems), fullyQualifiedName: "oci.redisOciCacheConfigSet.RedisOciCacheConfigSetConfigurationDetailsItems")]
        internal sealed class _Proxy : DeputyBase, oci.RedisOciCacheConfigSet.IRedisOciCacheConfigSetConfigurationDetailsItems
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/redis_oci_cache_config_set#config_key RedisOciCacheConfigSet#config_key}.</summary>
            [JsiiProperty(name: "configKey", typeJson: "{\"primitive\":\"string\"}")]
            public string ConfigKey
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/redis_oci_cache_config_set#config_value RedisOciCacheConfigSet#config_value}.</summary>
            [JsiiProperty(name: "configValue", typeJson: "{\"primitive\":\"string\"}")]
            public string ConfigValue
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}

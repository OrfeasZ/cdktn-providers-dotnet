using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.RedisOciCacheConfigSet
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.redisOciCacheConfigSet.RedisOciCacheConfigSetConfigurationDetailsItems")]
    public class RedisOciCacheConfigSetConfigurationDetailsItems : oci.RedisOciCacheConfigSet.IRedisOciCacheConfigSetConfigurationDetailsItems
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/redis_oci_cache_config_set#config_key RedisOciCacheConfigSet#config_key}.</summary>
        [JsiiProperty(name: "configKey", typeJson: "{\"primitive\":\"string\"}")]
        public string ConfigKey
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/redis_oci_cache_config_set#config_value RedisOciCacheConfigSet#config_value}.</summary>
        [JsiiProperty(name: "configValue", typeJson: "{\"primitive\":\"string\"}")]
        public string ConfigValue
        {
            get;
            set;
        }
    }
}

using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.RedisOciCacheConfigSet
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.redisOciCacheConfigSet.RedisOciCacheConfigSetConfigurationDetails")]
    public class RedisOciCacheConfigSetConfigurationDetails : oci.RedisOciCacheConfigSet.IRedisOciCacheConfigSetConfigurationDetails
    {
        private object _items;

        /// <summary>items block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/redis_oci_cache_config_set#items RedisOciCacheConfigSet#items}
        /// </remarks>
        [JsiiProperty(name: "items", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.redisOciCacheConfigSet.RedisOciCacheConfigSetConfigurationDetailsItems\"},\"kind\":\"array\"}}]}}")]
        public object Items
        {
            get => _items;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case oci.RedisOciCacheConfigSet.IRedisOciCacheConfigSetConfigurationDetailsItems[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.RedisOciCacheConfigSet.IRedisOciCacheConfigSetConfigurationDetailsItems).FullName}[]; received null", nameof(value));
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.RedisOciCacheConfigSet.IRedisOciCacheConfigSetConfigurationDetailsItems).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _items = value;
            }
        }
    }
}

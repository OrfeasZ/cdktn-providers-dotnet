using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.RedisOciCacheUser
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.redisOciCacheUser.RedisOciCacheUserAuthenticationMode")]
    public class RedisOciCacheUserAuthenticationMode : oci.RedisOciCacheUser.IRedisOciCacheUserAuthenticationMode
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/redis_oci_cache_user#authentication_type RedisOciCacheUser#authentication_type}.</summary>
        [JsiiProperty(name: "authenticationType", typeJson: "{\"primitive\":\"string\"}")]
        public string AuthenticationType
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/redis_oci_cache_user#hashed_passwords RedisOciCacheUser#hashed_passwords}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "hashedPasswords", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? HashedPasswords
        {
            get;
            set;
        }
    }
}

using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.RedisOciCacheUser
{
    [JsiiInterface(nativeType: typeof(IRedisOciCacheUserAuthenticationMode), fullyQualifiedName: "oci.redisOciCacheUser.RedisOciCacheUserAuthenticationMode")]
    public interface IRedisOciCacheUserAuthenticationMode
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/redis_oci_cache_user#authentication_type RedisOciCacheUser#authentication_type}.</summary>
        [JsiiProperty(name: "authenticationType", typeJson: "{\"primitive\":\"string\"}")]
        string AuthenticationType
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/redis_oci_cache_user#hashed_passwords RedisOciCacheUser#hashed_passwords}.</summary>
        [JsiiProperty(name: "hashedPasswords", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? HashedPasswords
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IRedisOciCacheUserAuthenticationMode), fullyQualifiedName: "oci.redisOciCacheUser.RedisOciCacheUserAuthenticationMode")]
        internal sealed class _Proxy : DeputyBase, oci.RedisOciCacheUser.IRedisOciCacheUserAuthenticationMode
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/redis_oci_cache_user#authentication_type RedisOciCacheUser#authentication_type}.</summary>
            [JsiiProperty(name: "authenticationType", typeJson: "{\"primitive\":\"string\"}")]
            public string AuthenticationType
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/redis_oci_cache_user#hashed_passwords RedisOciCacheUser#hashed_passwords}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "hashedPasswords", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? HashedPasswords
            {
                get => GetInstanceProperty<string[]?>();
            }
        }
    }
}

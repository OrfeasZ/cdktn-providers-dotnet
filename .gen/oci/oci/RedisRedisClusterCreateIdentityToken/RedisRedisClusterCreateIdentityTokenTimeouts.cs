using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.RedisRedisClusterCreateIdentityToken
{
    [JsiiByValue(fqn: "oci.redisRedisClusterCreateIdentityToken.RedisRedisClusterCreateIdentityTokenTimeouts")]
    public class RedisRedisClusterCreateIdentityTokenTimeouts : oci.RedisRedisClusterCreateIdentityToken.IRedisRedisClusterCreateIdentityTokenTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/redis_redis_cluster_create_identity_token#create RedisRedisClusterCreateIdentityToken#create}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Create
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/redis_redis_cluster_create_identity_token#delete RedisRedisClusterCreateIdentityToken#delete}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Delete
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/redis_redis_cluster_create_identity_token#update RedisRedisClusterCreateIdentityToken#update}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "update", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Update
        {
            get;
            set;
        }
    }
}

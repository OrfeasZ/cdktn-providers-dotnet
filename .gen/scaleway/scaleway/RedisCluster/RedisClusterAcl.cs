using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace scaleway.RedisCluster
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "scaleway.redisCluster.RedisClusterAcl")]
    public class RedisClusterAcl : scaleway.RedisCluster.IRedisClusterAcl
    {
        /// <summary>IPv4 network address of the rule in CIDR notation (IPv6 is not supported by the Scaleway API).</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/redis_cluster#ip RedisCluster#ip}
        /// </remarks>
        [JsiiProperty(name: "ip", typeJson: "{\"primitive\":\"string\"}")]
        public string Ip
        {
            get;
            set;
        }

        /// <summary>Description of the rule.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/redis_cluster#description RedisCluster#description}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Description
        {
            get;
            set;
        }
    }
}

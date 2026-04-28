using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace scaleway.RedisCluster
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "scaleway.redisCluster.RedisClusterPrivateNetwork")]
    public class RedisClusterPrivateNetwork : scaleway.RedisCluster.IRedisClusterPrivateNetwork
    {
        /// <summary>UUID of the private network to be connected to the cluster.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.74.0/docs/resources/redis_cluster#id RedisCluster#id}
        ///
        /// Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2.
        /// If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </remarks>
        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public string Id
        {
            get;
            set;
        }

        /// <summary>List of IPv4 addresses of the private network in CIDR notation (IPv6 is not supported by the Scaleway API).</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.74.0/docs/resources/redis_cluster#service_ips RedisCluster#service_ips}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "serviceIps", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? ServiceIps
        {
            get;
            set;
        }
    }
}

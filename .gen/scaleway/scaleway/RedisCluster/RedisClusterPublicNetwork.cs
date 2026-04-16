using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace scaleway.RedisCluster
{
    [JsiiByValue(fqn: "scaleway.redisCluster.RedisClusterPublicNetwork")]
    public class RedisClusterPublicNetwork : scaleway.RedisCluster.IRedisClusterPublicNetwork
    {
        /// <summary>UUID of the public network to be connected to the cluster.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/redis_cluster#id RedisCluster#id}
        ///
        /// Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2.
        /// If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Id
        {
            get;
            set;
        }

        /// <summary>List of IPv4 addresses of the endpoint.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/redis_cluster#ips RedisCluster#ips}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "ips", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? Ips
        {
            get;
            set;
        }

        /// <summary>TCP port of the endpoint.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/redis_cluster#port RedisCluster#port}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "port", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? Port
        {
            get;
            set;
        }
    }
}

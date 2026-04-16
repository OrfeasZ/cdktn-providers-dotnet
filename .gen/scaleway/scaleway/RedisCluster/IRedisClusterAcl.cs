using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace scaleway.RedisCluster
{
    [JsiiInterface(nativeType: typeof(IRedisClusterAcl), fullyQualifiedName: "scaleway.redisCluster.RedisClusterAcl")]
    public interface IRedisClusterAcl
    {
        /// <summary>IPv4 network address of the rule in CIDR notation (IPv6 is not supported by the Scaleway API).</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/redis_cluster#ip RedisCluster#ip}
        /// </remarks>
        [JsiiProperty(name: "ip", typeJson: "{\"primitive\":\"string\"}")]
        string Ip
        {
            get;
        }

        /// <summary>Description of the rule.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/redis_cluster#description RedisCluster#description}
        /// </remarks>
        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Description
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IRedisClusterAcl), fullyQualifiedName: "scaleway.redisCluster.RedisClusterAcl")]
        internal sealed class _Proxy : DeputyBase, scaleway.RedisCluster.IRedisClusterAcl
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>IPv4 network address of the rule in CIDR notation (IPv6 is not supported by the Scaleway API).</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/redis_cluster#ip RedisCluster#ip}
            /// </remarks>
            [JsiiProperty(name: "ip", typeJson: "{\"primitive\":\"string\"}")]
            public string Ip
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Description of the rule.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/redis_cluster#description RedisCluster#description}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Description
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}

using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.RedisRedisCluster
{
    [JsiiInterface(nativeType: typeof(IRedisRedisClusterImportFromObjectStorageDetails), fullyQualifiedName: "oci.redisRedisCluster.RedisRedisClusterImportFromObjectStorageDetails")]
    public interface IRedisRedisClusterImportFromObjectStorageDetails
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.21.0/docs/resources/redis_redis_cluster#bucket RedisRedisCluster#bucket}.</summary>
        [JsiiProperty(name: "bucket", typeJson: "{\"primitive\":\"string\"}")]
        string Bucket
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.21.0/docs/resources/redis_redis_cluster#namespace RedisRedisCluster#namespace}.</summary>
        [JsiiProperty(name: "namespace", typeJson: "{\"primitive\":\"string\"}")]
        string Namespace
        {
            get;
        }

        /// <summary>objects block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.21.0/docs/resources/redis_redis_cluster#objects RedisRedisCluster#objects}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="oci.RedisRedisCluster.IRedisRedisClusterImportFromObjectStorageDetailsObjects" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "objects", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.redisRedisCluster.RedisRedisClusterImportFromObjectStorageDetailsObjects\"},\"kind\":\"array\"}}]}}")]
        object Objects
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IRedisRedisClusterImportFromObjectStorageDetails), fullyQualifiedName: "oci.redisRedisCluster.RedisRedisClusterImportFromObjectStorageDetails")]
        internal sealed class _Proxy : DeputyBase, oci.RedisRedisCluster.IRedisRedisClusterImportFromObjectStorageDetails
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.21.0/docs/resources/redis_redis_cluster#bucket RedisRedisCluster#bucket}.</summary>
            [JsiiProperty(name: "bucket", typeJson: "{\"primitive\":\"string\"}")]
            public string Bucket
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.21.0/docs/resources/redis_redis_cluster#namespace RedisRedisCluster#namespace}.</summary>
            [JsiiProperty(name: "namespace", typeJson: "{\"primitive\":\"string\"}")]
            public string Namespace
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>objects block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.21.0/docs/resources/redis_redis_cluster#objects RedisRedisCluster#objects}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="oci.RedisRedisCluster.IRedisRedisClusterImportFromObjectStorageDetailsObjects" />)[]</para>
            /// </remarks>
            [JsiiProperty(name: "objects", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.redisRedisCluster.RedisRedisClusterImportFromObjectStorageDetailsObjects\"},\"kind\":\"array\"}}]}}")]
            public object Objects
            {
                get => GetInstanceProperty<object>()!;
            }
        }
    }
}

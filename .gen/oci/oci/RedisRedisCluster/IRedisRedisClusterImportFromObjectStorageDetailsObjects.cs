using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.RedisRedisCluster
{
    [JsiiInterface(nativeType: typeof(IRedisRedisClusterImportFromObjectStorageDetailsObjects), fullyQualifiedName: "oci.redisRedisCluster.RedisRedisClusterImportFromObjectStorageDetailsObjects")]
    public interface IRedisRedisClusterImportFromObjectStorageDetailsObjects
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.25.0/docs/resources/redis_redis_cluster#object RedisRedisCluster#object}.</summary>
        [JsiiProperty(name: "object", typeJson: "{\"primitive\":\"string\"}")]
        string Object
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IRedisRedisClusterImportFromObjectStorageDetailsObjects), fullyQualifiedName: "oci.redisRedisCluster.RedisRedisClusterImportFromObjectStorageDetailsObjects")]
        internal sealed class _Proxy : DeputyBase, oci.RedisRedisCluster.IRedisRedisClusterImportFromObjectStorageDetailsObjects
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.25.0/docs/resources/redis_redis_cluster#object RedisRedisCluster#object}.</summary>
            [JsiiProperty(name: "object", typeJson: "{\"primitive\":\"string\"}")]
            public string Object
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}

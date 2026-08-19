using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.RedisRedisCluster
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.redisRedisCluster.RedisRedisClusterImportFromObjectStorageDetails")]
    public class RedisRedisClusterImportFromObjectStorageDetails : oci.RedisRedisCluster.IRedisRedisClusterImportFromObjectStorageDetails
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.28.0/docs/resources/redis_redis_cluster#bucket RedisRedisCluster#bucket}.</summary>
        [JsiiProperty(name: "bucket", typeJson: "{\"primitive\":\"string\"}")]
        public string Bucket
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.28.0/docs/resources/redis_redis_cluster#namespace RedisRedisCluster#namespace}.</summary>
        [JsiiProperty(name: "namespace", typeJson: "{\"primitive\":\"string\"}")]
        public string Namespace
        {
            get;
            set;
        }

        private object _objects;

        /// <summary>objects block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.28.0/docs/resources/redis_redis_cluster#objects RedisRedisCluster#objects}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="oci.RedisRedisCluster.IRedisRedisClusterImportFromObjectStorageDetailsObjects" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "objects", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.redisRedisCluster.RedisRedisClusterImportFromObjectStorageDetailsObjects\"},\"kind\":\"array\"}}]}}")]
        public object Objects
        {
            get => _objects;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case oci.RedisRedisCluster.IRedisRedisClusterImportFromObjectStorageDetailsObjects[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.RedisRedisCluster.IRedisRedisClusterImportFromObjectStorageDetailsObjects).FullName}[]; received null", nameof(value));
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.RedisRedisCluster.IRedisRedisClusterImportFromObjectStorageDetailsObjects).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _objects = value;
            }
        }
    }
}

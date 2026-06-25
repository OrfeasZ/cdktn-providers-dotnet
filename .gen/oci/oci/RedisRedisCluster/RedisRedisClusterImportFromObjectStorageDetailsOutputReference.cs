using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.RedisRedisCluster
{
    [JsiiClass(nativeType: typeof(oci.RedisRedisCluster.RedisRedisClusterImportFromObjectStorageDetailsOutputReference), fullyQualifiedName: "oci.redisRedisCluster.RedisRedisClusterImportFromObjectStorageDetailsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class RedisRedisClusterImportFromObjectStorageDetailsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public RedisRedisClusterImportFromObjectStorageDetailsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute)
        {
            return new DeputyProps(new object?[]{terraformResource, terraformAttribute});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected RedisRedisClusterImportFromObjectStorageDetailsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected RedisRedisClusterImportFromObjectStorageDetailsOutputReference(DeputyProps props): base(props)
        {
        }

        /// <param name="value">Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="oci.RedisRedisCluster.IRedisRedisClusterImportFromObjectStorageDetailsObjects" />)[]</param>
        [JsiiMethod(name: "putObjects", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.redisRedisCluster.RedisRedisClusterImportFromObjectStorageDetailsObjects\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutObjects(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case oci.RedisRedisCluster.IRedisRedisClusterImportFromObjectStorageDetailsObjects[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.RedisRedisCluster.IRedisRedisClusterImportFromObjectStorageDetailsObjects).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.RedisRedisCluster.IRedisRedisClusterImportFromObjectStorageDetailsObjects).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiProperty(name: "objects", typeJson: "{\"fqn\":\"oci.redisRedisCluster.RedisRedisClusterImportFromObjectStorageDetailsObjectsList\"}")]
        public virtual oci.RedisRedisCluster.RedisRedisClusterImportFromObjectStorageDetailsObjectsList Objects
        {
            get => GetInstanceProperty<oci.RedisRedisCluster.RedisRedisClusterImportFromObjectStorageDetailsObjectsList>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "bucketInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? BucketInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "namespaceInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? NamespaceInput
        {
            get => GetInstanceProperty<string?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="oci.RedisRedisCluster.IRedisRedisClusterImportFromObjectStorageDetailsObjects" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "objectsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.redisRedisCluster.RedisRedisClusterImportFromObjectStorageDetailsObjects\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? ObjectsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiProperty(name: "bucket", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Bucket
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "namespace", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Namespace
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.redisRedisCluster.RedisRedisClusterImportFromObjectStorageDetails\"}", isOptional: true)]
        public virtual oci.RedisRedisCluster.IRedisRedisClusterImportFromObjectStorageDetails? InternalValue
        {
            get => GetInstanceProperty<oci.RedisRedisCluster.IRedisRedisClusterImportFromObjectStorageDetails?>();
            set => SetInstanceProperty(value);
        }
    }
}

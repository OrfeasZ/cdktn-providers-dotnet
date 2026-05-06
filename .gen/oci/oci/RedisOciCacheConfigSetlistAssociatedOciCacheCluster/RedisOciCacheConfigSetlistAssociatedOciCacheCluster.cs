using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.RedisOciCacheConfigSetlistAssociatedOciCacheCluster
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/redis_oci_cache_config_setlist_associated_oci_cache_cluster oci_redis_oci_cache_config_setlist_associated_oci_cache_cluster}.</summary>
    [JsiiClass(nativeType: typeof(oci.RedisOciCacheConfigSetlistAssociatedOciCacheCluster.RedisOciCacheConfigSetlistAssociatedOciCacheCluster), fullyQualifiedName: "oci.redisOciCacheConfigSetlistAssociatedOciCacheCluster.RedisOciCacheConfigSetlistAssociatedOciCacheCluster", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"oci.redisOciCacheConfigSetlistAssociatedOciCacheCluster.RedisOciCacheConfigSetlistAssociatedOciCacheClusterConfig\"}}]")]
    public class RedisOciCacheConfigSetlistAssociatedOciCacheCluster : Io.Cdktn.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/redis_oci_cache_config_setlist_associated_oci_cache_cluster oci_redis_oci_cache_config_setlist_associated_oci_cache_cluster} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public RedisOciCacheConfigSetlistAssociatedOciCacheCluster(Constructs.Construct scope, string id, oci.RedisOciCacheConfigSetlistAssociatedOciCacheCluster.IRedisOciCacheConfigSetlistAssociatedOciCacheClusterConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, oci.RedisOciCacheConfigSetlistAssociatedOciCacheCluster.IRedisOciCacheConfigSetlistAssociatedOciCacheClusterConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected RedisOciCacheConfigSetlistAssociatedOciCacheCluster(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected RedisOciCacheConfigSetlistAssociatedOciCacheCluster(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a RedisOciCacheConfigSetlistAssociatedOciCacheCluster resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the RedisOciCacheConfigSetlistAssociatedOciCacheCluster to import.</param>
        /// <param name="importFromId">The id of the existing RedisOciCacheConfigSetlistAssociatedOciCacheCluster that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the RedisOciCacheConfigSetlistAssociatedOciCacheCluster to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the RedisOciCacheConfigSetlistAssociatedOciCacheCluster to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/redis_oci_cache_config_setlist_associated_oci_cache_cluster#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing RedisOciCacheConfigSetlistAssociatedOciCacheCluster that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the RedisOciCacheConfigSetlistAssociatedOciCacheCluster to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(oci.RedisOciCacheConfigSetlistAssociatedOciCacheCluster.RedisOciCacheConfigSetlistAssociatedOciCacheCluster), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putTimeouts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.redisOciCacheConfigSetlistAssociatedOciCacheCluster.RedisOciCacheConfigSetlistAssociatedOciCacheClusterTimeouts\"}}]")]
        public virtual void PutTimeouts(oci.RedisOciCacheConfigSetlistAssociatedOciCacheCluster.IRedisOciCacheConfigSetlistAssociatedOciCacheClusterTimeouts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.RedisOciCacheConfigSetlistAssociatedOciCacheCluster.IRedisOciCacheConfigSetlistAssociatedOciCacheClusterTimeouts)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetId")]
        public virtual void ResetId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTimeouts")]
        public virtual void ResetTimeouts()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "synthesizeAttributes", returnsJson: "{\"type\":{\"collection\":{\"elementtype\":{\"primitive\":\"any\"},\"kind\":\"map\"}}}")]
        protected override System.Collections.Generic.IDictionary<string, object> SynthesizeAttributes()
        {
            return InvokeInstanceMethod<System.Collections.Generic.IDictionary<string, object>>(new System.Type[]{}, new object[]{})!;
        }

        [JsiiMethod(name: "synthesizeHclAttributes", returnsJson: "{\"type\":{\"collection\":{\"elementtype\":{\"primitive\":\"any\"},\"kind\":\"map\"}}}")]
        protected override System.Collections.Generic.IDictionary<string, object> SynthesizeHclAttributes()
        {
            return InvokeInstanceMethod<System.Collections.Generic.IDictionary<string, object>>(new System.Type[]{}, new object[]{})!;
        }

        [JsiiProperty(name: "tfResourceType", typeJson: "{\"primitive\":\"string\"}")]
        public static string TfResourceType
        {
            get;
        }
        = GetStaticProperty<string>(typeof(oci.RedisOciCacheConfigSetlistAssociatedOciCacheCluster.RedisOciCacheConfigSetlistAssociatedOciCacheCluster))!;

        [JsiiProperty(name: "items", typeJson: "{\"fqn\":\"oci.redisOciCacheConfigSetlistAssociatedOciCacheCluster.RedisOciCacheConfigSetlistAssociatedOciCacheClusterItemsList\"}")]
        public virtual oci.RedisOciCacheConfigSetlistAssociatedOciCacheCluster.RedisOciCacheConfigSetlistAssociatedOciCacheClusterItemsList Items
        {
            get => GetInstanceProperty<oci.RedisOciCacheConfigSetlistAssociatedOciCacheCluster.RedisOciCacheConfigSetlistAssociatedOciCacheClusterItemsList>()!;
        }

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"oci.redisOciCacheConfigSetlistAssociatedOciCacheCluster.RedisOciCacheConfigSetlistAssociatedOciCacheClusterTimeoutsOutputReference\"}")]
        public virtual oci.RedisOciCacheConfigSetlistAssociatedOciCacheCluster.RedisOciCacheConfigSetlistAssociatedOciCacheClusterTimeoutsOutputReference Timeouts
        {
            get => GetInstanceProperty<oci.RedisOciCacheConfigSetlistAssociatedOciCacheCluster.RedisOciCacheConfigSetlistAssociatedOciCacheClusterTimeoutsOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "idInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? IdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "ociCacheConfigSetIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? OciCacheConfigSetIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"oci.redisOciCacheConfigSetlistAssociatedOciCacheCluster.RedisOciCacheConfigSetlistAssociatedOciCacheClusterTimeouts\"}]}}", isOptional: true)]
        public virtual object? TimeoutsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "ociCacheConfigSetId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string OciCacheConfigSetId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}

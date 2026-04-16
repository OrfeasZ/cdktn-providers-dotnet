using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace scaleway.DataScalewayObjectBucket
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/data-sources/object_bucket scaleway_object_bucket}.</summary>
    [JsiiClass(nativeType: typeof(scaleway.DataScalewayObjectBucket.DataScalewayObjectBucket), fullyQualifiedName: "scaleway.dataScalewayObjectBucket.DataScalewayObjectBucket", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"optional\":true,\"type\":{\"fqn\":\"scaleway.dataScalewayObjectBucket.DataScalewayObjectBucketConfig\"}}]")]
    public class DataScalewayObjectBucket : Io.Cdktn.TerraformDataSource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/data-sources/object_bucket scaleway_object_bucket} Data Source.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public DataScalewayObjectBucket(Constructs.Construct scope, string id, scaleway.DataScalewayObjectBucket.IDataScalewayObjectBucketConfig? config = null): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, scaleway.DataScalewayObjectBucket.IDataScalewayObjectBucketConfig? config = null)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataScalewayObjectBucket(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataScalewayObjectBucket(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a DataScalewayObjectBucket resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the DataScalewayObjectBucket to import.</param>
        /// <param name="importFromId">The id of the existing DataScalewayObjectBucket that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the DataScalewayObjectBucket to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the DataScalewayObjectBucket to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/data-sources/object_bucket#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing DataScalewayObjectBucket that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the DataScalewayObjectBucket to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(scaleway.DataScalewayObjectBucket.DataScalewayObjectBucket), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "resetId")]
        public virtual void ResetId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetName")]
        public virtual void ResetName()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetProjectId")]
        public virtual void ResetProjectId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRegion")]
        public virtual void ResetRegion()
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
        = GetStaticProperty<string>(typeof(scaleway.DataScalewayObjectBucket.DataScalewayObjectBucket))!;

        [JsiiProperty(name: "acl", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Acl
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "apiEndpoint", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ApiEndpoint
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "corsRule", typeJson: "{\"fqn\":\"scaleway.dataScalewayObjectBucket.DataScalewayObjectBucketCorsRuleList\"}")]
        public virtual scaleway.DataScalewayObjectBucket.DataScalewayObjectBucketCorsRuleList CorsRule
        {
            get => GetInstanceProperty<scaleway.DataScalewayObjectBucket.DataScalewayObjectBucketCorsRuleList>()!;
        }

        [JsiiProperty(name: "endpoint", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Endpoint
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "forceDestroy", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable ForceDestroy
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "lifecycleRule", typeJson: "{\"fqn\":\"scaleway.dataScalewayObjectBucket.DataScalewayObjectBucketLifecycleRuleList\"}")]
        public virtual scaleway.DataScalewayObjectBucket.DataScalewayObjectBucketLifecycleRuleList LifecycleRule
        {
            get => GetInstanceProperty<scaleway.DataScalewayObjectBucket.DataScalewayObjectBucketLifecycleRuleList>()!;
        }

        [JsiiProperty(name: "objectLockEnabled", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable ObjectLockEnabled
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "tags", typeJson: "{\"fqn\":\"cdktn.StringMap\"}")]
        public virtual Io.Cdktn.StringMap Tags
        {
            get => GetInstanceProperty<Io.Cdktn.StringMap>()!;
        }

        [JsiiProperty(name: "versioning", typeJson: "{\"fqn\":\"scaleway.dataScalewayObjectBucket.DataScalewayObjectBucketVersioningList\"}")]
        public virtual scaleway.DataScalewayObjectBucket.DataScalewayObjectBucketVersioningList Versioning
        {
            get => GetInstanceProperty<scaleway.DataScalewayObjectBucket.DataScalewayObjectBucketVersioningList>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "idInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? IdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "nameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? NameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "projectIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ProjectIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "regionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? RegionInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Name
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "projectId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ProjectId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "region", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Region
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}

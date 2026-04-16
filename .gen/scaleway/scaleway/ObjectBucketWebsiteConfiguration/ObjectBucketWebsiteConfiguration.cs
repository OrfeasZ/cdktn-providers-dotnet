using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace scaleway.ObjectBucketWebsiteConfiguration
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/object_bucket_website_configuration scaleway_object_bucket_website_configuration}.</summary>
    [JsiiClass(nativeType: typeof(scaleway.ObjectBucketWebsiteConfiguration.ObjectBucketWebsiteConfiguration), fullyQualifiedName: "scaleway.objectBucketWebsiteConfiguration.ObjectBucketWebsiteConfiguration", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"scaleway.objectBucketWebsiteConfiguration.ObjectBucketWebsiteConfigurationConfig\"}}]")]
    public class ObjectBucketWebsiteConfiguration : Io.Cdktn.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/object_bucket_website_configuration scaleway_object_bucket_website_configuration} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public ObjectBucketWebsiteConfiguration(Constructs.Construct scope, string id, scaleway.ObjectBucketWebsiteConfiguration.IObjectBucketWebsiteConfigurationConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, scaleway.ObjectBucketWebsiteConfiguration.IObjectBucketWebsiteConfigurationConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected ObjectBucketWebsiteConfiguration(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected ObjectBucketWebsiteConfiguration(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a ObjectBucketWebsiteConfiguration resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the ObjectBucketWebsiteConfiguration to import.</param>
        /// <param name="importFromId">The id of the existing ObjectBucketWebsiteConfiguration that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the ObjectBucketWebsiteConfiguration to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the ObjectBucketWebsiteConfiguration to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/object_bucket_website_configuration#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing ObjectBucketWebsiteConfiguration that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the ObjectBucketWebsiteConfiguration to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(scaleway.ObjectBucketWebsiteConfiguration.ObjectBucketWebsiteConfiguration), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putErrorDocument", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"scaleway.objectBucketWebsiteConfiguration.ObjectBucketWebsiteConfigurationErrorDocument\"}}]")]
        public virtual void PutErrorDocument(scaleway.ObjectBucketWebsiteConfiguration.IObjectBucketWebsiteConfigurationErrorDocument @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(scaleway.ObjectBucketWebsiteConfiguration.IObjectBucketWebsiteConfigurationErrorDocument)}, new object[]{@value});
        }

        [JsiiMethod(name: "putIndexDocument", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"scaleway.objectBucketWebsiteConfiguration.ObjectBucketWebsiteConfigurationIndexDocument\"}}]")]
        public virtual void PutIndexDocument(scaleway.ObjectBucketWebsiteConfiguration.IObjectBucketWebsiteConfigurationIndexDocument @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(scaleway.ObjectBucketWebsiteConfiguration.IObjectBucketWebsiteConfigurationIndexDocument)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetErrorDocument")]
        public virtual void ResetErrorDocument()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetId")]
        public virtual void ResetId()
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
        = GetStaticProperty<string>(typeof(scaleway.ObjectBucketWebsiteConfiguration.ObjectBucketWebsiteConfiguration))!;

        [JsiiProperty(name: "errorDocument", typeJson: "{\"fqn\":\"scaleway.objectBucketWebsiteConfiguration.ObjectBucketWebsiteConfigurationErrorDocumentOutputReference\"}")]
        public virtual scaleway.ObjectBucketWebsiteConfiguration.ObjectBucketWebsiteConfigurationErrorDocumentOutputReference ErrorDocument
        {
            get => GetInstanceProperty<scaleway.ObjectBucketWebsiteConfiguration.ObjectBucketWebsiteConfigurationErrorDocumentOutputReference>()!;
        }

        [JsiiProperty(name: "indexDocument", typeJson: "{\"fqn\":\"scaleway.objectBucketWebsiteConfiguration.ObjectBucketWebsiteConfigurationIndexDocumentOutputReference\"}")]
        public virtual scaleway.ObjectBucketWebsiteConfiguration.ObjectBucketWebsiteConfigurationIndexDocumentOutputReference IndexDocument
        {
            get => GetInstanceProperty<scaleway.ObjectBucketWebsiteConfiguration.ObjectBucketWebsiteConfigurationIndexDocumentOutputReference>()!;
        }

        [JsiiProperty(name: "websiteDomain", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string WebsiteDomain
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "websiteEndpoint", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string WebsiteEndpoint
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "bucketInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? BucketInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "errorDocumentInput", typeJson: "{\"fqn\":\"scaleway.objectBucketWebsiteConfiguration.ObjectBucketWebsiteConfigurationErrorDocument\"}", isOptional: true)]
        public virtual scaleway.ObjectBucketWebsiteConfiguration.IObjectBucketWebsiteConfigurationErrorDocument? ErrorDocumentInput
        {
            get => GetInstanceProperty<scaleway.ObjectBucketWebsiteConfiguration.IObjectBucketWebsiteConfigurationErrorDocument?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "idInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? IdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "indexDocumentInput", typeJson: "{\"fqn\":\"scaleway.objectBucketWebsiteConfiguration.ObjectBucketWebsiteConfigurationIndexDocument\"}", isOptional: true)]
        public virtual scaleway.ObjectBucketWebsiteConfiguration.IObjectBucketWebsiteConfigurationIndexDocument? IndexDocumentInput
        {
            get => GetInstanceProperty<scaleway.ObjectBucketWebsiteConfiguration.IObjectBucketWebsiteConfigurationIndexDocument?>();
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

        [JsiiProperty(name: "bucket", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Bucket
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
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

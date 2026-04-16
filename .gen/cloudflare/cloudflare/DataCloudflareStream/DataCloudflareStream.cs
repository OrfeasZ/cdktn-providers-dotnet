using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.DataCloudflareStream
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/data-sources/stream cloudflare_stream}.</summary>
    [JsiiClass(nativeType: typeof(cloudflare.DataCloudflareStream.DataCloudflareStream), fullyQualifiedName: "cloudflare.dataCloudflareStream.DataCloudflareStream", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"cloudflare.dataCloudflareStream.DataCloudflareStreamConfig\"}}]")]
    public class DataCloudflareStream : Io.Cdktn.TerraformDataSource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/data-sources/stream cloudflare_stream} Data Source.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public DataCloudflareStream(Constructs.Construct scope, string id, cloudflare.DataCloudflareStream.IDataCloudflareStreamConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, cloudflare.DataCloudflareStream.IDataCloudflareStreamConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataCloudflareStream(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataCloudflareStream(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a DataCloudflareStream resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the DataCloudflareStream to import.</param>
        /// <param name="importFromId">The id of the existing DataCloudflareStream that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the DataCloudflareStream to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the DataCloudflareStream to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/data-sources/stream#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing DataCloudflareStream that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the DataCloudflareStream to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(cloudflare.DataCloudflareStream.DataCloudflareStream), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
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
        = GetStaticProperty<string>(typeof(cloudflare.DataCloudflareStream.DataCloudflareStream))!;

        [JsiiProperty(name: "allowedOrigins", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] AllowedOrigins
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "created", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Created
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "creator", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Creator
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "duration", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Duration
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "input", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareStream.DataCloudflareStreamInputOutputReference\"}")]
        public virtual cloudflare.DataCloudflareStream.DataCloudflareStreamInputOutputReference Input
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareStream.DataCloudflareStreamInputOutputReference>()!;
        }

        [JsiiProperty(name: "liveInput", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LiveInput
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "maxDurationSeconds", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MaxDurationSeconds
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "meta", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Meta
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "modified", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Modified
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "playback", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareStream.DataCloudflareStreamPlaybackOutputReference\"}")]
        public virtual cloudflare.DataCloudflareStream.DataCloudflareStreamPlaybackOutputReference Playback
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareStream.DataCloudflareStreamPlaybackOutputReference>()!;
        }

        [JsiiProperty(name: "preview", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Preview
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "readyToStream", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable ReadyToStream
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "readyToStreamAt", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ReadyToStreamAt
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "requireSignedUrls", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable RequireSignedUrls
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "scheduledDeletion", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ScheduledDeletion
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "size", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Size
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "status", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareStream.DataCloudflareStreamStatusOutputReference\"}")]
        public virtual cloudflare.DataCloudflareStream.DataCloudflareStreamStatusOutputReference Status
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareStream.DataCloudflareStreamStatusOutputReference>()!;
        }

        [JsiiProperty(name: "thumbnail", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Thumbnail
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "thumbnailTimestampPct", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double ThumbnailTimestampPct
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "uid", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Uid
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "uploaded", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Uploaded
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "uploadExpiry", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string UploadExpiry
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "watermark", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareStream.DataCloudflareStreamWatermarkOutputReference\"}")]
        public virtual cloudflare.DataCloudflareStream.DataCloudflareStreamWatermarkOutputReference Watermark
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareStream.DataCloudflareStreamWatermarkOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "accountIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? AccountIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "identifierInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? IdentifierInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "accountId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AccountId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "identifier", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Identifier
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}

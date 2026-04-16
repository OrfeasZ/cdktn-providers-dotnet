using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.Stream
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/stream cloudflare_stream}.</summary>
    [JsiiClass(nativeType: typeof(cloudflare.Stream.Stream), fullyQualifiedName: "cloudflare.stream.Stream", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"cloudflare.stream.StreamConfig\"}}]")]
    public class Stream : Io.Cdktn.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/stream cloudflare_stream} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public Stream(Constructs.Construct scope, string id, cloudflare.Stream.IStreamConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, cloudflare.Stream.IStreamConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected Stream(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected Stream(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a Stream resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the Stream to import.</param>
        /// <param name="importFromId">The id of the existing Stream that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the Stream to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the Stream to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/stream#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing Stream that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the Stream to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(cloudflare.Stream.Stream), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "resetAllowedOrigins")]
        public virtual void ResetAllowedOrigins()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetCreator")]
        public virtual void ResetCreator()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetIdentifier")]
        public virtual void ResetIdentifier()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMaxDurationSeconds")]
        public virtual void ResetMaxDurationSeconds()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMeta")]
        public virtual void ResetMeta()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRequireSignedUrls")]
        public virtual void ResetRequireSignedUrls()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetScheduledDeletion")]
        public virtual void ResetScheduledDeletion()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetThumbnailTimestampPct")]
        public virtual void ResetThumbnailTimestampPct()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetUploadExpiry")]
        public virtual void ResetUploadExpiry()
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
        = GetStaticProperty<string>(typeof(cloudflare.Stream.Stream))!;

        [JsiiProperty(name: "created", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Created
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "duration", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Duration
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "input", typeJson: "{\"fqn\":\"cloudflare.stream.StreamInputOutputReference\"}")]
        public virtual cloudflare.Stream.StreamInputOutputReference Input
        {
            get => GetInstanceProperty<cloudflare.Stream.StreamInputOutputReference>()!;
        }

        [JsiiProperty(name: "liveInput", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LiveInput
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "modified", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Modified
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "playback", typeJson: "{\"fqn\":\"cloudflare.stream.StreamPlaybackOutputReference\"}")]
        public virtual cloudflare.Stream.StreamPlaybackOutputReference Playback
        {
            get => GetInstanceProperty<cloudflare.Stream.StreamPlaybackOutputReference>()!;
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

        [JsiiProperty(name: "size", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Size
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "status", typeJson: "{\"fqn\":\"cloudflare.stream.StreamStatusOutputReference\"}")]
        public virtual cloudflare.Stream.StreamStatusOutputReference Status
        {
            get => GetInstanceProperty<cloudflare.Stream.StreamStatusOutputReference>()!;
        }

        [JsiiProperty(name: "thumbnail", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Thumbnail
        {
            get => GetInstanceProperty<string>()!;
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

        [JsiiProperty(name: "watermark", typeJson: "{\"fqn\":\"cloudflare.stream.StreamWatermarkOutputReference\"}")]
        public virtual cloudflare.Stream.StreamWatermarkOutputReference Watermark
        {
            get => GetInstanceProperty<cloudflare.Stream.StreamWatermarkOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "accountIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? AccountIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "allowedOriginsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? AllowedOriginsInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "creatorInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? CreatorInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "identifierInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? IdentifierInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "maxDurationSecondsInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? MaxDurationSecondsInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "metaInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? MetaInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "requireSignedUrlsInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public virtual object? RequireSignedUrlsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "scheduledDeletionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ScheduledDeletionInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "thumbnailTimestampPctInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? ThumbnailTimestampPctInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "uploadExpiryInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? UploadExpiryInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "accountId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AccountId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "allowedOrigins", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] AllowedOrigins
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "creator", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Creator
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

        [JsiiProperty(name: "maxDurationSeconds", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MaxDurationSeconds
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "meta", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Meta
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "requireSignedUrls", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        public virtual object RequireSignedUrls
        {
            get => GetInstanceProperty<object>()!;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case bool cast_cd4240:
                            break;
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received null", nameof(value));
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }

        [JsiiProperty(name: "scheduledDeletion", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ScheduledDeletion
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "thumbnailTimestampPct", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double ThumbnailTimestampPct
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "uploadExpiry", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string UploadExpiry
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}

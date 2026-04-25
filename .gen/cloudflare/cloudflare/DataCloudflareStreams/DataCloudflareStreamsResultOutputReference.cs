using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.DataCloudflareStreams
{
    [JsiiClass(nativeType: typeof(cloudflare.DataCloudflareStreams.DataCloudflareStreamsResultOutputReference), fullyQualifiedName: "cloudflare.dataCloudflareStreams.DataCloudflareStreamsResultOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataCloudflareStreamsResultOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataCloudflareStreamsResultOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet)
        {
            return new DeputyProps(new object?[]{terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataCloudflareStreamsResultOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataCloudflareStreamsResultOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "allowedOrigins", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] AllowedOrigins
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "clippedFrom", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ClippedFrom
        {
            get => GetInstanceProperty<string>()!;
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

        [JsiiProperty(name: "input", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareStreams.DataCloudflareStreamsResultInputOutputReference\"}")]
        public virtual cloudflare.DataCloudflareStreams.DataCloudflareStreamsResultInputOutputReference Input
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareStreams.DataCloudflareStreamsResultInputOutputReference>()!;
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

        [JsiiProperty(name: "maxSizeBytes", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MaxSizeBytes
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

        [JsiiProperty(name: "playback", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareStreams.DataCloudflareStreamsResultPlaybackOutputReference\"}")]
        public virtual cloudflare.DataCloudflareStreams.DataCloudflareStreamsResultPlaybackOutputReference Playback
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareStreams.DataCloudflareStreamsResultPlaybackOutputReference>()!;
        }

        [JsiiProperty(name: "preview", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Preview
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "publicDetails", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareStreams.DataCloudflareStreamsResultPublicDetailsOutputReference\"}")]
        public virtual cloudflare.DataCloudflareStreams.DataCloudflareStreamsResultPublicDetailsOutputReference PublicDetails
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareStreams.DataCloudflareStreamsResultPublicDetailsOutputReference>()!;
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

        [JsiiProperty(name: "status", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareStreams.DataCloudflareStreamsResultStatusOutputReference\"}")]
        public virtual cloudflare.DataCloudflareStreams.DataCloudflareStreamsResultStatusOutputReference Status
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareStreams.DataCloudflareStreamsResultStatusOutputReference>()!;
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

        [JsiiProperty(name: "watermark", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareStreams.DataCloudflareStreamsResultWatermarkOutputReference\"}")]
        public virtual cloudflare.DataCloudflareStreams.DataCloudflareStreamsResultWatermarkOutputReference Watermark
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareStreams.DataCloudflareStreamsResultWatermarkOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareStreams.DataCloudflareStreamsResult\"}", isOptional: true)]
        public virtual cloudflare.DataCloudflareStreams.IDataCloudflareStreamsResult? InternalValue
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareStreams.IDataCloudflareStreamsResult?>();
            set => SetInstanceProperty(value);
        }
    }
}

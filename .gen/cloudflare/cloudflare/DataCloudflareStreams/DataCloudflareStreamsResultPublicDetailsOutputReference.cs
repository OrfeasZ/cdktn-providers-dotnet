using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.DataCloudflareStreams
{
    [JsiiClass(nativeType: typeof(cloudflare.DataCloudflareStreams.DataCloudflareStreamsResultPublicDetailsOutputReference), fullyQualifiedName: "cloudflare.dataCloudflareStreams.DataCloudflareStreamsResultPublicDetailsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class DataCloudflareStreamsResultPublicDetailsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public DataCloudflareStreamsResultPublicDetailsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected DataCloudflareStreamsResultPublicDetailsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataCloudflareStreamsResultPublicDetailsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "channelLink", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ChannelLink
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "logo", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Logo
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "mediaId", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MediaId
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "shareLink", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ShareLink
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "title", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Title
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareStreams.DataCloudflareStreamsResultPublicDetails\"}", isOptional: true)]
        public virtual cloudflare.DataCloudflareStreams.IDataCloudflareStreamsResultPublicDetails? InternalValue
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareStreams.IDataCloudflareStreamsResultPublicDetails?>();
            set => SetInstanceProperty(value);
        }
    }
}

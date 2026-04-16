using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.StreamLiveInput
{
    [JsiiClass(nativeType: typeof(cloudflare.StreamLiveInput.StreamLiveInputSrtPlaybackOutputReference), fullyQualifiedName: "cloudflare.streamLiveInput.StreamLiveInputSrtPlaybackOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class StreamLiveInputSrtPlaybackOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public StreamLiveInputSrtPlaybackOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected StreamLiveInputSrtPlaybackOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected StreamLiveInputSrtPlaybackOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "passphrase", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Passphrase
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "streamId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string StreamId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "url", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Url
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"cloudflare.streamLiveInput.StreamLiveInputSrtPlayback\"}", isOptional: true)]
        public virtual cloudflare.StreamLiveInput.IStreamLiveInputSrtPlayback? InternalValue
        {
            get => GetInstanceProperty<cloudflare.StreamLiveInput.IStreamLiveInputSrtPlayback?>();
            set => SetInstanceProperty(value);
        }
    }
}

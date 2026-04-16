using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.DataCloudflareStream
{
    [JsiiClass(nativeType: typeof(cloudflare.DataCloudflareStream.DataCloudflareStreamPlaybackOutputReference), fullyQualifiedName: "cloudflare.dataCloudflareStream.DataCloudflareStreamPlaybackOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class DataCloudflareStreamPlaybackOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public DataCloudflareStreamPlaybackOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected DataCloudflareStreamPlaybackOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataCloudflareStreamPlaybackOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "dash", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Dash
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "hls", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Hls
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareStream.DataCloudflareStreamPlayback\"}", isOptional: true)]
        public virtual cloudflare.DataCloudflareStream.IDataCloudflareStreamPlayback? InternalValue
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareStream.IDataCloudflareStreamPlayback?>();
            set => SetInstanceProperty(value);
        }
    }
}

using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.DataCloudflareStreams
{
    [JsiiClass(nativeType: typeof(cloudflare.DataCloudflareStreams.DataCloudflareStreamsResultWatermarkOutputReference), fullyQualifiedName: "cloudflare.dataCloudflareStreams.DataCloudflareStreamsResultWatermarkOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class DataCloudflareStreamsResultWatermarkOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public DataCloudflareStreamsResultWatermarkOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected DataCloudflareStreamsResultWatermarkOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataCloudflareStreamsResultWatermarkOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "created", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Created
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "downloadedFrom", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DownloadedFrom
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "height", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Height
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Name
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "opacity", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Opacity
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "padding", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Padding
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "position", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Position
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "scale", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Scale
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "size", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Size
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "uid", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Uid
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "width", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Width
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareStreams.DataCloudflareStreamsResultWatermark\"}", isOptional: true)]
        public virtual cloudflare.DataCloudflareStreams.IDataCloudflareStreamsResultWatermark? InternalValue
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareStreams.IDataCloudflareStreamsResultWatermark?>();
            set => SetInstanceProperty(value);
        }
    }
}

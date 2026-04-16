using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.DataCloudflareZoneCacheVariants
{
    [JsiiClass(nativeType: typeof(cloudflare.DataCloudflareZoneCacheVariants.DataCloudflareZoneCacheVariantsValueOutputReference), fullyQualifiedName: "cloudflare.dataCloudflareZoneCacheVariants.DataCloudflareZoneCacheVariantsValueOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class DataCloudflareZoneCacheVariantsValueOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public DataCloudflareZoneCacheVariantsValueOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected DataCloudflareZoneCacheVariantsValueOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataCloudflareZoneCacheVariantsValueOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "avif", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] Avif
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "bmp", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] Bmp
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "gif", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] Gif
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "jp2", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] Jp2
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "jpeg", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] Jpeg
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "jpg", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] Jpg
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "jpg2", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] Jpg2
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "png", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] Png
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "tif", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] Tif
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "tiff", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] Tiff
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "webp", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] Webp
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareZoneCacheVariants.DataCloudflareZoneCacheVariantsValue\"}", isOptional: true)]
        public virtual cloudflare.DataCloudflareZoneCacheVariants.IDataCloudflareZoneCacheVariantsValue? InternalValue
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareZoneCacheVariants.IDataCloudflareZoneCacheVariantsValue?>();
            set => SetInstanceProperty(value);
        }
    }
}

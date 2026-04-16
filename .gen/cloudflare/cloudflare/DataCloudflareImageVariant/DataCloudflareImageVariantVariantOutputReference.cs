using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.DataCloudflareImageVariant
{
    [JsiiClass(nativeType: typeof(cloudflare.DataCloudflareImageVariant.DataCloudflareImageVariantVariantOutputReference), fullyQualifiedName: "cloudflare.dataCloudflareImageVariant.DataCloudflareImageVariantVariantOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class DataCloudflareImageVariantVariantOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public DataCloudflareImageVariantVariantOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected DataCloudflareImageVariantVariantOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataCloudflareImageVariantVariantOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "neverRequireSignedUrls", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable NeverRequireSignedUrls
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "options", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareImageVariant.DataCloudflareImageVariantVariantOptionsOutputReference\"}")]
        public virtual cloudflare.DataCloudflareImageVariant.DataCloudflareImageVariantVariantOptionsOutputReference Options
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareImageVariant.DataCloudflareImageVariantVariantOptionsOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareImageVariant.DataCloudflareImageVariantVariant\"}", isOptional: true)]
        public virtual cloudflare.DataCloudflareImageVariant.IDataCloudflareImageVariantVariant? InternalValue
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareImageVariant.IDataCloudflareImageVariantVariant?>();
            set => SetInstanceProperty(value);
        }
    }
}

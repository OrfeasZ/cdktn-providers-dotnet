using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.DataCloudflareWorkerVersions
{
    [JsiiClass(nativeType: typeof(cloudflare.DataCloudflareWorkerVersions.DataCloudflareWorkerVersionsResultAssetsConfigOutputReference), fullyQualifiedName: "cloudflare.dataCloudflareWorkerVersions.DataCloudflareWorkerVersionsResultAssetsConfigOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class DataCloudflareWorkerVersionsResultAssetsConfigOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public DataCloudflareWorkerVersionsResultAssetsConfigOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected DataCloudflareWorkerVersionsResultAssetsConfigOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataCloudflareWorkerVersionsResultAssetsConfigOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "htmlHandling", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string HtmlHandling
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "notFoundHandling", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string NotFoundHandling
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "runWorkerFirst", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] RunWorkerFirst
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareWorkerVersions.DataCloudflareWorkerVersionsResultAssetsConfig\"}", isOptional: true)]
        public virtual cloudflare.DataCloudflareWorkerVersions.IDataCloudflareWorkerVersionsResultAssetsConfig? InternalValue
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareWorkerVersions.IDataCloudflareWorkerVersionsResultAssetsConfig?>();
            set => SetInstanceProperty(value);
        }
    }
}

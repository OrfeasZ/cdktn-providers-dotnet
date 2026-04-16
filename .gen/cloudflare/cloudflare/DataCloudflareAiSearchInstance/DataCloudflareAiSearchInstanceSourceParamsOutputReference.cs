using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.DataCloudflareAiSearchInstance
{
    [JsiiClass(nativeType: typeof(cloudflare.DataCloudflareAiSearchInstance.DataCloudflareAiSearchInstanceSourceParamsOutputReference), fullyQualifiedName: "cloudflare.dataCloudflareAiSearchInstance.DataCloudflareAiSearchInstanceSourceParamsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class DataCloudflareAiSearchInstanceSourceParamsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public DataCloudflareAiSearchInstanceSourceParamsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected DataCloudflareAiSearchInstanceSourceParamsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataCloudflareAiSearchInstanceSourceParamsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "excludeItems", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] ExcludeItems
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "includeItems", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] IncludeItems
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "prefix", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Prefix
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "r2Jurisdiction", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string R2Jurisdiction
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "webCrawler", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareAiSearchInstance.DataCloudflareAiSearchInstanceSourceParamsWebCrawlerOutputReference\"}")]
        public virtual cloudflare.DataCloudflareAiSearchInstance.DataCloudflareAiSearchInstanceSourceParamsWebCrawlerOutputReference WebCrawler
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareAiSearchInstance.DataCloudflareAiSearchInstanceSourceParamsWebCrawlerOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareAiSearchInstance.DataCloudflareAiSearchInstanceSourceParams\"}", isOptional: true)]
        public virtual cloudflare.DataCloudflareAiSearchInstance.IDataCloudflareAiSearchInstanceSourceParams? InternalValue
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareAiSearchInstance.IDataCloudflareAiSearchInstanceSourceParams?>();
            set => SetInstanceProperty(value);
        }
    }
}

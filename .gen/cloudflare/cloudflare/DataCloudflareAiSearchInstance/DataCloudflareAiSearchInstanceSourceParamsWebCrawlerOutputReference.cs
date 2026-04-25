using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.DataCloudflareAiSearchInstance
{
    [JsiiClass(nativeType: typeof(cloudflare.DataCloudflareAiSearchInstance.DataCloudflareAiSearchInstanceSourceParamsWebCrawlerOutputReference), fullyQualifiedName: "cloudflare.dataCloudflareAiSearchInstance.DataCloudflareAiSearchInstanceSourceParamsWebCrawlerOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class DataCloudflareAiSearchInstanceSourceParamsWebCrawlerOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public DataCloudflareAiSearchInstanceSourceParamsWebCrawlerOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected DataCloudflareAiSearchInstanceSourceParamsWebCrawlerOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataCloudflareAiSearchInstanceSourceParamsWebCrawlerOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "crawlOptions", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareAiSearchInstance.DataCloudflareAiSearchInstanceSourceParamsWebCrawlerCrawlOptionsOutputReference\"}")]
        public virtual cloudflare.DataCloudflareAiSearchInstance.DataCloudflareAiSearchInstanceSourceParamsWebCrawlerCrawlOptionsOutputReference CrawlOptions
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareAiSearchInstance.DataCloudflareAiSearchInstanceSourceParamsWebCrawlerCrawlOptionsOutputReference>()!;
        }

        [JsiiProperty(name: "parseOptions", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareAiSearchInstance.DataCloudflareAiSearchInstanceSourceParamsWebCrawlerParseOptionsOutputReference\"}")]
        public virtual cloudflare.DataCloudflareAiSearchInstance.DataCloudflareAiSearchInstanceSourceParamsWebCrawlerParseOptionsOutputReference ParseOptions
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareAiSearchInstance.DataCloudflareAiSearchInstanceSourceParamsWebCrawlerParseOptionsOutputReference>()!;
        }

        [JsiiProperty(name: "parseType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ParseType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "storeOptions", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareAiSearchInstance.DataCloudflareAiSearchInstanceSourceParamsWebCrawlerStoreOptionsOutputReference\"}")]
        public virtual cloudflare.DataCloudflareAiSearchInstance.DataCloudflareAiSearchInstanceSourceParamsWebCrawlerStoreOptionsOutputReference StoreOptions
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareAiSearchInstance.DataCloudflareAiSearchInstanceSourceParamsWebCrawlerStoreOptionsOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareAiSearchInstance.DataCloudflareAiSearchInstanceSourceParamsWebCrawler\"}", isOptional: true)]
        public virtual cloudflare.DataCloudflareAiSearchInstance.IDataCloudflareAiSearchInstanceSourceParamsWebCrawler? InternalValue
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareAiSearchInstance.IDataCloudflareAiSearchInstanceSourceParamsWebCrawler?>();
            set => SetInstanceProperty(value);
        }
    }
}

using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.DataCloudflareAiSearchInstance
{
    [JsiiClass(nativeType: typeof(cloudflare.DataCloudflareAiSearchInstance.DataCloudflareAiSearchInstanceSourceParamsWebCrawlerParseOptionsOutputReference), fullyQualifiedName: "cloudflare.dataCloudflareAiSearchInstance.DataCloudflareAiSearchInstanceSourceParamsWebCrawlerParseOptionsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class DataCloudflareAiSearchInstanceSourceParamsWebCrawlerParseOptionsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public DataCloudflareAiSearchInstanceSourceParamsWebCrawlerParseOptionsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected DataCloudflareAiSearchInstanceSourceParamsWebCrawlerParseOptionsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataCloudflareAiSearchInstanceSourceParamsWebCrawlerParseOptionsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "contentSelector", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareAiSearchInstance.DataCloudflareAiSearchInstanceSourceParamsWebCrawlerParseOptionsContentSelectorList\"}")]
        public virtual cloudflare.DataCloudflareAiSearchInstance.DataCloudflareAiSearchInstanceSourceParamsWebCrawlerParseOptionsContentSelectorList ContentSelector
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareAiSearchInstance.DataCloudflareAiSearchInstanceSourceParamsWebCrawlerParseOptionsContentSelectorList>()!;
        }

        [JsiiProperty(name: "includeHeaders", typeJson: "{\"fqn\":\"cdktn.StringMap\"}")]
        public virtual Io.Cdktn.StringMap IncludeHeaders
        {
            get => GetInstanceProperty<Io.Cdktn.StringMap>()!;
        }

        [JsiiProperty(name: "includeImages", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IncludeImages
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "specificSitemaps", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] SpecificSitemaps
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "useBrowserRendering", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable UseBrowserRendering
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareAiSearchInstance.DataCloudflareAiSearchInstanceSourceParamsWebCrawlerParseOptions\"}", isOptional: true)]
        public virtual cloudflare.DataCloudflareAiSearchInstance.IDataCloudflareAiSearchInstanceSourceParamsWebCrawlerParseOptions? InternalValue
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareAiSearchInstance.IDataCloudflareAiSearchInstanceSourceParamsWebCrawlerParseOptions?>();
            set => SetInstanceProperty(value);
        }
    }
}

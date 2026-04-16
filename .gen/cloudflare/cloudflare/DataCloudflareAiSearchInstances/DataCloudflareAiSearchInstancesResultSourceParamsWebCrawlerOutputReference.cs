using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.DataCloudflareAiSearchInstances
{
    [JsiiClass(nativeType: typeof(cloudflare.DataCloudflareAiSearchInstances.DataCloudflareAiSearchInstancesResultSourceParamsWebCrawlerOutputReference), fullyQualifiedName: "cloudflare.dataCloudflareAiSearchInstances.DataCloudflareAiSearchInstancesResultSourceParamsWebCrawlerOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class DataCloudflareAiSearchInstancesResultSourceParamsWebCrawlerOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public DataCloudflareAiSearchInstancesResultSourceParamsWebCrawlerOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected DataCloudflareAiSearchInstancesResultSourceParamsWebCrawlerOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataCloudflareAiSearchInstancesResultSourceParamsWebCrawlerOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "parseOptions", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareAiSearchInstances.DataCloudflareAiSearchInstancesResultSourceParamsWebCrawlerParseOptionsOutputReference\"}")]
        public virtual cloudflare.DataCloudflareAiSearchInstances.DataCloudflareAiSearchInstancesResultSourceParamsWebCrawlerParseOptionsOutputReference ParseOptions
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareAiSearchInstances.DataCloudflareAiSearchInstancesResultSourceParamsWebCrawlerParseOptionsOutputReference>()!;
        }

        [JsiiProperty(name: "parseType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ParseType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "storeOptions", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareAiSearchInstances.DataCloudflareAiSearchInstancesResultSourceParamsWebCrawlerStoreOptionsOutputReference\"}")]
        public virtual cloudflare.DataCloudflareAiSearchInstances.DataCloudflareAiSearchInstancesResultSourceParamsWebCrawlerStoreOptionsOutputReference StoreOptions
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareAiSearchInstances.DataCloudflareAiSearchInstancesResultSourceParamsWebCrawlerStoreOptionsOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareAiSearchInstances.DataCloudflareAiSearchInstancesResultSourceParamsWebCrawler\"}", isOptional: true)]
        public virtual cloudflare.DataCloudflareAiSearchInstances.IDataCloudflareAiSearchInstancesResultSourceParamsWebCrawler? InternalValue
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareAiSearchInstances.IDataCloudflareAiSearchInstancesResultSourceParamsWebCrawler?>();
            set => SetInstanceProperty(value);
        }
    }
}

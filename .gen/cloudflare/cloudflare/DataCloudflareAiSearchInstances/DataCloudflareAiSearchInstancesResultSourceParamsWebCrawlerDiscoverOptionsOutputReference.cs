using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.DataCloudflareAiSearchInstances
{
    [JsiiClass(nativeType: typeof(cloudflare.DataCloudflareAiSearchInstances.DataCloudflareAiSearchInstancesResultSourceParamsWebCrawlerDiscoverOptionsOutputReference), fullyQualifiedName: "cloudflare.dataCloudflareAiSearchInstances.DataCloudflareAiSearchInstancesResultSourceParamsWebCrawlerDiscoverOptionsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class DataCloudflareAiSearchInstancesResultSourceParamsWebCrawlerDiscoverOptionsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public DataCloudflareAiSearchInstancesResultSourceParamsWebCrawlerDiscoverOptionsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected DataCloudflareAiSearchInstancesResultSourceParamsWebCrawlerDiscoverOptionsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataCloudflareAiSearchInstancesResultSourceParamsWebCrawlerDiscoverOptionsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "depth", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Depth
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "includeExternalLinks", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IncludeExternalLinks
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "includeSubdomains", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IncludeSubdomains
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "limit", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Limit
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "maxAge", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MaxAge
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "source", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Source
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareAiSearchInstances.DataCloudflareAiSearchInstancesResultSourceParamsWebCrawlerDiscoverOptions\"}", isOptional: true)]
        public virtual cloudflare.DataCloudflareAiSearchInstances.IDataCloudflareAiSearchInstancesResultSourceParamsWebCrawlerDiscoverOptions? InternalValue
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareAiSearchInstances.IDataCloudflareAiSearchInstancesResultSourceParamsWebCrawlerDiscoverOptions?>();
            set => SetInstanceProperty(value);
        }
    }
}

using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.DataCloudflareWebAnalyticsSites
{
    [JsiiClass(nativeType: typeof(cloudflare.DataCloudflareWebAnalyticsSites.DataCloudflareWebAnalyticsSitesResultOutputReference), fullyQualifiedName: "cloudflare.dataCloudflareWebAnalyticsSites.DataCloudflareWebAnalyticsSitesResultOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataCloudflareWebAnalyticsSitesResultOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataCloudflareWebAnalyticsSitesResultOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet)
        {
            return new DeputyProps(new object?[]{terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataCloudflareWebAnalyticsSitesResultOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataCloudflareWebAnalyticsSitesResultOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "autoInstall", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable AutoInstall
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "created", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Created
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "rules", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareWebAnalyticsSites.DataCloudflareWebAnalyticsSitesResultRulesList\"}")]
        public virtual cloudflare.DataCloudflareWebAnalyticsSites.DataCloudflareWebAnalyticsSitesResultRulesList Rules
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareWebAnalyticsSites.DataCloudflareWebAnalyticsSitesResultRulesList>()!;
        }

        [JsiiProperty(name: "ruleset", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareWebAnalyticsSites.DataCloudflareWebAnalyticsSitesResultRulesetOutputReference\"}")]
        public virtual cloudflare.DataCloudflareWebAnalyticsSites.DataCloudflareWebAnalyticsSitesResultRulesetOutputReference Ruleset
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareWebAnalyticsSites.DataCloudflareWebAnalyticsSitesResultRulesetOutputReference>()!;
        }

        [JsiiProperty(name: "siteTag", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SiteTag
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "siteToken", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SiteToken
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "snippet", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Snippet
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareWebAnalyticsSites.DataCloudflareWebAnalyticsSitesResult\"}", isOptional: true)]
        public virtual cloudflare.DataCloudflareWebAnalyticsSites.IDataCloudflareWebAnalyticsSitesResult? InternalValue
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareWebAnalyticsSites.IDataCloudflareWebAnalyticsSitesResult?>();
            set => SetInstanceProperty(value);
        }
    }
}

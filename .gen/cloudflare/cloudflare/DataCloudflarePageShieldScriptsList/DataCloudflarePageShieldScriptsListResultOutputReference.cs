using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.DataCloudflarePageShieldScriptsList
{
    [JsiiClass(nativeType: typeof(cloudflare.DataCloudflarePageShieldScriptsList.DataCloudflarePageShieldScriptsListResultOutputReference), fullyQualifiedName: "cloudflare.dataCloudflarePageShieldScriptsList.DataCloudflarePageShieldScriptsListResultOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataCloudflarePageShieldScriptsListResultOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataCloudflarePageShieldScriptsListResultOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataCloudflarePageShieldScriptsListResultOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataCloudflarePageShieldScriptsListResultOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "addedAt", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AddedAt
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "cryptominingScore", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double CryptominingScore
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "dataflowScore", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double DataflowScore
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "domainReportedMalicious", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable DomainReportedMalicious
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "fetchedAt", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string FetchedAt
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "firstPageUrl", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string FirstPageUrl
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "firstSeenAt", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string FirstSeenAt
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "hash", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Hash
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "host", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Host
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "jsIntegrityScore", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double JsIntegrityScore
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "lastSeenAt", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LastSeenAt
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "magecartScore", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MagecartScore
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "maliciousDomainCategories", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] MaliciousDomainCategories
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "maliciousUrlCategories", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] MaliciousUrlCategories
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "malwareScore", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MalwareScore
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "obfuscationScore", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double ObfuscationScore
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "pageUrls", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] PageUrls
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "url", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Url
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "urlContainsCdnCgiPath", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable UrlContainsCdnCgiPath
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "urlReportedMalicious", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable UrlReportedMalicious
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"cloudflare.dataCloudflarePageShieldScriptsList.DataCloudflarePageShieldScriptsListResult\"}", isOptional: true)]
        public virtual cloudflare.DataCloudflarePageShieldScriptsList.IDataCloudflarePageShieldScriptsListResult? InternalValue
        {
            get => GetInstanceProperty<cloudflare.DataCloudflarePageShieldScriptsList.IDataCloudflarePageShieldScriptsListResult?>();
            set => SetInstanceProperty(value);
        }
    }
}

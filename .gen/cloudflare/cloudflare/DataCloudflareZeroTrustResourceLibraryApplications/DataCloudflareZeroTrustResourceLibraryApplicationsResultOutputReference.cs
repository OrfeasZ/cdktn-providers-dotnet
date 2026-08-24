using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.DataCloudflareZeroTrustResourceLibraryApplications
{
    [JsiiClass(nativeType: typeof(cloudflare.DataCloudflareZeroTrustResourceLibraryApplications.DataCloudflareZeroTrustResourceLibraryApplicationsResultOutputReference), fullyQualifiedName: "cloudflare.dataCloudflareZeroTrustResourceLibraryApplications.DataCloudflareZeroTrustResourceLibraryApplicationsResultOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataCloudflareZeroTrustResourceLibraryApplicationsResultOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataCloudflareZeroTrustResourceLibraryApplicationsResultOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataCloudflareZeroTrustResourceLibraryApplicationsResultOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataCloudflareZeroTrustResourceLibraryApplicationsResultOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "applicationConfidenceScore", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double ApplicationConfidenceScore
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "applicationScoreComposition", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ApplicationScoreComposition
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "applicationSource", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ApplicationSource
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "applicationType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ApplicationType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "applicationTypeDescription", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ApplicationTypeDescription
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "categoryId", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double CategoryId
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "createdAt", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CreatedAt
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "genAiScore", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double GenAiScore
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "hostnames", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] Hostnames
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "humanId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string HumanId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Id
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "ipSubnets", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] IpSubnets
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Name
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "portProtocols", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] PortProtocols
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "supportDomains", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] SupportDomains
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "supported", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] Supported
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "updatedAt", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string UpdatedAt
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "version", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Version
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareZeroTrustResourceLibraryApplications.DataCloudflareZeroTrustResourceLibraryApplicationsResult\"}", isOptional: true)]
        public virtual cloudflare.DataCloudflareZeroTrustResourceLibraryApplications.IDataCloudflareZeroTrustResourceLibraryApplicationsResult? InternalValue
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareZeroTrustResourceLibraryApplications.IDataCloudflareZeroTrustResourceLibraryApplicationsResult?>();
            set => SetInstanceProperty(value);
        }
    }
}

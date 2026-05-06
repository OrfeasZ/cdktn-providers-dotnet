using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.DataCloudflareSpectrumApplications
{
    [JsiiClass(nativeType: typeof(cloudflare.DataCloudflareSpectrumApplications.DataCloudflareSpectrumApplicationsResultOutputReference), fullyQualifiedName: "cloudflare.dataCloudflareSpectrumApplications.DataCloudflareSpectrumApplicationsResultOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataCloudflareSpectrumApplicationsResultOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataCloudflareSpectrumApplicationsResultOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataCloudflareSpectrumApplicationsResultOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataCloudflareSpectrumApplicationsResultOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "argoSmartRouting", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable ArgoSmartRouting
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "createdOn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CreatedOn
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "dns", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareSpectrumApplications.DataCloudflareSpectrumApplicationsResultDnsOutputReference\"}")]
        public virtual cloudflare.DataCloudflareSpectrumApplications.DataCloudflareSpectrumApplicationsResultDnsOutputReference Dns
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareSpectrumApplications.DataCloudflareSpectrumApplicationsResultDnsOutputReference>()!;
        }

        [JsiiProperty(name: "edgeIps", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareSpectrumApplications.DataCloudflareSpectrumApplicationsResultEdgeIpsOutputReference\"}")]
        public virtual cloudflare.DataCloudflareSpectrumApplications.DataCloudflareSpectrumApplicationsResultEdgeIpsOutputReference EdgeIps
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareSpectrumApplications.DataCloudflareSpectrumApplicationsResultEdgeIpsOutputReference>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "ipFirewall", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IpFirewall
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "modifiedOn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ModifiedOn
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "originDirect", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] OriginDirect
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "originDns", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareSpectrumApplications.DataCloudflareSpectrumApplicationsResultOriginDnsOutputReference\"}")]
        public virtual cloudflare.DataCloudflareSpectrumApplications.DataCloudflareSpectrumApplicationsResultOriginDnsOutputReference OriginDns
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareSpectrumApplications.DataCloudflareSpectrumApplicationsResultOriginDnsOutputReference>()!;
        }

        [JsiiProperty(name: "originPort", typeJson: "{\"fqn\":\"cdktn.AnyMap\"}")]
        public virtual Io.Cdktn.AnyMap OriginPort
        {
            get => GetInstanceProperty<Io.Cdktn.AnyMap>()!;
        }

        [JsiiProperty(name: "protocol", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Protocol
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "proxyProtocol", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ProxyProtocol
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "tls", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Tls
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "trafficType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TrafficType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareSpectrumApplications.DataCloudflareSpectrumApplicationsResult\"}", isOptional: true)]
        public virtual cloudflare.DataCloudflareSpectrumApplications.IDataCloudflareSpectrumApplicationsResult? InternalValue
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareSpectrumApplications.IDataCloudflareSpectrumApplicationsResult?>();
            set => SetInstanceProperty(value);
        }
    }
}

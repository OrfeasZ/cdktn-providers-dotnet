using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.DataCloudflareEmailRoutingDns
{
    [JsiiClass(nativeType: typeof(cloudflare.DataCloudflareEmailRoutingDns.DataCloudflareEmailRoutingDnsResultInfoOutputReference), fullyQualifiedName: "cloudflare.dataCloudflareEmailRoutingDns.DataCloudflareEmailRoutingDnsResultInfoOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class DataCloudflareEmailRoutingDnsResultInfoOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public DataCloudflareEmailRoutingDnsResultInfoOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected DataCloudflareEmailRoutingDnsResultInfoOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataCloudflareEmailRoutingDnsResultInfoOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "emailRoutingDnsCount", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double EmailRoutingDnsCount
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "page", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Page
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "perPage", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double PerPage
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "totalCount", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double TotalCount
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareEmailRoutingDns.DataCloudflareEmailRoutingDnsResultInfo\"}", isOptional: true)]
        public virtual cloudflare.DataCloudflareEmailRoutingDns.IDataCloudflareEmailRoutingDnsResultInfo? InternalValue
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareEmailRoutingDns.IDataCloudflareEmailRoutingDnsResultInfo?>();
            set => SetInstanceProperty(value);
        }
    }
}

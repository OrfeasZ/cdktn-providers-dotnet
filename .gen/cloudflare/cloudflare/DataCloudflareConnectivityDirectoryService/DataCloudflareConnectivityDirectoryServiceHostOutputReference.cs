using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.DataCloudflareConnectivityDirectoryService
{
    [JsiiClass(nativeType: typeof(cloudflare.DataCloudflareConnectivityDirectoryService.DataCloudflareConnectivityDirectoryServiceHostOutputReference), fullyQualifiedName: "cloudflare.dataCloudflareConnectivityDirectoryService.DataCloudflareConnectivityDirectoryServiceHostOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class DataCloudflareConnectivityDirectoryServiceHostOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public DataCloudflareConnectivityDirectoryServiceHostOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected DataCloudflareConnectivityDirectoryServiceHostOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataCloudflareConnectivityDirectoryServiceHostOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "hostname", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Hostname
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "ipv4", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Ipv4
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "ipv6", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Ipv6
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "network", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareConnectivityDirectoryService.DataCloudflareConnectivityDirectoryServiceHostNetworkOutputReference\"}")]
        public virtual cloudflare.DataCloudflareConnectivityDirectoryService.DataCloudflareConnectivityDirectoryServiceHostNetworkOutputReference Network
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareConnectivityDirectoryService.DataCloudflareConnectivityDirectoryServiceHostNetworkOutputReference>()!;
        }

        [JsiiProperty(name: "resolverNetwork", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareConnectivityDirectoryService.DataCloudflareConnectivityDirectoryServiceHostResolverNetworkOutputReference\"}")]
        public virtual cloudflare.DataCloudflareConnectivityDirectoryService.DataCloudflareConnectivityDirectoryServiceHostResolverNetworkOutputReference ResolverNetwork
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareConnectivityDirectoryService.DataCloudflareConnectivityDirectoryServiceHostResolverNetworkOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareConnectivityDirectoryService.DataCloudflareConnectivityDirectoryServiceHost\"}", isOptional: true)]
        public virtual cloudflare.DataCloudflareConnectivityDirectoryService.IDataCloudflareConnectivityDirectoryServiceHost? InternalValue
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareConnectivityDirectoryService.IDataCloudflareConnectivityDirectoryServiceHost?>();
            set => SetInstanceProperty(value);
        }
    }
}

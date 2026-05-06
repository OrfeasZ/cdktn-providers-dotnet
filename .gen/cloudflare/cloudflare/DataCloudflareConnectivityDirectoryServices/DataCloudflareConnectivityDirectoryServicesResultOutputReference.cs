using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.DataCloudflareConnectivityDirectoryServices
{
    [JsiiClass(nativeType: typeof(cloudflare.DataCloudflareConnectivityDirectoryServices.DataCloudflareConnectivityDirectoryServicesResultOutputReference), fullyQualifiedName: "cloudflare.dataCloudflareConnectivityDirectoryServices.DataCloudflareConnectivityDirectoryServicesResultOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataCloudflareConnectivityDirectoryServicesResultOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataCloudflareConnectivityDirectoryServicesResultOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataCloudflareConnectivityDirectoryServicesResultOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataCloudflareConnectivityDirectoryServicesResultOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "appProtocol", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AppProtocol
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "createdAt", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CreatedAt
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "host", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareConnectivityDirectoryServices.DataCloudflareConnectivityDirectoryServicesResultHostOutputReference\"}")]
        public virtual cloudflare.DataCloudflareConnectivityDirectoryServices.DataCloudflareConnectivityDirectoryServicesResultHostOutputReference Host
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareConnectivityDirectoryServices.DataCloudflareConnectivityDirectoryServicesResultHostOutputReference>()!;
        }

        [JsiiProperty(name: "httpPort", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double HttpPort
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "httpsPort", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double HttpsPort
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Name
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "serviceId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ServiceId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "tcpPort", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double TcpPort
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "tlsSettings", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareConnectivityDirectoryServices.DataCloudflareConnectivityDirectoryServicesResultTlsSettingsOutputReference\"}")]
        public virtual cloudflare.DataCloudflareConnectivityDirectoryServices.DataCloudflareConnectivityDirectoryServicesResultTlsSettingsOutputReference TlsSettings
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareConnectivityDirectoryServices.DataCloudflareConnectivityDirectoryServicesResultTlsSettingsOutputReference>()!;
        }

        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Type
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "updatedAt", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string UpdatedAt
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareConnectivityDirectoryServices.DataCloudflareConnectivityDirectoryServicesResult\"}", isOptional: true)]
        public virtual cloudflare.DataCloudflareConnectivityDirectoryServices.IDataCloudflareConnectivityDirectoryServicesResult? InternalValue
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareConnectivityDirectoryServices.IDataCloudflareConnectivityDirectoryServicesResult?>();
            set => SetInstanceProperty(value);
        }
    }
}

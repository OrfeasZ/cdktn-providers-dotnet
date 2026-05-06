using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciApmSyntheticsMonitor
{
    [JsiiClass(nativeType: typeof(oci.DataOciApmSyntheticsMonitor.DataOciApmSyntheticsMonitorConfigurationOutputReference), fullyQualifiedName: "oci.dataOciApmSyntheticsMonitor.DataOciApmSyntheticsMonitorConfigurationOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciApmSyntheticsMonitorConfigurationOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciApmSyntheticsMonitorConfigurationOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataOciApmSyntheticsMonitorConfigurationOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciApmSyntheticsMonitorConfigurationOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "clientCertificateDetails", typeJson: "{\"fqn\":\"oci.dataOciApmSyntheticsMonitor.DataOciApmSyntheticsMonitorConfigurationClientCertificateDetailsList\"}")]
        public virtual oci.DataOciApmSyntheticsMonitor.DataOciApmSyntheticsMonitorConfigurationClientCertificateDetailsList ClientCertificateDetails
        {
            get => GetInstanceProperty<oci.DataOciApmSyntheticsMonitor.DataOciApmSyntheticsMonitorConfigurationClientCertificateDetailsList>()!;
        }

        [JsiiProperty(name: "configType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ConfigType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "connectionString", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ConnectionString
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "databaseAuthenticationDetails", typeJson: "{\"fqn\":\"oci.dataOciApmSyntheticsMonitor.DataOciApmSyntheticsMonitorConfigurationDatabaseAuthenticationDetailsList\"}")]
        public virtual oci.DataOciApmSyntheticsMonitor.DataOciApmSyntheticsMonitorConfigurationDatabaseAuthenticationDetailsList DatabaseAuthenticationDetails
        {
            get => GetInstanceProperty<oci.DataOciApmSyntheticsMonitor.DataOciApmSyntheticsMonitorConfigurationDatabaseAuthenticationDetailsList>()!;
        }

        [JsiiProperty(name: "databaseConnectionType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DatabaseConnectionType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "databaseRole", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DatabaseRole
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "databaseType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DatabaseType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "databaseWalletDetails", typeJson: "{\"fqn\":\"oci.dataOciApmSyntheticsMonitor.DataOciApmSyntheticsMonitorConfigurationDatabaseWalletDetailsList\"}")]
        public virtual oci.DataOciApmSyntheticsMonitor.DataOciApmSyntheticsMonitorConfigurationDatabaseWalletDetailsList DatabaseWalletDetails
        {
            get => GetInstanceProperty<oci.DataOciApmSyntheticsMonitor.DataOciApmSyntheticsMonitorConfigurationDatabaseWalletDetailsList>()!;
        }

        [JsiiProperty(name: "dnsConfiguration", typeJson: "{\"fqn\":\"oci.dataOciApmSyntheticsMonitor.DataOciApmSyntheticsMonitorConfigurationDnsConfigurationList\"}")]
        public virtual oci.DataOciApmSyntheticsMonitor.DataOciApmSyntheticsMonitorConfigurationDnsConfigurationList DnsConfiguration
        {
            get => GetInstanceProperty<oci.DataOciApmSyntheticsMonitor.DataOciApmSyntheticsMonitorConfigurationDnsConfigurationList>()!;
        }

        [JsiiProperty(name: "downloadSizeLimitInBytes", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double DownloadSizeLimitInBytes
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "ftpBasicAuthenticationDetails", typeJson: "{\"fqn\":\"oci.dataOciApmSyntheticsMonitor.DataOciApmSyntheticsMonitorConfigurationFtpBasicAuthenticationDetailsList\"}")]
        public virtual oci.DataOciApmSyntheticsMonitor.DataOciApmSyntheticsMonitorConfigurationFtpBasicAuthenticationDetailsList FtpBasicAuthenticationDetails
        {
            get => GetInstanceProperty<oci.DataOciApmSyntheticsMonitor.DataOciApmSyntheticsMonitorConfigurationFtpBasicAuthenticationDetailsList>()!;
        }

        [JsiiProperty(name: "ftpProtocol", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string FtpProtocol
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "ftpRequestType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string FtpRequestType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "isActiveMode", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IsActiveMode
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "isCertificateValidationEnabled", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IsCertificateValidationEnabled
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "isDefaultSnapshotEnabled", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IsDefaultSnapshotEnabled
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "isFailureRetried", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IsFailureRetried
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "isQueryRecursive", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IsQueryRecursive
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "isRedirectionEnabled", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IsRedirectionEnabled
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "nameServer", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string NameServer
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "networkConfiguration", typeJson: "{\"fqn\":\"oci.dataOciApmSyntheticsMonitor.DataOciApmSyntheticsMonitorConfigurationNetworkConfigurationList\"}")]
        public virtual oci.DataOciApmSyntheticsMonitor.DataOciApmSyntheticsMonitorConfigurationNetworkConfigurationList NetworkConfiguration
        {
            get => GetInstanceProperty<oci.DataOciApmSyntheticsMonitor.DataOciApmSyntheticsMonitorConfigurationNetworkConfigurationList>()!;
        }

        [JsiiProperty(name: "protocol", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Protocol
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "query", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Query
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "recordType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RecordType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "reqAuthenticationDetails", typeJson: "{\"fqn\":\"oci.dataOciApmSyntheticsMonitor.DataOciApmSyntheticsMonitorConfigurationReqAuthenticationDetailsList\"}")]
        public virtual oci.DataOciApmSyntheticsMonitor.DataOciApmSyntheticsMonitorConfigurationReqAuthenticationDetailsList ReqAuthenticationDetails
        {
            get => GetInstanceProperty<oci.DataOciApmSyntheticsMonitor.DataOciApmSyntheticsMonitorConfigurationReqAuthenticationDetailsList>()!;
        }

        [JsiiProperty(name: "reqAuthenticationScheme", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ReqAuthenticationScheme
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "requestHeaders", typeJson: "{\"fqn\":\"oci.dataOciApmSyntheticsMonitor.DataOciApmSyntheticsMonitorConfigurationRequestHeadersList\"}")]
        public virtual oci.DataOciApmSyntheticsMonitor.DataOciApmSyntheticsMonitorConfigurationRequestHeadersList RequestHeaders
        {
            get => GetInstanceProperty<oci.DataOciApmSyntheticsMonitor.DataOciApmSyntheticsMonitorConfigurationRequestHeadersList>()!;
        }

        [JsiiProperty(name: "requestMethod", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RequestMethod
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "requestPostBody", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RequestPostBody
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "requestQueryParams", typeJson: "{\"fqn\":\"oci.dataOciApmSyntheticsMonitor.DataOciApmSyntheticsMonitorConfigurationRequestQueryParamsList\"}")]
        public virtual oci.DataOciApmSyntheticsMonitor.DataOciApmSyntheticsMonitorConfigurationRequestQueryParamsList RequestQueryParams
        {
            get => GetInstanceProperty<oci.DataOciApmSyntheticsMonitor.DataOciApmSyntheticsMonitorConfigurationRequestQueryParamsList>()!;
        }

        [JsiiProperty(name: "uploadFileSizeInBytes", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double UploadFileSizeInBytes
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "verifyResponseCodes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] VerifyResponseCodes
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "verifyResponseContent", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string VerifyResponseContent
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "verifyTexts", typeJson: "{\"fqn\":\"oci.dataOciApmSyntheticsMonitor.DataOciApmSyntheticsMonitorConfigurationVerifyTextsList\"}")]
        public virtual oci.DataOciApmSyntheticsMonitor.DataOciApmSyntheticsMonitorConfigurationVerifyTextsList VerifyTexts
        {
            get => GetInstanceProperty<oci.DataOciApmSyntheticsMonitor.DataOciApmSyntheticsMonitorConfigurationVerifyTextsList>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciApmSyntheticsMonitor.DataOciApmSyntheticsMonitorConfiguration\"}", isOptional: true)]
        public virtual oci.DataOciApmSyntheticsMonitor.IDataOciApmSyntheticsMonitorConfiguration? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciApmSyntheticsMonitor.IDataOciApmSyntheticsMonitorConfiguration?>();
            set => SetInstanceProperty(value);
        }
    }
}

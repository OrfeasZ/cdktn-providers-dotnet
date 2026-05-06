using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciApmSyntheticsMonitors
{
    [JsiiClass(nativeType: typeof(oci.DataOciApmSyntheticsMonitors.DataOciApmSyntheticsMonitorsMonitorCollectionItemsConfigurationOutputReference), fullyQualifiedName: "oci.dataOciApmSyntheticsMonitors.DataOciApmSyntheticsMonitorsMonitorCollectionItemsConfigurationOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciApmSyntheticsMonitorsMonitorCollectionItemsConfigurationOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciApmSyntheticsMonitorsMonitorCollectionItemsConfigurationOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataOciApmSyntheticsMonitorsMonitorCollectionItemsConfigurationOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciApmSyntheticsMonitorsMonitorCollectionItemsConfigurationOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "clientCertificateDetails", typeJson: "{\"fqn\":\"oci.dataOciApmSyntheticsMonitors.DataOciApmSyntheticsMonitorsMonitorCollectionItemsConfigurationClientCertificateDetailsList\"}")]
        public virtual oci.DataOciApmSyntheticsMonitors.DataOciApmSyntheticsMonitorsMonitorCollectionItemsConfigurationClientCertificateDetailsList ClientCertificateDetails
        {
            get => GetInstanceProperty<oci.DataOciApmSyntheticsMonitors.DataOciApmSyntheticsMonitorsMonitorCollectionItemsConfigurationClientCertificateDetailsList>()!;
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

        [JsiiProperty(name: "databaseAuthenticationDetails", typeJson: "{\"fqn\":\"oci.dataOciApmSyntheticsMonitors.DataOciApmSyntheticsMonitorsMonitorCollectionItemsConfigurationDatabaseAuthenticationDetailsList\"}")]
        public virtual oci.DataOciApmSyntheticsMonitors.DataOciApmSyntheticsMonitorsMonitorCollectionItemsConfigurationDatabaseAuthenticationDetailsList DatabaseAuthenticationDetails
        {
            get => GetInstanceProperty<oci.DataOciApmSyntheticsMonitors.DataOciApmSyntheticsMonitorsMonitorCollectionItemsConfigurationDatabaseAuthenticationDetailsList>()!;
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

        [JsiiProperty(name: "databaseWalletDetails", typeJson: "{\"fqn\":\"oci.dataOciApmSyntheticsMonitors.DataOciApmSyntheticsMonitorsMonitorCollectionItemsConfigurationDatabaseWalletDetailsList\"}")]
        public virtual oci.DataOciApmSyntheticsMonitors.DataOciApmSyntheticsMonitorsMonitorCollectionItemsConfigurationDatabaseWalletDetailsList DatabaseWalletDetails
        {
            get => GetInstanceProperty<oci.DataOciApmSyntheticsMonitors.DataOciApmSyntheticsMonitorsMonitorCollectionItemsConfigurationDatabaseWalletDetailsList>()!;
        }

        [JsiiProperty(name: "dnsConfiguration", typeJson: "{\"fqn\":\"oci.dataOciApmSyntheticsMonitors.DataOciApmSyntheticsMonitorsMonitorCollectionItemsConfigurationDnsConfigurationList\"}")]
        public virtual oci.DataOciApmSyntheticsMonitors.DataOciApmSyntheticsMonitorsMonitorCollectionItemsConfigurationDnsConfigurationList DnsConfiguration
        {
            get => GetInstanceProperty<oci.DataOciApmSyntheticsMonitors.DataOciApmSyntheticsMonitorsMonitorCollectionItemsConfigurationDnsConfigurationList>()!;
        }

        [JsiiProperty(name: "downloadSizeLimitInBytes", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double DownloadSizeLimitInBytes
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "ftpBasicAuthenticationDetails", typeJson: "{\"fqn\":\"oci.dataOciApmSyntheticsMonitors.DataOciApmSyntheticsMonitorsMonitorCollectionItemsConfigurationFtpBasicAuthenticationDetailsList\"}")]
        public virtual oci.DataOciApmSyntheticsMonitors.DataOciApmSyntheticsMonitorsMonitorCollectionItemsConfigurationFtpBasicAuthenticationDetailsList FtpBasicAuthenticationDetails
        {
            get => GetInstanceProperty<oci.DataOciApmSyntheticsMonitors.DataOciApmSyntheticsMonitorsMonitorCollectionItemsConfigurationFtpBasicAuthenticationDetailsList>()!;
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

        [JsiiProperty(name: "networkConfiguration", typeJson: "{\"fqn\":\"oci.dataOciApmSyntheticsMonitors.DataOciApmSyntheticsMonitorsMonitorCollectionItemsConfigurationNetworkConfigurationList\"}")]
        public virtual oci.DataOciApmSyntheticsMonitors.DataOciApmSyntheticsMonitorsMonitorCollectionItemsConfigurationNetworkConfigurationList NetworkConfiguration
        {
            get => GetInstanceProperty<oci.DataOciApmSyntheticsMonitors.DataOciApmSyntheticsMonitorsMonitorCollectionItemsConfigurationNetworkConfigurationList>()!;
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

        [JsiiProperty(name: "reqAuthenticationDetails", typeJson: "{\"fqn\":\"oci.dataOciApmSyntheticsMonitors.DataOciApmSyntheticsMonitorsMonitorCollectionItemsConfigurationReqAuthenticationDetailsList\"}")]
        public virtual oci.DataOciApmSyntheticsMonitors.DataOciApmSyntheticsMonitorsMonitorCollectionItemsConfigurationReqAuthenticationDetailsList ReqAuthenticationDetails
        {
            get => GetInstanceProperty<oci.DataOciApmSyntheticsMonitors.DataOciApmSyntheticsMonitorsMonitorCollectionItemsConfigurationReqAuthenticationDetailsList>()!;
        }

        [JsiiProperty(name: "reqAuthenticationScheme", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ReqAuthenticationScheme
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "requestHeaders", typeJson: "{\"fqn\":\"oci.dataOciApmSyntheticsMonitors.DataOciApmSyntheticsMonitorsMonitorCollectionItemsConfigurationRequestHeadersList\"}")]
        public virtual oci.DataOciApmSyntheticsMonitors.DataOciApmSyntheticsMonitorsMonitorCollectionItemsConfigurationRequestHeadersList RequestHeaders
        {
            get => GetInstanceProperty<oci.DataOciApmSyntheticsMonitors.DataOciApmSyntheticsMonitorsMonitorCollectionItemsConfigurationRequestHeadersList>()!;
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

        [JsiiProperty(name: "requestQueryParams", typeJson: "{\"fqn\":\"oci.dataOciApmSyntheticsMonitors.DataOciApmSyntheticsMonitorsMonitorCollectionItemsConfigurationRequestQueryParamsList\"}")]
        public virtual oci.DataOciApmSyntheticsMonitors.DataOciApmSyntheticsMonitorsMonitorCollectionItemsConfigurationRequestQueryParamsList RequestQueryParams
        {
            get => GetInstanceProperty<oci.DataOciApmSyntheticsMonitors.DataOciApmSyntheticsMonitorsMonitorCollectionItemsConfigurationRequestQueryParamsList>()!;
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

        [JsiiProperty(name: "verifyTexts", typeJson: "{\"fqn\":\"oci.dataOciApmSyntheticsMonitors.DataOciApmSyntheticsMonitorsMonitorCollectionItemsConfigurationVerifyTextsList\"}")]
        public virtual oci.DataOciApmSyntheticsMonitors.DataOciApmSyntheticsMonitorsMonitorCollectionItemsConfigurationVerifyTextsList VerifyTexts
        {
            get => GetInstanceProperty<oci.DataOciApmSyntheticsMonitors.DataOciApmSyntheticsMonitorsMonitorCollectionItemsConfigurationVerifyTextsList>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciApmSyntheticsMonitors.DataOciApmSyntheticsMonitorsMonitorCollectionItemsConfiguration\"}", isOptional: true)]
        public virtual oci.DataOciApmSyntheticsMonitors.IDataOciApmSyntheticsMonitorsMonitorCollectionItemsConfiguration? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciApmSyntheticsMonitors.IDataOciApmSyntheticsMonitorsMonitorCollectionItemsConfiguration?>();
            set => SetInstanceProperty(value);
        }
    }
}

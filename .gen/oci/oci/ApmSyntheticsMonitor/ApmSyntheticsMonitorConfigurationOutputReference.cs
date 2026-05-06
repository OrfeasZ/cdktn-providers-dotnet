using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.ApmSyntheticsMonitor
{
    [JsiiClass(nativeType: typeof(oci.ApmSyntheticsMonitor.ApmSyntheticsMonitorConfigurationOutputReference), fullyQualifiedName: "oci.apmSyntheticsMonitor.ApmSyntheticsMonitorConfigurationOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class ApmSyntheticsMonitorConfigurationOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public ApmSyntheticsMonitorConfigurationOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected ApmSyntheticsMonitorConfigurationOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected ApmSyntheticsMonitorConfigurationOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putClientCertificateDetails", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.apmSyntheticsMonitor.ApmSyntheticsMonitorConfigurationClientCertificateDetails\"}}]")]
        public virtual void PutClientCertificateDetails(oci.ApmSyntheticsMonitor.IApmSyntheticsMonitorConfigurationClientCertificateDetails @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.ApmSyntheticsMonitor.IApmSyntheticsMonitorConfigurationClientCertificateDetails)}, new object[]{@value});
        }

        [JsiiMethod(name: "putDatabaseAuthenticationDetails", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.apmSyntheticsMonitor.ApmSyntheticsMonitorConfigurationDatabaseAuthenticationDetails\"}}]")]
        public virtual void PutDatabaseAuthenticationDetails(oci.ApmSyntheticsMonitor.IApmSyntheticsMonitorConfigurationDatabaseAuthenticationDetails @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.ApmSyntheticsMonitor.IApmSyntheticsMonitorConfigurationDatabaseAuthenticationDetails)}, new object[]{@value});
        }

        [JsiiMethod(name: "putDatabaseWalletDetails", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.apmSyntheticsMonitor.ApmSyntheticsMonitorConfigurationDatabaseWalletDetails\"}}]")]
        public virtual void PutDatabaseWalletDetails(oci.ApmSyntheticsMonitor.IApmSyntheticsMonitorConfigurationDatabaseWalletDetails @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.ApmSyntheticsMonitor.IApmSyntheticsMonitorConfigurationDatabaseWalletDetails)}, new object[]{@value});
        }

        [JsiiMethod(name: "putDnsConfiguration", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.apmSyntheticsMonitor.ApmSyntheticsMonitorConfigurationDnsConfiguration\"}}]")]
        public virtual void PutDnsConfiguration(oci.ApmSyntheticsMonitor.IApmSyntheticsMonitorConfigurationDnsConfiguration @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.ApmSyntheticsMonitor.IApmSyntheticsMonitorConfigurationDnsConfiguration)}, new object[]{@value});
        }

        [JsiiMethod(name: "putFtpBasicAuthenticationDetails", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.apmSyntheticsMonitor.ApmSyntheticsMonitorConfigurationFtpBasicAuthenticationDetails\"}}]")]
        public virtual void PutFtpBasicAuthenticationDetails(oci.ApmSyntheticsMonitor.IApmSyntheticsMonitorConfigurationFtpBasicAuthenticationDetails @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.ApmSyntheticsMonitor.IApmSyntheticsMonitorConfigurationFtpBasicAuthenticationDetails)}, new object[]{@value});
        }

        [JsiiMethod(name: "putNetworkConfiguration", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.apmSyntheticsMonitor.ApmSyntheticsMonitorConfigurationNetworkConfiguration\"}}]")]
        public virtual void PutNetworkConfiguration(oci.ApmSyntheticsMonitor.IApmSyntheticsMonitorConfigurationNetworkConfiguration @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.ApmSyntheticsMonitor.IApmSyntheticsMonitorConfigurationNetworkConfiguration)}, new object[]{@value});
        }

        [JsiiMethod(name: "putReqAuthenticationDetails", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.apmSyntheticsMonitor.ApmSyntheticsMonitorConfigurationReqAuthenticationDetails\"}}]")]
        public virtual void PutReqAuthenticationDetails(oci.ApmSyntheticsMonitor.IApmSyntheticsMonitorConfigurationReqAuthenticationDetails @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.ApmSyntheticsMonitor.IApmSyntheticsMonitorConfigurationReqAuthenticationDetails)}, new object[]{@value});
        }

        [JsiiMethod(name: "putRequestHeaders", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.apmSyntheticsMonitor.ApmSyntheticsMonitorConfigurationRequestHeaders\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutRequestHeaders(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case oci.ApmSyntheticsMonitor.IApmSyntheticsMonitorConfigurationRequestHeaders[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.ApmSyntheticsMonitor.IApmSyntheticsMonitorConfigurationRequestHeaders).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.ApmSyntheticsMonitor.IApmSyntheticsMonitorConfigurationRequestHeaders).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putRequestQueryParams", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.apmSyntheticsMonitor.ApmSyntheticsMonitorConfigurationRequestQueryParams\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutRequestQueryParams(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case oci.ApmSyntheticsMonitor.IApmSyntheticsMonitorConfigurationRequestQueryParams[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.ApmSyntheticsMonitor.IApmSyntheticsMonitorConfigurationRequestQueryParams).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.ApmSyntheticsMonitor.IApmSyntheticsMonitorConfigurationRequestQueryParams).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putVerifyTexts", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.apmSyntheticsMonitor.ApmSyntheticsMonitorConfigurationVerifyTexts\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutVerifyTexts(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case oci.ApmSyntheticsMonitor.IApmSyntheticsMonitorConfigurationVerifyTexts[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.ApmSyntheticsMonitor.IApmSyntheticsMonitorConfigurationVerifyTexts).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.ApmSyntheticsMonitor.IApmSyntheticsMonitorConfigurationVerifyTexts).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetClientCertificateDetails")]
        public virtual void ResetClientCertificateDetails()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetConfigType")]
        public virtual void ResetConfigType()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetConnectionString")]
        public virtual void ResetConnectionString()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDatabaseAuthenticationDetails")]
        public virtual void ResetDatabaseAuthenticationDetails()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDatabaseConnectionType")]
        public virtual void ResetDatabaseConnectionType()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDatabaseRole")]
        public virtual void ResetDatabaseRole()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDatabaseType")]
        public virtual void ResetDatabaseType()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDatabaseWalletDetails")]
        public virtual void ResetDatabaseWalletDetails()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDnsConfiguration")]
        public virtual void ResetDnsConfiguration()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDownloadSizeLimitInBytes")]
        public virtual void ResetDownloadSizeLimitInBytes()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetFtpBasicAuthenticationDetails")]
        public virtual void ResetFtpBasicAuthenticationDetails()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetFtpProtocol")]
        public virtual void ResetFtpProtocol()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetFtpRequestType")]
        public virtual void ResetFtpRequestType()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetIsActiveMode")]
        public virtual void ResetIsActiveMode()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetIsCertificateValidationEnabled")]
        public virtual void ResetIsCertificateValidationEnabled()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetIsDefaultSnapshotEnabled")]
        public virtual void ResetIsDefaultSnapshotEnabled()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetIsFailureRetried")]
        public virtual void ResetIsFailureRetried()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetIsQueryRecursive")]
        public virtual void ResetIsQueryRecursive()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetIsRedirectionEnabled")]
        public virtual void ResetIsRedirectionEnabled()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetNameServer")]
        public virtual void ResetNameServer()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetNetworkConfiguration")]
        public virtual void ResetNetworkConfiguration()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetProtocol")]
        public virtual void ResetProtocol()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetQuery")]
        public virtual void ResetQuery()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRecordType")]
        public virtual void ResetRecordType()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetReqAuthenticationDetails")]
        public virtual void ResetReqAuthenticationDetails()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetReqAuthenticationScheme")]
        public virtual void ResetReqAuthenticationScheme()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRequestHeaders")]
        public virtual void ResetRequestHeaders()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRequestMethod")]
        public virtual void ResetRequestMethod()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRequestPostBody")]
        public virtual void ResetRequestPostBody()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRequestQueryParams")]
        public virtual void ResetRequestQueryParams()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetUploadFileSizeInBytes")]
        public virtual void ResetUploadFileSizeInBytes()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetVerifyResponseCodes")]
        public virtual void ResetVerifyResponseCodes()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetVerifyResponseContent")]
        public virtual void ResetVerifyResponseContent()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetVerifyTexts")]
        public virtual void ResetVerifyTexts()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "clientCertificateDetails", typeJson: "{\"fqn\":\"oci.apmSyntheticsMonitor.ApmSyntheticsMonitorConfigurationClientCertificateDetailsOutputReference\"}")]
        public virtual oci.ApmSyntheticsMonitor.ApmSyntheticsMonitorConfigurationClientCertificateDetailsOutputReference ClientCertificateDetails
        {
            get => GetInstanceProperty<oci.ApmSyntheticsMonitor.ApmSyntheticsMonitorConfigurationClientCertificateDetailsOutputReference>()!;
        }

        [JsiiProperty(name: "databaseAuthenticationDetails", typeJson: "{\"fqn\":\"oci.apmSyntheticsMonitor.ApmSyntheticsMonitorConfigurationDatabaseAuthenticationDetailsOutputReference\"}")]
        public virtual oci.ApmSyntheticsMonitor.ApmSyntheticsMonitorConfigurationDatabaseAuthenticationDetailsOutputReference DatabaseAuthenticationDetails
        {
            get => GetInstanceProperty<oci.ApmSyntheticsMonitor.ApmSyntheticsMonitorConfigurationDatabaseAuthenticationDetailsOutputReference>()!;
        }

        [JsiiProperty(name: "databaseWalletDetails", typeJson: "{\"fqn\":\"oci.apmSyntheticsMonitor.ApmSyntheticsMonitorConfigurationDatabaseWalletDetailsOutputReference\"}")]
        public virtual oci.ApmSyntheticsMonitor.ApmSyntheticsMonitorConfigurationDatabaseWalletDetailsOutputReference DatabaseWalletDetails
        {
            get => GetInstanceProperty<oci.ApmSyntheticsMonitor.ApmSyntheticsMonitorConfigurationDatabaseWalletDetailsOutputReference>()!;
        }

        [JsiiProperty(name: "dnsConfiguration", typeJson: "{\"fqn\":\"oci.apmSyntheticsMonitor.ApmSyntheticsMonitorConfigurationDnsConfigurationOutputReference\"}")]
        public virtual oci.ApmSyntheticsMonitor.ApmSyntheticsMonitorConfigurationDnsConfigurationOutputReference DnsConfiguration
        {
            get => GetInstanceProperty<oci.ApmSyntheticsMonitor.ApmSyntheticsMonitorConfigurationDnsConfigurationOutputReference>()!;
        }

        [JsiiProperty(name: "ftpBasicAuthenticationDetails", typeJson: "{\"fqn\":\"oci.apmSyntheticsMonitor.ApmSyntheticsMonitorConfigurationFtpBasicAuthenticationDetailsOutputReference\"}")]
        public virtual oci.ApmSyntheticsMonitor.ApmSyntheticsMonitorConfigurationFtpBasicAuthenticationDetailsOutputReference FtpBasicAuthenticationDetails
        {
            get => GetInstanceProperty<oci.ApmSyntheticsMonitor.ApmSyntheticsMonitorConfigurationFtpBasicAuthenticationDetailsOutputReference>()!;
        }

        [JsiiProperty(name: "networkConfiguration", typeJson: "{\"fqn\":\"oci.apmSyntheticsMonitor.ApmSyntheticsMonitorConfigurationNetworkConfigurationOutputReference\"}")]
        public virtual oci.ApmSyntheticsMonitor.ApmSyntheticsMonitorConfigurationNetworkConfigurationOutputReference NetworkConfiguration
        {
            get => GetInstanceProperty<oci.ApmSyntheticsMonitor.ApmSyntheticsMonitorConfigurationNetworkConfigurationOutputReference>()!;
        }

        [JsiiProperty(name: "reqAuthenticationDetails", typeJson: "{\"fqn\":\"oci.apmSyntheticsMonitor.ApmSyntheticsMonitorConfigurationReqAuthenticationDetailsOutputReference\"}")]
        public virtual oci.ApmSyntheticsMonitor.ApmSyntheticsMonitorConfigurationReqAuthenticationDetailsOutputReference ReqAuthenticationDetails
        {
            get => GetInstanceProperty<oci.ApmSyntheticsMonitor.ApmSyntheticsMonitorConfigurationReqAuthenticationDetailsOutputReference>()!;
        }

        [JsiiProperty(name: "requestHeaders", typeJson: "{\"fqn\":\"oci.apmSyntheticsMonitor.ApmSyntheticsMonitorConfigurationRequestHeadersList\"}")]
        public virtual oci.ApmSyntheticsMonitor.ApmSyntheticsMonitorConfigurationRequestHeadersList RequestHeaders
        {
            get => GetInstanceProperty<oci.ApmSyntheticsMonitor.ApmSyntheticsMonitorConfigurationRequestHeadersList>()!;
        }

        [JsiiProperty(name: "requestQueryParams", typeJson: "{\"fqn\":\"oci.apmSyntheticsMonitor.ApmSyntheticsMonitorConfigurationRequestQueryParamsList\"}")]
        public virtual oci.ApmSyntheticsMonitor.ApmSyntheticsMonitorConfigurationRequestQueryParamsList RequestQueryParams
        {
            get => GetInstanceProperty<oci.ApmSyntheticsMonitor.ApmSyntheticsMonitorConfigurationRequestQueryParamsList>()!;
        }

        [JsiiProperty(name: "verifyTexts", typeJson: "{\"fqn\":\"oci.apmSyntheticsMonitor.ApmSyntheticsMonitorConfigurationVerifyTextsList\"}")]
        public virtual oci.ApmSyntheticsMonitor.ApmSyntheticsMonitorConfigurationVerifyTextsList VerifyTexts
        {
            get => GetInstanceProperty<oci.ApmSyntheticsMonitor.ApmSyntheticsMonitorConfigurationVerifyTextsList>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "clientCertificateDetailsInput", typeJson: "{\"fqn\":\"oci.apmSyntheticsMonitor.ApmSyntheticsMonitorConfigurationClientCertificateDetails\"}", isOptional: true)]
        public virtual oci.ApmSyntheticsMonitor.IApmSyntheticsMonitorConfigurationClientCertificateDetails? ClientCertificateDetailsInput
        {
            get => GetInstanceProperty<oci.ApmSyntheticsMonitor.IApmSyntheticsMonitorConfigurationClientCertificateDetails?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "configTypeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ConfigTypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "connectionStringInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ConnectionStringInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "databaseAuthenticationDetailsInput", typeJson: "{\"fqn\":\"oci.apmSyntheticsMonitor.ApmSyntheticsMonitorConfigurationDatabaseAuthenticationDetails\"}", isOptional: true)]
        public virtual oci.ApmSyntheticsMonitor.IApmSyntheticsMonitorConfigurationDatabaseAuthenticationDetails? DatabaseAuthenticationDetailsInput
        {
            get => GetInstanceProperty<oci.ApmSyntheticsMonitor.IApmSyntheticsMonitorConfigurationDatabaseAuthenticationDetails?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "databaseConnectionTypeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DatabaseConnectionTypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "databaseRoleInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DatabaseRoleInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "databaseTypeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DatabaseTypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "databaseWalletDetailsInput", typeJson: "{\"fqn\":\"oci.apmSyntheticsMonitor.ApmSyntheticsMonitorConfigurationDatabaseWalletDetails\"}", isOptional: true)]
        public virtual oci.ApmSyntheticsMonitor.IApmSyntheticsMonitorConfigurationDatabaseWalletDetails? DatabaseWalletDetailsInput
        {
            get => GetInstanceProperty<oci.ApmSyntheticsMonitor.IApmSyntheticsMonitorConfigurationDatabaseWalletDetails?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "dnsConfigurationInput", typeJson: "{\"fqn\":\"oci.apmSyntheticsMonitor.ApmSyntheticsMonitorConfigurationDnsConfiguration\"}", isOptional: true)]
        public virtual oci.ApmSyntheticsMonitor.IApmSyntheticsMonitorConfigurationDnsConfiguration? DnsConfigurationInput
        {
            get => GetInstanceProperty<oci.ApmSyntheticsMonitor.IApmSyntheticsMonitorConfigurationDnsConfiguration?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "downloadSizeLimitInBytesInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? DownloadSizeLimitInBytesInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "ftpBasicAuthenticationDetailsInput", typeJson: "{\"fqn\":\"oci.apmSyntheticsMonitor.ApmSyntheticsMonitorConfigurationFtpBasicAuthenticationDetails\"}", isOptional: true)]
        public virtual oci.ApmSyntheticsMonitor.IApmSyntheticsMonitorConfigurationFtpBasicAuthenticationDetails? FtpBasicAuthenticationDetailsInput
        {
            get => GetInstanceProperty<oci.ApmSyntheticsMonitor.IApmSyntheticsMonitorConfigurationFtpBasicAuthenticationDetails?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "ftpProtocolInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? FtpProtocolInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "ftpRequestTypeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? FtpRequestTypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "isActiveModeInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public virtual object? IsActiveModeInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "isCertificateValidationEnabledInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public virtual object? IsCertificateValidationEnabledInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "isDefaultSnapshotEnabledInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public virtual object? IsDefaultSnapshotEnabledInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "isFailureRetriedInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public virtual object? IsFailureRetriedInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "isQueryRecursiveInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public virtual object? IsQueryRecursiveInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "isRedirectionEnabledInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public virtual object? IsRedirectionEnabledInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "nameServerInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? NameServerInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "networkConfigurationInput", typeJson: "{\"fqn\":\"oci.apmSyntheticsMonitor.ApmSyntheticsMonitorConfigurationNetworkConfiguration\"}", isOptional: true)]
        public virtual oci.ApmSyntheticsMonitor.IApmSyntheticsMonitorConfigurationNetworkConfiguration? NetworkConfigurationInput
        {
            get => GetInstanceProperty<oci.ApmSyntheticsMonitor.IApmSyntheticsMonitorConfigurationNetworkConfiguration?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "protocolInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ProtocolInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "queryInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? QueryInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "recordTypeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? RecordTypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "reqAuthenticationDetailsInput", typeJson: "{\"fqn\":\"oci.apmSyntheticsMonitor.ApmSyntheticsMonitorConfigurationReqAuthenticationDetails\"}", isOptional: true)]
        public virtual oci.ApmSyntheticsMonitor.IApmSyntheticsMonitorConfigurationReqAuthenticationDetails? ReqAuthenticationDetailsInput
        {
            get => GetInstanceProperty<oci.ApmSyntheticsMonitor.IApmSyntheticsMonitorConfigurationReqAuthenticationDetails?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "reqAuthenticationSchemeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ReqAuthenticationSchemeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "requestHeadersInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.apmSyntheticsMonitor.ApmSyntheticsMonitorConfigurationRequestHeaders\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? RequestHeadersInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "requestMethodInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? RequestMethodInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "requestPostBodyInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? RequestPostBodyInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "requestQueryParamsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.apmSyntheticsMonitor.ApmSyntheticsMonitorConfigurationRequestQueryParams\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? RequestQueryParamsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "uploadFileSizeInBytesInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? UploadFileSizeInBytesInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "verifyResponseCodesInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? VerifyResponseCodesInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "verifyResponseContentInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? VerifyResponseContentInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "verifyTextsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.apmSyntheticsMonitor.ApmSyntheticsMonitorConfigurationVerifyTexts\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? VerifyTextsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiProperty(name: "configType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ConfigType
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "connectionString", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ConnectionString
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "databaseConnectionType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DatabaseConnectionType
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "databaseRole", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DatabaseRole
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "databaseType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DatabaseType
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "downloadSizeLimitInBytes", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double DownloadSizeLimitInBytes
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "ftpProtocol", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string FtpProtocol
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "ftpRequestType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string FtpRequestType
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "isActiveMode", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        public virtual object IsActiveMode
        {
            get => GetInstanceProperty<object>()!;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case bool cast_cd4240:
                            break;
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received null", nameof(value));
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }

        [JsiiProperty(name: "isCertificateValidationEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        public virtual object IsCertificateValidationEnabled
        {
            get => GetInstanceProperty<object>()!;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case bool cast_cd4240:
                            break;
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received null", nameof(value));
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }

        [JsiiProperty(name: "isDefaultSnapshotEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        public virtual object IsDefaultSnapshotEnabled
        {
            get => GetInstanceProperty<object>()!;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case bool cast_cd4240:
                            break;
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received null", nameof(value));
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }

        [JsiiProperty(name: "isFailureRetried", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        public virtual object IsFailureRetried
        {
            get => GetInstanceProperty<object>()!;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case bool cast_cd4240:
                            break;
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received null", nameof(value));
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }

        [JsiiProperty(name: "isQueryRecursive", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        public virtual object IsQueryRecursive
        {
            get => GetInstanceProperty<object>()!;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case bool cast_cd4240:
                            break;
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received null", nameof(value));
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }

        [JsiiProperty(name: "isRedirectionEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        public virtual object IsRedirectionEnabled
        {
            get => GetInstanceProperty<object>()!;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case bool cast_cd4240:
                            break;
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received null", nameof(value));
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }

        [JsiiProperty(name: "nameServer", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string NameServer
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "protocol", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Protocol
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "query", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Query
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "recordType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RecordType
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "reqAuthenticationScheme", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ReqAuthenticationScheme
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "requestMethod", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RequestMethod
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "requestPostBody", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RequestPostBody
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "uploadFileSizeInBytes", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double UploadFileSizeInBytes
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "verifyResponseCodes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] VerifyResponseCodes
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "verifyResponseContent", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string VerifyResponseContent
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.apmSyntheticsMonitor.ApmSyntheticsMonitorConfiguration\"}", isOptional: true)]
        public virtual oci.ApmSyntheticsMonitor.IApmSyntheticsMonitorConfiguration? InternalValue
        {
            get => GetInstanceProperty<oci.ApmSyntheticsMonitor.IApmSyntheticsMonitorConfiguration?>();
            set => SetInstanceProperty(value);
        }
    }
}

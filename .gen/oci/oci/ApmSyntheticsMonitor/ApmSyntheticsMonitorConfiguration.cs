using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.ApmSyntheticsMonitor
{
    [JsiiByValue(fqn: "oci.apmSyntheticsMonitor.ApmSyntheticsMonitorConfiguration")]
    public class ApmSyntheticsMonitorConfiguration : oci.ApmSyntheticsMonitor.IApmSyntheticsMonitorConfiguration
    {
        /// <summary>client_certificate_details block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/apm_synthetics_monitor#client_certificate_details ApmSyntheticsMonitor#client_certificate_details}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "clientCertificateDetails", typeJson: "{\"fqn\":\"oci.apmSyntheticsMonitor.ApmSyntheticsMonitorConfigurationClientCertificateDetails\"}", isOptional: true)]
        public oci.ApmSyntheticsMonitor.IApmSyntheticsMonitorConfigurationClientCertificateDetails? ClientCertificateDetails
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/apm_synthetics_monitor#config_type ApmSyntheticsMonitor#config_type}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "configType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ConfigType
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/apm_synthetics_monitor#connection_string ApmSyntheticsMonitor#connection_string}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "connectionString", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ConnectionString
        {
            get;
            set;
        }

        /// <summary>database_authentication_details block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/apm_synthetics_monitor#database_authentication_details ApmSyntheticsMonitor#database_authentication_details}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "databaseAuthenticationDetails", typeJson: "{\"fqn\":\"oci.apmSyntheticsMonitor.ApmSyntheticsMonitorConfigurationDatabaseAuthenticationDetails\"}", isOptional: true)]
        public oci.ApmSyntheticsMonitor.IApmSyntheticsMonitorConfigurationDatabaseAuthenticationDetails? DatabaseAuthenticationDetails
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/apm_synthetics_monitor#database_connection_type ApmSyntheticsMonitor#database_connection_type}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "databaseConnectionType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? DatabaseConnectionType
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/apm_synthetics_monitor#database_role ApmSyntheticsMonitor#database_role}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "databaseRole", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? DatabaseRole
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/apm_synthetics_monitor#database_type ApmSyntheticsMonitor#database_type}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "databaseType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? DatabaseType
        {
            get;
            set;
        }

        /// <summary>database_wallet_details block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/apm_synthetics_monitor#database_wallet_details ApmSyntheticsMonitor#database_wallet_details}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "databaseWalletDetails", typeJson: "{\"fqn\":\"oci.apmSyntheticsMonitor.ApmSyntheticsMonitorConfigurationDatabaseWalletDetails\"}", isOptional: true)]
        public oci.ApmSyntheticsMonitor.IApmSyntheticsMonitorConfigurationDatabaseWalletDetails? DatabaseWalletDetails
        {
            get;
            set;
        }

        /// <summary>dns_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/apm_synthetics_monitor#dns_configuration ApmSyntheticsMonitor#dns_configuration}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "dnsConfiguration", typeJson: "{\"fqn\":\"oci.apmSyntheticsMonitor.ApmSyntheticsMonitorConfigurationDnsConfiguration\"}", isOptional: true)]
        public oci.ApmSyntheticsMonitor.IApmSyntheticsMonitorConfigurationDnsConfiguration? DnsConfiguration
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/apm_synthetics_monitor#download_size_limit_in_bytes ApmSyntheticsMonitor#download_size_limit_in_bytes}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "downloadSizeLimitInBytes", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? DownloadSizeLimitInBytes
        {
            get;
            set;
        }

        /// <summary>ftp_basic_authentication_details block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/apm_synthetics_monitor#ftp_basic_authentication_details ApmSyntheticsMonitor#ftp_basic_authentication_details}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "ftpBasicAuthenticationDetails", typeJson: "{\"fqn\":\"oci.apmSyntheticsMonitor.ApmSyntheticsMonitorConfigurationFtpBasicAuthenticationDetails\"}", isOptional: true)]
        public oci.ApmSyntheticsMonitor.IApmSyntheticsMonitorConfigurationFtpBasicAuthenticationDetails? FtpBasicAuthenticationDetails
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/apm_synthetics_monitor#ftp_protocol ApmSyntheticsMonitor#ftp_protocol}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "ftpProtocol", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? FtpProtocol
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/apm_synthetics_monitor#ftp_request_type ApmSyntheticsMonitor#ftp_request_type}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "ftpRequestType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? FtpRequestType
        {
            get;
            set;
        }

        private object? _isActiveMode;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/apm_synthetics_monitor#is_active_mode ApmSyntheticsMonitor#is_active_mode}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "isActiveMode", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? IsActiveMode
        {
            get => _isActiveMode;
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
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _isActiveMode = value;
            }
        }

        private object? _isCertificateValidationEnabled;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/apm_synthetics_monitor#is_certificate_validation_enabled ApmSyntheticsMonitor#is_certificate_validation_enabled}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "isCertificateValidationEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? IsCertificateValidationEnabled
        {
            get => _isCertificateValidationEnabled;
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
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _isCertificateValidationEnabled = value;
            }
        }

        private object? _isDefaultSnapshotEnabled;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/apm_synthetics_monitor#is_default_snapshot_enabled ApmSyntheticsMonitor#is_default_snapshot_enabled}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "isDefaultSnapshotEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? IsDefaultSnapshotEnabled
        {
            get => _isDefaultSnapshotEnabled;
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
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _isDefaultSnapshotEnabled = value;
            }
        }

        private object? _isFailureRetried;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/apm_synthetics_monitor#is_failure_retried ApmSyntheticsMonitor#is_failure_retried}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "isFailureRetried", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? IsFailureRetried
        {
            get => _isFailureRetried;
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
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _isFailureRetried = value;
            }
        }

        private object? _isQueryRecursive;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/apm_synthetics_monitor#is_query_recursive ApmSyntheticsMonitor#is_query_recursive}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "isQueryRecursive", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? IsQueryRecursive
        {
            get => _isQueryRecursive;
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
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _isQueryRecursive = value;
            }
        }

        private object? _isRedirectionEnabled;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/apm_synthetics_monitor#is_redirection_enabled ApmSyntheticsMonitor#is_redirection_enabled}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "isRedirectionEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? IsRedirectionEnabled
        {
            get => _isRedirectionEnabled;
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
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _isRedirectionEnabled = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/apm_synthetics_monitor#name_server ApmSyntheticsMonitor#name_server}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "nameServer", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? NameServer
        {
            get;
            set;
        }

        /// <summary>network_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/apm_synthetics_monitor#network_configuration ApmSyntheticsMonitor#network_configuration}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "networkConfiguration", typeJson: "{\"fqn\":\"oci.apmSyntheticsMonitor.ApmSyntheticsMonitorConfigurationNetworkConfiguration\"}", isOptional: true)]
        public oci.ApmSyntheticsMonitor.IApmSyntheticsMonitorConfigurationNetworkConfiguration? NetworkConfiguration
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/apm_synthetics_monitor#protocol ApmSyntheticsMonitor#protocol}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "protocol", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Protocol
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/apm_synthetics_monitor#query ApmSyntheticsMonitor#query}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "query", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Query
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/apm_synthetics_monitor#record_type ApmSyntheticsMonitor#record_type}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "recordType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? RecordType
        {
            get;
            set;
        }

        /// <summary>req_authentication_details block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/apm_synthetics_monitor#req_authentication_details ApmSyntheticsMonitor#req_authentication_details}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "reqAuthenticationDetails", typeJson: "{\"fqn\":\"oci.apmSyntheticsMonitor.ApmSyntheticsMonitorConfigurationReqAuthenticationDetails\"}", isOptional: true)]
        public oci.ApmSyntheticsMonitor.IApmSyntheticsMonitorConfigurationReqAuthenticationDetails? ReqAuthenticationDetails
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/apm_synthetics_monitor#req_authentication_scheme ApmSyntheticsMonitor#req_authentication_scheme}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "reqAuthenticationScheme", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ReqAuthenticationScheme
        {
            get;
            set;
        }

        private object? _requestHeaders;

        /// <summary>request_headers block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/apm_synthetics_monitor#request_headers ApmSyntheticsMonitor#request_headers}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "requestHeaders", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.apmSyntheticsMonitor.ApmSyntheticsMonitorConfigurationRequestHeaders\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? RequestHeaders
        {
            get => _requestHeaders;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case oci.ApmSyntheticsMonitor.IApmSyntheticsMonitorConfigurationRequestHeaders[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.ApmSyntheticsMonitor.IApmSyntheticsMonitorConfigurationRequestHeaders).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _requestHeaders = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/apm_synthetics_monitor#request_method ApmSyntheticsMonitor#request_method}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "requestMethod", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? RequestMethod
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/apm_synthetics_monitor#request_post_body ApmSyntheticsMonitor#request_post_body}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "requestPostBody", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? RequestPostBody
        {
            get;
            set;
        }

        private object? _requestQueryParams;

        /// <summary>request_query_params block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/apm_synthetics_monitor#request_query_params ApmSyntheticsMonitor#request_query_params}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "requestQueryParams", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.apmSyntheticsMonitor.ApmSyntheticsMonitorConfigurationRequestQueryParams\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? RequestQueryParams
        {
            get => _requestQueryParams;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case oci.ApmSyntheticsMonitor.IApmSyntheticsMonitorConfigurationRequestQueryParams[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.ApmSyntheticsMonitor.IApmSyntheticsMonitorConfigurationRequestQueryParams).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _requestQueryParams = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/apm_synthetics_monitor#upload_file_size_in_bytes ApmSyntheticsMonitor#upload_file_size_in_bytes}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "uploadFileSizeInBytes", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? UploadFileSizeInBytes
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/apm_synthetics_monitor#verify_response_codes ApmSyntheticsMonitor#verify_response_codes}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "verifyResponseCodes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? VerifyResponseCodes
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/apm_synthetics_monitor#verify_response_content ApmSyntheticsMonitor#verify_response_content}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "verifyResponseContent", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? VerifyResponseContent
        {
            get;
            set;
        }

        private object? _verifyTexts;

        /// <summary>verify_texts block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/apm_synthetics_monitor#verify_texts ApmSyntheticsMonitor#verify_texts}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "verifyTexts", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.apmSyntheticsMonitor.ApmSyntheticsMonitorConfigurationVerifyTexts\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? VerifyTexts
        {
            get => _verifyTexts;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case oci.ApmSyntheticsMonitor.IApmSyntheticsMonitorConfigurationVerifyTexts[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.ApmSyntheticsMonitor.IApmSyntheticsMonitorConfigurationVerifyTexts).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _verifyTexts = value;
            }
        }
    }
}

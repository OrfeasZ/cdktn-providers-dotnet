using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace acme.Certificate
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "acme.certificate.CertificateConfig")]
    public class CertificateConfig : acme.Certificate.ICertificateConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/vancluever/acme/2.47.0/docs/resources/certificate#account_key_pem Certificate#account_key_pem}.</summary>
        [JsiiProperty(name: "accountKeyPem", typeJson: "{\"primitive\":\"string\"}")]
        public string AccountKeyPem
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/vancluever/acme/2.47.0/docs/resources/certificate#certificate_p12_password Certificate#certificate_p12_password}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "certificateP12Password", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? CertificateP12Password
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/vancluever/acme/2.47.0/docs/resources/certificate#certificate_request_pem Certificate#certificate_request_pem}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "certificateRequestPem", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? CertificateRequestPem
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/vancluever/acme/2.47.0/docs/resources/certificate#cert_timeout Certificate#cert_timeout}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "certTimeout", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? CertTimeout
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/vancluever/acme/2.47.0/docs/resources/certificate#common_name Certificate#common_name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "commonName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? CommonName
        {
            get;
            set;
        }

        private object? _deactivateAuthorizations;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/vancluever/acme/2.47.0/docs/resources/certificate#deactivate_authorizations Certificate#deactivate_authorizations}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "deactivateAuthorizations", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? DeactivateAuthorizations
        {
            get => _deactivateAuthorizations;
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
                _deactivateAuthorizations = value;
            }
        }

        private object? _disableCompletePropagation;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/vancluever/acme/2.47.0/docs/resources/certificate#disable_complete_propagation Certificate#disable_complete_propagation}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "disableCompletePropagation", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? DisableCompletePropagation
        {
            get => _disableCompletePropagation;
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
                _disableCompletePropagation = value;
            }
        }

        private object? _dnsChallenge;

        /// <summary>dns_challenge block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/vancluever/acme/2.47.0/docs/resources/certificate#dns_challenge Certificate#dns_challenge}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "dnsChallenge", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"acme.certificate.CertificateDnsChallenge\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? DnsChallenge
        {
            get => _dnsChallenge;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case acme.Certificate.ICertificateDnsChallenge[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(acme.Certificate.ICertificateDnsChallenge).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _dnsChallenge = value;
            }
        }

        /// <summary>http_challenge block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/vancluever/acme/2.47.0/docs/resources/certificate#http_challenge Certificate#http_challenge}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "httpChallenge", typeJson: "{\"fqn\":\"acme.certificate.CertificateHttpChallenge\"}", isOptional: true)]
        public acme.Certificate.ICertificateHttpChallenge? HttpChallenge
        {
            get;
            set;
        }

        /// <summary>http_memcached_challenge block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/vancluever/acme/2.47.0/docs/resources/certificate#http_memcached_challenge Certificate#http_memcached_challenge}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "httpMemcachedChallenge", typeJson: "{\"fqn\":\"acme.certificate.CertificateHttpMemcachedChallenge\"}", isOptional: true)]
        public acme.Certificate.ICertificateHttpMemcachedChallenge? HttpMemcachedChallenge
        {
            get;
            set;
        }

        /// <summary>http_s3_challenge block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/vancluever/acme/2.47.0/docs/resources/certificate#http_s3_challenge Certificate#http_s3_challenge}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "httpS3Challenge", typeJson: "{\"fqn\":\"acme.certificate.CertificateHttpS3Challenge\"}", isOptional: true)]
        public acme.Certificate.ICertificateHttpS3Challenge? HttpS3Challenge
        {
            get;
            set;
        }

        /// <summary>http_webroot_challenge block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/vancluever/acme/2.47.0/docs/resources/certificate#http_webroot_challenge Certificate#http_webroot_challenge}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "httpWebrootChallenge", typeJson: "{\"fqn\":\"acme.certificate.CertificateHttpWebrootChallenge\"}", isOptional: true)]
        public acme.Certificate.ICertificateHttpWebrootChallenge? HttpWebrootChallenge
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/vancluever/acme/2.47.0/docs/resources/certificate#id Certificate#id}.</summary>
        /// <remarks>
        /// Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2.
        /// If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Id
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/vancluever/acme/2.47.0/docs/resources/certificate#key_type Certificate#key_type}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "keyType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? KeyType
        {
            get;
            set;
        }

        private object? _minDaysDynamic;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/vancluever/acme/2.47.0/docs/resources/certificate#min_days_dynamic Certificate#min_days_dynamic}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "minDaysDynamic", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? MinDaysDynamic
        {
            get => _minDaysDynamic;
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
                _minDaysDynamic = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/vancluever/acme/2.47.0/docs/resources/certificate#min_days_remaining Certificate#min_days_remaining}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "minDaysRemaining", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? MinDaysRemaining
        {
            get;
            set;
        }

        private object? _mustStaple;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/vancluever/acme/2.47.0/docs/resources/certificate#must_staple Certificate#must_staple}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "mustStaple", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? MustStaple
        {
            get => _mustStaple;
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
                _mustStaple = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/vancluever/acme/2.47.0/docs/resources/certificate#pre_check_delay Certificate#pre_check_delay}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "preCheckDelay", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? PreCheckDelay
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/vancluever/acme/2.47.0/docs/resources/certificate#preferred_chain Certificate#preferred_chain}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "preferredChain", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? PreferredChain
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/vancluever/acme/2.47.0/docs/resources/certificate#profile Certificate#profile}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "profile", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Profile
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/vancluever/acme/2.47.0/docs/resources/certificate#propagation_wait Certificate#propagation_wait}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "propagationWait", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? PropagationWait
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/vancluever/acme/2.47.0/docs/resources/certificate#recursive_nameservers Certificate#recursive_nameservers}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "recursiveNameservers", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? RecursiveNameservers
        {
            get;
            set;
        }

        private object? _renewalInfoIgnoreRetryAfter;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/vancluever/acme/2.47.0/docs/resources/certificate#renewal_info_ignore_retry_after Certificate#renewal_info_ignore_retry_after}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "renewalInfoIgnoreRetryAfter", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? RenewalInfoIgnoreRetryAfter
        {
            get => _renewalInfoIgnoreRetryAfter;
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
                _renewalInfoIgnoreRetryAfter = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/vancluever/acme/2.47.0/docs/resources/certificate#renewal_info_max_sleep Certificate#renewal_info_max_sleep}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "renewalInfoMaxSleep", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? RenewalInfoMaxSleep
        {
            get;
            set;
        }

        private object? _revokeCertificateOnDestroy;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/vancluever/acme/2.47.0/docs/resources/certificate#revoke_certificate_on_destroy Certificate#revoke_certificate_on_destroy}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "revokeCertificateOnDestroy", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? RevokeCertificateOnDestroy
        {
            get => _revokeCertificateOnDestroy;
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
                _revokeCertificateOnDestroy = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/vancluever/acme/2.47.0/docs/resources/certificate#revoke_certificate_reason Certificate#revoke_certificate_reason}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "revokeCertificateReason", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? RevokeCertificateReason
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/vancluever/acme/2.47.0/docs/resources/certificate#subject_alternative_names Certificate#subject_alternative_names}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "subjectAlternativeNames", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? SubjectAlternativeNames
        {
            get;
            set;
        }

        /// <summary>tls_challenge block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/vancluever/acme/2.47.0/docs/resources/certificate#tls_challenge Certificate#tls_challenge}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "tlsChallenge", typeJson: "{\"fqn\":\"acme.certificate.CertificateTlsChallenge\"}", isOptional: true)]
        public acme.Certificate.ICertificateTlsChallenge? TlsChallenge
        {
            get;
            set;
        }

        private object? _useRenewalInfo;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/vancluever/acme/2.47.0/docs/resources/certificate#use_renewal_info Certificate#use_renewal_info}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "useRenewalInfo", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? UseRenewalInfo
        {
            get => _useRenewalInfo;
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
                _useRenewalInfo = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/vancluever/acme/2.47.0/docs/resources/certificate#validity_days Certificate#validity_days}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "validityDays", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? ValidityDays
        {
            get;
            set;
        }

        private object? _connection;

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "connection", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.SSHProvisionerConnection\"},{\"fqn\":\"cdktn.WinrmProvisionerConnection\"}]}}", isOptional: true)]
        public object? Connection
        {
            get => _connection;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.ISSHProvisionerConnection cast_cd4240:
                            break;
                        case Io.Cdktn.IWinrmProvisionerConnection cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.ISSHProvisionerConnection).FullName}, {typeof(Io.Cdktn.IWinrmProvisionerConnection).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _connection = value;
            }
        }

        private object? _count;

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "count", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"number\"},{\"fqn\":\"cdktn.TerraformCount\"}]}}", isOptional: true)]
        public object? Count
        {
            get => _count;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case double cast_cd4240:
                            break;
                        case byte cast_cd4240:
                            break;
                        case decimal cast_cd4240:
                            break;
                        case float cast_cd4240:
                            break;
                        case int cast_cd4240:
                            break;
                        case long cast_cd4240:
                            break;
                        case sbyte cast_cd4240:
                            break;
                        case short cast_cd4240:
                            break;
                        case uint cast_cd4240:
                            break;
                        case ulong cast_cd4240:
                            break;
                        case ushort cast_cd4240:
                            break;
                        case Io.Cdktn.TerraformCount cast_cd4240:
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: double, {typeof(Io.Cdktn.TerraformCount).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _count = value;
            }
        }

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "dependsOn", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"cdktn.ITerraformDependable\"},\"kind\":\"array\"}}", isOptional: true)]
        public Io.Cdktn.ITerraformDependable[]? DependsOn
        {
            get;
            set;
        }

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "forEach", typeJson: "{\"fqn\":\"cdktn.ITerraformIterator\"}", isOptional: true)]
        public Io.Cdktn.ITerraformIterator? ForEach
        {
            get;
            set;
        }

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "lifecycle", typeJson: "{\"fqn\":\"cdktn.TerraformResourceLifecycle\"}", isOptional: true)]
        public Io.Cdktn.ITerraformResourceLifecycle? Lifecycle
        {
            get;
            set;
        }

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "provider", typeJson: "{\"fqn\":\"cdktn.TerraformProvider\"}", isOptional: true)]
        public Io.Cdktn.TerraformProvider? Provider
        {
            get;
            set;
        }

        private object[]? _provisioners;

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "provisioners", typeJson: "{\"collection\":{\"elementtype\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.FileProvisioner\"},{\"fqn\":\"cdktn.LocalExecProvisioner\"},{\"fqn\":\"cdktn.RemoteExecProvisioner\"}]}},\"kind\":\"array\"}}", isOptional: true)]
        public object[]? Provisioners
        {
            get => _provisioners;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    for (var __idx_cd4240 = 0 ; __idx_cd4240 < value.Length ; __idx_cd4240++)
                    {
                        switch (value[__idx_cd4240])
                        {
                            case Io.Cdktn.IFileProvisioner cast_e9c63e:
                                break;
                            case Io.Cdktn.ILocalExecProvisioner cast_e9c63e:
                                break;
                            case Io.Cdktn.IRemoteExecProvisioner cast_e9c63e:
                                break;
                            case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_e9c63e:
                                // Not enough information to type-check...
                                break;
                            case null:
                                throw new System.ArgumentException($"Expected {nameof(value)}[{__idx_cd4240}] to be one of: {typeof(Io.Cdktn.IFileProvisioner).FullName}, {typeof(Io.Cdktn.ILocalExecProvisioner).FullName}, {typeof(Io.Cdktn.IRemoteExecProvisioner).FullName}; received null", nameof(value));
                            default:
                                throw new System.ArgumentException($"Expected {nameof(value)}[{__idx_cd4240}] to be one of: {typeof(Io.Cdktn.IFileProvisioner).FullName}, {typeof(Io.Cdktn.ILocalExecProvisioner).FullName}, {typeof(Io.Cdktn.IRemoteExecProvisioner).FullName}; received {value[__idx_cd4240].GetType().FullName}", nameof(value));
                        }
                    }
                }
                _provisioners = value;
            }
        }
    }
}

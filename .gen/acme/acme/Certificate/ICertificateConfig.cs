using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace acme.Certificate
{
    [JsiiInterface(nativeType: typeof(ICertificateConfig), fullyQualifiedName: "acme.certificate.CertificateConfig")]
    public interface ICertificateConfig : Io.Cdktn.ITerraformMetaArguments
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/vancluever/acme/2.48.0/docs/resources/certificate#account_key_pem Certificate#account_key_pem}.</summary>
        [JsiiProperty(name: "accountKeyPem", typeJson: "{\"primitive\":\"string\"}")]
        string AccountKeyPem
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/vancluever/acme/2.48.0/docs/resources/certificate#certificate_p12_password Certificate#certificate_p12_password}.</summary>
        [JsiiProperty(name: "certificateP12Password", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? CertificateP12Password
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/vancluever/acme/2.48.0/docs/resources/certificate#certificate_request_pem Certificate#certificate_request_pem}.</summary>
        [JsiiProperty(name: "certificateRequestPem", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? CertificateRequestPem
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/vancluever/acme/2.48.0/docs/resources/certificate#cert_timeout Certificate#cert_timeout}.</summary>
        [JsiiProperty(name: "certTimeout", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? CertTimeout
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/vancluever/acme/2.48.0/docs/resources/certificate#common_name Certificate#common_name}.</summary>
        [JsiiProperty(name: "commonName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? CommonName
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/vancluever/acme/2.48.0/docs/resources/certificate#deactivate_authorizations Certificate#deactivate_authorizations}.</summary>
        [JsiiProperty(name: "deactivateAuthorizations", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? DeactivateAuthorizations
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/vancluever/acme/2.48.0/docs/resources/certificate#disable_complete_propagation Certificate#disable_complete_propagation}.</summary>
        [JsiiProperty(name: "disableCompletePropagation", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? DisableCompletePropagation
        {
            get
            {
                return null;
            }
        }

        /// <summary>dns_challenge block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/vancluever/acme/2.48.0/docs/resources/certificate#dns_challenge Certificate#dns_challenge}
        /// </remarks>
        [JsiiProperty(name: "dnsChallenge", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"acme.certificate.CertificateDnsChallenge\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? DnsChallenge
        {
            get
            {
                return null;
            }
        }

        /// <summary>http_challenge block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/vancluever/acme/2.48.0/docs/resources/certificate#http_challenge Certificate#http_challenge}
        /// </remarks>
        [JsiiProperty(name: "httpChallenge", typeJson: "{\"fqn\":\"acme.certificate.CertificateHttpChallenge\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        acme.Certificate.ICertificateHttpChallenge? HttpChallenge
        {
            get
            {
                return null;
            }
        }

        /// <summary>http_memcached_challenge block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/vancluever/acme/2.48.0/docs/resources/certificate#http_memcached_challenge Certificate#http_memcached_challenge}
        /// </remarks>
        [JsiiProperty(name: "httpMemcachedChallenge", typeJson: "{\"fqn\":\"acme.certificate.CertificateHttpMemcachedChallenge\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        acme.Certificate.ICertificateHttpMemcachedChallenge? HttpMemcachedChallenge
        {
            get
            {
                return null;
            }
        }

        /// <summary>http_s3_challenge block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/vancluever/acme/2.48.0/docs/resources/certificate#http_s3_challenge Certificate#http_s3_challenge}
        /// </remarks>
        [JsiiProperty(name: "httpS3Challenge", typeJson: "{\"fqn\":\"acme.certificate.CertificateHttpS3Challenge\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        acme.Certificate.ICertificateHttpS3Challenge? HttpS3Challenge
        {
            get
            {
                return null;
            }
        }

        /// <summary>http_webroot_challenge block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/vancluever/acme/2.48.0/docs/resources/certificate#http_webroot_challenge Certificate#http_webroot_challenge}
        /// </remarks>
        [JsiiProperty(name: "httpWebrootChallenge", typeJson: "{\"fqn\":\"acme.certificate.CertificateHttpWebrootChallenge\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        acme.Certificate.ICertificateHttpWebrootChallenge? HttpWebrootChallenge
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/vancluever/acme/2.48.0/docs/resources/certificate#id Certificate#id}.</summary>
        /// <remarks>
        /// Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2.
        /// If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </remarks>
        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Id
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/vancluever/acme/2.48.0/docs/resources/certificate#key_type Certificate#key_type}.</summary>
        [JsiiProperty(name: "keyType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? KeyType
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/vancluever/acme/2.48.0/docs/resources/certificate#min_days_dynamic Certificate#min_days_dynamic}.</summary>
        [JsiiProperty(name: "minDaysDynamic", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? MinDaysDynamic
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/vancluever/acme/2.48.0/docs/resources/certificate#min_days_remaining Certificate#min_days_remaining}.</summary>
        [JsiiProperty(name: "minDaysRemaining", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? MinDaysRemaining
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/vancluever/acme/2.48.0/docs/resources/certificate#must_staple Certificate#must_staple}.</summary>
        [JsiiProperty(name: "mustStaple", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? MustStaple
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/vancluever/acme/2.48.0/docs/resources/certificate#pre_check_delay Certificate#pre_check_delay}.</summary>
        [JsiiProperty(name: "preCheckDelay", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? PreCheckDelay
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/vancluever/acme/2.48.0/docs/resources/certificate#preferred_chain Certificate#preferred_chain}.</summary>
        [JsiiProperty(name: "preferredChain", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? PreferredChain
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/vancluever/acme/2.48.0/docs/resources/certificate#profile Certificate#profile}.</summary>
        [JsiiProperty(name: "profile", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Profile
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/vancluever/acme/2.48.0/docs/resources/certificate#propagation_wait Certificate#propagation_wait}.</summary>
        [JsiiProperty(name: "propagationWait", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? PropagationWait
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/vancluever/acme/2.48.0/docs/resources/certificate#recursive_nameservers Certificate#recursive_nameservers}.</summary>
        [JsiiProperty(name: "recursiveNameservers", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? RecursiveNameservers
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/vancluever/acme/2.48.0/docs/resources/certificate#renewal_info_ignore_retry_after Certificate#renewal_info_ignore_retry_after}.</summary>
        [JsiiProperty(name: "renewalInfoIgnoreRetryAfter", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? RenewalInfoIgnoreRetryAfter
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/vancluever/acme/2.48.0/docs/resources/certificate#renewal_info_max_sleep Certificate#renewal_info_max_sleep}.</summary>
        [JsiiProperty(name: "renewalInfoMaxSleep", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? RenewalInfoMaxSleep
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/vancluever/acme/2.48.0/docs/resources/certificate#revoke_certificate_on_destroy Certificate#revoke_certificate_on_destroy}.</summary>
        [JsiiProperty(name: "revokeCertificateOnDestroy", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? RevokeCertificateOnDestroy
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/vancluever/acme/2.48.0/docs/resources/certificate#revoke_certificate_reason Certificate#revoke_certificate_reason}.</summary>
        [JsiiProperty(name: "revokeCertificateReason", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? RevokeCertificateReason
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/vancluever/acme/2.48.0/docs/resources/certificate#subject_alternative_names Certificate#subject_alternative_names}.</summary>
        [JsiiProperty(name: "subjectAlternativeNames", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? SubjectAlternativeNames
        {
            get
            {
                return null;
            }
        }

        /// <summary>tls_challenge block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/vancluever/acme/2.48.0/docs/resources/certificate#tls_challenge Certificate#tls_challenge}
        /// </remarks>
        [JsiiProperty(name: "tlsChallenge", typeJson: "{\"fqn\":\"acme.certificate.CertificateTlsChallenge\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        acme.Certificate.ICertificateTlsChallenge? TlsChallenge
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/vancluever/acme/2.48.0/docs/resources/certificate#use_renewal_info Certificate#use_renewal_info}.</summary>
        [JsiiProperty(name: "useRenewalInfo", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? UseRenewalInfo
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/vancluever/acme/2.48.0/docs/resources/certificate#validity_days Certificate#validity_days}.</summary>
        [JsiiProperty(name: "validityDays", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? ValidityDays
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ICertificateConfig), fullyQualifiedName: "acme.certificate.CertificateConfig")]
        internal sealed class _Proxy : DeputyBase, acme.Certificate.ICertificateConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/vancluever/acme/2.48.0/docs/resources/certificate#account_key_pem Certificate#account_key_pem}.</summary>
            [JsiiProperty(name: "accountKeyPem", typeJson: "{\"primitive\":\"string\"}")]
            public string AccountKeyPem
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/vancluever/acme/2.48.0/docs/resources/certificate#certificate_p12_password Certificate#certificate_p12_password}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "certificateP12Password", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? CertificateP12Password
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/vancluever/acme/2.48.0/docs/resources/certificate#certificate_request_pem Certificate#certificate_request_pem}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "certificateRequestPem", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? CertificateRequestPem
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/vancluever/acme/2.48.0/docs/resources/certificate#cert_timeout Certificate#cert_timeout}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "certTimeout", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? CertTimeout
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/vancluever/acme/2.48.0/docs/resources/certificate#common_name Certificate#common_name}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "commonName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? CommonName
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/vancluever/acme/2.48.0/docs/resources/certificate#deactivate_authorizations Certificate#deactivate_authorizations}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "deactivateAuthorizations", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? DeactivateAuthorizations
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/vancluever/acme/2.48.0/docs/resources/certificate#disable_complete_propagation Certificate#disable_complete_propagation}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "disableCompletePropagation", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? DisableCompletePropagation
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>dns_challenge block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/vancluever/acme/2.48.0/docs/resources/certificate#dns_challenge Certificate#dns_challenge}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "dnsChallenge", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"acme.certificate.CertificateDnsChallenge\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? DnsChallenge
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>http_challenge block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/vancluever/acme/2.48.0/docs/resources/certificate#http_challenge Certificate#http_challenge}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "httpChallenge", typeJson: "{\"fqn\":\"acme.certificate.CertificateHttpChallenge\"}", isOptional: true)]
            public acme.Certificate.ICertificateHttpChallenge? HttpChallenge
            {
                get => GetInstanceProperty<acme.Certificate.ICertificateHttpChallenge?>();
            }

            /// <summary>http_memcached_challenge block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/vancluever/acme/2.48.0/docs/resources/certificate#http_memcached_challenge Certificate#http_memcached_challenge}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "httpMemcachedChallenge", typeJson: "{\"fqn\":\"acme.certificate.CertificateHttpMemcachedChallenge\"}", isOptional: true)]
            public acme.Certificate.ICertificateHttpMemcachedChallenge? HttpMemcachedChallenge
            {
                get => GetInstanceProperty<acme.Certificate.ICertificateHttpMemcachedChallenge?>();
            }

            /// <summary>http_s3_challenge block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/vancluever/acme/2.48.0/docs/resources/certificate#http_s3_challenge Certificate#http_s3_challenge}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "httpS3Challenge", typeJson: "{\"fqn\":\"acme.certificate.CertificateHttpS3Challenge\"}", isOptional: true)]
            public acme.Certificate.ICertificateHttpS3Challenge? HttpS3Challenge
            {
                get => GetInstanceProperty<acme.Certificate.ICertificateHttpS3Challenge?>();
            }

            /// <summary>http_webroot_challenge block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/vancluever/acme/2.48.0/docs/resources/certificate#http_webroot_challenge Certificate#http_webroot_challenge}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "httpWebrootChallenge", typeJson: "{\"fqn\":\"acme.certificate.CertificateHttpWebrootChallenge\"}", isOptional: true)]
            public acme.Certificate.ICertificateHttpWebrootChallenge? HttpWebrootChallenge
            {
                get => GetInstanceProperty<acme.Certificate.ICertificateHttpWebrootChallenge?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/vancluever/acme/2.48.0/docs/resources/certificate#id Certificate#id}.</summary>
            /// <remarks>
            /// Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2.
            /// If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Id
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/vancluever/acme/2.48.0/docs/resources/certificate#key_type Certificate#key_type}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "keyType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? KeyType
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/vancluever/acme/2.48.0/docs/resources/certificate#min_days_dynamic Certificate#min_days_dynamic}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "minDaysDynamic", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? MinDaysDynamic
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/vancluever/acme/2.48.0/docs/resources/certificate#min_days_remaining Certificate#min_days_remaining}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "minDaysRemaining", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? MinDaysRemaining
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/vancluever/acme/2.48.0/docs/resources/certificate#must_staple Certificate#must_staple}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "mustStaple", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? MustStaple
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/vancluever/acme/2.48.0/docs/resources/certificate#pre_check_delay Certificate#pre_check_delay}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "preCheckDelay", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? PreCheckDelay
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/vancluever/acme/2.48.0/docs/resources/certificate#preferred_chain Certificate#preferred_chain}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "preferredChain", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? PreferredChain
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/vancluever/acme/2.48.0/docs/resources/certificate#profile Certificate#profile}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "profile", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Profile
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/vancluever/acme/2.48.0/docs/resources/certificate#propagation_wait Certificate#propagation_wait}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "propagationWait", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? PropagationWait
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/vancluever/acme/2.48.0/docs/resources/certificate#recursive_nameservers Certificate#recursive_nameservers}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "recursiveNameservers", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? RecursiveNameservers
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/vancluever/acme/2.48.0/docs/resources/certificate#renewal_info_ignore_retry_after Certificate#renewal_info_ignore_retry_after}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "renewalInfoIgnoreRetryAfter", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? RenewalInfoIgnoreRetryAfter
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/vancluever/acme/2.48.0/docs/resources/certificate#renewal_info_max_sleep Certificate#renewal_info_max_sleep}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "renewalInfoMaxSleep", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? RenewalInfoMaxSleep
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/vancluever/acme/2.48.0/docs/resources/certificate#revoke_certificate_on_destroy Certificate#revoke_certificate_on_destroy}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "revokeCertificateOnDestroy", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? RevokeCertificateOnDestroy
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/vancluever/acme/2.48.0/docs/resources/certificate#revoke_certificate_reason Certificate#revoke_certificate_reason}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "revokeCertificateReason", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? RevokeCertificateReason
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/vancluever/acme/2.48.0/docs/resources/certificate#subject_alternative_names Certificate#subject_alternative_names}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "subjectAlternativeNames", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? SubjectAlternativeNames
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>tls_challenge block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/vancluever/acme/2.48.0/docs/resources/certificate#tls_challenge Certificate#tls_challenge}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "tlsChallenge", typeJson: "{\"fqn\":\"acme.certificate.CertificateTlsChallenge\"}", isOptional: true)]
            public acme.Certificate.ICertificateTlsChallenge? TlsChallenge
            {
                get => GetInstanceProperty<acme.Certificate.ICertificateTlsChallenge?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/vancluever/acme/2.48.0/docs/resources/certificate#use_renewal_info Certificate#use_renewal_info}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "useRenewalInfo", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? UseRenewalInfo
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/vancluever/acme/2.48.0/docs/resources/certificate#validity_days Certificate#validity_days}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "validityDays", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? ValidityDays
            {
                get => GetInstanceProperty<double?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "connection", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.SSHProvisionerConnection\"},{\"fqn\":\"cdktn.WinrmProvisionerConnection\"}]}}", isOptional: true)]
            public object? Connection
            {
                get => GetInstanceProperty<object?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "count", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"number\"},{\"fqn\":\"cdktn.TerraformCount\"}]}}", isOptional: true)]
            public object? Count
            {
                get => GetInstanceProperty<object?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "dependsOn", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"cdktn.ITerraformDependable\"},\"kind\":\"array\"}}", isOptional: true)]
            public Io.Cdktn.ITerraformDependable[]? DependsOn
            {
                get => GetInstanceProperty<Io.Cdktn.ITerraformDependable[]?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "forEach", typeJson: "{\"fqn\":\"cdktn.ITerraformIterator\"}", isOptional: true)]
            public Io.Cdktn.ITerraformIterator? ForEach
            {
                get => GetInstanceProperty<Io.Cdktn.ITerraformIterator?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "lifecycle", typeJson: "{\"fqn\":\"cdktn.TerraformResourceLifecycle\"}", isOptional: true)]
            public Io.Cdktn.ITerraformResourceLifecycle? Lifecycle
            {
                get => GetInstanceProperty<Io.Cdktn.ITerraformResourceLifecycle?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "provider", typeJson: "{\"fqn\":\"cdktn.TerraformProvider\"}", isOptional: true)]
            public Io.Cdktn.TerraformProvider? Provider
            {
                get => GetInstanceProperty<Io.Cdktn.TerraformProvider?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "provisioners", typeJson: "{\"collection\":{\"elementtype\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.FileProvisioner\"},{\"fqn\":\"cdktn.LocalExecProvisioner\"},{\"fqn\":\"cdktn.RemoteExecProvisioner\"}]}},\"kind\":\"array\"}}", isOptional: true)]
            public object[]? Provisioners
            {
                get => GetInstanceProperty<object[]?>();
            }
        }
    }
}

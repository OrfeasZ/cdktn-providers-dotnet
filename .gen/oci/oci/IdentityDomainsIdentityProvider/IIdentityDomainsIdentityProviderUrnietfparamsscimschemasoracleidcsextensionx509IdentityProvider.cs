using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.IdentityDomainsIdentityProvider
{
    [JsiiInterface(nativeType: typeof(IIdentityDomainsIdentityProviderUrnietfparamsscimschemasoracleidcsextensionx509IdentityProvider), fullyQualifiedName: "oci.identityDomainsIdentityProvider.IdentityDomainsIdentityProviderUrnietfparamsscimschemasoracleidcsextensionx509IdentityProvider")]
    public interface IIdentityDomainsIdentityProviderUrnietfparamsscimschemasoracleidcsextensionx509IdentityProvider
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_identity_provider#cert_match_attribute IdentityDomainsIdentityProvider#cert_match_attribute}.</summary>
        [JsiiProperty(name: "certMatchAttribute", typeJson: "{\"primitive\":\"string\"}")]
        string CertMatchAttribute
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_identity_provider#signing_certificate_chain IdentityDomainsIdentityProvider#signing_certificate_chain}.</summary>
        [JsiiProperty(name: "signingCertificateChain", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        string[] SigningCertificateChain
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_identity_provider#user_match_attribute IdentityDomainsIdentityProvider#user_match_attribute}.</summary>
        [JsiiProperty(name: "userMatchAttribute", typeJson: "{\"primitive\":\"string\"}")]
        string UserMatchAttribute
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_identity_provider#crl_check_on_ocsp_failure_enabled IdentityDomainsIdentityProvider#crl_check_on_ocsp_failure_enabled}.</summary>
        [JsiiProperty(name: "crlCheckOnOcspFailureEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? CrlCheckOnOcspFailureEnabled
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_identity_provider#crl_enabled IdentityDomainsIdentityProvider#crl_enabled}.</summary>
        [JsiiProperty(name: "crlEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? CrlEnabled
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_identity_provider#crl_location IdentityDomainsIdentityProvider#crl_location}.</summary>
        [JsiiProperty(name: "crlLocation", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? CrlLocation
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_identity_provider#crl_reload_duration IdentityDomainsIdentityProvider#crl_reload_duration}.</summary>
        [JsiiProperty(name: "crlReloadDuration", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? CrlReloadDuration
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_identity_provider#eku_validation_enabled IdentityDomainsIdentityProvider#eku_validation_enabled}.</summary>
        [JsiiProperty(name: "ekuValidationEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? EkuValidationEnabled
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_identity_provider#eku_values IdentityDomainsIdentityProvider#eku_values}.</summary>
        [JsiiProperty(name: "ekuValues", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? EkuValues
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_identity_provider#ocsp_allow_unknown_response_status IdentityDomainsIdentityProvider#ocsp_allow_unknown_response_status}.</summary>
        [JsiiProperty(name: "ocspAllowUnknownResponseStatus", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? OcspAllowUnknownResponseStatus
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_identity_provider#ocsp_enabled IdentityDomainsIdentityProvider#ocsp_enabled}.</summary>
        [JsiiProperty(name: "ocspEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? OcspEnabled
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_identity_provider#ocsp_enable_signed_response IdentityDomainsIdentityProvider#ocsp_enable_signed_response}.</summary>
        [JsiiProperty(name: "ocspEnableSignedResponse", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? OcspEnableSignedResponse
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_identity_provider#ocsp_responder_url IdentityDomainsIdentityProvider#ocsp_responder_url}.</summary>
        [JsiiProperty(name: "ocspResponderUrl", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? OcspResponderUrl
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_identity_provider#ocsp_revalidate_time IdentityDomainsIdentityProvider#ocsp_revalidate_time}.</summary>
        [JsiiProperty(name: "ocspRevalidateTime", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? OcspRevalidateTime
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_identity_provider#ocsp_server_name IdentityDomainsIdentityProvider#ocsp_server_name}.</summary>
        [JsiiProperty(name: "ocspServerName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? OcspServerName
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_identity_provider#ocsp_trust_cert_chain IdentityDomainsIdentityProvider#ocsp_trust_cert_chain}.</summary>
        [JsiiProperty(name: "ocspTrustCertChain", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? OcspTrustCertChain
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_identity_provider#other_cert_match_attribute IdentityDomainsIdentityProvider#other_cert_match_attribute}.</summary>
        [JsiiProperty(name: "otherCertMatchAttribute", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? OtherCertMatchAttribute
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IIdentityDomainsIdentityProviderUrnietfparamsscimschemasoracleidcsextensionx509IdentityProvider), fullyQualifiedName: "oci.identityDomainsIdentityProvider.IdentityDomainsIdentityProviderUrnietfparamsscimschemasoracleidcsextensionx509IdentityProvider")]
        internal sealed class _Proxy : DeputyBase, oci.IdentityDomainsIdentityProvider.IIdentityDomainsIdentityProviderUrnietfparamsscimschemasoracleidcsextensionx509IdentityProvider
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_identity_provider#cert_match_attribute IdentityDomainsIdentityProvider#cert_match_attribute}.</summary>
            [JsiiProperty(name: "certMatchAttribute", typeJson: "{\"primitive\":\"string\"}")]
            public string CertMatchAttribute
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_identity_provider#signing_certificate_chain IdentityDomainsIdentityProvider#signing_certificate_chain}.</summary>
            [JsiiProperty(name: "signingCertificateChain", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
            public string[] SigningCertificateChain
            {
                get => GetInstanceProperty<string[]>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_identity_provider#user_match_attribute IdentityDomainsIdentityProvider#user_match_attribute}.</summary>
            [JsiiProperty(name: "userMatchAttribute", typeJson: "{\"primitive\":\"string\"}")]
            public string UserMatchAttribute
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_identity_provider#crl_check_on_ocsp_failure_enabled IdentityDomainsIdentityProvider#crl_check_on_ocsp_failure_enabled}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "crlCheckOnOcspFailureEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? CrlCheckOnOcspFailureEnabled
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_identity_provider#crl_enabled IdentityDomainsIdentityProvider#crl_enabled}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "crlEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? CrlEnabled
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_identity_provider#crl_location IdentityDomainsIdentityProvider#crl_location}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "crlLocation", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? CrlLocation
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_identity_provider#crl_reload_duration IdentityDomainsIdentityProvider#crl_reload_duration}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "crlReloadDuration", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? CrlReloadDuration
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_identity_provider#eku_validation_enabled IdentityDomainsIdentityProvider#eku_validation_enabled}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "ekuValidationEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? EkuValidationEnabled
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_identity_provider#eku_values IdentityDomainsIdentityProvider#eku_values}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "ekuValues", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? EkuValues
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_identity_provider#ocsp_allow_unknown_response_status IdentityDomainsIdentityProvider#ocsp_allow_unknown_response_status}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "ocspAllowUnknownResponseStatus", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? OcspAllowUnknownResponseStatus
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_identity_provider#ocsp_enabled IdentityDomainsIdentityProvider#ocsp_enabled}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "ocspEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? OcspEnabled
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_identity_provider#ocsp_enable_signed_response IdentityDomainsIdentityProvider#ocsp_enable_signed_response}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "ocspEnableSignedResponse", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? OcspEnableSignedResponse
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_identity_provider#ocsp_responder_url IdentityDomainsIdentityProvider#ocsp_responder_url}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "ocspResponderUrl", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? OcspResponderUrl
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_identity_provider#ocsp_revalidate_time IdentityDomainsIdentityProvider#ocsp_revalidate_time}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "ocspRevalidateTime", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? OcspRevalidateTime
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_identity_provider#ocsp_server_name IdentityDomainsIdentityProvider#ocsp_server_name}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "ocspServerName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? OcspServerName
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_identity_provider#ocsp_trust_cert_chain IdentityDomainsIdentityProvider#ocsp_trust_cert_chain}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "ocspTrustCertChain", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? OcspTrustCertChain
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_identity_provider#other_cert_match_attribute IdentityDomainsIdentityProvider#other_cert_match_attribute}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "otherCertMatchAttribute", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? OtherCertMatchAttribute
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}

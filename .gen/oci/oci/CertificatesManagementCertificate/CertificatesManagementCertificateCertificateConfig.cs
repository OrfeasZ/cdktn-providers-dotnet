using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.CertificatesManagementCertificate
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.certificatesManagementCertificate.CertificatesManagementCertificateCertificateConfig")]
    public class CertificatesManagementCertificateCertificateConfig : oci.CertificatesManagementCertificate.ICertificatesManagementCertificateCertificateConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/certificates_management_certificate#config_type CertificatesManagementCertificate#config_type}.</summary>
        [JsiiProperty(name: "configType", typeJson: "{\"primitive\":\"string\"}")]
        public string ConfigType
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/certificates_management_certificate#certificate_profile_type CertificatesManagementCertificate#certificate_profile_type}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "certificateProfileType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? CertificateProfileType
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/certificates_management_certificate#csr_pem CertificatesManagementCertificate#csr_pem}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "csrPem", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? CsrPem
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/certificates_management_certificate#issuer_certificate_authority_id CertificatesManagementCertificate#issuer_certificate_authority_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "issuerCertificateAuthorityId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? IssuerCertificateAuthorityId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/certificates_management_certificate#key_algorithm CertificatesManagementCertificate#key_algorithm}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "keyAlgorithm", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? KeyAlgorithm
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/certificates_management_certificate#signature_algorithm CertificatesManagementCertificate#signature_algorithm}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "signatureAlgorithm", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? SignatureAlgorithm
        {
            get;
            set;
        }

        /// <summary>subject block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/certificates_management_certificate#subject CertificatesManagementCertificate#subject}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "subject", typeJson: "{\"fqn\":\"oci.certificatesManagementCertificate.CertificatesManagementCertificateCertificateConfigSubject\"}", isOptional: true)]
        public oci.CertificatesManagementCertificate.ICertificatesManagementCertificateCertificateConfigSubject? Subject
        {
            get;
            set;
        }

        private object? _subjectAlternativeNames;

        /// <summary>subject_alternative_names block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/certificates_management_certificate#subject_alternative_names CertificatesManagementCertificate#subject_alternative_names}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "subjectAlternativeNames", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.certificatesManagementCertificate.CertificatesManagementCertificateCertificateConfigSubjectAlternativeNames\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? SubjectAlternativeNames
        {
            get => _subjectAlternativeNames;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case oci.CertificatesManagementCertificate.ICertificatesManagementCertificateCertificateConfigSubjectAlternativeNames[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.CertificatesManagementCertificate.ICertificatesManagementCertificateCertificateConfigSubjectAlternativeNames).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _subjectAlternativeNames = value;
            }
        }

        /// <summary>validity block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/certificates_management_certificate#validity CertificatesManagementCertificate#validity}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "validity", typeJson: "{\"fqn\":\"oci.certificatesManagementCertificate.CertificatesManagementCertificateCertificateConfigValidity\"}", isOptional: true)]
        public oci.CertificatesManagementCertificate.ICertificatesManagementCertificateCertificateConfigValidity? Validity
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/certificates_management_certificate#version_name CertificatesManagementCertificate#version_name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "versionName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? VersionName
        {
            get;
            set;
        }
    }
}

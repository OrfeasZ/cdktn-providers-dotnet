using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.CertificatesManagementCertificateAuthority
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.certificatesManagementCertificateAuthority.CertificatesManagementCertificateAuthorityCertificateAuthorityConfig")]
    public class CertificatesManagementCertificateAuthorityCertificateAuthorityConfig : oci.CertificatesManagementCertificateAuthority.ICertificatesManagementCertificateAuthorityCertificateAuthorityConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/certificates_management_certificate_authority#config_type CertificatesManagementCertificateAuthority#config_type}.</summary>
        [JsiiProperty(name: "configType", typeJson: "{\"primitive\":\"string\"}")]
        public string ConfigType
        {
            get;
            set;
        }

        /// <summary>subject block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/certificates_management_certificate_authority#subject CertificatesManagementCertificateAuthority#subject}
        /// </remarks>
        [JsiiProperty(name: "subject", typeJson: "{\"fqn\":\"oci.certificatesManagementCertificateAuthority.CertificatesManagementCertificateAuthorityCertificateAuthorityConfigSubject\"}")]
        public oci.CertificatesManagementCertificateAuthority.ICertificatesManagementCertificateAuthorityCertificateAuthorityConfigSubject Subject
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/certificates_management_certificate_authority#issuer_certificate_authority_id CertificatesManagementCertificateAuthority#issuer_certificate_authority_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "issuerCertificateAuthorityId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? IssuerCertificateAuthorityId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/certificates_management_certificate_authority#signing_algorithm CertificatesManagementCertificateAuthority#signing_algorithm}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "signingAlgorithm", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? SigningAlgorithm
        {
            get;
            set;
        }

        /// <summary>validity block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/certificates_management_certificate_authority#validity CertificatesManagementCertificateAuthority#validity}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "validity", typeJson: "{\"fqn\":\"oci.certificatesManagementCertificateAuthority.CertificatesManagementCertificateAuthorityCertificateAuthorityConfigValidity\"}", isOptional: true)]
        public oci.CertificatesManagementCertificateAuthority.ICertificatesManagementCertificateAuthorityCertificateAuthorityConfigValidity? Validity
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/certificates_management_certificate_authority#version_name CertificatesManagementCertificateAuthority#version_name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "versionName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? VersionName
        {
            get;
            set;
        }
    }
}

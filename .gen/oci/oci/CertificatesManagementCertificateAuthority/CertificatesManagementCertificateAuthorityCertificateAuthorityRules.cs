using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.CertificatesManagementCertificateAuthority
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.certificatesManagementCertificateAuthority.CertificatesManagementCertificateAuthorityCertificateAuthorityRules")]
    public class CertificatesManagementCertificateAuthorityCertificateAuthorityRules : oci.CertificatesManagementCertificateAuthority.ICertificatesManagementCertificateAuthorityCertificateAuthorityRules
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/certificates_management_certificate_authority#rule_type CertificatesManagementCertificateAuthority#rule_type}.</summary>
        [JsiiProperty(name: "ruleType", typeJson: "{\"primitive\":\"string\"}")]
        public string RuleType
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/certificates_management_certificate_authority#certificate_authority_max_validity_duration CertificatesManagementCertificateAuthority#certificate_authority_max_validity_duration}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "certificateAuthorityMaxValidityDuration", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? CertificateAuthorityMaxValidityDuration
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/certificates_management_certificate_authority#leaf_certificate_max_validity_duration CertificatesManagementCertificateAuthority#leaf_certificate_max_validity_duration}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "leafCertificateMaxValidityDuration", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? LeafCertificateMaxValidityDuration
        {
            get;
            set;
        }
    }
}

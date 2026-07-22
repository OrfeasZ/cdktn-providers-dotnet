using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.CertificatesManagementCertificateAuthority
{
    [JsiiByValue(fqn: "oci.certificatesManagementCertificateAuthority.CertificatesManagementCertificateAuthorityCertificateAuthorityConfigActionDetails")]
    public class CertificatesManagementCertificateAuthorityCertificateAuthorityConfigActionDetails : oci.CertificatesManagementCertificateAuthority.ICertificatesManagementCertificateAuthorityCertificateAuthorityConfigActionDetails
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.24.0/docs/resources/certificates_management_certificate_authority#action_type CertificatesManagementCertificateAuthority#action_type}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "actionType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ActionType
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.24.0/docs/resources/certificates_management_certificate_authority#certificate_pem CertificatesManagementCertificateAuthority#certificate_pem}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "certificatePem", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? CertificatePem
        {
            get;
            set;
        }
    }
}

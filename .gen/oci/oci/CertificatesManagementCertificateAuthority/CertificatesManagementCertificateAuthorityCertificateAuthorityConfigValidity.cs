using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.CertificatesManagementCertificateAuthority
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.certificatesManagementCertificateAuthority.CertificatesManagementCertificateAuthorityCertificateAuthorityConfigValidity")]
    public class CertificatesManagementCertificateAuthorityCertificateAuthorityConfigValidity : oci.CertificatesManagementCertificateAuthority.ICertificatesManagementCertificateAuthorityCertificateAuthorityConfigValidity
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/certificates_management_certificate_authority#time_of_validity_not_after CertificatesManagementCertificateAuthority#time_of_validity_not_after}.</summary>
        [JsiiProperty(name: "timeOfValidityNotAfter", typeJson: "{\"primitive\":\"string\"}")]
        public string TimeOfValidityNotAfter
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/certificates_management_certificate_authority#time_of_validity_not_before CertificatesManagementCertificateAuthority#time_of_validity_not_before}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "timeOfValidityNotBefore", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? TimeOfValidityNotBefore
        {
            get;
            set;
        }
    }
}

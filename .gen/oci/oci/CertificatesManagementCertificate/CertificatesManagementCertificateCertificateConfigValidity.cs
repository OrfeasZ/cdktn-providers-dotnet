using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.CertificatesManagementCertificate
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.certificatesManagementCertificate.CertificatesManagementCertificateCertificateConfigValidity")]
    public class CertificatesManagementCertificateCertificateConfigValidity : oci.CertificatesManagementCertificate.ICertificatesManagementCertificateCertificateConfigValidity
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/certificates_management_certificate#time_of_validity_not_after CertificatesManagementCertificate#time_of_validity_not_after}.</summary>
        [JsiiProperty(name: "timeOfValidityNotAfter", typeJson: "{\"primitive\":\"string\"}")]
        public string TimeOfValidityNotAfter
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/certificates_management_certificate#time_of_validity_not_before CertificatesManagementCertificate#time_of_validity_not_before}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "timeOfValidityNotBefore", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? TimeOfValidityNotBefore
        {
            get;
            set;
        }
    }
}

using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.CertificatesManagementCertificateAuthority
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.certificatesManagementCertificateAuthority.CertificatesManagementCertificateAuthorityCertificateRevocationListDetails")]
    public class CertificatesManagementCertificateAuthorityCertificateRevocationListDetails : oci.CertificatesManagementCertificateAuthority.ICertificatesManagementCertificateAuthorityCertificateRevocationListDetails
    {
        /// <summary>object_storage_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/certificates_management_certificate_authority#object_storage_config CertificatesManagementCertificateAuthority#object_storage_config}
        /// </remarks>
        [JsiiProperty(name: "objectStorageConfig", typeJson: "{\"fqn\":\"oci.certificatesManagementCertificateAuthority.CertificatesManagementCertificateAuthorityCertificateRevocationListDetailsObjectStorageConfig\"}")]
        public oci.CertificatesManagementCertificateAuthority.ICertificatesManagementCertificateAuthorityCertificateRevocationListDetailsObjectStorageConfig ObjectStorageConfig
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/certificates_management_certificate_authority#custom_formatted_urls CertificatesManagementCertificateAuthority#custom_formatted_urls}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "customFormattedUrls", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? CustomFormattedUrls
        {
            get;
            set;
        }
    }
}

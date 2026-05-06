using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.CertificatesManagementCertificateAuthority
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.certificatesManagementCertificateAuthority.CertificatesManagementCertificateAuthorityCertificateRevocationListDetailsObjectStorageConfig")]
    public class CertificatesManagementCertificateAuthorityCertificateRevocationListDetailsObjectStorageConfig : oci.CertificatesManagementCertificateAuthority.ICertificatesManagementCertificateAuthorityCertificateRevocationListDetailsObjectStorageConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/certificates_management_certificate_authority#object_storage_bucket_name CertificatesManagementCertificateAuthority#object_storage_bucket_name}.</summary>
        [JsiiProperty(name: "objectStorageBucketName", typeJson: "{\"primitive\":\"string\"}")]
        public string ObjectStorageBucketName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/certificates_management_certificate_authority#object_storage_object_name_format CertificatesManagementCertificateAuthority#object_storage_object_name_format}.</summary>
        [JsiiProperty(name: "objectStorageObjectNameFormat", typeJson: "{\"primitive\":\"string\"}")]
        public string ObjectStorageObjectNameFormat
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/certificates_management_certificate_authority#object_storage_namespace CertificatesManagementCertificateAuthority#object_storage_namespace}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "objectStorageNamespace", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ObjectStorageNamespace
        {
            get;
            set;
        }
    }
}

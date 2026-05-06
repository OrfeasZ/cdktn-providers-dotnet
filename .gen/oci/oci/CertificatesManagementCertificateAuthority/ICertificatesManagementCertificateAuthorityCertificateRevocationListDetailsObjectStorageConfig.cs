using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.CertificatesManagementCertificateAuthority
{
    [JsiiInterface(nativeType: typeof(ICertificatesManagementCertificateAuthorityCertificateRevocationListDetailsObjectStorageConfig), fullyQualifiedName: "oci.certificatesManagementCertificateAuthority.CertificatesManagementCertificateAuthorityCertificateRevocationListDetailsObjectStorageConfig")]
    public interface ICertificatesManagementCertificateAuthorityCertificateRevocationListDetailsObjectStorageConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/certificates_management_certificate_authority#object_storage_bucket_name CertificatesManagementCertificateAuthority#object_storage_bucket_name}.</summary>
        [JsiiProperty(name: "objectStorageBucketName", typeJson: "{\"primitive\":\"string\"}")]
        string ObjectStorageBucketName
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/certificates_management_certificate_authority#object_storage_object_name_format CertificatesManagementCertificateAuthority#object_storage_object_name_format}.</summary>
        [JsiiProperty(name: "objectStorageObjectNameFormat", typeJson: "{\"primitive\":\"string\"}")]
        string ObjectStorageObjectNameFormat
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/certificates_management_certificate_authority#object_storage_namespace CertificatesManagementCertificateAuthority#object_storage_namespace}.</summary>
        [JsiiProperty(name: "objectStorageNamespace", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ObjectStorageNamespace
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ICertificatesManagementCertificateAuthorityCertificateRevocationListDetailsObjectStorageConfig), fullyQualifiedName: "oci.certificatesManagementCertificateAuthority.CertificatesManagementCertificateAuthorityCertificateRevocationListDetailsObjectStorageConfig")]
        internal sealed class _Proxy : DeputyBase, oci.CertificatesManagementCertificateAuthority.ICertificatesManagementCertificateAuthorityCertificateRevocationListDetailsObjectStorageConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/certificates_management_certificate_authority#object_storage_bucket_name CertificatesManagementCertificateAuthority#object_storage_bucket_name}.</summary>
            [JsiiProperty(name: "objectStorageBucketName", typeJson: "{\"primitive\":\"string\"}")]
            public string ObjectStorageBucketName
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/certificates_management_certificate_authority#object_storage_object_name_format CertificatesManagementCertificateAuthority#object_storage_object_name_format}.</summary>
            [JsiiProperty(name: "objectStorageObjectNameFormat", typeJson: "{\"primitive\":\"string\"}")]
            public string ObjectStorageObjectNameFormat
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/certificates_management_certificate_authority#object_storage_namespace CertificatesManagementCertificateAuthority#object_storage_namespace}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "objectStorageNamespace", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ObjectStorageNamespace
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
